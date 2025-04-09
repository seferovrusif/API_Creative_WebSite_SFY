using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SFY.Business.DTOs.AppUserDTOs;
using SFY.Business.Services.Interfaces;

namespace SFY.APİ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService { get; }

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<ActionResult> CreateUser(RegisterDTO dto)
        {
            await _userService.CreateAsync(dto);
            return Ok();
        }
    }
}
