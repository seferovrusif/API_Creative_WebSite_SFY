using SFY.Business.DTOs.AppUserDTOs;

namespace SFY.Business.Services.Interfaces
{
    public interface IUserService
    {
        public Task CreateAsync(RegisterDTO  dto);

    }
}
    