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

{ . ../parser/dist/DibParser$(GetExecutableSuffix) Supervisor.dib fs } | Invoke-Block

{ . ../builder/dist/Builder$(GetExecutableSuffix) Supervisor.fs $($fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Argu FSharp.Control.AsyncSeq FSharp.Json Microsoft.AspNetCore.SignalR.Client System.CommandLine System.Reactive.Linq --modules lib/spiral/common.fsx lib/spiral/date_time.fsx lib/spiral/file_system.fsx lib/fsharp/Common.fs lib/fsharp/CommonFSharp.fs lib/fsharp/Threading.fs lib/fsharp/Async.fs lib/fsharp/AsyncSeq.fs lib/fsharp/Networking.fs lib/fsharp/Runtime.fs lib/fsharp/FileSystem.fs } | Invoke-Block

if (!$fast) {
    Invoke-Dib Eval.dib -Retries 3
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) Eval.dib fs } | Invoke-Block
