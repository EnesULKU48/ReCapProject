using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(col => col.ColorId).NotEmpty();
            RuleFor(col => col.ColorName).NotEmpty();
            RuleFor(col => col.ColorName).MinimumLength(2);
        }
    }
}
