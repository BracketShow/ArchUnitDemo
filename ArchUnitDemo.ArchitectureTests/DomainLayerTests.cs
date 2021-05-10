using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;
using Xunit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchUnitDemo.ArchitectureTests
{
    [Collection(nameof(ApplicationArchitectureCollectionFixture))]
    public class DomainLayerTests : IClassFixture<ApplicationArchitectureFixture>
    {
        private readonly ApplicationArchitectureFixture applicationArchitectureFixture;

        public DomainLayerTests(ApplicationArchitectureFixture applicationArchitectureFixture)
        {
            this.applicationArchitectureFixture = applicationArchitectureFixture;
        }

        [Fact]
        public void DomainClasses_ShouldOnlyImplementInterfacesFromTheDomainAbstractionsLayer()
        {
            IArchRule rule = Classes().That()
                .Are(applicationArchitectureFixture.DomainLayer)
                .And().AreInternal()
                .Should().BeAssignableTo(
                    Interfaces().That().Are(applicationArchitectureFixture.DomainAbstractionsLayer))
                .Because("Domain classes should only implement interfaces from the domain abstractions");
            rule.Check(applicationArchitectureFixture.architecture);
        }
    }
}