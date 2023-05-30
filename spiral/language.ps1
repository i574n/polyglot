Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ../core.ps1

git clone https://github.com/i574n/The-Spiral-Language.git

Invoke-Call -ScriptBlock {
    dotnet build -c Release "./The-Spiral-Language/The Spiral Language 2/The Spiral Language 2.fsproj"
} -ErrorAction Stop
