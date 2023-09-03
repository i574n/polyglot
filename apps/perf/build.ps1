param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


{ dotnet run -c Debug } | Invoke-Block
{ dotnet run -c Release } | Invoke-Block
