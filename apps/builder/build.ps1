param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../lib/spiral/lib.ps1


$dibParserExe = "../parser/dist/DibParser$(_exe)"
if (!(Test-Path $dibParserExe)) {
    pwsh ../parser/build.ps1 -fast 1

}
{ . $dibParserExe Builder.dib fs } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("Builder.fs", [String]::Join(" ", $runtime), "--packages", "Argu", "FSharp.Control.AsyncSeq", "System.CommandLine", "System.Reactive.Linq", "--modules", [String]::Join(" ", $(GetFsxModules)), "lib/fsharp/Common.fs", "lib/fsharp/CommonFSharp.fs", "lib/fsharp/Async.fs", "lib/fsharp/AsyncSeq.fs", "lib/fsharp/Runtime.fs", "lib/fsharp/FileSystem.fs")
Invoke-Dib Builder.dib -EnvironmentVariables @{ "ARGS" = [String]::Join(" ", $builderArgs) }
