dotnet fable `
    "$PSScriptRoot" `
    --optimize `
    --lang rs `
    --extension .rs `
    --outDir "$PSScriptRoot"

# cargo build --release --manifest-path "$PSScriptRoot/Cargo.toml"


# . "$PSScriptRoot/../../target/release/cli" SpiFsxBuild -- --spi-path="$PSScriptRoot/cli.spi"

# dotnet fable `
#     "$PSScriptRoot" `
#     --optimize `
#     --lang rs `
#     --extension .rs `
#     --outDir "$PSScriptRoot"

cargo fmt

cargo build --release --manifest-path "$PSScriptRoot/Cargo.toml"

. "$PSScriptRoot/../../target/release/cli.exe" | Tee-Object cli.md
