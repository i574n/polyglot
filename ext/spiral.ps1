$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../core.ps1


git clone https://github.com/i574n/The-Spiral-Language.git

{ dotnet build -c Release "./The-Spiral-Language/The Spiral Language 2/The Spiral Language 2.fsproj" } | Invoke-Block
