Set-Location $PSScriptRoot
. ../../core.ps1

dotnet fable `
    --optimize `
    --lang rs `
    --extension .rs `

# cargo build --release --manifest-path "$PSScriptRoot/Cargo.toml"


# . "$PSScriptRoot/../../target/release/cli" SpiFsxBuild -- --spi-path="$PSScriptRoot/cli.spi"

# dotnet fable `
#     "$PSScriptRoot" `
#     --optimize `
#     --lang rs `
#     --extension .rs `
#     --outDir "$PSScriptRoot"

cargo fmt

cargo build --release

. "$PSScriptRoot/../../target/release/cli" | Tee-Object cli.out
