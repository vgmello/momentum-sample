# InvoiceCreated

**Status:** Active  
**Version:** v1  
**Topic:** `invoices`  
**Type:** Integration Event

## Description

Published when a new invoice is successfully created in the billing system. This event contains the complete invoice data and is triggered after the invoice creation process is completed.

## When It's Triggered

This event is published when:
- A new invoice is created via the `CreateInvoiceCommand`
- The invoice creation process completes successfully
- All invoice validation and business rules have been satisfied

## Event Payload

| Property | Type | Required | Description |
|----------|------|----------|-------------|
| Invoice | `Invoice` | ✓ | Complete invoice object containing all invoice data including items, amounts, customer information, and metadata |

### Invoice Object Structure

The `Invoice` object contains the full invoice entity with all its properties and related data.

## Technical Details

```csharp
// Event Definition
[EventTopic<Invoice>] // [!code highlight]
public sealed record InvoiceCreated(Invoice Invoice) 
    : IntegrationEvent<InvoiceCreated>; // [!code highlight]
```

- **Full Type:** `Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated`
- **Namespace:** `Billing.Invoices.Contracts.IntegrationEvents`
- **Topic Attribute:** `[EventTopic<Invoice>]`
- **Payload Type:** Record with positional parameter
- **Partition Key:** Derived from Invoice entity properties