using Soenneker.Tests.HostedUnit;

namespace Soenneker.Pipedrive.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PipedriveOpenApiClientRunnerTests : HostedUnitTest
{
    public PipedriveOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
