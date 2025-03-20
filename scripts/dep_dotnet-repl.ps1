param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item "../deps" -ItemType Directory -Force)
git clone --recurse-submodules https://github.com/i574n/dotnet-repl.git
{ git pull } | Invoke-Block -Location dotnet-repl -OnError Continue

$path = "$HOME/.nuget/packages/dotnet-repl"
$tools = Get-LastSortedItem -Path $path -Filter "tools"
$netVersion = Get-LastSortedItem -Path $tools.FullName -Filter "any"

Write-Output "Tool path: $netVersion"


{ dotnet build -c Release "../deps/dotnet-repl/src/dotnet-repl/dotnet-repl.csproj" } | Invoke-Block -EnvironmentVariables @{ "MSBUILDDISABLENODEREUSE" = "1" }

Copy-Item "../deps/dotnet-repl/src/dotnet-repl/bin/Release/net10.0/**" $netVersion -Recurse -Force

Write-Output "polyglot/scripts/dep_dotnet-repl.ps1 / `$tools: $tools / `$netVersion: $netVersion / `$env:CI:'$env:CI'"

if ($env:CI) {
    Remove-Item "../deps/dotnet-interactive" -Recurse -Force -ErrorAction Ignore
    Remove-Item "../deps/dotnet-repl" -Recurse -Force -ErrorAction Ignore
}
