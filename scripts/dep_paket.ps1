param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item -ItemType Directory -Path "../deps" -Force)
git clone --recurse-submodules https://github.com/i574n/Paket.git
{ git pull } | Invoke-Block -Location $projectPath -Location Paket

$path = "$HOME/.nuget/packages/paket"
$tools = Get-LastSortedItem -Path $path -Filter "tools"
$toolVersionPath = Get-LastSortedItem -Path $tools.FullName -Filter "any"

Write-Output "Tool path: $toolVersionPath"

$projectPath = "../deps/Paket/src/Paket"

{ dotnet paket restore } | Invoke-Block -Location $projectPath

{ dotnet build -c Release "$projectPath/Paket.fsproj" } | Invoke-Block

$releasePath = "$projectPath/bin/Release"
$dllPath = Get-LastSortedItem -Path $releasePath -Filter "paket.dll"
$dotnetVersion = $dllPath | Split-Path -Parent | Split-Path -Leaf

Write-Output "paket.dll path: $dllPath"

Copy-Item "$releasePath/$dotnetVersion/**" $toolVersionPath -Recurse -Force
