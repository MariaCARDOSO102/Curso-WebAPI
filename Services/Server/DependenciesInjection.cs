using ReserveiAPI.Repositories.Interfaces;
using ReserveiAPI.Services.Interfaces;

namespace ReserveiAPI.Services.Server
{
    public static class DependenciesInjection
    {
        public static void AddUserDependencies(this IServiceCollection services)
        {
            // Dependência: Usuário
            services.AddScoped<IUserRepository, IUserRepository>();
            services.AddScoped<IUserService, IUserService>();
        }
    }
}
