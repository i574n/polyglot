param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { dotnet run -c Release } | Invoke-Block

    Invoke-Dib Dice.dib
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) Dice.dib } | Invoke-Block

{ . ../builder/dist/Builder$(GetExecutableSuffix) Dice.fs --packages Fable.Core --modules nbs/Common.fs } | Invoke-Block

{ dotnet fable target/Dice.fsproj --optimize --lang rs --extension .rs --outDir target/rs } | Invoke-Block
if (!$fast) {
    { dotnet fable target/Dice.fsproj --optimize --lang ts --extension .ts --outDir target/ts } | Invoke-Block
    { dotnet fable target/Dice.fsproj --optimize --lang py --extension .py --outDir target/py } | Invoke-Block
    { dotnet fable target/Dice.fsproj --optimize --lang php --extension .php --outDir target/php } | Invoke-Block -OnError Continue
    { dotnet fable target/Dice.fsproj --optimize --lang dart --extension .dart --outDir target/dart } | Invoke-Block -OnError Continue
}

Copy-Item -Force target/rs/nbs/Common.rs ../../nbs/Common.rs
if (!$fast) {
    Copy-Item -Force target/ts/nbs/Common.ts ../../nbs/Common.ts
    Copy-Item -Force target/py/nbs/common.py ../../nbs/common.py
    Copy-Item -Force target/php/nbs/Common.php ../../nbs/Common.php
    Copy-Item -Force target/dart/nbs/Common.dart ../../nbs/Common.dart
}

(Get-Content target/rs/Dice.rs) `
    -replace "../../../nbs", "../../nbs" `
    | Set-Content Dice.rs
if (!$fast) {
    Copy-Item -Force target/ts/Dice.ts Dice.ts
    Copy-Item -Force target/py/dice.py dice.py
    Copy-Item -Force target/php/Dice.php Dice.php
    Copy-Item -Force target/dart/Dice.dart Dice.dart
}

{ dotnet fable target/Dice.fsproj --optimize --lang rs --extension .rs --outDir target/rs --define CHAIN } | Invoke-Block

Copy-Item -Force target/rs/nbs/Common.rs ../../nbs/CommonChain.rs

(Get-Content target/rs/Dice.rs) `
    -replace "../../../nbs", "../../nbs" `
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
