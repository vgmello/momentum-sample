# <a id="Billing_Invoices_Contracts_Models_Invoice"></a> Class Invoice

Namespace: [Billing.Invoices.Contracts.Models](Billing.Invoices.Contracts.Models.md)  
Assembly: Billing.dll, Billing.Contracts.dll  

```csharp
public record Invoice : IEquatable<Invoice>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Invoice](Billing.Invoices.Contracts.Models.Invoice.md)

#### Implements

[IEquatable<Invoice\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Contracts_Models_Invoice__ctor_Billing_Invoices_Contracts_Models_Invoice_"></a> Invoice\(Invoice\)

```csharp
protected Invoice(Invoice original)
```

#### Parameters

`original` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)

### <a id="Billing_Invoices_Contracts_Models_Invoice__ctor"></a> Invoice\(\)

```csharp
public Invoice()
```

### <a id="Billing_Invoices_Contracts_Models_Invoice__ctor_Billing_Invoices_Contracts_Models_Invoice_"></a> Invoice\(Invoice\)

```csharp
protected Invoice(Invoice original)
```

#### Parameters

`original` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)

### <a id="Billing_Invoices_Contracts_Models_Invoice__ctor"></a> Invoice\(\)

```csharp
public Invoice()
```

## Properties

### <a id="Billing_Invoices_Contracts_Models_Invoice_Amount"></a> Amount

```csharp
public decimal Amount { get; set; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Amount"></a> Amount

```csharp
public decimal Amount { get; set; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Contracts_Models_Invoice_CashierId"></a> CashierId

```csharp
public Guid? CashierId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)?

### <a id="Billing_Invoices_Contracts_Models_Invoice_CashierId"></a> CashierId

```csharp
public Guid? CashierId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)?

### <a id="Billing_Invoices_Contracts_Models_Invoice_CreatedDateUtc"></a> CreatedDateUtc

```csharp
public DateTime CreatedDateUtc { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Contracts_Models_Invoice_CreatedDateUtc"></a> CreatedDateUtc

```csharp
public DateTime CreatedDateUtc { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Currency"></a> Currency

```csharp
public string? Currency { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Invoices_Contracts_Models_Invoice_Currency"></a> Currency

```csharp
public string? Currency { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Invoices_Contracts_Models_Invoice_DueDate"></a> DueDate

```csharp
public DateTime? DueDate { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

### <a id="Billing_Invoices_Contracts_Models_Invoice_DueDate"></a> DueDate

```csharp
public DateTime? DueDate { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

### <a id="Billing_Invoices_Contracts_Models_Invoice_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Contracts_Models_Invoice_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Contracts_Models_Invoice_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_Models_Invoice_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Name"></a> Name

```csharp
public required string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Name"></a> Name

```csharp
public required string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Status"></a> Status

```csharp
public required string Status { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Status"></a> Status

```csharp
public required string Status { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_Models_Invoice_UpdatedDateUtc"></a> UpdatedDateUtc

```csharp
public DateTime UpdatedDateUtc { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Contracts_Models_Invoice_UpdatedDateUtc"></a> UpdatedDateUtc

```csharp
public DateTime UpdatedDateUtc { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Version"></a> Version

```csharp
public int Version { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Version"></a> Version

```csharp
public int Version { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Billing_Invoices_Contracts_Models_Invoice__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual Invoice <Clone>$()
```

#### Returns

 [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)

### <a id="Billing_Invoices_Contracts_Models_Invoice__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual Invoice <Clone>$()
```

#### Returns

 [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Equals_Billing_Invoices_Contracts_Models_Invoice_"></a> Equals\(Invoice?\)

```csharp
public virtual bool Equals(Invoice? other)
```

#### Parameters

`other` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_Models_Invoice_Equals_Billing_Invoices_Contracts_Models_Invoice_"></a> Equals\(Invoice?\)

```csharp
public virtual bool Equals(Invoice? other)
```

#### Parameters

`other` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_Models_Invoice_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_Models_Invoice_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_Models_Invoice_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_Models_Invoice_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_Models_Invoice_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_Models_Invoice_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Contracts_Models_Invoice_op_Equality_Billing_Invoices_Contracts_Models_Invoice_Billing_Invoices_Contracts_Models_Invoice_"></a> operator ==\(Invoice?, Invoice?\)

```csharp
public static bool operator ==(Invoice? left, Invoice? right)
```

#### Parameters

`left` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)?

`right` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_Models_Invoice_op_Equality_Billing_Invoices_Contracts_Models_Invoice_Billing_Invoices_Contracts_Models_Invoice_"></a> operator ==\(Invoice?, Invoice?\)

```csharp
public static bool operator ==(Invoice? left, Invoice? right)
```

#### Parameters

`left` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)?

`right` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_Models_Invoice_op_Inequality_Billing_Invoices_Contracts_Models_Invoice_Billing_Invoices_Contracts_Models_Invoice_"></a> operator \!=\(Invoice?, Invoice?\)

```csharp
public static bool operator !=(Invoice? left, Invoice? right)
```

#### Parameters

`left` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)?

`right` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_Models_Invoice_op_Inequality_Billing_Invoices_Contracts_Models_Invoice_Billing_Invoices_Contracts_Models_Invoice_"></a> operator \!=\(Invoice?, Invoice?\)

```csharp
public static bool operator !=(Invoice? left, Invoice? right)
```

#### Parameters

`left` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)?

`right` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

