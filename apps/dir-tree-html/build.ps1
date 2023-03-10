param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    Invoke-Dib DirTreeHtml.dib
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) DirTreeHtml.dib fs } | Invoke-Block

{ . ../builder/dist/Builder$(GetExecutableSuffix) DirTreeHtml.fs $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Argu Falco.Markup FSharp.Control.AsyncSeq FSharp.Json System.CommandLine System.Reactive.Linq --modules lib/fsharp/Common.fs lib/fsharp/CommonFSharp.fs lib/fsharp/Async.fs lib/fsharp/AsyncSeq.fs lib/fsharp/Networking.fs lib/fsharp/Runtime.fs lib/fsharp/FileSystem.fs } | Invoke-Block

$targetDir = "../../target/polyglot/builder/DirTreeHtml"

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
