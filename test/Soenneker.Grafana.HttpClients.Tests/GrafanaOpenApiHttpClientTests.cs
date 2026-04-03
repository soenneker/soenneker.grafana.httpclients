using Soenneker.Grafana.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Grafana.HttpClients.Tests;

[Collection("Collection")]
public sealed class GrafanaOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IGrafanaOpenApiHttpClient _httpclient;

    public GrafanaOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IGrafanaOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
