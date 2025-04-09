using FluentValidation;

namespace SFY.Business.DTOs.Material
{
    public class MaterialUpdateDTO
    {
        public string Name { get; set; }

    }
    public class MaterialUpdateDTOValidator : AbstractValidator<MaterialUpdateDTO>
    {
        public MaterialUpdateDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(64);
        }
    }
}
