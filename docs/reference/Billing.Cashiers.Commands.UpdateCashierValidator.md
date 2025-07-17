# <a id="Billing_Cashiers_Commands_UpdateCashierValidator"></a> Class UpdateCashierValidator

Namespace: [Billing.Cashiers.Commands](Billing.Cashiers.Commands.md)  
Assembly: Billing.dll  

```csharp
public class UpdateCashierValidator : AbstractValidator<UpdateCashierCommand>, IValidator<UpdateCashierCommand>, IValidator, IEnumerable<IValidationRule>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
AbstractValidator<UpdateCashierCommand\> ← 
[UpdateCashierValidator](Billing.Cashiers.Commands.UpdateCashierValidator.md)

#### Implements

IValidator<UpdateCashierCommand\>, 
IValidator, 
[IEnumerable<IValidationRule\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

AbstractValidator<UpdateCashierCommand\>.Validate\(UpdateCashierCommand\), 
AbstractValidator<UpdateCashierCommand\>.ValidateAsync\(UpdateCashierCommand, CancellationToken\), 
AbstractValidator<UpdateCashierCommand\>.Validate\(ValidationContext<UpdateCashierCommand\>\), 
AbstractValidator<UpdateCashierCommand\>.ValidateAsync\(ValidationContext<UpdateCashierCommand\>, CancellationToken\), 
AbstractValidator<UpdateCashierCommand\>.CreateDescriptor\(\), 
AbstractValidator<UpdateCashierCommand\>.RuleFor<TProperty\>\(Expression<Func<UpdateCashierCommand, TProperty\>\>\), 
AbstractValidator<UpdateCashierCommand\>.RuleForEach<TElement\>\(Expression<Func<UpdateCashierCommand, IEnumerable<TElement\>\>\>\), 
AbstractValidator<UpdateCashierCommand\>.RuleSet\(string, Action\), 
AbstractValidator<UpdateCashierCommand\>.When\(Func<UpdateCashierCommand, bool\>, Action\), 
AbstractValidator<UpdateCashierCommand\>.When\(Func<UpdateCashierCommand, ValidationContext<UpdateCashierCommand\>, bool\>, Action\), 
AbstractValidator<UpdateCashierCommand\>.Unless\(Func<UpdateCashierCommand, bool\>, Action\), 
AbstractValidator<UpdateCashierCommand\>.Unless\(Func<UpdateCashierCommand, ValidationContext<UpdateCashierCommand\>, bool\>, Action\), 
AbstractValidator<UpdateCashierCommand\>.WhenAsync\(Func<UpdateCashierCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<UpdateCashierCommand\>.WhenAsync\(Func<UpdateCashierCommand, ValidationContext<UpdateCashierCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<UpdateCashierCommand\>.UnlessAsync\(Func<UpdateCashierCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<UpdateCashierCommand\>.UnlessAsync\(Func<UpdateCashierCommand, ValidationContext<UpdateCashierCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<UpdateCashierCommand\>.Include\(IValidator<UpdateCashierCommand\>\), 
AbstractValidator<UpdateCashierCommand\>.Include<TValidator\>\(Func<UpdateCashierCommand, TValidator\>\), 
AbstractValidator<UpdateCashierCommand\>.GetEnumerator\(\), 
AbstractValidator<UpdateCashierCommand\>.PreValidate\(ValidationContext<UpdateCashierCommand\>, ValidationResult\), 
AbstractValidator<UpdateCashierCommand\>.RaiseValidationException\(ValidationContext<UpdateCashierCommand\>, ValidationResult\), 
AbstractValidator<UpdateCashierCommand\>.OnRuleAdded\(IValidationRule<UpdateCashierCommand\>\), 
AbstractValidator<UpdateCashierCommand\>.ClassLevelCascadeMode, 
AbstractValidator<UpdateCashierCommand\>.RuleLevelCascadeMode, 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Commands_UpdateCashierValidator__ctor"></a> UpdateCashierValidator\(\)

```csharp
public UpdateCashierValidator()
```

