# <a id="Billing_BackOffice_Orleans_Invoices_Grains_InvoiceState"></a> Class InvoiceState

Namespace: [Billing.BackOffice.Orleans.Invoices.Grains](Billing.BackOffice.Orleans.Invoices.Grains.md)  
Assembly: Billing.BackOffice.Orleans.dll  

```csharp
[GenerateSerializer]
public sealed class InvoiceState
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvoiceState](Billing.BackOffice.Orleans.Invoices.Grains.InvoiceState.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_BackOffice_Orleans_Invoices_Grains_InvoiceState__ctor"></a> InvoiceState\(\)

```csharp
public InvoiceState()
```

## Properties

### <a id="Billing_BackOffice_Orleans_Invoices_Grains_InvoiceState_Amount"></a> Amount

```csharp
[Id(0)]
public decimal Amount { get; set; }
```

#### Property Value

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="Billing_BackOffice_Orleans_Invoices_Grains_InvoiceState_Paid"></a> Paid

```csharp
[Id(1)]
public bool Paid { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

