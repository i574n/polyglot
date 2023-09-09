param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1
. ../../../scripts/chain.ps1


$nearSandboxExe = DownloadNearSandbox

{ cargo run --release } | Invoke-Block -Linux -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100; "NEAR_SANDBOX_BIN_PATH" = $nearSandboxExe }

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
