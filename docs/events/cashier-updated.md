# CashierUpdated

**Status:** Active  
**Version:** v1  
**Topic:** `cashiers`  
**Type:** Integration Event

## Description

Published when an existing cashier is updated in the billing system. This event signals that cashier information has been modified and external systems should refresh their data.

## When It's Triggered

This event is published when:
- A cashier is updated via the `UpdateCashierCommand`
- The update process completes successfully
- Cashier properties are modified and saved

## Event Payload

| Property | Type | Required | Description |
|----------|------|----------|-------------|
| CashierId | `Guid` | ✓ | Unique identifier of the updated cashier |

## Technical Details

- **Full Type:** `Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated`
- **Namespace:** `Billing.Cashiers.Contracts.IntegrationEvents`
- **Topic Attribute:** `[EventTopic<Cashier>]`
- **Payload Type:** Record with positional parameter
- **Partition Key:** Derived from Cashier entity properties