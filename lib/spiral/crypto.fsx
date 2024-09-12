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
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
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
module TraceState = let mutable trace_state = None
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
and Mut4 = {mutable l0 : string}
and Mut5 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : string
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : US0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : int64
    | US3_1
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
    let v71 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v72 : bool = Fable.Core.RustInterop.emitRustExpr v70 v71 
    let v73 : string = "x"
    let v74 : uint8 = Fable.Core.RustInterop.emitRustExpr () v73 
    let v75 : string = "format!(\"{:02x}\", $0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let v77 : string = "fable_library_rust::String_::fromString($0)"
    let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let v79 : string = "true; $0 }).collect::<Vec<_>>()"
    let v80 : bool = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v81 : string = "_vec_map"
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
and closure4 (v0 : US1 option ref) (v1 : US1 option) : US1 option ref =
    v0.Value <- v1 
    v0
and closure5 (v0 : string option, v1 : (US1 option -> US1 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : string = x
    let v3 : US1 = US1_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and method6 (v0 : string) : string =
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
    let v14 : string = method7()
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
    let v29 : string = method7()
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
    let v65 : US1 option ref = _v64 
    let v66 : (US1 option -> US1 option ref) = closure4(v65)
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure5(v61, v66)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v72 : US1 option = _v64.Value 
    let v83 : US1 = US1_1
    let v84 : US1 = v72 |> Option.defaultValue v83 
    let v91 : string =
        match v84 with
        | US1_1 -> (* None *)
            let v89 : string = ""
            v89
        | US1_0(v88) -> (* Some *)
            v88
    let _v1 = v91 
    #endif
#else
    let v92 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v93 : string = v92 v0
    let mutable _v93 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v94 : (string -> string option) = Option.ofObj
    let v95 : string option = v94 v93
    v95 
    #else
    Some v93 
    #endif
    |> fun x -> _v93 <- Some x
    let v96 : string option = match _v93 with Some x -> x | None -> failwith "optionm'.of_obj / _v93=None"
    let v99 : US1 option = None
    let _v99 = ref v99 
    let v100 : US1 option ref = _v99 
    let v101 : (US1 option -> US1 option ref) = closure4(v100)
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure5(v96, v101)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : US1 option = _v99.Value 
    let v118 : US1 = US1_1
    let v119 : US1 = v107 |> Option.defaultValue v118 
    let v126 : string =
        match v119 with
        | US1_1 -> (* None *)
            let v124 : string = ""
            v124
        | US1_0(v123) -> (* Some *)
            v123
    let _v1 = v126 
    #endif
    let v127 : string = _v1 
    v127
and method8 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure6 () (v0 : string) : unit =
    ()
and method4 (v0 : US0) : struct (Mut1 * Mut2 * Mut3 * Mut4 * Mut5 * int64 option) =
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
    let v359 : Mut1 = {l0 = 0L} : Mut1
    let v360 : (string -> unit) = closure6()
    let v361 : Mut2 = {l0 = v360} : Mut2
    let v362 : Mut3 = {l0 = true} : Mut3
    let v363 : string = ""
    let v364 : Mut4 = {l0 = v363} : Mut4
    let v367 : US0 =
        match v294 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v365) -> (* Some *)
            v365
    let v368 : Mut5 = {l0 = v367} : Mut5
    let v375 : int64 option =
        match v295 with
        | US3_1 -> (* None *)
            let v373 : int64 option = None
            v373
        | US3_0(v369) -> (* Some *)
            let v370 : int64 option = Some v369 
            v370
    struct (v359, v361, v362, v364, v368, v375)
and closure3 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut1, v3 : Mut2, v4 : Mut3, v5 : Mut4, v6 : Mut5, v7 : int64 option) = method4(v1)
        let v8 : struct (Mut1 * Mut2 * Mut3 * Mut4 * Mut5 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and closure7 (v0 : Mut1) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure8 (v0 : US3 option ref) (v1 : US3 option) : US3 option ref =
    v0.Value <- v1 
    v0
and closure9 (v0 : int64 option, v1 : (US3 option -> US3 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : int64 = x
    let v3 : US3 = US3_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
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
and closure10 (v0 : Mut4, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure12 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure11 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure12(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure2 (v0 : int32, v1 : string, v2 : uint16) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure3()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : unit = ()
    let v38 : unit = (fun () -> v4 (); v37) ()
    let struct (v52 : Mut1, v53 : Mut2, v54 : Mut3, v55 : Mut4, v56 : Mut5, v57 : int64 option) = TraceState.trace_state.Value
    let v70 : US0 = v56.l0
    let v71 : bool = v54.l0
    let v72 : bool = v71 = false
    let v75 : bool =
        if v72 then
            false
        else
            let v73 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v70
            let v74 : bool = 0 >= v73
            v74
    if v75 then
        let v76 : unit = ()
        let v77 : (unit -> unit) = closure7(v19)
        let v78 : unit = (fun () -> v77 (); v76) ()
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : Mut5, v101 : int64 option) = TraceState.trace_state.Value
        let v114 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v115 : US3 option = None
        let _v115 = ref v115 
        let v116 : US3 option ref = _v115 
        let v117 : (US3 option -> US3 option ref) = closure8(v116)
        let v118 : unit = ()
        let v119 : (unit -> unit) = closure9(v101, v117)
        let v120 : unit = (fun () -> v119 (); v118) ()
        let v123 : US3 option = _v115.Value 
        let v134 : US3 = US3_1
        let v135 : US3 = v123 |> Option.defaultValue v134 
        let v175 : System.DateTime =
            match v135 with
            | US3_1 -> (* None *)
                let v171 : System.DateTime = System.DateTime.Now
                v171
            | US3_0(v139) -> (* Some *)
                let v140 : System.DateTime = System.DateTime.Now
                let v143 : (System.DateTime -> int64) = _.Ticks
                let v144 : int64 = v143 v140
                let v147 : int64 = v144 - v139
                let v148 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v149 : System.TimeSpan = v148 v147
                let v152 : (System.TimeSpan -> int32) = _.Hours
                let v153 : int32 = v152 v149
                let v156 : (System.TimeSpan -> int32) = _.Minutes
                let v157 : int32 = v156 v149
                let v160 : (System.TimeSpan -> int32) = _.Seconds
                let v161 : int32 = v160 v149
                let v164 : (System.TimeSpan -> int32) = _.Milliseconds
                let v165 : int32 = v164 v149
                let v168 : System.DateTime = System.DateTime (1, 1, 1, v153, v157, v161, v165)
                v168
        let v176 : string = method9()
        let v179 : (string -> string) = v175.ToString
        let v180 : string = v179 v176
        let _v114 = v180 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v183 : US3 option = None
        let _v183 = ref v183 
        let v184 : US3 option ref = _v183 
        let v185 : (US3 option -> US3 option ref) = closure8(v184)
        let v186 : unit = ()
        let v187 : (unit -> unit) = closure9(v101, v185)
        let v188 : unit = (fun () -> v187 (); v186) ()
        let v191 : US3 option = _v183.Value 
        let v202 : US3 = US3_1
        let v203 : US3 = v191 |> Option.defaultValue v202 
        let v243 : System.DateTime =
            match v203 with
            | US3_1 -> (* None *)
                let v239 : System.DateTime = System.DateTime.Now
                v239
            | US3_0(v207) -> (* Some *)
                let v208 : System.DateTime = System.DateTime.Now
                let v211 : (System.DateTime -> int64) = _.Ticks
                let v212 : int64 = v211 v208
                let v215 : int64 = v212 - v207
                let v216 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v217 : System.TimeSpan = v216 v215
                let v220 : (System.TimeSpan -> int32) = _.Hours
                let v221 : int32 = v220 v217
                let v224 : (System.TimeSpan -> int32) = _.Minutes
                let v225 : int32 = v224 v217
                let v228 : (System.TimeSpan -> int32) = _.Seconds
                let v229 : int32 = v228 v217
                let v232 : (System.TimeSpan -> int32) = _.Milliseconds
                let v233 : int32 = v232 v217
                let v236 : System.DateTime = System.DateTime (1, 1, 1, v221, v225, v229, v233)
                v236
        let v244 : string = method9()
        let v247 : (string -> string) = v243.ToString
        let v248 : string = v247 v244
        let _v114 = v248 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v251 : string = $"near_sdk::env::block_timestamp()"
        let v252 : uint64 = Fable.Core.RustInterop.emitRustExpr () v251 
        let v253 : US3 option = None
        let _v253 = ref v253 
        let v254 : US3 option ref = _v253 
        let v255 : (US3 option -> US3 option ref) = closure8(v254)
        let v256 : unit = ()
        let v257 : (unit -> unit) = closure9(v101, v255)
        let v258 : unit = (fun () -> v257 (); v256) ()
        let v261 : US3 option = _v253.Value 
        let v272 : US3 = US3_1
        let v273 : US3 = v261 |> Option.defaultValue v272 
        let v282 : uint64 =
            match v273 with
            | US3_1 -> (* None *)
                v252
            | US3_0(v277) -> (* Some *)
                let v278 : (int64 -> uint64) = uint64
                let v279 : uint64 = v278 v277
                let v280 : uint64 = v252 - v279
                v280
        let v283 : uint64 = v282 / 1000000000UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v283 / 60UL
        let v286 : uint64 = v285 % 60UL
        let v287 : uint64 = v283 / 3600UL
        let v288 : uint64 = v287 % 24UL
        let v289 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v288, v286, v284) v289 
        let v291 : string = "fable_library_rust::String_::fromString($0)"
        let v292 : string = Fable.Core.RustInterop.emitRustExpr v290 v291 
        let _v114 = v292 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v293 : US3 option = None
        let _v293 = ref v293 
        let v294 : US3 option ref = _v293 
        let v295 : (US3 option -> US3 option ref) = closure8(v294)
        let v296 : unit = ()
        let v297 : (unit -> unit) = closure9(v101, v295)
        let v298 : unit = (fun () -> v297 (); v296) ()
        let v301 : US3 option = _v293.Value 
        let v312 : US3 = US3_1
        let v313 : US3 = v301 |> Option.defaultValue v312 
        let v353 : System.DateTime =
            match v313 with
            | US3_1 -> (* None *)
                let v349 : System.DateTime = System.DateTime.Now
                v349
            | US3_0(v317) -> (* Some *)
                let v318 : System.DateTime = System.DateTime.Now
                let v321 : (System.DateTime -> int64) = _.Ticks
                let v322 : int64 = v321 v318
                let v325 : int64 = v322 - v317
                let v326 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v327 : System.TimeSpan = v326 v325
                let v330 : (System.TimeSpan -> int32) = _.Hours
                let v331 : int32 = v330 v327
                let v334 : (System.TimeSpan -> int32) = _.Minutes
                let v335 : int32 = v334 v327
                let v338 : (System.TimeSpan -> int32) = _.Seconds
                let v339 : int32 = v338 v327
                let v342 : (System.TimeSpan -> int32) = _.Milliseconds
                let v343 : int32 = v342 v327
                let v346 : System.DateTime = System.DateTime (1, 1, 1, v331, v335, v339, v343)
                v346
        let v354 : string = method10()
        let v357 : (string -> string) = v353.ToString
        let v358 : string = v357 v354
        let _v114 = v358 
        #endif
#if FABLE_COMPILER_PYTHON
        let v361 : US3 option = None
        let _v361 = ref v361 
        let v362 : US3 option ref = _v361 
        let v363 : (US3 option -> US3 option ref) = closure8(v362)
        let v364 : unit = ()
        let v365 : (unit -> unit) = closure9(v101, v363)
        let v366 : unit = (fun () -> v365 (); v364) ()
        let v369 : US3 option = _v361.Value 
        let v380 : US3 = US3_1
        let v381 : US3 = v369 |> Option.defaultValue v380 
        let v421 : System.DateTime =
            match v381 with
            | US3_1 -> (* None *)
                let v417 : System.DateTime = System.DateTime.Now
                v417
            | US3_0(v385) -> (* Some *)
                let v386 : System.DateTime = System.DateTime.Now
                let v389 : (System.DateTime -> int64) = _.Ticks
                let v390 : int64 = v389 v386
                let v393 : int64 = v390 - v385
                let v394 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v395 : System.TimeSpan = v394 v393
                let v398 : (System.TimeSpan -> int32) = _.Hours
                let v399 : int32 = v398 v395
                let v402 : (System.TimeSpan -> int32) = _.Minutes
                let v403 : int32 = v402 v395
                let v406 : (System.TimeSpan -> int32) = _.Seconds
                let v407 : int32 = v406 v395
                let v410 : (System.TimeSpan -> int32) = _.Milliseconds
                let v411 : int32 = v410 v395
                let v414 : System.DateTime = System.DateTime (1, 1, 1, v399, v403, v407, v411)
                v414
        let v422 : string = method10()
        let v425 : (string -> string) = v421.ToString
        let v426 : string = v425 v422
        let _v114 = v426 
        #endif
#else
        let v429 : US3 option = None
        let _v429 = ref v429 
        let v430 : US3 option ref = _v429 
        let v431 : (US3 option -> US3 option ref) = closure8(v430)
        let v432 : unit = ()
        let v433 : (unit -> unit) = closure9(v101, v431)
        let v434 : unit = (fun () -> v433 (); v432) ()
        let v437 : US3 option = _v429.Value 
        let v448 : US3 = US3_1
        let v449 : US3 = v437 |> Option.defaultValue v448 
        let v489 : System.DateTime =
            match v449 with
            | US3_1 -> (* None *)
                let v485 : System.DateTime = System.DateTime.Now
                v485
            | US3_0(v453) -> (* Some *)
                let v454 : System.DateTime = System.DateTime.Now
                let v457 : (System.DateTime -> int64) = _.Ticks
                let v458 : int64 = v457 v454
                let v461 : int64 = v458 - v453
                let v462 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v463 : System.TimeSpan = v462 v461
                let v466 : (System.TimeSpan -> int32) = _.Hours
                let v467 : int32 = v466 v463
                let v470 : (System.TimeSpan -> int32) = _.Minutes
                let v471 : int32 = v470 v463
                let v474 : (System.TimeSpan -> int32) = _.Seconds
                let v475 : int32 = v474 v463
                let v478 : (System.TimeSpan -> int32) = _.Milliseconds
                let v479 : int32 = v478 v463
                let v482 : System.DateTime = System.DateTime (1, 1, 1, v467, v471, v475, v479)
                v482
        let v490 : string = method10()
        let v493 : (string -> string) = v489.ToString
        let v494 : string = v493 v490
        let _v114 = v494 
        #endif
        let v497 : string = _v114 
        
        
        
        
        
        let v567 : string = "Verbose"
        let v568 : (unit -> string) = v567.ToLower
        let v569 : string = v568 ()
        let v572 : string = v569.PadLeft (7, ' ')
        let v586 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v587 : string = "inline_colorization::color_bright_black"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
        let v589 : string = "&*$0"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v589 
        let v591 : string = "inline_colorization::color_reset"
        let v592 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "\"{v588}{v590}{v592}\""
        let v594 : string = @$"format!(" + v593 + ")"
        let v595 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "fable_library_rust::String_::fromString($0)"
        let v597 : string = Fable.Core.RustInterop.emitRustExpr v595 v596 
        let _v586 = v597 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v598 : string = "inline_colorization::color_bright_black"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "&*$0"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v600 
        let v602 : string = "inline_colorization::color_reset"
        let v603 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "\"{v599}{v601}{v603}\""
        let v605 : string = @$"format!(" + v604 + ")"
        let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v605 
        let v607 : string = "fable_library_rust::String_::fromString($0)"
        let v608 : string = Fable.Core.RustInterop.emitRustExpr v606 v607 
        let _v586 = v608 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v609 : string = "inline_colorization::color_bright_black"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v609 
        let v611 : string = "&*$0"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v611 
        let v613 : string = "inline_colorization::color_reset"
        let v614 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "\"{v610}{v612}{v614}\""
        let v616 : string = @$"format!(" + v615 + ")"
        let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v616 
        let v618 : string = "fable_library_rust::String_::fromString($0)"
        let v619 : string = Fable.Core.RustInterop.emitRustExpr v617 v618 
        let _v586 = v619 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v620 : string = "\u001b[90m"
        let v621 : string = method11()
        let v622 : string = v620 + v572 
        let v623 : string = v622 + v621 
        let _v586 = v623 
        #endif
#if FABLE_COMPILER_PYTHON
        let v624 : string = "\u001b[90m"
        let v625 : string = method11()
        let v626 : string = v624 + v572 
        let v627 : string = v626 + v625 
        let _v586 = v627 
        #endif
#else
        let v628 : string = "\u001b[90m"
        let v629 : string = method11()
        let v630 : string = v628 + v572 
        let v631 : string = v630 + v629 
        let _v586 = v631 
        #endif
        let v632 : string = _v586 
        let v638 : int64 = v96.l0
        let v639 : string = method12()
        let v640 : Mut4 = {l0 = v639} : Mut4
        let v641 : string = "{ "
        let v642 : string = $"{v641}"
        let v645 : unit = ()
        let v646 : (unit -> unit) = closure10(v640, v642)
        let v647 : unit = (fun () -> v646 (); v645) ()
        let v650 : string = "first_letter_code"
        let v651 : string = $"{v650}"
        let v654 : unit = ()
        let v655 : (unit -> unit) = closure10(v640, v651)
        let v656 : unit = (fun () -> v655 (); v654) ()
        let v659 : string = " = "
        let v660 : string = $"{v659}"
        let v663 : unit = ()
        let v664 : (unit -> unit) = closure10(v640, v660)
        let v665 : unit = (fun () -> v664 (); v663) ()
        let v668 : string = $"{v0}"
        let v671 : unit = ()
        let v672 : (unit -> unit) = closure10(v640, v668)
        let v673 : unit = (fun () -> v672 (); v671) ()
        let v676 : string = "; "
        let v677 : string = $"{v676}"
        let v680 : unit = ()
        let v681 : (unit -> unit) = closure10(v640, v677)
        let v682 : unit = (fun () -> v681 (); v680) ()
        let v685 : string = "hash_part"
        let v686 : string = $"{v685}"
        let v689 : unit = ()
        let v690 : (unit -> unit) = closure10(v640, v686)
        let v691 : unit = (fun () -> v690 (); v689) ()
        let v694 : string = $"{v659}"
        let v697 : unit = ()
        let v698 : (unit -> unit) = closure10(v640, v694)
        let v699 : unit = (fun () -> v698 (); v697) ()
        let v702 : string = $"{v1}"
        let v705 : unit = ()
        let v706 : (unit -> unit) = closure10(v640, v702)
        let v707 : unit = (fun () -> v706 (); v705) ()
        let v710 : string = $"{v676}"
        let v713 : unit = ()
        let v714 : (unit -> unit) = closure10(v640, v710)
        let v715 : unit = (fun () -> v714 (); v713) ()
        let v718 : string = "combined_value"
        let v719 : string = $"{v718}"
        let v722 : unit = ()
        let v723 : (unit -> unit) = closure10(v640, v719)
        let v724 : unit = (fun () -> v723 (); v722) ()
        let v727 : string = $"{v659}"
        let v730 : unit = ()
        let v731 : (unit -> unit) = closure10(v640, v727)
        let v732 : unit = (fun () -> v731 (); v730) ()
        let v735 : string = $"{v2}"
        let v738 : unit = ()
        let v739 : (unit -> unit) = closure10(v640, v735)
        let v740 : unit = (fun () -> v739 (); v738) ()
        let v743 : string = " }"
        let v744 : string = $"{v743}"
        let v747 : unit = ()
        let v748 : (unit -> unit) = closure10(v640, v744)
        let v749 : unit = (fun () -> v748 (); v747) ()
        let v752 : string = v640.l0
        let v753 : string = "crypto.hash_to_port"
        let v754 : string = $"{v497} {v632} #{v638} %s{v753} / {v752}"
        let v757 : char list = []
        let v758 : (char list -> (char [])) = List.toArray
        let v759 : (char []) = v758 v757
        let v762 : string = v754.TrimStart v759 
        let v780 : char list = []
        let v781 : char list = '/' :: v780 
        let v784 : char list = ' ' :: v781 
        let v787 : (char list -> (char [])) = List.toArray
        let v788 : (char []) = v787 v784
        let v791 : string = v762.TrimEnd v788 
        let v809 : (string -> unit) = closure11()
        let v810 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v811 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v791 v811 
        let _v810 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v812 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v791 v812 
        let _v810 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v813 : string = v22.l0
        let v814 : bool = v813 = ""
        let v822 : string =
            if v814 then
                v791
            else
                let v815 : bool = v791 = ""
                if v815 then
                    let v816 : string = v22.l0
                    v816
                else
                    let v817 : string = v22.l0
                    let v818 : string = "\n"
                    let v819 : string = v817 + v818 
                    let v820 : string = v819 + v791 
                    v820
        let v823 : string = "&*$0"
        let v824 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v822 v823 
        let v825 : string = $"$0.chars()"
        let v826 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v824 v825 
        let v827 : string = "v826"
        let v828 : _ = Fable.Core.RustInterop.emitRustExpr () v827 
        let v829 : string = "v828.collect::<Vec<_>>()"
        let v830 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v829 
        let v831 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v832 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v830 v831 
        let v833 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v834 : bool = Fable.Core.RustInterop.emitRustExpr v832 v833 
        let v835 : string = "x"
        let v836 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v835 
        let v837 : string = "String::from_iter($0)"
        let v838 : std_string_String = Fable.Core.RustInterop.emitRustExpr v836 v837 
        let v839 : string = "true; $0 }).collect::<Vec<_>>()"
        let v840 : bool = Fable.Core.RustInterop.emitRustExpr v838 v839 
        let v841 : string = "_vec_map"
        let v842 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v841 
        let v843 : string = "$0.len()"
        let v844 : unativeint = Fable.Core.RustInterop.emitRustExpr v842 v843 
        let v845 : (unativeint -> int32) = int32
        let v846 : int32 = v845 v844
        let v847 : string = ""
        let v848 : bool = v791 <> v847 
        let v852 : bool =
            if v848 then
                let v851 : bool = v846 <= 1
                v851
            else
                false
        if v852 then
            v22.l0 <- v822
            ()
        else
            v22.l0 <- v847
            let v853 : string = "true; $0.into_iter().for_each(|x| { //"
            let v854 : bool = Fable.Core.RustInterop.emitRustExpr v842 v853 
            let v855 : string = "x"
            let v856 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v855 
            let v857 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v856 v857 
            let v858 : string = $"true;"
            let v859 : bool = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "true; }}); { //"
            let v861 : bool = Fable.Core.RustInterop.emitRustExpr () v860 
            ()
        let _v810 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v809 v791
        let _v810 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v809 v791
        let _v810 = () 
        #endif
#else
        v809 v791
        let _v810 = () 
        #endif
        _v810 
        let v862 : (string -> unit) = v20.l0
        v862 v791
and closure1 () (v0 : string) : uint16 =
    let v1 : char = v0.[int 0]
    let v2 : (char -> int32) = int32
    let v3 : int32 = v2 v1
    let v4 : string = v0.[int 0..int 7]
    let v5 : int32 = System.Convert.ToInt32 (v4, 16)
    let v6 : int32 = v5 + v3
    let v7 : (int32 -> uint16) = uint16
    let v8 : uint16 = v7 v6
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure2(v3, v4, v8)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v872 : uint16 = v8 % 48128us
    let v873 : uint16 = v872 + 1024us
    v873
let v0 : (string -> string) = closure0()
let hash_text x = v0 x
let v1 : (string -> uint16) = closure1()
let hash_to_port x = v1 x
()
