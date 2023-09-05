param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


npx -y tailwindcss -i input.css -o target/tailwind.css

{ trunk serve --dist="target/trunk" } | Invoke-Block
