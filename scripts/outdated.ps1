param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


function CheckToml {
    param (
        [string] $toml
    )
    $toml = [IO.Path]::GetFullPath("$ScriptDir/$toml")
    Write-Output "`n$toml"
    { cargo outdated -w -m $toml } | Invoke-Block
}

function CheckJson {
    param (
        [string] $json
    )
    $json = [IO.Path]::GetFullPath("$ScriptDir/$json")
    Write-Output "`n$json"
    { pnpm -C $json outdated-pre } | Invoke-Block
}


{ dotnet paket outdated --include-prereleases } | Invoke-Block

{ cargo outdated -w } | Invoke-Block

CheckToml "../apps/chat/contract/Cargo.toml"
CheckToml "../apps/chat/tests/Cargo.toml"
CheckToml "../apps/chat/ui/Cargo.toml"
CheckToml "../apps/dice/Cargo.toml"
CheckToml "../apps/dice/contract/Cargo.toml"
CheckToml "../apps/dice/tests/Cargo.toml"
CheckToml "../apps/plot/Cargo.toml"

CheckJson "../spiral/extension"
CheckJson "../apps/ipfs"
CheckJson ".."
