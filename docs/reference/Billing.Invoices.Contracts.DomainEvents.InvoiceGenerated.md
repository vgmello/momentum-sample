# <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated"></a> Class InvoiceGenerated

Namespace: [Billing.Invoices.Contracts.DomainEvents](Billing.Invoices.Contracts.DomainEvents.md)  
Assembly: Billing.dll  

```csharp
public record InvoiceGenerated : IEquatable<InvoiceGenerated>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvoiceGenerated](Billing.Invoices.Contracts.DomainEvents.InvoiceGenerated.md)

#### Implements

[IEquatable<InvoiceGenerated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated__ctor_System_Guid_System_Decimal_"></a> InvoiceGenerated\(Guid, decimal\)

```csharp
public InvoiceGenerated(Guid InvoiceId, decimal InvoiceAmount)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`InvoiceAmount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated__ctor_Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_"></a> InvoiceGenerated\(InvoiceGenerated\)

```csharp
protected InvoiceGenerated(InvoiceGenerated original)
```

#### Parameters

`original` [InvoiceGenerated](Billing.Invoices.Contracts.DomainEvents.InvoiceGenerated.md)

## Properties

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_InvoiceAmount"></a> InvoiceAmount

```csharp
public decimal InvoiceAmount { get; init; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Methods

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual InvoiceGenerated <Clone>$()
```

#### Returns

 [InvoiceGenerated](Billing.Invoices.Contracts.DomainEvents.InvoiceGenerated.md)

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_Deconstruct_System_Guid__System_Decimal__"></a> Deconstruct\(out Guid, out decimal\)

```csharp
public void Deconstruct(out Guid InvoiceId, out decimal InvoiceAmount)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`InvoiceAmount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_Equals_Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_"></a> Equals\(InvoiceGenerated?\)

```csharp
public virtual bool Equals(InvoiceGenerated? other)
```

#### Parameters

`other` [InvoiceGenerated](Billing.Invoices.Contracts.DomainEvents.InvoiceGenerated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_op_Equality_Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_"></a> operator ==\(InvoiceGenerated?, InvoiceGenerated?\)

```csharp
public static bool operator ==(InvoiceGenerated? left, InvoiceGenerated? right)
```

#### Parameters

`left` [InvoiceGenerated](Billing.Invoices.Contracts.DomainEvents.InvoiceGenerated.md)?

`right` [InvoiceGenerated](Billing.Invoices.Contracts.DomainEvents.InvoiceGenerated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_op_Inequality_Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_"></a> operator \!=\(InvoiceGenerated?, InvoiceGenerated?\)

```csharp
public static bool operator !=(InvoiceGenerated? left, InvoiceGenerated? right)
```

#### Parameters

`left` [InvoiceGenerated](Billing.Invoices.Contracts.DomainEvents.InvoiceGenerated.md)?

`right` [InvoiceGenerated](Billing.Invoices.Contracts.DomainEvents.InvoiceGenerated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

