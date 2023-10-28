param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    Invoke-Dib Async.dib
    Invoke-Dib AsyncSeq.dib
    Invoke-Dib Common.dib
    Invoke-Dib CommonFSharp.dib
    Invoke-Dib Threading.dib
    Invoke-Dib Crypto.dib
    Invoke-Dib FileSystem.dib
    Invoke-Dib Networking.dib
    Invoke-Dib Runtime.dib
    Invoke-Dib Toml.dib
}

{ . ../../apps/parser/dist/DibParser$(GetExecutableSuffix) Async.dib fs AsyncSeq.dib fs Common.dib fs CommonFSharp.dib fs Threading.dib fs Crypto.dib fs FileSystem.dib fs Networking.dib fs Runtime.dib fs Toml.dib fs } | Invoke-Block
