# <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand"></a> Class UpdateCashierCommandHandler.UpdateCashierDbCommand

Namespace: [Billing.Cashiers.Commands](Billing.Cashiers.Commands.md)  
Assembly: Billing.dll  

```csharp
[DbCommand("billing.cashiers_update", null, null, DbParamsCase.Unset, true, null)]
public sealed record UpdateCashierCommandHandler.UpdateCashierDbCommand : ICommand<int>, IDbParamsProvider, IEquatable<UpdateCashierCommandHandler.UpdateCashierDbCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UpdateCashierCommandHandler.UpdateCashierDbCommand](Billing.Cashiers.Commands.UpdateCashierCommandHandler.UpdateCashierDbCommand.md)

#### Implements

[ICommand<int\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IDbParamsProvider](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Dapper/IDbParamsProvider.cs), 
[IEquatable<UpdateCashierCommandHandler.UpdateCashierDbCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand__ctor_System_Guid_System_String_System_String_"></a> UpdateCashierDbCommand\(Guid, string, string?\)

```csharp
public UpdateCashierDbCommand(Guid CashierId, string Name, string? Email)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Email` [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Properties

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_Email"></a> Email

```csharp
public string? Email { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_Name"></a> Name

```csharp
public string Name { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public UpdateCashierCommandHandler.UpdateCashierDbCommand <Clone>$()
```

#### Returns

 [UpdateCashierCommandHandler](Billing.Cashiers.Commands.UpdateCashierCommandHandler.md).[UpdateCashierDbCommand](Billing.Cashiers.Commands.UpdateCashierCommandHandler.UpdateCashierDbCommand.md)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_Deconstruct_System_Guid__System_String__System_String__"></a> Deconstruct\(out Guid, out string, out string?\)

```csharp
public void Deconstruct(out Guid CashierId, out string Name, out string? Email)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Email` [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_Equals_Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_"></a> Equals\(UpdateCashierDbCommand?\)

```csharp
public bool Equals(UpdateCashierCommandHandler.UpdateCashierDbCommand? other)
```

#### Parameters

`other` [UpdateCashierCommandHandler](Billing.Cashiers.Commands.UpdateCashierCommandHandler.md).[UpdateCashierDbCommand](Billing.Cashiers.Commands.UpdateCashierCommandHandler.UpdateCashierDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_ToDbParams"></a> ToDbParams\(\)

```csharp
public object ToDbParams()
```

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_op_Equality_Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_"></a> operator ==\(UpdateCashierDbCommand?, UpdateCashierDbCommand?\)

```csharp
public static bool operator ==(UpdateCashierCommandHandler.UpdateCashierDbCommand? left, UpdateCashierCommandHandler.UpdateCashierDbCommand? right)
```

#### Parameters

`left` [UpdateCashierCommandHandler](Billing.Cashiers.Commands.UpdateCashierCommandHandler.md).[UpdateCashierDbCommand](Billing.Cashiers.Commands.UpdateCashierCommandHandler.UpdateCashierDbCommand.md)?

`right` [UpdateCashierCommandHandler](Billing.Cashiers.Commands.UpdateCashierCommandHandler.md).[UpdateCashierDbCommand](Billing.Cashiers.Commands.UpdateCashierCommandHandler.UpdateCashierDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_op_Inequality_Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_Billing_Cashiers_Commands_UpdateCashierCommandHandler_UpdateCashierDbCommand_"></a> operator \!=\(UpdateCashierDbCommand?, UpdateCashierDbCommand?\)

```csharp
public static bool operator !=(UpdateCashierCommandHandler.UpdateCashierDbCommand? left, UpdateCashierCommandHandler.UpdateCashierDbCommand? right)
```

#### Parameters

`left` [UpdateCashierCommandHandler](Billing.Cashiers.Commands.UpdateCashierCommandHandler.md).[UpdateCashierDbCommand](Billing.Cashiers.Commands.UpdateCashierCommandHandler.UpdateCashierDbCommand.md)?

`right` [UpdateCashierCommandHandler](Billing.Cashiers.Commands.UpdateCashierCommandHandler.md).[UpdateCashierDbCommand](Billing.Cashiers.Commands.UpdateCashierCommandHandler.UpdateCashierDbCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

