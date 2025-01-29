param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


{ dotnet fable --optimize --lang rs --extension .rs --noCache } | Invoke-Block

$libPath = "./fable_modules/fable-library-rust"

$rsPath = "$libPath/src/Range.rs"
(Get-Content $rsPath) `
    -replace "use crate::String_::fromCharCode;", "use crate::String_::fromChar;" `
    -replace "fromCharCode\(c\)", "std::char::from_u32(c).unwrap()" `
    | Set-Content $rsPath

$rsPath = "$libPath/src/Seq.rs"
(Get-Content $rsPath) `
    -replace "\(&e\.get_Current", "(e.get_Current" `
    | Set-Content $rsPath

{ cargo check } | Invoke-Block -Location $libPath -OnError Continue
if (!$fast) {
    # { cargo clippy } | Invoke-Block -Location $libPath -OnError Continue
}
