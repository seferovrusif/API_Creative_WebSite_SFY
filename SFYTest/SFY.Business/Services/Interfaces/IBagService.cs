using SFY.Business.DTOs.BagDTOs;

namespace SFY.Business.Services.Interfaces
{
    public interface IBagService
    {
        public IEnumerable<BagListItemDTO> GetAll();
        public Task<BagDetailDTO> GetByIdAsync(int id);
        public Task CreateAsync(BagCreateDTO dto);
        public Task RemoveAsync(int id);
        public Task UpdateAsync(int id, BagUpdateDTO dto);
    }
}
