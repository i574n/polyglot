param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


if (!$fast) {
    { . ../../spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../../scripts/invoke-dib.ps1 dice_fsharp.dib`"" } | Invoke-Block -Retries 5
}

{ . ../../parser/dist/DibParser$(GetExecutableSuffix) dice_fsharp.dib fs } | Invoke-Block

{ . ../../builder/dist/Builder$(GetExecutableSuffix) dice_fsharp.fs $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Fable.Core --modules lib/fsharp/Common.fs } | Invoke-Block

{ dotnet fable target/dice_fsharp.fsproj --optimize --lang rs --extension .rs --outDir target/rs } | Invoke-Block
if (!$fast) {
    { dotnet fable target/dice_fsharp.fsproj --optimize --lang ts --extension .ts --outDir target/ts } | Invoke-Block
    { dotnet fable target/dice_fsharp.fsproj --optimize --lang py --extension .py --outDir target/py } | Invoke-Block
    { dotnet fable target/dice_fsharp.fsproj --optimize --lang php --extension .php --outDir target/php } | Invoke-Block -OnError Continue
    { dotnet fable target/dice_fsharp.fsproj --optimize --lang dart --extension .dart --outDir target/dart } | Invoke-Block -OnError Continue
}

Copy-Item -Force target/rs/lib/fsharp/Common.rs ../../../lib/fsharp/Common.rs
if (!$fast) {
    Copy-Item -Force target/ts/lib/fsharp/Common.ts ../../../lib/fsharp/Common.ts
    Copy-Item -Force target/py/lib/fsharp/common.py ../../../lib/fsharp/common.py
    Copy-Item -Force target/php/lib/fsharp/Common.php ../../../lib/fsharp/Common.php
    Copy-Item -Force target/dart/lib/fsharp/Common.dart ../../../lib/fsharp/Common.dart
}

(Get-Content target/rs/dice_fsharp.rs) `
    -replace "../../../../lib/fsharp", "../../../lib/fsharp" `
    | Set-Content dice_fsharp.rs
if (!$fast) {
    Copy-Item -Force target/ts/dice_fsharp.ts dice_fsharp.ts
    Copy-Item -Force target/py/dice_fsharp.py dice_fsharp.py
    Copy-Item -Force target/php/dice_fsharp.php dice_fsharp.php
    Copy-Item -Force target/dart/dice_fsharp.dart dice_fsharp.dart
}

{ dotnet fable target/dice_fsharp.fsproj --optimize --lang rs --extension .rs --outDir target/rs --define CHAIN } | Invoke-Block

Copy-Item -Force target/rs/lib/fsharp/Common.rs ../../lib/fsharp/CommonChain.rs

(Get-Content target/rs/dice_fsharp.rs) `
    -replace "../../../../lib/fsharp", "../../../lib/fsharp" `
    -replace "/Common.rs", "/CommonChain.rs" `
    | Set-Content dice_chain_fsharp.rs

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
