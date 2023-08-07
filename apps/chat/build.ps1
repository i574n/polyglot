param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ cargo build --release --target wasm32-unknown-unknown --manifest-path contract/Cargo.toml } | Invoke-Block
Copy-Item -Force contract/target/wasm32-unknown-unknown/release/chat.wasm contract/res/chat.wasm

{ cargo run --release --example tests --manifest-path tests/Cargo.toml } | Invoke-Block -Linux -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100; "NEAR_SANDBOX_BIN_PATH" = (($p = "../../../nearcore/target/debug/near-sandbox") -and (Test-Path $p) ? $p : "") }
