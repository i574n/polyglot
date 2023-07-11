Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"

{ dotnet run -c Debug | Tee-Object perf.Debug.out } | Invoke-Block
{ dotnet run -c Release | Tee-Object perf.Release.out } | Invoke-Block
