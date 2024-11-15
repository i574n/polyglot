param(
    $fast,
    $SkipPreBuild,
    $SkipNotebook,
    $SkipFsx,
    $SkipFable,
    $SkipRs,
    $SkipTs,
    $SkipPy,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../../scripts/core.ps1
. ../../../../lib/spiral/lib.ps1


$projectName = "cube"

if (!$SkipPreBuild) {
    if (!$SkipNotebook) {
        { . ../../dist/Supervisor$(_exe) --execute-command "../../../../workspace/target/release/spiral_builder$(_exe) dib --path $projectName.dib" } | Invoke-Block -Retries 3
    }

    { . ../../../parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block
}

if (!$SkipFsx) {
    { . ../../dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" } | Invoke-Block
}

if (!$SkipFable) {
    $runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
    $builderArgs = @("$projectName.fsx", "--persist-only", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
    { . ../../../builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

    $targetDir = GetTargetDir $projectName
}

if (!$SkipRs -and !$SkipFable) {
    { BuildFable $targetDir $projectName "rs" } | Invoke-Block

    $path = "$targetDir/target/rs/polyglot/target/Builder/$projectName/$projectName.rs"
    if (!(Test-Path $path)) {
        $path = "$targetDir/target/rs/$projectName.rs"
    }
    (Get-Content $path) `
        -replace "../../../lib", "../../../../lib" `
        -replace ".fsx`"]", ".rs`"]" `
        | FixRust `
        | Set-Content "$projectName.rs"

    cargo fmt --
}

if (!$SkipTs -and !$SkipFable) {
    { BuildFable $targetDir $projectName "ts" } | Invoke-Block

    $path = "$targetDir/target/ts/polyglot/target/Builder/$projectName/$projectName.ts"
    if (!(Test-Path $path)) {
        $path = "$targetDir/target/ts/$projectName.ts"
    }
    (Get-Content $path) `
        -replace "from `"./fable_modules", "from `"../../../../lib/typescript/fable/fable_modules" `
        | Set-Content "$projectName.ts"
}

if (!$SkipPy -and !$SkipFable) {
    { BuildFable $targetDir $projectName "py" } | Invoke-Block

    $path = "$targetDir/target/py/polyglot/target/Builder/$projectName/$projectName.py"
    if (!(Test-Path $path)) {
        $path = "$targetDir/target/py/$projectName.py"
    }
    (Get-Content $path) `
        -replace "import sys", "import sys`nsys.path.insert(0, f'{os.path.dirname(__file__)}/../../../../lib/python/fable')" `
        | Set-Content "$projectName.py"
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
