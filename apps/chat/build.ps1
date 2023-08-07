param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ cargo build --release --target wasm32-unknown-unknown --manifest-path contract/Cargo.toml } | Invoke-Block
Copy-Item -Force contract/target/wasm32-unknown-unknown/release/chat.wasm contract/res/chat.wasm

$nearSandboxExe = "tests/target/near-sandbox"
if (!(Test-Path $nearSandboxExe)) {
    $nearSandboxZip = Join-Path -Path ([System.IO.Path]::GetTempPath()) -ChildPath "near-sandbox.zip"
    $url = if (Get-Content -Path /etc/os-release -ErrorAction SilentlyContinue | Select-String -Pattern "NixOS") {
        "https://bafybeiahopxwsng6nmgihipwjpv6nzwoz7ta2jam6bukve7kni5auhiimu.ipfs.dweb.link"
    } else {
        "https://bafybeictjqjc3sbppcslzezn64h7acnrmt3oskdyjxgcrawlu6pujvin3i.ipfs.dweb.link"
    }
    Invoke-WebRequest -Uri $url -OutFile $nearSandboxZip
    Expand-Archive -Path $nearSandboxZip -DestinationPath "tests/target" -Force
    { chmod +x $nearSandboxExe } | Invoke-Block -Linux
}

{ cargo run --release --manifest-path tests/Cargo.toml } | Invoke-Block -Linux -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100; "NEAR_SANDBOX_BIN_PATH" = $nearSandboxExe }
