# <a id="Billing_Invoices_Grpc_InvoicesService_InvoicesServiceBase"></a> Class InvoicesService.InvoicesServiceBase

Namespace: [Billing.Invoices.Grpc](Billing.Invoices.Grpc.md)  
Assembly: Billing.Api.dll  

Base class for server-side implementations of InvoicesService

```csharp
[BindServiceMethod(typeof(InvoicesService), "BindService")]
public abstract class InvoicesService.InvoicesServiceBase
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvoicesService.InvoicesServiceBase](Billing.Invoices.Grpc.InvoicesService.InvoicesServiceBase.md)

#### Derived

[InvoiceService](Billing.Api.Invoices.InvoiceService.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Grpc_InvoicesService_InvoicesServiceBase__ctor"></a> InvoicesServiceBase\(\)

```csharp
protected InvoicesServiceBase()
```

## Methods

### <a id="Billing_Invoices_Grpc_InvoicesService_InvoicesServiceBase_CancelInvoice_Billing_Invoices_Grpc_CancelInvoiceRequest_Grpc_Core_ServerCallContext_"></a> CancelInvoice\(CancelInvoiceRequest, ServerCallContext\)

```csharp
public virtual Task<Invoice> CancelInvoice(CancelInvoiceRequest request, ServerCallContext context)
```

#### Parameters

`request` [CancelInvoiceRequest](Billing.Invoices.Grpc.CancelInvoiceRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Invoice](Billing.Invoices.Grpc.Models.Invoice.md)\>

### <a id="Billing_Invoices_Grpc_InvoicesService_InvoicesServiceBase_CreateInvoice_Billing_Invoices_Grpc_CreateInvoiceRequest_Grpc_Core_ServerCallContext_"></a> CreateInvoice\(CreateInvoiceRequest, ServerCallContext\)

```csharp
public virtual Task<Invoice> CreateInvoice(CreateInvoiceRequest request, ServerCallContext context)
```

#### Parameters

`request` [CreateInvoiceRequest](Billing.Invoices.Grpc.CreateInvoiceRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Invoice](Billing.Invoices.Grpc.Models.Invoice.md)\>

### <a id="Billing_Invoices_Grpc_InvoicesService_InvoicesServiceBase_GetInvoice_Billing_Invoices_Grpc_GetInvoiceRequest_Grpc_Core_ServerCallContext_"></a> GetInvoice\(GetInvoiceRequest, ServerCallContext\)

```csharp
public virtual Task<Invoice> GetInvoice(GetInvoiceRequest request, ServerCallContext context)
```

#### Parameters

`request` [GetInvoiceRequest](Billing.Invoices.Grpc.GetInvoiceRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Invoice](Billing.Invoices.Grpc.Models.Invoice.md)\>

### <a id="Billing_Invoices_Grpc_InvoicesService_InvoicesServiceBase_GetInvoices_Billing_Invoices_Grpc_GetInvoicesRequest_Grpc_Core_ServerCallContext_"></a> GetInvoices\(GetInvoicesRequest, ServerCallContext\)

```csharp
public virtual Task<GetInvoicesResponse> GetInvoices(GetInvoicesRequest request, ServerCallContext context)
```

#### Parameters

`request` [GetInvoicesRequest](Billing.Invoices.Grpc.GetInvoicesRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[GetInvoicesResponse](Billing.Invoices.Grpc.GetInvoicesResponse.md)\>

### <a id="Billing_Invoices_Grpc_InvoicesService_InvoicesServiceBase_MarkInvoiceAsPaid_Billing_Invoices_Grpc_MarkInvoiceAsPaidRequest_Grpc_Core_ServerCallContext_"></a> MarkInvoiceAsPaid\(MarkInvoiceAsPaidRequest, ServerCallContext\)

```csharp
public virtual Task<Invoice> MarkInvoiceAsPaid(MarkInvoiceAsPaidRequest request, ServerCallContext context)
```

#### Parameters

`request` [MarkInvoiceAsPaidRequest](Billing.Invoices.Grpc.MarkInvoiceAsPaidRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Invoice](Billing.Invoices.Grpc.Models.Invoice.md)\>

### <a id="Billing_Invoices_Grpc_InvoicesService_InvoicesServiceBase_SimulatePayment_Billing_Invoices_Grpc_SimulatePaymentRequest_Grpc_Core_ServerCallContext_"></a> SimulatePayment\(SimulatePaymentRequest, ServerCallContext\)

```csharp
public virtual Task<SimulatePaymentResponse> SimulatePayment(SimulatePaymentRequest request, ServerCallContext context)
```

#### Parameters

`request` [SimulatePaymentRequest](Billing.Invoices.Grpc.SimulatePaymentRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[SimulatePaymentResponse](Billing.Invoices.Grpc.SimulatePaymentResponse.md)\>

