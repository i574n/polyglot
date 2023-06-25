$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Get-ChildItem -Path .. -Recurse -File -Force | Where-Object { $_.Name -ieq '.gitignore' } | ForEach-Object {
    Rename-Item -Path $_.FullName -NewName '_.gitignore'
}

rsync -av `
    --exclude 'deps' `
    --exclude 'fable_modules' `
    --exclude 'node_modules' `
    --exclude 'target' `
    --exclude '.elixir_ls' `
    --exclude 'paket-files' `
    --exclude 'bin' `
    --exclude 'obj' `
    --exclude 'pkg' `
    --include '*.md' `
    --include '*.editorconfig' `
    --include '*.gitignore' `
    --include '*.toml' `
    --include '*.out' `
    --include '*.ans' `
    --include '*.log' `
    --include '*.ps1' `
    --include '*.dependencies' `
    --include '*.references' `
    --include '*.sln' `
    --include '*.json' `
    --include '*.yaml' `
    --include '*.yml' `
    --include '*.nix' `
    --include '*.cs' `
    --include '*.csproj' `
    --include '*.exs' `
    --include '*.fs' `
    --include '*.fsx' `
    --include '*.fsproj' `
    --include '*.rs' `
    --include '*.spi' `
    --include '*.spir' `
    --include '*.spiproj' `
    --include '*.ts' `
    --include '*.js' `
    --include '*.wasm' `
    --include '*.webm' `
    --include '*.zip' `
    --include '*.html' `
    --include '*.ipynb' `
    --include '*.dib' `
    --include '*/' `
    --exclude '*' `
    --prune-empty-dirs `
    ../ `
    ../dist/
