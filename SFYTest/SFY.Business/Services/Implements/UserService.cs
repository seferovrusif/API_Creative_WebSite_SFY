using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SFY.Business.DTOs.AppUserDTOs;
using SFY.Business.Exceptions.AppUser;
using SFY.Business.Services.Interfaces;
using SFY.Core.Entities;
using SFY.Core.Enums;
using System.Text;

namespace SFY.Business.Services.Implements
{
    public class UserService : IUserService
    {
        UserManager<AppUser> _userManager { get; }
        RoleManager<IdentityRole> _roleManager { get; }
        IMapper _mapper { get; }
        public UserService(UserManager<AppUser> userManager, IMapper mapper, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
        }

        public async Task CreateAsync(RegisterDTO dto)
        {
            AppUser user = _mapper.Map<AppUser>(dto);
            var result=await _userManager.CreateAsync(user, dto.Password);
            if(!result.Succeeded)
            {
                StringBuilder sb = new();
                foreach (var item in result.Errors)
                {
                    sb.Append(item.Description+" ");
                }
                throw new AppUserCreatedFailedException(sb.ToString().TrimEnd());
            }
            var roleResult =await _userManager.AddToRoleAsync(user, nameof(Roles.Member));
            if (!roleResult.Succeeded)
            {
                StringBuilder sb = new();
                foreach (var item in result.Errors)
                {
                    sb.Append(item.Description + " ");
                }
                //TODO : Custom Exception
                throw new Exception(sb.ToString().TrimEnd());
            }
        }
    }
}
