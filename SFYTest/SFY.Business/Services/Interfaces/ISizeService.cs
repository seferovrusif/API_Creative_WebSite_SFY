using SFY.Business.DTOs.SizeDTOs;
using SFY.Core.Entities;

namespace SFY.Business.Services.Interfaces
{
    public interface ISizeService
    {
        public IEnumerable<SizeListItemDTO> GetAll();
        public Task<SizeDetailDTO> GetByIdAsync(int id);
        public Task CreateAsync(SizeCreateDTO dto);
        public Task RemoveAsync(int id);
        public Task UpdateAsync(int id, SizeUpdateDTO dto);
    }
}
