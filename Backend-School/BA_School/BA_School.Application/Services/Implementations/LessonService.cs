using AutoMapper;
using BA_School.Application.DTOs;
using BA_School.Application.DTOs.Lessons;
using BA_School.Application.Services.Interfaces;
using BA_School.Domain.Entities;
using BA_School.Domain.Interfaces;
namespace BA_School.Application.Services.Implementations
{
    public class LessonService(IGeneric<Lesson> LessonGeneric, IMapper mapper) : ILessonService
    {
        public async Task<ServiceResponse> CreateAsync(CreateLessonDto entity)
        {
            var mapperData = mapper.Map<Lesson>(entity);
            int result = await LessonGeneric.CreateAsync(mapperData);
            return result > 0 ? new ServiceResponse(true, "Lesson create!") : new ServiceResponse(false, "Lesson fail create!");
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            int result = await LessonGeneric.DeleteAsync(id);
            return result > 0 ? new ServiceResponse(true, "Lesson delete!") : new ServiceResponse(false, "Lesson fail delete!");
        }

        public async Task<IEnumerable<GetLessonDto>> GetAllAsync()
        {
            var rawData = await LessonGeneric.GetAllAsync();
            if (!rawData.Any()) return [];
            return mapper.Map<IEnumerable<GetLessonDto>>(rawData);
        }

        public async Task<GetLessonDto> GetByIdAsync(int id)
        {
            var rawData = await LessonGeneric.GetByIdAsync(id);
            if (rawData == null) return new GetLessonDto();
            return mapper.Map<GetLessonDto>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateLessonDto entity)
        {
            var mapperData = mapper.Map<Lesson>(entity);
            int result = await LessonGeneric.UpdateAsync(mapperData);
            return result > 0 ? new ServiceResponse(true, "Lesson update!") : new ServiceResponse(false, "Lesson fail update!");
        }
    }
}
