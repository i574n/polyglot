Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ../../core.ps1

wasm-pack build --dev --target web --reference-types # --weak-refs --no-typescript

$wasmJsPath = "./pkg/extension_bg_dist.wasm.js"
wasm2js -O4 pkg/extension_bg.wasm --output $wasmJsPath
$Content = Get-Content -Path $wasmJsPath -Raw
$Content = $Content -replace "import \* as wbg from 'wbg';", "import * as wbg from './extension.js';"
$Content = $Content -replace """wbg"": wbg,", @"
`"wbg`": (() => {
  const imports = wbg.__wbg_get_imports().wbg;
  const init = wbg.__wbg_finalize_init({
    exports: wbg,
  });
  return imports;
})(),
"@
$Content | Out-File -FilePath $wasmJsPath

$extensionJsPath = "./pkg/extension.js"
$Content = Get-Content -Path $extensionJsPath -Raw
$Content = $Content -replace "let wasm;", "let wasm; export const set_wasm = (w) => wasm = w;"
$Content = $Content -replace "function __wbg_get_imports", "export function __wbg_get_imports"
$Content = $Content -replace "function __wbg_finalize_init", "export function __wbg_finalize_init"
$Content | Out-File -FilePath $extensionJsPath

esbuild --bundle --minify --loader:.wasm=file --outdir=dist content_script.ts service_worker.ts

Copy-Item -Path ./public/* -Destination ./dist -Recurse -Force
