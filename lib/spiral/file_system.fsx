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
    let v15 : string = v14.ToString ()
    let v16 : string = v13.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v17 : System.Guid = System.Guid $"{v16}{v15.[v16.Length..]}"
    let v18 : string = v17.ToString ()
    let v19 : string = System.IO.Path.Combine (v12, v18)
    v19
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v20 : US0 = US0_0
    let v21 : US1 = US1_0(v20)
    let v22 : string = $"create_temp_directory_name target: {v21}"
    let v23 : string = failwith<string> v22
    v23
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v24 : US0 = US0_2
    let v25 : US1 = US1_0(v24)
    let v26 : string = $"create_temp_directory_name target: {v25}"
    let v27 : string = failwith<string> v26
    v27
    #endif
    |> fun x -> result <- Some x
    let v28 : string = result |> Option.get
    v28
let v0 : (unit -> string) = closure0()
let create_temp_directory_name () = v0 ()
()
