using FluentValidation;

namespace SFY.Business.DTOs.SizeDTOs
{
    public class SizeCreateDTO
    {
        public string Name {  get; set; }
    }
    public class SizeCreateDTOValidator : AbstractValidator<SizeCreateDTO>
    {
        public SizeCreateDTOValidator()
        {
            RuleFor(x=>x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(16);
        }
    }
}
