#if FABLE_COMPILER
[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module System =
 module Diagnostics =
  type Process = unit
  type DataReceivedEventArgs = unit
#endif
module State = let mutable trace_state = None
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and [<Struct>] US2 =
    | US2_0
    | US2_1
and [<Struct>] US1 =
    | US1_0
    | US1_1 of f1_0 : US2
    | US1_2
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
    | US3_1
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and Mut2 = {mutable l0 : US0}
and [<Struct>] US4 =
    | US4_0 of f0_0 : int64
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : int64
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : (struct (bool * string * int32) -> Async<unit>)
    | US6_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : System.Threading.CancellationToken
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : US0
    | US8_1
let rec closure0 () () : bool =
    let v0 : bool option = None
    let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : bool = null |> unbox<bool>
    v1 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v2 : bool = null |> unbox<bool>
    v2 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v3 : bool = null |> unbox<bool>
    v3 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v4 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v5 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v6 : bool = v5 v4
    v6 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v7 : bool = null |> unbox<bool>
    v7 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v8 : bool = Unchecked.defaultof<bool>
    v8 
    #endif
    |> fun x -> _v0 <- Some x
    let v9 : bool = _v0.Value
    v9
and closure1 () () : string =
    let v0 : bool option = None
    let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : bool = null |> unbox<bool>
    v1 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v2 : bool = null |> unbox<bool>
    v2 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v3 : bool = null |> unbox<bool>
    v3 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v4 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v5 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v6 : bool = v5 v4
    v6 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v7 : bool = null |> unbox<bool>
    v7 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v8 : bool = Unchecked.defaultof<bool>
    v8 
    #endif
    |> fun x -> _v0 <- Some x
    let v9 : bool = _v0.Value
    if v9 then
        let v10 : string = ".exe"
        v10
    else
        let v11 : string = ""
        v11
and method0 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and closure4 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure3 () (v0 : char) : (UH0 -> UH0) =
    closure4(v0)
and method1 () : (char -> (UH0 -> UH0)) =
    closure3()
and method2 (v0 : string, v1 : string, v2 : UH0, v3 : US1) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US2 = US2_0
                let v10 : US1 = US1_1(v9)
                method2(v0, v1, v5, v10)
            else
                match v3 with
                | US1_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US1 = US1_2
                    method2(v38, v1, v5, v39)
                | US1_1(v13) -> (* Path *)
                    match v13 with
                    | US2_0 -> (* Quoted *)
                        let v14 : US2 = US2_1
                        let v15 : US1 = US1_1(v14)
                        method2(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US1 = US1_2
                            method2(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method2(v0, v22, v5, v3)
                | US1_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US1 = US1_2
                        method2(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method2(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US2 = US2_0
                    let v54 : US1 = US1_1(v53)
                    method2(v0, v1, v5, v54)
                else
                    match v3 with
                    | US1_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US1 = US1_2
                        method2(v82, v1, v5, v83)
                    | US1_1(v57) -> (* Path *)
                        match v57 with
                        | US2_0 -> (* Quoted *)
                            let v58 : US2 = US2_1
                            let v59 : US1 = US1_1(v58)
                            method2(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US1 = US1_2
                                method2(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method2(v0, v66, v5, v3)
                    | US1_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US1 = US1_2
                            method2(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method2(v0, v77, v5, v3)
            else
                match v3 with
                | US1_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US1 = US1_2
                    method2(v126, v1, v5, v127)
                | US1_1(v94) -> (* Path *)
                    match v94 with
                    | US2_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US2 = US2_0
                            let v98 : US1 = US1_1(v97)
                            method2(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method2(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US1 = US1_2
                            method2(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method2(v0, v110, v5, v3)
                | US1_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US1 = US1_2
                        method2(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method2(v0, v121, v5, v3)
    | _ ->
        match v3 with
        | US1_2 -> (* Arguments *)
            let v152 : string = "\\"
            let v153 : string = "/"
            let v154 : string = v1.Replace (v152, v153)
            struct (v154, v0)
        | US1_1(v140) -> (* Path *)
            match v140 with
            | US2_0 -> (* Quoted *)
                let v141 : string = "\\"
                let v142 : string = "/"
                let v143 : string = v1.Replace (v141, v142)
                struct (v143, v0)
            | _ ->
                let v144 : string = "\\"
                let v145 : string = "/"
                let v146 : string = v1.Replace (v144, v145)
                struct (v146, v0)
        | US1_0 -> (* Start *)
            let v149 : string = "\\"
            let v150 : string = "/"
            let v151 : string = v1.Replace (v149, v150)
            struct (v151, v0)
and closure5 () (v0 : string) : US3 =
    US3_0(v0)
and method3 () : (string -> US3) =
    closure5()
and closure6 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : US0 option, v4 : string option) () : string =
    let v5 : string = $"execute_with_options_async / options: %A{struct (v0, v1, v2, v3, v4)}"
    v5
and closure7 () () : string =
    let v0 : string = ""
    v0
and method4 () : (unit -> string) =
    closure7()
and method6 (v0 : int64 option) : int64 option =
    v0
and method7 (v0 : int64 option) : int64 option =
    v0
and closure8 () () : struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US0 = US0_0
    let v3 : Mut2 = {l0 = v2} : Mut2
    let v4 : Mut1 = {l0 = false} : Mut1
    let v5 : int64 option option = None
    let mutable _v5 = v5
    #if INTERACTIVE || !FABLE_COMPILER
    let v6 : string option = None
    let mutable _v6 = v6
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = null |> unbox<string>
    v7 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v8 : string = null |> unbox<string>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v9 : string = null |> unbox<string>
    v9 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v10 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v10 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v11 : string = null |> unbox<string>
    v11 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v12 : string = Unchecked.defaultof<string>
    v12 
    #endif
    |> fun x -> _v6 <- Some x
    let v13 : string = _v6.Value
    let v15 : bool = v13 = "Microsoft.DotNet.Interactive.App"
    let v16 : bool = v15 <> true
    let v22 : US4 =
        if v16 then
            let v17 : System.DateTime = System.DateTime.Now
            let v18 : (System.DateTime -> int64) = _.Ticks
            let v19 : int64 = v18 v17
            US4_0(v19)
        else
            US4_1
    let v27 : int64 option =
        match v22 with
        | US4_1 -> (* None *)
            let v25 : int64 option = None
            v25
        | US4_0(v23) -> (* Some *)
            let v24 : int64 option = Some v23 
            v24
    let v28 : int64 option = method6(v27)
    v28 
    #else
    let v29 : int64 option = None
    let v30 : int64 option = method7(v29)
    v30 
    #endif
    |> fun x -> _v5 <- Some x
    let v31 : int64 option = _v5.Value
    struct (v1, v4, v0, v3, v31)
and closure10 () (v0 : int64) : US5 =
    US5_0(v0)
and method8 () : (int64 -> US5) =
    closure10()
and method9 () : string =
    let v0 : string = ""
    v0
and closure9 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure8()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    let v9 : string option = None
    let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : (int64 -> US5) = method8()
    let v11 : US5 = US5_1
    let v12 : US5 = v8 |> Option.map v10 |> Option.defaultValue v11 
    let v30 : System.DateTime =
        match v12 with
        | US5_1 -> (* None *)
            let v28 : System.DateTime = System.DateTime.Now
            v28
        | US5_0(v13) -> (* Some *)
            let v14 : System.DateTime = System.DateTime.Now
            let v15 : (System.DateTime -> int64) = _.Ticks
            let v16 : int64 = v15 v14
            let v17 : int64 = v16 - v13
            let v18 : System.TimeSpan = System.TimeSpan v17 
            let v19 : (System.TimeSpan -> int32) = _.Hours
            let v20 : int32 = v19 v18
            let v21 : (System.TimeSpan -> int32) = _.Minutes
            let v22 : int32 = v21 v18
            let v23 : (System.TimeSpan -> int32) = _.Seconds
            let v24 : int32 = v23 v18
            let v25 : (System.TimeSpan -> int32) = _.Milliseconds
            let v26 : int32 = v25 v18
            let v27 : System.DateTime = System.DateTime (1, 1, 1, v20, v22, v24, v26)
            v27
    let v31 : string = "hh:mm:ss"
    let v32 : string = v30.ToString v31 
    v32 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v33 : string = method9()
    v33 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = method9()
    v34 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v35 : (int64 -> US5) = method8()
    let v36 : US5 = US5_1
    let v37 : US5 = v8 |> Option.map v35 |> Option.defaultValue v36 
    let v55 : System.DateTime =
        match v37 with
        | US5_1 -> (* None *)
            let v53 : System.DateTime = System.DateTime.Now
            v53
        | US5_0(v38) -> (* Some *)
            let v39 : System.DateTime = System.DateTime.Now
            let v40 : (System.DateTime -> int64) = _.Ticks
            let v41 : int64 = v40 v39
            let v42 : int64 = v41 - v38
            let v43 : System.TimeSpan = System.TimeSpan v42 
            let v44 : (System.TimeSpan -> int32) = _.Hours
            let v45 : int32 = v44 v43
            let v46 : (System.TimeSpan -> int32) = _.Minutes
            let v47 : int32 = v46 v43
            let v48 : (System.TimeSpan -> int32) = _.Seconds
            let v49 : int32 = v48 v43
            let v50 : (System.TimeSpan -> int32) = _.Milliseconds
            let v51 : int32 = v50 v43
            let v52 : System.DateTime = System.DateTime (1, 1, 1, v45, v47, v49, v51)
            v52
    let v56 : string = "HH:mm:ss"
    let v57 : string = v55.ToString v56 
    v57 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v58 : string = method9()
    v58 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v59 : string = Unchecked.defaultof<string>
    v59 
    #endif
    |> fun x -> _v9 <- Some x
    let v60 : string = _v9.Value
    let v61 : int64 = v4.l0
    let v71 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v66 : string = "Critical"
            v66
        | US0_1 -> (* Debug *)
            let v63 : string = "Debug"
            v63
        | US0_2 -> (* Info *)
            let v64 : string = "Info"
            v64
        | US0_0 -> (* Verbose *)
            let v62 : string = "Verbose"
            v62
        | US0_3 -> (* Warning *)
            let v65 : string = "Warning"
            v65
    let v72 : string = v71.ToLower ()
    let v73 : string = $"{v60} #{v61} [{v72}] %s{v1 ()} / %s{v2 ()}"
    let v74 : (char []) = [||]
    let v75 : string = v73.TrimStart v74
    let v76 : (char []) = [|' '; '/'|]
    let v77 : string = v75.TrimEnd v76
    v77
and method5 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure8()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v9 : Mut0, v10 : Mut1, v11 : Mut1, v12 : Mut2, v13 : int64 option) = State.trace_state.Value
    let v14 : US0 = v12.l0
    let v15 : bool = v11.l0
    let v17 : bool =
        if v15 then
            let v16 : bool = v0 >= v14 
            v16
        else
            false
    if v17 then
        let v18 : int64 = v4.l0
        let v19 : int64 = v18 + 1L
        v4.l0 <- v19
        let v20 : (unit -> string) = closure9(v0, v1, v2)
        let v21 : string = $"%s{v20 ()}"
        let v22 : unit option = None
        let mutable _v22 = v22
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v23 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v23
        () 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v24 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v24
        () 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v25
        () 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        System.Console.WriteLine v21 
        () 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v21 
        () 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<unit>
        () 
        #endif
        |> fun x -> _v22 <- Some x
        _v22.Value
        ()
and closure12 () (v0 : (struct (bool * string * int32) -> Async<unit>)) : US6 =
    US6_0(v0)
and method10 () : ((struct (bool * string * int32) -> Async<unit>) -> US6) =
    closure12()
and closure13 (v0 : string) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure11 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : US0 option, v4 : string option, v5 : System.Diagnostics.Process, v6 : System.Collections.Concurrent.ConcurrentStack<string>) (v7 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v8 : Async<unit> option = None
    let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    v9 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : Async<unit> option = None
    let mutable _v12 = v12
    async {
    let v13 : string = v7.Data
    let v14 : string = null |> unbox<string>
    let v15 : bool = v13 = v14
    let v16 : bool = v15 <> true
    if v16 then
        let v17 : ((struct (bool * string * int32) -> Async<unit>) -> US6) = method10()
        let v18 : US6 = US6_1
        let v19 : US6 = v2 |> Option.map v17 |> Option.defaultValue v18 
        match v19 with
        | US6_1 -> (* None *)
            ()
        | US6_0(v20) -> (* Some *)
            let v21 : int32 = v5.Id
            let v22 : Async<unit> = v20 struct (false, v13, v21)
            do! v22 
            ()
        let v23 : US0 = US0_0
        let v24 : (unit -> string) = closure13(v13)
        let v25 : (unit -> string) = closure7()
        method5(v23, v24, v25)
        let v26 : string = ""
        let v27 : string = $"{v26}{v13}{v26}"
        let v28 : (string -> unit) = v6.Push
        v28 v27
    }
    |> fun x -> _v12 <- Some x
    let v29 : Async<unit> = _v12 |> Option.get
    v29 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v30 : Async<unit> = null |> unbox<Async<unit>>
    v30 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v31 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v31 
    #endif
    |> fun x -> _v8 <- Some x
    let v32 : Async<unit> = _v8.Value
    let v33 : unit option = None
    let mutable _v33 = v33
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    () 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    () 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    () 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v34 : (Async<unit> -> unit) = Async.StartImmediate
    v34 v32
    () 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    () 
    #endif
    |> fun x -> _v33 <- Some x
    _v33.Value
    ()
and closure14 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : US0 option, v4 : string option, v5 : System.Diagnostics.Process, v6 : System.Collections.Concurrent.ConcurrentStack<string>) (v7 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v8 : Async<unit> option = None
    let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    v9 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : Async<unit> option = None
    let mutable _v12 = v12
    async {
    let v13 : string = v7.Data
    let v14 : string = null |> unbox<string>
    let v15 : bool = v13 = v14
    let v16 : bool = v15 <> true
    if v16 then
        let v17 : ((struct (bool * string * int32) -> Async<unit>) -> US6) = method10()
        let v18 : US6 = US6_1
        let v19 : US6 = v2 |> Option.map v17 |> Option.defaultValue v18 
        match v19 with
        | US6_1 -> (* None *)
            ()
        | US6_0(v20) -> (* Some *)
            let v21 : int32 = v5.Id
            let v22 : Async<unit> = v20 struct (true, v13, v21)
            do! v22 
            ()
        let v23 : US0 = US0_0
        let v24 : (unit -> string) = closure13(v13)
        let v25 : (unit -> string) = closure7()
        method5(v23, v24, v25)
        let v26 : string = "["
        let v27 : string = "]"
        let v28 : string = $"{v26}{v13}{v27}"
        let v29 : (string -> unit) = v6.Push
        v29 v28
    }
    |> fun x -> _v12 <- Some x
    let v30 : Async<unit> = _v12 |> Option.get
    v30 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v31 : Async<unit> = null |> unbox<Async<unit>>
    v31 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v32 
    #endif
    |> fun x -> _v8 <- Some x
    let v33 : Async<unit> = _v8.Value
    let v34 : unit option = None
    let mutable _v34 = v34
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    () 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    () 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    () 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v35 : (Async<unit> -> unit) = Async.StartImmediate
    v35 v33
    () 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    () 
    #endif
    |> fun x -> _v34 <- Some x
    _v34.Value
    ()
and closure15 () (v0 : System.Threading.CancellationToken) : US7 =
    US7_0(v0)
and method11 () : (System.Threading.CancellationToken -> US7) =
    closure15()
and closure16 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = null |> unbox<bool>
    v2 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v3 : bool = null |> unbox<bool>
    v3 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v4 : bool = null |> unbox<bool>
    v4 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : bool = v0.HasExited
    v5 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v6 : bool = null |> unbox<bool>
    v6 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v7 : bool = Unchecked.defaultof<bool>
    v7 
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : bool = _v1.Value
    let v9 : bool = v8 = false
    if v9 then
        let v10 : unit option = None
        let mutable _v10 = v10
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        null |> unbox<unit>
        () 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        null |> unbox<unit>
        () 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        null |> unbox<unit>
        () 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v11 : (unit -> unit) = v0.Kill
        v11 ()
        () 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        null |> unbox<unit>
        () 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<unit>
        () 
        #endif
        |> fun x -> _v10 <- Some x
        _v10.Value
        ()
and closure17 (v0 : System.Threading.Tasks.TaskCanceledException) () : string =
    let v1 : string = $"execute_with_options_async / WaitForExitAsync / ex: %A{v0}"
    v1
and method12 () : string =
    let v0 : string = "\n"
    v0
and closure18 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and closure19 () (v0 : US0) : US8 =
    US8_0(v0)
and method13 () : (US0 -> US8) =
    closure19()
and closure2 () (v0 : string) : Async<struct (int32 * string)> =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v3 : string option = None
    let v4 : US0 option = None
    let v5 : Async<struct (int32 * string)> option = None
    let mutable _v5 = v5
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v6 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v7 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v7 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v8 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v9 : Async<struct (int32 * string)> option = None
    let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v10 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v11 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v12 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v12 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : Async<struct (int32 * string)> option = None
    let mutable _v13 = v13
    async {
    let struct (v14 : string, v15 : string) = method0()
    let v16 : char seq = v0 |> unbox<char seq>
    let v17 : (char seq -> char list) = Seq.toList
    let v18 : char list = v17 v16
    let v19 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v20 : (char -> (UH0 -> UH0)) = method1()
    let v21 : (char list -> (UH0 -> UH0)) = v19 v20
    let v22 : (UH0 -> UH0) = v21 v18
    let v23 : UH0 = UH0_0
    let v24 : UH0 = v22 v23
    let v25 : US1 = US1_0
    let struct (v26 : string, v27 : string) = method2(v15, v14, v24, v25)
    let v28 : (string -> US3) = method3()
    let v29 : US3 = US3_1
    let v30 : US3 = v3 |> Option.map v28 |> Option.defaultValue v29 
    let v34 : string =
        match v30 with
        | US3_1 -> (* None *)
            let v32 : string = ""
            v32
        | US3_0(v31) -> (* Some *)
            v31
    let v35 : US0 = US0_1
    let v36 : (unit -> string) = closure6(v1, v0, v2, v4, v3)
    let v37 : (unit -> string) = method4()
    method5(v35, v36, v37)
    let v38 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v39 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v27, StandardOutputEncoding = v38, WorkingDirectory = v34, FileName = v26, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v40 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v39)
    use v40 = v40 
    let v41 : System.Diagnostics.Process = v40 
    let v42 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v43 : System.Collections.Concurrent.ConcurrentStack<string> = v42 ()
    let v44 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure11(v1, v0, v2, v4, v3, v41, v43)
    v41.OutputDataReceived.Add v44 
    let v45 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure14(v1, v0, v2, v4, v3, v41, v43)
    v41.ErrorDataReceived.Add v45 
    let v46 : (unit -> bool) = v41.Start
    let v47 : bool = v46 ()
    let v48 : bool = v47 = false
    if v48 then
        let v49 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v49
    let v50 : (unit -> unit) = v41.BeginErrorReadLine
    v50 ()
    let v51 : (unit -> unit) = v41.BeginOutputReadLine
    v51 ()
    let v52 : (System.Threading.CancellationToken -> US7) = method11()
    let v53 : US7 = US7_1
    let v54 : US7 = v1 |> Option.map v52 |> Option.defaultValue v53 
    let v58 : System.Threading.CancellationToken =
        match v54 with
        | US7_1 -> (* None *)
            let v56 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v56
        | US7_0(v55) -> (* Some *)
            v55
    let v59 : Async<System.Threading.CancellationToken> option = None
    let mutable _v59 = v59
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v60 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v60 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v61 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v61 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v62 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v62 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v63 : Async<System.Threading.CancellationToken> option = None
    let mutable _v63 = v63
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v64 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v64 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v65 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v65 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v66 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v66 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v67 : Async<System.Threading.CancellationToken> option = None
    let mutable _v67 = v67
    async {
    let v68 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v68 = v68 
    let v69 : System.Threading.CancellationToken = v68 
    let v70 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v71 : (System.Threading.CancellationToken []) = [|v69; v70; v58|]
    let v72 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v73 : System.Threading.CancellationTokenSource = v72 v71
    let v74 : System.Threading.CancellationToken = v73.Token
    return v74 
    }
    |> fun x -> _v67 <- Some x
    let v75 : Async<System.Threading.CancellationToken> = _v67 |> Option.get
    v75 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v76 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v76 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v77 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v77 
    #endif
    |> fun x -> _v63 <- Some x
    let v78 : Async<System.Threading.CancellationToken> = _v63.Value
    v78 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v79 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v79 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v80 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v80 
    #endif
    |> fun x -> _v59 <- Some x
    let v81 : Async<System.Threading.CancellationToken> = _v59.Value
    let! v81 = v81 
    let v82 : System.Threading.CancellationToken = v81 
    let v83 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v82.Register
    let v84 : (unit -> unit) = closure16(v41)
    let v85 : System.Threading.CancellationTokenRegistration = v83 v84
    use v85 = v85 
    let v86 : System.Threading.CancellationTokenRegistration = v85 
    let v87 : Async<int32> option = None
    let mutable _v87 = v87
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : Async<int32> = null |> unbox<Async<int32>>
    v88 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v89 : Async<int32> = null |> unbox<Async<int32>>
    v89 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v90 : Async<int32> = null |> unbox<Async<int32>>
    v90 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v91 : Async<int32> option = None
    let mutable _v91 = v91
    async {
    try
    let v92 : System.Threading.Tasks.Task = v41.WaitForExitAsync v82 
    let v93 : Async<unit> option = None
    let mutable _v93 = v93
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v94 : Async<unit> = null |> unbox<Async<unit>>
    v94 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v95 : Async<unit> = null |> unbox<Async<unit>>
    v95 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v96 : Async<unit> = null |> unbox<Async<unit>>
    v96 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v97 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v98 : Async<unit> = v97 v92
    v98 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v99 : Async<unit> = null |> unbox<Async<unit>>
    v99 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v100 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v100 
    #endif
    |> fun x -> _v93 <- Some x
    let v101 : Async<unit> = _v93.Value
    do! v101 
    let v102 : int32 = v41.ExitCode
    return v102 
    with ex ->
    let v103 : exn = ex
    let v104 : string option = None
    let mutable _v104 = v104
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v105 : string = $"%A{v103}"
    v105 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v106 : string = $"%A{v103}"
    v106 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = $"%A{v103}"
    v107 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v108 : string = $"{v103.GetType ()}: {v103.Message}"
    v108 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v109 : string = $"%A{v103}"
    v109 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v110 : string = Unchecked.defaultof<string>
    v110 
    #endif
    |> fun x -> _v104 <- Some x
    let v111 : string = _v104.Value
    let v112 : (string -> unit) = v43.Push
    v112 v111
    let v113 : System.Threading.Tasks.TaskCanceledException = v103 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v114 : US0 = US0_3
    let v115 : (unit -> string) = closure17(v113)
    let v116 : (unit -> string) = method4()
    method5(v114, v115, v116)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v91 <- Some x
    let v117 : Async<int32> = _v91 |> Option.get
    v117 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v118 : Async<int32> = null |> unbox<Async<int32>>
    v118 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v119 : Async<int32> = Unchecked.defaultof<Async<int32>>
    v119 
    #endif
    |> fun x -> _v87 <- Some x
    let v120 : Async<int32> = _v87.Value
    let! v120 = v120 
    let v121 : int32 = v120 
    let v122 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v123 : string seq = v122 v43
    let v124 : string = method12()
    let v125 : (string -> (string seq -> string)) = String.concat
    let v126 : (string seq -> string) = v125 v124
    let v127 : string = v126 v123
    let v128 : US0 = US0_1
    let v129 : (unit -> string) = closure18(v121, v127)
    let v130 : (unit -> string) = method4()
    method5(v128, v129, v130)
    return struct (v121, v127) 
    }
    |> fun x -> _v13 <- Some x
    let v131 : Async<struct (int32 * string)> = _v13 |> Option.get
    v131 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v132 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v132 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v133 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v133 
    #endif
    |> fun x -> _v9 <- Some x
    let v134 : Async<struct (int32 * string)> = _v9.Value
    let v135 : (US0 -> US8) = method13()
    let v136 : US8 = US8_1
    let v137 : US8 = v4 |> Option.map v135 |> Option.defaultValue v136 
    let v158 : Async<struct (int32 * string)> =
        match v137 with
        | US8_1 -> (* None *)
            v134
        | US8_0(v138) -> (* Some *)
            let v139 : Async<struct (int32 * string)> option = None
            let mutable _v139 = v139
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v140 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v140 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v141 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v141 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v142 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v142 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v143 : Async<struct (int32 * string)> option = None
            let mutable _v143 = v143
            async {
            let v144 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure8()
            if State.trace_state = None then State.trace_state <- v144 () |> Some
            let struct (v145 : Mut0, v146 : Mut1, v147 : Mut1, v148 : Mut2, v149 : int64 option) = State.trace_state.Value
            let v150 : US0 = v148.l0
            try
            v148.l0 <- v138
            return! v134 
            finally
            v148.l0 <- v150
            (*
            let struct (v151 : int32, v152 : string) = *)
            }
            |> fun x -> _v143 <- Some x
            let v153 : Async<struct (int32 * string)> = _v143 |> Option.get
            v153 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v154 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v154 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v155 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
            v155 
            #endif
            |> fun x -> _v139 <- Some x
            let v156 : Async<struct (int32 * string)> = _v139.Value
            v156
    v158 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v159 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v159 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v160 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v160 
    #endif
    |> fun x -> _v5 <- Some x
    let v161 : Async<struct (int32 * string)> = _v5.Value
    v161
and closure20 () struct (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : US0 option, v4 : string option) : Async<struct (int32 * string)> =
    let v5 : Async<struct (int32 * string)> option = None
    let mutable _v5 = v5
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v6 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v7 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v7 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v8 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v9 : Async<struct (int32 * string)> option = None
    let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v10 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v11 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v12 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v12 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : Async<struct (int32 * string)> option = None
    let mutable _v13 = v13
    async {
    let struct (v14 : string, v15 : string) = method0()
    let v16 : char seq = v1 |> unbox<char seq>
    let v17 : (char seq -> char list) = Seq.toList
    let v18 : char list = v17 v16
    let v19 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v20 : (char -> (UH0 -> UH0)) = method1()
    let v21 : (char list -> (UH0 -> UH0)) = v19 v20
    let v22 : (UH0 -> UH0) = v21 v18
    let v23 : UH0 = UH0_0
    let v24 : UH0 = v22 v23
    let v25 : US1 = US1_0
    let struct (v26 : string, v27 : string) = method2(v15, v14, v24, v25)
    let v28 : (string -> US3) = method3()
    let v29 : US3 = US3_1
    let v30 : US3 = v4 |> Option.map v28 |> Option.defaultValue v29 
    let v34 : string =
        match v30 with
        | US3_1 -> (* None *)
            let v32 : string = ""
            v32
        | US3_0(v31) -> (* Some *)
            v31
    let v35 : US0 = US0_1
    let v36 : (unit -> string) = closure6(v0, v1, v2, v3, v4)
    let v37 : (unit -> string) = method4()
    method5(v35, v36, v37)
    let v38 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v39 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v27, StandardOutputEncoding = v38, WorkingDirectory = v34, FileName = v26, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v40 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v39)
    use v40 = v40 
    let v41 : System.Diagnostics.Process = v40 
    let v42 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v43 : System.Collections.Concurrent.ConcurrentStack<string> = v42 ()
    let v44 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure11(v0, v1, v2, v3, v4, v41, v43)
    v41.OutputDataReceived.Add v44 
    let v45 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure14(v0, v1, v2, v3, v4, v41, v43)
    v41.ErrorDataReceived.Add v45 
    let v46 : (unit -> bool) = v41.Start
    let v47 : bool = v46 ()
    let v48 : bool = v47 = false
    if v48 then
        let v49 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v49
    let v50 : (unit -> unit) = v41.BeginErrorReadLine
    v50 ()
    let v51 : (unit -> unit) = v41.BeginOutputReadLine
    v51 ()
    let v52 : (System.Threading.CancellationToken -> US7) = method11()
    let v53 : US7 = US7_1
    let v54 : US7 = v0 |> Option.map v52 |> Option.defaultValue v53 
    let v58 : System.Threading.CancellationToken =
        match v54 with
        | US7_1 -> (* None *)
            let v56 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v56
        | US7_0(v55) -> (* Some *)
            v55
    let v59 : Async<System.Threading.CancellationToken> option = None
    let mutable _v59 = v59
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v60 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v60 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v61 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v61 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v62 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v62 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v63 : Async<System.Threading.CancellationToken> option = None
    let mutable _v63 = v63
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v64 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v64 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v65 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v65 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v66 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v66 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v67 : Async<System.Threading.CancellationToken> option = None
    let mutable _v67 = v67
    async {
    let v68 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v68 = v68 
    let v69 : System.Threading.CancellationToken = v68 
    let v70 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v71 : (System.Threading.CancellationToken []) = [|v69; v70; v58|]
    let v72 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v73 : System.Threading.CancellationTokenSource = v72 v71
    let v74 : System.Threading.CancellationToken = v73.Token
    return v74 
    }
    |> fun x -> _v67 <- Some x
    let v75 : Async<System.Threading.CancellationToken> = _v67 |> Option.get
    v75 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v76 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v76 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v77 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v77 
    #endif
    |> fun x -> _v63 <- Some x
    let v78 : Async<System.Threading.CancellationToken> = _v63.Value
    v78 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v79 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v79 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v80 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v80 
    #endif
    |> fun x -> _v59 <- Some x
    let v81 : Async<System.Threading.CancellationToken> = _v59.Value
    let! v81 = v81 
    let v82 : System.Threading.CancellationToken = v81 
    let v83 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v82.Register
    let v84 : (unit -> unit) = closure16(v41)
    let v85 : System.Threading.CancellationTokenRegistration = v83 v84
    use v85 = v85 
    let v86 : System.Threading.CancellationTokenRegistration = v85 
    let v87 : Async<int32> option = None
    let mutable _v87 = v87
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : Async<int32> = null |> unbox<Async<int32>>
    v88 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v89 : Async<int32> = null |> unbox<Async<int32>>
    v89 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v90 : Async<int32> = null |> unbox<Async<int32>>
    v90 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v91 : Async<int32> option = None
    let mutable _v91 = v91
    async {
    try
    let v92 : System.Threading.Tasks.Task = v41.WaitForExitAsync v82 
    let v93 : Async<unit> option = None
    let mutable _v93 = v93
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v94 : Async<unit> = null |> unbox<Async<unit>>
    v94 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v95 : Async<unit> = null |> unbox<Async<unit>>
    v95 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v96 : Async<unit> = null |> unbox<Async<unit>>
    v96 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v97 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v98 : Async<unit> = v97 v92
    v98 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v99 : Async<unit> = null |> unbox<Async<unit>>
    v99 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v100 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v100 
    #endif
    |> fun x -> _v93 <- Some x
    let v101 : Async<unit> = _v93.Value
    do! v101 
    let v102 : int32 = v41.ExitCode
    return v102 
    with ex ->
    let v103 : exn = ex
    let v104 : string option = None
    let mutable _v104 = v104
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v105 : string = $"%A{v103}"
    v105 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v106 : string = $"%A{v103}"
    v106 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = $"%A{v103}"
    v107 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v108 : string = $"{v103.GetType ()}: {v103.Message}"
    v108 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v109 : string = $"%A{v103}"
    v109 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v110 : string = Unchecked.defaultof<string>
    v110 
    #endif
    |> fun x -> _v104 <- Some x
    let v111 : string = _v104.Value
    let v112 : (string -> unit) = v43.Push
    v112 v111
    let v113 : System.Threading.Tasks.TaskCanceledException = v103 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v114 : US0 = US0_3
    let v115 : (unit -> string) = closure17(v113)
    let v116 : (unit -> string) = method4()
    method5(v114, v115, v116)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v91 <- Some x
    let v117 : Async<int32> = _v91 |> Option.get
    v117 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v118 : Async<int32> = null |> unbox<Async<int32>>
    v118 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v119 : Async<int32> = Unchecked.defaultof<Async<int32>>
    v119 
    #endif
    |> fun x -> _v87 <- Some x
    let v120 : Async<int32> = _v87.Value
    let! v120 = v120 
    let v121 : int32 = v120 
    let v122 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v123 : string seq = v122 v43
    let v124 : string = method12()
    let v125 : (string -> (string seq -> string)) = String.concat
    let v126 : (string seq -> string) = v125 v124
    let v127 : string = v126 v123
    let v128 : US0 = US0_1
    let v129 : (unit -> string) = closure18(v121, v127)
    let v130 : (unit -> string) = method4()
    method5(v128, v129, v130)
    return struct (v121, v127) 
    }
    |> fun x -> _v13 <- Some x
    let v131 : Async<struct (int32 * string)> = _v13 |> Option.get
    v131 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v132 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v132 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v133 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v133 
    #endif
    |> fun x -> _v9 <- Some x
    let v134 : Async<struct (int32 * string)> = _v9.Value
    let v135 : (US0 -> US8) = method13()
    let v136 : US8 = US8_1
    let v137 : US8 = v3 |> Option.map v135 |> Option.defaultValue v136 
    let v158 : Async<struct (int32 * string)> =
        match v137 with
        | US8_1 -> (* None *)
            v134
        | US8_0(v138) -> (* Some *)
            let v139 : Async<struct (int32 * string)> option = None
            let mutable _v139 = v139
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v140 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v140 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v141 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v141 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v142 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v142 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v143 : Async<struct (int32 * string)> option = None
            let mutable _v143 = v143
            async {
            let v144 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure8()
            if State.trace_state = None then State.trace_state <- v144 () |> Some
            let struct (v145 : Mut0, v146 : Mut1, v147 : Mut1, v148 : Mut2, v149 : int64 option) = State.trace_state.Value
            let v150 : US0 = v148.l0
            try
            v148.l0 <- v138
            return! v134 
            finally
            v148.l0 <- v150
            (*
            let struct (v151 : int32, v152 : string) = *)
            }
            |> fun x -> _v143 <- Some x
            let v153 : Async<struct (int32 * string)> = _v143 |> Option.get
            v153 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v154 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v154 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v155 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
            v155 
            #endif
            |> fun x -> _v139 <- Some x
            let v156 : Async<struct (int32 * string)> = _v139.Value
            v156
    v158 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v159 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v159 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v160 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v160 
    #endif
    |> fun x -> _v5 <- Some x
    let v161 : Async<struct (int32 * string)> = _v5.Value
    v161
let v0 : (unit -> bool) = closure0()
let is_windows () = v0 ()
let v1 : (unit -> string) = closure1()
let get_executable_suffix () = v1 ()
let v2 : (string -> Async<struct (int32 * string)>) = closure2()
let execute_async x = v2 x
let v3 : (struct (System.Threading.CancellationToken option * string * (struct (bool * string * int32) -> Async<unit>) option * US0 option * string option) -> Async<struct (int32 * string)>) = closure20()
let execute_with_options_async x = v3 x
type RuntimeTraceLevel = US0 
()
