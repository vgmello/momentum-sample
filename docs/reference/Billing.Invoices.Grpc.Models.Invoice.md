# <a id="Billing_Invoices_Grpc_Models_Invoice"></a> Class Invoice

Namespace: [Billing.Invoices.Grpc.Models](Billing.Invoices.Grpc.Models.md)  
Assembly: Billing.Api.dll  

```csharp
public sealed class Invoice : IMessage<Invoice>, IEquatable<Invoice>, IDeepCloneable<Invoice>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Invoice](Billing.Invoices.Grpc.Models.Invoice.md)

#### Implements

IMessage<Invoice\>, 
[IEquatable<Invoice\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<Invoice\>, 
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

### <a id="Billing_Invoices_Grpc_Models_Invoice__ctor"></a> Invoice\(\)

```csharp
public Invoice()
```

### <a id="Billing_Invoices_Grpc_Models_Invoice__ctor_Billing_Invoices_Grpc_Models_Invoice_"></a> Invoice\(Invoice\)

```csharp
public Invoice(Invoice other)
```

#### Parameters

`other` [Invoice](Billing.Invoices.Grpc.Models.Invoice.md)

## Fields

### <a id="Billing_Invoices_Grpc_Models_Invoice_AmountFieldNumber"></a> AmountFieldNumber

Field number for the "amount" field.

```csharp
public const int AmountFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_CashierIdFieldNumber"></a> CashierIdFieldNumber

Field number for the "cashierId" field.

```csharp
public const int CashierIdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_CreatedDateUtcFieldNumber"></a> CreatedDateUtcFieldNumber

Field number for the "created_date_utc" field.

```csharp
public const int CreatedDateUtcFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_CurrencyFieldNumber"></a> CurrencyFieldNumber

Field number for the "currency" field.

```csharp
public const int CurrencyFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_DueDateFieldNumber"></a> DueDateFieldNumber

Field number for the "due_date" field.

```csharp
public const int DueDateFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_InvoiceIdFieldNumber"></a> InvoiceIdFieldNumber

Field number for the "invoiceId" field.

```csharp
public const int InvoiceIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_NameFieldNumber"></a> NameFieldNumber

Field number for the "name" field.

```csharp
public const int NameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_StatusFieldNumber"></a> StatusFieldNumber

Field number for the "status" field.

```csharp
public const int StatusFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_TenantIdFieldNumber"></a> TenantIdFieldNumber

Field number for the "tenant_id" field.

```csharp
public const int TenantIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_UpdatedDateUtcFieldNumber"></a> UpdatedDateUtcFieldNumber

Field number for the "updated_date_utc" field.

```csharp
public const int UpdatedDateUtcFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_VersionFieldNumber"></a> VersionFieldNumber

Field number for the "version" field.

```csharp
public const int VersionFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Billing_Invoices_Grpc_Models_Invoice_Amount"></a> Amount

```csharp
public double Amount { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="Billing_Invoices_Grpc_Models_Invoice_CashierId"></a> CashierId

```csharp
public string CashierId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_Models_Invoice_CreatedDateUtc"></a> CreatedDateUtc

```csharp
public Timestamp CreatedDateUtc { get; set; }
```

#### Property Value

 Timestamp

### <a id="Billing_Invoices_Grpc_Models_Invoice_Currency"></a> Currency

```csharp
public string Currency { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_Models_Invoice_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Billing_Invoices_Grpc_Models_Invoice_DueDate"></a> DueDate

```csharp
public Timestamp DueDate { get; set; }
```

#### Property Value

 Timestamp

### <a id="Billing_Invoices_Grpc_Models_Invoice_InvoiceId"></a> InvoiceId

```csharp
public string InvoiceId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_Models_Invoice_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_Models_Invoice_Parser"></a> Parser

```csharp
public static MessageParser<Invoice> Parser { get; }
```

#### Property Value

 MessageParser<[Invoice](Billing.Invoices.Grpc.Models.Invoice.md)\>

### <a id="Billing_Invoices_Grpc_Models_Invoice_Status"></a> Status

```csharp
public string Status { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_Models_Invoice_TenantId"></a> TenantId

```csharp
public string TenantId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_Models_Invoice_UpdatedDateUtc"></a> UpdatedDateUtc

```csharp
public Timestamp UpdatedDateUtc { get; set; }
```

#### Property Value

 Timestamp

### <a id="Billing_Invoices_Grpc_Models_Invoice_Version"></a> Version

```csharp
public int Version { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Billing_Invoices_Grpc_Models_Invoice_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_Clone"></a> Clone\(\)

```csharp
public Invoice Clone()
```

#### Returns

 [Invoice](Billing.Invoices.Grpc.Models.Invoice.md)

### <a id="Billing_Invoices_Grpc_Models_Invoice_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_Models_Invoice_Equals_Billing_Invoices_Grpc_Models_Invoice_"></a> Equals\(Invoice\)

```csharp
public bool Equals(Invoice other)
```

#### Parameters

`other` [Invoice](Billing.Invoices.Grpc.Models.Invoice.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Billing_Invoices_Grpc_Models_Invoice_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Billing_Invoices_Grpc_Models_Invoice_MergeFrom_Billing_Invoices_Grpc_Models_Invoice_"></a> MergeFrom\(Invoice\)

```csharp
public void MergeFrom(Invoice other)
```

#### Parameters

`other` [Invoice](Billing.Invoices.Grpc.Models.Invoice.md)

### <a id="Billing_Invoices_Grpc_Models_Invoice_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Billing_Invoices_Grpc_Models_Invoice_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Billing_Invoices_Grpc_Models_Invoice_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

