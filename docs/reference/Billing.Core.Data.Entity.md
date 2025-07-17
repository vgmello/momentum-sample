# <a id="Billing_Core_Data_Entity"></a> Class Entity

Namespace: [Billing.Core.Data](Billing.Core.Data.md)  
Assembly: Billing.dll  

```csharp
public record Entity : IEquatable<Entity>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Billing.Core.Data.Entity.md)

#### Derived

[Cashier](Billing.Cashiers.Data.Entities.Cashier.md), 
[CashierCurrency](Billing.Cashiers.Data.Entities.CashierCurrency.md), 
[Invoice](Billing.Invoices.Data.Entities.Invoice.md)

#### Implements

[IEquatable<Entity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Core_Data_Entity__ctor_Billing_Core_Data_Entity_"></a> Entity\(Entity\)

```csharp
protected Entity(Entity original)
```

#### Parameters

`original` [Entity](Billing.Core.Data.Entity.md)

### <a id="Billing_Core_Data_Entity__ctor"></a> Entity\(\)

```csharp
public Entity()
```

## Properties

### <a id="Billing_Core_Data_Entity_CreatedDateUtc"></a> CreatedDateUtc

```csharp
public DateTime CreatedDateUtc { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Core_Data_Entity_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Core_Data_Entity_UpdatedDateUtc"></a> UpdatedDateUtc

```csharp
public DateTime UpdatedDateUtc { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Core_Data_Entity_Version"></a> Version

```csharp
[ConcurrencyCheck]
public int Version { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Billing_Core_Data_Entity__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual Entity <Clone>$()
```

#### Returns

 [Entity](Billing.Core.Data.Entity.md)

### <a id="Billing_Core_Data_Entity_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Core_Data_Entity_Equals_Billing_Core_Data_Entity_"></a> Equals\(Entity?\)

```csharp
public virtual bool Equals(Entity? other)
```

#### Parameters

`other` [Entity](Billing.Core.Data.Entity.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Core_Data_Entity_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Core_Data_Entity_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Core_Data_Entity_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Core_Data_Entity_op_Equality_Billing_Core_Data_Entity_Billing_Core_Data_Entity_"></a> operator ==\(Entity?, Entity?\)

```csharp
public static bool operator ==(Entity? left, Entity? right)
```

#### Parameters

`left` [Entity](Billing.Core.Data.Entity.md)?

`right` [Entity](Billing.Core.Data.Entity.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Core_Data_Entity_op_Inequality_Billing_Core_Data_Entity_Billing_Core_Data_Entity_"></a> operator \!=\(Entity?, Entity?\)

```csharp
public static bool operator !=(Entity? left, Entity? right)
```

#### Parameters

`left` [Entity](Billing.Core.Data.Entity.md)?

`right` [Entity](Billing.Core.Data.Entity.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

