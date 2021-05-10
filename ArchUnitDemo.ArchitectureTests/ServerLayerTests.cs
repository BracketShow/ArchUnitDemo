using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;
using Microsoft.AspNetCore.Mvc;
using Xunit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchUnitDemo.ArchitectureTests
{
    [Collection(nameof(ApplicationArchitectureCollectionFixture))]
    public class ServerLayerTests : IClassFixture<ApplicationArchitectureFixture>
    {
        private readonly ApplicationArchitectureFixture applicationArchitectureFixture;

        public ServerLayerTests(ApplicationArchitectureFixture applicationArchitectureFixture)
        {
            this.applicationArchitectureFixture = applicationArchitectureFixture;
        }

        [Fact]
        public void ServerControllers_ShouldHaveApiControllerAttribute()
        {
            IArchRule rule = Classes().That().ResideInNamespace("ArchUnitDemo.Server.Controllers").And()
                .HaveNameEndingWith("Controller").Should()
                .HaveAnyAttributes(typeof(ApiControllerAttribute), typeof(RouteAttribute))
                .Because("Api controllers require the ApiController and Route attributes");
            rule.Check(applicationArchitectureFixture.architecture);
        }
    }
}