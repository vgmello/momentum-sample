using FluentAssertions;
using Operations.Extensions.EventMarkdownGenerator.Models;
using Operations.Extensions.EventMarkdownGenerator.Services;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Operations.Extensions.EventMarkdownGenerator.Tests;

public class IntegrationTests
{
    private const string TestAssemblyPath = "/home/vgmello/shared/repos/momentum-sample/libs/Operations/tests/TestEvents/bin/Debug/net9.0/TestEvents.dll";
    private const string TestXmlPath = "/home/vgmello/shared/repos/momentum-sample/libs/Operations/tests/TestEvents/bin/Debug/net9.0/TestEvents.xml";
    private const string ReferenceMarkdownPath = "/home/vgmello/shared/repos/momentum-sample/docs/events/cashier-created.md";

    [Fact]
    public async Task GenerateMarkdown_ShouldMatchReferenceFormat()
    {
        // Arrange
        var outputDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
        Directory.CreateDirectory(outputDir);

        try
        {
            // Initialize services
            var xmlParser = new XmlDocumentationParser();
            var eventDiscovery = new AssemblyEventDiscovery();
            var markdownGenerator = new IndividualMarkdownGenerator();

            // Load XML documentation
            await xmlParser.LoadDocumentationAsync(TestXmlPath);

            // Load and discover events
            var assembly = Assembly.LoadFrom(TestAssemblyPath);
            var events = eventDiscovery.DiscoverEvents(assembly).ToList();

            events.Should().HaveCount(1);
            var cashierCreatedEvent = events.First();
            cashierCreatedEvent.EventName.Should().Be("CashierCreated");

            // Get documentation and generate markdown
            var documentation = xmlParser.GetEventDocumentation(cashierCreatedEvent.EventType);
            var eventWithDoc = new EventWithDocumentation
            {
                Metadata = cashierCreatedEvent,
                Documentation = documentation
            };

            var generatedMarkdown = markdownGenerator.GenerateMarkdown(eventWithDoc, outputDir);

            // Act - Read generated content
            var generatedContent = await File.ReadAllTextAsync(generatedMarkdown.FilePath);

            // Assert - Compare with reference (if exists)
            if (File.Exists(ReferenceMarkdownPath))
            {
                var referenceContent = await File.ReadAllTextAsync(ReferenceMarkdownPath);
                
                // Compare key sections
                CompareMarkdownSection(generatedContent, referenceContent, "# CashierCreated", "Title should match");
                CompareMarkdownSection(generatedContent, referenceContent, "**Status:**", "Status should match");
                CompareMarkdownSection(generatedContent, referenceContent, "**Topic:**", "Topic should match");
                CompareMarkdownSection(generatedContent, referenceContent, "**Type:**", "Type should match");
            }

            // Validate specific content regardless of reference
            ValidateGeneratedContent(generatedContent, cashierCreatedEvent);
        }
        finally
        {
            if (Directory.Exists(outputDir))
                Directory.Delete(outputDir, true);
        }
    }

    [Fact]
    public void EventDiscovery_ShouldDetectPartitionKeys()
    {
        // Arrange
        var eventDiscovery = new AssemblyEventDiscovery();
        var assembly = Assembly.LoadFrom(TestAssemblyPath);

        // Act
        var events = eventDiscovery.DiscoverEvents(assembly).ToList();

        // Assert
        events.Should().HaveCount(1);
        var cashierEvent = events.First();
        
        cashierEvent.PartitionKeys.Should().HaveCount(2);
        cashierEvent.PartitionKeys.Should().ContainSingle(pk => pk.Name == "TenantId");
        cashierEvent.PartitionKeys.Should().ContainSingle(pk => pk.Name == "PartitionKeyTest");
        
        // Validate partition key ordering
        var orderedKeys = cashierEvent.PartitionKeys.OrderBy(pk => pk.Order).ToList();
        orderedKeys[0].Name.Should().Be("TenantId");
        orderedKeys[1].Name.Should().Be("PartitionKeyTest");
    }

    [Fact]
    public void EventDiscovery_ShouldDetectDomainFromNamespace()
    {
        // Arrange
        var eventDiscovery = new AssemblyEventDiscovery();
        var assembly = Assembly.LoadFrom(TestAssemblyPath);

        // Act
        var events = eventDiscovery.DiscoverEvents(assembly).ToList();

        // Assert
        events.Should().HaveCount(1);
        var cashierEvent = events.First();
        cashierEvent.Domain.Should().Be("Billing");
    }

    [Fact]
    public async Task XmlDocumentationParser_ShouldParsePropertyDescriptions()
    {
        // Arrange
        var parser = new XmlDocumentationParser();
        await parser.LoadDocumentationAsync(TestXmlPath);
        
        var assembly = Assembly.LoadFrom(TestAssemblyPath);
        var cashierCreatedType = assembly.GetType("Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated");

        // Act
        var documentation = parser.GetEventDocumentation(cashierCreatedType!);

        // Assert
        documentation.Summary.Should().Contain("Published when a new cashier is successfully created");
        
        // These are currently failing - documenting the expected behavior
        documentation.PropertyDescriptions.Should().ContainKey("TenantId");
        if (documentation.PropertyDescriptions.ContainsKey("TenantId"))
        {
            documentation.PropertyDescriptions["TenantId"].Should().NotBe("No description available");
        }
    }

    private static void CompareMarkdownSection(string generated, string reference, string sectionMarker, string message)
    {
        var generatedLine = FindLineContaining(generated, sectionMarker);
        var referenceLine = FindLineContaining(reference, sectionMarker);
        
        if (generatedLine != null && referenceLine != null)
        {
            generatedLine.Should().Be(referenceLine, message);
        }
    }

    private static string? FindLineContaining(string content, string marker)
    {
        return content.Split('\n')
            .FirstOrDefault(line => line.Contains(marker))?.Trim();
    }

    private static void ValidateGeneratedContent(string content, EventMetadata eventMetadata)
    {
        // Validate basic structure
        content.Should().Contain("# CashierCreated");
        content.Should().Contain("**Status:**");
        content.Should().Contain("**Version:**");
        content.Should().Contain("**Topic:**");
        content.Should().Contain("**Type:** Integration Event");
        
        // Validate sections
        content.Should().Contain("## Description");
        content.Should().Contain("## Event Payload");
        content.Should().Contain("### Partition Keys");
        content.Should().Contain("## Technical Details");
        
        // Validate partition keys are mentioned
        content.Should().Contain("TenantId");
        content.Should().Contain("PartitionKeyTest");
        
        // Validate code snippet exists
        content.Should().Contain("```csharp");
        content.Should().Contain("[PartitionKey]");
        
        // Validate domain detection
        content.Should().Contain("Billing.Cashiers.Contracts.IntegrationEvents");
    }
}