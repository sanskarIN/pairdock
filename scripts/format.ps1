Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

dotnet format "$PSScriptRoot/../backend/src/SanskarConnectX.Api/SanskarConnectX.Api.csproj" --verify-no-changes

