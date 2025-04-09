using AutoMapper;
using SFY.Business.DTOs.SizeDTOs;
using SFY.Core.Entities;

namespace SFY.Business.Profiles
{
    public class SizeMappingProfile: Profile
    {
       public SizeMappingProfile()
        {
            CreateMap<SizeCreateDTO, Size>();
            CreateMap<SizeUpdateDTO, Size>();
            CreateMap<Size, SizeListItemDTO>();
            CreateMap<Size, SizeDetailDTO>();
        }
    }
}
    