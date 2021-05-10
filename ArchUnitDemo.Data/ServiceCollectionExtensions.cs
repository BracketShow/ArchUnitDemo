using ArchUnitDemo.Data.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ArchUnitDemo.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddData(this IServiceCollection services)
        {
            return services.AddTransient<IWeatherForecastRepository, WeatherForecastRepository>();
        }
    }
}