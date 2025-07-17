# <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest"></a> Class MarkInvoiceAsPaidRequest

Namespace: [Billing.Invoices.Grpc](Billing.Invoices.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class MarkInvoiceAsPaidRequest : IMessage<MarkInvoiceAsPaidRequest>, IEquatable<MarkInvoiceAsPaidRequest>, IDeepCloneable<MarkInvoiceAsPaidRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MarkInvoiceAsPaidRequest](Billing.Invoices.Grpc.MarkInvoiceAsPaidRequest.md)

#### Implements

IMessage<MarkInvoiceAsPaidRequest\>, 
[IEquatable<MarkInvoiceAsPaidRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<MarkInvoiceAsPaidRequest\>, 
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

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest__ctor"></a> MarkInvoiceAsPaidRequest\(\)

```csharp
public MarkInvoiceAsPaidRequest()
```

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest__ctor_Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_"></a> MarkInvoiceAsPaidRequest\(MarkInvoiceAsPaidRequest\)

```csharp
public MarkInvoiceAsPaidRequest(MarkInvoiceAsPaidRequest other)
```

#### Parameters

`other` [MarkInvoiceAsPaidRequest](Billing.Invoices.Grpc.MarkInvoiceAsPaidRequest.md)

## Fields

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_AmountPaidFieldNumber"></a> AmountPaidFieldNumber

Field number for the "amount_paid" field.

```csharp
public const int AmountPaidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_InvoiceIdFieldNumber"></a> InvoiceIdFieldNumber

Field number for the "invoiceId" field.

```csharp
public const int InvoiceIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_PaymentDateFieldNumber"></a> PaymentDateFieldNumber

Field number for the "payment_date" field.

```csharp
public const int PaymentDateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_AmountPaid"></a> AmountPaid

```csharp
public double AmountPaid { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_InvoiceId"></a> InvoiceId

```csharp
public string InvoiceId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_Parser"></a> Parser

```csharp
public static MessageParser<MarkInvoiceAsPaidRequest> Parser { get; }
```

#### Property Value

 MessageParser<[MarkInvoiceAsPaidRequest](Billing.Invoices.Grpc.MarkInvoiceAsPaidRequest.md)\>

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_PaymentDate"></a> PaymentDate

```csharp
public Timestamp PaymentDate { get; set; }
```

#### Property Value

 Timestamp

## Methods

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_Clone"></a> Clone\(\)

```csharp
public MarkInvoiceAsPaidRequest Clone()
```

#### Returns

 [MarkInvoiceAsPaidRequest](Billing.Invoices.Grpc.MarkInvoiceAsPaidRequest.md)

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_Equals_Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_"></a> Equals\(MarkInvoiceAsPaidRequest\)

```csharp
public bool Equals(MarkInvoiceAsPaidRequest other)
```

#### Parameters

`other` [MarkInvoiceAsPaidRequest](Billing.Invoices.Grpc.MarkInvoiceAsPaidRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_MergeFrom_Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_"></a> MergeFrom\(MarkInvoiceAsPaidRequest\)

```csharp
public void MergeFrom(MarkInvoiceAsPaidRequest other)
```

#### Parameters

`other` [MarkInvoiceAsPaidRequest](Billing.Invoices.Grpc.MarkInvoiceAsPaidRequest.md)

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

