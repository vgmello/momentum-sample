# <a id="Billing_Cashiers_Grpc_GetCashiersResponse"></a> Class GetCashiersResponse

Namespace: [Billing.Cashiers.Grpc](Billing.Cashiers.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class GetCashiersResponse : IMessage<GetCashiersResponse>, IEquatable<GetCashiersResponse>, IDeepCloneable<GetCashiersResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetCashiersResponse](Billing.Cashiers.Grpc.GetCashiersResponse.md)

#### Implements

IMessage<GetCashiersResponse\>, 
[IEquatable<GetCashiersResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<GetCashiersResponse\>, 
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

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse__ctor"></a> GetCashiersResponse\(\)

```csharp
public GetCashiersResponse()
```

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse__ctor_Billing_Cashiers_Grpc_GetCashiersResponse_"></a> GetCashiersResponse\(GetCashiersResponse\)

```csharp
public GetCashiersResponse(GetCashiersResponse other)
```

#### Parameters

`other` [GetCashiersResponse](Billing.Cashiers.Grpc.GetCashiersResponse.md)

## Fields

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_CashiersFieldNumber"></a> CashiersFieldNumber

Field number for the "cashiers" field.

```csharp
public const int CashiersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_Cashiers"></a> Cashiers

```csharp
public RepeatedField<Cashier> Cashiers { get; }
```

#### Property Value

 RepeatedField<[Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)\>

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_Parser"></a> Parser

```csharp
public static MessageParser<GetCashiersResponse> Parser { get; }
```

#### Property Value

 MessageParser<[GetCashiersResponse](Billing.Cashiers.Grpc.GetCashiersResponse.md)\>

## Methods

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_Clone"></a> Clone\(\)

```csharp
public GetCashiersResponse Clone()
```

#### Returns

 [GetCashiersResponse](Billing.Cashiers.Grpc.GetCashiersResponse.md)

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_Equals_Billing_Cashiers_Grpc_GetCashiersResponse_"></a> Equals\(GetCashiersResponse\)

```csharp
public bool Equals(GetCashiersResponse other)
```

#### Parameters

`other` [GetCashiersResponse](Billing.Cashiers.Grpc.GetCashiersResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_MergeFrom_Billing_Cashiers_Grpc_GetCashiersResponse_"></a> MergeFrom\(GetCashiersResponse\)

```csharp
public void MergeFrom(GetCashiersResponse other)
```

#### Parameters

`other` [GetCashiersResponse](Billing.Cashiers.Grpc.GetCashiersResponse.md)

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_GetCashiersResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

