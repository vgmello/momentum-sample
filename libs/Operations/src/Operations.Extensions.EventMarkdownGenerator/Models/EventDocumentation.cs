namespace Operations.Extensions.EventMarkdownGenerator.Models;

public record EventDocumentation
{
    public required string Summary { get; init; }
    public string? Remarks { get; init; }
    public string? Example { get; init; }
    public Dictionary<string, string> PropertyDescriptions { get; init; } = new();
    public Dictionary<string, string> StructuredRemarks { get; init; } = new();
    
    public string GetTriggerScenario() => 
        StructuredRemarks.TryGetValue("When It's Triggered", out var trigger) 
            ? trigger 
            : !string.IsNullOrEmpty(Remarks) ? Remarks : "Not specified";
    
    public string GetDescription() => 
        !string.IsNullOrEmpty(Summary) ? Summary : "No description available";
}

public record AssemblyEventDocumentation
{
    public required string AssemblyName { get; init; }
    public required string AssemblyPath { get; init; }
    public required string DefaultDomain { get; init; }
    public List<EventWithDocumentation> PublicEvents { get; init; } = new();
    public List<EventWithDocumentation> InternalEvents { get; init; } = new();
    
    public IEnumerable<EventWithDocumentation> AllEvents => PublicEvents.Concat(InternalEvents);
    
    public Dictionary<string, List<EventWithDocumentation>> GetEventsByDomain()
    {
        return AllEvents
            .GroupBy(e => e.Metadata.Domain)
            .ToDictionary(g => g.Key, g => g.OrderBy(e => e.Metadata.EventName).ToList());
    }
    
    public Dictionary<string, List<EventWithDocumentation>> GetEventsByTopic()
    {
        return AllEvents
            .GroupBy(e => e.Metadata.TopicName)
            .ToDictionary(g => g.Key, g => g.OrderBy(e => e.Metadata.Version).ToList());
    }
}

public record EventWithDocumentation
{
    public required EventMetadata Metadata { get; init; }
    public required EventDocumentation Documentation { get; init; }
    
    public string GetFileName() => Metadata.GetKebabCaseFileName();
    public string GetDisplayName() => Metadata.EventName.ToDisplayName();
}

public static class StringExtensions
{
    public static string ToDisplayName(this string value)
    {
        if (string.IsNullOrEmpty(value))
            return value;

        var result = string.Concat(
            value.Select((x, i) => i > 0 && char.IsUpper(x) && char.IsLower(value[i - 1])
                ? " " + x
                : x.ToString())
        );

        return result;
    }
}