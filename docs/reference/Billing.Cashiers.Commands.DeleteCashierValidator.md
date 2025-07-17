# <a id="Billing_Cashiers_Commands_DeleteCashierValidator"></a> Class DeleteCashierValidator

Namespace: [Billing.Cashiers.Commands](Billing.Cashiers.Commands.md)  
Assembly: Billing.dll  

```csharp
public class DeleteCashierValidator : AbstractValidator<DeleteCashierCommand>, IValidator<DeleteCashierCommand>, IValidator, IEnumerable<IValidationRule>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
AbstractValidator<DeleteCashierCommand\> ← 
[DeleteCashierValidator](Billing.Cashiers.Commands.DeleteCashierValidator.md)

#### Implements

IValidator<DeleteCashierCommand\>, 
IValidator, 
[IEnumerable<IValidationRule\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

AbstractValidator<DeleteCashierCommand\>.Validate\(DeleteCashierCommand\), 
AbstractValidator<DeleteCashierCommand\>.ValidateAsync\(DeleteCashierCommand, CancellationToken\), 
AbstractValidator<DeleteCashierCommand\>.Validate\(ValidationContext<DeleteCashierCommand\>\), 
AbstractValidator<DeleteCashierCommand\>.ValidateAsync\(ValidationContext<DeleteCashierCommand\>, CancellationToken\), 
AbstractValidator<DeleteCashierCommand\>.CreateDescriptor\(\), 
AbstractValidator<DeleteCashierCommand\>.RuleFor<TProperty\>\(Expression<Func<DeleteCashierCommand, TProperty\>\>\), 
AbstractValidator<DeleteCashierCommand\>.RuleForEach<TElement\>\(Expression<Func<DeleteCashierCommand, IEnumerable<TElement\>\>\>\), 
AbstractValidator<DeleteCashierCommand\>.RuleSet\(string, Action\), 
AbstractValidator<DeleteCashierCommand\>.When\(Func<DeleteCashierCommand, bool\>, Action\), 
AbstractValidator<DeleteCashierCommand\>.When\(Func<DeleteCashierCommand, ValidationContext<DeleteCashierCommand\>, bool\>, Action\), 
AbstractValidator<DeleteCashierCommand\>.Unless\(Func<DeleteCashierCommand, bool\>, Action\), 
AbstractValidator<DeleteCashierCommand\>.Unless\(Func<DeleteCashierCommand, ValidationContext<DeleteCashierCommand\>, bool\>, Action\), 
AbstractValidator<DeleteCashierCommand\>.WhenAsync\(Func<DeleteCashierCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<DeleteCashierCommand\>.WhenAsync\(Func<DeleteCashierCommand, ValidationContext<DeleteCashierCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<DeleteCashierCommand\>.UnlessAsync\(Func<DeleteCashierCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<DeleteCashierCommand\>.UnlessAsync\(Func<DeleteCashierCommand, ValidationContext<DeleteCashierCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<DeleteCashierCommand\>.Include\(IValidator<DeleteCashierCommand\>\), 
AbstractValidator<DeleteCashierCommand\>.Include<TValidator\>\(Func<DeleteCashierCommand, TValidator\>\), 
AbstractValidator<DeleteCashierCommand\>.GetEnumerator\(\), 
AbstractValidator<DeleteCashierCommand\>.PreValidate\(ValidationContext<DeleteCashierCommand\>, ValidationResult\), 
AbstractValidator<DeleteCashierCommand\>.RaiseValidationException\(ValidationContext<DeleteCashierCommand\>, ValidationResult\), 
AbstractValidator<DeleteCashierCommand\>.OnRuleAdded\(IValidationRule<DeleteCashierCommand\>\), 
AbstractValidator<DeleteCashierCommand\>.ClassLevelCascadeMode, 
AbstractValidator<DeleteCashierCommand\>.RuleLevelCascadeMode, 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Cashiers_Commands_DeleteCashierValidator__ctor"></a> DeleteCashierValidator\(\)

```csharp
public DeleteCashierValidator()
```

