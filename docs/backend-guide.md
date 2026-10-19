# Backend Guide

The backend uses ASP.NET Core Clean Architecture.

## Projects

- `SanskarConnectX.Domain`: entities, enums, and value objects.
- `SanskarConnectX.Application`: DTOs, interfaces, validation, and use cases.
- `SanskarConnectX.Infrastructure`: persistence, repositories, JWT, external services.
- `SanskarConnectX.Api`: HTTP controllers, middleware, OpenAPI, health checks.
- `SanskarConnectX.Workers`: background jobs for telemetry retention and OTA rollout.

## Local Run

```powershell
dotnet run --project ./backend/src/SanskarConnectX.Api/SanskarConnectX.Api.csproj
```

## API Areas

- Authentication and user accounts.
- Device registration and ownership.
- Device commands.
- Telemetry ingestion.
- Firmware versions and OTA.
- Notifications.
- Admin and audit logs.

## Phase 2 Additions

- Request validation for accounts, devices, commands, and payload shape.
- Duplicate device and serial number checks.
- Optional ownership assignment during device registration.
- EF Core entity configuration classes under `Infrastructure/Persistence/Configurations`.
- Development password hashing abstraction.

SCX-TODO: Phase 3 should replace in-memory persistence with PostgreSQL-backed integration tests.
