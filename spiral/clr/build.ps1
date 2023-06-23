Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ../../core.ps1


{ dotnet run -c Release | Tee-Object clr.out } | Invoke-Block
