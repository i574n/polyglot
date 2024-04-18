param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1
. ../../../lib/spiral/lib.ps1


$projectName = "rust_builder"

if (!$fast -and !$SkipNotebook) {
    { . ../dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../../scripts/invoke-dib.ps1 $projectName.dib`"" } | Invoke-Block -Retries 5
}

{ . ../../parser/dist/DibParser$(GetExecutableSuffix) "$projectName.dib" spi } | Invoke-Block

{ . ../dist/Supervisor$(GetExecutableSuffix) --build-file "$projectName.spi" "$projectName.fsx" --timeout 60000 } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", "--persist-only", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../builder/dist/Builder$(GetExecutableSuffix) @builderArgs } | Invoke-Block

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
