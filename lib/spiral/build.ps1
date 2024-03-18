param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 testing.dib`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 common.dib`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 console.dib`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 math.dib`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"optionm'.dib\`"`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"am'.dib\`"`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"sm'.dib\`"`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 \`"listm'.dib\`"`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 benchmark.dib`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 stream.dib`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 seq.dib`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 util.dib`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 rust.dib`"" } | Invoke-Block -Retries 5
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 physics.dib`"" } | Invoke-Block -Retries 5
}

{ . ../../apps/parser/dist/DibParser$(GetExecutableSuffix) testing.dib spi common.dib spi console.dib spi math.dib spi "optionm'.dib" spi "am'.dib" spi "sm'.dib" spi "listm'.dib" spi benchmark.dib spi stream.dib spi seq.dib spi util.dib spi rust.dib spi physics.dib spi } | Invoke-Block
