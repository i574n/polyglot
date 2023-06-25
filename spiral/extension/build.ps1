Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ pnpm install --frozen-lockfile } | Invoke-Block
{ wasm-pack build --target web --dev <# --reference-types # --weak-refs --no-typescript #> } | Invoke-Block
{ if (Test-Path ./dist) { Remove-Item -Path ./dist -Recurse -Force } } | Invoke-Block
{ esbuild --bundle --minify --loader:.wasm=file --outdir=dist content_script.ts service_worker.ts } | Invoke-Block
{ Copy-Item -Path ./public/* -Destination ./dist -Recurse -Force } | Invoke-Block
{ pnpm test:e2e } | Invoke-Block
