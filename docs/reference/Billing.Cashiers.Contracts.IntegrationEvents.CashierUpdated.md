# <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated"></a> Class CashierUpdated

Namespace: [Billing.Cashiers.Contracts.IntegrationEvents](Billing.Cashiers.Contracts.IntegrationEvents.md)  
Assembly: Billing.dll, Billing.Contracts.dll  

```csharp
[EventTopic<Cashier>(null, "v1")]
public record CashierUpdated : IEquatable<CashierUpdated>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)

#### Implements

[IEquatable<CashierUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated__ctor_System_Guid_"></a> CashierUpdated\(Guid\)

```csharp
public CashierUpdated(Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated__ctor_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_"></a> CashierUpdated\(CashierUpdated\)

```csharp
protected CashierUpdated(CashierUpdated original)
```

#### Parameters

`original` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated__ctor_System_Guid_"></a> CashierUpdated\(Guid\)

```csharp
public CashierUpdated(Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated__ctor_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_"></a> CashierUpdated\(CashierUpdated\)

```csharp
protected CashierUpdated(CashierUpdated original)
```

#### Parameters

`original` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)

## Properties

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

## Methods

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual CashierUpdated <Clone>$()
```

#### Returns

 [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual CashierUpdated <Clone>$()
```

#### Returns

 [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_Equals_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_"></a> Equals\(CashierUpdated?\)

```csharp
public virtual bool Equals(CashierUpdated? other)
```

#### Parameters

`other` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_Equals_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_"></a> Equals\(CashierUpdated?\)

```csharp
public virtual bool Equals(CashierUpdated? other)
```

#### Parameters

`other` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_op_Equality_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_"></a> operator ==\(CashierUpdated?, CashierUpdated?\)

```csharp
public static bool operator ==(CashierUpdated? left, CashierUpdated? right)
```

#### Parameters

`left` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)?

`right` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_op_Equality_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_"></a> operator ==\(CashierUpdated?, CashierUpdated?\)

```csharp
public static bool operator ==(CashierUpdated? left, CashierUpdated? right)
```

#### Parameters

`left` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)?

`right` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_op_Inequality_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_"></a> operator \!=\(CashierUpdated?, CashierUpdated?\)

```csharp
public static bool operator !=(CashierUpdated? left, CashierUpdated? right)
```

#### Parameters

`left` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)?

`right` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_op_Inequality_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_Billing_Cashiers_Contracts_IntegrationEvents_CashierUpdated_"></a> operator \!=\(CashierUpdated?, CashierUpdated?\)

```csharp
public static bool operator !=(CashierUpdated? left, CashierUpdated? right)
```

#### Parameters

`left` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)?

`right` [CashierUpdated](Billing.Cashiers.Contracts.IntegrationEvents.CashierUpdated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

