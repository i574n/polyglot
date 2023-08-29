param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1

Remove-Item ./dist -Recurse -Force -ErrorAction Ignore

npx -y tailwindcss -i input.css -o dist/tailwind.css

{ trunk build --dist="dist/trunk" --public-url="./dist" } | Invoke-Block

$path = "dist/trunk/index.html"
(Get-Content $path) `
    -replace "/./dist/", "./" `
    | Set-Content $path

{ rna build --bundle --minify --no-map --assetNames "[name]" dist/trunk/index.html --output dist/rna } | Invoke-Block

$path = "dist/rna/index.html"
$html = Get-Content $path
$module = $html | Select-String -Pattern '<link rel="modulepreload" href="([^"]+)">' -AllMatches
if ($module.Matches.Count -gt 0) {
    $module.Matches | ForEach-Object { Remove-Item "dist/rna/$($_.Groups[1].Value)" -Force }
    $html -replace ' *<link rel="modulepreload" href="([^"]+)">', "" | Set-Content $path
}

{ pnpm -C e2e install --frozen-lockfile } | Invoke-Block
{ pnpm -C e2e test:e2e } | Invoke-Block
