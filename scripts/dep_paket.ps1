param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
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
        sudo apt install ca-certificates gnupg
        sudo gpg --homedir /tmp --no-default-keyring --keyring /usr/share/keyrings/mono-official-archive-keyring.gpg --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
        echo "deb [signed-by=/usr/share/keyrings/mono-official-archive-keyring.gpg] https://download.mono-project.com/repo/ubuntu stable-focal main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
        sudo apt update

        sudo apt install mono-devel
    }

    { pwsh -c "./build.sh MergePaketTool SkipDocs" } | Invoke-Block -Location $projectPath
}
Copy-Item "$projectPath/bin/net9.0/paket.exe" "$($tools.FullName)/paket.exe" -Recurse -Force

$releasePath = "$projectPath/src/Paket/bin/Release"
$dllPath = Get-LastSortedItem -Path $releasePath -Filter "paket.dll"
$dotnetVersion = $dllPath | Split-Path -Parent | Split-Path -Leaf

Write-Output "paket.dll path: $dllPath"


Copy-Item "$releasePath/$dotnetVersion/**" $toolVersionPath -Recurse -Force

if ($env:CI) {
    Remove-Item $projectPath -Recurse -Force -ErrorAction Ignore
}
