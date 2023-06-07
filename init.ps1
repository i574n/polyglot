$ErrorActionPreference = "Stop"
. ./core.ps1


rustup +nightly component add clippy rust-src rustfmt
rustup update

cargo +nightly install wasm-pack


npm install -g esbuild


dotnet tool restore
dotnet paket restore


[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
Install-Module -Name PowerShellGet -Force -AllowClobber -Scope CurrentUser
Set-PSRepository -Name PSGallery -InstallationPolicy Trusted

Install-Module -Name PSToml -Scope CurrentUser


. "$PSScriptRoot/spiral/language.ps1"
. "$PSScriptRoot/spiral/extension.ps1"
. "$PSScriptRoot/spiral/fable.ps1"
