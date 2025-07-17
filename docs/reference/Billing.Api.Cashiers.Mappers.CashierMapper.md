# <a id="Billing_Api_Cashiers_Mappers_CashierMapper"></a> Class CashierMapper

Namespace: [Billing.Api.Cashiers.Mappers](Billing.Api.Cashiers.Mappers.md)  
Assembly: Billing.Api.dll  

```csharp
public static class CashierMapper
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CashierMapper](Billing.Api.Cashiers.Mappers.CashierMapper.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_Api_Cashiers_Mappers_CashierMapper_ToGrpc_Billing_Cashiers_Contracts_Models_Cashier_"></a> ToGrpc\(Cashier\)

```csharp
public static Cashier ToGrpc(this Cashier source)
```

#### Parameters

`source` [Cashier](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Contracts/Models/Cashier.cs)

#### Returns

 [Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)

### <a id="Billing_Api_Cashiers_Mappers_CashierMapper_ToGrpc_Billing_Cashiers_Queries_GetCashiersQuery_Result_"></a> ToGrpc\(Result\)

```csharp
public static Cashier ToGrpc(this GetCashiersQuery.Result source)
```

#### Parameters

`source` [GetCashiersQuery](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Queries/GetCashiers.cs).[Result](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Queries/GetCashiers.cs)

#### Returns

 [Cashier](Billing.Cashiers.Grpc.Models.Cashier.md)

