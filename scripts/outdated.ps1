$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


dotnet paket outdated --include-prereleases
pnpm -C ../spiral/extension outdated-pre
