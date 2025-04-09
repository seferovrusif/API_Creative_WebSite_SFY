using FluentValidation;

namespace SFY.Business.DTOs.ColorDTOs
{
    public class ColorUpdateDTO
    {
        public string HexCode { get; set; }

    }
    public class ColorUpdateDTOValidator : AbstractValidator<ColorUpdateDTO>
    {
        public ColorUpdateDTOValidator()
        {
            RuleFor(x => x.HexCode)
                .NotEmpty()
                .NotNull()
                .MaximumLength(16);
        }
    }
    }
