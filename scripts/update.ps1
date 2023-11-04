param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


function UpdateToml {
    param (
        [Parameter(Position = 0, Mandatory)]
        [string] $toml
    )
    $toml = [IO.Path]::GetFullPath("$ScriptDir/$toml")
    Write-Output "`n$toml"
    { cargo update --manifest-path $toml } | Invoke-Block
}

function UpdateJson {
    param (
        [string] $json
    )
    $json = [IO.Path]::GetFullPath("$ScriptDir/$json")
    Write-Output "`n$json"
    { pnpm -C $json update } | Invoke-Block
}


{ dotnet paket update } | Invoke-Block

{ cargo update } | Invoke-Block

UpdateToml "../apps/chat/contract/Cargo.toml"
UpdateToml "../apps/chat/contract/tests/Cargo.toml"
UpdateToml "../apps/chat/ui/Cargo.toml"
UpdateToml "../apps/dice/Cargo.toml"
UpdateToml "../apps/dice/fsharp/Cargo.toml"
UpdateToml "../apps/dice/contract/Cargo.toml"
UpdateToml "../apps/dice/contract/tests/Cargo.toml"
UpdateToml "../apps/plot/Cargo.toml"

UpdateJson "../apps/spiral/temp/extension"
UpdateJson "../apps/ipfs"
UpdateJson ".."
