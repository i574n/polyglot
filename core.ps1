function Invoke-Call {
    param (
        [scriptblock]$ScriptBlock,
        [string]$ErrorAction = $ErrorActionPreference
    )
    & @ScriptBlock
    if (($lastexitcode -ne 0) -and $ErrorAction -eq "Stop") {
        exit $lastexitcode
    }
}

function Get-LastSortedItem {
    param (
        [Parameter(Mandatory)] [string]$Path,
        [Parameter(Mandatory)] [string]$Filter
    )
    (Get-ChildItem -Path $Path -Filter $Filter -Recurse | Sort-Object FullName)[-1]
}

function Update-Toml {
    param (
        [Parameter(Mandatory=$true)]
        [string] $tomlPath,

        [Parameter(Mandatory=$true)]
        [scriptblock] $ContentModifier
    )

    if (!(Test-Path $tomlPath)) {
        New-Item -ItemType File -Path $tomlPath -Force | Out-Null
    }

    $tomlContent = Get-Content $tomlPath | ConvertFrom-Toml

    $tomlContent = &$ContentModifier $tomlContent

    $tomlContent | ConvertTo-Toml | Set-Content -Path $tomlPath
}
