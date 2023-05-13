# curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
# source "$HOME/.cargo/env"
# export PATH="$HOME/.cargo/bin:$PATH"

# rustup +nightly target add wasm32-unknown-unknown
# rustup +nightly target add wasm32-wasi
rustup +nightly component add rust-src
rustup component add rustfmt

rustup update

# cargo install wasm-pack

dotnet tool restore
dotnet paket restore

# echo 'set -gx PATH $HOME/.cargo/bin $PATH' >> ~/.config/fish/config.fish

. spiral/language.ps1
. spiral/extension.ps1

. spiral/fable.ps1
