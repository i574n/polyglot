param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


Remove-Item ../dist -Recurse -Force -ErrorAction Ignore

rsync -av `
    --exclude '.elixir_ls' `
    --exclude '.git' `
    --exclude '.history' `
    --exclude '.paket' `
    --exclude '.vscode' `
    --exclude 'bin' `
    --exclude 'deps' `
    --exclude 'fable_modules' `
    --exclude 'node_modules' `
    --exclude 'obj' `
    --exclude 'paket-files' `
    --exclude 'pkg' `
    --exclude 'target' `
`
    --include 'LICENSE' `
    --include '*.ans' `
    --include '*.cs' `
    --include '*.csproj' `
    --include '*.dependencies' `
    --include '*.dart' `
    --include '*.dib' `
    --include '*.editorconfig' `
    --include '*.exs' `
    --include '*.fs' `
    --include '*.fsproj' `
    --include '*.fsx' `
    --include '*.gitattributes' `
    --include '*.gitignore' `
    --include '*.html' `
    --include '*.ipynb' `
    --include '*.js' `
    --include '*.json' `
    --include '*.log' `
    --include '*.md' `
    --include '*.nix' `
    --include '*.out' `
    --include '*.php' `
    --include '*.ps1' `
    --include '*.py' `
    --include '*.references' `
    --include '*.rs' `
    --include '*.sln' `
    --include '*.spi' `
    --include '*.spiproj' `
    --include '*.spir' `
    --include '*.toml' `
    --include '*.ts' `
    --include '*.wasm' `
    --include '*.webm' `
    --include '*.yaml' `
    --include '*.yml' `
    --include '*.zip' `
`
    --include '*/' `
    --exclude '*' `
    --prune-empty-dirs `
    ../ `
    ../dist/

Get-ChildItem -Path ../dist -Recurse -File -Force | Where-Object { $_.Name -ieq '.gitignore' } | ForEach-Object {
    Rename-Item -Path $_.FullName -NewName '_.gitignore'
}
