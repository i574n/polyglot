param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    Invoke-Dib Supervisor.dib
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) Supervisor.dib } | Invoke-Block

{ . ../builder/dist/Builder$(GetExecutableSuffix) Supervisor.fs --packages Argu FSharp.Control.AsyncSeq FSharp.Json NetMQ System.CommandLine System.Reactive.Linq --modules nbs/Common.fs nbs/CommonFSharp.fs nbs/Async.fs nbs/AsyncSeq.fs nbs/Networking.fs nbs/Runtime.fs nbs/FileSystem.fs } | Invoke-Block

if (!$fast) {
    Invoke-Dib Spiral.dib
    Invoke-Dib Physics.dib
    Invoke-Dib Tasks.dib
}

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
