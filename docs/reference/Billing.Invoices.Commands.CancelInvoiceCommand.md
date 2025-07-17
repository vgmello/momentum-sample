# <a id="Billing_Invoices_Commands_CancelInvoiceCommand"></a> Class CancelInvoiceCommand

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public record CancelInvoiceCommand : ICommand<Result<Invoice>>, IEquatable<CancelInvoiceCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CancelInvoiceCommand](Billing.Invoices.Commands.CancelInvoiceCommand.md)

#### Implements

[ICommand<Result<Invoice\>\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IEquatable<CancelInvoiceCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand__ctor_System_Guid_"></a> CancelInvoiceCommand\(Guid\)

```csharp
public CancelInvoiceCommand(Guid InvoiceId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand__ctor_Billing_Invoices_Commands_CancelInvoiceCommand_"></a> CancelInvoiceCommand\(CancelInvoiceCommand\)

```csharp
protected CancelInvoiceCommand(CancelInvoiceCommand original)
```

#### Parameters

`original` [CancelInvoiceCommand](Billing.Invoices.Commands.CancelInvoiceCommand.md)

## Properties

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Methods

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual CancelInvoiceCommand <Clone>$()
```

#### Returns

 [CancelInvoiceCommand](Billing.Invoices.Commands.CancelInvoiceCommand.md)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid InvoiceId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand_Equals_Billing_Invoices_Commands_CancelInvoiceCommand_"></a> Equals\(CancelInvoiceCommand?\)

```csharp
public virtual bool Equals(CancelInvoiceCommand? other)
```

#### Parameters

`other` [CancelInvoiceCommand](Billing.Invoices.Commands.CancelInvoiceCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand_op_Equality_Billing_Invoices_Commands_CancelInvoiceCommand_Billing_Invoices_Commands_CancelInvoiceCommand_"></a> operator ==\(CancelInvoiceCommand?, CancelInvoiceCommand?\)

```csharp
public static bool operator ==(CancelInvoiceCommand? left, CancelInvoiceCommand? right)
```

#### Parameters

`left` [CancelInvoiceCommand](Billing.Invoices.Commands.CancelInvoiceCommand.md)?

`right` [CancelInvoiceCommand](Billing.Invoices.Commands.CancelInvoiceCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommand_op_Inequality_Billing_Invoices_Commands_CancelInvoiceCommand_Billing_Invoices_Commands_CancelInvoiceCommand_"></a> operator \!=\(CancelInvoiceCommand?, CancelInvoiceCommand?\)

```csharp
public static bool operator !=(CancelInvoiceCommand? left, CancelInvoiceCommand? right)
```

#### Parameters

`left` [CancelInvoiceCommand](Billing.Invoices.Commands.CancelInvoiceCommand.md)?

`right` [CancelInvoiceCommand](Billing.Invoices.Commands.CancelInvoiceCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

