param(
    $ScriptDir = $PSScriptRoot
)
. $ScriptDir/core.ps1


function DownloadNearSandbox {
    param (
        [string] $path = "$ScriptDir/../target/near-sandbox"
    )
    $path = [IO.Path]::GetRelativePath((Get-Location), $path) -replace "\\", "/"

    if (!(Test-Path $path)) {
        $nearSandboxZip = Join-Path -Path ([System.IO.Path]::GetTempPath()) -ChildPath "near-sandbox.zip"
        $osRelease = { pwsh -c Get-Content /etc/os-release } | Invoke-Block -Linux
        $url = if ($osRelease | Select-String -Pattern "NixOS" -Quiet) {
            "https://bafybeiahopxwsng6nmgihipwjpv6nzwoz7ta2jam6bukve7kni5auhiimu.ipfs.dweb.link"
        } else {
            "https://bafybeictjqjc3sbppcslzezn64h7acnrmt3oskdyjxgcrawlu6pujvin3i.ipfs.dweb.link"
        }

        $retryCount = 0
        Write-Host "## 1"
        while ($retryCount -lt 20) {
            if ($retryCount -gt 0) {
                Write-Host "Retrying download of $url - $retryCount"
            }
            $Error.Clear()
            Write-Host "## 2"

            try {
                Invoke-WebRequest $url -OutFile $nearSandboxZip
                $output = Expand-Archive -Force $nearSandboxZip (Split-Path $path) -PassThru
                Write-Host "Output: $output / length: $($output.Length)"
            } catch {
                Write-Host "Error: '$Error'"
            }
            Write-Host "## 3"

            if ($Error.Count -eq 0) {
                Write-Host "## 3.1"
                break
            }

            Remove-Item $nearSandboxZip -Force -ErrorAction Ignore
            Remove-Item $path -Force -ErrorAction Ignore
            Write-Host "## 4"
            $retryCount++
        }
        Write-Host "## 5"
        Write-Host "$path Length: $((Get-Item $path).Length)"
        if ($Error.Count -gt 0) {
            throw "Failed to download $url ($Error)"
            exit 1
        }

        { chmod +x $path } | Invoke-Block -Linux
        Write-Host "## 6"
    }
    Write-Host "## 7"

    return $path
}
