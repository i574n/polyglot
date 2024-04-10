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

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
Invoke-Dib Builder.dib -EnvironmentVariables @{ "ARGS" = "Builder.fs $runtime --packages Argu FSharp.Control.AsyncSeq System.CommandLine System.Reactive.Linq --modules lib/spiral/common.fsx lib/spiral/sm.fsx lib/spiral/date_time.fsx lib/spiral/file_system.fsx lib/spiral/trace.fsx lib/spiral/lib.fsx lib/fsharp/Common.fs lib/fsharp/CommonFSharp.fs lib/fsharp/Async.fs lib/fsharp/AsyncSeq.fs lib/fsharp/Runtime.fs lib/fsharp/FileSystem.fs" }
