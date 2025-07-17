# <a id="Billing_Invoices_Commands_CancelInvoiceValidator"></a> Class CancelInvoiceValidator

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public class CancelInvoiceValidator : AbstractValidator<CancelInvoiceCommand>, IValidator<CancelInvoiceCommand>, IValidator, IEnumerable<IValidationRule>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
AbstractValidator<CancelInvoiceCommand\> ← 
[CancelInvoiceValidator](Billing.Invoices.Commands.CancelInvoiceValidator.md)

#### Implements

IValidator<CancelInvoiceCommand\>, 
IValidator, 
[IEnumerable<IValidationRule\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

AbstractValidator<CancelInvoiceCommand\>.Validate\(CancelInvoiceCommand\), 
AbstractValidator<CancelInvoiceCommand\>.ValidateAsync\(CancelInvoiceCommand, CancellationToken\), 
AbstractValidator<CancelInvoiceCommand\>.Validate\(ValidationContext<CancelInvoiceCommand\>\), 
AbstractValidator<CancelInvoiceCommand\>.ValidateAsync\(ValidationContext<CancelInvoiceCommand\>, CancellationToken\), 
AbstractValidator<CancelInvoiceCommand\>.CreateDescriptor\(\), 
AbstractValidator<CancelInvoiceCommand\>.RuleFor<TProperty\>\(Expression<Func<CancelInvoiceCommand, TProperty\>\>\), 
AbstractValidator<CancelInvoiceCommand\>.RuleForEach<TElement\>\(Expression<Func<CancelInvoiceCommand, IEnumerable<TElement\>\>\>\), 
AbstractValidator<CancelInvoiceCommand\>.RuleSet\(string, Action\), 
AbstractValidator<CancelInvoiceCommand\>.When\(Func<CancelInvoiceCommand, bool\>, Action\), 
AbstractValidator<CancelInvoiceCommand\>.When\(Func<CancelInvoiceCommand, ValidationContext<CancelInvoiceCommand\>, bool\>, Action\), 
AbstractValidator<CancelInvoiceCommand\>.Unless\(Func<CancelInvoiceCommand, bool\>, Action\), 
AbstractValidator<CancelInvoiceCommand\>.Unless\(Func<CancelInvoiceCommand, ValidationContext<CancelInvoiceCommand\>, bool\>, Action\), 
AbstractValidator<CancelInvoiceCommand\>.WhenAsync\(Func<CancelInvoiceCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CancelInvoiceCommand\>.WhenAsync\(Func<CancelInvoiceCommand, ValidationContext<CancelInvoiceCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CancelInvoiceCommand\>.UnlessAsync\(Func<CancelInvoiceCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CancelInvoiceCommand\>.UnlessAsync\(Func<CancelInvoiceCommand, ValidationContext<CancelInvoiceCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CancelInvoiceCommand\>.Include\(IValidator<CancelInvoiceCommand\>\), 
AbstractValidator<CancelInvoiceCommand\>.Include<TValidator\>\(Func<CancelInvoiceCommand, TValidator\>\), 
AbstractValidator<CancelInvoiceCommand\>.GetEnumerator\(\), 
AbstractValidator<CancelInvoiceCommand\>.PreValidate\(ValidationContext<CancelInvoiceCommand\>, ValidationResult\), 
AbstractValidator<CancelInvoiceCommand\>.RaiseValidationException\(ValidationContext<CancelInvoiceCommand\>, ValidationResult\), 
AbstractValidator<CancelInvoiceCommand\>.OnRuleAdded\(IValidationRule<CancelInvoiceCommand\>\), 
AbstractValidator<CancelInvoiceCommand\>.ClassLevelCascadeMode, 
AbstractValidator<CancelInvoiceCommand\>.RuleLevelCascadeMode, 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Commands_CancelInvoiceValidator__ctor"></a> CancelInvoiceValidator\(\)

```csharp
public CancelInvoiceValidator()
```

