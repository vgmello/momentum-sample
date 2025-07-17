# <a id="Billing_BackOffice_Messaging_BillingDomainHandler_InvoiceGeneratedHandler"></a> Class InvoiceGeneratedHandler

Namespace: [Billing.BackOffice.Messaging.BillingDomainHandler](Billing.BackOffice.Messaging.BillingDomainHandler.md)  
Assembly: Billing.BackOffice.dll  

```csharp
public class InvoiceGeneratedHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvoiceGeneratedHandler](Billing.BackOffice.Messaging.BillingDomainHandler.InvoiceGeneratedHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_BackOffice_Messaging_BillingDomainHandler_InvoiceGeneratedHandler__ctor_Microsoft_Extensions_Logging_ILogger_Billing_BackOffice_Messaging_BillingDomainHandler_InvoiceGeneratedHandler__"></a> InvoiceGeneratedHandler\(ILogger<InvoiceGeneratedHandler\>\)

```csharp
public InvoiceGeneratedHandler(ILogger<InvoiceGeneratedHandler> logger)
```

#### Parameters

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger\-1)<[InvoiceGeneratedHandler](Billing.BackOffice.Messaging.BillingDomainHandler.InvoiceGeneratedHandler.md)\>

## Methods

### <a id="Billing_BackOffice_Messaging_BillingDomainHandler_InvoiceGeneratedHandler_Handle_Billing_Invoices_Contracts_DomainEvents_InvoiceGenerated_"></a> Handle\(InvoiceGenerated\)

```csharp
public Task Handle(InvoiceGenerated invoiceGenerated)
```

#### Parameters

`invoiceGenerated` [InvoiceGenerated](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Invoices/Contracts/DomainEvents/InvoiceGenerated.cs)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

