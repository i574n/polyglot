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
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method2(v0)
    let v4 : string = "std::env::var(&*$0)"
    let v5 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "x"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "true; $0 })"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "_result_map_"
    let v15 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = method3()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    let _run_target_args'_v2 = v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : US0 = US0_1
    let v20 : US1 = US1_3(v19)
    let v21 : string = $"env.get_environment_variable / target: {v20} / var: {v0}"
    let v22 : string = failwith<string> v21
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : US0 = US0_2
    let v24 : US1 = US1_3(v23)
    let v25 : string = $"env.get_environment_variable / target: {v24} / var: {v0}"
    let v26 : string = failwith<string> v25
    let _run_target_args'_v2 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : string = "process.env[$0] ?? \"\""
    let v28 : string = Fable.Core.JsInterop.emitJsExpr v0 v27 
    let _run_target_args'_v2 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v30 : string = "os"
    let v31 : IOsEnviron = Fable.Core.PyInterop.importAll v30 
    let v32 : string = "v31.environ"
    let v33 : obj = Fable.Core.PyInterop.emitPyExpr () v32 
    let v37 : string = "v33.get($0)"
    let v38 : string = Fable.Core.PyInterop.emitPyExpr v0 v37 
    let mutable _v38 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v42 : (string -> string option) = Option.ofObj
    let v43 : string option = v42 v38
    v43 
    #else
    Some v38 
    #endif
    |> fun x -> _v38 <- Some x
    let v44 : string option = match _v38 with Some x -> x | None -> failwith "optionm'.of_obj / _v38=None"
    let v49 : (string -> US2) = method4()
    let v50 : US2 option = v44 |> Option.map v49 
    let v70 : US2 = US2_1
    let v71 : US2 = v50 |> Option.defaultValue v70 
    let v78 : string =
        match v71 with
        | US2_1 -> (* None *)
            let v76 : string = ""
            v76
        | US2_0(v75) -> (* Some *)
            v75
    let _run_target_args'_v2 = v78 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : US0 = US0_1
    let v80 : US1 = US1_1(v79)
    let v81 : string = $"env.get_environment_variable / target: {v80} / var: {v0}"
    let v82 : string = failwith<string> v81
    let _run_target_args'_v2 = v82 
    #endif
#else
    let v83 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v84 : string = v83 v0
    let mutable _v84 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v86 : (string -> string option) = Option.ofObj
    let v87 : string option = v86 v84
    v87 
    #else
    Some v84 
    #endif
    |> fun x -> _v84 <- Some x
    let v88 : string option = match _v84 with Some x -> x | None -> failwith "optionm'.of_obj / _v84=None"
    let v93 : (string -> US2) = method4()
    let v94 : US2 option = v88 |> Option.map v93 
    let v114 : US2 = US2_1
    let v115 : US2 = v94 |> Option.defaultValue v114 
    let v122 : string =
        match v115 with
        | US2_1 -> (* None *)
            let v120 : string = ""
            v120
        | US2_0(v119) -> (* Some *)
            v119
    let _run_target_args'_v2 = v122 
    #endif
    let v123 : string = _run_target_args'_v2 
    v123
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
            let v77 : Mut0 = {l0 = v5} : Mut0
            while method9(v3, v77) do
                let v79 : float = v77.l0
                yield v79 
                let v80 : float = v77.l0
                let v81 : float = v80 + 0.6
                v77.l0 <- v81
                ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v147 : float seq = _let'_v9 
    let v151 : float seq = method10(v147)
    let v152 : (float -> (float -> US3 list)) = method11(v0, v1, v2, v3, v4)
    let v153 : (US3 -> struct (int32 * float * char) option) = method13()
    let v157 : unit = ()
    let _let'_v157 =
        seq {
            for cube_x in v151 do
            for cube_y in v151 do
            let x = v152 cube_x cube_y |> Seq.choose v153 
            yield! x
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v160 : struct (int32 * float * char) seq = _let'_v157 
    v160
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
            let struct (v1131 : float, v1132 : float, v1133 : float) = method7(v2, v3, v4)
            let v1134 : struct (float * float) list = []
            let v1136 : struct (float * float) list = struct (5.0, 40.0) :: v1134 
            let v1140 : struct (float * float) list = struct (10.0, 10.0) :: v1136 
            let v1144 : struct (float * float) list = struct (20.0, -40.0) :: v1140 
            let v1148 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v1131, v1132, v1133)
            let v1149 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v1148 
            let v1150 : struct (int32 * float * char) seq = v1149 v1144
            let v1155 : US4 = US4_1
            let v1156 : (US4 []) = Array.create (160 * 44) v1155 
            let v1160 : (int32 -> (struct (float * char) -> unit)) = closure6(v1156)
            let v1161 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v1160 idx (ooz, ch))
            v1161 v1150
            let v1162 : string = method14()
            let v1164 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v1165 : System.Text.StringBuilder = v1164 v1162
            let v1168 : (int32 -> unit) = closure8(v1156, v1165)
            for row in 0 .. (44 - 1) do v1168 row
            let v1170 : (System.Text.StringBuilder -> string) = _.ToString()
            let v1171 : string = v1170 v1165
            let v1174 : bool = v0 < 0
            if v1174 then
                (* run_target_args'
                let v1175 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1176 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1176 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1177 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1177 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1178 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v1178 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1179 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v1179 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1180 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v1180 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v1182 : unit = ()
            let v1183 : (unit -> unit) = closure10(v1171)
            let v1184 : unit = (fun () -> v1183 (); v1182) ()
            (* run_target_args'
            let v1190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1191 : (int32 -> Async<unit>) = Async.Sleep
            let v1192 : Async<unit> = v1191 1
            let _run_target_args'_v1190 = v1192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1193 : (int32 -> Async<unit>) = Async.Sleep
            let v1194 : Async<unit> = v1193 1
            let _run_target_args'_v1190 = v1194 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1195 : (int32 -> Async<unit>) = Async.Sleep
            let v1196 : Async<unit> = v1195 1
            let _run_target_args'_v1190 = v1196 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1197 : (int32 -> Async<unit>) = Async.Sleep
            let v1198 : Async<unit> = v1197 1
            let _run_target_args'_v1190 = v1198 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1199 : (int32 -> Async<unit>) = Async.Sleep
            let v1200 : Async<unit> = v1199 1
            let _run_target_args'_v1190 = v1200 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1201 : (int32 -> Async<unit>) = Async.Sleep
            let v1202 : Async<unit> = v1201 1
            let _run_target_args'_v1190 = v1202 
            #endif
#else
            let v1203 : (int32 -> Async<unit>) = Async.Sleep
            let v1204 : Async<unit> = v1203 1
            let _run_target_args'_v1190 = v1204 
            #endif
            let v1205 : Async<unit> = _run_target_args'_v1190 
            do! v1205 
            let v1208 : bool = v0 > 0
            let v1210 : bool =
                if v1208 then
                    let v1209 : bool = v1 >= v0
                    v1209
                else
                    false
            if v1210 then
                ()
            else
                let v1211 : float = v1131 + 0.05
                let v1212 : float = v1132 + 0.05
                let v1213 : float = v1133 + 0.01
                let v1214 : int32 = v1 + 1
                let v1215 : Async<unit> = method5(v0, v1214, v1211, v1212, v1213)
                return! v1215 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2321 : Async<unit> = _let'_v23 
    let _run_target_args'_v9 = v2321 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2323 : unit = ()
    let _let'_v2323 =
        async {
            let struct (v3431 : float, v3432 : float, v3433 : float) = method7(v2, v3, v4)
            let v3434 : struct (float * float) list = []
            let v3436 : struct (float * float) list = struct (5.0, 40.0) :: v3434 
            let v3440 : struct (float * float) list = struct (10.0, 10.0) :: v3436 
            let v3444 : struct (float * float) list = struct (20.0, -40.0) :: v3440 
            let v3448 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v3431, v3432, v3433)
            let v3449 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v3448 
            let v3450 : struct (int32 * float * char) seq = v3449 v3444
            let v3455 : US4 = US4_1
            let v3456 : (US4 []) = Array.create (160 * 44) v3455 
            let v3460 : (int32 -> (struct (float * char) -> unit)) = closure6(v3456)
            let v3461 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v3460 idx (ooz, ch))
            v3461 v3450
            let v3462 : string = method14()
            let v3464 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v3465 : System.Text.StringBuilder = v3464 v3462
            let v3468 : (int32 -> unit) = closure8(v3456, v3465)
            for row in 0 .. (44 - 1) do v3468 row
            let v3470 : (System.Text.StringBuilder -> string) = _.ToString()
            let v3471 : string = v3470 v3465
            let v3474 : bool = v0 < 0
            if v3474 then
                (* run_target_args'
                let v3475 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3476 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v3476 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3477 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v3477 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3478 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v3478 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3479 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v3479 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3480 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v3480 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v3482 : unit = ()
            let v3483 : (unit -> unit) = closure10(v3471)
            let v3484 : unit = (fun () -> v3483 (); v3482) ()
            (* run_target_args'
            let v3490 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3491 : (int32 -> Async<unit>) = Async.Sleep
            let v3492 : Async<unit> = v3491 1
            let _run_target_args'_v3490 = v3492 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3493 : (int32 -> Async<unit>) = Async.Sleep
            let v3494 : Async<unit> = v3493 1
            let _run_target_args'_v3490 = v3494 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3495 : (int32 -> Async<unit>) = Async.Sleep
            let v3496 : Async<unit> = v3495 1
            let _run_target_args'_v3490 = v3496 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3497 : (int32 -> Async<unit>) = Async.Sleep
            let v3498 : Async<unit> = v3497 1
            let _run_target_args'_v3490 = v3498 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3499 : (int32 -> Async<unit>) = Async.Sleep
            let v3500 : Async<unit> = v3499 1
            let _run_target_args'_v3490 = v3500 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3501 : (int32 -> Async<unit>) = Async.Sleep
            let v3502 : Async<unit> = v3501 1
            let _run_target_args'_v3490 = v3502 
            #endif
#else
            let v3503 : (int32 -> Async<unit>) = Async.Sleep
            let v3504 : Async<unit> = v3503 1
            let _run_target_args'_v3490 = v3504 
            #endif
            let v3505 : Async<unit> = _run_target_args'_v3490 
            do! v3505 
            let v3508 : bool = v0 > 0
            let v3510 : bool =
                if v3508 then
                    let v3509 : bool = v1 >= v0
                    v3509
                else
                    false
            if v3510 then
                ()
            else
                let v3511 : float = v3431 + 0.05
                let v3512 : float = v3432 + 0.05
                let v3513 : float = v3433 + 0.01
                let v3514 : int32 = v1 + 1
                let v3515 : Async<unit> = method5(v0, v3514, v3511, v3512, v3513)
                return! v3515 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4621 : Async<unit> = _let'_v2323 
    let _run_target_args'_v9 = v4621 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4623 : unit = ()
    let _let'_v4623 =
        async {
            let struct (v5731 : float, v5732 : float, v5733 : float) = method7(v2, v3, v4)
            let v5734 : struct (float * float) list = []
            let v5736 : struct (float * float) list = struct (5.0, 40.0) :: v5734 
            let v5740 : struct (float * float) list = struct (10.0, 10.0) :: v5736 
            let v5744 : struct (float * float) list = struct (20.0, -40.0) :: v5740 
            let v5748 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v5731, v5732, v5733)
            let v5749 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v5748 
            let v5750 : struct (int32 * float * char) seq = v5749 v5744
            let v5755 : US4 = US4_1
            let v5756 : (US4 []) = Array.create (160 * 44) v5755 
            let v5760 : (int32 -> (struct (float * char) -> unit)) = closure6(v5756)
            let v5761 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v5760 idx (ooz, ch))
            v5761 v5750
            let v5762 : string = method14()
            let v5764 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v5765 : System.Text.StringBuilder = v5764 v5762
            let v5768 : (int32 -> unit) = closure8(v5756, v5765)
            for row in 0 .. (44 - 1) do v5768 row
            let v5770 : (System.Text.StringBuilder -> string) = _.ToString()
            let v5771 : string = v5770 v5765
            let v5774 : bool = v0 < 0
            if v5774 then
                (* run_target_args'
                let v5775 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v5776 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v5776 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v5777 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v5777 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v5778 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v5778 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v5779 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v5779 
                #endif
#if FABLE_COMPILER_PYTHON
                let v5780 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v5780 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v5782 : unit = ()
            let v5783 : (unit -> unit) = closure10(v5771)
            let v5784 : unit = (fun () -> v5783 (); v5782) ()
            (* run_target_args'
            let v5790 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5791 : (int32 -> Async<unit>) = Async.Sleep
            let v5792 : Async<unit> = v5791 1
            let _run_target_args'_v5790 = v5792 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5793 : (int32 -> Async<unit>) = Async.Sleep
            let v5794 : Async<unit> = v5793 1
            let _run_target_args'_v5790 = v5794 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5795 : (int32 -> Async<unit>) = Async.Sleep
            let v5796 : Async<unit> = v5795 1
            let _run_target_args'_v5790 = v5796 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5797 : (int32 -> Async<unit>) = Async.Sleep
            let v5798 : Async<unit> = v5797 1
            let _run_target_args'_v5790 = v5798 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5799 : (int32 -> Async<unit>) = Async.Sleep
            let v5800 : Async<unit> = v5799 1
            let _run_target_args'_v5790 = v5800 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5801 : (int32 -> Async<unit>) = Async.Sleep
            let v5802 : Async<unit> = v5801 1
            let _run_target_args'_v5790 = v5802 
            #endif
#else
            let v5803 : (int32 -> Async<unit>) = Async.Sleep
            let v5804 : Async<unit> = v5803 1
            let _run_target_args'_v5790 = v5804 
            #endif
            let v5805 : Async<unit> = _run_target_args'_v5790 
            do! v5805 
            let v5808 : bool = v0 > 0
            let v5810 : bool =
                if v5808 then
                    let v5809 : bool = v1 >= v0
                    v5809
                else
                    false
            if v5810 then
                ()
            else
                let v5811 : float = v5731 + 0.05
                let v5812 : float = v5732 + 0.05
                let v5813 : float = v5733 + 0.01
                let v5814 : int32 = v1 + 1
                let v5815 : Async<unit> = method5(v0, v5814, v5811, v5812, v5813)
                return! v5815 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v6921 : Async<unit> = _let'_v4623 
    let _run_target_args'_v9 = v6921 
    #endif
#else
    let v6923 : unit = ()
    let _let'_v6923 =
        async {
            let struct (v8031 : float, v8032 : float, v8033 : float) = method7(v2, v3, v4)
            let v8034 : struct (float * float) list = []
            let v8036 : struct (float * float) list = struct (5.0, 40.0) :: v8034 
            let v8040 : struct (float * float) list = struct (10.0, 10.0) :: v8036 
            let v8044 : struct (float * float) list = struct (20.0, -40.0) :: v8040 
            let v8048 : (struct (float * float) -> struct (int32 * float * char) seq) = method8(v8031, v8032, v8033)
            let v8049 : (struct (float * float) list -> struct (int32 * float * char) seq) = Seq.collect v8048 
            let v8050 : struct (int32 * float * char) seq = v8049 v8044
            let v8055 : US4 = US4_1
            let v8056 : (US4 []) = Array.create (160 * 44) v8055 
            let v8060 : (int32 -> (struct (float * char) -> unit)) = closure6(v8056)
            let v8061 : (struct (int32 * float * char) seq -> unit) = Seq.iter (fun (struct (idx, ooz, ch)) -> v8060 idx (ooz, ch))
            v8061 v8050
            let v8062 : string = method14()
            let v8064 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
            let v8065 : System.Text.StringBuilder = v8064 v8062
            let v8068 : (int32 -> unit) = closure8(v8056, v8065)
            for row in 0 .. (44 - 1) do v8068 row
            let v8070 : (System.Text.StringBuilder -> string) = _.ToString()
            let v8071 : string = v8070 v8065
            let v8074 : bool = v0 < 0
            if v8074 then
                (* run_target_args'
                let v8075 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v8076 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v8076 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v8077 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v8077 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v8078 : string = $"print!(\"\\x1B[1;1H\")"
                Fable.Core.RustInterop.emitRustExpr () v8078 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v8079 : string = $"process.stdout.write('\\u001B[1;1H')"
                Fable.Core.JsInterop.emitJsExpr () v8079 
                #endif
#if FABLE_COMPILER_PYTHON
                let v8080 : string = $"sys.stdout.write(\"\\033[1;1H\")"
                Fable.Core.PyInterop.emitPyExpr () v8080 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                System.Console.SetCursorPosition (0, 0)
                #endif
                // run_target_args' is_unit
                ()
            let v8082 : unit = ()
            let v8083 : (unit -> unit) = closure10(v8071)
            let v8084 : unit = (fun () -> v8083 (); v8082) ()
            (* run_target_args'
            let v8090 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v8091 : (int32 -> Async<unit>) = Async.Sleep
            let v8092 : Async<unit> = v8091 1
            let _run_target_args'_v8090 = v8092 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v8093 : (int32 -> Async<unit>) = Async.Sleep
            let v8094 : Async<unit> = v8093 1
            let _run_target_args'_v8090 = v8094 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v8095 : (int32 -> Async<unit>) = Async.Sleep
            let v8096 : Async<unit> = v8095 1
            let _run_target_args'_v8090 = v8096 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v8097 : (int32 -> Async<unit>) = Async.Sleep
            let v8098 : Async<unit> = v8097 1
            let _run_target_args'_v8090 = v8098 
            #endif
#if FABLE_COMPILER_PYTHON
            let v8099 : (int32 -> Async<unit>) = Async.Sleep
            let v8100 : Async<unit> = v8099 1
            let _run_target_args'_v8090 = v8100 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8101 : (int32 -> Async<unit>) = Async.Sleep
            let v8102 : Async<unit> = v8101 1
            let _run_target_args'_v8090 = v8102 
            #endif
#else
            let v8103 : (int32 -> Async<unit>) = Async.Sleep
            let v8104 : Async<unit> = v8103 1
            let _run_target_args'_v8090 = v8104 
            #endif
            let v8105 : Async<unit> = _run_target_args'_v8090 
            do! v8105 
            let v8108 : bool = v0 > 0
            let v8110 : bool =
                if v8108 then
                    let v8109 : bool = v1 >= v0
                    v8109
                else
                    false
            if v8110 then
                ()
            else
                let v8111 : float = v8031 + 0.05
                let v8112 : float = v8032 + 0.05
                let v8113 : float = v8033 + 0.01
                let v8114 : int32 = v1 + 1
                let v8115 : Async<unit> = method5(v0, v8114, v8111, v8112, v8113)
                return! v8115 
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v9221 : Async<unit> = _let'_v6923 
    let _run_target_args'_v9 = v9221 
    #endif
    let v9222 : Async<unit> = _run_target_args'_v9 
    v9222
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
