# InvoiceFinalized

**Status:** Active  
**Version:** v1  
**Topic:** `invoices`  
**Type:** Integration Event

## Description

Published when an invoice is finalized during the business day end processing. This event indicates that the invoice has been processed and is ready for external systems to handle payment collection or accounting operations.

## When It's Triggered

This event is published when:
- The `BusinessDayEndedHandler` processes end-of-day operations
- An invoice reaches its finalization criteria
- All business rules for invoice finalization are satisfied

## Event Payload

| Property | Type | Required | Description |
|----------|------|----------|-------------|
| TenantId | `string` | ✓ | Identifier of the tenant that owns the invoice |
| InvoiceId | `Guid` | ✓ | Unique identifier of the finalized invoice |
| CustomerId | `Guid` | ✓ | Unique identifier of the customer associated with the invoice |
| PublicInvoiceNumber | `string` | ✓ | Public-facing invoice number for customer reference |
| FinalTotalAmount | `decimal` | ✓ | Final total amount of the invoice after all calculations |

## Technical Details

- **Full Type:** `Billing.Invoices.Contracts.IntegrationEvents.InvoiceFinalized`
- **Namespace:** `Billing.Invoices.Contracts.IntegrationEvents`
- **Topic Attribute:** `[EventTopic<Invoice>]`
- **Payload Type:** Class with properties
- **Partition Key:** Derived from Invoice entity properties