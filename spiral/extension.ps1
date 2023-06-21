Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ../core.ps1


$extensionSrcPath = "./The-Spiral-Language/VS Code Plugin"

$json = Get-Content (Join-Path -Path $extensionSrcPath -ChildPath "package.json") | ConvertFrom-Json
$extensionDestDir = $json.publisher + "." + $json.name + "-" + $json.version
$vsixName = $json.name + "-" + $json.version + ".vsix"
$vsixPath = Join-Path -Path $extensionSrcPath -ChildPath $vsixName

if ((Test-Path "$extensionSrcPath/compiler")) {
    Remove-Item -Recurse -Force "$extensionSrcPath/compiler"
}

Copy-Item -Recurse "./The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release/" "$extensionSrcPath/compiler"

Set-Location $extensionSrcPath
npm install
npx tsc --build
npx @vscode/vsce package
Set-Location $PSScriptRoot


$extensionsPath = @()

$extensionsPathHome = "$HOME/.vscode/extensions"

if (Test-Path $extensionsPathHome) {
    $extensionsPath += $extensionsPathHome
}

if ($IsLinux) {
    $(Invoke-WebRequest -Uri "https://code-server.dev/install.sh" -UseBasicParsing -ErrorAction Stop).Content | sh
    code-server --install-extension $vsixPath
    $extensionsPath += "$HOME/.local/share/code-server/extensions"
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
    $extensionPath = Join-Path -Path $extensionsPath -ChildPath $extensionDestDir
    Write-Output "Copying compiler to $extensionPath"

    Remove-Item -Path $extensionPath -Recurse -Force -ErrorAction SilentlyContinue

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

    Remove-Item -Path "$extensionPath/dist" -Recurse -Force

    Update-Toml -tomlPath "$PSScriptRoot/extension.toml" -ContentModifier {
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
