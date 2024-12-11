using BA_School.Application.Mapping;
using BA_School.Application.Services.Implementations;
using BA_School.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
namespace BA_School.Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingConfig));
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IResultService, ResultService>();

            return services;
        }
    }
}
