Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"

dotnet run -c Release | Tee-Object dice.ans
