$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ dotnet run -c Release } | Invoke-Block

{ dotnet repl --run Dice.dib --output-path Dice.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run ../parser/DibParser.dib --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "OUTPUT" = "Dice.dib" }
