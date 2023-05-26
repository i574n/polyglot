Set-Location $PSScriptRoot
. ../core.ps1


$extensionsPath = "$HOME/.vscode/extensions"

if (!(Test-Path $extensionsPath)) {
    if ((pwsh -c '[System.Environment]::OSVersion.VersionString') -like "*Windows*") {
        $extensionsPath = "$env:scoop/persist/vscode/data/extensions"
    } else {
        curl -fsSL https://code-server.dev/install.sh | sh
        Set-Location "./The-Spiral-Language/VS Code Plugin"
        npx @vscode/vsce package
        code-server --install-extension spiral-lang-vscode-2.3.10.vsix

        $extensionsPath = "$HOME/.local/share/code-server/extensions"
        Set-Location $PSScriptRoot
    }
}

if ((Test-Path $extensionsPath)) {
    $extension = Get-ChildItem -Path $extensionsPath -Filter "*spiral-lang*" -Recurse | Select-Object -Last 1

    $extensionPath = $extension.FullName
    Write-Output "Copying compiler to $extensionPath"

    if ((Test-Path "$extensionPath/compiler")) {
        Remove-Item -Recurse -Force "$extensionPath/compiler"
    }
    Copy-Item -Recurse "./The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release/" "$extensionPath/compiler"
}
