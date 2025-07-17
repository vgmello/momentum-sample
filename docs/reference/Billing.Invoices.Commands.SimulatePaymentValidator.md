# <a id="Billing_Invoices_Commands_SimulatePaymentValidator"></a> Class SimulatePaymentValidator

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public class SimulatePaymentValidator : AbstractValidator<SimulatePaymentCommand>, IValidator<SimulatePaymentCommand>, IValidator, IEnumerable<IValidationRule>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
AbstractValidator<SimulatePaymentCommand\> ← 
[SimulatePaymentValidator](Billing.Invoices.Commands.SimulatePaymentValidator.md)

#### Implements

IValidator<SimulatePaymentCommand\>, 
IValidator, 
[IEnumerable<IValidationRule\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

AbstractValidator<SimulatePaymentCommand\>.Validate\(SimulatePaymentCommand\), 
AbstractValidator<SimulatePaymentCommand\>.ValidateAsync\(SimulatePaymentCommand, CancellationToken\), 
AbstractValidator<SimulatePaymentCommand\>.Validate\(ValidationContext<SimulatePaymentCommand\>\), 
AbstractValidator<SimulatePaymentCommand\>.ValidateAsync\(ValidationContext<SimulatePaymentCommand\>, CancellationToken\), 
AbstractValidator<SimulatePaymentCommand\>.CreateDescriptor\(\), 
AbstractValidator<SimulatePaymentCommand\>.RuleFor<TProperty\>\(Expression<Func<SimulatePaymentCommand, TProperty\>\>\), 
AbstractValidator<SimulatePaymentCommand\>.RuleForEach<TElement\>\(Expression<Func<SimulatePaymentCommand, IEnumerable<TElement\>\>\>\), 
AbstractValidator<SimulatePaymentCommand\>.RuleSet\(string, Action\), 
AbstractValidator<SimulatePaymentCommand\>.When\(Func<SimulatePaymentCommand, bool\>, Action\), 
AbstractValidator<SimulatePaymentCommand\>.When\(Func<SimulatePaymentCommand, ValidationContext<SimulatePaymentCommand\>, bool\>, Action\), 
AbstractValidator<SimulatePaymentCommand\>.Unless\(Func<SimulatePaymentCommand, bool\>, Action\), 
AbstractValidator<SimulatePaymentCommand\>.Unless\(Func<SimulatePaymentCommand, ValidationContext<SimulatePaymentCommand\>, bool\>, Action\), 
AbstractValidator<SimulatePaymentCommand\>.WhenAsync\(Func<SimulatePaymentCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<SimulatePaymentCommand\>.WhenAsync\(Func<SimulatePaymentCommand, ValidationContext<SimulatePaymentCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<SimulatePaymentCommand\>.UnlessAsync\(Func<SimulatePaymentCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<SimulatePaymentCommand\>.UnlessAsync\(Func<SimulatePaymentCommand, ValidationContext<SimulatePaymentCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<SimulatePaymentCommand\>.Include\(IValidator<SimulatePaymentCommand\>\), 
AbstractValidator<SimulatePaymentCommand\>.Include<TValidator\>\(Func<SimulatePaymentCommand, TValidator\>\), 
AbstractValidator<SimulatePaymentCommand\>.GetEnumerator\(\), 
AbstractValidator<SimulatePaymentCommand\>.PreValidate\(ValidationContext<SimulatePaymentCommand\>, ValidationResult\), 
AbstractValidator<SimulatePaymentCommand\>.RaiseValidationException\(ValidationContext<SimulatePaymentCommand\>, ValidationResult\), 
AbstractValidator<SimulatePaymentCommand\>.OnRuleAdded\(IValidationRule<SimulatePaymentCommand\>\), 
AbstractValidator<SimulatePaymentCommand\>.ClassLevelCascadeMode, 
AbstractValidator<SimulatePaymentCommand\>.RuleLevelCascadeMode, 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Commands_SimulatePaymentValidator__ctor"></a> SimulatePaymentValidator\(\)

```csharp
public SimulatePaymentValidator()
```

