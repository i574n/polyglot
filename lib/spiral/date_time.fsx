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
    let v235 : US2 = US2_2
    let v236 : US3 = US3_2(v235)
    let v237 : string = $"date_time.get_utc_offset / target: {v236}"
    let v238 : System.TimeSpan = failwith<System.TimeSpan> v237
    let _v154 = v238 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v241 : US2 = US2_0
    let v242 : US3 = US3_3(v241)
    let v243 : string = $"date_time.get_utc_offset / target: {v242}"
    let v244 : System.TimeSpan = failwith<System.TimeSpan> v243
    let _v154 = v244 
    #endif
#if FABLE_COMPILER_PYTHON
    let v247 : US2 = US2_0
    let v248 : US3 = US3_4(v247)
    let v249 : string = $"date_time.get_utc_offset / target: {v248}"
    let v250 : System.TimeSpan = failwith<System.TimeSpan> v249
    let _v154 = v250 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v253 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v254 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v255 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v256 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v255 
    let _v254 = v256 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v257 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v254 = v257 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v260 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v254 = v260 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v263 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v254 = v263 
    #endif
#if FABLE_COMPILER_PYTHON
    let v266 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v254 = v266 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v269 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v254 = v269 
    #endif
#else
    let v270 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v254 = v270 
    #endif
    let v271 : System.TimeZoneInfo = _v254 
    let v276 : (System.DateTime -> System.TimeSpan) = v253 v271
    let v277 : System.TimeSpan = v276 v15
    let _v154 = v277 
    #endif
#else
    let v278 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v279 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v280 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v281 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v280 
    let _v279 = v281 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v282 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v279 = v282 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v285 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v279 = v285 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v288 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v279 = v288 
    #endif
#if FABLE_COMPILER_PYTHON
    let v291 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v279 = v291 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v294 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v279 = v294 
    #endif
#else
    let v295 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v279 = v295 
    #endif
    let v296 : System.TimeZoneInfo = _v279 
    let v301 : (System.DateTime -> System.TimeSpan) = v278 v296
    let v302 : System.TimeSpan = v301 v15
    let _v154 = v302 
    #endif
    let v303 : System.TimeSpan = _v154 
    let v311 : (System.TimeSpan -> int32) = _.Hours
    let v312 : int32 = v311 v303
    let v315 : bool = v312 > 0
    let v316 : uint8 =
        if v315 then
            1uy
        else
            0uy
    let v317 : string = method2()
    let v318 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v319 : string = v303.ToString v317 
    let _v318 = v319 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v322 : string = v303.ToString v317 
    let _v318 = v322 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v325 : string = v303.ToString v317 
    let _v318 = v325 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v328 : string = v303.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v318 = v328 
    #endif
#if FABLE_COMPILER_PYTHON
    let v329 : string = v303.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v318 = v329 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v330 : string = v303.ToString v317 
    let _v318 = v330 
    #endif
#else
    let v333 : string = v303.ToString v317 
    let _v318 = v333 
    #endif
    let v336 : string = _v318 
    let v341 : string = $"{v316}{v336.[0..1]}{v336.[3..4]}"
    let v342 : (System.Guid -> string) = _.ToString()
    let v343 : string = v342 v0
    let v346 : int32 = v131.Length
    let v347 : int32 = v341.Length
    let v348 : int32 = v346 + v347
    let v349 : (string -> int32) = String.length
    let v350 : int32 = v349 v343
    let v353 : int32 = v348 |> int32 
    let v360 : int32 = v350 |> int32 
    let v367 : int32 = v360 - 1
    let v368 : string = v343.[int v353..int v367]
    let v372 : string = $"{v131}{v341}{v368}"
    let v373 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v374 : System.Guid = v372 |> System.Guid 
    let _v373 = v374 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v377 : System.Guid = v372 |> System.Guid 
    let _v373 = v377 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v380 : System.Guid = null |> unbox<System.Guid>
    let _v373 = v380 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v383 : System.Guid = v372 |> System.Guid 
    let _v373 = v383 
    #endif
#if FABLE_COMPILER_PYTHON
    let v386 : System.Guid = v372 |> System.Guid 
    let _v373 = v386 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v389 : System.Guid = v372 |> System.Guid 
    let _v373 = v389 
    #endif
#else
    let v392 : System.Guid = v372 |> System.Guid 
    let _v373 = v392 
    #endif
    let v395 : System.Guid = _v373 
    let _v2 = v395 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v400 : System.DateTime = System.DateTime.UnixEpoch
    let v403 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v404 : System.DateTime = v403 v400
    let v407 : System.DateTimeKind = System.DateTimeKind.Local
    let v408 : System.DateTime = System.DateTime.SpecifyKind (v1, v407)
    let v411 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v412 : System.DateTime = v411 v408
    let v415 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v416 : (System.DateTime -> int64) = _.Ticks
    let v417 : int64 = v416 v412
    let _v415 = v417 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v418 : (System.DateTime -> int64) = _.Ticks
    let v419 : int64 = v418 v412
    let _v415 = v419 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v420 : int64 = null |> unbox<int64>
    let _v415 = v420 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v423 : (System.DateTime -> int64) = _.Ticks
    let v424 : int64 = v423 v412
    let _v415 = v424 
    #endif
#if FABLE_COMPILER_PYTHON
    let v425 : (System.DateTime -> int64) = _.Ticks
    let v426 : int64 = v425 v412
    let _v415 = v426 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v427 : (System.DateTime -> int64) = _.Ticks
    let v428 : int64 = v427 v412
    let _v415 = v428 
    #endif
#else
    let v429 : (System.DateTime -> int64) = _.Ticks
    let v430 : int64 = v429 v412
    let _v415 = v430 
    #endif
    let v431 : int64 = _v415 
    let v448 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v449 : (System.DateTime -> int64) = _.Ticks
    let v450 : int64 = v449 v404
    let _v448 = v450 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v451 : (System.DateTime -> int64) = _.Ticks
    let v452 : int64 = v451 v404
    let _v448 = v452 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v453 : int64 = null |> unbox<int64>
    let _v448 = v453 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v456 : (System.DateTime -> int64) = _.Ticks
    let v457 : int64 = v456 v404
    let _v448 = v457 
    #endif
#if FABLE_COMPILER_PYTHON
    let v458 : (System.DateTime -> int64) = _.Ticks
    let v459 : int64 = v458 v404
    let _v448 = v459 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v460 : (System.DateTime -> int64) = _.Ticks
    let v461 : int64 = v460 v404
    let _v448 = v461 
    #endif
#else
    let v462 : (System.DateTime -> int64) = _.Ticks
    let v463 : int64 = v462 v404
    let _v448 = v463 
    #endif
    let v464 : int64 = _v448 
    let v481 : int64 = v431 |> int64 
    let v484 : int64 = v464 |> int64 
    let v487 : int64 = v481 - v484
    let v488 : int64 = v487 / 10L
    let v489 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v490 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v488 v489 
    let v491 : (chrono_DateTime<chrono_Utc> -> US0) = method1()
    let v492 : US0 option = v490 |> Option.map v491 
    let v503 : US0 = US0_1
    let v504 : US0 = v492 |> Option.defaultValue v503 
    let v524 : US1 =
        match v504 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v508) -> (* Some *)
            let v509 : string = "$0.naive_utc()"
            let v510 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v508 v509 
            let v511 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v512 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v510 v511 
            let v513 : string = "%Y%m%d-%H%M-%S%f"
            let v514 : string = "r#\"" + v513 + "\"#"
            let v515 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v514 
            let v516 : string = "$0.format($1).to_string()"
            let v517 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v512, v515) v516 
            let v518 : string = "fable_library_rust::String_::fromString($0)"
            let v519 : string = Fable.Core.RustInterop.emitRustExpr v517 v518 
            let v520 : string = $"{v519.[0..17]}-{v519.[18..21]}-{v519.[22]}"
            US1_0(v520)
    let v528 : string =
        match v524 with
        | US1_1 -> (* None *)
            let v526 : string = ""
            v526
        | US1_0(v525) -> (* Some *)
            v525
    let v529 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v530 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v531 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v530 
    let _v529 = v531 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v532 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v529 = v532 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v535 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v529 = v535 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v538 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v529 = v538 
    #endif
#if FABLE_COMPILER_PYTHON
    let v541 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v529 = v541 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v544 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v529 = v544 
    #endif
#else
    let v545 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v529 = v545 
    #endif
    let v546 : System.TimeZoneInfo = _v529 
    let v551 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v552 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v553 : (System.DateTime -> int64) = _.Ticks
    let v554 : int64 = v553 v412
    let _v552 = v554 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v555 : (System.DateTime -> int64) = _.Ticks
    let v556 : int64 = v555 v412
    let _v552 = v556 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v557 : int64 = null |> unbox<int64>
    let _v552 = v557 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v560 : (System.DateTime -> int64) = _.Ticks
    let v561 : int64 = v560 v412
    let _v552 = v561 
    #endif
#if FABLE_COMPILER_PYTHON
    let v562 : (System.DateTime -> int64) = _.Ticks
    let v563 : int64 = v562 v412
    let _v552 = v563 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v564 : (System.DateTime -> int64) = _.Ticks
    let v565 : int64 = v564 v412
    let _v552 = v565 
    #endif
#else
    let v566 : (System.DateTime -> int64) = _.Ticks
    let v567 : int64 = v566 v412
    let _v552 = v567 
    #endif
    let v568 : int64 = _v552 
    let v585 : string = "$0"
    let v586 : int64 = Fable.Core.RustInterop.emitRustExpr v568 v585 
    let v587 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v586))))"
    let v588 : int32 = Fable.Core.RustInterop.emitRustExpr v412 v587 
    let v589 : System.TimeSpan = v588 |> System.TimeSpan 
    let _v551 = v589 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v592 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v593 : (System.DateTime -> int64) = _.Ticks
    let v594 : int64 = v593 v412
    let _v592 = v594 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v595 : (System.DateTime -> int64) = _.Ticks
    let v596 : int64 = v595 v412
    let _v592 = v596 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v597 : int64 = null |> unbox<int64>
    let _v592 = v597 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v600 : (System.DateTime -> int64) = _.Ticks
    let v601 : int64 = v600 v412
    let _v592 = v601 
    #endif
#if FABLE_COMPILER_PYTHON
    let v602 : (System.DateTime -> int64) = _.Ticks
    let v603 : int64 = v602 v412
    let _v592 = v603 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v604 : (System.DateTime -> int64) = _.Ticks
    let v605 : int64 = v604 v412
    let _v592 = v605 
    #endif
#else
    let v606 : (System.DateTime -> int64) = _.Ticks
    let v607 : int64 = v606 v412
    let _v592 = v607 
    #endif
    let v608 : int64 = _v592 
    let v625 : string = "$0"
    let v626 : int64 = Fable.Core.RustInterop.emitRustExpr v608 v625 
    let v627 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v626))))"
    let v628 : int32 = Fable.Core.RustInterop.emitRustExpr v412 v627 
    let v629 : System.TimeSpan = v628 |> System.TimeSpan 
    let _v551 = v629 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v632 : US2 = US2_2
    let v633 : US3 = US3_2(v632)
    let v634 : string = $"date_time.get_utc_offset / target: {v633}"
    let v635 : System.TimeSpan = failwith<System.TimeSpan> v634
    let _v551 = v635 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v638 : US2 = US2_0
    let v639 : US3 = US3_3(v638)
    let v640 : string = $"date_time.get_utc_offset / target: {v639}"
    let v641 : System.TimeSpan = failwith<System.TimeSpan> v640
    let _v551 = v641 
    #endif
#if FABLE_COMPILER_PYTHON
    let v644 : US2 = US2_0
    let v645 : US3 = US3_4(v644)
    let v646 : string = $"date_time.get_utc_offset / target: {v645}"
    let v647 : System.TimeSpan = failwith<System.TimeSpan> v646
    let _v551 = v647 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v650 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v651 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v652 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v653 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v652 
    let _v651 = v653 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v654 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v651 = v654 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v657 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v651 = v657 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v660 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v651 = v660 
    #endif
#if FABLE_COMPILER_PYTHON
    let v663 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v651 = v663 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v666 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v651 = v666 
    #endif
#else
    let v667 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v651 = v667 
    #endif
    let v668 : System.TimeZoneInfo = _v651 
    let v673 : (System.DateTime -> System.TimeSpan) = v650 v668
    let v674 : System.TimeSpan = v673 v412
    let _v551 = v674 
    #endif
#else
    let v675 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v676 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v677 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v678 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v677 
    let _v676 = v678 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v679 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v676 = v679 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v682 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v676 = v682 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v685 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v676 = v685 
    #endif
#if FABLE_COMPILER_PYTHON
    let v688 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v676 = v688 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v691 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v676 = v691 
    #endif
#else
    let v692 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v676 = v692 
    #endif
    let v693 : System.TimeZoneInfo = _v676 
    let v698 : (System.DateTime -> System.TimeSpan) = v675 v693
    let v699 : System.TimeSpan = v698 v412
    let _v551 = v699 
    #endif
    let v700 : System.TimeSpan = _v551 
    let v708 : (System.TimeSpan -> int32) = _.Hours
    let v709 : int32 = v708 v700
    let v712 : bool = v709 > 0
    let v713 : uint8 =
        if v712 then
            1uy
        else
            0uy
    let v714 : string = method2()
    let v715 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v716 : string = v700.ToString v714 
    let _v715 = v716 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v719 : string = v700.ToString v714 
    let _v715 = v719 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v722 : string = v700.ToString v714 
    let _v715 = v722 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v725 : string = v700.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v715 = v725 
    #endif
#if FABLE_COMPILER_PYTHON
    let v726 : string = v700.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v715 = v726 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v727 : string = v700.ToString v714 
    let _v715 = v727 
    #endif
#else
    let v730 : string = v700.ToString v714 
    let _v715 = v730 
    #endif
    let v733 : string = _v715 
    let v738 : string = $"{v713}{v733.[0..1]}{v733.[3..4]}"
    let v739 : (System.Guid -> string) = _.ToString()
    let v740 : string = v739 v0
    let v743 : int32 = v528.Length
    let v744 : int32 = v738.Length
    let v745 : int32 = v743 + v744
    let v746 : (string -> int32) = String.length
    let v747 : int32 = v746 v740
    let v750 : int32 = v745 |> int32 
    let v757 : int32 = v747 |> int32 
    let v764 : int32 = v757 - 1
    let v765 : string = v740.[int v750..int v764]
    let v769 : string = $"{v528}{v738}{v765}"
    let v770 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v771 : System.Guid = v769 |> System.Guid 
    let _v770 = v771 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v774 : System.Guid = v769 |> System.Guid 
    let _v770 = v774 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v777 : System.Guid = null |> unbox<System.Guid>
    let _v770 = v777 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v780 : System.Guid = v769 |> System.Guid 
    let _v770 = v780 
    #endif
#if FABLE_COMPILER_PYTHON
    let v783 : System.Guid = v769 |> System.Guid 
    let _v770 = v783 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v786 : System.Guid = v769 |> System.Guid 
    let _v770 = v786 
    #endif
#else
    let v789 : System.Guid = v769 |> System.Guid 
    let _v770 = v789 
    #endif
    let v792 : System.Guid = _v770 
    let _v2 = v792 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v797 : System.Guid = null |> unbox<System.Guid>
    let _v2 = v797 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v800 : string = method3()
    let v801 : bool = v800 = ""
    let v803 : string =
        if v801 then
            let v802 : string = "M-d-y hh:mm:ss tt"
            v802
        else
            v800
    let v804 : (string -> string) = v1.ToString
    let v805 : string = v804 v803
    let v819 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v820 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v821 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v820 
    let _v819 = v821 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v822 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v819 = v822 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v825 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v819 = v825 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v828 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v819 = v828 
    #endif
#if FABLE_COMPILER_PYTHON
    let v831 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v819 = v831 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v834 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v819 = v834 
    #endif
#else
    let v835 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v819 = v835 
    #endif
    let v836 : System.TimeZoneInfo = _v819 
    let v841 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v842 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v843 : (System.DateTime -> int64) = _.Ticks
    let v844 : int64 = v843 v1
    let _v842 = v844 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v845 : (System.DateTime -> int64) = _.Ticks
    let v846 : int64 = v845 v1
    let _v842 = v846 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v847 : int64 = null |> unbox<int64>
    let _v842 = v847 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v850 : (System.DateTime -> int64) = _.Ticks
    let v851 : int64 = v850 v1
    let _v842 = v851 
    #endif
#if FABLE_COMPILER_PYTHON
    let v852 : (System.DateTime -> int64) = _.Ticks
    let v853 : int64 = v852 v1
    let _v842 = v853 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v854 : (System.DateTime -> int64) = _.Ticks
    let v855 : int64 = v854 v1
    let _v842 = v855 
    #endif
#else
    let v856 : (System.DateTime -> int64) = _.Ticks
    let v857 : int64 = v856 v1
    let _v842 = v857 
    #endif
    let v858 : int64 = _v842 
    let v875 : string = "$0"
    let v876 : int64 = Fable.Core.RustInterop.emitRustExpr v858 v875 
    let v877 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v876))))"
    let v878 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v877 
    let v879 : System.TimeSpan = v878 |> System.TimeSpan 
    let _v841 = v879 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v882 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v883 : (System.DateTime -> int64) = _.Ticks
    let v884 : int64 = v883 v1
    let _v882 = v884 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v885 : (System.DateTime -> int64) = _.Ticks
    let v886 : int64 = v885 v1
    let _v882 = v886 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v887 : int64 = null |> unbox<int64>
    let _v882 = v887 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v890 : (System.DateTime -> int64) = _.Ticks
    let v891 : int64 = v890 v1
    let _v882 = v891 
    #endif
#if FABLE_COMPILER_PYTHON
    let v892 : (System.DateTime -> int64) = _.Ticks
    let v893 : int64 = v892 v1
    let _v882 = v893 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v894 : (System.DateTime -> int64) = _.Ticks
    let v895 : int64 = v894 v1
    let _v882 = v895 
    #endif
#else
    let v896 : (System.DateTime -> int64) = _.Ticks
    let v897 : int64 = v896 v1
    let _v882 = v897 
    #endif
    let v898 : int64 = _v882 
    let v915 : string = "$0"
    let v916 : int64 = Fable.Core.RustInterop.emitRustExpr v898 v915 
    let v917 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v916))))"
    let v918 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v917 
    let v919 : System.TimeSpan = v918 |> System.TimeSpan 
    let _v841 = v919 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v922 : US2 = US2_2
    let v923 : US3 = US3_2(v922)
    let v924 : string = $"date_time.get_utc_offset / target: {v923}"
    let v925 : System.TimeSpan = failwith<System.TimeSpan> v924
    let _v841 = v925 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v928 : US2 = US2_0
    let v929 : US3 = US3_3(v928)
    let v930 : string = $"date_time.get_utc_offset / target: {v929}"
    let v931 : System.TimeSpan = failwith<System.TimeSpan> v930
    let _v841 = v931 
    #endif
#if FABLE_COMPILER_PYTHON
    let v934 : US2 = US2_0
    let v935 : US3 = US3_4(v934)
    let v936 : string = $"date_time.get_utc_offset / target: {v935}"
    let v937 : System.TimeSpan = failwith<System.TimeSpan> v936
    let _v841 = v937 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v940 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v941 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v942 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v943 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v942 
    let _v941 = v943 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v944 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v941 = v944 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v947 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v941 = v947 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v950 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v941 = v950 
    #endif
#if FABLE_COMPILER_PYTHON
    let v953 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v941 = v953 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v956 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v941 = v956 
    #endif
#else
    let v957 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v941 = v957 
    #endif
    let v958 : System.TimeZoneInfo = _v941 
    let v963 : (System.DateTime -> System.TimeSpan) = v940 v958
    let v964 : System.TimeSpan = v963 v1
    let _v841 = v964 
    #endif
#else
    let v965 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v966 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v967 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v968 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v967 
    let _v966 = v968 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v969 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v966 = v969 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v972 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v966 = v972 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v975 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v966 = v975 
    #endif
#if FABLE_COMPILER_PYTHON
    let v978 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v966 = v978 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v981 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v966 = v981 
    #endif
#else
    let v982 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v966 = v982 
    #endif
    let v983 : System.TimeZoneInfo = _v966 
    let v988 : (System.DateTime -> System.TimeSpan) = v965 v983
    let v989 : System.TimeSpan = v988 v1
    let _v841 = v989 
    #endif
    let v990 : System.TimeSpan = _v841 
    let v998 : (System.TimeSpan -> int32) = _.Hours
    let v999 : int32 = v998 v990
    let v1002 : bool = v999 > 0
    let v1003 : uint8 =
        if v1002 then
            1uy
        else
            0uy
    let v1004 : string = method4()
    let v1005 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1006 : string = v990.ToString v1004 
    let _v1005 = v1006 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1009 : string = v990.ToString v1004 
    let _v1005 = v1009 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1012 : string = v990.ToString v1004 
    let _v1005 = v1012 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1015 : string = v990.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1005 = v1015 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1016 : string = v990.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1005 = v1016 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1017 : string = v990.ToString v1004 
    let _v1005 = v1017 
    #endif
#else
    let v1020 : string = v990.ToString v1004 
    let _v1005 = v1020 
    #endif
    let v1023 : string = _v1005 
    let v1028 : string = $"{v1003}{v1023}"
    let v1029 : (System.Guid -> string) = _.ToString()
    let v1030 : string = v1029 v0
    let v1033 : int32 = v805.Length
    let v1034 : int32 = v1028.Length
    let v1035 : int32 = v1033 + v1034
    let v1036 : (string -> int32) = String.length
    let v1037 : int32 = v1036 v1030
    let v1040 : int32 = v1035 |> int32 
    let v1047 : int32 = v1037 |> int32 
    let v1054 : int32 = v1047 - 1
    let v1055 : string = v1030.[int v1040..int v1054]
    let v1059 : string = $"{v805}{v1028}{v1055}"
    let v1060 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1061 : System.Guid = v1059 |> System.Guid 
    let _v1060 = v1061 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1064 : System.Guid = v1059 |> System.Guid 
    let _v1060 = v1064 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1067 : System.Guid = null |> unbox<System.Guid>
    let _v1060 = v1067 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1070 : System.Guid = v1059 |> System.Guid 
    let _v1060 = v1070 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1073 : System.Guid = v1059 |> System.Guid 
    let _v1060 = v1073 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1076 : System.Guid = v1059 |> System.Guid 
    let _v1060 = v1076 
    #endif
#else
    let v1079 : System.Guid = v1059 |> System.Guid 
    let _v1060 = v1079 
    #endif
    let v1082 : System.Guid = _v1060 
    let _v2 = v1082 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1087 : string = method3()
    let v1088 : bool = v1087 = ""
    let v1090 : string =
        if v1088 then
            let v1089 : string = "M-d-y hh:mm:ss tt"
            v1089
        else
            v1087
    let v1091 : (string -> string) = v1.ToString
    let v1092 : string = v1091 v1090
    let v1106 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1107 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1108 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1107 
    let _v1106 = v1108 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1109 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1106 = v1109 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1112 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1106 = v1112 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1115 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1106 = v1115 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1118 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1106 = v1118 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1121 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1106 = v1121 
    #endif
#else
    let v1122 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1106 = v1122 
    #endif
    let v1123 : System.TimeZoneInfo = _v1106 
    let v1128 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1129 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1130 : (System.DateTime -> int64) = _.Ticks
    let v1131 : int64 = v1130 v1
    let _v1129 = v1131 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1132 : (System.DateTime -> int64) = _.Ticks
    let v1133 : int64 = v1132 v1
    let _v1129 = v1133 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1134 : int64 = null |> unbox<int64>
    let _v1129 = v1134 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1137 : (System.DateTime -> int64) = _.Ticks
    let v1138 : int64 = v1137 v1
    let _v1129 = v1138 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1139 : (System.DateTime -> int64) = _.Ticks
    let v1140 : int64 = v1139 v1
    let _v1129 = v1140 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1141 : (System.DateTime -> int64) = _.Ticks
    let v1142 : int64 = v1141 v1
    let _v1129 = v1142 
    #endif
#else
    let v1143 : (System.DateTime -> int64) = _.Ticks
    let v1144 : int64 = v1143 v1
    let _v1129 = v1144 
    #endif
    let v1145 : int64 = _v1129 
    let v1162 : string = "$0"
    let v1163 : int64 = Fable.Core.RustInterop.emitRustExpr v1145 v1162 
    let v1164 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1163))))"
    let v1165 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1164 
    let v1166 : System.TimeSpan = v1165 |> System.TimeSpan 
    let _v1128 = v1166 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1169 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1170 : (System.DateTime -> int64) = _.Ticks
    let v1171 : int64 = v1170 v1
    let _v1169 = v1171 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1172 : (System.DateTime -> int64) = _.Ticks
    let v1173 : int64 = v1172 v1
    let _v1169 = v1173 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1174 : int64 = null |> unbox<int64>
    let _v1169 = v1174 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1177 : (System.DateTime -> int64) = _.Ticks
    let v1178 : int64 = v1177 v1
    let _v1169 = v1178 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1179 : (System.DateTime -> int64) = _.Ticks
    let v1180 : int64 = v1179 v1
    let _v1169 = v1180 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1181 : (System.DateTime -> int64) = _.Ticks
    let v1182 : int64 = v1181 v1
    let _v1169 = v1182 
    #endif
#else
    let v1183 : (System.DateTime -> int64) = _.Ticks
    let v1184 : int64 = v1183 v1
    let _v1169 = v1184 
    #endif
    let v1185 : int64 = _v1169 
    let v1202 : string = "$0"
    let v1203 : int64 = Fable.Core.RustInterop.emitRustExpr v1185 v1202 
    let v1204 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1203))))"
    let v1205 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1204 
    let v1206 : System.TimeSpan = v1205 |> System.TimeSpan 
    let _v1128 = v1206 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1209 : US2 = US2_2
    let v1210 : US3 = US3_2(v1209)
    let v1211 : string = $"date_time.get_utc_offset / target: {v1210}"
    let v1212 : System.TimeSpan = failwith<System.TimeSpan> v1211
    let _v1128 = v1212 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1215 : US2 = US2_0
    let v1216 : US3 = US3_3(v1215)
    let v1217 : string = $"date_time.get_utc_offset / target: {v1216}"
    let v1218 : System.TimeSpan = failwith<System.TimeSpan> v1217
    let _v1128 = v1218 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1221 : US2 = US2_0
    let v1222 : US3 = US3_4(v1221)
    let v1223 : string = $"date_time.get_utc_offset / target: {v1222}"
    let v1224 : System.TimeSpan = failwith<System.TimeSpan> v1223
    let _v1128 = v1224 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1227 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1228 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1229 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1230 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1229 
    let _v1228 = v1230 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1231 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1228 = v1231 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1234 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1228 = v1234 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1237 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1228 = v1237 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1240 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1228 = v1240 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1243 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1228 = v1243 
    #endif
#else
    let v1244 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1228 = v1244 
    #endif
    let v1245 : System.TimeZoneInfo = _v1228 
    let v1250 : (System.DateTime -> System.TimeSpan) = v1227 v1245
    let v1251 : System.TimeSpan = v1250 v1
    let _v1128 = v1251 
    #endif
#else
    let v1252 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1253 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1254 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1255 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1254 
    let _v1253 = v1255 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1256 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1253 = v1256 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1259 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1253 = v1259 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1262 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1253 = v1262 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1265 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1253 = v1265 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1268 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1253 = v1268 
    #endif
#else
    let v1269 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1253 = v1269 
    #endif
    let v1270 : System.TimeZoneInfo = _v1253 
    let v1275 : (System.DateTime -> System.TimeSpan) = v1252 v1270
    let v1276 : System.TimeSpan = v1275 v1
    let _v1128 = v1276 
    #endif
    let v1277 : System.TimeSpan = _v1128 
    let v1285 : (System.TimeSpan -> int32) = _.Hours
    let v1286 : int32 = v1285 v1277
    let v1289 : bool = v1286 > 0
    let v1290 : uint8 =
        if v1289 then
            1uy
        else
            0uy
    let v1291 : string = method4()
    let v1292 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1293 : string = v1277.ToString v1291 
    let _v1292 = v1293 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1296 : string = v1277.ToString v1291 
    let _v1292 = v1296 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1299 : string = v1277.ToString v1291 
    let _v1292 = v1299 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1302 : string = v1277.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1292 = v1302 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1303 : string = v1277.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1292 = v1303 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1304 : string = v1277.ToString v1291 
    let _v1292 = v1304 
    #endif
#else
    let v1307 : string = v1277.ToString v1291 
    let _v1292 = v1307 
    #endif
    let v1310 : string = _v1292 
    let v1315 : string = $"{v1290}{v1310}"
    let v1316 : (System.Guid -> string) = _.ToString()
    let v1317 : string = v1316 v0
    let v1320 : int32 = v1092.Length
    let v1321 : int32 = v1315.Length
    let v1322 : int32 = v1320 + v1321
    let v1323 : (string -> int32) = String.length
    let v1324 : int32 = v1323 v1317
    let v1327 : int32 = v1322 |> int32 
    let v1334 : int32 = v1324 |> int32 
    let v1341 : int32 = v1334 - 1
    let v1342 : string = v1317.[int v1327..int v1341]
    let v1346 : string = $"{v1092}{v1315}{v1342}"
    let v1347 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1348 : System.Guid = v1346 |> System.Guid 
    let _v1347 = v1348 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1351 : System.Guid = v1346 |> System.Guid 
    let _v1347 = v1351 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1354 : System.Guid = null |> unbox<System.Guid>
    let _v1347 = v1354 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1357 : System.Guid = v1346 |> System.Guid 
    let _v1347 = v1357 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1360 : System.Guid = v1346 |> System.Guid 
    let _v1347 = v1360 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1363 : System.Guid = v1346 |> System.Guid 
    let _v1347 = v1363 
    #endif
#else
    let v1366 : System.Guid = v1346 |> System.Guid 
    let _v1347 = v1366 
    #endif
    let v1369 : System.Guid = _v1347 
    let _v2 = v1369 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1374 : string = method3()
    let v1375 : bool = v1374 = ""
    let v1377 : string =
        if v1375 then
            let v1376 : string = "M-d-y hh:mm:ss tt"
            v1376
        else
            v1374
    let v1378 : (string -> string) = v1.ToString
    let v1379 : string = v1378 v1377
    let v1393 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1394 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1395 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1394 
    let _v1393 = v1395 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1396 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1393 = v1396 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1399 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1393 = v1399 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1402 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1393 = v1402 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1405 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1393 = v1405 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1408 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1393 = v1408 
    #endif
#else
    let v1409 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1393 = v1409 
    #endif
    let v1410 : System.TimeZoneInfo = _v1393 
    let v1415 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1416 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1417 : (System.DateTime -> int64) = _.Ticks
    let v1418 : int64 = v1417 v1
    let _v1416 = v1418 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1419 : (System.DateTime -> int64) = _.Ticks
    let v1420 : int64 = v1419 v1
    let _v1416 = v1420 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1421 : int64 = null |> unbox<int64>
    let _v1416 = v1421 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1424 : (System.DateTime -> int64) = _.Ticks
    let v1425 : int64 = v1424 v1
    let _v1416 = v1425 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1426 : (System.DateTime -> int64) = _.Ticks
    let v1427 : int64 = v1426 v1
    let _v1416 = v1427 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1428 : (System.DateTime -> int64) = _.Ticks
    let v1429 : int64 = v1428 v1
    let _v1416 = v1429 
    #endif
#else
    let v1430 : (System.DateTime -> int64) = _.Ticks
    let v1431 : int64 = v1430 v1
    let _v1416 = v1431 
    #endif
    let v1432 : int64 = _v1416 
    let v1449 : string = "$0"
    let v1450 : int64 = Fable.Core.RustInterop.emitRustExpr v1432 v1449 
    let v1451 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1450))))"
    let v1452 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1451 
    let v1453 : System.TimeSpan = v1452 |> System.TimeSpan 
    let _v1415 = v1453 
    #endif
#if FABLE_COMPILER_RUST && WASM
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
    let _v1415 = v1493 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1496 : US2 = US2_2
    let v1497 : US3 = US3_2(v1496)
    let v1498 : string = $"date_time.get_utc_offset / target: {v1497}"
    let v1499 : System.TimeSpan = failwith<System.TimeSpan> v1498
    let _v1415 = v1499 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1502 : US2 = US2_0
    let v1503 : US3 = US3_3(v1502)
    let v1504 : string = $"date_time.get_utc_offset / target: {v1503}"
    let v1505 : System.TimeSpan = failwith<System.TimeSpan> v1504
    let _v1415 = v1505 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1508 : US2 = US2_0
    let v1509 : US3 = US3_4(v1508)
    let v1510 : string = $"date_time.get_utc_offset / target: {v1509}"
    let v1511 : System.TimeSpan = failwith<System.TimeSpan> v1510
    let _v1415 = v1511 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1514 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1515 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1516 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1517 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1516 
    let _v1515 = v1517 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1518 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1515 = v1518 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1521 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1515 = v1521 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1524 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1515 = v1524 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1527 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1515 = v1527 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1530 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1515 = v1530 
    #endif
#else
    let v1531 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1515 = v1531 
    #endif
    let v1532 : System.TimeZoneInfo = _v1515 
    let v1537 : (System.DateTime -> System.TimeSpan) = v1514 v1532
    let v1538 : System.TimeSpan = v1537 v1
    let _v1415 = v1538 
    #endif
#else
    let v1539 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1540 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1541 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1542 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1541 
    let _v1540 = v1542 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1543 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1540 = v1543 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1546 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1540 = v1546 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1549 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1540 = v1549 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1552 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1540 = v1552 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1555 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1540 = v1555 
    #endif
#else
    let v1556 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1540 = v1556 
    #endif
    let v1557 : System.TimeZoneInfo = _v1540 
    let v1562 : (System.DateTime -> System.TimeSpan) = v1539 v1557
    let v1563 : System.TimeSpan = v1562 v1
    let _v1415 = v1563 
    #endif
    let v1564 : System.TimeSpan = _v1415 
    let v1572 : (System.TimeSpan -> int32) = _.Hours
    let v1573 : int32 = v1572 v1564
    let v1576 : bool = v1573 > 0
    let v1577 : uint8 =
        if v1576 then
            1uy
        else
            0uy
    let v1578 : string = method4()
    let v1579 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1580 : string = v1564.ToString v1578 
    let _v1579 = v1580 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1583 : string = v1564.ToString v1578 
    let _v1579 = v1583 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1586 : string = v1564.ToString v1578 
    let _v1579 = v1586 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1589 : string = v1564.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1579 = v1589 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1590 : string = v1564.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1579 = v1590 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1591 : string = v1564.ToString v1578 
    let _v1579 = v1591 
    #endif
#else
    let v1594 : string = v1564.ToString v1578 
    let _v1579 = v1594 
    #endif
    let v1597 : string = _v1579 
    let v1602 : string = $"{v1577}{v1597}"
    let v1603 : (System.Guid -> string) = _.ToString()
    let v1604 : string = v1603 v0
    let v1607 : int32 = v1379.Length
    let v1608 : int32 = v1602.Length
    let v1609 : int32 = v1607 + v1608
    let v1610 : (string -> int32) = String.length
    let v1611 : int32 = v1610 v1604
    let v1614 : int32 = v1609 |> int32 
    let v1621 : int32 = v1611 |> int32 
    let v1628 : int32 = v1621 - 1
    let v1629 : string = v1604.[int v1614..int v1628]
    let v1633 : string = $"{v1379}{v1602}{v1629}"
    let v1634 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1635 : System.Guid = v1633 |> System.Guid 
    let _v1634 = v1635 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1638 : System.Guid = v1633 |> System.Guid 
    let _v1634 = v1638 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1641 : System.Guid = null |> unbox<System.Guid>
    let _v1634 = v1641 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1644 : System.Guid = v1633 |> System.Guid 
    let _v1634 = v1644 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1647 : System.Guid = v1633 |> System.Guid 
    let _v1634 = v1647 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1650 : System.Guid = v1633 |> System.Guid 
    let _v1634 = v1650 
    #endif
#else
    let v1653 : System.Guid = v1633 |> System.Guid 
    let _v1634 = v1653 
    #endif
    let v1656 : System.Guid = _v1634 
    let _v2 = v1656 
    #endif
#else
    let v1661 : string = method3()
    let v1662 : bool = v1661 = ""
    let v1664 : string =
        if v1662 then
            let v1663 : string = "M-d-y hh:mm:ss tt"
            v1663
        else
            v1661
    let v1665 : (string -> string) = v1.ToString
    let v1666 : string = v1665 v1664
    let v1680 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1681 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1682 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1681 
    let _v1680 = v1682 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1683 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1680 = v1683 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1686 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1680 = v1686 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1689 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1680 = v1689 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1692 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1680 = v1692 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1695 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1680 = v1695 
    #endif
#else
    let v1696 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1680 = v1696 
    #endif
    let v1697 : System.TimeZoneInfo = _v1680 
    let v1702 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1703 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1704 : (System.DateTime -> int64) = _.Ticks
    let v1705 : int64 = v1704 v1
    let _v1703 = v1705 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1706 : (System.DateTime -> int64) = _.Ticks
    let v1707 : int64 = v1706 v1
    let _v1703 = v1707 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1708 : int64 = null |> unbox<int64>
    let _v1703 = v1708 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1711 : (System.DateTime -> int64) = _.Ticks
    let v1712 : int64 = v1711 v1
    let _v1703 = v1712 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1713 : (System.DateTime -> int64) = _.Ticks
    let v1714 : int64 = v1713 v1
    let _v1703 = v1714 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1715 : (System.DateTime -> int64) = _.Ticks
    let v1716 : int64 = v1715 v1
    let _v1703 = v1716 
    #endif
#else
    let v1717 : (System.DateTime -> int64) = _.Ticks
    let v1718 : int64 = v1717 v1
    let _v1703 = v1718 
    #endif
    let v1719 : int64 = _v1703 
    let v1736 : string = "$0"
    let v1737 : int64 = Fable.Core.RustInterop.emitRustExpr v1719 v1736 
    let v1738 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1737))))"
    let v1739 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1738 
    let v1740 : System.TimeSpan = v1739 |> System.TimeSpan 
    let _v1702 = v1740 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1743 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1744 : (System.DateTime -> int64) = _.Ticks
    let v1745 : int64 = v1744 v1
    let _v1743 = v1745 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1746 : (System.DateTime -> int64) = _.Ticks
    let v1747 : int64 = v1746 v1
    let _v1743 = v1747 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1748 : int64 = null |> unbox<int64>
    let _v1743 = v1748 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1751 : (System.DateTime -> int64) = _.Ticks
    let v1752 : int64 = v1751 v1
    let _v1743 = v1752 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1753 : (System.DateTime -> int64) = _.Ticks
    let v1754 : int64 = v1753 v1
    let _v1743 = v1754 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1755 : (System.DateTime -> int64) = _.Ticks
    let v1756 : int64 = v1755 v1
    let _v1743 = v1756 
    #endif
#else
    let v1757 : (System.DateTime -> int64) = _.Ticks
    let v1758 : int64 = v1757 v1
    let _v1743 = v1758 
    #endif
    let v1759 : int64 = _v1743 
    let v1776 : string = "$0"
    let v1777 : int64 = Fable.Core.RustInterop.emitRustExpr v1759 v1776 
    let v1778 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v1777))))"
    let v1779 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v1778 
    let v1780 : System.TimeSpan = v1779 |> System.TimeSpan 
    let _v1702 = v1780 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1783 : US2 = US2_2
    let v1784 : US3 = US3_2(v1783)
    let v1785 : string = $"date_time.get_utc_offset / target: {v1784}"
    let v1786 : System.TimeSpan = failwith<System.TimeSpan> v1785
    let _v1702 = v1786 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1789 : US2 = US2_0
    let v1790 : US3 = US3_3(v1789)
    let v1791 : string = $"date_time.get_utc_offset / target: {v1790}"
    let v1792 : System.TimeSpan = failwith<System.TimeSpan> v1791
    let _v1702 = v1792 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1795 : US2 = US2_0
    let v1796 : US3 = US3_4(v1795)
    let v1797 : string = $"date_time.get_utc_offset / target: {v1796}"
    let v1798 : System.TimeSpan = failwith<System.TimeSpan> v1797
    let _v1702 = v1798 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1801 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1802 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1803 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1804 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1803 
    let _v1802 = v1804 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1805 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1802 = v1805 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1808 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1802 = v1808 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1811 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1802 = v1811 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1814 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1802 = v1814 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1817 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1802 = v1817 
    #endif
#else
    let v1818 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1802 = v1818 
    #endif
    let v1819 : System.TimeZoneInfo = _v1802 
    let v1824 : (System.DateTime -> System.TimeSpan) = v1801 v1819
    let v1825 : System.TimeSpan = v1824 v1
    let _v1702 = v1825 
    #endif
#else
    let v1826 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1827 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1828 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1829 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1828 
    let _v1827 = v1829 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1830 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1827 = v1830 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1833 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1827 = v1833 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1836 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1827 = v1836 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1839 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1827 = v1839 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1842 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1827 = v1842 
    #endif
#else
    let v1843 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1827 = v1843 
    #endif
    let v1844 : System.TimeZoneInfo = _v1827 
    let v1849 : (System.DateTime -> System.TimeSpan) = v1826 v1844
    let v1850 : System.TimeSpan = v1849 v1
    let _v1702 = v1850 
    #endif
    let v1851 : System.TimeSpan = _v1702 
    let v1859 : (System.TimeSpan -> int32) = _.Hours
    let v1860 : int32 = v1859 v1851
    let v1863 : bool = v1860 > 0
    let v1864 : uint8 =
        if v1863 then
            1uy
        else
            0uy
    let v1865 : string = method4()
    let v1866 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1867 : string = v1851.ToString v1865 
    let _v1866 = v1867 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1870 : string = v1851.ToString v1865 
    let _v1866 = v1870 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1873 : string = v1851.ToString v1865 
    let _v1866 = v1873 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1876 : string = v1851.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1866 = v1876 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1877 : string = v1851.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1866 = v1877 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1878 : string = v1851.ToString v1865 
    let _v1866 = v1878 
    #endif
#else
    let v1881 : string = v1851.ToString v1865 
    let _v1866 = v1881 
    #endif
    let v1884 : string = _v1866 
    let v1889 : string = $"{v1864}{v1884}"
    let v1890 : (System.Guid -> string) = _.ToString()
    let v1891 : string = v1890 v0
    let v1894 : int32 = v1666.Length
    let v1895 : int32 = v1889.Length
    let v1896 : int32 = v1894 + v1895
    let v1897 : (string -> int32) = String.length
    let v1898 : int32 = v1897 v1891
    let v1901 : int32 = v1896 |> int32 
    let v1908 : int32 = v1898 |> int32 
    let v1915 : int32 = v1908 - 1
    let v1916 : string = v1891.[int v1901..int v1915]
    let v1920 : string = $"{v1666}{v1889}{v1916}"
    let v1921 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1922 : System.Guid = v1920 |> System.Guid 
    let _v1921 = v1922 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1925 : System.Guid = v1920 |> System.Guid 
    let _v1921 = v1925 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1928 : System.Guid = null |> unbox<System.Guid>
    let _v1921 = v1928 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1931 : System.Guid = v1920 |> System.Guid 
    let _v1921 = v1931 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1934 : System.Guid = v1920 |> System.Guid 
    let _v1921 = v1934 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1937 : System.Guid = v1920 |> System.Guid 
    let _v1921 = v1937 
    #endif
#else
    let v1940 : System.Guid = v1920 |> System.Guid 
    let _v1921 = v1940 
    #endif
    let v1943 : System.Guid = _v1921 
    let _v2 = v1943 
    #endif
    let v1948 : System.Guid = _v2 
    v1948
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
