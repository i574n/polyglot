$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ dotnet repl --run Supervisor.dib --output-path Supervisor.repl.ipynb --exit-after-run } | Invoke-Block
{ . "../parser/target/bin/Release/net8.0/DibParser$(if ($IsWindows) { '.exe' } else { '' })" "Supervisor.dib" } | Invoke-Block
