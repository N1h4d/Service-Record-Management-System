﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    //public class ProductValidator : AbstractValidator<salam>
    //{
    //    public ProductValidator()
    //    {
    //        RuleFor(p => p.ProductName).NotEmpty();
    //        RuleFor(p => p.ProductName).Length(2, 30);
    //        RuleFor(p => p.UnitPrice).NotEmpty();
    //        RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(1);
    //        RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
    //        RuleFor(p => p.ProductName).Must(StartWithA);
    //    }

    //    private bool StartWithA(string arg)
    //    {
    //        return arg.StartsWith("A");
    //    }
    //}
}
