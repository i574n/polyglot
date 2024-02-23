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

$projectPath = "../deps/Fable/src/Fable.Cli"

{ dotnet build -c Release "$projectPath/Fable.Cli.fsproj" } | Invoke-Block

$releasePath = "$projectPath/bin/Release"
$dllPath = Get-LastSortedItem -Path $releasePath -Filter "fable.dll"
$dotnetVersion = $dllPath | Split-Path -Parent | Split-Path -Leaf

Write-Output "fable.dll path: $dllPath"

Copy-Item "$releasePath/$dotnetVersion/**" $toolVersionPath -Recurse -Force


Copy-Item "../deps/Fable/src/fable-library**" "$tools/.." -Recurse -Force


$path = "$HOME/.nuget/packages/fable.core"
$lib = Get-LastSortedItem -Path $path -Filter "lib"
$libVersionPath = Get-LastSortedItem -Path $lib.FullName -Filter "netstandard2.0"

Write-Output "Lib path: $libVersionPath"

$projectPath = "../deps/Fable/src/Fable.Core"

{ dotnet build -c Release "$projectPath/Fable.Core.fsproj" } | Invoke-Block

$releasePath = "$projectPath/bin/Release"
$dllPath = Get-LastSortedItem -Path $releasePath -Filter "fable.core.dll"
$dotnetVersion = $dllPath | Split-Path -Parent | Split-Path -Leaf

Copy-Item "$releasePath/$dotnetVersion/**" $libVersionPath -Recurse -Force
