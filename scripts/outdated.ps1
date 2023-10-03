param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


function CheckToml {
    param (
        [Parameter(Position = 0, Mandatory)]
        [string] $toml,

        [Parameter(Position = 1, ValueFromRemainingArguments)]
        [Object[]]$_args
    )
    $toml = [IO.Path]::GetFullPath("$ScriptDir/$toml")
    Write-Output "`n$toml"
    { cargo outdated -w -m $toml @_args } | Invoke-Block
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
CheckToml "../apps/chat/tests/Cargo.toml" --exclude tokio
CheckToml "../apps/chat/ui/Cargo.toml"
CheckToml "../apps/dice/Cargo.toml"
CheckToml "../apps/dice/contract/Cargo.toml"
CheckToml "../apps/dice/tests/Cargo.toml" --exclude tokio
CheckToml "../apps/plot/Cargo.toml"

CheckJson "../spiral/extension"
CheckJson "../apps/ipfs"
CheckJson ".."
