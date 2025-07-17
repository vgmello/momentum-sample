# <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler"></a> Class DeleteCashierCommandHandler

Namespace: [Billing.Cashiers.Commands](Billing.Cashiers.Commands.md)  
Assembly: Billing.dll  

```csharp
public static class DeleteCashierCommandHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DeleteCashierCommandHandler](Billing.Cashiers.Commands.DeleteCashierCommandHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_Handle_Billing_Cashiers_Commands_DeleteCashierCommand_Wolverine_IMessageBus_System_Threading_CancellationToken_"></a> Handle\(DeleteCashierCommand, IMessageBus, CancellationToken\)

```csharp
public static Task<(Result<bool>, CashierDeleted?)> Handle(DeleteCashierCommand command, IMessageBus messaging, CancellationToken cancellationToken)
```

#### Parameters

`command` [DeleteCashierCommand](Billing.Cashiers.Commands.DeleteCashierCommand.md)

`messaging` IMessageBus

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<\([Result](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions/Result.cs)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>, [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)?\)\>

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_HandleAsync_Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_System_Data_Common_DbDataSource_System_Threading_CancellationToken_"></a> HandleAsync\(DeleteCashierDbCommand, DbDataSource, CancellationToken\)

```csharp
public static Task<int> HandleAsync(DeleteCashierCommandHandler.DeleteCashierDbCommand command, DbDataSource datasource, CancellationToken cancellationToken = default)
```

#### Parameters

`command` [DeleteCashierCommandHandler](Billing.Cashiers.Commands.DeleteCashierCommandHandler.md).[DeleteCashierDbCommand](Billing.Cashiers.Commands.DeleteCashierCommandHandler.DeleteCashierDbCommand.md)

`datasource` [DbDataSource](https://learn.microsoft.com/dotnet/api/system.data.common.dbdatasource)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

