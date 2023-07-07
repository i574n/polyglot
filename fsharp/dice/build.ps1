$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ dotnet run -c Release | Tee-Object dice.ans } | Invoke-Block

# { dotnet repl --run dice.dib --output-path dice.repl.ipynb --exit-after-run } | Invoke-Block
