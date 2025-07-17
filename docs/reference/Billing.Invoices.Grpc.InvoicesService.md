# <a id="Billing_Invoices_Grpc_InvoicesService"></a> Class InvoicesService

Namespace: [Billing.Invoices.Grpc](Billing.Invoices.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public static class InvoicesService
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvoicesService](Billing.Invoices.Grpc.InvoicesService.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Properties

### <a id="Billing_Invoices_Grpc_InvoicesService_Descriptor"></a> Descriptor

Service descriptor

```csharp
public static ServiceDescriptor Descriptor { get; }
```

#### Property Value

 ServiceDescriptor

## Methods

### <a id="Billing_Invoices_Grpc_InvoicesService_BindService_Billing_Invoices_Grpc_InvoicesService_InvoicesServiceBase_"></a> BindService\(InvoicesServiceBase\)

Creates service definition that can be registered with a server

```csharp
public static ServerServiceDefinition BindService(InvoicesService.InvoicesServiceBase serviceImpl)
```

#### Parameters

`serviceImpl` [InvoicesService](Billing.Invoices.Grpc.InvoicesService.md).[InvoicesServiceBase](Billing.Invoices.Grpc.InvoicesService.InvoicesServiceBase.md)

An object implementing the server-side handling logic.

#### Returns

 ServerServiceDefinition

### <a id="Billing_Invoices_Grpc_InvoicesService_BindService_Grpc_Core_ServiceBinderBase_Billing_Invoices_Grpc_InvoicesService_InvoicesServiceBase_"></a> BindService\(ServiceBinderBase, InvoicesServiceBase\)

Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
            Note: this method is part of an experimental API that can change or be removed without any prior notice.

```csharp
public static void BindService(ServiceBinderBase serviceBinder, InvoicesService.InvoicesServiceBase serviceImpl)
```

#### Parameters

`serviceBinder` ServiceBinderBase

Service methods will be bound by calling <code>AddMethod</code> on this object.

`serviceImpl` [InvoicesService](Billing.Invoices.Grpc.InvoicesService.md).[InvoicesServiceBase](Billing.Invoices.Grpc.InvoicesService.InvoicesServiceBase.md)

An object implementing the server-side handling logic.

