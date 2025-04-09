using AutoMapper;
using SFY.Business.DTOs.SizeDTOs;
using SFY.Business.Exceptions.Common;
using SFY.Business.Repositories.Interfaces;
using SFY.Business.Services.Interfaces;
using SFY.Core.Entities;

namespace SFY.Business.Services.Implements
{
    public class SizeService : ISizeService
    {
        ISizeRepository _repo { get; }

        IMapper _mapper { get; }


        public SizeService(ISizeRepository repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(SizeCreateDTO dto)
        {
            if (await _repo.IsExistAsync(r => r.Name.ToLower() == dto.Name.ToLower()))
                throw new ExistException<Size>();
            await _repo.CreateAsync(_mapper.Map<Size>(dto));
            await _repo.SaveAsync();
        }

        public IEnumerable<SizeListItemDTO> GetAll()
            => _mapper.Map<IEnumerable<SizeListItemDTO>>(_repo.GetAll());

        public async Task<SizeDetailDTO> GetByIdAsync(int id)
        {
            var data = await _checkId(id,true);
            return  _mapper.Map<SizeDetailDTO>(data);
        }

        public async Task RemoveAsync(int id)
        {
            var data = await _checkId(id);
            _repo.Remove(data);
            await _repo.SaveAsync();
        }

        public async Task UpdateAsync(int id, SizeUpdateDTO dto)
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

        async Task<Size> _checkId(int id, bool isTrack = false)
        {
            if (id <= 0) throw new ArgumentException();
            var data = await _repo.GetByIdAsync(id, isTrack);
            if (data == null) throw new NotFoundException<Size>(); 
            return data;
        }

      
    }
}