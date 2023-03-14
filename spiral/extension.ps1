$path = ~/.vscode/extensions
if (!(Test-Path $path)) {
    $path = "$env:scoop/persist/vscode/data/extensions"
}

$extension = Get-ChildItem -Path $path -Filter "*spiral-lang*" -Recurse | Select-Object -Last 1

$path = $extension.FullName
Write-Output "Copying compiler to $path"

Remove-Item -Recurse -Force "$path/compiler"
Copy-Item -Recurse "./The-Spiral-Language/The Spiral Language 2/bin/Release/net7.0/" "$path/compiler"
