param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    Invoke-Dib testing.dib
    Invoke-Dib common.dib
    Invoke-Dib console.dib
    Invoke-Dib math.dib
    Invoke-Dib "optionm'.dib"
    Invoke-Dib "am'.dib"
    Invoke-Dib "listm'.dib"
    Invoke-Dib seq.dib
    Invoke-Dib util.dib
    Invoke-Dib physics.dib
}

{ . ../../apps/parser/dist/DibParser$(GetExecutableSuffix) testing.dib spi common.dib spi console.dib spi math.dib spi "optionm'.dib" spi "am'.dib" spi "listm'.dib" spi seq.dib spi util.dib spi physics.dib spi } | Invoke-Block
