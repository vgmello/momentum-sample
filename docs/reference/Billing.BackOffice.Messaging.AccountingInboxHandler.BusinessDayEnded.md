# <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded"></a> Class BusinessDayEnded

Namespace: [Billing.BackOffice.Messaging.AccountingInboxHandler](Billing.BackOffice.Messaging.AccountingInboxHandler.md)  
Assembly: Billing.BackOffice.dll  

```csharp
[EventTopic("operations", "accounting", "v1")]
public record BusinessDayEnded : IEquatable<BusinessDayEnded>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BusinessDayEnded](Billing.BackOffice.Messaging.AccountingInboxHandler.BusinessDayEnded.md)

#### Implements

[IEquatable<BusinessDayEnded\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded__ctor_System_DateTime_System_String_System_String_"></a> BusinessDayEnded\(DateTime, string, string\)

```csharp
public BusinessDayEnded(DateTime BusinessDate, string Market, string Region)
```

#### Parameters

`BusinessDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

`Market` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Region` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded__ctor_Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_"></a> BusinessDayEnded\(BusinessDayEnded\)

```csharp
protected BusinessDayEnded(BusinessDayEnded original)
```

#### Parameters

`original` [BusinessDayEnded](Billing.BackOffice.Messaging.AccountingInboxHandler.BusinessDayEnded.md)

## Properties

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_BusinessDate"></a> BusinessDate

```csharp
public DateTime BusinessDate { get; init; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_EqualityContract"></a> EqualityContract

```csharp
protected virtual Type EqualityContract { get; }
```

#### Property Value

 [Type](https://learn.microsoft.com/dotnet/api/system.type)

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_Market"></a> Market

```csharp
public string Market { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_Region"></a> Region

```csharp
public string Region { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded__Clone__"></a> <Clone\>$\(\)

```csharp
public virtual BusinessDayEnded <Clone>$()
```

#### Returns

 [BusinessDayEnded](Billing.BackOffice.Messaging.AccountingInboxHandler.BusinessDayEnded.md)

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_Deconstruct_System_DateTime__System_String__System_String__"></a> Deconstruct\(out DateTime, out string, out string\)

```csharp
public void Deconstruct(out DateTime BusinessDate, out string Market, out string Region)
```

#### Parameters

`BusinessDate` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

`Market` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Region` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_Equals_Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_"></a> Equals\(BusinessDayEnded?\)

```csharp
public virtual bool Equals(BusinessDayEnded? other)
```

#### Parameters

`other` [BusinessDayEnded](Billing.BackOffice.Messaging.AccountingInboxHandler.BusinessDayEnded.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_PrintMembers_System_Text_StringBuilder_"></a> PrintMembers\(StringBuilder\)

```csharp
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_op_Equality_Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_"></a> operator ==\(BusinessDayEnded?, BusinessDayEnded?\)

```csharp
public static bool operator ==(BusinessDayEnded? left, BusinessDayEnded? right)
```

#### Parameters

`left` [BusinessDayEnded](Billing.BackOffice.Messaging.AccountingInboxHandler.BusinessDayEnded.md)?

`right` [BusinessDayEnded](Billing.BackOffice.Messaging.AccountingInboxHandler.BusinessDayEnded.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_op_Inequality_Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_Billing_BackOffice_Messaging_AccountingInboxHandler_BusinessDayEnded_"></a> operator \!=\(BusinessDayEnded?, BusinessDayEnded?\)

```csharp
public static bool operator !=(BusinessDayEnded? left, BusinessDayEnded? right)
```

#### Parameters

`left` [BusinessDayEnded](Billing.BackOffice.Messaging.AccountingInboxHandler.BusinessDayEnded.md)?

`right` [BusinessDayEnded](Billing.BackOffice.Messaging.AccountingInboxHandler.BusinessDayEnded.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

