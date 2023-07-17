$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


function EnsureSymbolicLink([string]$Path, [string] $Target) {
    $Path =  [IO.Path]::GetFullPath((Join-Path $ScriptDir $Path))
    $Target = [IO.Path]::GetFullPath((Join-Path $ScriptDir $Target))

    if (Test-Path $Path) {
        $attr = (Get-Item $Path).Attributes
        if ($null -ne $attr -and (-not ($attr -band [IO.FileAttributes]::Directory))) {
            Write-Output "Removing file: $Path ($attr)"
            Remove-Item $Path
        }
    }

    if (-Not (Test-Path $Path)) {
        Write-Output "Creating symlink: $Path -> $Target"
        $result =
            if ($IsLinux) {
                ln -s "$Target" "$Path"
                $lastexitcode -eq 0
            } else {
                $null -ne (New-Item -ItemType SymbolicLink -Path $Path -Target $Target -ErrorAction SilentlyContinue)
            }
        if (-not $result) {
            Write-Error "Failed to create symlink: $Path -> $Target ($Error)"
        }
    } else {
        Write-Output "Symlink already exists: $Path -> $Target"
    }
}

EnsureSymbolicLink -Path "../nbs/nbs" -Target "../nbs"
EnsureSymbolicLink -Path "../scripts/nbs" -Target "../nbs"
EnsureSymbolicLink -Path "../apps/dice/nbs" -Target "../nbs"
EnsureSymbolicLink -Path "../apps/parser/nbs" -Target "../nbs"
EnsureSymbolicLink -Path "../apps/spiral/nbs" -Target "../nbs"
