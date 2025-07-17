# <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler"></a> Class UpdateCashierCommandHandler

Namespace: [Billing.Cashiers.Commands](Billing.Cashiers.Commands.md)  
Assembly: Billing.dll  

```csharp
public static class UpdateCashierCommandHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UpdateCashierCommandHandler](Billing.Cashiers.Commands.UpdateCashierCommandHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_Handle_Billing_Cashiers_Commands_UpdateCashierCommand_Wolverine_IMessageBus_System_Threading_CancellationToken_"></a> Handle\(UpdateCashierCommand, IMessageBus, CancellationToken\)

```csharp
public static Task<(Result<Cashier>, CashierUpdated?)> Handle(UpdateCashierCommand command, IMessageBus messaging, CancellationToken cancellationToken)
```

#### Parameters

`command` [UpdateCashierCommand](Billing.Cashiers.Commands.UpdateCashierCommand.md)

`messaging` IMessageBus

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<\([Result](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions/Result.cs)<[Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)\>, [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)?\)\>

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_HandleAsync_Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_System_Data_Common_DbDataSource_System_Threading_CancellationToken_"></a> HandleAsync\(UpdateCashierDbCommand, DbDataSource, CancellationToken\)

```csharp
public static Task<int> HandleAsync(UpdateCashierCommandHandler.UpdateCashierDbCommand command, DbDataSource datasource, CancellationToken cancellationToken = default)
```

#### Parameters

`command` [UpdateCashierCommandHandler](Billing.Cashiers.Commands.UpdateCashierCommandHandler.md).[UpdateCashierDbCommand](Billing.Cashiers.Commands.UpdateCashierCommandHandler.UpdateCashierDbCommand.md)

`datasource` [DbDataSource](https://learn.microsoft.com/dotnet/api/system.data.common.dbdatasource)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

