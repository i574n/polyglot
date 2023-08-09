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
    $osRelease = { pwsh -c Get-Content /etc/os-release } | Invoke-Block -Linux
    $url = if ($osRelease | Select-String -Pattern "NixOS" -Quiet) {
        "https://bafybeiahopxwsng6nmgihipwjpv6nzwoz7ta2jam6bukve7kni5auhiimu.ipfs.dweb.link"
    } else {
        "https://bafybeictjqjc3sbppcslzezn64h7acnrmt3oskdyjxgcrawlu6pujvin3i.ipfs.dweb.link"
    }

    $retryCount = 0
    while ($retryCount -lt 3) {
        $Error.Clear()

        Invoke-WebRequest $url -OutFile $nearSandboxZip -ErrorAction Stop
        Expand-Archive -Force $nearSandboxZip "tests/target" -ErrorAction Stop

        if ($Error.Count -eq 0) {
            break
        }

        $retryCount++
        Write-Output "Retrying download of $url"
    }
    if ($Error.Count -gt 0) {
        throw "Failed to download $url"
    }

    { chmod +x $nearSandboxExe } | Invoke-Block -Linux
}

{ cargo run --release --manifest-path tests/Cargo.toml } | Invoke-Block -Linux -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100; "NEAR_SANDBOX_BIN_PATH" = $nearSandboxExe }
