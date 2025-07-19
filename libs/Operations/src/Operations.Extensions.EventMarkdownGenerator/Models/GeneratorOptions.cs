namespace Operations.Extensions.EventMarkdownGenerator.Models;

public record GeneratorOptions
{
    public required List<string> AssemblyPaths { get; init; }
    public required string OutputDirectory { get; init; }
    public List<string>? XmlDocumentationPaths { get; init; }
    public string SidebarFileName { get; init; } = "events-sidebar.json";
    public bool Verbose { get; init; } = false;
    
    public string GetSidebarPath() => Path.Combine(OutputDirectory, SidebarFileName);
    
    public void EnsureOutputDirectoryExists()
    {
        if (!Directory.Exists(OutputDirectory))
        {
            Directory.CreateDirectory(OutputDirectory);
        }
    }
}

public record SidebarItem
{
    public required string Text { get; init; }
    public string? Link { get; init; }
    public List<SidebarItem> Items { get; init; } = new();
    public bool Collapsed { get; init; } = false;
}

public record IndividualMarkdownOutput
{
    public required string FileName { get; init; }
    public required string Content { get; init; }
    public required string FilePath { get; init; }
}

public record GenerationResult
{
    public List<IndividualMarkdownOutput> MarkdownFiles { get; init; } = new();
    public List<SidebarItem> SidebarConfiguration { get; init; } = new();
    public string SidebarJson { get; init; } = string.Empty;
    public int ProcessedEventsCount { get; init; }
    public int ProcessedAssembliesCount { get; init; }
    
    public void WriteToDirectory(string outputDirectory)
    {
        foreach (var markdownFile in MarkdownFiles)
        {
            File.WriteAllText(markdownFile.FilePath, markdownFile.Content);
        }
        
        if (!string.IsNullOrEmpty(SidebarJson))
        {
            var sidebarPath = Path.Combine(outputDirectory, "events-sidebar.json");
            File.WriteAllText(sidebarPath, SidebarJson);
        }
    }
}