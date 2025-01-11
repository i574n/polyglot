#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::DateTime<$0>")>]
#endif
type chrono_DateTime<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::NaiveDateTime")>]
#endif
type chrono_NaiveDateTime = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Utc")>]
#endif
type chrono_Utc = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Local")>]
#endif
type chrono_Local = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
type Str = class end
#else
type Str = string
#endif

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
let rec closure2 () (v0 : chrono_DateTime<chrono_Utc>) : US0 =
    US0_0(v0)
and method1 () : (chrono_DateTime<chrono_Utc> -> US0) =
    closure2()
and method2 () : string =
    let v0 : string = "hh:mm"
    v0
and method3 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method4 () : string =
    let v0 : string = "hhmm"
    v0
and method0 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : System.DateTime = System.DateTime.UnixEpoch
    let v6 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v7 : System.DateTime = v6 v3
    let v10 : System.DateTimeKind = System.DateTimeKind.Local
    let v11 : System.DateTime = System.DateTime.SpecifyKind (v1, v10)
    let v14 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v15 : System.DateTime = v14 v11
    (* run_target_args'
    let v18 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : (System.DateTime -> int64) = _.Ticks
    let v20 : int64 = v19 v15
    let _run_target_args'_v18 = v20 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : (System.DateTime -> int64) = _.Ticks
    let v22 : int64 = v21 v15
    let _run_target_args'_v18 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : int64 = null |> unbox<int64>
    let _run_target_args'_v18 = v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : (System.DateTime -> int64) = _.Ticks
    let v27 : int64 = v26 v15
    let _run_target_args'_v18 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v28 : (System.DateTime -> int64) = _.Ticks
    let v29 : int64 = v28 v15
    let _run_target_args'_v18 = v29 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v30 : (System.DateTime -> int64) = _.Ticks
    let v31 : int64 = v30 v15
    let _run_target_args'_v18 = v31 
    #endif
#else
    let v32 : (System.DateTime -> int64) = _.Ticks
    let v33 : int64 = v32 v15
    let _run_target_args'_v18 = v33 
    #endif
    let v34 : int64 = _run_target_args'_v18 
    (* run_target_args'
    let v51 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : (System.DateTime -> int64) = _.Ticks
    let v53 : int64 = v52 v7
    let _run_target_args'_v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : (System.DateTime -> int64) = _.Ticks
    let v55 : int64 = v54 v7
    let _run_target_args'_v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : int64 = null |> unbox<int64>
    let _run_target_args'_v51 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v59 : (System.DateTime -> int64) = _.Ticks
    let v60 : int64 = v59 v7
    let _run_target_args'_v51 = v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : (System.DateTime -> int64) = _.Ticks
    let v62 : int64 = v61 v7
    let _run_target_args'_v51 = v62 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : (System.DateTime -> int64) = _.Ticks
    let v64 : int64 = v63 v7
    let _run_target_args'_v51 = v64 
    #endif
#else
    let v65 : (System.DateTime -> int64) = _.Ticks
    let v66 : int64 = v65 v7
    let _run_target_args'_v51 = v66 
    #endif
    let v67 : int64 = _run_target_args'_v51 
    let v84 : int64 = v34 |> int64 
    let v87 : int64 = v67 |> int64 
    let v90 : int64 = v84 - v87
    let v91 : int64 = v90 / 10L
    let v92 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v93 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let v94 : (chrono_DateTime<chrono_Utc> -> US0) = method1()
    let v95 : US0 option = v93 |> Option.map v94 
    let v106 : US0 = US0_1
    let v107 : US0 = v95 |> Option.defaultValue v106 
    let v127 : US1 =
        match v107 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v111) -> (* Some *)
            let v112 : string = "$0.naive_utc()"
            let v113 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v111 v112 
            let v114 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v115 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v113 v114 
            let v116 : string = "%Y%m%d-%H%M-%S%f"
            let v117 : string = "r#\"" + v116 + "\"#"
            let v118 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v117 
            let v119 : string = "$0.format($1).to_string()"
            let v120 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v115, v118) v119 
            let v121 : string = "fable_library_rust::String_::fromString($0)"
            let v122 : string = Fable.Core.RustInterop.emitRustExpr v120 v121 
            let v123 : string = $"{v122.[0..17]}-{v122.[18..21]}-{v122.[22]}"
            US1_0(v123)
    let v131 : string =
        match v127 with
        | US1_1 -> (* None *)
            let v129 : string = ""
            v129
        | US1_0(v128) -> (* Some *)
            v128
    (* run_target_args'
    let v132 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v133 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v134 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v133 
    let _run_target_args'_v132 = v134 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v135 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v132 = v135 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v138 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v132 = v138 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v141 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v132 = v141 
    #endif
#if FABLE_COMPILER_PYTHON
    let v144 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v132 = v144 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v147 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v132 = v147 
    #endif
#else
    let v148 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v132 = v148 
    #endif
    let v149 : System.TimeZoneInfo = _run_target_args'_v132 
    (* run_target_args'
    let v154 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v155 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v156 : (System.DateTime -> int64) = _.Ticks
    let v157 : int64 = v156 v15
    let _run_target_args'_v155 = v157 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v158 : (System.DateTime -> int64) = _.Ticks
    let v159 : int64 = v158 v15
    let _run_target_args'_v155 = v159 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v160 : int64 = null |> unbox<int64>
    let _run_target_args'_v155 = v160 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v163 : (System.DateTime -> int64) = _.Ticks
    let v164 : int64 = v163 v15
    let _run_target_args'_v155 = v164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v165 : (System.DateTime -> int64) = _.Ticks
    let v166 : int64 = v165 v15
    let _run_target_args'_v155 = v166 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v167 : (System.DateTime -> int64) = _.Ticks
    let v168 : int64 = v167 v15
    let _run_target_args'_v155 = v168 
    #endif
#else
    let v169 : (System.DateTime -> int64) = _.Ticks
    let v170 : int64 = v169 v15
    let _run_target_args'_v155 = v170 
    #endif
    let v171 : int64 = _run_target_args'_v155 
    let v188 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v189 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v15, v171) v188 
    let v190 : System.TimeSpan = v189 |> System.TimeSpan 
    let _run_target_args'_v154 = v190 
    #endif
#if FABLE_COMPILER_RUST && WASM
    (* run_target_args'
    let v193 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v194 : (System.DateTime -> int64) = _.Ticks
    let v195 : int64 = v194 v15
    let _run_target_args'_v193 = v195 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v196 : (System.DateTime -> int64) = _.Ticks
    let v197 : int64 = v196 v15
    let _run_target_args'_v193 = v197 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v198 : int64 = null |> unbox<int64>
    let _run_target_args'_v193 = v198 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v201 : (System.DateTime -> int64) = _.Ticks
    let v202 : int64 = v201 v15
    let _run_target_args'_v193 = v202 
    #endif
#if FABLE_COMPILER_PYTHON
    let v203 : (System.DateTime -> int64) = _.Ticks
    let v204 : int64 = v203 v15
    let _run_target_args'_v193 = v204 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v205 : (System.DateTime -> int64) = _.Ticks
    let v206 : int64 = v205 v15
    let _run_target_args'_v193 = v206 
    #endif
#else
    let v207 : (System.DateTime -> int64) = _.Ticks
    let v208 : int64 = v207 v15
    let _run_target_args'_v193 = v208 
    #endif
    let v209 : int64 = _run_target_args'_v193 
    let v226 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v227 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v15, v209) v226 
    let v228 : System.TimeSpan = v227 |> System.TimeSpan 
    let _run_target_args'_v154 = v228 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v231 : US2 = US2_2
    let v232 : US3 = US3_2(v231)
    let v233 : string = $"date_time.get_utc_offset / target: {v232}"
    let v234 : System.TimeSpan = failwith<System.TimeSpan> v233
    let _run_target_args'_v154 = v234 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v237 : US2 = US2_0
    let v238 : US3 = US3_3(v237)
    let v239 : string = $"date_time.get_utc_offset / target: {v238}"
    let v240 : System.TimeSpan = failwith<System.TimeSpan> v239
    let _run_target_args'_v154 = v240 
    #endif
#if FABLE_COMPILER_PYTHON
    let v243 : US2 = US2_0
    let v244 : US3 = US3_4(v243)
    let v245 : string = $"date_time.get_utc_offset / target: {v244}"
    let v246 : System.TimeSpan = failwith<System.TimeSpan> v245
    let _run_target_args'_v154 = v246 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v249 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v250 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v251 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v252 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v251 
    let _run_target_args'_v250 = v252 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v253 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v250 = v253 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v256 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v250 = v256 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v259 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v250 = v259 
    #endif
#if FABLE_COMPILER_PYTHON
    let v262 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v250 = v262 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v265 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v250 = v265 
    #endif
#else
    let v266 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v250 = v266 
    #endif
    let v267 : System.TimeZoneInfo = _run_target_args'_v250 
    let v272 : (System.DateTime -> System.TimeSpan) = v249 v267
    let v273 : System.TimeSpan = v272 v15
    let _run_target_args'_v154 = v273 
    #endif
#else
    let v274 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v275 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v276 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v277 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v276 
    let _run_target_args'_v275 = v277 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v278 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v275 = v278 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v281 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v275 = v281 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v284 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v275 = v284 
    #endif
#if FABLE_COMPILER_PYTHON
    let v287 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v275 = v287 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v290 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v275 = v290 
    #endif
#else
    let v291 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v275 = v291 
    #endif
    let v292 : System.TimeZoneInfo = _run_target_args'_v275 
    let v297 : (System.DateTime -> System.TimeSpan) = v274 v292
    let v298 : System.TimeSpan = v297 v15
    let _run_target_args'_v154 = v298 
    #endif
    let v299 : System.TimeSpan = _run_target_args'_v154 
    let v307 : (System.TimeSpan -> int32) = _.Hours
    let v308 : int32 = v307 v299
    let v311 : bool = v308 > 0
    let v312 : uint8 =
        if v311 then
            1uy
        else
            0uy
    let v313 : string = method2()
    (* run_target_args'
    let v314 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v315 : string = v299.ToString v313 
    let _run_target_args'_v314 = v315 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v318 : string = v299.ToString v313 
    let _run_target_args'_v314 = v318 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v321 : string = v299.ToString v313 
    let _run_target_args'_v314 = v321 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v324 : string = v299.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v314 = v324 
    #endif
#if FABLE_COMPILER_PYTHON
    let v325 : string = v299.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v314 = v325 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v326 : string = v299.ToString v313 
    let _run_target_args'_v314 = v326 
    #endif
#else
    let v329 : string = v299.ToString v313 
    let _run_target_args'_v314 = v329 
    #endif
    let v332 : string = _run_target_args'_v314 
    let v337 : string = $"{v312}{v332.[0..1]}{v332.[3..4]}"
    let v338 : (System.Guid -> string) = _.ToString()
    let v339 : string = v338 v0
    let v342 : int32 = v131.Length
    let v343 : int32 = v337.Length
    let v344 : int32 = v342 + v343
    let v345 : (string -> int32) = String.length
    let v346 : int32 = v345 v339
    let v349 : int32 = v344 |> int32 
    let v356 : int32 = v346 |> int32 
    let v363 : int32 = v356 - 1
    let v364 : string = v339.[int v349..int v363]
    let v368 : string = $"{v131}{v337}{v364}"
    (* run_target_args'
    let v369 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v370 : System.Guid = v368 |> System.Guid 
    let _run_target_args'_v369 = v370 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v373 : System.Guid = v368 |> System.Guid 
    let _run_target_args'_v369 = v373 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v376 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v369 = v376 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v379 : System.Guid = v368 |> System.Guid 
    let _run_target_args'_v369 = v379 
    #endif
#if FABLE_COMPILER_PYTHON
    let v382 : System.Guid = v368 |> System.Guid 
    let _run_target_args'_v369 = v382 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v385 : System.Guid = v368 |> System.Guid 
    let _run_target_args'_v369 = v385 
    #endif
#else
    let v388 : System.Guid = v368 |> System.Guid 
    let _run_target_args'_v369 = v388 
    #endif
    let v391 : System.Guid = _run_target_args'_v369 
    let _run_target_args'_v2 = v391 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v396 : System.DateTime = System.DateTime.UnixEpoch
    let v399 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v400 : System.DateTime = v399 v396
    let v403 : System.DateTimeKind = System.DateTimeKind.Local
    let v404 : System.DateTime = System.DateTime.SpecifyKind (v1, v403)
    let v407 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v408 : System.DateTime = v407 v404
    (* run_target_args'
    let v411 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v412 : (System.DateTime -> int64) = _.Ticks
    let v413 : int64 = v412 v408
    let _run_target_args'_v411 = v413 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v414 : (System.DateTime -> int64) = _.Ticks
    let v415 : int64 = v414 v408
    let _run_target_args'_v411 = v415 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v416 : int64 = null |> unbox<int64>
    let _run_target_args'_v411 = v416 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v419 : (System.DateTime -> int64) = _.Ticks
    let v420 : int64 = v419 v408
    let _run_target_args'_v411 = v420 
    #endif
#if FABLE_COMPILER_PYTHON
    let v421 : (System.DateTime -> int64) = _.Ticks
    let v422 : int64 = v421 v408
    let _run_target_args'_v411 = v422 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v423 : (System.DateTime -> int64) = _.Ticks
    let v424 : int64 = v423 v408
    let _run_target_args'_v411 = v424 
    #endif
#else
    let v425 : (System.DateTime -> int64) = _.Ticks
    let v426 : int64 = v425 v408
    let _run_target_args'_v411 = v426 
    #endif
    let v427 : int64 = _run_target_args'_v411 
    (* run_target_args'
    let v444 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v445 : (System.DateTime -> int64) = _.Ticks
    let v446 : int64 = v445 v400
    let _run_target_args'_v444 = v446 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v447 : (System.DateTime -> int64) = _.Ticks
    let v448 : int64 = v447 v400
    let _run_target_args'_v444 = v448 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v449 : int64 = null |> unbox<int64>
    let _run_target_args'_v444 = v449 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v452 : (System.DateTime -> int64) = _.Ticks
    let v453 : int64 = v452 v400
    let _run_target_args'_v444 = v453 
    #endif
#if FABLE_COMPILER_PYTHON
    let v454 : (System.DateTime -> int64) = _.Ticks
    let v455 : int64 = v454 v400
    let _run_target_args'_v444 = v455 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v456 : (System.DateTime -> int64) = _.Ticks
    let v457 : int64 = v456 v400
    let _run_target_args'_v444 = v457 
    #endif
#else
    let v458 : (System.DateTime -> int64) = _.Ticks
    let v459 : int64 = v458 v400
    let _run_target_args'_v444 = v459 
    #endif
    let v460 : int64 = _run_target_args'_v444 
    let v477 : int64 = v427 |> int64 
    let v480 : int64 = v460 |> int64 
    let v483 : int64 = v477 - v480
    let v484 : int64 = v483 / 10L
    let v485 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v486 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v484 v485 
    let v487 : (chrono_DateTime<chrono_Utc> -> US0) = method1()
    let v488 : US0 option = v486 |> Option.map v487 
    let v499 : US0 = US0_1
    let v500 : US0 = v488 |> Option.defaultValue v499 
    let v520 : US1 =
        match v500 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v504) -> (* Some *)
            let v505 : string = "$0.naive_utc()"
            let v506 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v504 v505 
            let v507 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v508 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v506 v507 
            let v509 : string = "%Y%m%d-%H%M-%S%f"
            let v510 : string = "r#\"" + v509 + "\"#"
            let v511 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v510 
            let v512 : string = "$0.format($1).to_string()"
            let v513 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v508, v511) v512 
            let v514 : string = "fable_library_rust::String_::fromString($0)"
            let v515 : string = Fable.Core.RustInterop.emitRustExpr v513 v514 
            let v516 : string = $"{v515.[0..17]}-{v515.[18..21]}-{v515.[22]}"
            US1_0(v516)
    let v524 : string =
        match v520 with
        | US1_1 -> (* None *)
            let v522 : string = ""
            v522
        | US1_0(v521) -> (* Some *)
            v521
    (* run_target_args'
    let v525 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v526 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v527 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v526 
    let _run_target_args'_v525 = v527 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v528 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v525 = v528 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v531 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v525 = v531 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v534 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v525 = v534 
    #endif
#if FABLE_COMPILER_PYTHON
    let v537 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v525 = v537 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v540 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v525 = v540 
    #endif
#else
    let v541 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v525 = v541 
    #endif
    let v542 : System.TimeZoneInfo = _run_target_args'_v525 
    (* run_target_args'
    let v547 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v548 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v549 : (System.DateTime -> int64) = _.Ticks
    let v550 : int64 = v549 v408
    let _run_target_args'_v548 = v550 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v551 : (System.DateTime -> int64) = _.Ticks
    let v552 : int64 = v551 v408
    let _run_target_args'_v548 = v552 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v553 : int64 = null |> unbox<int64>
    let _run_target_args'_v548 = v553 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v556 : (System.DateTime -> int64) = _.Ticks
    let v557 : int64 = v556 v408
    let _run_target_args'_v548 = v557 
    #endif
#if FABLE_COMPILER_PYTHON
    let v558 : (System.DateTime -> int64) = _.Ticks
    let v559 : int64 = v558 v408
    let _run_target_args'_v548 = v559 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v560 : (System.DateTime -> int64) = _.Ticks
    let v561 : int64 = v560 v408
    let _run_target_args'_v548 = v561 
    #endif
#else
    let v562 : (System.DateTime -> int64) = _.Ticks
    let v563 : int64 = v562 v408
    let _run_target_args'_v548 = v563 
    #endif
    let v564 : int64 = _run_target_args'_v548 
    let v581 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v582 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v408, v564) v581 
    let v583 : System.TimeSpan = v582 |> System.TimeSpan 
    let _run_target_args'_v547 = v583 
    #endif
#if FABLE_COMPILER_RUST && WASM
    (* run_target_args'
    let v586 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v587 : (System.DateTime -> int64) = _.Ticks
    let v588 : int64 = v587 v408
    let _run_target_args'_v586 = v588 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v589 : (System.DateTime -> int64) = _.Ticks
    let v590 : int64 = v589 v408
    let _run_target_args'_v586 = v590 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v591 : int64 = null |> unbox<int64>
    let _run_target_args'_v586 = v591 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v594 : (System.DateTime -> int64) = _.Ticks
    let v595 : int64 = v594 v408
    let _run_target_args'_v586 = v595 
    #endif
#if FABLE_COMPILER_PYTHON
    let v596 : (System.DateTime -> int64) = _.Ticks
    let v597 : int64 = v596 v408
    let _run_target_args'_v586 = v597 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v598 : (System.DateTime -> int64) = _.Ticks
    let v599 : int64 = v598 v408
    let _run_target_args'_v586 = v599 
    #endif
#else
    let v600 : (System.DateTime -> int64) = _.Ticks
    let v601 : int64 = v600 v408
    let _run_target_args'_v586 = v601 
    #endif
    let v602 : int64 = _run_target_args'_v586 
    let v619 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v620 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v408, v602) v619 
    let v621 : System.TimeSpan = v620 |> System.TimeSpan 
    let _run_target_args'_v547 = v621 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v624 : US2 = US2_2
    let v625 : US3 = US3_2(v624)
    let v626 : string = $"date_time.get_utc_offset / target: {v625}"
    let v627 : System.TimeSpan = failwith<System.TimeSpan> v626
    let _run_target_args'_v547 = v627 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v630 : US2 = US2_0
    let v631 : US3 = US3_3(v630)
    let v632 : string = $"date_time.get_utc_offset / target: {v631}"
    let v633 : System.TimeSpan = failwith<System.TimeSpan> v632
    let _run_target_args'_v547 = v633 
    #endif
#if FABLE_COMPILER_PYTHON
    let v636 : US2 = US2_0
    let v637 : US3 = US3_4(v636)
    let v638 : string = $"date_time.get_utc_offset / target: {v637}"
    let v639 : System.TimeSpan = failwith<System.TimeSpan> v638
    let _run_target_args'_v547 = v639 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v642 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v643 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v644 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v645 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v644 
    let _run_target_args'_v643 = v645 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v646 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v643 = v646 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v649 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v643 = v649 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v652 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v643 = v652 
    #endif
#if FABLE_COMPILER_PYTHON
    let v655 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v643 = v655 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v658 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v643 = v658 
    #endif
#else
    let v659 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v643 = v659 
    #endif
    let v660 : System.TimeZoneInfo = _run_target_args'_v643 
    let v665 : (System.DateTime -> System.TimeSpan) = v642 v660
    let v666 : System.TimeSpan = v665 v408
    let _run_target_args'_v547 = v666 
    #endif
#else
    let v667 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v668 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v669 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v670 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v669 
    let _run_target_args'_v668 = v670 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v671 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v668 = v671 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v674 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v668 = v674 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v677 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v668 = v677 
    #endif
#if FABLE_COMPILER_PYTHON
    let v680 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v668 = v680 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v683 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v668 = v683 
    #endif
#else
    let v684 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v668 = v684 
    #endif
    let v685 : System.TimeZoneInfo = _run_target_args'_v668 
    let v690 : (System.DateTime -> System.TimeSpan) = v667 v685
    let v691 : System.TimeSpan = v690 v408
    let _run_target_args'_v547 = v691 
    #endif
    let v692 : System.TimeSpan = _run_target_args'_v547 
    let v700 : (System.TimeSpan -> int32) = _.Hours
    let v701 : int32 = v700 v692
    let v704 : bool = v701 > 0
    let v705 : uint8 =
        if v704 then
            1uy
        else
            0uy
    let v706 : string = method2()
    (* run_target_args'
    let v707 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v708 : string = v692.ToString v706 
    let _run_target_args'_v707 = v708 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v711 : string = v692.ToString v706 
    let _run_target_args'_v707 = v711 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v714 : string = v692.ToString v706 
    let _run_target_args'_v707 = v714 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v717 : string = v692.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v707 = v717 
    #endif
#if FABLE_COMPILER_PYTHON
    let v718 : string = v692.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v707 = v718 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v719 : string = v692.ToString v706 
    let _run_target_args'_v707 = v719 
    #endif
#else
    let v722 : string = v692.ToString v706 
    let _run_target_args'_v707 = v722 
    #endif
    let v725 : string = _run_target_args'_v707 
    let v730 : string = $"{v705}{v725.[0..1]}{v725.[3..4]}"
    let v731 : (System.Guid -> string) = _.ToString()
    let v732 : string = v731 v0
    let v735 : int32 = v524.Length
    let v736 : int32 = v730.Length
    let v737 : int32 = v735 + v736
    let v738 : (string -> int32) = String.length
    let v739 : int32 = v738 v732
    let v742 : int32 = v737 |> int32 
    let v749 : int32 = v739 |> int32 
    let v756 : int32 = v749 - 1
    let v757 : string = v732.[int v742..int v756]
    let v761 : string = $"{v524}{v730}{v757}"
    (* run_target_args'
    let v762 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v763 : System.Guid = v761 |> System.Guid 
    let _run_target_args'_v762 = v763 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v766 : System.Guid = v761 |> System.Guid 
    let _run_target_args'_v762 = v766 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v769 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v762 = v769 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v772 : System.Guid = v761 |> System.Guid 
    let _run_target_args'_v762 = v772 
    #endif
#if FABLE_COMPILER_PYTHON
    let v775 : System.Guid = v761 |> System.Guid 
    let _run_target_args'_v762 = v775 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v778 : System.Guid = v761 |> System.Guid 
    let _run_target_args'_v762 = v778 
    #endif
#else
    let v781 : System.Guid = v761 |> System.Guid 
    let _run_target_args'_v762 = v781 
    #endif
    let v784 : System.Guid = _run_target_args'_v762 
    let _run_target_args'_v2 = v784 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v789 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v2 = v789 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v792 : string = method3()
    let v793 : bool = v792 = ""
    let v795 : string =
        if v793 then
            let v794 : string = "M-d-y hh:mm:ss tt"
            v794
        else
            v792
    let v796 : (string -> string) = v1.ToString
    let v797 : string = v796 v795
    (* run_target_args'
    let v811 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v812 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v813 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v812 
    let _run_target_args'_v811 = v813 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v814 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v811 = v814 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v817 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v811 = v817 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v820 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v811 = v820 
    #endif
#if FABLE_COMPILER_PYTHON
    let v823 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v811 = v823 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v826 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v811 = v826 
    #endif
#else
    let v827 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v811 = v827 
    #endif
    let v828 : System.TimeZoneInfo = _run_target_args'_v811 
    (* run_target_args'
    let v833 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v834 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v835 : (System.DateTime -> int64) = _.Ticks
    let v836 : int64 = v835 v1
    let _run_target_args'_v834 = v836 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v837 : (System.DateTime -> int64) = _.Ticks
    let v838 : int64 = v837 v1
    let _run_target_args'_v834 = v838 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v839 : int64 = null |> unbox<int64>
    let _run_target_args'_v834 = v839 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v842 : (System.DateTime -> int64) = _.Ticks
    let v843 : int64 = v842 v1
    let _run_target_args'_v834 = v843 
    #endif
#if FABLE_COMPILER_PYTHON
    let v844 : (System.DateTime -> int64) = _.Ticks
    let v845 : int64 = v844 v1
    let _run_target_args'_v834 = v845 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v846 : (System.DateTime -> int64) = _.Ticks
    let v847 : int64 = v846 v1
    let _run_target_args'_v834 = v847 
    #endif
#else
    let v848 : (System.DateTime -> int64) = _.Ticks
    let v849 : int64 = v848 v1
    let _run_target_args'_v834 = v849 
    #endif
    let v850 : int64 = _run_target_args'_v834 
    let v867 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v868 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v850) v867 
    let v869 : System.TimeSpan = v868 |> System.TimeSpan 
    let _run_target_args'_v833 = v869 
    #endif
#if FABLE_COMPILER_RUST && WASM
    (* run_target_args'
    let v872 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v873 : (System.DateTime -> int64) = _.Ticks
    let v874 : int64 = v873 v1
    let _run_target_args'_v872 = v874 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v875 : (System.DateTime -> int64) = _.Ticks
    let v876 : int64 = v875 v1
    let _run_target_args'_v872 = v876 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v877 : int64 = null |> unbox<int64>
    let _run_target_args'_v872 = v877 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v880 : (System.DateTime -> int64) = _.Ticks
    let v881 : int64 = v880 v1
    let _run_target_args'_v872 = v881 
    #endif
#if FABLE_COMPILER_PYTHON
    let v882 : (System.DateTime -> int64) = _.Ticks
    let v883 : int64 = v882 v1
    let _run_target_args'_v872 = v883 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v884 : (System.DateTime -> int64) = _.Ticks
    let v885 : int64 = v884 v1
    let _run_target_args'_v872 = v885 
    #endif
#else
    let v886 : (System.DateTime -> int64) = _.Ticks
    let v887 : int64 = v886 v1
    let _run_target_args'_v872 = v887 
    #endif
    let v888 : int64 = _run_target_args'_v872 
    let v905 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v906 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v888) v905 
    let v907 : System.TimeSpan = v906 |> System.TimeSpan 
    let _run_target_args'_v833 = v907 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v910 : US2 = US2_2
    let v911 : US3 = US3_2(v910)
    let v912 : string = $"date_time.get_utc_offset / target: {v911}"
    let v913 : System.TimeSpan = failwith<System.TimeSpan> v912
    let _run_target_args'_v833 = v913 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v916 : US2 = US2_0
    let v917 : US3 = US3_3(v916)
    let v918 : string = $"date_time.get_utc_offset / target: {v917}"
    let v919 : System.TimeSpan = failwith<System.TimeSpan> v918
    let _run_target_args'_v833 = v919 
    #endif
#if FABLE_COMPILER_PYTHON
    let v922 : US2 = US2_0
    let v923 : US3 = US3_4(v922)
    let v924 : string = $"date_time.get_utc_offset / target: {v923}"
    let v925 : System.TimeSpan = failwith<System.TimeSpan> v924
    let _run_target_args'_v833 = v925 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v928 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v929 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v930 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v931 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v930 
    let _run_target_args'_v929 = v931 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v932 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v929 = v932 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v935 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v929 = v935 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v938 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v929 = v938 
    #endif
#if FABLE_COMPILER_PYTHON
    let v941 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v929 = v941 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v944 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v929 = v944 
    #endif
#else
    let v945 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v929 = v945 
    #endif
    let v946 : System.TimeZoneInfo = _run_target_args'_v929 
    let v951 : (System.DateTime -> System.TimeSpan) = v928 v946
    let v952 : System.TimeSpan = v951 v1
    let _run_target_args'_v833 = v952 
    #endif
#else
    let v953 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v954 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v955 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v956 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v955 
    let _run_target_args'_v954 = v956 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v957 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v954 = v957 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v960 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v954 = v960 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v963 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v954 = v963 
    #endif
#if FABLE_COMPILER_PYTHON
    let v966 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v954 = v966 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v969 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v954 = v969 
    #endif
#else
    let v970 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v954 = v970 
    #endif
    let v971 : System.TimeZoneInfo = _run_target_args'_v954 
    let v976 : (System.DateTime -> System.TimeSpan) = v953 v971
    let v977 : System.TimeSpan = v976 v1
    let _run_target_args'_v833 = v977 
    #endif
    let v978 : System.TimeSpan = _run_target_args'_v833 
    let v986 : (System.TimeSpan -> int32) = _.Hours
    let v987 : int32 = v986 v978
    let v990 : bool = v987 > 0
    let v991 : uint8 =
        if v990 then
            1uy
        else
            0uy
    let v992 : string = method4()
    (* run_target_args'
    let v993 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v994 : string = v978.ToString v992 
    let _run_target_args'_v993 = v994 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v997 : string = v978.ToString v992 
    let _run_target_args'_v993 = v997 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1000 : string = v978.ToString v992 
    let _run_target_args'_v993 = v1000 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1003 : string = v978.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v993 = v1003 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1004 : string = v978.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v993 = v1004 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1005 : string = v978.ToString v992 
    let _run_target_args'_v993 = v1005 
    #endif
#else
    let v1008 : string = v978.ToString v992 
    let _run_target_args'_v993 = v1008 
    #endif
    let v1011 : string = _run_target_args'_v993 
    let v1016 : string = $"{v991}{v1011}"
    let v1017 : (System.Guid -> string) = _.ToString()
    let v1018 : string = v1017 v0
    let v1021 : int32 = v797.Length
    let v1022 : int32 = v1016.Length
    let v1023 : int32 = v1021 + v1022
    let v1024 : (string -> int32) = String.length
    let v1025 : int32 = v1024 v1018
    let v1028 : int32 = v1023 |> int32 
    let v1035 : int32 = v1025 |> int32 
    let v1042 : int32 = v1035 - 1
    let v1043 : string = v1018.[int v1028..int v1042]
    let v1047 : string = $"{v797}{v1016}{v1043}"
    (* run_target_args'
    let v1048 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1049 : System.Guid = v1047 |> System.Guid 
    let _run_target_args'_v1048 = v1049 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1052 : System.Guid = v1047 |> System.Guid 
    let _run_target_args'_v1048 = v1052 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1055 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v1048 = v1055 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1058 : System.Guid = v1047 |> System.Guid 
    let _run_target_args'_v1048 = v1058 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1061 : System.Guid = v1047 |> System.Guid 
    let _run_target_args'_v1048 = v1061 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1064 : System.Guid = v1047 |> System.Guid 
    let _run_target_args'_v1048 = v1064 
    #endif
#else
    let v1067 : System.Guid = v1047 |> System.Guid 
    let _run_target_args'_v1048 = v1067 
    #endif
    let v1070 : System.Guid = _run_target_args'_v1048 
    let _run_target_args'_v2 = v1070 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1075 : string = method3()
    let v1076 : bool = v1075 = ""
    let v1078 : string =
        if v1076 then
            let v1077 : string = "M-d-y hh:mm:ss tt"
            v1077
        else
            v1075
    let v1079 : (string -> string) = v1.ToString
    let v1080 : string = v1079 v1078
    (* run_target_args'
    let v1094 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1095 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1096 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1095 
    let _run_target_args'_v1094 = v1096 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1097 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1094 = v1097 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1100 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1094 = v1100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1103 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1094 = v1103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1106 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1094 = v1106 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1109 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1094 = v1109 
    #endif
#else
    let v1110 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1094 = v1110 
    #endif
    let v1111 : System.TimeZoneInfo = _run_target_args'_v1094 
    (* run_target_args'
    let v1116 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v1117 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1118 : (System.DateTime -> int64) = _.Ticks
    let v1119 : int64 = v1118 v1
    let _run_target_args'_v1117 = v1119 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1120 : (System.DateTime -> int64) = _.Ticks
    let v1121 : int64 = v1120 v1
    let _run_target_args'_v1117 = v1121 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1122 : int64 = null |> unbox<int64>
    let _run_target_args'_v1117 = v1122 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1125 : (System.DateTime -> int64) = _.Ticks
    let v1126 : int64 = v1125 v1
    let _run_target_args'_v1117 = v1126 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1127 : (System.DateTime -> int64) = _.Ticks
    let v1128 : int64 = v1127 v1
    let _run_target_args'_v1117 = v1128 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1129 : (System.DateTime -> int64) = _.Ticks
    let v1130 : int64 = v1129 v1
    let _run_target_args'_v1117 = v1130 
    #endif
#else
    let v1131 : (System.DateTime -> int64) = _.Ticks
    let v1132 : int64 = v1131 v1
    let _run_target_args'_v1117 = v1132 
    #endif
    let v1133 : int64 = _run_target_args'_v1117 
    let v1150 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1151 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1133) v1150 
    let v1152 : System.TimeSpan = v1151 |> System.TimeSpan 
    let _run_target_args'_v1116 = v1152 
    #endif
#if FABLE_COMPILER_RUST && WASM
    (* run_target_args'
    let v1155 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1156 : (System.DateTime -> int64) = _.Ticks
    let v1157 : int64 = v1156 v1
    let _run_target_args'_v1155 = v1157 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1158 : (System.DateTime -> int64) = _.Ticks
    let v1159 : int64 = v1158 v1
    let _run_target_args'_v1155 = v1159 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1160 : int64 = null |> unbox<int64>
    let _run_target_args'_v1155 = v1160 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1163 : (System.DateTime -> int64) = _.Ticks
    let v1164 : int64 = v1163 v1
    let _run_target_args'_v1155 = v1164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1165 : (System.DateTime -> int64) = _.Ticks
    let v1166 : int64 = v1165 v1
    let _run_target_args'_v1155 = v1166 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1167 : (System.DateTime -> int64) = _.Ticks
    let v1168 : int64 = v1167 v1
    let _run_target_args'_v1155 = v1168 
    #endif
#else
    let v1169 : (System.DateTime -> int64) = _.Ticks
    let v1170 : int64 = v1169 v1
    let _run_target_args'_v1155 = v1170 
    #endif
    let v1171 : int64 = _run_target_args'_v1155 
    let v1188 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1189 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1171) v1188 
    let v1190 : System.TimeSpan = v1189 |> System.TimeSpan 
    let _run_target_args'_v1116 = v1190 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1193 : US2 = US2_2
    let v1194 : US3 = US3_2(v1193)
    let v1195 : string = $"date_time.get_utc_offset / target: {v1194}"
    let v1196 : System.TimeSpan = failwith<System.TimeSpan> v1195
    let _run_target_args'_v1116 = v1196 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1199 : US2 = US2_0
    let v1200 : US3 = US3_3(v1199)
    let v1201 : string = $"date_time.get_utc_offset / target: {v1200}"
    let v1202 : System.TimeSpan = failwith<System.TimeSpan> v1201
    let _run_target_args'_v1116 = v1202 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1205 : US2 = US2_0
    let v1206 : US3 = US3_4(v1205)
    let v1207 : string = $"date_time.get_utc_offset / target: {v1206}"
    let v1208 : System.TimeSpan = failwith<System.TimeSpan> v1207
    let _run_target_args'_v1116 = v1208 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1211 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v1212 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1213 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1214 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1213 
    let _run_target_args'_v1212 = v1214 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1215 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1212 = v1215 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1218 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1212 = v1218 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1221 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1212 = v1221 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1224 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1212 = v1224 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1227 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1212 = v1227 
    #endif
#else
    let v1228 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1212 = v1228 
    #endif
    let v1229 : System.TimeZoneInfo = _run_target_args'_v1212 
    let v1234 : (System.DateTime -> System.TimeSpan) = v1211 v1229
    let v1235 : System.TimeSpan = v1234 v1
    let _run_target_args'_v1116 = v1235 
    #endif
#else
    let v1236 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v1237 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1238 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1239 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1238 
    let _run_target_args'_v1237 = v1239 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1240 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1237 = v1240 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1243 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1237 = v1243 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1246 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1237 = v1246 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1249 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1237 = v1249 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1252 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1237 = v1252 
    #endif
#else
    let v1253 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1237 = v1253 
    #endif
    let v1254 : System.TimeZoneInfo = _run_target_args'_v1237 
    let v1259 : (System.DateTime -> System.TimeSpan) = v1236 v1254
    let v1260 : System.TimeSpan = v1259 v1
    let _run_target_args'_v1116 = v1260 
    #endif
    let v1261 : System.TimeSpan = _run_target_args'_v1116 
    let v1269 : (System.TimeSpan -> int32) = _.Hours
    let v1270 : int32 = v1269 v1261
    let v1273 : bool = v1270 > 0
    let v1274 : uint8 =
        if v1273 then
            1uy
        else
            0uy
    let v1275 : string = method4()
    (* run_target_args'
    let v1276 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1277 : string = v1261.ToString v1275 
    let _run_target_args'_v1276 = v1277 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1280 : string = v1261.ToString v1275 
    let _run_target_args'_v1276 = v1280 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1283 : string = v1261.ToString v1275 
    let _run_target_args'_v1276 = v1283 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1286 : string = v1261.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v1276 = v1286 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1287 : string = v1261.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v1276 = v1287 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1288 : string = v1261.ToString v1275 
    let _run_target_args'_v1276 = v1288 
    #endif
#else
    let v1291 : string = v1261.ToString v1275 
    let _run_target_args'_v1276 = v1291 
    #endif
    let v1294 : string = _run_target_args'_v1276 
    let v1299 : string = $"{v1274}{v1294}"
    let v1300 : (System.Guid -> string) = _.ToString()
    let v1301 : string = v1300 v0
    let v1304 : int32 = v1080.Length
    let v1305 : int32 = v1299.Length
    let v1306 : int32 = v1304 + v1305
    let v1307 : (string -> int32) = String.length
    let v1308 : int32 = v1307 v1301
    let v1311 : int32 = v1306 |> int32 
    let v1318 : int32 = v1308 |> int32 
    let v1325 : int32 = v1318 - 1
    let v1326 : string = v1301.[int v1311..int v1325]
    let v1330 : string = $"{v1080}{v1299}{v1326}"
    (* run_target_args'
    let v1331 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1332 : System.Guid = v1330 |> System.Guid 
    let _run_target_args'_v1331 = v1332 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1335 : System.Guid = v1330 |> System.Guid 
    let _run_target_args'_v1331 = v1335 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1338 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v1331 = v1338 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1341 : System.Guid = v1330 |> System.Guid 
    let _run_target_args'_v1331 = v1341 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1344 : System.Guid = v1330 |> System.Guid 
    let _run_target_args'_v1331 = v1344 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1347 : System.Guid = v1330 |> System.Guid 
    let _run_target_args'_v1331 = v1347 
    #endif
#else
    let v1350 : System.Guid = v1330 |> System.Guid 
    let _run_target_args'_v1331 = v1350 
    #endif
    let v1353 : System.Guid = _run_target_args'_v1331 
    let _run_target_args'_v2 = v1353 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1358 : string = method3()
    let v1359 : bool = v1358 = ""
    let v1361 : string =
        if v1359 then
            let v1360 : string = "M-d-y hh:mm:ss tt"
            v1360
        else
            v1358
    let v1362 : (string -> string) = v1.ToString
    let v1363 : string = v1362 v1361
    (* run_target_args'
    let v1377 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1378 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1379 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1378 
    let _run_target_args'_v1377 = v1379 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1380 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1377 = v1380 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1383 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1377 = v1383 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1386 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1377 = v1386 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1389 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1377 = v1389 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1392 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1377 = v1392 
    #endif
#else
    let v1393 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1377 = v1393 
    #endif
    let v1394 : System.TimeZoneInfo = _run_target_args'_v1377 
    (* run_target_args'
    let v1399 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v1400 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1401 : (System.DateTime -> int64) = _.Ticks
    let v1402 : int64 = v1401 v1
    let _run_target_args'_v1400 = v1402 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1403 : (System.DateTime -> int64) = _.Ticks
    let v1404 : int64 = v1403 v1
    let _run_target_args'_v1400 = v1404 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1405 : int64 = null |> unbox<int64>
    let _run_target_args'_v1400 = v1405 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1408 : (System.DateTime -> int64) = _.Ticks
    let v1409 : int64 = v1408 v1
    let _run_target_args'_v1400 = v1409 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1410 : (System.DateTime -> int64) = _.Ticks
    let v1411 : int64 = v1410 v1
    let _run_target_args'_v1400 = v1411 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1412 : (System.DateTime -> int64) = _.Ticks
    let v1413 : int64 = v1412 v1
    let _run_target_args'_v1400 = v1413 
    #endif
#else
    let v1414 : (System.DateTime -> int64) = _.Ticks
    let v1415 : int64 = v1414 v1
    let _run_target_args'_v1400 = v1415 
    #endif
    let v1416 : int64 = _run_target_args'_v1400 
    let v1433 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1434 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1416) v1433 
    let v1435 : System.TimeSpan = v1434 |> System.TimeSpan 
    let _run_target_args'_v1399 = v1435 
    #endif
#if FABLE_COMPILER_RUST && WASM
    (* run_target_args'
    let v1438 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1439 : (System.DateTime -> int64) = _.Ticks
    let v1440 : int64 = v1439 v1
    let _run_target_args'_v1438 = v1440 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1441 : (System.DateTime -> int64) = _.Ticks
    let v1442 : int64 = v1441 v1
    let _run_target_args'_v1438 = v1442 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1443 : int64 = null |> unbox<int64>
    let _run_target_args'_v1438 = v1443 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1446 : (System.DateTime -> int64) = _.Ticks
    let v1447 : int64 = v1446 v1
    let _run_target_args'_v1438 = v1447 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1448 : (System.DateTime -> int64) = _.Ticks
    let v1449 : int64 = v1448 v1
    let _run_target_args'_v1438 = v1449 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1450 : (System.DateTime -> int64) = _.Ticks
    let v1451 : int64 = v1450 v1
    let _run_target_args'_v1438 = v1451 
    #endif
#else
    let v1452 : (System.DateTime -> int64) = _.Ticks
    let v1453 : int64 = v1452 v1
    let _run_target_args'_v1438 = v1453 
    #endif
    let v1454 : int64 = _run_target_args'_v1438 
    let v1471 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1472 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1454) v1471 
    let v1473 : System.TimeSpan = v1472 |> System.TimeSpan 
    let _run_target_args'_v1399 = v1473 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1476 : US2 = US2_2
    let v1477 : US3 = US3_2(v1476)
    let v1478 : string = $"date_time.get_utc_offset / target: {v1477}"
    let v1479 : System.TimeSpan = failwith<System.TimeSpan> v1478
    let _run_target_args'_v1399 = v1479 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1482 : US2 = US2_0
    let v1483 : US3 = US3_3(v1482)
    let v1484 : string = $"date_time.get_utc_offset / target: {v1483}"
    let v1485 : System.TimeSpan = failwith<System.TimeSpan> v1484
    let _run_target_args'_v1399 = v1485 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1488 : US2 = US2_0
    let v1489 : US3 = US3_4(v1488)
    let v1490 : string = $"date_time.get_utc_offset / target: {v1489}"
    let v1491 : System.TimeSpan = failwith<System.TimeSpan> v1490
    let _run_target_args'_v1399 = v1491 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1494 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v1495 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1496 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1497 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1496 
    let _run_target_args'_v1495 = v1497 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1498 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1495 = v1498 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1501 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1495 = v1501 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1504 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1495 = v1504 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1507 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1495 = v1507 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1510 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1495 = v1510 
    #endif
#else
    let v1511 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1495 = v1511 
    #endif
    let v1512 : System.TimeZoneInfo = _run_target_args'_v1495 
    let v1517 : (System.DateTime -> System.TimeSpan) = v1494 v1512
    let v1518 : System.TimeSpan = v1517 v1
    let _run_target_args'_v1399 = v1518 
    #endif
#else
    let v1519 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v1520 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1521 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1522 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1521 
    let _run_target_args'_v1520 = v1522 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1523 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1520 = v1523 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1526 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1520 = v1526 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1529 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1520 = v1529 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1532 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1520 = v1532 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1535 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1520 = v1535 
    #endif
#else
    let v1536 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1520 = v1536 
    #endif
    let v1537 : System.TimeZoneInfo = _run_target_args'_v1520 
    let v1542 : (System.DateTime -> System.TimeSpan) = v1519 v1537
    let v1543 : System.TimeSpan = v1542 v1
    let _run_target_args'_v1399 = v1543 
    #endif
    let v1544 : System.TimeSpan = _run_target_args'_v1399 
    let v1552 : (System.TimeSpan -> int32) = _.Hours
    let v1553 : int32 = v1552 v1544
    let v1556 : bool = v1553 > 0
    let v1557 : uint8 =
        if v1556 then
            1uy
        else
            0uy
    let v1558 : string = method4()
    (* run_target_args'
    let v1559 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1560 : string = v1544.ToString v1558 
    let _run_target_args'_v1559 = v1560 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1563 : string = v1544.ToString v1558 
    let _run_target_args'_v1559 = v1563 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1566 : string = v1544.ToString v1558 
    let _run_target_args'_v1559 = v1566 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1569 : string = v1544.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v1559 = v1569 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1570 : string = v1544.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v1559 = v1570 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1571 : string = v1544.ToString v1558 
    let _run_target_args'_v1559 = v1571 
    #endif
#else
    let v1574 : string = v1544.ToString v1558 
    let _run_target_args'_v1559 = v1574 
    #endif
    let v1577 : string = _run_target_args'_v1559 
    let v1582 : string = $"{v1557}{v1577}"
    let v1583 : (System.Guid -> string) = _.ToString()
    let v1584 : string = v1583 v0
    let v1587 : int32 = v1363.Length
    let v1588 : int32 = v1582.Length
    let v1589 : int32 = v1587 + v1588
    let v1590 : (string -> int32) = String.length
    let v1591 : int32 = v1590 v1584
    let v1594 : int32 = v1589 |> int32 
    let v1601 : int32 = v1591 |> int32 
    let v1608 : int32 = v1601 - 1
    let v1609 : string = v1584.[int v1594..int v1608]
    let v1613 : string = $"{v1363}{v1582}{v1609}"
    (* run_target_args'
    let v1614 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1615 : System.Guid = v1613 |> System.Guid 
    let _run_target_args'_v1614 = v1615 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1618 : System.Guid = v1613 |> System.Guid 
    let _run_target_args'_v1614 = v1618 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1621 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v1614 = v1621 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1624 : System.Guid = v1613 |> System.Guid 
    let _run_target_args'_v1614 = v1624 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1627 : System.Guid = v1613 |> System.Guid 
    let _run_target_args'_v1614 = v1627 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1630 : System.Guid = v1613 |> System.Guid 
    let _run_target_args'_v1614 = v1630 
    #endif
#else
    let v1633 : System.Guid = v1613 |> System.Guid 
    let _run_target_args'_v1614 = v1633 
    #endif
    let v1636 : System.Guid = _run_target_args'_v1614 
    let _run_target_args'_v2 = v1636 
    #endif
#else
    let v1641 : string = method3()
    let v1642 : bool = v1641 = ""
    let v1644 : string =
        if v1642 then
            let v1643 : string = "M-d-y hh:mm:ss tt"
            v1643
        else
            v1641
    let v1645 : (string -> string) = v1.ToString
    let v1646 : string = v1645 v1644
    (* run_target_args'
    let v1660 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1661 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1662 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1661 
    let _run_target_args'_v1660 = v1662 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1663 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1660 = v1663 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1666 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1660 = v1666 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1669 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1660 = v1669 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1672 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1660 = v1672 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1675 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1660 = v1675 
    #endif
#else
    let v1676 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1660 = v1676 
    #endif
    let v1677 : System.TimeZoneInfo = _run_target_args'_v1660 
    (* run_target_args'
    let v1682 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v1683 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1684 : (System.DateTime -> int64) = _.Ticks
    let v1685 : int64 = v1684 v1
    let _run_target_args'_v1683 = v1685 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1686 : (System.DateTime -> int64) = _.Ticks
    let v1687 : int64 = v1686 v1
    let _run_target_args'_v1683 = v1687 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1688 : int64 = null |> unbox<int64>
    let _run_target_args'_v1683 = v1688 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1691 : (System.DateTime -> int64) = _.Ticks
    let v1692 : int64 = v1691 v1
    let _run_target_args'_v1683 = v1692 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1693 : (System.DateTime -> int64) = _.Ticks
    let v1694 : int64 = v1693 v1
    let _run_target_args'_v1683 = v1694 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1695 : (System.DateTime -> int64) = _.Ticks
    let v1696 : int64 = v1695 v1
    let _run_target_args'_v1683 = v1696 
    #endif
#else
    let v1697 : (System.DateTime -> int64) = _.Ticks
    let v1698 : int64 = v1697 v1
    let _run_target_args'_v1683 = v1698 
    #endif
    let v1699 : int64 = _run_target_args'_v1683 
    let v1716 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1717 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1699) v1716 
    let v1718 : System.TimeSpan = v1717 |> System.TimeSpan 
    let _run_target_args'_v1682 = v1718 
    #endif
#if FABLE_COMPILER_RUST && WASM
    (* run_target_args'
    let v1721 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1722 : (System.DateTime -> int64) = _.Ticks
    let v1723 : int64 = v1722 v1
    let _run_target_args'_v1721 = v1723 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1724 : (System.DateTime -> int64) = _.Ticks
    let v1725 : int64 = v1724 v1
    let _run_target_args'_v1721 = v1725 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1726 : int64 = null |> unbox<int64>
    let _run_target_args'_v1721 = v1726 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1729 : (System.DateTime -> int64) = _.Ticks
    let v1730 : int64 = v1729 v1
    let _run_target_args'_v1721 = v1730 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1731 : (System.DateTime -> int64) = _.Ticks
    let v1732 : int64 = v1731 v1
    let _run_target_args'_v1721 = v1732 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1733 : (System.DateTime -> int64) = _.Ticks
    let v1734 : int64 = v1733 v1
    let _run_target_args'_v1721 = v1734 
    #endif
#else
    let v1735 : (System.DateTime -> int64) = _.Ticks
    let v1736 : int64 = v1735 v1
    let _run_target_args'_v1721 = v1736 
    #endif
    let v1737 : int64 = _run_target_args'_v1721 
    let v1754 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1755 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1737) v1754 
    let v1756 : System.TimeSpan = v1755 |> System.TimeSpan 
    let _run_target_args'_v1682 = v1756 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1759 : US2 = US2_2
    let v1760 : US3 = US3_2(v1759)
    let v1761 : string = $"date_time.get_utc_offset / target: {v1760}"
    let v1762 : System.TimeSpan = failwith<System.TimeSpan> v1761
    let _run_target_args'_v1682 = v1762 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1765 : US2 = US2_0
    let v1766 : US3 = US3_3(v1765)
    let v1767 : string = $"date_time.get_utc_offset / target: {v1766}"
    let v1768 : System.TimeSpan = failwith<System.TimeSpan> v1767
    let _run_target_args'_v1682 = v1768 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1771 : US2 = US2_0
    let v1772 : US3 = US3_4(v1771)
    let v1773 : string = $"date_time.get_utc_offset / target: {v1772}"
    let v1774 : System.TimeSpan = failwith<System.TimeSpan> v1773
    let _run_target_args'_v1682 = v1774 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1777 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v1778 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1779 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1780 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1779 
    let _run_target_args'_v1778 = v1780 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1781 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1778 = v1781 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1784 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1778 = v1784 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1787 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1778 = v1787 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1790 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1778 = v1790 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1793 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1778 = v1793 
    #endif
#else
    let v1794 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1778 = v1794 
    #endif
    let v1795 : System.TimeZoneInfo = _run_target_args'_v1778 
    let v1800 : (System.DateTime -> System.TimeSpan) = v1777 v1795
    let v1801 : System.TimeSpan = v1800 v1
    let _run_target_args'_v1682 = v1801 
    #endif
#else
    let v1802 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    (* run_target_args'
    let v1803 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1804 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1805 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1804 
    let _run_target_args'_v1803 = v1805 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1806 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1803 = v1806 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1809 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1803 = v1809 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1812 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1803 = v1812 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1815 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _run_target_args'_v1803 = v1815 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1818 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1803 = v1818 
    #endif
#else
    let v1819 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _run_target_args'_v1803 = v1819 
    #endif
    let v1820 : System.TimeZoneInfo = _run_target_args'_v1803 
    let v1825 : (System.DateTime -> System.TimeSpan) = v1802 v1820
    let v1826 : System.TimeSpan = v1825 v1
    let _run_target_args'_v1682 = v1826 
    #endif
    let v1827 : System.TimeSpan = _run_target_args'_v1682 
    let v1835 : (System.TimeSpan -> int32) = _.Hours
    let v1836 : int32 = v1835 v1827
    let v1839 : bool = v1836 > 0
    let v1840 : uint8 =
        if v1839 then
            1uy
        else
            0uy
    let v1841 : string = method4()
    (* run_target_args'
    let v1842 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1843 : string = v1827.ToString v1841 
    let _run_target_args'_v1842 = v1843 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1846 : string = v1827.ToString v1841 
    let _run_target_args'_v1842 = v1846 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1849 : string = v1827.ToString v1841 
    let _run_target_args'_v1842 = v1849 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1852 : string = v1827.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v1842 = v1852 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1853 : string = v1827.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _run_target_args'_v1842 = v1853 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1854 : string = v1827.ToString v1841 
    let _run_target_args'_v1842 = v1854 
    #endif
#else
    let v1857 : string = v1827.ToString v1841 
    let _run_target_args'_v1842 = v1857 
    #endif
    let v1860 : string = _run_target_args'_v1842 
    let v1865 : string = $"{v1840}{v1860}"
    let v1866 : (System.Guid -> string) = _.ToString()
    let v1867 : string = v1866 v0
    let v1870 : int32 = v1646.Length
    let v1871 : int32 = v1865.Length
    let v1872 : int32 = v1870 + v1871
    let v1873 : (string -> int32) = String.length
    let v1874 : int32 = v1873 v1867
    let v1877 : int32 = v1872 |> int32 
    let v1884 : int32 = v1874 |> int32 
    let v1891 : int32 = v1884 - 1
    let v1892 : string = v1867.[int v1877..int v1891]
    let v1896 : string = $"{v1646}{v1865}{v1892}"
    (* run_target_args'
    let v1897 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1898 : System.Guid = v1896 |> System.Guid 
    let _run_target_args'_v1897 = v1898 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1901 : System.Guid = v1896 |> System.Guid 
    let _run_target_args'_v1897 = v1901 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1904 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v1897 = v1904 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1907 : System.Guid = v1896 |> System.Guid 
    let _run_target_args'_v1897 = v1907 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1910 : System.Guid = v1896 |> System.Guid 
    let _run_target_args'_v1897 = v1910 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1913 : System.Guid = v1896 |> System.Guid 
    let _run_target_args'_v1897 = v1913 
    #endif
#else
    let v1916 : System.Guid = v1896 |> System.Guid 
    let _run_target_args'_v1897 = v1916 
    #endif
    let v1919 : System.Guid = _run_target_args'_v1897 
    let _run_target_args'_v2 = v1919 
    #endif
    let v1924 : System.Guid = _run_target_args'_v2 
    v1924
and closure1 (v0 : System.Guid) (v1 : System.DateTime) : System.Guid =
    method0(v0, v1)
and closure0 () (v0 : System.Guid) : (System.DateTime -> System.Guid) =
    closure1(v0)
and closure4 () (v0 : string) : string =
    let v1 : string = "-"
    let v2 : string = ""
    let v3 : string = v0.Replace (v1, v2)
    v3
and closure3 () (v0 : System.Guid) : System.DateTime =
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v5 : (string -> string) = closure4()
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v5)
    let _run_target_args'_v6 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v5)
    let _run_target_args'_v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v5)
    let _run_target_args'_v6 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v5)
    let _run_target_args'_v6 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v5, "yyyyMMddHHmmssfffffff", null)
    let _run_target_args'_v6 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v5, "yyyyMMddHHmmssfffffff", null)
    let _run_target_args'_v6 = v12 
    #endif
#else
    let v13 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v5, "yyyyMMddHHmmssfffffff", null)
    let _run_target_args'_v6 = v13 
    #endif
    let v14 : System.DateTime = _run_target_args'_v6 
    v14
and closure7 (v0 : int32, v1 : string, v2 : int32) (v3 : string) : string =
    let v4 : bool = v2 >= v0
    if v4 then
        v3
    else
        let v5 : int32 = v2 + 1
        let v6 : (string -> string) = method5(v0, v1, v5)
        let v7 : string = v3 + v1 
        v6 v7
and method5 (v0 : int32, v1 : string, v2 : int32) : (string -> string) =
    closure7(v0, v1, v2)
and closure6 (v0 : System.Guid) (v1 : int64) : System.Guid =
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v0
    let v6 : (int64 -> string) = _.ToString()
    let v7 : string = v6 v1
    let v10 : (char -> string) = _.ToString()
    let v11 : string = v10 '0'
    let v14 : int32 = v7.Length
    let v15 : int32 = 18 - v14
    let v16 : int32 = 0
    let v17 : (string -> string) = method5(v15, v11, v16)
    let v18 : string = ""
    let v19 : string = v17 v18
    let v20 : string = v19 + v7 
    let v21 : System.Guid = System.Guid $"{v20.[0..7]}-{v20.[8..11]}-{v20.[12..15]}-{v20.[16..17]}{v3.[21..]}"
    v21
and closure5 () (v0 : System.Guid) : (int64 -> System.Guid) =
    closure6(v0)
and closure8 () (v0 : System.Guid) : int64 =
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v5 : int64 = int64 $"{v2.[0..7]}{v2.[9..12]}{v2.[14..17]}{v2.[19..20]}"
    v5
and closure9 () (v0 : System.DateTime) : System.Guid =
    let v1 : (unit -> System.Guid) = System.Guid.NewGuid
    let v2 : System.Guid = v1 ()
    method0(v2, v0)
and closure10 () (v0 : int64) : System.Guid =
    let v1 : (unit -> System.Guid) = System.Guid.NewGuid
    let v2 : System.Guid = v1 ()
    let v5 : (System.Guid -> string) = _.ToString()
    let v6 : string = v5 v2
    let v9 : (int64 -> string) = _.ToString()
    let v10 : string = v9 v0
    let v13 : (char -> string) = _.ToString()
    let v14 : string = v13 '0'
    let v17 : int32 = v10.Length
    let v18 : int32 = 18 - v17
    let v19 : int32 = 0
    let v20 : (string -> string) = method5(v18, v14, v19)
    let v21 : string = ""
    let v22 : string = v20 v21
    let v23 : string = v22 + v10 
    let v24 : System.Guid = System.Guid $"{v23.[0..7]}-{v23.[8..11]}-{v23.[12..15]}-{v23.[16..17]}{v6.[21..]}"
    v24
and closure12 (v0 : string) (v1 : System.DateTime) : string =
    let v2 : bool = v0 = ""
    let v4 : string =
        if v2 then
            let v3 : string = "M-d-y hh:mm:ss tt"
            v3
        else
            v0
    let v5 : (string -> string) = v1.ToString
    v5 v4
and closure11 () (v0 : string) : (System.DateTime -> string) =
    closure12(v0)
and closure13 () (v0 : System.DateTime) : string =
    let v1 : (string -> string) = v0.ToString
    let v2 : string = "yyyy-MM-ddTHH-mm-ss.fff"
    v1 v2
let v0 : (System.Guid -> (System.DateTime -> System.Guid)) = closure0()
let date_time_guid_from_date_time x = v0 x
let v1 : (System.Guid -> System.DateTime) = closure3()
let date_time_from_guid x = v1 x
let v2 : (System.Guid -> (int64 -> System.Guid)) = closure5()
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
