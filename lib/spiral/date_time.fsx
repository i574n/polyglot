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
[<Fable.Core.Erase; Fable.Core.Emit("$0 + Send")>]
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
[<Fable.Core.Erase; Fable.Core.Emit("&'static $0")>]
#endif
type StaticRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>]
#endif
type MutCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>]
#endif
type std_any_Any = class end
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
let rec closure2 () (v0 : chrono_DateTime<chrono_Utc>) : US0 =
    US0_0(v0)
and method0 () : (chrono_DateTime<chrono_Utc> -> US0) =
    closure2()
and method1 (v0 : chrono_DateTime<chrono_Utc>) : chrono_DateTime<chrono_Utc> =
    v0
and method2 (v0 : chrono_DateTime<chrono_Local>) : chrono_DateTime<chrono_Local> =
    v0
and method3 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method4 () : string =
    let v0 : string = "hhmm"
    v0
and closure1 (v0 : System.Guid) (v1 : System.DateTime) : System.Guid =
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v0
    let v4 : struct (string * string) option = None
    let v5 : bool = true in let mutable _v4 = v4
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v7 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v8 : System.DateTime = v7 v6
    let v9 : System.DateTimeKind = System.DateTimeKind.Local
    let v10 : System.DateTime = System.DateTime.SpecifyKind (v1, v9)
    let v11 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v12 : System.DateTime = v11 v10
    let v13 : (System.DateTime -> int64) = _.Ticks
    let v14 : int64 = v13 v12
    let v15 : (System.DateTime -> int64) = _.Ticks
    let v16 : int64 = v15 v8
    let v17 : int64 = v14 - v16
    let v18 : int64 = v17 / 10L
    let v19 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v20 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : (chrono_DateTime<chrono_Utc> -> US0) = method0()
    let v22 : US0 = US0_1
    let v23 : US0 = v20 |> Option.map v21 |> Option.defaultValue v22 
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
    let v47 : System.TimeZoneInfo option = None
    let v48 : bool = true in let mutable _v47 = v47
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : string = "0i64.into()"
    let v50 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v49
    v50
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v51 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v51
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v52 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v52
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v53 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v53
#endif
    
#if FABLE_COMPILER_PYTHON
    let v54 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v54
#endif
    
#else
    let v55 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v55
#endif
    |> fun x -> _v47 <- Some x
    let v56 : System.TimeZoneInfo = _v47.Value
    let v57 : System.TimeSpan option = None
    let v58 : bool = true in let mutable _v57 = v57
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v59 : System.TimeSpan = System.TimeSpan () 
    v59
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v60 : System.TimeSpan = System.TimeSpan () 
    v60
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v61 : System.TimeSpan = System.TimeSpan () 
    v61
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : System.TimeSpan = System.TimeSpan () 
    v62
#endif
    
#if FABLE_COMPILER_PYTHON
    let v63 : System.TimeSpan = System.TimeSpan () 
    v63
#endif
    
#else
    let v64 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v65 : System.TimeZoneInfo option = None
    let v66 : bool = true in let mutable _v65 = v65
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "0i64.into()"
    let v68 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v67
    v68
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v69 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v69
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v70
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v71 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v71
#endif
    
#if FABLE_COMPILER_PYTHON
    let v72 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v72
#endif
    
#else
    let v73 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v73
#endif
    |> fun x -> _v65 <- Some x
    let v74 : System.TimeZoneInfo = _v65.Value
    let v75 : (System.DateTime -> System.TimeSpan) = v64 v74
    let v76 : System.TimeSpan = v75 v12
    v76
#endif
    |> fun x -> _v57 <- Some x
    let v77 : System.TimeSpan = _v57.Value
    let v78 : (System.TimeSpan -> int32) = _.Hours
    let v79 : int32 = v78 v77
    let v80 : bool = v79 > 0
    let v81 : uint8 =
        if v80 then
            1uy
        else
            0uy
    let v82 : (string -> string) = v77.ToString
    let v83 : string = "hh:mm"
    let v84 : string = v82 v83
    let v85 : string = $"{v81}{v84.[0..1]}{v84.[3..4]}"
    struct (v46, v85)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v86 : string, v87 : string) = null |> unbox<struct (string * string)>
    struct (v86, v87)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v88 : string, v89 : string) = null |> unbox<struct (string * string)>
    struct (v88, v89)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v90 : string, v91 : string) = null |> unbox<struct (string * string)>
    struct (v90, v91)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v92 : string, v93 : string) = null |> unbox<struct (string * string)>
    struct (v92, v93)
#endif
    
#else
    let v94 : string = method3()
    let v95 : (string -> string) = v1.ToString
    let v96 : string = v95 v94
    let v97 : System.TimeZoneInfo option = None
    let v98 : bool = true in let mutable _v97 = v97
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v99 : string = "0i64.into()"
    let v100 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v99
    v100
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v101 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v101
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v102 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v102
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v103
#endif
    
#if FABLE_COMPILER_PYTHON
    let v104 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v104
#endif
    
#else
    let v105 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v105
#endif
    |> fun x -> _v97 <- Some x
    let v106 : System.TimeZoneInfo = _v97.Value
    let v107 : System.TimeSpan option = None
    let v108 : bool = true in let mutable _v107 = v107
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v109 : System.TimeSpan = System.TimeSpan () 
    v109
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v110 : System.TimeSpan = System.TimeSpan () 
    v110
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : System.TimeSpan = System.TimeSpan () 
    v111
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : System.TimeSpan = System.TimeSpan () 
    v112
#endif
    
#if FABLE_COMPILER_PYTHON
    let v113 : System.TimeSpan = System.TimeSpan () 
    v113
#endif
    
#else
    let v114 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v115 : System.TimeZoneInfo option = None
    let v116 : bool = true in let mutable _v115 = v115
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v117 : string = "0i64.into()"
    let v118 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v117
    v118
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v119 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v119
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v120 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v120
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v121 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v121
#endif
    
#if FABLE_COMPILER_PYTHON
    let v122 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v122
#endif
    
#else
    let v123 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v123
#endif
    |> fun x -> _v115 <- Some x
    let v124 : System.TimeZoneInfo = _v115.Value
    let v125 : (System.DateTime -> System.TimeSpan) = v114 v124
    let v126 : System.TimeSpan = v125 v1
    v126
#endif
    |> fun x -> _v107 <- Some x
    let v127 : System.TimeSpan = _v107.Value
    let v128 : (System.TimeSpan -> int32) = _.Hours
    let v129 : int32 = v128 v127
    let v130 : bool = v129 > 0
    let v131 : (bool -> int32) = System.Convert.ToInt32
    let v132 : int32 = v131 v130
    let v133 : string = method4()
    let v134 : (string -> string) = v127.ToString
    let v135 : string = v134 v133
    let v136 : string = $"{v132}{v135}"
    struct (v96, v136)
#endif
    |> fun x -> _v4 <- Some x
    let struct (v137 : string, v138 : string) = _v4.Value
    let v139 : System.Guid = System.Guid $"{v137}{v138}{v3.[v137.Length + v138.Length..]}"
    v139
and closure0 () (v0 : System.Guid) : (System.DateTime -> System.Guid) =
    closure1(v0)
and closure6 (v0 : string, v1 : string) (v2 : string) : string =
    let v3 : string = v2.Replace (v0, v1)
    v3
and closure5 (v0 : string) (v1 : string) : (string -> string) =
    closure6(v0, v1)
and closure4 () (v0 : string) : (string -> (string -> string)) =
    closure5(v0)
and method5 () : (string -> (string -> (string -> string))) =
    closure4()
and closure3 () (v0 : System.Guid) : System.DateTime =
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v3 : (string -> (string -> (string -> string))) = method5()
    let v4 : System.DateTime option = None
    let v5 : bool = true in let mutable _v4 = v4
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v3 "-" "")
    v6
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v7 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v3 "-" "")
    v7
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v3 "-" "")
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v3 "-" "", "yyyyMMddHHmmssfffffff", null)
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v3 "-" "", "yyyyMMddHHmmssfffffff", null)
    v10
#endif
    
#else
    let v11 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v3 "-" "", "yyyyMMddHHmmssfffffff", null)
    v11
#endif
    |> fun x -> _v4 <- Some x
    let v12 : System.DateTime = _v4.Value
    v12
and closure8 (v0 : System.Guid) (v1 : int64) : System.Guid =
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v0
    let v4 : (int64 -> string) = _.ToString()
    let v5 : string = v4 v1
    let v6 : string = v5.PadLeft (18, '0')
    let v7 : System.Guid = System.Guid $"{v6.[0..7]}-{v6.[8..11]}-{v6.[12..15]}-{v6.[16..17]}{v3.[21..]}"
    v7
and closure7 () (v0 : System.Guid) : (int64 -> System.Guid) =
    closure8(v0)
and closure9 () (v0 : System.Guid) : int64 =
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v3 : int64 = int64 $"{v2.[0..7]}{v2.[9..12]}{v2.[14..17]}{v2.[19..20]}"
    v3
and closure10 () (v0 : System.DateTime) : System.Guid =
    let v1 : System.Guid = System.Guid.NewGuid ()
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : struct (string * string) option = None
    let v5 : bool = true in let mutable _v4 = v4
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v7 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v8 : System.DateTime = v7 v6
    let v9 : System.DateTimeKind = System.DateTimeKind.Local
    let v10 : System.DateTime = System.DateTime.SpecifyKind (v0, v9)
    let v11 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v12 : System.DateTime = v11 v10
    let v13 : (System.DateTime -> int64) = _.Ticks
    let v14 : int64 = v13 v12
    let v15 : (System.DateTime -> int64) = _.Ticks
    let v16 : int64 = v15 v8
    let v17 : int64 = v14 - v16
    let v18 : int64 = v17 / 10L
    let v19 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v20 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : (chrono_DateTime<chrono_Utc> -> US0) = method0()
    let v22 : US0 = US0_1
    let v23 : US0 = v20 |> Option.map v21 |> Option.defaultValue v22 
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
    let v47 : System.TimeZoneInfo option = None
    let v48 : bool = true in let mutable _v47 = v47
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : string = "0i64.into()"
    let v50 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v49
    v50
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v51 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v51
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v52 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v52
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v53 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v53
#endif
    
#if FABLE_COMPILER_PYTHON
    let v54 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v54
#endif
    
#else
    let v55 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v55
#endif
    |> fun x -> _v47 <- Some x
    let v56 : System.TimeZoneInfo = _v47.Value
    let v57 : System.TimeSpan option = None
    let v58 : bool = true in let mutable _v57 = v57
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v59 : System.TimeSpan = System.TimeSpan () 
    v59
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v60 : System.TimeSpan = System.TimeSpan () 
    v60
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v61 : System.TimeSpan = System.TimeSpan () 
    v61
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : System.TimeSpan = System.TimeSpan () 
    v62
#endif
    
#if FABLE_COMPILER_PYTHON
    let v63 : System.TimeSpan = System.TimeSpan () 
    v63
#endif
    
#else
    let v64 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v65 : System.TimeZoneInfo option = None
    let v66 : bool = true in let mutable _v65 = v65
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "0i64.into()"
    let v68 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v67
    v68
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v69 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v69
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v70
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v71 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v71
#endif
    
#if FABLE_COMPILER_PYTHON
    let v72 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v72
#endif
    
#else
    let v73 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v73
#endif
    |> fun x -> _v65 <- Some x
    let v74 : System.TimeZoneInfo = _v65.Value
    let v75 : (System.DateTime -> System.TimeSpan) = v64 v74
    let v76 : System.TimeSpan = v75 v12
    v76
#endif
    |> fun x -> _v57 <- Some x
    let v77 : System.TimeSpan = _v57.Value
    let v78 : (System.TimeSpan -> int32) = _.Hours
    let v79 : int32 = v78 v77
    let v80 : bool = v79 > 0
    let v81 : uint8 =
        if v80 then
            1uy
        else
            0uy
    let v82 : (string -> string) = v77.ToString
    let v83 : string = "hh:mm"
    let v84 : string = v82 v83
    let v85 : string = $"{v81}{v84.[0..1]}{v84.[3..4]}"
    struct (v46, v85)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v86 : string, v87 : string) = null |> unbox<struct (string * string)>
    struct (v86, v87)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v88 : string, v89 : string) = null |> unbox<struct (string * string)>
    struct (v88, v89)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v90 : string, v91 : string) = null |> unbox<struct (string * string)>
    struct (v90, v91)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v92 : string, v93 : string) = null |> unbox<struct (string * string)>
    struct (v92, v93)
#endif
    
#else
    let v94 : string = method3()
    let v95 : (string -> string) = v0.ToString
    let v96 : string = v95 v94
    let v97 : System.TimeZoneInfo option = None
    let v98 : bool = true in let mutable _v97 = v97
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v99 : string = "0i64.into()"
    let v100 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v99
    v100
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v101 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v101
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v102 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v102
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v103
#endif
    
#if FABLE_COMPILER_PYTHON
    let v104 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v104
#endif
    
#else
    let v105 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v105
#endif
    |> fun x -> _v97 <- Some x
    let v106 : System.TimeZoneInfo = _v97.Value
    let v107 : System.TimeSpan option = None
    let v108 : bool = true in let mutable _v107 = v107
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v109 : System.TimeSpan = System.TimeSpan () 
    v109
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v110 : System.TimeSpan = System.TimeSpan () 
    v110
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : System.TimeSpan = System.TimeSpan () 
    v111
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : System.TimeSpan = System.TimeSpan () 
    v112
#endif
    
#if FABLE_COMPILER_PYTHON
    let v113 : System.TimeSpan = System.TimeSpan () 
    v113
#endif
    
#else
    let v114 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v115 : System.TimeZoneInfo option = None
    let v116 : bool = true in let mutable _v115 = v115
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v117 : string = "0i64.into()"
    let v118 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v117
    v118
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v119 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v119
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v120 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v120
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v121 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v121
#endif
    
#if FABLE_COMPILER_PYTHON
    let v122 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v122
#endif
    
#else
    let v123 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v123
#endif
    |> fun x -> _v115 <- Some x
    let v124 : System.TimeZoneInfo = _v115.Value
    let v125 : (System.DateTime -> System.TimeSpan) = v114 v124
    let v126 : System.TimeSpan = v125 v0
    v126
#endif
    |> fun x -> _v107 <- Some x
    let v127 : System.TimeSpan = _v107.Value
    let v128 : (System.TimeSpan -> int32) = _.Hours
    let v129 : int32 = v128 v127
    let v130 : bool = v129 > 0
    let v131 : (bool -> int32) = System.Convert.ToInt32
    let v132 : int32 = v131 v130
    let v133 : string = method4()
    let v134 : (string -> string) = v127.ToString
    let v135 : string = v134 v133
    let v136 : string = $"{v132}{v135}"
    struct (v96, v136)
#endif
    |> fun x -> _v4 <- Some x
    let struct (v137 : string, v138 : string) = _v4.Value
    let v139 : System.Guid = System.Guid $"{v137}{v138}{v3.[v137.Length + v138.Length..]}"
    v139
and closure11 () (v0 : int64) : System.Guid =
    let v1 : System.Guid = System.Guid.NewGuid ()
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : (int64 -> string) = _.ToString()
    let v5 : string = v4 v0
    let v6 : string = v5.PadLeft (18, '0')
    let v7 : System.Guid = System.Guid $"{v6.[0..7]}-{v6.[8..11]}-{v6.[12..15]}-{v6.[16..17]}{v3.[21..]}"
    v7
and closure13 (v0 : string) (v1 : System.DateTime) : string =
    let v2 : (string -> string) = v1.ToString
    v2 v0
and closure12 () (v0 : string) : (System.DateTime -> string) =
    closure13(v0)
and closure14 () (v0 : System.DateTime) : string =
    let v1 : (string -> string) = v0.ToString
    let v2 : string = "yyyy-MM-ddTHH-mm-ss.fff"
    v1 v2
let v0 : (System.Guid -> (System.DateTime -> System.Guid)) = closure0()
let date_time_guid_from_date_time x = v0 x
let v1 : (System.Guid -> System.DateTime) = closure3()
let date_time_from_guid x = v1 x
let v2 : (System.Guid -> (int64 -> System.Guid)) = closure7()
let timestamp_guid_from_timestamp x = v2 x
let v3 : (System.Guid -> int64) = closure9()
let timestamp_from_guid x = v3 x
let v4 : (System.DateTime -> System.Guid) = closure10()
let new_guid_from_date_time x = v4 x
let v5 : (int64 -> System.Guid) = closure11()
let new_guid_from_timestamp x = v5 x
let v6 : (string -> (System.DateTime -> string)) = closure12()
let format x = v6 x
let v7 : (System.DateTime -> string) = closure14()
let format_iso8601 x = v7 x
()
