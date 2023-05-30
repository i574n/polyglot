Set-Location $PSScriptRoot
$ErrorActionPreference = "Stop"



$tomlPath = Join-Path -Path $PSScriptRoot -ChildPath "../extension.toml"
$tomlContent = Get-Content $tomlPath | ConvertFrom-Toml

$logPath = Join-Path -Path $tomlContent.extension.path -ChildPath "compiler/log/supervisor"




# $process = Start-Process -FilePath dotnet -ArgumentList "$dllPath port=$port" -RedirectStandardOutput $outputFile -RedirectStandardError $errorFile -PassThru -NoNewWindow


# $command = "dotnet `"$dllPath`" port=$port"
# $output = (Start-Process -FilePath PowerShell -ArgumentList "-NoProfile", "-Command", "& { $command }" -PassThru -Wait -WindowStyle Hidden).StandardOutput.ReadToEnd()

# $command = "dotnet `"$dllPath`" port=$port"
# $process = Start-Process -FilePath "pwsh" -ArgumentList "-NoProfile", "-Command", "$command" -PassThru -Wait




# if (!(Test-Path $logPath)) {
#     New-Item -ItemType Directory -Path $logPath -Force | Out-Null
# }

$obj = @{
    Ping = $true
}
$req = "Ping"
$jsonPath = "$logPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
New-Item -ItemType File -Path $jsonPath -Force | Out-Null
$obj | ConvertTo-Json -Compress > $jsonPath



echo 1


$dllPath = Join-Path -Path $tomlContent.extension.path -ChildPath "compiler/Spiral.dll"
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















# $baseSpiprojPath = Join-Path -Path $PSScriptRoot -ChildPath "../The-Spiral-Language/VS Code Plugin/core/package.spiproj"
# $baseSpiprojPath = (Get-Item -Path $baseSpiprojPath).FullName
# $baseSpiprojText = Get-Content $baseSpiprojPath -Raw

# $obj = @{
#     ProjectFileOpen = @{
#         uri = "file:///$($baseSpiprojPath.Replace('\', '/').TrimStart('/'))"
#         spiprojText = $baseSpiprojText
#     }
# }

# $req = "ProjectFileOpen"
# $jsonPath = "$logPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath










# $spiprojPath = Join-Path -Path $PSScriptRoot -ChildPath "../package.spiproj"
# $spiprojPath = (Get-Item -Path $spiprojPath).FullName
# $spiprojText = Get-Content $spiprojPath -Raw
# $obj = @{
#     ProjectFileOpen = @{
#         uri = "file:///$($spiprojPath.Replace('\', '/').TrimStart('/'))"
#         spiprojText = $spiprojText
#     }
# }

# $req = "ProjectFileOpen"
# $jsonPath = "$logPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath




# Start-Sleep -Milliseconds 500



echo 2

# $obj = @{
#     Ping = $true
# }
# $req = "Ping"
# $jsonPath = "$logPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath
# # Start-Sleep -Milliseconds 1000
# while ($true) {
#     if (-not (Test-Path $jsonPath)) {
#         break
#     }
#     Start-Sleep -Milliseconds 100
# }
while ($true) {
    if (-not (Test-Path $jsonPath)) {
        break
    }
    Start-Sleep -Milliseconds 100
}



echo 3

Start-Sleep -Milliseconds 500




$spiPath =  Join-Path -Path $PSScriptRoot -ChildPath "test.spi"
$spiText = Get-Content $spiPath -Raw
$obj = @{
    FileOpen = @{
        uri = "file:///$($spiPath.Replace('\', '/').TrimStart('/'))"
        spiText = $spiText
    }
}


$req = "FileOpen"
$jsonPath = "$logPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
New-Item -ItemType File -Path $jsonPath -Force | Out-Null
$obj | ConvertTo-Json -Compress > $jsonPath





# $obj = @{
#     Ping = $true
# }


# $req = "Ping"
# $jsonPath = "$logPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath



# Start-Sleep -Milliseconds 500


echo 4

while ($true) {
    if (-not (Test-Path $jsonPath)) {
        break
    }
    Start-Sleep -Milliseconds 100
}

echo 5
Start-Sleep -Milliseconds 2000




# $obj = @{
#     Ping = $true
# }
# $req = "Ping"
# $jsonPath = "$logPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
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
# $jsonPath = "$logPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
# New-Item -ItemType File -Path $jsonPath -Force | Out-Null
# $obj | ConvertTo-Json -Compress > $jsonPath

echo 6






$spiPath =  Join-Path -Path $PSScriptRoot -ChildPath "test.spi"
$obj = @{
    BuildFile = @{
        uri = "file:///$($spiPath.Replace('\', '/').TrimStart('/'))"
        backend = "Fsharp"
    }
}

$req = "BuildFile"
$jsonPath = "$logPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
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


# Start-Sleep -Milliseconds 1000


echo 7

while ($true) {
    if (-not (Test-Path $jsonPath)) {
        break
    }
    Start-Sleep -Milliseconds 100
}

echo 8
# Start-Sleep -Milliseconds 1000





# $obj = @{
#     Ping = $true
# }
# $req = "Ping"
# $jsonPath = "$logPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
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


Start-Sleep -Milliseconds 500

$obj = @{
    Exit = $true
}
$req = "Exit"
$jsonPath = "$logPath/$(Get-Date -Format 'yyyy_MM_dd_HH_mm_ss_fff')_$req.json"
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

Start-Sleep -Milliseconds 500

$output = $process.StandardOutput.ReadToEnd()


# Start-Sleep -Milliseconds 500
# $process.Kill()
# $process.WaitForExit()

# Stop-Process -Id $process.Id


Write-Output $output

# dotnet fable `
#     "$PSScriptRoot" `
#     --optimize `
#     --lang rs `
#     --extension .rs `
#     --outDir "$PSScriptRoot"

# cargo build --release --manifest-path "$PSScriptRoot/Cargo.toml"


# . "$PSScriptRoot/../../target/release/cli" SpiFsxBuild -- --spi-path="$PSScriptRoot/test.spi"

# dotnet fable `
#     "$PSScriptRoot" `
#     --optimize `
#     --lang rs `
#     --extension .rs `
#     --outDir "$PSScriptRoot"

# cargo fmt --

# $env:RUST_LOG="info"; cargo test --release | Tee-Object test.test.ans

# cargo build --release

# . "$PSScriptRoot/../../target/release/test$(if ($IsWindows) { '.exe' } else { '' })" | Tee-Object test.out
