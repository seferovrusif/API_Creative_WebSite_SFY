using AutoMapper;
using SFY.Business.DTOs.Material;
using SFY.Business.Exceptions.Common;
using SFY.Business.Repositories.Interfaces;
using SFY.Business.Services.Interfaces;
using SFY.Core.Entities;

namespace SFY.Business.Services.Implements
{
    public class MaterialService : IMaterialService
    {
        IMaterialRepository _repo { get; }
        IMapper _mapper { get; }

        public MaterialService(IMapper mapper, IMaterialRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task CreateAsync(MaterialCreateDTO dto)
        {
            if (await _repo.IsExistAsync(r => r.Name.ToLower() == dto.Name.ToLower()))
                throw new ExistException<Material>();
            await _repo.CreateAsync(_mapper.Map<Material>(dto));
            await _repo.SaveAsync();
        }

        public IEnumerable<MaterialListItemDTO> GetAll()
                  => _mapper.Map<IEnumerable<MaterialListItemDTO>>(_repo.GetAll());

        public async Task<MaterialDetailDTO> GetByIdAsync(int id)
        {
            var data = await _checkId(id, true);
            return _mapper.Map<MaterialDetailDTO>(data);
        }

        public async Task RemoveAsync(int id)
        {
            var data = await _checkId(id);
            _repo.Remove(data);
            await _repo.SaveAsync();
        }

        public async Task UpdateAsync(int id, MaterialUpdateDTO dto)
        {
            var data = await _checkId(id);
            if (dto.Name.ToLower() != data.Name.ToLower())
            {
                if (await _repo.IsExistAsync(r => r.Name.ToLower() == dto.Name.ToLower()))
                    throw new ExistException<Size>();
                data = _mapper.Map(dto, data);
                await _repo.SaveAsync();
            }
        }

        public async Task<Material> _checkId(int id, bool isTrack = false)
        {
            if (id <= 0) throw new ArgumentException();
            var data = await _repo.GetByIdAsync(id, isTrack);
            if (data == null) throw new NotFoundException<Material>();
            return data;
        }

    }
}
