# <a id="Billing_Cashiers_Contracts_Models_Cashier"></a> Class Cashier

Namespace: [Billing.Cashiers.Contracts.Models](Billing.Cashiers.Contracts.Models.md)  
Assembly: Billing.dll, Billing.Contracts.dll  

```csharp
public record Cashier : IEquatable<Cashier>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)

#### Implements

[IEquatable<Cashier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Contracts_Models_Cashier__ctor_Billing_Cashiers_Contracts_Models_Cashier_"></a> Cashier\(Cashier\)

```csharp
protected Cashier(Cashier original)
```

#### Parameters

`original` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)

### <a id="Billing_Cashiers_Contracts_Models_Cashier__ctor"></a> Cashier\(\)

```csharp
public Cashier()
```

### <a id="Billing_Cashiers_Contracts_Models_Cashier__ctor_Billing_Cashiers_Contracts_Models_Cashier_"></a> Cashier\(Cashier\)

```csharp
protected Cashier(Cashier original)
```

#### Parameters

`original` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)

### <a id="Billing_Cashiers_Contracts_Models_Cashier__ctor"></a> Cashier\(\)

```csharp
public Cashier()
```

## Properties

### <a id="Billing_Cashiers_Contracts_Models_Cashier_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_CashierPayments"></a> CashierPayments

```csharp
public List<CashierPayment> CashierPayments { get; set; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[CashierPayment](Billing.Cashiers.Contracts.Models.CashierPayment.md)\>

### <a id="Billing_Cashiers_Contracts_Models_Cashier_CashierPayments"></a> CashierPayments

```csharp
public List<CashierPayment> CashierPayments { get; set; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[CashierPayment](Billing.Cashiers.Contracts.Models.CashierPayment.md)\>

### <a id="Billing_Cashiers_Contracts_Models_Cashier_Email"></a> Email

```csharp
public required string Email { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_Email"></a> Email

```csharp
public required string Email { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_Name"></a> Name

```csharp
public required string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_Name"></a> Name

```csharp
public required string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_TenantId"></a> TenantId

```csharp
public Guid TenantId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_TenantId"></a> TenantId

```csharp
public Guid TenantId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Methods

### <a id="Billing_Cashiers_Contracts_Models_Cashier__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual Cashier <Clone>$()
```

#### Returns

 [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)

### <a id="Billing_Cashiers_Contracts_Models_Cashier__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual Cashier <Clone>$()
```

#### Returns

 [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_Equals_Billing_Cashiers_Contracts_Models_Cashier_"></a> Equals\(Cashier?\)

```csharp
public virtual bool Equals(Cashier? other)
```

#### Parameters

`other` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_Equals_Billing_Cashiers_Contracts_Models_Cashier_"></a> Equals\(Cashier?\)

```csharp
public virtual bool Equals(Cashier? other)
```

#### Parameters

`other` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Contracts_Models_Cashier_op_Equality_Billing_Cashiers_Contracts_Models_Cashier_Billing_Cashiers_Contracts_Models_Cashier_"></a> operator ==\(Cashier?, Cashier?\)

```csharp
public static bool operator ==(Cashier? left, Cashier? right)
```

#### Parameters

`left` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)?

`right` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_op_Equality_Billing_Cashiers_Contracts_Models_Cashier_Billing_Cashiers_Contracts_Models_Cashier_"></a> operator ==\(Cashier?, Cashier?\)

```csharp
public static bool operator ==(Cashier? left, Cashier? right)
```

#### Parameters

`left` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)?

`right` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_op_Inequality_Billing_Cashiers_Contracts_Models_Cashier_Billing_Cashiers_Contracts_Models_Cashier_"></a> operator \!=\(Cashier?, Cashier?\)

```csharp
public static bool operator !=(Cashier? left, Cashier? right)
```

#### Parameters

`left` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)?

`right` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_Models_Cashier_op_Inequality_Billing_Cashiers_Contracts_Models_Cashier_Billing_Cashiers_Contracts_Models_Cashier_"></a> operator \!=\(Cashier?, Cashier?\)

```csharp
public static bool operator !=(Cashier? left, Cashier? right)
```

#### Parameters

`left` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)?

`right` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

