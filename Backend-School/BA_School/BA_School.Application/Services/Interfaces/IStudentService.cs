using BA_School.Application.DTOs;
using BA_School.Application.DTOs.Students;
using System.Linq.Expressions;
namespace BA_School.Application.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<GetStudentDto>> GetAllAsync();
        Task<GetStudentDto> GetByIdAsync(int id);
        Task<ServiceResponse> CreateAsync(CreateStudentDto entity);
        Task<ServiceResponse> UpdateAsync(UpdateStudentDto entity);
        Task<ServiceResponse> DeleteAsync(int id);
    }
}
