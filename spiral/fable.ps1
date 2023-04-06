Set-Location $PSScriptRoot
git clone https://github.com/i574n/Fable.git

dotnet build -c Release "./Fable/src/Fable.Transforms/Fable.Transforms.fsproj"

function Get-LastSortedItem {
    param (
        [Parameter(Mandatory)] [string]$Path,
        [Parameter(Mandatory)] [string]$Filter
    )
    (Get-ChildItem -Path $Path -Filter $Filter -Recurse | Sort-Object FullName)[-1]
}


$path = "$HOME/.nuget/packages/fable"
$fableTools = Get-LastSortedItem -Path $path -Filter "tools"
$netVersion = Get-LastSortedItem -Path $fableTools.FullName -Filter "any"

Write-Output "Fable tool path: $netVersion"

Copy-Item -Recurse -Force "./Fable/src/Fable.Transforms/bin/Release/netstandard2.0/**" $netVersion
