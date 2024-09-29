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
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
type std_io_Error = class end
#else
type std_io_Error = string
#endif

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
type Str = class end
#else
type Str = string
#endif

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
    let v10 : string = "std::io::BufReader::new($0)"
    let v11 : std_io_BufReader<std_io_Cursor<Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v9 v10 
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
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    let v32 : unativeint = Fable.Core.RustInterop.emitRustExpr v29 v31 
    let _v30 = v32 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = "$0.unwrap()"
    let v34 : unativeint = Fable.Core.RustInterop.emitRustExpr v29 v33 
    let _v30 = v34 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = "$0.unwrap()"
    let v36 : unativeint = Fable.Core.RustInterop.emitRustExpr v29 v35 
    let _v30 = v36 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v37 : unativeint = match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = v37 
    #endif
#if FABLE_COMPILER_PYTHON
    let v38 : unativeint = match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = v38 
    #endif
#else
    let v39 : unativeint = match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v30 = v39 
    #endif
    let v40 : unativeint = _v30 
    let v43 : bool = v40 = v19 
    if v43 then
        let v46 : string = "true; break"
        let v47 : bool = Fable.Core.RustInterop.emitRustExpr () v46 
        ()
    let v48 : string = "v23.len()"
    let v49 : unativeint = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : uint8 = v49 |> uint8 
    let v53 : unativeint = v40 |> unativeint 
    let v56 : unativeint = v53 |> unbox<unativeint>
    let v59 : bool = v56 = v49 
    let v66 : Ref<Slice'<uint8>> =
        if v59 then
            let v62 : string = "&v23[v19..]"
            let v63 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v62 
            v63
        else
            let v64 : string = "&v23[$0..$1]"
            let v65 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v19, v53) v64 
            v65
    let v67 : string = "sha2::Digest::update(&mut v16, v66)"
    Fable.Core.RustInterop.emitRustExpr () v67 
    let v68 : string = "true; } // rust.loop"
    let v69 : bool = Fable.Core.RustInterop.emitRustExpr () v68 
    let v70 : string = "true; } // rust.loop"
    let v71 : bool = Fable.Core.RustInterop.emitRustExpr () v70 
    let v72 : string = "true; } // rust.loop"
    let v73 : bool = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : string = "true; { // rust.loop"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr () v74 
    let v76 : string = "true; { // rust.loop"
    let v77 : bool = Fable.Core.RustInterop.emitRustExpr () v76 
    let v78 : string = "&sha2::Digest::finalize(v16)"
    let v79 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
    let v81 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v83 : bool = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let v84 : string = "x"
    let v85 : uint8 = Fable.Core.RustInterop.emitRustExpr () v84 
    let v86 : string = "format!(\"{:02x}\", $0)"
    let v87 : std_string_String = Fable.Core.RustInterop.emitRustExpr v85 v86 
    let v88 : string = "fable_library_rust::String_::fromString($0)"
    let v89 : string = Fable.Core.RustInterop.emitRustExpr v87 v88 
    let v90 : string = "true; $0 }).collect::<Vec<_>>()"
    let v91 : bool = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let v92 : string = "_vec_map"
    let v93 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v92 
    let v94 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v95 : (string []) = Fable.Core.RustInterop.emitRustExpr v93 v94 
    let v96 : string seq = seq { for i = 0 to v95.Length - 1 do yield v95.[i] }
    let v99 : string = method1()
    let v100 : (string -> (string seq -> string)) = String.concat
    let v101 : (string seq -> string) = v100 v99
    let v102 : string = v101 v96
    let v105 : Result<string, std_io_Error> = Ok v102 
    let v106 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v107 : string = "$0.unwrap()"
    let v108 : string = Fable.Core.RustInterop.emitRustExpr v105 v107 
    let _v106 = v108 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v109 : string = "$0.unwrap()"
    let v110 : string = Fable.Core.RustInterop.emitRustExpr v105 v109 
    let _v106 = v110 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : string = "$0.unwrap()"
    let v112 : string = Fable.Core.RustInterop.emitRustExpr v105 v111 
    let _v106 = v112 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v113 : string = match v105 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v106 = v113 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : string = match v105 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v106 = v114 
    #endif
#else
    let v115 : string = match v105 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v106 = v115 
    #endif
    let v116 : string = _v106 
    let _v1 = v116 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v119 : string = null |> unbox<string>
    let _v1 = v119 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v122 : string = null |> unbox<string>
    let _v1 = v122 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v125 : string = "crypto"
    let v126 : ICryptoCreateHash = Fable.Core.JsInterop.importAll v125 
    let v127 : string = "v126.createHash($0)"
    let v128 : string = "sha256"
    let v129 : obj = Fable.Core.JsInterop.emitJsExpr v128 v127 
    let v130 : string = "$0.update($1, 'utf8')"
    let v131 : obj = Fable.Core.JsInterop.emitJsExpr struct (v129, v0) v130 
    let v132 : string = "$0.digest($1)"
    let v133 : string = "hex"
    let v134 : string = Fable.Core.JsInterop.emitJsExpr struct (v131, v133) v132 
    let _v1 = v134 
    #endif
#if FABLE_COMPILER_PYTHON
    let v135 : string = "hashlib"
    let v136 : IHashlibSha256 = Fable.Core.PyInterop.importAll v135 
    let v137 : string = "v136.sha256()"
    let v138 : obj = Fable.Core.PyInterop.emitPyExpr () v137 
    let v141 : string = "$0.encode($1)"
    let v142 : string = "utf-8"
    let v143 : string = Fable.Core.PyInterop.emitPyExpr struct (v0, v142) v141 
    let v146 : string = "v138.update($0)"
    Fable.Core.PyInterop.emitPyExpr v143 v146 
    let v147 : string = "v138.hexdigest()"
    let v148 : string = Fable.Core.PyInterop.emitPyExpr () v147 
    let _v1 = v148 
    #endif
#else
    let v151 : (unit -> System.Security.Cryptography.SHA256) = System.Security.Cryptography.SHA256.Create
    let v152 : System.Security.Cryptography.SHA256 = v151 ()
    use v152 = v152 
    let v153 : System.Security.Cryptography.SHA256 = v152 
    let v154 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v155 : (System.Text.Encoding -> (string -> (uint8 []))) = _.GetBytes
    let v156 : (string -> (uint8 [])) = v155 v154
    let v157 : (uint8 []) = v156 v0
    let v158 : ((uint8 []) -> (uint8 [])) = v153.ComputeHash
    let v159 : (uint8 []) = v158 v157
    let v160 : int32 = v159.Length
    let v161 : (string []) = Array.zeroCreate<string> (v160)
    let v162 : Mut0 = {l0 = 0} : Mut0
    while method2(v160, v162) do
        let v164 : int32 = v162.l0
        let v165 : uint8 = v159.[int v164]
        let v166 : (string -> string) = v165.ToString
        let v167 : string = "x2"
        let v168 : string = v166 v167
        v161.[int v164] <- v168
        let v169 : int32 = v164 + 1
        v162.l0 <- v169
        ()
    let v170 : string seq = seq { for i = 0 to v161.Length - 1 do yield v161.[i] }
    let v173 : string = method3()
    let v174 : (string -> (string seq -> string)) = String.concat
    let v175 : (string seq -> string) = v174 v173
    let v176 : string = v175 v170
    let _v1 = v176 
    #endif
    let v179 : string = _v1 
    v179
and closure0 () (v0 : string) : string =
    method0(v0)
and method5 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method7 () : string =
    let v0 : string = ""
    v0
and closure4 () (v0 : string) : US1 =
    US1_0(v0)
and method8 () : (string -> US1) =
    closure4()
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
    let v64 : (string -> US1) = method8()
    let v65 : US1 option = v61 |> Option.map v64 
    let v76 : US1 = US1_1
    let v77 : US1 = v65 |> Option.defaultValue v76 
    let v84 : string =
        match v77 with
        | US1_1 -> (* None *)
            let v82 : string = ""
            v82
        | US1_0(v81) -> (* Some *)
            v81
    let _v1 = v84 
    #endif
#else
    let v85 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v86 : string = v85 v0
    let mutable _v86 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v87 : (string -> string option) = Option.ofObj
    let v88 : string option = v87 v86
    v88 
    #else
    Some v86 
    #endif
    |> fun x -> _v86 <- Some x
    let v89 : string option = match _v86 with Some x -> x | None -> failwith "optionm'.of_obj / _v86=None"
    let v92 : (string -> US1) = method8()
    let v93 : US1 option = v89 |> Option.map v92 
    let v104 : US1 = US1_1
    let v105 : US1 = v93 |> Option.defaultValue v104 
    let v112 : string =
        match v105 with
        | US1_1 -> (* None *)
            let v110 : string = ""
            v110
        | US1_0(v109) -> (* Some *)
            v109
    let _v1 = v112 
    #endif
    let v113 : string = _v1 
    v113
and method9 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure5 () (v0 : string) : unit =
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
    let v50 : string = method9()
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
    let v69 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v70 : string = "String::from($0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v70 
    let _v69 = v71 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : string = "String::from($0)"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v72 
    let _v69 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "String::from($0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v74 
    let _v69 = v75 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v76 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v76 
    #endif
#if FABLE_COMPILER_PYTHON
    let v79 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v79 
    #endif
#else
    let v82 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v82 
    #endif
    let v85 : std_string_String = _v69 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v85 v90 
    let _v66 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "env!(\"" + v65 + "\")"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v92 
    let v94 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v95 
    let _v94 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v97 
    let _v94 = v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "String::from($0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v99 
    let _v94 = v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v101 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v101 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v104 
    #endif
#else
    let v107 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v107 
    #endif
    let v110 : std_string_String = _v94 
    let v115 : string = "fable_library_rust::String_::fromString($0)"
    let v116 : string = Fable.Core.RustInterop.emitRustExpr v110 v115 
    let _v66 = v116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v117 : string = "env!(\"" + v65 + "\")"
    let v118 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v117 
    let v119 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v120 : string = "String::from($0)"
    let v121 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v120 
    let _v119 = v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v122 : string = "String::from($0)"
    let v123 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v122 
    let _v119 = v123 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v124 : string = "String::from($0)"
    let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v124 
    let _v119 = v125 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v126 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v126 
    #endif
#if FABLE_COMPILER_PYTHON
    let v129 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v129 
    #endif
#else
    let v132 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v132 
    #endif
    let v135 : std_string_String = _v119 
    let v140 : string = "fable_library_rust::String_::fromString($0)"
    let v141 : string = Fable.Core.RustInterop.emitRustExpr v135 v140 
    let _v66 = v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v142 : string = null |> unbox<string>
    let _v66 = v142 
    #endif
#if FABLE_COMPILER_PYTHON
    let v145 : string = null |> unbox<string>
    let _v66 = v145 
    #endif
#else
    let v148 : string = null |> unbox<string>
    let _v66 = v148 
    #endif
    let v151 : string = _v66 
    let v156 : string = "True"
    let v157 : bool = v151 <> v156 
    let v166 : US3 =
        if v157 then
            US3_1
        else
            let v161 : string = $"near_sdk::env::block_timestamp()"
            let v162 : uint64 = Fable.Core.RustInterop.emitRustExpr () v161 
            let v163 : (uint64 -> int64) = int64
            let v164 : int64 = v163 v162
            US3_0(v164)
    let v167 : US2 = US2_1
    let _v1 = struct (v167, v166) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v168 : string = method5()
    let v169 : string = method6(v168)
    
    
    
    
    
    let v170 : bool = "Verbose" = v169
    let v174 : US2 =
        if v170 then
            let v171 : US0 = US0_0
            US2_0(v171)
        else
            US2_1
    let v215 : US2 =
        match v174 with
        | US2_1 -> (* None *)
            let v177 : bool = "Debug" = v169
            let v181 : US2 =
                if v177 then
                    let v178 : US0 = US0_1
                    US2_0(v178)
                else
                    US2_1
            match v181 with
            | US2_1 -> (* None *)
                let v184 : bool = "Info" = v169
                let v188 : US2 =
                    if v184 then
                        let v185 : US0 = US0_2
                        US2_0(v185)
                    else
                        US2_1
                match v188 with
                | US2_1 -> (* None *)
                    let v191 : bool = "Warning" = v169
                    let v195 : US2 =
                        if v191 then
                            let v192 : US0 = US0_3
                            US2_0(v192)
                        else
                            US2_1
                    match v195 with
                    | US2_1 -> (* None *)
                        let v198 : bool = "Critical" = v169
                        let v202 : US2 =
                            if v198 then
                                let v199 : US0 = US0_4
                                US2_0(v199)
                            else
                                US2_1
                        match v202 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v203) -> (* Some *)
                            US2_0(v203)
                    | US2_0(v196) -> (* Some *)
                        US2_0(v196)
                | US2_0(v189) -> (* Some *)
                    US2_0(v189)
            | US2_0(v182) -> (* Some *)
                US2_0(v182)
        | US2_0(v175) -> (* Some *)
            US2_0(v175)
    let v216 : string = method9()
    let v217 : string = method6(v216)
    let v218 : bool = v217 = "True"
    let v228 : US3 =
        if v218 then
            let v219 : System.DateTime = System.DateTime.Now
            let v222 : (System.DateTime -> int64) = _.Ticks
            let v223 : int64 = v222 v219
            US3_0(v223)
        else
            US3_1
    let _v1 = struct (v215, v228) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v229 : string = method5()
    let v230 : string = method6(v229)
    
    
    
    
    
    let v231 : bool = "Verbose" = v230
    let v235 : US2 =
        if v231 then
            let v232 : US0 = US0_0
            US2_0(v232)
        else
            US2_1
    let v276 : US2 =
        match v235 with
        | US2_1 -> (* None *)
            let v238 : bool = "Debug" = v230
            let v242 : US2 =
                if v238 then
                    let v239 : US0 = US0_1
                    US2_0(v239)
                else
                    US2_1
            match v242 with
            | US2_1 -> (* None *)
                let v245 : bool = "Info" = v230
                let v249 : US2 =
                    if v245 then
                        let v246 : US0 = US0_2
                        US2_0(v246)
                    else
                        US2_1
                match v249 with
                | US2_1 -> (* None *)
                    let v252 : bool = "Warning" = v230
                    let v256 : US2 =
                        if v252 then
                            let v253 : US0 = US0_3
                            US2_0(v253)
                        else
                            US2_1
                    match v256 with
                    | US2_1 -> (* None *)
                        let v259 : bool = "Critical" = v230
                        let v263 : US2 =
                            if v259 then
                                let v260 : US0 = US0_4
                                US2_0(v260)
                            else
                                US2_1
                        match v263 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v264) -> (* Some *)
                            US2_0(v264)
                    | US2_0(v257) -> (* Some *)
                        US2_0(v257)
                | US2_0(v250) -> (* Some *)
                    US2_0(v250)
            | US2_0(v243) -> (* Some *)
                US2_0(v243)
        | US2_0(v236) -> (* Some *)
            US2_0(v236)
    let v277 : string = method9()
    let v278 : string = method6(v277)
    let v279 : bool = v278 = "True"
    let v289 : US3 =
        if v279 then
            let v280 : System.DateTime = System.DateTime.Now
            let v283 : (System.DateTime -> int64) = _.Ticks
            let v284 : int64 = v283 v280
            US3_0(v284)
        else
            US3_1
    let _v1 = struct (v276, v289) 
    #endif
#else
    let v290 : string = method5()
    let v291 : string = method6(v290)
    
    
    
    
    
    let v292 : bool = "Verbose" = v291
    let v296 : US2 =
        if v292 then
            let v293 : US0 = US0_0
            US2_0(v293)
        else
            US2_1
    let v337 : US2 =
        match v296 with
        | US2_1 -> (* None *)
            let v299 : bool = "Debug" = v291
            let v303 : US2 =
                if v299 then
                    let v300 : US0 = US0_1
                    US2_0(v300)
                else
                    US2_1
            match v303 with
            | US2_1 -> (* None *)
                let v306 : bool = "Info" = v291
                let v310 : US2 =
                    if v306 then
                        let v307 : US0 = US0_2
                        US2_0(v307)
                    else
                        US2_1
                match v310 with
                | US2_1 -> (* None *)
                    let v313 : bool = "Warning" = v291
                    let v317 : US2 =
                        if v313 then
                            let v314 : US0 = US0_3
                            US2_0(v314)
                        else
                            US2_1
                    match v317 with
                    | US2_1 -> (* None *)
                        let v320 : bool = "Critical" = v291
                        let v324 : US2 =
                            if v320 then
                                let v321 : US0 = US0_4
                                US2_0(v321)
                            else
                                US2_1
                        match v324 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v325) -> (* Some *)
                            US2_0(v325)
                    | US2_0(v318) -> (* Some *)
                        US2_0(v318)
                | US2_0(v311) -> (* Some *)
                    US2_0(v311)
            | US2_0(v304) -> (* Some *)
                US2_0(v304)
        | US2_0(v297) -> (* Some *)
            US2_0(v297)
    let v338 : string = method9()
    let v339 : string = method6(v338)
    let v340 : bool = v339 = "True"
    let v350 : US3 =
        if v340 then
            let v341 : System.DateTime = System.DateTime.Now
            let v344 : (System.DateTime -> int64) = _.Ticks
            let v345 : int64 = v344 v341
            US3_0(v345)
        else
            US3_1
    let _v1 = struct (v337, v350) 
    #endif
    let struct (v351 : US2, v352 : US3) = _v1 
    let v416 : Mut1 = {l0 = 1L} : Mut1
    let v417 : (string -> unit) = closure5()
    let v418 : Mut2 = {l0 = v417} : Mut2
    let v419 : Mut3 = {l0 = true} : Mut3
    let v420 : string = ""
    let v421 : Mut4 = {l0 = v420} : Mut4
    let v424 : US0 =
        match v351 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v422) -> (* Some *)
            v422
    let v425 : Mut5 = {l0 = v424} : Mut5
    let v432 : int64 option =
        match v352 with
        | US3_1 -> (* None *)
            let v430 : int64 option = None
            v430
        | US3_0(v426) -> (* Some *)
            let v427 : int64 option = Some v426 
            v427
    struct (v416, v418, v419, v421, v425, v432)
and closure3 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut1, v3 : Mut2, v4 : Mut3, v5 : Mut4, v6 : Mut5, v7 : int64 option) = method4(v1)
        let v8 : struct (Mut1 * Mut2 * Mut3 * Mut4 * Mut5 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and closure6 () (v0 : int64) : US3 =
    US3_0(v0)
and method11 () : (int64 -> US3) =
    closure6()
and method12 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method13 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method10 (v0 : Mut1, v1 : Mut2, v2 : Mut3, v3 : Mut4, v4 : Mut5, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US3) = method11()
    let v8 : US3 option = v5 |> Option.map v7 
    let v19 : US3 = US3_1
    let v20 : US3 = v8 |> Option.defaultValue v19 
    let v60 : System.DateTime =
        match v20 with
        | US3_1 -> (* None *)
            let v56 : System.DateTime = System.DateTime.Now
            v56
        | US3_0(v24) -> (* Some *)
            let v25 : System.DateTime = System.DateTime.Now
            let v28 : (System.DateTime -> int64) = _.Ticks
            let v29 : int64 = v28 v25
            let v32 : int64 = v29 - v24
            let v33 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v34 : System.TimeSpan = v33 v32
            let v37 : (System.TimeSpan -> int32) = _.Hours
            let v38 : int32 = v37 v34
            let v41 : (System.TimeSpan -> int32) = _.Minutes
            let v42 : int32 = v41 v34
            let v45 : (System.TimeSpan -> int32) = _.Seconds
            let v46 : int32 = v45 v34
            let v49 : (System.TimeSpan -> int32) = _.Milliseconds
            let v50 : int32 = v49 v34
            let v53 : System.DateTime = System.DateTime (1, 1, 1, v38, v42, v46, v50)
            v53
    let v61 : string = method12()
    let v64 : (string -> string) = v60.ToString
    let v65 : string = v64 v61
    let _v6 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (int64 -> US3) = method11()
    let v69 : US3 option = v5 |> Option.map v68 
    let v80 : US3 = US3_1
    let v81 : US3 = v69 |> Option.defaultValue v80 
    let v121 : System.DateTime =
        match v81 with
        | US3_1 -> (* None *)
            let v117 : System.DateTime = System.DateTime.Now
            v117
        | US3_0(v85) -> (* Some *)
            let v86 : System.DateTime = System.DateTime.Now
            let v89 : (System.DateTime -> int64) = _.Ticks
            let v90 : int64 = v89 v86
            let v93 : int64 = v90 - v85
            let v94 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v95 : System.TimeSpan = v94 v93
            let v98 : (System.TimeSpan -> int32) = _.Hours
            let v99 : int32 = v98 v95
            let v102 : (System.TimeSpan -> int32) = _.Minutes
            let v103 : int32 = v102 v95
            let v106 : (System.TimeSpan -> int32) = _.Seconds
            let v107 : int32 = v106 v95
            let v110 : (System.TimeSpan -> int32) = _.Milliseconds
            let v111 : int32 = v110 v95
            let v114 : System.DateTime = System.DateTime (1, 1, 1, v99, v103, v107, v111)
            v114
    let v122 : string = method12()
    let v125 : (string -> string) = v121.ToString
    let v126 : string = v125 v122
    let _v6 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = $"near_sdk::env::block_timestamp()"
    let v130 : uint64 = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : (int64 -> US3) = method11()
    let v132 : US3 option = v5 |> Option.map v131 
    let v143 : US3 = US3_1
    let v144 : US3 = v132 |> Option.defaultValue v143 
    let v153 : uint64 =
        match v144 with
        | US3_1 -> (* None *)
            v130
        | US3_0(v148) -> (* Some *)
            let v149 : (int64 -> uint64) = uint64
            let v150 : uint64 = v149 v148
            let v151 : uint64 = v130 - v150
            v151
    let v154 : uint64 = v153 / 1000000000UL
    let v155 : uint64 = v154 % 60UL
    let v156 : uint64 = v154 / 60UL
    let v157 : uint64 = v156 % 60UL
    let v158 : uint64 = v154 / 3600UL
    let v159 : uint64 = v158 % 24UL
    let v160 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v159, v157, v155) v160 
    let v162 : string = "fable_library_rust::String_::fromString($0)"
    let v163 : string = Fable.Core.RustInterop.emitRustExpr v161 v162 
    let _v6 = v163 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v164 : (int64 -> US3) = method11()
    let v165 : US3 option = v5 |> Option.map v164 
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
    let v218 : string = method13()
    let v221 : (string -> string) = v217.ToString
    let v222 : string = v221 v218
    let _v6 = v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : (int64 -> US3) = method11()
    let v226 : US3 option = v5 |> Option.map v225 
    let v237 : US3 = US3_1
    let v238 : US3 = v226 |> Option.defaultValue v237 
    let v278 : System.DateTime =
        match v238 with
        | US3_1 -> (* None *)
            let v274 : System.DateTime = System.DateTime.Now
            v274
        | US3_0(v242) -> (* Some *)
            let v243 : System.DateTime = System.DateTime.Now
            let v246 : (System.DateTime -> int64) = _.Ticks
            let v247 : int64 = v246 v243
            let v250 : int64 = v247 - v242
            let v251 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v252 : System.TimeSpan = v251 v250
            let v255 : (System.TimeSpan -> int32) = _.Hours
            let v256 : int32 = v255 v252
            let v259 : (System.TimeSpan -> int32) = _.Minutes
            let v260 : int32 = v259 v252
            let v263 : (System.TimeSpan -> int32) = _.Seconds
            let v264 : int32 = v263 v252
            let v267 : (System.TimeSpan -> int32) = _.Milliseconds
            let v268 : int32 = v267 v252
            let v271 : System.DateTime = System.DateTime (1, 1, 1, v256, v260, v264, v268)
            v271
    let v279 : string = method13()
    let v282 : (string -> string) = v278.ToString
    let v283 : string = v282 v279
    let _v6 = v283 
    #endif
#else
    let v286 : (int64 -> US3) = method11()
    let v287 : US3 option = v5 |> Option.map v286 
    let v298 : US3 = US3_1
    let v299 : US3 = v287 |> Option.defaultValue v298 
    let v339 : System.DateTime =
        match v299 with
        | US3_1 -> (* None *)
            let v335 : System.DateTime = System.DateTime.Now
            v335
        | US3_0(v303) -> (* Some *)
            let v304 : System.DateTime = System.DateTime.Now
            let v307 : (System.DateTime -> int64) = _.Ticks
            let v308 : int64 = v307 v304
            let v311 : int64 = v308 - v303
            let v312 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v313 : System.TimeSpan = v312 v311
            let v316 : (System.TimeSpan -> int32) = _.Hours
            let v317 : int32 = v316 v313
            let v320 : (System.TimeSpan -> int32) = _.Minutes
            let v321 : int32 = v320 v313
            let v324 : (System.TimeSpan -> int32) = _.Seconds
            let v325 : int32 = v324 v313
            let v328 : (System.TimeSpan -> int32) = _.Milliseconds
            let v329 : int32 = v328 v313
            let v332 : System.DateTime = System.DateTime (1, 1, 1, v317, v321, v325, v329)
            v332
    let v340 : string = method13()
    let v343 : (string -> string) = v339.ToString
    let v344 : string = v343 v340
    let _v6 = v344 
    #endif
    let v347 : string = _v6 
    v347
and method15 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method14 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_black"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v23 
    let _v22 = v24 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v25 
    let _v22 = v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v27 
    let _v22 = v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v32 
    #endif
#else
    let v35 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v35 
    #endif
    let v38 : Ref<Str> = _v22 
    let v43 : string = "inline_colorization::color_reset"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v38, v44) v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _v19 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "inline_colorization::color_bright_black"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = "&*$0"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v52 
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v54 
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v56 
    let _v51 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v61 
    #endif
#else
    let v64 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v64 
    #endif
    let v67 : Ref<Str> = _v51 
    let v72 : string = "inline_colorization::color_reset"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v50, v67, v73) v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _v19 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "inline_colorization::color_bright_black"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : string = "&*$0"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v81 
    let _v80 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "&*$0"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v83 
    let _v80 = v84 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "&*$0"
    let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v85 
    let _v80 = v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v90 
    #endif
#else
    let v93 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v93 
    #endif
    let v96 : Ref<Str> = _v80 
    let v101 : string = "inline_colorization::color_reset"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v79, v96, v102) v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    let _v19 = v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v107 : string = "\u001b[90m"
    let v108 : string = method15()
    let v109 : string = v107 + v5 
    let v110 : string = v109 + v108 
    let _v19 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = "\u001b[90m"
    let v112 : string = method15()
    let v113 : string = v111 + v5 
    let v114 : string = v113 + v112 
    let _v19 = v114 
    #endif
#else
    let v115 : string = "\u001b[90m"
    let v116 : string = method15()
    let v117 : string = v115 + v5 
    let v118 : string = v117 + v116 
    let _v19 = v118 
    #endif
    let v119 : string = _v19 
    v119
and method17 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : Mut4, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method16 (v0 : int32, v1 : string, v2 : uint16) : string =
    let v3 : string = method17()
    let v4 : Mut4 = {l0 = v3} : Mut4
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure7(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "first_letter_code"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure7(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure7(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure7(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure7(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "hash_part"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure7(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure7(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure7(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure7(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "combined_value"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure7(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure7(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure7(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure7(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method18 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "crypto.hash_to_port"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure8 (v0 : Mut1) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure10 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure9 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure10(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method19 (v0 : string, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : Mut5, v6 : int64 option) : unit =
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v1)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : (string -> unit) = closure9()
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v14 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = v4.l0
    let v17 : bool = v16 = ""
    let v25 : string =
        if v17 then
            v0
        else
            let v18 : bool = v0 = ""
            if v18 then
                let v19 : string = v4.l0
                v19
            else
                let v20 : string = v4.l0
                let v21 : string = "\n"
                let v22 : string = v20 + v21 
                let v23 : string = v22 + v0 
                v23
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "&*$0"
    let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "&*$0"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v36 
    #endif
#else
    let v39 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v39 
    #endif
    let v42 : Ref<Str> = _v26 
    let v47 : string = $"$0.chars()"
    let v48 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v42 v47 
    let v49 : string = "$0"
    let v50 : _ = Fable.Core.RustInterop.emitRustExpr v48 v49 
    let v51 : string = "$0.collect::<Vec<_>>()"
    let v52 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v54 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let v55 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v56 : bool = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v57 : string = "x"
    let v58 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : string = "String::from_iter($0)"
    let v60 : std_string_String = Fable.Core.RustInterop.emitRustExpr v58 v59 
    let v61 : string = "true; $0 }).collect::<Vec<_>>()"
    let v62 : bool = Fable.Core.RustInterop.emitRustExpr v60 v61 
    let v63 : string = "_vec_map"
    let v64 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v63 
    let v65 : string = "$0.len()"
    let v66 : unativeint = Fable.Core.RustInterop.emitRustExpr v64 v65 
    let v67 : (unativeint -> int32) = int32
    let v68 : int32 = v67 v66
    let v69 : string = ""
    let v70 : bool = v0 <> v69 
    let v74 : bool =
        if v70 then
            let v73 : bool = v68 <= 1
            v73
        else
            false
    if v74 then
        v4.l0 <- v25
        ()
    else
        v4.l0 <- v69
        let v75 : string = "true; $0.into_iter().for_each(|x| { //"
        let v76 : bool = Fable.Core.RustInterop.emitRustExpr v64 v75 
        let v77 : string = "x"
        let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v77 
        let v79 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v80 : bool = Fable.Core.RustInterop.emitRustExpr v78 v79 
        let v81 : string = $"true"
        let v82 : bool = Fable.Core.RustInterop.emitRustExpr () v81 
        let v83 : string = "true; }); //"
        let v84 : bool = Fable.Core.RustInterop.emitRustExpr () v83 
        ()
    let _v13 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v12 v0
    let _v13 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v12 v0
    let _v13 = () 
    #endif
#else
    v12 v0
    let _v13 = () 
    #endif
    _v13 
    let v85 : (string -> unit) = v2.l0
    v85 v0
and closure2 (v0 : int32, v1 : string, v2 : uint16) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure3()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : US0 = v23.l0
    let v38 : bool = v21.l0
    let v39 : bool = v38 = false
    let v42 : bool =
        if v39 then
            false
        else
            let v40 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v37
            let v41 : bool = 0 >= v40
            v41
    if v42 then
        let v43 : unit = ()
        let v44 : unit = (fun () -> v4 (); v43) ()
        let struct (v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : Mut5, v63 : int64 option) = TraceState.trace_state.Value
        let v76 : string = method10(v58, v59, v60, v61, v62, v63)
        let v77 : string = method14()
        let v78 : int64 = v58.l0
        let v79 : string = method16(v0, v1, v2)
        let v80 : string = method18(v76, v77, v78, v79)
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : Mut5, v101 : int64 option) = TraceState.trace_state.Value
        method19(v80, v96, v97, v98, v99, v100, v101)
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
    let v123 : uint16 = v8 % 48128us
    let v124 : uint16 = v123 + 1024us
    v124
let v0 : (string -> string) = closure0()
let hash_text x = v0 x
let v1 : (string -> uint16) = closure1()
let hash_to_port x = v1 x
()
