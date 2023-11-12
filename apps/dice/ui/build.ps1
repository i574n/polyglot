param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


{ . ../../spiral/dist/Supervisor$(GetExecutableSuffix) --build-file ui.spi ui.fsx --timeout 10000 } | Invoke-Block

{ . ../../builder/dist/Builder$(GetExecutableSuffix) ui.fsx $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) $($fast ? @("--persist-only") : @()) --packages Fable.Core --modules lib/fsharp/Common.fs } | Invoke-Block

{ dotnet fable target/ui.fsproj --optimize --lang rs --extension .rs --outDir target/rs --define WASM } | Invoke-Block

Copy-Item target/rs/lib/fsharp/Common.rs ../../../lib/fsharp/CommonWasm.rs -Force

(Get-Content target/rs/ui.rs) `
    -replace "../../../lib/fsharp", "../../lib/fsharp" `
    -replace "pub use crate::module_", "// pub use crate::module_" `
    -replace "/Common.rs", "/CommonWasm.rs" `
| Set-Content ui_wasm.rs

cargo fmt --
leptosfmt ./ui_wasm.rs

if (!$fast) {
    Remove-Item ./target/trunk -Recurse -Force -ErrorAction Ignore
    Remove-Item ./dist -Recurse -Force -ErrorAction Ignore

    npx -y tailwindcss -i input.css -o target/tailwind.css
}

{ trunk build $($fast ? $() : '--release') --dist="target/trunk" --public-url="./dist" } | Invoke-Block

$path = "target/trunk/index.html"
$html = Get-Content $path
$oldModule = ($html | Select-String -Pattern "import init from '/./dist/(.*?)'").Matches[0].Groups[1].Value
$html `
    -replace "/./dist/", "./" `
    -replace "import init from '([^']+)';init\(", "import init from './$oldModule';init(" `
| Set-Content $path

{ rna build --bundle --minify --no-map --assetNames "[name]" target/trunk/index.html --output dist } | Invoke-Block

$path = "dist/index.html"
$html = Get-Content $path -Raw

$oldModule = $html | Select-String -Pattern '<link rel="modulepreload" href="([^"]+)">' -AllMatches
if ($oldModule.Matches.Count -gt 0) {
    $oldModule.Matches | ForEach-Object { Remove-Item "dist/$($_.Groups[1].Value)" -Force }
    $newModule = $html | Select-String -Pattern "import './(.*?)'"
    $newModule = $newModule.Matches[0].Groups[1].Value
    $html `
        -replace '<link rel="modulepreload" href="([^"]+)">', "<script type=`"text/javascript`" src=`"$newModule`"></script>" `
        -replace "\n        import './$newModule'\n    ", '' `
    | Set-Content $path

    $jsPath = "dist/$newModule"
    $text = Get-Content $jsPath
    $text `
        -replace "`",import.meta.url\)\);", "`"));" `
    | Set-Content $jsPath
}

Move-Item $path dist/popup.html -Force
Copy-Item public/manifest.json dist/manifest.json -Force

if (!$fast) {
    { pnpm install --frozen-lockfile } | Invoke-Block -Location e2e
    { pnpm test:e2e } | Invoke-Block -Location e2e
}

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
