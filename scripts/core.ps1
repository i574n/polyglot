function Invoke-Linux {
    param (
        [Parameter(Mandatory, ValueFromPipeline)]
        [ScriptBlock] $ScriptBlock,
        [string] $Distro = ""
    )
    if ($IsWindows) {
        if ($Distro -ne "") {
            $Distro = " -d $Distro"
        }
        else {
            $Distro = ""
        }
        Invoke-Expression "wsl$Distro --shell-type login -- $($ScriptBlock.ToString().Trim())"
    }
    else {
        & @ScriptBlock
    }
}

function Invoke-Block {
    param (
        [Parameter(Mandatory, ValueFromPipeline)]
        [ScriptBlock] $ScriptBlock,
        [string] $OnError = $ErrorActionPreference,
        [Hashtable] $EnvironmentVariables,
        [switch] $Linux = $false,
        [switch] $Return = $false,
        [string] $Distro = "",
        [string] $Location = "",
        [int] $Retries = 1
    )
    if (!$EnvironmentVariables) {
        $EnvironmentVariables = @{}
    }
    if (!$Linux) {
        $sep = $IsWindows ? ";" : ":"
        $EnvironmentVariables["PATH"] = "$env:PATH$sep$HOME/.cargo/bin$sep$HOME/.bun/bin"
    }

    if ($Linux -and $IsWindows) {
        $envVars = ""
        if ($EnvironmentVariables.Count -gt 0) {
            $envVars = $EnvironmentVariables.Keys | ForEach-Object { "$_=$($EnvironmentVariables[$_])" } | ForEach-Object { "$_ " }
        }
    }
    else {
        $originalEnvironmentVariables = @{}
        foreach ($var in $EnvironmentVariables.Keys) {
            if (Test-Path "Env:$var") {
                $originalEnvironmentVariables[$var] = (Get-Item "Env:$var").Value
            }
            Set-Item -Path "Env:$var" -Value $EnvironmentVariables[$var]
        }
    }

    $OldLocation = Get-Location
    if ($Location -ne "") {
        Set-Location $Location
    }

    $result = $null
    $output = $null

    Write-Output "`n────────────────────────────────────────────────────────────────────────────────"
    Write-Output "core.Invoke-Block / Get-Location: $(Get-Location) / `$ScriptBlock:`n'$($ScriptBlock.ToString().Trim())'`n"

    $fatal = $null
    $retry = 1
    while ($retry -le $Retries) {
        try {
            $Error.Clear()
            $exitcode = 0
            if ($Linux -and $IsWindows) {
                Invoke-Expression "{ $envVars $ScriptBlock } | Invoke-Linux -Distro `"$Distro`""
            }
            else {
                if ($Return) {
                    $result = & @ScriptBlock
                    $output = $result | Select-Object -First $($result.Count - 1)
                    $result = $result | Select-Object -Last 1
                    $output | Out-Default
                }
                else {
                    & @ScriptBlock
                }
            }
            $exitcode = $lastexitcode ?? 0
        }
        catch {
            $exitcode = -1
        }
        if ($exitcode -ne 0 -or $Error.Count -gt 0) {
            # / `$EnvVars: $($EnvironmentVariables | ConvertTo-Json)
            $msg = "`n# Invoke-Block / `$retry: $retry/$Retries / `$Location: $Location / Get-Location: $(Get-Location) / `$OnError: $OnError / `$exitcode: $exitcode / `$Error: '$Error' / `$ScriptBlock:`n'$($ScriptBlock.ToString().Trim())'`n / `$result:`n'$result'`n / `$output:`n'$output'`n"

            Write-Host $msg
            if ($OnError -eq "Stop") {
                if ($retry -eq $Retries) {
                    if ($host.Name -match "Interactive") {
                        # In a notebook, end the cell: a terminating error (thrown after the cleanup below) fails
                        # the command. Publishing CommandFailed instead left the script running after a fatal error
                        # (dep_spiral.ps1 went on past its failed build) and gave the cell two completions.
                        $fatal = $msg
                        break
                    }
                    else {
                        exit ([Math]::Abs($exitcode), $Error.Count | Measure-Object -Maximum).Maximum
                    }
                }
            } else {
                $lastexitcode = 0
            }
            $Error.Clear()
            $retry++
            continue
        }
        break
    }

    Set-Location $OldLocation

    if (!($Linux -and $IsWindows)) {
        foreach ($var in $EnvironmentVariables.Keys) {
            if ($null -eq $originalEnvironmentVariables[$var]) {
                if (Test-Path "Env:$var") {
                    Remove-Item "Env:$var"
                }
            }
            else {
                Set-Item -Path "Env:$var" -Value $originalEnvironmentVariables[$var]
            }
        }
    }

    if ($fatal) {
        throw $fatal
    }

    if ($env:CI -and $IsLinux) {
        Write-Output "core.Invoke-Block / df - /dev/root"
        df -h /dev/root
    }

    if ($Return) {
        return $result
    }
}

function Get-LastSortedItem {
    param (
        [Parameter(Mandatory)]
        [string] $Path,
        [Parameter(Mandatory)]
        [string] $Filter
    )
    (Get-ChildItem -Path $Path -Filter $Filter -Recurse | Sort-Object { [regex]::Replace($_.FullName, '\d+', { $args[0].Value.PadLeft(20) }) })[-1]
}

function Update-Json {
    param (
        [Parameter(Mandatory)]
        [string] $jsonPath,
        [Parameter(Mandatory)]
        [scriptblock] $ContentModifier
    )

    if (!(Test-Path $jsonPath)) {
        New-Item $jsonPath -ItemType File -Force | Out-Null
    }

    $jsonContent = Get-Content $jsonPath | ConvertFrom-Json

    $jsonContent = &$ContentModifier $jsonContent

    $jsonContent | ConvertTo-Json -Depth 10 | Set-Content -Path $jsonPath
}

function ResolveLink (
    [string] $Path,
    [string] $End = ''
) {
    # Write-Host "polyglot/scripts/core.ps1/ResolveLink #1 / Path: $Path / End: $End"
    if (!$Path) {
        return $End
    }

    $parent = $Path | Split-Path
    if (!$parent) {
        # Write-Host "polyglot/scripts/core.ps1/ResolveLink #2 / parent: $parent / Path: $Path / End: $End"
        return Join-Path $Path $End
    }

    if ($Path.EndsWith("..")) {
        $End = "..$($End ? '/' : '')$End"
    } else {
        $End = "$($Path | Split-Path -Leaf)$($End ? '/' : '')$End"
    }

    if ($parent | Test-Path) {
        $parent_target = ($parent | Get-Item -Force).Target
        if ($Path | Test-Path) {
            $path_target = ($Path | Get-Item -Force).Target
        }
        # Write-Host ("polyglot/scripts/core.ps1/ResolveLink #3 / " + `
        #     "Path: $Path / parent_target: $parent_target / path_target: $path_target / parent: $parent / End: $End")

        if ($parent_target -and ($parent_target | Test-Path)) {
            if ($parent_target.StartsWith(".")) {
                $parent | Remove-Item -Force -Recurse
            }
            else {
                $parent = $parent_target
            }
        } elseif ($path_target) {
            Write-Host ("polyglot/scripts/core.ps1/ResolveLink #4 / " + `
                "Path: $Path / parent_target: $parent_target / path_target: $path_target / " + `
                "parent: $parent / End: $End")
            return $path_target
        }
    }

    # Write-Host ("polyglot/scripts/core.ps1/ResolveLink #5 / " + `
    #     "Path: $Path / parent_target: $parent_target / path_target: $path_target / parent: $parent / " + `
    #     "End: $End")
    return ResolveLink $parent $End
}

function GetFullPath([string] $Path) {
    $Location = Get-Location

    if ($Path.StartsWith(".") -or $Path.StartsWith("/")) {
        $ResolvedLocation = ResolveLink $Location
        Write-Host ("polyglot/scripts/core.ps1/GetFullPath / " + `
            "Path: $Path / Location: $Location / ResolvedLocation: $ResolvedLocation")
        if ($Path.StartsWith("/")) {
            $Path = [IO.Path]::GetFullPath($Path)
        } else {
            $Path = [IO.Path]::GetFullPath((Join-Path $ResolvedLocation $Path))
        }
        Write-Host "polyglot/scripts/core.ps1/GetFullPath / FullPath: $Path"
    }

    return ResolveLink $Path
}

function EnsureSymbolicLink([string] $Path, [string] $Target) {
    $Path = GetFullPath $Path

    if (!$Path) {
        return
    }

    $Parent = $Path | Split-Path

    Write-Output "polyglot/scripts/core.ps1/EnsureSymbolicLink / Parent: $Parent / Path: $Path"

    if (-Not ($Parent | Test-Path)) {
        Write-Output "polyglot/scripts/core.ps1/EnsureSymbolicLink / Creating parent directory: $Parent"
        New-Item $Parent -ItemType Directory | Out-Null
    }

    if ($Path | Test-Path) {
        $attr = ($Path | Get-Item).Attributes
        if ($null -ne $attr `
                -and (-not ($attr -band [IO.FileAttributes]::Directory)) `
                -and ((-not ($attr -band [IO.FileAttributes]::ReparsePoint)))) {
            Write-Output "polyglot/scripts/core.ps1/EnsureSymbolicLink / Removing file: $Path ($attr)"
            $Path | Remove-Item
        }
    }

    $Target = GetFullPath $Target
    $ResolvedTarget = ResolveLink $Target

    Write-Host ("polyglot/scripts/core.ps1/EnsureSymbolicLink / " + `
        "FullPath: $Path / Target: $Target / ResolvedTarget: $ResolvedTarget")

    if (-Not ($Path | Test-Path)) {
        Write-Output "polyglot/scripts/core.ps1/EnsureSymbolicLink / Creating symlink: $Path -> $Target"
        $result = New-Item -ItemType SymbolicLink -Path $Path -Target $Target -ErrorAction SilentlyContinue
        if ($null -eq $result) {
            Write-Error ("polyglot/scripts/core.ps1/EnsureSymbolicLink / " + `
                "Failed to create symlink: $Path -> $Target ($Error)")
        }
    }
    else {
        Write-Output "polyglot/scripts/core.ps1/EnsureSymbolicLink / Symlink already exists: $Path -> $Target"
    }
}

function Search-Command {
    param (
        [string] $CommandName
    )
    try {
        return (Get-Command $CommandName).Source
    }
    catch {
        return $null
    }
}

function _exe {
    if ($IsWindows) {
        return ".exe"
    }
    else {
        return ""
    }
}

function Invoke-Dib {
    param (
        [Parameter(Position = 0, Mandatory)]
        [string] $path,

        [Parameter(Position = 1, ValueFromRemainingArguments)]
        [Object[]] $_args
    )
    $mergedArgs = @{
        "ScriptBlock" = { dotnet repl --run "$path" --output-path "$path.ipynb" --exit-after-run }
    }
    $key = $null
    foreach ($item in $_args) {
        if ($item -match "^-") {
            $key = $item -replace "^-"
        }
        elseif ($null -ne $key) {
            $mergedArgs[$key] = $item
            $key = $null
        }
    }
    Write-Output ("polyglot/scripts/core.ps1/Invoke-Dib / " + `
        "Get-Location: $(Get-Location) / path: $path / _args: $($_args | ConvertTo-Json)")

    $mergedArgs["EnvironmentVariables"] = @{ LOG_LEVEL = "Verbose" }

    { Invoke-Block @mergedArgs } | Invoke-Block

    { jupyter nbconvert "$path.ipynb" --to html --HTMLExporter.theme=dark } | Invoke-Block

    $counter = 1
    (Get-Content "$path.html" -Raw) `
        -replace '(id="cell\-id=)[a-fA-F0-9]{8}', { $_.Groups[1].Value + $counter++ } `
    | Set-Content "$path.html"
}

# Runs a notebook whose code cells are all `#!pwsh` (e.g. init.dib) as one plain pwsh script, without a notebook kernel
# (dotnet repl): its cells in order, in one session (they share variables, as in the notebook), from the notebook's
# directory (nbs_header.ps1 then takes it as $ScriptDir); the first error stops it, like a failing cell.
function Invoke-PwshDib {
    param (
        [Parameter(Mandatory)]
        [string] $Path
    )
    $fullPath = (Resolve-Path $Path).Path
    $cells = @()
    $kernel = $null
    $lines = @()
    foreach ($line in (Get-Content $fullPath)) {
        if ($line -match '^#!([\w-]+)\s*$' -and $Matches[1] -notin @("import", "set", "share", "connect", "value")) {
            if ($kernel) { $cells += [pscustomobject]@{ Kernel = $kernel; Code = $lines -join "`n" } }
            $kernel = $Matches[1]
            $lines = @()
        } else {
            $lines += $line
        }
    }
    if ($kernel) { $cells += [pscustomobject]@{ Kernel = $kernel; Code = $lines -join "`n" } }
    $other = $cells | Where-Object { $_.Kernel -notin @("meta", "markdown", "pwsh") -and $_.Code.Trim() }
    if ($other) {
        throw "polyglot/scripts/core.ps1/Invoke-PwshDib / $Path has non-pwsh code cells ($(($other.Kernel | Select-Object -Unique) -join ', '))"
    }
    $script = Join-Path ([IO.Path]::GetTempPath()) "$([IO.Path]::GetFileNameWithoutExtension($fullPath))-$([guid]::NewGuid().ToString('N')).ps1"
    ($cells | Where-Object Kernel -eq "pwsh" | ForEach-Object Code) -join "`n`n" | Set-Content $script
    Write-Output "polyglot/scripts/core.ps1/Invoke-PwshDib / path: $fullPath / cells: $(@($cells | Where-Object Kernel -eq 'pwsh').Count)"
    try {
        { pwsh -NoProfile -NonInteractive -File $script } | Invoke-Block -Location (Split-Path $fullPath)
    } finally {
        Remove-Item $script -Force -ErrorAction Ignore
    }
}

function Search-DotnetSdk($version) {
    if (!(Search-Command "dotnet")) {
        return $false
    }
    $sdks = & dotnet --list-sdks
    foreach ($sdk in $sdks) {
        if ($sdk.StartsWith($version)) {
            return $true
        }
    }
    return $false
}

function ClearCargoTarget($path) {
    Remove-Item "$path/target/debug/deps" -Recurse -Force -ErrorAction Ignore
    Remove-Item "$path/target/debug/incremental" -Recurse -Force -ErrorAction Ignore
    Remove-Item "$path/target/debug/build" -Recurse -Force -ErrorAction Ignore

    Remove-Item "$path/target/release/deps" -Recurse -Force -ErrorAction Ignore
    Remove-Item "$path/target/release/incremental" -Recurse -Force -ErrorAction Ignore
    Remove-Item "$path/target/release/build" -Recurse -Force -ErrorAction Ignore

    Remove-Item "$path/target/wasm32-unknown-unknown/debug/deps" -Recurse -Force -ErrorAction Ignore
    Remove-Item "$path/target/wasm32-unknown-unknown/debug/incremental" -Recurse -Force -ErrorAction Ignore
    Remove-Item "$path/target/wasm32-unknown-unknown/debug/build" -Recurse -Force -ErrorAction Ignore

    Remove-Item "$path/target/wasm32-unknown-unknown/release/deps" -Recurse -Force -ErrorAction Ignore
    Remove-Item "$path/target/wasm32-unknown-unknown/release/incremental" -Recurse -Force -ErrorAction Ignore
    Remove-Item "$path/target/wasm32-unknown-unknown/release/build" -Recurse -Force -ErrorAction Ignore
}
