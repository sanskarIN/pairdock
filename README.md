# PairDock

Pair, provision, monitor, and update Wi-Fi and Bluetooth devices.

Open-source connected-device workspace made by Sanskar.

PairDock brings firmware, an ASP.NET Core API, a Blazor dashboard, C# SDK, desktop and mobile application structures, device tools, SQL, and manufacturing guidance into one repository. The codebase began as a phased foundation. It is **not yet a production-ready device service**: the API still uses an in-memory database, hardware integrations are host-side examples, and end-to-end security and hardware tests remain to be completed. Do not deploy it to an untrusted network or use it for safety-critical control.

## Repository Map

| Area | Purpose | Current state |
| --- | --- | --- |
| `firmware/` | C/C++ HAL, connectivity, state machine, OTA concepts, assembly examples | Host build and examples; ESP-IDF integration pending |
| `backend/` | Clean Architecture domain, services, API, EF Core infrastructure | Builds; persistence is in-memory |
| `apps/web-dashboard/` | Blazor device dashboard | Builds; some views use example data |
| `apps/desktop/` | WPF/MVVM application | Starter implementation |
| `apps/mobile/` | MAUI-style application structure | Starter implementation |
| `shared/protocol/` | Versioned device messages and examples | Buildable C# contracts |
| `sdk/` | C# API client and models | Buildable starter SDK |
| `database/` | PostgreSQL schema and migrations | Reference SQL, not wired to API |
| `tools/` | Simulator, firmware packaging, telemetry and test utilities | Mixed implementation maturity |
| `docs/`, `security/`, `manufacturing/`, `tests/` | Architecture, operation, risk and verification guidance | Expand alongside each feature |

The existing `SanskarConnectX` C# namespaces and project paths remain for source compatibility. PairDock is the product and GitHub repository name; a namespace migration should be a separately tested change.

## Prerequisites

- .NET SDK 10.0.x to build the `net8.0` C# projects. The .NET 8 runtime is needed to run them.
- CMake 3.24+ and a C/C++ compiler for the firmware host build.
- A NuGet connection for first-time package restore.
- Docker only for optional local containers.
- ESP-IDF and supported hardware for future on-device validation; the host build does not flash an ESP32.

## Build And Run

From the repository root:

```powershell
dotnet build backend/src/SanskarConnectX.Api/SanskarConnectX.Api.csproj -c Release -m:1
dotnet build apps/web-dashboard/SanskarConnectX.WebDashboard.csproj -c Release -m:1
dotnet build sdk/SanskarConnectX.Sdk.csproj -c Release -m:1
cmake -S firmware -B firmware/build
cmake --build firmware/build
```

The API requires a unique JWT signing key of at least 32 UTF-8 bytes. For a local session in PowerShell:

```powershell
$env:Jwt__SigningKey = [Convert]::ToBase64String([Security.Cryptography.RandomNumberGenerator]::GetBytes(48))
dotnet run --project backend/src/SanskarConnectX.Api/SanskarConnectX.Api.csproj
```

For local Docker Compose, set `PAIRDOCK_JWT_SIGNING_KEY` to a fresh secret before starting. Do not commit secrets, use the development containers as a production deployment, or rely on the sample PostgreSQL container for API persistence; the current API uses EF Core InMemory.

```powershell
$env:PAIRDOCK_JWT_SIGNING_KEY = [Convert]::ToBase64String([Security.Cryptography.RandomNumberGenerator]::GetBytes(48))
docker compose -f devops/docker-compose.yml up --build
```

## Tests

```powershell
dotnet test backend/tests/SanskarConnectX.Application.Tests/SanskarConnectX.Application.Tests.csproj -c Release -m:1
dotnet test backend/tests/SanskarConnectX.Infrastructure.Tests/SanskarConnectX.Infrastructure.Tests.csproj -c Release -m:1
dotnet test tests/Protocol.Tests/Protocol.Tests.csproj -c Release -m:1
dotnet test tests/Sdk.Tests/Sdk.Tests.csproj -c Release -m:1
```

See [testing guidance](docs/testing-guide.md) and [documentation index](docs/README.md). Test package restore needs NuGet access. Host tests are not a substitute for BLE, Wi-Fi, secure-boot, OTA, or manufacturing validation on real hardware.

## Security And Release Status

The API rejects a missing/short JWT signing key and uses salted PBKDF2 password hashes. These are foundations, not a completed security review. Before a stable production release, implement persistent storage and migrations, per-device authentication, device ownership authorization on every relevant endpoint, signed OTA verification, end-to-end tests, and hardware-in-loop validation. The [security policy](SECURITY.md) explains vulnerability reporting.

The source is licensed under [MIT](LICENSE). Review third-party dependency licenses when distributing binaries.

## Support

PairDock is open source. Supporting the developer is optional:

- [Buy Me a Coffee](https://buymeacoffee.com/SanskarCodes)
- [Razorpay](https://razorpay.me/@SanskarCodes)
- [PayPal](https://paypal.me/SanskarCodes)

Developer: [GitHub](https://github.com/sanskarIN) | [Website](https://sanskarin.github.io). Made by Sanskar.

## Next Work

1. Replace API in-memory storage with PostgreSQL and tested migrations.
2. Enforce user/device ownership and device credentials across commands and telemetry.
3. Implement and verify ESP-IDF adapters, provisioning, signed OTA, and factory reset on supported boards.
4. Connect desktop/mobile/dashboard flows to the real API and add integration and hardware tests.
5. Publish versioned artifacts only after the corresponding runtime is verified; keep scaffolds clearly labelled.
