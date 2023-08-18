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
        while ($retryCount -lt 3) {
            $Error.Clear()

            Invoke-WebRequest $url -OutFile $nearSandboxZip -ErrorAction SilentlyContinue
            Expand-Archive -Force $nearSandboxZip (Split-Path $path) -ErrorAction SilentlyContinue

            if ($Error.Count -eq 0) {
                break
            }

            $retryCount++
            Write-Output "Retrying download of $url ($Error)"
        }
        if ($Error.Count -gt 0) {
            throw "Failed to download $url ($Error)"
        }

        { chmod +x $path } | Invoke-Block -Linux
    }

    return $path
}
