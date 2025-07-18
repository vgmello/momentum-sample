# InvoiceGenerated

**Status:** Active
**Version:** v1
**Topic:** 
**Type:** Domain Event

## Description

Internal domain event triggered when an invoice is generated within the billing domain. This event is used for coordinating internal domain logic and workflows, and is not published to external systems.

## When It's Triggered

This event is published when:
- The `BusinessDayEndedHandler` processes end-of-day operations
- An invoice generation process completes successfully
- Internal domain workflows need to be notified of invoice generation

## Event Payload

| Property | Type | Required | Description |
|----------|------|----------|-------------|
| InvoiceId | `Guid` | ✓ | Unique identifier of the generated invoice |
| InvoiceAmount | `decimal` | ✓ | Total amount of the generated invoice |

## Usage

This domain event is handled internally by:
- `InvoiceGeneratedHandler` for domain-specific processing
- Other domain services that need to react to invoice generation

## Technical Details

- **Full Type:** `Billing.Invoices.Contracts.DomainEvents.InvoiceGenerated`
- **Namespace:** `Billing.Invoices.Contracts.DomainEvents`
- **Topic Attribute:** None (domain events don't use EventTopic)
- **Payload Type:** Record with positional parameters
- **Scope:** Internal to billing domain only
