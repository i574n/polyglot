param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../scripts/core.ps1


$interactivePath = "../deps/dotnet-interactive"

$extensionSrcPath = "$interactivePath/src/polyglot-notebooks-vscode-insiders"

$json = Get-Content (Join-Path -Path $extensionSrcPath -ChildPath "package.json") | ConvertFrom-Json
$vsixName = $json.name + "-" + $json.version + ".vsix"
$vsixPath = Join-Path -Path $extensionSrcPath -ChildPath $vsixName

{ npm install } | Invoke-Block -Location ../polyglot-notebooks-ui-components

{ npm install } | Invoke-Block -Location $extensionSrcPath
{ npm run compile } | Invoke-Block -Location $extensionSrcPath
{ npx @vscode/vsce package } | Invoke-Block -Location $extensionSrcPath


$extensionsPath = @()

$extensionsPathHome = "$HOME/.vscode/extensions"

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

foreach ($extensionsPath in $extensionsPath) {
    $version = Get-ChildItem -Path $extensionsPath -Filter "$($json.publisher).$($json.name)-*" | Sort-Object -Property Name -Descending | Select-Object -First 1 | ForEach-Object { $_.Name.Substring("$($json.publisher).$($json.name)-".Length) }

    if ($null -eq $version) {
        Write-Output "Skipping copying extension to $extensionsPath"
        continue
    }

    $extensionDestDir = $json.publisher + "." + $json.name + "-" + $version
    $extensionPath = Join-Path -Path $extensionsPath -ChildPath $extensionDestDir
    Write-Output "Copying extension to $extensionPath"

    $currentJson = Get-Content (Join-Path -Path $extensionPath -ChildPath "package.json") | ConvertFrom-Json

    Remove-Item $extensionPath -Recurse -Force -ErrorAction Ignore

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

        Move-Item $_.FullName $destPath -Force -ErrorAction Ignore
    }

    Remove-Item "$extensionPath/dist" -Recurse -Force

    Update-Json -jsonPath "$extensionPath/package.json" -ContentModifier {
        param($jsonContent)
        $jsonContent.version = $version
        $jsonContent.contributes.configuration.properties."dotnet-interactive.requiredInteractiveToolVersion".default = $currentJson.contributes.configuration.properties."dotnet-interactive.requiredInteractiveToolVersion".default
        if (-not $jsonContent.__metadata) {
            $jsonContent | Add-Member -NotePropertyName "__metadata" -NotePropertyValue @{}
        }
        $jsonContent.__metadata = $currentJson.__metadata
        return $jsonContent
    }
}
