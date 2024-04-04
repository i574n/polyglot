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

{ . ../../apps/builder/dist/Builder$(GetExecutableSuffix) math.fsx $($fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Fable.Core --modules lib/spiral/common.fsx lib/spiral/sm.fsx lib/spiral/date_time.fsx lib/spiral/file_system.fsx lib/spiral/lib.fsx lib/fsharp/Common.fs } | Invoke-Block

$targetDir = "../../target/polyglot/builder/math"

{ dotnet fable $targetDir/math.fsproj --optimize --lang rs --extension .rs --outDir $targetDir/target/rs } | Invoke-Block

function CopyTarget {
    param (
        [Parameter(Mandatory)]
        [string] $Language
    )

    Copy-Item $targetDir/target/$Language/lib/fsharp/Common.$Language ../../lib/fsharp/Common.$Language -Force
    Copy-Item $targetDir/target/$Language/lib/spiral/common.$Language ../../lib/spiral/common.$Language -Force
    Copy-Item $targetDir/target/$Language/lib/spiral/date_time.$Language ../../lib/spiral/date_time.$Language -Force
    Copy-Item $targetDir/target/$Language/lib/spiral/file_system.$Language ../../lib/spiral/file_system.$Language -Force
    Copy-Item $targetDir/target/$Language/lib/spiral/sm.$Language ../../lib/spiral/sm.$Language -Force
    Copy-Item $targetDir/target/$Language/lib/spiral/lib.$Language ../../lib/spiral/lib.$Language -Force
}

CopyTarget "rs"

(Get-Content $targetDir/target/rs/math.rs) `
    -replace "../../../lib", "../lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | Set-Content math.rs

cargo fmt --

{ cargo test --release } | Invoke-Block

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
