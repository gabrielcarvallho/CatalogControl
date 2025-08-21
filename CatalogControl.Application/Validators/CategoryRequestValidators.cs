using CatalogControl.Application.DTOs;
using FluentValidation;

namespace CatalogControl.Application.Validators;

public class CategoryRequestValidators : AbstractValidator<CategoryRequestDto>
{
    public CategoryRequestValidators()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required")
            .MaximumLength(100).WithMessage("Name cannot exceed 100 characters");
    }
}