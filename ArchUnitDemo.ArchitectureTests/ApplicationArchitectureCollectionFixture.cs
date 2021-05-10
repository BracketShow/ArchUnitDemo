using Xunit;

namespace ArchUnitDemo.ArchitectureTests
{
    [CollectionDefinition(nameof(ApplicationArchitectureCollectionFixture))]
    public record ApplicationArchitectureCollectionFixture : ICollectionFixture<ApplicationArchitectureFixture>
    {
    }
}