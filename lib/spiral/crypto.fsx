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
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
    | US3_1
and Mut5 = {mutable l0 : string}
let rec method1 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method2 () : string =
    let v0 : string = ""
    v0
and method0 (v0 : string) : string =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v5 : (System.Text.Encoding -> (string -> (uint8 []))) = _.GetBytes
    let v6 : (string -> (uint8 [])) = v5 v4
    let v7 : (uint8 []) = v6 v0
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "std::io::Cursor::new(v9)"
    let v11 : std_io_Cursor<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr () v10 
    let v12 : string = "std::io::BufReader::new(v11)"
    let v13 : std_io_BufReader<std_io_Cursor<Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "true; let mut v13 = v13"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "result"
    let v18 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : string = "true; let mut v18 = v18"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr () v19 
    let v23 : unativeint = 0 |> unativeint 
    let v30 : string = "[$0; 1024]"
    let v31 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v30 
    let v32 : string = "true; loop { // rust.loop"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "true; let mut v31 = v31"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "std::io::Read::read(&mut v13, &mut v31)"
    let v37 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    let v39 : unativeint = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v42 : bool = v39 = v23 
    if v42 then
        let v49 : string = "true; break"
        let v50 : bool = Fable.Core.RustInterop.emitRustExpr () v49 
        ()
    let v51 : string = "v31.len()"
    let v52 : unativeint = Fable.Core.RustInterop.emitRustExpr () v51 
    let v55 : uint8 = v52 |> uint8 
    let v64 : unativeint = v39 |> unativeint 
    let v73 : unativeint = v64 |> unbox<unativeint>
    let v82 : bool = v73 = v52 
    let v93 : Ref<Slice'<uint8>> =
        if v82 then
            let v89 : string = "&v31[v23..]"
            let v90 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v89 
            v90
        else
            let v91 : string = "&v31[$0..$1]"
            let v92 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v23, v64) v91 
            v92
    let v94 : string = "sha2::Digest::update(&mut v18, v93)"
    Fable.Core.RustInterop.emitRustExpr () v94 
    let v95 : string = "true; } // rust.loop"
    let v96 : bool = Fable.Core.RustInterop.emitRustExpr () v95 
    let v97 : string = "true; } // rust.loop"
    let v98 : bool = Fable.Core.RustInterop.emitRustExpr () v97 
    let v99 : string = "true; } // rust.loop"
    let v100 : bool = Fable.Core.RustInterop.emitRustExpr () v99 
    let v101 : string = "true; { // rust.loop"
    let v102 : bool = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = "true; { // rust.loop"
    let v104 : bool = Fable.Core.RustInterop.emitRustExpr () v103 
    let v105 : string = "&sha2::Digest::finalize(v18)"
    let v106 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v105 
    let v107 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
    let v108 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v106 v107 
    let v109 : string = "true; let _result : Vec<_> = v108.into_iter().map(|x| { //"
    let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109 
    let v111 : string = "x"
    let v112 : uint8 = Fable.Core.RustInterop.emitRustExpr () v111 
    let v113 : string = "format!(\"{:02x}\", $0)"
    let v114 : std_string_String = Fable.Core.RustInterop.emitRustExpr v112 v113 
    let v115 : string = "fable_library_rust::String_::fromString($0)"
    let v116 : string = Fable.Core.RustInterop.emitRustExpr v114 v115 
    let v117 : string = "true; $0 }).collect::<Vec<_>>()"
    let v118 : bool = Fable.Core.RustInterop.emitRustExpr v116 v117 
    let v119 : string = "_result"
    let v120 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v119 
    let v121 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v122 : (string []) = Fable.Core.RustInterop.emitRustExpr v120 v121 
    let v125 : string seq = seq { for i = 0 to v122.Length - 1 do yield v122.[i] }
    let v134 : (string -> (string seq -> string)) = String.concat
    let v135 : string = ""
    let v136 : (string seq -> string) = v134 v135
    let v137 : string = v136 v125
    let v144 : Result<string, std_io_Error> = Ok v137 
    let v145 : string = "$0.unwrap()"
    let v146 : string = Fable.Core.RustInterop.emitRustExpr v144 v145 
    v146 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v149 : string = null |> unbox<string>
    v149 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v158 : string = null |> unbox<string>
    v158 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v165 : string = "crypto"
    let v166 : ICryptoCreateHash = Fable.Core.JsInterop.importAll v165 
    let v167 : string = "v166.createHash($0)"
    let v168 : string = "sha256"
    let v169 : obj = Fable.Core.JsInterop.emitJsExpr v168 v167 
    let v170 : string = "$0.update($1, 'utf8')"
    let v171 : obj = Fable.Core.JsInterop.emitJsExpr struct (v169, v0) v170 
    let v172 : string = "$0.digest($1)"
    let v173 : string = "hex"
    let v174 : string = Fable.Core.JsInterop.emitJsExpr struct (v171, v173) v172 
    v174 
    #endif
#if FABLE_COMPILER_PYTHON
    let v177 : string = "hashlib"
    let v178 : IHashlibSha256 = Fable.Core.PyInterop.importAll v177 
    let v179 : string = "v178.sha256()"
    let v180 : obj = Fable.Core.PyInterop.emitPyExpr () v179 
    let v189 : string = "$0.encode($1)"
    let v190 : string = "utf-8"
    let v191 : string = Fable.Core.PyInterop.emitPyExpr struct (v0, v190) v189 
    let v200 : string = "v180.update($0)"
    Fable.Core.PyInterop.emitPyExpr v191 v200 
    let v207 : string = "v180.hexdigest()"
    let v208 : string = Fable.Core.PyInterop.emitPyExpr () v207 
    v208 
    #endif
#else
    let v215 : (unit -> System.Security.Cryptography.SHA256) = System.Security.Cryptography.SHA256.Create
    let v216 : System.Security.Cryptography.SHA256 = v215 ()
    use v216 = v216 
    let v217 : System.Security.Cryptography.SHA256 = v216 
    let v218 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v219 : (System.Text.Encoding -> (string -> (uint8 []))) = _.GetBytes
    let v220 : (string -> (uint8 [])) = v219 v218
    let v221 : (uint8 []) = v220 v0
    let v222 : ((uint8 []) -> (uint8 [])) = v217.ComputeHash
    let v223 : (uint8 []) = v222 v221
    let v224 : int32 = v223.Length
    let v225 : (string []) = Array.zeroCreate<string> (v224)
    let v226 : Mut0 = {l0 = 0} : Mut0
    while method1(v224, v226) do
        let v228 : int32 = v226.l0
        let v229 : uint8 = v223.[int v228]
        let v230 : (string -> string) = v229.ToString
        let v231 : string = "x2"
        let v232 : string = v230 v231
        v225.[int v228] <- v232
        let v233 : int32 = v228 + 1
        v226.l0 <- v233
        ()
    let v236 : string seq = seq { for i = 0 to v225.Length - 1 do yield v225.[i] }
    let v243 : string = method2()
    let v246 : (string -> (string seq -> string)) = String.concat
    let v247 : (string seq -> string) = v246 v243
    let v248 : string = v247 v236
    v248 
    #endif
    |> fun x -> _v3 <- Some x
    let v255 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v255
and closure0 () (v0 : string) : string =
    method0(v0)
and closure2 () () : string =
    let v0 : string = "crypto.hash_to_port"
    v0
and closure3 (v0 : int32, v1 : string, v2 : uint16) () : struct (int32 * string * uint16) =
    struct (v0, v1, v2)
and method4 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method6 () : string =
    let v0 : string = ""
    v0
and method5 (v0 : string) : string =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "std::env::var(&*$0)"
    let v5 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : string = "true; let _result = $0.map(|x| { //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "x"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "true; $0 })"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "_result"
    let v15 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = method6()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : string = "std::env::var(&*$0)"
    let v20 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v19 
    let v21 : string = "true; let _result = $0.map(|x| { //"
    let v22 : bool = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "x"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "true; $0 })"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let v29 : string = "_result"
    let v30 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : string = method6()
    let v32 : string = "$0.unwrap_or($1)"
    let v33 : string = Fable.Core.RustInterop.emitRustExpr struct (v30, v31) v32 
    v33 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "std::env::var(&*$0)"
    let v35 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v34 
    let v36 : string = "true; let _result = $0.map(|x| { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "x"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "true; $0 })"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "_result"
    let v45 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = method6()
    let v47 : string = "$0.unwrap_or($1)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr struct (v45, v46) v47 
    v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : string = "process.env[$0] ?? \"\""
    let v50 : string = Fable.Core.JsInterop.emitJsExpr v0 v49 
    v50 
    #endif
#if FABLE_COMPILER_PYTHON
    let v53 : string = "os"
    let v54 : IOsEnviron = Fable.Core.PyInterop.importAll v53 
    let v55 : string = "v54.environ"
    let v56 : obj = Fable.Core.PyInterop.emitPyExpr () v55 
    let v65 : string = "v56.get($0)"
    let v66 : string = Fable.Core.PyInterop.emitPyExpr v0 v65 
    let mutable _v66 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v75 : (string -> string option) = Option.ofObj
    let v76 : string option = v75 v66
    v76 
    #else
    Some v66 
    #endif
    |> fun x -> _v66 <- Some x
    let v77 : string option = match _v66 with Some x -> x | None -> failwith "optionm'.of_obj / _v66=None"
    let v86 : US3 option = None
    let _v86 = ref v86 
    match v77 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v87 : string = x
    let v88 : US3 = US3_0(v87)
    v88 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v86.Value <- x
    let v89 : US3 option = _v86.Value 
    let v112 : US3 = US3_1
    let v113 : US3 = v89 |> Option.defaultValue v112 
    let v124 : string =
        match v113 with
        | US3_1 -> (* None *)
            let v122 : string = ""
            v122
        | US3_0(v121) -> (* Some *)
            v121
    v124 
    #endif
#else
    let v125 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v126 : string = v125 v0
    let mutable _v126 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v129 : (string -> string option) = Option.ofObj
    let v130 : string option = v129 v126
    v130 
    #else
    Some v126 
    #endif
    |> fun x -> _v126 <- Some x
    let v131 : string option = match _v126 with Some x -> x | None -> failwith "optionm'.of_obj / _v126=None"
    let v140 : US3 option = None
    let _v140 = ref v140 
    match v131 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v141 : string = x
    let v142 : US3 = US3_0(v141)
    v142 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v140.Value <- x
    let v143 : US3 option = _v140.Value 
    let v166 : US3 = US3_1
    let v167 : US3 = v143 |> Option.defaultValue v166 
    let v178 : string =
        match v167 with
        | US3_1 -> (* None *)
            let v176 : string = ""
            v176
        | US3_0(v175) -> (* Some *)
            v175
    v178 
    #endif
    |> fun x -> _v3 <- Some x
    let v179 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v179
and method7 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure6 () (v0 : string) : unit =
    ()
and closure5 () (v0 : US0) : struct (Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v3 : bool = true
    let mutable _v3 : struct (US1 * US2) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method4()
    let v5 : string = method5(v4)
    let v7 : bool = "Verbose" = v5
    let v11 : US1 =
        if v7 then
            let v8 : US0 = US0_0
            US1_0(v8)
        else
            US1_1
    let v56 : US1 =
        match v11 with
        | US1_1 -> (* None *)
            let v15 : bool = "Debug" = v5
            let v19 : US1 =
                if v15 then
                    let v16 : US0 = US0_1
                    US1_0(v16)
                else
                    US1_1
            match v19 with
            | US1_1 -> (* None *)
                let v23 : bool = "Info" = v5
                let v27 : US1 =
                    if v23 then
                        let v24 : US0 = US0_2
                        US1_0(v24)
                    else
                        US1_1
                match v27 with
                | US1_1 -> (* None *)
                    let v31 : bool = "Warning" = v5
                    let v35 : US1 =
                        if v31 then
                            let v32 : US0 = US0_3
                            US1_0(v32)
                        else
                            US1_1
                    match v35 with
                    | US1_1 -> (* None *)
                        let v39 : bool = "Critical" = v5
                        let v43 : US1 =
                            if v39 then
                                let v40 : US0 = US0_4
                                US1_0(v40)
                            else
                                US1_1
                        match v43 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v44) -> (* Some *)
                            US1_0(v44)
                    | US1_0(v36) -> (* Some *)
                        US1_0(v36)
                | US1_0(v28) -> (* Some *)
                    US1_0(v28)
            | US1_0(v20) -> (* Some *)
                US1_0(v20)
        | US1_0(v12) -> (* Some *)
            US1_0(v12)
    let v57 : string = method7()
    let v58 : string = method5(v57)
    let v60 : bool = v58 = "True"
    let v82 : US2 =
        if v60 then
            let v63 : System.DateTime = System.DateTime.Now
            let v72 : (System.DateTime -> int64) = _.Ticks
            let v73 : int64 = v72 v63
            US2_0(v73)
        else
            US2_1
    struct (v56, v82) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : US1 = US1_1
    let v84 : US2 = US2_1
    struct (v83, v84) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "AUTOMATION"
    let v88 : bool = true
    let mutable _v88 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : string = "env!(\"" + v85 + "\")"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = "String::from($0)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v90 v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    v94 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v95 : string = "env!(\"" + v85 + "\")"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v96 v97 
    let v99 : string = "fable_library_rust::String_::fromString($0)"
    let v100 : string = Fable.Core.RustInterop.emitRustExpr v98 v99 
    v100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v101 : string = "env!(\"" + v85 + "\")"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = "String::from($0)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : string = null |> unbox<string>
    v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v118 : string = null |> unbox<string>
    v118 
    #endif
#else
    let v127 : string = null |> unbox<string>
    v127 
    #endif
    |> fun x -> _v88 <- Some x
    let v134 : string = match _v88 with Some x -> x | None -> failwith "base.run_target / _v88=None"
    let v151 : string = "True"
    let v152 : bool = v134 <> v151 
    let v165 : US2 =
        if v152 then
            US2_1
        else
            let v160 : string = $"near_sdk::env::block_timestamp()"
            let v161 : uint64 = Fable.Core.RustInterop.emitRustExpr () v160 
            let v162 : (uint64 -> int64) = int64
            let v163 : int64 = v162 v161
            US2_0(v163)
    let v166 : US1 = US1_1
    struct (v166, v165) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v167 : string = method4()
    let v168 : string = method5(v167)
    let v170 : bool = "Verbose" = v168
    let v174 : US1 =
        if v170 then
            let v171 : US0 = US0_0
            US1_0(v171)
        else
            US1_1
    let v219 : US1 =
        match v174 with
        | US1_1 -> (* None *)
            let v178 : bool = "Debug" = v168
            let v182 : US1 =
                if v178 then
                    let v179 : US0 = US0_1
                    US1_0(v179)
                else
                    US1_1
            match v182 with
            | US1_1 -> (* None *)
                let v186 : bool = "Info" = v168
                let v190 : US1 =
                    if v186 then
                        let v187 : US0 = US0_2
                        US1_0(v187)
                    else
                        US1_1
                match v190 with
                | US1_1 -> (* None *)
                    let v194 : bool = "Warning" = v168
                    let v198 : US1 =
                        if v194 then
                            let v195 : US0 = US0_3
                            US1_0(v195)
                        else
                            US1_1
                    match v198 with
                    | US1_1 -> (* None *)
                        let v202 : bool = "Critical" = v168
                        let v206 : US1 =
                            if v202 then
                                let v203 : US0 = US0_4
                                US1_0(v203)
                            else
                                US1_1
                        match v206 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v207) -> (* Some *)
                            US1_0(v207)
                    | US1_0(v199) -> (* Some *)
                        US1_0(v199)
                | US1_0(v191) -> (* Some *)
                    US1_0(v191)
            | US1_0(v183) -> (* Some *)
                US1_0(v183)
        | US1_0(v175) -> (* Some *)
            US1_0(v175)
    let v220 : string = method7()
    let v221 : string = method5(v220)
    let v222 : bool = v221 = "True"
    let v244 : US2 =
        if v222 then
            let v225 : System.DateTime = System.DateTime.Now
            let v234 : (System.DateTime -> int64) = _.Ticks
            let v235 : int64 = v234 v225
            US2_0(v235)
        else
            US2_1
    struct (v219, v244) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v245 : string = method4()
    let v246 : string = method5(v245)
    let v248 : bool = "Verbose" = v246
    let v252 : US1 =
        if v248 then
            let v249 : US0 = US0_0
            US1_0(v249)
        else
            US1_1
    let v297 : US1 =
        match v252 with
        | US1_1 -> (* None *)
            let v256 : bool = "Debug" = v246
            let v260 : US1 =
                if v256 then
                    let v257 : US0 = US0_1
                    US1_0(v257)
                else
                    US1_1
            match v260 with
            | US1_1 -> (* None *)
                let v264 : bool = "Info" = v246
                let v268 : US1 =
                    if v264 then
                        let v265 : US0 = US0_2
                        US1_0(v265)
                    else
                        US1_1
                match v268 with
                | US1_1 -> (* None *)
                    let v272 : bool = "Warning" = v246
                    let v276 : US1 =
                        if v272 then
                            let v273 : US0 = US0_3
                            US1_0(v273)
                        else
                            US1_1
                    match v276 with
                    | US1_1 -> (* None *)
                        let v280 : bool = "Critical" = v246
                        let v284 : US1 =
                            if v280 then
                                let v281 : US0 = US0_4
                                US1_0(v281)
                            else
                                US1_1
                        match v284 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v285) -> (* Some *)
                            US1_0(v285)
                    | US1_0(v277) -> (* Some *)
                        US1_0(v277)
                | US1_0(v269) -> (* Some *)
                    US1_0(v269)
            | US1_0(v261) -> (* Some *)
                US1_0(v261)
        | US1_0(v253) -> (* Some *)
            US1_0(v253)
    let v298 : string = method7()
    let v299 : string = method5(v298)
    let v300 : bool = v299 = "True"
    let v322 : US2 =
        if v300 then
            let v303 : System.DateTime = System.DateTime.Now
            let v312 : (System.DateTime -> int64) = _.Ticks
            let v313 : int64 = v312 v303
            US2_0(v313)
        else
            US2_1
    struct (v297, v322) 
    #endif
#else
    let v323 : string = method4()
    let v324 : string = method5(v323)
    let v326 : bool = "Verbose" = v324
    let v330 : US1 =
        if v326 then
            let v327 : US0 = US0_0
            US1_0(v327)
        else
            US1_1
    let v375 : US1 =
        match v330 with
        | US1_1 -> (* None *)
            let v334 : bool = "Debug" = v324
            let v338 : US1 =
                if v334 then
                    let v335 : US0 = US0_1
                    US1_0(v335)
                else
                    US1_1
            match v338 with
            | US1_1 -> (* None *)
                let v342 : bool = "Info" = v324
                let v346 : US1 =
                    if v342 then
                        let v343 : US0 = US0_2
                        US1_0(v343)
                    else
                        US1_1
                match v346 with
                | US1_1 -> (* None *)
                    let v350 : bool = "Warning" = v324
                    let v354 : US1 =
                        if v350 then
                            let v351 : US0 = US0_3
                            US1_0(v351)
                        else
                            US1_1
                    match v354 with
                    | US1_1 -> (* None *)
                        let v358 : bool = "Critical" = v324
                        let v362 : US1 =
                            if v358 then
                                let v359 : US0 = US0_4
                                US1_0(v359)
                            else
                                US1_1
                        match v362 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v363) -> (* Some *)
                            US1_0(v363)
                    | US1_0(v355) -> (* Some *)
                        US1_0(v355)
                | US1_0(v347) -> (* Some *)
                    US1_0(v347)
            | US1_0(v339) -> (* Some *)
                US1_0(v339)
        | US1_0(v331) -> (* Some *)
            US1_0(v331)
    let v376 : string = method7()
    let v377 : string = method5(v376)
    let v378 : bool = v377 = "True"
    let v400 : US2 =
        if v378 then
            let v381 : System.DateTime = System.DateTime.Now
            let v390 : (System.DateTime -> int64) = _.Ticks
            let v391 : int64 = v390 v381
            US2_0(v391)
        else
            US2_1
    struct (v375, v400) 
    #endif
    |> fun x -> _v3 <- Some x
    let struct (v401 : US1, v402 : US2) = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    let v487 : Mut3 = {l0 = true} : Mut3
    let v488 : Mut1 = {l0 = 0L} : Mut1
    let v491 : US0 =
        match v401 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v489) -> (* Some *)
            v489
    let v492 : Mut4 = {l0 = v491} : Mut4
    let v493 : (string -> unit) = closure6()
    let v494 : Mut2 = {l0 = v493} : Mut2
    let v507 : int64 option =
        match v402 with
        | US2_1 -> (* None *)
            let v505 : int64 option = None
            v505
        | US2_0(v495) -> (* Some *)
            let v498 : int64 option = Some v495 
            v498
    struct (v488, v494, v487, v492, v507)
and method8 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method9 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method10 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method12 (v0 : Mut5, v1 : string) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and method13 (v0 : Mut5) : unit =
    ()
and method14 (v0 : Mut5, v1 : int32) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and method15 (v0 : Mut5, v1 : uint16) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and method11 (v0 : Mut5, v1 : int32, v2 : string, v3 : uint16) : unit =
    let v4 : string = "{ "
    method12(v0, v4)
    method13(v0)
    let v5 : string = "first_letter_code"
    method12(v0, v5)
    let v6 : string = " = "
    method12(v0, v6)
    method14(v0, v1)
    let v7 : string = "; "
    method12(v0, v7)
    let v8 : string = "hash_part"
    method12(v0, v8)
    method12(v0, v6)
    method12(v0, v2)
    method12(v0, v7)
    let v9 : string = "combined_value"
    method12(v0, v9)
    method12(v0, v6)
    method15(v0, v3)
    let v10 : string = " }"
    method12(v0, v10)
and closure4 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string * uint16))) () : string =
    let v5 : (US0 -> struct (Mut1 * Mut2 * Mut3 * Mut4 * int64 option)) = closure5()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut1, v15 : Mut2, v16 : Mut3, v17 : Mut4, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method8()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method8()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method9()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method9()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method9()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method10()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method10()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method10()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : int32, v1216 : string, v1217 : uint16) = v2 ()
    let v1218 : string = ""
    let v1219 : Mut5 = {l0 = v1218} : Mut5
    method11(v1219, v1215, v1216, v1217)
    let v1220 : string = v1219.l0
    let v1223 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1220}"
    let v1230 : char list = []
    let v1235 : (char list -> (char [])) = List.toArray
    let v1236 : (char []) = v1235 v1230
    let v1243 : string = v1223.TrimStart v1236 
    let v1282 : char list = []
    let v1285 : char list = '/' :: v1282 
    let v1294 : char list = ' ' :: v1285 
    let v1305 : (char list -> (char [])) = List.toArray
    let v1306 : (char []) = v1305 v1294
    let v1313 : string = v1243.TrimEnd v1306 
    v1313
and method16 (v0 : US0, v1 : (unit -> string)) : unit =
    let v4 : (US0 -> struct (Mut1 * Mut2 * Mut3 * Mut4 * int64 option)) = closure5()
    let v5 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v4 v5 |> Some
    let struct (v13 : Mut1, v14 : Mut2, v15 : Mut3, v16 : Mut4, v17 : int64 option) = State.trace_state.Value
    let v34 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v4 v34 |> Some
    let struct (v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : Mut4, v46 : int64 option) = State.trace_state.Value
    let v61 : US0 = v45.l0
    let v62 : bool = v44.l0
    let v63 : bool = v62 = false
    let v67 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v65 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v66 : bool = v64 >= v65
            v66
    if v67 then
        let v68 : int64 = v13.l0
        let v69 : int64 = v68 + 1L
        v13.l0 <- v69
        let v72 : string = $"%s{v1 ()}"
        let v81 : bool = true
        let mutable _v81 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v82 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v82 
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v83 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v83 
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v84 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v84 
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v72 
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v72 
        () 
        #endif
#else
        System.Console.WriteLine v72 
        () 
        #endif
        |> fun x -> _v81 <- Some x
        match _v81 with Some x -> x | None -> failwith "base.run_target / _v81=None"
        let v113 : (string -> unit) = v14.l0
        v113 v72
and method3 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string * uint16))) : unit =
    let v3 : (unit -> string) = closure4(v0, v1, v2)
    method16(v0, v3)
and closure1 () (v0 : string) : uint16 =
    let v1 : char = v0.[int 0]
    let v2 : (char -> int32) = int32
    let v3 : int32 = v2 v1
    let v4 : string = v0.[int 0..int 7]
    let v5 : int32 = System.Convert.ToInt32 (v4, 16)
    let v6 : int32 = v5 + v3
    let v7 : (int32 -> uint16) = uint16
    let v8 : uint16 = v7 v6
    let v9 : US0 = US0_0
    let v10 : (unit -> string) = closure2()
    let v11 : (unit -> struct (int32 * string * uint16)) = closure3(v3, v4, v8)
    method3(v9, v10, v11)
    let v12 : uint16 = v8 % 48128us
    let v13 : uint16 = v12 + 1024us
    v13
let v0 : (string -> string) = closure0()
let hash_text x = v0 x
let v1 : (string -> uint16) = closure1()
let hash_to_port x = v1 x
()
