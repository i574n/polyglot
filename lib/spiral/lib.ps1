function CopyTarget {
    param (
        $targetDir,
        $root,
        [Parameter(Mandatory)]
        [string] $Language,
        [string] $Runtime
    )
    $_runtime = $Runtime -ne "" ? "_$Runtime" : ""
    Copy-Item $targetDir/target/$Language/lib/fsharp/Common.$Language $root/lib/fsharp/Common$_runtime.$Language -Force
    Copy-Item $targetDir/target/$Language/lib/spiral/common.$Language $root/lib/spiral/common$_runtime.$Language -Force
    Copy-Item $targetDir/target/$Language/lib/spiral/date_time.$Language $root/lib/spiral/date_time$_runtime.$Language -Force
    Copy-Item $targetDir/target/$Language/lib/spiral/file_system.$Language $root/lib/spiral/file_system$_runtime.$Language -Force
    Copy-Item $targetDir/target/$Language/lib/spiral/sm.$Language $root/lib/spiral/sm$_runtime.$Language -Force
    Copy-Item $targetDir/target/$Language/lib/spiral/lib.$Language $root/lib/spiral/lib$_runtime.$Language -Force

    if ($Language -eq "rs" -and $Runtime -eq "contract") {
        Set-Content "$root/lib/spiral/date_time_contract.rs" ""
    }
}
