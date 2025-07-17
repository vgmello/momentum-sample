# <a id="Billing_Cashiers_Grpc_CreateCashierRequest"></a> Class CreateCashierRequest

Namespace: [Billing.Cashiers.Grpc](Billing.Cashiers.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class CreateCashierRequest : IMessage<CreateCashierRequest>, IEquatable<CreateCashierRequest>, IDeepCloneable<CreateCashierRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CreateCashierRequest](Billing.Cashiers.Grpc.CreateCashierRequest.md)

#### Implements

IMessage<CreateCashierRequest\>, 
[IEquatable<CreateCashierRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CreateCashierRequest\>, 
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

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest__ctor"></a> CreateCashierRequest\(\)

```csharp
public CreateCashierRequest()
```

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest__ctor_Billing_Cashiers_Grpc_CreateCashierRequest_"></a> CreateCashierRequest\(CreateCashierRequest\)

```csharp
public CreateCashierRequest(CreateCashierRequest other)
```

#### Parameters

`other` [CreateCashierRequest](Billing.Cashiers.Grpc.CreateCashierRequest.md)

## Fields

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_EmailFieldNumber"></a> EmailFieldNumber

Field number for the "email" field.

```csharp
public const int EmailFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_NameFieldNumber"></a> NameFieldNumber

Field number for the "name" field.

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_Email"></a> Email

```csharp
public string Email { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_Parser"></a> Parser

```csharp
public static MessageParser<CreateCashierRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CreateCashierRequest](Billing.Cashiers.Grpc.CreateCashierRequest.md)\>

## Methods

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_Clone"></a> Clone\(\)

```csharp
public CreateCashierRequest Clone()
```

#### Returns

 [CreateCashierRequest](Billing.Cashiers.Grpc.CreateCashierRequest.md)

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_Equals_Billing_Cashiers_Grpc_CreateCashierRequest_"></a> Equals\(CreateCashierRequest\)

```csharp
public bool Equals(CreateCashierRequest other)
```

#### Parameters

`other` [CreateCashierRequest](Billing.Cashiers.Grpc.CreateCashierRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_MergeFrom_Billing_Cashiers_Grpc_CreateCashierRequest_"></a> MergeFrom\(CreateCashierRequest\)

```csharp
public void MergeFrom(CreateCashierRequest other)
```

#### Parameters

`other` [CreateCashierRequest](Billing.Cashiers.Grpc.CreateCashierRequest.md)

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_CreateCashierRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

