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
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : System.DateTime = System.DateTime.UnixEpoch
    let v6 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v7 : System.DateTime = v6 v3
    let v10 : System.DateTimeKind = System.DateTimeKind.Local
    let v11 : System.DateTime = System.DateTime.SpecifyKind (v1, v10)
    let v14 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v15 : System.DateTime = v14 v11
    let v18 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : (System.DateTime -> int64) = _.Ticks
    let v20 : int64 = v19 v15
    let _v18 = v20 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : (System.DateTime -> int64) = _.Ticks
    let v22 : int64 = v21 v15
    let _v18 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : int64 = null |> unbox<int64>
    let _v18 = v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : (System.DateTime -> int64) = _.Ticks
    let v27 : int64 = v26 v15
    let _v18 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v28 : (System.DateTime -> int64) = _.Ticks
    let v29 : int64 = v28 v15
    let _v18 = v29 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v30 : (System.DateTime -> int64) = _.Ticks
    let v31 : int64 = v30 v15
    let _v18 = v31 
    #endif
#else
    let v32 : (System.DateTime -> int64) = _.Ticks
    let v33 : int64 = v32 v15
    let _v18 = v33 
    #endif
    let v34 : int64 = _v18 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : (System.DateTime -> int64) = _.Ticks
    let v53 : int64 = v52 v7
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : (System.DateTime -> int64) = _.Ticks
    let v55 : int64 = v54 v7
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : int64 = null |> unbox<int64>
    let _v51 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v59 : (System.DateTime -> int64) = _.Ticks
    let v60 : int64 = v59 v7
    let _v51 = v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : (System.DateTime -> int64) = _.Ticks
    let v62 : int64 = v61 v7
    let _v51 = v62 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : (System.DateTime -> int64) = _.Ticks
    let v64 : int64 = v63 v7
    let _v51 = v64 
    #endif
#else
    let v65 : (System.DateTime -> int64) = _.Ticks
    let v66 : int64 = v65 v7
    let _v51 = v66 
    #endif
    let v67 : int64 = _v51 
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
    let v132 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v133 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v134 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v133 
    let _v132 = v134 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v135 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v132 = v135 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v138 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v132 = v138 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v141 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v132 = v141 
    #endif
#if FABLE_COMPILER_PYTHON
    let v144 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v132 = v144 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v147 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v132 = v147 
    #endif
#else
    let v148 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v132 = v148 
    #endif
    let v149 : System.TimeZoneInfo = _v132 
    let v154 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v155 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v156 : (System.DateTime -> int64) = _.Ticks
    let v157 : int64 = v156 v15
    let _v155 = v157 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v158 : (System.DateTime -> int64) = _.Ticks
    let v159 : int64 = v158 v15
    let _v155 = v159 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v160 : int64 = null |> unbox<int64>
    let _v155 = v160 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v163 : (System.DateTime -> int64) = _.Ticks
    let v164 : int64 = v163 v15
    let _v155 = v164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v165 : (System.DateTime -> int64) = _.Ticks
    let v166 : int64 = v165 v15
    let _v155 = v166 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v167 : (System.DateTime -> int64) = _.Ticks
    let v168 : int64 = v167 v15
    let _v155 = v168 
    #endif
#else
    let v169 : (System.DateTime -> int64) = _.Ticks
    let v170 : int64 = v169 v15
    let _v155 = v170 
    #endif
    let v171 : int64 = _v155 
    let v188 : string = "$0"
    let v189 : int64 = Fable.Core.RustInterop.emitRustExpr v171 v188 
    let v190 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v189))))"
    let v191 : int32 = Fable.Core.RustInterop.emitRustExpr v15 v190 
    let v192 : System.TimeSpan = v191 |> System.TimeSpan 
    let _v154 = v192 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v195 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v196 : (System.DateTime -> int64) = _.Ticks
    let v197 : int64 = v196 v15
    let _v195 = v197 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v198 : (System.DateTime -> int64) = _.Ticks
    let v199 : int64 = v198 v15
    let _v195 = v199 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v200 : int64 = null |> unbox<int64>
    let _v195 = v200 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v203 : (System.DateTime -> int64) = _.Ticks
    let v204 : int64 = v203 v15
    let _v195 = v204 
    #endif
#if FABLE_COMPILER_PYTHON
    let v205 : (System.DateTime -> int64) = _.Ticks
    let v206 : int64 = v205 v15
    let _v195 = v206 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v207 : (System.DateTime -> int64) = _.Ticks
    let v208 : int64 = v207 v15
    let _v195 = v208 
    #endif
#else
    let v209 : (System.DateTime -> int64) = _.Ticks
    let v210 : int64 = v209 v15
    let _v195 = v210 
    #endif
    let v211 : int64 = _v195 
    let v228 : string = "$0"
    let v229 : int64 = Fable.Core.RustInterop.emitRustExpr v211 v228 
    let v230 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v229))))"
    let v231 : int32 = Fable.Core.RustInterop.emitRustExpr v15 v230 
    let v232 : System.TimeSpan = v231 |> System.TimeSpan 
    let _v154 = v232 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v235 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v236 : (System.DateTime -> int64) = _.Ticks
    let v237 : int64 = v236 v15
    let _v235 = v237 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v238 : (System.DateTime -> int64) = _.Ticks
    let v239 : int64 = v238 v15
    let _v235 = v239 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v240 : int64 = null |> unbox<int64>
    let _v235 = v240 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v243 : (System.DateTime -> int64) = _.Ticks
    let v244 : int64 = v243 v15
    let _v235 = v244 
    #endif
#if FABLE_COMPILER_PYTHON
    let v245 : (System.DateTime -> int64) = _.Ticks
    let v246 : int64 = v245 v15
    let _v235 = v246 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v247 : (System.DateTime -> int64) = _.Ticks
    let v248 : int64 = v247 v15
    let _v235 = v248 
    #endif
#else
    let v249 : (System.DateTime -> int64) = _.Ticks
    let v250 : int64 = v249 v15
    let _v235 = v250 
    #endif
    let v251 : int64 = _v235 
    let v268 : string = "$0"
    let v269 : int64 = Fable.Core.RustInterop.emitRustExpr v251 v268 
    let v270 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v269))))"
    let v271 : int32 = Fable.Core.RustInterop.emitRustExpr v15 v270 
    let v272 : System.TimeSpan = v271 |> System.TimeSpan 
    let _v154 = v272 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v275 : US2 = US2_0
    let v276 : US3 = US3_3(v275)
    let v277 : string = $"date_time.get_utc_offset / target: {v276}"
    let v278 : System.TimeSpan = failwith<System.TimeSpan> v277
    let _v154 = v278 
    #endif
#if FABLE_COMPILER_PYTHON
    let v281 : US2 = US2_0
    let v282 : US3 = US3_4(v281)
    let v283 : string = $"date_time.get_utc_offset / target: {v282}"
    let v284 : System.TimeSpan = failwith<System.TimeSpan> v283
    let _v154 = v284 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v287 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v288 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v289 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v290 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v289 
    let _v288 = v290 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v291 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v288 = v291 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v294 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v288 = v294 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v297 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v288 = v297 
    #endif
#if FABLE_COMPILER_PYTHON
    let v300 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v288 = v300 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v303 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v288 = v303 
    #endif
#else
    let v304 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v288 = v304 
    #endif
    let v305 : System.TimeZoneInfo = _v288 
    let v310 : (System.DateTime -> System.TimeSpan) = v287 v305
    let v311 : System.TimeSpan = v310 v15
    let _v154 = v311 
    #endif
#else
    let v312 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v313 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v314 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v315 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v314 
    let _v313 = v315 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v316 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v313 = v316 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v319 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v313 = v319 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v322 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v313 = v322 
    #endif
#if FABLE_COMPILER_PYTHON
    let v325 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v313 = v325 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v328 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v313 = v328 
    #endif
#else
    let v329 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v313 = v329 
    #endif
    let v330 : System.TimeZoneInfo = _v313 
    let v335 : (System.DateTime -> System.TimeSpan) = v312 v330
    let v336 : System.TimeSpan = v335 v15
    let _v154 = v336 
    #endif
    let v337 : System.TimeSpan = _v154 
    let v345 : (System.TimeSpan -> int32) = _.Hours
    let v346 : int32 = v345 v337
    let v349 : bool = v346 > 0
    let v350 : uint8 =
        if v349 then
            1uy
        else
            0uy
    let v351 : string = method2()
    let v352 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v353 : string = v337.ToString v351 
    let _v352 = v353 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v356 : string = v337.ToString v351 
    let _v352 = v356 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v359 : string = v337.ToString v351 
    let _v352 = v359 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v362 : string = v337.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v352 = v362 
    #endif
#if FABLE_COMPILER_PYTHON
    let v363 : string = v337.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v352 = v363 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v364 : string = v337.ToString v351 
    let _v352 = v364 
    #endif
#else
    let v367 : string = v337.ToString v351 
    let _v352 = v367 
    #endif
    let v370 : string = _v352 
    let v375 : string = $"{v350}{v370.[0..1]}{v370.[3..4]}"
    let v376 : (System.Guid -> string) = _.ToString()
    let v377 : string = v376 v0
    let v380 : int32 = v131.Length
    let v381 : int32 = v375.Length
    let v382 : int32 = v380 + v381
    let v383 : (string -> int32) = String.length
    let v384 : int32 = v383 v377
    let v387 : int32 = v382 |> int32 
    let v394 : int32 = v384 |> int32 
    let v401 : int32 = v394 - 1
    let v402 : string = v377.[int v387..int v401]
    let v406 : string = $"{v131}{v375}{v402}"
    let v407 : System.Guid = v406 |> System.Guid 
    let _v2 = v407 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v410 : System.DateTime = System.DateTime.UnixEpoch
    let v413 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v414 : System.DateTime = v413 v410
    let v417 : System.DateTimeKind = System.DateTimeKind.Local
    let v418 : System.DateTime = System.DateTime.SpecifyKind (v1, v417)
    let v421 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v422 : System.DateTime = v421 v418
    let v425 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v426 : (System.DateTime -> int64) = _.Ticks
    let v427 : int64 = v426 v422
    let _v425 = v427 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v428 : (System.DateTime -> int64) = _.Ticks
    let v429 : int64 = v428 v422
    let _v425 = v429 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v430 : int64 = null |> unbox<int64>
    let _v425 = v430 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v433 : (System.DateTime -> int64) = _.Ticks
    let v434 : int64 = v433 v422
    let _v425 = v434 
    #endif
#if FABLE_COMPILER_PYTHON
    let v435 : (System.DateTime -> int64) = _.Ticks
    let v436 : int64 = v435 v422
    let _v425 = v436 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v437 : (System.DateTime -> int64) = _.Ticks
    let v438 : int64 = v437 v422
    let _v425 = v438 
    #endif
#else
    let v439 : (System.DateTime -> int64) = _.Ticks
    let v440 : int64 = v439 v422
    let _v425 = v440 
    #endif
    let v441 : int64 = _v425 
    let v458 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v459 : (System.DateTime -> int64) = _.Ticks
    let v460 : int64 = v459 v414
    let _v458 = v460 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v461 : (System.DateTime -> int64) = _.Ticks
    let v462 : int64 = v461 v414
    let _v458 = v462 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v463 : int64 = null |> unbox<int64>
    let _v458 = v463 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v466 : (System.DateTime -> int64) = _.Ticks
    let v467 : int64 = v466 v414
    let _v458 = v467 
    #endif
#if FABLE_COMPILER_PYTHON
    let v468 : (System.DateTime -> int64) = _.Ticks
    let v469 : int64 = v468 v414
    let _v458 = v469 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v470 : (System.DateTime -> int64) = _.Ticks
    let v471 : int64 = v470 v414
    let _v458 = v471 
    #endif
#else
    let v472 : (System.DateTime -> int64) = _.Ticks
    let v473 : int64 = v472 v414
    let _v458 = v473 
    #endif
    let v474 : int64 = _v458 
    let v491 : int64 = v441 |> int64 
    let v494 : int64 = v474 |> int64 
    let v497 : int64 = v491 - v494
    let v498 : int64 = v497 / 10L
    let v499 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v500 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v498 v499 
    let v501 : (chrono_DateTime<chrono_Utc> -> US0) = method1()
    let v502 : US0 option = v500 |> Option.map v501 
    let v513 : US0 = US0_1
    let v514 : US0 = v502 |> Option.defaultValue v513 
    let v534 : US1 =
        match v514 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v518) -> (* Some *)
            let v519 : string = "$0.naive_utc()"
            let v520 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v518 v519 
            let v521 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v522 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v520 v521 
            let v523 : string = "%Y%m%d-%H%M-%S%f"
            let v524 : string = "r#\"" + v523 + "\"#"
            let v525 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v524 
            let v526 : string = "$0.format($1).to_string()"
            let v527 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v522, v525) v526 
            let v528 : string = "fable_library_rust::String_::fromString($0)"
            let v529 : string = Fable.Core.RustInterop.emitRustExpr v527 v528 
            let v530 : string = $"{v529.[0..17]}-{v529.[18..21]}-{v529.[22]}"
            US1_0(v530)
    let v538 : string =
        match v534 with
        | US1_1 -> (* None *)
            let v536 : string = ""
            v536
        | US1_0(v535) -> (* Some *)
            v535
    let v539 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v540 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v541 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v540 
    let _v539 = v541 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v542 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v539 = v542 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v545 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v539 = v545 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v548 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v539 = v548 
    #endif
#if FABLE_COMPILER_PYTHON
    let v551 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v539 = v551 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v554 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v539 = v554 
    #endif
#else
    let v555 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v539 = v555 
    #endif
    let v556 : System.TimeZoneInfo = _v539 
    let v561 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v562 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v563 : (System.DateTime -> int64) = _.Ticks
    let v564 : int64 = v563 v422
    let _v562 = v564 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v565 : (System.DateTime -> int64) = _.Ticks
    let v566 : int64 = v565 v422
    let _v562 = v566 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v567 : int64 = null |> unbox<int64>
    let _v562 = v567 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v570 : (System.DateTime -> int64) = _.Ticks
    let v571 : int64 = v570 v422
    let _v562 = v571 
    #endif
#if FABLE_COMPILER_PYTHON
    let v572 : (System.DateTime -> int64) = _.Ticks
    let v573 : int64 = v572 v422
    let _v562 = v573 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v574 : (System.DateTime -> int64) = _.Ticks
    let v575 : int64 = v574 v422
    let _v562 = v575 
    #endif
#else
    let v576 : (System.DateTime -> int64) = _.Ticks
    let v577 : int64 = v576 v422
    let _v562 = v577 
    #endif
    let v578 : int64 = _v562 
    let v595 : string = "$0"
    let v596 : int64 = Fable.Core.RustInterop.emitRustExpr v578 v595 
    let v597 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v596))))"
    let v598 : int32 = Fable.Core.RustInterop.emitRustExpr v422 v597 
    let v599 : System.TimeSpan = v598 |> System.TimeSpan 
    let _v561 = v599 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v602 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v603 : (System.DateTime -> int64) = _.Ticks
    let v604 : int64 = v603 v422
    let _v602 = v604 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v605 : (System.DateTime -> int64) = _.Ticks
    let v606 : int64 = v605 v422
    let _v602 = v606 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v607 : int64 = null |> unbox<int64>
    let _v602 = v607 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v610 : (System.DateTime -> int64) = _.Ticks
    let v611 : int64 = v610 v422
    let _v602 = v611 
    #endif
#if FABLE_COMPILER_PYTHON
    let v612 : (System.DateTime -> int64) = _.Ticks
    let v613 : int64 = v612 v422
    let _v602 = v613 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v614 : (System.DateTime -> int64) = _.Ticks
    let v615 : int64 = v614 v422
    let _v602 = v615 
    #endif
#else
    let v616 : (System.DateTime -> int64) = _.Ticks
    let v617 : int64 = v616 v422
    let _v602 = v617 
    #endif
    let v618 : int64 = _v602 
    let v635 : string = "$0"
    let v636 : int64 = Fable.Core.RustInterop.emitRustExpr v618 v635 
    let v637 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v636))))"
    let v638 : int32 = Fable.Core.RustInterop.emitRustExpr v422 v637 
    let v639 : System.TimeSpan = v638 |> System.TimeSpan 
    let _v561 = v639 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v642 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v643 : (System.DateTime -> int64) = _.Ticks
    let v644 : int64 = v643 v422
    let _v642 = v644 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v645 : (System.DateTime -> int64) = _.Ticks
    let v646 : int64 = v645 v422
    let _v642 = v646 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v647 : int64 = null |> unbox<int64>
    let _v642 = v647 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v650 : (System.DateTime -> int64) = _.Ticks
    let v651 : int64 = v650 v422
    let _v642 = v651 
    #endif
#if FABLE_COMPILER_PYTHON
    let v652 : (System.DateTime -> int64) = _.Ticks
    let v653 : int64 = v652 v422
    let _v642 = v653 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v654 : (System.DateTime -> int64) = _.Ticks
    let v655 : int64 = v654 v422
    let _v642 = v655 
    #endif
#else
    let v656 : (System.DateTime -> int64) = _.Ticks
    let v657 : int64 = v656 v422
    let _v642 = v657 
    #endif
    let v658 : int64 = _v642 
    let v675 : string = "$0"
    let v676 : int64 = Fable.Core.RustInterop.emitRustExpr v658 v675 
    let v677 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v676))))"
    let v678 : int32 = Fable.Core.RustInterop.emitRustExpr v422 v677 
    let v679 : System.TimeSpan = v678 |> System.TimeSpan 
    let _v561 = v679 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v682 : US2 = US2_0
    let v683 : US3 = US3_3(v682)
    let v684 : string = $"date_time.get_utc_offset / target: {v683}"
    let v685 : System.TimeSpan = failwith<System.TimeSpan> v684
    let _v561 = v685 
    #endif
#if FABLE_COMPILER_PYTHON
    let v688 : US2 = US2_0
    let v689 : US3 = US3_4(v688)
    let v690 : string = $"date_time.get_utc_offset / target: {v689}"
    let v691 : System.TimeSpan = failwith<System.TimeSpan> v690
    let _v561 = v691 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v694 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v695 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v696 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v697 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v696 
    let _v695 = v697 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v698 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v695 = v698 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v701 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v695 = v701 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v704 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v695 = v704 
    #endif
#if FABLE_COMPILER_PYTHON
    let v707 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v695 = v707 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v710 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v695 = v710 
    #endif
#else
    let v711 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v695 = v711 
    #endif
    let v712 : System.TimeZoneInfo = _v695 
    let v717 : (System.DateTime -> System.TimeSpan) = v694 v712
    let v718 : System.TimeSpan = v717 v422
    let _v561 = v718 
    #endif
#else
    let v719 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v720 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v721 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v722 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v721 
    let _v720 = v722 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v723 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v720 = v723 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v726 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v720 = v726 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v729 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v720 = v729 
    #endif
#if FABLE_COMPILER_PYTHON
    let v732 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v720 = v732 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v735 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v720 = v735 
    #endif
#else
    let v736 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v720 = v736 
    #endif
    let v737 : System.TimeZoneInfo = _v720 
    let v742 : (System.DateTime -> System.TimeSpan) = v719 v737
    let v743 : System.TimeSpan = v742 v422
    let _v561 = v743 
    #endif
    let v744 : System.TimeSpan = _v561 
    let v752 : (System.TimeSpan -> int32) = _.Hours
    let v753 : int32 = v752 v744
    let v756 : bool = v753 > 0
    let v757 : uint8 =
        if v756 then
            1uy
        else
            0uy
    let v758 : string = method2()
    let v759 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v760 : string = v744.ToString v758 
    let _v759 = v760 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v763 : string = v744.ToString v758 
    let _v759 = v763 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v766 : string = v744.ToString v758 
    let _v759 = v766 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v769 : string = v744.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v759 = v769 
    #endif
#if FABLE_COMPILER_PYTHON
    let v770 : string = v744.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v759 = v770 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v771 : string = v744.ToString v758 
    let _v759 = v771 
    #endif
#else
    let v774 : string = v744.ToString v758 
    let _v759 = v774 
    #endif
    let v777 : string = _v759 
    let v782 : string = $"{v757}{v777.[0..1]}{v777.[3..4]}"
    let v783 : (System.Guid -> string) = _.ToString()
    let v784 : string = v783 v0
    let v787 : int32 = v538.Length
    let v788 : int32 = v782.Length
    let v789 : int32 = v787 + v788
    let v790 : (string -> int32) = String.length
    let v791 : int32 = v790 v784
    let v794 : int32 = v789 |> int32 
    let v801 : int32 = v791 |> int32 
    let v808 : int32 = v801 - 1
    let v809 : string = v784.[int v794..int v808]
    let v813 : string = $"{v538}{v782}{v809}"
    let v814 : System.Guid = v813 |> System.Guid 
    let _v2 = v814 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v817 : System.Guid = null |> unbox<System.Guid>
    let _v2 = v817 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v820 : string = method3()
    let v821 : bool = v820 = ""
    let v823 : string =
        if v821 then
            let v822 : string = "M-d-y hh:mm:ss tt"
            v822
        else
            v820
    let v824 : (string -> string) = v1.ToString
    let v825 : string = v824 v823
    let v839 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v840 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v841 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v840 
    let _v839 = v841 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v842 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v839 = v842 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v845 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v839 = v845 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v848 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v839 = v848 
    #endif
#if FABLE_COMPILER_PYTHON
    let v851 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v839 = v851 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v854 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v839 = v854 
    #endif
#else
    let v855 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v839 = v855 
    #endif
    let v856 : System.TimeZoneInfo = _v839 
    let v861 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v862 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v863 : (System.DateTime -> int64) = _.Ticks
    let v864 : int64 = v863 v1
    let _v862 = v864 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v865 : (System.DateTime -> int64) = _.Ticks
    let v866 : int64 = v865 v1
    let _v862 = v866 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v867 : int64 = null |> unbox<int64>
    let _v862 = v867 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v870 : (System.DateTime -> int64) = _.Ticks
    let v871 : int64 = v870 v1
    let _v862 = v871 
    #endif
#if FABLE_COMPILER_PYTHON
    let v872 : (System.DateTime -> int64) = _.Ticks
    let v873 : int64 = v872 v1
    let _v862 = v873 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v874 : (System.DateTime -> int64) = _.Ticks
    let v875 : int64 = v874 v1
    let _v862 = v875 
    #endif
#else
    let v876 : (System.DateTime -> int64) = _.Ticks
    let v877 : int64 = v876 v1
    let _v862 = v877 
    #endif
    let v878 : int64 = _v862 
    let v895 : string = "$0"
    let v896 : int64 = Fable.Core.RustInterop.emitRustExpr v878 v895 
    let v897 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v896))))"
    let v898 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v897 
    let v899 : System.TimeSpan = v898 |> System.TimeSpan 
    let _v861 = v899 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v902 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v903 : (System.DateTime -> int64) = _.Ticks
    let v904 : int64 = v903 v1
    let _v902 = v904 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v905 : (System.DateTime -> int64) = _.Ticks
    let v906 : int64 = v905 v1
    let _v902 = v906 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v907 : int64 = null |> unbox<int64>
    let _v902 = v907 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v910 : (System.DateTime -> int64) = _.Ticks
    let v911 : int64 = v910 v1
    let _v902 = v911 
    #endif
#if FABLE_COMPILER_PYTHON
    let v912 : (System.DateTime -> int64) = _.Ticks
    let v913 : int64 = v912 v1
    let _v902 = v913 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v914 : (System.DateTime -> int64) = _.Ticks
    let v915 : int64 = v914 v1
    let _v902 = v915 
    #endif
#else
    let v916 : (System.DateTime -> int64) = _.Ticks
    let v917 : int64 = v916 v1
    let _v902 = v917 
    #endif
    let v918 : int64 = _v902 
    let v935 : string = "$0"
    let v936 : int64 = Fable.Core.RustInterop.emitRustExpr v918 v935 
    let v937 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v936))))"
    let v938 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v937 
    let v939 : System.TimeSpan = v938 |> System.TimeSpan 
    let _v861 = v939 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v942 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v943 : (System.DateTime -> int64) = _.Ticks
    let v944 : int64 = v943 v1
    let _v942 = v944 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v945 : (System.DateTime -> int64) = _.Ticks
    let v946 : int64 = v945 v1
    let _v942 = v946 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v947 : int64 = null |> unbox<int64>
    let _v942 = v947 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v950 : (System.DateTime -> int64) = _.Ticks
    let v951 : int64 = v950 v1
    let _v942 = v951 
    #endif
#if FABLE_COMPILER_PYTHON
    let v952 : (System.DateTime -> int64) = _.Ticks
    let v953 : int64 = v952 v1
    let _v942 = v953 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v954 : (System.DateTime -> int64) = _.Ticks
    let v955 : int64 = v954 v1
    let _v942 = v955 
    #endif
#else
    let v956 : (System.DateTime -> int64) = _.Ticks
    let v957 : int64 = v956 v1
    let _v942 = v957 
    #endif
    let v958 : int64 = _v942 
    let v975 : string = "$0"
    let v976 : int64 = Fable.Core.RustInterop.emitRustExpr v958 v975 
    let v977 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v976))))"
    let v978 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v977 
    let v979 : System.TimeSpan = v978 |> System.TimeSpan 
    let _v861 = v979 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v982 : US2 = US2_0
    let v983 : US3 = US3_3(v982)
    let v984 : string = $"date_time.get_utc_offset / target: {v983}"
    let v985 : System.TimeSpan = failwith<System.TimeSpan> v984
    let _v861 = v985 
    #endif
#if FABLE_COMPILER_PYTHON
    let v988 : US2 = US2_0
    let v989 : US3 = US3_4(v988)
    let v990 : string = $"date_time.get_utc_offset / target: {v989}"
    let v991 : System.TimeSpan = failwith<System.TimeSpan> v990
    let _v861 = v991 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v994 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v995 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v996 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v997 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v996 
    let _v995 = v997 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v998 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v995 = v998 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1001 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v995 = v1001 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1004 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v995 = v1004 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1007 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v995 = v1007 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1010 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v995 = v1010 
    #endif
#else
    let v1011 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v995 = v1011 
    #endif
    let v1012 : System.TimeZoneInfo = _v995 
    let v1017 : (System.DateTime -> System.TimeSpan) = v994 v1012
    let v1018 : System.TimeSpan = v1017 v1
    let _v861 = v1018 
    #endif
#else
    let v1019 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1020 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1021 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1022 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1021 
    let _v1020 = v1022 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1023 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1020 = v1023 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1026 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1020 = v1026 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1029 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1020 = v1029 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1032 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1020 = v1032 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1035 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1020 = v1035 
    #endif
#else
    let v1036 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1020 = v1036 
    #endif
    let v1037 : System.TimeZoneInfo = _v1020 
    let v1042 : (System.DateTime -> System.TimeSpan) = v1019 v1037
    let v1043 : System.TimeSpan = v1042 v1
    let _v861 = v1043 
    #endif
    let v1044 : System.TimeSpan = _v861 
    let v1052 : (System.TimeSpan -> int32) = _.Hours
    let v1053 : int32 = v1052 v1044
    let v1056 : bool = v1053 > 0
    let v1057 : uint8 =
        if v1056 then
            1uy
        else
            0uy
    let v1058 : string = method4()
    let v1059 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1060 : string = v1044.ToString v1058 
    let _v1059 = v1060 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1063 : string = v1044.ToString v1058 
    let _v1059 = v1063 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1066 : string = v1044.ToString v1058 
    let _v1059 = v1066 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1069 : string = v1044.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1059 = v1069 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1070 : string = v1044.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1059 = v1070 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1071 : string = v1044.ToString v1058 
    let _v1059 = v1071 
    #endif
#else
    let v1074 : string = v1044.ToString v1058 
    let _v1059 = v1074 
    #endif
    let v1077 : string = _v1059 
    let v1082 : string = $"{v1057}{v1077}"
    let v1083 : (System.Guid -> string) = _.ToString()
    let v1084 : string = v1083 v0
    let v1087 : int32 = v825.Length
    let v1088 : int32 = v1082.Length
    let v1089 : int32 = v1087 + v1088
    let v1090 : (string -> int32) = String.length
    let v1091 : int32 = v1090 v1084
    let v1094 : int32 = v1089 |> int32 
    let v1101 : int32 = v1091 |> int32 
    let v1108 : int32 = v1101 - 1
    let v1109 : string = v1084.[int v1094..int v1108]
    let v1113 : string = $"{v825}{v1082}{v1109}"
    let v1114 : System.Guid = v1113 |> System.Guid 
    let _v2 = v1114 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1117 : string = method3()
    let v1118 : bool = v1117 = ""
    let v1120 : string =
        if v1118 then
            let v1119 : string = "M-d-y hh:mm:ss tt"
            v1119
        else
            v1117
    let v1121 : (string -> string) = v1.ToString
    let v1122 : string = v1121 v1120
    let v1136 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1137 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1138 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1137 
    let _v1136 = v1138 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1139 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1136 = v1139 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1142 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1136 = v1142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1145 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1136 = v1145 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1148 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1136 = v1148 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1151 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1136 = v1151 
    #endif
#else
    let v1152 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1136 = v1152 
    #endif
    let v1153 : System.TimeZoneInfo = _v1136 
    let v1158 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1159 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1160 : (System.DateTime -> int64) = _.Ticks
    let v1161 : int64 = v1160 v1
    let _v1159 = v1161 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1162 : (System.DateTime -> int64) = _.Ticks
    let v1163 : int64 = v1162 v1
    let _v1159 = v1163 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1164 : int64 = null |> unbox<int64>
    let _v1159 = v1164 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1167 : (System.DateTime -> int64) = _.Ticks
    let v1168 : int64 = v1167 v1
    let _v1159 = v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1169 : (System.DateTime -> int64) = _.Ticks
    let v1170 : int64 = v1169 v1
    let _v1159 = v1170 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1171 : (System.DateTime -> int64) = _.Ticks
    let v1172 : int64 = v1171 v1
    let _v1159 = v1172 
    #endif
#else
    let v1173 : (System.DateTime -> int64) = _.Ticks
    let v1174 : int64 = v1173 v1
    let _v1159 = v1174 
    #endif
    let v1175 : int64 = _v1159 
    let v1192 : string = "$0"
    let v1193 : int64 = Fable.Core.RustInterop.emitRustExpr v1175 v1192 
    let v1194 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1193))))"
    let v1195 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1194 
    let v1196 : System.TimeSpan = v1195 |> System.TimeSpan 
    let _v1158 = v1196 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1199 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1200 : (System.DateTime -> int64) = _.Ticks
    let v1201 : int64 = v1200 v1
    let _v1199 = v1201 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1202 : (System.DateTime -> int64) = _.Ticks
    let v1203 : int64 = v1202 v1
    let _v1199 = v1203 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1204 : int64 = null |> unbox<int64>
    let _v1199 = v1204 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1207 : (System.DateTime -> int64) = _.Ticks
    let v1208 : int64 = v1207 v1
    let _v1199 = v1208 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1209 : (System.DateTime -> int64) = _.Ticks
    let v1210 : int64 = v1209 v1
    let _v1199 = v1210 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1211 : (System.DateTime -> int64) = _.Ticks
    let v1212 : int64 = v1211 v1
    let _v1199 = v1212 
    #endif
#else
    let v1213 : (System.DateTime -> int64) = _.Ticks
    let v1214 : int64 = v1213 v1
    let _v1199 = v1214 
    #endif
    let v1215 : int64 = _v1199 
    let v1232 : string = "$0"
    let v1233 : int64 = Fable.Core.RustInterop.emitRustExpr v1215 v1232 
    let v1234 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1233))))"
    let v1235 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1234 
    let v1236 : System.TimeSpan = v1235 |> System.TimeSpan 
    let _v1158 = v1236 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1239 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1240 : (System.DateTime -> int64) = _.Ticks
    let v1241 : int64 = v1240 v1
    let _v1239 = v1241 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1242 : (System.DateTime -> int64) = _.Ticks
    let v1243 : int64 = v1242 v1
    let _v1239 = v1243 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1244 : int64 = null |> unbox<int64>
    let _v1239 = v1244 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1247 : (System.DateTime -> int64) = _.Ticks
    let v1248 : int64 = v1247 v1
    let _v1239 = v1248 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1249 : (System.DateTime -> int64) = _.Ticks
    let v1250 : int64 = v1249 v1
    let _v1239 = v1250 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1251 : (System.DateTime -> int64) = _.Ticks
    let v1252 : int64 = v1251 v1
    let _v1239 = v1252 
    #endif
#else
    let v1253 : (System.DateTime -> int64) = _.Ticks
    let v1254 : int64 = v1253 v1
    let _v1239 = v1254 
    #endif
    let v1255 : int64 = _v1239 
    let v1272 : string = "$0"
    let v1273 : int64 = Fable.Core.RustInterop.emitRustExpr v1255 v1272 
    let v1274 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1273))))"
    let v1275 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1274 
    let v1276 : System.TimeSpan = v1275 |> System.TimeSpan 
    let _v1158 = v1276 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1279 : US2 = US2_0
    let v1280 : US3 = US3_3(v1279)
    let v1281 : string = $"date_time.get_utc_offset / target: {v1280}"
    let v1282 : System.TimeSpan = failwith<System.TimeSpan> v1281
    let _v1158 = v1282 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1285 : US2 = US2_0
    let v1286 : US3 = US3_4(v1285)
    let v1287 : string = $"date_time.get_utc_offset / target: {v1286}"
    let v1288 : System.TimeSpan = failwith<System.TimeSpan> v1287
    let _v1158 = v1288 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1291 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1292 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1293 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1294 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1293 
    let _v1292 = v1294 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1295 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1292 = v1295 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1298 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1292 = v1298 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1301 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1292 = v1301 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1304 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1292 = v1304 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1307 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1292 = v1307 
    #endif
#else
    let v1308 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1292 = v1308 
    #endif
    let v1309 : System.TimeZoneInfo = _v1292 
    let v1314 : (System.DateTime -> System.TimeSpan) = v1291 v1309
    let v1315 : System.TimeSpan = v1314 v1
    let _v1158 = v1315 
    #endif
#else
    let v1316 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1317 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1318 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1319 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1318 
    let _v1317 = v1319 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1320 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1317 = v1320 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1323 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1317 = v1323 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1326 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1317 = v1326 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1329 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1317 = v1329 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1332 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1317 = v1332 
    #endif
#else
    let v1333 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1317 = v1333 
    #endif
    let v1334 : System.TimeZoneInfo = _v1317 
    let v1339 : (System.DateTime -> System.TimeSpan) = v1316 v1334
    let v1340 : System.TimeSpan = v1339 v1
    let _v1158 = v1340 
    #endif
    let v1341 : System.TimeSpan = _v1158 
    let v1349 : (System.TimeSpan -> int32) = _.Hours
    let v1350 : int32 = v1349 v1341
    let v1353 : bool = v1350 > 0
    let v1354 : uint8 =
        if v1353 then
            1uy
        else
            0uy
    let v1355 : string = method4()
    let v1356 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1357 : string = v1341.ToString v1355 
    let _v1356 = v1357 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1360 : string = v1341.ToString v1355 
    let _v1356 = v1360 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1363 : string = v1341.ToString v1355 
    let _v1356 = v1363 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1366 : string = v1341.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1356 = v1366 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1367 : string = v1341.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1356 = v1367 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1368 : string = v1341.ToString v1355 
    let _v1356 = v1368 
    #endif
#else
    let v1371 : string = v1341.ToString v1355 
    let _v1356 = v1371 
    #endif
    let v1374 : string = _v1356 
    let v1379 : string = $"{v1354}{v1374}"
    let v1380 : (System.Guid -> string) = _.ToString()
    let v1381 : string = v1380 v0
    let v1384 : int32 = v1122.Length
    let v1385 : int32 = v1379.Length
    let v1386 : int32 = v1384 + v1385
    let v1387 : (string -> int32) = String.length
    let v1388 : int32 = v1387 v1381
    let v1391 : int32 = v1386 |> int32 
    let v1398 : int32 = v1388 |> int32 
    let v1405 : int32 = v1398 - 1
    let v1406 : string = v1381.[int v1391..int v1405]
    let v1410 : string = $"{v1122}{v1379}{v1406}"
    let v1411 : System.Guid = v1410 |> System.Guid 
    let _v2 = v1411 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1414 : string = method3()
    let v1415 : bool = v1414 = ""
    let v1417 : string =
        if v1415 then
            let v1416 : string = "M-d-y hh:mm:ss tt"
            v1416
        else
            v1414
    let v1418 : (string -> string) = v1.ToString
    let v1419 : string = v1418 v1417
    let v1433 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1434 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1435 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1434 
    let _v1433 = v1435 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1436 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1433 = v1436 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1439 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1433 = v1439 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1442 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1433 = v1442 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1445 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1433 = v1445 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1448 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1433 = v1448 
    #endif
#else
    let v1449 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1433 = v1449 
    #endif
    let v1450 : System.TimeZoneInfo = _v1433 
    let v1455 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1456 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1457 : (System.DateTime -> int64) = _.Ticks
    let v1458 : int64 = v1457 v1
    let _v1456 = v1458 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1459 : (System.DateTime -> int64) = _.Ticks
    let v1460 : int64 = v1459 v1
    let _v1456 = v1460 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1461 : int64 = null |> unbox<int64>
    let _v1456 = v1461 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1464 : (System.DateTime -> int64) = _.Ticks
    let v1465 : int64 = v1464 v1
    let _v1456 = v1465 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1466 : (System.DateTime -> int64) = _.Ticks
    let v1467 : int64 = v1466 v1
    let _v1456 = v1467 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1468 : (System.DateTime -> int64) = _.Ticks
    let v1469 : int64 = v1468 v1
    let _v1456 = v1469 
    #endif
#else
    let v1470 : (System.DateTime -> int64) = _.Ticks
    let v1471 : int64 = v1470 v1
    let _v1456 = v1471 
    #endif
    let v1472 : int64 = _v1456 
    let v1489 : string = "$0"
    let v1490 : int64 = Fable.Core.RustInterop.emitRustExpr v1472 v1489 
    let v1491 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1490))))"
    let v1492 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1491 
    let v1493 : System.TimeSpan = v1492 |> System.TimeSpan 
    let _v1455 = v1493 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1496 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1497 : (System.DateTime -> int64) = _.Ticks
    let v1498 : int64 = v1497 v1
    let _v1496 = v1498 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1499 : (System.DateTime -> int64) = _.Ticks
    let v1500 : int64 = v1499 v1
    let _v1496 = v1500 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1501 : int64 = null |> unbox<int64>
    let _v1496 = v1501 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1504 : (System.DateTime -> int64) = _.Ticks
    let v1505 : int64 = v1504 v1
    let _v1496 = v1505 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1506 : (System.DateTime -> int64) = _.Ticks
    let v1507 : int64 = v1506 v1
    let _v1496 = v1507 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1508 : (System.DateTime -> int64) = _.Ticks
    let v1509 : int64 = v1508 v1
    let _v1496 = v1509 
    #endif
#else
    let v1510 : (System.DateTime -> int64) = _.Ticks
    let v1511 : int64 = v1510 v1
    let _v1496 = v1511 
    #endif
    let v1512 : int64 = _v1496 
    let v1529 : string = "$0"
    let v1530 : int64 = Fable.Core.RustInterop.emitRustExpr v1512 v1529 
    let v1531 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1530))))"
    let v1532 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1531 
    let v1533 : System.TimeSpan = v1532 |> System.TimeSpan 
    let _v1455 = v1533 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1536 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1537 : (System.DateTime -> int64) = _.Ticks
    let v1538 : int64 = v1537 v1
    let _v1536 = v1538 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1539 : (System.DateTime -> int64) = _.Ticks
    let v1540 : int64 = v1539 v1
    let _v1536 = v1540 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1541 : int64 = null |> unbox<int64>
    let _v1536 = v1541 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1544 : (System.DateTime -> int64) = _.Ticks
    let v1545 : int64 = v1544 v1
    let _v1536 = v1545 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1546 : (System.DateTime -> int64) = _.Ticks
    let v1547 : int64 = v1546 v1
    let _v1536 = v1547 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1548 : (System.DateTime -> int64) = _.Ticks
    let v1549 : int64 = v1548 v1
    let _v1536 = v1549 
    #endif
#else
    let v1550 : (System.DateTime -> int64) = _.Ticks
    let v1551 : int64 = v1550 v1
    let _v1536 = v1551 
    #endif
    let v1552 : int64 = _v1536 
    let v1569 : string = "$0"
    let v1570 : int64 = Fable.Core.RustInterop.emitRustExpr v1552 v1569 
    let v1571 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1570))))"
    let v1572 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1571 
    let v1573 : System.TimeSpan = v1572 |> System.TimeSpan 
    let _v1455 = v1573 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1576 : US2 = US2_0
    let v1577 : US3 = US3_3(v1576)
    let v1578 : string = $"date_time.get_utc_offset / target: {v1577}"
    let v1579 : System.TimeSpan = failwith<System.TimeSpan> v1578
    let _v1455 = v1579 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1582 : US2 = US2_0
    let v1583 : US3 = US3_4(v1582)
    let v1584 : string = $"date_time.get_utc_offset / target: {v1583}"
    let v1585 : System.TimeSpan = failwith<System.TimeSpan> v1584
    let _v1455 = v1585 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1588 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1589 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1590 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1591 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1590 
    let _v1589 = v1591 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1592 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1589 = v1592 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1595 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1589 = v1595 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1598 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1589 = v1598 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1601 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1589 = v1601 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1604 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1589 = v1604 
    #endif
#else
    let v1605 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1589 = v1605 
    #endif
    let v1606 : System.TimeZoneInfo = _v1589 
    let v1611 : (System.DateTime -> System.TimeSpan) = v1588 v1606
    let v1612 : System.TimeSpan = v1611 v1
    let _v1455 = v1612 
    #endif
#else
    let v1613 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1614 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1615 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1616 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1615 
    let _v1614 = v1616 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1617 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1614 = v1617 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1620 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1614 = v1620 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1623 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1614 = v1623 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1626 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1614 = v1626 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1629 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1614 = v1629 
    #endif
#else
    let v1630 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1614 = v1630 
    #endif
    let v1631 : System.TimeZoneInfo = _v1614 
    let v1636 : (System.DateTime -> System.TimeSpan) = v1613 v1631
    let v1637 : System.TimeSpan = v1636 v1
    let _v1455 = v1637 
    #endif
    let v1638 : System.TimeSpan = _v1455 
    let v1646 : (System.TimeSpan -> int32) = _.Hours
    let v1647 : int32 = v1646 v1638
    let v1650 : bool = v1647 > 0
    let v1651 : uint8 =
        if v1650 then
            1uy
        else
            0uy
    let v1652 : string = method4()
    let v1653 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1654 : string = v1638.ToString v1652 
    let _v1653 = v1654 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1657 : string = v1638.ToString v1652 
    let _v1653 = v1657 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1660 : string = v1638.ToString v1652 
    let _v1653 = v1660 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1663 : string = v1638.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1653 = v1663 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1664 : string = v1638.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1653 = v1664 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1665 : string = v1638.ToString v1652 
    let _v1653 = v1665 
    #endif
#else
    let v1668 : string = v1638.ToString v1652 
    let _v1653 = v1668 
    #endif
    let v1671 : string = _v1653 
    let v1676 : string = $"{v1651}{v1671}"
    let v1677 : (System.Guid -> string) = _.ToString()
    let v1678 : string = v1677 v0
    let v1681 : int32 = v1419.Length
    let v1682 : int32 = v1676.Length
    let v1683 : int32 = v1681 + v1682
    let v1684 : (string -> int32) = String.length
    let v1685 : int32 = v1684 v1678
    let v1688 : int32 = v1683 |> int32 
    let v1695 : int32 = v1685 |> int32 
    let v1702 : int32 = v1695 - 1
    let v1703 : string = v1678.[int v1688..int v1702]
    let v1707 : string = $"{v1419}{v1676}{v1703}"
    let v1708 : System.Guid = v1707 |> System.Guid 
    let _v2 = v1708 
    #endif
#else
    let v1711 : string = method3()
    let v1712 : bool = v1711 = ""
    let v1714 : string =
        if v1712 then
            let v1713 : string = "M-d-y hh:mm:ss tt"
            v1713
        else
            v1711
    let v1715 : (string -> string) = v1.ToString
    let v1716 : string = v1715 v1714
    let v1730 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1731 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1732 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1731 
    let _v1730 = v1732 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1733 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1730 = v1733 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1736 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1730 = v1736 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1739 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1730 = v1739 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1742 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1730 = v1742 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1745 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1730 = v1745 
    #endif
#else
    let v1746 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1730 = v1746 
    #endif
    let v1747 : System.TimeZoneInfo = _v1730 
    let v1752 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1753 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1754 : (System.DateTime -> int64) = _.Ticks
    let v1755 : int64 = v1754 v1
    let _v1753 = v1755 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1756 : (System.DateTime -> int64) = _.Ticks
    let v1757 : int64 = v1756 v1
    let _v1753 = v1757 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1758 : int64 = null |> unbox<int64>
    let _v1753 = v1758 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1761 : (System.DateTime -> int64) = _.Ticks
    let v1762 : int64 = v1761 v1
    let _v1753 = v1762 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1763 : (System.DateTime -> int64) = _.Ticks
    let v1764 : int64 = v1763 v1
    let _v1753 = v1764 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1765 : (System.DateTime -> int64) = _.Ticks
    let v1766 : int64 = v1765 v1
    let _v1753 = v1766 
    #endif
#else
    let v1767 : (System.DateTime -> int64) = _.Ticks
    let v1768 : int64 = v1767 v1
    let _v1753 = v1768 
    #endif
    let v1769 : int64 = _v1753 
    let v1786 : string = "$0"
    let v1787 : int64 = Fable.Core.RustInterop.emitRustExpr v1769 v1786 
    let v1788 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1787))))"
    let v1789 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1788 
    let v1790 : System.TimeSpan = v1789 |> System.TimeSpan 
    let _v1752 = v1790 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1793 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1794 : (System.DateTime -> int64) = _.Ticks
    let v1795 : int64 = v1794 v1
    let _v1793 = v1795 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1796 : (System.DateTime -> int64) = _.Ticks
    let v1797 : int64 = v1796 v1
    let _v1793 = v1797 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1798 : int64 = null |> unbox<int64>
    let _v1793 = v1798 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1801 : (System.DateTime -> int64) = _.Ticks
    let v1802 : int64 = v1801 v1
    let _v1793 = v1802 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1803 : (System.DateTime -> int64) = _.Ticks
    let v1804 : int64 = v1803 v1
    let _v1793 = v1804 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1805 : (System.DateTime -> int64) = _.Ticks
    let v1806 : int64 = v1805 v1
    let _v1793 = v1806 
    #endif
#else
    let v1807 : (System.DateTime -> int64) = _.Ticks
    let v1808 : int64 = v1807 v1
    let _v1793 = v1808 
    #endif
    let v1809 : int64 = _v1793 
    let v1826 : string = "$0"
    let v1827 : int64 = Fable.Core.RustInterop.emitRustExpr v1809 v1826 
    let v1828 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1827))))"
    let v1829 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1828 
    let v1830 : System.TimeSpan = v1829 |> System.TimeSpan 
    let _v1752 = v1830 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1833 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1834 : (System.DateTime -> int64) = _.Ticks
    let v1835 : int64 = v1834 v1
    let _v1833 = v1835 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1836 : (System.DateTime -> int64) = _.Ticks
    let v1837 : int64 = v1836 v1
    let _v1833 = v1837 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1838 : int64 = null |> unbox<int64>
    let _v1833 = v1838 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1841 : (System.DateTime -> int64) = _.Ticks
    let v1842 : int64 = v1841 v1
    let _v1833 = v1842 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1843 : (System.DateTime -> int64) = _.Ticks
    let v1844 : int64 = v1843 v1
    let _v1833 = v1844 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1845 : (System.DateTime -> int64) = _.Ticks
    let v1846 : int64 = v1845 v1
    let _v1833 = v1846 
    #endif
#else
    let v1847 : (System.DateTime -> int64) = _.Ticks
    let v1848 : int64 = v1847 v1
    let _v1833 = v1848 
    #endif
    let v1849 : int64 = _v1833 
    let v1866 : string = "$0"
    let v1867 : int64 = Fable.Core.RustInterop.emitRustExpr v1849 v1866 
    let v1868 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1867))))"
    let v1869 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1868 
    let v1870 : System.TimeSpan = v1869 |> System.TimeSpan 
    let _v1752 = v1870 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1873 : US2 = US2_0
    let v1874 : US3 = US3_3(v1873)
    let v1875 : string = $"date_time.get_utc_offset / target: {v1874}"
    let v1876 : System.TimeSpan = failwith<System.TimeSpan> v1875
    let _v1752 = v1876 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1879 : US2 = US2_0
    let v1880 : US3 = US3_4(v1879)
    let v1881 : string = $"date_time.get_utc_offset / target: {v1880}"
    let v1882 : System.TimeSpan = failwith<System.TimeSpan> v1881
    let _v1752 = v1882 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1885 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1886 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1887 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1888 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1887 
    let _v1886 = v1888 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1889 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1886 = v1889 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1892 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1886 = v1892 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1895 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1886 = v1895 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1898 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1886 = v1898 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1901 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1886 = v1901 
    #endif
#else
    let v1902 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1886 = v1902 
    #endif
    let v1903 : System.TimeZoneInfo = _v1886 
    let v1908 : (System.DateTime -> System.TimeSpan) = v1885 v1903
    let v1909 : System.TimeSpan = v1908 v1
    let _v1752 = v1909 
    #endif
#else
    let v1910 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1911 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1912 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1913 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1912 
    let _v1911 = v1913 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1914 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1911 = v1914 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1917 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1911 = v1917 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1920 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1911 = v1920 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1923 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1911 = v1923 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1926 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1911 = v1926 
    #endif
#else
    let v1927 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1911 = v1927 
    #endif
    let v1928 : System.TimeZoneInfo = _v1911 
    let v1933 : (System.DateTime -> System.TimeSpan) = v1910 v1928
    let v1934 : System.TimeSpan = v1933 v1
    let _v1752 = v1934 
    #endif
    let v1935 : System.TimeSpan = _v1752 
    let v1943 : (System.TimeSpan -> int32) = _.Hours
    let v1944 : int32 = v1943 v1935
    let v1947 : bool = v1944 > 0
    let v1948 : uint8 =
        if v1947 then
            1uy
        else
            0uy
    let v1949 : string = method4()
    let v1950 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1951 : string = v1935.ToString v1949 
    let _v1950 = v1951 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1954 : string = v1935.ToString v1949 
    let _v1950 = v1954 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1957 : string = v1935.ToString v1949 
    let _v1950 = v1957 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1960 : string = v1935.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1950 = v1960 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1961 : string = v1935.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1950 = v1961 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1962 : string = v1935.ToString v1949 
    let _v1950 = v1962 
    #endif
#else
    let v1965 : string = v1935.ToString v1949 
    let _v1950 = v1965 
    #endif
    let v1968 : string = _v1950 
    let v1973 : string = $"{v1948}{v1968}"
    let v1974 : (System.Guid -> string) = _.ToString()
    let v1975 : string = v1974 v0
    let v1978 : int32 = v1716.Length
    let v1979 : int32 = v1973.Length
    let v1980 : int32 = v1978 + v1979
    let v1981 : (string -> int32) = String.length
    let v1982 : int32 = v1981 v1975
    let v1985 : int32 = v1980 |> int32 
    let v1992 : int32 = v1982 |> int32 
    let v1999 : int32 = v1992 - 1
    let v2000 : string = v1975.[int v1985..int v1999]
    let v2004 : string = $"{v1716}{v1973}{v2000}"
    let v2005 : System.Guid = v2004 |> System.Guid 
    let _v2 = v2005 
    #endif
    let v2008 : System.Guid = _v2 
    v2008
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
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v5)
    let _v6 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v5)
    let _v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v5)
    let _v6 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v5)
    let _v6 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v5, "yyyyMMddHHmmssfffffff", null)
    let _v6 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v5, "yyyyMMddHHmmssfffffff", null)
    let _v6 = v12 
    #endif
#else
    let v13 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v5, "yyyyMMddHHmmssfffffff", null)
    let _v6 = v13 
    #endif
    let v14 : System.DateTime = _v6 
    v14
and closure6 (v0 : System.Guid) (v1 : int64) : System.Guid =
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v0
    let v6 : (int64 -> string) = _.ToString()
    let v7 : string = v6 v1
    let v10 : string = v7.PadLeft (18, '0')
    let v24 : System.Guid = System.Guid $"{v10.[0..7]}-{v10.[8..11]}-{v10.[12..15]}-{v10.[16..17]}{v3.[21..]}"
    v24
and closure5 () (v0 : System.Guid) : (int64 -> System.Guid) =
    closure6(v0)
and closure7 () (v0 : System.Guid) : int64 =
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v5 : int64 = int64 $"{v2.[0..7]}{v2.[9..12]}{v2.[14..17]}{v2.[19..20]}"
    v5
and closure8 () (v0 : System.DateTime) : System.Guid =
    let v1 : (unit -> System.Guid) = System.Guid.NewGuid
    let v2 : System.Guid = v1 ()
    method0(v2, v0)
and closure9 () (v0 : int64) : System.Guid =
    let v1 : (unit -> System.Guid) = System.Guid.NewGuid
    let v2 : System.Guid = v1 ()
    let v5 : (System.Guid -> string) = _.ToString()
    let v6 : string = v5 v2
    let v9 : (int64 -> string) = _.ToString()
    let v10 : string = v9 v0
    let v13 : string = v10.PadLeft (18, '0')
    let v27 : System.Guid = System.Guid $"{v13.[0..7]}-{v13.[8..11]}-{v13.[12..15]}-{v13.[16..17]}{v6.[21..]}"
    v27
and closure11 (v0 : string) (v1 : System.DateTime) : string =
    let v2 : bool = v0 = ""
    let v4 : string =
        if v2 then
            let v3 : string = "M-d-y hh:mm:ss tt"
            v3
        else
            v0
    let v5 : (string -> string) = v1.ToString
    v5 v4
and closure10 () (v0 : string) : (System.DateTime -> string) =
    closure11(v0)
and closure12 () (v0 : System.DateTime) : string =
    let v1 : (string -> string) = v0.ToString
    let v2 : string = "yyyy-MM-ddTHH-mm-ss.fff"
    v1 v2
let v0 : (System.Guid -> (System.DateTime -> System.Guid)) = closure0()
let date_time_guid_from_date_time x = v0 x
let v1 : (System.Guid -> System.DateTime) = closure3()
let date_time_from_guid x = v1 x
let v2 : (System.Guid -> (int64 -> System.Guid)) = closure5()
let timestamp_guid_from_timestamp x = v2 x
let v3 : (System.Guid -> int64) = closure7()
let timestamp_from_guid x = v3 x
let v4 : (System.DateTime -> System.Guid) = closure8()
let new_guid_from_date_time x = v4 x
let v5 : (int64 -> System.Guid) = closure9()
let new_guid_from_timestamp x = v5 x
let v6 : (string -> (System.DateTime -> string)) = closure10()
let format x = v6 x
let v7 : (System.DateTime -> string) = closure12()
let format_iso8601 x = v7 x
()
