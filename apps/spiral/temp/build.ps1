param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


{ pwsh ./cube/build.ps1 } | Invoke-Block

{ pwsh ./extension/build.ps1 } | Invoke-Block

{ pwsh ./test/build.ps1 } | Invoke-Block
