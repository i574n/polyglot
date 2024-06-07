param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


{ dotnet fable --optimize --lang ts --extension .ts --noCache } | Invoke-Block
