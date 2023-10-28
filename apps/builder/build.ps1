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

Invoke-Dib Builder.dib -EnvironmentVariables @{ "ARGS" = "Builder.fs --packages Argu FSharp.Control.AsyncSeq System.CommandLine System.Reactive.Linq --modules lib/fsharp/Common.fs lib/fsharp/CommonFSharp.fs lib/fsharp/Async.fs lib/fsharp/AsyncSeq.fs lib/fsharp/Runtime.fs lib/fsharp/FileSystem.fs" }

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
