param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


$targetDir = "../../target/polyglot/builder/Supervisor"

if (!$fast) {
    { . ../spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 Tasks.dib -Retries 3`"" } | Invoke-Block

    { . ../parser/dist/DibParser$(GetExecutableSuffix) Tasks.dib spi } | Invoke-Block
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
