using FluentValidation;

namespace SFY.Business.DTOs.BagDTOs
{
    public class BagUpdateDTO
    {
        public string Title { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public int MaterialId { get; set; }
        public int Handle_SizeId { get; set; }
        public int Handle_ColorId { get; set; }
        public int Handle_MaterialId { get; set; }
        public class BagUpdateDTOValidator : AbstractValidator<BagUpdateDTO>
        {
            public BagUpdateDTOValidator()
            {
                RuleFor(x => x.Title)
                    .NotEmpty()
                    .NotNull()
                    .MaximumLength(32);
                RuleFor(x => x.SizeId)
                    .NotEmpty()
                    .NotNull();
                RuleFor(x => x.ColorId)
                    .NotEmpty()
                    .NotNull();
                RuleFor(x => x.MaterialId)
                    .NotEmpty()
                    .NotNull();
                RuleFor(x => x.Handle_MaterialId)
                    .NotEmpty()
                    .NotNull();
                RuleFor(x => x.Handle_ColorId)
                    .NotEmpty()
                    .NotNull();
                RuleFor(x => x.Handle_SizeId)
                    .NotEmpty()
                    .NotNull();
            }
        }
    }
}