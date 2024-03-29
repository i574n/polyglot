param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    { . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../scripts/invoke-dib.ps1 math.dib`"" } | Invoke-Block -Retries ($fast -or !($env:CI) ? 1 : 3)
}

{ . ../../apps/parser/dist/DibParser$(GetExecutableSuffix) math.dib spi } | Invoke-Block

{ . ../../apps/spiral/dist/Supervisor$(GetExecutableSuffix) --build-file math.spi math.fsx --timeout 60000 } | Invoke-Block

{ . ../../apps/builder/dist/Builder$(GetExecutableSuffix) math.fsx $($fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Fable.Core --modules lib/fsharp/Common.fs } | Invoke-Block

$targetDir = "../../target/polyglot/builder/math"

{ dotnet fable $targetDir/math.fsproj --optimize --lang rs --extension .rs --outDir $targetDir/rs } | Invoke-Block


Copy-Item $targetDir/rs/lib/fsharp/Common.rs ../../lib/fsharp/Common.rs -Force

(Get-Content $targetDir/rs/math.rs) `
    -replace "../../../lib/fsharp", "../lib/fsharp" `
    | Set-Content math.rs

cargo fmt --

{ cargo test --release } | Invoke-Block

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
