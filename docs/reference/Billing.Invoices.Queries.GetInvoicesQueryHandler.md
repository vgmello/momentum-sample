# <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler"></a> Class GetInvoicesQueryHandler

Namespace: [Billing.Invoices.Queries](Billing.Invoices.Queries.md)  
Assembly: Billing.dll  

```csharp
public static class GetInvoicesQueryHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetInvoicesQueryHandler](Billing.Invoices.Queries.GetInvoicesQueryHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_Handle_Billing_Invoices_Queries_GetInvoicesQuery_Wolverine_IMessageBus_System_Threading_CancellationToken_"></a> Handle\(GetInvoicesQuery, IMessageBus, CancellationToken\)

```csharp
public static Task<IEnumerable<Invoice>> Handle(GetInvoicesQuery query, IMessageBus messaging, CancellationToken cancellationToken)
```

#### Parameters

`query` [GetInvoicesQuery](Billing.Invoices.Queries.GetInvoicesQuery.md)

`messaging` IMessageBus

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Invoice](Billing.Invoices.Contracts.Models.Invoice.md)\>\>

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_HandleAsync_Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_System_Data_Common_DbDataSource_System_Threading_CancellationToken_"></a> HandleAsync\(GetInvoicesDbQuery, DbDataSource, CancellationToken\)

```csharp
public static Task<IEnumerable<Invoice>> HandleAsync(GetInvoicesQueryHandler.GetInvoicesDbQuery command, DbDataSource datasource, CancellationToken cancellationToken = default)
```

#### Parameters

`command` [GetInvoicesQueryHandler](Billing.Invoices.Queries.GetInvoicesQueryHandler.md).[GetInvoicesDbQuery](Billing.Invoices.Queries.GetInvoicesQueryHandler.GetInvoicesDbQuery.md)

`datasource` [DbDataSource](https://learn.microsoft.com/dotnet/api/system.data.common.dbdatasource)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Invoice](Billing.Invoices.Contracts.Models.Invoice.md)\>\>

