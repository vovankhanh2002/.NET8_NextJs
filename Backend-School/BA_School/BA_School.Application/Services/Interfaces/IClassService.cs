using BA_School.Application.DTOs;
using BA_School.Application.DTOs.Classes;
namespace BA_School.Application.Services.Interfaces
{
    public interface IClassService
    {
        Task<IEnumerable<GetClassDto>> GetAllAsync();
        Task<GetClassDto> GetByIdAsync(int id);
        Task<ServiceResponse> CreateAsync(CreateClassDto entity);
        Task<ServiceResponse> UpdateAsync(UpdateClassDto entity);
        Task<ServiceResponse> DeleteAsync(int id);
    }
}
