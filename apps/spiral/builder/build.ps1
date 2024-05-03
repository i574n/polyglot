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
    { cargo build --release } | Invoke-Block
    { . ../dist/Supervisor$(_exe) --execute-command "pwsh -c `"../../../scripts/invoke-dib.ps1 $projectName.dib -Retries 3`"" } | Invoke-Block
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
    | Set-Content "$projectName.rs"

cargo fmt --

{ cargo test --release -- --show-output } | Invoke-Block
{ cargo build --release } | Invoke-Block

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
