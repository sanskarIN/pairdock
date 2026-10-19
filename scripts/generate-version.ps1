Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

param(
  [string]$Version = "0.1.0"
)

$metadata = @{
  name = "PairDock"
  version = $Version
  credit = "Made by Sanskar"
  generatedUtc = (Get-Date).ToUniversalTime().ToString("O")
}

$metadata | ConvertTo-Json | Set-Content "$PSScriptRoot/../metadata/version.generated.json"
