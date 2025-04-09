using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using SFY.Business.DTOs.BagDTOs;
using SFY.Business.Exceptions.Common;
using SFY.Business.Repositories.Interfaces;
using SFY.Business.Services.Interfaces;
using SFY.Core.Entities;
using System.Security.Claims;

namespace SFY.Business.Services.Implements
{
    public class BagService : IBagService
    {
        IBagRepository _repo { get; }
        IMapper _mapper { get; }
        IHttpContextAccessor _contextAccessor { get; }
        UserManager<AppUser> _userManager { get; }
        readonly string userId;

        public BagService(IBagRepository repo, IMapper mapper, IHttpContextAccessor contextAccessor,
        UserManager<AppUser> userManager)
        {
            _contextAccessor = contextAccessor;
            if (_contextAccessor.HttpContext.User.Claims.Any())
            {
                userId = _contextAccessor.HttpContext?.User?.Claims?.First(x => x.Type == ClaimTypes.NameIdentifier)?.Value ?? throw new NullReferenceException();
            }
            _userManager = userManager;
            _mapper = mapper;
            _repo = repo;
            _mapper = mapper;
        }


        public async Task CreateAsync(BagCreateDTO dto)
        {
            if (await _repo.IsExistAsync(r => r.Title.ToLower() == dto.Title.ToLower()))
                throw new ExistException<Bag>();     
            var entity = _mapper.Map<Bag>(dto);
            entity.AppUserId = userId;
            await _repo.CreateAsync(entity);
            await _repo.SaveAsync();
        }

        public IEnumerable<BagListItemDTO> GetAll()
         => _mapper.Map<IEnumerable<BagListItemDTO>>(_repo.GetAll());

        public async Task<BagDetailDTO> GetByIdAsync(int id)
        {
            var data = await _checkId(id, true);
            return _mapper.Map<BagDetailDTO>(data);
        }

        public async Task RemoveAsync(int id)
        {
            var data = await _checkId(id);
            _repo.Remove(data);
            await _repo.SaveAsync();
        }

        public async Task UpdateAsync(int id, BagUpdateDTO dto)
        {
            var data = await _checkId(id);
            if (data.AppUserId != userId) throw new Exception("User has no access");
            if (dto.Title.ToLower() != data.Title.ToLower())
            {
                if (await _repo.IsExistAsync(r => r.Title.ToLower() == dto.Title.ToLower()))
                    throw new ExistException<Bag>();
            }
                data = _mapper.Map(dto, data);
                await _repo.SaveAsync();
        }
        async Task<Bag> _checkId(int id, bool isTrack = false)
        {
            if (id <= 0) throw new ArgumentException();
            var data = await _repo.GetByIdAsync(id, isTrack);
            if (data == null) throw new NotFoundException<Bag>();
            return data;
        }
    }
}
