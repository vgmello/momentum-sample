# <a id="Billing_Cashiers_Data_Entities_CashierCurrency"></a> Class CashierCurrency

Namespace: [Billing.Cashiers.Data.Entities](Billing.Cashiers.Data.Entities.md)  
Assembly: Billing.dll  

```csharp
public record CashierCurrency : Entity, IEquatable<Entity>, IEquatable<CashierCurrency>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Billing.Core.Data.Entity.md) ← 
[CashierCurrency](Billing.Cashiers.Data.Entities.CashierCurrency.md)

#### Implements

[IEquatable<Entity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<CashierCurrency\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[Entity.ToString\(\)](Billing.Core.Data.Entity.md\#Billing\_Core\_Data\_Entity\_ToString), 
[Entity.PrintMembers\(StringBuilder\)](Billing.Core.Data.Entity.md\#Billing\_Core\_Data\_Entity\_PrintMembers\_System\_Text\_StringBuilder\_), 
[Entity.GetHashCode\(\)](Billing.Core.Data.Entity.md\#Billing\_Core\_Data\_Entity\_GetHashCode), 
[Entity.Equals\(object?\)](Billing.Core.Data.Entity.md\#Billing\_Core\_Data\_Entity\_Equals\_System\_Object\_), 
[Entity.Equals\(Entity?\)](Billing.Core.Data.Entity.md\#Billing\_Core\_Data\_Entity\_Equals\_Billing\_Core\_Data\_Entity\_), 
[Entity.<Clone\>$\(\)](Billing.Core.Data.Entity.md\#Billing\_Core\_Data\_Entity\_\_Clone\_\_), 
[Entity.EqualityContract](Billing.Core.Data.Entity.md\#Billing\_Core\_Data\_Entity\_EqualityContract), 
[Entity.CreatedDateUtc](Billing.Core.Data.Entity.md\#Billing\_Core\_Data\_Entity\_CreatedDateUtc), 
[Entity.UpdatedDateUtc](Billing.Core.Data.Entity.md\#Billing\_Core\_Data\_Entity\_UpdatedDateUtc), 
[Entity.Version](Billing.Core.Data.Entity.md\#Billing\_Core\_Data\_Entity\_Version), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency__ctor_Billing_Cashiers_Data_Entities_CashierCurrency_"></a> CashierCurrency\(CashierCurrency\)

```csharp
protected CashierCurrency(CashierCurrency original)
```

#### Parameters

`original` [CashierCurrency](Billing.Cashiers.Data.Entities.CashierCurrency.md)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency__ctor"></a> CashierCurrency\(\)

```csharp
public CashierCurrency()
```

## Properties

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_Cashier"></a> Cashier

```csharp
[ForeignKey("CashierId")]
public Cashier Cashier { get; set; }
```

#### Property Value

 [Cashier](Billing.Cashiers.Data.Entities.Cashier.md)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_CurrencyId"></a> CurrencyId

```csharp
public Guid CurrencyId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_CustomCurrencyCode"></a> CustomCurrencyCode

```csharp
[MaxLength(10)]
public string CustomCurrencyCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_EffectiveDateUtc"></a> EffectiveDateUtc

```csharp
public DateTime EffectiveDateUtc { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_EqualityContract"></a> EqualityContract

```csharp
protected override Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

## Methods

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency__Clone__"></a> <Clone\>$\(\)

```csharp
public override CashierCurrency <Clone>$()
```

#### Returns

 [CashierCurrency](Billing.Cashiers.Data.Entities.CashierCurrency.md)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_Equals_Billing_Core_Data_Entity_"></a> Equals\(Entity?\)

```csharp
public override sealed bool Equals(Entity? other)
```

#### Parameters

`other` [Entity](Billing.Core.Data.Entity.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_Equals_Billing_Cashiers_Data_Entities_CashierCurrency_"></a> Equals\(CashierCurrency?\)

```csharp
public virtual bool Equals(CashierCurrency? other)
```

#### Parameters

`other` [CashierCurrency](Billing.Cashiers.Data.Entities.CashierCurrency.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected override bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_op_Equality_Billing_Cashiers_Data_Entities_CashierCurrency_Billing_Cashiers_Data_Entities_CashierCurrency_"></a> operator ==\(CashierCurrency?, CashierCurrency?\)

```csharp
public static bool operator ==(CashierCurrency? left, CashierCurrency? right)
```

#### Parameters

`left` [CashierCurrency](Billing.Cashiers.Data.Entities.CashierCurrency.md)?

`right` [CashierCurrency](Billing.Cashiers.Data.Entities.CashierCurrency.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Data_Entities_CashierCurrency_op_Inequality_Billing_Cashiers_Data_Entities_CashierCurrency_Billing_Cashiers_Data_Entities_CashierCurrency_"></a> operator \!=\(CashierCurrency?, CashierCurrency?\)

```csharp
public static bool operator !=(CashierCurrency? left, CashierCurrency? right)
```

#### Parameters

`left` [CashierCurrency](Billing.Cashiers.Data.Entities.CashierCurrency.md)?

`right` [CashierCurrency](Billing.Cashiers.Data.Entities.CashierCurrency.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

