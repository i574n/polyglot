param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


$dibParserExe = "../parser/target/bin/Release/net8.0/DibParser$(GetExecutableSuffix)"
if ($fast -and (Test-Path $dibParserExe)) {
    { . $dibParserExe Builder.dib } | Invoke-Block
} else {
    { dotnet repl --run ../parser/DibParser.dib --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "ARGS" = "Builder.dib" }
}

{ dotnet repl --run Builder.dib --output-path Builder.repl.ipynb --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "ARGS" = "Builder.fs" }
