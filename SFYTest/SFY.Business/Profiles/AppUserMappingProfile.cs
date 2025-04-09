using AutoMapper;
using SFY.Business.DTOs.AppUserDTOs;
using SFY.Core.Entities;

namespace SFY.Business.Profiles
{
    public class AppUserMappingProfile : Profile
    {
        public AppUserMappingProfile()
        {
            CreateMap<RegisterDTO, AppUser>();
        }
    }
}
