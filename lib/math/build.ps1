param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../deps/spiral/lib/spiral/lib.ps1


$projectName = "math"

if (!$fast -and !$SkipNotebook) {
    { . ../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path "$projectName.dib" --retries $($fast -or !$env:CI ? 1 : 2) } | Invoke-Block -OnError Continue
}

{ . ../../deps/spiral/workspace/target/release/spiral$(_exe) dib-export "$projectName.dib" spi } | Invoke-Block

{ . ../../apps/spiral/dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" --timeout 300000 } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

# Native Rust: the same math.spi entry (its `main` has a `Rust` arm that runs the tests by name, plus one `#[test]`
# wrapper per test) -> a crate under the target dir with the Spiral compiler's own Rust backend, no Fable. Required
# check: `cargo test` must pass all 12 tests (pyo3 + Python's mpmath).
# The compiler also writes its output next to the .spi it compiles (math.rs is Fable's), so it compiles a staged copy
# (the .spi plus a package file with an absolute packageDir) under the target dir.
$nativeDir = "$targetDir/native"
$nativeStage = "$nativeDir/spi"
$nativeTests = 12
Remove-Item $nativeStage -Recurse -Force -ErrorAction Ignore
New-Item -ItemType Directory -Force "$nativeDir/src", $nativeStage | Out-Null
Copy-Item "$projectName.spi" $nativeStage
$packageDir = (ResolveLink (GetFullPath "../../deps/spiral/lib")) -replace '\\', '/'
@("packageDir: $packageDir", 'packages:', '    |core-', '    spiral-', 'modules:', "    $projectName") | Set-Content "$nativeStage/package.spiproj"
@('[package]', "name = `"$($projectName)_native`"", 'version = "0.0.1"', 'edition = "2021"', '', '[workspace]', '', '[dependencies]', 'num-complex = ">=0.4,<1"', 'pyo3 = "=0.26.0"') `
    | Set-Content "$nativeDir/Cargo.toml"
if (!(BuildNativeRust "$nativeStage/$projectName.spi" "$nativeDir/src/main.rs" "lib/math")) {
    throw "NATIVE-RUST-FAILED lib/math / compile"
}
Push-Location $nativeDir
try {
    $nativeOutput = cargo +nightly-2025-11-01 test --release 2>&1 | ForEach-Object { "$_" }
    $nativeExit = $LASTEXITCODE
} finally {
    Pop-Location
}
$nativeOutput | ForEach-Object { Write-Output "polyglot/lib/math/build.ps1 / native test / $_" }
if ($nativeExit -ne 0 -or !($nativeOutput -match "^test result: ok\. $nativeTests passed; 0 failed")) {
    throw "NATIVE-RUST-FAILED lib/math / cargo test exit code $($nativeExit): expected 'test result: ok. $nativeTests passed; 0 failed'"
}
Write-Output "NATIVE-RUST-OK lib/math"

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block

$path = "$targetDir/$projectName.rs"
if (!(Test-Path $path)) {
    $path = "$targetDir/target/rs/target/Builder/$projectName/$projectName.rs"
}
if (!(Test-Path $path)) {
    $path = "$targetDir/target/rs/$projectName.rs"
}
Write-Output "polyglot/lib/math/build.ps1 / path: $path"
(Get-Content $path) `
    -replace "`"../../../../../deps", "`"../../deps" `
    -replace "`"./lib", "`"../../lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | Set-Content "$projectName.rs"

cargo fmt --

{ cargo +nightly-2025-11-01 test --timings --release } | Invoke-Block -OnError Continue

Write-Output "polyglot/lib/math/build.ps1 / `$targetDir: $targetDir / `$projectName: $projectName / `$env:CI:'$env:CI'"

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
    ClearCargoTarget "../../workspace"
}
