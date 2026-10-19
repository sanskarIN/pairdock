# Getting Started

## 1. Clone And Inspect

```powershell
git clone https://github.com/sanskarIN/pairdock.git
cd pairdock
rg "PairDock"
```

## 2. Install Tooling

- .NET SDK 10.0.x and .NET 8 runtime
- CMake
- ESP-IDF or compatible ESP32 toolchain
- Docker
- PostgreSQL tooling
- PowerShell 7

## 3. Bootstrap

```powershell
pwsh ./scripts/bootstrap.ps1
```

## 4. Run Backend

```powershell
$env:Jwt__SigningKey = [Convert]::ToBase64String([Security.Cryptography.RandomNumberGenerator]::GetBytes(48))
dotnet run --project ./backend/src/SanskarConnectX.Api/SanskarConnectX.Api.csproj
```

The signing key must be at least 32 UTF-8 bytes and must never be committed. The current API uses in-memory persistence and is for local development only.

## 5. Run Dashboard

```powershell
dotnet run --project ./apps/web-dashboard/SanskarConnectX.WebDashboard.csproj
```

## 6. Explore Protocol

Start with `shared/protocol/README.md` and the JSON examples.

Made by Sanskar.
