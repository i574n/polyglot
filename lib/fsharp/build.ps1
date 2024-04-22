param(
    $fast,
    $sequential,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { . ../../apps/spiral/dist/Supervisor$(_exe) `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 Async.dib`" -Retries 3" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 AsyncSeq.dib`" -Retries 3" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 Common.dib`" -Retries 3" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 CommonFSharp.dib`" -Retries 3" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 FileSystem.dib -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 Runtime.dib -Retries 3`"" `
        --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 Toml.dib -Retries 3`"" `
        $(!$sequential ? @("--parallel") : @()) `
    } | Invoke-Block
}

{ . ../../apps/parser/dist/DibParser$(_exe) Async.dib fs AsyncSeq.dib fs Common.dib fs CommonFSharp.dib fs FileSystem.dib fs Runtime.dib fs Toml.dib fs } | Invoke-Block
