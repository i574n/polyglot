param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


$dibParserExe = "dist/DibParser$(GetExecutableSuffix)"
if ($fast -and (Test-Path $dibParserExe)) {
    { . $dibParserExe DibParser.dib fs } | Invoke-Block
} else {
    Invoke-Dib DibParser.dib -EnvironmentVariables @{ "ARGS" = "DibParser.dib fs" }
}

{ . ../builder/dist/Builder$(GetExecutableSuffix) DibParser.fs $($fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Argu FParsec FSharp.Control.AsyncSeq System.CommandLine System.Reactive.Linq --modules lib/fsharp/Common.fs lib/fsharp/CommonFSharp.fs lib/fsharp/Async.fs lib/fsharp/AsyncSeq.fs lib/fsharp/Runtime.fs lib/fsharp/FileSystem.fs } | Invoke-Block

if (!$fast) {
    Invoke-Dib JsonParser.dib
    Invoke-Dib Parser.dib
}

{ . dist/DibParser$(GetExecutableSuffix) JsonParser.dib fs Parser.dib fs } | Invoke-Block
