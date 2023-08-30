param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


npm i -g @fleekxyz/cli@dev

Set-Location ..


$files = @(
    Get-ChildItem -Path . -Recurse -File -Force `
    | Where-Object {
        $_.FullName.Replace("\", "/").Contains("/target/dist") `
            -and ($_.Extension -eq ".exe" -or $_.Extension -eq "")
    } `
    | Select-Object FullName, DirectoryName, Name
)

$files | ForEach-Object {
    Write-Output "`npath: $($_.FullName)"

    Remove-Item $_.FullName -Force
}

exit 0

# $files | ForEach-Object -ThrottleLimit 1 -Parallel {
$files | ForEach-Object {
    Write-Output "`npath: $($_.FullName)"

    $retryCount = 0
    while ($retryCount -lt 10) {
        if ($retryCount -gt 0) {
            Write-Host "Retrying upload of $($_.Name) - $retryCount ($Error)"
        }
        $Error.Clear()

        $output = fleek ipfs add $_.FullName
        $hash = $output `
        | Select-String -Pattern "https://\S+/(\S+)$" `
        | ForEach-Object { $_.Matches.Groups[1].Value }

        if (!$hash) {
            $Error.Add("Hash error: $output") | Out-Null
            $retryCount++
            continue
        }

        Write-Output "hash: '$hash'"

        $hash | Set-Content "$($_.DirectoryName)/$($_.Name).hash"

        $dwebUrl = "https://dweb.link/ipfs/$hash"
        # cf-ipfs.com
        # nftstorage.link

        try {
            $response = Invoke-WebRequest `
                -Uri $dwebUrl `
                -MaximumRedirection 10 `
                -Headers @{ "Range" = "bytes=1000-1001" } `
                -ErrorAction SilentlyContinue
        }
        catch {
            if ($_.Exception.Response.StatusCode -eq 504) {
                $Error.Clear()
                $Error.Add($_.Exception.Message) | Out-Null
                $retryCount++
                continue
            }
            Write-Output "Error: $($_ | ConvertTo-Json)"
        }

        if ($Error.Count -gt 0) {
            $retryCount++
            continue
        }

        $cid = $response.Headers["X-Ipfs-Roots"]

        Write-Output "cid: '$cid'"

        $cid | Set-Content "$($_.DirectoryName)/$($_.Name).cid"
        Remove-Item $_.FullName -Force

        break
    }
    if ($Error.Count -gt 0) {
        throw "Failed to upload ($Error)"
        exit 1
    }
}
