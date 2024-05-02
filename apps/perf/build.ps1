param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { . ../spiral/dist/Supervisor$(_exe) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 Perf.dib`"" } | Invoke-Block -Retries 3
}

{ . ../parser/dist/DibParser$(_exe) Perf.dib fs } | Invoke-Block
