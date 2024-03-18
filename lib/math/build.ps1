param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 math.dib`"" } | Invoke-Block -Retries 5
}

{ . ../../apps/parser/dist/DibParser$(GetExecutableSuffix) math.dib spi } | Invoke-Block

{ cargo test --release } | Invoke-Block
