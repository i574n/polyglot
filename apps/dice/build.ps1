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

{ . ../builder/target/bin/Release/net8.0/Builder$(GetExecutableSuffix) Dice.fs } | Invoke-Block
