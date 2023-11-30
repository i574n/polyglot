param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


if (!$fast) {
    { . ../../spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../../scripts/invoke-dib.ps1 dice_fsharp.dib`"" } | Invoke-Block -Retries 5
}

{ . ../../parser/dist/DibParser$(GetExecutableSuffix) dice_fsharp.dib fs } | Invoke-Block

{ . ../../builder/dist/Builder$(GetExecutableSuffix) dice_fsharp.fs $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Fable.Core --modules lib/fsharp/Common.fs } | Invoke-Block

$targetDir = "../../../target/polyglot/builder/dice_fsharp"

{ dotnet fable $targetDir/dice_fsharp.fsproj --optimize --lang rs --extension .rs --outDir $targetDir/rs } | Invoke-Block
if (!$fast) {
    { dotnet fable $targetDir/dice_fsharp.fsproj --optimize --lang ts --extension .ts --outDir $targetDir/ts } | Invoke-Block
    { dotnet fable $targetDir/dice_fsharp.fsproj --optimize --lang py --extension .py --outDir $targetDir/py } | Invoke-Block
    { dotnet fable $targetDir/dice_fsharp.fsproj --optimize --lang php --extension .php --outDir $targetDir/php } | Invoke-Block -OnError Continue
    { dotnet fable $targetDir/dice_fsharp.fsproj --optimize --lang dart --extension .dart --outDir $targetDir/dart } | Invoke-Block -OnError Continue
}

Copy-Item $targetDir/rs/lib/fsharp/Common.rs ../../../lib/fsharp/Common.rs -Force
if (!$fast) {
    Copy-Item $targetDir/ts/lib/fsharp/Common.ts ../../../lib/fsharp/Common.ts -Force
    Copy-Item $targetDir/py/lib/fsharp/common.py ../../../lib/fsharp/common.py -Force
    Copy-Item $targetDir/php/lib/fsharp/Common.php ../../../lib/fsharp/Common.php -Force
    Copy-Item $targetDir/dart/lib/fsharp/Common.dart ../../../lib/fsharp/Common.dart -Force
}

(Get-Content $targetDir/rs/dice_fsharp.rs) `
    -replace "../../../../lib/fsharp", "../../../lib/fsharp" `
    | Set-Content dice_fsharp.rs
if (!$fast) {
    Copy-Item $targetDir/ts/dice_fsharp.ts dice_fsharp.ts -Force
    Copy-Item $targetDir/py/dice_fsharp.py dice_fsharp.py -Force
    Copy-Item $targetDir/php/dice_fsharp.php dice_fsharp.php -Force
    Copy-Item $targetDir/dart/dice_fsharp.dart dice_fsharp.dart -Force
}

{ dotnet fable $targetDir/dice_fsharp.fsproj --optimize --lang rs --extension .rs --outDir $targetDir/rs --define WASM } | Invoke-Block

Copy-Item $targetDir/rs/lib/fsharp/Common.rs ../../lib/fsharp/CommonWasm.rs -Force

(Get-Content $targetDir/rs/dice_fsharp.rs) `
    -replace "../../../../lib/fsharp", "../../../lib/fsharp" `
    -replace "/Common.rs", "/CommonWasm.rs" `
    | Set-Content dice_wasm_fsharp.rs

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
