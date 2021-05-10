using ArchUnitDemo.Domain.Entities;

namespace ArchUnitDemo.Data
{
    internal static class WeatherForecastMapper
    {
        internal static WeatherForecastEntity ToWeatherForecastEntity(this WeatherForecastDto weatherForecast) =>
            new()
            {
                Date = weatherForecast.Date,
                Summary = weatherForecast.Summary,
                TemperatureC = weatherForecast.TemperatureC
            };
    }
}