param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


{ cargo +nightly build --release --target wasm32-unknown-unknown } | Invoke-Block
New-Item dist -ItemType Directory -Force | Out-Null
Copy-Item ../../../workspace/target/wasm32-unknown-unknown/release/chat_contract.wasm dist/chat.wasm -Force

if (!$fast) {
    { ../../../workspace/target/release/chat_contract_tests } | Invoke-Block -Linux -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100 }
}
