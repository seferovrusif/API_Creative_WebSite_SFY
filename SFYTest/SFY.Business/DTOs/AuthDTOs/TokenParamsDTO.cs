using SFY.Core.Entities;

namespace SFY.Business.DTOs.AuthDTOs
{
    public class TokenParamsDTO
    {
        public AppUser User { get; set; }
        public string Role { get; set; }
    }
}

