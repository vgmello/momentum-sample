# <a id="Billing_BackOffice_Orleans_Invoices_Grains_InvoiceGrain"></a> Class InvoiceGrain

Namespace: [Billing.BackOffice.Orleans.Invoices.Grains](Billing.BackOffice.Orleans.Invoices.Grains.md)  
Assembly: Billing.BackOffice.Orleans.dll  

```csharp
public sealed class InvoiceGrain : Grain, IGrainBase, IInvoiceGrain, IGrainWithGuidKey, IGrain, IAddressable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Grain](https://learn.microsoft.com/dotnet/api/orleans.grain) ← 
[InvoiceGrain](Billing.BackOffice.Orleans.Invoices.Grains.InvoiceGrain.md)

#### Implements

[IGrainBase](https://learn.microsoft.com/dotnet/api/orleans.igrainbase), 
[IInvoiceGrain](Billing.BackOffice.Orleans.Invoices.Grains.IInvoiceGrain.md), 
[IGrainWithGuidKey](https://learn.microsoft.com/dotnet/api/orleans.igrainwithguidkey), 
[IGrain](https://learn.microsoft.com/dotnet/api/orleans.igrain), 
[IAddressable](https://learn.microsoft.com/dotnet/api/orleans.runtime.iaddressable)

#### Inherited Members

[Grain.OnActivateAsync\(CancellationToken\)](https://learn.microsoft.com/dotnet/api/orleans.grain.onactivateasync), 
[Grain.OnDeactivateAsync\(DeactivationReason, CancellationToken\)](https://learn.microsoft.com/dotnet/api/orleans.grain.ondeactivateasync), 
[Grain.GrainContext](https://learn.microsoft.com/dotnet/api/orleans.grain.graincontext), 
[Grain.GrainReference](https://learn.microsoft.com/dotnet/api/orleans.grain.grainreference), 
[Grain.IdentityString](https://learn.microsoft.com/dotnet/api/orleans.grain.identitystring), 
[Grain.RuntimeIdentity](https://learn.microsoft.com/dotnet/api/orleans.grain.runtimeidentity), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_BackOffice_Orleans_Invoices_Grains_InvoiceGrain__ctor_Orleans_Runtime_IPersistentState_Billing_BackOffice_Orleans_Invoices_Grains_InvoiceState__"></a> InvoiceGrain\(IPersistentState<InvoiceState\>\)

```csharp
public InvoiceGrain(IPersistentState<InvoiceState> state)
```

#### Parameters

`state` [IPersistentState](https://learn.microsoft.com/dotnet/api/orleans.runtime.ipersistentstate\-1)<[InvoiceState](Billing.BackOffice.Orleans.Invoices.Grains.InvoiceState.md)\>

## Methods

### <a id="Billing_BackOffice_Orleans_Invoices_Grains_InvoiceGrain_GetState"></a> GetState\(\)

```csharp
public Task<InvoiceState> GetState()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[InvoiceState](Billing.BackOffice.Orleans.Invoices.Grains.InvoiceState.md)\>

### <a id="Billing_BackOffice_Orleans_Invoices_Grains_InvoiceGrain_Notify_System_Boolean_"></a> Notify\(bool\)

```csharp
public Task Notify(bool important)
```

#### Parameters

`important` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Billing_BackOffice_Orleans_Invoices_Grains_InvoiceGrain_Pay_System_Decimal_"></a> Pay\(decimal\)

```csharp
public Task Pay(decimal amount)
```

#### Parameters

`amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

