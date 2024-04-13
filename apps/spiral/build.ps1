param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../lib/spiral/lib.ps1


if (!$fast) {
    Invoke-Dib Supervisor.dib -Retries 3
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) Supervisor.dib fs } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("Supervisor.fs", $runtime, "--packages", "Argu", "FSharp.Control.AsyncSeq", "FSharp.Json", "Microsoft.AspNetCore.SignalR.Client", "System.CommandLine", "System.Reactive.Linq", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs", "lib/fsharp/CommonFSharp.fs", "lib/fsharp/Async.fs", "lib/fsharp/AsyncSeq.fs", "lib/fsharp/Runtime.fs", "lib/fsharp/FileSystem.fs")
{ . ../builder/dist/Builder$(GetExecutableSuffix) @builderArgs } | Invoke-Block

if (!$fast) {
    Invoke-Dib Eval.dib -Retries 3
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) Eval.dib fs } | Invoke-Block
