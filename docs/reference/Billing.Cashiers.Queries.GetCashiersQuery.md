# <a id="Billing_Cashiers_Queries_GetCashiersQuery"></a> Class GetCashiersQuery

Namespace: [Billing.Cashiers.Queries](Billing.Cashiers.Queries.md)  
Assembly: Billing.dll  

```csharp
public record GetCashiersQuery : IQuery<IEnumerable<GetCashiersQuery.Result>>, IEquatable<GetCashiersQuery>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md)

#### Implements

[IQuery<IEnumerable<GetCashiersQuery.Result\>\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/IQuery.cs), 
[IEquatable<GetCashiersQuery\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Queries_GetCashiersQuery__ctor_Billing_Cashiers_Queries_GetCashiersQuery_"></a> GetCashiersQuery\(GetCashiersQuery\)

```csharp
protected GetCashiersQuery(GetCashiersQuery original)
```

#### Parameters

`original` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery__ctor"></a> GetCashiersQuery\(\)

```csharp
public GetCashiersQuery()
```

## Properties

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Limit"></a> Limit

```csharp
[Range(1, 1000)]
public int Limit { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Offset"></a> Offset

```csharp
[Range(0, 2147483647)]
public int Offset { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Billing_Cashiers_Queries_GetCashiersQuery__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual GetCashiersQuery <Clone>$()
```

#### Returns

 [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Equals_Billing_Cashiers_Queries_GetCashiersQuery_"></a> Equals\(GetCashiersQuery?\)

```csharp
public virtual bool Equals(GetCashiersQuery? other)
```

#### Parameters

`other` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_op_Equality_Billing_Cashiers_Queries_GetCashiersQuery_Billing_Cashiers_Queries_GetCashiersQuery_"></a> operator ==\(GetCashiersQuery?, GetCashiersQuery?\)

```csharp
public static bool operator ==(GetCashiersQuery? left, GetCashiersQuery? right)
```

#### Parameters

`left` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md)?

`right` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_op_Inequality_Billing_Cashiers_Queries_GetCashiersQuery_Billing_Cashiers_Queries_GetCashiersQuery_"></a> operator \!=\(GetCashiersQuery?, GetCashiersQuery?\)

```csharp
public static bool operator !=(GetCashiersQuery? left, GetCashiersQuery? right)
```

#### Parameters

`left` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md)?

`right` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

