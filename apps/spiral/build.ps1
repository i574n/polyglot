param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    Invoke-Dib Supervisor.dib -Retries 3
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) Supervisor.dib fs Tasks.dib spi } | Invoke-Block

{ . ../builder/dist/Builder$(GetExecutableSuffix) Supervisor.fs $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Argu FSharp.Control.AsyncSeq FSharp.Json Microsoft.AspNetCore.SignalR.Client System.CommandLine System.Reactive.Linq --modules nbs/Common.fs nbs/CommonFSharp.fs nbs/Threading.fs nbs/Async.fs nbs/AsyncSeq.fs nbs/Networking.fs nbs/Runtime.fs nbs/FileSystem.fs } | Invoke-Block

if (!$fast) {
    { . ./dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 Tasks.dib -Retries 3`"" } | Invoke-Block
}

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
