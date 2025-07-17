# <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest"></a> Class SimulatePaymentRequest

Namespace: [Billing.Api.Invoices.Models](Billing.Api.Invoices.Models.md)  
Assembly: Billing.Api.dll  

```csharp
public record SimulatePaymentRequest : IEquatable<SimulatePaymentRequest>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SimulatePaymentRequest](Billing.Api.Invoices.Models.SimulatePaymentRequest.md)

#### Implements

[IEquatable<SimulatePaymentRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest__ctor_System_Decimal_System_String_System_String_System_String_"></a> SimulatePaymentRequest\(decimal, string?, string?, string?\)

```csharp
public SimulatePaymentRequest(decimal Amount, string? Currency = "USD", string? PaymentMethod = "Credit Card", string? PaymentReference = null)
```

#### Parameters

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`PaymentMethod` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`PaymentReference` [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest__ctor_Billing_Api_Invoices_Models_SimulatePaymentRequest_"></a> SimulatePaymentRequest\(SimulatePaymentRequest\)

```csharp
protected SimulatePaymentRequest(SimulatePaymentRequest original)
```

#### Parameters

`original` [SimulatePaymentRequest](Billing.Api.Invoices.Models.SimulatePaymentRequest.md)

## Properties

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_Amount"></a> Amount

```csharp
[JsonRequired]
public decimal Amount { get; init; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_Currency"></a> Currency

```csharp
public string? Currency { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_PaymentMethod"></a> PaymentMethod

```csharp
public string? PaymentMethod { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_PaymentReference"></a> PaymentReference

```csharp
public string? PaymentReference { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Methods

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual SimulatePaymentRequest <Clone>$()
```

#### Returns

 [SimulatePaymentRequest](Billing.Api.Invoices.Models.SimulatePaymentRequest.md)

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_Deconstruct_System_Decimal__System_String__System_String__System_String__"></a> Deconstruct\(out decimal, out string?, out string?, out string?\)

```csharp
public void Deconstruct(out decimal Amount, out string? Currency, out string? PaymentMethod, out string? PaymentReference)
```

#### Parameters

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`PaymentMethod` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`PaymentReference` [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_Equals_Billing_Api_Invoices_Models_SimulatePaymentRequest_"></a> Equals\(SimulatePaymentRequest?\)

```csharp
public virtual bool Equals(SimulatePaymentRequest? other)
```

#### Parameters

`other` [SimulatePaymentRequest](Billing.Api.Invoices.Models.SimulatePaymentRequest.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_op_Equality_Billing_Api_Invoices_Models_SimulatePaymentRequest_Billing_Api_Invoices_Models_SimulatePaymentRequest_"></a> operator ==\(SimulatePaymentRequest?, SimulatePaymentRequest?\)

```csharp
public static bool operator ==(SimulatePaymentRequest? left, SimulatePaymentRequest? right)
```

#### Parameters

`left` [SimulatePaymentRequest](Billing.Api.Invoices.Models.SimulatePaymentRequest.md)?

`right` [SimulatePaymentRequest](Billing.Api.Invoices.Models.SimulatePaymentRequest.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Api_Invoices_Models_SimulatePaymentRequest_op_Inequality_Billing_Api_Invoices_Models_SimulatePaymentRequest_Billing_Api_Invoices_Models_SimulatePaymentRequest_"></a> operator \!=\(SimulatePaymentRequest?, SimulatePaymentRequest?\)

```csharp
public static bool operator !=(SimulatePaymentRequest? left, SimulatePaymentRequest? right)
```

#### Parameters

`left` [SimulatePaymentRequest](Billing.Api.Invoices.Models.SimulatePaymentRequest.md)?

`right` [SimulatePaymentRequest](Billing.Api.Invoices.Models.SimulatePaymentRequest.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

