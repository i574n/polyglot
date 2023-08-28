param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


$dibParserExe = "../parser/target/dist/DibParser$(GetExecutableSuffix)"
if ($fast -and (Test-Path $dibParserExe)) {
    { . $dibParserExe Builder.dib } | Invoke-Block
} else {
    { dotnet repl --run ../parser/DibParser.dib --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "ARGS" = "Builder.dib" }
}

{ dotnet repl --run Builder.dib --output-path Builder.repl.ipynb --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "ARGS" = "Builder.fs --packages Argu FSharp.Control.AsyncSeq System.CommandLine System.Reactive.Linq --modules nbs/Common.fs nbs/CommonFSharp.fs nbs/Async.fs nbs/AsyncSeq.fs nbs/Runtime.fs nbs/FileSystem.fs" }
