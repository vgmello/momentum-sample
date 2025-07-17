# <a id="Billing_Api_Cashiers_CashierService"></a> Class CashierService

Namespace: [Billing.Api.Cashiers](Billing.Api.Cashiers.md)  
Assembly: Billing.Api.dll  

```csharp
public class CashierService : CashiersService.CashiersServiceBase
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CashiersService.CashiersServiceBase](Billing.Cashiers.Grpc.CashiersService.CashiersServiceBase.md) ← 
[CashierService](Billing.Api.Cashiers.CashierService.md)

#### Inherited Members

[CashiersService.CashiersServiceBase.GetCashier\(GetCashierRequest, ServerCallContext\)](Billing.Cashiers.Grpc.CashiersService.CashiersServiceBase.md\#Billing\_Cashiers\_Grpc\_CashiersService\_CashiersServiceBase\_GetCashier\_Billing\_Cashiers\_Grpc\_GetCashierRequest\_Grpc\_Core\_ServerCallContext\_), 
[CashiersService.CashiersServiceBase.GetCashiers\(GetCashiersRequest, ServerCallContext\)](Billing.Cashiers.Grpc.CashiersService.CashiersServiceBase.md\#Billing\_Cashiers\_Grpc\_CashiersService\_CashiersServiceBase\_GetCashiers\_Billing\_Cashiers\_Grpc\_GetCashiersRequest\_Grpc\_Core\_ServerCallContext\_), 
[CashiersService.CashiersServiceBase.CreateCashier\(CreateCashierRequest, ServerCallContext\)](Billing.Cashiers.Grpc.CashiersService.CashiersServiceBase.md\#Billing\_Cashiers\_Grpc\_CashiersService\_CashiersServiceBase\_CreateCashier\_Billing\_Cashiers\_Grpc\_CreateCashierRequest\_Grpc\_Core\_ServerCallContext\_), 
[CashiersService.CashiersServiceBase.UpdateCashier\(UpdateCashierRequest, ServerCallContext\)](Billing.Cashiers.Grpc.CashiersService.CashiersServiceBase.md\#Billing\_Cashiers\_Grpc\_CashiersService\_CashiersServiceBase\_UpdateCashier\_Billing\_Cashiers\_Grpc\_UpdateCashierRequest\_Grpc\_Core\_ServerCallContext\_), 
[CashiersService.CashiersServiceBase.DeleteCashier\(DeleteCashierRequest, ServerCallContext\)](Billing.Cashiers.Grpc.CashiersService.CashiersServiceBase.md\#Billing\_Cashiers\_Grpc\_CashiersService\_CashiersServiceBase\_DeleteCashier\_Billing\_Cashiers\_Grpc\_DeleteCashierRequest\_Grpc\_Core\_ServerCallContext\_), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Api_Cashiers_CashierService__ctor_Wolverine_IMessageBus_"></a> CashierService\(IMessageBus\)

```csharp
public CashierService(IMessageBus bus)
```

#### Parameters

`bus` IMessageBus

## Methods

### <a id="Billing_Api_Cashiers_CashierService_CreateCashier_Billing_Cashiers_Grpc_CreateCashierRequest_Grpc_Core_ServerCallContext_"></a> CreateCashier\(CreateCashierRequest, ServerCallContext\)

```csharp
public override Task<Cashier> CreateCashier(CreateCashierRequest request, ServerCallContext context)
```

#### Parameters

`request` [CreateCashierRequest](Billing.Cashiers.Grpc.CreateCashierRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)\>

### <a id="Billing_Api_Cashiers_CashierService_DeleteCashier_Billing_Cashiers_Grpc_DeleteCashierRequest_Grpc_Core_ServerCallContext_"></a> DeleteCashier\(DeleteCashierRequest, ServerCallContext\)

```csharp
public override Task<Empty> DeleteCashier(DeleteCashierRequest request, ServerCallContext context)
```

#### Parameters

`request` [DeleteCashierRequest](Billing.Cashiers.Grpc.DeleteCashierRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<Empty\>

### <a id="Billing_Api_Cashiers_CashierService_GetCashier_Billing_Cashiers_Grpc_GetCashierRequest_Grpc_Core_ServerCallContext_"></a> GetCashier\(GetCashierRequest, ServerCallContext\)

```csharp
public override Task<Cashier> GetCashier(GetCashierRequest request, ServerCallContext context)
```

#### Parameters

`request` [GetCashierRequest](Billing.Cashiers.Grpc.GetCashierRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)\>

### <a id="Billing_Api_Cashiers_CashierService_GetCashiers_Billing_Cashiers_Grpc_GetCashiersRequest_Grpc_Core_ServerCallContext_"></a> GetCashiers\(GetCashiersRequest, ServerCallContext\)

```csharp
public override Task<GetCashiersResponse> GetCashiers(GetCashiersRequest request, ServerCallContext context)
```

#### Parameters

`request` [GetCashiersRequest](Billing.Cashiers.Grpc.GetCashiersRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[GetCashiersResponse](Billing.Cashiers.Grpc.GetCashiersResponse.md)\>

### <a id="Billing_Api_Cashiers_CashierService_UpdateCashier_Billing_Cashiers_Grpc_UpdateCashierRequest_Grpc_Core_ServerCallContext_"></a> UpdateCashier\(UpdateCashierRequest, ServerCallContext\)

```csharp
public override Task<Cashier> UpdateCashier(UpdateCashierRequest request, ServerCallContext context)
```

#### Parameters

`request` [UpdateCashierRequest](Billing.Cashiers.Grpc.UpdateCashierRequest.md)

`context` ServerCallContext

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)\>

