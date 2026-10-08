param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1

$livebook = Join-Path $ScriptDir "../../deps/spiral/apps/kino/spi/run_notebook.ps1"
$notebook = Join-Path $ScriptDir "Tasks.livemd"
$spi = Join-Path $ScriptDir "Tasks.spi"
if (!$fast) {
    { pwsh -NoProfile -File $livebook --path $notebook --spi-path $spi --output-path (Join-Path $ScriptDir "Tasks.livemd.ipynb") } | Invoke-Block -Retries $($env:CI ? 3 : 1)
}
else {
    { pwsh -NoProfile -File $livebook --path $notebook --spi-path $spi --export-only } | Invoke-Block
}