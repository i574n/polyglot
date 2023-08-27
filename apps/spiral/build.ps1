param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { dotnet repl --run Supervisor.dib --output-path Supervisor.repl.ipynb --exit-after-run } | Invoke-Block
}

{ . ../parser/target/bin/Release/net8.0/DibParser$(GetExecutableSuffix) Supervisor.dib } | Invoke-Block

{ . ../builder/target/bin/Release/net8.0/Builder$(GetExecutableSuffix) Supervisor.fs --packages Argu FSharp.Control.AsyncSeq FSharp.Json NetMQ System.CommandLine System.Reactive.Linq --modules nbs/Common.fs nbs/CommonFSharp.fs nbs/Async.fs nbs/AsyncSeq.fs nbs/Networking.fs nbs/Runtime.fs nbs/FileSystem.fs } | Invoke-Block

if (!$fast) {
    { dotnet repl --run Spiral.dib --output-path Spiral.repl.ipynb --exit-after-run } | Invoke-Block
    { dotnet repl --run Physics.dib --output-path Physics.repl.ipynb --exit-after-run } | Invoke-Block
    # { dotnet repl --run Tasks.dib --output-path Tasks.repl.ipynb --exit-after-run } | Invoke-Block
}
