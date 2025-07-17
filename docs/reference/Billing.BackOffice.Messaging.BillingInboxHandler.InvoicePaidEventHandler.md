# <a id="Billing_BackOffice_Messaging_BillingInboxHandler_InvoicePaidEventHandler"></a> Class InvoicePaidEventHandler

Namespace: [Billing.BackOffice.Messaging.BillingInboxHandler](Billing.BackOffice.Messaging.BillingInboxHandler.md)  
Assembly: Billing.BackOffice.dll  

```csharp
public static class InvoicePaidEventHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvoicePaidEventHandler](Billing.BackOffice.Messaging.BillingInboxHandler.InvoicePaidEventHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_BackOffice_Messaging_BillingInboxHandler_InvoicePaidEventHandler_Handle_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_Microsoft_Extensions_Logging_ILogger_System_Threading_CancellationToken_"></a> Handle\(InvoicePaid, ILogger, CancellationToken\)

```csharp
public static Task Handle(InvoicePaid @event, ILogger logger, CancellationToken cancellationToken)
```

#### Parameters

`event` [InvoicePaid](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Invoices/Contracts/IntegrationEvents/InvoicePaid.cs)

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

