$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


function EnsureSymbolicLink([string]$Path, [string] $Target) {
    $Path =  [IO.Path]::GetFullPath((Join-Path $ScriptDir $Path))
    $Target = [IO.Path]::GetFullPath((Join-Path $ScriptDir $Target))

    if (-Not (Test-Path $Path)) {
        Write-Output "Creating symlink: $Path -> $Target"
        New-Item -ItemType SymbolicLink -Path $Path -Target $Target -ErrorAction SilentlyContinue | Out-Null
    } else {
        Write-Output "Symlink already exists: $Path -> $Target"
    }
}

EnsureSymbolicLink -Path "../nbs/nbs" -Target "../nbs"
EnsureSymbolicLink -Path "../scripts/nbs" -Target "../nbs"
EnsureSymbolicLink -Path "../apps/dice/nbs" -Target "../nbs"
EnsureSymbolicLink -Path "../apps/parser/nbs" -Target "../nbs"
EnsureSymbolicLink -Path "../apps/spiral/nbs" -Target "../nbs"
