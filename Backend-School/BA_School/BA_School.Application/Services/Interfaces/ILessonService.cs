using BA_School.Application.DTOs;
using BA_School.Application.DTOs.Lessons;
namespace BA_School.Application.Services.Interfaces
{
    public interface ILessonService
    {
        Task<IEnumerable<GetLessonDto>> GetAllAsync();
        Task<GetLessonDto> GetByIdAsync(int id);
        Task<ServiceResponse> CreateAsync(CreateLessonDto entity);
        Task<ServiceResponse> UpdateAsync(UpdateLessonDto entity);
        Task<ServiceResponse> DeleteAsync(int id);
    }
}
