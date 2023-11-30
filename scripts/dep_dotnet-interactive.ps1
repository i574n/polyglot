param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item -ItemType Directory -Path "../deps" -Force)
git clone --recurse-submodules https://github.com/i574n/interactive.git dotnet-interactive
Set-Location dotnet-interactive
git pull
Set-Location $ScriptDir

$path = "$HOME/.nuget/packages/microsoft.dotnet-interactive"
$tools = Get-LastSortedItem -Path $path -Filter "tools"
$netVersion = Get-LastSortedItem -Path $tools.FullName -Filter "any"

Write-Output "Tool path: $netVersion"


# { sudo pwsh ../deps/dotnet-interactive/src/ensure-symlinks.ps1 } | Invoke-Block
# { pwsh ../deps/dotnet-interactive/eng/build.ps1 -build -restore } | Invoke-Block

if (!$fast) {
    { Start-Process "npm" "install" -Wait -NoNewWindow -WorkingDirectory "../deps/dotnet-interactive/src/polyglot-notebooks" } | Invoke-Block
    { Start-Process "npm" "install" -Wait -NoNewWindow -WorkingDirectory "../deps/dotnet-interactive/src/polyglot-notebooks-browser" } | Invoke-Block
    { npm run --prefix "../deps/dotnet-interactive/src/polyglot-notebooks-browser" rollup } | Invoke-Block
    { npm run --prefix "../deps/dotnet-interactive/src/polyglot-notebooks" compile-library } | Invoke-Block
}

{ dotnet build -c Release "../deps/dotnet-interactive/src/dotnet-interactive/dotnet-interactive.csproj" } | Invoke-Block

Copy-Item "../deps/dotnet-interactive/artifacts/bin/dotnet-interactive/Release/net8.0/**" $netVersion -Recurse -Force

Remove-Item "../deps/dotnet-interactive/artifacts" -Recurse -Force -ErrorAction Ignore
