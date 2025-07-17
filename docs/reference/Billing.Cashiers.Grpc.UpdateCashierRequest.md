# <a id="Billing_Cashiers_Grpc_UpdateCashierRequest"></a> Class UpdateCashierRequest

Namespace: [Billing.Cashiers.Grpc](Billing.Cashiers.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class UpdateCashierRequest : IMessage<UpdateCashierRequest>, IEquatable<UpdateCashierRequest>, IDeepCloneable<UpdateCashierRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UpdateCashierRequest](Billing.Cashiers.Grpc.UpdateCashierRequest.md)

#### Implements

IMessage<UpdateCashierRequest\>, 
[IEquatable<UpdateCashierRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<UpdateCashierRequest\>, 
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

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest__ctor"></a> UpdateCashierRequest\(\)

```csharp
public UpdateCashierRequest()
```

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest__ctor_Billing_Cashiers_Grpc_UpdateCashierRequest_"></a> UpdateCashierRequest\(UpdateCashierRequest\)

```csharp
public UpdateCashierRequest(UpdateCashierRequest other)
```

#### Parameters

`other` [UpdateCashierRequest](Billing.Cashiers.Grpc.UpdateCashierRequest.md)

## Fields

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_CashierIdFieldNumber"></a> CashierIdFieldNumber

Field number for the "cashierId" field.

```csharp
public const int CashierIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_EmailFieldNumber"></a> EmailFieldNumber

Field number for the "email" field.

```csharp
public const int EmailFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_NameFieldNumber"></a> NameFieldNumber

Field number for the "name" field.

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_CashierId"></a> CashierId

```csharp
public string CashierId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_Email"></a> Email

```csharp
public string Email { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_Parser"></a> Parser

```csharp
public static MessageParser<UpdateCashierRequest> Parser { get; }
```

#### Property Value

 MessageParser<[UpdateCashierRequest](Billing.Cashiers.Grpc.UpdateCashierRequest.md)\>

## Methods

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_Clone"></a> Clone\(\)

```csharp
public UpdateCashierRequest Clone()
```

#### Returns

 [UpdateCashierRequest](Billing.Cashiers.Grpc.UpdateCashierRequest.md)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_Equals_Billing_Cashiers_Grpc_UpdateCashierRequest_"></a> Equals\(UpdateCashierRequest\)

```csharp
public bool Equals(UpdateCashierRequest other)
```

#### Parameters

`other` [UpdateCashierRequest](Billing.Cashiers.Grpc.UpdateCashierRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_MergeFrom_Billing_Cashiers_Grpc_UpdateCashierRequest_"></a> MergeFrom\(UpdateCashierRequest\)

```csharp
public void MergeFrom(UpdateCashierRequest other)
```

#### Parameters

`other` [UpdateCashierRequest](Billing.Cashiers.Grpc.UpdateCashierRequest.md)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Cashiers_Grpc_UpdateCashierRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

