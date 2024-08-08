#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Cursor<$0>")>]
#endif
type std_io_Cursor<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::BufReader<$0>")>]
#endif
type std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("sha2::Sha256")>]
#endif
type sha2_Sha256 = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
#endif
type std_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
type ICryptoCreateHash = abstract createHash: x: string -> obj
type IHashlibSha256 = abstract sha256: x: unit -> obj
module State = let mutable trace_state = None
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
type IOsEnviron = abstract environ: x: unit -> obj
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
type Mut0 = {mutable l0 : int32}
and [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut1 = {mutable l0 : int64}
and Mut2 = {mutable l0 : (string -> unit)}
and Mut3 = {mutable l0 : bool}
and Mut4 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : string
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : US0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : int64
    | US3_1
and Mut5 = {mutable l0 : string}
let rec method1 () : string =
    let v0 : string = ""
    v0
and method2 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method3 () : string =
    let v0 : string = ""
    v0
and method0 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v3 : (System.Text.Encoding -> (string -> (uint8 []))) = _.GetBytes
    let v4 : (string -> (uint8 [])) = v3 v2
    let v5 : (uint8 []) = v4 v0
    let v6 : string = "$0.to_vec()"
    let v7 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "std::io::Cursor::new(v7)"
    let v9 : std_io_Cursor<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "std::io::BufReader::new(v9)"
    let v11 : std_io_BufReader<std_io_Cursor<Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v10 
    let v12 : string = "true; let mut v11 = v11"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "result"
    let v16 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v15 
    let v17 : string = "true; let mut v16 = v16"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : unativeint = 0 |> unativeint 
    let v22 : string = "[$0; 1024]"
    let v23 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v22 
    let v24 : string = "true; loop { // rust.loop"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "true; let mut v23 = v23"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "std::io::Read::read(&mut v11, &mut v23)"
    let v29 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = "$0.unwrap()"
    let v31 : unativeint = Fable.Core.RustInterop.emitRustExpr v29 v30 
    let v32 : bool = v31 = v19 
    if v32 then
        let v35 : string = "true; break"
        let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
        ()
    let v37 : string = "v23.len()"
    let v38 : unativeint = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : uint8 = v38 |> uint8 
    let v42 : unativeint = v31 |> unativeint 
    let v45 : unativeint = v42 |> unbox<unativeint>
    let v48 : bool = v45 = v38 
    let v55 : Ref<Slice'<uint8>> =
        if v48 then
            let v51 : string = "&v23[v19..]"
            let v52 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v51 
            v52
        else
            let v53 : string = "&v23[$0..$1]"
            let v54 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v19, v42) v53 
            v54
    let v56 : string = "sha2::Digest::update(&mut v16, v55)"
    Fable.Core.RustInterop.emitRustExpr () v56 
    let v57 : string = "true; } // rust.loop"
    let v58 : bool = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : string = "true; } // rust.loop"
    let v60 : bool = Fable.Core.RustInterop.emitRustExpr () v59 
    let v61 : string = "true; } // rust.loop"
    let v62 : bool = Fable.Core.RustInterop.emitRustExpr () v61 
    let v63 : string = "true; { // rust.loop"
    let v64 : bool = Fable.Core.RustInterop.emitRustExpr () v63 
    let v65 : string = "true; { // rust.loop"
    let v66 : bool = Fable.Core.RustInterop.emitRustExpr () v65 
    let v67 : string = "&sha2::Digest::finalize(v16)"
    let v68 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v67 
    let v69 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
    let v70 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v68 v69 
    let v71 : string = "true; let _result : Vec<_> = v70.into_iter().map(|x| { //"
    let v72 : bool = Fable.Core.RustInterop.emitRustExpr () v71 
    let v73 : string = "x"
    let v74 : uint8 = Fable.Core.RustInterop.emitRustExpr () v73 
    let v75 : string = "format!(\"{:02x}\", $0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let v77 : string = "fable_library_rust::String_::fromString($0)"
    let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let v79 : string = "true; $0 }).collect::<Vec<_>>()"
    let v80 : bool = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v81 : string = "_result"
    let v82 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v81 
    let v83 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v84 : (string []) = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : string seq = seq { for i = 0 to v84.Length - 1 do yield v84.[i] }
    let v88 : string = method1()
    let v89 : (string -> (string seq -> string)) = String.concat
    let v90 : (string seq -> string) = v89 v88
    let v91 : string = v90 v85
    let v94 : Result<string, std_io_Error> = Ok v91 
    let v95 : string = "$0.unwrap()"
    let v96 : string = Fable.Core.RustInterop.emitRustExpr v94 v95 
    let _v1 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = null |> unbox<string>
    let _v1 = v97 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : string = null |> unbox<string>
    let _v1 = v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : string = "crypto"
    let v104 : ICryptoCreateHash = Fable.Core.JsInterop.importAll v103 
    let v105 : string = "v104.createHash($0)"
    let v106 : string = "sha256"
    let v107 : obj = Fable.Core.JsInterop.emitJsExpr v106 v105 
    let v108 : string = "$0.update($1, 'utf8')"
    let v109 : obj = Fable.Core.JsInterop.emitJsExpr struct (v107, v0) v108 
    let v110 : string = "$0.digest($1)"
    let v111 : string = "hex"
    let v112 : string = Fable.Core.JsInterop.emitJsExpr struct (v109, v111) v110 
    let _v1 = v112 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : string = "hashlib"
    let v114 : IHashlibSha256 = Fable.Core.PyInterop.importAll v113 
    let v115 : string = "v114.sha256()"
    let v116 : obj = Fable.Core.PyInterop.emitPyExpr () v115 
    let v119 : string = "$0.encode($1)"
    let v120 : string = "utf-8"
    let v121 : string = Fable.Core.PyInterop.emitPyExpr struct (v0, v120) v119 
    let v124 : string = "v116.update($0)"
    Fable.Core.PyInterop.emitPyExpr v121 v124 
    let v125 : string = "v116.hexdigest()"
    let v126 : string = Fable.Core.PyInterop.emitPyExpr () v125 
    let _v1 = v126 
    #endif
#else
    let v129 : (unit -> System.Security.Cryptography.SHA256) = System.Security.Cryptography.SHA256.Create
    let v130 : System.Security.Cryptography.SHA256 = v129 ()
    use v130 = v130 
    let v131 : System.Security.Cryptography.SHA256 = v130 
    let v132 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v133 : (System.Text.Encoding -> (string -> (uint8 []))) = _.GetBytes
    let v134 : (string -> (uint8 [])) = v133 v132
    let v135 : (uint8 []) = v134 v0
    let v136 : ((uint8 []) -> (uint8 [])) = v131.ComputeHash
    let v137 : (uint8 []) = v136 v135
    let v138 : int32 = v137.Length
    let v139 : (string []) = Array.zeroCreate<string> (v138)
    let v140 : Mut0 = {l0 = 0} : Mut0
    while method2(v138, v140) do
        let v142 : int32 = v140.l0
        let v143 : uint8 = v137.[int v142]
        let v144 : (string -> string) = v143.ToString
        let v145 : string = "x2"
        let v146 : string = v144 v145
        v139.[int v142] <- v146
        let v147 : int32 = v142 + 1
        v140.l0 <- v147
        ()
    let v148 : string seq = seq { for i = 0 to v139.Length - 1 do yield v139.[i] }
    let v151 : string = method3()
    let v152 : (string -> (string seq -> string)) = String.concat
    let v153 : (string seq -> string) = v152 v151
    let v154 : string = v153 v148
    let _v1 = v154 
    #endif
    let v157 : string = _v1 
    v157
and closure0 () (v0 : string) : string =
    method0(v0)
and method5 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method7 () : string =
    let v0 : string = ""
    v0
and method6 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::env::var(&*$0)"
    let v3 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "true; let _result = $0.map(|x| { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "x"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "fable_library_rust::String_::fromString($0)"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "true; $0 })"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "_result"
    let v13 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = method7()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "std::env::var(&*$0)"
    let v18 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v17 
    let v19 : string = "true; let _result = $0.map(|x| { //"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "x"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "fable_library_rust::String_::fromString($0)"
    let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "true; $0 })"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "_result"
    let v28 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = method7()
    let v30 : string = "$0.unwrap_or($1)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr struct (v28, v29) v30 
    let _v1 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "std::env::var(&*$0)"
    let v33 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "true; let _result = $0.map(|x| { //"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "x"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "true; $0 })"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "_result"
    let v43 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = method7()
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
    let v64 : US1 option = None
    let _v64 = ref v64 
    match v61 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v65 : string = x
    let v66 : US1 = US1_0(v65)
    v66 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v64.Value <- x
    let v67 : US1 option = _v64.Value 
    let v78 : US1 = US1_1
    let v79 : US1 = v67 |> Option.defaultValue v78 
    let v86 : string =
        match v79 with
        | US1_1 -> (* None *)
            let v84 : string = ""
            v84
        | US1_0(v83) -> (* Some *)
            v83
    let _v1 = v86 
    #endif
#else
    let v87 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v88 : string = v87 v0
    let mutable _v88 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v89 : (string -> string option) = Option.ofObj
    let v90 : string option = v89 v88
    v90 
    #else
    Some v88 
    #endif
    |> fun x -> _v88 <- Some x
    let v91 : string option = match _v88 with Some x -> x | None -> failwith "optionm'.of_obj / _v88=None"
    let v94 : US1 option = None
    let _v94 = ref v94 
    match v91 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v95 : string = x
    let v96 : US1 = US1_0(v95)
    v96 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v94.Value <- x
    let v97 : US1 option = _v94.Value 
    let v108 : US1 = US1_1
    let v109 : US1 = v97 |> Option.defaultValue v108 
    let v116 : string =
        match v109 with
        | US1_1 -> (* None *)
            let v114 : string = ""
            v114
        | US1_0(v113) -> (* Some *)
            v113
    let _v1 = v116 
    #endif
    let v117 : string = _v1 
    v117
and method8 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure2 () (v0 : string) : unit =
    ()
and method4 (v0 : US0) : struct (Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method5()
    let v3 : string = method6(v2)
    let v4 : bool = "Verbose" = v3
    let v8 : US2 =
        if v4 then
            let v5 : US0 = US0_0
            US2_0(v5)
        else
            US2_1
    let v49 : US2 =
        match v8 with
        | US2_1 -> (* None *)
            let v11 : bool = "Debug" = v3
            let v15 : US2 =
                if v11 then
                    let v12 : US0 = US0_1
                    US2_0(v12)
                else
                    US2_1
            match v15 with
            | US2_1 -> (* None *)
                let v18 : bool = "Info" = v3
                let v22 : US2 =
                    if v18 then
                        let v19 : US0 = US0_2
                        US2_0(v19)
                    else
                        US2_1
                match v22 with
                | US2_1 -> (* None *)
                    let v25 : bool = "Warning" = v3
                    let v29 : US2 =
                        if v25 then
                            let v26 : US0 = US0_3
                            US2_0(v26)
                        else
                            US2_1
                    match v29 with
                    | US2_1 -> (* None *)
                        let v32 : bool = "Critical" = v3
                        let v36 : US2 =
                            if v32 then
                                let v33 : US0 = US0_4
                                US2_0(v33)
                            else
                                US2_1
                        match v36 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v37) -> (* Some *)
                            US2_0(v37)
                    | US2_0(v30) -> (* Some *)
                        US2_0(v30)
                | US2_0(v23) -> (* Some *)
                    US2_0(v23)
            | US2_0(v16) -> (* Some *)
                US2_0(v16)
        | US2_0(v9) -> (* Some *)
            US2_0(v9)
    let v50 : string = method8()
    let v51 : string = method6(v50)
    let v52 : bool = v51 = "True"
    let v62 : US3 =
        if v52 then
            let v53 : System.DateTime = System.DateTime.Now
            let v56 : (System.DateTime -> int64) = _.Ticks
            let v57 : int64 = v56 v53
            US3_0(v57)
        else
            US3_1
    let _v1 = struct (v49, v62) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : US2 = US2_1
    let v64 : US3 = US3_1
    let _v1 = struct (v63, v64) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "AUTOMATION"
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "env!(\"" + v65 + "\")"
    let v68 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v67 
    let v69 : string = "String::from($0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v69 
    let v71 : string = "fable_library_rust::String_::fromString($0)"
    let v72 : string = Fable.Core.RustInterop.emitRustExpr v70 v71 
    let _v66 = v72 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v73 : string = "env!(\"" + v65 + "\")"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v73 
    let v75 : string = "String::from($0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let v77 : string = "fable_library_rust::String_::fromString($0)"
    let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let _v66 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "env!(\"" + v65 + "\")"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v79 
    let v81 : string = "String::from($0)"
    let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let v83 : string = "fable_library_rust::String_::fromString($0)"
    let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let _v66 = v84 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : string = null |> unbox<string>
    let _v66 = v85 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : string = null |> unbox<string>
    let _v66 = v88 
    #endif
#else
    let v91 : string = null |> unbox<string>
    let _v66 = v91 
    #endif
    let v94 : string = _v66 
    let v99 : string = "True"
    let v100 : bool = v94 <> v99 
    let v109 : US3 =
        if v100 then
            US3_1
        else
            let v104 : string = $"near_sdk::env::block_timestamp()"
            let v105 : uint64 = Fable.Core.RustInterop.emitRustExpr () v104 
            let v106 : (uint64 -> int64) = int64
            let v107 : int64 = v106 v105
            US3_0(v107)
    let v110 : US2 = US2_1
    let _v1 = struct (v110, v109) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v111 : string = method5()
    let v112 : string = method6(v111)
    let v113 : bool = "Verbose" = v112
    let v117 : US2 =
        if v113 then
            let v114 : US0 = US0_0
            US2_0(v114)
        else
            US2_1
    let v158 : US2 =
        match v117 with
        | US2_1 -> (* None *)
            let v120 : bool = "Debug" = v112
            let v124 : US2 =
                if v120 then
                    let v121 : US0 = US0_1
                    US2_0(v121)
                else
                    US2_1
            match v124 with
            | US2_1 -> (* None *)
                let v127 : bool = "Info" = v112
                let v131 : US2 =
                    if v127 then
                        let v128 : US0 = US0_2
                        US2_0(v128)
                    else
                        US2_1
                match v131 with
                | US2_1 -> (* None *)
                    let v134 : bool = "Warning" = v112
                    let v138 : US2 =
                        if v134 then
                            let v135 : US0 = US0_3
                            US2_0(v135)
                        else
                            US2_1
                    match v138 with
                    | US2_1 -> (* None *)
                        let v141 : bool = "Critical" = v112
                        let v145 : US2 =
                            if v141 then
                                let v142 : US0 = US0_4
                                US2_0(v142)
                            else
                                US2_1
                        match v145 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v146) -> (* Some *)
                            US2_0(v146)
                    | US2_0(v139) -> (* Some *)
                        US2_0(v139)
                | US2_0(v132) -> (* Some *)
                    US2_0(v132)
            | US2_0(v125) -> (* Some *)
                US2_0(v125)
        | US2_0(v118) -> (* Some *)
            US2_0(v118)
    let v159 : string = method8()
    let v160 : string = method6(v159)
    let v161 : bool = v160 = "True"
    let v171 : US3 =
        if v161 then
            let v162 : System.DateTime = System.DateTime.Now
            let v165 : (System.DateTime -> int64) = _.Ticks
            let v166 : int64 = v165 v162
            US3_0(v166)
        else
            US3_1
    let _v1 = struct (v158, v171) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v172 : string = method5()
    let v173 : string = method6(v172)
    let v174 : bool = "Verbose" = v173
    let v178 : US2 =
        if v174 then
            let v175 : US0 = US0_0
            US2_0(v175)
        else
            US2_1
    let v219 : US2 =
        match v178 with
        | US2_1 -> (* None *)
            let v181 : bool = "Debug" = v173
            let v185 : US2 =
                if v181 then
                    let v182 : US0 = US0_1
                    US2_0(v182)
                else
                    US2_1
            match v185 with
            | US2_1 -> (* None *)
                let v188 : bool = "Info" = v173
                let v192 : US2 =
                    if v188 then
                        let v189 : US0 = US0_2
                        US2_0(v189)
                    else
                        US2_1
                match v192 with
                | US2_1 -> (* None *)
                    let v195 : bool = "Warning" = v173
                    let v199 : US2 =
                        if v195 then
                            let v196 : US0 = US0_3
                            US2_0(v196)
                        else
                            US2_1
                    match v199 with
                    | US2_1 -> (* None *)
                        let v202 : bool = "Critical" = v173
                        let v206 : US2 =
                            if v202 then
                                let v203 : US0 = US0_4
                                US2_0(v203)
                            else
                                US2_1
                        match v206 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v207) -> (* Some *)
                            US2_0(v207)
                    | US2_0(v200) -> (* Some *)
                        US2_0(v200)
                | US2_0(v193) -> (* Some *)
                    US2_0(v193)
            | US2_0(v186) -> (* Some *)
                US2_0(v186)
        | US2_0(v179) -> (* Some *)
            US2_0(v179)
    let v220 : string = method8()
    let v221 : string = method6(v220)
    let v222 : bool = v221 = "True"
    let v232 : US3 =
        if v222 then
            let v223 : System.DateTime = System.DateTime.Now
            let v226 : (System.DateTime -> int64) = _.Ticks
            let v227 : int64 = v226 v223
            US3_0(v227)
        else
            US3_1
    let _v1 = struct (v219, v232) 
    #endif
#else
    let v233 : string = method5()
    let v234 : string = method6(v233)
    let v235 : bool = "Verbose" = v234
    let v239 : US2 =
        if v235 then
            let v236 : US0 = US0_0
            US2_0(v236)
        else
            US2_1
    let v280 : US2 =
        match v239 with
        | US2_1 -> (* None *)
            let v242 : bool = "Debug" = v234
            let v246 : US2 =
                if v242 then
                    let v243 : US0 = US0_1
                    US2_0(v243)
                else
                    US2_1
            match v246 with
            | US2_1 -> (* None *)
                let v249 : bool = "Info" = v234
                let v253 : US2 =
                    if v249 then
                        let v250 : US0 = US0_2
                        US2_0(v250)
                    else
                        US2_1
                match v253 with
                | US2_1 -> (* None *)
                    let v256 : bool = "Warning" = v234
                    let v260 : US2 =
                        if v256 then
                            let v257 : US0 = US0_3
                            US2_0(v257)
                        else
                            US2_1
                    match v260 with
                    | US2_1 -> (* None *)
                        let v263 : bool = "Critical" = v234
                        let v267 : US2 =
                            if v263 then
                                let v264 : US0 = US0_4
                                US2_0(v264)
                            else
                                US2_1
                        match v267 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v268) -> (* Some *)
                            US2_0(v268)
                    | US2_0(v261) -> (* Some *)
                        US2_0(v261)
                | US2_0(v254) -> (* Some *)
                    US2_0(v254)
            | US2_0(v247) -> (* Some *)
                US2_0(v247)
        | US2_0(v240) -> (* Some *)
            US2_0(v240)
    let v281 : string = method8()
    let v282 : string = method6(v281)
    let v283 : bool = v282 = "True"
    let v293 : US3 =
        if v283 then
            let v284 : System.DateTime = System.DateTime.Now
            let v287 : (System.DateTime -> int64) = _.Ticks
            let v288 : int64 = v287 v284
            US3_0(v288)
        else
            US3_1
    let _v1 = struct (v280, v293) 
    #endif
    let struct (v294 : US2, v295 : US3) = _v1 
    let v359 : Mut3 = {l0 = true} : Mut3
    let v360 : Mut1 = {l0 = 0L} : Mut1
    let v363 : US0 =
        match v294 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v361) -> (* Some *)
            v361
    let v364 : Mut4 = {l0 = v363} : Mut4
    let v365 : (string -> unit) = closure2()
    let v366 : Mut2 = {l0 = v365} : Mut2
    let v373 : int64 option =
        match v295 with
        | US3_1 -> (* None *)
            let v371 : int64 option = None
            v371
        | US3_0(v367) -> (* Some *)
            let v368 : int64 option = Some v367 
            v368
    struct (v360, v366, v359, v364, v373)
and method9 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method10 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method11 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method12 () : string =
    let v0 : string = ""
    v0
and closure3 () () : string =
    let v0 : string = "crypto.hash_to_port"
    v0
and closure1 () (v0 : string) : uint16 =
    let v1 : char = v0.[int 0]
    let v2 : (char -> int32) = int32
    let v3 : int32 = v2 v1
    let v4 : string = v0.[int 0..int 7]
    let v5 : int32 = System.Convert.ToInt32 (v4, 16)
    let v6 : int32 = v5 + v3
    let v7 : (int32 -> uint16) = uint16
    let v8 : uint16 = v7 v6
    let v9 : bool = State.trace_state.IsNone
    if v9 then
        let v10 : US0 = US0_0
        let struct (v11 : Mut1, v12 : Mut2, v13 : Mut3, v14 : Mut4, v15 : int64 option) = method4(v10)
        let v16 : struct (Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v11, v12, v13, v14, v15) 
        State.trace_state <- v16 
        ()
    let struct (v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = State.trace_state.Value
    let v36 : bool = State.trace_state.IsNone
    if v36 then
        let v37 : US0 = US0_0
        let struct (v38 : Mut1, v39 : Mut2, v40 : Mut3, v41 : Mut4, v42 : int64 option) = method4(v37)
        let v43 : struct (Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v38, v39, v40, v41, v42) 
        State.trace_state <- v43 
        ()
    let struct (v48 : Mut1, v49 : Mut2, v50 : Mut3, v51 : Mut4, v52 : int64 option) = State.trace_state.Value
    let v63 : US0 = v51.l0
    let v64 : bool = v50.l0
    let v65 : bool = v64 = false
    let v68 : bool =
        if v65 then
            false
        else
            let v66 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v63
            let v67 : bool = 0 >= v66
            v67
    if v68 then
        let v69 : int64 = v21.l0
        let v70 : int64 = v69 + 1L
        v21.l0 <- v70
        let v71 : bool = State.trace_state.IsNone
        if v71 then
            let v72 : US0 = US0_0
            let struct (v73 : Mut1, v74 : Mut2, v75 : Mut3, v76 : Mut4, v77 : int64 option) = method4(v72)
            let v78 : struct (Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v73, v74, v75, v76, v77) 
            State.trace_state <- v78 
            ()
        let struct (v83 : Mut1, v84 : Mut2, v85 : Mut3, v86 : Mut4, v87 : int64 option) = State.trace_state.Value
        let v98 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v99 : US3 option = None
        let _v99 = ref v99 
        match v87 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v100 : int64 = x
        let v101 : US3 = US3_0(v100)
        v101 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v99.Value <- x
        let v102 : US3 option = _v99.Value 
        let v113 : US3 = US3_1
        let v114 : US3 = v102 |> Option.defaultValue v113 
        let v154 : System.DateTime =
            match v114 with
            | US3_1 -> (* None *)
                let v150 : System.DateTime = System.DateTime.Now
                v150
            | US3_0(v118) -> (* Some *)
                let v119 : System.DateTime = System.DateTime.Now
                let v122 : (System.DateTime -> int64) = _.Ticks
                let v123 : int64 = v122 v119
                let v126 : int64 = v123 - v118
                let v127 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v128 : System.TimeSpan = v127 v126
                let v131 : (System.TimeSpan -> int32) = _.Hours
                let v132 : int32 = v131 v128
                let v135 : (System.TimeSpan -> int32) = _.Minutes
                let v136 : int32 = v135 v128
                let v139 : (System.TimeSpan -> int32) = _.Seconds
                let v140 : int32 = v139 v128
                let v143 : (System.TimeSpan -> int32) = _.Milliseconds
                let v144 : int32 = v143 v128
                let v147 : System.DateTime = System.DateTime (1, 1, 1, v132, v136, v140, v144)
                v147
        let v155 : string = method9()
        let v158 : (string -> string) = v154.ToString
        let v159 : string = v158 v155
        let _v98 = v159 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v162 : US3 option = None
        let _v162 = ref v162 
        match v87 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v163 : int64 = x
        let v164 : US3 = US3_0(v163)
        v164 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v162.Value <- x
        let v165 : US3 option = _v162.Value 
        let v176 : US3 = US3_1
        let v177 : US3 = v165 |> Option.defaultValue v176 
        let v217 : System.DateTime =
            match v177 with
            | US3_1 -> (* None *)
                let v213 : System.DateTime = System.DateTime.Now
                v213
            | US3_0(v181) -> (* Some *)
                let v182 : System.DateTime = System.DateTime.Now
                let v185 : (System.DateTime -> int64) = _.Ticks
                let v186 : int64 = v185 v182
                let v189 : int64 = v186 - v181
                let v190 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v191 : System.TimeSpan = v190 v189
                let v194 : (System.TimeSpan -> int32) = _.Hours
                let v195 : int32 = v194 v191
                let v198 : (System.TimeSpan -> int32) = _.Minutes
                let v199 : int32 = v198 v191
                let v202 : (System.TimeSpan -> int32) = _.Seconds
                let v203 : int32 = v202 v191
                let v206 : (System.TimeSpan -> int32) = _.Milliseconds
                let v207 : int32 = v206 v191
                let v210 : System.DateTime = System.DateTime (1, 1, 1, v195, v199, v203, v207)
                v210
        let v218 : string = method9()
        let v221 : (string -> string) = v217.ToString
        let v222 : string = v221 v218
        let _v98 = v222 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v225 : string = $"near_sdk::env::block_timestamp()"
        let v226 : uint64 = Fable.Core.RustInterop.emitRustExpr () v225 
        let v227 : US3 option = None
        let _v227 = ref v227 
        match v87 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v228 : int64 = x
        let v229 : US3 = US3_0(v228)
        v229 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v227.Value <- x
        let v230 : US3 option = _v227.Value 
        let v241 : US3 = US3_1
        let v242 : US3 = v230 |> Option.defaultValue v241 
        let v251 : uint64 =
            match v242 with
            | US3_1 -> (* None *)
                v226
            | US3_0(v246) -> (* Some *)
                let v247 : (int64 -> uint64) = uint64
                let v248 : uint64 = v247 v246
                let v249 : uint64 = v226 - v248
                v249
        let v252 : uint64 = v251 / 1000000000UL
        let v253 : uint64 = v252 % 60UL
        let v254 : uint64 = v252 / 60UL
        let v255 : uint64 = v254 % 60UL
        let v256 : uint64 = v252 / 3600UL
        let v257 : uint64 = v256 % 24UL
        let v258 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v257, v255, v253) v258 
        let v260 : string = "fable_library_rust::String_::fromString($0)"
        let v261 : string = Fable.Core.RustInterop.emitRustExpr v259 v260 
        let _v98 = v261 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v262 : US3 option = None
        let _v262 = ref v262 
        match v87 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v263 : int64 = x
        let v264 : US3 = US3_0(v263)
        v264 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v262.Value <- x
        let v265 : US3 option = _v262.Value 
        let v276 : US3 = US3_1
        let v277 : US3 = v265 |> Option.defaultValue v276 
        let v317 : System.DateTime =
            match v277 with
            | US3_1 -> (* None *)
                let v313 : System.DateTime = System.DateTime.Now
                v313
            | US3_0(v281) -> (* Some *)
                let v282 : System.DateTime = System.DateTime.Now
                let v285 : (System.DateTime -> int64) = _.Ticks
                let v286 : int64 = v285 v282
                let v289 : int64 = v286 - v281
                let v290 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v291 : System.TimeSpan = v290 v289
                let v294 : (System.TimeSpan -> int32) = _.Hours
                let v295 : int32 = v294 v291
                let v298 : (System.TimeSpan -> int32) = _.Minutes
                let v299 : int32 = v298 v291
                let v302 : (System.TimeSpan -> int32) = _.Seconds
                let v303 : int32 = v302 v291
                let v306 : (System.TimeSpan -> int32) = _.Milliseconds
                let v307 : int32 = v306 v291
                let v310 : System.DateTime = System.DateTime (1, 1, 1, v295, v299, v303, v307)
                v310
        let v318 : string = method10()
        let v321 : (string -> string) = v317.ToString
        let v322 : string = v321 v318
        let _v98 = v322 
        #endif
#if FABLE_COMPILER_PYTHON
        let v325 : US3 option = None
        let _v325 = ref v325 
        match v87 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v326 : int64 = x
        let v327 : US3 = US3_0(v326)
        v327 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v325.Value <- x
        let v328 : US3 option = _v325.Value 
        let v339 : US3 = US3_1
        let v340 : US3 = v328 |> Option.defaultValue v339 
        let v380 : System.DateTime =
            match v340 with
            | US3_1 -> (* None *)
                let v376 : System.DateTime = System.DateTime.Now
                v376
            | US3_0(v344) -> (* Some *)
                let v345 : System.DateTime = System.DateTime.Now
                let v348 : (System.DateTime -> int64) = _.Ticks
                let v349 : int64 = v348 v345
                let v352 : int64 = v349 - v344
                let v353 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v354 : System.TimeSpan = v353 v352
                let v357 : (System.TimeSpan -> int32) = _.Hours
                let v358 : int32 = v357 v354
                let v361 : (System.TimeSpan -> int32) = _.Minutes
                let v362 : int32 = v361 v354
                let v365 : (System.TimeSpan -> int32) = _.Seconds
                let v366 : int32 = v365 v354
                let v369 : (System.TimeSpan -> int32) = _.Milliseconds
                let v370 : int32 = v369 v354
                let v373 : System.DateTime = System.DateTime (1, 1, 1, v358, v362, v366, v370)
                v373
        let v381 : string = method10()
        let v384 : (string -> string) = v380.ToString
        let v385 : string = v384 v381
        let _v98 = v385 
        #endif
#else
        let v388 : US3 option = None
        let _v388 = ref v388 
        match v87 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v389 : int64 = x
        let v390 : US3 = US3_0(v389)
        v390 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v388.Value <- x
        let v391 : US3 option = _v388.Value 
        let v402 : US3 = US3_1
        let v403 : US3 = v391 |> Option.defaultValue v402 
        let v443 : System.DateTime =
            match v403 with
            | US3_1 -> (* None *)
                let v439 : System.DateTime = System.DateTime.Now
                v439
            | US3_0(v407) -> (* Some *)
                let v408 : System.DateTime = System.DateTime.Now
                let v411 : (System.DateTime -> int64) = _.Ticks
                let v412 : int64 = v411 v408
                let v415 : int64 = v412 - v407
                let v416 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v417 : System.TimeSpan = v416 v415
                let v420 : (System.TimeSpan -> int32) = _.Hours
                let v421 : int32 = v420 v417
                let v424 : (System.TimeSpan -> int32) = _.Minutes
                let v425 : int32 = v424 v417
                let v428 : (System.TimeSpan -> int32) = _.Seconds
                let v429 : int32 = v428 v417
                let v432 : (System.TimeSpan -> int32) = _.Milliseconds
                let v433 : int32 = v432 v417
                let v436 : System.DateTime = System.DateTime (1, 1, 1, v421, v425, v429, v433)
                v436
        let v444 : string = method10()
        let v447 : (string -> string) = v443.ToString
        let v448 : string = v447 v444
        let _v98 = v448 
        #endif
        let v451 : string = _v98 
        let v516 : string = "Verbose"
        let v517 : (unit -> string) = v516.ToLower
        let v518 : string = v517 ()
        let v521 : string = v518.PadLeft (7, ' ')
        let v535 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v536 : string = "inline_colorization::color_bright_black"
        let v537 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v536 
        let v538 : string = "&*$0"
        let v539 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v521 v538 
        let v540 : string = "inline_colorization::color_reset"
        let v541 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v540 
        let v542 : string = "\"{v537}{v539}{v541}\""
        let v543 : string = @$"format!(" + v542 + ")"
        let v544 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v543 
        let v545 : string = "fable_library_rust::String_::fromString($0)"
        let v546 : string = Fable.Core.RustInterop.emitRustExpr v544 v545 
        let _v535 = v546 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v547 : string = "inline_colorization::color_bright_black"
        let v548 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v547 
        let v549 : string = "&*$0"
        let v550 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v521 v549 
        let v551 : string = "inline_colorization::color_reset"
        let v552 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v551 
        let v553 : string = "\"{v548}{v550}{v552}\""
        let v554 : string = @$"format!(" + v553 + ")"
        let v555 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v554 
        let v556 : string = "fable_library_rust::String_::fromString($0)"
        let v557 : string = Fable.Core.RustInterop.emitRustExpr v555 v556 
        let _v535 = v557 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v558 : string = "inline_colorization::color_bright_black"
        let v559 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v558 
        let v560 : string = "&*$0"
        let v561 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v521 v560 
        let v562 : string = "inline_colorization::color_reset"
        let v563 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v562 
        let v564 : string = "\"{v559}{v561}{v563}\""
        let v565 : string = @$"format!(" + v564 + ")"
        let v566 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v565 
        let v567 : string = "fable_library_rust::String_::fromString($0)"
        let v568 : string = Fable.Core.RustInterop.emitRustExpr v566 v567 
        let _v535 = v568 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v569 : string = "\u001b[90m"
        let v570 : string = method11()
        let v571 : string = v569 + v521 
        let v572 : string = v571 + v570 
        let _v535 = v572 
        #endif
#if FABLE_COMPILER_PYTHON
        let v573 : string = "\u001b[90m"
        let v574 : string = method11()
        let v575 : string = v573 + v521 
        let v576 : string = v575 + v574 
        let _v535 = v576 
        #endif
#else
        let v577 : string = "\u001b[90m"
        let v578 : string = method11()
        let v579 : string = v577 + v521 
        let v580 : string = v579 + v578 
        let _v535 = v580 
        #endif
        let v581 : string = _v535 
        let v587 : int64 = v83.l0
        let v588 : string = method12()
        let v589 : Mut5 = {l0 = v588} : Mut5
        let v590 : string = "{ "
        let v591 : string = $"{v590}"
        let v594 : string = v589.l0
        let v595 : string = v594 + v591 
        v589.l0 <- v595
        let v596 : string = "first_letter_code"
        let v597 : string = $"{v596}"
        let v600 : string = v589.l0
        let v601 : string = v600 + v597 
        v589.l0 <- v601
        let v602 : string = " = "
        let v603 : string = $"{v602}"
        let v606 : string = v589.l0
        let v607 : string = v606 + v603 
        v589.l0 <- v607
        let v608 : string = $"{v3}"
        let v611 : string = v589.l0
        let v612 : string = v611 + v608 
        v589.l0 <- v612
        let v613 : string = "; "
        let v614 : string = $"{v613}"
        let v617 : string = v589.l0
        let v618 : string = v617 + v614 
        v589.l0 <- v618
        let v619 : string = "hash_part"
        let v620 : string = $"{v619}"
        let v623 : string = v589.l0
        let v624 : string = v623 + v620 
        v589.l0 <- v624
        let v625 : string = $"{v602}"
        let v628 : string = v589.l0
        let v629 : string = v628 + v625 
        v589.l0 <- v629
        let v630 : string = $"{v4}"
        let v633 : string = v589.l0
        let v634 : string = v633 + v630 
        v589.l0 <- v634
        let v635 : string = $"{v613}"
        let v638 : string = v589.l0
        let v639 : string = v638 + v635 
        v589.l0 <- v639
        let v640 : string = "combined_value"
        let v641 : string = $"{v640}"
        let v644 : string = v589.l0
        let v645 : string = v644 + v641 
        v589.l0 <- v645
        let v646 : string = $"{v602}"
        let v649 : string = v589.l0
        let v650 : string = v649 + v646 
        v589.l0 <- v650
        let v651 : string = $"{v8}"
        let v654 : string = v589.l0
        let v655 : string = v654 + v651 
        v589.l0 <- v655
        let v656 : string = " }"
        let v657 : string = $"{v656}"
        let v660 : string = v589.l0
        let v661 : string = v660 + v657 
        v589.l0 <- v661
        let v662 : string = v589.l0
        let v663 : (unit -> string) = closure3()
        let v664 : string = $"{v451} {v581} #{v587} %s{v663 ()} / {v662}"
        let v667 : char list = []
        let v668 : (char list -> (char [])) = List.toArray
        let v669 : (char []) = v668 v667
        let v672 : string = v664.TrimStart v669 
        let v690 : char list = []
        let v691 : char list = '/' :: v690 
        let v694 : char list = ' ' :: v691 
        let v697 : (char list -> (char [])) = List.toArray
        let v698 : (char []) = v697 v694
        let v701 : string = v672.TrimEnd v698 
        let v719 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v720 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v701 v720 
        let _v719 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v721 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v701 v721 
        let _v719 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v722 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v701 v722 
        let _v719 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v701 
        let _v719 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v701 
        let _v719 = () 
        #endif
#else
        System.Console.WriteLine v701 
        let _v719 = () 
        #endif
        _v719 
        let v723 : (string -> unit) = v22.l0
        v723 v701
    let v724 : uint16 = v8 % 48128us
    let v725 : uint16 = v724 + 1024us
    v725
let v0 : (string -> string) = closure0()
let hash_text x = v0 x
let v1 : (string -> uint16) = closure1()
let hash_to_port x = v1 x
()
