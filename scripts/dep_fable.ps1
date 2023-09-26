param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item -ItemType Directory -Path "../deps" -Force)
git clone --recurse-submodules https://github.com/i574n/Fable.git
Set-Location Fable
git pull
Set-Location $ScriptDir

$path = "$HOME/.nuget/packages/fable"
$tools = Get-LastSortedItem -Path $path -Filter "tools"
$toolVersionPath = Get-LastSortedItem -Path $tools.FullName -Filter "any"

Write-Output "Tool path: $toolVersionPath"

{ dotnet build -c Release "../deps/Fable/src/Fable.Cli/Fable.Cli.fsproj" } | Invoke-Block

$releasePath = "../deps/Fable/src/Fable.Cli/bin/Release"
$dllPath = Get-LastSortedItem -Path $releasePath -Filter "fable.dll"
$dotnetVersion = $dllPath | Split-Path -Parent | Split-Path -Leaf

Copy-Item -Recurse -Force "../deps/Fable/src/Fable.Cli/bin/Release/$dotnetVersion/**" $toolVersionPath

{ dotnet build -c Release "../deps/Fable/src/Fable.Core/Fable.Core.fsproj" } | Invoke-Block
Copy-Item -Force "../deps/Fable/src/Fable.Core/bin/Release/netstandard2.0/Fable.Core.dll" "$HOME/.nuget/packages/fable.core/4.0.0/lib/netstandard2.0/Fable.Core.dll"
