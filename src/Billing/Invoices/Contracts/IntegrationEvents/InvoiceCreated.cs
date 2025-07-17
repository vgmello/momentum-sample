// Copyright (c) ABCDEG. All rights reserved.

using Billing.Invoices.Contracts.Models;
using Operations.Extensions.Abstractions.Messaging;

namespace Billing.Invoices.Contracts.IntegrationEvents;

[EventTopic<Invoice>]
public record InvoiceCreated(Invoice Invoice);
