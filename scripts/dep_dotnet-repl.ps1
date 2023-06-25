$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


$depsPath = "../deps"
if (!(Test-Path $depsPath)) { New-Item -ItemType Directory -Path $depsPath }
Set-Location $depsPath
git clone https://github.com/i574n/dotnet-repl.git
Set-Location $ScriptDir

$path = "$HOME/.nuget/packages/dotnet-repl"
$tools =  Get-LastSortedItem -Path $path -Filter "tools"
$netVersion = Get-LastSortedItem -Path $tools.FullName -Filter "any"

Write-Output "Tool path: $netVersion"


{ dotnet build -c Release "../deps/dotnet-repl/src/dotnet-repl/dotnet-repl.csproj" } | Invoke-Block

Copy-Item -Recurse -Force "../deps/dotnet-repl/src/dotnet-repl/bin/Release/net7.0/**" $netVersion
