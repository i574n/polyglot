dotnet fable `
    "$PSScriptRoot" `
    --optimize `
    --lang rs `
    --extension .rs `
    --outDir "$PSScriptRoot"

# cargo build --release --manifest-path "$PSScriptRoot/Cargo.toml"


# . "$PSScriptRoot/../../target/release/cli" SpiFsxBuild -- --spi-path="$PSScriptRoot/test.spi"

# dotnet fable `
#     "$PSScriptRoot" `
#     --optimize `
#     --lang rs `
#     --extension .rs `
#     --outDir "$PSScriptRoot"

cargo fmt

cargo build --release --manifest-path "$PSScriptRoot/Cargo.toml"

. "$PSScriptRoot/../../target/release/test" | Tee-Object test.out
