param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


dotnet paket outdated --include-prereleases

cargo outdated -w

function CheckToml {
    param (
        [string] $toml
    )
    $toml = [IO.Path]::GetFullPath("$ScriptDir/$toml")
    Write-Output "`n$toml"
    cargo outdated -w -m $toml
}
CheckToml "../apps/chat/contract/Cargo.toml"
CheckToml "../apps/chat/tests/Cargo.toml"
CheckToml "../apps/chat/ui/Cargo.toml"
CheckToml "../apps/dice/Cargo.toml"
CheckToml "../apps/dice/contract/Cargo.toml"
CheckToml "../apps/dice/tests/Cargo.toml"
CheckToml "../apps/plot/Cargo.toml"

pnpm -C ../spiral/extension outdated-pre
