param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 testing.dib`"" } | Invoke-Block
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 common.dib`"" } | Invoke-Block
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 console.dib`"" } | Invoke-Block
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 math.dib`"" } | Invoke-Block
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 \`"optionm'.dib\`"`"" } | Invoke-Block
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 \`"am'.dib\`"`"" } | Invoke-Block
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 \`"listm'.dib\`"`"" } | Invoke-Block
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 stream.dib`"" } | Invoke-Block
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 seq.dib`"" } | Invoke-Block
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 util.dib`"" } | Invoke-Block
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --executecommand "pwsh -c `"../../scripts/invoke-dib.ps1 physics.dib`"" } | Invoke-Block
}

{ . ../../apps/parser/dist/DibParser$(GetExecutableSuffix) testing.dib spi common.dib spi console.dib spi math.dib spi "optionm'.dib" spi "am'.dib" spi "listm'.dib" spi stream.dib spi seq.dib spi util.dib spi physics.dib spi } | Invoke-Block
