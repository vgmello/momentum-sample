# <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated"></a> Class CashierCreated

Namespace: [Billing.Cashiers.Contracts.IntegrationEvents](Billing.Cashiers.Contracts.IntegrationEvents.md)  
Assembly: Billing.dll, Billing.Contracts.dll  

```csharp
[EventTopic<Cashier>(null, "v1")]
public record CashierCreated : IEquatable<CashierCreated>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)

#### Implements

[IEquatable<CashierCreated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated__ctor_System_Guid_System_Int32_Billing_Cashiers_Contracts_Models_Cashier_"></a> CashierCreated\(Guid, int, Cashier\)

```csharp
public CashierCreated(Guid TenantId, int PartitionKeyTest, Cashier Cashier)
```

#### Parameters

`TenantId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`PartitionKeyTest` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Cashier` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated__ctor_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_"></a> CashierCreated\(CashierCreated\)

```csharp
protected CashierCreated(CashierCreated original)
```

#### Parameters

`original` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated__ctor_System_Guid_System_Int32_Billing_Cashiers_Contracts_Models_Cashier_"></a> CashierCreated\(Guid, int, Cashier\)

```csharp
public CashierCreated(Guid TenantId, int PartitionKeyTest, Cashier Cashier)
```

#### Parameters

`TenantId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`PartitionKeyTest` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Cashier` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated__ctor_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_"></a> CashierCreated\(CashierCreated\)

```csharp
protected CashierCreated(CashierCreated original)
```

#### Parameters

`original` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)

## Properties

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Cashier"></a> Cashier

```csharp
public Cashier Cashier { get; init; }
```

#### Property Value

 [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Cashier"></a> Cashier

```csharp
public Cashier Cashier { get; init; }
```

#### Property Value

 [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_PartitionKeyTest"></a> PartitionKeyTest

```csharp
public int PartitionKeyTest { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_PartitionKeyTest"></a> PartitionKeyTest

```csharp
public int PartitionKeyTest { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_TenantId"></a> TenantId

```csharp
public Guid TenantId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_TenantId"></a> TenantId

```csharp
public Guid TenantId { get; init; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

## Methods

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual CashierCreated <Clone>$()
```

#### Returns

 [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual CashierCreated <Clone>$()
```

#### Returns

 [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Deconstruct_System_Guid__System_Int32__Billing_Cashiers_Contracts_Models_Cashier__"></a> Deconstruct\(out Guid, out int, out Cashier\)

```csharp
public void Deconstruct(out Guid TenantId, out int PartitionKeyTest, out Cashier Cashier)
```

#### Parameters

`TenantId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`PartitionKeyTest` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Cashier` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Deconstruct_System_Guid__System_Int32__Billing_Cashiers_Contracts_Models_Cashier__"></a> Deconstruct\(out Guid, out int, out Cashier\)

```csharp
public void Deconstruct(out Guid TenantId, out int PartitionKeyTest, out Cashier Cashier)
```

#### Parameters

`TenantId` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

`PartitionKeyTest` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`Cashier` [Cashier](Billing.Cashiers.Contracts.Models.Cashier.md)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Equals_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_"></a> Equals\(CashierCreated?\)

```csharp
public virtual bool Equals(CashierCreated? other)
```

#### Parameters

`other` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Equals_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_"></a> Equals\(CashierCreated?\)

```csharp
public virtual bool Equals(CashierCreated? other)
```

#### Parameters

`other` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_op_Equality_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_"></a> operator ==\(CashierCreated?, CashierCreated?\)

```csharp
public static bool operator ==(CashierCreated? left, CashierCreated? right)
```

#### Parameters

`left` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)?

`right` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_op_Equality_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_"></a> operator ==\(CashierCreated?, CashierCreated?\)

```csharp
public static bool operator ==(CashierCreated? left, CashierCreated? right)
```

#### Parameters

`left` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)?

`right` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_op_Inequality_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_"></a> operator \!=\(CashierCreated?, CashierCreated?\)

```csharp
public static bool operator !=(CashierCreated? left, CashierCreated? right)
```

#### Parameters

`left` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)?

`right` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_op_Inequality_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_Billing_Cashiers_Contracts_IntegrationEvents_CashierCreated_"></a> operator \!=\(CashierCreated?, CashierCreated?\)

```csharp
public static bool operator !=(CashierCreated? left, CashierCreated? right)
```

#### Parameters

`left` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)?

`right` [CashierCreated](Billing.Cashiers.Contracts.IntegrationEvents.CashierCreated.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

