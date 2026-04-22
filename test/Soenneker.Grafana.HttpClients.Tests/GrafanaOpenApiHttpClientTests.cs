using Soenneker.Grafana.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Grafana.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class GrafanaOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IGrafanaOpenApiHttpClient _httpclient;

    public GrafanaOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IGrafanaOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
