[![](https://img.shields.io/nuget/v/soenneker.grafana.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.grafana.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.grafana.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.grafana.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.grafana.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.grafana.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.grafana.httpclients/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.grafana.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Grafana.HttpClients

Provide a cached, authenticated `HttpClient` for the generated Grafana OpenAPI client.

## Installation

```bash
dotnet add package Soenneker.Grafana.HttpClients
```

## Configuration

```json
{
  "Grafana": {
    "ApiKey": "grafana-service-account-token",
    "ClientBaseUrl": "https://grafana.example.com/api"
  }
}
```

`ClientBaseUrl` is required and must be the absolute URL of the Grafana HTTP API, including `/api`. Requests use `Authorization: Bearer <token>` by default.

To use another header format, set `AuthHeaderName` and `AuthHeaderValueTemplate`; `{token}` is replaced with `ApiKey`.

## Registration and usage

```csharp
services.AddGrafanaOpenApiHttpClientAsSingleton();

HttpClient client = await grafanaHttpClient.Get(cancellationToken);
```

`Get` returns the same client for the lifetime of that provider instance. `AddGrafanaOpenApiHttpClientAsScoped()` creates one provider-owned client per scope. Disposing the provider removes and disposes only the client it owns.
