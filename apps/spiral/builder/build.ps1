param(
    $fast,
    $SkipNotebook,
    $SkipFsx,
    $SkipPreBuild,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1
. ../../../lib/spiral/lib.ps1


$projectName = "spiral_builder"

if (!$SkipPreBuild -and !$SkipFsx) {
    if (!$fast -and !$SkipNotebook) {
        { . ../dist/Supervisor$(_exe) --execute-command "../../../workspace/target/release/spiral_builder$(_exe) dib --path $projectName.dib" } | Invoke-Block -Retries 3
    }

    { . ../../parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block

    { . ../dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" } | Invoke-Block
}

if (!$SkipPreBuild) {
    $runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
    $builderArgs = @("$projectName.fsx", "--persist-only", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
    { . ../../builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

    $targetDir = GetTargetDir $projectName

    { BuildFable $targetDir $projectName "rs" } | Invoke-Block

    $path = "$targetDir/target/rs/polyglot/target/Builder/$projectName/$projectName.rs"
    if (!(Test-Path $path)) {
        $path = "$targetDir/target/rs/$projectName.rs"
    }
    (Get-Content $path) `
        -replace "../../../../lib", "../../../lib" `
        -replace ".fsx`"]", ".rs`"]" `
        | FixRust `
        | Set-Content "$projectName.rs"

    if ($env:CI) {
        Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
    }
}

cargo fmt --

if (!$fast) {
    { cargo test --release -- --show-output } | Invoke-Block
}
{ cargo build --release } | Invoke-Block -OnError Continue
