Set-Location $PSScriptRoot
git clone https://github.com/i574n/Fable.git

# git --git-dir=Fable/.git --work-tree=Fable remote add fable https://github.com/fable-compiler/Fable.git
# git --git-dir=Fable/.git --work-tree=Fable fetch fable
# git --git-dir=Fable/.git --work-tree=Fable merge fable/main

# sudo add-apt-repository universe
# sudo apt-get install apt-transport-https
# sudo apt-get update
# sudo apt-get install dotnet-sdk-6.0

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
