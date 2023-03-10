param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Set-Location (New-Item -ItemType Directory -Path "../deps" -Force)
git clone --recurse-submodules https://github.com/i574n/The-Spiral-Language.git
Set-Location The-Spiral-Language
git pull
Set-Location $ScriptDir

{ dotnet build -c Release "../deps/The-Spiral-Language/The Spiral Language 2/The Spiral Language 2.fsproj" } | Invoke-Block
Copy-Item "../deps/The-Spiral-Language/VS Code Plugin/core/" "../deps/The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2" -Recurse -Force
