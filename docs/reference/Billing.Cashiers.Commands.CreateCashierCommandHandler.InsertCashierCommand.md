# <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand"></a> Class CreateCashierCommandHandler.InsertCashierCommand

Namespace: [Billing.Cashiers.Commands](Billing.Cashiers.Commands.md)  
Assembly: Billing.dll  

```csharp
[DbCommand("billing.cashiers_create", null, null, DbParamsCase.Unset, true, null)]
public sealed record CreateCashierCommandHandler.InsertCashierCommand : ICommand<int>, IDbParamsProvider, IEquatable<CreateCashierCommandHandler.InsertCashierCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CreateCashierCommandHandler.InsertCashierCommand](Billing.Cashiers.Commands.CreateCashierCommandHandler.InsertCashierCommand.md)

#### Implements

[ICommand<int\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IDbParamsProvider](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Dapper/IDbParamsProvider.cs), 
[IEquatable<CreateCashierCommandHandler.InsertCashierCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand__ctor_System_Guid_System_String_System_String_"></a> InsertCashierCommand\(Guid, string, string?\)

```csharp
public InsertCashierCommand(Guid CashierId, string Name, string? Email)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Email` [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Properties

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_Email"></a> Email

```csharp
public string? Email { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_Name"></a> Name

```csharp
public string Name { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public CreateCashierCommandHandler.InsertCashierCommand <Clone>$()
```

#### Returns

 [CreateCashierCommandHandler](Billing.Cashiers.Commands.CreateCashierCommandHandler.md).[InsertCashierCommand](Billing.Cashiers.Commands.CreateCashierCommandHandler.InsertCashierCommand.md)

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_Deconstruct_System_Guid__System_String__System_String__"></a> Deconstruct\(out Guid, out string, out string?\)

```csharp
public void Deconstruct(out Guid CashierId, out string Name, out string? Email)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Email` [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_Equals_Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_"></a> Equals\(InsertCashierCommand?\)

```csharp
public bool Equals(CreateCashierCommandHandler.InsertCashierCommand? other)
```

#### Parameters

`other` [CreateCashierCommandHandler](Billing.Cashiers.Commands.CreateCashierCommandHandler.md).[InsertCashierCommand](Billing.Cashiers.Commands.CreateCashierCommandHandler.InsertCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_ToDbParams"></a> ToDbParams\(\)

```csharp
public object ToDbParams()
```

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_op_Equality_Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_"></a> operator ==\(InsertCashierCommand?, InsertCashierCommand?\)

```csharp
public static bool operator ==(CreateCashierCommandHandler.InsertCashierCommand? left, CreateCashierCommandHandler.InsertCashierCommand? right)
```

#### Parameters

`left` [CreateCashierCommandHandler](Billing.Cashiers.Commands.CreateCashierCommandHandler.md).[InsertCashierCommand](Billing.Cashiers.Commands.CreateCashierCommandHandler.InsertCashierCommand.md)?

`right` [CreateCashierCommandHandler](Billing.Cashiers.Commands.CreateCashierCommandHandler.md).[InsertCashierCommand](Billing.Cashiers.Commands.CreateCashierCommandHandler.InsertCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_op_Inequality_Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_Billing_Cashiers_Commands_CreateCashierCommandHandler_InsertCashierCommand_"></a> operator \!=\(InsertCashierCommand?, InsertCashierCommand?\)

```csharp
public static bool operator !=(CreateCashierCommandHandler.InsertCashierCommand? left, CreateCashierCommandHandler.InsertCashierCommand? right)
```

#### Parameters

`left` [CreateCashierCommandHandler](Billing.Cashiers.Commands.CreateCashierCommandHandler.md).[InsertCashierCommand](Billing.Cashiers.Commands.CreateCashierCommandHandler.InsertCashierCommand.md)?

`right` [CreateCashierCommandHandler](Billing.Cashiers.Commands.CreateCashierCommandHandler.md).[InsertCashierCommand](Billing.Cashiers.Commands.CreateCashierCommandHandler.InsertCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

