using AutoMapper;
using BA_School.Application.DTOs;
using BA_School.Application.DTOs.Classes;
using BA_School.Application.Services.Interfaces;
using BA_School.Domain.Entities;
using BA_School.Domain.Interfaces;
namespace BA_School.Application.Services.Implementations
{
    public class ClassService(IGeneric<Class> ClassGeneric, IMapper mapper) : IClassService
    {
        public async Task<ServiceResponse> CreateAsync(CreateClassDto entity)
        {
            var mapperData = mapper.Map<Class>(entity);
            int result = await ClassGeneric.CreateAsync(mapperData);
            return result > 0 ? new ServiceResponse(true, "Class create!") : new ServiceResponse(false, "Class fail create!");
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            int result = await ClassGeneric.DeleteAsync(id);
            return result > 0 ? new ServiceResponse(true, "Class delete!") : new ServiceResponse(false, "Class fail delete!");
        }

        public async Task<IEnumerable<GetClassDto>> GetAllAsync()
        {
            var rawData = await ClassGeneric.GetAllAsync();
            if (!rawData.Any()) return [];
            return mapper.Map<IEnumerable<GetClassDto>>(rawData);
        }

        public async Task<GetClassDto> GetByIdAsync(int id)
        {
            var rawData = await ClassGeneric.GetByIdAsync(id);
            if (rawData == null) return new GetClassDto();
            return mapper.Map<GetClassDto>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateClassDto entity)
        {
            var mapperData = mapper.Map<Class>(entity);
            int result = await ClassGeneric.UpdateAsync(mapperData);
            return result > 0 ? new ServiceResponse(true, "Class update!") : new ServiceResponse(false, "Class fail update!");
        }
    }
}
