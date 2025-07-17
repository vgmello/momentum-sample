# <a id="Billing_Cashiers_Grpc_Models_Cashier"></a> Class Cashier

Namespace: [Billing.Cashiers.Grpc.Models](Billing.Cashiers.Grpc.Models.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class Cashier : IMessage<Cashier>, IEquatable<Cashier>, IDeepCloneable<Cashier>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)

#### Implements

IMessage<Cashier\>, 
[IEquatable<Cashier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<Cashier\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Grpc_Models_Cashier__ctor"></a> Cashier\(\)

```csharp
public Cashier()
```

### <a id="Billing_Cashiers_Grpc_Models_Cashier__ctor_Billing_Cashiers_Grpc_Models_Cashier_"></a> Cashier\(Cashier\)

```csharp
public Cashier(Cashier other)
```

#### Parameters

`other` [Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)

## Fields

### <a id="Billing_Cashiers_Grpc_Models_Cashier_CashierIdFieldNumber"></a> CashierIdFieldNumber

Field number for the "cashierId" field.

```csharp
public const int CashierIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_EmailFieldNumber"></a> EmailFieldNumber

Field number for the "email" field.

```csharp
public const int EmailFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_NameFieldNumber"></a> NameFieldNumber

Field number for the "name" field.

```csharp
public const int NameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_TenantIdFieldNumber"></a> TenantIdFieldNumber

Field number for the "tenant_id" field.

```csharp
public const int TenantIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Cashiers_Grpc_Models_Cashier_CashierId"></a> CashierId

```csharp
public string CashierId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Cashiers_Grpc_Models_Cashier_Email"></a> Email

```csharp
public string Email { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_Parser"></a> Parser

```csharp
public static MessageParser<Cashier> Parser { get; }
```

#### Property Value

 MessageParser<[Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)\>

### <a id="Billing_Cashiers_Grpc_Models_Cashier_TenantId"></a> TenantId

```csharp
public string TenantId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Cashiers_Grpc_Models_Cashier_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_Clone"></a> Clone\(\)

```csharp
public Cashier Clone()
```

#### Returns

 [Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_Equals_Billing_Cashiers_Grpc_Models_Cashier_"></a> Equals\(Cashier\)

```csharp
public bool Equals(Cashier other)
```

#### Parameters

`other` [Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_MergeFrom_Billing_Cashiers_Grpc_Models_Cashier_"></a> MergeFrom\(Cashier\)

```csharp
public void MergeFrom(Cashier other)
```

#### Parameters

`other` [Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Cashiers_Grpc_Models_Cashier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_Models_Cashier_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

