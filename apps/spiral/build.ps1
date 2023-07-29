$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ dotnet repl --run Supervisor.dib --output-path Supervisor.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run ../parser/DibParser.dib --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "OUTPUT" = "Supervisor.dib" }
