Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"


{ dotnet run -c Debug } | Invoke-Block
{ dotnet run -c Release } | Invoke-Block
