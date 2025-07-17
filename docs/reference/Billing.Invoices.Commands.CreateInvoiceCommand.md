# <a id="Billing_Invoices_Commands_CreateInvoiceCommand"></a> Class CreateInvoiceCommand

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public record CreateInvoiceCommand : ICommand<Result<Invoice>>, IEquatable<CreateInvoiceCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CreateInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommand.md)

#### Implements

[ICommand<Result<Invoice\>\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IEquatable<CreateInvoiceCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand__ctor_System_String_System_Decimal_System_String_System_Nullable_System_DateTime__System_Nullable_System_Guid__"></a> CreateInvoiceCommand\(string, decimal, string?, DateTime?, Guid?\)

```csharp
public CreateInvoiceCommand(string Name, decimal Amount, string? Currency = "", DateTime? DueDate = null, Guid? CashierId = null)
```

#### Parameters

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`DueDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)?

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand__ctor_Billing_Invoices_Commands_CreateInvoiceCommand_"></a> CreateInvoiceCommand\(CreateInvoiceCommand\)

```csharp
protected CreateInvoiceCommand(CreateInvoiceCommand original)
```

#### Parameters

`original` [CreateInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommand.md)

## Properties

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_Amount"></a> Amount

```csharp
public decimal Amount { get; init; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_CashierId"></a> CashierId

```csharp
public Guid? CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)?

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_Currency"></a> Currency

```csharp
public string? Currency { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_DueDate"></a> DueDate

```csharp
public DateTime? DueDate { get; init; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_Name"></a> Name

```csharp
public string Name { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual CreateInvoiceCommand <Clone>$()
```

#### Returns

 [CreateInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommand.md)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_Deconstruct_System_String__System_Decimal__System_String__System_Nullable_System_DateTime___System_Nullable_System_Guid___"></a> Deconstruct\(out string, out decimal, out string?, out DateTime?, out Guid?\)

```csharp
public void Deconstruct(out string Name, out decimal Amount, out string? Currency, out DateTime? DueDate, out Guid? CashierId)
```

#### Parameters

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`DueDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)?

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_Equals_Billing_Invoices_Commands_CreateInvoiceCommand_"></a> Equals\(CreateInvoiceCommand?\)

```csharp
public virtual bool Equals(CreateInvoiceCommand? other)
```

#### Parameters

`other` [CreateInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_op_Equality_Billing_Invoices_Commands_CreateInvoiceCommand_Billing_Invoices_Commands_CreateInvoiceCommand_"></a> operator ==\(CreateInvoiceCommand?, CreateInvoiceCommand?\)

```csharp
public static bool operator ==(CreateInvoiceCommand? left, CreateInvoiceCommand? right)
```

#### Parameters

`left` [CreateInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommand.md)?

`right` [CreateInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommand_op_Inequality_Billing_Invoices_Commands_CreateInvoiceCommand_Billing_Invoices_Commands_CreateInvoiceCommand_"></a> operator \!=\(CreateInvoiceCommand?, CreateInvoiceCommand?\)

```csharp
public static bool operator !=(CreateInvoiceCommand? left, CreateInvoiceCommand? right)
```

#### Parameters

`left` [CreateInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommand.md)?

`right` [CreateInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

