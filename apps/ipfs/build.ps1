param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ ~/.bun/bin/bun install --frozen-lockfile } | Invoke-Block
