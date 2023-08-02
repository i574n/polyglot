param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ dotnet repl --run build.dib --output-path build.repl.ipynb --exit-after-run } | Invoke-Block
