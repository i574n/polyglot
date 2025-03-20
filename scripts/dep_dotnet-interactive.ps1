param(
    $fast,
    $pack,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item "../deps" -ItemType Directory -Force)
git clone --recurse-submodules https://github.com/i574n/dotnet-interactive.git
{ git pull } | Invoke-Block -Location dotnet-interactive -OnError Continue

Set-Location $ScriptDir

$path = "$HOME/.nuget/packages/i574n.dotnet-interactive-i574n"
$tools = Get-LastSortedItem -Path $path -Filter "tools"
$netVersion = Get-LastSortedItem -Path $tools.FullName -Filter "any"

$versions = Get-ChildItem -Path $path -Directory

if ($versions.Count -gt 1) {
    Write-Output "More than one directory in $path `n`n$versions"

    $versions `
    | Where-Object { !"$($netVersion)".StartsWith("$($_)$([IO.Path]::DirectorySeparatorChar)") } `
    | ForEach-Object {
        Write-Output "Deleting $_"
        Remove-Item $_.FullName -Recurse -Force
    }
}

Write-Output "Tool path: $netVersion"


# { pwsh ../deps/dotnet-interactive/eng/build.ps1 -build -restore } | Invoke-Block

if (!$fast) {
    # { sudo pwsh ../deps/dotnet-interactive/src/ensure-symlinks.ps1 } | Invoke-Block -OnError Continue

    { . $(Search-Command bun) install } | Invoke-Block -Location ../deps/dotnet-interactive/src/polyglot-notebooks
    { . $(Search-Command bun) install } | Invoke-Block -Location ../deps/dotnet-interactive/src/polyglot-notebooks-browser
    { . $(Search-Command bun) --bun rollup } | Invoke-Block -Location ../deps/dotnet-interactive/src/polyglot-notebooks-browser -OnError Continue
    { . $(Search-Command bun) --bun compile-library } | Invoke-Block -Location ../deps/dotnet-interactive/src/polyglot-notebooks
}

{ dotnet build -c Release "../deps/dotnet-interactive/src/dotnet-interactive/dotnet-interactive.csproj" } | Invoke-Block -EnvironmentVariables @{ "MSBUILDDISABLENODEREUSE" = "1" }

Copy-Item "../deps/dotnet-interactive/artifacts/bin/dotnet-interactive/Release/net10.0/**" $netVersion -Recurse -Force

if ($pack) {
    { dotnet pack -c Release /p:Version=0.1.3 } | Invoke-Block -Location ../deps/dotnet-interactive/src/dotnet-interactive -EnvironmentVariables @{ "MSBUILDDISABLENODEREUSE" = "1" }
}
