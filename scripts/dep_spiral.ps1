$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


$depsPath = "../deps"
if (!(Test-Path $depsPath)) { New-Item -ItemType Directory -Path $depsPath }
Set-Location $depsPath
git clone https://github.com/i574n/The-Spiral-Language.git
Set-Location $ScriptDir

{ dotnet build -c Release "../deps/The-Spiral-Language/The Spiral Language 2/The Spiral Language 2.fsproj" } | Invoke-Block
