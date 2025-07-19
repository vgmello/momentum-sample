using FluentAssertions;
using Operations.Extensions.EventMarkdownGenerator.Services;
using System.Reflection;

namespace Operations.Extensions.EventMarkdownGenerator.Tests;

public class XmlDocumentationParserTests
{
    [Fact]
    public async Task LoadDocumentationAsync_ShouldParseParameterDocumentation()
    {
        // Arrange
        var parser = new XmlDocumentationParser();
        var xmlPath = "/home/vgmello/shared/repos/momentum-sample/libs/Operations/tests/TestEvents/bin/Debug/net9.0/TestEvents.xml";
        
        // Act
        var result = await parser.LoadDocumentationAsync(xmlPath);
        
        // Assert
        result.Should().BeTrue();
        
        // Load the actual CashierCreated type
        var assembly = Assembly.LoadFrom("/home/vgmello/shared/repos/momentum-sample/libs/Operations/tests/TestEvents/bin/Debug/net9.0/TestEvents.dll");
        var cashierCreatedType = assembly.GetType("Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated");
        cashierCreatedType.Should().NotBeNull();
        
        // Get documentation for the event
        var documentation = parser.GetEventDocumentation(cashierCreatedType!);
        
        // Verify summary is parsed
        documentation.Summary.Should().Contain("Published when a new cashier is successfully created");
        
        // Verify parameter descriptions are parsed (this is what's failing)
        documentation.PropertyDescriptions.Should().ContainKey("TenantId");
        documentation.PropertyDescriptions["TenantId"].Should().Be("Identifier of the tenant that owns the cashier");
        
        documentation.PropertyDescriptions.Should().ContainKey("PartitionKeyTest");
        documentation.PropertyDescriptions["PartitionKeyTest"].Should().Be("Additional partition key for message routing");
        
        documentation.PropertyDescriptions.Should().ContainKey("Cashier");
        documentation.PropertyDescriptions["Cashier"].Should().Be("Complete cashier object containing all cashier data and configuration");
    }
}