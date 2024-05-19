param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { . ../spiral/dist/Supervisor$(_exe) --execute-command "../../workspace/target/release/spiral_builder$(_exe) dib --path Perf.dib --retries 3" } | Invoke-Block
}

{ . ../parser/dist/DibParser$(_exe) Perf.dib fs } | Invoke-Block
