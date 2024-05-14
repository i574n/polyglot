param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


{ ~/.bun/bin/bun install --frozen-lockfile } | Invoke-Block

EnsureSymbolicLink -Path "./LICENSE" -Target "../../../LICENSE"

{ pwsh ./compile.ps1 } | Invoke-Block

{ bunx @vscode/vsce package --pre-release --out "out/" } | Invoke-Block
