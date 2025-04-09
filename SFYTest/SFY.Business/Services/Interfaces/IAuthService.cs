using SFY.Business.DTOs.AuthDTOs;

namespace SFY.Business.Services.Interfaces
{
    public interface IAuthService
    {
        Task<TokenDTO> Login(LoginDTO dto);
    }
}
