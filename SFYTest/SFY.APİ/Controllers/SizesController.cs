using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SFY.Business.DTOs.SizeDTOs;
using SFY.Business.Exceptions.Common;
using SFY.Business.Services.Interfaces;
using SFY.Core.Entities;

namespace SFY.APİ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizesController : ControllerBase
    {
      ISizeService _service { get; }
        public SizesController(ISizeService service)
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
        public async Task<IActionResult> Post(SizeCreateDTO dto)
        {
            try
            {
                await _service.CreateAsync(dto);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch(ExistException<Size> ex)
            {
                return Conflict(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, SizeUpdateDTO dto)
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
        {  try
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
