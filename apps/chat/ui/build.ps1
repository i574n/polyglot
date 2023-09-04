param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


if (!$fast) {
    Remove-Item ./dist -Recurse -Force -ErrorAction Ignore

    npx -y tailwindcss -i input.css -o dist/tailwind.css
}

{ trunk build --dist="dist/trunk" --public-url="./dist" } | Invoke-Block

$path = "dist/trunk/index.html"
$html = Get-Content $path
$oldModule = ($html | Select-String -Pattern "import init from '/./dist/(.*?)'").Matches[0].Groups[1].Value
$html `
    -replace "/./dist/", "./" `
    -replace "import init from '([^']+)';init\(", "import init,{set_outer_messages_state,set_inner_messages_state} from './$oldModule';window.set_outer_messages_state=set_outer_messages_state;window.set_inner_messages_state=set_inner_messages_state;init(" `
    | Set-Content $path

{ rna build --bundle --minify --no-map --assetNames "[name]" dist/trunk/index.html --output dist/rna } | Invoke-Block

$path = "dist/rna/index.html"
$html = Get-Content $path

$oldModule = $html | Select-String -Pattern '<link rel="modulepreload" href="([^"]+)">' -AllMatches
if ($oldModule.Matches.Count -gt 0) {
    $oldModule.Matches | ForEach-Object { Remove-Item "dist/rna/$($_.Groups[1].Value)" -Force }
    $newModule = $html | Select-String -Pattern "import './(.*?)'"
    $html -replace '<link rel="modulepreload" href="([^"]+)">', "<link rel=`"modulepreload`" href=`"$($newModule.Matches[0].Groups[1].Value)`">" | Set-Content $path
}

if (!$fast) {
    { pnpm install --frozen-lockfile } | Invoke-Block -Location e2e
    { pnpm test:e2e } | Invoke-Block -Location e2e
}
