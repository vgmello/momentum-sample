# <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler"></a> Class MarkInvoiceAsPaidCommandHandler

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public static class MarkInvoiceAsPaidCommandHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MarkInvoiceAsPaidCommandHandler](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_Handle_Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_Wolverine_IMessageBus_System_Threading_CancellationToken_"></a> Handle\(MarkInvoiceAsPaidCommand, IMessageBus, CancellationToken\)

```csharp
public static Task<(Result<Invoice>, InvoicePaid?)> Handle(MarkInvoiceAsPaidCommand command, IMessageBus messaging, CancellationToken cancellationToken)
```

#### Parameters

`command` [MarkInvoiceAsPaidCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommand.md)

`messaging` IMessageBus

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<\([Result](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions/Result.cs)<[Invoice](Billing.Invoices.Contracts.Models.Invoice.md)\>, [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)?\)\>

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_HandleAsync_Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_System_Data_Common_DbDataSource_System_Threading_CancellationToken_"></a> HandleAsync\(MarkInvoiceAsPaidDbCommand, DbDataSource, CancellationToken\)

```csharp
public static Task<int> HandleAsync(MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand command, DbDataSource datasource, CancellationToken cancellationToken = default)
```

#### Parameters

`command` [MarkInvoiceAsPaidCommandHandler](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.md).[MarkInvoiceAsPaidDbCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand.md)

`datasource` [DbDataSource](https://learn.microsoft.com/dotnet/api/system.data.common.dbdatasource)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

