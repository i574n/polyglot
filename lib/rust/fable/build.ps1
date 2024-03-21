param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


Invoke-Dib build.dib

$targetDir = "./fable_modules/fable-library-rust/target"

Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
