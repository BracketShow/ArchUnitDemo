using ArchUnitDemo.Client.Pages;
using ArchUnitDemo.Data;
using ArchUnitDemo.Data.Abstractions;
using ArchUnitDemo.Domain.Abstractions;
using ArchUnitDemo.Domain.Entities;
using ArchUnitDemo.Server.Controllers;
using ArchUnitDemo.Shared;
using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Loader;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchUnitDemo.ArchitectureTests
{
    public class ApplicationArchitectureFixture
    {
        public readonly Architecture architecture = new ArchLoader().LoadAssemblies(
            typeof(IWeatherForecastRepository).Assembly,
            typeof(WeatherForecastRepository).Assembly,
            typeof(WeatherForecastEntity).Assembly,
            typeof(IWeatherForecastService).Assembly,
            typeof(IWeatherForecastService).Assembly,
            typeof(WeatherForecastController).Assembly,
            typeof(WeatherForecast).Assembly,
            typeof(FetchData).Assembly).Build();

        public readonly IObjectProvider<IType> DataAbstractionsLayer =
            Types().That().ResideInAssembly("ArchUnitDemo.Data.Abstractions")
                .As("Data Abstractions Layer");

        public readonly IObjectProvider<IType> DataLayer =
            Types().That().ResideInAssembly("ArchUnitDemo.Data").As("Data Layer");

        public readonly IObjectProvider<IType> DomainEntitiesLayer =
            Types().That().ResideInAssembly("ArchUnitDemo.Domain.Entities")
                .As("Domain Entities Layer");

        public readonly IObjectProvider<IType> DomainAbstractionsLayer =
            Types().That().ResideInAssembly("ArchUnitDemo.Domain.Abstractions")
                .As("Domain Abstractions Layer");

        public readonly IObjectProvider<IType> DomainLayer =
            Types().That().ResideInAssembly("ArchUnitDemo.Domain").As("Domain Layer");

        public readonly IObjectProvider<IType> ServerLayer =
            Types().That().ResideInAssembly("ArchUnitDemo.Server").As("Server Layer");

        public readonly IObjectProvider<IType> SharedLayer =
            Types().That().ResideInAssembly("ArchUnitDemo.Shared").As("Shared Layer");

        public readonly IObjectProvider<IType> ClientLayer =
            Types().That().ResideInAssembly("ArchUnitDemo.Client").As("Client Layer");
    }
}