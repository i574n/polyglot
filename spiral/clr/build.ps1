Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ../../core.ps1


Invoke-Call -ScriptBlock {
    dotnet run -c Release | Tee-Object clr.out
} -ErrorAction Stop
