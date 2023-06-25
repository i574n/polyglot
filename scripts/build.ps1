$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


{ dotnet repl --run build.dib --output-path build.repl.ipynb --exit-after-run } | Invoke-Block
