param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1
. ../../../lib/spiral/lib.ps1


$projectName = "spiral_builder"

if (!$fast -and !$SkipNotebook) {
    { . ../dist/Supervisor$(_exe) --execute-command "../../../target/release/spiral_builder$(_exe) dib --path $projectName.dib" } | Invoke-Block -Retries 3
}

{ . ../../parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block

{ . ../dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", "--persist-only", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block
(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../../lib", "../../../lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | FixRust2 `
    | Set-Content "$projectName.rs"

cargo fmt --

{ cargo +nightly test --release -- --show-output } | Invoke-Block
{ cargo +nightly build --release } | Invoke-Block

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
