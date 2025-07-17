# <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidValidator"></a> Class MarkInvoiceAsPaidValidator

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public class MarkInvoiceAsPaidValidator : AbstractValidator<MarkInvoiceAsPaidCommand>, IValidator<MarkInvoiceAsPaidCommand>, IValidator, IEnumerable<IValidationRule>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
AbstractValidator<MarkInvoiceAsPaidCommand\> ← 
[MarkInvoiceAsPaidValidator](Billing.Invoices.Commands.MarkInvoiceAsPaidValidator.md)

#### Implements

IValidator<MarkInvoiceAsPaidCommand\>, 
IValidator, 
[IEnumerable<IValidationRule\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

AbstractValidator<MarkInvoiceAsPaidCommand\>.Validate\(MarkInvoiceAsPaidCommand\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.ValidateAsync\(MarkInvoiceAsPaidCommand, CancellationToken\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.Validate\(ValidationContext<MarkInvoiceAsPaidCommand\>\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.ValidateAsync\(ValidationContext<MarkInvoiceAsPaidCommand\>, CancellationToken\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.CreateDescriptor\(\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.RuleFor<TProperty\>\(Expression<Func<MarkInvoiceAsPaidCommand, TProperty\>\>\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.RuleForEach<TElement\>\(Expression<Func<MarkInvoiceAsPaidCommand, IEnumerable<TElement\>\>\>\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.RuleSet\(string, Action\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.When\(Func<MarkInvoiceAsPaidCommand, bool\>, Action\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.When\(Func<MarkInvoiceAsPaidCommand, ValidationContext<MarkInvoiceAsPaidCommand\>, bool\>, Action\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.Unless\(Func<MarkInvoiceAsPaidCommand, bool\>, Action\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.Unless\(Func<MarkInvoiceAsPaidCommand, ValidationContext<MarkInvoiceAsPaidCommand\>, bool\>, Action\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.WhenAsync\(Func<MarkInvoiceAsPaidCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.WhenAsync\(Func<MarkInvoiceAsPaidCommand, ValidationContext<MarkInvoiceAsPaidCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.UnlessAsync\(Func<MarkInvoiceAsPaidCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.UnlessAsync\(Func<MarkInvoiceAsPaidCommand, ValidationContext<MarkInvoiceAsPaidCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.Include\(IValidator<MarkInvoiceAsPaidCommand\>\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.Include<TValidator\>\(Func<MarkInvoiceAsPaidCommand, TValidator\>\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.GetEnumerator\(\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.PreValidate\(ValidationContext<MarkInvoiceAsPaidCommand\>, ValidationResult\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.RaiseValidationException\(ValidationContext<MarkInvoiceAsPaidCommand\>, ValidationResult\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.OnRuleAdded\(IValidationRule<MarkInvoiceAsPaidCommand\>\), 
AbstractValidator<MarkInvoiceAsPaidCommand\>.ClassLevelCascadeMode, 
AbstractValidator<MarkInvoiceAsPaidCommand\>.RuleLevelCascadeMode, 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Commands_MarkInvoiceAsPaidValidator__ctor"></a> MarkInvoiceAsPaidValidator\(\)

```csharp
public MarkInvoiceAsPaidValidator()
```

