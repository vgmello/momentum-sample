# <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand"></a> Class DeleteCashierCommandHandler.DeleteCashierDbCommand

Namespace: [Billing.Cashiers.Commands](Billing.Cashiers.Commands.md)  
Assembly: Billing.dll  

```csharp
[DbCommand("billing.cashiers_delete", null, null, DbParamsCase.Unset, true, null)]
public sealed record DeleteCashierCommandHandler.DeleteCashierDbCommand : ICommand<int>, IDbParamsProvider, IEquatable<DeleteCashierCommandHandler.DeleteCashierDbCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DeleteCashierCommandHandler.DeleteCashierDbCommand](Billing.Cashiers.Commands.DeleteCashierCommandHandler.DeleteCashierDbCommand.md)

#### Implements

[ICommand<int\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IDbParamsProvider](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Dapper/IDbParamsProvider.cs), 
[IEquatable<DeleteCashierCommandHandler.DeleteCashierDbCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand__ctor_System_Guid_"></a> DeleteCashierDbCommand\(Guid\)

```csharp
public DeleteCashierDbCommand(Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Properties

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Methods

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public DeleteCashierCommandHandler.DeleteCashierDbCommand <Clone>$()
```

#### Returns

 [DeleteCashierCommandHandler](Billing.Cashiers.Commands.DeleteCashierCommandHandler.md).[DeleteCashierDbCommand](Billing.Cashiers.Commands.DeleteCashierCommandHandler.DeleteCashierDbCommand.md)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_Equals_Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_"></a> Equals\(DeleteCashierDbCommand?\)

```csharp
public bool Equals(DeleteCashierCommandHandler.DeleteCashierDbCommand? other)
```

#### Parameters

`other` [DeleteCashierCommandHandler](Billing.Cashiers.Commands.DeleteCashierCommandHandler.md).[DeleteCashierDbCommand](Billing.Cashiers.Commands.DeleteCashierCommandHandler.DeleteCashierDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_ToDbParams"></a> ToDbParams\(\)

```csharp
public object ToDbParams()
```

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_op_Equality_Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_"></a> operator ==\(DeleteCashierDbCommand?, DeleteCashierDbCommand?\)

```csharp
public static bool operator ==(DeleteCashierCommandHandler.DeleteCashierDbCommand? left, DeleteCashierCommandHandler.DeleteCashierDbCommand? right)
```

#### Parameters

`left` [DeleteCashierCommandHandler](Billing.Cashiers.Commands.DeleteCashierCommandHandler.md).[DeleteCashierDbCommand](Billing.Cashiers.Commands.DeleteCashierCommandHandler.DeleteCashierDbCommand.md)?

`right` [DeleteCashierCommandHandler](Billing.Cashiers.Commands.DeleteCashierCommandHandler.md).[DeleteCashierDbCommand](Billing.Cashiers.Commands.DeleteCashierCommandHandler.DeleteCashierDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_op_Inequality_Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_Billing_Cashiers_Commands_DeleteCashierCommandHandler_DeleteCashierDbCommand_"></a> operator \!=\(DeleteCashierDbCommand?, DeleteCashierDbCommand?\)

```csharp
public static bool operator !=(DeleteCashierCommandHandler.DeleteCashierDbCommand? left, DeleteCashierCommandHandler.DeleteCashierDbCommand? right)
```

#### Parameters

`left` [DeleteCashierCommandHandler](Billing.Cashiers.Commands.DeleteCashierCommandHandler.md).[DeleteCashierDbCommand](Billing.Cashiers.Commands.DeleteCashierCommandHandler.DeleteCashierDbCommand.md)?

`right` [DeleteCashierCommandHandler](Billing.Cashiers.Commands.DeleteCashierCommandHandler.md).[DeleteCashierDbCommand](Billing.Cashiers.Commands.DeleteCashierCommandHandler.DeleteCashierDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

