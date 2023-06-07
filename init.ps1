$ErrorActionPreference = "Stop"
. ./core.ps1

# curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
# source "$HOME/.cargo/env"
# export PATH="$HOME/.cargo/bin:$PATH"

# rustup +nightly target add wasm32-unknown-unknown
# rustup +nightly target add wasm32-wasi
rustup +nightly component add clippy rust-src rustfmt

rustup update

try {
    cargo +nightly install wasm-pack --keep-going -Z unstable-options
} catch {}

npm install -g esbuild

dotnet tool restore
dotnet paket restore

# echo 'set -gx PATH $HOME/.cargo/bin $PATH' >> ~/.config/fish/config.fish


[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

# Install-PackageProvider -Name NuGet -MinimumVersion 2.8.5.201 -Force -Scope CurrentUser
Install-Module -Name PowerShellGet -Force -AllowClobber -Scope CurrentUser

Set-PSRepository -Name PSGallery -InstallationPolicy Trusted

Install-Module -Name PSToml -Scope CurrentUser


. "$PSScriptRoot/spiral/language.ps1"
. "$PSScriptRoot/spiral/extension.ps1"
. "$PSScriptRoot/spiral/fable.ps1"
