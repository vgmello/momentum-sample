// Copyright (c) ABCDEG. All rights reserved.

using Billing.Cashiers.Contracts.Models;

namespace Billing.Cashiers.Contracts.IntegrationEvents;

/// <summary>
///     Published when a new cashier is successfully created in the billing system. This event contains the complete cashier data and partition
///     key information for proper message routing.
/// </summary>
/// <remarks>
///     - The cashier creation process completes successfully <br />
///     - Some other actions
/// </remarks>
[EventTopic<Cashier>]
public record CashierCreated([PartitionKey] Guid TenantId, [PartitionKey] int PartitionKeyTest, Cashier Cashier);
