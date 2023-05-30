Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ../core.ps1


$extensionsPath = "$HOME/.vscode/extensions"

if (!(Test-Path $extensionsPath)) {
    if ($IsWindows) {
        $extensionsPath = "$env:scoop/persist/vscode/data/extensions"
    } else {
        $(Invoke-WebRequest -Uri "https://code-server.dev/install.sh" -UseBasicParsing -ErrorAction Stop).Content | sh
        Set-Location "./The-Spiral-Language/VS Code Plugin"
        npx @vscode/vsce package
        code-server --install-extension spiral-lang-vscode-2.3.10.vsix

        $extensionsPath = "$HOME/.local/share/code-server/extensions"
        Set-Location $PSScriptRoot
    }
}

if ((Test-Path $extensionsPath)) {
    $extension = Get-ChildItem -Path $extensionsPath -Filter "*spiral-lang*" -Recurse | Sort-Object @{Expression={([version]($_.Name -replace '^\D*')).Major}; Descending=$true},
    @{Expression={([version]($_.Name -replace '^\D*')).Minor}; Descending=$true},
    @{Expression={([version]($_.Name -replace '^\D*')).Build}; Descending=$true},
    @{Expression={([version]($_.Name -replace '^\D*')).Revision}; Descending=$true} | Select-Object -First 1

    $extensionPath = $extension.FullName
    Write-Output "Copying compiler to $extensionPath"

    $tomlPath = Join-Path -Path $PSScriptRoot -ChildPath "extension.toml"
    if (!(Test-Path $tomlPath)) {
        New-Item -ItemType File -Path $tomlPath -Force | Out-Null
    }

    $tomlContent = Get-Content $tomlPath | ConvertFrom-Toml
    if ($null -eq $tomlContent.extension) {
        $tomlContent.extension = @{}
    }
    $tomlContent.extension.path = $extensionPath

    $tomlContent | ConvertTo-Toml | Set-Content -Path $tomlPath

    if ((Test-Path "$extensionPath/compiler")) {
        Remove-Item -Recurse -Force "$extensionPath/compiler"
    }
    Copy-Item -Recurse "./The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release/" "$extensionPath/compiler"



    Set-Location "./The-Spiral-Language/VS Code Plugin"
    npm install
    npx tsc --build
    npx @vscode/vsce package

    $vsixPath = $extension.Name.Substring($extension.Name.IndexOf(".") + 1) + ".vsix"
    Expand-Archive -Path $vsixPath -DestinationPath "$extensionPath/dist" -Force
    Get-ChildItem -Path "$extensionPath/dist/extension" -Recurse -Force | Where-Object { -not $_.PSIsContainer } | ForEach-Object {
        $destPath = Join-Path -Path $extensionPath -ChildPath $_.FullName.Substring("$extensionPath/dist/extension/".Length)

        if (Test-Path -Path $destPath) {
            [System.IO.File]::Delete($destPath)
        } else {
            New-Item -Path $destPath -Force | Out-Null
        }

        Move-Item -Path $_.FullName -Destination $destPath -Force
    }
}
