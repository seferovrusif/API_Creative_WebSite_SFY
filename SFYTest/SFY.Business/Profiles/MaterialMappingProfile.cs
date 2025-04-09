using AutoMapper;
using SFY.Business.DTOs.Material;
using SFY.Core.Entities;

namespace SFY.Business.Profiles
{
    public class MaterialMappingProfile : Profile
    {
        public MaterialMappingProfile()
        {
            CreateMap<MaterialCreateDTO, Material>();
            CreateMap<MaterialUpdateDTO, Material>();
            CreateMap<Material, MaterialListItemDTO>();
            CreateMap<Material, MaterialDetailDTO>();
        }
    }
}
