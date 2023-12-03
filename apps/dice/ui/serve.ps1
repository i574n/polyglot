param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../scripts/core.ps1


# npx -y tailwindcss -i input.css -o target/tailwind.css

if (!$fast) {
    npx ssl-serve --ssl dist
} else {
    $targetDir = "../../../target/polyglot/builder/dice_ui"
    { trunk serve --dist="$targetDir/trunk" } | Invoke-Block -EnvironmentVariables @{ "TRUNK_TOOLS_WASM_BINDGEN" = "0.2.89" }
}
