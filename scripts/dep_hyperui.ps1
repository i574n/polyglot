param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item "../deps" -ItemType Directory -Force)
git clone --recurse-submodules https://github.com/i574n/hyperui.git
{ git pull } | Invoke-Block -Location hyperui -OnError Continue

{ ~/.bun/bin/bun install --frozen-lockfile } | Invoke-Block -Location hyperui
{ ~/.bun/bin/bun --bun run build } | Invoke-Block -Location hyperui
