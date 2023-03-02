$extension = Get-ChildItem -Path ~/.vscode/extensions -Filter "*spiral-lang*" -Recurse | Select-Object -Last 1
$path = $extension.FullName
echo "Copying compiler to $path"

rm -rf "$path/compiler"
cp -r "./The-Spiral-Language/The Spiral Language 2/bin/Release/net7.0/" "$path/compiler"
