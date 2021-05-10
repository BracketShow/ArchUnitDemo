using System.Collections.Generic;
using ArchUnitDemo.Domain.Entities;

namespace ArchUnitDemo.Domain.Abstractions
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecastEntity> GetShortTermForecasts();
    }
}
