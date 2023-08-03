param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { dotnet run -c Release } | Invoke-Block

    { dotnet repl --run Dice.dib --output-path Dice.repl.ipynb --exit-after-run } | Invoke-Block
}

{ . ../parser/target/bin/Release/net8.0/DibParser$(GetExecutableSuffix) Dice.dib } | Invoke-Block

{ . ../builder/target/bin/Release/net8.0/Builder$(GetExecutableSuffix) Dice.fs --packages Fable.Core --modules nbs/Common.fs } | Invoke-Block

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

cargo fmt --
