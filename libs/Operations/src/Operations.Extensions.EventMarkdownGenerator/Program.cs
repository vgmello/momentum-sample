using System.CommandLine;
using System.Reflection;
using Operations.Extensions.EventMarkdownGenerator.Models;
using Operations.Extensions.EventMarkdownGenerator.Services;

namespace Operations.Extensions.EventMarkdownGenerator;

internal class Program
{
    static async Task<int> Main(string[] args)
    {
        var assembliesOption = new Option<string>(
            name: "--assemblies",
            description: "Comma-separated list of assembly paths to analyze")
        {
            IsRequired = true
        };

        var xmlDocsOption = new Option<string?>(
            name: "--xml-docs",
            description: "Comma-separated list of XML documentation file paths (auto-discovered if not provided)");

        var outputOption = new Option<string>(
            name: "--output",
            description: "Output directory for generated markdown files")
        {
            IsRequired = true
        };

        var sidebarFileOption = new Option<string>(
            name: "--sidebar-file",
            description: "Name of the JSON sidebar file",
            getDefaultValue: () => "events-sidebar.json");

        var verboseOption = new Option<bool>(
            name: "--verbose",
            description: "Enable verbose output");

        var rootCommand = new RootCommand("Generate individual markdown documentation files for integration events")
        {
            assembliesOption,
            xmlDocsOption,
            outputOption,
            sidebarFileOption,
            verboseOption
        };

        rootCommand.SetHandler(async (assemblies, xmlDocs, outputDir, sidebarFile, verbose) =>
        {
            try
            {
                var assemblyPaths = assemblies.Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim())
                    .ToList();

                var xmlDocPaths = string.IsNullOrEmpty(xmlDocs)
                    ? null
                    : xmlDocs.Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(p => p.Trim())
                        .ToList();

                var options = new GeneratorOptions
                {
                    AssemblyPaths = assemblyPaths,
                    XmlDocumentationPaths = xmlDocPaths,
                    OutputDirectory = outputDir,
                    SidebarFileName = sidebarFile,
                    Verbose = verbose
                };

                await GenerateDocumentationAsync(options);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                if (verbose)
                {
                    Console.WriteLine($"Stack trace: {ex.StackTrace}");
                }
                Environment.Exit(1);
            }
        }, assembliesOption, xmlDocsOption, outputOption, sidebarFileOption, verboseOption);

        return await rootCommand.InvokeAsync(args);
    }

    private static async Task GenerateDocumentationAsync(GeneratorOptions options)
    {
        if (options.Verbose)
        {
            Console.WriteLine($"Analyzing {options.AssemblyPaths.Count} assemblies:");
            foreach (var assemblyPath in options.AssemblyPaths)
            {
                Console.WriteLine($"  - {assemblyPath}");
            }
            
            if (options.XmlDocumentationPaths?.Any() == true)
            {
                Console.WriteLine($"Explicit XML documentation files:");
                foreach (var xmlPath in options.XmlDocumentationPaths)
                {
                    Console.WriteLine($"  - {xmlPath}");
                }
            }
            else
            {
                Console.WriteLine("XML documentation: Will auto-discover alongside assemblies");
            }
            
            Console.WriteLine($"Output directory: {options.OutputDirectory}");
            Console.WriteLine();
        }

        // Validate assembly paths
        foreach (var assemblyPath in options.AssemblyPaths)
        {
            if (!File.Exists(assemblyPath))
            {
                throw new FileNotFoundException($"Assembly not found: {assemblyPath}");
            }
        }

        // Ensure output directory exists
        options.EnsureOutputDirectoryExists();

        // Initialize services
        var xmlParser = new XmlDocumentationParser();
        var eventDiscovery = new AssemblyEventDiscovery();
        var markdownGenerator = new IndividualMarkdownGenerator();
        var sidebarGenerator = new JsonSidebarGenerator();

        // Auto-discover and load XML documentation
        var xmlDocumentationPaths = DiscoverXmlDocumentationFiles(options.AssemblyPaths, options.XmlDocumentationPaths, options.Verbose);
        
        if (xmlDocumentationPaths.Any())
        {
            var xmlLoadResult = await xmlParser.LoadMultipleDocumentationAsync(xmlDocumentationPaths);
            if (options.Verbose)
            {
                Console.WriteLine($"XML documentation loaded: {(xmlLoadResult ? "Success" : "Failed or partial")}");
                Console.WriteLine();
            }
        }
        else if (options.Verbose)
        {
            Console.WriteLine("No XML documentation files found");
            Console.WriteLine();
        }

        var allEvents = new List<EventWithDocumentation>();
        var processedAssemblies = 0;

        // Process each assembly
        foreach (var assemblyPath in options.AssemblyPaths)
        {
            try
            {
                if (options.Verbose)
                {
                    Console.WriteLine($"Processing assembly: {Path.GetFileName(assemblyPath)}");
                }

                var assembly = Assembly.LoadFrom(assemblyPath);
                var events = eventDiscovery.DiscoverEvents(assembly, xmlParser);

                foreach (var eventMetadata in events)
                {
                    var documentation = xmlParser.GetEventDocumentation(eventMetadata.EventType);
                    var eventWithDoc = new EventWithDocumentation
                    {
                        Metadata = eventMetadata,
                        Documentation = documentation
                    };

                    allEvents.Add(eventWithDoc);

                    if (options.Verbose)
                    {
                        Console.WriteLine($"  Found event: {eventMetadata.EventName} (PartitionKeys: {eventMetadata.PartitionKeys.Count})");
                    }
                }

                processedAssemblies++;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Warning: Failed to process assembly {assemblyPath}: {ex.Message}");
                if (options.Verbose)
                {
                    Console.WriteLine($"  Stack trace: {ex.StackTrace}");
                }
            }
        }

        if (!allEvents.Any())
        {
            Console.WriteLine("No integration events found in the provided assemblies.");
            return;
        }

        // Generate individual markdown files
        var markdownFiles = markdownGenerator.GenerateAllMarkdown(allEvents, options.OutputDirectory).ToList();

        // Write markdown files
        foreach (var markdownFile in markdownFiles)
        {
            await File.WriteAllTextAsync(markdownFile.FilePath, markdownFile.Content);
            
            if (options.Verbose)
            {
                Console.WriteLine($"Generated: {markdownFile.FileName}");
            }
        }

        // Generate and write sidebar JSON
        await sidebarGenerator.WriteSidebarAsync(allEvents, options.GetSidebarPath());
        
        if (options.Verbose)
        {
            Console.WriteLine($"Generated sidebar: {options.SidebarFileName}");
        }

        // Summary
        Console.WriteLine();
        Console.WriteLine($"✓ Successfully generated documentation for {allEvents.Count} events from {processedAssemblies} assemblies");
        Console.WriteLine($"✓ Created {markdownFiles.Count} markdown files in: {options.OutputDirectory}");
        Console.WriteLine($"✓ Generated sidebar file: {options.SidebarFileName}");

        // Group by domain for summary
        if (options.Verbose)
        {
            var eventsByDomain = allEvents.GroupBy(e => e.Metadata.Domain);
            Console.WriteLine();
            Console.WriteLine("Events by domain:");
            foreach (var domainGroup in eventsByDomain.OrderBy(g => g.Key))
            {
                Console.WriteLine($"  {domainGroup.Key}: {domainGroup.Count()} events");
            }

            var partitionKeyEvents = allEvents.Where(e => e.Metadata.PartitionKeys.Any()).ToList();
            if (partitionKeyEvents.Any())
            {
                Console.WriteLine();
                Console.WriteLine($"Events with partition keys: {partitionKeyEvents.Count}");
            }

            var obsoleteEvents = allEvents.Where(e => e.Metadata.IsObsolete).ToList();
            if (obsoleteEvents.Any())
            {
                Console.WriteLine($"Obsolete events: {obsoleteEvents.Count}");
            }
        }
    }

    private static List<string> DiscoverXmlDocumentationFiles(List<string> assemblyPaths, List<string>? explicitXmlPaths, bool verbose)
    {
        var xmlPaths = new List<string>();

        // First, add any explicitly provided XML documentation paths
        if (explicitXmlPaths?.Any() == true)
        {
            foreach (var xmlPath in explicitXmlPaths)
            {
                if (File.Exists(xmlPath))
                {
                    xmlPaths.Add(xmlPath);
                    if (verbose)
                    {
                        Console.WriteLine($"Using explicit XML documentation: {xmlPath}");
                    }
                }
                else if (verbose)
                {
                    Console.WriteLine($"Warning: Explicit XML documentation not found: {xmlPath}");
                }
            }
        }

        // Auto-discover XML files alongside assemblies
        foreach (var assemblyPath in assemblyPaths)
        {
            var xmlPath = GetExpectedXmlDocumentationPath(assemblyPath);
            
            if (File.Exists(xmlPath) && !xmlPaths.Contains(xmlPath, StringComparer.OrdinalIgnoreCase))
            {
                xmlPaths.Add(xmlPath);
                if (verbose)
                {
                    Console.WriteLine($"Auto-discovered XML documentation: {xmlPath}");
                }
            }
            else if (verbose)
            {
                Console.WriteLine($"XML documentation not found for: {Path.GetFileName(assemblyPath)} (expected: {Path.GetFileName(xmlPath)})");
            }
        }

        return xmlPaths;
    }

    private static string GetExpectedXmlDocumentationPath(string assemblyPath)
    {
        // Replace .dll/.exe with .xml in the same directory
        var directory = Path.GetDirectoryName(assemblyPath) ?? string.Empty;
        var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(assemblyPath);
        return Path.Combine(directory, $"{fileNameWithoutExtension}.xml");
    }
}