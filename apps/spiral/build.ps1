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

{ . ../builder/dist/Builder$(GetExecutableSuffix) Supervisor.fs $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Argu FSharp.Control.AsyncSeq FSharp.Json Microsoft.AspNetCore.SignalR.Client System.CommandLine System.Reactive.Linq --modules lib/fsharp/Common.fs lib/fsharp/CommonFSharp.fs lib/fsharp/Threading.fs lib/fsharp/Async.fs lib/fsharp/AsyncSeq.fs lib/fsharp/Networking.fs lib/fsharp/Runtime.fs lib/fsharp/FileSystem.fs } | Invoke-Block

if (!$fast) {
    { . ./dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 Tasks.dib -Retries 3`"" } | Invoke-Block

    { . ../parser/dist/DibParser$(GetExecutableSuffix) Tasks.dib spi } | Invoke-Block
}

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
