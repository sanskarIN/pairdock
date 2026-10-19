Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

dotnet build "$PSScriptRoot/../shared/protocol/csharp/SanskarConnectX.Protocol.csproj"
dotnet build "$PSScriptRoot/../sdk/SanskarConnectX.Sdk.csproj"
dotnet build "$PSScriptRoot/../backend/src/SanskarConnectX.Api/SanskarConnectX.Api.csproj"
dotnet build "$PSScriptRoot/../apps/web-dashboard/SanskarConnectX.WebDashboard.csproj"

