using SFY.Business.DTOs.Material;

namespace SFY.Business.Services.Interfaces
{
    public interface IMaterialService
    {
        public IEnumerable<MaterialListItemDTO> GetAll();
        public Task<MaterialDetailDTO> GetByIdAsync(int id);
        public Task CreateAsync(MaterialCreateDTO dto);
        public Task RemoveAsync(int id);
        public Task UpdateAsync(int id, MaterialUpdateDTO dto);
    }
}
