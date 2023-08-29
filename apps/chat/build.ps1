param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../scripts/chain.ps1


{ pwsh ./contract/build.ps1 -fast 1 } | Invoke-Block

{ pwsh ./ui/build.ps1 -fast $($fast ?? '') } | Invoke-Block

$nearSandboxExe = DownloadNearSandbox

{ cargo run --release --manifest-path tests/Cargo.toml } | Invoke-Block -Linux -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100; "NEAR_SANDBOX_BIN_PATH" = $nearSandboxExe }
