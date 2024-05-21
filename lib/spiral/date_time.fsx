#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::any::Any")>]
#endif
type core_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type core_ops_Try<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>]
#endif
type Func0<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>]
#endif
type Func0<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>]
#endif
type Box<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>]
#endif
type Dyn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Send")>]
#endif
type Send<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>]
#endif
type Fn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>]
#endif
type FnUnit = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>]
#endif
type FnOnce<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0)")>]
#endif
type ActionFn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0, $1)")>]
#endif
type ActionFn2<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>]
#endif
type Impl<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 + $1")>]
#endif
type LifetimeJoin<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0")>]
#endif
type LifetimeRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>]
#endif
type MutCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>]
#endif
type std_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::borrow::Cow<$0>")>]
#endif
type std_borrow_Cow<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::cell::RefCell<$0>")>]
#endif
type std_cell_RefCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>]
#endif
type std_pin_Pin<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>]
#endif
type std_rc_Rc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Weak<$0>")>]
#endif
type std_rc_Weak<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>]
#endif
type std_collections_HashMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::BTreeMap<$0, $1>")>]
#endif
type std_collections_BTreeMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("base64::DecodeError")>]
#endif
type base64_DecodeError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("borsh::io::Error")>]
#endif
type borsh_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs::Encoding")>]
#endif
type encoding_rs_Encoding = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::JsString")>]
#endif
type js_sys_JsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>]
#endif
type serde_json_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>]
#endif
type serde_json_Value = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_wasm_bindgen::Error")>]
#endif
type serde_wasm_bindgen_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>]
#endif
type std_ffi_OsStr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>]
#endif
type std_ffi_OsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fmt::Display<$0>")>]
#endif
type std_fmt_Display<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>]
#endif
type std_str_Utf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::FromUtf8Error")>]
#endif
type std_string_FromUtf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::slice::Windows<$0>")>]
#endif
type std_slice_Windows<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures")>]
#endif
type regex_Captures = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::DateTime<$0>")>]
#endif
type chrono_DateTime<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Local")>]
#endif
type chrono_Local = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::NaiveDateTime")>]
#endif
type chrono_NaiveDateTime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Utc")>]
#endif
type chrono_Utc = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::time::Duration")>]
#endif
type std_time_Duration = class end
type [<Struct>] US0 =
    | US0_0 of f0_0 : chrono_DateTime<chrono_Utc>
    | US0_1
and [<Struct>] US1 =
    | US1_0 of f0_0 : string
    | US1_1
let rec method1 (v0 : chrono_DateTime<chrono_Utc>) : chrono_DateTime<chrono_Utc> =
    v0
and method2 (v0 : chrono_DateTime<chrono_Local>) : chrono_DateTime<chrono_Local> =
    v0
and method3 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method4 () : string =
    let v0 : string = "hhmm"
    v0
and method0 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
    let v2 : bool = true
    let mutable _v2 : System.Guid option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v4 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v5 : System.DateTime = v4 v3
    let v6 : System.DateTimeKind = System.DateTimeKind.Local
    let v7 : System.DateTime = System.DateTime.SpecifyKind (v1, v6)
    let v8 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v9 : System.DateTime = v8 v7
    let v10 : (System.DateTime -> int64) = _.Ticks
    let v11 : int64 = v10 v9
    let v12 : (System.DateTime -> int64) = _.Ticks
    let v13 : int64 = v12 v5
    let v14 : int64 = v11 - v13
    let v15 : int64 = v14 / 10L
    let v16 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v17 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : US0 option = None
    let _v18 = ref v18 
    match v17 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v19 : chrono_DateTime<chrono_Utc> = x
    let v20 : US0 = US0_0(v19)
    v20 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v18.Value <- x
    let v21 : US0 option = _v18.Value 
    let v22 : US0 = US0_1
    let v23 : US0 = v21 |> Option.defaultValue v22 
    let v42 : US1 =
        match v23 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v24) -> (* Some *)
            let v25 : chrono_DateTime<chrono_Utc> = method1(v24)
            let v26 : string = "v25.naive_utc()"
            let v27 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v26 
            let v28 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v27)"
            let v29 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v28 
            let v30 : string = "%Y%m%d-%H%M-%S%f"
            let v31 : string = "r#\"" + v30 + "\"#"
            let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
            let v33 : chrono_DateTime<chrono_Local> = method2(v29)
            let v34 : string = "v33.format(v32).to_string()"
            let v35 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v34 
            let v36 : string = "fable_library_rust::String_::fromString($0)"
            let v37 : string = Fable.Core.RustInterop.emitRustExpr v35 v36 
            let v38 : string = $"{v37.[0..17]}-{v37.[18..21]}-{v37.[22]}"
            US1_0(v38)
    let v46 : string =
        match v42 with
        | US1_1 -> (* None *)
            let v44 : string = ""
            v44
        | US1_0(v43) -> (* Some *)
            v43
    let v47 : bool = true
    let mutable _v47 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "0i64.into()"
    let v49 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v48 
    v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v51 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v52 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v52 
    #endif
#if FABLE_COMPILER_PYTHON
    let v53 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v53 
    #endif
#else
    let v54 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v54 
    #endif
    |> fun x -> _v47 <- Some x
    let v55 : System.TimeZoneInfo = match _v47 with Some x -> x | None -> failwith "base.run_target / _v47=None"
    let v56 : bool = true
    let mutable _v56 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v57 : System.TimeSpan = System.TimeSpan () 
    v57 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v58 : System.TimeSpan = System.TimeSpan () 
    v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : System.TimeSpan = System.TimeSpan () 
    v59 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v60 : System.TimeSpan = System.TimeSpan () 
    v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : System.TimeSpan = System.TimeSpan () 
    v61 
    #endif
#else
    let v62 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v63 : bool = true
    let mutable _v63 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v64 : string = "0i64.into()"
    let v65 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v64 
    v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v69 
    #endif
#else
    let v70 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v70 
    #endif
    |> fun x -> _v63 <- Some x
    let v71 : System.TimeZoneInfo = match _v63 with Some x -> x | None -> failwith "base.run_target / _v63=None"
    let v72 : (System.DateTime -> System.TimeSpan) = v62 v71
    let v73 : System.TimeSpan = v72 v9
    v73 
    #endif
    |> fun x -> _v56 <- Some x
    let v74 : System.TimeSpan = match _v56 with Some x -> x | None -> failwith "base.run_target / _v56=None"
    let v75 : (System.TimeSpan -> int32) = _.Hours
    let v76 : int32 = v75 v74
    let v77 : bool = v76 > 0
    let v78 : uint8 =
        if v77 then
            1uy
        else
            0uy
    let v79 : (string -> string) = v74.ToString
    let v80 : string = "hh:mm"
    let v81 : string = v79 v80
    let v82 : string = $"{v78}{v81.[0..1]}{v81.[3..4]}"
    let v83 : (System.Guid -> string) = _.ToString()
    let v84 : string = v83 v0
    let v85 : System.Guid = System.Guid $"{v46}{v82}{v84.[v46.Length + v82.Length..]}"
    v85 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v86 : System.Guid = null |> unbox<System.Guid>
    v86 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v87 : System.Guid = null |> unbox<System.Guid>
    v87 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v88 : System.Guid = null |> unbox<System.Guid>
    v88 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : System.Guid = null |> unbox<System.Guid>
    v89 
    #endif
#else
    let v90 : string = method3()
    let v91 : (string -> string) = v1.ToString
    let v92 : string = v91 v90
    let v93 : bool = true
    let mutable _v93 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v94 : string = "0i64.into()"
    let v95 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v94 
    v95 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v96 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v96 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v97 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v97 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v98 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v99 
    #endif
#else
    let v100 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v100 
    #endif
    |> fun x -> _v93 <- Some x
    let v101 : System.TimeZoneInfo = match _v93 with Some x -> x | None -> failwith "base.run_target / _v93=None"
    let v102 : bool = true
    let mutable _v102 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : System.TimeSpan = System.TimeSpan () 
    v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : System.TimeSpan = System.TimeSpan () 
    v104 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v105 : System.TimeSpan = System.TimeSpan () 
    v105 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : System.TimeSpan = System.TimeSpan () 
    v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : System.TimeSpan = System.TimeSpan () 
    v107 
    #endif
#else
    let v108 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v109 : bool = true
    let mutable _v109 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v110 : string = "0i64.into()"
    let v111 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v110 
    v111 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v112 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v112 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v113 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v113 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v114 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v114 
    #endif
#if FABLE_COMPILER_PYTHON
    let v115 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v115 
    #endif
#else
    let v116 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v116 
    #endif
    |> fun x -> _v109 <- Some x
    let v117 : System.TimeZoneInfo = match _v109 with Some x -> x | None -> failwith "base.run_target / _v109=None"
    let v118 : (System.DateTime -> System.TimeSpan) = v108 v117
    let v119 : System.TimeSpan = v118 v1
    v119 
    #endif
    |> fun x -> _v102 <- Some x
    let v120 : System.TimeSpan = match _v102 with Some x -> x | None -> failwith "base.run_target / _v102=None"
    let v121 : (System.TimeSpan -> int32) = _.Hours
    let v122 : int32 = v121 v120
    let v123 : bool = v122 > 0
    let v124 : (bool -> int32) = System.Convert.ToInt32
    let v125 : int32 = v124 v123
    let v126 : string = method4()
    let v127 : (string -> string) = v120.ToString
    let v128 : string = v127 v126
    let v129 : string = $"{v125}{v128}"
    let v130 : (System.Guid -> string) = _.ToString()
    let v131 : string = v130 v0
    let v132 : System.Guid = System.Guid $"{v92}{v129}{v131.[v92.Length + v129.Length..]}"
    v132 
    #endif
    |> fun x -> _v2 <- Some x
    let v133 : System.Guid = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v133
and closure1 (v0 : System.Guid) (v1 : System.DateTime) : System.Guid =
    method0(v0, v1)
and closure0 () (v0 : System.Guid) : (System.DateTime -> System.Guid) =
    closure1(v0)
and closure5 (v0 : string, v1 : string) (v2 : string) : string =
    let v3 : string = v2.Replace (v0, v1)
    v3
and closure4 (v0 : string) (v1 : string) : (string -> string) =
    closure5(v0, v1)
and closure3 () (v0 : string) : (string -> (string -> string)) =
    closure4(v0)
and method5 () : (string -> (string -> (string -> string))) =
    closure3()
and closure2 () (v0 : System.Guid) : System.DateTime =
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v3 : (string -> (string -> (string -> string))) = method5()
    let v4 : bool = true
    let mutable _v4 : System.DateTime option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v3 "-" "")
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v3 "-" "")
    v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v3 "-" "")
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v3 "-" "", "yyyyMMddHHmmssfffffff", null)
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v3 "-" "", "yyyyMMddHHmmssfffffff", null)
    v9 
    #endif
#else
    let v10 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v3 "-" "", "yyyyMMddHHmmssfffffff", null)
    v10 
    #endif
    |> fun x -> _v4 <- Some x
    let v11 : System.DateTime = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v11
and closure7 (v0 : System.Guid) (v1 : int64) : System.Guid =
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v0
    let v4 : (int64 -> string) = _.ToString()
    let v5 : string = v4 v1
    let v6 : string = v5.PadLeft (18, '0')
    let v7 : System.Guid = System.Guid $"{v6.[0..7]}-{v6.[8..11]}-{v6.[12..15]}-{v6.[16..17]}{v3.[21..]}"
    v7
and closure6 () (v0 : System.Guid) : (int64 -> System.Guid) =
    closure7(v0)
and closure8 () (v0 : System.Guid) : int64 =
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v3 : int64 = int64 $"{v2.[0..7]}{v2.[9..12]}{v2.[14..17]}{v2.[19..20]}"
    v3
and closure9 () (v0 : System.DateTime) : System.Guid =
    let v1 : (unit -> System.Guid) = System.Guid.NewGuid
    let v2 : System.Guid = v1 ()
    method0(v2, v0)
and closure10 () (v0 : int64) : System.Guid =
    let v1 : (unit -> System.Guid) = System.Guid.NewGuid
    let v2 : System.Guid = v1 ()
    let v3 : (System.Guid -> string) = _.ToString()
    let v4 : string = v3 v2
    let v5 : (int64 -> string) = _.ToString()
    let v6 : string = v5 v0
    let v7 : string = v6.PadLeft (18, '0')
    let v8 : System.Guid = System.Guid $"{v7.[0..7]}-{v7.[8..11]}-{v7.[12..15]}-{v7.[16..17]}{v4.[21..]}"
    v8
and closure12 (v0 : string) (v1 : System.DateTime) : string =
    let v2 : (string -> string) = v1.ToString
    v2 v0
and closure11 () (v0 : string) : (System.DateTime -> string) =
    closure12(v0)
and closure13 () (v0 : System.DateTime) : string =
    let v1 : (string -> string) = v0.ToString
    let v2 : string = "yyyy-MM-ddTHH-mm-ss.fff"
    v1 v2
let v0 : (System.Guid -> (System.DateTime -> System.Guid)) = closure0()
let date_time_guid_from_date_time x = v0 x
let v1 : (System.Guid -> System.DateTime) = closure2()
let date_time_from_guid x = v1 x
let v2 : (System.Guid -> (int64 -> System.Guid)) = closure6()
let timestamp_guid_from_timestamp x = v2 x
let v3 : (System.Guid -> int64) = closure8()
let timestamp_from_guid x = v3 x
let v4 : (System.DateTime -> System.Guid) = closure9()
let new_guid_from_date_time x = v4 x
let v5 : (int64 -> System.Guid) = closure10()
let new_guid_from_timestamp x = v5 x
let v6 : (string -> (System.DateTime -> string)) = closure11()
let format x = v6 x
let v7 : (System.DateTime -> string) = closure13()
let format_iso8601 x = v7 x
()
