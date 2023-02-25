rustup +nightly target add wasm32-unknown-unknown
rustup +nightly target add wasm32-wasi
rustup +nightly component add rust-src

cargo install wasm-pack
