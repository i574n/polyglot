param(
    $fast,
    $init,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ./core.ps1


function Search-DotnetSdk($version) {
    $sdks = & dotnet --list-sdks
    foreach ($sdk in $sdks) {
        if ($sdk.StartsWith($version)) {
            return $true
        }
    }
    return $false
}

if (!(Search-Command "nix")) {
    if (!$IsWindows) {
        if (!(Search-DotnetSdk "9")) {
            curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --version "9.0.100-preview.1.24101.2"
        }

        if (!(Test-Path "~/.bun/bin/bun")) {
            curl -sSL https://bun.sh/install | bash
            $env:PATH = "~/.bun/bin:$env:PATH"
        }

        # if (!(Search-Command "mono")) {
        #     sudo apt-add-repository 'deb https://download.mono-project.com/repo/ubuntu stable-focal main'
        #     sudo apt install -y mono-complete
        # }

        if (!(Search-Command "pip")) {
            sudo apt install -y python3-pip
        }
    }

    pip install -r ../requirements.txt
} else {
    mkdir -p ~/.bun/bin
    ln -s /run/current-system/sw/bin/bun ~/.bun/bin/bun
    ln -s /run/current-system/sw/bin/bunx ~/.bun/bin/bunx
}

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
}
rustup install nightly
rustup default nightly

if ($init) {
    exit
}

dotnet tool restore

{ dotnet paket restore } | Invoke-Block

{ . $ScriptDir/symlinks.ps1 } | Invoke-Block

{ . $ScriptDir/dep_dotnet-interactive.ps1 -fast $($fast ?? '') } | Invoke-Block
{ . $ScriptDir/dep_dotnet-repl.ps1 } | Invoke-Block

Set-Location $ScriptDir

Invoke-Dib init.dib
{ pwsh ../lib/rust/fable/build.ps1 } | Invoke-Block
{ pwsh ../apps/spiral/builder/build.ps1 -SkipPreBuild 1 } | Invoke-Block

{ pwsh ../lib/typescript/fable/build.ps1 } | Invoke-Block
{ pwsh ../lib/python/fable/build.ps1 } | Invoke-Block
