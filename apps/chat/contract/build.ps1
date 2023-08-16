param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1
. ../../../scripts/chain.ps1


{ cargo build --release --target wasm32-unknown-unknown } | Invoke-Block
Copy-Item -Force target/wasm32-unknown-unknown/release/chat.wasm res/chat.wasm

if (!$fast) {
    $nearSandboxExe = DownloadNearSandbox

    { ../tests/target/release/chat } | Invoke-Block -Linux -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100; "NEAR_SANDBOX_BIN_PATH" = $nearSandboxExe }
}
