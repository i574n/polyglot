Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ pnpm install --frozen-lockfile } | Invoke-Block
