# <a id="Billing_Cashiers_Grpc_DeleteCashierRequest"></a> Class DeleteCashierRequest

Namespace: [Billing.Cashiers.Grpc](Billing.Cashiers.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class DeleteCashierRequest : IMessage<DeleteCashierRequest>, IEquatable<DeleteCashierRequest>, IDeepCloneable<DeleteCashierRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DeleteCashierRequest](Billing.Cashiers.Grpc.DeleteCashierRequest.md)

#### Implements

IMessage<DeleteCashierRequest\>, 
[IEquatable<DeleteCashierRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<DeleteCashierRequest\>, 
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

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest__ctor"></a> DeleteCashierRequest\(\)

```csharp
public DeleteCashierRequest()
```

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest__ctor_Billing_Cashiers_Grpc_DeleteCashierRequest_"></a> DeleteCashierRequest\(DeleteCashierRequest\)

```csharp
public DeleteCashierRequest(DeleteCashierRequest other)
```

#### Parameters

`other` [DeleteCashierRequest](Billing.Cashiers.Grpc.DeleteCashierRequest.md)

## Fields

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_CashierIdFieldNumber"></a> CashierIdFieldNumber

Field number for the "cashierId" field.

```csharp
public const int CashierIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_CashierId"></a> CashierId

```csharp
public string CashierId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_Parser"></a> Parser

```csharp
public static MessageParser<DeleteCashierRequest> Parser { get; }
```

#### Property Value

 MessageParser<[DeleteCashierRequest](Billing.Cashiers.Grpc.DeleteCashierRequest.md)\>

## Methods

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_Clone"></a> Clone\(\)

```csharp
public DeleteCashierRequest Clone()
```

#### Returns

 [DeleteCashierRequest](Billing.Cashiers.Grpc.DeleteCashierRequest.md)

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_Equals_Billing_Cashiers_Grpc_DeleteCashierRequest_"></a> Equals\(DeleteCashierRequest\)

```csharp
public bool Equals(DeleteCashierRequest other)
```

#### Parameters

`other` [DeleteCashierRequest](Billing.Cashiers.Grpc.DeleteCashierRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_MergeFrom_Billing_Cashiers_Grpc_DeleteCashierRequest_"></a> MergeFrom\(DeleteCashierRequest\)

```csharp
public void MergeFrom(DeleteCashierRequest other)
```

#### Parameters

`other` [DeleteCashierRequest](Billing.Cashiers.Grpc.DeleteCashierRequest.md)

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_DeleteCashierRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

