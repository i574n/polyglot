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
            $msg = "`n# Invoke-Block / `$retry: $retry/$Retries / `$Location: $Location / Get-Location: $(Get-Location) / `$OnError: $OnError / `$exitcode: $exitcode / `$EnvVars: $($EnvironmentVariables | ConvertTo-Json) / `$Error: '$Error' / `$ScriptBlock:`n'$($ScriptBlock.ToString().Trim())'`n"

            Write-Host $msg
            if ($OnError -eq "Stop" -and $retry -eq $Retries) {
                if ($host.Name -match "Interactive") {
                    [Microsoft.DotNet.Interactive.KernelInvocationContext]::Current.Publish([Microsoft.DotNet.Interactive.Events.CommandFailed]::new([System.Exception]::new($msg), [Microsoft.DotNet.Interactive.KernelInvocationContext]::Current.Command))
                }
                else {
                    exit ([Math]::Abs($exitcode), $Error.Count | Measure-Object -Maximum).Maximum
                }
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
    Write-Host "polyglot/scripts/core.ps1/ResolveLink #1 / Path: $Path / End: $End"
    if (!$Path) {
        return $End
    }

    $parent = $Path | Split-Path
    if (!$parent) {
        Write-Host "polyglot/scripts/core.ps1/ResolveLink #2 / parent: $parent / Path: $Path / End: $End"
        return Join-Path $Path $End
    }

    if ($Path.EndsWith("..")) {
        $End = "..$($End ? '/' : '')$End"
    } else {
        $End = "$($Path | Split-Path -Leaf)$($End ? '/' : '')$End"
    }

    if ($parent | Test-Path) {
        $parent_target = ($parent | Get-Item).Target
        if ($Path | Test-Path) {
            $path_target = ($Path | Get-Item).Target
        }
        Write-Host ("polyglot/scripts/core.ps1/ResolveLink #3 / " + `
            "parent_target: $parent_target / path_target: $path_target / parent: $parent / End: $End")

        if ($parent_target -and ($parent_target | Test-Path)) {
            if ($parent_target.StartsWith(".")) {
                $parent | Remove-Item -Force -Recurse
            }
            else {
                $parent = $parent_target
            }
        } elseif ($path_target) {
            return $path_target
        }
    }

    Write-Host "polyglot/scripts/core.ps1/ResolveLink #4 / parent: $parent / Path: $Path / End: $End"
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

    return $Path
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
