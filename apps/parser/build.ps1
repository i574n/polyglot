$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ dotnet repl --run DibParser.dib --output-path DibParser.repl.ipynb --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "OUTPUT" = "DibParser.dib;JsonParser.dib;Parser.dib" }

{ dotnet repl --run JsonParser.dib --output-path JsonParser.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run Parser.dib --output-path Parser.repl.ipynb --exit-after-run } | Invoke-Block
