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
    let v365 : (string -> unit) = closure6()
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
and closure3 () () : unit =
    let v0 : bool = State.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut1, v3 : Mut2, v4 : Mut3, v5 : Mut4, v6 : int64 option) = method4(v1)
        let v7 : struct (Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6) 
        State.trace_state <- v7 
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
and closure10 (v0 : Mut5, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure11 () () : string =
    let v0 : string = "crypto.hash_to_port"
    v0
and closure13 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure12 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure13(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure2 (v0 : int32, v1 : string, v2 : uint16) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure3()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = State.trace_state.Value
    let v33 : unit = ()
    let v34 : unit = (fun () -> v4 (); v33) ()
    let struct (v47 : Mut1, v48 : Mut2, v49 : Mut3, v50 : Mut4, v51 : int64 option) = State.trace_state.Value
    let v62 : US0 = v50.l0
    let v63 : bool = v49.l0
    let v64 : bool = v63 = false
    let v67 : bool =
        if v64 then
            false
        else
            let v65 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v62
            let v66 : bool = 0 >= v65
            v66
    if v67 then
        let v68 : unit = ()
        let v69 : (unit -> unit) = closure7(v18)
        let v70 : unit = (fun () -> v69 (); v68) ()
        let v73 : unit = ()
        let v74 : unit = (fun () -> v4 (); v73) ()
        let struct (v87 : Mut1, v88 : Mut2, v89 : Mut3, v90 : Mut4, v91 : int64 option) = State.trace_state.Value
        let v102 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v103 : US3 option = None
        let _v103 = ref v103 
        let v104 : US3 option ref = _v103 
        let v105 : (US3 option -> US3 option ref) = closure8(v104)
        let v106 : unit = ()
        let v107 : (unit -> unit) = closure9(v91, v105)
        let v108 : unit = (fun () -> v107 (); v106) ()
        let v111 : US3 option = _v103.Value 
        let v122 : US3 = US3_1
        let v123 : US3 = v111 |> Option.defaultValue v122 
        let v163 : System.DateTime =
            match v123 with
            | US3_1 -> (* None *)
                let v159 : System.DateTime = System.DateTime.Now
                v159
            | US3_0(v127) -> (* Some *)
                let v128 : System.DateTime = System.DateTime.Now
                let v131 : (System.DateTime -> int64) = _.Ticks
                let v132 : int64 = v131 v128
                let v135 : int64 = v132 - v127
                let v136 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v137 : System.TimeSpan = v136 v135
                let v140 : (System.TimeSpan -> int32) = _.Hours
                let v141 : int32 = v140 v137
                let v144 : (System.TimeSpan -> int32) = _.Minutes
                let v145 : int32 = v144 v137
                let v148 : (System.TimeSpan -> int32) = _.Seconds
                let v149 : int32 = v148 v137
                let v152 : (System.TimeSpan -> int32) = _.Milliseconds
                let v153 : int32 = v152 v137
                let v156 : System.DateTime = System.DateTime (1, 1, 1, v141, v145, v149, v153)
                v156
        let v164 : string = method9()
        let v167 : (string -> string) = v163.ToString
        let v168 : string = v167 v164
        let _v102 = v168 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v171 : US3 option = None
        let _v171 = ref v171 
        let v172 : US3 option ref = _v171 
        let v173 : (US3 option -> US3 option ref) = closure8(v172)
        let v174 : unit = ()
        let v175 : (unit -> unit) = closure9(v91, v173)
        let v176 : unit = (fun () -> v175 (); v174) ()
        let v179 : US3 option = _v171.Value 
        let v190 : US3 = US3_1
        let v191 : US3 = v179 |> Option.defaultValue v190 
        let v231 : System.DateTime =
            match v191 with
            | US3_1 -> (* None *)
                let v227 : System.DateTime = System.DateTime.Now
                v227
            | US3_0(v195) -> (* Some *)
                let v196 : System.DateTime = System.DateTime.Now
                let v199 : (System.DateTime -> int64) = _.Ticks
                let v200 : int64 = v199 v196
                let v203 : int64 = v200 - v195
                let v204 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v205 : System.TimeSpan = v204 v203
                let v208 : (System.TimeSpan -> int32) = _.Hours
                let v209 : int32 = v208 v205
                let v212 : (System.TimeSpan -> int32) = _.Minutes
                let v213 : int32 = v212 v205
                let v216 : (System.TimeSpan -> int32) = _.Seconds
                let v217 : int32 = v216 v205
                let v220 : (System.TimeSpan -> int32) = _.Milliseconds
                let v221 : int32 = v220 v205
                let v224 : System.DateTime = System.DateTime (1, 1, 1, v209, v213, v217, v221)
                v224
        let v232 : string = method9()
        let v235 : (string -> string) = v231.ToString
        let v236 : string = v235 v232
        let _v102 = v236 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v239 : string = $"near_sdk::env::block_timestamp()"
        let v240 : uint64 = Fable.Core.RustInterop.emitRustExpr () v239 
        let v241 : US3 option = None
        let _v241 = ref v241 
        let v242 : US3 option ref = _v241 
        let v243 : (US3 option -> US3 option ref) = closure8(v242)
        let v244 : unit = ()
        let v245 : (unit -> unit) = closure9(v91, v243)
        let v246 : unit = (fun () -> v245 (); v244) ()
        let v249 : US3 option = _v241.Value 
        let v260 : US3 = US3_1
        let v261 : US3 = v249 |> Option.defaultValue v260 
        let v270 : uint64 =
            match v261 with
            | US3_1 -> (* None *)
                v240
            | US3_0(v265) -> (* Some *)
                let v266 : (int64 -> uint64) = uint64
                let v267 : uint64 = v266 v265
                let v268 : uint64 = v240 - v267
                v268
        let v271 : uint64 = v270 / 1000000000UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v271 / 60UL
        let v274 : uint64 = v273 % 60UL
        let v275 : uint64 = v271 / 3600UL
        let v276 : uint64 = v275 % 24UL
        let v277 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v278 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v276, v274, v272) v277 
        let v279 : string = "fable_library_rust::String_::fromString($0)"
        let v280 : string = Fable.Core.RustInterop.emitRustExpr v278 v279 
        let _v102 = v280 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v281 : US3 option = None
        let _v281 = ref v281 
        let v282 : US3 option ref = _v281 
        let v283 : (US3 option -> US3 option ref) = closure8(v282)
        let v284 : unit = ()
        let v285 : (unit -> unit) = closure9(v91, v283)
        let v286 : unit = (fun () -> v285 (); v284) ()
        let v289 : US3 option = _v281.Value 
        let v300 : US3 = US3_1
        let v301 : US3 = v289 |> Option.defaultValue v300 
        let v341 : System.DateTime =
            match v301 with
            | US3_1 -> (* None *)
                let v337 : System.DateTime = System.DateTime.Now
                v337
            | US3_0(v305) -> (* Some *)
                let v306 : System.DateTime = System.DateTime.Now
                let v309 : (System.DateTime -> int64) = _.Ticks
                let v310 : int64 = v309 v306
                let v313 : int64 = v310 - v305
                let v314 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v315 : System.TimeSpan = v314 v313
                let v318 : (System.TimeSpan -> int32) = _.Hours
                let v319 : int32 = v318 v315
                let v322 : (System.TimeSpan -> int32) = _.Minutes
                let v323 : int32 = v322 v315
                let v326 : (System.TimeSpan -> int32) = _.Seconds
                let v327 : int32 = v326 v315
                let v330 : (System.TimeSpan -> int32) = _.Milliseconds
                let v331 : int32 = v330 v315
                let v334 : System.DateTime = System.DateTime (1, 1, 1, v319, v323, v327, v331)
                v334
        let v342 : string = method10()
        let v345 : (string -> string) = v341.ToString
        let v346 : string = v345 v342
        let _v102 = v346 
        #endif
#if FABLE_COMPILER_PYTHON
        let v349 : US3 option = None
        let _v349 = ref v349 
        let v350 : US3 option ref = _v349 
        let v351 : (US3 option -> US3 option ref) = closure8(v350)
        let v352 : unit = ()
        let v353 : (unit -> unit) = closure9(v91, v351)
        let v354 : unit = (fun () -> v353 (); v352) ()
        let v357 : US3 option = _v349.Value 
        let v368 : US3 = US3_1
        let v369 : US3 = v357 |> Option.defaultValue v368 
        let v409 : System.DateTime =
            match v369 with
            | US3_1 -> (* None *)
                let v405 : System.DateTime = System.DateTime.Now
                v405
            | US3_0(v373) -> (* Some *)
                let v374 : System.DateTime = System.DateTime.Now
                let v377 : (System.DateTime -> int64) = _.Ticks
                let v378 : int64 = v377 v374
                let v381 : int64 = v378 - v373
                let v382 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v383 : System.TimeSpan = v382 v381
                let v386 : (System.TimeSpan -> int32) = _.Hours
                let v387 : int32 = v386 v383
                let v390 : (System.TimeSpan -> int32) = _.Minutes
                let v391 : int32 = v390 v383
                let v394 : (System.TimeSpan -> int32) = _.Seconds
                let v395 : int32 = v394 v383
                let v398 : (System.TimeSpan -> int32) = _.Milliseconds
                let v399 : int32 = v398 v383
                let v402 : System.DateTime = System.DateTime (1, 1, 1, v387, v391, v395, v399)
                v402
        let v410 : string = method10()
        let v413 : (string -> string) = v409.ToString
        let v414 : string = v413 v410
        let _v102 = v414 
        #endif
#else
        let v417 : US3 option = None
        let _v417 = ref v417 
        let v418 : US3 option ref = _v417 
        let v419 : (US3 option -> US3 option ref) = closure8(v418)
        let v420 : unit = ()
        let v421 : (unit -> unit) = closure9(v91, v419)
        let v422 : unit = (fun () -> v421 (); v420) ()
        let v425 : US3 option = _v417.Value 
        let v436 : US3 = US3_1
        let v437 : US3 = v425 |> Option.defaultValue v436 
        let v477 : System.DateTime =
            match v437 with
            | US3_1 -> (* None *)
                let v473 : System.DateTime = System.DateTime.Now
                v473
            | US3_0(v441) -> (* Some *)
                let v442 : System.DateTime = System.DateTime.Now
                let v445 : (System.DateTime -> int64) = _.Ticks
                let v446 : int64 = v445 v442
                let v449 : int64 = v446 - v441
                let v450 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v451 : System.TimeSpan = v450 v449
                let v454 : (System.TimeSpan -> int32) = _.Hours
                let v455 : int32 = v454 v451
                let v458 : (System.TimeSpan -> int32) = _.Minutes
                let v459 : int32 = v458 v451
                let v462 : (System.TimeSpan -> int32) = _.Seconds
                let v463 : int32 = v462 v451
                let v466 : (System.TimeSpan -> int32) = _.Milliseconds
                let v467 : int32 = v466 v451
                let v470 : System.DateTime = System.DateTime (1, 1, 1, v455, v459, v463, v467)
                v470
        let v478 : string = method10()
        let v481 : (string -> string) = v477.ToString
        let v482 : string = v481 v478
        let _v102 = v482 
        #endif
        let v485 : string = _v102 
        
        
        
        
        
        let v555 : string = "Verbose"
        let v556 : (unit -> string) = v555.ToLower
        let v557 : string = v556 ()
        let v560 : string = v557.PadLeft (7, ' ')
        let v574 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v575 : string = "inline_colorization::color_bright_black"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v575 
        let v577 : string = "&*$0"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v577 
        let v579 : string = "inline_colorization::color_reset"
        let v580 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v579 
        let v581 : string = "\"{v576}{v578}{v580}\""
        let v582 : string = @$"format!(" + v581 + ")"
        let v583 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v582 
        let v584 : string = "fable_library_rust::String_::fromString($0)"
        let v585 : string = Fable.Core.RustInterop.emitRustExpr v583 v584 
        let _v574 = v585 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v586 : string = "inline_colorization::color_bright_black"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v586 
        let v588 : string = "&*$0"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v588 
        let v590 : string = "inline_colorization::color_reset"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "\"{v587}{v589}{v591}\""
        let v593 : string = @$"format!(" + v592 + ")"
        let v594 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v593 
        let v595 : string = "fable_library_rust::String_::fromString($0)"
        let v596 : string = Fable.Core.RustInterop.emitRustExpr v594 v595 
        let _v574 = v596 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v597 : string = "inline_colorization::color_bright_black"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "&*$0"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v599 
        let v601 : string = "inline_colorization::color_reset"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "\"{v598}{v600}{v602}\""
        let v604 : string = @$"format!(" + v603 + ")"
        let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v604 
        let v606 : string = "fable_library_rust::String_::fromString($0)"
        let v607 : string = Fable.Core.RustInterop.emitRustExpr v605 v606 
        let _v574 = v607 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v608 : string = "\u001b[90m"
        let v609 : string = method11()
        let v610 : string = v608 + v560 
        let v611 : string = v610 + v609 
        let _v574 = v611 
        #endif
#if FABLE_COMPILER_PYTHON
        let v612 : string = "\u001b[90m"
        let v613 : string = method11()
        let v614 : string = v612 + v560 
        let v615 : string = v614 + v613 
        let _v574 = v615 
        #endif
#else
        let v616 : string = "\u001b[90m"
        let v617 : string = method11()
        let v618 : string = v616 + v560 
        let v619 : string = v618 + v617 
        let _v574 = v619 
        #endif
        let v620 : string = _v574 
        let v626 : int64 = v87.l0
        let v627 : string = method12()
        let v628 : Mut5 = {l0 = v627} : Mut5
        let v629 : string = "{ "
        let v630 : string = $"{v629}"
        let v633 : unit = ()
        let v634 : (unit -> unit) = closure10(v628, v630)
        let v635 : unit = (fun () -> v634 (); v633) ()
        let v638 : string = "first_letter_code"
        let v639 : string = $"{v638}"
        let v642 : unit = ()
        let v643 : (unit -> unit) = closure10(v628, v639)
        let v644 : unit = (fun () -> v643 (); v642) ()
        let v647 : string = " = "
        let v648 : string = $"{v647}"
        let v651 : unit = ()
        let v652 : (unit -> unit) = closure10(v628, v648)
        let v653 : unit = (fun () -> v652 (); v651) ()
        let v656 : string = $"{v0}"
        let v659 : unit = ()
        let v660 : (unit -> unit) = closure10(v628, v656)
        let v661 : unit = (fun () -> v660 (); v659) ()
        let v664 : string = "; "
        let v665 : string = $"{v664}"
        let v668 : unit = ()
        let v669 : (unit -> unit) = closure10(v628, v665)
        let v670 : unit = (fun () -> v669 (); v668) ()
        let v673 : string = "hash_part"
        let v674 : string = $"{v673}"
        let v677 : unit = ()
        let v678 : (unit -> unit) = closure10(v628, v674)
        let v679 : unit = (fun () -> v678 (); v677) ()
        let v682 : string = $"{v647}"
        let v685 : unit = ()
        let v686 : (unit -> unit) = closure10(v628, v682)
        let v687 : unit = (fun () -> v686 (); v685) ()
        let v690 : string = $"{v1}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure10(v628, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = $"{v664}"
        let v701 : unit = ()
        let v702 : (unit -> unit) = closure10(v628, v698)
        let v703 : unit = (fun () -> v702 (); v701) ()
        let v706 : string = "combined_value"
        let v707 : string = $"{v706}"
        let v710 : unit = ()
        let v711 : (unit -> unit) = closure10(v628, v707)
        let v712 : unit = (fun () -> v711 (); v710) ()
        let v715 : string = $"{v647}"
        let v718 : unit = ()
        let v719 : (unit -> unit) = closure10(v628, v715)
        let v720 : unit = (fun () -> v719 (); v718) ()
        let v723 : string = $"{v2}"
        let v726 : unit = ()
        let v727 : (unit -> unit) = closure10(v628, v723)
        let v728 : unit = (fun () -> v727 (); v726) ()
        let v731 : string = " }"
        let v732 : string = $"{v731}"
        let v735 : unit = ()
        let v736 : (unit -> unit) = closure10(v628, v732)
        let v737 : unit = (fun () -> v736 (); v735) ()
        let v740 : string = v628.l0
        let v741 : (unit -> string) = closure11()
        let v742 : string = $"{v485} {v620} #{v626} %s{v741 ()} / {v740}"
        let v745 : char list = []
        let v746 : (char list -> (char [])) = List.toArray
        let v747 : (char []) = v746 v745
        let v750 : string = v742.TrimStart v747 
        let v768 : char list = []
        let v769 : char list = '/' :: v768 
        let v772 : char list = ' ' :: v769 
        let v775 : (char list -> (char [])) = List.toArray
        let v776 : (char []) = v775 v772
        let v779 : string = v750.TrimEnd v776 
        let v797 : (string -> unit) = closure12()
        let v798 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v799 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v779 v799 
        let _v798 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v800 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v779 v800 
        let _v798 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v801 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v779 v801 
        let _v798 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v797 v779
        let _v798 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v797 v779
        let _v798 = () 
        #endif
#else
        v797 v779
        let _v798 = () 
        #endif
        _v798 
        let v802 : (string -> unit) = v19.l0
        v802 v779
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
    let v812 : uint16 = v8 % 48128us
    let v813 : uint16 = v812 + 1024us
    v813
let v0 : (string -> string) = closure0()
let hash_text x = v0 x
let v1 : (string -> uint16) = closure1()
let hash_to_port x = v1 x
()
