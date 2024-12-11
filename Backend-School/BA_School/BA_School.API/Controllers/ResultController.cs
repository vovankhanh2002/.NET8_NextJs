using BA_School.Application.DTOs.Results;
using BA_School.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace BA_School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController(IResultService ResultService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var data = await ResultService.GetAllAsync();
            return data.Any() ? Ok(data) : NotFound(data);
        }

        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await ResultService.GetByIdAsync(id);
            return data != null ? Ok(data) : NotFound(data);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Createcategory(CreateResultDto ResultDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await ResultService.CreateAsync(ResultDto);
            return result.Flag == true ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Updatecategory(UpdateResultDto ResultDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await ResultService.UpdateAsync(ResultDto);
            return result.Flag == true ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Deletecategory(int id)
        {
            var result = await ResultService.DeleteAsync(id);
            return result.Flag == true ? Ok(result) : BadRequest(result);
        }
    }
}
