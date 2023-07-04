function Invoke-Block {
    param (
        [string] $OnError = $ErrorActionPreference,
        [Hashtable] $EnvironmentVariables,
        [Parameter(Mandatory, ValueFromPipeline)] [ScriptBlock] $ScriptBlock
    )
    $originalEnvironmentVariables = @{}
    if ($EnvironmentVariables) {
        foreach ($var in $EnvironmentVariables.Keys) {
            if (Test-Path "Env:$var") {
                $originalEnvironmentVariables[$var] = (Get-Item "Env:$var").Value
            }
            Set-Item -Path "Env:$var" -Value $EnvironmentVariables[$var]
        }
    }

    & @ScriptBlock

    $exitcode = $lastexitcode

    if ($EnvironmentVariables) {
        foreach ($var in $EnvironmentVariables.Keys) {
            if ($null -eq $originalEnvironmentVariables[$var]) {
                Remove-Item "Env:$var"
            } else {
                Set-Item -Path "Env:$var" -Value $originalEnvironmentVariables[$var]
            }
        }
    }

    if ($exitcode -ne 0) {
        $msg = "# Invoke-Block / `$lastexitcode: $exitcode / `$OnError: $OnError / `$ScriptBlock:`n'$($ScriptBlock.ToString().Trim())'"

        if ($OnError -eq "Stop") {
            if ($host.Name -match "Interactive") {
                [Microsoft.DotNet.Interactive.KernelInvocationContext]::Current.Publish([Microsoft.DotNet.Interactive.Events.CommandFailed]::new([System.Exception]::new($msg), [Microsoft.DotNet.Interactive.KernelInvocationContext]::Current.Command))
            } else {
                Write-Output $msg
                exit $exitcode
            }
        }
    }
}

function Get-LastSortedItem {
    param (
        [Parameter(Mandatory)] [string] $Path,
        [Parameter(Mandatory)] [string] $Filter
    )
    (Get-ChildItem -Path $Path -Filter $Filter -Recurse | Sort-Object FullName)[-1]
}

function Update-Toml {
    param (
        [Parameter(Mandatory)] [string] $tomlPath,
        [Parameter(Mandatory)] [scriptblock] $ContentModifier
    )

    if (!(Test-Path $tomlPath)) {
        New-Item -ItemType File -Path $tomlPath -Force | Out-Null
    }

    $tomlContent = Get-Content $tomlPath | ConvertFrom-Toml

    $tomlContent = &$ContentModifier $tomlContent

    $tomlContent | ConvertTo-Toml -Depth 3 | Set-Content -Path $tomlPath
}
