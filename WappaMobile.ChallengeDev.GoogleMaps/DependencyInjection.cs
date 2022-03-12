using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WappaMobile.ChallengeDev.Models.Addresses;

namespace WappaMobile.ChallengeDev.GoogleMaps
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddGoogleMaps(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration.GetSection("GoogleMaps").Get<GoogleMapsOptions>());
            services.AddScoped<IGeoCodeFacade, GoogleMapsGeoCodeFacade>();
            return services;
        }
    }
}
