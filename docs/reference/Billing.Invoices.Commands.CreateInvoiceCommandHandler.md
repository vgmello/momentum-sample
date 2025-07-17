# <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler"></a> Class CreateInvoiceCommandHandler

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public static class CreateInvoiceCommandHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CreateInvoiceCommandHandler](Billing.Invoices.Commands.CreateInvoiceCommandHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_Handle_Billing_Invoices_Commands_CreateInvoiceCommand_Wolverine_IMessageBus_System_Threading_CancellationToken_"></a> Handle\(CreateInvoiceCommand, IMessageBus, CancellationToken\)

```csharp
public static Task<(Result<Invoice>, InvoiceCreated)> Handle(CreateInvoiceCommand command, IMessageBus messaging, CancellationToken cancellationToken)
```

#### Parameters

`command` [CreateInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommand.md)

`messaging` IMessageBus

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<\([Result](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions/Result.cs)<[Invoice](Billing.Invoices.Contracts.Models.Invoice.md)\>, [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)\)\>

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_HandleAsync_Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_System_Data_Common_DbDataSource_System_Threading_CancellationToken_"></a> HandleAsync\(InsertInvoiceCommand, DbDataSource, CancellationToken\)

```csharp
public static Task<int> HandleAsync(CreateInvoiceCommandHandler.InsertInvoiceCommand command, DbDataSource datasource, CancellationToken cancellationToken = default)
```

#### Parameters

`command` [CreateInvoiceCommandHandler](Billing.Invoices.Commands.CreateInvoiceCommandHandler.md).[InsertInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommandHandler.InsertInvoiceCommand.md)

`datasource` [DbDataSource](https://learn.microsoft.com/dotnet/api/system.data.common.dbdatasource)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

