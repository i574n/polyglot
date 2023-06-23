Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ./core.ps1


{ . "$PSScriptRoot/spiral/clr/build.ps1" } | Invoke-Block
{ . "$PSScriptRoot/spiral/extension/build.ps1" } | Invoke-Block
# { . "$PSScriptRoot/spiral/cli/build.ps1" } | Invoke-Block
{ . "$PSScriptRoot/spiral/test/build.ps1" } | Invoke-Block
{ . "$PSScriptRoot/fsharp/dice/build.ps1" } | Invoke-Block
{ . "$PSScriptRoot/fsharp/perf/build.ps1" } | Invoke-Block
