param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"

. ../../../../scripts/core.ps1
. ../../../../lib/spiral/lib.ps1


blender -b --python build.py
