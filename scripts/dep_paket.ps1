param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item -ItemType Directory -Path "../deps" -Force)
git clone --recurse-submodules https://github.com/i574n/Paket.git
{ git pull } | Invoke-Block -Location Paket

$path = "$HOME/.nuget/packages/paket"
$tools = Get-LastSortedItem -Path $path -Filter "tools"
$toolVersionPath = Get-LastSortedItem -Path $tools.FullName -Filter "any"

Write-Output "Tool path: $toolVersionPath"

$projectPath = "../deps/Paket"

{ dotnet paket restore } | Invoke-Block -Location $projectPath

if ($IsWindows) {
    { pwsh -c "./build.cmd MergePaketTool SkipDocs" } | Invoke-Block -Location $projectPath
} else {
    { pwsh -c "./build.sh MergePaketTool SkipDocs" } | Invoke-Block -Location $projectPath
}
Copy-Item "$projectPath/bin/merged/paket.exe" "$($tools.FullName)/paket.exe" -Recurse -Force

$releasePath = "$projectPath/src/Paket/bin/Release"
$dllPath = Get-LastSortedItem -Path $releasePath -Filter "paket.dll"
$dotnetVersion = $dllPath | Split-Path -Parent | Split-Path -Leaf

Write-Output "paket.dll path: $dllPath"


Copy-Item "$releasePath/$dotnetVersion/**" $toolVersionPath -Recurse -Force

if ($env:CI) {
    Remove-Item $projectPath -Recurse -Force -ErrorAction Ignore
}
