param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


# build.livemd's cells are all pwsh: one pwsh session (core.ps1 Invoke-PwshNotebook), no notebook kernel.
Invoke-PwshNotebook build.livemd
