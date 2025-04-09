using Microsoft.AspNetCore.Identity;
using SFY.Business.DTOs.AuthDTOs;
using SFY.Business.Exceptions.Auth;
using SFY.Business.ExternalServices.Interfaces;
using SFY.Business.Services.Interfaces;
using SFY.Core.Entities;
using System.Data;

namespace SFY.Business.Services.Implements
{
    public class AuthService : IAuthService
    {
        UserManager<AppUser> _userManager {  get; }
        ITokenService _tokenService { get; }
        public AuthService(UserManager<AppUser> userManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }

        public async Task<TokenDTO> Login(LoginDTO dto)
        {
            AppUser? user = null;
            if (dto.UsernameOrEmail.Contains("@"))
            {
                user = await _userManager.FindByEmailAsync(dto.UsernameOrEmail);
            }
            else
            {
                user = await _userManager.FindByNameAsync(dto.UsernameOrEmail);
            }
            if (user == null) { throw new UsernameOrPasswordWrongException(); }
            var result = await _userManager.CheckPasswordAsync(user, dto.Password);
            
            if(!result) throw new UsernameOrPasswordWrongException();
            string role = (await _userManager.GetRolesAsync(user)).First(); 
            return _tokenService.CreateToken(new TokenParamsDTO
            {
                Role = role,
                User = user
            });
        }
    }
}
