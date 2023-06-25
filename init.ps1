$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


dotnet tool restore
dotnet paket restore

{ dotnet repl --run init.dib --output-path init.repl.ipynb --exit-after-run } | Invoke-Block
