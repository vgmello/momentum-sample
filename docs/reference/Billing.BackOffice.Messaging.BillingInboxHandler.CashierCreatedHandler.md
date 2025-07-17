# <a id="Billing_BackOffice_Messaging_BillingInboxHandler_CashierCreatedHandler"></a> Class CashierCreatedHandler

Namespace: [Billing.BackOffice.Messaging.BillingInboxHandler](Billing.BackOffice.Messaging.BillingInboxHandler.md)  
Assembly: Billing.BackOffice.dll  

```csharp
public static class CashierCreatedHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CashierCreatedHandler](Billing.BackOffice.Messaging.BillingInboxHandler.CashierCreatedHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_BackOffice_Messaging_BillingInboxHandler_CashierCreatedHandler_Handle_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Microsoft_Extensions_Logging_ILogger_Wolverine_IMessageBus_System_Threading_CancellationToken_"></a> Handle\(CashierCreated, ILogger, IMessageBus, CancellationToken\)

```csharp
public static Task Handle(CashierCreated @event, ILogger logger, IMessageBus messaging, CancellationToken cancellationToken)
```

#### Parameters

`event` [CashierCreated](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Contracts/IntegrationEvents/CashierCreated.cs)

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger)

`messaging` IMessageBus

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

