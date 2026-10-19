Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

dotnet test "$PSScriptRoot/../backend/tests/SanskarConnectX.Application.Tests/SanskarConnectX.Application.Tests.csproj"
dotnet test "$PSScriptRoot/../tests/Protocol.Tests/Protocol.Tests.csproj"
dotnet test "$PSScriptRoot/../tests/Sdk.Tests/Sdk.Tests.csproj"
