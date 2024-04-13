param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../lib/spiral/lib.ps1


if (!$fast) {
    Invoke-Dib DirTreeHtml.dib
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) DirTreeHtml.dib fs } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("DirTreeHtml.fs", $runtime, "--packages", "Argu", "Falco.Markup", "FSharp.Control.AsyncSeq", "FSharp.Json", "System.CommandLine", "System.Reactive.Linq", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs", "lib/fsharp/CommonFSharp.fs", "lib/fsharp/Async.fs", "lib/fsharp/AsyncSeq.fs", "lib/fsharp/Runtime.fs", "lib/fsharp/FileSystem.fs")
{ . ../builder/dist/Builder$(GetExecutableSuffix) @builderArgs } | Invoke-Block
