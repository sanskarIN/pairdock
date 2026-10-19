Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

param(
  [Parameter(Mandatory = $true)]
  [string]$Area,
  [Parameter(Mandatory = $true)]
  [string]$Name
)

$target = Join-Path "$PSScriptRoot/.." "$Area/$Name"
New-Item -ItemType Directory -Force -Path $target | Out-Null
@"
# $Name

PairDock module.

Made by Sanskar.

SCX-TODO: Add source, tests, and documentation for this module.
"@ | Set-Content (Join-Path $target "README.md")

