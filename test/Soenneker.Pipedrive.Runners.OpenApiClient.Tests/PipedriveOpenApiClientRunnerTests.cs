using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Pipedrive.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class PipedriveOpenApiClientRunnerTests : FixturedUnitTest
{
    public PipedriveOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
