# CashierCreated

**Status:** Active
**Version:** v1
**Topic:** `cashiers`
**Type:** Integration Event

## Description

Published when a new cashier is successfully created in the billing system. This event contains the complete cashier data and partition key information for proper message routing.

## When It's Triggered

This event is published when:

-   The cashier creation process completes successfully

## Event Payload

| Property         | Type      | Required | Description                                                           |
| ---------------- | --------- | -------- | --------------------------------------------------------------------- |
| TenantId         | `Guid`    | ✓        | Identifier of the tenant that owns the cashier (partition key)        |
| PartitionKeyTest | `int`     | ✓        | Additional partition key for message routing (partition key)          |
| Cashier          | `Cashier` | ✓        | Complete cashier object containing all cashier data and configuration |

### Partition Keys

This event uses multiple partition keys for message routing:

-   `TenantId` - Primary partition key based on tenant
-   `PartitionKeyTest` - Secondary partition key for routing optimization

## Technical Details

```csharp
// Event Definition
[EventTopic<Cashier>]
public sealed record CashierCreated(
    [PartitionKey] Guid TenantId,
    [PartitionKey] int PartitionKeyTest,
    Cashier Cashier
) : IntegrationEvent<CashierCreated>;
```

-   **Full Type:** `Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated`
-   **Namespace:** `Billing.Cashiers.Contracts.IntegrationEvents`
-   **Topic Attribute:** `[EventTopic<Cashier>]`
-   **Payload Type:** Record with positional parameters
-   **Partition Keys:** TenantId, PartitionKeyTest (both marked with `[PartitionKey]`)
