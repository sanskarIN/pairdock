# Backend

ASP.NET Core Clean Architecture backend for PairDock.

Made by Sanskar.

## Projects

- `SanskarConnectX.Domain`: enterprise entities and value objects.
- `SanskarConnectX.Application`: use cases, DTOs, validation, and interfaces.
- `SanskarConnectX.Infrastructure`: EF Core persistence, repositories, JWT, logging, and gateways.
- `SanskarConnectX.Api`: REST API, middleware, auth, OpenAPI, health checks.
- `SanskarConnectX.Workers`: background workers for OTA rollout and telemetry retention.

## Run

```powershell
dotnet run --project ./src/SanskarConnectX.Api/SanskarConnectX.Api.csproj
```

SCX-TODO: Add OpenAPI examples and production authentication policies in Phase 2.
