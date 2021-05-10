using ArchUnitDemo.Domain.Entities;
using ArchUnitDemo.Shared;

namespace ArchUnitDemo.Server.Controllers
{
    public static class WeatherForecastMapper
    {
        public static WeatherForecast ToWeatherForecast(this WeatherForecastEntity entity) => new()
        {
            Date = entity.Date,
            Summary = entity.Summary,
            TemperatureC = entity.TemperatureC
        };
    }
}