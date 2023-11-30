param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1
. ../../../scripts/chain.ps1


{ cargo build --release --target wasm32-unknown-unknown } | Invoke-Block
New-Item dist -ItemType Directory -Force | Out-Null
Copy-Item ../../../target/wasm32-unknown-unknown/release/chat_contract.wasm dist/chat.wasm -Force

if (!$fast) {
    $nearSandboxExe = DownloadNearSandbox

    { ../../../target/release/chat_contract_tests } | Invoke-Block -Linux -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100; "NEAR_SANDBOX_BIN_PATH" = $nearSandboxExe }
}
