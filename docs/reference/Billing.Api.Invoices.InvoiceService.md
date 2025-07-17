# <a id="Billing_Api_Invoices_InvoiceService"></a> Class InvoiceService

Namespace: [Billing.Api.Invoices](Billing.Api.Invoices.md)  
Assembly: Billing.Api.dll  

```csharp
public class InvoiceService : InvoicesService.InvoicesServiceBase
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvoicesService.InvoicesServiceBase](Billing.Invoices.Grpc.InvoicesService.InvoicesServiceBase.md) ← 
[InvoiceService](Billing.Api.Invoices.InvoiceService.md)

#### Inherited Members

[InvoicesService.InvoicesServiceBase.GetInvoice\(GetInvoiceRequest, ServerCallContext\)](Billing.Invoices.Grpc.InvoicesService.InvoicesServiceBase.md\#Billing\_Invoices\_Grpc\_InvoicesService\_InvoicesServiceBase\_GetInvoice\_Billing\_Invoices\_Grpc\_GetInvoiceRequest\_Grpc\_Core\_ServerCallContext\_), 
[InvoicesService.InvoicesServiceBase.GetInvoices\(GetInvoicesRequest, ServerCallContext\)](Billing.Invoices.Grpc.InvoicesService.InvoicesServiceBase.md\#Billing\_Invoices\_Grpc\_InvoicesService\_InvoicesServiceBase\_GetInvoices\_Billing\_Invoices\_Grpc\_GetInvoicesRequest\_Grpc\_Core\_ServerCallContext\_), 
[InvoicesService.InvoicesServiceBase.CreateInvoice\(CreateInvoiceRequest, ServerCallContext\)](Billing.Invoices.Grpc.InvoicesService.InvoicesServiceBase.md\#Billing\_Invoices\_Grpc\_InvoicesService\_InvoicesServiceBase\_CreateInvoice\_Billing\_Invoices\_Grpc\_CreateInvoiceRequest\_Grpc\_Core\_ServerCallContext\_), 
[InvoicesService.InvoicesServiceBase.CancelInvoice\(CancelInvoiceRequest, ServerCallContext\)](Billing.Invoices.Grpc.InvoicesService.InvoicesServiceBase.md\#Billing\_Invoices\_Grpc\_InvoicesService\_InvoicesServiceBase\_CancelInvoice\_Billing\_Invoices\_Grpc\_CancelInvoiceRequest\_Grpc\_Core\_ServerCallContext\_), 
[InvoicesService.InvoicesServiceBase.MarkInvoiceAsPaid\(MarkInvoiceAsPaidRequest, ServerCallContext\)](Billing.Invoices.Grpc.InvoicesService.InvoicesServiceBase.md\#Billing\_Invoices\_Grpc\_InvoicesService\_InvoicesServiceBase\_MarkInvoiceAsPaid\_Billing\_Invoices\_Grpc\_MarkInvoiceAsPaidRequest\_Grpc\_Core\_ServerCallContext\_), 
[InvoicesService.InvoicesServiceBase.SimulatePayment\(SimulatePaymentRequest, ServerCallContext\)](Billing.Invoices.Grpc.InvoicesService.InvoicesServiceBase.md\#Billing\_Invoices\_Grpc\_InvoicesService\_InvoicesServiceBase\_SimulatePayment\_Billing\_Invoices\_Grpc\_SimulatePaymentRequest\_Grpc\_Core\_ServerCallContext\_), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Api_Invoices_InvoiceService__ctor_Wolverine_IMessageBus_"></a> InvoiceService\(IMessageBus\)

```csharp
public InvoiceService(IMessageBus bus)
```

#### Parameters

`bus` IMessageBus

## Methods

### <a id="Billing_Api_Invoices_InvoiceService_CancelInvoice_Billing_Invoices_Grpc_CancelInvoiceRequest_Grpc_Core_ServerCallContext_"></a> CancelInvoice\(CancelInvoiceRequest, ServerCallContext\)

```csharp
public override Task<Invoice> CancelInvoice(CancelInvoiceRequest request, ServerCallContext context)
```

#### Parameters

`request` [CancelInvoiceRequest](Billing.Invoices.Grpc.CancelInvoiceRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Invoice](Billing.Invoices.Grpc.Models.Invoice.md)\>

### <a id="Billing_Api_Invoices_InvoiceService_CreateInvoice_Billing_Invoices_Grpc_CreateInvoiceRequest_Grpc_Core_ServerCallContext_"></a> CreateInvoice\(CreateInvoiceRequest, ServerCallContext\)

```csharp
public override Task<Invoice> CreateInvoice(CreateInvoiceRequest request, ServerCallContext context)
```

#### Parameters

`request` [CreateInvoiceRequest](Billing.Invoices.Grpc.CreateInvoiceRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Invoice](Billing.Invoices.Grpc.Models.Invoice.md)\>

### <a id="Billing_Api_Invoices_InvoiceService_GetInvoice_Billing_Invoices_Grpc_GetInvoiceRequest_Grpc_Core_ServerCallContext_"></a> GetInvoice\(GetInvoiceRequest, ServerCallContext\)

```csharp
public override Task<Invoice> GetInvoice(GetInvoiceRequest request, ServerCallContext context)
```

#### Parameters

`request` [GetInvoiceRequest](Billing.Invoices.Grpc.GetInvoiceRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Invoice](Billing.Invoices.Grpc.Models.Invoice.md)\>

### <a id="Billing_Api_Invoices_InvoiceService_GetInvoices_Billing_Invoices_Grpc_GetInvoicesRequest_Grpc_Core_ServerCallContext_"></a> GetInvoices\(GetInvoicesRequest, ServerCallContext\)

```csharp
public override Task<GetInvoicesResponse> GetInvoices(GetInvoicesRequest request, ServerCallContext context)
```

#### Parameters

`request` [GetInvoicesRequest](Billing.Invoices.Grpc.GetInvoicesRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[GetInvoicesResponse](Billing.Invoices.Grpc.GetInvoicesResponse.md)\>

### <a id="Billing_Api_Invoices_InvoiceService_MarkInvoiceAsPaid_Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_Grpc_Core_ServerCallContext_"></a> MarkInvoiceAsPaid\(MarkInvoiceAsPaidRequest, ServerCallContext\)

```csharp
public override Task<Invoice> MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest request, ServerCallContext context)
```

#### Parameters

`request` [MarkInvoiceAsPaidRequest](Billing.Invoices.Grpc.MarkInvoiceAsPaidRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Invoice](Billing.Invoices.Grpc.Models.Invoice.md)\>

### <a id="Billing_Api_Invoices_InvoiceService_SimulatePayment_Billing_Invoices_Grpc_SimulatePaymentRequest_Grpc_Core_ServerCallContext_"></a> SimulatePayment\(SimulatePaymentRequest, ServerCallContext\)

```csharp
public override Task<SimulatePaymentResponse> SimulatePayment(SimulatePaymentRequest request, ServerCallContext context)
```

#### Parameters

`request` [SimulatePaymentRequest](Billing.Invoices.Grpc.SimulatePaymentRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[SimulatePaymentResponse](Billing.Invoices.Grpc.SimulatePaymentResponse.md)\>

