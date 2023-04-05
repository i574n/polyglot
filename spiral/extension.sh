#!/bin/bash

path=$(find "$HOME" -type d -name "*.vscode*" -print -quit)
echo "Extensions path: $path"

extension=$(find "$path" -type d -name "*spiral-lang-*" -print -quit)
echo "Extension: $extension"

path="$extension"
echo "Copying compiler to $path"

sudo rm -rf "$path/compiler"
sudo cp -r "./The-Spiral-Language/The Spiral Language 2/bin/Release/net7.0/" "$path/compiler"
