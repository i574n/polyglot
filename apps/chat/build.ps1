param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ pwsh ./contract/build.ps1 -fast 1 } | Invoke-Block

{ pwsh ./tests/build.ps1 } | Invoke-Block

{ pwsh ./ui/build.ps1 -fast $($fast ?? '') } | Invoke-Block
