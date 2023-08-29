param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


dotnet paket outdated --include-prereleases

cargo outdated -w
cargo outdated -w -m apps/chat/contract/Cargo.toml
cargo outdated -w -m apps/chat/tests/Cargo.toml
cargo outdated -w -m apps/chat/ui/Cargo.toml
cargo outdated -w -m apps/dice/Cargo.toml
cargo outdated -w -m apps/dice/contract/Cargo.toml
cargo outdated -w -m apps/dice/tests/Cargo.toml
cargo outdated -w -m apps/plot/Cargo.toml

pnpm -C ../spiral/extension outdated-pre
