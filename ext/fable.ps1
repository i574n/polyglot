$ScriptDir = $PSScriptRoot
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../core.ps1


git clone https://github.com/i574n/Fable.git

# git --git-dir=Fable/.git --work-tree=Fable remote add fable https://github.com/fable-compiler/Fable.git
# git --git-dir=Fable/.git --work-tree=Fable fetch fable
# git --git-dir=Fable/.git --work-tree=Fable merge fable/main

# sudo add-apt-repository universe
# sudo apt-get install apt-transport-https
# sudo apt-get update
# sudo apt-get install dotnet-sdk-6.0

$path = "$HOME/.nuget/packages/fable"
$tools =  Get-LastSortedItem -Path $path -Filter "tools"
$netVersion = Get-LastSortedItem -Path $tools.FullName -Filter "any"

Write-Output "Tool path: $netVersion"


{ dotnet build -c Release "./Fable/src/Fable.Transforms/Fable.Transforms.fsproj" } | Invoke-Block

Copy-Item -Recurse -Force "./Fable/src/Fable.Transforms/bin/Release/netstandard2.0/**" $netVersion
