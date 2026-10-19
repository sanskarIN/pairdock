Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

param(
  [Parameter(Mandatory = $true)]
  [string]$Version
)

New-Item -ItemType Directory -Force -Path "$PSScriptRoot/../../artifacts/releases/$Version" | Out-Null
dotnet publish "$PSScriptRoot/../../backend/src/SanskarConnectX.Api/SanskarConnectX.Api.csproj" -c Release -o "$PSScriptRoot/../../artifacts/releases/$Version/backend"
dotnet publish "$PSScriptRoot/../../apps/web-dashboard/SanskarConnectX.WebDashboard.csproj" -c Release -o "$PSScriptRoot/../../artifacts/releases/$Version/dashboard"
Write-Host "PairDock release $Version prepared. Made by Sanskar."
