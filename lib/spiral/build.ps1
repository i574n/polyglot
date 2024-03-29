param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 testing.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 guid.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 common.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 console.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 date_time.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 math.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"optionm'.dib\`"`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"am'.dib\`"`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"sm'.dib\`"`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"listm'.dib\`"`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 benchmark.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 stream.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 seq.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 util.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 file_system.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 rust.dib`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 physics.dib`"" `
    } | Invoke-Block -Retries 3
}

{ . ../../apps/parser/dist/DibParser$(GetExecutableSuffix) testing.dib spi common.dib spi console.dib spi date_time.dib spi file_system.dib spi guid.dib spi math.dib spi "optionm'.dib" spi "am'.dib" spi "sm'.dib" spi "listm'.dib" spi benchmark.dib spi stream.dib spi seq.dib spi util.dib spi rust.dib spi physics.dib spi } | Invoke-Block

{ . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --build-file common.spi common.fsx --build-file date_time.spi date_time.fsx --build-file file_system.spi file_system.fsx --build-file guid.spi guid.fsx --timeout 60000 } | Invoke-Block -Retries 1
