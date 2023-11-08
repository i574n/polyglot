param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1
. ../../../scripts/chain.ps1


{ cargo build --release --target wasm32-unknown-unknown --features wasm } | Invoke-Block
New-Item dist -ItemType Directory -Force | Out-Null
Copy-Item -Force ../../../target/wasm32-unknown-unknown/release/dice_contract.wasm dist/dice.wasm

if (!$fast) {
    $nearSandboxExe = DownloadNearSandbox

    { ../../../target/release/dice_contract_tests } | Invoke-Block -Linux -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100; "NEAR_SANDBOX_BIN_PATH" = $nearSandboxExe }
}

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
