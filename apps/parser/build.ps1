param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1
. ../../deps/spiral/lib/spiral/lib.ps1


if (!$fast) {
    { . ../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path JsonParser.dib } | Invoke-Block
    { . ../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path Parser.dib } | Invoke-Block
}

{ . ../../deps/spiral/workspace/target/release/spiral$(_exe) dib-export JsonParser.dib fs } | Invoke-Block
{ . ../../deps/spiral/workspace/target/release/spiral$(_exe) dib-export Parser.dib fs } | Invoke-Block

Write-Output "polyglot/apps/parser/build.ps1 / `$env:CI:'$env:CI'"
