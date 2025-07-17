# <a id="Billing_Cashiers_Queries_GetCashierQuery"></a> Class GetCashierQuery

Namespace: [Billing.Cashiers.Queries](Billing.Cashiers.Queries.md)  
Assembly: Billing.dll  

```csharp
public record GetCashierQuery : IQuery<Cashier>, IEquatable<GetCashierQuery>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetCashierQuery](Billing.Cashiers.Queries.GetCashierQuery.md)

#### Implements

[IQuery<Cashier\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/IQuery.cs), 
[IEquatable<GetCashierQuery\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Queries_GetCashierQuery__ctor_System_Guid_"></a> GetCashierQuery\(Guid\)

```csharp
public GetCashierQuery(Guid Id)
```

#### Parameters

`Id` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Queries_GetCashierQuery__ctor_Billing_Cashiers_Queries_GetCashierQuery_"></a> GetCashierQuery\(GetCashierQuery\)

```csharp
protected GetCashierQuery(GetCashierQuery original)
```

#### Parameters

`original` [GetCashierQuery](Billing.Cashiers.Queries.GetCashierQuery.md)

## Properties

### <a id="Billing_Cashiers_Queries_GetCashierQuery_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Queries_GetCashierQuery_Id"></a> Id

```csharp
public Guid Id { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Methods

### <a id="Billing_Cashiers_Queries_GetCashierQuery__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual GetCashierQuery <Clone>$()
```

#### Returns

 [GetCashierQuery](Billing.Cashiers.Queries.GetCashierQuery.md)

### <a id="Billing_Cashiers_Queries_GetCashierQuery_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid Id)
```

#### Parameters

`Id` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Queries_GetCashierQuery_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashierQuery_Equals_Billing_Cashiers_Queries_GetCashierQuery_"></a> Equals\(GetCashierQuery?\)

```csharp
public virtual bool Equals(GetCashierQuery? other)
```

#### Parameters

`other` [GetCashierQuery](Billing.Cashiers.Queries.GetCashierQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashierQuery_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Queries_GetCashierQuery_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashierQuery_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Queries_GetCashierQuery_op_Equality_Billing_Cashiers_Queries_GetCashierQuery_Billing_Cashiers_Queries_GetCashierQuery_"></a> operator ==\(GetCashierQuery?, GetCashierQuery?\)

```csharp
public static bool operator ==(GetCashierQuery? left, GetCashierQuery? right)
```

#### Parameters

`left` [GetCashierQuery](Billing.Cashiers.Queries.GetCashierQuery.md)?

`right` [GetCashierQuery](Billing.Cashiers.Queries.GetCashierQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashierQuery_op_Inequality_Billing_Cashiers_Queries_GetCashierQuery_Billing_Cashiers_Queries_GetCashierQuery_"></a> operator \!=\(GetCashierQuery?, GetCashierQuery?\)

```csharp
public static bool operator !=(GetCashierQuery? left, GetCashierQuery? right)
```

#### Parameters

`left` [GetCashierQuery](Billing.Cashiers.Queries.GetCashierQuery.md)?

`right` [GetCashierQuery](Billing.Cashiers.Queries.GetCashierQuery.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

