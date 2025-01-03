param(
    $fast,
    $sequential,
    $SkipFsx,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../scripts/core.ps1


if (!$fast) {
    {
        . ../../apps/spiral/dist/Supervisor$(_exe) `
            --exit-on-error `
            $(!$sequential ? @("--parallel") : @()) `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path parsing.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path sm'.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path rust/rust.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path rust/testing.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path rust/near.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path rust/near_workspaces.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path testing.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path guid.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path async.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path runtime.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path trace.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path am'.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path crypto.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path common.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path resultm.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path console.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path base.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path date_time.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path math.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path mapm.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path optionm'.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path listm'.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path reflection.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path iter.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path wasm.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path leptos/leptos.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path util.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path platform.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path stream.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path threading.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path benchmark.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path physics.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path seq.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path env.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path python.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path typescript.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path file_system.dib --retries 3" `
            --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path networking.dib --retries 3" `
    } | Invoke-Block
}

{ . ../../apps/parser/dist/DibParser$(_exe) testing.dib spi async.dib spi runtime.dib spi trace.dib spi threading.dib spi networking.dib spi crypto.dib spi common.dib spi base.dib spi resultm.dib spi iter.dib spi env.dib spi parsing.dib spi console.dib spi date_time.dib spi file_system.dib spi guid.dib spi math.dib spi mapm.dib spi "optionm'.dib" spi "am'.dib" spi "sm'.dib" spi "sm'.dib" spir "listm'.dib" spi reflection.dib spi python.dib spi typescript.dib spi benchmark.dib spi stream.dib spi seq.dib spi util.dib spi platform.dib spi rust/rust.dib spi rust/testing.dib spi rust/near.dib spi rust/near_workspaces.dib spi physics.dib spi leptos/leptos.dib spi wasm.dib spi } | Invoke-Block

if (!$SkipFsx) {
    { . ../../apps/spiral/dist/Supervisor$(_exe) --parallel --build-file async.spi async_.fsx --build-file runtime.spi runtime.fsx --build-file trace.spi trace.fsx --build-file threading.spi threading.fsx --build-file networking.spi networking.fsx --build-file crypto.spi crypto.fsx --build-file common.spi common.fsx --build-file date_time.spi date_time.fsx --build-file platform.spi platform.fsx --build-file file_system.spi file_system.fsx --build-file guid.spi guid.fsx --build-file "sm'.spi" sm.fsx } | Invoke-Block -Retries 3
}

Remove-Item "async.fsx" -Force -ErrorAction Ignore
Remove-Item "sm'.fsx" -Force -ErrorAction Ignore
