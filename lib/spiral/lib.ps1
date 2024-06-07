function FixRust {
    param (
        [Parameter(Mandatory, ValueFromPipeline)]
        $text
    )
    process {
        $text `
            -replace [regex]::Escape("),);"), "));" `
            -replace [regex]::Escape("},);"), "});" `
            -replace "get_or_insert_with", "get_or_init" `
            -replace "_self_.", "self." `
            -replace "\s\sdefaultOf\(\);", " defaultOf::<()>();" `
            -replace "use fable_library_rust::System::Collections::Concurrent::ConcurrentStack_1;", "type ConcurrentStack_1<T> = T;" `
            -replace "use fable_library_rust::System::Threading::CancellationToken;", "type CancellationToken = ();" `
            -replace "use fable_library_rust::System::Threading::Tasks::TaskCanceledException;", "type TaskCanceledException = ();" `
            -replace "use fable_library_rust::System::TimeZoneInfo;", "type TimeZoneInfo = i64;"
    }
}

function TsVersion {
    "4.17.0"
}

function FixTypeScript {
    param (
        [Parameter(Mandatory, ValueFromPipeline)]
        $text
    )
    process {
        $text `
            -replace "\./fable_modules/fable-library-ts.$(TsVersion)/", "./deps/Fable/src/fable-library-ts/" `
            -replace "from `"\./deps/", "from `"../../polyglot/deps/"
    }
}

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
        $name = $Language -eq "py" -and @("threading", "platform") -contains $name ? "$($name)_" : $name
        $name = $Language -eq "py" ? $name.ToLower() : $name
        $from = "$TargetDir/target/$Language/lib/$lib/$name.$Language"
        $to = "$root/lib/$lib/$name$_runtime.$Language"
        Copy-Item $from $to -Force

        $text = Get-Content $to

        if ($Language -eq "ts") {
            $text = $text `
                -replace "this\$.tag", "(this$ as any)['tag']" `
                -replace "../../../../../../../../", "../../" `
                | FixTypeScript
        }
        if ($Language -eq "rs") {
            $text = $text `
                | FixRust

            if ($name -in @("async_", "runtime", "threading", "networking", "file_system")) {
                $text = $text `
                    -replace "use fable_library_rust::Async_::Async;", "type Async<T> = T;"
            }
            if ($name -in @("threading")) {
                $text = $text `
                    -replace "use fable_library_rust::System::Threading::CancellationTokenSource;", "type CancellationTokenSource = ();"
            }
            if ($name -in @("common") -and !$Runtime) {
                $text = $text `
                    -replace "defaultOf\(\)", "defaultOf::<std::sync::Arc<dyn IDisposable>>()"
            }
            if ($name -in @("file_system") -and $Runtime -eq "contract") {
                $text = $text `
                    -replace "defaultOf\(\),", "defaultOf::<std::rc::Rc<dyn IDisposable>>(),"
            }
            if ($name -in @("file_system") -and $Runtime -ne "contract") {
                $text = $text `
                    -replace "defaultOf\(\),", "defaultOf::<std::sync::Arc<dyn IDisposable>>(),"
            }
            if ($name -in @("common") -and $Runtime -in @("wasm", "contract")) {
                $text = $text `
                    -replace "defaultOf\(\),", "defaultOf::<std::rc::Rc<dyn IDisposable>>(),"
            }
            if ($name -eq "file_system" -and $Runtime -in @("contract")) {
                $text = $text `
                    -replace "chrono::Utc", "()" `
                    -replace "chrono::Local", "()" `
                    -replace "chrono::DateTime", "Option" `
                    -replace "use fable_library_rust::DateTime_::DateTime;", "type DateTime = ();" `
                    -replace "use fable_library_rust::Guid_::Guid;", "type Guid = ();"
            }
        }

        $text | Set-Content $to
    }

    CopyItem "fsharp" "Common"
    CopyItem "spiral" "common"
    CopyItem "spiral" "date_time"
    CopyItem "spiral" "async_"
    CopyItem "spiral" "platform"
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
    $result = (Resolve-Path "$root/target/Builder/$ProjectName").Path
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
    $root = "$PSScriptRoot/../.."

    { dotnet fable "$TargetDir/$ProjectName.fsproj" --optimize --lang $Language --extension ".$Language" --outDir $TargetDir/target/$Language --define $($IsWindows ? "_WINDOWS" : "_LINUX") $($Runtime ? @("--define", $Runtime) : @()) } | Invoke-Block -Location $root

    CopyTarget $TargetDir $root $Language $Runtime.ToLower()
}


function GetFsxModules {
    @("lib/spiral/common.fsx", "lib/spiral/sm.fsx", "lib/spiral/crypto.fsx", "lib/spiral/date_time.fsx", "lib/spiral/async_.fsx", "lib/spiral/threading.fsx", "lib/spiral/networking.fsx", "lib/spiral/platform.fsx", "lib/spiral/runtime.fsx", "lib/spiral/file_system.fsx", "lib/spiral/trace.fsx", "lib/spiral/lib.fsx")
}
