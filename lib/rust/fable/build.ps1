param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


if (!$fast) {
    Invoke-Dib build.dib
}

$rsPath = "./fable_modules/fable-library-rust/src/Range.rs"

(Get-Content $rsPath) `
    -replace "use crate::String_::fromCharCode;", "use crate::String_::fromChar;" `
    -replace "fromCharCode\(c\)", "std::char::from_u32(c).unwrap()" `
    | Set-Content $rsPath

$targetDir = "./fable_modules/fable-library-rust/target"

Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
