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

# The notebook runs through Kino (core.ps1 Invoke-Notebook) and exports math.spi.
if (!$fast -and !$SkipNotebook) {
    Invoke-Notebook "$projectName.livemd" -Retries ($fast -or !$env:CI ? 1 : 2)
}

Invoke-Notebook "$projectName.livemd" @("--spi-path", "$ScriptDir/$projectName.spi", "--export-only")

$targetDir = GetTargetDir $projectName

# Native Rust: math.spi (its `main` has a `Rust` arm that runs the tests by name, plus one `#[test]` wrapper per test) ->
# math.rs (tracked) with the Spiral compiler's own Rust backend: the `math` bin of Cargo.toml, a member of the polyglot
# workspace. Required check: `cargo test` must pass all 12 tests (pyo3 + Python's mpmath).
$nativeTests = 12
if (!(BuildNativeRust "$projectName.spi" "$projectName.rs" "lib/math")) {
    throw "NATIVE-RUST-FAILED lib/math / compile"
}
Push-Location ../../workspace
try {
    $nativeOutput = cargo +nightly-2025-11-01 test --release --package $projectName 2>&1 | ForEach-Object { "$_" }
    $nativeExit = $LASTEXITCODE
} finally {
    Pop-Location
}
$nativeOutput | ForEach-Object { Write-Output "polyglot/lib/math/build.ps1 / native test / $_" }
if ($nativeExit -ne 0 -or !($nativeOutput -match "^test result: ok\. $nativeTests passed; 0 failed")) {
    throw "NATIVE-RUST-FAILED lib/math / cargo test exit code $($nativeExit): expected 'test result: ok. $nativeTests passed; 0 failed'"
}
Write-Output "NATIVE-RUST-OK lib/math"
Write-Output "polyglot/lib/math/build.ps1 / `$targetDir: $targetDir / `$projectName: $projectName / `$env:CI:'$env:CI'"

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
    ClearCargoTarget "../../workspace"
}
