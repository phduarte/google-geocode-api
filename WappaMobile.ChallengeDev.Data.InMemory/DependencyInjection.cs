using Microsoft.Extensions.DependencyInjection;
using WappaMobile.ChallengeDev.Models;

namespace WappaMobile.ChallengeDev.Data.InMemory
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataInMemory(this IServiceCollection services)
        {
            services.AddSingleton<IDriversRepository, DriversRepository>();
            services.AddSingleton<ICarsRepository, CarsRepository>();
            return services;
        }
    }
}
