Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"


. "$PSScriptRoot/spiral/clr/build.ps1"
. "$PSScriptRoot/spiral/extension/build.ps1"
# . "$PSScriptRoot/spiral/cli/build.ps1"
. "$PSScriptRoot/spiral/test/build.ps1"
. "$PSScriptRoot/fsharp/dice/build.ps1"
. "$PSScriptRoot/fsharp/perf/build.ps1"
