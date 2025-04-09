using SFY.Business.DTOs.ColorDTOs;

namespace SFY.Business.Services.Interfaces
{
    public interface IColorService
    {
        public IEnumerable<ColorListItemDTO> GetAll();
        public Task<ColorDetailDTO> GetByIdAsync(int id);
        public Task CreateAsync(ColorCreateDTO dto);
        public Task RemoveAsync(int id);
        public Task UpdateAsync(int id, ColorUpdateDTO dto);
    }
}
