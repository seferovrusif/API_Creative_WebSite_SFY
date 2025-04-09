using SFY.Business.DTOs.AuthDTOs;
using SFY.Core.Entities;

namespace SFY.Business.ExternalServices.Interfaces
{
    public interface ITokenService
    {
        TokenDTO CreateToken(TokenParamsDTO dto); 
    }
}
