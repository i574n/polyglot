function CopyTarget {
    param (
        $targetDir,
        $root,
        [Parameter(Mandatory)]
        [string] $Language,
        [string] $Runtime
    )
    $_runtime = $Runtime -ne "" ? "_$Runtime" : ""

    function CopyItem {
        param (
            $lib,
            $name
        )
        $name = $Language -eq "py" ? $name.ToLower() : $name
        $from = "$targetDir/target/$Language/lib/$lib/$name.$Language"
        $to = "$root/lib/$lib/$name$_runtime.$Language"
        Copy-Item $from $to -Force

        if ($Language -eq "ts") {
            (Get-Content $to) `
                -replace "../../fable_modules/fable-library-ts.4.14.0/", "../../deps/Fable/src/fable-library-ts/" `
                -replace "this\$.tag", "(this$ as any)['tag']" `
                -replace "../../../../../../../../", "../../" `
                | Set-Content $to
        }
        if ($Language -eq "rs") {
            if ($name -eq "file_system") {
                (Get-Content $to) `
                    -replace "use fable_library_rust::Async_::Async;", "type Async<T> = Option<T>;" `
                    -replace "\s\sdefaultOf\(\);", " defaultOf::<()>();" `
                    | Set-Content $to
            }
            if ($name -eq "common") {
                (Get-Content $to) `
                    -replace "defaultOf\(\)", "defaultOf::<std::rc::Rc<dyn IDisposable>>()" `
                    | Set-Content $to
            }
        }
    }

    CopyItem "fsharp" "Common"
    CopyItem "spiral" "common"
    CopyItem "spiral" "date_time"
    CopyItem "spiral" "file_system"
    CopyItem "spiral" "sm"
    CopyItem "spiral" "trace"
    CopyItem "spiral" "lib"

    if ($Language -eq "rs" -and $Runtime -eq "contract") {
        Set-Content "$root/lib/spiral/date_time_contract.rs" ""
    }
}
