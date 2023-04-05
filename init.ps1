# curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
# source "$HOME/.cargo/env"

# rustup +nightly target add wasm32-unknown-unknown
# rustup +nightly target add wasm32-wasi
rustup +nightly component add rust-src
rustup component add rustfmt

# cargo install wasm-pack

. spiral/language.ps1
