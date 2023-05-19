Set-Location $PSScriptRoot

dotnet run -c Debug | Tee-Object perf.Debug.out
dotnet run -c Release | Tee-Object perf.Release.out
