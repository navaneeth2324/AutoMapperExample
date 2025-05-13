using AutoMapperExample.DTOs;
using FluentValidation;

namespace AutoMapperExample.Validators
{
    public class ItemDTOValidator : AbstractValidator<ItemDTO>
    {
        public ItemDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.")
                .Length(3,50).WithMessage("Name must be minimum 3 characters");
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id must be greater than 0.")
                .LessThan(100).WithMessage("Id must be less than 100.");
        }
    }
 
}
