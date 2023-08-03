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

{ . ../builder/target/bin/Release/net8.0/Builder$(GetExecutableSuffix) Dice.fs --modules nbs/Common.fs } | Invoke-Block

dotnet fable target/Dice.fsproj --optimize --lang rs --extension .rs

(Get-Content target/Dice.rs) `
    -replace "use fable_library_rust::Util_::randomNext;", "" `
    -replace "use fable_library_rust::System::Random;", "" `
    -replace "<Random>", "<i32>" `
    -replace "../../../nbs", "../../nbs" `
    | Set-Content target/Dice.rs

Copy-Item -Force target/Dice.rs Dice.rs

cargo fmt --
