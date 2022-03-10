using Microsoft.Extensions.DependencyInjection;

namespace WappaMobile.ChallengeDev.Models
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IDriverServices, DriverServices>();
            return services;
        }
    }
}
