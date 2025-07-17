# <a id="Billing_Cashiers_Queries_GetCashierQueryHandler"></a> Class GetCashierQueryHandler

Namespace: [Billing.Cashiers.Queries](Billing.Cashiers.Queries.md)  
Assembly: Billing.dll  

```csharp
public static class GetCashierQueryHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetCashierQueryHandler](Billing.Cashiers.Queries.GetCashierQueryHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_Cashiers_Queries_GetCashierQueryHandler_Handle_Billing_Cashiers_Queries_GetCashierQuery_Npgsql_NpgsqlDataSource_System_Threading_CancellationToken_"></a> Handle\(GetCashierQuery, NpgsqlDataSource, CancellationToken\)

```csharp
public static Task<Cashier> Handle(GetCashierQuery query, NpgsqlDataSource dataSource, CancellationToken cancellationToken)
```

#### Parameters

`query` [GetCashierQuery](Billing.Cashiers.Queries.GetCashierQuery.md)

`dataSource` NpgsqlDataSource

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)\>

