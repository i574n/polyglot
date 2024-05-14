param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../../scripts/core.ps1


{ . ../../../../apps/spiral/dist/Supervisor$(_exe) --execute-command "../../../../target/release/spiral_builder$(_exe) dib --path build.dib" } | Invoke-Block

$targetDir = "./fable_modules/fable-library-rust/target"

Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
