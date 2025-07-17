# <a id="Billing_Invoices_Grpc_SimulatePaymentResponse"></a> Class SimulatePaymentResponse

Namespace: [Billing.Invoices.Grpc](Billing.Invoices.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class SimulatePaymentResponse : IMessage<SimulatePaymentResponse>, IEquatable<SimulatePaymentResponse>, IDeepCloneable<SimulatePaymentResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SimulatePaymentResponse](Billing.Invoices.Grpc.SimulatePaymentResponse.md)

#### Implements

IMessage<SimulatePaymentResponse\>, 
[IEquatable<SimulatePaymentResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<SimulatePaymentResponse\>, 
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

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse__ctor"></a> SimulatePaymentResponse\(\)

```csharp
public SimulatePaymentResponse()
```

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse__ctor_Billing_Invoices_Grpc_SimulatePaymentResponse_"></a> SimulatePaymentResponse\(SimulatePaymentResponse\)

```csharp
public SimulatePaymentResponse(SimulatePaymentResponse other)
```

#### Parameters

`other` [SimulatePaymentResponse](Billing.Invoices.Grpc.SimulatePaymentResponse.md)

## Fields

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_MessageFieldNumber"></a> MessageFieldNumber

Field number for the "message" field.

```csharp
public const int MessageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_Parser"></a> Parser

```csharp
public static MessageParser<SimulatePaymentResponse> Parser { get; }
```

#### Property Value

 MessageParser<[SimulatePaymentResponse](Billing.Invoices.Grpc.SimulatePaymentResponse.md)\>

## Methods

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_Clone"></a> Clone\(\)

```csharp
public SimulatePaymentResponse Clone()
```

#### Returns

 [SimulatePaymentResponse](Billing.Invoices.Grpc.SimulatePaymentResponse.md)

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_Equals_Billing_Invoices_Grpc_SimulatePaymentResponse_"></a> Equals\(SimulatePaymentResponse\)

```csharp
public bool Equals(SimulatePaymentResponse other)
```

#### Parameters

`other` [SimulatePaymentResponse](Billing.Invoices.Grpc.SimulatePaymentResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_MergeFrom_Billing_Invoices_Grpc_SimulatePaymentResponse_"></a> MergeFrom\(SimulatePaymentResponse\)

```csharp
public void MergeFrom(SimulatePaymentResponse other)
```

#### Parameters

`other` [SimulatePaymentResponse](Billing.Invoices.Grpc.SimulatePaymentResponse.md)

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_SimulatePaymentResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

