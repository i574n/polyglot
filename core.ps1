function Invoke-Block {
    param (
        [string] $OnError = $ErrorActionPreference,
        [Parameter(Mandatory, ValueFromPipeline)] [ScriptBlock] $ScriptBlock
    )
    & @ScriptBlock
    if ($lastexitcode -ne 0) {
        Write-Output "# Invoke-Block / $$lastexitcode: $lastexitcode / $$OnError: $OnError / $$ScriptBlock:`n'$($ScriptBlock.ToString().Trim())'"

        if ($OnError -eq "Stop") {
            exit $lastexitcode
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
