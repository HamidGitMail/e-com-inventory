using Microsoft.Extensions.DependencyInjection;
using ECom.Data;
using Microsoft.EntityFrameworkCore;
using ECom.Infrastructure.Repositories;
using ECom.Application.Services;
using ECom.Application.Services.Interfaces;

namespace ECom.Api.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddEComServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            // Register generic types
            services.AddScoped(typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

            // Per-entity registrations will map repository and services
            services.AddScoped<ECom.Application.Repositories.IAccountsRepository, AccountsRepository>();
            services.AddScoped<ECom.Application.Services.Interfaces.IAccountsService, AccountsService>();

            // Repeat registrations for all entities (repositories and services)

            return services;
        }
    }
}