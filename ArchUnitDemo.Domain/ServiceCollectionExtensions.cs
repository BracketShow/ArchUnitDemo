using ArchUnitDemo.Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ArchUnitDemo.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            return services.AddTransient<IWeatherForecastService, WeatherForecastService>();
        }
    }
}