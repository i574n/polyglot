param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ pnpm install --frozen-lockfile } | Invoke-Block
{ wasm-pack build --target web --dev <# --reference-types # --weak-refs --no-typescript #> } | Invoke-Block
Remove-Item ./dist -Recurse -Force -ErrorAction Ignore
{ esbuild --bundle --minify --loader:.wasm=file --outdir=dist content_script.ts service_worker.ts } | Invoke-Block
{ Copy-Item -Recurse -Force ./public/* ./dist } | Invoke-Block
{ pnpm test:e2e } | Invoke-Block
