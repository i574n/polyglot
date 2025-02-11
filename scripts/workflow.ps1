param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"

. ./core.ps1

{ pwsh init.ps1 } | Invoke-Block

{ pwsh build.ps1 } | Invoke-Block

{ pwsh publish.ps1 } | Invoke-Block

{ pwsh ../dist/scripts/publish-bin.ps1 } | Invoke-Block
