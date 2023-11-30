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

Copy-Item -Force $targetDir/rs/lib/fsharp/Common.rs ../../../lib/fsharp/Common.rs
if (!$fast) {
    Copy-Item -Force $targetDir/ts/lib/fsharp/Common.ts ../../../lib/fsharp/Common.ts
    Copy-Item -Force $targetDir/py/lib/fsharp/common.py ../../../lib/fsharp/common.py
    Copy-Item -Force $targetDir/php/lib/fsharp/Common.php ../../../lib/fsharp/Common.php
    Copy-Item -Force $targetDir/dart/lib/fsharp/Common.dart ../../../lib/fsharp/Common.dart
}

(Get-Content $targetDir/rs/dice_fsharp.rs) `
    -replace "../../../../lib/fsharp", "../../../lib/fsharp" `
    | Set-Content dice_fsharp.rs
if (!$fast) {
    Copy-Item -Force $targetDir/ts/dice_fsharp.ts dice_fsharp.ts
    Copy-Item -Force $targetDir/py/dice_fsharp.py dice_fsharp.py
    Copy-Item -Force $targetDir/php/dice_fsharp.php dice_fsharp.php
    Copy-Item -Force $targetDir/dart/dice_fsharp.dart dice_fsharp.dart
}

{ dotnet fable $targetDir/dice_fsharp.fsproj --optimize --lang rs --extension .rs --outDir $targetDir/rs --define WASM } | Invoke-Block

Copy-Item -Force $targetDir/rs/lib/fsharp/Common.rs ../../lib/fsharp/CommonWasm.rs

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
