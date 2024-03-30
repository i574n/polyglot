type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1 of f1_0 : US0
let rec closure0 () () : string =
    let mutable result = None
    #if FABLE_COMPILER_RUST && !WASM
    let v0 : US0 = US0_1
    let v1 : US1 = US1_1(v0)
    let v2 : string = $"create_temp_directory_name target: {v1}"
    let v3 : string = failwith<string> v2
    v3
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : US0 = US0_2
    let v5 : US1 = US1_1(v4)
    let v6 : string = $"create_temp_directory_name target: {v5}"
    let v7 : string = failwith<string> v6
    v7
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v8 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    let v9 : (unit -> string) = System.IO.Path.GetTempPath
    let v10 : string = v9 ()
    let v11 : string = $"{v8}"
    let v12 : string = System.IO.Path.Combine (v10, v11)
    let v13 : System.DateTime = System.DateTime.Now
    let v14 : System.Guid = System.Guid.NewGuid ()
    let v15 : (System.Guid -> string) = _.ToString()
    let v16 : string = v15 v14
    let v17 : string = v13.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v18 : System.Guid = System.Guid $"{v17}{v16.[v17.Length..]}"
    let v19 : (System.Guid -> string) = _.ToString()
    let v20 : string = v19 v18
    let v21 : string = System.IO.Path.Combine (v12, v20)
    v21
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v22 : US0 = US0_0
    let v23 : US1 = US1_0(v22)
    let v24 : string = $"create_temp_directory_name target: {v23}"
    let v25 : string = failwith<string> v24
    v25
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v26 : US0 = US0_2
    let v27 : US1 = US1_0(v26)
    let v28 : string = $"create_temp_directory_name target: {v27}"
    let v29 : string = failwith<string> v28
    v29
    #endif
    |> fun x -> result <- Some x
    let v30 : string = result |> Option.get
    v30
let v0 : (unit -> string) = closure0()
let create_temp_directory_name () = v0 ()
()
