using FluentValidation;

namespace SFY.Business.DTOs.SizeDTOs
{
    public class SizeUpdateDTO
    {
        public string Name { get; set; }
    }
    public class SizeUpdateDTOValidator : AbstractValidator<SizeUpdateDTO>
    {
        public SizeUpdateDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(16);
        }
    }
}