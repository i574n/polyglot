function CopyTarget {
    param (
        $TargetDir,
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
        $name = $Language -eq "py" -and $name -eq "threading" ? "$($name)_" : $name
        $name = $Language -eq "py" ? $name.ToLower() : $name
        $from = "$TargetDir/target/$Language/lib/$lib/$name.$Language"
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
            (Get-Content $to) `
                -replace [regex]::Escape("),);"), "));" `
                -replace [regex]::Escape("},);"), "});" `
                -replace "get_or_insert_with", "get_or_init" `
                | Set-Content $to

            if ($name -in @("async_", "runtime", "threading", "networking", "file_system")) {
                (Get-Content $to) `
                    -replace "use fable_library_rust::Async_::Async;", "type Async<T> = T;" `
                    | Set-Content $to
            }
            if ($name -in @("async_", "runtime", "threading")) {
                (Get-Content $to) `
                    -replace "use fable_library_rust::System::Threading::CancellationToken;", "type CancellationToken = ();" `
                    | Set-Content $to
            }
            if ($name -in @("threading")) {
                (Get-Content $to) `
                    -replace "use fable_library_rust::System::Threading::CancellationTokenSource;", "type CancellationTokenSource = ();" `
                    | Set-Content $to
            }
            if ($name -in @("runtime", "threading", "file_system")) {
                (Get-Content $to) `
                    -replace "\s\sdefaultOf\(\);", " defaultOf::<()>();" `
                    | Set-Content $to
            }
            if ($name -eq "runtime") {
                (Get-Content $to) `
                    -replace "use fable_library_rust::System::Threading::Tasks::TaskCanceledException;", "type TaskCanceledException = ();" `
                    -replace "use fable_library_rust::System::Collections::Concurrent::ConcurrentStack_1;", "type ConcurrentStack_1<T> = T;" `
                    | Set-Content $to
            }
            if ($name -eq "common" -and !$Runtime) {
                (Get-Content $to) `
                    -replace "defaultOf\(\)", "defaultOf::<std::sync::Arc<dyn IDisposable>>()" `
                    | Set-Content $to
            }
            if ($name -eq "common" -and ($Runtime -eq "wasm" -or $Runtime -eq "contract")) {
                (Get-Content $to) `
                    -replace "defaultOf\(\)", "defaultOf::<std::rc::Rc<dyn IDisposable>>()" `
                    | Set-Content $to
            }
            if ($name -eq "lib") {
                (Get-Content $to) `
                    -replace "trace_state\(\)", "trace_state().get().clone()" `
                    | Set-Content $to
            }
        }
    }

    CopyItem "fsharp" "Common"
    CopyItem "spiral" "common"
    CopyItem "spiral" "date_time"
    CopyItem "spiral" "async_"
    CopyItem "spiral" "runtime"
    CopyItem "spiral" "threading"
    CopyItem "spiral" "networking"
    CopyItem "spiral" "file_system"
    CopyItem "spiral" "sm"
    CopyItem "spiral" "crypto"
    CopyItem "spiral" "trace"
    CopyItem "spiral" "lib"

    if ($Language -eq "rs" -and $Runtime -eq "contract") {
        Set-Content "$root/lib/spiral/date_time_contract.rs" ""
    }
}

function GetTargetDir {
    param (
        [Parameter(Mandatory)]
        [string] $ProjectName
    )
    $root = "$PSScriptRoot/../.."
    $result = (Resolve-Path "$root/target/polyglot/builder/$ProjectName").Path
    Write-Host "targetDir: $result"
    $result
}

function BuildFable {
    param (
        [Parameter(Mandatory)]
        [string] $TargetDir,
        [Parameter(Mandatory)]
        [string] $ProjectName,
        [Parameter(Mandatory)]
        [string] $Language,
        [string] $Runtime
    )
    dotnet fable "$TargetDir/$ProjectName.fsproj" --optimize --lang $Language --extension ".$Language" --outDir $TargetDir/target/$Language $($Runtime ? @("--define", $Runtime) : @())

    $root = "$PSScriptRoot/../.."
    CopyTarget $TargetDir $root $Language $Runtime.ToLower()
}


function GetFsxModules {
    @("lib/spiral/common.fsx", "lib/spiral/sm.fsx", "lib/spiral/crypto.fsx", "lib/spiral/date_time.fsx", "lib/spiral/async_.fsx", "lib/spiral/threading.fsx", "lib/spiral/networking.fsx", "lib/spiral/runtime.fsx", "lib/spiral/file_system.fsx", "lib/spiral/trace.fsx", "lib/spiral/lib.fsx")
}
