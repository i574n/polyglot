$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ dotnet repl --run parser.dib --output-path parser.repl.ipynb --exit-after-run } | Invoke-Block
