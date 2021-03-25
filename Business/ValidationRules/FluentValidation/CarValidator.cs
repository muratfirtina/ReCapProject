using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(500).When(c => c.BrandId == 1);
            RuleFor(c => c.CarName).Must(StartWithM).WithMessage("Ürünler M harfi ile başlamalı").When(c=>c.BrandId==1);
        }

        private bool StartWithM(string arg)
        {
            return arg.StartsWith("M");
        }
    }
}
