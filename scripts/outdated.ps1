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
    Write-Output "`nCheckToml / toml: $toml"
    { cargo outdated -m $toml --exclude tokio @_args } | Invoke-Block
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

CheckToml "../Cargo.toml" `-w

CheckToml "../apps/chat/contract/Cargo.toml"
CheckToml "../apps/chat/contract/tests/Cargo.toml"
CheckToml "../apps/dice/Cargo.toml"
CheckToml "../apps/dice/fsharp/Cargo.toml"
CheckToml "../apps/dice/contract/Cargo.toml"
CheckToml "../apps/dice/contract/tests/Cargo.toml"
CheckToml "../apps/dice/ui/Cargo.toml"
CheckToml "../apps/plot/Cargo.toml"

CheckJson ".."
CheckJson "../apps/dice/ui"
CheckJson "../apps/dice/ui/e2e"
CheckJson "../apps/ipfs"
CheckJson "../apps/spiral/temp/extension"
