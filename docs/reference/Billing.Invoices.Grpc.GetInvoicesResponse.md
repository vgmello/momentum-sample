# <a id="Billing_Invoices_Grpc_GetInvoicesResponse"></a> Class GetInvoicesResponse

Namespace: [Billing.Invoices.Grpc](Billing.Invoices.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class GetInvoicesResponse : IMessage<GetInvoicesResponse>, IEquatable<GetInvoicesResponse>, IDeepCloneable<GetInvoicesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GetInvoicesResponse](Billing.Invoices.Grpc.GetInvoicesResponse.md)

#### Implements

IMessage<GetInvoicesResponse\>, 
[IEquatable<GetInvoicesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<GetInvoicesResponse\>, 
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

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse__ctor"></a> GetInvoicesResponse\(\)

```csharp
public GetInvoicesResponse()
```

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse__ctor_Billing_Invoices_Grpc_GetInvoicesResponse_"></a> GetInvoicesResponse\(GetInvoicesResponse\)

```csharp
public GetInvoicesResponse(GetInvoicesResponse other)
```

#### Parameters

`other` [GetInvoicesResponse](Billing.Invoices.Grpc.GetInvoicesResponse.md)

## Fields

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_InvoicesFieldNumber"></a> InvoicesFieldNumber

Field number for the "invoices" field.

```csharp
public const int InvoicesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_Invoices"></a> Invoices

```csharp
public RepeatedField<Invoice> Invoices { get; }
```

#### Property Value

 RepeatedField<[Invoice](Billing.Invoices.Grpc.Models.Invoice.md)\>

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_Parser"></a> Parser

```csharp
public static MessageParser<GetInvoicesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[GetInvoicesResponse](Billing.Invoices.Grpc.GetInvoicesResponse.md)\>

## Methods

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_Clone"></a> Clone\(\)

```csharp
public GetInvoicesResponse Clone()
```

#### Returns

 [GetInvoicesResponse](Billing.Invoices.Grpc.GetInvoicesResponse.md)

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_Equals_Billing_Invoices_Grpc_GetInvoicesResponse_"></a> Equals\(GetInvoicesResponse\)

```csharp
public bool Equals(GetInvoicesResponse other)
```

#### Parameters

`other` [GetInvoicesResponse](Billing.Invoices.Grpc.GetInvoicesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_MergeFrom_Billing_Invoices_Grpc_GetInvoicesResponse_"></a> MergeFrom\(GetInvoicesResponse\)

```csharp
public void MergeFrom(GetInvoicesResponse other)
```

#### Parameters

`other` [GetInvoicesResponse](Billing.Invoices.Grpc.GetInvoicesResponse.md)

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_GetInvoicesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

