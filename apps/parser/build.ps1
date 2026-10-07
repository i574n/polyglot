param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../deps/spiral/lib/spiral/lib.ps1


# The notebooks run through Kino (core.ps1 Invoke-Notebook) and export their F# modules (<nb>.fs).
foreach ($notebook in "JsonParser", "Parser") {
    if (!$fast) { Invoke-Notebook "$notebook.livemd" @("--no-spi") }
    Invoke-Notebook "$notebook.livemd" @("--no-spi", "--fs-path", "$ScriptDir/$notebook.fs", "--export-only")
}

Write-Output "polyglot/apps/parser/build.ps1 / `$env:CI:'$env:CI'"
