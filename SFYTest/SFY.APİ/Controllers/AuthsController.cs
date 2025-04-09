﻿using Microsoft.AspNetCore.Mvc;
using SFY.Business.DTOs.AuthDTOs;
using SFY.Business.Services.Interfaces;

namespace SFY.APİ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        IAuthService _service { get; }

        public AuthsController(IAuthService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            return Ok(await _service.Login(dto));
        }
    }
}
