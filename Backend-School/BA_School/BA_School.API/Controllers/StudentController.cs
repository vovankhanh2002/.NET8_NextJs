using BA_School.Application.DTOs.Students;
using BA_School.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace BA_School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController(IStudentService studentService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var data = await studentService.GetAllAsync();
            return data.Any() ? Ok(data) : NotFound(data);
        }

        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await studentService.GetByIdAsync(id);
            return data != null ? Ok(data) : NotFound(data);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Createcategory(CreateStudentDto studentDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await studentService.CreateAsync(studentDto);
            return result.Flag == true ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Updatecategory(UpdateStudentDto studentDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await studentService.UpdateAsync(studentDto);
            return result.Flag == true ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Deletecategory(int id)
        {
            var result = await studentService.DeleteAsync(id);
            return result.Flag == true ? Ok(result) : BadRequest(result);
        }
    }
}
