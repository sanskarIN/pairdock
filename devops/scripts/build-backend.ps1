Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

dotnet restore "$PSScriptRoot/../../backend/src/SanskarConnectX.Api/SanskarConnectX.Api.csproj"
dotnet build "$PSScriptRoot/../../backend/src/SanskarConnectX.Api/SanskarConnectX.Api.csproj" --configuration Release

