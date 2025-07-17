# <a id="Billing_Cashiers_Commands_DeleteCashierCommand"></a> Class DeleteCashierCommand

Namespace: [Billing.Cashiers.Commands](Billing.Cashiers.Commands.md)  
Assembly: Billing.dll  

```csharp
public record DeleteCashierCommand : ICommand<Result<bool>>, IEquatable<DeleteCashierCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DeleteCashierCommand](Billing.Cashiers.Commands.DeleteCashierCommand.md)

#### Implements

[ICommand<Result<bool\>\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IEquatable<DeleteCashierCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand__ctor_System_Guid_"></a> DeleteCashierCommand\(Guid\)

```csharp
public DeleteCashierCommand(Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand__ctor_Billing_Cashiers_Commands_DeleteCashierCommand_"></a> DeleteCashierCommand\(DeleteCashierCommand\)

```csharp
protected DeleteCashierCommand(DeleteCashierCommand original)
```

#### Parameters

`original` [DeleteCashierCommand](Billing.Cashiers.Commands.DeleteCashierCommand.md)

## Properties

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

## Methods

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual DeleteCashierCommand <Clone>$()
```

#### Returns

 [DeleteCashierCommand](Billing.Cashiers.Commands.DeleteCashierCommand.md)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand_Equals_Billing_Cashiers_Commands_DeleteCashierCommand_"></a> Equals\(DeleteCashierCommand?\)

```csharp
public virtual bool Equals(DeleteCashierCommand? other)
```

#### Parameters

`other` [DeleteCashierCommand](Billing.Cashiers.Commands.DeleteCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand_op_Equality_Billing_Cashiers_Commands_DeleteCashierCommand_Billing_Cashiers_Commands_DeleteCashierCommand_"></a> operator ==\(DeleteCashierCommand?, DeleteCashierCommand?\)

```csharp
public static bool operator ==(DeleteCashierCommand? left, DeleteCashierCommand? right)
```

#### Parameters

`left` [DeleteCashierCommand](Billing.Cashiers.Commands.DeleteCashierCommand.md)?

`right` [DeleteCashierCommand](Billing.Cashiers.Commands.DeleteCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_DeleteCashierCommand_op_Inequality_Billing_Cashiers_Commands_DeleteCashierCommand_Billing_Cashiers_Commands_DeleteCashierCommand_"></a> operator \!=\(DeleteCashierCommand?, DeleteCashierCommand?\)

```csharp
public static bool operator !=(DeleteCashierCommand? left, DeleteCashierCommand? right)
```

#### Parameters

`left` [DeleteCashierCommand](Billing.Cashiers.Commands.DeleteCashierCommand.md)?

`right` [DeleteCashierCommand](Billing.Cashiers.Commands.DeleteCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

