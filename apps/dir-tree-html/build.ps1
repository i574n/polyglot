param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../lib/spiral/lib.ps1


if (!$fast) {
    { . ../spiral/dist/Supervisor$(_exe) --execute-command "../../target/release/spiral_builder$(_exe) dib --path DirTreeHtml.dib" } | Invoke-Block

    Get-Content ../../lib/spiral/networking.fsx | Write-Output
}

{ . ../parser/dist/DibParser$(_exe) DirTreeHtml.dib fs } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("DirTreeHtml.fs", $runtime, "--packages", "Argu", "Falco.Markup", "FSharp.Control.AsyncSeq", "FSharp.Json", "System.Reactive.Linq", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs", "lib/fsharp/CommonFSharp.fs", "lib/fsharp/Async.fs", "lib/fsharp/AsyncSeq.fs", "lib/fsharp/Runtime.fs", "lib/fsharp/FileSystem.fs")
{ . ../builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block
