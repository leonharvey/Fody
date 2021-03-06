using Moq;
using Xunit;

public class ProjectWeaversFinderTests : TestBase
{
    [Fact]
    public void NotFound()
    {
        var logger = new Mock<BuildLogger>(MockBehavior.Loose).Object;

        var configFiles = ConfigFileFinder.FindWeaverConfigFiles(AssemblyLocation.CurrentDirectory, AssemblyLocation.CurrentDirectory, logger);

        Assert.Empty(configFiles);
    }
}