# <a id="Billing_Cashiers_Commands_CreateCashierCommand"></a> Class CreateCashierCommand

Namespace: [Billing.Cashiers.Commands](Billing.Cashiers.Commands.md)  
Assembly: Billing.dll  

```csharp
public record CreateCashierCommand : ICommand<Result<Cashier>>, IEquatable<CreateCashierCommand>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CreateCashierCommand](Billing.Cashiers.Commands.CreateCashierCommand.md)

#### Implements

[ICommand<Result<Cashier\>\>](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions.Abstractions/Messaging/ICommand.cs), 
[IEquatable<CreateCashierCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Commands_CreateCashierCommand__ctor_System_Guid_System_String_System_String_"></a> CreateCashierCommand\(Guid, string, string\)

```csharp
public CreateCashierCommand(Guid TenantId, string Name, string Email)
```

#### Parameters

`TenantId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Email` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Commands_CreateCashierCommand__ctor_Billing_Cashiers_Commands_CreateCashierCommand_"></a> CreateCashierCommand\(CreateCashierCommand\)

```csharp
protected CreateCashierCommand(CreateCashierCommand original)
```

#### Parameters

`original` [CreateCashierCommand](Billing.Cashiers.Commands.CreateCashierCommand.md)

## Properties

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_Email"></a> Email

```csharp
public string Email { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_Name"></a> Name

```csharp
public string Name { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_TenantId"></a> TenantId

```csharp
public Guid TenantId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Methods

### <a id="Billing_Cashiers_Commands_CreateCashierCommand__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual CreateCashierCommand <Clone>$()
```

#### Returns

 [CreateCashierCommand](Billing.Cashiers.Commands.CreateCashierCommand.md)

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_Deconstruct_System_Guid__System_String__System_String__"></a> Deconstruct\(out Guid, out string, out string\)

```csharp
public void Deconstruct(out Guid TenantId, out string Name, out string Email)
```

#### Parameters

`TenantId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Email` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_Equals_Billing_Cashiers_Commands_CreateCashierCommand_"></a> Equals\(CreateCashierCommand?\)

```csharp
public virtual bool Equals(CreateCashierCommand? other)
```

#### Parameters

`other` [CreateCashierCommand](Billing.Cashiers.Commands.CreateCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_op_Equality_Billing_Cashiers_Commands_CreateCashierCommand_Billing_Cashiers_Commands_CreateCashierCommand_"></a> operator ==\(CreateCashierCommand?, CreateCashierCommand?\)

```csharp
public static bool operator ==(CreateCashierCommand? left, CreateCashierCommand? right)
```

#### Parameters

`left` [CreateCashierCommand](Billing.Cashiers.Commands.CreateCashierCommand.md)?

`right` [CreateCashierCommand](Billing.Cashiers.Commands.CreateCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Commands_CreateCashierCommand_op_Inequality_Billing_Cashiers_Commands_CreateCashierCommand_Billing_Cashiers_Commands_CreateCashierCommand_"></a> operator \!=\(CreateCashierCommand?, CreateCashierCommand?\)

```csharp
public static bool operator !=(CreateCashierCommand? left, CreateCashierCommand? right)
```

#### Parameters

`left` [CreateCashierCommand](Billing.Cashiers.Commands.CreateCashierCommand.md)?

`right` [CreateCashierCommand](Billing.Cashiers.Commands.CreateCashierCommand.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

