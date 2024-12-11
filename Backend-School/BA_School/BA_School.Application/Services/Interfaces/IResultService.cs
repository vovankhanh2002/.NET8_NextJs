using BA_School.Application.DTOs.Students;
using BA_School.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA_School.Application.DTOs.Results;

namespace BA_School.Application.Services.Interfaces
{
    public interface IResultService
    {
        Task<IEnumerable<GetResultDto>> GetAllAsync();
        Task<GetResultDto> GetByIdAsync(int id);
        Task<ServiceResponse> CreateAsync(CreateResultDto entity);
        Task<ServiceResponse> UpdateAsync(UpdateResultDto entity);
        Task<ServiceResponse> DeleteAsync(int id);
    }
}
