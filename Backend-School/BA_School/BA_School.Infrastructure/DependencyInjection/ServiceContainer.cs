using BA_School.Domain.Entities;
using BA_School.Domain.Interfaces;
using BA_School.Infrastructure.Data;
using BA_School.Infrastructure.Repositories;
using EntityFramework.Exceptions.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace BA_School.Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SchoolDbcontext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnect"),
            sqlOption =>
            {
                sqlOption.EnableRetryOnFailure();
                sqlOption.MigrationsAssembly(typeof(SchoolDbcontext).Assembly.FullName);
            })
            .UseExceptionProcessor(),
            ServiceLifetime.Scoped);

            services.AddScoped<IGeneric<Student>, GenericRepostitory<Student>>();
           
            return services;
        }
    }
}
