using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cus => cus.CompanyName).NotEmpty();
            RuleFor(cus => cus.CompanyName).MinimumLength(2);
        }
    }
}