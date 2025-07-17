# <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result"></a> Class GetCashiersQuery.Result

Namespace: [Billing.Cashiers.Queries](Billing.Cashiers.Queries.md)  
Assembly: Billing.dll  

```csharp
public record GetCashiersQuery.Result : IEquatable<GetCashiersQuery.Result>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetCashiersQuery.Result](Billing.Cashiers.Queries.GetCashiersQuery.Result.md)

#### Implements

[IEquatable<GetCashiersQuery.Result\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result__ctor_System_Guid_System_Guid_System_String_System_String_"></a> Result\(Guid, Guid, string, string\)

```csharp
public Result(Guid TenantId, Guid CashierId, string Name, string Email)
```

#### Parameters

`TenantId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Email` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result__ctor_Billing_Cashiers_Queries_GetCashiersQuery_Result_"></a> Result\(Result\)

```csharp
protected Result(GetCashiersQuery.Result original)
```

#### Parameters

`original` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md).[Result](Billing.Cashiers.Queries.GetCashiersQuery.Result.md)

## Properties

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_Email"></a> Email

```csharp
public string Email { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_Name"></a> Name

```csharp
public string Name { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_TenantId"></a> TenantId

```csharp
public Guid TenantId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Methods

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual GetCashiersQuery.Result <Clone>$()
```

#### Returns

 [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md).[Result](Billing.Cashiers.Queries.GetCashiersQuery.Result.md)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_Deconstruct_System_Guid__System_Guid__System_String__System_String__"></a> Deconstruct\(out Guid, out Guid, out string, out string\)

```csharp
public void Deconstruct(out Guid TenantId, out Guid CashierId, out string Name, out string Email)
```

#### Parameters

`TenantId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Email` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_Equals_Billing_Cashiers_Queries_GetCashiersQuery_Result_"></a> Equals\(Result?\)

```csharp
public virtual bool Equals(GetCashiersQuery.Result? other)
```

#### Parameters

`other` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md).[Result](Billing.Cashiers.Queries.GetCashiersQuery.Result.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_op_Equality_Billing_Cashiers_Queries_GetCashiersQuery_Result_Billing_Cashiers_Queries_GetCashiersQuery_Result_"></a> operator ==\(Result?, Result?\)

```csharp
public static bool operator ==(GetCashiersQuery.Result? left, GetCashiersQuery.Result? right)
```

#### Parameters

`left` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md).[Result](Billing.Cashiers.Queries.GetCashiersQuery.Result.md)?

`right` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md).[Result](Billing.Cashiers.Queries.GetCashiersQuery.Result.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Queries_GetCashiersQuery_Result_op_Inequality_Billing_Cashiers_Queries_GetCashiersQuery_Result_Billing_Cashiers_Queries_GetCashiersQuery_Result_"></a> operator \!=\(Result?, Result?\)

```csharp
public static bool operator !=(GetCashiersQuery.Result? left, GetCashiersQuery.Result? right)
```

#### Parameters

`left` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md).[Result](Billing.Cashiers.Queries.GetCashiersQuery.Result.md)?

`right` [GetCashiersQuery](Billing.Cashiers.Queries.GetCashiersQuery.md).[Result](Billing.Cashiers.Queries.GetCashiersQuery.Result.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

