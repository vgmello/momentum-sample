# InvoiceCancelled

**Status:** Active  
**Version:** v1  
**Topic:** `invoices`  
**Type:** Integration Event

## Description

Published when an existing invoice is cancelled in the billing system. This event signals that the invoice is no longer valid and should not be processed for payment.

## When It's Triggered

This event is published when:
- An invoice is cancelled via the `CancelInvoiceCommand`
- The cancellation process completes successfully
- The invoice status is updated to cancelled

## Event Payload

| Property | Type | Required | Description |
|----------|------|----------|-------------|
| InvoiceId | `Guid` | ✓ | Unique identifier of the cancelled invoice |

## Technical Details

- **Full Type:** `Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled`
- **Namespace:** `Billing.Invoices.Contracts.IntegrationEvents`
- **Topic Attribute:** `[EventTopic<Invoice>]`
- **Payload Type:** Record with positional parameter
- **Partition Key:** Derived from Invoice entity properties