$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


{ dotnet repl --run DibParser.dib --output-path DibParser.repl.ipynb --exit-after-run } | Invoke-Block -EnvironmentVariables @{ "OUTPUT" = "DibParser.dib" }

{ . "../builder/target/bin/Release/net8.0/Builder$(if ($IsWindows) { '.exe' } else { '' })" "DibParser.fs" } | Invoke-Block

{ . "target/bin/Release/net8.0/DibParser$(if ($IsWindows) { '.exe' } else { '' })" "JsonParser.dib;Parser.dib" } | Invoke-Block

{ dotnet repl --run JsonParser.dib --output-path JsonParser.repl.ipynb --exit-after-run } | Invoke-Block
{ dotnet repl --run Parser.dib --output-path Parser.repl.ipynb --exit-after-run } | Invoke-Block
