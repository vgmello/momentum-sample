# <a id="Billing_Invoices_Commands_CreateInvoiceValidator"></a> Class CreateInvoiceValidator

Namespace: [Billing.Invoices.Commands](Billing.Invoices.Commands.md)  
Assembly: Billing.dll  

```csharp
public class CreateInvoiceValidator : AbstractValidator<CreateInvoiceCommand>, IValidator<CreateInvoiceCommand>, IValidator, IEnumerable<IValidationRule>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
AbstractValidator<CreateInvoiceCommand\> ← 
[CreateInvoiceValidator](Billing.Invoices.Commands.CreateInvoiceValidator.md)

#### Implements

IValidator<CreateInvoiceCommand\>, 
IValidator, 
[IEnumerable<IValidationRule\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

AbstractValidator<CreateInvoiceCommand\>.Validate\(CreateInvoiceCommand\), 
AbstractValidator<CreateInvoiceCommand\>.ValidateAsync\(CreateInvoiceCommand, CancellationToken\), 
AbstractValidator<CreateInvoiceCommand\>.Validate\(ValidationContext<CreateInvoiceCommand\>\), 
AbstractValidator<CreateInvoiceCommand\>.ValidateAsync\(ValidationContext<CreateInvoiceCommand\>, CancellationToken\), 
AbstractValidator<CreateInvoiceCommand\>.CreateDescriptor\(\), 
AbstractValidator<CreateInvoiceCommand\>.RuleFor<TProperty\>\(Expression<Func<CreateInvoiceCommand, TProperty\>\>\), 
AbstractValidator<CreateInvoiceCommand\>.RuleForEach<TElement\>\(Expression<Func<CreateInvoiceCommand, IEnumerable<TElement\>\>\>\), 
AbstractValidator<CreateInvoiceCommand\>.RuleSet\(string, Action\), 
AbstractValidator<CreateInvoiceCommand\>.When\(Func<CreateInvoiceCommand, bool\>, Action\), 
AbstractValidator<CreateInvoiceCommand\>.When\(Func<CreateInvoiceCommand, ValidationContext<CreateInvoiceCommand\>, bool\>, Action\), 
AbstractValidator<CreateInvoiceCommand\>.Unless\(Func<CreateInvoiceCommand, bool\>, Action\), 
AbstractValidator<CreateInvoiceCommand\>.Unless\(Func<CreateInvoiceCommand, ValidationContext<CreateInvoiceCommand\>, bool\>, Action\), 
AbstractValidator<CreateInvoiceCommand\>.WhenAsync\(Func<CreateInvoiceCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CreateInvoiceCommand\>.WhenAsync\(Func<CreateInvoiceCommand, ValidationContext<CreateInvoiceCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CreateInvoiceCommand\>.UnlessAsync\(Func<CreateInvoiceCommand, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CreateInvoiceCommand\>.UnlessAsync\(Func<CreateInvoiceCommand, ValidationContext<CreateInvoiceCommand\>, CancellationToken, Task<bool\>\>, Action\), 
AbstractValidator<CreateInvoiceCommand\>.Include\(IValidator<CreateInvoiceCommand\>\), 
AbstractValidator<CreateInvoiceCommand\>.Include<TValidator\>\(Func<CreateInvoiceCommand, TValidator\>\), 
AbstractValidator<CreateInvoiceCommand\>.GetEnumerator\(\), 
AbstractValidator<CreateInvoiceCommand\>.PreValidate\(ValidationContext<CreateInvoiceCommand\>, ValidationResult\), 
AbstractValidator<CreateInvoiceCommand\>.RaiseValidationException\(ValidationContext<CreateInvoiceCommand\>, ValidationResult\), 
AbstractValidator<CreateInvoiceCommand\>.OnRuleAdded\(IValidationRule<CreateInvoiceCommand\>\), 
AbstractValidator<CreateInvoiceCommand\>.ClassLevelCascadeMode, 
AbstractValidator<CreateInvoiceCommand\>.RuleLevelCascadeMode, 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Invoices_Commands_CreateInvoiceValidator__ctor"></a> CreateInvoiceValidator\(\)

```csharp
public CreateInvoiceValidator()
```

