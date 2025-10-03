using ECom.Application.Repositories;
using ECom.Application.Services;
using ECom.Application.Services.Interfaces;
using ECom.Infrastructure.Repositories;

namespace ECom.Api.DependencyInjection
{
    // This file contains a compact set of additional registrations and compatibility bindings.
    // Merge into your main ServiceRegistration.cs or include it in the project so types register cleanly.
    public static class ServiceRegistrationAdditions
    {
        public static IServiceCollection AddEComCompatibility(this IServiceCollection services, string connectionString)
        {
            // The main ServiceRegistration already registers DbContext/generics.
            // Here we register compatibility adapter types and cross-named aliases.
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IVersionRepository, VersionRepository>();

            services.AddScoped<IAuthService, AuthService>();

            // If singular service aliases are referenced, register them as well
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IAccountsService, AccountsService>();

            return services;
        }
    }
}