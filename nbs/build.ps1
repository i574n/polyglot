$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../scripts/core.ps1


{ dotnet repl --run Async.dib --output-path Async.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run Common.dib --output-path Common.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run FileSystem.dib --output-path FileSystem.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run ../apps/parser/DibParser.dib --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "OUTPUT" = "Async.dib;Common.dib;FileSystem.dib" }
