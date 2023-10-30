param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { . ./fsharp/build.ps1 } | Invoke-Block -Location .

    { dotnet run --configuration Release --project temp/dice.fsproj } | Invoke-Block

    { . ../spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 dice.dib`"" } | Invoke-Block -Retries 5
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) dice.dib spi } | Invoke-Block

{ . ../spiral/dist/Supervisor$(GetExecutableSuffix) --buildfile dice.spi dice.fsx --timeout 10000 } | Invoke-Block

{ . ../builder/dist/Builder$(GetExecutableSuffix) dice.fsx $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Fable.Core --modules lib/fsharp/Common.fs } | Invoke-Block

{ dotnet fable target/dice.fsproj --optimize --lang rs --extension .rs --outDir target/rs } | Invoke-Block

if (!$fast) {
    { dotnet fable target/dice.fsproj --optimize --lang ts --extension .ts --outDir target/ts } | Invoke-Block
    { dotnet fable target/dice.fsproj --optimize --lang py --extension .py --outDir target/py } | Invoke-Block
    { dotnet fable target/dice.fsproj --optimize --lang php --extension .php --outDir target/php } | Invoke-Block -OnError Continue
    { dotnet fable target/dice.fsproj --optimize --lang dart --extension .dart --outDir target/dart } | Invoke-Block -OnError Continue
}

Copy-Item -Force target/rs/lib/fsharp/Common.rs ../../lib/fsharp/Common.rs
if (!$fast) {
    Copy-Item -Force target/ts/lib/fsharp/Common.ts ../../lib/fsharp/Common.ts
    Copy-Item -Force target/py/lib/fsharp/common.py ../../lib/fsharp/common.py
    Copy-Item -Force target/php/lib/fsharp/Common.php ../../lib/fsharp/Common.php
    Copy-Item -Force target/dart/lib/fsharp/Common.dart ../../lib/fsharp/Common.dart
}

(Get-Content target/rs/dice.rs) `
    -replace "../../../lib/fsharp", "../../lib/fsharp" `
    | Set-Content dice.rs
if (!$fast) {
    Copy-Item -Force target/ts/dice.ts dice.ts
    Copy-Item -Force target/py/dice.py dice.py
    Copy-Item -Force target/php/dice.php dice.php
    Copy-Item -Force target/dart/dice.dart dice.dart
}

{ dotnet fable target/dice.fsproj --optimize --lang rs --extension .rs --outDir target/rs --define WASM } | Invoke-Block

Copy-Item -Force target/rs/lib/fsharp/Common.rs ../../lib/fsharp/CommonWasm.rs

(Get-Content target/rs/dice.rs) `
    -replace "../../../lib/fsharp", "../../lib/fsharp" `
    -replace "/Common.rs", "/CommonWasm.rs" `
    | Set-Content dice_wasm.rs

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

{ pwsh ./contract/build.ps1 -fast 1 } | Invoke-Block

{ pwsh ./contract/tests/build.ps1 } | Invoke-Block

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
