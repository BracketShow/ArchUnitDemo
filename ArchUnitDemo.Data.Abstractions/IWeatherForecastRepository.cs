using System;
using System.Collections.Generic;
using ArchUnitDemo.Domain.Entities;

namespace ArchUnitDemo.Data.Abstractions
{
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecastEntity> GetShortTermForecasts();
    }
}
