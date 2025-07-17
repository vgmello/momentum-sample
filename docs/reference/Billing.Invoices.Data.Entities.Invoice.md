# <a id="Billing_Invoices_Data_Entities_Invoice"></a> Class Invoice

Namespace: [Billing.Invoices.Data.Entities](Billing.Invoices.Data.Entities.md)  
Assembly: Billing.dll  

```csharp
public record Invoice : Entity, IEquatable<Entity>, IEquatable<Invoice>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Billing.Core.Data.Entity.md) ← 
[Invoice](Billing.Invoices.Data.Entities.Invoice.md)

#### Implements

[IEquatable<Entity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<Invoice\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

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

### <a id="Billing_Invoices_Data_Entities_Invoice__ctor_Billing_Invoices_Data_Entities_Invoice_"></a> Invoice\(Invoice\)

```csharp
protected Invoice(Invoice original)
```

#### Parameters

`original` [Invoice](Billing.Invoices.Data.Entities.Invoice.md)

### <a id="Billing_Invoices_Data_Entities_Invoice__ctor"></a> Invoice\(\)

```csharp
public Invoice()
```

## Properties

### <a id="Billing_Invoices_Data_Entities_Invoice_Amount"></a> Amount

```csharp
public decimal Amount { get; set; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Data_Entities_Invoice_CashierId"></a> CashierId

```csharp
public Guid? CashierId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)?

### <a id="Billing_Invoices_Data_Entities_Invoice_Currency"></a> Currency

```csharp
public string? Currency { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Invoices_Data_Entities_Invoice_DueDate"></a> DueDate

```csharp
public DateTime? DueDate { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

### <a id="Billing_Invoices_Data_Entities_Invoice_EqualityContract"></a> EqualityContract

```csharp
protected override Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Data_Entities_Invoice_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Data_Entities_Invoice_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Data_Entities_Invoice_Status"></a> Status

```csharp
public string Status { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Invoices_Data_Entities_Invoice__Clone__"></a> <Clone\>$\(\)

```csharp
public override Invoice <Clone>$()
```

#### Returns

 [Invoice](Billing.Invoices.Data.Entities.Invoice.md)

### <a id="Billing_Invoices_Data_Entities_Invoice_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Data_Entities_Invoice_Equals_Billing_Core_Data_Entity_"></a> Equals\(Entity?\)

```csharp
public override sealed bool Equals(Entity? other)
```

#### Parameters

`other` [Entity](Billing.Core.Data.Entity.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Data_Entities_Invoice_Equals_Billing_Invoices_Data_Entities_Invoice_"></a> Equals\(Invoice?\)

```csharp
public virtual bool Equals(Invoice? other)
```

#### Parameters

`other` [Invoice](Billing.Invoices.Data.Entities.Invoice.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Data_Entities_Invoice_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Data_Entities_Invoice_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected override bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Data_Entities_Invoice_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Data_Entities_Invoice_op_Equality_Billing_Invoices_Data_Entities_Invoice_Billing_Invoices_Data_Entities_Invoice_"></a> operator ==\(Invoice?, Invoice?\)

```csharp
public static bool operator ==(Invoice? left, Invoice? right)
```

#### Parameters

`left` [Invoice](Billing.Invoices.Data.Entities.Invoice.md)?

`right` [Invoice](Billing.Invoices.Data.Entities.Invoice.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Data_Entities_Invoice_op_Inequality_Billing_Invoices_Data_Entities_Invoice_Billing_Invoices_Data_Entities_Invoice_"></a> operator \!=\(Invoice?, Invoice?\)

```csharp
public static bool operator !=(Invoice? left, Invoice? right)
```

#### Parameters

`left` [Invoice](Billing.Invoices.Data.Entities.Invoice.md)?

`right` [Invoice](Billing.Invoices.Data.Entities.Invoice.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

