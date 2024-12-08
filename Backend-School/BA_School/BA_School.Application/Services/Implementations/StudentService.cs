using AutoMapper;
using BA_School.Application.DTOs;
using BA_School.Application.DTOs.Students;
using BA_School.Application.Services.Interfaces;
using BA_School.Domain.Entities;
using BA_School.Domain.Interfaces;
namespace BA_School.Application.Services.Implementations
{
    public class StudentService(IGeneric<Student> StudentGeneric, IMapper mapper) : IStudentService
    {
        public async Task<ServiceResponse> CreateAsync(CreateStudentDto entity)
        {
            var mapperData = mapper.Map<Student>(entity);
            int result = await StudentGeneric.CreateAsync(mapperData);
            return result > 0 ? new ServiceResponse(true, "Student create!") : new ServiceResponse(false, "Student fail create!");
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            int result = await StudentGeneric.DeleteAsync(id);
            return result > 0 ? new ServiceResponse(true, "Student delete!") : new ServiceResponse(false, "Student fail delete!");
        }

        public async Task<IEnumerable<GetStudentDto>> GetAllAsync()
        {
            var rawData = await StudentGeneric.GetAllAsync(s => s.Attendances!, s => s.Results! );
            if (!rawData.Any()) return [];
            return mapper.Map<IEnumerable<GetStudentDto>>(rawData);
        }

        public async Task<GetStudentDto> GetByIdAsync(int id)
        {
            var rawData = await StudentGeneric.GetByIdAsync(id);
            if (rawData == null) return new GetStudentDto();
            return mapper.Map<GetStudentDto>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateStudentDto entity)
        {
            var mapperData = mapper.Map<Student>(entity);
            int result = await StudentGeneric.UpdateAsync(mapperData);
            return result > 0 ? new ServiceResponse(true, "Student update!") : new ServiceResponse(false, "Student fail update!");
        }
    }
}
