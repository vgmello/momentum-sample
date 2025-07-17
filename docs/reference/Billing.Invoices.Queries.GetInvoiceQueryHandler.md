# <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler"></a> Class GetInvoiceQueryHandler

Namespace: [Billing.Invoices.Queries](Billing.Invoices.Queries.md)  
Assembly: Billing.dll  

```csharp
public static class GetInvoiceQueryHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetInvoiceQueryHandler](Billing.Invoices.Queries.GetInvoiceQueryHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_Handle_Billing_Invoices_Queries_GetInvoiceQuery_Wolverine_IMessageBus_System_Threading_CancellationToken_"></a> Handle\(GetInvoiceQuery, IMessageBus, CancellationToken\)

```csharp
public static Task<Result<Invoice>> Handle(GetInvoiceQuery query, IMessageBus messaging, CancellationToken cancellationToken)
```

#### Parameters

`query` [GetInvoiceQuery](Billing.Invoices.Queries.GetInvoiceQuery.md)

`messaging` IMessageBus

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Result](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions/Result.cs)<[Invoice](Billing.Invoices.Contracts.Models.Invoice.md)\>\>

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_HandleAsync_Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_System_Data_Common_DbDataSource_System_Threading_CancellationToken_"></a> HandleAsync\(GetInvoiceDbQuery, DbDataSource, CancellationToken\)

```csharp
public static Task<Invoice?> HandleAsync(GetInvoiceQueryHandler.GetInvoiceDbQuery command, DbDataSource datasource, CancellationToken cancellationToken = default)
```

#### Parameters

`command` [GetInvoiceQueryHandler](Billing.Invoices.Queries.GetInvoiceQueryHandler.md).[GetInvoiceDbQuery](Billing.Invoices.Queries.GetInvoiceQueryHandler.GetInvoiceDbQuery.md)

`datasource` [DbDataSource](https://learn.microsoft.com/dotnet/api/system.data.common.dbdatasource)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Invoice](Billing.Invoices.Contracts.Models.Invoice.md)?\>

