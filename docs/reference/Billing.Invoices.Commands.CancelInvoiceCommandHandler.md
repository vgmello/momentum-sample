# <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler"></a> Class CancelInvoiceCommandHandler

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public static class CancelInvoiceCommandHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CancelInvoiceCommandHandler](Billing.Invoices.Commands.CancelInvoiceCommandHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_Handle_Billing_Invoices_Commands_CancelInvoiceCommand_Wolverine_IMessageBus_System_Threading_CancellationToken_"></a> Handle\(CancelInvoiceCommand, IMessageBus, CancellationToken\)

```csharp
public static Task<(Result<Invoice>, InvoiceCancelled?)> Handle(CancelInvoiceCommand command, IMessageBus messaging, CancellationToken cancellationToken)
```

#### Parameters

`command` [CancelInvoiceCommand](Billing.Invoices.Commands.CancelInvoiceCommand.md)

`messaging` IMessageBus

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<\([Result](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions/Result.cs)<[Invoice](Billing.Invoices.Contracts.Models.Invoice.md)\>, [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)?\)\>

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_HandleAsync_Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_System_Data_Common_DbDataSource_System_Threading_CancellationToken_"></a> HandleAsync\(CancelInvoiceDbCommand, DbDataSource, CancellationToken\)

```csharp
public static Task<int> HandleAsync(CancelInvoiceCommandHandler.CancelInvoiceDbCommand command, DbDataSource datasource, CancellationToken cancellationToken = default)
```

#### Parameters

`command` [CancelInvoiceCommandHandler](Billing.Invoices.Commands.CancelInvoiceCommandHandler.md).[CancelInvoiceDbCommand](Billing.Invoices.Commands.CancelInvoiceCommandHandler.CancelInvoiceDbCommand.md)

`datasource` [DbDataSource](https://learn.microsoft.com/dotnet/api/system.data.common.dbdatasource)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

