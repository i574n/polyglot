param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../deps/spiral/lib/spiral/lib.ps1


if (!$fast) {
    { pwsh ../../deps/spiral/apps/compiler/build.ps1 -fast 1 } | Invoke-Block
}

# The notebooks run through Kino (core.ps1 Invoke-Notebook) and export their F# modules (<nb>.fs).
if (!$fast -and !$SkipNotebook) {
    Invoke-Notebook Supervisor.livemd @("--no-spi") -Retries 3
}

Invoke-Notebook Supervisor.livemd @("--no-spi", "--fs-path", "$ScriptDir/Supervisor.fs", "--export-only")

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("Supervisor.fs", $runtime, "--packages", "Argu", "FSharp.Control.AsyncSeq", "FSharp.Json", "Microsoft.AspNetCore.SignalR.Client", "System.Reactive.Linq", "Hopac", "FSharpx.Collections", "FParsec", "System.Management", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs", "lib/fsharp/CommonFSharp.fs", "lib/fsharp/Async.fs", "lib/fsharp/AsyncSeq.fs", "lib/fsharp/Runtime.fs", "lib/fsharp/FileSystem.fs", "deps/spiral/apps/compiler/spiral_compiler.fs")
{ . ../builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

Write-Output "polyglot/apps/spiral/build.ps1 / `$env:CI:'$env:CI'"
