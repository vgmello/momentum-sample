# InvoicePaid

**Status:** Active  
**Version:** v1  
**Topic:** `invoices`  
**Type:** Integration Event

## Description

Published when an invoice is successfully marked as paid in the billing system. This event confirms that payment has been received and processed for the specified invoice.

## When It's Triggered

This event is published when:
- An invoice is marked as paid via the `MarkInvoiceAsPaidCommand`
- Payment processing completes successfully
- The invoice status is updated to reflect the paid status

## Event Payload

| Property | Type | Required | Description |
|----------|------|----------|-------------|
| TenantId | `string` | ✓ | Identifier of the tenant that owns the invoice |
| InvoiceId | `Guid` | ✓ | Unique identifier of the paid invoice |
| CustomerId | `Guid` | ✓ | Unique identifier of the customer who made the payment |
| AmountPaid | `decimal` | ✓ | Amount that was paid for this invoice |
| PaymentDate | `DateTime` | ✓ | Date and time when the payment was processed |

## Technical Details

- **Full Type:** `Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid`
- **Namespace:** `Billing.Invoices.Contracts.IntegrationEvents`
- **Topic Attribute:** `[EventTopic<Invoice>]`
- **Payload Type:** Record with property initializers
- **Partition Key:** Derived from Invoice entity properties