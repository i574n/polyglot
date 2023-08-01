param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1

















$tomlPath = Join-Path -Path $ScriptDir -ChildPath "../extension.toml"
$tomlContent = Get-Content $tomlPath | ConvertFrom-Toml

$commandsPath = $tomlContent.extension.paths | ForEach-Object {
    Join-Path -Path $_ -ChildPath "compiler/supervisor/commands"
#} | Where-Object {
#    Test-Path $_
} | Select-Object -Last 1

Write-Output "commandsPath: $commandsPath"

# $process = Start-Process -FilePath dotnet -ArgumentList "$dllPath port=$port" -RedirectStandardOutput $outputFile -RedirectStandardError $errorFile -PassThru -NoNewWindow


# $command = "dotnet `"$dllPath`" port=$port"
# $output = (Start-Process -FilePath PowerShell -ArgumentList "-NoProfile", "-Command", "& { $command }" -PassThru -Wait -WindowStyle Hidden).StandardOutput.ReadToEnd()

# $command = "dotnet `"$dllPath`" port=$port"
# $process = Start-Process -FilePath "pwsh" -ArgumentList "-NoProfile", "-Command", "$command" -PassThru -Wait




# if (!(Test-Path $commandsPath)) {
#     New-Item -ItemType Directory -Path $commandsPath -Force | Out-Null
# }

$obj = @{
    Ping = $true
}
$req = "Ping"
$jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
New-Item -ItemType File -Path $jsonPath -Force | Out-Null
$obj | ConvertTo-Json -Compress > $jsonPath



echo 1


$dllPath = Join-Path -Path $commandsPath -ChildPath "../../Spiral.dll"
$port = 13805


$processStartInfo = New-Object System.Diagnostics.ProcessStartInfo
$processStartInfo.FileName = "dotnet"
$processStartInfo.Arguments = "$dllPath port=$port"
$processStartInfo.RedirectStandardOutput = $true
$processStartInfo.RedirectStandardError = $true
$processStartInfo.UseShellExecute = $false

$process = New-Object System.Diagnostics.Process
$process.StartInfo = $processStartInfo

$process.Start() | Out-Null















# $baseSpiprojPath = Join-Path -Path $ScriptDir -ChildPath "../The-Spiral-Language/VS Code Plugin/core/package.spiproj"
# $baseSpiprojPath = (Get-Item -Path $baseSpiprojPath).FullName
# $baseSpiprojText = Get-Content $baseSpiprojPath -Raw

# $obj = @{
#     ProjectFileOpen = @{
#         uri = "file:///$($baseSpiprojPath.Replace('\', '/').TrimStart('/'))"
#         spiprojText = $baseSpiprojText
#     }
# }

# $req = "ProjectFileOpen"
# $jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath










# $spiprojPath = Join-Path -Path $ScriptDir -ChildPath "../package.spiproj"
# $spiprojPath = (Get-Item -Path $spiprojPath).FullName
# $spiprojText = Get-Content $spiprojPath -Raw
# $obj = @{
#     ProjectFileOpen = @{
#         uri = "file:///$($spiprojPath.Replace('\', '/').TrimStart('/'))"
#         spiprojText = $spiprojText
#     }
# }

# $req = "ProjectFileOpen"
# $jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath




# Start-Sleep -Milliseconds 500



echo 2

# $obj = @{
#     Ping = $true
# }
# $req = "Ping"
# $jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath
# # Start-Sleep -Milliseconds 1000
# while ($true) {
#     if (-not (Test-Path $jsonPath)) {
#         break
#     }
#     Start-Sleep -Milliseconds 100
# }
$counter = 0
while ($counter -lt 100) {
    if (-not (Test-Path $jsonPath)) {
        break
    }
    Start-Sleep -Milliseconds 50
    $counter++
}
if (Test-Path $jsonPath) {
    $process.Kill()
    Write-Output $process.StandardOutput.ReadToEnd()
    exit 1
}



echo 3

Start-Sleep -Milliseconds 1500

# $obj = @{
#     Ping = $true
# }
# $req = "Ping"
# $jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath
# $counter = 0
# while ($counter -lt 100) {
#     if (-not (Test-Path $jsonPath)) {
#         break
#     }
#     Start-Sleep -Milliseconds 100
#     $counter++
# }





$spiPath =  Join-Path -Path $ScriptDir -ChildPath "test.spi"
$spiText = Get-Content $spiPath -Raw
$obj = @{
    FileOpen = @{
        uri = "file:///$($spiPath.Replace('\', '/').TrimStart('/'))"
        spiText = $spiText
    }
}


$req = "FileOpen"
$jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
New-Item -ItemType File -Path $jsonPath -Force | Out-Null
$obj | ConvertTo-Json -Compress > $jsonPath





# $obj = @{
#     Ping = $true
# }
# $req = "Ping"
# $jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath



# Start-Sleep -Milliseconds 500


echo 4

$counter = 0
while ($counter -lt 100) {
    if (-not (Test-Path $jsonPath)) {
        break
    }
    Start-Sleep -Milliseconds 50
    $counter++
}
if (Test-Path $jsonPath) {
    $process.Kill()
    Write-Output $process.StandardOutput.ReadToEnd()
    & $MyInvocation.MyCommand.Path
    exit $LASTEXITCODE
}








# Start-Sleep -Milliseconds 500





$obj = @{
    Ping = $true
}
$req = "Ping"
$jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
New-Item -ItemType File -Path $jsonPath -Force | Out-Null
$obj | ConvertTo-Json -Compress > $jsonPath
$counter = 0
while ($counter -lt 100) {
    if (-not (Test-Path $jsonPath)) {
        break
    }
    Start-Sleep -Milliseconds 50
    $counter++
}



echo 5
Start-Sleep -Milliseconds 2000




# $obj = @{
#     Ping = $true
# }
# $req = "Ping"
# $jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath
# Start-Sleep -Milliseconds 1000
# while ($true) {
#     if (-not (Test-Path $jsonPath)) {
#         break
#     }
#     Start-Sleep -Milliseconds 100
# }
# Start-Sleep -Milliseconds 1000

# Start-Sleep -Milliseconds 3000



# $output = $process.StandardOutput.ReadToEnd()
# Write-Output $output


#



# $obj = @{
#     Ping = $true
# }


# $req = "Ping"
# $jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath

echo 6






$spiPath =  Join-Path -Path $ScriptDir -ChildPath "test.spi"
$obj = @{
    BuildFile = @{
        uri = "file:///$($spiPath.Replace('\', '/').TrimStart('/'))"
        backend = "Fsharp"
    }
}

$req = "BuildFile"
$jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
New-Item -ItemType File -Path $jsonPath -Force | Out-Null
$obj | ConvertTo-Json -Compress > $jsonPath



















# $processStartInfo = New-Object System.Diagnostics.ProcessStartInfo
# $processStartInfo.FileName = "dotnet"
# $processStartInfo.Arguments = "$dllPath port=$port"
# $processStartInfo.RedirectStandardOutput = $true
# $processStartInfo.RedirectStandardError = $true
# $processStartInfo.UseShellExecute = $false

# $process = New-Object System.Diagnostics.Process
# $process.StartInfo = $processStartInfo


# Register-ObjectEvent -InputObject $process -EventName OutputDataReceived -Action {
#     Write-Output "OUTPUT: $EventArgs.Data"
# }
# Register-ObjectEvent -InputObject $process -EventName ErrorDataReceived -Action {
#     Write-Output "ERROR: $EventArgs.Data"
# }

# $process.Start() | Out-Null
# $process.BeginOutputReadLine()
# $process.BeginErrorReadLine()



# $outputFile = "output.txt"
# $errorFile = "error.txt"

# $process = Start-Process -FilePath dotnet -ArgumentList "$dllPath port=$port" -RedirectStandardOutput $outputFile -RedirectStandardError $errorFile -PassThru -NoNewWindow


# $command = "dotnet `"$dllPath`" port=$port"
# $output = (Start-Process -FilePath PowerShell -ArgumentList "-NoProfile", "-Command", "& { $command }" -PassThru -Wait -WindowStyle Hidden).StandardOutput.ReadToEnd()


Start-Sleep -Milliseconds 500


echo 7

$counter = 0
while ($counter -lt 100) {
    if (-not (Test-Path $jsonPath)) {
        break
    }
    Start-Sleep -Milliseconds 50
    $counter++
}
if (Test-Path $jsonPath) {
    $process.Kill()
    Write-Output $process.StandardOutput.ReadToEnd()
    & $MyInvocation.MyCommand.Path
    exit $LASTEXITCODE
}

echo 8

Start-Sleep -Milliseconds 1000
# Start-Sleep -Milliseconds 1000





# $obj = @{
#     Ping = $true
# }
# $req = "Ping"
# $jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath
# Start-Sleep -Milliseconds 1000
# while ($true) {
#     if (-not (Test-Path $jsonPath)) {
#         break
#     }
#     Start-Sleep -Milliseconds 100
# }



echo 9
# Start-Sleep -Milliseconds 1000


# Start-Sleep -Milliseconds 1000

$obj = @{
    Exit = $true
}
$req = "Exit"
$jsonPath = "$commandsPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
New-Item -ItemType File -Path $jsonPath -Force | Out-Null
$obj | ConvertTo-Json -Compress > $jsonPath


# Start-Sleep -Milliseconds 2000

echo 10

# while ($true) {
#     if (-not (Test-Path $jsonPath)) {
#         break
#     }
#     Start-Sleep -Milliseconds 100
# }

# echo 11

# $output = $process.StandardOutput.ReadToEnd()
# Write-Output $output


# Start-Sleep -Milliseconds 1000

# $process.Kill()
# $process.Close()
# $process.WaitForExit()

# Start-Sleep -Milliseconds 500

Write-Output $process.StandardOutput.ReadToEnd()


# Start-Sleep -Milliseconds 500
# $process.Kill()
# $process.WaitForExit()

# Stop-Process -Id $process.Id


# Write-Output $output



{ dotnet repl --run test.dib --output-path test.repl.ipynb --exit-after-run } | Invoke-Block
