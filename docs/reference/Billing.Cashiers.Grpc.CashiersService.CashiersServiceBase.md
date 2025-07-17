# <a id="Billing_Cashiers_Grpc_CashiersService_CashiersServiceBase"></a> Class CashiersService.CashiersServiceBase

Namespace: [Billing.Cashiers.Grpc](Billing.Cashiers.Grpc.md)  
Assembly: Billing.Api.dll  

Base class for server-side implementations of CashiersService

```csharp
[BindServiceMethod(typeof(CashiersService), "BindService")]
public abstract class CashiersService.CashiersServiceBase
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CashiersService.CashiersServiceBase](Billing.Cashiers.Grpc.CashiersService.CashiersServiceBase.md)

#### Derived

[CashierService](Billing.Api.Cashiers.CashierService.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Grpc_CashiersService_CashiersServiceBase__ctor"></a> CashiersServiceBase\(\)

```csharp
protected CashiersServiceBase()
```

## Methods

### <a id="Billing_Cashiers_Grpc_CashiersService_CashiersServiceBase_CreateCashier_Billing_Cashiers_Grpc_CreateCashierRequest_Grpc_Core_ServerCallContext_"></a> CreateCashier\(CreateCashierRequest, ServerCallContext\)

```csharp
public virtual Task<Cashier> CreateCashier(CreateCashierRequest request, ServerCallContext context)
```

#### Parameters

`request` [CreateCashierRequest](Billing.Cashiers.Grpc.CreateCashierRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)\>

### <a id="Billing_Cashiers_Grpc_CashiersService_CashiersServiceBase_DeleteCashier_Billing_Cashiers_Grpc_DeleteCashierRequest_Grpc_Core_ServerCallContext_"></a> DeleteCashier\(DeleteCashierRequest, ServerCallContext\)

```csharp
public virtual Task<Empty> DeleteCashier(DeleteCashierRequest request, ServerCallContext context)
```

#### Parameters

`request` [DeleteCashierRequest](Billing.Cashiers.Grpc.DeleteCashierRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<Empty\>

### <a id="Billing_Cashiers_Grpc_CashiersService_CashiersServiceBase_GetCashier_Billing_Cashiers_Grpc_GetCashierRequest_Grpc_Core_ServerCallContext_"></a> GetCashier\(GetCashierRequest, ServerCallContext\)

```csharp
public virtual Task<Cashier> GetCashier(GetCashierRequest request, ServerCallContext context)
```

#### Parameters

`request` [GetCashierRequest](Billing.Cashiers.Grpc.GetCashierRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)\>

### <a id="Billing_Cashiers_Grpc_CashiersService_CashiersServiceBase_GetCashiers_Billing_Cashiers_Grpc_GetCashiersRequest_Grpc_Core_ServerCallContext_"></a> GetCashiers\(GetCashiersRequest, ServerCallContext\)

```csharp
public virtual Task<GetCashiersResponse> GetCashiers(GetCashiersRequest request, ServerCallContext context)
```

#### Parameters

`request` [GetCashiersRequest](Billing.Cashiers.Grpc.GetCashiersRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[GetCashiersResponse](Billing.Cashiers.Grpc.GetCashiersResponse.md)\>

### <a id="Billing_Cashiers_Grpc_CashiersService_CashiersServiceBase_UpdateCashier_Billing_Cashiers_Grpc_UpdateCashierRequest_Grpc_Core_ServerCallContext_"></a> UpdateCashier\(UpdateCashierRequest, ServerCallContext\)

```csharp
public virtual Task<Cashier> UpdateCashier(UpdateCashierRequest request, ServerCallContext context)
```

#### Parameters

`request` [UpdateCashierRequest](Billing.Cashiers.Grpc.UpdateCashierRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)\>

