param(
    $ScriptDir = $PSScriptRoot
)
$ScriptDir | Set-Location
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item "../deps" -ItemType Directory -Force)
git clone --recurse-submodules https://github.com/i574n/Paket.git
{ git pull } | Invoke-Block -Location Paket

$path = "$HOME/.nuget/packages/paket"
$tools = Get-LastSortedItem -Path $path -Filter "tools"
$toolVersionPath = Get-LastSortedItem -Path $tools.FullName -Filter "any"

Write-Output "Tool path: $toolVersionPath"

$projectPath = "../deps/Paket"

{ dotnet tool restore } | Invoke-Block -Location $projectPath

{ dotnet paket restore } | Invoke-Block -Location $projectPath

if ($IsWindows) {
    { pwsh -c "./build.cmd MergePaketTool SkipDocs" } | Invoke-Block -Location $projectPath
} else {

    if (!(Search-Command "mono")) {
        $env:PREFIX="/usr/local"
        $env:VERSION="6.14.0"
        if (!(Test-Path mono-$env:VERSION)) {
            sudo apt-get install git autoconf libtool automake build-essential gettext cmake python3 curl

            wget https://dl.winehq.org/mono/sources/mono/mono-$($env:VERSION).tar.xz
            tar xf mono-$env:VERSION.tar.xz
        }
        cd mono-$env:VERSION
        ./configure --prefix=$env:PREFIX
        sudo make
        sudo make install
        $ScriptDir | Set-Location
    }

    { pwsh -c "./build.sh MergePaketTool SkipDocs" } | Invoke-Block -Location $projectPath
}
Copy-Item "$projectPath/bin/net9.0/paket$(_exe)" "$($tools.FullName)/paket$(_exe)" -Recurse -Force

$releasePath = "$projectPath/src/Paket/bin/Release"
$dllPath = Get-LastSortedItem -Path $releasePath -Filter "paket.dll"
$dotnetVersion = $dllPath | Split-Path -Parent | Split-Path -Leaf

Write-Output "paket.dll path: $dllPath"


Copy-Item "$releasePath/$dotnetVersion/**" $toolVersionPath -Recurse -Force

if ($env:CI) {
    Remove-Item $projectPath -Recurse -Force -ErrorAction Ignore
}
