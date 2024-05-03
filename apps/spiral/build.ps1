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

{ . ../parser/dist/DibParser$(_exe) Supervisor.dib fs } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("Supervisor.fs", $runtime, "--packages", "Argu", "FSharp.Control.AsyncSeq", "FSharp.Json", "Microsoft.AspNetCore.SignalR.Client", "System.Reactive.Linq", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs", "lib/fsharp/CommonFSharp.fs", "lib/fsharp/Async.fs", "lib/fsharp/AsyncSeq.fs", "lib/fsharp/Runtime.fs", "lib/fsharp/FileSystem.fs")
{ . ../builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

if (!$fast) {
    Invoke-Dib Eval.dib -Retries 3
}

{ . ../parser/dist/DibParser$(_exe) Eval.dib fs } | Invoke-Block

$builderArgs = @("Eval.fs", $runtime, "--packages", "Argu", "FSharp.Control.AsyncSeq", "FSharp.Json", "Microsoft.AspNetCore.SignalR.Client", "System.Reactive.Linq", "System.Management", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs", "lib/fsharp/CommonFSharp.fs", "lib/fsharp/Async.fs", "lib/fsharp/AsyncSeq.fs", "lib/fsharp/Runtime.fs", "lib/fsharp/FileSystem.fs", "apps/builder/Builder.fs", "apps/spiral/Supervisor.fs")
{ . ../builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block
