# <a id="Billing_Invoices_Grpc_GetInvoiceRequest"></a> Class GetInvoiceRequest

Namespace: [Billing.Invoices.Grpc](Billing.Invoices.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class GetInvoiceRequest : IMessage<GetInvoiceRequest>, IEquatable<GetInvoiceRequest>, IDeepCloneable<GetInvoiceRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetInvoiceRequest](Billing.Invoices.Grpc.GetInvoiceRequest.md)

#### Implements

IMessage<GetInvoiceRequest\>, 
[IEquatable<GetInvoiceRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<GetInvoiceRequest\>, 
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

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest__ctor"></a> GetInvoiceRequest\(\)

```csharp
public GetInvoiceRequest()
```

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest__ctor_Billing_Invoices_Grpc_GetInvoiceRequest_"></a> GetInvoiceRequest\(GetInvoiceRequest\)

```csharp
public GetInvoiceRequest(GetInvoiceRequest other)
```

#### Parameters

`other` [GetInvoiceRequest](Billing.Invoices.Grpc.GetInvoiceRequest.md)

## Fields

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_IdFieldNumber"></a> IdFieldNumber

Field number for the "id" field.

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_Id"></a> Id

```csharp
public string Id { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_Parser"></a> Parser

```csharp
public static MessageParser<GetInvoiceRequest> Parser { get; }
```

#### Property Value

 MessageParser<[GetInvoiceRequest](Billing.Invoices.Grpc.GetInvoiceRequest.md)\>

## Methods

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_Clone"></a> Clone\(\)

```csharp
public GetInvoiceRequest Clone()
```

#### Returns

 [GetInvoiceRequest](Billing.Invoices.Grpc.GetInvoiceRequest.md)

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_Equals_Billing_Invoices_Grpc_GetInvoiceRequest_"></a> Equals\(GetInvoiceRequest\)

```csharp
public bool Equals(GetInvoiceRequest other)
```

#### Parameters

`other` [GetInvoiceRequest](Billing.Invoices.Grpc.GetInvoiceRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_MergeFrom_Billing_Invoices_Grpc_GetInvoiceRequest_"></a> MergeFrom\(GetInvoiceRequest\)

```csharp
public void MergeFrom(GetInvoiceRequest other)
```

#### Parameters

`other` [GetInvoiceRequest](Billing.Invoices.Grpc.GetInvoiceRequest.md)

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_GetInvoiceRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

