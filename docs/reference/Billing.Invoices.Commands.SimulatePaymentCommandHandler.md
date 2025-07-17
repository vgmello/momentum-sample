# <a id="Billing_Invoices_Commands_SimulatePaymentCommandHandler"></a> Class SimulatePaymentCommandHandler

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public static class SimulatePaymentCommandHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SimulatePaymentCommandHandler](Billing.Invoices.Commands.SimulatePaymentCommandHandler.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_Invoices_Commands_SimulatePaymentCommandHandler_Handle_Billing_Invoices_Commands_SimulatePaymentCommand_Wolverine_IMessageBus_System_Threading_CancellationToken_"></a> Handle\(SimulatePaymentCommand, IMessageBus, CancellationToken\)

```csharp
public static Task<(Result<bool>, PaymentReceived)> Handle(SimulatePaymentCommand command, IMessageBus messaging, CancellationToken cancellationToken)
```

#### Parameters

`command` [SimulatePaymentCommand](Billing.Invoices.Commands.SimulatePaymentCommand.md)

`messaging` IMessageBus

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<\([Result](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/libs/Operations/src/Operations.Extensions/Result.cs)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>, [PaymentReceived](Billing.Invoices.Contracts.IntegrationEvents.PaymentReceived.md)\)\>

