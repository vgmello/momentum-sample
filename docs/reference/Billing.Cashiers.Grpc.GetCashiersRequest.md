# <a id="Billing_Cashiers_Grpc_GetCashiersRequest"></a> Class GetCashiersRequest

Namespace: [Billing.Cashiers.Grpc](Billing.Cashiers.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class GetCashiersRequest : IMessage<GetCashiersRequest>, IEquatable<GetCashiersRequest>, IDeepCloneable<GetCashiersRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetCashiersRequest](Billing.Cashiers.Grpc.GetCashiersRequest.md)

#### Implements

IMessage<GetCashiersRequest\>, 
[IEquatable<GetCashiersRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<GetCashiersRequest\>, 
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

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest__ctor"></a> GetCashiersRequest\(\)

```csharp
public GetCashiersRequest()
```

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest__ctor_Billing_Cashiers_Grpc_GetCashiersRequest_"></a> GetCashiersRequest\(GetCashiersRequest\)

```csharp
public GetCashiersRequest(GetCashiersRequest other)
```

#### Parameters

`other` [GetCashiersRequest](Billing.Cashiers.Grpc.GetCashiersRequest.md)

## Fields

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_LimitFieldNumber"></a> LimitFieldNumber

Field number for the "limit" field.

```csharp
public const int LimitFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_OffsetFieldNumber"></a> OffsetFieldNumber

Field number for the "offset" field.

```csharp
public const int OffsetFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_Limit"></a> Limit

```csharp
public int Limit { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_Offset"></a> Offset

```csharp
public int Offset { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_Parser"></a> Parser

```csharp
public static MessageParser<GetCashiersRequest> Parser { get; }
```

#### Property Value

 MessageParser<[GetCashiersRequest](Billing.Cashiers.Grpc.GetCashiersRequest.md)\>

## Methods

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_Clone"></a> Clone\(\)

```csharp
public GetCashiersRequest Clone()
```

#### Returns

 [GetCashiersRequest](Billing.Cashiers.Grpc.GetCashiersRequest.md)

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_Equals_Billing_Cashiers_Grpc_GetCashiersRequest_"></a> Equals\(GetCashiersRequest\)

```csharp
public bool Equals(GetCashiersRequest other)
```

#### Parameters

`other` [GetCashiersRequest](Billing.Cashiers.Grpc.GetCashiersRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_MergeFrom_Billing_Cashiers_Grpc_GetCashiersRequest_"></a> MergeFrom\(GetCashiersRequest\)

```csharp
public void MergeFrom(GetCashiersRequest other)
```

#### Parameters

`other` [GetCashiersRequest](Billing.Cashiers.Grpc.GetCashiersRequest.md)

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_GetCashiersRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

