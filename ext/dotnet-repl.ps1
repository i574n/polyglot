$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../core.ps1


git clone https://github.com/i574n/dotnet-repl.git

$path = "$HOME/.nuget/packages/dotnet-repl"
$tools =  Get-LastSortedItem -Path $path -Filter "tools"
$netVersion = Get-LastSortedItem -Path $tools.FullName -Filter "any"

Write-Output "Tool path: $netVersion"


{ dotnet build -c Release "./dotnet-repl/src/dotnet-repl/dotnet-repl.csproj" } | Invoke-Block

Copy-Item -Recurse -Force "./dotnet-repl/src/dotnet-repl/bin/Release/net7.0/**" $netVersion
