# <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled"></a> Class InvoiceCancelled

Namespace: [Billing.Invoices.Contracts.IntegrationEvents](Billing.Invoices.Contracts.IntegrationEvents.md)  
Assembly: Billing.dll, Billing.Contracts.dll  

```csharp
[EventTopic<Invoice>(null, "v1")]
public record InvoiceCancelled : IEquatable<InvoiceCancelled>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)

#### Implements

[IEquatable<InvoiceCancelled\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled__ctor_System_Guid_"></a> InvoiceCancelled\(Guid\)

```csharp
public InvoiceCancelled(Guid InvoiceId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled__ctor_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_"></a> InvoiceCancelled\(InvoiceCancelled\)

```csharp
protected InvoiceCancelled(InvoiceCancelled original)
```

#### Parameters

`original` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled__ctor_System_Guid_"></a> InvoiceCancelled\(Guid\)

```csharp
public InvoiceCancelled(Guid InvoiceId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled__ctor_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_"></a> InvoiceCancelled\(InvoiceCancelled\)

```csharp
protected InvoiceCancelled(InvoiceCancelled original)
```

#### Parameters

`original` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)

## Properties

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Methods

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual InvoiceCancelled <Clone>$()
```

#### Returns

 [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual InvoiceCancelled <Clone>$()
```

#### Returns

 [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid InvoiceId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid InvoiceId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_Equals_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_"></a> Equals\(InvoiceCancelled?\)

```csharp
public virtual bool Equals(InvoiceCancelled? other)
```

#### Parameters

`other` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_Equals_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_"></a> Equals\(InvoiceCancelled?\)

```csharp
public virtual bool Equals(InvoiceCancelled? other)
```

#### Parameters

`other` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_op_Equality_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_"></a> operator ==\(InvoiceCancelled?, InvoiceCancelled?\)

```csharp
public static bool operator ==(InvoiceCancelled? left, InvoiceCancelled? right)
```

#### Parameters

`left` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)?

`right` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_op_Equality_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_"></a> operator ==\(InvoiceCancelled?, InvoiceCancelled?\)

```csharp
public static bool operator ==(InvoiceCancelled? left, InvoiceCancelled? right)
```

#### Parameters

`left` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)?

`right` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_op_Inequality_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_"></a> operator \!=\(InvoiceCancelled?, InvoiceCancelled?\)

```csharp
public static bool operator !=(InvoiceCancelled? left, InvoiceCancelled? right)
```

#### Parameters

`left` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)?

`right` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_op_Inequality_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_Billing_Invoices_Contracts_IntegrationEvents_InvoiceCancelled_"></a> operator \!=\(InvoiceCancelled?, InvoiceCancelled?\)

```csharp
public static bool operator !=(InvoiceCancelled? left, InvoiceCancelled? right)
```

#### Parameters

`left` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)?

`right` [InvoiceCancelled](Billing.Invoices.Contracts.IntegrationEvents.InvoiceCancelled.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

