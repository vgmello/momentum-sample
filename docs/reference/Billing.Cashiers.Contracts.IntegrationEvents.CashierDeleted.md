# <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted"></a> Class CashierDeleted

Namespace: [Billing.Cashiers.Contracts.IntegrationEvents](Billing.Cashiers.Contracts.IntegrationEvents.md)  
Assembly: Billing.dll, Billing.Contracts.dll  

```csharp
[EventTopic<Cashier>(null, "v1")]
public record CashierDeleted : IEquatable<CashierDeleted>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)

#### Implements

[IEquatable<CashierDeleted\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted__ctor_System_Guid_"></a> CashierDeleted\(Guid\)

```csharp
public CashierDeleted(Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted__ctor_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_"></a> CashierDeleted\(CashierDeleted\)

```csharp
protected CashierDeleted(CashierDeleted original)
```

#### Parameters

`original` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted__ctor_System_Guid_"></a> CashierDeleted\(Guid\)

```csharp
public CashierDeleted(Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted__ctor_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_"></a> CashierDeleted\(CashierDeleted\)

```csharp
protected CashierDeleted(CashierDeleted original)
```

#### Parameters

`original` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)

## Properties

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_CashierId"></a> CashierId

```csharp
public Guid CashierId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

## Methods

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual CashierDeleted <Clone>$()
```

#### Returns

 [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual CashierDeleted <Clone>$()
```

#### Returns

 [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_Deconstruct_System_Guid__"></a> Deconstruct\(out Guid\)

```csharp
public void Deconstruct(out Guid CashierId)
```

#### Parameters

`CashierId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_Equals_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_"></a> Equals\(CashierDeleted?\)

```csharp
public virtual bool Equals(CashierDeleted? other)
```

#### Parameters

`other` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_Equals_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_"></a> Equals\(CashierDeleted?\)

```csharp
public virtual bool Equals(CashierDeleted? other)
```

#### Parameters

`other` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_op_Equality_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_"></a> operator ==\(CashierDeleted?, CashierDeleted?\)

```csharp
public static bool operator ==(CashierDeleted? left, CashierDeleted? right)
```

#### Parameters

`left` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)?

`right` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_op_Equality_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_"></a> operator ==\(CashierDeleted?, CashierDeleted?\)

```csharp
public static bool operator ==(CashierDeleted? left, CashierDeleted? right)
```

#### Parameters

`left` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)?

`right` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_op_Inequality_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_"></a> operator \!=\(CashierDeleted?, CashierDeleted?\)

```csharp
public static bool operator !=(CashierDeleted? left, CashierDeleted? right)
```

#### Parameters

`left` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)?

`right` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_op_Inequality_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_Billing_Cashiers_Contracts_IntegrationEvents_CashierDeleted_"></a> operator \!=\(CashierDeleted?, CashierDeleted?\)

```csharp
public static bool operator !=(CashierDeleted? left, CashierDeleted? right)
```

#### Parameters

`left` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)?

`right` [CashierDeleted](Billing.Cashiers.Contracts.IntegrationEvents.CashierDeleted.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

