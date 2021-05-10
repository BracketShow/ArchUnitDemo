using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;
using Microsoft.AspNetCore.Components;
using Xunit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchUnitDemo.ArchitectureTests
{
    [Collection(nameof(ApplicationArchitectureCollectionFixture))]
    public class ClientLayerTests : IClassFixture<ApplicationArchitectureFixture>
    {
        private readonly ApplicationArchitectureFixture applicationArchitectureFixture;

        public ClientLayerTests(ApplicationArchitectureFixture applicationArchitectureFixture)
        {
            this.applicationArchitectureFixture = applicationArchitectureFixture;
        }

        [Fact]
        public void ClientLayer_ShouldNotDependOnServerLayer()
        {
            IArchRule clientLayerShouldNotAccessServerLayer = Types().That()
                .Are(applicationArchitectureFixture.ClientLayer).Should()
                .NotDependOnAny(applicationArchitectureFixture.ServerLayer)
                .Because("The client should not depend on the server");
            clientLayerShouldNotAccessServerLayer.Check(applicationArchitectureFixture.architecture);
        }

        [Fact]
        public void ClientLayer_ShouldNotDependOnDomainLayer()
        {
            IArchRule clientLayerShouldNotAccessDomainLayer = Types().That()
                .Are(applicationArchitectureFixture.ClientLayer).Should()
                .NotDependOnAny(applicationArchitectureFixture.DomainLayer)
                .Because("The client should not depend on the domain");
            clientLayerShouldNotAccessDomainLayer.Check(applicationArchitectureFixture.architecture);
        }

        [Fact]
        public void ClientLayer_ShouldNotDependOnDomainAbstractionsLayer()
        {
            IArchRule clientLayerShouldNotAccessDomainAbstractionsLayer = Types().That()
                .Are(applicationArchitectureFixture.ClientLayer).Should()
                .NotDependOnAny(applicationArchitectureFixture.DomainAbstractionsLayer)
                .Because("The client should not depend on the domain abstractions");
            clientLayerShouldNotAccessDomainAbstractionsLayer.Check(applicationArchitectureFixture.architecture);
        }

        [Fact]
        public void ClientLayer_ShouldNotDependOnDomainEntitiesLayer()
        {
            IArchRule clientLayerShouldNotAccessDomainEntitiesLayer = Types().That()
                .Are(applicationArchitectureFixture.ClientLayer).Should()
                .NotDependOnAny(applicationArchitectureFixture.DomainEntitiesLayer)
                .Because("The client should not depend on the domain entities");
            clientLayerShouldNotAccessDomainEntitiesLayer.Check(applicationArchitectureFixture.architecture);
        }

        [Fact]
        public void ClientLayer_ShouldNotDependOnDataLayer()
        {
            IArchRule clientLayerShouldNotAccessDataLayer = Types().That()
                .Are(applicationArchitectureFixture.ClientLayer).Should()
                .NotDependOnAny(applicationArchitectureFixture.DataLayer)
                .Because("The client should not depend on the data");
            clientLayerShouldNotAccessDataLayer.Check(applicationArchitectureFixture.architecture);
        }

        [Fact]
        public void ClientLayer_ShouldNotDependOnDataAbstractionsLayer()
        {
            IArchRule clientLayerShouldNotAccessDataAbstractionsLayer = Types().That()
                .Are(applicationArchitectureFixture.ClientLayer).Should()
                .NotDependOnAny(applicationArchitectureFixture.DataAbstractionsLayer)
                .Because("The client should not depend on the data abstractions");
            clientLayerShouldNotAccessDataAbstractionsLayer.Check(applicationArchitectureFixture.architecture);
        }

        [Fact]
        public void PageComponents_ShouldHaveThePageSuffix()
        {
            IArchRule pageComponentsShouldHaveThePageSuffix = Classes().That()
                .HaveAnyAttributes(typeof(RouteAttribute))
                .Should().HaveNameEndingWith("Page")
                .Because("Our convention is to name every page component with the Page suffix");
            pageComponentsShouldHaveThePageSuffix.Check(applicationArchitectureFixture.architecture);
        }
    }
}
