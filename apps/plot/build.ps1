param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ cargo fmt -- } | Invoke-Block

{ cargo +nightly-2025-11-01 build --timings --release } | Invoke-Block
