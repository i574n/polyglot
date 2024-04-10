#if !INTERACTIVE
namespace Polyglot
#endif

module Common =

#if !INTERACTIVE
    open Lib
#endif

    let nl = System.Environment.NewLine
    let q = @""""

    let inline cons head tail = head :: tail

    /// ## memoize

    let inline memoize fn =
        let result = lazy fn ()
        fun () -> result.Value

    /// ## TraceLevel

    type TraceLevel =
        | Verbose
        | Debug
        | Info
        | Warning
        | Critical

    let inline getLocals () = ""

    /// ## trace

    let to_trace_level = function
        | Verbose -> SpiralTrace.US0_0
        | Debug -> SpiralTrace.US0_1
        | Info -> SpiralTrace.US0_2
        | Warning -> SpiralTrace.US0_3
        | Critical -> SpiralTrace.US0_4

    let trace level fn getLocals =
        let level = level |> to_trace_level
        SpiralTrace.trace level fn getLocals
