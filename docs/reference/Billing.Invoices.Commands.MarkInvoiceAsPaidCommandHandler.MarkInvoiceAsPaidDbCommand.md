# <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand"></a> Class MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
[DbCommand("billing.invoices_mark_paid", null, null, DbParamsCase.Unset, true, null)]
public sealed record MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand : ICommand<int>, IDbParamsProvider, IEquatable<MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand.md)

#### Implements

[ICommand<int\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IDbParamsProvider](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Dapper/IDbParamsProvider.cs), 
[IEquatable<MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand__ctor_System_Guid_System_Decimal_System_DateTime_"></a> MarkInvoiceAsPaidDbCommand\(Guid, decimal, DateTime\)

```csharp
public MarkInvoiceAsPaidDbCommand(Guid InvoiceId, decimal AmountPaid, DateTime PaymentDate)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`AmountPaid` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`PaymentDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

## Properties

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_AmountPaid"></a> AmountPaid

```csharp
public decimal AmountPaid { get; init; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_PaymentDate"></a> PaymentDate

```csharp
public DateTime PaymentDate { get; init; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

## Methods

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand <Clone>$()
```

#### Returns

 [MarkInvoiceAsPaidCommandHandler](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.md).[MarkInvoiceAsPaidDbCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand.md)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_Deconstruct_System_Guid__System_Decimal__System_DateTime__"></a> Deconstruct\(out Guid, out decimal, out DateTime\)

```csharp
public void Deconstruct(out Guid InvoiceId, out decimal AmountPaid, out DateTime PaymentDate)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`AmountPaid` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`PaymentDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_Equals_Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_"></a> Equals\(MarkInvoiceAsPaidDbCommand?\)

```csharp
public bool Equals(MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand? other)
```

#### Parameters

`other` [MarkInvoiceAsPaidCommandHandler](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.md).[MarkInvoiceAsPaidDbCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_ToDbParams"></a> ToDbParams\(\)

```csharp
public object ToDbParams()
```

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_op_Equality_Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_"></a> operator ==\(MarkInvoiceAsPaidDbCommand?, MarkInvoiceAsPaidDbCommand?\)

```csharp
public static bool operator ==(MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand? left, MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand? right)
```

#### Parameters

`left` [MarkInvoiceAsPaidCommandHandler](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.md).[MarkInvoiceAsPaidDbCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand.md)?

`right` [MarkInvoiceAsPaidCommandHandler](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.md).[MarkInvoiceAsPaidDbCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_op_Inequality_Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_Billing_Invoices_Commands_MarkInvoiceAsPaidCommandHandler_MarkInvoiceAsPaidDbCommand_"></a> operator \!=\(MarkInvoiceAsPaidDbCommand?, MarkInvoiceAsPaidDbCommand?\)

```csharp
public static bool operator !=(MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand? left, MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand? right)
```

#### Parameters

`left` [MarkInvoiceAsPaidCommandHandler](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.md).[MarkInvoiceAsPaidDbCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand.md)?

`right` [MarkInvoiceAsPaidCommandHandler](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.md).[MarkInvoiceAsPaidDbCommand](Billing.Invoices.Commands.MarkInvoiceAsPaidCommandHandler.MarkInvoiceAsPaidDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

