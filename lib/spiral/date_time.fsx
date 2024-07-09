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
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures<$0>")>]
#endif
type regex_Captures<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureNames")>]
#endif
type regex_CaptureNames = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Match")>]
#endif
type regex_Match = class end
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
and [<Struct>] US2 =
    | US2_0
    | US2_1
    | US2_2
and [<Struct>] US3 =
    | US3_0 of f0_0 : US2
    | US3_1 of f1_0 : US2
    | US3_2 of f2_0 : US2
    | US3_3 of f3_0 : US2
    | US3_4 of f4_0 : US2
let rec method1 () : string =
    let v0 : string = "hh:mm"
    v0
and method2 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method3 () : string =
    let v0 : string = "hhmm"
    v0
and method0 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
    let v4 : bool = true
    let mutable _v4 : System.Guid option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v16 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v17 : System.DateTime = v16 v7
    let v24 : System.DateTimeKind = System.DateTimeKind.Local
    let v25 : System.DateTime = System.DateTime.SpecifyKind (v1, v24)
    let v28 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v29 : System.DateTime = v28 v25
    let v38 : (System.DateTime -> int64) = _.Ticks
    let v39 : int64 = v38 v29
    let v48 : (System.DateTime -> int64) = _.Ticks
    let v49 : int64 = v48 v17
    let v56 : int64 = v39 - v49
    let v57 : int64 = v56 / 10L
    let v58 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v59 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v57 v58 
    let v62 : US0 option = None
    let _v62 = ref v62 
    match v59 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v63 : chrono_DateTime<chrono_Utc> = x
    let v64 : US0 = US0_0(v63)
    v64 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v62.Value <- x
    let v65 : US0 option = _v62.Value 
    let v88 : US0 = US0_1
    let v89 : US0 = v65 |> Option.defaultValue v88 
    let v113 : US1 =
        match v89 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v97) -> (* Some *)
            let v98 : string = "$0.naive_utc()"
            let v99 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v97 v98 
            let v100 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v101 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v99 v100 
            let v102 : string = "%Y%m%d-%H%M-%S%f"
            let v103 : string = "r#\"" + v102 + "\"#"
            let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v103 
            let v105 : string = "$0.format($1).to_string()"
            let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v101, v104) v105 
            let v107 : string = "fable_library_rust::String_::fromString($0)"
            let v108 : string = Fable.Core.RustInterop.emitRustExpr v106 v107 
            let v109 : string = $"{v108.[0..17]}-{v108.[18..21]}-{v108.[22]}"
            US1_0(v109)
    let v117 : string =
        match v113 with
        | US1_1 -> (* None *)
            let v115 : string = ""
            v115
        | US1_0(v114) -> (* Some *)
            v114
    let v120 : bool = true
    let mutable _v120 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v121 : string = "0i64.into()"
    let v122 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v121 
    v122 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v125 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v125 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v134 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v134 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v143 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v143 
    #endif
#if FABLE_COMPILER_PYTHON
    let v152 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v152 
    #endif
#else
    let v159 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v159 
    #endif
    |> fun x -> _v120 <- Some x
    let v160 : System.TimeZoneInfo = match _v120 with Some x -> x | None -> failwith "base.run_target / _v120=None"
    let v177 : bool = true
    let mutable _v177 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v180 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v181 : System.TimeSpan = v180 ()
    v181 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v190 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v191 : System.TimeSpan = v190 ()
    v191 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v200 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v201 : System.TimeSpan = v200 ()
    v201 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v208 : US2 = US2_0
    let v209 : US3 = US3_3(v208)
    let v210 : string = $"date_time.get_utc_offset / target: {v209}"
    let v211 : System.TimeSpan = failwith<System.TimeSpan> v210
    v211 
    #endif
#if FABLE_COMPILER_PYTHON
    let v212 : US2 = US2_0
    let v213 : US3 = US3_4(v212)
    let v214 : string = $"date_time.get_utc_offset / target: {v213}"
    let v215 : System.TimeSpan = failwith<System.TimeSpan> v214
    v215 
    #endif
#else
    let v216 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v219 : bool = true
    let mutable _v219 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v220 : string = "0i64.into()"
    let v221 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v220 
    v221 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v224 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v224 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v233 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v233 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v242 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v242 
    #endif
#if FABLE_COMPILER_PYTHON
    let v251 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v251 
    #endif
#else
    let v258 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v258 
    #endif
    |> fun x -> _v219 <- Some x
    let v259 : System.TimeZoneInfo = match _v219 with Some x -> x | None -> failwith "base.run_target / _v219=None"
    let v274 : (System.DateTime -> System.TimeSpan) = v216 v259
    let v275 : System.TimeSpan = v274 v29
    v275 
    #endif
    |> fun x -> _v177 <- Some x
    let v276 : System.TimeSpan = match _v177 with Some x -> x | None -> failwith "base.run_target / _v177=None"
    let v288 : (System.TimeSpan -> int32) = _.Hours
    let v289 : int32 = v288 v276
    let v296 : bool = v289 > 0
    let v297 : uint8 =
        if v296 then
            1uy
        else
            0uy
    let v298 : string = method1()
    let v301 : bool = true
    let mutable _v301 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v302 : string = v276.ToString v298 
    v302 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v303 : string = v276.ToString v298 
    v303 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v304 : string = v276.ToString v298 
    v304 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v305 : string = v276.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v305 
    #endif
#if FABLE_COMPILER_PYTHON
    let v306 : string = v276.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v306 
    #endif
#else
    let v307 : string = v276.ToString v298 
    v307 
    #endif
    |> fun x -> _v301 <- Some x
    let v308 : string = match _v301 with Some x -> x | None -> failwith "base.run_target / _v301=None"
    let v315 : string = $"{v297}{v308.[0..1]}{v308.[3..4]}"
    let v318 : (System.Guid -> string) = _.ToString()
    let v319 : string = v318 v0
    let v326 : System.Guid = System.Guid $"{v117}{v315}{v319.[v117.Length + v315.Length..]}"
    v326 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v329 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v338 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v339 : System.DateTime = v338 v329
    let v346 : System.DateTimeKind = System.DateTimeKind.Local
    let v347 : System.DateTime = System.DateTime.SpecifyKind (v1, v346)
    let v350 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v351 : System.DateTime = v350 v347
    let v360 : (System.DateTime -> int64) = _.Ticks
    let v361 : int64 = v360 v351
    let v370 : (System.DateTime -> int64) = _.Ticks
    let v371 : int64 = v370 v339
    let v378 : int64 = v361 - v371
    let v379 : int64 = v378 / 10L
    let v380 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v381 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v379 v380 
    let v384 : US0 option = None
    let _v384 = ref v384 
    match v381 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v385 : chrono_DateTime<chrono_Utc> = x
    let v386 : US0 = US0_0(v385)
    v386 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v384.Value <- x
    let v387 : US0 option = _v384.Value 
    let v410 : US0 = US0_1
    let v411 : US0 = v387 |> Option.defaultValue v410 
    let v435 : US1 =
        match v411 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v419) -> (* Some *)
            let v420 : string = "$0.naive_utc()"
            let v421 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v419 v420 
            let v422 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v423 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v421 v422 
            let v424 : string = "%Y%m%d-%H%M-%S%f"
            let v425 : string = "r#\"" + v424 + "\"#"
            let v426 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v425 
            let v427 : string = "$0.format($1).to_string()"
            let v428 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v423, v426) v427 
            let v429 : string = "fable_library_rust::String_::fromString($0)"
            let v430 : string = Fable.Core.RustInterop.emitRustExpr v428 v429 
            let v431 : string = $"{v430.[0..17]}-{v430.[18..21]}-{v430.[22]}"
            US1_0(v431)
    let v439 : string =
        match v435 with
        | US1_1 -> (* None *)
            let v437 : string = ""
            v437
        | US1_0(v436) -> (* Some *)
            v436
    let v442 : bool = true
    let mutable _v442 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v443 : string = "0i64.into()"
    let v444 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v443 
    v444 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v447 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v447 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v456 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v456 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v465 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v465 
    #endif
#if FABLE_COMPILER_PYTHON
    let v474 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v474 
    #endif
#else
    let v481 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v481 
    #endif
    |> fun x -> _v442 <- Some x
    let v482 : System.TimeZoneInfo = match _v442 with Some x -> x | None -> failwith "base.run_target / _v442=None"
    let v499 : bool = true
    let mutable _v499 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v502 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v503 : System.TimeSpan = v502 ()
    v503 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v512 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v513 : System.TimeSpan = v512 ()
    v513 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v522 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v523 : System.TimeSpan = v522 ()
    v523 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v530 : US2 = US2_0
    let v531 : US3 = US3_3(v530)
    let v532 : string = $"date_time.get_utc_offset / target: {v531}"
    let v533 : System.TimeSpan = failwith<System.TimeSpan> v532
    v533 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 = US2_0
    let v535 : US3 = US3_4(v534)
    let v536 : string = $"date_time.get_utc_offset / target: {v535}"
    let v537 : System.TimeSpan = failwith<System.TimeSpan> v536
    v537 
    #endif
#else
    let v538 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v541 : bool = true
    let mutable _v541 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v542 : string = "0i64.into()"
    let v543 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v542 
    v543 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v546 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v546 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v555 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v555 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v564 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v564 
    #endif
#if FABLE_COMPILER_PYTHON
    let v573 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v573 
    #endif
#else
    let v580 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v580 
    #endif
    |> fun x -> _v541 <- Some x
    let v581 : System.TimeZoneInfo = match _v541 with Some x -> x | None -> failwith "base.run_target / _v541=None"
    let v596 : (System.DateTime -> System.TimeSpan) = v538 v581
    let v597 : System.TimeSpan = v596 v351
    v597 
    #endif
    |> fun x -> _v499 <- Some x
    let v598 : System.TimeSpan = match _v499 with Some x -> x | None -> failwith "base.run_target / _v499=None"
    let v610 : (System.TimeSpan -> int32) = _.Hours
    let v611 : int32 = v610 v598
    let v618 : bool = v611 > 0
    let v619 : uint8 =
        if v618 then
            1uy
        else
            0uy
    let v620 : string = method1()
    let v623 : bool = true
    let mutable _v623 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v624 : string = v598.ToString v620 
    v624 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v625 : string = v598.ToString v620 
    v625 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v626 : string = v598.ToString v620 
    v626 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v627 : string = v598.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v627 
    #endif
#if FABLE_COMPILER_PYTHON
    let v628 : string = v598.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v628 
    #endif
#else
    let v629 : string = v598.ToString v620 
    v629 
    #endif
    |> fun x -> _v623 <- Some x
    let v630 : string = match _v623 with Some x -> x | None -> failwith "base.run_target / _v623=None"
    let v637 : string = $"{v619}{v630.[0..1]}{v630.[3..4]}"
    let v640 : (System.Guid -> string) = _.ToString()
    let v641 : string = v640 v0
    let v648 : System.Guid = System.Guid $"{v439}{v637}{v641.[v439.Length + v637.Length..]}"
    v648 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v651 : System.Guid = null |> unbox<System.Guid>
    v651 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v658 : string = method2()
    let v661 : (string -> string) = v1.ToString
    let v662 : string = v661 v658
    let v671 : bool = true
    let mutable _v671 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v672 : string = "0i64.into()"
    let v673 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v672 
    v673 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v676 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v676 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v685 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v685 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v694 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v694 
    #endif
#if FABLE_COMPILER_PYTHON
    let v703 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v703 
    #endif
#else
    let v710 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v710 
    #endif
    |> fun x -> _v671 <- Some x
    let v711 : System.TimeZoneInfo = match _v671 with Some x -> x | None -> failwith "base.run_target / _v671=None"
    let v728 : bool = true
    let mutable _v728 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v731 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v732 : System.TimeSpan = v731 ()
    v732 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v741 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v742 : System.TimeSpan = v741 ()
    v742 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v751 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v752 : System.TimeSpan = v751 ()
    v752 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v759 : US2 = US2_0
    let v760 : US3 = US3_3(v759)
    let v761 : string = $"date_time.get_utc_offset / target: {v760}"
    let v762 : System.TimeSpan = failwith<System.TimeSpan> v761
    v762 
    #endif
#if FABLE_COMPILER_PYTHON
    let v763 : US2 = US2_0
    let v764 : US3 = US3_4(v763)
    let v765 : string = $"date_time.get_utc_offset / target: {v764}"
    let v766 : System.TimeSpan = failwith<System.TimeSpan> v765
    v766 
    #endif
#else
    let v767 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v770 : bool = true
    let mutable _v770 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v771 : string = "0i64.into()"
    let v772 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v771 
    v772 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v775 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v775 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v784 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v784 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v793 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v793 
    #endif
#if FABLE_COMPILER_PYTHON
    let v802 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v802 
    #endif
#else
    let v809 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v809 
    #endif
    |> fun x -> _v770 <- Some x
    let v810 : System.TimeZoneInfo = match _v770 with Some x -> x | None -> failwith "base.run_target / _v770=None"
    let v825 : (System.DateTime -> System.TimeSpan) = v767 v810
    let v826 : System.TimeSpan = v825 v1
    v826 
    #endif
    |> fun x -> _v728 <- Some x
    let v827 : System.TimeSpan = match _v728 with Some x -> x | None -> failwith "base.run_target / _v728=None"
    let v839 : (System.TimeSpan -> int32) = _.Hours
    let v840 : int32 = v839 v827
    let v847 : bool = v840 > 0
    let v848 : uint8 =
        if v847 then
            1uy
        else
            0uy
    let v849 : string = method3()
    let v852 : bool = true
    let mutable _v852 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v853 : string = v827.ToString v849 
    v853 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v854 : string = v827.ToString v849 
    v854 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v855 : string = v827.ToString v849 
    v855 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v856 : string = v827.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v856 
    #endif
#if FABLE_COMPILER_PYTHON
    let v857 : string = v827.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v857 
    #endif
#else
    let v858 : string = v827.ToString v849 
    v858 
    #endif
    |> fun x -> _v852 <- Some x
    let v859 : string = match _v852 with Some x -> x | None -> failwith "base.run_target / _v852=None"
    let v866 : string = $"{v848}{v859}"
    let v869 : (System.Guid -> string) = _.ToString()
    let v870 : string = v869 v0
    let v877 : System.Guid = System.Guid $"{v662}{v866}{v870.[v662.Length + v866.Length..]}"
    v877 
    #endif
#if FABLE_COMPILER_PYTHON
    let v878 : string = method2()
    let v881 : (string -> string) = v1.ToString
    let v882 : string = v881 v878
    let v891 : bool = true
    let mutable _v891 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v892 : string = "0i64.into()"
    let v893 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v892 
    v893 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v896 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v896 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v905 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v905 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v914 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v914 
    #endif
#if FABLE_COMPILER_PYTHON
    let v923 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v923 
    #endif
#else
    let v930 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v930 
    #endif
    |> fun x -> _v891 <- Some x
    let v931 : System.TimeZoneInfo = match _v891 with Some x -> x | None -> failwith "base.run_target / _v891=None"
    let v948 : bool = true
    let mutable _v948 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v951 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v952 : System.TimeSpan = v951 ()
    v952 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v961 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v962 : System.TimeSpan = v961 ()
    v962 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v971 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v972 : System.TimeSpan = v971 ()
    v972 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v979 : US2 = US2_0
    let v980 : US3 = US3_3(v979)
    let v981 : string = $"date_time.get_utc_offset / target: {v980}"
    let v982 : System.TimeSpan = failwith<System.TimeSpan> v981
    v982 
    #endif
#if FABLE_COMPILER_PYTHON
    let v983 : US2 = US2_0
    let v984 : US3 = US3_4(v983)
    let v985 : string = $"date_time.get_utc_offset / target: {v984}"
    let v986 : System.TimeSpan = failwith<System.TimeSpan> v985
    v986 
    #endif
#else
    let v987 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v990 : bool = true
    let mutable _v990 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v991 : string = "0i64.into()"
    let v992 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v991 
    v992 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v995 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v995 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1004 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1004 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1013 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1013 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1022 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1022 
    #endif
#else
    let v1029 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v1029 
    #endif
    |> fun x -> _v990 <- Some x
    let v1030 : System.TimeZoneInfo = match _v990 with Some x -> x | None -> failwith "base.run_target / _v990=None"
    let v1045 : (System.DateTime -> System.TimeSpan) = v987 v1030
    let v1046 : System.TimeSpan = v1045 v1
    v1046 
    #endif
    |> fun x -> _v948 <- Some x
    let v1047 : System.TimeSpan = match _v948 with Some x -> x | None -> failwith "base.run_target / _v948=None"
    let v1059 : (System.TimeSpan -> int32) = _.Hours
    let v1060 : int32 = v1059 v1047
    let v1067 : bool = v1060 > 0
    let v1068 : uint8 =
        if v1067 then
            1uy
        else
            0uy
    let v1069 : string = method3()
    let v1072 : bool = true
    let mutable _v1072 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1073 : string = v1047.ToString v1069 
    v1073 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1074 : string = v1047.ToString v1069 
    v1074 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1075 : string = v1047.ToString v1069 
    v1075 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1076 : string = v1047.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v1076 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1077 : string = v1047.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v1077 
    #endif
#else
    let v1078 : string = v1047.ToString v1069 
    v1078 
    #endif
    |> fun x -> _v1072 <- Some x
    let v1079 : string = match _v1072 with Some x -> x | None -> failwith "base.run_target / _v1072=None"
    let v1086 : string = $"{v1068}{v1079}"
    let v1089 : (System.Guid -> string) = _.ToString()
    let v1090 : string = v1089 v0
    let v1097 : System.Guid = System.Guid $"{v882}{v1086}{v1090.[v882.Length + v1086.Length..]}"
    v1097 
    #endif
#else
    let v1098 : string = method2()
    let v1101 : (string -> string) = v1.ToString
    let v1102 : string = v1101 v1098
    let v1111 : bool = true
    let mutable _v1111 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1112 : string = "0i64.into()"
    let v1113 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1112 
    v1113 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1116 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1125 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1125 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1134 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1134 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1143 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1143 
    #endif
#else
    let v1150 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v1150 
    #endif
    |> fun x -> _v1111 <- Some x
    let v1151 : System.TimeZoneInfo = match _v1111 with Some x -> x | None -> failwith "base.run_target / _v1111=None"
    let v1168 : bool = true
    let mutable _v1168 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1171 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v1172 : System.TimeSpan = v1171 ()
    v1172 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1181 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v1182 : System.TimeSpan = v1181 ()
    v1182 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1191 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v1192 : System.TimeSpan = v1191 ()
    v1192 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1199 : US2 = US2_0
    let v1200 : US3 = US3_3(v1199)
    let v1201 : string = $"date_time.get_utc_offset / target: {v1200}"
    let v1202 : System.TimeSpan = failwith<System.TimeSpan> v1201
    v1202 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1203 : US2 = US2_0
    let v1204 : US3 = US3_4(v1203)
    let v1205 : string = $"date_time.get_utc_offset / target: {v1204}"
    let v1206 : System.TimeSpan = failwith<System.TimeSpan> v1205
    v1206 
    #endif
#else
    let v1207 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1210 : bool = true
    let mutable _v1210 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1211 : string = "0i64.into()"
    let v1212 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1211 
    v1212 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1215 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1215 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1224 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1224 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1233 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1233 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1242 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1242 
    #endif
#else
    let v1249 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v1249 
    #endif
    |> fun x -> _v1210 <- Some x
    let v1250 : System.TimeZoneInfo = match _v1210 with Some x -> x | None -> failwith "base.run_target / _v1210=None"
    let v1265 : (System.DateTime -> System.TimeSpan) = v1207 v1250
    let v1266 : System.TimeSpan = v1265 v1
    v1266 
    #endif
    |> fun x -> _v1168 <- Some x
    let v1267 : System.TimeSpan = match _v1168 with Some x -> x | None -> failwith "base.run_target / _v1168=None"
    let v1279 : (System.TimeSpan -> int32) = _.Hours
    let v1280 : int32 = v1279 v1267
    let v1287 : bool = v1280 > 0
    let v1288 : uint8 =
        if v1287 then
            1uy
        else
            0uy
    let v1289 : string = method3()
    let v1292 : bool = true
    let mutable _v1292 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1293 : string = v1267.ToString v1289 
    v1293 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1294 : string = v1267.ToString v1289 
    v1294 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1295 : string = v1267.ToString v1289 
    v1295 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1296 : string = v1267.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v1296 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1297 : string = v1267.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v1297 
    #endif
#else
    let v1298 : string = v1267.ToString v1289 
    v1298 
    #endif
    |> fun x -> _v1292 <- Some x
    let v1299 : string = match _v1292 with Some x -> x | None -> failwith "base.run_target / _v1292=None"
    let v1306 : string = $"{v1288}{v1299}"
    let v1309 : (System.Guid -> string) = _.ToString()
    let v1310 : string = v1309 v0
    let v1317 : System.Guid = System.Guid $"{v1102}{v1306}{v1310.[v1102.Length + v1306.Length..]}"
    v1317 
    #endif
    |> fun x -> _v4 <- Some x
    let v1318 : System.Guid = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v1318
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
and method4 () : (string -> (string -> (string -> string))) =
    closure3()
and closure2 () (v0 : System.Guid) : System.DateTime =
    let v3 : (System.Guid -> string) = _.ToString()
    let v4 : string = v3 v0
    let v11 : (string -> (string -> (string -> string))) = method4()
    let v14 : bool = true
    let mutable _v14 : System.DateTime option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : System.DateTime = System.DateTime.Parse (v4.[..24] |> v11 "-" "")
    v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : System.DateTime = System.DateTime.Parse (v4.[..24] |> v11 "-" "")
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : System.DateTime = System.DateTime.Parse (v4.[..24] |> v11 "-" "")
    v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : System.DateTime = System.DateTime.Parse (v4.[..24] |> v11 "-" "")
    v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : System.DateTime = System.DateTime.ParseExact (v4.[..24] |> v11 "-" "", "yyyyMMddHHmmssfffffff", null)
    v19 
    #endif
#else
    let v20 : System.DateTime = System.DateTime.ParseExact (v4.[..24] |> v11 "-" "", "yyyyMMddHHmmssfffffff", null)
    v20 
    #endif
    |> fun x -> _v14 <- Some x
    let v21 : System.DateTime = match _v14 with Some x -> x | None -> failwith "base.run_target / _v14=None"
    v21
and closure7 (v0 : System.Guid) (v1 : int64) : System.Guid =
    let v4 : (System.Guid -> string) = _.ToString()
    let v5 : string = v4 v0
    let v14 : (int64 -> string) = _.ToString()
    let v15 : string = v14 v1
    let v24 : string = v15.PadLeft (18, '0')
    let v54 : System.Guid = System.Guid $"{v24.[0..7]}-{v24.[8..11]}-{v24.[12..15]}-{v24.[16..17]}{v5.[21..]}"
    v54
and closure6 () (v0 : System.Guid) : (int64 -> System.Guid) =
    closure7(v0)
and closure8 () (v0 : System.Guid) : int64 =
    let v3 : (System.Guid -> string) = _.ToString()
    let v4 : string = v3 v0
    let v11 : int64 = int64 $"{v4.[0..7]}{v4.[9..12]}{v4.[14..17]}{v4.[19..20]}"
    v11
and closure9 () (v0 : System.DateTime) : System.Guid =
    let v3 : (unit -> System.Guid) = System.Guid.NewGuid
    let v4 : System.Guid = v3 ()
    method0(v4, v0)
and closure10 () (v0 : int64) : System.Guid =
    let v3 : (unit -> System.Guid) = System.Guid.NewGuid
    let v4 : System.Guid = v3 ()
    let v13 : (System.Guid -> string) = _.ToString()
    let v14 : string = v13 v4
    let v23 : (int64 -> string) = _.ToString()
    let v24 : string = v23 v0
    let v33 : string = v24.PadLeft (18, '0')
    let v63 : System.Guid = System.Guid $"{v33.[0..7]}-{v33.[8..11]}-{v33.[12..15]}-{v33.[16..17]}{v14.[21..]}"
    v63
and closure12 (v0 : string) (v1 : System.DateTime) : string =
    let v4 : (string -> string) = v1.ToString
    v4 v0
and closure11 () (v0 : string) : (System.DateTime -> string) =
    closure12(v0)
and closure13 () (v0 : System.DateTime) : string =
    let v5 : (string -> string) = v0.ToString
    let v6 : string = "yyyy-MM-ddTHH-mm-ss.fff"
    v5 v6
let v30 : (System.Guid -> (System.DateTime -> System.Guid)) = closure0()
let date_time_guid_from_date_time x = v30 x
let v31 : (System.Guid -> System.DateTime) = closure2()
let date_time_from_guid x = v31 x
let v32 : (System.Guid -> (int64 -> System.Guid)) = closure6()
let timestamp_guid_from_timestamp x = v32 x
let v33 : (System.Guid -> int64) = closure8()
let timestamp_from_guid x = v33 x
let v34 : (System.DateTime -> System.Guid) = closure9()
let new_guid_from_date_time x = v34 x
let v35 : (int64 -> System.Guid) = closure10()
let new_guid_from_timestamp x = v35 x
let v36 : (string -> (System.DateTime -> string)) = closure11()
let format x = v36 x
let v37 : (System.DateTime -> string) = closure13()
let format_iso8601 x = v37 x
()
