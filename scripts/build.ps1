param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


{ . ../workspace/target/release/spiral_builder$(_exe) dib --path build.dib } | Invoke-Block
