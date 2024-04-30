param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../lib/spiral/lib.ps1


$projectName = "math"

if (!$fast && !$SkipNotebook) {
    { . ../../apps/spiral/dist/Supervisor$(_exe) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 $projectName.dib`"" } | Invoke-Block -Retries ($fast -or !$env:CI ? 1 : 5)
}

{ . ../../apps/parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block

{ . ../../apps/spiral/dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" --timeout 60000 } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block

(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../lib", "../lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | Set-Content "$projectName.rs"

cargo fmt --

{ cargo test --release } | Invoke-Block

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
