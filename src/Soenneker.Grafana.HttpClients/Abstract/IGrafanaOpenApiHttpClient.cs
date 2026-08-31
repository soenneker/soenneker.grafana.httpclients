using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Grafana.HttpClients.Abstract;

/// <summary>
/// Provides an authenticated <see cref="HttpClient"/> for the generated Grafana OpenAPI client.
/// </summary>
public interface IGrafanaOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the value.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
