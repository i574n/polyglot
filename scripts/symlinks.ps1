$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


EnsureSymbolicLink -Path "../apps/nbs" -Target "../nbs"