param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item -ItemType Directory -Path "../deps" -Force)
git clone --recurse-submodules https://github.com/i574n/hyperui.git
{ git pull } | Invoke-Block -Location hyperui

{ yarn install } | Invoke-Block -Location hyperui
{ yarn build } | Invoke-Block -Location hyperui
