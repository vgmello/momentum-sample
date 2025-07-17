# <a id="Billing_Cashiers_Commands_CreateCashierValidator"></a> Class CreateCashierValidator

Namespace: [Billing.Cashiers.Commands](Billing.Cashiers.Commands.md)  
Assembly: Billing.dll  

```csharp
public class CreateCashierValidator : AbstractValidator<CreateCashierCommand>, IValidator<CreateCashierCommand>, IValidator, IEnumerable<IValidationRule>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
AbstractValidator<CreateCashierCommand\> ← 
[CreateCashierValidator](Billing.Cashiers.Commands.CreateCashierValidator.md)

#### Implements

IValidator<CreateCashierCommand\>, 
IValidator, 
[IEnumerable<IValidationRule\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

AbstractValidator<CreateCashierCommand\>.Validate\(CreateCashierCommand\), 
AbstractValidator<CreateCashierCommand\>.ValidateAsync\(CreateCashierCommand, CancellationToken\), 
AbstractValidator<CreateCashierCommand\>.Validate\(ValidationContext<CreateCashierCommand\>\), 
AbstractValidator<CreateCashierCommand\>.ValidateAsync\(ValidationContext<CreateCashierCommand\>, CancellationToken\), 
AbstractValidator<CreateCashierCommand\>.CreateDescriptor\(\), 
AbstractValidator<CreateCashierCommand\>.RuleFor<TProperty\>\(Expression<Func<CreateCashierCommand, TProperty\>\>\), 
AbstractValidator<CreateCashierCommand\>.RuleForEach<TElement\>\(Expression<Func<CreateCashierCommand, IEnumerable<TElement\>\>\>\), 
AbstractValidator<CreateCashierCommand\>.RuleSet\(string, Action\), 
AbstractValidator<CreateCashierCommand\>.When\(Func<CreateCashierCommand, bool\>, Action\), 
AbstractValidator<CreateCashierCommand\>.When\(Func<CreateCashierCommand, ValidationContext<CreateCashierCommand\>, bool\>, Action\), 
AbstractValidator<CreateCashierCommand\>.Unless\(Func<CreateCashierCommand, bool\>, Action\), 
AbstractValidator<CreateCashierCommand\>.Unless\(Func<CreateCashierCommand, ValidationContext<CreateCashierCommand\>, bool\>, Action\), 
AbstractValidator<CreateCashierCommand\>.WhenAsync\(Func<CreateCashierCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CreateCashierCommand\>.WhenAsync\(Func<CreateCashierCommand, ValidationContext<CreateCashierCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CreateCashierCommand\>.UnlessAsync\(Func<CreateCashierCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CreateCashierCommand\>.UnlessAsync\(Func<CreateCashierCommand, ValidationContext<CreateCashierCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CreateCashierCommand\>.Include\(IValidator<CreateCashierCommand\>\), 
AbstractValidator<CreateCashierCommand\>.Include<TValidator\>\(Func<CreateCashierCommand, TValidator\>\), 
AbstractValidator<CreateCashierCommand\>.GetEnumerator\(\), 
AbstractValidator<CreateCashierCommand\>.PreValidate\(ValidationContext<CreateCashierCommand\>, ValidationResult\), 
AbstractValidator<CreateCashierCommand\>.RaiseValidationException\(ValidationContext<CreateCashierCommand\>, ValidationResult\), 
AbstractValidator<CreateCashierCommand\>.OnRuleAdded\(IValidationRule<CreateCashierCommand\>\), 
AbstractValidator<CreateCashierCommand\>.ClassLevelCascadeMode, 
AbstractValidator<CreateCashierCommand\>.RuleLevelCascadeMode, 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Commands_CreateCashierValidator__ctor"></a> CreateCashierValidator\(\)

```csharp
public CreateCashierValidator()
```

