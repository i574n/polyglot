param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


$dibParserExe = "dist/DibParser$(GetExecutableSuffix)"
if ($fast -and (Test-Path $dibParserExe)) {
    { . $dibParserExe DibParser.dib } | Invoke-Block
} else {
    { dotnet repl --run DibParser.dib --output-path DibParser.repl.ipynb --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "ARGS" = "DibParser.dib" }
}

{ . ../builder/dist/Builder$(GetExecutableSuffix) DibParser.fs --packages Argu FParsec FSharp.Control.AsyncSeq System.CommandLine System.Reactive.Linq --modules nbs/Common.fs nbs/CommonFSharp.fs nbs/Async.fs nbs/AsyncSeq.fs nbs/Runtime.fs nbs/FileSystem.fs } | Invoke-Block

if (!$fast) {
    { dotnet repl --run JsonParser.dib --output-path JsonParser.repl.ipynb --exit-after-run } | Invoke-Block
    { dotnet repl --run Parser.dib --output-path Parser.repl.ipynb --exit-after-run } | Invoke-Block
}

{ . dist/DibParser$(GetExecutableSuffix) JsonParser.dib Parser.dib } | Invoke-Block

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
