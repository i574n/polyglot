param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


if (!(Search-Command "rustup")) {
    if ($IsWindows) {
        $rustupExePath = Join-Path -Path ([System.IO.Path]::GetTempPath()) -ChildPath "rustup-init.exe"
        Invoke-WebRequest -Uri "https://win.rustup.rs/x86_64" -OutFile $rustupExePath -ErrorAction Stop
        Start-Process -FilePath $rustupExePath -Wait
    } else {
        $rustupScriptPath = Join-Path -Path ([System.IO.Path]::GetTempPath()) -ChildPath "rustup.sh"
        Invoke-WebRequest -Uri "https://sh.rustup.rs" -OutFile $rustupScriptPath -ErrorAction Stop
        /bin/sh $rustupScriptPath -y
        $env:PATH = "~/.cargo/bin:$env:PATH"
    }
    rustup install nightly
}

function Search-DotnetSdk($version) {
    $sdks = & dotnet --list-sdks
    foreach ($sdk in $sdks) {
        if ($sdk.StartsWith($version)) {
            return $true
        }
    }
    return $false
}

if (!(Search-DotnetSdk "8")) {
    if (!$IsWindows) {
        curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --version 8.0.100-rc.1.23463.5
    }
}


dotnet tool restore

{ dotnet paket restore } | Invoke-Block

{ . $ScriptDir/symlinks.ps1 } | Invoke-Block
{ . $ScriptDir/dep_dotnet-interactive.ps1 -fast $($fast ?? '') } | Invoke-Block
{ . $ScriptDir/dep_dotnet-repl.ps1 } | Invoke-Block
Invoke-Dib "$ScriptDir/init.dib"
