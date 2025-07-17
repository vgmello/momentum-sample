# <a id="Billing_Cashiers_Data_Entities_Cashier"></a> Class Cashier

Namespace: [Billing.Cashiers.Data.Entities](Billing.Cashiers.Data.Entities.md)  
Assembly: Billing.dll  

```csharp
public record Cashier : Entity, IEquatable<Entity>, IEquatable<Cashier>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Billing.Core.Data.Entity.md) ← 
[Cashier](Billing.Cashiers.Data.Entities.Cashier.md)

#### Implements

[IEquatable<Entity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<Cashier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

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

### <a id="Billing_Cashiers_Data_Entities_Cashier__ctor_Billing_Cashiers_Data_Entities_Cashier_"></a> Cashier\(Cashier\)

```csharp
protected Cashier(Cashier original)
```

#### Parameters

`original` [Cashier](Billing.Cashiers.Data.Entities.Cashier.md)

### <a id="Billing_Cashiers_Data_Entities_Cashier__ctor"></a> Cashier\(\)

```csharp
public Cashier()
```

## Properties

### <a id="Billing_Cashiers_Data_Entities_Cashier_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Data_Entities_Cashier_Email"></a> Email

```csharp
public string? Email { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Cashiers_Data_Entities_Cashier_EqualityContract"></a> EqualityContract

```csharp
protected override Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Data_Entities_Cashier_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Cashiers_Data_Entities_Cashier__Clone__"></a> <Clone\>$\(\)

```csharp
public override Cashier <Clone>$()
```

#### Returns

 [Cashier](Billing.Cashiers.Data.Entities.Cashier.md)

### <a id="Billing_Cashiers_Data_Entities_Cashier_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Data_Entities_Cashier_Equals_Billing_Core_Data_Entity_"></a> Equals\(Entity?\)

```csharp
public override sealed bool Equals(Entity? other)
```

#### Parameters

`other` [Entity](Billing.Core.Data.Entity.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Data_Entities_Cashier_Equals_Billing_Cashiers_Data_Entities_Cashier_"></a> Equals\(Cashier?\)

```csharp
public virtual bool Equals(Cashier? other)
```

#### Parameters

`other` [Cashier](Billing.Cashiers.Data.Entities.Cashier.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Data_Entities_Cashier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Data_Entities_Cashier_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected override bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Data_Entities_Cashier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Data_Entities_Cashier_op_Equality_Billing_Cashiers_Data_Entities_Cashier_Billing_Cashiers_Data_Entities_Cashier_"></a> operator ==\(Cashier?, Cashier?\)

```csharp
public static bool operator ==(Cashier? left, Cashier? right)
```

#### Parameters

`left` [Cashier](Billing.Cashiers.Data.Entities.Cashier.md)?

`right` [Cashier](Billing.Cashiers.Data.Entities.Cashier.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Data_Entities_Cashier_op_Inequality_Billing_Cashiers_Data_Entities_Cashier_Billing_Cashiers_Data_Entities_Cashier_"></a> operator \!=\(Cashier?, Cashier?\)

```csharp
public static bool operator !=(Cashier? left, Cashier? right)
```

#### Parameters

`left` [Cashier](Billing.Cashiers.Data.Entities.Cashier.md)?

`right` [Cashier](Billing.Cashiers.Data.Entities.Cashier.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

