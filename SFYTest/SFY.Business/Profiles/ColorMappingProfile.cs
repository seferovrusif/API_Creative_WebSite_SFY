using AutoMapper;
using SFY.Business.DTOs.ColorDTOs;
using SFY.Core.Entities;

namespace SFY.Business.Profiles
{
    public class ColorMappingProfile:Profile
    {
        public ColorMappingProfile()
        {
            CreateMap<ColorCreateDTO, Color>();
            CreateMap<ColorUpdateDTO, Color>();
            CreateMap<Color, ColorListItemDTO>();
            CreateMap<Color, ColorDetailDTO>();
        }
    }
}
