param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


{ . ../../spiral/dist/Supervisor$(GetExecutableSuffix) --build-file src/dice_ui.spi src/dice_ui.fsx --timeout 20000 } | Invoke-Block

(Get-Content src/dice_ui.fsx) `
    -replace "and Heap2 =", "and  Heap2 =" `
| Set-Content src/dice_ui.fsx

{ . ../../builder/dist/Builder$(GetExecutableSuffix) src/dice_ui.fsx $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) $($fast ? @("--persist-only") : @()) --packages Fable.Core --modules lib/fsharp/Common.fs } | Invoke-Block

$targetDir = "../../../target/polyglot/builder/dice_ui"

{ dotnet fable $targetDir/dice_ui.fsproj --optimize --lang rs --extension .rs --outDir $targetDir/rs --define WASM } | Invoke-Block

Copy-Item $targetDir/rs/lib/fsharp/Common.rs ../../../lib/fsharp/CommonWasm.rs -Force

(Get-Content $targetDir/rs/dice_ui.rs) `
    -replace "../../../../lib/fsharp", "../../../lib/fsharp" `
    -replace "pub use crate::module_", "// pub use crate::module_" `
    -replace "pub struct Heap0 {", "#[derive(serde::Serialize)] pub struct Heap0 {" `
    -replace "pub struct Heap1 {", "#[derive(serde::Serialize)] pub struct Heap1 {" `
    -replace "pub struct Heap2 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize)] pub struct Heap2 {" `
    -replace "pub struct Heap3 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize, PartialEq)] pub struct Heap3 {" `
    -replace "/Common.rs", "/CommonWasm.rs" `
| Set-Content src/dice_ui_wasm.rs
    # -replace "pub struct Heap0 {", "#[derive(serde::Serialize)] pub struct Heap0 {" `
    # -replace "pub struct Heap1 {", "#[derive(serde::Serialize, serde::Deserialize)] pub struct Heap1 {" `
    # -replace "pub struct Heap2 {", "#[derive(serde::Serialize)] pub struct Heap2 {" `
    # -replace "pub struct Heap3 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize)] pub struct Heap3 {" `
    # -replace "pub struct Heap4 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize)] pub struct Heap4 {" `

cargo fmt --
leptosfmt ./src/dice_ui_wasm.rs

if (!$fast) {
    Remove-Item $targetDir/trunk -Recurse -Force -ErrorAction Ignore
    Remove-Item ./dist -Recurse -Force -ErrorAction Ignore

    { pnpm install --frozen-lockfile } | Invoke-Block
}

{ pnpm build-css } | Invoke-Block

{ trunk build $($fast ? $() : '--release') --dist="$targetDir/trunk" --public-url="./" --no-sri } | Invoke-Block -EnvironmentVariables @{ "TRUNK_TOOLS_WASM_BINDGEN" = "0.2.89" }
# { cargo leptos build --release } | Invoke-Block

$path = "$targetDir/trunk/index.html"
{ rna build --bundle --minify --no-map --assetNames "[name]" $path --output dist } | Invoke-Block

$path = "dist/index.html"

Move-Item $path dist/popup.html -Force
Copy-Item public/manifest.json dist/manifest.json -Force

if (!$fast) {
    { pnpm install --frozen-lockfile } | Invoke-Block -Location e2e
    { pnpm test:e2e } | Invoke-Block -Location e2e
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
