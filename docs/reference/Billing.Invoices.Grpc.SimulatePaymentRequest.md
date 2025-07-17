# <a id="Billing_Invoices_Grpc_SimulatePaymentRequest"></a> Class SimulatePaymentRequest

Namespace: [Billing.Invoices.Grpc](Billing.Invoices.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class SimulatePaymentRequest : IMessage<SimulatePaymentRequest>, IEquatable<SimulatePaymentRequest>, IDeepCloneable<SimulatePaymentRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SimulatePaymentRequest](Billing.Invoices.Grpc.SimulatePaymentRequest.md)

#### Implements

IMessage<SimulatePaymentRequest\>, 
[IEquatable<SimulatePaymentRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<SimulatePaymentRequest\>, 
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

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest__ctor"></a> SimulatePaymentRequest\(\)

```csharp
public SimulatePaymentRequest()
```

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest__ctor_Billing_Invoices_Grpc_SimulatePaymentRequest_"></a> SimulatePaymentRequest\(SimulatePaymentRequest\)

```csharp
public SimulatePaymentRequest(SimulatePaymentRequest other)
```

#### Parameters

`other` [SimulatePaymentRequest](Billing.Invoices.Grpc.SimulatePaymentRequest.md)

## Fields

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_AmountFieldNumber"></a> AmountFieldNumber

Field number for the "amount" field.

```csharp
public const int AmountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_CurrencyFieldNumber"></a> CurrencyFieldNumber

Field number for the "currency" field.

```csharp
public const int CurrencyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_InvoiceIdFieldNumber"></a> InvoiceIdFieldNumber

Field number for the "invoiceId" field.

```csharp
public const int InvoiceIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_PaymentMethodFieldNumber"></a> PaymentMethodFieldNumber

Field number for the "payment_method" field.

```csharp
public const int PaymentMethodFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_PaymentReferenceFieldNumber"></a> PaymentReferenceFieldNumber

Field number for the "payment_reference" field.

```csharp
public const int PaymentReferenceFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_Amount"></a> Amount

```csharp
public double Amount { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_Currency"></a> Currency

```csharp
public string Currency { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_InvoiceId"></a> InvoiceId

```csharp
public string InvoiceId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_Parser"></a> Parser

```csharp
public static MessageParser<SimulatePaymentRequest> Parser { get; }
```

#### Property Value

 MessageParser<[SimulatePaymentRequest](Billing.Invoices.Grpc.SimulatePaymentRequest.md)\>

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_PaymentMethod"></a> PaymentMethod

```csharp
public string PaymentMethod { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_PaymentReference"></a> PaymentReference

```csharp
public string PaymentReference { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_Clone"></a> Clone\(\)

```csharp
public SimulatePaymentRequest Clone()
```

#### Returns

 [SimulatePaymentRequest](Billing.Invoices.Grpc.SimulatePaymentRequest.md)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_Equals_Billing_Invoices_Grpc_SimulatePaymentRequest_"></a> Equals\(SimulatePaymentRequest\)

```csharp
public bool Equals(SimulatePaymentRequest other)
```

#### Parameters

`other` [SimulatePaymentRequest](Billing.Invoices.Grpc.SimulatePaymentRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_MergeFrom_Billing_Invoices_Grpc_SimulatePaymentRequest_"></a> MergeFrom\(SimulatePaymentRequest\)

```csharp
public void MergeFrom(SimulatePaymentRequest other)
```

#### Parameters

`other` [SimulatePaymentRequest](Billing.Invoices.Grpc.SimulatePaymentRequest.md)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_SimulatePaymentRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

