# <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated"></a> Class InvoiceCreated

Namespace: [Billing.Invoices.Contracts.IntegrationEvents](Billing.Invoices.Contracts.IntegrationEvents.md)  
Assembly: Billing.dll, Billing.Contracts.dll  

```csharp
[EventTopic<Invoice>(null, "v1")]
public record InvoiceCreated : IEquatable<InvoiceCreated>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)

#### Implements

[IEquatable<InvoiceCreated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated__ctor_Billing_Invoices_Contracts_Models_Invoice_"></a> InvoiceCreated\(Invoice\)

```csharp
public InvoiceCreated(Invoice Invoice)
```

#### Parameters

`Invoice` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated__ctor_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_"></a> InvoiceCreated\(InvoiceCreated\)

```csharp
protected InvoiceCreated(InvoiceCreated original)
```

#### Parameters

`original` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated__ctor_Billing_Invoices_Contracts_Models_Invoice_"></a> InvoiceCreated\(Invoice\)

```csharp
public InvoiceCreated(Invoice Invoice)
```

#### Parameters

`Invoice` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated__ctor_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_"></a> InvoiceCreated\(InvoiceCreated\)

```csharp
protected InvoiceCreated(InvoiceCreated original)
```

#### Parameters

`original` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)

## Properties

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Invoice"></a> Invoice

```csharp
public Invoice Invoice { get; init; }
```

#### Property Value

 [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Invoice"></a> Invoice

```csharp
public Invoice Invoice { get; init; }
```

#### Property Value

 [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)

## Methods

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual InvoiceCreated <Clone>$()
```

#### Returns

 [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual InvoiceCreated <Clone>$()
```

#### Returns

 [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Deconstruct_Billing_Invoices_Contracts_Models_Invoice__"></a> Deconstruct\(out Invoice\)

```csharp
public void Deconstruct(out Invoice Invoice)
```

#### Parameters

`Invoice` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Deconstruct_Billing_Invoices_Contracts_Models_Invoice__"></a> Deconstruct\(out Invoice\)

```csharp
public void Deconstruct(out Invoice Invoice)
```

#### Parameters

`Invoice` [Invoice](Billing.Invoices.Contracts.Models.Invoice.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Equals_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_"></a> Equals\(InvoiceCreated?\)

```csharp
public virtual bool Equals(InvoiceCreated? other)
```

#### Parameters

`other` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Equals_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_"></a> Equals\(InvoiceCreated?\)

```csharp
public virtual bool Equals(InvoiceCreated? other)
```

#### Parameters

`other` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_op_Equality_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_"></a> operator ==\(InvoiceCreated?, InvoiceCreated?\)

```csharp
public static bool operator ==(InvoiceCreated? left, InvoiceCreated? right)
```

#### Parameters

`left` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)?

`right` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_op_Equality_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_"></a> operator ==\(InvoiceCreated?, InvoiceCreated?\)

```csharp
public static bool operator ==(InvoiceCreated? left, InvoiceCreated? right)
```

#### Parameters

`left` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)?

`right` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_op_Inequality_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_"></a> operator \!=\(InvoiceCreated?, InvoiceCreated?\)

```csharp
public static bool operator !=(InvoiceCreated? left, InvoiceCreated? right)
```

#### Parameters

`left` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)?

`right` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_op_Inequality_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCreated_"></a> operator \!=\(InvoiceCreated?, InvoiceCreated?\)

```csharp
public static bool operator !=(InvoiceCreated? left, InvoiceCreated? right)
```

#### Parameters

`left` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)?

`right` [InvoiceCreated](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

