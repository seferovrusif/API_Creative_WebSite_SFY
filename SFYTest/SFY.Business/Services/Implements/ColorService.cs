using AutoMapper;
using SFY.Business.DTOs.ColorDTOs;
using SFY.Business.Exceptions.Common;
using SFY.Business.Repositories.Interfaces;
using SFY.Business.Services.Interfaces;
using SFY.Core.Entities;

namespace SFY.Business.Services.Implements
{
    public class ColorService : IColorService
    {

        IColorRepository _repo { get; }
        IMapper _mapper { get; }

        public ColorService(IMapper mapper, IColorRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task CreateAsync(ColorCreateDTO dto)
        {
            if (await _repo.IsExistAsync(r => r.HexCode.ToLower() == dto.HexCode.ToLower()))
                throw new ExistException<Color>();
            await _repo.CreateAsync(_mapper.Map<Color>(dto));
            await _repo.SaveAsync();
        }

        public IEnumerable<ColorListItemDTO> GetAll()
         => _mapper.Map<IEnumerable<ColorListItemDTO>>(_repo.GetAll());

        public async Task<ColorDetailDTO> GetByIdAsync(int id)
        {
            var data = await _checkId(id, true);
            return _mapper.Map<ColorDetailDTO>(data);
        }

        public async Task RemoveAsync(int id)
        {
            var data = await _checkId(id);
            _repo.Remove(data);
            await _repo.SaveAsync();
        }

        public async Task UpdateAsync(int id, ColorUpdateDTO dto)
        {
            var data = await _checkId(id);
            if (dto.HexCode.ToLower() != data.HexCode.ToLower())
            {
                if (await _repo.IsExistAsync(r => r.HexCode.ToLower() == dto.HexCode.ToLower()))
                    throw new ExistException<Color>();
                data = _mapper.Map(dto, data);
                await _repo.SaveAsync();
            }
        }
        async Task<Color> _checkId(int id, bool isTrack = false)
        {
            if (id <= 0) throw new ArgumentException();
            var data = await _repo.GetByIdAsync(id, isTrack);
            if (data == null) throw new NotFoundException<Color>();
            return data;
        }
    }
}
