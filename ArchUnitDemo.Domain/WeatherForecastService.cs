using System;
using System.Collections.Generic;
using ArchUnitDemo.Data.Abstractions;
using ArchUnitDemo.Domain.Abstractions;
using ArchUnitDemo.Domain.Entities;

namespace ArchUnitDemo.Domain
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository) =>
            this.weatherForecastRepository = weatherForecastRepository;

        public IEnumerable<WeatherForecastEntity> GetShortTermForecasts() =>
            weatherForecastRepository.GetShortTermForecasts();
    }
}
