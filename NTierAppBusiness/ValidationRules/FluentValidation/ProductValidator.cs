using FluentValidation;
using NTierApp.Entities.Concrete;

namespace NTierApp.Business.ValidationRules.FluentValidation;

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz!");
        RuleFor(p => p.CategoryId).NotEmpty();
        RuleFor(p => p.UnitPrice).NotEmpty();
        RuleFor(p => p.QuantityPerUnit).NotEmpty();
        RuleFor(p => p.UnitsInStock).NotEmpty();

        RuleFor(p => p.UnitPrice).GreaterThan(0);
        RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
        RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);

        RuleFor(p => p.ProductName).Must(StartWithK).WithMessage("Ürün adı K karfi ile başlamalı!");
    }

    private bool StartWithK(string? arg)
    {
        return arg!.StartsWith("K");
    }
}