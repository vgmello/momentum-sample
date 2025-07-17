# <a id="Billing_Invoices_Grpc_GetInvoicesRequest"></a> Class GetInvoicesRequest

Namespace: [Billing.Invoices.Grpc](Billing.Invoices.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class GetInvoicesRequest : IMessage<GetInvoicesRequest>, IEquatable<GetInvoicesRequest>, IDeepCloneable<GetInvoicesRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetInvoicesRequest](Billing.Invoices.Grpc.GetInvoicesRequest.md)

#### Implements

IMessage<GetInvoicesRequest\>, 
[IEquatable<GetInvoicesRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<GetInvoicesRequest\>, 
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

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest__ctor"></a> GetInvoicesRequest\(\)

```csharp
public GetInvoicesRequest()
```

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest__ctor_Billing_Invoices_Grpc_GetInvoicesRequest_"></a> GetInvoicesRequest\(GetInvoicesRequest\)

```csharp
public GetInvoicesRequest(GetInvoicesRequest other)
```

#### Parameters

`other` [GetInvoicesRequest](Billing.Invoices.Grpc.GetInvoicesRequest.md)

## Fields

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_LimitFieldNumber"></a> LimitFieldNumber

Field number for the "limit" field.

```csharp
public const int LimitFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_OffsetFieldNumber"></a> OffsetFieldNumber

Field number for the "offset" field.

```csharp
public const int OffsetFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_StatusFieldNumber"></a> StatusFieldNumber

Field number for the "status" field.

```csharp
public const int StatusFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_Limit"></a> Limit

```csharp
public int Limit { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_Offset"></a> Offset

```csharp
public int Offset { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_Parser"></a> Parser

```csharp
public static MessageParser<GetInvoicesRequest> Parser { get; }
```

#### Property Value

 MessageParser<[GetInvoicesRequest](Billing.Invoices.Grpc.GetInvoicesRequest.md)\>

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_Status"></a> Status

```csharp
public string Status { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_Clone"></a> Clone\(\)

```csharp
public GetInvoicesRequest Clone()
```

#### Returns

 [GetInvoicesRequest](Billing.Invoices.Grpc.GetInvoicesRequest.md)

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_Equals_Billing_Invoices_Grpc_GetInvoicesRequest_"></a> Equals\(GetInvoicesRequest\)

```csharp
public bool Equals(GetInvoicesRequest other)
```

#### Parameters

`other` [GetInvoicesRequest](Billing.Invoices.Grpc.GetInvoicesRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_MergeFrom_Billing_Invoices_Grpc_GetInvoicesRequest_"></a> MergeFrom\(GetInvoicesRequest\)

```csharp
public void MergeFrom(GetInvoicesRequest other)
```

#### Parameters

`other` [GetInvoicesRequest](Billing.Invoices.Grpc.GetInvoicesRequest.md)

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_GetInvoicesRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

