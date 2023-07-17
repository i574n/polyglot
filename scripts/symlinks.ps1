$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


function EnsureSymbolicLink([string]$Path, [string] $Target) {
    if (-Not (Test-Path $Path)) {
        New-Item -ItemType SymbolicLink -Path $Path -Target $Target -ErrorAction SilentlyContinue | Out-Null
    }
}

$nbsTarget = Join-Path $ScriptDir "../nbs"
EnsureSymbolicLink -Path "../nbs/nbs" -Target $nbsTarget
EnsureSymbolicLink -Path "../scripts/nbs" -Target $nbsTarget
EnsureSymbolicLink -Path "../apps/dice/nbs" -Target $nbsTarget
EnsureSymbolicLink -Path "../apps/parser/nbs" -Target $nbsTarget
EnsureSymbolicLink -Path "../apps/spiral/nbs" -Target $nbsTarget
