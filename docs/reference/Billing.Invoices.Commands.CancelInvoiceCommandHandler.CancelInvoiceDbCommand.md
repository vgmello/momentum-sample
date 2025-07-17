# <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand"></a> Class CancelInvoiceCommandHandler.CancelInvoiceDbCommand

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
[DbCommand("billing.invoices_cancel", null, null, DbParamsCase.Unset, true, null)]
public sealed record CancelInvoiceCommandHandler.CancelInvoiceDbCommand : ICommand<int>, IDbParamsProvider, IEquatable<CancelInvoiceCommandHandler.CancelInvoiceDbCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CancelInvoiceCommandHandler.CancelInvoiceDbCommand](Billing.Invoices.Commands.CancelInvoiceCommandHandler.CancelInvoiceDbCommand.md)

#### Implements

[ICommand<int\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IDbParamsProvider](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Dapper/IDbParamsProvider.cs), 
[IEquatable<CancelInvoiceCommandHandler.CancelInvoiceDbCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand__ctor_System_Guid_"></a> CancelInvoiceDbCommand\(Guid\)

```csharp
public CancelInvoiceDbCommand(Guid InvoiceId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Properties

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_InvoiceId"></a> InvoiceId

```csharp
public Guid InvoiceId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Methods

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public CancelInvoiceCommandHandler.CancelInvoiceDbCommand <Clone>$()
```

#### Returns

 [CancelInvoiceCommandHandler](Billing.Invoices.Commands.CancelInvoiceCommandHandler.md).[CancelInvoiceDbCommand](Billing.Invoices.Commands.CancelInvoiceCommandHandler.CancelInvoiceDbCommand.md)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid InvoiceId)
```

#### Parameters

`InvoiceId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_Equals_Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_"></a> Equals\(CancelInvoiceDbCommand?\)

```csharp
public bool Equals(CancelInvoiceCommandHandler.CancelInvoiceDbCommand? other)
```

#### Parameters

`other` [CancelInvoiceCommandHandler](Billing.Invoices.Commands.CancelInvoiceCommandHandler.md).[CancelInvoiceDbCommand](Billing.Invoices.Commands.CancelInvoiceCommandHandler.CancelInvoiceDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_ToDbParams"></a> ToDbParams\(\)

```csharp
public object ToDbParams()
```

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_op_Equality_Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_"></a> operator ==\(CancelInvoiceDbCommand?, CancelInvoiceDbCommand?\)

```csharp
public static bool operator ==(CancelInvoiceCommandHandler.CancelInvoiceDbCommand? left, CancelInvoiceCommandHandler.CancelInvoiceDbCommand? right)
```

#### Parameters

`left` [CancelInvoiceCommandHandler](Billing.Invoices.Commands.CancelInvoiceCommandHandler.md).[CancelInvoiceDbCommand](Billing.Invoices.Commands.CancelInvoiceCommandHandler.CancelInvoiceDbCommand.md)?

`right` [CancelInvoiceCommandHandler](Billing.Invoices.Commands.CancelInvoiceCommandHandler.md).[CancelInvoiceDbCommand](Billing.Invoices.Commands.CancelInvoiceCommandHandler.CancelInvoiceDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_op_Inequality_Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_Billing_Invoices_Commands_CancelInvoiceCommandHandler_CancelInvoiceDbCommand_"></a> operator \!=\(CancelInvoiceDbCommand?, CancelInvoiceDbCommand?\)

```csharp
public static bool operator !=(CancelInvoiceCommandHandler.CancelInvoiceDbCommand? left, CancelInvoiceCommandHandler.CancelInvoiceDbCommand? right)
```

#### Parameters

`left` [CancelInvoiceCommandHandler](Billing.Invoices.Commands.CancelInvoiceCommandHandler.md).[CancelInvoiceDbCommand](Billing.Invoices.Commands.CancelInvoiceCommandHandler.CancelInvoiceDbCommand.md)?

`right` [CancelInvoiceCommandHandler](Billing.Invoices.Commands.CancelInvoiceCommandHandler.md).[CancelInvoiceDbCommand](Billing.Invoices.Commands.CancelInvoiceCommandHandler.CancelInvoiceDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

