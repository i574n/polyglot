param(
    $fast,
    $SkipNotebook,
    $SkipFsx,
    $SkipPreBuild,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1
. ../../../lib/spiral/lib.ps1


$projectName = "cube"

if (!$SkipPreBuild -and !$SkipFsx) {
    if (!$SkipNotebook) {
        { . ../dist/Supervisor$(_exe) --execute-command "../../../workspace/target/release/spiral_builder$(_exe) dib --path $projectName.dib" } | Invoke-Block -Retries 3
    }

    # { . ../../parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block

    # { . ../dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" } | Invoke-Block
}

if (!$fast) {
    { pwsh ./extension/build.ps1 } | Invoke-Block

    { pwsh ./test/build.ps1 } | Invoke-Block
}
