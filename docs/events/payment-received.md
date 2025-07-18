# PaymentReceived

**Status:** Active  
**Version:** v1  
**Topic:** `payment-received`  
**Type:** Integration Event

## Description

Published when a payment is received and processed in the billing system. This event contains detailed payment information and is used to trigger invoice payment processing workflows.

## When It's Triggered

This event is published when:
- A payment is simulated via the `SimulatePaymentCommand`
- Payment processing completes successfully
- Payment details are validated and recorded in the system

## Event Payload

| Property | Type | Required | Description |
|----------|------|----------|-------------|
| InvoiceId | `Guid` | ✓ | Unique identifier of the invoice this payment is for |
| Amount | `decimal` | ✓ | Amount of the payment received |
| Currency | `string` | ✓ | Currency code of the payment (e.g., USD, EUR) |
| PaymentMethod | `string` | ✓ | Method used for payment (e.g., credit card, bank transfer) |
| PaymentReference | `string` | ✓ | External reference or transaction ID for the payment |
| ReceivedDate | `DateTime` | ✓ | Date and time when the payment was received |

## Technical Details

- **Full Type:** `Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived`
- **Namespace:** `Billing.Invoices.Contracts.IntegrationEvents`
- **Topic Attribute:** `[EventTopic("payment-received")]`
- **Payload Type:** Record with positional parameters
- **Partition Key:** Derived from event properties