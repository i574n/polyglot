param(
    $fast,
    $sequential,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 testing.dib -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 guid.dib -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 common.dib -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 console.dib -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 date_time.dib -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 math.dib -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"optionm'.dib\`" -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"am'.dib\`" -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"sm'.dib\`" -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"listm'.dib\`" -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 benchmark.dib`" -Retries 3" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 stream.dib`" -Retries 3" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 seq.dib`" -Retries 3" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 util.dib`" -Retries 3" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 file_system.dib`" -Retries 3" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 rust.dib`" -Retries 3" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 physics.dib`" -Retries 3" `
        $(!$sequential ? @("--parallel") : @()) `
    } | Invoke-Block
}

{ . ../../apps/parser/dist/DibParser$(GetExecutableSuffix) testing.dib spi common.dib spi console.dib spi date_time.dib spi file_system.dib spi guid.dib spi math.dib spi "optionm'.dib" spi "am'.dib" spi "sm'.dib" spi "listm'.dib" spi benchmark.dib spi stream.dib spi seq.dib spi util.dib spi rust.dib spi physics.dib spi } | Invoke-Block

{ . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --build-file common.spi common.fsx --build-file date_time.spi date_time.fsx --build-file file_system.spi file_system.fsx --build-file guid.spi guid.fsx --build-file "sm'.spi" sm.fsx --timeout 60000 } | Invoke-Block -Retries 3

Remove-Item "sm'.fsx" -Force -ErrorAction Ignore
