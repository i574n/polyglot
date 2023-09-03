param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


npx -y tailwindcss -i input.css -o dist/tailwind.css

{ trunk serve --dist="dist/trunk" } | Invoke-Block
