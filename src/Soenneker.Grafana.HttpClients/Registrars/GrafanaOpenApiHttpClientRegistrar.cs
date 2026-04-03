using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Grafana.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Grafana.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class GrafanaOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="GrafanaOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddGrafanaOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IGrafanaOpenApiHttpClient, GrafanaOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="GrafanaOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddGrafanaOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IGrafanaOpenApiHttpClient, GrafanaOpenApiHttpClient>();

        return services;
    }
}
