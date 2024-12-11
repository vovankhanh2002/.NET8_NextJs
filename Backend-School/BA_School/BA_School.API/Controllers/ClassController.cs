using BA_School.Application.DTOs.Classes;
using BA_School.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace BA_School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController(IClassService ClassService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var data = await ClassService.GetAllAsync();
            return data.Any() ? Ok(data) : NotFound(data);
        }

        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await ClassService.GetByIdAsync(id);
            return data != null ? Ok(data) : NotFound(data);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Createcategory(CreateClassDto ClassDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await ClassService.CreateAsync(ClassDto);
            return result.Flag == true ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Updatecategory(UpdateClassDto ClassDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await ClassService.UpdateAsync(ClassDto);
            return result.Flag == true ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Deletecategory(int id)
        {
            var result = await ClassService.DeleteAsync(id);
            return result.Flag == true ? Ok(result) : BadRequest(result);
        }
    }
}
