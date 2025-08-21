using CatalogControl.Application.DTOs;
using FluentValidation;

namespace CatalogControl.Application.Validators;

public class ProductRequestValidators : AbstractValidator<ProductRequestDto>
{
    public ProductRequestValidators()
    {
        RuleFor(x => x.CategoryId)
            .NotEmpty().WithMessage("Category is required");

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required")
            .MaximumLength(100).WithMessage("Name cannot exceed 100 characters");

        RuleFor(x => x.Description)
           .MaximumLength(200).WithMessage("Name cannot exceed 200 characters");

        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("Price cannot be less than 0");
    }
}