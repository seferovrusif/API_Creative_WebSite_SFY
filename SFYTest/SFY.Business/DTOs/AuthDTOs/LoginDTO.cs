using FluentValidation;

namespace SFY.Business.DTOs.AuthDTOs
{
    public class LoginDTO
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }    
    }
    public class LoginDTOValidator:AbstractValidator<LoginDTO>
    {
        public LoginDTOValidator()
        {
            RuleFor(x => x.UsernameOrEmail)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(64);
            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .MaximumLength(64);
        }
    }
}
