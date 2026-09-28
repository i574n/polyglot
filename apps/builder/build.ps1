param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../scripts/spiral-bundle.ps1

$spiral = Ensure-SpiralRustCompiler
$dotnet = $spiral.Dotnet
$compiler = $spiral.Compiler

{ & $dotnet $compiler --backend Rust builder.spi builder.rs } | Invoke-Block
{ cargo +nightly-2025-11-01 build --release } | Invoke-Block

Remove-Item dist -Recurse -Force -ErrorAction Ignore
New-Item -ItemType Directory -Force -Path dist | Out-Null
Copy-Item -Force "../../workspace/target/release/Builder$(_exe)" "dist/Builder$(_exe)"
{ & "dist/Builder$(_exe)" --self-test } | Invoke-Block
