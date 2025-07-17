# <a id="Billing_Cashiers_Queries_GetCashiersQueryHandler"></a> Class GetCashiersQueryHandler

Namespace: [Billing.Cashiers.Queries](Billing.Cashiers.Queries.md)  
Assembly: Billing.dll  

```csharp
public static class GetCashiersQueryHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetCashiersQueryHandler](Billing.Cashiers.Queries.GetCashiersQueryHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_Cashiers_Queries_GetCashiersQueryHandler_Handle_Billing_Cashiers_Queries_GetCashiersQuery_Npgsql_NpgsqlDataSource_System_Threading_CancellationToken_"></a> Handle\(GetCashiersQuery, NpgsqlDataSource, CancellationToken\)

```csharp
public static Task<IEnumerable<GetCashiersQuery.Result>> Handle(GetCashiersQuery query, NpgsqlDataSource dataSource, CancellationToken cancellationToken)
```

#### Parameters

`query` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md)

`dataSource` NpgsqlDataSource

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md).[Result](Billing.Cashiers.Queries.GetCashiersQuery.Result.md)\>\>

