$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ dotnet run -c Release } | Invoke-Block

{ dotnet repl --run Dice.dib --output-path Dice.repl.ipynb --exit-after-run } | Invoke-Block
{ . "../parser/target/bin/Release/net8.0/DibParser$(if ($IsWindows) { '.exe' } else { '' })" "Dice.dib" } | Invoke-Block
