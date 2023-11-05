param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../../scripts/core.ps1


if (!$fast) {
    { pnpm install --frozen-lockfile } | Invoke-Block
}

{ wasm-pack build --target web --dev <# --reference-types # --weak-refs --no-typescript #> } | Invoke-Block

Remove-Item ./dist -Recurse -Force -ErrorAction Ignore
{ esbuild --bundle --minify --loader:.wasm=file --platform=node --outdir=dist content_script.ts service_worker.ts devtools.ts } | Invoke-Block
{ Copy-Item -Recurse -Force ./public/* ./dist } | Invoke-Block

if (!$fast) {
    { pnpm test:e2e } | Invoke-Block
}
