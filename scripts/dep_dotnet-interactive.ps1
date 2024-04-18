param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item -ItemType Directory -Path "../deps" -Force)
git clone --recurse-submodules https://github.com/i574n/interactive.git dotnet-interactive
{ git pull } | Invoke-Block -Location dotnet-interactive

$path = "$HOME/.nuget/packages/microsoft.dotnet-interactive"
$tools = Get-LastSortedItem -Path $path -Filter "tools"
$netVersion = Get-LastSortedItem -Path $tools.FullName -Filter "any"

if ((Get-ChildItem -Path $path -Directory).Count -gt 1) {
    throw "More than one directory in $path"
}

Write-Output "Tool path: $netVersion"


# { sudo pwsh ../deps/dotnet-interactive/src/ensure-symlinks.ps1 } | Invoke-Block
# { pwsh ../deps/dotnet-interactive/eng/build.ps1 -build -restore } | Invoke-Block

if (!$fast) {
    { npm install } | Invoke-Block -Location ../deps/dotnet-interactive/src/polyglot-notebooks
    { npm install } | Invoke-Block -Location ../deps/dotnet-interactive/src/polyglot-notebooks-browser
    { npm run rollup } | Invoke-Block -Location ../deps/dotnet-interactive/src/polyglot-notebooks-browser
    { npm run compile-library } | Invoke-Block -Location ../deps/dotnet-interactive/src/polyglot-notebooks
}

{ dotnet build -c Release "../deps/dotnet-interactive/src/dotnet-interactive/dotnet-interactive.csproj" } | Invoke-Block

Copy-Item "../deps/dotnet-interactive/artifacts/bin/dotnet-interactive/Release/net9.0/**" $netVersion -Recurse -Force
