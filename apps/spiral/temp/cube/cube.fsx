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
    | US1_5 of f5_0 : US0
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
and method2 (v0 : string) : string =
    v0
and method3 () : string =
    let v0 : string = ""
    v0
and closure1 () (v0 : string) : US2 =
    US2_0(v0)
and method4 () : (string -> US2) =
    closure1()
and method1 (v0 : string) : string =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method2(v0)
    let v7 : string = "std::env::var(&*$0)"
    let v8 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "x"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : string = "fable_library_rust::String_::fromString($0)"
    let v14 : string = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "true; $0 })"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : string = "_result_map_"
    let v18 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : string = method3()
    let v20 : string = "$0.unwrap_or($1)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v20 
    let _run_target_args'_v5 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : US0 = US0_1
    let v23 : US1 = US1_3(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _run_target_args'_v5 = v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : US0 = US0_2
    let v27 : US1 = US1_3(v26)
    let v28 : string = $"env.get_environment_variable / target: {v27} / var: {v0}"
    let v29 : string = failwith<string> v28
    let _run_target_args'_v5 = v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = "process.env[$0] ?? \"\""
    let v31 : string = Fable.Core.JsInterop.emitJsExpr v0 v30 
    let _run_target_args'_v5 = v31 
    #endif
#if FABLE_COMPILER_PYTHON
    let v33 : string = "os"
    let v34 : IOsEnviron = Fable.Core.PyInterop.importAll v33 
    let v35 : string = "v34.environ"
    let v36 : obj = Fable.Core.PyInterop.emitPyExpr () v35 
    let v40 : string = "v36.get($0)"
    let v41 : string = Fable.Core.PyInterop.emitPyExpr v0 v40 
    let mutable _v41 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v45 : (string -> string option) = Option.ofObj
    let v46 : string option = v45 v41
    v46 
    #else
    Some v41 
    #endif
    |> fun x -> _v41 <- Some x
    let v47 : string option = match _v41 with Some x -> x | None -> failwith "optionm'.of_obj / _v41=None"
    let v52 : (string -> US2) = method4()
    let v53 : US2 option = v47 |> Option.map v52 
    let v73 : US2 = US2_1
    let v74 : US2 = v53 |> Option.defaultValue v73 
    let v81 : string =
        match v74 with
        | US2_1 -> (* None *)
            let v79 : string = ""
            v79
        | US2_0(v78) -> (* Some *)
            v78
    let _run_target_args'_v5 = v81 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v82 : US0 = US0_1
    let v83 : US1 = US1_1(v82)
    let v84 : string = $"env.get_environment_variable / target: {v83} / var: {v0}"
    let v85 : string = failwith<string> v84
    let _run_target_args'_v5 = v85 
    #endif
#else
    let v86 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v87 : string = v86 v0
    let mutable _v87 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v89 : (string -> string option) = Option.ofObj
    let v90 : string option = v89 v87
    v90 
    #else
    Some v87 
    #endif
    |> fun x -> _v87 <- Some x
    let v91 : string option = match _v87 with Some x -> x | None -> failwith "optionm'.of_obj / _v87=None"
    let v96 : (string -> US2) = method4()
    let v97 : US2 option = v91 |> Option.map v96 
    let v117 : US2 = US2_1
    let v118 : US2 = v97 |> Option.defaultValue v117 
    let v125 : string =
        match v118 with
        | US2_1 -> (* None *)
            let v123 : string = ""
            v123
        | US2_0(v122) -> (* Some *)
            v122
    let _run_target_args'_v5 = v125 
    #endif
    let v126 : string = _run_target_args'_v5 
    v126
and method7 (v0 : float, v1 : float, v2 : float) : struct (float * float * float) =
    struct (v0, v1, v2)
and method9 (v0 : float, v1 : Mut0) : bool =
    let v2 : float = v1.l0
    let v3 : bool = v2 < v0
    v3
and method10 (v0 : float seq) : float seq =
    v0
and method12 (v0 : float, v1 : float, v2 : float, v3 : char, v4 : float, v5 : float, v6 : float, v7 : float) : US3 =
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
    let v47 : (int32 -> float) = float
    let v48 : float = v47 160
    let v51 : float = v48 / 2.0
    let v52 : float = v51 + v7
    let v53 : float = 40.0 * v45
    let v54 : float = v53 * v29
    let v55 : float = v54 * 2.0
    let v56 : float = v52 + v55
    let v62 : int32 = v56 |> int32 
    let v71 : (int32 -> float) = float
    let v72 : float = v71 44
    let v75 : float = v72 / 2.0
    let v76 : float = v53 * v38
    let v77 : float = v75 + v76
    let v83 : int32 = v77 |> int32 
    let v91 : int32 = v83 * 160
    let v92 : int32 = v62 + v91
    let v93 : bool = v92 >= 0
    let v95 : bool =
        if v93 then
            let v94 : bool = v92 < 7040
            v94
        else
            false
    if v95 then
        US3_0(v92, v45, v3)
    else
        US3_1
and closure4 (v0 : float, v1 : float, v2 : float, v3 : float, v4 : float, v5 : float) (v6 : float) : US3 list =
    let v7 : float =  -v3
    let v8 : char = ';'
    let v9 : US3 = method12(v5, v6, v7, v8, v0, v1, v2, v4)
    let v10 : char = '\\'
    let v11 : US3 = method12(v3, v6, v5, v10, v0, v1, v2, v4)
    let v12 : float =  -v5
    let v13 : char = '/'
    let v14 : US3 = method12(v7, v6, v12, v13, v0, v1, v2, v4)
    let v15 : char = '='
    let v16 : US3 = method12(v12, v6, v3, v15, v0, v1, v2, v4)
    let v17 : float =  -v6
    let v18 : char = '>'
    let v19 : US3 = method12(v5, v7, v17, v18, v0, v1, v2, v4)
    let v20 : char = '<'
    let v21 : US3 = method12(v5, v3, v6, v20, v0, v1, v2, v4)
    let v22 : US3 list = []
    let v24 : US3 list = v21 :: v22 
    let v28 : US3 list = v19 :: v24 
    let v32 : US3 list = v16 :: v28 
    let v36 : US3 list = v14 :: v32 
    let v40 : US3 list = v11 :: v36 
    let v44 : US3 list = v9 :: v40 
    v44
and closure3 (v0 : float, v1 : float, v2 : float, v3 : float, v4 : float) (v5 : float) : (float -> US3 list) =
    closure4(v0, v1, v2, v3, v4, v5)
and method11 (v0 : float, v1 : float, v2 : float, v3 : float, v4 : float) : (float -> (float -> US3 list)) =
    closure3(v0, v1, v2, v3, v4)
and closure5 () (v0 : US3) : struct (int32 * float * char) option =
    match v0 with
    | US3_1 -> (* None *)
        let v9 : struct (int32 * float * char) option = None
        v9
    | US3_0(v1, v2, v3) -> (* Some *)
        let v5 : struct (int32 * float * char) option = Some struct (v1, v2, v3) 
        v5
and method13 () : (US3 -> struct (int32 * float * char) option) =
    closure5()
and closure2 (v0 : float, v1 : float, v2 : float) struct (v3 : float, v4 : float) : struct (int32 * float * char) seq =
    let v5 : float =  -v3
    let v9 : unit = ()
    let _let'_v9 =
        seq {
            let v12 : Mut0 = {l0 = v5} : Mut0
            while method9(v3, v12) do
                let v14 : float = v12.l0
                yield v14 
                let v15 : float = v12.l0
                let v16 : float = v15 + 0.6
                v12.l0 <- v16
                ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v52 : float seq = _let'_v9 
    let v56 : float seq = method10(v52)
    let v57 : (float -> (float -> US3 list)) = method11(v0, v1, v2, v3, v4)
    let v58 : (US3 -> struct (int32 * float * char) option) = method13()
    let v62 : unit = ()
    let _let'_v62 =
        seq {
            for cube_x in v56 do
            for cube_y in v56 do
            let x = v57 cube_x cube_y |> Seq.choose v58 
            yield! x
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v65 : struct (int32 * float * char) seq = _let'_v62 
    v65
and method8 (v0 : float, v1 : float, v2 : float) : (struct (float * float) -> struct (int32 * float * char) seq) =
    closure2(v0, v1, v2)
and closure7 (v0 : (US4 []), v1 : int32) struct (v2 : float, v3 : char) : unit =
    let v5 : US4 = v0.[int v1]
    match v5 with
    | US4_0(v8, v9) -> (* Some *)
        let v10 : bool = v8 >= v2
        if v10 then
            ()
        else
            let v11 : US4 = US4_0(v2, v3)
            v0.[v1] <- v11 
            ()
    | _ ->
        let v13 : US4 = US4_0(v2, v3)
        v0.[v1] <- v13 
        ()
and closure6 (v0 : (US4 [])) (v1 : int32) : (struct (float * char) -> unit) =
    closure7(v0, v1)
and method14 () : string =
    let v0 : string = ""
    v0
and closure9 (v0 : (US4 []), v1 : System.Text.StringBuilder, v2 : int32) (v3 : int32) : unit =
    let v4 : int32 = v2 * 160
    let v5 : int32 = v3 + v4
    let v7 : US4 = v0.[int v5]
    let v13 : char =
        match v7 with
        | US4_1 -> (* None *)
            '.'
        | US4_0(v10, v11) -> (* Some *)
            v11
    let v15 : (char -> string) = _.ToString()
    let v16 : string = v15 v13
    let v20 : (string -> System.Text.StringBuilder) = v1.Append
    let v21 : System.Text.StringBuilder = v20 v16
    ()
and closure8 (v0 : (US4 []), v1 : System.Text.StringBuilder) (v2 : int32) : unit =
    let v3 : (int32 -> unit) = closure9(v0, v1, v2)
    for col in 0 .. (160 - 1) do v3 col
    let v11 : System.Text.StringBuilder = v1.AppendLine ()
    ()
and closure10 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and method6 (v0 : int32, v1 : int32, v2 : float, v3 : float, v4 : float) : Async<unit> =
    (* run_target_args'
    let v9 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v9 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v9 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v9 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v23 : unit = ()
    let _let'_v23 =
        async {
            let struct (v26 : float, v27 : float, v28 : float) = method7(v2, v3, v4)
            let v29 : struct (float * float) list = []
            let v31 : struct (float * float) list = struct (5.0, 40.0) :: v29 
            let v35 : struct (float * float) list = struct (10.0, 10.0) :: v31 
            let v39 : struct (float * float) list = struct (20.0, -40.0) :: v35 
            let v43 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v26, v27, v28)
            let v44 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v43 
            let v45 : struct (int32 * float * char) seq = v44 v39
            let v50 : US4 = US4_1
            let v51 : (US4 []) = Array.create (160 * 44) v50 
            let v55 : (int32 -> (struct (float * char) -> unit)) = closure6(v51)
            let v56 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v55 idx (ooz, ch))
            v56 v45
            let v57 : string = method14()
            let v59 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v60 : System.Text.StringBuilder = v59 v57
            let v63 : (int32 -> unit) = closure8(v51, v60)
            for row in 0 .. (44 - 1) do v63 row
            let v65 : (System.Text.StringBuilder -> string) = _.ToString()
            let v66 : string = v65 v60
            let v69 : bool = v0 < 0
            if v69 then
                (* run_target_args'
                let v70 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v71 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v71 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v72 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v72 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v73 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v73 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v74 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v74 
                #endif
#if FABLE_COMPILER_PYTHON
                let v75 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v75 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v76 : unit = ()
            let v77 : (unit -> unit) = closure10(v66)
            let v78 : unit = (fun () -> v77 (); v76) ()
            (* run_target_args'
            let v84 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v85 : (int32 -> Async<unit>) = Async.Sleep
            let v86 : Async<unit> = v85 1
            let _run_target_args'_v84 = v86 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v87 : (int32 -> Async<unit>) = Async.Sleep
            let v88 : Async<unit> = v87 1
            let _run_target_args'_v84 = v88 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v89 : (int32 -> Async<unit>) = Async.Sleep
            let v90 : Async<unit> = v89 1
            let _run_target_args'_v84 = v90 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v91 : (int32 -> Async<unit>) = Async.Sleep
            let v92 : Async<unit> = v91 1
            let _run_target_args'_v84 = v92 
            #endif
#if FABLE_COMPILER_PYTHON
            let v93 : (int32 -> Async<unit>) = Async.Sleep
            let v94 : Async<unit> = v93 1
            let _run_target_args'_v84 = v94 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v95 : (int32 -> Async<unit>) = Async.Sleep
            let v96 : Async<unit> = v95 1
            let _run_target_args'_v84 = v96 
            #endif
#else
            let v97 : (int32 -> Async<unit>) = Async.Sleep
            let v98 : Async<unit> = v97 1
            let _run_target_args'_v84 = v98 
            #endif
            let v99 : Async<unit> = _run_target_args'_v84 
            do! v99 
            let v102 : bool = v0 > 0
            let v104 : bool =
                if v102 then
                    let v103 : bool = v1 >= v0
                    v103
                else
                    false
            if v104 then
                ()
            else
                let v105 : float = v26 + 0.05
                let v106 : float = v27 + 0.05
                let v107 : float = v28 + 0.01
                let v108 : int32 = v1 + 1
                let v109 : Async<unit> = method5(v0, v108, v105, v106, v107)
                return! v109 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v698 : Async<unit> = _let'_v23 
    let _run_target_args'_v9 = v698 
    #endif
#if FABLE_COMPILER_PYTHON
    let v700 : unit = ()
    let _let'_v700 =
        async {
            let struct (v703 : float, v704 : float, v705 : float) = method7(v2, v3, v4)
            let v706 : struct (float * float) list = []
            let v708 : struct (float * float) list = struct (5.0, 40.0) :: v706 
            let v712 : struct (float * float) list = struct (10.0, 10.0) :: v708 
            let v716 : struct (float * float) list = struct (20.0, -40.0) :: v712 
            let v720 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v703, v704, v705)
            let v721 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v720 
            let v722 : struct (int32 * float * char) seq = v721 v716
            let v727 : US4 = US4_1
            let v728 : (US4 []) = Array.create (160 * 44) v727 
            let v732 : (int32 -> (struct (float * char) -> unit)) = closure6(v728)
            let v733 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v732 idx (ooz, ch))
            v733 v722
            let v734 : string = method14()
            let v736 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v737 : System.Text.StringBuilder = v736 v734
            let v740 : (int32 -> unit) = closure8(v728, v737)
            for row in 0 .. (44 - 1) do v740 row
            let v742 : (System.Text.StringBuilder -> string) = _.ToString()
            let v743 : string = v742 v737
            let v746 : bool = v0 < 0
            if v746 then
                (* run_target_args'
                let v747 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v748 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v748 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v749 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v749 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v750 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v750 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v751 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v751 
                #endif
#if FABLE_COMPILER_PYTHON
                let v752 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v752 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v753 : unit = ()
            let v754 : (unit -> unit) = closure10(v743)
            let v755 : unit = (fun () -> v754 (); v753) ()
            (* run_target_args'
            let v761 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v762 : (int32 -> Async<unit>) = Async.Sleep
            let v763 : Async<unit> = v762 1
            let _run_target_args'_v761 = v763 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v764 : (int32 -> Async<unit>) = Async.Sleep
            let v765 : Async<unit> = v764 1
            let _run_target_args'_v761 = v765 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v766 : (int32 -> Async<unit>) = Async.Sleep
            let v767 : Async<unit> = v766 1
            let _run_target_args'_v761 = v767 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v768 : (int32 -> Async<unit>) = Async.Sleep
            let v769 : Async<unit> = v768 1
            let _run_target_args'_v761 = v769 
            #endif
#if FABLE_COMPILER_PYTHON
            let v770 : (int32 -> Async<unit>) = Async.Sleep
            let v771 : Async<unit> = v770 1
            let _run_target_args'_v761 = v771 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v772 : (int32 -> Async<unit>) = Async.Sleep
            let v773 : Async<unit> = v772 1
            let _run_target_args'_v761 = v773 
            #endif
#else
            let v774 : (int32 -> Async<unit>) = Async.Sleep
            let v775 : Async<unit> = v774 1
            let _run_target_args'_v761 = v775 
            #endif
            let v776 : Async<unit> = _run_target_args'_v761 
            do! v776 
            let v779 : bool = v0 > 0
            let v781 : bool =
                if v779 then
                    let v780 : bool = v1 >= v0
                    v780
                else
                    false
            if v781 then
                ()
            else
                let v782 : float = v703 + 0.05
                let v783 : float = v704 + 0.05
                let v784 : float = v705 + 0.01
                let v785 : int32 = v1 + 1
                let v786 : Async<unit> = method5(v0, v785, v782, v783, v784)
                return! v786 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1375 : Async<unit> = _let'_v700 
    let _run_target_args'_v9 = v1375 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1377 : unit = ()
    let _let'_v1377 =
        async {
            let struct (v1380 : float, v1381 : float, v1382 : float) = method7(v2, v3, v4)
            let v1383 : struct (float * float) list = []
            let v1385 : struct (float * float) list = struct (5.0, 40.0) :: v1383 
            let v1389 : struct (float * float) list = struct (10.0, 10.0) :: v1385 
            let v1393 : struct (float * float) list = struct (20.0, -40.0) :: v1389 
            let v1397 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v1380, v1381, v1382)
            let v1398 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v1397 
            let v1399 : struct (int32 * float * char) seq = v1398 v1393
            let v1404 : US4 = US4_1
            let v1405 : (US4 []) = Array.create (160 * 44) v1404 
            let v1409 : (int32 -> (struct (float * char) -> unit)) = closure6(v1405)
            let v1410 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v1409 idx (ooz, ch))
            v1410 v1399
            let v1411 : string = method14()
            let v1413 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v1414 : System.Text.StringBuilder = v1413 v1411
            let v1417 : (int32 -> unit) = closure8(v1405, v1414)
            for row in 0 .. (44 - 1) do v1417 row
            let v1419 : (System.Text.StringBuilder -> string) = _.ToString()
            let v1420 : string = v1419 v1414
            let v1423 : bool = v0 < 0
            if v1423 then
                (* run_target_args'
                let v1424 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1425 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1425 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1426 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1426 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1427 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1427 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1428 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v1428 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1429 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v1429 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v1430 : unit = ()
            let v1431 : (unit -> unit) = closure10(v1420)
            let v1432 : unit = (fun () -> v1431 (); v1430) ()
            (* run_target_args'
            let v1438 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1439 : (int32 -> Async<unit>) = Async.Sleep
            let v1440 : Async<unit> = v1439 1
            let _run_target_args'_v1438 = v1440 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1441 : (int32 -> Async<unit>) = Async.Sleep
            let v1442 : Async<unit> = v1441 1
            let _run_target_args'_v1438 = v1442 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1443 : (int32 -> Async<unit>) = Async.Sleep
            let v1444 : Async<unit> = v1443 1
            let _run_target_args'_v1438 = v1444 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1445 : (int32 -> Async<unit>) = Async.Sleep
            let v1446 : Async<unit> = v1445 1
            let _run_target_args'_v1438 = v1446 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1447 : (int32 -> Async<unit>) = Async.Sleep
            let v1448 : Async<unit> = v1447 1
            let _run_target_args'_v1438 = v1448 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1449 : (int32 -> Async<unit>) = Async.Sleep
            let v1450 : Async<unit> = v1449 1
            let _run_target_args'_v1438 = v1450 
            #endif
#else
            let v1451 : (int32 -> Async<unit>) = Async.Sleep
            let v1452 : Async<unit> = v1451 1
            let _run_target_args'_v1438 = v1452 
            #endif
            let v1453 : Async<unit> = _run_target_args'_v1438 
            do! v1453 
            let v1456 : bool = v0 > 0
            let v1458 : bool =
                if v1456 then
                    let v1457 : bool = v1 >= v0
                    v1457
                else
                    false
            if v1458 then
                ()
            else
                let v1459 : float = v1380 + 0.05
                let v1460 : float = v1381 + 0.05
                let v1461 : float = v1382 + 0.01
                let v1462 : int32 = v1 + 1
                let v1463 : Async<unit> = method5(v0, v1462, v1459, v1460, v1461)
                return! v1463 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2052 : Async<unit> = _let'_v1377 
    let _run_target_args'_v9 = v2052 
    #endif
#else
    let v2054 : unit = ()
    let _let'_v2054 =
        async {
            let struct (v2057 : float, v2058 : float, v2059 : float) = method7(v2, v3, v4)
            let v2060 : struct (float * float) list = []
            let v2062 : struct (float * float) list = struct (5.0, 40.0) :: v2060 
            let v2066 : struct (float * float) list = struct (10.0, 10.0) :: v2062 
            let v2070 : struct (float * float) list = struct (20.0, -40.0) :: v2066 
            let v2074 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v2057, v2058, v2059)
            let v2075 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v2074 
            let v2076 : struct (int32 * float * char) seq = v2075 v2070
            let v2081 : US4 = US4_1
            let v2082 : (US4 []) = Array.create (160 * 44) v2081 
            let v2086 : (int32 -> (struct (float * char) -> unit)) = closure6(v2082)
            let v2087 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v2086 idx (ooz, ch))
            v2087 v2076
            let v2088 : string = method14()
            let v2090 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v2091 : System.Text.StringBuilder = v2090 v2088
            let v2094 : (int32 -> unit) = closure8(v2082, v2091)
            for row in 0 .. (44 - 1) do v2094 row
            let v2096 : (System.Text.StringBuilder -> string) = _.ToString()
            let v2097 : string = v2096 v2091
            let v2100 : bool = v0 < 0
            if v2100 then
                (* run_target_args'
                let v2101 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2102 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v2102 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2103 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v2103 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2104 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v2104 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2105 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v2105 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2106 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v2106 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v2107 : unit = ()
            let v2108 : (unit -> unit) = closure10(v2097)
            let v2109 : unit = (fun () -> v2108 (); v2107) ()
            (* run_target_args'
            let v2115 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2116 : (int32 -> Async<unit>) = Async.Sleep
            let v2117 : Async<unit> = v2116 1
            let _run_target_args'_v2115 = v2117 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2118 : (int32 -> Async<unit>) = Async.Sleep
            let v2119 : Async<unit> = v2118 1
            let _run_target_args'_v2115 = v2119 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2120 : (int32 -> Async<unit>) = Async.Sleep
            let v2121 : Async<unit> = v2120 1
            let _run_target_args'_v2115 = v2121 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2122 : (int32 -> Async<unit>) = Async.Sleep
            let v2123 : Async<unit> = v2122 1
            let _run_target_args'_v2115 = v2123 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2124 : (int32 -> Async<unit>) = Async.Sleep
            let v2125 : Async<unit> = v2124 1
            let _run_target_args'_v2115 = v2125 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2126 : (int32 -> Async<unit>) = Async.Sleep
            let v2127 : Async<unit> = v2126 1
            let _run_target_args'_v2115 = v2127 
            #endif
#else
            let v2128 : (int32 -> Async<unit>) = Async.Sleep
            let v2129 : Async<unit> = v2128 1
            let _run_target_args'_v2115 = v2129 
            #endif
            let v2130 : Async<unit> = _run_target_args'_v2115 
            do! v2130 
            let v2133 : bool = v0 > 0
            let v2135 : bool =
                if v2133 then
                    let v2134 : bool = v1 >= v0
                    v2134
                else
                    false
            if v2135 then
                ()
            else
                let v2136 : float = v2057 + 0.05
                let v2137 : float = v2058 + 0.05
                let v2138 : float = v2059 + 0.01
                let v2139 : int32 = v1 + 1
                let v2140 : Async<unit> = method5(v0, v2139, v2136, v2137, v2138)
                return! v2140 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2729 : Async<unit> = _let'_v2054 
    let _run_target_args'_v9 = v2729 
    #endif
    let v2730 : Async<unit> = _run_target_args'_v9 
    v2730
and method5 (v0 : int32, v1 : int32, v2 : float, v3 : float, v4 : float) : Async<unit> =
    method6(v0, v1, v2, v3, v4)
and closure0 () (v0 : (string [])) : unit =
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
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
    let _run_target_args'_v10 = v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
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
    let _run_target_args'_v10 = v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
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
    let _run_target_args'_v10 = v37 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
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
    let _run_target_args'_v10 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
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
    let _run_target_args'_v10 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v10 = false 
    #endif
#else
    let v56 : string = method0()
    let v57 : string = method1(v56)
    let v58 : int32 = v57.Length
    let v59 : bool = 0 = v58
    let v64 : bool =
        if v59 then
            let v60 : string = "AUTOMATION"
            let v61 : string = method1(v60)
            let v62 : int32 = v61.Length
            let v63 : bool = 0 = v62
            v63
        else
            false
    let _run_target_args'_v10 = v64 
    #endif
    let v65 : bool = _run_target_args'_v10 
    if v65 then
        (* run_target_args'
        let v76 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v77 : string = $"print!(\"\\x1B[?25l\")"
        Fable.Core.RustInterop.emitRustExpr () v77 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v78 : string = $"print!(\"\\x1B[?25l\")"
        Fable.Core.RustInterop.emitRustExpr () v78 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v79 : string = $"print!(\"\\x1B[?25l\")"
        Fable.Core.RustInterop.emitRustExpr () v79 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v80 : string = $"process.stdout.write('\\u001B[?25l')"
        Fable.Core.JsInterop.emitJsExpr () v80 
        #endif
#if FABLE_COMPILER_PYTHON
        let v81 : string = "sys"
        Fable.Core.PyInterop.importAll v81 
        let v82 : string = $"sys.stdout.write(\"\\033[?25l\")"
        Fable.Core.PyInterop.emitPyExpr () v82 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        #endif
#else
        System.Console.CursorVisible <- false
        #endif
        // run_target_args' is_unit
        ()
    let v83 : int32 =
        if v65 then
            -1
        else
            50
    let v84 : int32 = 1
    let v85 : float = 0.0
    let v86 : float = 0.0
    let v87 : float = 0.0
    let v88 : Async<unit> = method5(v83, v84, v85, v86, v87)
    (* run_target_args'
    let v93 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v94 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : (Async<unit> -> unit) = Async.RunSynchronously
    v95 v88
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v96 : (Async<unit> -> unit) = Async.RunSynchronously
    v96 v88
    #endif
#else
    let v97 : (Async<unit> -> unit) = Async.RunSynchronously
    v97 v88
    #endif
    // run_target_args' is_unit
    #endif
#if FABLE_COMPILER_RUST && WASM
    (* run_target_args'
    let v98 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : (Async<unit> -> unit) = Async.RunSynchronously
    v99 v88
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v100 : (Async<unit> -> unit) = Async.RunSynchronously
    v100 v88
    #endif
#else
    let v101 : (Async<unit> -> unit) = Async.RunSynchronously
    v101 v88
    #endif
    // run_target_args' is_unit
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    (* run_target_args'
    let v102 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_PYTHON
    let v103 : (Async<unit> -> unit) = Async.RunSynchronously
    v103 v88
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v104 : (Async<unit> -> unit) = Async.RunSynchronously
    v104 v88
    #endif
#else
    let v105 : (Async<unit> -> unit) = Async.RunSynchronously
    v105 v88
    #endif
    // run_target_args' is_unit
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    (* run_target_args'
    let v110 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v112 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _run_target_args'_v110 = v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v116 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _run_target_args'_v110 = v116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v120 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _run_target_args'_v110 = v120 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v123 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v124 : Async<Async<unit>> = v123 v88
    let _run_target_args'_v110 = v124 
    #endif
#if FABLE_COMPILER_PYTHON
    let v125 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v126 : Async<Async<unit>> = v125 v88
    let _run_target_args'_v110 = v126 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v127 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v128 : Async<Async<unit>> = v127 v88
    let _run_target_args'_v110 = v128 
    #endif
#else
    let v129 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v130 : Async<Async<unit>> = v129 v88
    let _run_target_args'_v110 = v130 
    #endif
    let v131 : Async<Async<unit>> = _run_target_args'_v110 
    #endif
#if FABLE_COMPILER_PYTHON
    (* run_target_args'
    let v137 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v138 : (Async<unit> -> unit) = Async.StartImmediate
    v138 v88
    #endif
#if FABLE_COMPILER_PYTHON
    let v139 : (Async<unit> -> unit) = Async.StartImmediate
    v139 v88
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v140 : (Async<unit> -> unit) = Async.StartImmediate
    v140 v88
    #endif
#else
    let v141 : (Async<unit> -> unit) = Async.StartImmediate
    v141 v88
    #endif
    // run_target_args' is_unit
    (* run_target_args'
    let v142 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v143 : (int32 -> unit) = System.Threading.Thread.Sleep
    v143 2000
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v144 : (int32 -> unit) = System.Threading.Thread.Sleep
    v144 2000
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v145 : (int32 -> unit) = System.Threading.Thread.Sleep
    v145 2000
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    let v146 : (int32 -> unit) = System.Threading.Thread.Sleep
    v146 2000
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    let v147 : (int32 -> unit) = System.Threading.Thread.Sleep
    v147 2000
    #endif
    // run_target_args' is_unit
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    (* run_target_args'
    let v152 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v154 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _run_target_args'_v152 = v154 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v158 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _run_target_args'_v152 = v158 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v162 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _run_target_args'_v152 = v162 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v165 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v166 : Async<Async<unit>> = v165 v88
    let _run_target_args'_v152 = v166 
    #endif
#if FABLE_COMPILER_PYTHON
    let v167 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v168 : Async<Async<unit>> = v167 v88
    let _run_target_args'_v152 = v168 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v169 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v170 : Async<Async<unit>> = v169 v88
    let _run_target_args'_v152 = v170 
    #endif
#else
    let v171 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v172 : Async<Async<unit>> = v171 v88
    let _run_target_args'_v152 = v172 
    #endif
    let v173 : Async<Async<unit>> = _run_target_args'_v152 
    #endif
#else
    (* run_target_args'
    let v179 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_PYTHON
    let v180 : (Async<unit> -> unit) = Async.RunSynchronously
    v180 v88
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v181 : (Async<unit> -> unit) = Async.RunSynchronously
    v181 v88
    #endif
#else
    let v182 : (Async<unit> -> unit) = Async.RunSynchronously
    v182 v88
    #endif
    // run_target_args' is_unit
    #endif
    // run_target_args' is_unit
    ()
let v0 : ((string []) -> unit) = closure0()
let main_ = v0 
#if !FABLE_COMPILER_RUST
main_ [||]
#else
let main args = main_ [||]; 0
#endif
()
