using System.Reflection;
using Operations.Extensions.Abstractions.Messaging;
using Operations.Extensions.EventMarkdownGenerator.Models;

namespace Operations.Extensions.EventMarkdownGenerator.Services;

public class AssemblyEventDiscovery
{
    private const string IntegrationEventsNamespace = ".IntegrationEvents";

    public IEnumerable<EventMetadata> DiscoverEvents(Assembly assembly, string environment = "dev")
    {
        var defaultDomain = GetDefaultDomain(assembly);
        var integrationEventTypes = GetIntegrationEventTypes(assembly);

        return integrationEventTypes.Select(type => CreateEventMetadata(type, defaultDomain, environment, null));
    }

    public IEnumerable<EventMetadata> DiscoverEvents(Assembly assembly, XmlDocumentationParser? xmlParser, string environment = "dev")
    {
        var defaultDomain = GetDefaultDomain(assembly);
        var integrationEventTypes = GetIntegrationEventTypes(assembly);

        return integrationEventTypes.Select(type => CreateEventMetadata(type, defaultDomain, environment, xmlParser));
    }

    private static IEnumerable<Type> GetIntegrationEventTypes(Assembly assembly)
    {
        return assembly.GetTypes()
            .Where(IsIntegrationEventType)
            .Where(HasEventTopicAttribute);
    }

    private static bool IsIntegrationEventType(Type type)
    {
        return type.Namespace?.EndsWith(IntegrationEventsNamespace) == true;
    }

    private static bool HasEventTopicAttribute(Type type)
    {
        return type.GetCustomAttribute<EventTopicAttribute>() != null ||
               type.GetCustomAttributes().Any(attr => attr.GetType().Name.StartsWith("EventTopicAttribute"));
    }

    private static EventMetadata CreateEventMetadata(Type eventType, string defaultDomain, string environment, XmlDocumentationParser? xmlParser)
    {
        var topicAttribute = GetEventTopicAttribute(eventType);
        var obsoleteAttribute = eventType.GetCustomAttribute<ObsoleteAttribute>();
        var (properties, partitionKeys) = GetEventPropertiesAndPartitionKeys(eventType, xmlParser);

        var domain = !string.IsNullOrWhiteSpace(topicAttribute.Domain)
            ? topicAttribute.Domain
            : GetDomainFromNamespace(eventType.Namespace) ?? defaultDomain;

        var topicName = topicAttribute.Topic;
        if (topicAttribute.ShouldPluralizeTopicName)
        {
            topicName = PluralizeTopic(topicName);
        }

        return new EventMetadata
        {
            EventName = eventType.Name,
            FullTypeName = eventType.FullName ?? eventType.Name,
            Namespace = eventType.Namespace ?? string.Empty,
            TopicName = topicName,
            Domain = domain,
            Version = topicAttribute.Version ?? "v1",
            IsInternal = topicAttribute.Internal,
            EventType = eventType,
            TopicAttribute = GetEventTopicAttributeInstance(eventType),
            Properties = properties,
            PartitionKeys = partitionKeys,
            ObsoleteMessage = obsoleteAttribute?.Message
        };
    }

    private static EventTopicAttribute GetEventTopicAttribute(Type type)
    {
        var attribute = type.GetCustomAttribute<EventTopicAttribute>();
        if (attribute != null)
        {
            return attribute;
        }

        // Handle generic EventTopicAttribute<T>
        var genericAttribute = type.GetCustomAttributes()
            .FirstOrDefault(attr => attr.GetType().Name.StartsWith("EventTopicAttribute") && attr.GetType().IsGenericType);

        if (genericAttribute != null)
        {
            return (EventTopicAttribute)genericAttribute;
        }

        throw new InvalidOperationException($"EventTopicAttribute not found on type {type.Name}");
    }

    private static Attribute GetEventTopicAttributeInstance(Type type)
    {
        var attribute = type.GetCustomAttribute<EventTopicAttribute>();
        if (attribute != null)
        {
            return attribute;
        }

        // Handle generic EventTopicAttribute<T>
        var genericAttribute = type.GetCustomAttributes()
            .FirstOrDefault(attr => attr.GetType().Name.StartsWith("EventTopicAttribute") && attr.GetType().IsGenericType);

        if (genericAttribute != null)
        {
            return genericAttribute;
        }

        throw new InvalidOperationException($"EventTopicAttribute not found on type {type.Name}");
    }

    private static (List<EventPropertyMetadata> properties, List<PartitionKeyMetadata> partitionKeys) GetEventPropertiesAndPartitionKeys(Type eventType, XmlDocumentationParser? xmlParser)
    {
        var properties = new List<EventPropertyMetadata>();
        var partitionKeys = new List<PartitionKeyMetadata>();

        // Handle C# records with primary constructor parameters
        var constructor = eventType.GetConstructors().FirstOrDefault();
        var constructorParameters = constructor?.GetParameters() ?? Array.Empty<ParameterInfo>();
        
        // Map constructor parameters to properties for records
        var parameterToPropertyMap = MapConstructorParametersToProperties(eventType, constructorParameters);

        // Get event documentation once per type to avoid redundant XML parsing
        var eventDoc = xmlParser?.GetEventDocumentation(eventType);

        foreach (var property in eventType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            var isComplexType = !IsSimpleType(property.PropertyType);
            var isRequired = IsRequiredProperty(property);
            
            // Check for PartitionKey attribute on the property
            var partitionKeyAttr = property.GetCustomAttribute<PartitionKeyAttribute>();
            var isPartitionKey = partitionKeyAttr != null;
            
            // If not found on property, check corresponding constructor parameter for records
            if (!isPartitionKey && parameterToPropertyMap.TryGetValue(property.Name, out var parameter))
            {
                partitionKeyAttr = parameter.GetCustomAttribute<PartitionKeyAttribute>();
                isPartitionKey = partitionKeyAttr != null;
            }

            // Get property description from XML documentation
            var description = eventDoc?.PropertyDescriptions?.GetValueOrDefault(property.Name) ?? "No description available";

            properties.Add(new EventPropertyMetadata
            {
                Name = property.Name,
                TypeName = GetFriendlyTypeName(property.PropertyType),
                PropertyType = property.PropertyType,
                IsRequired = isRequired,
                IsComplexType = isComplexType,
                IsPartitionKey = isPartitionKey,
                PartitionKeyOrder = partitionKeyAttr?.Order,
                Description = description
            });

            if (isPartitionKey)
            {
                partitionKeys.Add(new PartitionKeyMetadata
                {
                    Name = property.Name,
                    TypeName = GetFriendlyTypeName(property.PropertyType),
                    Order = partitionKeyAttr?.Order ?? 0,
                    IsFromParameter = parameterToPropertyMap.ContainsKey(property.Name)
                });
            }
        }

        // Sort partition keys by order
        partitionKeys = partitionKeys.OrderBy(pk => pk.Order).ThenBy(pk => pk.Name).ToList();

        return (properties, partitionKeys);
    }

    private static Dictionary<string, ParameterInfo> MapConstructorParametersToProperties(Type eventType, ParameterInfo[] constructorParameters)
    {
        var map = new Dictionary<string, ParameterInfo>(StringComparer.OrdinalIgnoreCase);
        
        foreach (var parameter in constructorParameters)
        {
            // Find matching property by name (case-insensitive)
            var property = eventType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .FirstOrDefault(p => string.Equals(p.Name, parameter.Name, StringComparison.OrdinalIgnoreCase));
            
            if (property != null)
            {
                map[property.Name] = parameter;
            }
        }

        return map;
    }

    private static bool IsSimpleType(Type type)
    {
        return type.IsPrimitive ||
               type.IsEnum ||
               type == typeof(string) ||
               type == typeof(decimal) ||
               type == typeof(DateTime) ||
               type == typeof(DateTimeOffset) ||
               type == typeof(TimeSpan) ||
               type == typeof(Guid) ||
               Nullable.GetUnderlyingType(type) != null && IsSimpleType(Nullable.GetUnderlyingType(type)!);
    }

    private static bool IsRequiredProperty(PropertyInfo property)
    {
        // Check for required keyword (C# 11+)
        if (property.GetCustomAttribute<System.ComponentModel.DataAnnotations.RequiredAttribute>() != null)
        {
            return true;
        }

        // Check for nullable reference types
        var nullableContext = new System.Reflection.NullabilityInfoContext();
        var nullabilityInfo = nullableContext.Create(property);
        
        return nullabilityInfo.WriteState == System.Reflection.NullabilityState.NotNull;
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

    private static string? GetDomainFromNamespace(string? namespaceName)
    {
        if (string.IsNullOrEmpty(namespaceName))
            return null;
            
        // For namespaces like "Billing.Cashiers.Contracts.IntegrationEvents", extract "Billing"
        var parts = namespaceName.Split('.');
        if (parts.Length >= 1)
        {
            return parts[0]; // Take first part as domain
        }
        
        return null;
    }

    private static string GetDefaultDomain(Assembly assembly)
    {
        // Try to extract domain from assembly name
        var assemblyName = assembly.GetName().Name ?? "Unknown";
        
        // Look for patterns like "Company.Domain.Service" and extract "Domain"
        var parts = assemblyName.Split('.');
        if (parts.Length >= 2)
        {
            return parts[1]; // Take second part as domain
        }

        return "Unknown";
    }

    private static string PluralizeTopic(string topic)
    {
        if (string.IsNullOrEmpty(topic))
            return topic;

        // Simple pluralization logic
        if (topic.EndsWith("y", StringComparison.OrdinalIgnoreCase))
        {
            return topic.Substring(0, topic.Length - 1) + "ies";
        }
        
        if (topic.EndsWith("s", StringComparison.OrdinalIgnoreCase) ||
            topic.EndsWith("sh", StringComparison.OrdinalIgnoreCase) ||
            topic.EndsWith("ch", StringComparison.OrdinalIgnoreCase) ||
            topic.EndsWith("x", StringComparison.OrdinalIgnoreCase) ||
            topic.EndsWith("z", StringComparison.OrdinalIgnoreCase))
        {
            return topic + "es";
        }

        return topic + "s";
    }
}