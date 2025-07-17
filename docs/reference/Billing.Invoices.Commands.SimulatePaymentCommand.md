# <a id="Billing_Invoices_Commands_SimulatePaymentCommand"></a> Class SimulatePaymentCommand

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public record SimulatePaymentCommand : ICommand<Result<bool>>, IEquatable<SimulatePaymentCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SimulatePaymentCommand](Billing.Invoices.Commands.SimulatePaymentCommand.md)

#### Implements

[ICommand<Result<bool\>\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IEquatable<SimulatePaymentCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand__ctor_System_Guid_System_Decimal_System_String_System_String_System_String_"></a> SimulatePaymentCommand\(Guid, decimal, string, string, string\)

```csharp
public SimulatePaymentCommand(Guid InvoiceId, decimal Amount, string Currency = "USD", string PaymentMethod = "Credit Card", string PaymentReference = "SIM-REF")
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentMethod` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentReference` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand__ctor_Billing_Invoices_Commands_SimulatePaymentCommand_"></a> SimulatePaymentCommand\(SimulatePaymentCommand\)

```csharp
protected SimulatePaymentCommand(SimulatePaymentCommand original)
```

#### Parameters

`original` [SimulatePaymentCommand](Billing.Invoices.Commands.SimulatePaymentCommand.md)

## Properties

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_Amount"></a> Amount

```csharp
public decimal Amount { get; init; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_Currency"></a> Currency

```csharp
public string Currency { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_PaymentMethod"></a> PaymentMethod

```csharp
public string PaymentMethod { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_PaymentReference"></a> PaymentReference

```csharp
public string PaymentReference { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual SimulatePaymentCommand <Clone>$()
```

#### Returns

 [SimulatePaymentCommand](Billing.Invoices.Commands.SimulatePaymentCommand.md)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_Deconstruct_System_Guid__System_Decimal__System_String__System_String__System_String__"></a> Deconstruct\(out Guid, out decimal, out string, out string, out string\)

```csharp
public void Deconstruct(out Guid InvoiceId, out decimal Amount, out string Currency, out string PaymentMethod, out string PaymentReference)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentMethod` [string](https://learn.microsoft.com/dotnet/api/system.string)

`PaymentReference` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_Equals_Billing_Invoices_Commands_SimulatePaymentCommand_"></a> Equals\(SimulatePaymentCommand?\)

```csharp
public virtual bool Equals(SimulatePaymentCommand? other)
```

#### Parameters

`other` [SimulatePaymentCommand](Billing.Invoices.Commands.SimulatePaymentCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_op_Equality_Billing_Invoices_Commands_SimulatePaymentCommand_Billing_Invoices_Commands_SimulatePaymentCommand_"></a> operator ==\(SimulatePaymentCommand?, SimulatePaymentCommand?\)

```csharp
public static bool operator ==(SimulatePaymentCommand? left, SimulatePaymentCommand? right)
```

#### Parameters

`left` [SimulatePaymentCommand](Billing.Invoices.Commands.SimulatePaymentCommand.md)?

`right` [SimulatePaymentCommand](Billing.Invoices.Commands.SimulatePaymentCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_SimulatePaymentCommand_op_Inequality_Billing_Invoices_Commands_SimulatePaymentCommand_Billing_Invoices_Commands_SimulatePaymentCommand_"></a> operator \!=\(SimulatePaymentCommand?, SimulatePaymentCommand?\)

```csharp
public static bool operator !=(SimulatePaymentCommand? left, SimulatePaymentCommand? right)
```

#### Parameters

`left` [SimulatePaymentCommand](Billing.Invoices.Commands.SimulatePaymentCommand.md)?

`right` [SimulatePaymentCommand](Billing.Invoices.Commands.SimulatePaymentCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

