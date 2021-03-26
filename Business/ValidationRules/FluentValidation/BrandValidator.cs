using System.Security.Cryptography.X509Certificates;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty();
            RuleFor(b => b.BrandName).MinimumLength(2);
            RuleFor(b => b.BrandName).Must(StartWithM).WithMessage("Ürünler M harfi ile başlamalı").When(c => c.BrandId == 1);
            RuleFor(b => b.BrandName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı").When(c => c.BrandId == 2);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }

        private bool StartWithM(string arg)
        {
            return arg.StartsWith("M");
        }
    }
}