Set-Location $PSScriptRoot

dotnet run -c Release | Tee-Object dice.ans
