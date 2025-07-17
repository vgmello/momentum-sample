# <a id="Billing_Invoices_Queries_GetInvoicesQuery"></a> Class GetInvoicesQuery

Namespace: [Billing.Invoices.Queries](Billing.Invoices.Queries.md)  
Assembly: Billing.dll  

```csharp
public record GetInvoicesQuery : IQuery<IEnumerable<Invoice>>, IEquatable<GetInvoicesQuery>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetInvoicesQuery](Billing.Invoices.Queries.GetInvoicesQuery.md)

#### Implements

[IQuery<IEnumerable<Invoice\>\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/IQuery.cs), 
[IEquatable<GetInvoicesQuery\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Queries_GetInvoicesQuery__ctor_System_Int32_System_Int32_System_String_"></a> GetInvoicesQuery\(int, int, string?\)

```csharp
public GetInvoicesQuery(int Limit = 50, int Offset = 0, string? Status = null)
```

#### Parameters

`Limit` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Offset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Status` [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Invoices_Queries_GetInvoicesQuery__ctor_Billing_Invoices_Queries_GetInvoicesQuery_"></a> GetInvoicesQuery\(GetInvoicesQuery\)

```csharp
protected GetInvoicesQuery(GetInvoicesQuery original)
```

#### Parameters

`original` [GetInvoicesQuery](Billing.Invoices.Queries.GetInvoicesQuery.md)

## Properties

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_Limit"></a> Limit

```csharp
public int Limit { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_Offset"></a> Offset

```csharp
public int Offset { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_Status"></a> Status

```csharp
public string? Status { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Methods

### <a id="Billing_Invoices_Queries_GetInvoicesQuery__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual GetInvoicesQuery <Clone>$()
```

#### Returns

 [GetInvoicesQuery](Billing.Invoices.Queries.GetInvoicesQuery.md)

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_Deconstruct_System_Int32__System_Int32__System_String__"></a> Deconstruct\(out int, out int, out string?\)

```csharp
public void Deconstruct(out int Limit, out int Offset, out string? Status)
```

#### Parameters

`Limit` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Offset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Status` [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_Equals_Billing_Invoices_Queries_GetInvoicesQuery_"></a> Equals\(GetInvoicesQuery?\)

```csharp
public virtual bool Equals(GetInvoicesQuery? other)
```

#### Parameters

`other` [GetInvoicesQuery](Billing.Invoices.Queries.GetInvoicesQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_op_Equality_Billing_Invoices_Queries_GetInvoicesQuery_Billing_Invoices_Queries_GetInvoicesQuery_"></a> operator ==\(GetInvoicesQuery?, GetInvoicesQuery?\)

```csharp
public static bool operator ==(GetInvoicesQuery? left, GetInvoicesQuery? right)
```

#### Parameters

`left` [GetInvoicesQuery](Billing.Invoices.Queries.GetInvoicesQuery.md)?

`right` [GetInvoicesQuery](Billing.Invoices.Queries.GetInvoicesQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Queries_GetInvoicesQuery_op_Inequality_Billing_Invoices_Queries_GetInvoicesQuery_Billing_Invoices_Queries_GetInvoicesQuery_"></a> operator \!=\(GetInvoicesQuery?, GetInvoicesQuery?\)

```csharp
public static bool operator !=(GetInvoicesQuery? left, GetInvoicesQuery? right)
```

#### Parameters

`left` [GetInvoicesQuery](Billing.Invoices.Queries.GetInvoicesQuery.md)?

`right` [GetInvoicesQuery](Billing.Invoices.Queries.GetInvoicesQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

