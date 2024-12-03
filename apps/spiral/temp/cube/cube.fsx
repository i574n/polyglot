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
    | US0_0
    | US0_1
    | US0_2
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1 of f1_0 : US0
    | US1_2 of f2_0 : US0
    | US1_3 of f3_0 : US0
    | US1_4 of f4_0 : US0
and [<Struct>] US2 =
    | US2_0 of f0_0 : string
    | US2_1
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
and closure1 () (v0 : string) : US2 =
    US2_0(v0)
and method3 () : (string -> US2) =
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
    let v17 : US0 = US0_1
    let v18 : US1 = US1_2(v17)
    let v19 : string = $"env.get_environment_variable / target: {v18} / var: {v0}"
    let v20 : string = failwith<string> v19
    let _v1 = v20 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : US0 = US0_2
    let v22 : US1 = US1_2(v21)
    let v23 : string = $"env.get_environment_variable / target: {v22} / var: {v0}"
    let v24 : string = failwith<string> v23
    let _v1 = v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "process.env[$0] ?? \"\""
    let v26 : string = Fable.Core.JsInterop.emitJsExpr v0 v25 
    let _v1 = v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : string = "os"
    let v28 : IOsEnviron = Fable.Core.PyInterop.importAll v27 
    let v29 : string = "v28.environ"
    let v30 : obj = Fable.Core.PyInterop.emitPyExpr () v29 
    let v33 : string = "v30.get($0)"
    let v34 : string = Fable.Core.PyInterop.emitPyExpr v0 v33 
    let mutable _v34 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v37 : (string -> string option) = Option.ofObj
    let v38 : string option = v37 v34
    v38 
    #else
    Some v34 
    #endif
    |> fun x -> _v34 <- Some x
    let v39 : string option = match _v34 with Some x -> x | None -> failwith "optionm'.of_obj / _v34=None"
    let v42 : (string -> US2) = method3()
    let v43 : US2 option = v39 |> Option.map v42 
    let v54 : US2 = US2_1
    let v55 : US2 = v43 |> Option.defaultValue v54 
    let v62 : string =
        match v55 with
        | US2_1 -> (* None *)
            let v60 : string = ""
            v60
        | US2_0(v59) -> (* Some *)
            v59
    let _v1 = v62 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : US0 = US0_1
    let v64 : US1 = US1_0(v63)
    let v65 : string = $"env.get_environment_variable / target: {v64} / var: {v0}"
    let v66 : string = failwith<string> v65
    let _v1 = v66 
    #endif
#else
    let v67 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v68 : string = v67 v0
    let mutable _v68 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v69 : (string -> string option) = Option.ofObj
    let v70 : string option = v69 v68
    v70 
    #else
    Some v68 
    #endif
    |> fun x -> _v68 <- Some x
    let v71 : string option = match _v68 with Some x -> x | None -> failwith "optionm'.of_obj / _v68=None"
    let v74 : (string -> US2) = method3()
    let v75 : US2 option = v71 |> Option.map v74 
    let v86 : US2 = US2_1
    let v87 : US2 = v75 |> Option.defaultValue v86 
    let v94 : string =
        match v87 with
        | US2_1 -> (* None *)
            let v92 : string = ""
            v92
        | US2_0(v91) -> (* Some *)
            v91
    let _v1 = v94 
    #endif
    let v95 : string = _v1 
    v95
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
    let v50 : float = v47 / 2.0
    let v51 : float = v50 + v7
    let v52 : float = 40.0 * v45
    let v53 : float = v52 * v29
    let v54 : float = v53 * 2.0
    let v55 : float = v51 + v54
    let v56 : int32 = v55 |> int32 
    let v63 : (int32 -> float) = float
    let v64 : float = v63 44
    let v67 : float = v64 / 2.0
    let v68 : float = v52 * v38
    let v69 : float = v67 + v68
    let v70 : int32 = v69 |> int32 
    let v77 : int32 = v70 * 160
    let v78 : int32 = v56 + v77
    let v79 : bool = v78 >= 0
    let v81 : bool =
        if v79 then
            let v80 : bool = v78 < 7040
            v80
        else
            false
    if v81 then
        US3_0(v78, v45, v3)
    else
        US3_1
and closure4 (v0 : float, v1 : float, v2 : float, v3 : float, v4 : float, v5 : float) (v6 : float) : US3 list =
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
    let v22 : US3 list = []
    let v23 : US3 list = v21 :: v22 
    let v26 : US3 list = v19 :: v23 
    let v29 : US3 list = v16 :: v26 
    let v32 : US3 list = v14 :: v29 
    let v35 : US3 list = v11 :: v32 
    let v38 : US3 list = v9 :: v35 
    v38
and closure3 (v0 : float, v1 : float, v2 : float, v3 : float, v4 : float) (v5 : float) : (float -> US3 list) =
    closure4(v0, v1, v2, v3, v4, v5)
and method9 (v0 : float, v1 : float, v2 : float, v3 : float, v4 : float) : (float -> (float -> US3 list)) =
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
    let v16 : float seq = method8(v12)
    let v17 : (float -> (float -> US3 list)) = method9(v0, v1, v2, v3, v4)
    let v18 : (US3 -> struct (int32 * float * char) option) = method11()
    let v19 : unit = ()
    let _v19 =
        seq {
            for cube_x in v16 do
            for cube_y in v16 do
            let x = v17 cube_x cube_y |> Seq.choose v18 
            yield! x
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v20 : struct (int32 * float * char) seq = _v19 
    v20
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
        let v12 : US4 = US4_0(v2, v3)
        v0.[v1] <- v12 
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
    let v15 : unit = ()
    let _v15 =
        async {
            let struct (v16 : float, v17 : float, v18 : float) = method5(v2, v3, v4)
            let v19 : struct (float * float) list = []
            let v20 : struct (float * float) list = struct (5.0, 40.0) :: v19 
            let v23 : struct (float * float) list = struct (10.0, 10.0) :: v20 
            let v26 : struct (float * float) list = struct (20.0, -40.0) :: v23 
            let v29 : (struct (float * float) -> struct (int32 * float * char) seq) = method6(v16, v17, v18)
            let v30 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v29 
            let v31 : struct (int32 * float * char) seq = v30 v26
            let v35 : US4 = US4_1
            let v36 : (US4 []) = Array.create (160 * 44) v35 
            let v40 : (int32 -> (struct (float * char) -> unit)) = closure6(v36)
            let v41 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v40 idx (ooz, ch))
            v41 v31
            let v42 : string = method12()
            let v43 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v44 : System.Text.StringBuilder = v43 v42
            let v47 : (int32 -> unit) = closure8(v36, v44)
            for row in 0 .. (44 - 1) do v47 row
            let v48 : (System.Text.StringBuilder -> string) = _.ToString()
            let v49 : string = v48 v44
            let v52 : bool = v0 < 0
            if v52 then
                let v53 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v54 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v54 
                let _v53 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v55 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v55 
                let _v53 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v56 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v56 
                let _v53 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v57 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v57 
                let _v53 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let v58 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v58 
                let _v53 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v53 = () 
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                let _v53 = () 
                #endif
                _v53 
                ()
            let v59 : unit = ()
            let v60 : (unit -> unit) = closure10(v49)
            let v61 : unit = (fun () -> v60 (); v59) ()
            let v63 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v64 : (int32 -> Async<unit>) = Async.Sleep
            let v65 : Async<unit> = v64 1
            let _v63 = v65 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v66 : (int32 -> Async<unit>) = Async.Sleep
            let v67 : Async<unit> = v66 1
            let _v63 = v67 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v68 : (int32 -> Async<unit>) = Async.Sleep
            let v69 : Async<unit> = v68 1
            let _v63 = v69 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v70 : (int32 -> Async<unit>) = Async.Sleep
            let v71 : Async<unit> = v70 1
            let _v63 = v71 
            #endif
#if FABLE_COMPILER_PYTHON
            let v72 : (int32 -> Async<unit>) = Async.Sleep
            let v73 : Async<unit> = v72 1
            let _v63 = v73 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v74 : (int32 -> Async<unit>) = Async.Sleep
            let v75 : Async<unit> = v74 1
            let _v63 = v75 
            #endif
#else
            let v76 : (int32 -> Async<unit>) = Async.Sleep
            let v77 : Async<unit> = v76 1
            let _v63 = v77 
            #endif
            let v78 : Async<unit> = _v63 
            do! v78 
            let v83 : bool = v0 > 0
            let v85 : bool =
                if v83 then
                    let v84 : bool = v1 >= v0
                    v84
                else
                    false
            if v85 then
                ()
            else
                let v86 : float = v16 + 0.05
                let v87 : float = v17 + 0.05
                let v88 : float = v18 + 0.01
                let v89 : int32 = v1 + 1
                let v90 : Async<unit> = method4(v0, v89, v86, v87, v88)
                return! v90 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v91 : Async<unit> = _v15 
    let _v5 = v91 
    #endif
#if FABLE_COMPILER_PYTHON
    let v92 : unit = ()
    let _v92 =
        async {
            let struct (v93 : float, v94 : float, v95 : float) = method5(v2, v3, v4)
            let v96 : struct (float * float) list = []
            let v97 : struct (float * float) list = struct (5.0, 40.0) :: v96 
            let v100 : struct (float * float) list = struct (10.0, 10.0) :: v97 
            let v103 : struct (float * float) list = struct (20.0, -40.0) :: v100 
            let v106 : (struct (float * float) -> struct (int32 * float * char) seq) = method6(v93, v94, v95)
            let v107 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v106 
            let v108 : struct (int32 * float * char) seq = v107 v103
            let v112 : US4 = US4_1
            let v113 : (US4 []) = Array.create (160 * 44) v112 
            let v117 : (int32 -> (struct (float * char) -> unit)) = closure6(v113)
            let v118 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v117 idx (ooz, ch))
            v118 v108
            let v119 : string = method12()
            let v120 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v121 : System.Text.StringBuilder = v120 v119
            let v124 : (int32 -> unit) = closure8(v113, v121)
            for row in 0 .. (44 - 1) do v124 row
            let v125 : (System.Text.StringBuilder -> string) = _.ToString()
            let v126 : string = v125 v121
            let v129 : bool = v0 < 0
            if v129 then
                let v130 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v131 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v131 
                let _v130 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v132 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v132 
                let _v130 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v133 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v133 
                let _v130 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v134 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v134 
                let _v130 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let v135 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v135 
                let _v130 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v130 = () 
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                let _v130 = () 
                #endif
                _v130 
                ()
            let v136 : unit = ()
            let v137 : (unit -> unit) = closure10(v126)
            let v138 : unit = (fun () -> v137 (); v136) ()
            let v140 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v141 : (int32 -> Async<unit>) = Async.Sleep
            let v142 : Async<unit> = v141 1
            let _v140 = v142 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v143 : (int32 -> Async<unit>) = Async.Sleep
            let v144 : Async<unit> = v143 1
            let _v140 = v144 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v145 : (int32 -> Async<unit>) = Async.Sleep
            let v146 : Async<unit> = v145 1
            let _v140 = v146 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v147 : (int32 -> Async<unit>) = Async.Sleep
            let v148 : Async<unit> = v147 1
            let _v140 = v148 
            #endif
#if FABLE_COMPILER_PYTHON
            let v149 : (int32 -> Async<unit>) = Async.Sleep
            let v150 : Async<unit> = v149 1
            let _v140 = v150 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v151 : (int32 -> Async<unit>) = Async.Sleep
            let v152 : Async<unit> = v151 1
            let _v140 = v152 
            #endif
#else
            let v153 : (int32 -> Async<unit>) = Async.Sleep
            let v154 : Async<unit> = v153 1
            let _v140 = v154 
            #endif
            let v155 : Async<unit> = _v140 
            do! v155 
            let v160 : bool = v0 > 0
            let v162 : bool =
                if v160 then
                    let v161 : bool = v1 >= v0
                    v161
                else
                    false
            if v162 then
                ()
            else
                let v163 : float = v93 + 0.05
                let v164 : float = v94 + 0.05
                let v165 : float = v95 + 0.01
                let v166 : int32 = v1 + 1
                let v167 : Async<unit> = method4(v0, v166, v163, v164, v165)
                return! v167 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v168 : Async<unit> = _v92 
    let _v5 = v168 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v169 : unit = ()
    let _v169 =
        async {
            let struct (v170 : float, v171 : float, v172 : float) = method5(v2, v3, v4)
            let v173 : struct (float * float) list = []
            let v174 : struct (float * float) list = struct (5.0, 40.0) :: v173 
            let v177 : struct (float * float) list = struct (10.0, 10.0) :: v174 
            let v180 : struct (float * float) list = struct (20.0, -40.0) :: v177 
            let v183 : (struct (float * float) -> struct (int32 * float * char) seq) = method6(v170, v171, v172)
            let v184 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v183 
            let v185 : struct (int32 * float * char) seq = v184 v180
            let v189 : US4 = US4_1
            let v190 : (US4 []) = Array.create (160 * 44) v189 
            let v194 : (int32 -> (struct (float * char) -> unit)) = closure6(v190)
            let v195 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v194 idx (ooz, ch))
            v195 v185
            let v196 : string = method12()
            let v197 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v198 : System.Text.StringBuilder = v197 v196
            let v201 : (int32 -> unit) = closure8(v190, v198)
            for row in 0 .. (44 - 1) do v201 row
            let v202 : (System.Text.StringBuilder -> string) = _.ToString()
            let v203 : string = v202 v198
            let v206 : bool = v0 < 0
            if v206 then
                let v207 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v208 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v208 
                let _v207 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v209 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v209 
                let _v207 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v210 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v210 
                let _v207 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v211 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v211 
                let _v207 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let v212 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v212 
                let _v207 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v207 = () 
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                let _v207 = () 
                #endif
                _v207 
                ()
            let v213 : unit = ()
            let v214 : (unit -> unit) = closure10(v203)
            let v215 : unit = (fun () -> v214 (); v213) ()
            let v217 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v218 : (int32 -> Async<unit>) = Async.Sleep
            let v219 : Async<unit> = v218 1
            let _v217 = v219 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v220 : (int32 -> Async<unit>) = Async.Sleep
            let v221 : Async<unit> = v220 1
            let _v217 = v221 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v222 : (int32 -> Async<unit>) = Async.Sleep
            let v223 : Async<unit> = v222 1
            let _v217 = v223 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v224 : (int32 -> Async<unit>) = Async.Sleep
            let v225 : Async<unit> = v224 1
            let _v217 = v225 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : (int32 -> Async<unit>) = Async.Sleep
            let v227 : Async<unit> = v226 1
            let _v217 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v228 : (int32 -> Async<unit>) = Async.Sleep
            let v229 : Async<unit> = v228 1
            let _v217 = v229 
            #endif
#else
            let v230 : (int32 -> Async<unit>) = Async.Sleep
            let v231 : Async<unit> = v230 1
            let _v217 = v231 
            #endif
            let v232 : Async<unit> = _v217 
            do! v232 
            let v237 : bool = v0 > 0
            let v239 : bool =
                if v237 then
                    let v238 : bool = v1 >= v0
                    v238
                else
                    false
            if v239 then
                ()
            else
                let v240 : float = v170 + 0.05
                let v241 : float = v171 + 0.05
                let v242 : float = v172 + 0.01
                let v243 : int32 = v1 + 1
                let v244 : Async<unit> = method4(v0, v243, v240, v241, v242)
                return! v244 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v245 : Async<unit> = _v169 
    let _v5 = v245 
    #endif
#else
    let v246 : unit = ()
    let _v246 =
        async {
            let struct (v247 : float, v248 : float, v249 : float) = method5(v2, v3, v4)
            let v250 : struct (float * float) list = []
            let v251 : struct (float * float) list = struct (5.0, 40.0) :: v250 
            let v254 : struct (float * float) list = struct (10.0, 10.0) :: v251 
            let v257 : struct (float * float) list = struct (20.0, -40.0) :: v254 
            let v260 : (struct (float * float) -> struct (int32 * float * char) seq) = method6(v247, v248, v249)
            let v261 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v260 
            let v262 : struct (int32 * float * char) seq = v261 v257
            let v266 : US4 = US4_1
            let v267 : (US4 []) = Array.create (160 * 44) v266 
            let v271 : (int32 -> (struct (float * char) -> unit)) = closure6(v267)
            let v272 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v271 idx (ooz, ch))
            v272 v262
            let v273 : string = method12()
            let v274 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v275 : System.Text.StringBuilder = v274 v273
            let v278 : (int32 -> unit) = closure8(v267, v275)
            for row in 0 .. (44 - 1) do v278 row
            let v279 : (System.Text.StringBuilder -> string) = _.ToString()
            let v280 : string = v279 v275
            let v283 : bool = v0 < 0
            if v283 then
                let v284 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v285 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v285 
                let _v284 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v286 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v286 
                let _v284 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v287 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v287 
                let _v284 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v288 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v288 
                let _v284 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let v289 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v289 
                let _v284 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v284 = () 
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                let _v284 = () 
                #endif
                _v284 
                ()
            let v290 : unit = ()
            let v291 : (unit -> unit) = closure10(v280)
            let v292 : unit = (fun () -> v291 (); v290) ()
            let v294 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v295 : (int32 -> Async<unit>) = Async.Sleep
            let v296 : Async<unit> = v295 1
            let _v294 = v296 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v297 : (int32 -> Async<unit>) = Async.Sleep
            let v298 : Async<unit> = v297 1
            let _v294 = v298 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v299 : (int32 -> Async<unit>) = Async.Sleep
            let v300 : Async<unit> = v299 1
            let _v294 = v300 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v301 : (int32 -> Async<unit>) = Async.Sleep
            let v302 : Async<unit> = v301 1
            let _v294 = v302 
            #endif
#if FABLE_COMPILER_PYTHON
            let v303 : (int32 -> Async<unit>) = Async.Sleep
            let v304 : Async<unit> = v303 1
            let _v294 = v304 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v305 : (int32 -> Async<unit>) = Async.Sleep
            let v306 : Async<unit> = v305 1
            let _v294 = v306 
            #endif
#else
            let v307 : (int32 -> Async<unit>) = Async.Sleep
            let v308 : Async<unit> = v307 1
            let _v294 = v308 
            #endif
            let v309 : Async<unit> = _v294 
            do! v309 
            let v314 : bool = v0 > 0
            let v316 : bool =
                if v314 then
                    let v315 : bool = v1 >= v0
                    v315
                else
                    false
            if v316 then
                ()
            else
                let v317 : float = v247 + 0.05
                let v318 : float = v248 + 0.05
                let v319 : float = v249 + 0.01
                let v320 : int32 = v1 + 1
                let v321 : Async<unit> = method4(v0, v320, v317, v318, v319)
                return! v321 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v322 : Async<unit> = _v246 
    let _v5 = v322 
    #endif
    let v323 : Async<unit> = _v5 
    v323
and closure0 () (v0 : (string [])) : unit =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method0()
    let v3 : string = method1(v2)
    let v4 : int32 = v3.Length
    let v5 : bool = 0 = v4
    let v10 : bool =
        if v5 then
            let v6 : string = "AUTOMATION"
            let v7 : string = method1(v6)
            let v8 : int32 = v7.Length
            let v9 : bool = 0 = v8
            v9
        else
            false
    let _v1 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = method0()
    let v12 : string = method1(v11)
    let v13 : int32 = v12.Length
    let v14 : bool = 0 = v13
    let v19 : bool =
        if v14 then
            let v15 : string = "AUTOMATION"
            let v16 : string = method1(v15)
            let v17 : int32 = v16.Length
            let v18 : bool = 0 = v17
            v18
        else
            false
    let _v1 = v19 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v20 : string = method0()
    let v21 : string = method1(v20)
    let v22 : int32 = v21.Length
    let v23 : bool = 0 = v22
    let v28 : bool =
        if v23 then
            let v24 : string = "AUTOMATION"
            let v25 : string = method1(v24)
            let v26 : int32 = v25.Length
            let v27 : bool = 0 = v26
            v27
        else
            false
    let _v1 = v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : string = method0()
    let v30 : string = method1(v29)
    let v31 : int32 = v30.Length
    let v32 : bool = 0 = v31
    let v37 : bool =
        if v32 then
            let v33 : string = "AUTOMATION"
            let v34 : string = method1(v33)
            let v35 : int32 = v34.Length
            let v36 : bool = 0 = v35
            v36
        else
            false
    let _v1 = v37 
    #endif
#if FABLE_COMPILER_PYTHON
    let v38 : string = method0()
    let v39 : string = method1(v38)
    let v40 : int32 = v39.Length
    let v41 : bool = 0 = v40
    let v46 : bool =
        if v41 then
            let v42 : string = "AUTOMATION"
            let v43 : string = method1(v42)
            let v44 : int32 = v43.Length
            let v45 : bool = 0 = v44
            v45
        else
            false
    let _v1 = v46 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _v1 = false 
    #endif
#else
    let v47 : string = method0()
    let v48 : string = method1(v47)
    let v49 : int32 = v48.Length
    let v50 : bool = 0 = v49
    let v55 : bool =
        if v50 then
            let v51 : string = "AUTOMATION"
            let v52 : string = method1(v51)
            let v53 : int32 = v52.Length
            let v54 : bool = 0 = v53
            v54
        else
            false
    let _v1 = v55 
    #endif
    let v56 : bool = _v1 
    if v56 then
        let v67 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v68 : string = $"print!(\"\\x1B[?25l\")"
        Fable.Core.RustInterop.emitRustExpr () v68 
        let _v67 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v69 : string = $"print!(\"\\x1B[?25l\")"
        Fable.Core.RustInterop.emitRustExpr () v69 
        let _v67 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v70 : string = $"print!(\"\\x1B[?25l\")"
        Fable.Core.RustInterop.emitRustExpr () v70 
        let _v67 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v71 : string = $"process.stdout.write('\\u001B[?25l')"
        Fable.Core.JsInterop.emitJsExpr () v71 
        let _v67 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        let v72 : string = "sys"
        Fable.Core.PyInterop.importAll v72 
        let v73 : string = $"sys.stdout.write(\"\\033[?25l\")"
        Fable.Core.PyInterop.emitPyExpr () v73 
        let _v67 = () 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let _v67 = () 
        #endif
#else
        System.Console.CursorVisible <- false
        let _v67 = () 
        #endif
        _v67 
        ()
    let v74 : int32 =
        if v56 then
            -1
        else
            50
    let v75 : int32 = 1
    let v76 : float = 0.0
    let v77 : float = 0.0
    let v78 : float = 0.0
    let v79 : Async<unit> = method4(v74, v75, v76, v77, v78)
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v82 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v81 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v85 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v81 = v85 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v81 = v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v91 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v92 : Async<Async<unit>> = v91 v79
    let _v81 = v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v94 : Async<Async<unit>> = v93 v79
    let _v81 = v94 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v95 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v96 : Async<Async<unit>> = v95 v79
    let _v81 = v96 
    #endif
#else
    let v97 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v98 : Async<Async<unit>> = v97 v79
    let _v81 = v98 
    #endif
    let v99 : Async<Async<unit>> = _v81 
    let _v80 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v105 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v104 = v105 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v108 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v104 = v108 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v104 = v111 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v114 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v115 : Async<Async<unit>> = v114 v79
    let _v104 = v115 
    #endif
#if FABLE_COMPILER_PYTHON
    let v116 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v117 : Async<Async<unit>> = v116 v79
    let _v104 = v117 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v119 : Async<Async<unit>> = v118 v79
    let _v104 = v119 
    #endif
#else
    let v120 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v121 : Async<Async<unit>> = v120 v79
    let _v104 = v121 
    #endif
    let v122 : Async<Async<unit>> = _v104 
    let _v80 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v127 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v128 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v127 = v128 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v131 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v127 = v131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v134 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v127 = v134 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v138 : Async<Async<unit>> = v137 v79
    let _v127 = v138 
    #endif
#if FABLE_COMPILER_PYTHON
    let v139 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v140 : Async<Async<unit>> = v139 v79
    let _v127 = v140 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v141 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v142 : Async<Async<unit>> = v141 v79
    let _v127 = v142 
    #endif
#else
    let v143 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v144 : Async<Async<unit>> = v143 v79
    let _v127 = v144 
    #endif
    let v145 : Async<Async<unit>> = _v127 
    let _v80 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v151 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v150 = v151 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v154 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v150 = v154 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v157 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v150 = v157 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v160 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v161 : Async<Async<unit>> = v160 v79
    let _v150 = v161 
    #endif
#if FABLE_COMPILER_PYTHON
    let v162 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v163 : Async<Async<unit>> = v162 v79
    let _v150 = v163 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v164 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v165 : Async<Async<unit>> = v164 v79
    let _v150 = v165 
    #endif
#else
    let v166 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v167 : Async<Async<unit>> = v166 v79
    let _v150 = v167 
    #endif
    let v168 : Async<Async<unit>> = _v150 
    let _v80 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v173 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v173 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v173 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v173 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v174 : (Async<unit> -> unit) = Async.StartImmediate
    v174 v79
    let _v173 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v175 : (Async<unit> -> unit) = Async.StartImmediate
    v175 v79
    let _v173 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v176 : (Async<unit> -> unit) = Async.StartImmediate
    v176 v79
    let _v173 = () 
    #endif
#else
    let v177 : (Async<unit> -> unit) = Async.StartImmediate
    v177 v79
    let _v173 = () 
    #endif
    _v173 
    let v178 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v179 : (int32 -> unit) = System.Threading.Thread.Sleep
    v179 2000
    let _v178 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v180 : (int32 -> unit) = System.Threading.Thread.Sleep
    v180 2000
    let _v178 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : (int32 -> unit) = System.Threading.Thread.Sleep
    v181 2000
    let _v178 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _v178 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v182 : (int32 -> unit) = System.Threading.Thread.Sleep
    v182 2000
    let _v178 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _v178 = () 
    #endif
#else
    let v183 : (int32 -> unit) = System.Threading.Thread.Sleep
    v183 2000
    let _v178 = () 
    #endif
    _v178 
    let _v80 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v184 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v185 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v184 = v185 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v188 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v184 = v188 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v191 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v184 = v191 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v194 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v195 : Async<Async<unit>> = v194 v79
    let _v184 = v195 
    #endif
#if FABLE_COMPILER_PYTHON
    let v196 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v197 : Async<Async<unit>> = v196 v79
    let _v184 = v197 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v198 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v199 : Async<Async<unit>> = v198 v79
    let _v184 = v199 
    #endif
#else
    let v200 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v201 : Async<Async<unit>> = v200 v79
    let _v184 = v201 
    #endif
    let v202 : Async<Async<unit>> = _v184 
    let _v80 = () 
    #endif
#else
    let v207 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v207 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v207 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v207 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v207 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v208 : (Async<unit> -> unit) = Async.RunSynchronously
    v208 v79
    let _v207 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v209 : (Async<unit> -> unit) = Async.RunSynchronously
    v209 v79
    let _v207 = () 
    #endif
#else
    let v210 : (Async<unit> -> unit) = Async.RunSynchronously
    v210 v79
    let _v207 = () 
    #endif
    _v207 
    let _v80 = () 
    #endif
    _v80 
    ()
let v0 : ((string []) -> unit) = closure0()
let main_ = v0 
#if !FABLE_COMPILER_RUST
main_ [||]
#else
let main args = main_ [||]; 0
#endif
()
