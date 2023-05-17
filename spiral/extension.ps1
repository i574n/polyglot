Set-Location $PSScriptRoot

$extensionsPath = "$HOME/.vscode/extensions"
if (!(Test-Path $extensionsPath)) {
    $extensionsPath = "$env:scoop/persist/vscode/data/extensions"
}

$extension = Get-ChildItem -Path $extensionsPath -Filter "*spiral-lang*" -Recurse | Select-Object -Last 1

$extensionPath = $extension.FullName
Write-Output "Copying compiler to $extensionPath"

Remove-Item -Recurse -Force "$extensionPath/compiler"
Copy-Item -Recurse "./The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release/" "$extensionPath/compiler"
