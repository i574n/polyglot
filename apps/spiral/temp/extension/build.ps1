param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../../scripts/core.ps1


if (!$fast) {
    { ~/.bun/bin/bun install --frozen-lockfile } | Invoke-Block
}

{ wasm-pack build --target web --dev <# --reference-types # --weak-refs --no-typescript #> } | Invoke-Block

Remove-Item ./dist -Recurse -Force -ErrorAction Ignore
{ ~/.bun/bin/bunx --bun esbuild --bundle --minify --loader:.wasm=file --outdir=dist content_script.ts service_worker.ts devtools.ts } | Invoke-Block
{ Copy-Item ./public/* ./dist -Recurse -Force } | Invoke-Block

if (!$fast) {
    { ~/.bun/bin/bun test:e2e } | Invoke-Block -OnError Continue
}
