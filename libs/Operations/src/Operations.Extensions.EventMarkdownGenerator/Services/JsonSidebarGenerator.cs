using System.Text.Json;
using Operations.Extensions.EventMarkdownGenerator.Models;

namespace Operations.Extensions.EventMarkdownGenerator.Services;

public class JsonSidebarGenerator
{
    private readonly JsonSerializerOptions _jsonOptions = new()
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public string GenerateSidebar(IEnumerable<EventWithDocumentation> events)
    {
        var sidebarItems = GenerateSidebarItems(events);
        return JsonSerializer.Serialize(sidebarItems, _jsonOptions);
    }

    public List<SidebarItem> GenerateSidebarItems(IEnumerable<EventWithDocumentation> events)
    {
        var sidebarItems = new List<SidebarItem>();
        
        // Group events by domain (not by topic as in the original)
        var eventsByDomain = events
            .GroupBy(e => e.Metadata.Domain)
            .OrderBy(g => g.Key);

        foreach (var domainGroup in eventsByDomain)
        {
            var domainName = CapitalizeDomain(domainGroup.Key);
            
            var eventItems = domainGroup
                .OrderBy(e => e.Metadata.EventName)
                .Select(CreateEventSidebarItem)
                .ToList();

            sidebarItems.Add(new SidebarItem
            {
                Text = domainName,
                Collapsed = false,
                Items = eventItems
            });
        }

        return sidebarItems;
    }

    public async Task WriteSidebarAsync(IEnumerable<EventWithDocumentation> events, string filePath)
    {
        var sidebarJson = GenerateSidebar(events);
        await File.WriteAllTextAsync(filePath, sidebarJson);
    }

    private static SidebarItem CreateEventSidebarItem(EventWithDocumentation eventWithDoc)
    {
        var metadata = eventWithDoc.Metadata;
        var displayName = metadata.EventName.ToDisplayName();
        var link = "/" + metadata.GetKebabCaseFileName().Replace(".md", "");

        return new SidebarItem
        {
            Text = displayName,
            Link = link
        };
    }

    private static string CapitalizeDomain(string domain)
    {
        if (string.IsNullOrEmpty(domain))
            return "Unknown";

        // Handle special cases
        if (domain.Equals("unknown", StringComparison.OrdinalIgnoreCase))
            return "Unknown";

        // Capitalize first letter and handle camelCase/PascalCase
        var result = char.ToUpperInvariant(domain[0]) + domain.Substring(1);
        
        // If it's already properly capitalized, return as-is
        if (char.IsUpper(domain[0]))
            return domain;
            
        return result;
    }
}

public static class SidebarExtensions
{
    public static string ToDisplayName(this string eventName)
    {
        if (string.IsNullOrEmpty(eventName))
            return eventName;

        // Convert PascalCase to space-separated words
        var result = string.Concat(
            eventName.Select((x, i) => i > 0 && char.IsUpper(x) && char.IsLower(eventName[i - 1])
                ? " " + x
                : x.ToString())
        );

        return result;
    }
}