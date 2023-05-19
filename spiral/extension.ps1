Set-Location $PSScriptRoot
. ../core.ps1

$extensionsPath = "$HOME/.vscode/extensions"
if (!(Test-Path $extensionsPath)) {
    $extensionsPath = "$env:scoop/persist/vscode/data/extensions"
}

if ((Test-Path $extensionsPath)) {
    $extension = Get-ChildItem -Path $extensionsPath -Filter "*spiral-lang*" -Recurse | Select-Object -Last 1

    $extensionPath = $extension.FullName
    Write-Output "Copying compiler to $extensionPath"

    Remove-Item -Recurse -Force "$extensionPath/compiler"
    Copy-Item -Recurse "./The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release/" "$extensionPath/compiler"
} else {
    curl -fsSL https://code-server.dev/install.sh | sh
    code-server --install-extension mrakgr.spiral-lang-vscode-2.3.10.vsix
    code-server --install-extension ms-toolsai.jupyter-2023.4.1011241018-win32-x64.vsix
}
