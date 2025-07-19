using System.Reflection;
using System.Text;
using Operations.Extensions.EventMarkdownGenerator.Models;

namespace Operations.Extensions.EventMarkdownGenerator.Services;

public class IndividualMarkdownGenerator
{
    public IndividualMarkdownOutput GenerateMarkdown(EventWithDocumentation eventWithDoc, string outputDirectory)
    {
        var metadata = eventWithDoc.Metadata;
        var documentation = eventWithDoc.Documentation;
        
        var fileName = metadata.GetKebabCaseFileName();
        var filePath = Path.Combine(outputDirectory, fileName);
        
        var content = GenerateMarkdownContent(metadata, documentation);
        
        return new IndividualMarkdownOutput
        {
            FileName = fileName,
            Content = content,
            FilePath = filePath
        };
    }

    public IEnumerable<IndividualMarkdownOutput> GenerateAllMarkdown(
        IEnumerable<EventWithDocumentation> events, 
        string outputDirectory)
    {
        return events.Select(eventWithDoc => GenerateMarkdown(eventWithDoc, outputDirectory));
    }

    private static string GenerateMarkdownContent(EventMetadata metadata, EventDocumentation documentation)
    {
        var sb = new StringBuilder();
        
        // Title
        sb.AppendLine($"# {metadata.EventName}");
        sb.AppendLine();

        // Add obsolete warning if applicable
        if (metadata.IsObsolete)
        {
            GenerateObsoleteWarning(sb, metadata.ObsoleteMessage);
        }

        // Status, Version, Topic, Type
        sb.AppendLine($"**Status:** {metadata.GetStatus()}");
        sb.AppendLine($"**Version:** {metadata.Version}");
        sb.AppendLine($"**Topic:** `{metadata.TopicName}`");
        sb.AppendLine($"**Type:** Integration Event");
        sb.AppendLine();

        // Description
        GenerateDescriptionSection(sb, documentation);

        // Structured remarks sections (like "When It's Triggered")
        GenerateStructuredRemarksSection(sb, documentation);

        // Event Payload table
        GenerateEventPayloadSection(sb, metadata);

        // Partition Keys section
        if (metadata.PartitionKeys.Any())
        {
            GeneratePartitionKeysSection(sb, metadata);
        }

        // Technical Details
        GenerateTechnicalDetailsSection(sb, metadata);

        return sb.ToString();
    }

    private static void GenerateObsoleteWarning(StringBuilder sb, string? obsoleteMessage)
    {
        sb.AppendLine("> [!CAUTION]");
        sb.AppendLine($"> This event is deprecated. {obsoleteMessage ?? "Use alternative event instead."}");
        sb.AppendLine();
    }

    private static void GenerateDescriptionSection(StringBuilder sb, EventDocumentation documentation)
    {
        sb.AppendLine("## Description");
        sb.AppendLine();
        sb.AppendLine(documentation.GetDescription());
        sb.AppendLine();
    }

    private static void GenerateStructuredRemarksSection(StringBuilder sb, EventDocumentation documentation)
    {
        foreach (var (sectionTitle, sectionContent) in documentation.StructuredRemarks)
        {
            sb.AppendLine($"## {sectionTitle}");
            sb.AppendLine();
            sb.AppendLine(sectionContent);
            sb.AppendLine();
        }
    }

    private static void GenerateEventPayloadSection(StringBuilder sb, EventMetadata metadata)
    {
        sb.AppendLine("## Event Payload");
        sb.AppendLine();
        sb.AppendLine("| Property | Type | Required | Description |");
        sb.AppendLine("| -------- | ---- | -------- | ----------- |");

        foreach (var property in metadata.Properties)
        {
            var propertyName = property.Name;
            var typeName = $"`{property.TypeName}`";
            var required = property.IsRequired ? "✓" : "";
            var description = GetPropertyDescription(property, metadata);

            sb.AppendLine($"| {propertyName} | {typeName} | {required} | {description} |");
        }

        sb.AppendLine();
    }

    private static string GetPropertyDescription(EventPropertyMetadata property, EventMetadata metadata)
    {
        var description = property.Description ?? "No description available";
        
        if (property.IsPartitionKey)
        {
            description += " (partition key)";
        }

        return description;
    }

    private static void GeneratePartitionKeysSection(StringBuilder sb, EventMetadata metadata)
    {
        sb.AppendLine("### Partition Keys");
        sb.AppendLine();
        
        if (metadata.PartitionKeys.Count == 1)
        {
            sb.AppendLine("This event uses a partition key for message routing:");
        }
        else
        {
            sb.AppendLine("This event uses multiple partition keys for message routing:");
        }
        sb.AppendLine();

        foreach (var partitionKey in metadata.PartitionKeys)
        {
            var description = GetPartitionKeyDescription(partitionKey, metadata.PartitionKeys);
            sb.AppendLine($"- `{partitionKey.Name}` - {description}");
        }

        sb.AppendLine();
    }

    private static void GenerateTechnicalDetailsSection(StringBuilder sb, EventMetadata metadata)
    {
        sb.AppendLine("## Technical Details");
        sb.AppendLine();

        // Generate code snippet
        GenerateCodeSnippet(sb, metadata);

        // Technical information
        sb.AppendLine($"- **Full Type:** `{metadata.FullTypeName}`");
        sb.AppendLine($"- **Namespace:** `{metadata.Namespace}`");
        sb.AppendLine($"- **Topic Attribute:** `{GetTopicAttributeDisplayName(metadata.TopicAttribute)}`");
        
        var payloadType = IsRecordType(metadata.EventType) ? "Record" : "Class";
        if (IsRecordType(metadata.EventType) && HasPositionalParameters(metadata.EventType))
        {
            payloadType += " with positional parameters";
        }
        sb.AppendLine($"- **Payload Type:** {payloadType}");
        
        if (metadata.PartitionKeys.Any())
        {
            var partitionKeyNames = string.Join(", ", metadata.PartitionKeys.Select(pk => pk.Name));
            sb.AppendLine($"- **Partition Keys:** {partitionKeyNames} (marked with `[PartitionKey]`)");
        }
        
        sb.AppendLine();
    }

    private static void GenerateCodeSnippet(StringBuilder sb, EventMetadata metadata)
    {
        sb.AppendLine("```csharp");
        sb.AppendLine("// Event Definition");
        
        // Generate the attribute line
        sb.AppendLine($"[{GetTopicAttributeDisplayName(metadata.TopicAttribute, false)}]");
        
        // Generate the class/record declaration
        var keyword = IsRecordType(metadata.EventType) ? "record" : "class";
        var constructor = metadata.EventType.GetConstructors().FirstOrDefault();
        
        if (IsRecordType(metadata.EventType) && constructor?.GetParameters().Length > 0)
        {
            // Record with positional parameters
            sb.Append($"public sealed {keyword} {metadata.EventName}(");
            
            var parameters = constructor.GetParameters();
            var paramLines = new List<string>();
            
            for (int i = 0; i < parameters.Length; i++)
            {
                var param = parameters[i];
                var paramAttrs = new List<string>();
                
                // Add PartitionKey attribute if present
                if (param.GetCustomAttribute<Operations.Extensions.Abstractions.Messaging.PartitionKeyAttribute>() != null)
                {
                    paramAttrs.Add("[PartitionKey]");
                }
                
                var attrString = paramAttrs.Any() ? string.Join(" ", paramAttrs) + " " : "";
                var typeName = GetFriendlyTypeName(param.ParameterType);
                var line = $"    {attrString}{typeName} {param.Name}";
                
                if (i < parameters.Length - 1)
                {
                    line += ",";
                }
                
                paramLines.Add(line);
            }
            
            if (paramLines.Count <= 3)
            {
                // Short parameter list - single line
                sb.AppendLine();
                foreach (var line in paramLines)
                {
                    sb.AppendLine(line);
                }
                sb.AppendLine($") : IntegrationEvent<{metadata.EventName}>;");
            }
            else
            {
                // Long parameter list - multiple lines
                sb.AppendLine();
                foreach (var line in paramLines)
                {
                    sb.AppendLine(line);
                }
                sb.AppendLine($") : IntegrationEvent<{metadata.EventName}>;");
            }
        }
        else
        {
            // Regular class with properties
            sb.AppendLine($"public sealed {keyword} {metadata.EventName} : IntegrationEvent<{metadata.EventName}>");
            sb.AppendLine("{");
            
            foreach (var property in metadata.Properties)
            {
                if (property.IsPartitionKey)
                {
                    sb.AppendLine("    [PartitionKey]");
                }
                sb.AppendLine($"    public {property.TypeName} {property.Name} {{ get; set; }}");
                sb.AppendLine();
            }
            
            sb.AppendLine("}");
        }
        
        sb.AppendLine("```");
        sb.AppendLine();
    }

    private static bool IsRecordType(Type type)
    {
        // Check if the type has a copy constructor typical of records
        return type.GetMethods().Any(m => m.Name == "<Clone>$") ||
               type.GetProperty("EqualityContract", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance) != null;
    }

    private static bool HasPositionalParameters(Type type)
    {
        var constructor = type.GetConstructors().FirstOrDefault();
        return constructor?.GetParameters().Length > 0;
    }

    private static string GetFriendlyTypeName(Type type)
    {
        if (type == typeof(string)) return "string";
        if (type == typeof(int)) return "int";
        if (type == typeof(long)) return "long";
        if (type == typeof(bool)) return "bool";
        if (type == typeof(decimal)) return "decimal";
        if (type == typeof(double)) return "double";
        if (type == typeof(float)) return "float";
        if (type == typeof(DateTime)) return "DateTime";
        if (type == typeof(DateTimeOffset)) return "DateTimeOffset";
        if (type == typeof(TimeSpan)) return "TimeSpan";
        if (type == typeof(Guid)) return "Guid";

        // Handle nullable types
        var underlyingType = Nullable.GetUnderlyingType(type);
        if (underlyingType != null)
        {
            return GetFriendlyTypeName(underlyingType) + "?";
        }

        // Handle generic types
        if (type.IsGenericType)
        {
            var genericTypeName = type.Name.Substring(0, type.Name.IndexOf('`'));
            var genericArgs = type.GetGenericArguments().Select(GetFriendlyTypeName);
            return $"{genericTypeName}<{string.Join(", ", genericArgs)}>";
        }

        return type.Name;
    }

    private static string GetTopicAttributeDisplayName(Attribute topicAttribute, bool includeBackticks = true)
    {
        var attrType = topicAttribute.GetType();
        var name = "EventTopic";
        
        if (attrType.IsGenericType)
        {
            var genericArgs = attrType.GetGenericArguments();
            if (genericArgs.Length > 0)
            {
                var genericArg = genericArgs[0];
                name = $"EventTopic<{genericArg.Name}>";
            }
        }
        
        return includeBackticks ? $"[{name}]" : name;
    }

    private static string GetPartitionKeyDescription(PartitionKeyMetadata partitionKey, List<PartitionKeyMetadata> allPartitionKeys)
    {
        // If there's a custom description, use it as base
        var baseDescription = partitionKey.Description ?? "Used for message routing";
        
        // Enhance description based on partition key characteristics
        if (allPartitionKeys.Count == 1)
        {
            // Single partition key
            if (partitionKey.Name.Contains("Tenant", StringComparison.OrdinalIgnoreCase))
                return "Primary partition key based on tenant";
            return baseDescription;
        }
        
        // Multiple partition keys - determine if primary or secondary
        var sortedKeys = allPartitionKeys.OrderBy(pk => pk.Order).ThenBy(pk => pk.Name).ToList();
        var index = sortedKeys.FindIndex(pk => pk.Name == partitionKey.Name);
        
        if (index == 0)
        {
            // First partition key
            if (partitionKey.Name.Contains("Tenant", StringComparison.OrdinalIgnoreCase))
                return "Primary partition key based on tenant";
            return $"Primary partition key for message routing";
        }
        else
        {
            // Secondary partition key
            if (partitionKey.Name.Contains("Test", StringComparison.OrdinalIgnoreCase))
                return "Secondary partition key for routing optimization";
            return $"Secondary partition key for message routing";
        }
    }
}