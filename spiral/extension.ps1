$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../scripts/core.ps1


$spiralPath = "../deps/The-Spiral-Language"

$extensionSrcPath = "$spiralPath/VS Code Plugin"

$json = Get-Content (Join-Path -Path $extensionSrcPath -ChildPath "package.json") | ConvertFrom-Json
$vsixName = $json.name + "-" + $json.version + ".vsix"
$vsixPath = Join-Path -Path $extensionSrcPath -ChildPath $vsixName

Remove-Item "$extensionSrcPath/compiler" -Recurse -Force -ErrorAction SilentlyContinue

Copy-Item -Recurse "$spiralPath/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release/" "$extensionSrcPath/compiler"

Set-Location $extensionSrcPath
npm install
npx tsc --build
npx @vscode/vsce package
Set-Location $ScriptDir


$extensionsPath = @()

$extensionsPathHome = "$HOME/.vscode/extensions"
if (Test-Path $extensionsPathHome) {
    $extensionsPath += $extensionsPathHome
}

$extensionsPathHome = "$HOME/.vscode-remote/extensions"
if (Test-Path $extensionsPathHome) {
    $extensionsPath += $extensionsPathHome
}

if ($IsLinux) {
    if ($extensionsPath.Length -eq 0) {
        $(Invoke-WebRequest -Uri "https://code-server.dev/install.sh" -UseBasicParsing -ErrorAction Stop).Content | sh
        code-server --install-extension $vsixPath
        $extensionsPath += "$HOME/.local/share/code-server/extensions"
    }
} else {
    $extensionsPathScoop = "$env:scoop/persist/vscode/data/extensions"
    if (Test-Path $extensionsPathScoop) {
        $extensionsPath += $extensionsPathScoop
    }
    $extensionsPathScoop = "$env:scoop/persist/vscode-insiders/data/extensions"
    if (Test-Path $extensionsPathScoop) {
        $extensionsPath += $extensionsPathScoop
    }
}

foreach ($extensionsPath in $extensionsPath) {
    $extensionDestDir = $json.publisher + "." + $json.name + "-" + $json.version
    $extensionPath = Join-Path -Path $extensionsPath -ChildPath $extensionDestDir
    Write-Output "Copying extension to $extensionPath"

    Remove-Item $extensionPath -Recurse -Force -ErrorAction SilentlyContinue

    Expand-Archive -Path $vsixPath -DestinationPath "$extensionPath/dist" -Force
    Get-ChildItem -Path "$extensionPath/dist/extension" -Recurse -Force | Where-Object { -not $_.PSIsContainer } | ForEach-Object {
        $destPath = Join-Path -Path $extensionPath -ChildPath $_.FullName.Substring("$extensionPath/dist/extension/".Length)

        if (Test-Path -Path $destPath) {
            try {
                [System.IO.File]::Delete($destPath)
            } catch {
                Write-Output "Failed to delete $destPath"
            }
        } else {
            New-Item -Path $destPath -Force | Out-Null
        }

        Move-Item -Path $_.FullName -Destination $destPath -Force -ErrorAction SilentlyContinue
    }

    Remove-Item "$extensionPath/dist" -Recurse -Force

    Update-Toml -tomlPath "$ScriptDir/extension.toml" -ContentModifier {
        param($tomlContent)

        if ($null -eq $tomlContent.extension) {
            $tomlContent.extension = @{}
        }

        if ($null -eq $tomlContent.extension.paths) {
            $tomlContent.extension.paths = @()
        }

        if (($tomlContent.extension.paths | Where-Object { $_ -eq $extensionPath }).Length -eq 0) {
            $tomlContent.extension.paths += $extensionPath
        }

        return $tomlContent
    }
}
