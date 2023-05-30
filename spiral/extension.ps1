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


$extensionsPath = "$HOME/.vscode/extensions"

if ($IsLinux) {
    $(Invoke-WebRequest -Uri "https://code-server.dev/install.sh" -UseBasicParsing -ErrorAction Stop).Content | sh
    code-server --install-extension $vsixPath
    $extensionsPath = "$HOME/.local/share/code-server/extensions"
} else {
    if (!(Test-Path $extensionsPath)) {
        $extensionsPath = "$env:scoop/persist/vscode/data/extensions"
    }
}

if ((Test-Path $extensionsPath)) {
    $extensionPath = Join-Path -Path $extensionsPath -ChildPath $extensionDestDir
    Write-Output "Copying compiler to $extensionPath"

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

    Update-Toml -tomlPath "$PSScriptRoot/extension.toml" -ContentModifier {
        param($tomlContent)

        if ($null -eq $tomlContent.extension) {
            $tomlContent.extension = @{}
        }
        $tomlContent.extension.path = $extensionPath

        return $tomlContent
    }
}
