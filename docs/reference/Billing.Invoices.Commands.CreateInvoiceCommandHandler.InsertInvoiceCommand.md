# <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand"></a> Class CreateInvoiceCommandHandler.InsertInvoiceCommand

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
[DbCommand("billing.invoices_create", null, null, DbParamsCase.Unset, true, null)]
public sealed record CreateInvoiceCommandHandler.InsertInvoiceCommand : ICommand<int>, IDbParamsProvider, IEquatable<CreateInvoiceCommandHandler.InsertInvoiceCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CreateInvoiceCommandHandler.InsertInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommandHandler.InsertInvoiceCommand.md)

#### Implements

[ICommand<int\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IDbParamsProvider](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Dapper/IDbParamsProvider.cs), 
[IEquatable<CreateInvoiceCommandHandler.InsertInvoiceCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand__ctor_System_Guid_System_String_System_String_System_Decimal_System_String_System_Nullable_System_DateTime__System_Nullable_System_Guid__"></a> InsertInvoiceCommand\(Guid, string, string, decimal, string?, DateTime?, Guid?\)

```csharp
public InsertInvoiceCommand(Guid InvoiceId, string Name, string Status, decimal Amount, string? Currency, DateTime? DueDate, Guid? CashierId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Status` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`DueDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)?

## Properties

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_Amount"></a> Amount

```csharp
public decimal Amount { get; init; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_CashierId"></a> CashierId

```csharp
public Guid? CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)?

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_Currency"></a> Currency

```csharp
public string? Currency { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_DueDate"></a> DueDate

```csharp
public DateTime? DueDate { get; init; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_Name"></a> Name

```csharp
public string Name { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_Status"></a> Status

```csharp
public string Status { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public CreateInvoiceCommandHandler.InsertInvoiceCommand <Clone>$()
```

#### Returns

 [CreateInvoiceCommandHandler](Billing.Invoices.Commands.CreateInvoiceCommandHandler.md).[InsertInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommandHandler.InsertInvoiceCommand.md)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_Deconstruct_System_Guid__System_String__System_String__System_Decimal__System_String__System_Nullable_System_DateTime___System_Nullable_System_Guid___"></a> Deconstruct\(out Guid, out string, out string, out decimal, out string?, out DateTime?, out Guid?\)

```csharp
public void Deconstruct(out Guid InvoiceId, out string Name, out string Status, out decimal Amount, out string? Currency, out DateTime? DueDate, out Guid? CashierId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Status` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`Currency` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`DueDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)?

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)?

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_Equals_Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_"></a> Equals\(InsertInvoiceCommand?\)

```csharp
public bool Equals(CreateInvoiceCommandHandler.InsertInvoiceCommand? other)
```

#### Parameters

`other` [CreateInvoiceCommandHandler](Billing.Invoices.Commands.CreateInvoiceCommandHandler.md).[InsertInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommandHandler.InsertInvoiceCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_ToDbParams"></a> ToDbParams\(\)

```csharp
public object ToDbParams()
```

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_op_Equality_Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_"></a> operator ==\(InsertInvoiceCommand?, InsertInvoiceCommand?\)

```csharp
public static bool operator ==(CreateInvoiceCommandHandler.InsertInvoiceCommand? left, CreateInvoiceCommandHandler.InsertInvoiceCommand? right)
```

#### Parameters

`left` [CreateInvoiceCommandHandler](Billing.Invoices.Commands.CreateInvoiceCommandHandler.md).[InsertInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommandHandler.InsertInvoiceCommand.md)?

`right` [CreateInvoiceCommandHandler](Billing.Invoices.Commands.CreateInvoiceCommandHandler.md).[InsertInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommandHandler.InsertInvoiceCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_op_Inequality_Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_Billing_Invoices_Commands_CreateInvoiceCommandHandler_InsertInvoiceCommand_"></a> operator \!=\(InsertInvoiceCommand?, InsertInvoiceCommand?\)

```csharp
public static bool operator !=(CreateInvoiceCommandHandler.InsertInvoiceCommand? left, CreateInvoiceCommandHandler.InsertInvoiceCommand? right)
```

#### Parameters

`left` [CreateInvoiceCommandHandler](Billing.Invoices.Commands.CreateInvoiceCommandHandler.md).[InsertInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommandHandler.InsertInvoiceCommand.md)?

`right` [CreateInvoiceCommandHandler](Billing.Invoices.Commands.CreateInvoiceCommandHandler.md).[InsertInvoiceCommand](Billing.Invoices.Commands.CreateInvoiceCommandHandler.InsertInvoiceCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

