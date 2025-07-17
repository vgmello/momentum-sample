# <a id="Billing_Cashiers_Grpc_CashiersService"></a> Class CashiersService

Namespace: [Billing.Cashiers.Grpc](Billing.Cashiers.Grpc.md)  
Assembly: Billing.Api.dll  

```csharp
public static class CashiersService
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CashiersService](Billing.Cashiers.Grpc.CashiersService.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Properties

### <a id="Billing_Cashiers_Grpc_CashiersService_Descriptor"></a> Descriptor

Service descriptor

```csharp
public static ServiceDescriptor Descriptor { get; }
```

#### Property Value

 ServiceDescriptor

## Methods

### <a id="Billing_Cashiers_Grpc_CashiersService_BindService_Billing_Cashiers_Grpc_CashiersService_CashiersServiceBase_"></a> BindService\(CashiersServiceBase\)

Creates service definition that can be registered with a server

```csharp
public static ServerServiceDefinition BindService(CashiersService.CashiersServiceBase serviceImpl)
```

#### Parameters

`serviceImpl` [CashiersService](Billing.Cashiers.Grpc.CashiersService.md).[CashiersServiceBase](Billing.Cashiers.Grpc.CashiersService.CashiersServiceBase.md)

An object implementing the server-side handling logic.

#### Returns

 ServerServiceDefinition

### <a id="Billing_Cashiers_Grpc_CashiersService_BindService_Grpc_Core_ServiceBinderBase_Billing_Cashiers_Grpc_CashiersService_CashiersServiceBase_"></a> BindService\(ServiceBinderBase, CashiersServiceBase\)

Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
            Note: this method is part of an experimental API that can change or be removed without any prior notice.

```csharp
public static void BindService(ServiceBinderBase serviceBinder, CashiersService.CashiersServiceBase serviceImpl)
```

#### Parameters

`serviceBinder` ServiceBinderBase

Service methods will be bound by calling <code>AddMethod</code> on this object.

`serviceImpl` [CashiersService](Billing.Cashiers.Grpc.CashiersService.md).[CashiersServiceBase](Billing.Cashiers.Grpc.CashiersService.CashiersServiceBase.md)

An object implementing the server-side handling logic.

