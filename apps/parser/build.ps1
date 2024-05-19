param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../lib/spiral/lib.ps1


$dibParserExe = "dist/DibParser$(_exe)"
if ($fast -and (Test-Path $dibParserExe)) {
    { . $dibParserExe DibParser.dib fs } | Invoke-Block
} else {
    { . ../../workspace/target/release/spiral_builder$(_exe) dib --path DibParser.dib } | Invoke-Block -EnvironmentVariables @{ "ARGS" = "DibParser.dib fs" }
}

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("DibParser.fs", $runtime, "--packages", "Argu", "FParsec", "FSharp.Control.AsyncSeq", "System.Reactive.Linq", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs", "lib/fsharp/CommonFSharp.fs", "lib/fsharp/Async.fs", "lib/fsharp/AsyncSeq.fs", "lib/fsharp/Runtime.fs", "lib/fsharp/FileSystem.fs")
{ . ../builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

if (!$fast) {
    { . ../../workspace/target/release/spiral_builder$(_exe) dib --path JsonParser.dib } | Invoke-Block
    { . ../../workspace/target/release/spiral_builder$(_exe) dib --path Parser.dib } | Invoke-Block
}

{ . dist/DibParser$(_exe) JsonParser.dib fs Parser.dib fs } | Invoke-Block
