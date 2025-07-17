# <a id="Billing_Cashiers_Commands_UpdateCashierCommand"></a> Class UpdateCashierCommand

Namespace: [Billing.Cashiers.Commands](Billing.Cashiers.Commands.md)  
Assembly: Billing.dll  

```csharp
public record UpdateCashierCommand : ICommand<Result<Cashier>>, IEquatable<UpdateCashierCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UpdateCashierCommand](Billing.Cashiers.Commands.UpdateCashierCommand.md)

#### Implements

[ICommand<Result<Cashier\>\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IEquatable<UpdateCashierCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand__ctor_System_Guid_System_String_System_String_"></a> UpdateCashierCommand\(Guid, string, string?\)

```csharp
public UpdateCashierCommand(Guid CashierId, string Name, string? Email)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Email` [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand__ctor_Billing_Cashiers_Commands_UpdateCashierCommand_"></a> UpdateCashierCommand\(UpdateCashierCommand\)

```csharp
protected UpdateCashierCommand(UpdateCashierCommand original)
```

#### Parameters

`original` [UpdateCashierCommand](Billing.Cashiers.Commands.UpdateCashierCommand.md)

## Properties

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_Email"></a> Email

```csharp
public string? Email { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_Name"></a> Name

```csharp
public string Name { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual UpdateCashierCommand <Clone>$()
```

#### Returns

 [UpdateCashierCommand](Billing.Cashiers.Commands.UpdateCashierCommand.md)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_Deconstruct_System_Guid__System_String__System_String__"></a> Deconstruct\(out Guid, out string, out string?\)

```csharp
public void Deconstruct(out Guid CashierId, out string Name, out string? Email)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Email` [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_Equals_Billing_Cashiers_Commands_UpdateCashierCommand_"></a> Equals\(UpdateCashierCommand?\)

```csharp
public virtual bool Equals(UpdateCashierCommand? other)
```

#### Parameters

`other` [UpdateCashierCommand](Billing.Cashiers.Commands.UpdateCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_op_Equality_Billing_Cashiers_Commands_UpdateCashierCommand_Billing_Cashiers_Commands_UpdateCashierCommand_"></a> operator ==\(UpdateCashierCommand?, UpdateCashierCommand?\)

```csharp
public static bool operator ==(UpdateCashierCommand? left, UpdateCashierCommand? right)
```

#### Parameters

`left` [UpdateCashierCommand](Billing.Cashiers.Commands.UpdateCashierCommand.md)?

`right` [UpdateCashierCommand](Billing.Cashiers.Commands.UpdateCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_UpdateCashierCommand_op_Inequality_Billing_Cashiers_Commands_UpdateCashierCommand_Billing_Cashiers_Commands_UpdateCashierCommand_"></a> operator \!=\(UpdateCashierCommand?, UpdateCashierCommand?\)

```csharp
public static bool operator !=(UpdateCashierCommand? left, UpdateCashierCommand? right)
```

#### Parameters

`left` [UpdateCashierCommand](Billing.Cashiers.Commands.UpdateCashierCommand.md)?

`right` [UpdateCashierCommand](Billing.Cashiers.Commands.UpdateCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

