# <a id="Billing_Invoices_Grpc_CancelInvoiceRequest"></a> Class CancelInvoiceRequest

Namespace: [Billing.Invoices.Grpc](Billing.Invoices.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class CancelInvoiceRequest : IMessage<CancelInvoiceRequest>, IEquatable<CancelInvoiceRequest>, IDeepCloneable<CancelInvoiceRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CancelInvoiceRequest](Billing.Invoices.Grpc.CancelInvoiceRequest.md)

#### Implements

IMessage<CancelInvoiceRequest\>, 
[IEquatable<CancelInvoiceRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CancelInvoiceRequest\>, 
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

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest__ctor"></a> CancelInvoiceRequest\(\)

```csharp
public CancelInvoiceRequest()
```

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest__ctor_Billing_Invoices_Grpc_CancelInvoiceRequest_"></a> CancelInvoiceRequest\(CancelInvoiceRequest\)

```csharp
public CancelInvoiceRequest(CancelInvoiceRequest other)
```

#### Parameters

`other` [CancelInvoiceRequest](Billing.Invoices.Grpc.CancelInvoiceRequest.md)

## Fields

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_InvoiceIdFieldNumber"></a> InvoiceIdFieldNumber

Field number for the "invoiceId" field.

```csharp
public const int InvoiceIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_InvoiceId"></a> InvoiceId

```csharp
public string InvoiceId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_Parser"></a> Parser

```csharp
public static MessageParser<CancelInvoiceRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CancelInvoiceRequest](Billing.Invoices.Grpc.CancelInvoiceRequest.md)\>

## Methods

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_Clone"></a> Clone\(\)

```csharp
public CancelInvoiceRequest Clone()
```

#### Returns

 [CancelInvoiceRequest](Billing.Invoices.Grpc.CancelInvoiceRequest.md)

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_Equals_Billing_Invoices_Grpc_CancelInvoiceRequest_"></a> Equals\(CancelInvoiceRequest\)

```csharp
public bool Equals(CancelInvoiceRequest other)
```

#### Parameters

`other` [CancelInvoiceRequest](Billing.Invoices.Grpc.CancelInvoiceRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_MergeFrom_Billing_Invoices_Grpc_CancelInvoiceRequest_"></a> MergeFrom\(CancelInvoiceRequest\)

```csharp
public void MergeFrom(CancelInvoiceRequest other)
```

#### Parameters

`other` [CancelInvoiceRequest](Billing.Invoices.Grpc.CancelInvoiceRequest.md)

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_CancelInvoiceRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

