using AutoMapper;
using SFY.Business.DTOs.BagDTOs;
using SFY.Core.Entities;

namespace SFY.Business.Profiles
{
    public class BagMappingProfile : Profile
    {
        public BagMappingProfile()
        {
            CreateMap<BagCreateDTO, Bag>();
            CreateMap<BagUpdateDTO, Bag>();
            CreateMap<Bag, BagListItemDTO>();
            CreateMap<Bag, BagDetailDTO>();
        }
    }
}
