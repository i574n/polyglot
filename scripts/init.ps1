$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


dotnet tool restore
dotnet paket restore

{ . "$ScriptDir/symlinks.ps1" } | Invoke-Block
{ . "$ScriptDir/dep_dotnet-repl.ps1" } | Invoke-Block
{ dotnet repl --run "$ScriptDir/init.dib" --output-path "$ScriptDir/init.repl.ipynb" --exit-after-run } | Invoke-Block
