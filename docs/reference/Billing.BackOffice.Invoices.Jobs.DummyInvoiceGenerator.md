# <a id="Billing_BackOffice_Invoices_Jobs_DummyInvoiceGenerator"></a> Class DummyInvoiceGenerator

Namespace: [Billing.BackOffice.Invoices.Jobs](Billing.BackOffice.Invoices.Jobs.md)  
Assembly: Billing.BackOffice.dll  

```csharp
public class DummyInvoiceGenerator : BackgroundService, IHostedService, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BackgroundService](https://learn.microsoft.com/dotnet/api/microsoft.extensions.hosting.backgroundservice) ← 
[DummyInvoiceGenerator](Billing.BackOffice.Invoices.Jobs.DummyInvoiceGenerator.md)

#### Implements

[IHostedService](https://learn.microsoft.com/dotnet/api/microsoft.extensions.hosting.ihostedservice), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[BackgroundService.ExecuteAsync\(CancellationToken\)](https://learn.microsoft.com/dotnet/api/microsoft.extensions.hosting.backgroundservice.executeasync), 
[BackgroundService.StartAsync\(CancellationToken\)](https://learn.microsoft.com/dotnet/api/microsoft.extensions.hosting.backgroundservice.startasync), 
[BackgroundService.StopAsync\(CancellationToken\)](https://learn.microsoft.com/dotnet/api/microsoft.extensions.hosting.backgroundservice.stopasync), 
[BackgroundService.Dispose\(\)](https://learn.microsoft.com/dotnet/api/microsoft.extensions.hosting.backgroundservice.dispose), 
[BackgroundService.ExecuteTask](https://learn.microsoft.com/dotnet/api/microsoft.extensions.hosting.backgroundservice.executetask), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_BackOffice_Invoices_Jobs_DummyInvoiceGenerator__ctor_Wolverine_IMessageBus_"></a> DummyInvoiceGenerator\(IMessageBus\)

```csharp
public DummyInvoiceGenerator(IMessageBus bus)
```

#### Parameters

`bus` IMessageBus

## Methods

### <a id="Billing_BackOffice_Invoices_Jobs_DummyInvoiceGenerator_ExecuteAsync_System_Threading_CancellationToken_"></a> ExecuteAsync\(CancellationToken\)

```csharp
protected override Task ExecuteAsync(CancellationToken stoppingToken)
```

#### Parameters

`stoppingToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

