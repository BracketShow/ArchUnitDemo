using System;
using System.Collections.Generic;
using System.Linq;
using ArchUnitDemo.Data.Abstractions;
using ArchUnitDemo.Domain.Entities;

namespace ArchUnitDemo.Data
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecastEntity> GetShortTermForecasts()
        {
            return GetShortTermForecastsFromDatabase().Select(w => w.ToWeatherForecastEntity());

            static IEnumerable<WeatherForecastDto> GetShortTermForecastsFromDatabase()
            {
                var rng = new Random();
                return Enumerable.Range(1, 5).Select(index => new WeatherForecastDto
                    {
                        Date = DateTime.Now.AddDays(index),
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    });
            }
        }
    }
}
