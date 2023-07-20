$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../scripts/core.ps1


{ dotnet repl --run Common.dib --output-path Common.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run Async.dib --output-path Async.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run AsyncSeq.dib --output-path AsyncSeq.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run Networking.dib --output-path Networking.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run FileSystem.dib --output-path FileSystem.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run ../apps/parser/DibParser.dib --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "OUTPUT" = "Async.dib;AsyncSeq.dib;Common.dib;FileSystem.dib;Networking.dib" }
