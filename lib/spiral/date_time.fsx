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
    let v3 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v6 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v7 : System.DateTime = v6 v3
    let v10 : System.DateTimeKind = System.DateTimeKind.Local
    let v11 : System.DateTime = System.DateTime.SpecifyKind (v1, v10)
    let v12 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v13 : System.DateTime = v12 v11
    let v16 : (System.DateTime -> int64) = _.Ticks
    let v17 : int64 = v16 v13
    let v20 : (System.DateTime -> int64) = _.Ticks
    let v21 : int64 = v20 v7
    let v24 : int64 = v17 - v21
    let v25 : int64 = v24 / 10L
    let v26 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v27 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : (chrono_DateTime<chrono_Utc> -> US0) = method1()
    let v29 : US0 option = v27 |> Option.map v28 
    let v40 : US0 = US0_1
    let v41 : US0 = v29 |> Option.defaultValue v40 
    let v61 : US1 =
        match v41 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v45) -> (* Some *)
            let v46 : string = "$0.naive_utc()"
            let v47 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v45 v46 
            let v48 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v49 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v47 v48 
            let v50 : string = "%Y%m%d-%H%M-%S%f"
            let v51 : string = "r#\"" + v50 + "\"#"
            let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v51 
            let v53 : string = "$0.format($1).to_string()"
            let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v52) v53 
            let v55 : string = "fable_library_rust::String_::fromString($0)"
            let v56 : string = Fable.Core.RustInterop.emitRustExpr v54 v55 
            let v57 : string = $"{v56.[0..17]}-{v56.[18..21]}-{v56.[22]}"
            US1_0(v57)
    let v65 : string =
        match v61 with
        | US1_1 -> (* None *)
            let v63 : string = ""
            v63
        | US1_0(v62) -> (* Some *)
            v62
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "0i64.into()"
    let v68 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v67 
    let _v66 = v68 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v66 = v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v66 = v72 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v66 = v75 
    #endif
#if FABLE_COMPILER_PYTHON
    let v78 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v66 = v78 
    #endif
#else
    let v81 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v66 = v81 
    #endif
    let v82 : System.TimeZoneInfo = _v66 
    let v87 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v89 : System.TimeSpan = v88 ()
    let _v87 = v89 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v93 : System.TimeSpan = v92 ()
    let _v87 = v93 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v97 : System.TimeSpan = v96 ()
    let _v87 = v97 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v100 : US2 = US2_0
    let v101 : US3 = US3_3(v100)
    let v102 : string = $"date_time.get_utc_offset / target: {v101}"
    let v103 : System.TimeSpan = failwith<System.TimeSpan> v102
    let _v87 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : US2 = US2_0
    let v105 : US3 = US3_4(v104)
    let v106 : string = $"date_time.get_utc_offset / target: {v105}"
    let v107 : System.TimeSpan = failwith<System.TimeSpan> v106
    let _v87 = v107 
    #endif
#else
    let v108 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v109 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v110 : string = "0i64.into()"
    let v111 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v110 
    let _v109 = v111 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v112 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v109 = v112 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v109 = v115 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v118 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v109 = v118 
    #endif
#if FABLE_COMPILER_PYTHON
    let v121 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v109 = v121 
    #endif
#else
    let v124 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v109 = v124 
    #endif
    let v125 : System.TimeZoneInfo = _v109 
    let v130 : (System.DateTime -> System.TimeSpan) = v108 v125
    let v131 : System.TimeSpan = v130 v13
    let _v87 = v131 
    #endif
    let v132 : System.TimeSpan = _v87 
    let v138 : (System.TimeSpan -> int32) = _.Hours
    let v139 : int32 = v138 v132
    let v142 : bool = v139 > 0
    let v143 : uint8 =
        if v142 then
            1uy
        else
            0uy
    let v144 : string = method2()
    let v145 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v146 : string = v132.ToString v144 
    let _v145 = v146 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v147 : string = v132.ToString v144 
    let _v145 = v147 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v148 : string = v132.ToString v144 
    let _v145 = v148 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v149 : string = v132.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v145 = v149 
    #endif
#if FABLE_COMPILER_PYTHON
    let v150 : string = v132.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v145 = v150 
    #endif
#else
    let v151 : string = v132.ToString v144 
    let _v145 = v151 
    #endif
    let v152 : string = _v145 
    let v155 : string = $"{v143}{v152.[0..1]}{v152.[3..4]}"
    let v156 : (System.Guid -> string) = _.ToString()
    let v157 : string = v156 v0
    let v160 : System.Guid = System.Guid $"{v65}{v155}{v157.[v65.Length + v155.Length..]}"
    let _v2 = v160 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v161 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v164 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v165 : System.DateTime = v164 v161
    let v168 : System.DateTimeKind = System.DateTimeKind.Local
    let v169 : System.DateTime = System.DateTime.SpecifyKind (v1, v168)
    let v170 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v171 : System.DateTime = v170 v169
    let v174 : (System.DateTime -> int64) = _.Ticks
    let v175 : int64 = v174 v171
    let v178 : (System.DateTime -> int64) = _.Ticks
    let v179 : int64 = v178 v165
    let v182 : int64 = v175 - v179
    let v183 : int64 = v182 / 10L
    let v184 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v185 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v183 v184 
    let v186 : (chrono_DateTime<chrono_Utc> -> US0) = method1()
    let v187 : US0 option = v185 |> Option.map v186 
    let v198 : US0 = US0_1
    let v199 : US0 = v187 |> Option.defaultValue v198 
    let v219 : US1 =
        match v199 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v203) -> (* Some *)
            let v204 : string = "$0.naive_utc()"
            let v205 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v203 v204 
            let v206 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v207 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v205 v206 
            let v208 : string = "%Y%m%d-%H%M-%S%f"
            let v209 : string = "r#\"" + v208 + "\"#"
            let v210 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v209 
            let v211 : string = "$0.format($1).to_string()"
            let v212 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v207, v210) v211 
            let v213 : string = "fable_library_rust::String_::fromString($0)"
            let v214 : string = Fable.Core.RustInterop.emitRustExpr v212 v213 
            let v215 : string = $"{v214.[0..17]}-{v214.[18..21]}-{v214.[22]}"
            US1_0(v215)
    let v223 : string =
        match v219 with
        | US1_1 -> (* None *)
            let v221 : string = ""
            v221
        | US1_0(v220) -> (* Some *)
            v220
    let v224 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v225 : string = "0i64.into()"
    let v226 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v225 
    let _v224 = v226 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v227 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v224 = v227 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v230 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v224 = v230 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v233 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v224 = v233 
    #endif
#if FABLE_COMPILER_PYTHON
    let v236 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v224 = v236 
    #endif
#else
    let v239 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v224 = v239 
    #endif
    let v240 : System.TimeZoneInfo = _v224 
    let v245 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v246 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v247 : System.TimeSpan = v246 ()
    let _v245 = v247 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v250 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v251 : System.TimeSpan = v250 ()
    let _v245 = v251 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v254 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v255 : System.TimeSpan = v254 ()
    let _v245 = v255 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v258 : US2 = US2_0
    let v259 : US3 = US3_3(v258)
    let v260 : string = $"date_time.get_utc_offset / target: {v259}"
    let v261 : System.TimeSpan = failwith<System.TimeSpan> v260
    let _v245 = v261 
    #endif
#if FABLE_COMPILER_PYTHON
    let v262 : US2 = US2_0
    let v263 : US3 = US3_4(v262)
    let v264 : string = $"date_time.get_utc_offset / target: {v263}"
    let v265 : System.TimeSpan = failwith<System.TimeSpan> v264
    let _v245 = v265 
    #endif
#else
    let v266 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v267 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v268 : string = "0i64.into()"
    let v269 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v268 
    let _v267 = v269 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v270 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v267 = v270 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v273 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v267 = v273 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v276 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v267 = v276 
    #endif
#if FABLE_COMPILER_PYTHON
    let v279 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v267 = v279 
    #endif
#else
    let v282 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v267 = v282 
    #endif
    let v283 : System.TimeZoneInfo = _v267 
    let v288 : (System.DateTime -> System.TimeSpan) = v266 v283
    let v289 : System.TimeSpan = v288 v171
    let _v245 = v289 
    #endif
    let v290 : System.TimeSpan = _v245 
    let v296 : (System.TimeSpan -> int32) = _.Hours
    let v297 : int32 = v296 v290
    let v300 : bool = v297 > 0
    let v301 : uint8 =
        if v300 then
            1uy
        else
            0uy
    let v302 : string = method2()
    let v303 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v304 : string = v290.ToString v302 
    let _v303 = v304 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v305 : string = v290.ToString v302 
    let _v303 = v305 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v306 : string = v290.ToString v302 
    let _v303 = v306 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v307 : string = v290.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v303 = v307 
    #endif
#if FABLE_COMPILER_PYTHON
    let v308 : string = v290.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v303 = v308 
    #endif
#else
    let v309 : string = v290.ToString v302 
    let _v303 = v309 
    #endif
    let v310 : string = _v303 
    let v313 : string = $"{v301}{v310.[0..1]}{v310.[3..4]}"
    let v314 : (System.Guid -> string) = _.ToString()
    let v315 : string = v314 v0
    let v318 : System.Guid = System.Guid $"{v223}{v313}{v315.[v223.Length + v313.Length..]}"
    let _v2 = v318 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v319 : System.Guid = null |> unbox<System.Guid>
    let _v2 = v319 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v322 : string = method3()
    let v323 : (string -> string) = v1.ToString
    let v324 : string = v323 v322
    let v327 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v328 : string = "0i64.into()"
    let v329 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v328 
    let _v327 = v329 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v330 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v327 = v330 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v333 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v327 = v333 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v336 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v327 = v336 
    #endif
#if FABLE_COMPILER_PYTHON
    let v339 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v327 = v339 
    #endif
#else
    let v342 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v327 = v342 
    #endif
    let v343 : System.TimeZoneInfo = _v327 
    let v348 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v349 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v350 : System.TimeSpan = v349 ()
    let _v348 = v350 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v353 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v354 : System.TimeSpan = v353 ()
    let _v348 = v354 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v357 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v358 : System.TimeSpan = v357 ()
    let _v348 = v358 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v361 : US2 = US2_0
    let v362 : US3 = US3_3(v361)
    let v363 : string = $"date_time.get_utc_offset / target: {v362}"
    let v364 : System.TimeSpan = failwith<System.TimeSpan> v363
    let _v348 = v364 
    #endif
#if FABLE_COMPILER_PYTHON
    let v365 : US2 = US2_0
    let v366 : US3 = US3_4(v365)
    let v367 : string = $"date_time.get_utc_offset / target: {v366}"
    let v368 : System.TimeSpan = failwith<System.TimeSpan> v367
    let _v348 = v368 
    #endif
#else
    let v369 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v370 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v371 : string = "0i64.into()"
    let v372 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v371 
    let _v370 = v372 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v373 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v370 = v373 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v376 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v370 = v376 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v379 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v370 = v379 
    #endif
#if FABLE_COMPILER_PYTHON
    let v382 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v370 = v382 
    #endif
#else
    let v385 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v370 = v385 
    #endif
    let v386 : System.TimeZoneInfo = _v370 
    let v391 : (System.DateTime -> System.TimeSpan) = v369 v386
    let v392 : System.TimeSpan = v391 v1
    let _v348 = v392 
    #endif
    let v393 : System.TimeSpan = _v348 
    let v399 : (System.TimeSpan -> int32) = _.Hours
    let v400 : int32 = v399 v393
    let v403 : bool = v400 > 0
    let v404 : uint8 =
        if v403 then
            1uy
        else
            0uy
    let v405 : string = method4()
    let v406 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v407 : string = v393.ToString v405 
    let _v406 = v407 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v408 : string = v393.ToString v405 
    let _v406 = v408 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v409 : string = v393.ToString v405 
    let _v406 = v409 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v410 : string = v393.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v406 = v410 
    #endif
#if FABLE_COMPILER_PYTHON
    let v411 : string = v393.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v406 = v411 
    #endif
#else
    let v412 : string = v393.ToString v405 
    let _v406 = v412 
    #endif
    let v413 : string = _v406 
    let v416 : string = $"{v404}{v413}"
    let v417 : (System.Guid -> string) = _.ToString()
    let v418 : string = v417 v0
    let v421 : System.Guid = System.Guid $"{v324}{v416}{v418.[v324.Length + v416.Length..]}"
    let _v2 = v421 
    #endif
#if FABLE_COMPILER_PYTHON
    let v422 : string = method3()
    let v423 : (string -> string) = v1.ToString
    let v424 : string = v423 v422
    let v427 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v428 : string = "0i64.into()"
    let v429 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v428 
    let _v427 = v429 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v430 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v427 = v430 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v433 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v427 = v433 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v436 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v427 = v436 
    #endif
#if FABLE_COMPILER_PYTHON
    let v439 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v427 = v439 
    #endif
#else
    let v442 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v427 = v442 
    #endif
    let v443 : System.TimeZoneInfo = _v427 
    let v448 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v449 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v450 : System.TimeSpan = v449 ()
    let _v448 = v450 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v453 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v454 : System.TimeSpan = v453 ()
    let _v448 = v454 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v457 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v458 : System.TimeSpan = v457 ()
    let _v448 = v458 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v461 : US2 = US2_0
    let v462 : US3 = US3_3(v461)
    let v463 : string = $"date_time.get_utc_offset / target: {v462}"
    let v464 : System.TimeSpan = failwith<System.TimeSpan> v463
    let _v448 = v464 
    #endif
#if FABLE_COMPILER_PYTHON
    let v465 : US2 = US2_0
    let v466 : US3 = US3_4(v465)
    let v467 : string = $"date_time.get_utc_offset / target: {v466}"
    let v468 : System.TimeSpan = failwith<System.TimeSpan> v467
    let _v448 = v468 
    #endif
#else
    let v469 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v470 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v471 : string = "0i64.into()"
    let v472 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v471 
    let _v470 = v472 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v473 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v470 = v473 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v476 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v470 = v476 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v479 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v470 = v479 
    #endif
#if FABLE_COMPILER_PYTHON
    let v482 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v470 = v482 
    #endif
#else
    let v485 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v470 = v485 
    #endif
    let v486 : System.TimeZoneInfo = _v470 
    let v491 : (System.DateTime -> System.TimeSpan) = v469 v486
    let v492 : System.TimeSpan = v491 v1
    let _v448 = v492 
    #endif
    let v493 : System.TimeSpan = _v448 
    let v499 : (System.TimeSpan -> int32) = _.Hours
    let v500 : int32 = v499 v493
    let v503 : bool = v500 > 0
    let v504 : uint8 =
        if v503 then
            1uy
        else
            0uy
    let v505 : string = method4()
    let v506 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v507 : string = v493.ToString v505 
    let _v506 = v507 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v508 : string = v493.ToString v505 
    let _v506 = v508 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v509 : string = v493.ToString v505 
    let _v506 = v509 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v510 : string = v493.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v506 = v510 
    #endif
#if FABLE_COMPILER_PYTHON
    let v511 : string = v493.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v506 = v511 
    #endif
#else
    let v512 : string = v493.ToString v505 
    let _v506 = v512 
    #endif
    let v513 : string = _v506 
    let v516 : string = $"{v504}{v513}"
    let v517 : (System.Guid -> string) = _.ToString()
    let v518 : string = v517 v0
    let v521 : System.Guid = System.Guid $"{v424}{v516}{v518.[v424.Length + v516.Length..]}"
    let _v2 = v521 
    #endif
#else
    let v522 : string = method3()
    let v523 : (string -> string) = v1.ToString
    let v524 : string = v523 v522
    let v527 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v528 : string = "0i64.into()"
    let v529 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v528 
    let _v527 = v529 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v530 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v527 = v530 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v533 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v527 = v533 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v536 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v527 = v536 
    #endif
#if FABLE_COMPILER_PYTHON
    let v539 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v527 = v539 
    #endif
#else
    let v542 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v527 = v542 
    #endif
    let v543 : System.TimeZoneInfo = _v527 
    let v548 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v549 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v550 : System.TimeSpan = v549 ()
    let _v548 = v550 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v553 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v554 : System.TimeSpan = v553 ()
    let _v548 = v554 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v557 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v558 : System.TimeSpan = v557 ()
    let _v548 = v558 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v561 : US2 = US2_0
    let v562 : US3 = US3_3(v561)
    let v563 : string = $"date_time.get_utc_offset / target: {v562}"
    let v564 : System.TimeSpan = failwith<System.TimeSpan> v563
    let _v548 = v564 
    #endif
#if FABLE_COMPILER_PYTHON
    let v565 : US2 = US2_0
    let v566 : US3 = US3_4(v565)
    let v567 : string = $"date_time.get_utc_offset / target: {v566}"
    let v568 : System.TimeSpan = failwith<System.TimeSpan> v567
    let _v548 = v568 
    #endif
#else
    let v569 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v570 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v571 : string = "0i64.into()"
    let v572 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v571 
    let _v570 = v572 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v573 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v570 = v573 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v576 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v570 = v576 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v579 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v570 = v579 
    #endif
#if FABLE_COMPILER_PYTHON
    let v582 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v570 = v582 
    #endif
#else
    let v585 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v570 = v585 
    #endif
    let v586 : System.TimeZoneInfo = _v570 
    let v591 : (System.DateTime -> System.TimeSpan) = v569 v586
    let v592 : System.TimeSpan = v591 v1
    let _v548 = v592 
    #endif
    let v593 : System.TimeSpan = _v548 
    let v599 : (System.TimeSpan -> int32) = _.Hours
    let v600 : int32 = v599 v593
    let v603 : bool = v600 > 0
    let v604 : uint8 =
        if v603 then
            1uy
        else
            0uy
    let v605 : string = method4()
    let v606 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v607 : string = v593.ToString v605 
    let _v606 = v607 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v608 : string = v593.ToString v605 
    let _v606 = v608 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v609 : string = v593.ToString v605 
    let _v606 = v609 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v610 : string = v593.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v606 = v610 
    #endif
#if FABLE_COMPILER_PYTHON
    let v611 : string = v593.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v606 = v611 
    #endif
#else
    let v612 : string = v593.ToString v605 
    let _v606 = v612 
    #endif
    let v613 : string = _v606 
    let v616 : string = $"{v604}{v613}"
    let v617 : (System.Guid -> string) = _.ToString()
    let v618 : string = v617 v0
    let v621 : System.Guid = System.Guid $"{v524}{v616}{v618.[v524.Length + v616.Length..]}"
    let _v2 = v621 
    #endif
    let v622 : System.Guid = _v2 
    v622
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
#else
    let v12 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v5, "yyyyMMddHHmmssfffffff", null)
    let _v6 = v12 
    #endif
    let v13 : System.DateTime = _v6 
    v13
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
    let v2 : (string -> string) = v1.ToString
    v2 v0
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
