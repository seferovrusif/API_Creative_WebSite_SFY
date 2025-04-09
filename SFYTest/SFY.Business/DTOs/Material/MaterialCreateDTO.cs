using FluentValidation;
using SFY.Business.DTOs.SizeDTOs;

namespace SFY.Business.DTOs.Material
{
    public class MaterialCreateDTO
    {
        public string Name { get; set; }
    }
    public class MaterialCreateDTOValidator : AbstractValidator<MaterialCreateDTO>
    {
        public MaterialCreateDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(64);
        }
    }
}
