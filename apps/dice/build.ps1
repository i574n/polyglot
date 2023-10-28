param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { dotnet run -c Release } | Invoke-Block

    { . ../spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 Dice.dib`"" } | Invoke-Block -Retries 5
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) Dice.dib fs Dice.dib spi } | Invoke-Block

{ . ../builder/dist/Builder$(GetExecutableSuffix) Dice.fs $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Fable.Core --modules lib/fsharp/Common.fs } | Invoke-Block

{ dotnet fable target/Dice.fsproj --optimize --lang rs --extension .rs --outDir target/rs } | Invoke-Block
if (!$fast) {
    { dotnet fable target/Dice.fsproj --optimize --lang ts --extension .ts --outDir target/ts } | Invoke-Block
    { dotnet fable target/Dice.fsproj --optimize --lang py --extension .py --outDir target/py } | Invoke-Block
    { dotnet fable target/Dice.fsproj --optimize --lang php --extension .php --outDir target/php } | Invoke-Block -OnError Continue
    { dotnet fable target/Dice.fsproj --optimize --lang dart --extension .dart --outDir target/dart } | Invoke-Block -OnError Continue
}

Copy-Item -Force target/rs/lib/fsharp/Common.rs ../../lib/fsharp/Common.rs
if (!$fast) {
    Copy-Item -Force target/ts/lib/fsharp/Common.ts ../../lib/fsharp/Common.ts
    Copy-Item -Force target/py/lib/fsharp/common.py ../../lib/fsharp/common.py
    Copy-Item -Force target/php/lib/fsharp/Common.php ../../lib/fsharp/Common.php
    Copy-Item -Force target/dart/lib/fsharp/Common.dart ../../lib/fsharp/Common.dart
}

(Get-Content target/rs/Dice.rs) `
    -replace "../../../lib/fsharp", "../../lib/fsharp" `
    | Set-Content Dice.rs
if (!$fast) {
    Copy-Item -Force target/ts/Dice.ts Dice.ts
    Copy-Item -Force target/py/dice.py dice.py
    Copy-Item -Force target/php/Dice.php Dice.php
    Copy-Item -Force target/dart/Dice.dart Dice.dart
}

{ dotnet fable target/Dice.fsproj --optimize --lang rs --extension .rs --outDir target/rs --define CHAIN } | Invoke-Block

Copy-Item -Force target/rs/lib/fsharp/Common.rs ../../lib/fsharp/CommonChain.rs

(Get-Content target/rs/Dice.rs) `
    -replace "../../../lib/fsharp", "../../lib/fsharp" `
    -replace "/Common.rs", "/CommonChain.rs" `
    | Set-Content DiceChain.rs

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

{ pwsh ./contract/build.ps1 -fast 1 } | Invoke-Block

{ pwsh ./tests/build.ps1 } | Invoke-Block

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
