$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item -ItemType Directory -Path "../deps" -Force)
git clone --recurse-submodules https://github.com/i574n/netmq.git
Set-Location netmq
git pull
Set-Location $ScriptDir

$path = "$HOME/.nuget/packages/netmq"
$tools = Get-LastSortedItem -Path $path -Filter "lib"
$netVersion = Get-LastSortedItem -Path $tools.FullName -Filter "netstandard*"

Write-Output "Tool path: $netVersion"


{ dotnet build -c Release "../deps/netmq/src/NetMQ/NetMQ.csproj" } | Invoke-Block

Copy-Item -Recurse -Force "../deps/netmq/src/NetMQ/bin/Release/netstandard2.1/**" $netVersion
