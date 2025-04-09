using FluentValidation;

namespace SFY.Business.DTOs.AppUserDTOs
{
    public class RegisterDTO
    {
        public string Fullname { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class RegisterDtoValidator : AbstractValidator<RegisterDTO>
    {
        public RegisterDtoValidator()
        {
            RuleFor(r => r.Fullname)
                .NotNull()
                .NotEmpty()
                .MaximumLength(32)
                .MinimumLength(5);
            RuleFor(r => r.BirthDate)
                .NotEmpty()
                .NotNull();
            //.LessThan(DateTime.Now.AddYears(-18))
            //    .WithMessage("18 yas");
            RuleFor(r => r.UserName)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(64);
            RuleFor(r => r.Email)
                .NotEmpty()
                .NotNull()
                //.Must(r => MailAddress.TryCreate(r, out _));
                .EmailAddress();
            RuleFor(r => r.Password)
                .NotNull()
                .NotEmpty()
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$");

        }
    }
}