# <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid"></a> Class InvoicePaid

Namespace: [Billing.Invoices.Contracts.IntegrationEvents](Billing.Invoices.Contracts.IntegrationEvents.md)  
Assembly: Billing.dll, Billing.Contracts.dll  

```csharp
[EventTopic<Invoice>(null, "v1")]
public record InvoicePaid : IEquatable<InvoicePaid>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)

#### Implements

[IEquatable<InvoicePaid\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid__ctor_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_"></a> InvoicePaid\(InvoicePaid\)

```csharp
protected InvoicePaid(InvoicePaid original)
```

#### Parameters

`original` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid__ctor"></a> InvoicePaid\(\)

```csharp
public InvoicePaid()
```

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid__ctor_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_"></a> InvoicePaid\(InvoicePaid\)

```csharp
protected InvoicePaid(InvoicePaid original)
```

#### Parameters

`original` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid__ctor"></a> InvoicePaid\(\)

```csharp
public InvoicePaid()
```

## Properties

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_AmountPaid"></a> AmountPaid

```csharp
public decimal AmountPaid { get; set; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_AmountPaid"></a> AmountPaid

```csharp
public decimal AmountPaid { get; set; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_CustomerId"></a> CustomerId

```csharp
public Guid CustomerId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_CustomerId"></a> CustomerId

```csharp
public Guid CustomerId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; set; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_PaymentDate"></a> PaymentDate

```csharp
public DateTime PaymentDate { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_PaymentDate"></a> PaymentDate

```csharp
public DateTime PaymentDate { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_TenantId"></a> TenantId

```csharp
public string TenantId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_TenantId"></a> TenantId

```csharp
public string TenantId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual InvoicePaid <Clone>$()
```

#### Returns

 [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual InvoicePaid <Clone>$()
```

#### Returns

 [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_Equals_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_"></a> Equals\(InvoicePaid?\)

```csharp
public virtual bool Equals(InvoicePaid? other)
```

#### Parameters

`other` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_Equals_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_"></a> Equals\(InvoicePaid?\)

```csharp
public virtual bool Equals(InvoicePaid? other)
```

#### Parameters

`other` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_op_Equality_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_"></a> operator ==\(InvoicePaid?, InvoicePaid?\)

```csharp
public static bool operator ==(InvoicePaid? left, InvoicePaid? right)
```

#### Parameters

`left` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)?

`right` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_op_Equality_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_"></a> operator ==\(InvoicePaid?, InvoicePaid?\)

```csharp
public static bool operator ==(InvoicePaid? left, InvoicePaid? right)
```

#### Parameters

`left` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)?

`right` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_op_Inequality_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_"></a> operator \!=\(InvoicePaid?, InvoicePaid?\)

```csharp
public static bool operator !=(InvoicePaid? left, InvoicePaid? right)
```

#### Parameters

`left` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)?

`right` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_op_Inequality_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_Billing_Invoices_Contracts_IntegrationEvents_InvoicePaid_"></a> operator \!=\(InvoicePaid?, InvoicePaid?\)

```csharp
public static bool operator !=(InvoicePaid? left, InvoicePaid? right)
```

#### Parameters

`left` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)?

`right` [InvoicePaid](Billing.Invoices.Contracts.IntegrationEvents.InvoicePaid.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

