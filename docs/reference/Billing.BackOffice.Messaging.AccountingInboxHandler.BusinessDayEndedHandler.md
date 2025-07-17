# <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEndedHandler"></a> Class BusinessDayEndedHandler

Namespace: [Billing.BackOffice.Messaging.AccountingInboxHandler](Billing.BackOffice.Messaging.AccountingInboxHandler.md)  
Assembly: Billing.BackOffice.dll  

```csharp
public class BusinessDayEndedHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BusinessDayEndedHandler](Billing.BackOffice.Messaging.AccountingInboxHandler.BusinessDayEndedHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEndedHandler__ctor_Microsoft_Extensions_Logging_ILogger_Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEndedHandler__Wolverine_IMessageBus_"></a> BusinessDayEndedHandler\(ILogger<BusinessDayEndedHandler\>, IMessageBus\)

```csharp
public BusinessDayEndedHandler(ILogger<BusinessDayEndedHandler> logger, IMessageBus messageBus)
```

#### Parameters

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger\-1)<[BusinessDayEndedHandler](Billing.BackOffice.Messaging.AccountingInboxHandler.BusinessDayEndedHandler.md)\>

`messageBus` IMessageBus

## Methods

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEndedHandler_Handle_Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_"></a> Handle\(BusinessDayEnded\)

```csharp
public Task Handle(BusinessDayEnded businessDayEnded)
```

#### Parameters

`businessDayEnded` [BusinessDayEnded](Billing.BackOffice.Messaging.AccountingInboxHandler.BusinessDayEnded.md)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

