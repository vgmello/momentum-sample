# <a id="Billing_Invoices_Grpc_CreateInvoiceRequest"></a> Class CreateInvoiceRequest

Namespace: [Billing.Invoices.Grpc](Billing.Invoices.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class CreateInvoiceRequest : IMessage<CreateInvoiceRequest>, IEquatable<CreateInvoiceRequest>, IDeepCloneable<CreateInvoiceRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CreateInvoiceRequest](Billing.Invoices.Grpc.CreateInvoiceRequest.md)

#### Implements

IMessage<CreateInvoiceRequest\>, 
[IEquatable<CreateInvoiceRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CreateInvoiceRequest\>, 
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

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest__ctor"></a> CreateInvoiceRequest\(\)

```csharp
public CreateInvoiceRequest()
```

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest__ctor_Billing_Invoices_Grpc_CreateInvoiceRequest_"></a> CreateInvoiceRequest\(CreateInvoiceRequest\)

```csharp
public CreateInvoiceRequest(CreateInvoiceRequest other)
```

#### Parameters

`other` [CreateInvoiceRequest](Billing.Invoices.Grpc.CreateInvoiceRequest.md)

## Fields

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_AmountFieldNumber"></a> AmountFieldNumber

Field number for the "amount" field.

```csharp
public const int AmountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_CashierIdFieldNumber"></a> CashierIdFieldNumber

Field number for the "cashierId" field.

```csharp
public const int CashierIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_CurrencyFieldNumber"></a> CurrencyFieldNumber

Field number for the "currency" field.

```csharp
public const int CurrencyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_DueDateFieldNumber"></a> DueDateFieldNumber

Field number for the "due_date" field.

```csharp
public const int DueDateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_NameFieldNumber"></a> NameFieldNumber

Field number for the "name" field.

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_Amount"></a> Amount

```csharp
public double Amount { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_CashierId"></a> CashierId

```csharp
public string CashierId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_Currency"></a> Currency

```csharp
public string Currency { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_DueDate"></a> DueDate

```csharp
public Timestamp DueDate { get; set; }
```

#### Property Value

 Timestamp

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_Parser"></a> Parser

```csharp
public static MessageParser<CreateInvoiceRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CreateInvoiceRequest](Billing.Invoices.Grpc.CreateInvoiceRequest.md)\>

## Methods

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_Clone"></a> Clone\(\)

```csharp
public CreateInvoiceRequest Clone()
```

#### Returns

 [CreateInvoiceRequest](Billing.Invoices.Grpc.CreateInvoiceRequest.md)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_Equals_Billing_Invoices_Grpc_CreateInvoiceRequest_"></a> Equals\(CreateInvoiceRequest\)

```csharp
public bool Equals(CreateInvoiceRequest other)
```

#### Parameters

`other` [CreateInvoiceRequest](Billing.Invoices.Grpc.CreateInvoiceRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_MergeFrom_Billing_Invoices_Grpc_CreateInvoiceRequest_"></a> MergeFrom\(CreateInvoiceRequest\)

```csharp
public void MergeFrom(CreateInvoiceRequest other)
```

#### Parameters

`other` [CreateInvoiceRequest](Billing.Invoices.Grpc.CreateInvoiceRequest.md)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_CreateInvoiceRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

