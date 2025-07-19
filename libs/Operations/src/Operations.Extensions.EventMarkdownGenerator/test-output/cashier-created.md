# CashierCreated

**Status:** Active
**Version:** v1
**Topic:** `cashiers`
**Type:** Integration Event

## Description

Published when a new cashier is successfully created in the billing system. This event contains the complete cashier data and partition key information for proper message routing.

## When It's Triggered

This event is published when

## Some other event data

Some other event data text

## Event Payload

| Property | Type | Required | Description |
| -------- | ---- | -------- | ----------- |
| TenantId | `Guid` | ✓ | No description available (partition key) |
| PartitionKeyTest | `int` | ✓ | No description available (partition key) |
| Cashier | `Cashier` | ✓ | No description available |

### Partition Keys

This event uses multiple partition keys for message routing:

- `TenantId` - Used for message routing
- `PartitionKeyTest` - Used for message routing

## Technical Details

```csharp
// Event Definition
[EventTopic]
public sealed record CashierCreated(
    [PartitionKey] Guid TenantId,
    [PartitionKey] int PartitionKeyTest,
    Cashier Cashier
);
```

- **Full Type:** `Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated`
- **Namespace:** `Billing.Cashiers.Contracts.IntegrationEvents`
- **Topic Attribute:** `[EventTopic]` or `[EventTopic<T>]`
- **Payload Type:** Record with positional parameters
- **Partition Keys:** TenantId, PartitionKeyTest (marked with `[PartitionKey]`)

