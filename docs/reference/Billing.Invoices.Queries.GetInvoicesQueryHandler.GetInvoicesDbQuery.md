# <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery"></a> Class GetInvoicesQueryHandler.GetInvoicesDbQuery

Namespace: [Billing.Invoices.Queries](Billing.Invoices.Queries.md)  
Assembly: Billing.dll  

```csharp
[DbCommand(null, null, "select * from billing.invoices_get", DbParamsCase.Unset, false, null)]
public sealed record GetInvoicesQueryHandler.GetInvoicesDbQuery : IQuery<IEnumerable<Invoice>>, IDbParamsProvider, IEquatable<GetInvoicesQueryHandler.GetInvoicesDbQuery>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetInvoicesQueryHandler.GetInvoicesDbQuery](Billing.Invoices.Queries.GetInvoicesQueryHandler.GetInvoicesDbQuery.md)

#### Implements

[IQuery<IEnumerable<Invoice\>\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/IQuery.cs), 
[IDbParamsProvider](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Dapper/IDbParamsProvider.cs), 
[IEquatable<GetInvoicesQueryHandler.GetInvoicesDbQuery\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery__ctor_System_Int32_System_Int32_System_String_"></a> GetInvoicesDbQuery\(int, int, string?\)

```csharp
public GetInvoicesDbQuery(int Limit, int Offset, string? Status)
```

#### Parameters

`Limit` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Offset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Status` [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Properties

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_Limit"></a> Limit

```csharp
public int Limit { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_Offset"></a> Offset

```csharp
public int Offset { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_Status"></a> Status

```csharp
public string? Status { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Methods

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery__Clone__"></a> <Clone\>$\(\)

```csharp
public GetInvoicesQueryHandler.GetInvoicesDbQuery <Clone>$()
```

#### Returns

 [GetInvoicesQueryHandler](Billing.Invoices.Queries.GetInvoicesQueryHandler.md).[GetInvoicesDbQuery](Billing.Invoices.Queries.GetInvoicesQueryHandler.GetInvoicesDbQuery.md)

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_Deconstruct_System_Int32__System_Int32__System_String__"></a> Deconstruct\(out int, out int, out string?\)

```csharp
public void Deconstruct(out int Limit, out int Offset, out string? Status)
```

#### Parameters

`Limit` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Offset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Status` [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_Equals_Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_"></a> Equals\(GetInvoicesDbQuery?\)

```csharp
public bool Equals(GetInvoicesQueryHandler.GetInvoicesDbQuery? other)
```

#### Parameters

`other` [GetInvoicesQueryHandler](Billing.Invoices.Queries.GetInvoicesQueryHandler.md).[GetInvoicesDbQuery](Billing.Invoices.Queries.GetInvoicesQueryHandler.GetInvoicesDbQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_ToDbParams"></a> ToDbParams\(\)

```csharp
public object ToDbParams()
```

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_op_Equality_Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_"></a> operator ==\(GetInvoicesDbQuery?, GetInvoicesDbQuery?\)

```csharp
public static bool operator ==(GetInvoicesQueryHandler.GetInvoicesDbQuery? left, GetInvoicesQueryHandler.GetInvoicesDbQuery? right)
```

#### Parameters

`left` [GetInvoicesQueryHandler](Billing.Invoices.Queries.GetInvoicesQueryHandler.md).[GetInvoicesDbQuery](Billing.Invoices.Queries.GetInvoicesQueryHandler.GetInvoicesDbQuery.md)?

`right` [GetInvoicesQueryHandler](Billing.Invoices.Queries.GetInvoicesQueryHandler.md).[GetInvoicesDbQuery](Billing.Invoices.Queries.GetInvoicesQueryHandler.GetInvoicesDbQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_op_Inequality_Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_Billing_Invoices_Queries_GetInvoicesQueryHandler_GetInvoicesDbQuery_"></a> operator \!=\(GetInvoicesDbQuery?, GetInvoicesDbQuery?\)

```csharp
public static bool operator !=(GetInvoicesQueryHandler.GetInvoicesDbQuery? left, GetInvoicesQueryHandler.GetInvoicesDbQuery? right)
```

#### Parameters

`left` [GetInvoicesQueryHandler](Billing.Invoices.Queries.GetInvoicesQueryHandler.md).[GetInvoicesDbQuery](Billing.Invoices.Queries.GetInvoicesQueryHandler.GetInvoicesDbQuery.md)?

`right` [GetInvoicesQueryHandler](Billing.Invoices.Queries.GetInvoicesQueryHandler.md).[GetInvoicesDbQuery](Billing.Invoices.Queries.GetInvoicesQueryHandler.GetInvoicesDbQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

