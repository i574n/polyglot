param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item "../deps" -ItemType Directory -Force)
git clone --recurse-submodules https://github.com/i574n/The-Spiral-Language.git
{ git pull } | Invoke-Block -Location The-Spiral-Language
Set-Location $ScriptDir

{ dotnet build -c Release "../deps/The-Spiral-Language/The Spiral Language 2/The Spiral Language 2.fsproj" } | Invoke-Block
Copy-Item "../deps/The-Spiral-Language/VS Code Plugin/core/" "../deps/The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2" -Recurse -Force
