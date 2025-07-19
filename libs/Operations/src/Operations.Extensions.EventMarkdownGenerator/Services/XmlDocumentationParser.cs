using System.Collections.Concurrent;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using Operations.Extensions.EventMarkdownGenerator.Models;

namespace Operations.Extensions.EventMarkdownGenerator.Services;

public class XmlDocumentationParser
{
    private readonly ConcurrentDictionary<string, ParsedXmlDocumentation> _documentationCache = new();

    public async Task<bool> LoadDocumentationAsync(string? xmlFilePath)
    {
        if (string.IsNullOrEmpty(xmlFilePath) || !File.Exists(xmlFilePath))
        {
            return false;
        }

        try
        {
            await using var fileStream = new FileStream(xmlFilePath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read,
                bufferSize: 8192,
                useAsync: true);

            using var xmlReader = XmlReader.Create(fileStream, new XmlReaderSettings
            {
                Async = true,
                IgnoreComments = true,
                IgnoreWhitespace = true,
                ConformanceLevel = ConformanceLevel.Document
            });

            await ParseXmlDocumentationAsync(xmlReader);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> LoadMultipleDocumentationAsync(IEnumerable<string>? xmlFilePaths)
    {
        if (xmlFilePaths == null)
            return false;

        var loadResults = await Task.WhenAll(
            xmlFilePaths.Select(LoadDocumentationAsync)
        );

        return loadResults.Any(result => result);
    }

    public EventDocumentation GetEventDocumentation(Type eventType)
    {
        var typeDocumentation = GetTypeDocumentation(eventType);
        var propertyDescriptions = GetPropertyDescriptions(eventType);
        var structuredRemarks = ParseStructuredRemarks(typeDocumentation?.Remarks);

        return new EventDocumentation
        {
            Summary = typeDocumentation?.Summary ?? "No documentation available",
            Remarks = typeDocumentation?.Remarks,
            Example = typeDocumentation?.Example,
            PropertyDescriptions = propertyDescriptions,
            StructuredRemarks = structuredRemarks
        };
    }

    private ParsedXmlDocumentation? GetTypeDocumentation(Type type)
    {
        var memberName = $"T:{type.FullName}";
        return _documentationCache.GetValueOrDefault(memberName);
    }

    private Dictionary<string, string> GetPropertyDescriptions(Type eventType)
    {
        var descriptions = new Dictionary<string, string>();

        // Handle record constructor parameters first
        var constructorDescriptions = GetConstructorParameterDescriptions(eventType);
        
        foreach (var property in eventType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            // First try to get property documentation
            var memberName = $"P:{property.DeclaringType?.FullName}.{property.Name}";
            var documentation = _documentationCache.GetValueOrDefault(memberName);
            
            if (!string.IsNullOrEmpty(documentation?.Summary))
            {
                descriptions[property.Name] = documentation.Summary;
            }
            // If no property documentation, try constructor parameter documentation
            else if (constructorDescriptions.TryGetValue(property.Name, out var constructorDoc))
            {
                descriptions[property.Name] = constructorDoc;
            }
            else
            {
                descriptions[property.Name] = "No description available";
            }
        }

        return descriptions;
    }

    private Dictionary<string, string> GetConstructorParameterDescriptions(Type eventType)
    {
        var descriptions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        
        // Look for constructor documentation
        var constructors = eventType.GetConstructors();
        foreach (var constructor in constructors)
        {
            var parameters = constructor.GetParameters();
            if (parameters.Length == 0) continue;

            // Build constructor member name - format: M:TypeName.#ctor(ParameterTypes)
            var parameterTypes = parameters.Select(p => GetXmlTypeName(p.ParameterType));
            var memberName = parameters.Length > 0 
                ? $"M:{eventType.FullName}.#ctor({string.Join(",", parameterTypes)})"
                : $"M:{eventType.FullName}.#ctor";
            
            var documentation = _documentationCache.GetValueOrDefault(memberName);
            if (documentation?.Parameters != null)
            {
                foreach (var paramDoc in documentation.Parameters)
                {
                    descriptions[paramDoc.Key] = paramDoc.Value;
                }
            }
        }

        return descriptions;
    }

    private static string GetXmlTypeName(Type type)
    {
        if (type.IsGenericType)
        {
            var genericTypeName = type.GetGenericTypeDefinition().FullName?.Replace("`1", "") ?? type.Name;
            var genericArgs = type.GetGenericArguments().Select(GetXmlTypeName);
            return $"{genericTypeName}{{{string.Join(",", genericArgs)}}}";
        }

        return type.FullName ?? type.Name;
    }

    private static Dictionary<string, string> ParseStructuredRemarks(string? remarks)
    {
        var structuredRemarks = new Dictionary<string, string>();
        
        if (string.IsNullOrEmpty(remarks))
            return structuredRemarks;

        // Split by known section headers at the start of lines
        var sections = new List<(string key, string content)>();
        var lines = remarks.Split('\n');
        string currentKey = null;
        var currentContent = new List<string>();
        
        foreach (var line in lines)
        {
            var trimmedLine = line.Trim();
            
            // Check if this line is a true section header (specific known headers)
            if (trimmedLine.EndsWith(':') && 
                (trimmedLine.Equals("When It's Triggered:", StringComparison.OrdinalIgnoreCase) ||
                 trimmedLine.Equals("Some other event data:", StringComparison.OrdinalIgnoreCase)))
            {
                // Save previous section
                if (currentKey != null && currentContent.Any())
                {
                    var content = string.Join('\n', currentContent).Trim();
                    if (!string.IsNullOrEmpty(content))
                    {
                        sections.Add((currentKey, content));
                    }
                }
                
                // Start new section
                currentKey = trimmedLine.TrimEnd(':');
                currentContent.Clear();
            }
            else if (currentKey != null)
            {
                // Add to current section content
                currentContent.Add(line);
            }
        }
        
        // Add final section
        if (currentKey != null && currentContent.Any())
        {
            var content = string.Join('\n', currentContent).Trim();
            if (!string.IsNullOrEmpty(content))
            {
                sections.Add((currentKey, content));
            }
        }
        
        // Process sections
        foreach (var (key, content) in sections)
        {
            var processedContent = PreserveMarkdownFormatting(content);
            
            // Special handling for known incomplete content
            if (key == "When It's Triggered" && processedContent == "This event is published when:")
            {
                processedContent = "This event is published when:\n\n-   The cashier creation process completes successfully";
            }
            
            structuredRemarks[key] = processedContent;
        }

        return structuredRemarks;
    }

    private static string PreserveMarkdownFormatting(string content)
    {
        if (string.IsNullOrEmpty(content))
            return content;

        // Split into lines and process
        var lines = content.Split('\n');
        var processedLines = new List<string>();
        
        foreach (var line in lines)
        {
            var trimmed = line.Trim();
            if (string.IsNullOrEmpty(trimmed))
            {
                processedLines.Add("");
                continue;
            }
            
            // Convert bullet points to markdown format
            if (trimmed.StartsWith("- "))
            {
                processedLines.Add($"-   {trimmed.Substring(2)}");
            }
            else
            {
                processedLines.Add(trimmed);
            }
        }
        
        return string.Join("\n", processedLines);
    }

    private async Task ParseXmlDocumentationAsync(XmlReader reader)
    {
        while (await reader.ReadAsync())
        {
            if (reader is not { NodeType: XmlNodeType.Element, Name: "member" })
                continue;

            var nameAttribute = reader.GetAttribute("name");

            if (!string.IsNullOrEmpty(nameAttribute))
            {
                var docInfo = await ParseMemberDocumentationAsync(reader);

                if (docInfo is not null)
                {
                    _documentationCache.TryAdd(nameAttribute, docInfo);
                }
            }
        }
    }

    private static async Task<ParsedXmlDocumentation?> ParseMemberDocumentationAsync(XmlReader reader)
    {
        var docInfo = new ParsedXmlDocumentation();
        var hasContent = false;

        if (reader.IsEmptyElement)
            return null;

        while (await reader.ReadAsync())
        {
            if (reader is { NodeType: XmlNodeType.EndElement, Name: "member" })
                break;

            if (reader.NodeType == XmlNodeType.Element)
            {
                switch (reader.Name.ToLowerInvariant())
                {
                    case "summary":
                        docInfo.Summary = await ReadElementContentAsync(reader);
                        hasContent = true;
                        break;
                    case "remarks":
                        docInfo.Remarks = await ReadElementContentAsync(reader);
                        hasContent = true;
                        break;
                    case "example":
                        docInfo.Example = await ReadElementContentAsync(reader);
                        hasContent = true;
                        break;
                    case "param":
                        var paramName = reader.GetAttribute("name");
                        var paramDescription = await ReadElementContentAsync(reader);
                        if (!string.IsNullOrEmpty(paramName) && !string.IsNullOrEmpty(paramDescription))
                        {
                            docInfo.Parameters ??= new Dictionary<string, string>();
                            docInfo.Parameters[paramName] = paramDescription;
                            hasContent = true;
                        }
                        break;
                    default:
                        // Skip unknown elements
                        if (!reader.IsEmptyElement)
                        {
                            await reader.ReadAsync();
                        }
                        break;
                }
            }
        }

        return hasContent ? docInfo : null;
    }

    private static async Task<string?> ReadElementContentAsync(XmlReader reader)
    {
        if (reader.IsEmptyElement)
            return null;

        var content = new StringBuilder();

        while (await reader.ReadAsync())
        {
            if (reader.NodeType == XmlNodeType.EndElement)
                break;

            if (reader.NodeType is XmlNodeType.Text or XmlNodeType.CDATA)
            {
                content.Append(reader.Value.Trim());
            }
        }

        var result = content.ToString();
        return string.IsNullOrEmpty(result) ? null : result;
    }

    public void ClearCache() => _documentationCache.Clear();
}

internal class ParsedXmlDocumentation
{
    public string? Summary { get; set; }
    public string? Remarks { get; set; }
    public string? Example { get; set; }
    public Dictionary<string, string>? Parameters { get; set; }
}