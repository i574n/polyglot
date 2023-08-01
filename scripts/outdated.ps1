param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


dotnet paket outdated --include-prereleases
cargo outdated -w
pnpm -C ../spiral/extension outdated-pre
