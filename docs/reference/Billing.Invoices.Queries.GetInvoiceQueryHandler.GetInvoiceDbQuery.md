# <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery"></a> Class GetInvoiceQueryHandler.GetInvoiceDbQuery

Namespace: [Billing.Invoices.Queries](Billing.Invoices.Queries.md)  
Assembly: Billing.dll  

```csharp
[DbCommand(null, null, "select * from billing.invoices_get_single", DbParamsCase.Unset, false, null)]
public sealed record GetInvoiceQueryHandler.GetInvoiceDbQuery : IQuery<Invoice?>, IDbParamsProvider, IEquatable<GetInvoiceQueryHandler.GetInvoiceDbQuery>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetInvoiceQueryHandler.GetInvoiceDbQuery](Billing.Invoices.Queries.GetInvoiceQueryHandler.GetInvoiceDbQuery.md)

#### Implements

[IQuery<Invoice?\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/IQuery.cs), 
[IDbParamsProvider](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Dapper/IDbParamsProvider.cs), 
[IEquatable<GetInvoiceQueryHandler.GetInvoiceDbQuery\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery__ctor_System_Guid_"></a> GetInvoiceDbQuery\(Guid\)

```csharp
public GetInvoiceDbQuery(Guid InvoiceId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Properties

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Methods

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery__Clone__"></a> <Clone\>$\(\)

```csharp
public GetInvoiceQueryHandler.GetInvoiceDbQuery <Clone>$()
```

#### Returns

 [GetInvoiceQueryHandler](Billing.Invoices.Queries.GetInvoiceQueryHandler.md).[GetInvoiceDbQuery](Billing.Invoices.Queries.GetInvoiceQueryHandler.GetInvoiceDbQuery.md)

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid InvoiceId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_Equals_Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_"></a> Equals\(GetInvoiceDbQuery?\)

```csharp
public bool Equals(GetInvoiceQueryHandler.GetInvoiceDbQuery? other)
```

#### Parameters

`other` [GetInvoiceQueryHandler](Billing.Invoices.Queries.GetInvoiceQueryHandler.md).[GetInvoiceDbQuery](Billing.Invoices.Queries.GetInvoiceQueryHandler.GetInvoiceDbQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_ToDbParams"></a> ToDbParams\(\)

```csharp
public object ToDbParams()
```

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_op_Equality_Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_"></a> operator ==\(GetInvoiceDbQuery?, GetInvoiceDbQuery?\)

```csharp
public static bool operator ==(GetInvoiceQueryHandler.GetInvoiceDbQuery? left, GetInvoiceQueryHandler.GetInvoiceDbQuery? right)
```

#### Parameters

`left` [GetInvoiceQueryHandler](Billing.Invoices.Queries.GetInvoiceQueryHandler.md).[GetInvoiceDbQuery](Billing.Invoices.Queries.GetInvoiceQueryHandler.GetInvoiceDbQuery.md)?

`right` [GetInvoiceQueryHandler](Billing.Invoices.Queries.GetInvoiceQueryHandler.md).[GetInvoiceDbQuery](Billing.Invoices.Queries.GetInvoiceQueryHandler.GetInvoiceDbQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_op_Inequality_Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_Billing_Invoices_Queries_GetInvoiceQueryHandler_GetInvoiceDbQuery_"></a> operator \!=\(GetInvoiceDbQuery?, GetInvoiceDbQuery?\)

```csharp
public static bool operator !=(GetInvoiceQueryHandler.GetInvoiceDbQuery? left, GetInvoiceQueryHandler.GetInvoiceDbQuery? right)
```

#### Parameters

`left` [GetInvoiceQueryHandler](Billing.Invoices.Queries.GetInvoiceQueryHandler.md).[GetInvoiceDbQuery](Billing.Invoices.Queries.GetInvoiceQueryHandler.GetInvoiceDbQuery.md)?

`right` [GetInvoiceQueryHandler](Billing.Invoices.Queries.GetInvoiceQueryHandler.md).[GetInvoiceDbQuery](Billing.Invoices.Queries.GetInvoiceQueryHandler.GetInvoiceDbQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

