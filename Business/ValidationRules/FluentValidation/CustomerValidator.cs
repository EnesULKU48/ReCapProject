using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.UserId).NotEmpty();
            RuleFor(r => r.CompanyName).NotEmpty();
            RuleFor(r => r.CompanyName).MinimumLength(2);
        }
    }
}
