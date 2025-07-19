using FluentAssertions;
using Operations.Extensions.EventMarkdownGenerator.Services;
using System.Reflection;

namespace Operations.Extensions.EventMarkdownGenerator.Tests;

public class XmlParsingDebugTests
{
    [Fact]
    public async Task DebugXmlParsing_ShouldShowWhatIsParsed()
    {
        // Arrange
        var parser = new XmlDocumentationParser();
        var xmlPath = "/home/vgmello/shared/repos/momentum-sample/libs/Operations/tests/TestEvents/bin/Debug/net9.0/TestEvents.xml";
        var assemblyPath = "/home/vgmello/shared/repos/momentum-sample/libs/Operations/tests/TestEvents/bin/Debug/net9.0/TestEvents.dll";
        
        // Act
        var result = await parser.LoadDocumentationAsync(xmlPath);
        result.Should().BeTrue("XML file should load successfully");
        
        var assembly = Assembly.LoadFrom(assemblyPath);
        var cashierCreatedType = assembly.GetType("Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated");
        cashierCreatedType.Should().NotBeNull();
        
        var documentation = parser.GetEventDocumentation(cashierCreatedType!);
        
        // Debug output - let's see what we actually get
        Console.WriteLine($"Summary: {documentation.Summary}");
        Console.WriteLine($"Remarks: {documentation.Remarks}");
        Console.WriteLine($"Property descriptions count: {documentation.PropertyDescriptions.Count}");
        
        foreach (var prop in documentation.PropertyDescriptions)
        {
            Console.WriteLine($"  {prop.Key}: {prop.Value}");
        }
        
        Console.WriteLine($"Structured remarks count: {documentation.StructuredRemarks.Count}");
        foreach (var remark in documentation.StructuredRemarks)
        {
            Console.WriteLine($"  {remark.Key}: {remark.Value}");
        }
        
        // Basic assertions
        documentation.Summary.Should().NotBeNullOrEmpty();
        documentation.Summary.Should().Contain("Published when a new cashier is successfully created");
        
        // This will help us see why property descriptions aren't working
        var properties = cashierCreatedType.GetProperties();
        Console.WriteLine($"\nType properties ({properties.Length}):");
        foreach (var prop in properties)
        {
            Console.WriteLine($"  {prop.Name} - {prop.PropertyType.Name}");
        }
        
        // Check what's in the property descriptions
        documentation.PropertyDescriptions.Should().ContainKey("TenantId");
        documentation.PropertyDescriptions.Should().ContainKey("PartitionKeyTest");
        documentation.PropertyDescriptions.Should().ContainKey("Cashier");
        
        // The main issue we're investigating
        foreach (var expectedProp in new[] { "TenantId", "PartitionKeyTest", "Cashier" })
        {
            if (documentation.PropertyDescriptions.ContainsKey(expectedProp))
            {
                var desc = documentation.PropertyDescriptions[expectedProp];
                Console.WriteLine($"Property {expectedProp}: '{desc}'");
                
                // This should NOT be "No description available" if XML parsing works
                if (desc == "No description available")
                {
                    Console.WriteLine($"  ❌ Property {expectedProp} has no description - XML parsing failed");
                }
                else
                {
                    Console.WriteLine($"  ✅ Property {expectedProp} has description - XML parsing worked");
                }
            }
        }
    }
    
    [Fact]
    public void ValidateXmlFileContent()
    {
        // Let's verify the XML file contains what we expect
        var xmlPath = "/home/vgmello/shared/repos/momentum-sample/libs/Operations/tests/TestEvents/bin/Debug/net9.0/TestEvents.xml";
        File.Exists(xmlPath).Should().BeTrue("XML documentation file should exist");
        
        var xmlContent = File.ReadAllText(xmlPath);
        Console.WriteLine("XML Content preview:");
        Console.WriteLine(xmlContent.Substring(0, Math.Min(1000, xmlContent.Length)));
        
        // Verify expected property documentation exists
        xmlContent.Should().Contain("P:Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.TenantId");
        xmlContent.Should().Contain("P:Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.PartitionKeyTest");
        xmlContent.Should().Contain("P:Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.Cashier");
        
        // Verify parameter documentation exists
        xmlContent.Should().Contain("M:Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.#ctor");
        xmlContent.Should().Contain("param name=\"TenantId\"");
        xmlContent.Should().Contain("param name=\"PartitionKeyTest\"");
        xmlContent.Should().Contain("param name=\"Cashier\"");
        
        // Verify descriptions
        xmlContent.Should().Contain("Identifier of the tenant that owns the cashier");
        xmlContent.Should().Contain("Additional partition key for message routing");
        xmlContent.Should().Contain("Complete cashier object containing all cashier data and configuration");
    }
}