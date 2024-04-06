param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../scripts/core.ps1


$extensionsPath = @()

$extensionsPathHome = "$HOME/.vscode/extensions"
if (Test-Path $extensionsPathHome) {
    $extensionsPath += $extensionsPathHome
}

$extensionsPathHome = "$HOME/.vscode-remote/extensions"
if (Test-Path $extensionsPathHome) {
    $extensionsPath += $extensionsPathHome
}

if ($IsWindows -and $env:scoop) {
    $extensionsPathScoop = "$env:scoop/persist/vscode/data/extensions"
    if (Test-Path $extensionsPathScoop) {
        $extensionsPath += $extensionsPathScoop
    }
    $extensionsPathScoop = "$env:scoop/persist/vscode-insiders/data/extensions"
    if (Test-Path $extensionsPathScoop) {
        $extensionsPath += $extensionsPathScoop
    }
}

if ($extensionsPath.Count -gt 0) {
    $spiralPath = "../deps/The-Spiral-Language"

    $extensionSrcPath = "$spiralPath/VS Code Plugin"

    $json = Get-Content (Join-Path -Path $extensionSrcPath -ChildPath "package.json") | ConvertFrom-Json
    $vsixName = $json.name + "-" + $json.version + ".vsix"
    $vsixPath = Join-Path -Path $extensionSrcPath -ChildPath $vsixName

    Remove-Item "$extensionSrcPath/compiler" -Recurse -Force -ErrorAction Ignore

    $path ="$spiralPath/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release/"
    Write-Output "path: $path"

    Copy-Item $path "$extensionSrcPath/compiler" -Recurse -Force

    if (!$fast) {
        { bun install } | Invoke-Block -Location $extensionSrcPath
        { bunx tsc --build } | Invoke-Block -Location $extensionSrcPath
    }
    { bunx @vscode/vsce package } | Invoke-Block -Location $extensionSrcPath
}

foreach ($extensionsPath in $extensionsPath) {
    $extensionDestDir = $json.publisher + "." + $json.name + "-" + $json.version
    $extensionPath = Join-Path -Path $extensionsPath -ChildPath $extensionDestDir

    if (Test-Path $extensionPath) {
        Write-Output "Copying extension to $extensionPath"

        Remove-Item $extensionPath -Recurse -Force -ErrorAction Ignore

        Expand-Archive -Path $vsixPath -DestinationPath "$extensionPath/dist" -Force
        Get-ChildItem -Path "$extensionPath/dist/extension" -Recurse -Force | Where-Object { -not $_.PSIsContainer } | ForEach-Object {
            $destPath = Join-Path -Path $extensionPath -ChildPath $_.FullName.Substring("$extensionPath/dist/extension/".Length)

            if (Test-Path $destPath) {
                try {
                    [System.IO.File]::Delete($destPath)
                } catch {
                    Write-Output "Failed to delete $destPath"
                }
            } else {
                New-Item -Path $destPath -Force | Out-Null
            }

            Move-Item $_.FullName $destPath -Force -ErrorAction SilentlyContinue
        }

        Remove-Item "$extensionPath/dist" -Recurse -Force
    }
}
