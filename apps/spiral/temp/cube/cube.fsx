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
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method2(v0)
    let v3 : string = "std::env::var(&*$0)"
    let v4 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "x"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = "fable_library_rust::String_::fromString($0)"
    let v10 : string = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "true; $0 })"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "_result_map_"
    let v14 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : string = method3()
    let v16 : string = "$0.unwrap_or($1)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr struct (v14, v15) v16 
    let _v1 = v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : US0 = US0_1
    let v19 : US1 = US1_2(v18)
    let v20 : string = $"env.get_environment_variable / target: {v19} / var: {v0}"
    let v21 : string = failwith<string> v20
    let _v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : US0 = US0_2
    let v23 : US1 = US1_2(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _v1 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "process.env[$0] ?? \"\""
    let v27 : string = Fable.Core.JsInterop.emitJsExpr v0 v26 
    let _v1 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v28 : string = "os"
    let v29 : IOsEnviron = Fable.Core.PyInterop.importAll v28 
    let v30 : string = "v29.environ"
    let v31 : obj = Fable.Core.PyInterop.emitPyExpr () v30 
    let v34 : string = "v31.get($0)"
    let v35 : string = Fable.Core.PyInterop.emitPyExpr v0 v34 
    let mutable _v35 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v38 : (string -> string option) = Option.ofObj
    let v39 : string option = v38 v35
    v39 
    #else
    Some v35 
    #endif
    |> fun x -> _v35 <- Some x
    let v40 : string option = match _v35 with Some x -> x | None -> failwith "optionm'.of_obj / _v35=None"
    let v43 : (string -> US2) = method4()
    let v44 : US2 option = v40 |> Option.map v43 
    let v55 : US2 = US2_1
    let v56 : US2 = v44 |> Option.defaultValue v55 
    let v63 : string =
        match v56 with
        | US2_1 -> (* None *)
            let v61 : string = ""
            v61
        | US2_0(v60) -> (* Some *)
            v60
    let _v1 = v63 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v64 : US0 = US0_1
    let v65 : US1 = US1_0(v64)
    let v66 : string = $"env.get_environment_variable / target: {v65} / var: {v0}"
    let v67 : string = failwith<string> v66
    let _v1 = v67 
    #endif
#else
    let v68 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v69 : string = v68 v0
    let mutable _v69 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v70 : (string -> string option) = Option.ofObj
    let v71 : string option = v70 v69
    v71 
    #else
    Some v69 
    #endif
    |> fun x -> _v69 <- Some x
    let v72 : string option = match _v69 with Some x -> x | None -> failwith "optionm'.of_obj / _v69=None"
    let v75 : (string -> US2) = method4()
    let v76 : US2 option = v72 |> Option.map v75 
    let v87 : US2 = US2_1
    let v88 : US2 = v76 |> Option.defaultValue v87 
    let v95 : string =
        match v88 with
        | US2_1 -> (* None *)
            let v93 : string = ""
            v93
        | US2_0(v92) -> (* Some *)
            v92
    let _v1 = v95 
    #endif
    let v96 : string = _v1 
    v96
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
    let v23 : US3 list = v21 :: v22 
    let v26 : US3 list = v19 :: v23 
    let v29 : US3 list = v16 :: v26 
    let v32 : US3 list = v14 :: v29 
    let v35 : US3 list = v11 :: v32 
    let v38 : US3 list = v9 :: v35 
    v38
and closure3 (v0 : float, v1 : float, v2 : float, v3 : float, v4 : float) (v5 : float) : (float -> US3 list) =
    closure4(v0, v1, v2, v3, v4, v5)
and method11 (v0 : float, v1 : float, v2 : float, v3 : float, v4 : float) : (float -> (float -> US3 list)) =
    closure3(v0, v1, v2, v3, v4)
and closure5 () (v0 : US3) : struct (int32 * float * char) option =
    match v0 with
    | US3_1 -> (* None *)
        let v7 : struct (int32 * float * char) option = None
        v7
    | US3_0(v1, v2, v3) -> (* Some *)
        let v4 : struct (int32 * float * char) option = Some struct (v1, v2, v3) 
        v4
and method13 () : (US3 -> struct (int32 * float * char) option) =
    closure5()
and closure2 (v0 : float, v1 : float, v2 : float) struct (v3 : float, v4 : float) : struct (int32 * float * char) seq =
    let v5 : float =  -v3
    let v6 : unit = ()
    let _v6 =
        seq {
            let v9 : Mut0 = {l0 = v5} : Mut0
            while method9(v3, v9) do
                let v11 : float = v9.l0
                yield v11 
                let v12 : float = v9.l0
                let v13 : float = v12 + 0.6
                v9.l0 <- v13
                ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v49 : float seq = _v6 
    let v53 : float seq = method10(v49)
    let v54 : (float -> (float -> US3 list)) = method11(v0, v1, v2, v3, v4)
    let v55 : (US3 -> struct (int32 * float * char) option) = method13()
    let v56 : unit = ()
    let _v56 =
        seq {
            for cube_x in v53 do
            for cube_y in v53 do
            let x = v54 cube_x cube_y |> Seq.choose v55 
            yield! x
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v59 : struct (int32 * float * char) seq = _v56 
    v59
and method8 (v0 : float, v1 : float, v2 : float) : (struct (float * float) -> struct (int32 * float * char) seq) =
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
and method14 () : string =
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
and method6 (v0 : int32, v1 : int32, v2 : float, v3 : float, v4 : float) : Async<unit> =
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
            let struct (v18 : float, v19 : float, v20 : float) = method7(v2, v3, v4)
            let v21 : struct (float * float) list = []
            let v22 : struct (float * float) list = struct (5.0, 40.0) :: v21 
            let v25 : struct (float * float) list = struct (10.0, 10.0) :: v22 
            let v28 : struct (float * float) list = struct (20.0, -40.0) :: v25 
            let v31 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v18, v19, v20)
            let v32 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v31 
            let v33 : struct (int32 * float * char) seq = v32 v28
            let v37 : US4 = US4_1
            let v38 : (US4 []) = Array.create (160 * 44) v37 
            let v42 : (int32 -> (struct (float * char) -> unit)) = closure6(v38)
            let v43 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v42 idx (ooz, ch))
            v43 v33
            let v44 : string = method14()
            let v45 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v46 : System.Text.StringBuilder = v45 v44
            let v49 : (int32 -> unit) = closure8(v38, v46)
            for row in 0 .. (44 - 1) do v49 row
            let v50 : (System.Text.StringBuilder -> string) = _.ToString()
            let v51 : string = v50 v46
            let v54 : bool = v0 < 0
            if v54 then
                let v55 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v56 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v56 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v57 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v57 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v58 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v58 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v59 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v59 
                #endif
#if FABLE_COMPILER_PYTHON
                let v60 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v60 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v61 : unit = ()
            let v62 : (unit -> unit) = closure10(v51)
            let v63 : unit = (fun () -> v62 (); v61) ()
            let v65 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v66 : (int32 -> Async<unit>) = Async.Sleep
            let v67 : Async<unit> = v66 1
            let _v65 = v67 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v68 : (int32 -> Async<unit>) = Async.Sleep
            let v69 : Async<unit> = v68 1
            let _v65 = v69 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v70 : (int32 -> Async<unit>) = Async.Sleep
            let v71 : Async<unit> = v70 1
            let _v65 = v71 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v72 : (int32 -> Async<unit>) = Async.Sleep
            let v73 : Async<unit> = v72 1
            let _v65 = v73 
            #endif
#if FABLE_COMPILER_PYTHON
            let v74 : (int32 -> Async<unit>) = Async.Sleep
            let v75 : Async<unit> = v74 1
            let _v65 = v75 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v76 : (int32 -> Async<unit>) = Async.Sleep
            let v77 : Async<unit> = v76 1
            let _v65 = v77 
            #endif
#else
            let v78 : (int32 -> Async<unit>) = Async.Sleep
            let v79 : Async<unit> = v78 1
            let _v65 = v79 
            #endif
            let v80 : Async<unit> = _v65 
            do! v80 
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
                let v86 : float = v18 + 0.05
                let v87 : float = v19 + 0.05
                let v88 : float = v20 + 0.01
                let v89 : int32 = v1 + 1
                let v90 : Async<unit> = method5(v0, v89, v86, v87, v88)
                return! v90 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v602 : Async<unit> = _v15 
    let _v5 = v602 
    #endif
#if FABLE_COMPILER_PYTHON
    let v603 : unit = ()
    let _v603 =
        async {
            let struct (v606 : float, v607 : float, v608 : float) = method7(v2, v3, v4)
            let v609 : struct (float * float) list = []
            let v610 : struct (float * float) list = struct (5.0, 40.0) :: v609 
            let v613 : struct (float * float) list = struct (10.0, 10.0) :: v610 
            let v616 : struct (float * float) list = struct (20.0, -40.0) :: v613 
            let v619 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v606, v607, v608)
            let v620 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v619 
            let v621 : struct (int32 * float * char) seq = v620 v616
            let v625 : US4 = US4_1
            let v626 : (US4 []) = Array.create (160 * 44) v625 
            let v630 : (int32 -> (struct (float * char) -> unit)) = closure6(v626)
            let v631 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v630 idx (ooz, ch))
            v631 v621
            let v632 : string = method14()
            let v633 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v634 : System.Text.StringBuilder = v633 v632
            let v637 : (int32 -> unit) = closure8(v626, v634)
            for row in 0 .. (44 - 1) do v637 row
            let v638 : (System.Text.StringBuilder -> string) = _.ToString()
            let v639 : string = v638 v634
            let v642 : bool = v0 < 0
            if v642 then
                let v643 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v644 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v644 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v645 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v645 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v646 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v646 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v647 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v647 
                #endif
#if FABLE_COMPILER_PYTHON
                let v648 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v648 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v649 : unit = ()
            let v650 : (unit -> unit) = closure10(v639)
            let v651 : unit = (fun () -> v650 (); v649) ()
            let v653 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v654 : (int32 -> Async<unit>) = Async.Sleep
            let v655 : Async<unit> = v654 1
            let _v653 = v655 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v656 : (int32 -> Async<unit>) = Async.Sleep
            let v657 : Async<unit> = v656 1
            let _v653 = v657 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v658 : (int32 -> Async<unit>) = Async.Sleep
            let v659 : Async<unit> = v658 1
            let _v653 = v659 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v660 : (int32 -> Async<unit>) = Async.Sleep
            let v661 : Async<unit> = v660 1
            let _v653 = v661 
            #endif
#if FABLE_COMPILER_PYTHON
            let v662 : (int32 -> Async<unit>) = Async.Sleep
            let v663 : Async<unit> = v662 1
            let _v653 = v663 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v664 : (int32 -> Async<unit>) = Async.Sleep
            let v665 : Async<unit> = v664 1
            let _v653 = v665 
            #endif
#else
            let v666 : (int32 -> Async<unit>) = Async.Sleep
            let v667 : Async<unit> = v666 1
            let _v653 = v667 
            #endif
            let v668 : Async<unit> = _v653 
            do! v668 
            let v671 : bool = v0 > 0
            let v673 : bool =
                if v671 then
                    let v672 : bool = v1 >= v0
                    v672
                else
                    false
            if v673 then
                ()
            else
                let v674 : float = v606 + 0.05
                let v675 : float = v607 + 0.05
                let v676 : float = v608 + 0.01
                let v677 : int32 = v1 + 1
                let v678 : Async<unit> = method5(v0, v677, v674, v675, v676)
                return! v678 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1190 : Async<unit> = _v603 
    let _v5 = v1190 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1191 : unit = ()
    let _v1191 =
        async {
            let struct (v1194 : float, v1195 : float, v1196 : float) = method7(v2, v3, v4)
            let v1197 : struct (float * float) list = []
            let v1198 : struct (float * float) list = struct (5.0, 40.0) :: v1197 
            let v1201 : struct (float * float) list = struct (10.0, 10.0) :: v1198 
            let v1204 : struct (float * float) list = struct (20.0, -40.0) :: v1201 
            let v1207 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v1194, v1195, v1196)
            let v1208 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v1207 
            let v1209 : struct (int32 * float * char) seq = v1208 v1204
            let v1213 : US4 = US4_1
            let v1214 : (US4 []) = Array.create (160 * 44) v1213 
            let v1218 : (int32 -> (struct (float * char) -> unit)) = closure6(v1214)
            let v1219 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v1218 idx (ooz, ch))
            v1219 v1209
            let v1220 : string = method14()
            let v1221 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v1222 : System.Text.StringBuilder = v1221 v1220
            let v1225 : (int32 -> unit) = closure8(v1214, v1222)
            for row in 0 .. (44 - 1) do v1225 row
            let v1226 : (System.Text.StringBuilder -> string) = _.ToString()
            let v1227 : string = v1226 v1222
            let v1230 : bool = v0 < 0
            if v1230 then
                let v1231 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1232 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1232 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1233 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1233 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1234 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1234 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1235 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v1235 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1236 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v1236 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v1237 : unit = ()
            let v1238 : (unit -> unit) = closure10(v1227)
            let v1239 : unit = (fun () -> v1238 (); v1237) ()
            let v1241 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1242 : (int32 -> Async<unit>) = Async.Sleep
            let v1243 : Async<unit> = v1242 1
            let _v1241 = v1243 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1244 : (int32 -> Async<unit>) = Async.Sleep
            let v1245 : Async<unit> = v1244 1
            let _v1241 = v1245 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1246 : (int32 -> Async<unit>) = Async.Sleep
            let v1247 : Async<unit> = v1246 1
            let _v1241 = v1247 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1248 : (int32 -> Async<unit>) = Async.Sleep
            let v1249 : Async<unit> = v1248 1
            let _v1241 = v1249 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1250 : (int32 -> Async<unit>) = Async.Sleep
            let v1251 : Async<unit> = v1250 1
            let _v1241 = v1251 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1252 : (int32 -> Async<unit>) = Async.Sleep
            let v1253 : Async<unit> = v1252 1
            let _v1241 = v1253 
            #endif
#else
            let v1254 : (int32 -> Async<unit>) = Async.Sleep
            let v1255 : Async<unit> = v1254 1
            let _v1241 = v1255 
            #endif
            let v1256 : Async<unit> = _v1241 
            do! v1256 
            let v1259 : bool = v0 > 0
            let v1261 : bool =
                if v1259 then
                    let v1260 : bool = v1 >= v0
                    v1260
                else
                    false
            if v1261 then
                ()
            else
                let v1262 : float = v1194 + 0.05
                let v1263 : float = v1195 + 0.05
                let v1264 : float = v1196 + 0.01
                let v1265 : int32 = v1 + 1
                let v1266 : Async<unit> = method5(v0, v1265, v1262, v1263, v1264)
                return! v1266 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1778 : Async<unit> = _v1191 
    let _v5 = v1778 
    #endif
#else
    let v1779 : unit = ()
    let _v1779 =
        async {
            let struct (v1782 : float, v1783 : float, v1784 : float) = method7(v2, v3, v4)
            let v1785 : struct (float * float) list = []
            let v1786 : struct (float * float) list = struct (5.0, 40.0) :: v1785 
            let v1789 : struct (float * float) list = struct (10.0, 10.0) :: v1786 
            let v1792 : struct (float * float) list = struct (20.0, -40.0) :: v1789 
            let v1795 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v1782, v1783, v1784)
            let v1796 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v1795 
            let v1797 : struct (int32 * float * char) seq = v1796 v1792
            let v1801 : US4 = US4_1
            let v1802 : (US4 []) = Array.create (160 * 44) v1801 
            let v1806 : (int32 -> (struct (float * char) -> unit)) = closure6(v1802)
            let v1807 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v1806 idx (ooz, ch))
            v1807 v1797
            let v1808 : string = method14()
            let v1809 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v1810 : System.Text.StringBuilder = v1809 v1808
            let v1813 : (int32 -> unit) = closure8(v1802, v1810)
            for row in 0 .. (44 - 1) do v1813 row
            let v1814 : (System.Text.StringBuilder -> string) = _.ToString()
            let v1815 : string = v1814 v1810
            let v1818 : bool = v0 < 0
            if v1818 then
                let v1819 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1820 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1820 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1821 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1821 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1822 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1822 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1823 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v1823 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1824 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v1824 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v1825 : unit = ()
            let v1826 : (unit -> unit) = closure10(v1815)
            let v1827 : unit = (fun () -> v1826 (); v1825) ()
            let v1829 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1830 : (int32 -> Async<unit>) = Async.Sleep
            let v1831 : Async<unit> = v1830 1
            let _v1829 = v1831 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1832 : (int32 -> Async<unit>) = Async.Sleep
            let v1833 : Async<unit> = v1832 1
            let _v1829 = v1833 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1834 : (int32 -> Async<unit>) = Async.Sleep
            let v1835 : Async<unit> = v1834 1
            let _v1829 = v1835 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1836 : (int32 -> Async<unit>) = Async.Sleep
            let v1837 : Async<unit> = v1836 1
            let _v1829 = v1837 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1838 : (int32 -> Async<unit>) = Async.Sleep
            let v1839 : Async<unit> = v1838 1
            let _v1829 = v1839 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1840 : (int32 -> Async<unit>) = Async.Sleep
            let v1841 : Async<unit> = v1840 1
            let _v1829 = v1841 
            #endif
#else
            let v1842 : (int32 -> Async<unit>) = Async.Sleep
            let v1843 : Async<unit> = v1842 1
            let _v1829 = v1843 
            #endif
            let v1844 : Async<unit> = _v1829 
            do! v1844 
            let v1847 : bool = v0 > 0
            let v1849 : bool =
                if v1847 then
                    let v1848 : bool = v1 >= v0
                    v1848
                else
                    false
            if v1849 then
                ()
            else
                let v1850 : float = v1782 + 0.05
                let v1851 : float = v1783 + 0.05
                let v1852 : float = v1784 + 0.01
                let v1853 : int32 = v1 + 1
                let v1854 : Async<unit> = method5(v0, v1853, v1850, v1851, v1852)
                return! v1854 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2366 : Async<unit> = _v1779 
    let _v5 = v2366 
    #endif
    let v2367 : Async<unit> = _v5 
    v2367
and method5 (v0 : int32, v1 : int32, v2 : float, v3 : float, v4 : float) : Async<unit> =
    method6(v0, v1, v2, v3, v4)
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
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v69 : string = $"print!(\"\\x1B[?25l\")"
        Fable.Core.RustInterop.emitRustExpr () v69 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v70 : string = $"print!(\"\\x1B[?25l\")"
        Fable.Core.RustInterop.emitRustExpr () v70 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v71 : string = $"process.stdout.write('\\u001B[?25l')"
        Fable.Core.JsInterop.emitJsExpr () v71 
        #endif
#if FABLE_COMPILER_PYTHON
        let v72 : string = "sys"
        Fable.Core.PyInterop.importAll v72 
        let v73 : string = $"sys.stdout.write(\"\\033[?25l\")"
        Fable.Core.PyInterop.emitPyExpr () v73 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        #endif
#else
        System.Console.CursorVisible <- false
        #endif
        // run_target_args' is_unit
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
    let v79 : Async<unit> = method5(v74, v75, v76, v77, v78)
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : unit = ()
    
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
    let v82 : (Async<unit> -> unit) = Async.RunSynchronously
    v82 v79
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v83 : (Async<unit> -> unit) = Async.RunSynchronously
    v83 v79
    #endif
#else
    let v84 : (Async<unit> -> unit) = Async.RunSynchronously
    v84 v79
    #endif
    // run_target_args' is_unit
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v85 : unit = ()
    
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
    let v86 : (Async<unit> -> unit) = Async.RunSynchronously
    v86 v79
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : (Async<unit> -> unit) = Async.RunSynchronously
    v87 v79
    #endif
#else
    let v88 : (Async<unit> -> unit) = Async.RunSynchronously
    v88 v79
    #endif
    // run_target_args' is_unit
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v89 : unit = ()
    
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
    let v90 : (Async<unit> -> unit) = Async.RunSynchronously
    v90 v79
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v91 : (Async<unit> -> unit) = Async.RunSynchronously
    v91 v79
    #endif
#else
    let v92 : (Async<unit> -> unit) = Async.RunSynchronously
    v92 v79
    #endif
    // run_target_args' is_unit
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v93 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v94 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v93 = v94 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v93 = v97 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : Async<Async<unit>> = null |> unbox<Async<Async<unit>>>
    let _v93 = v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v104 : Async<Async<unit>> = v103 v79
    let _v93 = v104 
    #endif
#if FABLE_COMPILER_PYTHON
    let v105 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v106 : Async<Async<unit>> = v105 v79
    let _v93 = v106 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v107 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v108 : Async<Async<unit>> = v107 v79
    let _v93 = v108 
    #endif
#else
    let v109 : (Async<unit> -> Async<Async<unit>>) = Async.StartChild
    let v110 : Async<Async<unit>> = v109 v79
    let _v93 = v110 
    #endif
    let v111 : Async<Async<unit>> = _v93 
    #endif
#if FABLE_COMPILER_PYTHON
    let v116 : unit = ()
    
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
    let v117 : (Async<unit> -> unit) = Async.StartImmediate
    v117 v79
    #endif
#if FABLE_COMPILER_PYTHON
    let v118 : (Async<unit> -> unit) = Async.StartImmediate
    v118 v79
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v119 : (Async<unit> -> unit) = Async.StartImmediate
    v119 v79
    #endif
#else
    let v120 : (Async<unit> -> unit) = Async.StartImmediate
    v120 v79
    #endif
    // run_target_args' is_unit
    let v121 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v122 : (int32 -> unit) = System.Threading.Thread.Sleep
    v122 2000
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v123 : (int32 -> unit) = System.Threading.Thread.Sleep
    v123 2000
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v124 : (int32 -> unit) = System.Threading.Thread.Sleep
    v124 2000
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    let v125 : (int32 -> unit) = System.Threading.Thread.Sleep
    v125 2000
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    let v126 : (int32 -> unit) = System.Threading.Thread.Sleep
    v126 2000
    #endif
    // run_target_args' is_unit
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
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
    #endif
#else
    let v150 : unit = ()
    
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
    let v151 : (Async<unit> -> unit) = Async.RunSynchronously
    v151 v79
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : (Async<unit> -> unit) = Async.RunSynchronously
    v152 v79
    #endif
#else
    let v153 : (Async<unit> -> unit) = Async.RunSynchronously
    v153 v79
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
