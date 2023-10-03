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

{ . ../builder/dist/Builder$(GetExecutableSuffix) DibParser.fs $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Argu FParsec FSharp.Control.AsyncSeq System.CommandLine System.Reactive.Linq --modules nbs/Common.fs nbs/CommonFSharp.fs nbs/Async.fs nbs/AsyncSeq.fs nbs/Runtime.fs nbs/FileSystem.fs } | Invoke-Block

if (!$fast) {
    Invoke-Dib JsonParser.dib
    Invoke-Dib Parser.dib
}

{ . dist/DibParser$(GetExecutableSuffix) JsonParser.dib fs Parser.dib fs } | Invoke-Block

if ($env:CI) {
    Remove-Item ./target -Recurse -Force -ErrorAction Ignore
}
