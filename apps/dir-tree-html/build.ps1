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

{ . ../parser/target/bin/Release/net8.0/DibParser$(GetExecutableSuffix) DirTreeHtml.dib } | Invoke-Block

{ . ../builder/target/bin/Release/net8.0/Builder$(GetExecutableSuffix) DirTreeHtml.fs --packages Argu FSharp.Control.AsyncSeq FSharp.Json System.CommandLine System.Reactive.Linq --modules nbs/Common.fs nbs/CommonFSharp.fs nbs/Async.fs nbs/AsyncSeq.fs nbs/Networking.fs nbs/Runtime.fs nbs/FileSystem.fs } | Invoke-Block
