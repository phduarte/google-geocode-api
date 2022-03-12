using Microsoft.Extensions.DependencyInjection;
using WappaMobile.ChallengeDev.Models.Cars;
using WappaMobile.ChallengeDev.Models.Drivers;

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
