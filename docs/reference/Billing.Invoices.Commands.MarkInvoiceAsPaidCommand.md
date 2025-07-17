# <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand"></a> Class MarkInvoiceAsPaidCommand

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public record MarkInvoiceAsPaidCommand : ICommand<Result<Invoice>>, IEquatable<MarkInvoiceAsPaidCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MarkInvoiceAsPaidCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommand.md)

#### Implements

[ICommand<Result<Invoice\>\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IEquatable<MarkInvoiceAsPaidCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand__ctor_System_Guid_System_Decimal_System_Nullable_System_DateTime__"></a> MarkInvoiceAsPaidCommand\(Guid, decimal, DateTime?\)

```csharp
public MarkInvoiceAsPaidCommand(Guid InvoiceId, decimal AmountPaid, DateTime? PaymentDate = null)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`AmountPaid` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`PaymentDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand__ctor_Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_"></a> MarkInvoiceAsPaidCommand\(MarkInvoiceAsPaidCommand\)

```csharp
protected MarkInvoiceAsPaidCommand(MarkInvoiceAsPaidCommand original)
```

#### Parameters

`original` [MarkInvoiceAsPaidCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommand.md)

## Properties

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_AmountPaid"></a> AmountPaid

```csharp
public decimal AmountPaid { get; init; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_PaymentDate"></a> PaymentDate

```csharp
public DateTime? PaymentDate { get; init; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

## Methods

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual MarkInvoiceAsPaidCommand <Clone>$()
```

#### Returns

 [MarkInvoiceAsPaidCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommand.md)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_Deconstruct_System_Guid__System_Decimal__System_Nullable_System_DateTime___"></a> Deconstruct\(out Guid, out decimal, out DateTime?\)

```csharp
public void Deconstruct(out Guid InvoiceId, out decimal AmountPaid, out DateTime? PaymentDate)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`AmountPaid` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`PaymentDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_Equals_Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_"></a> Equals\(MarkInvoiceAsPaidCommand?\)

```csharp
public virtual bool Equals(MarkInvoiceAsPaidCommand? other)
```

#### Parameters

`other` [MarkInvoiceAsPaidCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_op_Equality_Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_"></a> operator ==\(MarkInvoiceAsPaidCommand?, MarkInvoiceAsPaidCommand?\)

```csharp
public static bool operator ==(MarkInvoiceAsPaidCommand? left, MarkInvoiceAsPaidCommand? right)
```

#### Parameters

`left` [MarkInvoiceAsPaidCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommand.md)?

`right` [MarkInvoiceAsPaidCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_op_Inequality_Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_Billing_Invoices_Commands_MarkInvoiceAsPaidCommand_"></a> operator \!=\(MarkInvoiceAsPaidCommand?, MarkInvoiceAsPaidCommand?\)

```csharp
public static bool operator !=(MarkInvoiceAsPaidCommand? left, MarkInvoiceAsPaidCommand? right)
```

#### Parameters

`left` [MarkInvoiceAsPaidCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommand.md)?

`right` [MarkInvoiceAsPaidCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

