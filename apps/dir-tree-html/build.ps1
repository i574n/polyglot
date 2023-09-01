param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { dotnet repl --run DirTreeHtml.dib --output-path DirTreeHtml.repl.ipynb --exit-after-run } | Invoke-Block
}

{ . ../parser/target/dist/DibParser$(GetExecutableSuffix) DirTreeHtml.dib } | Invoke-Block

{ . ../builder/target/dist/Builder$(GetExecutableSuffix) DirTreeHtml.fs $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Argu Feliz.ViewEngine FSharp.Control.AsyncSeq FSharp.Json System.CommandLine System.Reactive.Linq --modules nbs/Common.fs nbs/CommonFSharp.fs nbs/Async.fs nbs/AsyncSeq.fs nbs/Networking.fs nbs/Runtime.fs nbs/FileSystem.fs } | Invoke-Block
