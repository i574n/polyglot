param(
    [Parameter(Position = 0, Mandatory)]
    [string] $path,

    [Parameter(Position = 1, ValueFromRemainingArguments)]
    [Object[]]$_args,

    $ScriptDir = $PSScriptRoot
)
$ErrorActionPreference = "Stop"
. $ScriptDir/core.ps1


Invoke-Dib $path $_args
