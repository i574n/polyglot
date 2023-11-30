param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { dotnet run --configuration Release --project temp/dice.fsproj } | Invoke-Block

    { . ../spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 dice.dib`"" } | Invoke-Block -Retries 5
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) dice.dib spi } | Invoke-Block

{ . ../spiral/dist/Supervisor$(GetExecutableSuffix) --build-file dice.spi dice.fsx --timeout 10000 } | Invoke-Block

{ . ../builder/dist/Builder$(GetExecutableSuffix) dice.fsx $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Fable.Core --modules lib/fsharp/Common.fs } | Invoke-Block

$targetDir = "../../target/polyglot/builder/dice"

{ dotnet fable $targetDir/dice.fsproj --optimize --lang rs --extension .rs --outDir $targetDir/rs } | Invoke-Block

if (!$fast) {
    { dotnet fable $targetDir/dice.fsproj --optimize --lang ts --extension .ts --outDir $targetDir/ts } | Invoke-Block
    { dotnet fable $targetDir/dice.fsproj --optimize --lang py --extension .py --outDir $targetDir/py } | Invoke-Block
    { dotnet fable $targetDir/dice.fsproj --optimize --lang php --extension .php --outDir $targetDir/php } | Invoke-Block -OnError Continue
    { dotnet fable $targetDir/dice.fsproj --optimize --lang dart --extension .dart --outDir $targetDir/dart } | Invoke-Block -OnError Continue
}

Copy-Item $targetDir/rs/lib/fsharp/Common.rs ../../lib/fsharp/Common.rs -Force
if (!$fast) {
    Copy-Item $targetDir/ts/lib/fsharp/Common.ts ../../lib/fsharp/Common.ts -Force
    Copy-Item $targetDir/py/lib/fsharp/common.py ../../lib/fsharp/common.py -Force
    Copy-Item $targetDir/php/lib/fsharp/Common.php ../../lib/fsharp/Common.php -Force
    Copy-Item $targetDir/dart/lib/fsharp/Common.dart ../../lib/fsharp/Common.dart -Force
}

(Get-Content $targetDir/rs/dice.rs) `
    -replace "../../../../lib/fsharp", "../../lib/fsharp" `
    | Set-Content dice.rs
if (!$fast) {
    Copy-Item $targetDir/ts/dice.ts dice.ts -Force
    Copy-Item $targetDir/py/dice.py dice.py -Force
    Copy-Item $targetDir/php/dice.php dice.php -Force
    Copy-Item $targetDir/dart/dice.dart dice.dart -Force
}

{ dotnet fable $targetDir/dice.fsproj --optimize --lang rs --extension .rs --outDir $targetDir/rs --define WASM } | Invoke-Block

Copy-Item $targetDir/rs/lib/fsharp/Common.rs ../../lib/fsharp/CommonWasm.rs -Force

(Get-Content $targetDir/rs/dice.rs) `
    -replace "../../../../lib/fsharp", "../../lib/fsharp" `
    -replace "/Common.rs", "/CommonWasm.rs" `
    | Set-Content dice_wasm.rs

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

{ pwsh ./contract/build.ps1 -fast 1 } | Invoke-Block

{ pwsh ./contract/tests/build.ps1 } | Invoke-Block

{ pwsh ./ui/build.ps1 -fast $($fast ?? '') } | Invoke-Block

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
