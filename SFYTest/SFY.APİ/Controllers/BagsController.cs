using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SFY.Business.DTOs.BagDTOs;
using SFY.Business.DTOs.SizeDTOs;
using SFY.Business.Exceptions.Common;
using SFY.Business.Services.Interfaces;
using SFY.Core.Entities;

namespace SFY.APİ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BagsController : ControllerBase
    {
        IBagService _service { get; }
        public BagsController(IBagService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }
        [Authorize]
        [HttpGet("GetById")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            try
            {
                return Ok(await _service.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(BagCreateDTO dto)
        {
            try
            {
                await _service.CreateAsync(dto);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (ExistException<Bag> ex)
            {
                return Conflict(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BagUpdateDTO dto)
        {
            try
            {
                await _service.UpdateAsync(id, dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.RemoveAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }

    }
}

