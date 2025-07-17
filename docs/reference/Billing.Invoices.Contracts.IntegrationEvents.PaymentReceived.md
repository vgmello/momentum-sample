# <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived"></a> Class PaymentReceived

Namespace: [Billing.Invoices.Contracts.IntegrationEvents](Billing.Invoices.Contracts.IntegrationEvents.md)  
Assembly: Billing.dll, Billing.Contracts.dll  

```csharp
[EventTopic("payment-received", null, "v1")]
public record PaymentReceived : IEquatable<PaymentReceived>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)

#### Implements

[IEquatable<PaymentReceived\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived__ctor_System_Guid_System_Decimal_System_String_System_String_System_String_System_DateTime_"></a> PaymentReceived\(Guid, decimal, string, string, string, DateTime\)

```csharp
public PaymentReceived(Guid InvoiceId, decimal Amount, string Currency, string PaymentMethod, string PaymentReference, DateTime ReceivedDate)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentMethod` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentReference` [string](https://learn.microsoft.com/dotnet/api/system.string)

`ReceivedDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived__ctor_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_"></a> PaymentReceived\(PaymentReceived\)

```csharp
protected PaymentReceived(PaymentReceived original)
```

#### Parameters

`original` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived__ctor_System_Guid_System_Decimal_System_String_System_String_System_String_System_DateTime_"></a> PaymentReceived\(Guid, decimal, string, string, string, DateTime\)

```csharp
public PaymentReceived(Guid InvoiceId, decimal Amount, string Currency, string PaymentMethod, string PaymentReference, DateTime ReceivedDate)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentMethod` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentReference` [string](https://learn.microsoft.com/dotnet/api/system.string)

`ReceivedDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived__ctor_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_"></a> PaymentReceived\(PaymentReceived\)

```csharp
protected PaymentReceived(PaymentReceived original)
```

#### Parameters

`original` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)

## Properties

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Amount"></a> Amount

```csharp
public decimal Amount { get; init; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Amount"></a> Amount

```csharp
public decimal Amount { get; init; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Currency"></a> Currency

```csharp
public string Currency { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Currency"></a> Currency

```csharp
public string Currency { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_PaymentMethod"></a> PaymentMethod

```csharp
public string PaymentMethod { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_PaymentMethod"></a> PaymentMethod

```csharp
public string PaymentMethod { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_PaymentReference"></a> PaymentReference

```csharp
public string PaymentReference { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_PaymentReference"></a> PaymentReference

```csharp
public string PaymentReference { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_ReceivedDate"></a> ReceivedDate

```csharp
public DateTime ReceivedDate { get; init; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_ReceivedDate"></a> ReceivedDate

```csharp
public DateTime ReceivedDate { get; init; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

## Methods

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual PaymentReceived <Clone>$()
```

#### Returns

 [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual PaymentReceived <Clone>$()
```

#### Returns

 [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Deconstruct_System_Guid__System_Decimal__System_String__System_String__System_String__System_DateTime__"></a> Deconstruct\(out Guid, out decimal, out string, out string, out string, out DateTime\)

```csharp
public void Deconstruct(out Guid InvoiceId, out decimal Amount, out string Currency, out string PaymentMethod, out string PaymentReference, out DateTime ReceivedDate)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentMethod` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentReference` [string](https://learn.microsoft.com/dotnet/api/system.string)

`ReceivedDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Deconstruct_System_Guid__System_Decimal__System_String__System_String__System_String__System_DateTime__"></a> Deconstruct\(out Guid, out decimal, out string, out string, out string, out DateTime\)

```csharp
public void Deconstruct(out Guid InvoiceId, out decimal Amount, out string Currency, out string PaymentMethod, out string PaymentReference, out DateTime ReceivedDate)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentMethod` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentReference` [string](https://learn.microsoft.com/dotnet/api/system.string)

`ReceivedDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Equals_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_"></a> Equals\(PaymentReceived?\)

```csharp
public virtual bool Equals(PaymentReceived? other)
```

#### Parameters

`other` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Equals_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_"></a> Equals\(PaymentReceived?\)

```csharp
public virtual bool Equals(PaymentReceived? other)
```

#### Parameters

`other` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_op_Equality_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_"></a> operator ==\(PaymentReceived?, PaymentReceived?\)

```csharp
public static bool operator ==(PaymentReceived? left, PaymentReceived? right)
```

#### Parameters

`left` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)?

`right` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_op_Equality_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_"></a> operator ==\(PaymentReceived?, PaymentReceived?\)

```csharp
public static bool operator ==(PaymentReceived? left, PaymentReceived? right)
```

#### Parameters

`left` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)?

`right` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_op_Inequality_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_"></a> operator \!=\(PaymentReceived?, PaymentReceived?\)

```csharp
public static bool operator !=(PaymentReceived? left, PaymentReceived? right)
```

#### Parameters

`left` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)?

`right` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_op_Inequality_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_Billing_Invoices_Contracts_IntegrationEvents_PaymentReceived_"></a> operator \!=\(PaymentReceived?, PaymentReceived?\)

```csharp
public static bool operator !=(PaymentReceived? left, PaymentReceived? right)
```

#### Parameters

`left` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)?

`right` [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

