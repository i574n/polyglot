param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1

# { bun build --target node --outdir out `
#     src/extension.ts `
#     media/cellOutputScrollButtons.ts `
# } | Invoke-Block

{ esbuild --bundle --outdir=out --external:vscode --format=cjs --platform=node `
    src/extension.ts `
    media/cellOutputScrollButtons.ts `
} | Invoke-Block
