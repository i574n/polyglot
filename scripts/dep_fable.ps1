$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item -ItemType Directory -Path "../deps" -Force)
git clone --recurse-submodules https://github.com/i574n/Fable.git
Set-Location $ScriptDir

$path = "$HOME/.nuget/packages/fable"
$tools =  Get-LastSortedItem -Path $path -Filter "tools"
$netVersion = Get-LastSortedItem -Path $tools.FullName -Filter "any"

Write-Output "Tool path: $netVersion"


{ dotnet build -c Release "../deps/Fable/src/Fable.Transforms/Fable.Transforms.fsproj" } | Invoke-Block

Copy-Item -Recurse -Force "../deps/Fable/src/Fable.Transforms/bin/Release/netstandard2.0/**" $netVersion
