$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ dotnet repl --run ../parser/DibParser.dib --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "OUTPUT" = "Builder.dib" }
{ dotnet repl --run Builder.dib --output-path Builder.repl.ipynb --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "OUTPUT" = "Builder.fs" }
