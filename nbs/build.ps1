param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../scripts/core.ps1


if (!$fast) {
    { dotnet repl --run Deps.dib --exit-after-run } | Invoke-Block
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

{ . ../apps/parser/dist/DibParser$(GetExecutableSuffix) Async.dib AsyncSeq.dib Common.dib CommonFSharp.dib Threading.dib Crypto.dib FileSystem.dib Networking.dib Runtime.dib Toml.dib } | Invoke-Block
