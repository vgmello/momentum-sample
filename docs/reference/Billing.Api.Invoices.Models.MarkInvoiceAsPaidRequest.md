# <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest"></a> Class MarkInvoiceAsPaidRequest

Namespace: [Billing.Api.Invoices.Models](Billing.Api.Invoices.Models.md)  
Assembly: Billing.Api.dll  

```csharp
public record MarkInvoiceAsPaidRequest : IEquatable<MarkInvoiceAsPaidRequest>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MarkInvoiceAsPaidRequest](Billing.Api.Invoices.Models.MarkInvoiceAsPaidRequest.md)

#### Implements

[IEquatable<MarkInvoiceAsPaidRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest__ctor_System_Decimal_System_Nullable_System_DateTime__"></a> MarkInvoiceAsPaidRequest\(decimal, DateTime?\)

```csharp
public MarkInvoiceAsPaidRequest(decimal AmountPaid, DateTime? PaymentDate = null)
```

#### Parameters

`AmountPaid` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`PaymentDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest__ctor_Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_"></a> MarkInvoiceAsPaidRequest\(MarkInvoiceAsPaidRequest\)

```csharp
protected MarkInvoiceAsPaidRequest(MarkInvoiceAsPaidRequest original)
```

#### Parameters

`original` [MarkInvoiceAsPaidRequest](Billing.Api.Invoices.Models.MarkInvoiceAsPaidRequest.md)

## Properties

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_AmountPaid"></a> AmountPaid

```csharp
[JsonRequired]
public decimal AmountPaid { get; init; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_PaymentDate"></a> PaymentDate

```csharp
public DateTime? PaymentDate { get; init; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

## Methods

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual MarkInvoiceAsPaidRequest <Clone>$()
```

#### Returns

 [MarkInvoiceAsPaidRequest](Billing.Api.Invoices.Models.MarkInvoiceAsPaidRequest.md)

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_Deconstruct_System_Decimal__System_Nullable_System_DateTime___"></a> Deconstruct\(out decimal, out DateTime?\)

```csharp
public void Deconstruct(out decimal AmountPaid, out DateTime? PaymentDate)
```

#### Parameters

`AmountPaid` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`PaymentDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_Equals_Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_"></a> Equals\(MarkInvoiceAsPaidRequest?\)

```csharp
public virtual bool Equals(MarkInvoiceAsPaidRequest? other)
```

#### Parameters

`other` [MarkInvoiceAsPaidRequest](Billing.Api.Invoices.Models.MarkInvoiceAsPaidRequest.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_op_Equality_Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_"></a> operator ==\(MarkInvoiceAsPaidRequest?, MarkInvoiceAsPaidRequest?\)

```csharp
public static bool operator ==(MarkInvoiceAsPaidRequest? left, MarkInvoiceAsPaidRequest? right)
```

#### Parameters

`left` [MarkInvoiceAsPaidRequest](Billing.Api.Invoices.Models.MarkInvoiceAsPaidRequest.md)?

`right` [MarkInvoiceAsPaidRequest](Billing.Api.Invoices.Models.MarkInvoiceAsPaidRequest.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_op_Inequality_Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_Billing_Api_Invoices_Models_MarkInvoiceAsPaidRequest_"></a> operator \!=\(MarkInvoiceAsPaidRequest?, MarkInvoiceAsPaidRequest?\)

```csharp
public static bool operator !=(MarkInvoiceAsPaidRequest? left, MarkInvoiceAsPaidRequest? right)
```

#### Parameters

`left` [MarkInvoiceAsPaidRequest](Billing.Api.Invoices.Models.MarkInvoiceAsPaidRequest.md)?

`right` [MarkInvoiceAsPaidRequest](Billing.Api.Invoices.Models.MarkInvoiceAsPaidRequest.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

