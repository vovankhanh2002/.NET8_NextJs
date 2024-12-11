using AutoMapper;
using BA_School.Application.DTOs;
using BA_School.Application.DTOs.Results;
using BA_School.Application.Services.Interfaces;
using BA_School.Domain.Entities;
using BA_School.Domain.Interfaces;
namespace BA_School.Application.Services.Implementations
{
    public class ResultService(IGeneric<Result> ResultGeneric, IMapper mapper) : IResultService
    {
        public async Task<ServiceResponse> CreateAsync(CreateResultDto entity)
        {
            var mapperData = mapper.Map<Result>(entity);
            int result = await ResultGeneric.CreateAsync(mapperData);
            return result > 0 ? new ServiceResponse(true, "Result create!") : new ServiceResponse(false, "Result fail create!");
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            int result = await ResultGeneric.DeleteAsync(id);
            return result > 0 ? new ServiceResponse(true, "Result delete!") : new ServiceResponse(false, "Result fail delete!");
        }

        public async Task<IEnumerable<GetResultDto>> GetAllAsync()
        {
            var rawData = await ResultGeneric.GetAllAsync();
            if (!rawData.Any()) return [];
            return mapper.Map<IEnumerable<GetResultDto>>(rawData);
        }

        public async Task<GetResultDto> GetByIdAsync(int id)
        {
            var rawData = await ResultGeneric.GetByIdAsync(id);
            if (rawData == null) return new GetResultDto();
            return mapper.Map<GetResultDto>(rawData);
        }

        public async Task<ServiceResponse> UpdateAsync(UpdateResultDto entity)
        {
            var mapperData = mapper.Map<Result>(entity);
            int result = await ResultGeneric.UpdateAsync(mapperData);
            return result > 0 ? new ServiceResponse(true, "Result update!") : new ServiceResponse(false, "Result fail update!");
        }
    }
}
