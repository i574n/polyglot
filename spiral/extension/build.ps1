Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ../../core.ps1

wasm-pack build --release --target web

esbuild --bundle --minify --loader:.wasm=file --outdir=dist content_script.ts service_worker.ts

Copy-Item -Path ./public/* -Destination ./dist -Recurse -Force
