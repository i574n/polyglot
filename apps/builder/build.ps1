param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


$dibParserExe = "../parser/dist/DibParser$(GetExecutableSuffix)"
if ($fast -and (Test-Path $dibParserExe)) {
    { . $dibParserExe Builder.dib fs } | Invoke-Block
} else {
    { dotnet repl --run ../parser/DibParser.dib --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "ARGS" = "Builder.dib fs" }
}

Invoke-Dib Builder.dib -EnvironmentVariables @{ "ARGS" = "Builder.fs --packages Argu FSharp.Control.AsyncSeq System.CommandLine System.Reactive.Linq --modules nbs/Common.fs nbs/CommonFSharp.fs nbs/Async.fs nbs/AsyncSeq.fs nbs/Runtime.fs nbs/FileSystem.fs" }

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
