#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
type IOsEnviron = abstract environ: x: unit -> obj
type [<Struct>] US0 =
    | US0_0 of f0_0 : string
    | US0_1
and [<Struct>] US1 =
    | US1_0
    | US1_1
    | US1_2
and [<Struct>] US2 =
    | US2_0 of f0_0 : US1
    | US2_1 of f1_0 : US1
    | US2_2 of f2_0 : US1
    | US2_3 of f3_0 : US1
    | US2_4 of f4_0 : US1
and Mut0 = {mutable l0 : float}
and [<Struct>] US3 =
    | US3_0 of f0_0 : int32 * f0_1 : float * f0_2 : char
    | US3_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : float * f0_1 : char
    | US4_1
let rec method0 () : string =
    let v0 : string = "VSCODE_PID"
    v0
and method2 () : string =
    let v0 : string = ""
    v0
and closure1 () (v0 : string) : US0 =
    US0_0(v0)
and method3 () : (string -> US0) =
    closure1()
and method1 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::env::var(&*$0)"
    let v3 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "x"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "fable_library_rust::String_::fromString($0)"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "true; $0 })"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "_result_map_"
    let v13 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = method2()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "std::env::var(&*$0)"
    let v18 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v17 
    let v19 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "x"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "fable_library_rust::String_::fromString($0)"
    let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "true; $0 })"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "_result_map_"
    let v28 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = method2()
    let v30 : string = "$0.unwrap_or($1)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr struct (v28, v29) v30 
    let _v1 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "std::env::var(&*$0)"
    let v33 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "x"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "true; $0 })"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "_result_map_"
    let v43 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = method2()
    let v45 : string = "$0.unwrap_or($1)"
    let v46 : string = Fable.Core.RustInterop.emitRustExpr struct (v43, v44) v45 
    let _v1 = v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : string = "process.env[$0] ?? \"\""
    let v48 : string = Fable.Core.JsInterop.emitJsExpr v0 v47 
    let _v1 = v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : string = "os"
    let v50 : IOsEnviron = Fable.Core.PyInterop.importAll v49 
    let v51 : string = "v50.environ"
    let v52 : obj = Fable.Core.PyInterop.emitPyExpr () v51 
    let v55 : string = "v52.get($0)"
    let v56 : string = Fable.Core.PyInterop.emitPyExpr v0 v55 
    let mutable _v56 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v59 : (string -> string option) = Option.ofObj
    let v60 : string option = v59 v56
    v60 
    #else
    Some v56 
    #endif
    |> fun x -> _v56 <- Some x
    let v61 : string option = match _v56 with Some x -> x | None -> failwith "optionm'.of_obj / _v56=None"
    let v64 : (string -> US0) = method3()
    let v65 : US0 option = v61 |> Option.map v64 
    let v76 : US0 = US0_1
    let v77 : US0 = v65 |> Option.defaultValue v76 
    let v84 : string =
        match v77 with
        | US0_1 -> (* None *)
            let v82 : string = ""
            v82
        | US0_0(v81) -> (* Some *)
            v81
    let _v1 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v85 : US1 = US1_1
    let v86 : US2 = US2_0(v85)
    let v87 : string = $"env.get_environment_variable / target: {v86} / var: {v0}"
    let v88 : string = failwith<string> v87
    let _v1 = v88 
    #endif
#else
    let v89 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v90 : string = v89 v0
    let mutable _v90 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v91 : (string -> string option) = Option.ofObj
    let v92 : string option = v91 v90
    v92 
    #else
    Some v90 
    #endif
    |> fun x -> _v90 <- Some x
    let v93 : string option = match _v90 with Some x -> x | None -> failwith "optionm'.of_obj / _v90=None"
    let v96 : (string -> US0) = method3()
    let v97 : US0 option = v93 |> Option.map v96 
    let v108 : US0 = US0_1
    let v109 : US0 = v97 |> Option.defaultValue v108 
    let v116 : string =
        match v109 with
        | US0_1 -> (* None *)
            let v114 : string = ""
            v114
        | US0_0(v113) -> (* Some *)
            v113
    let _v1 = v116 
    #endif
    let v117 : string = _v1 
    v117
and method5 (v0 : float, v1 : float, v2 : float) : struct (float * float * float) =
    struct (v0, v1, v2)
and method7 (v0 : float, v1 : Mut0) : bool =
    let v2 : float = v1.l0
    let v3 : bool = v2 < v0
    v3
and method8 (v0 : float seq) : float seq =
    v0
and method10 (v0 : float, v1 : float, v2 : float, v3 : char, v4 : float, v5 : float, v6 : float, v7 : float) : US3 =
    let v8 : float = sin v4
    let v9 : float = v1 * v8
    let v10 : float = sin v5
    let v11 : float = v9 * v10
    let v12 : float = cos v6
    let v13 : float = v11 * v12
    let v14 : float = cos v4
    let v15 : float = v2 * v14
    let v16 : float = v15 * v10
    let v17 : float = v16 * v12
    let v18 : float = v13 - v17
    let v19 : float = v1 * v14
    let v20 : float = sin v6
    let v21 : float = v19 * v20
    let v22 : float = v18 + v21
    let v23 : float = v2 * v8
    let v24 : float = v23 * v20
    let v25 : float = v22 + v24
    let v26 : float = cos v5
    let v27 : float = v0 * v26
    let v28 : float = v27 * v12
    let v29 : float = v25 + v28
    let v30 : float = v19 * v12
    let v31 : float = v23 * v12
    let v32 : float = v30 + v31
    let v33 : float = v11 * v20
    let v34 : float = v32 - v33
    let v35 : float = v16 * v20
    let v36 : float = v34 + v35
    let v37 : float = v27 * v20
    let v38 : float = v36 - v37
    let v39 : float = v15 * v26
    let v40 : float = v9 * v26
    let v41 : float = v39 - v40
    let v42 : float = v0 * v10
    let v43 : float = v41 + v42
    let v44 : float = v43 + 100.0
    let v45 : float = 1.0 / v44
    let v46 : (int32 -> float) = float
    let v47 : float = v46 160
    let v48 : float = v47 / 2.0
    let v49 : float = v48 + v7
    let v50 : float = 40.0 * v45
    let v51 : float = v50 * v29
    let v52 : float = v51 * 2.0
    let v53 : float = v49 + v52
    let v54 : (float -> int32) = int32
    let v55 : int32 = v54 v53
    let v56 : (int32 -> float) = float
    let v57 : float = v56 44
    let v58 : float = v57 / 2.0
    let v59 : float = v50 * v38
    let v60 : float = v58 + v59
    let v61 : (float -> int32) = int32
    let v62 : int32 = v61 v60
    let v63 : int32 = v62 * 160
    let v64 : int32 = v55 + v63
    let v65 : bool = v64 >= 0
    let v67 : bool =
        if v65 then
            let v66 : bool = v64 < 7040
            v66
        else
            false
    if v67 then
        US3_0(v64, v45, v3)
    else
        US3_1
and closure4 (v0 : float, v1 : float, v2 : float, v3 : float, v4 : float, v5 : float) (v6 : float) : (US3 []) =
    let v7 : float =  -v3
    let v8 : char = ';'
    let v9 : US3 = method10(v5, v6, v7, v8, v0, v1, v2, v4)
    let v10 : char = '\\'
    let v11 : US3 = method10(v3, v6, v5, v10, v0, v1, v2, v4)
    let v12 : float =  -v5
    let v13 : char = '/'
    let v14 : US3 = method10(v7, v6, v12, v13, v0, v1, v2, v4)
    let v15 : char = '='
    let v16 : US3 = method10(v12, v6, v3, v15, v0, v1, v2, v4)
    let v17 : float =  -v6
    let v18 : char = '>'
    let v19 : US3 = method10(v5, v7, v17, v18, v0, v1, v2, v4)
    let v20 : char = '<'
    let v21 : US3 = method10(v5, v3, v6, v20, v0, v1, v2, v4)
    [|v9; v11; v14; v16; v19; v21|]
and closure3 (v0 : float, v1 : float, v2 : float, v3 : float, v4 : float) (v5 : float) : (float -> (US3 [])) =
    closure4(v0, v1, v2, v3, v4, v5)
and method9 (v0 : float, v1 : float, v2 : float, v3 : float, v4 : float) : (float -> (float -> (US3 []))) =
    closure3(v0, v1, v2, v3, v4)
and closure5 () (v0 : US3) : struct (int32 * float * char) option =
    match v0 with
    | US3_1 -> (* None *)
        let v7 : struct (int32 * float * char) option = None
        v7
    | US3_0(v1, v2, v3) -> (* Some *)
        let v4 : struct (int32 * float * char) option = Some struct (v1, v2, v3) 
        v4
and method11 () : (US3 -> struct (int32 * float * char) option) =
    closure5()
and closure2 (v0 : float, v1 : float, v2 : float) struct (v3 : float, v4 : float) : struct (int32 * float * char) seq =
    let v5 : float =  -v3
    let v6 : unit = ()
    let _v6 =
        seq {
            let v7 : Mut0 = {l0 = v5} : Mut0
            while method7(v3, v7) do
                let v9 : float = v7.l0
                yield v9 
                let v10 : float = v7.l0
                let v11 : float = v10 + 0.6
                v7.l0 <- v11
                ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v12 : float seq = _v6 
    let v13 : float seq = method8(v12)
    let v14 : (float -> (float -> (US3 []))) = method9(v0, v1, v2, v3, v4)
    let v15 : (US3 -> struct (int32 * float * char) option) = method11()
    let v16 : unit = ()
    let _v16 =
        seq {
            for cube_x in v13 do
            for cube_y in v13 do
            let x = v14 cube_x cube_y |> Seq.choose v15 
            yield! x
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v17 : struct (int32 * float * char) seq = _v16 
    v17
and method6 (v0 : float, v1 : float, v2 : float) : (struct (float * float) -> struct (int32 * float * char) seq) =
    closure2(v0, v1, v2)
and closure7 (v0 : (US4 []), v1 : int32) struct (v2 : float, v3 : char) : unit =
    let v4 : US4 = v0.[int v1]
    match v4 with
    | US4_0(v7, v8) -> (* Some *)
        let v9 : bool = v7 >= v2
        if v9 then
            ()
        else
            let v10 : US4 = US4_0(v2, v3)
            v0.[v1] <- v10 
            ()
    | _ ->
        let v11 : US4 = US4_0(v2, v3)
        v0.[v1] <- v11 
        ()
and closure6 (v0 : (US4 [])) (v1 : int32) : (struct (float * char) -> unit) =
    closure7(v0, v1)
and method12 () : string =
    let v0 : string = ""
    v0
and closure9 (v0 : (US4 []), v1 : System.Text.StringBuilder, v2 : int32) (v3 : int32) : unit =
    let v4 : int32 = v2 * 160
    let v5 : int32 = v3 + v4
    let v6 : US4 = v0.[int v5]
    let v12 : char =
        match v6 with
        | US4_1 -> (* None *)
            '.'
        | US4_0(v9, v10) -> (* Some *)
            v10
    let v13 : (char -> string) = _.ToString()
    let v14 : string = v13 v12
    let v17 : (string -> System.Text.StringBuilder) = v1.Append
    let v18 : System.Text.StringBuilder = v17 v14
    ()
and closure8 (v0 : (US4 []), v1 : System.Text.StringBuilder) (v2 : int32) : unit =
    let v3 : (int32 -> unit) = closure9(v0, v1, v2)
    for col in 0 .. (160 - 1) do v3 col
    let v4 : System.Text.StringBuilder = v1.AppendLine ()
    ()
and closure10 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and method4 (v0 : int32, v1 : int32, v2 : float, v3 : float, v4 : float) : Async<unit> =
    let v5 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<unit> = null |> unbox<Async<unit>>
    let _v5 = v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    let _v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    let _v5 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    let _v5 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    let _v5 = v18 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : unit = ()
    let _v21 =
        async {
            let struct (v22 : float, v23 : float, v24 : float) = method5(v2, v3, v4)
            let v25 : (struct (float * float) -> struct (int32 * float * char) seq) = method6(v22, v23, v24)
            let v26 : (struct (float * float) []) = [|struct (20.0, -40.0); struct (10.0, 10.0); struct (5.0, 40.0)|]
            let v27 : ((struct (float * float) []) -> struct (int32 * float * char) seq) = Seq.collect v25 
            let v28 : struct (int32 * float * char) seq = v27 v26
            let v29 : US4 = US4_1
            let v30 : (US4 []) = Array.create (160 * 44) v29 
            let v31 : (int32 -> (struct (float * char) -> unit)) = closure6(v30)
            let v32 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v31 idx (ooz, ch))
            v32 v28
            let v33 : string = method12()
            let v34 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v35 : System.Text.StringBuilder = v34 v33
            let v36 : (int32 -> unit) = closure8(v30, v35)
            for row in 0 .. (44 - 1) do v36 row
            let v37 : (System.Text.StringBuilder -> string) = _.ToString()
            let v38 : string = v37 v35
            try
            let v41 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            System.Console.SetCursorPosition (0, 0)
            let _v41 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            System.Console.SetCursorPosition (0, 0)
            let _v41 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            System.Console.SetCursorPosition (0, 0)
            let _v41 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.SetCursorPosition (0, 0)
            let _v41 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.SetCursorPosition (0, 0)
            let _v41 = () 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _v41 = () 
            #endif
#else
            System.Console.SetCursorPosition (0, 0)
            let _v41 = () 
            #endif
            _v41 
            with ex ->
                let v42 : exn = ex
                ()
                (*
                ()
            *)
            (*
            *)
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure10(v38)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v47 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : Async<unit> = null |> unbox<Async<unit>>
            let _v47 = v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v51 : Async<unit> = null |> unbox<Async<unit>>
            let _v47 = v51 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v54 : Async<unit> = null |> unbox<Async<unit>>
            let _v47 = v54 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v57 : Async<unit> = null |> unbox<Async<unit>>
            let _v47 = v57 
            #endif
#if FABLE_COMPILER_PYTHON
            let v60 : Async<unit> = null |> unbox<Async<unit>>
            let _v47 = v60 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v63 : (int32 -> Async<unit>) = Async.Sleep
            let v64 : Async<unit> = v63 1
            let _v47 = v64 
            #endif
#else
            let v65 : (int32 -> Async<unit>) = Async.Sleep
            let v66 : Async<unit> = v65 1
            let _v47 = v66 
            #endif
            let v67 : Async<unit> = _v47 
            do! v67 
            let v72 : bool = v0 > 0
            let v74 : bool =
                if v72 then
                    let v73 : bool = v1 >= v0
                    v73
                else
                    false
            if v74 then
                ()
            else
                let v75 : float = v22 + 0.05
                let v76 : float = v23 + 0.05
                let v77 : float = v24 + 0.01
                let v78 : int32 = v1 + 1
                let v79 : Async<unit> = method4(v0, v78, v75, v76, v77)
                return! v79 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v80 : Async<unit> = _v21 
    let _v5 = v80 
    #endif
#else
    let v81 : unit = ()
    let _v81 =
        async {
            let struct (v82 : float, v83 : float, v84 : float) = method5(v2, v3, v4)
            let v85 : (struct (float * float) -> struct (int32 * float * char) seq) = method6(v82, v83, v84)
            let v86 : (struct (float * float) []) = [|struct (20.0, -40.0); struct (10.0, 10.0); struct (5.0, 40.0)|]
            let v87 : ((struct (float * float) []) -> struct (int32 * float * char) seq) = Seq.collect v85 
            let v88 : struct (int32 * float * char) seq = v87 v86
            let v89 : US4 = US4_1
            let v90 : (US4 []) = Array.create (160 * 44) v89 
            let v91 : (int32 -> (struct (float * char) -> unit)) = closure6(v90)
            let v92 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v91 idx (ooz, ch))
            v92 v88
            let v93 : string = method12()
            let v94 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v95 : System.Text.StringBuilder = v94 v93
            let v96 : (int32 -> unit) = closure8(v90, v95)
            for row in 0 .. (44 - 1) do v96 row
            let v97 : (System.Text.StringBuilder -> string) = _.ToString()
            let v98 : string = v97 v95
            try
            let v101 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            System.Console.SetCursorPosition (0, 0)
            let _v101 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            System.Console.SetCursorPosition (0, 0)
            let _v101 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            System.Console.SetCursorPosition (0, 0)
            let _v101 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.SetCursorPosition (0, 0)
            let _v101 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.SetCursorPosition (0, 0)
            let _v101 = () 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _v101 = () 
            #endif
#else
            System.Console.SetCursorPosition (0, 0)
            let _v101 = () 
            #endif
            _v101 
            with ex ->
                let v102 : exn = ex
                ()
                (*
                ()
            *)
            (*
            *)
            let v103 : unit = ()
            let v104 : (unit -> unit) = closure10(v98)
            let v105 : unit = (fun () -> v104 (); v103) ()
            let v107 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v108 : Async<unit> = null |> unbox<Async<unit>>
            let _v107 = v108 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v111 : Async<unit> = null |> unbox<Async<unit>>
            let _v107 = v111 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v114 : Async<unit> = null |> unbox<Async<unit>>
            let _v107 = v114 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v117 : Async<unit> = null |> unbox<Async<unit>>
            let _v107 = v117 
            #endif
#if FABLE_COMPILER_PYTHON
            let v120 : Async<unit> = null |> unbox<Async<unit>>
            let _v107 = v120 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v123 : (int32 -> Async<unit>) = Async.Sleep
            let v124 : Async<unit> = v123 1
            let _v107 = v124 
            #endif
#else
            let v125 : (int32 -> Async<unit>) = Async.Sleep
            let v126 : Async<unit> = v125 1
            let _v107 = v126 
            #endif
            let v127 : Async<unit> = _v107 
            do! v127 
            let v132 : bool = v0 > 0
            let v134 : bool =
                if v132 then
                    let v133 : bool = v1 >= v0
                    v133
                else
                    false
            if v134 then
                ()
            else
                let v135 : float = v82 + 0.05
                let v136 : float = v83 + 0.05
                let v137 : float = v84 + 0.01
                let v138 : int32 = v1 + 1
                let v139 : Async<unit> = method4(v0, v138, v135, v136, v137)
                return! v139 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v140 : Async<unit> = _v81 
    let _v5 = v140 
    #endif
    let v141 : Async<unit> = _v5 
    v141
and closure0 () (v0 : (string [])) : unit =
    try
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    System.Console.CursorVisible <- false
    let _v1 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    System.Console.CursorVisible <- false
    let _v1 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    System.Console.CursorVisible <- false
    let _v1 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    System.Console.CursorVisible <- false
    let _v1 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    System.Console.CursorVisible <- false
    let _v1 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _v1 = () 
    #endif
#else
    System.Console.CursorVisible <- false
    let _v1 = () 
    #endif
    _v1 
    with ex ->
        let v2 : exn = ex
        ()
        (*
        ()
    *)
    (*
    *)
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method0()
    let v5 : string = method1(v4)
    let v6 : int32 = v5.Length
    let v7 : bool = 0 = v6
    let v12 : bool =
        if v7 then
            let v8 : string = "AUTOMATION"
            let v9 : string = method1(v8)
            let v10 : int32 = v9.Length
            let v11 : bool = 0 = v10
            v11
        else
            false
    let _v3 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = method0()
    let v14 : string = method1(v13)
    let v15 : int32 = v14.Length
    let v16 : bool = 0 = v15
    let v21 : bool =
        if v16 then
            let v17 : string = "AUTOMATION"
            let v18 : string = method1(v17)
            let v19 : int32 = v18.Length
            let v20 : bool = 0 = v19
            v20
        else
            false
    let _v3 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = method0()
    let v23 : string = method1(v22)
    let v24 : int32 = v23.Length
    let v25 : bool = 0 = v24
    let v30 : bool =
        if v25 then
            let v26 : string = "AUTOMATION"
            let v27 : string = method1(v26)
            let v28 : int32 = v27.Length
            let v29 : bool = 0 = v28
            v29
        else
            false
    let _v3 = v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v31 : string = method0()
    let v32 : string = method1(v31)
    let v33 : int32 = v32.Length
    let v34 : bool = 0 = v33
    let v39 : bool =
        if v34 then
            let v35 : string = "AUTOMATION"
            let v36 : string = method1(v35)
            let v37 : int32 = v36.Length
            let v38 : bool = 0 = v37
            v38
        else
            false
    let _v3 = v39 
    #endif
#if FABLE_COMPILER_PYTHON
    let v40 : string = method0()
    let v41 : string = method1(v40)
    let v42 : int32 = v41.Length
    let v43 : bool = 0 = v42
    let v48 : bool =
        if v43 then
            let v44 : string = "AUTOMATION"
            let v45 : string = method1(v44)
            let v46 : int32 = v45.Length
            let v47 : bool = 0 = v46
            v47
        else
            false
    let _v3 = v48 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _v3 = false 
    #endif
#else
    let v49 : string = method0()
    let v50 : string = method1(v49)
    let v51 : int32 = v50.Length
    let v52 : bool = 0 = v51
    let v57 : bool =
        if v52 then
            let v53 : string = "AUTOMATION"
            let v54 : string = method1(v53)
            let v55 : int32 = v54.Length
            let v56 : bool = 0 = v55
            v56
        else
            false
    let _v3 = v57 
    #endif
    let v58 : bool = _v3 
    let v69 : int32 =
        if v58 then
            -1
        else
            50
    let v70 : int32 = 1
    let v71 : float = 0.0
    let v72 : float = 0.0
    let v73 : float = 0.0
    let v74 : Async<unit> = method4(v69, v70, v71, v72, v73)
    let v75 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v76 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v76 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v76 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v76 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v76 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v76 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v77 : (Async<unit> -> unit) = Async.RunSynchronously
    v77 v74
    let _v76 = () 
    #endif
#else
    let v78 : (Async<unit> -> unit) = Async.RunSynchronously
    v78 v74
    let _v76 = () 
    #endif
    _v76 
    let _v75 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v79 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v79 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v79 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v79 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v79 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v80 : (Async<unit> -> unit) = Async.RunSynchronously
    v80 v74
    let _v79 = () 
    #endif
#else
    let v81 : (Async<unit> -> unit) = Async.RunSynchronously
    v81 v74
    let _v79 = () 
    #endif
    _v79 
    let _v75 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v82 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v82 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v82 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v82 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v82 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v83 : (Async<unit> -> unit) = Async.RunSynchronously
    v83 v74
    let _v82 = () 
    #endif
#else
    let v84 : (Async<unit> -> unit) = Async.RunSynchronously
    v84 v74
    let _v82 = () 
    #endif
    _v82 
    let _v75 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v85 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v85 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v85 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v85 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v85 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v86 : (Async<unit> -> unit) = Async.RunSynchronously
    v86 v74
    let _v85 = () 
    #endif
#else
    let v87 : (Async<unit> -> unit) = Async.RunSynchronously
    v87 v74
    let _v85 = () 
    #endif
    _v85 
    let _v75 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v88 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v88 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v88 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v88 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v88 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v89 : (Async<unit> -> unit) = Async.RunSynchronously
    v89 v74
    let _v88 = () 
    #endif
#else
    let v90 : (Async<unit> -> unit) = Async.RunSynchronously
    v90 v74
    let _v88 = () 
    #endif
    _v88 
    let _v75 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v91 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v92 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v91 = v92 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v95 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v91 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v98 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v91 = v98 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v101 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v91 = v101 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v91 = v104 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v107 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v108 : Async<Async<unit>> = v107 v74
    let _v91 = v108 
    #endif
#else
    let v109 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v110 : Async<Async<unit>> = v109 v74
    let _v91 = v110 
    #endif
    let v111 : Async<Async<unit>> = _v91 
    let _v75 = () 
    #endif
#else
    let v116 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v116 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v116 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v116 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v116 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v116 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : (Async<unit> -> unit) = Async.RunSynchronously
    v117 v74
    let _v116 = () 
    #endif
#else
    let v118 : (Async<unit> -> unit) = Async.RunSynchronously
    v118 v74
    let _v116 = () 
    #endif
    _v116 
    let _v75 = () 
    #endif
    _v75 
    ()
let v0 : ((string []) -> unit) = closure0()
v0 [||]
()
