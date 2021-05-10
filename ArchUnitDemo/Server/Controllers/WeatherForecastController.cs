using ArchUnitDemo.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ArchUnitDemo.Domain.Abstractions;

namespace ArchUnitDemo.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService) =>
            this.weatherForecastService = weatherForecastService;

        [HttpGet]
        public IEnumerable<WeatherForecast> Get() => weatherForecastService.GetShortTermForecasts()
            .Select(w => w.ToWeatherForecast()).ToArray();
    }
}
