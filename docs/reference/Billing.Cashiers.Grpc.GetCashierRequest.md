# <a id="Billing_Cashiers_Grpc_GetCashierRequest"></a> Class GetCashierRequest

Namespace: [Billing.Cashiers.Grpc](Billing.Cashiers.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class GetCashierRequest : IMessage<GetCashierRequest>, IEquatable<GetCashierRequest>, IDeepCloneable<GetCashierRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetCashierRequest](Billing.Cashiers.Grpc.GetCashierRequest.md)

#### Implements

IMessage<GetCashierRequest\>, 
[IEquatable<GetCashierRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<GetCashierRequest\>, 
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

### <a id="Billing_Cashiers_Grpc_GetCashierRequest__ctor"></a> GetCashierRequest\(\)

```csharp
public GetCashierRequest()
```

### <a id="Billing_Cashiers_Grpc_GetCashierRequest__ctor_Billing_Cashiers_Grpc_GetCashierRequest_"></a> GetCashierRequest\(GetCashierRequest\)

```csharp
public GetCashierRequest(GetCashierRequest other)
```

#### Parameters

`other` [GetCashierRequest](Billing.Cashiers.Grpc.GetCashierRequest.md)

## Fields

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_IdFieldNumber"></a> IdFieldNumber

Field number for the "id" field.

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_Id"></a> Id

```csharp
public string Id { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_Parser"></a> Parser

```csharp
public static MessageParser<GetCashierRequest> Parser { get; }
```

#### Property Value

 MessageParser<[GetCashierRequest](Billing.Cashiers.Grpc.GetCashierRequest.md)\>

## Methods

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_Clone"></a> Clone\(\)

```csharp
public GetCashierRequest Clone()
```

#### Returns

 [GetCashierRequest](Billing.Cashiers.Grpc.GetCashierRequest.md)

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_Equals_Billing_Cashiers_Grpc_GetCashierRequest_"></a> Equals\(GetCashierRequest\)

```csharp
public bool Equals(GetCashierRequest other)
```

#### Parameters

`other` [GetCashierRequest](Billing.Cashiers.Grpc.GetCashierRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_MergeFrom_Billing_Cashiers_Grpc_GetCashierRequest_"></a> MergeFrom\(GetCashierRequest\)

```csharp
public void MergeFrom(GetCashierRequest other)
```

#### Parameters

`other` [GetCashierRequest](Billing.Cashiers.Grpc.GetCashierRequest.md)

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_GetCashierRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

