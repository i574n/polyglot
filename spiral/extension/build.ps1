Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ../../core.ps1

wasm-pack build --release --target web # --no-typescript --reference-types --weak-refs
wasm2js -O4 pkg/extension_bg.wasm --output pkg/extension_bg.wasm.js

$wasmJsPath = "./pkg/extension_bg.wasm.js"
$Content = Get-Content -Path $wasmJsPath -Raw
$UpdatedContent = $Content -replace "import \* as wbg from 'wbg';", "import * as wbg from './extension.js';"
$UpdatedContent | Out-File -FilePath $wasmJsPath

esbuild --bundle --minify --loader:.wasm=file --outdir=dist content_script.ts service_worker.ts

Copy-Item -Path ./public/* -Destination ./dist -Recurse -Force
