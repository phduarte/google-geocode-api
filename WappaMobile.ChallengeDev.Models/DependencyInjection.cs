using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace WappaMobile.ChallengeDev.Models
{
    [ExcludeFromCodeCoverage]
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            var type = typeof(IUseCase<,>);
            var useCaseTypes = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(a => a.GetTypes())
                    .Where(x => x.GetInterfaces().Any(_ => _.Name.Equals(type.Name)));

            foreach (var s in useCaseTypes)
            {
                services.AddSingleton(s);
            }

            return services;
        }
    }
}
