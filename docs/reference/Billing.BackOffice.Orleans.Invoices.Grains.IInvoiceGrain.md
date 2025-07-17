# <a id="Billing_BackOffice_Orleans_Invoices_Grains_IInvoiceGrain"></a> Interface IInvoiceGrain

Namespace: [Billing.BackOffice.Orleans.Invoices.Grains](Billing.BackOffice.Orleans.Invoices.Grains.md)  
Assembly: Billing.BackOffice.Orleans.dll  

```csharp
public interface IInvoiceGrain : IGrainWithGuidKey, IGrain, IAddressable
```

#### Implements

[IGrainWithGuidKey](https://learn.microsoft.com/dotnet/api/orleans.igrainwithguidkey), 
[IGrain](https://learn.microsoft.com/dotnet/api/orleans.igrain), 
[IAddressable](https://learn.microsoft.com/dotnet/api/orleans.runtime.iaddressable)

## Methods

### <a id="Billing_BackOffice_Orleans_Invoices_Grains_IInvoiceGrain_GetState"></a> GetState\(\)

```csharp
Task<InvoiceState> GetState()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[InvoiceState](Billing.BackOffice.Orleans.Invoices.Grains.InvoiceState.md)\>

### <a id="Billing_BackOffice_Orleans_Invoices_Grains_IInvoiceGrain_Notify_System_Boolean_"></a> Notify\(bool\)

```csharp
[OneWay]
Task Notify(bool important)
```

#### Parameters

`important` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="Billing_BackOffice_Orleans_Invoices_Grains_IInvoiceGrain_Pay_System_Decimal_"></a> Pay\(decimal\)

```csharp
Task Pay(decimal amount)
```

#### Parameters

`amount` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

