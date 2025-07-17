# CashierDeleted

**Status:** Active  
**Version:** v1  
**Topic:** `cashiers`  
**Type:** Integration Event

## Description

Published when a cashier is deleted from the billing system. This event notifies external systems that the cashier is no longer available and should be removed from their records.

## When It's Triggered

This event is published when:
- A cashier is deleted via the `DeleteCashierCommand`
- The deletion process completes successfully
- The cashier is removed from the system

## Event Payload

| Property | Type | Required | Description |
|----------|------|----------|-------------|
| CashierId | `Guid` | ✓ | Unique identifier of the deleted cashier |

## Technical Details

- **Full Type:** `Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted`
- **Namespace:** `Billing.Cashiers.Contracts.IntegrationEvents`
- **Topic Attribute:** `[EventTopic<Cashier>]`
- **Payload Type:** Record with positional parameter
- **Partition Key:** Derived from Cashier entity properties