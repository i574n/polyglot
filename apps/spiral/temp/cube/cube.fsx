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
            let v85 : bool = v0 > 0
            let v87 : bool =
                if v85 then
                    let v86 : bool = v1 >= v0
                    v86
                else
                    false
            if v87 then
                ()
            else
                let v88 : float = v18 + 0.05
                let v89 : float = v19 + 0.05
                let v90 : float = v20 + 0.01
                let v91 : int32 = v1 + 1
                let v92 : Async<unit> = method5(v0, v91, v88, v89, v90)
                return! v92 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v618 : Async<unit> = _v15 
    let _v5 = v618 
    #endif
#if FABLE_COMPILER_PYTHON
    let v619 : unit = ()
    let _v619 =
        async {
            let struct (v622 : float, v623 : float, v624 : float) = method7(v2, v3, v4)
            let v625 : struct (float * float) list = []
            let v626 : struct (float * float) list = struct (5.0, 40.0) :: v625 
            let v629 : struct (float * float) list = struct (10.0, 10.0) :: v626 
            let v632 : struct (float * float) list = struct (20.0, -40.0) :: v629 
            let v635 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v622, v623, v624)
            let v636 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v635 
            let v637 : struct (int32 * float * char) seq = v636 v632
            let v641 : US4 = US4_1
            let v642 : (US4 []) = Array.create (160 * 44) v641 
            let v646 : (int32 -> (struct (float * char) -> unit)) = closure6(v642)
            let v647 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v646 idx (ooz, ch))
            v647 v637
            let v648 : string = method14()
            let v649 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v650 : System.Text.StringBuilder = v649 v648
            let v653 : (int32 -> unit) = closure8(v642, v650)
            for row in 0 .. (44 - 1) do v653 row
            let v654 : (System.Text.StringBuilder -> string) = _.ToString()
            let v655 : string = v654 v650
            let v658 : bool = v0 < 0
            if v658 then
                let v659 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v660 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v660 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v661 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v661 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v662 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v662 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v663 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v663 
                #endif
#if FABLE_COMPILER_PYTHON
                let v664 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v664 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v665 : unit = ()
            let v666 : (unit -> unit) = closure10(v655)
            let v667 : unit = (fun () -> v666 (); v665) ()
            let v669 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v670 : (int32 -> Async<unit>) = Async.Sleep
            let v671 : Async<unit> = v670 1
            let _v669 = v671 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v672 : (int32 -> Async<unit>) = Async.Sleep
            let v673 : Async<unit> = v672 1
            let _v669 = v673 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v674 : (int32 -> Async<unit>) = Async.Sleep
            let v675 : Async<unit> = v674 1
            let _v669 = v675 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v676 : (int32 -> Async<unit>) = Async.Sleep
            let v677 : Async<unit> = v676 1
            let _v669 = v677 
            #endif
#if FABLE_COMPILER_PYTHON
            let v678 : (int32 -> Async<unit>) = Async.Sleep
            let v679 : Async<unit> = v678 1
            let _v669 = v679 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v680 : (int32 -> Async<unit>) = Async.Sleep
            let v681 : Async<unit> = v680 1
            let _v669 = v681 
            #endif
#else
            let v682 : (int32 -> Async<unit>) = Async.Sleep
            let v683 : Async<unit> = v682 1
            let _v669 = v683 
            #endif
            let v684 : Async<unit> = _v669 
            do! v684 
            let v689 : bool = v0 > 0
            let v691 : bool =
                if v689 then
                    let v690 : bool = v1 >= v0
                    v690
                else
                    false
            if v691 then
                ()
            else
                let v692 : float = v622 + 0.05
                let v693 : float = v623 + 0.05
                let v694 : float = v624 + 0.01
                let v695 : int32 = v1 + 1
                let v696 : Async<unit> = method5(v0, v695, v692, v693, v694)
                return! v696 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1222 : Async<unit> = _v619 
    let _v5 = v1222 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1223 : unit = ()
    let _v1223 =
        async {
            let struct (v1226 : float, v1227 : float, v1228 : float) = method7(v2, v3, v4)
            let v1229 : struct (float * float) list = []
            let v1230 : struct (float * float) list = struct (5.0, 40.0) :: v1229 
            let v1233 : struct (float * float) list = struct (10.0, 10.0) :: v1230 
            let v1236 : struct (float * float) list = struct (20.0, -40.0) :: v1233 
            let v1239 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v1226, v1227, v1228)
            let v1240 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v1239 
            let v1241 : struct (int32 * float * char) seq = v1240 v1236
            let v1245 : US4 = US4_1
            let v1246 : (US4 []) = Array.create (160 * 44) v1245 
            let v1250 : (int32 -> (struct (float * char) -> unit)) = closure6(v1246)
            let v1251 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v1250 idx (ooz, ch))
            v1251 v1241
            let v1252 : string = method14()
            let v1253 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v1254 : System.Text.StringBuilder = v1253 v1252
            let v1257 : (int32 -> unit) = closure8(v1246, v1254)
            for row in 0 .. (44 - 1) do v1257 row
            let v1258 : (System.Text.StringBuilder -> string) = _.ToString()
            let v1259 : string = v1258 v1254
            let v1262 : bool = v0 < 0
            if v1262 then
                let v1263 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1264 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1264 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1265 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1265 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1266 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1266 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1267 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v1267 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1268 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v1268 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v1269 : unit = ()
            let v1270 : (unit -> unit) = closure10(v1259)
            let v1271 : unit = (fun () -> v1270 (); v1269) ()
            let v1273 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1274 : (int32 -> Async<unit>) = Async.Sleep
            let v1275 : Async<unit> = v1274 1
            let _v1273 = v1275 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1276 : (int32 -> Async<unit>) = Async.Sleep
            let v1277 : Async<unit> = v1276 1
            let _v1273 = v1277 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1278 : (int32 -> Async<unit>) = Async.Sleep
            let v1279 : Async<unit> = v1278 1
            let _v1273 = v1279 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1280 : (int32 -> Async<unit>) = Async.Sleep
            let v1281 : Async<unit> = v1280 1
            let _v1273 = v1281 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1282 : (int32 -> Async<unit>) = Async.Sleep
            let v1283 : Async<unit> = v1282 1
            let _v1273 = v1283 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1284 : (int32 -> Async<unit>) = Async.Sleep
            let v1285 : Async<unit> = v1284 1
            let _v1273 = v1285 
            #endif
#else
            let v1286 : (int32 -> Async<unit>) = Async.Sleep
            let v1287 : Async<unit> = v1286 1
            let _v1273 = v1287 
            #endif
            let v1288 : Async<unit> = _v1273 
            do! v1288 
            let v1293 : bool = v0 > 0
            let v1295 : bool =
                if v1293 then
                    let v1294 : bool = v1 >= v0
                    v1294
                else
                    false
            if v1295 then
                ()
            else
                let v1296 : float = v1226 + 0.05
                let v1297 : float = v1227 + 0.05
                let v1298 : float = v1228 + 0.01
                let v1299 : int32 = v1 + 1
                let v1300 : Async<unit> = method5(v0, v1299, v1296, v1297, v1298)
                return! v1300 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1826 : Async<unit> = _v1223 
    let _v5 = v1826 
    #endif
#else
    let v1827 : unit = ()
    let _v1827 =
        async {
            let struct (v1830 : float, v1831 : float, v1832 : float) = method7(v2, v3, v4)
            let v1833 : struct (float * float) list = []
            let v1834 : struct (float * float) list = struct (5.0, 40.0) :: v1833 
            let v1837 : struct (float * float) list = struct (10.0, 10.0) :: v1834 
            let v1840 : struct (float * float) list = struct (20.0, -40.0) :: v1837 
            let v1843 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v1830, v1831, v1832)
            let v1844 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v1843 
            let v1845 : struct (int32 * float * char) seq = v1844 v1840
            let v1849 : US4 = US4_1
            let v1850 : (US4 []) = Array.create (160 * 44) v1849 
            let v1854 : (int32 -> (struct (float * char) -> unit)) = closure6(v1850)
            let v1855 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v1854 idx (ooz, ch))
            v1855 v1845
            let v1856 : string = method14()
            let v1857 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v1858 : System.Text.StringBuilder = v1857 v1856
            let v1861 : (int32 -> unit) = closure8(v1850, v1858)
            for row in 0 .. (44 - 1) do v1861 row
            let v1862 : (System.Text.StringBuilder -> string) = _.ToString()
            let v1863 : string = v1862 v1858
            let v1866 : bool = v0 < 0
            if v1866 then
                let v1867 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1868 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1868 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1869 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1869 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1870 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1870 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1871 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v1871 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1872 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v1872 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v1873 : unit = ()
            let v1874 : (unit -> unit) = closure10(v1863)
            let v1875 : unit = (fun () -> v1874 (); v1873) ()
            let v1877 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1878 : (int32 -> Async<unit>) = Async.Sleep
            let v1879 : Async<unit> = v1878 1
            let _v1877 = v1879 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1880 : (int32 -> Async<unit>) = Async.Sleep
            let v1881 : Async<unit> = v1880 1
            let _v1877 = v1881 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1882 : (int32 -> Async<unit>) = Async.Sleep
            let v1883 : Async<unit> = v1882 1
            let _v1877 = v1883 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1884 : (int32 -> Async<unit>) = Async.Sleep
            let v1885 : Async<unit> = v1884 1
            let _v1877 = v1885 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1886 : (int32 -> Async<unit>) = Async.Sleep
            let v1887 : Async<unit> = v1886 1
            let _v1877 = v1887 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1888 : (int32 -> Async<unit>) = Async.Sleep
            let v1889 : Async<unit> = v1888 1
            let _v1877 = v1889 
            #endif
#else
            let v1890 : (int32 -> Async<unit>) = Async.Sleep
            let v1891 : Async<unit> = v1890 1
            let _v1877 = v1891 
            #endif
            let v1892 : Async<unit> = _v1877 
            do! v1892 
            let v1897 : bool = v0 > 0
            let v1899 : bool =
                if v1897 then
                    let v1898 : bool = v1 >= v0
                    v1898
                else
                    false
            if v1899 then
                ()
            else
                let v1900 : float = v1830 + 0.05
                let v1901 : float = v1831 + 0.05
                let v1902 : float = v1832 + 0.01
                let v1903 : int32 = v1 + 1
                let v1904 : Async<unit> = method5(v0, v1903, v1900, v1901, v1902)
                return! v1904 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2430 : Async<unit> = _v1827 
    let _v5 = v2430 
    #endif
    let v2431 : Async<unit> = _v5 
    v2431
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
    #endif
#if FABLE_COMPILER_PYTHON
    let v173 : unit = ()
    
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
    let v174 : (Async<unit> -> unit) = Async.StartImmediate
    v174 v79
    #endif
#if FABLE_COMPILER_PYTHON
    let v175 : (Async<unit> -> unit) = Async.StartImmediate
    v175 v79
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v176 : (Async<unit> -> unit) = Async.StartImmediate
    v176 v79
    #endif
#else
    let v177 : (Async<unit> -> unit) = Async.StartImmediate
    v177 v79
    #endif
    // run_target_args' is_unit
    let v178 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v179 : (int32 -> unit) = System.Threading.Thread.Sleep
    v179 2000
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v180 : (int32 -> unit) = System.Threading.Thread.Sleep
    v180 2000
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : (int32 -> unit) = System.Threading.Thread.Sleep
    v181 2000
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    let v182 : (int32 -> unit) = System.Threading.Thread.Sleep
    v182 2000
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    let v183 : (int32 -> unit) = System.Threading.Thread.Sleep
    v183 2000
    #endif
    // run_target_args' is_unit
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
    #endif
#else
    let v207 : unit = ()
    
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
    let v208 : (Async<unit> -> unit) = Async.RunSynchronously
    v208 v79
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v209 : (Async<unit> -> unit) = Async.RunSynchronously
    v209 v79
    #endif
#else
    let v210 : (Async<unit> -> unit) = Async.RunSynchronously
    v210 v79
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
