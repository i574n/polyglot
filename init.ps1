Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"
. ./core.ps1


dotnet tool restore
dotnet paket restore

{ dotnet repl --run init.dib --output-path init.repl.ipynb --exit-after-run } | Invoke-Block




cargo +nightly install wasm-pack

npm install -g pnpm
npm install -g esbuild

npx playwright install


[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
Install-Module -Name PowerShellGet -Force -AllowClobber -Scope CurrentUser
Set-PSRepository -Name PSGallery -InstallationPolicy Trusted

Install-Module -Name PSToml -Scope CurrentUser


{ . "$PSScriptRoot/spiral/language.ps1" } | Invoke-Block
{ . "$PSScriptRoot/spiral/extension.ps1" } | Invoke-Block
{ . "$PSScriptRoot/spiral/fable.ps1" } | Invoke-Block
