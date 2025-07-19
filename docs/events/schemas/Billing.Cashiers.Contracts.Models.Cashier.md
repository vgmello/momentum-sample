---
editLink: false
---

# Cashier

## Description

Published when a new cashier is successfully created in the billing system. This event contains the complete cashier data and partition key information for proper message routing.

## Schema

<!-- #region schema -->

| Property                                                                           | Type                   | Required | Description                                                                |
| ---------------------------------------------------------------------------------- | ---------------------- | -------- | -------------------------------------------------------------------------- |
| `TenantId`                                                                         | `Guid`                 |          | Gets or sets the unique identifier for the tenant this cashier belongs to. |
| `CashierId`                                                                        | `Guid`                 |          | Gets or sets the unique identifier for the cashier.                        |
| `Name`                                                                             | `string`               | ✓        | Gets or sets the name of the cashier.                                      |
| `Email`                                                                            | `string`               | ✓        | Gets or sets the email address of the cashier.                             |
| [`CashierPayments`](./schemas/Billing.Cashiers.Contracts.Models.CashierPayment.md) | `List<CashierPayment>` |          | Gets or sets the list of payment methods associated with this cashier.     |

<!-- #endregion schema -->

### Reference Schemas

#### Cashier Payment

<!--@include: ./schemas/Billing.Cashiers.Contracts.Models.CashierPayment.md#schema-->
