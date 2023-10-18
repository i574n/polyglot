param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { . ../spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 Perf.dib`"" } | Invoke-Block -Retries 5
}

{ . ../parser/dist/DibParser$(GetExecutableSuffix) Perf.dib fs } | Invoke-Block
