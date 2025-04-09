using FluentValidation;
using SFY.Business.DTOs.SizeDTOs;

namespace SFY.Business.DTOs.ColorDTOs
{
    public class ColorCreateDTO
    {
        public string HexCode { get; set; }

    }
    public class ColorCreateDTOValidator : AbstractValidator<ColorCreateDTO>
    {
        public ColorCreateDTOValidator()
        {
            RuleFor(x => x.HexCode)
                .NotEmpty()
                .NotNull()
                .MaximumLength(16);
        }
    }
}
