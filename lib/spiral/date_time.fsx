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
    let v16 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v17 : (System.DateTime -> int64) = _.Ticks
    let v18 : int64 = v17 v13
    let _v16 = v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : (System.DateTime -> int64) = _.Ticks
    let v20 : int64 = v19 v13
    let _v16 = v20 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : int64 = null |> unbox<int64>
    let _v16 = v21 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : (System.DateTime -> int64) = _.Ticks
    let v25 : int64 = v24 v13
    let _v16 = v25 
    #endif
#if FABLE_COMPILER_PYTHON
    let v26 : (System.DateTime -> int64) = _.Ticks
    let v27 : int64 = v26 v13
    let _v16 = v27 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v28 : (System.DateTime -> int64) = _.Ticks
    let v29 : int64 = v28 v13
    let _v16 = v29 
    #endif
#else
    let v30 : (System.DateTime -> int64) = _.Ticks
    let v31 : int64 = v30 v13
    let _v16 = v31 
    #endif
    let v32 : int64 = _v16 
    let v49 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v50 : (System.DateTime -> int64) = _.Ticks
    let v51 : int64 = v50 v7
    let _v49 = v51 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v52 : (System.DateTime -> int64) = _.Ticks
    let v53 : int64 = v52 v7
    let _v49 = v53 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v54 : int64 = null |> unbox<int64>
    let _v49 = v54 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : (System.DateTime -> int64) = _.Ticks
    let v58 : int64 = v57 v7
    let _v49 = v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v59 : (System.DateTime -> int64) = _.Ticks
    let v60 : int64 = v59 v7
    let _v49 = v60 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v61 : (System.DateTime -> int64) = _.Ticks
    let v62 : int64 = v61 v7
    let _v49 = v62 
    #endif
#else
    let v63 : (System.DateTime -> int64) = _.Ticks
    let v64 : int64 = v63 v7
    let _v49 = v64 
    #endif
    let v65 : int64 = _v49 
    let v82 : int64 = v32 |> int64 
    let v85 : int64 = v65 |> int64 
    let v88 : int64 = v82 - v85
    let v89 : int64 = v88 / 10L
    let v90 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v91 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let v92 : (chrono_DateTime<chrono_Utc> -> US0) = method1()
    let v93 : US0 option = v91 |> Option.map v92 
    let v104 : US0 = US0_1
    let v105 : US0 = v93 |> Option.defaultValue v104 
    let v125 : US1 =
        match v105 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v109) -> (* Some *)
            let v110 : string = "$0.naive_utc()"
            let v111 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v109 v110 
            let v112 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v113 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v111 v112 
            let v114 : string = "%Y%m%d-%H%M-%S%f"
            let v115 : string = "r#\"" + v114 + "\"#"
            let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v115 
            let v117 : string = "$0.format($1).to_string()"
            let v118 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v113, v116) v117 
            let v119 : string = "fable_library_rust::String_::fromString($0)"
            let v120 : string = Fable.Core.RustInterop.emitRustExpr v118 v119 
            let v121 : string = $"{v120.[0..17]}-{v120.[18..21]}-{v120.[22]}"
            US1_0(v121)
    let v129 : string =
        match v125 with
        | US1_1 -> (* None *)
            let v127 : string = ""
            v127
        | US1_0(v126) -> (* Some *)
            v126
    let v130 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v131 : string = "0i64.into()"
    let v132 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v131 
    let _v130 = v132 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v133 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v130 = v133 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v136 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v130 = v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v139 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v130 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v142 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v130 = v142 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v145 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v130 = v145 
    #endif
#else
    let v146 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v130 = v146 
    #endif
    let v147 : System.TimeZoneInfo = _v130 
    let v152 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v153 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v154 : System.TimeSpan = v153 ()
    let _v152 = v154 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v157 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v158 : System.TimeSpan = v157 ()
    let _v152 = v158 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v161 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v162 : System.TimeSpan = v161 ()
    let _v152 = v162 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v165 : US2 = US2_0
    let v166 : US3 = US3_3(v165)
    let v167 : string = $"date_time.get_utc_offset / target: {v166}"
    let v168 : System.TimeSpan = failwith<System.TimeSpan> v167
    let _v152 = v168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v169 : US2 = US2_0
    let v170 : US3 = US3_4(v169)
    let v171 : string = $"date_time.get_utc_offset / target: {v170}"
    let v172 : System.TimeSpan = failwith<System.TimeSpan> v171
    let _v152 = v172 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v173 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v174 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v175 : string = "0i64.into()"
    let v176 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v175 
    let _v174 = v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v177 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v174 = v177 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v180 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v174 = v180 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v174 = v183 
    #endif
#if FABLE_COMPILER_PYTHON
    let v186 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v174 = v186 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v189 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v174 = v189 
    #endif
#else
    let v190 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v174 = v190 
    #endif
    let v191 : System.TimeZoneInfo = _v174 
    let v196 : (System.DateTime -> System.TimeSpan) = v173 v191
    let v197 : System.TimeSpan = v196 v13
    let _v152 = v197 
    #endif
#else
    let v198 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v199 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v200 : string = "0i64.into()"
    let v201 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v200 
    let _v199 = v201 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v202 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v199 = v202 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v205 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v199 = v205 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v208 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v199 = v208 
    #endif
#if FABLE_COMPILER_PYTHON
    let v211 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v199 = v211 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v214 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v199 = v214 
    #endif
#else
    let v215 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v199 = v215 
    #endif
    let v216 : System.TimeZoneInfo = _v199 
    let v221 : (System.DateTime -> System.TimeSpan) = v198 v216
    let v222 : System.TimeSpan = v221 v13
    let _v152 = v222 
    #endif
    let v223 : System.TimeSpan = _v152 
    let v229 : (System.TimeSpan -> int32) = _.Hours
    let v230 : int32 = v229 v223
    let v233 : bool = v230 > 0
    let v234 : uint8 =
        if v233 then
            1uy
        else
            0uy
    let v235 : string = method2()
    let v236 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v237 : string = v223.ToString v235 
    let _v236 = v237 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v238 : string = v223.ToString v235 
    let _v236 = v238 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v239 : string = v223.ToString v235 
    let _v236 = v239 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v240 : string = v223.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v236 = v240 
    #endif
#if FABLE_COMPILER_PYTHON
    let v241 : string = v223.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v236 = v241 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v242 : string = v223.ToString v235 
    let _v236 = v242 
    #endif
#else
    let v243 : string = v223.ToString v235 
    let _v236 = v243 
    #endif
    let v244 : string = _v236 
    let v247 : string = $"{v234}{v244.[0..1]}{v244.[3..4]}"
    let v248 : (System.Guid -> string) = _.ToString()
    let v249 : string = v248 v0
    let v252 : System.Guid = System.Guid $"{v129}{v247}{v249.[v129.Length + v247.Length..]}"
    let _v2 = v252 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v253 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v256 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v257 : System.DateTime = v256 v253
    let v260 : System.DateTimeKind = System.DateTimeKind.Local
    let v261 : System.DateTime = System.DateTime.SpecifyKind (v1, v260)
    let v262 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v263 : System.DateTime = v262 v261
    let v266 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v267 : (System.DateTime -> int64) = _.Ticks
    let v268 : int64 = v267 v263
    let _v266 = v268 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v269 : (System.DateTime -> int64) = _.Ticks
    let v270 : int64 = v269 v263
    let _v266 = v270 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v271 : int64 = null |> unbox<int64>
    let _v266 = v271 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v274 : (System.DateTime -> int64) = _.Ticks
    let v275 : int64 = v274 v263
    let _v266 = v275 
    #endif
#if FABLE_COMPILER_PYTHON
    let v276 : (System.DateTime -> int64) = _.Ticks
    let v277 : int64 = v276 v263
    let _v266 = v277 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v278 : (System.DateTime -> int64) = _.Ticks
    let v279 : int64 = v278 v263
    let _v266 = v279 
    #endif
#else
    let v280 : (System.DateTime -> int64) = _.Ticks
    let v281 : int64 = v280 v263
    let _v266 = v281 
    #endif
    let v282 : int64 = _v266 
    let v299 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v300 : (System.DateTime -> int64) = _.Ticks
    let v301 : int64 = v300 v257
    let _v299 = v301 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v302 : (System.DateTime -> int64) = _.Ticks
    let v303 : int64 = v302 v257
    let _v299 = v303 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v304 : int64 = null |> unbox<int64>
    let _v299 = v304 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v307 : (System.DateTime -> int64) = _.Ticks
    let v308 : int64 = v307 v257
    let _v299 = v308 
    #endif
#if FABLE_COMPILER_PYTHON
    let v309 : (System.DateTime -> int64) = _.Ticks
    let v310 : int64 = v309 v257
    let _v299 = v310 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v311 : (System.DateTime -> int64) = _.Ticks
    let v312 : int64 = v311 v257
    let _v299 = v312 
    #endif
#else
    let v313 : (System.DateTime -> int64) = _.Ticks
    let v314 : int64 = v313 v257
    let _v299 = v314 
    #endif
    let v315 : int64 = _v299 
    let v332 : int64 = v282 |> int64 
    let v335 : int64 = v315 |> int64 
    let v338 : int64 = v332 - v335
    let v339 : int64 = v338 / 10L
    let v340 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v341 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v339 v340 
    let v342 : (chrono_DateTime<chrono_Utc> -> US0) = method1()
    let v343 : US0 option = v341 |> Option.map v342 
    let v354 : US0 = US0_1
    let v355 : US0 = v343 |> Option.defaultValue v354 
    let v375 : US1 =
        match v355 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v359) -> (* Some *)
            let v360 : string = "$0.naive_utc()"
            let v361 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v359 v360 
            let v362 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v363 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v361 v362 
            let v364 : string = "%Y%m%d-%H%M-%S%f"
            let v365 : string = "r#\"" + v364 + "\"#"
            let v366 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v365 
            let v367 : string = "$0.format($1).to_string()"
            let v368 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v363, v366) v367 
            let v369 : string = "fable_library_rust::String_::fromString($0)"
            let v370 : string = Fable.Core.RustInterop.emitRustExpr v368 v369 
            let v371 : string = $"{v370.[0..17]}-{v370.[18..21]}-{v370.[22]}"
            US1_0(v371)
    let v379 : string =
        match v375 with
        | US1_1 -> (* None *)
            let v377 : string = ""
            v377
        | US1_0(v376) -> (* Some *)
            v376
    let v380 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v381 : string = "0i64.into()"
    let v382 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v381 
    let _v380 = v382 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v383 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v380 = v383 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v386 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v380 = v386 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v389 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v380 = v389 
    #endif
#if FABLE_COMPILER_PYTHON
    let v392 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v380 = v392 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v395 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v380 = v395 
    #endif
#else
    let v396 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v380 = v396 
    #endif
    let v397 : System.TimeZoneInfo = _v380 
    let v402 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v403 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v404 : System.TimeSpan = v403 ()
    let _v402 = v404 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v407 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v408 : System.TimeSpan = v407 ()
    let _v402 = v408 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v411 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v412 : System.TimeSpan = v411 ()
    let _v402 = v412 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v415 : US2 = US2_0
    let v416 : US3 = US3_3(v415)
    let v417 : string = $"date_time.get_utc_offset / target: {v416}"
    let v418 : System.TimeSpan = failwith<System.TimeSpan> v417
    let _v402 = v418 
    #endif
#if FABLE_COMPILER_PYTHON
    let v419 : US2 = US2_0
    let v420 : US3 = US3_4(v419)
    let v421 : string = $"date_time.get_utc_offset / target: {v420}"
    let v422 : System.TimeSpan = failwith<System.TimeSpan> v421
    let _v402 = v422 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v423 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v424 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v425 : string = "0i64.into()"
    let v426 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v425 
    let _v424 = v426 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v427 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v424 = v427 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v430 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v424 = v430 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v433 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v424 = v433 
    #endif
#if FABLE_COMPILER_PYTHON
    let v436 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v424 = v436 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v439 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v424 = v439 
    #endif
#else
    let v440 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v424 = v440 
    #endif
    let v441 : System.TimeZoneInfo = _v424 
    let v446 : (System.DateTime -> System.TimeSpan) = v423 v441
    let v447 : System.TimeSpan = v446 v263
    let _v402 = v447 
    #endif
#else
    let v448 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v449 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v450 : string = "0i64.into()"
    let v451 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v450 
    let _v449 = v451 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v452 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v449 = v452 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v455 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v449 = v455 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v458 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v449 = v458 
    #endif
#if FABLE_COMPILER_PYTHON
    let v461 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v449 = v461 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v464 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v449 = v464 
    #endif
#else
    let v465 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v449 = v465 
    #endif
    let v466 : System.TimeZoneInfo = _v449 
    let v471 : (System.DateTime -> System.TimeSpan) = v448 v466
    let v472 : System.TimeSpan = v471 v263
    let _v402 = v472 
    #endif
    let v473 : System.TimeSpan = _v402 
    let v479 : (System.TimeSpan -> int32) = _.Hours
    let v480 : int32 = v479 v473
    let v483 : bool = v480 > 0
    let v484 : uint8 =
        if v483 then
            1uy
        else
            0uy
    let v485 : string = method2()
    let v486 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v487 : string = v473.ToString v485 
    let _v486 = v487 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v488 : string = v473.ToString v485 
    let _v486 = v488 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v489 : string = v473.ToString v485 
    let _v486 = v489 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v490 : string = v473.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v486 = v490 
    #endif
#if FABLE_COMPILER_PYTHON
    let v491 : string = v473.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v486 = v491 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v492 : string = v473.ToString v485 
    let _v486 = v492 
    #endif
#else
    let v493 : string = v473.ToString v485 
    let _v486 = v493 
    #endif
    let v494 : string = _v486 
    let v497 : string = $"{v484}{v494.[0..1]}{v494.[3..4]}"
    let v498 : (System.Guid -> string) = _.ToString()
    let v499 : string = v498 v0
    let v502 : System.Guid = System.Guid $"{v379}{v497}{v499.[v379.Length + v497.Length..]}"
    let _v2 = v502 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v503 : System.Guid = null |> unbox<System.Guid>
    let _v2 = v503 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v506 : string = method3()
    let v507 : (string -> string) = v1.ToString
    let v508 : string = v507 v506
    let v511 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v512 : string = "0i64.into()"
    let v513 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v512 
    let _v511 = v513 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v514 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v511 = v514 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v517 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v511 = v517 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v520 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v511 = v520 
    #endif
#if FABLE_COMPILER_PYTHON
    let v523 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v511 = v523 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v526 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v511 = v526 
    #endif
#else
    let v527 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v511 = v527 
    #endif
    let v528 : System.TimeZoneInfo = _v511 
    let v533 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v534 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v535 : System.TimeSpan = v534 ()
    let _v533 = v535 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v538 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v539 : System.TimeSpan = v538 ()
    let _v533 = v539 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v542 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v543 : System.TimeSpan = v542 ()
    let _v533 = v543 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v546 : US2 = US2_0
    let v547 : US3 = US3_3(v546)
    let v548 : string = $"date_time.get_utc_offset / target: {v547}"
    let v549 : System.TimeSpan = failwith<System.TimeSpan> v548
    let _v533 = v549 
    #endif
#if FABLE_COMPILER_PYTHON
    let v550 : US2 = US2_0
    let v551 : US3 = US3_4(v550)
    let v552 : string = $"date_time.get_utc_offset / target: {v551}"
    let v553 : System.TimeSpan = failwith<System.TimeSpan> v552
    let _v533 = v553 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v554 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v555 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v556 : string = "0i64.into()"
    let v557 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v556 
    let _v555 = v557 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v558 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v555 = v558 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v561 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v555 = v561 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v564 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v555 = v564 
    #endif
#if FABLE_COMPILER_PYTHON
    let v567 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v555 = v567 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v570 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v555 = v570 
    #endif
#else
    let v571 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v555 = v571 
    #endif
    let v572 : System.TimeZoneInfo = _v555 
    let v577 : (System.DateTime -> System.TimeSpan) = v554 v572
    let v578 : System.TimeSpan = v577 v1
    let _v533 = v578 
    #endif
#else
    let v579 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v580 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v581 : string = "0i64.into()"
    let v582 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v581 
    let _v580 = v582 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v583 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v580 = v583 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v586 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v580 = v586 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v589 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v580 = v589 
    #endif
#if FABLE_COMPILER_PYTHON
    let v592 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v580 = v592 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v595 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v580 = v595 
    #endif
#else
    let v596 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v580 = v596 
    #endif
    let v597 : System.TimeZoneInfo = _v580 
    let v602 : (System.DateTime -> System.TimeSpan) = v579 v597
    let v603 : System.TimeSpan = v602 v1
    let _v533 = v603 
    #endif
    let v604 : System.TimeSpan = _v533 
    let v610 : (System.TimeSpan -> int32) = _.Hours
    let v611 : int32 = v610 v604
    let v614 : bool = v611 > 0
    let v615 : uint8 =
        if v614 then
            1uy
        else
            0uy
    let v616 : string = method4()
    let v617 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v618 : string = v604.ToString v616 
    let _v617 = v618 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v619 : string = v604.ToString v616 
    let _v617 = v619 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v620 : string = v604.ToString v616 
    let _v617 = v620 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v621 : string = v604.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v617 = v621 
    #endif
#if FABLE_COMPILER_PYTHON
    let v622 : string = v604.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v617 = v622 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v623 : string = v604.ToString v616 
    let _v617 = v623 
    #endif
#else
    let v624 : string = v604.ToString v616 
    let _v617 = v624 
    #endif
    let v625 : string = _v617 
    let v628 : string = $"{v615}{v625}"
    let v629 : (System.Guid -> string) = _.ToString()
    let v630 : string = v629 v0
    let v633 : System.Guid = System.Guid $"{v508}{v628}{v630.[v508.Length + v628.Length..]}"
    let _v2 = v633 
    #endif
#if FABLE_COMPILER_PYTHON
    let v634 : string = method3()
    let v635 : (string -> string) = v1.ToString
    let v636 : string = v635 v634
    let v639 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v640 : string = "0i64.into()"
    let v641 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v640 
    let _v639 = v641 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v642 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v639 = v642 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v645 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v639 = v645 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v648 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v639 = v648 
    #endif
#if FABLE_COMPILER_PYTHON
    let v651 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v639 = v651 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v654 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v639 = v654 
    #endif
#else
    let v655 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v639 = v655 
    #endif
    let v656 : System.TimeZoneInfo = _v639 
    let v661 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v662 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v663 : System.TimeSpan = v662 ()
    let _v661 = v663 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v666 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v667 : System.TimeSpan = v666 ()
    let _v661 = v667 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v670 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v671 : System.TimeSpan = v670 ()
    let _v661 = v671 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v674 : US2 = US2_0
    let v675 : US3 = US3_3(v674)
    let v676 : string = $"date_time.get_utc_offset / target: {v675}"
    let v677 : System.TimeSpan = failwith<System.TimeSpan> v676
    let _v661 = v677 
    #endif
#if FABLE_COMPILER_PYTHON
    let v678 : US2 = US2_0
    let v679 : US3 = US3_4(v678)
    let v680 : string = $"date_time.get_utc_offset / target: {v679}"
    let v681 : System.TimeSpan = failwith<System.TimeSpan> v680
    let _v661 = v681 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v682 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v683 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v684 : string = "0i64.into()"
    let v685 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v684 
    let _v683 = v685 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v686 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v683 = v686 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v689 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v683 = v689 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v692 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v683 = v692 
    #endif
#if FABLE_COMPILER_PYTHON
    let v695 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v683 = v695 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v698 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v683 = v698 
    #endif
#else
    let v699 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v683 = v699 
    #endif
    let v700 : System.TimeZoneInfo = _v683 
    let v705 : (System.DateTime -> System.TimeSpan) = v682 v700
    let v706 : System.TimeSpan = v705 v1
    let _v661 = v706 
    #endif
#else
    let v707 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v708 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v709 : string = "0i64.into()"
    let v710 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v709 
    let _v708 = v710 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v711 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v708 = v711 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v714 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v708 = v714 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v717 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v708 = v717 
    #endif
#if FABLE_COMPILER_PYTHON
    let v720 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v708 = v720 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v723 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v708 = v723 
    #endif
#else
    let v724 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v708 = v724 
    #endif
    let v725 : System.TimeZoneInfo = _v708 
    let v730 : (System.DateTime -> System.TimeSpan) = v707 v725
    let v731 : System.TimeSpan = v730 v1
    let _v661 = v731 
    #endif
    let v732 : System.TimeSpan = _v661 
    let v738 : (System.TimeSpan -> int32) = _.Hours
    let v739 : int32 = v738 v732
    let v742 : bool = v739 > 0
    let v743 : uint8 =
        if v742 then
            1uy
        else
            0uy
    let v744 : string = method4()
    let v745 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v746 : string = v732.ToString v744 
    let _v745 = v746 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v747 : string = v732.ToString v744 
    let _v745 = v747 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v748 : string = v732.ToString v744 
    let _v745 = v748 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v749 : string = v732.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v745 = v749 
    #endif
#if FABLE_COMPILER_PYTHON
    let v750 : string = v732.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v745 = v750 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v751 : string = v732.ToString v744 
    let _v745 = v751 
    #endif
#else
    let v752 : string = v732.ToString v744 
    let _v745 = v752 
    #endif
    let v753 : string = _v745 
    let v756 : string = $"{v743}{v753}"
    let v757 : (System.Guid -> string) = _.ToString()
    let v758 : string = v757 v0
    let v761 : System.Guid = System.Guid $"{v636}{v756}{v758.[v636.Length + v756.Length..]}"
    let _v2 = v761 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v762 : string = method3()
    let v763 : (string -> string) = v1.ToString
    let v764 : string = v763 v762
    let v767 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v768 : string = "0i64.into()"
    let v769 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v768 
    let _v767 = v769 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v770 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v767 = v770 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v773 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v767 = v773 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v776 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v767 = v776 
    #endif
#if FABLE_COMPILER_PYTHON
    let v779 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v767 = v779 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v782 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v767 = v782 
    #endif
#else
    let v783 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v767 = v783 
    #endif
    let v784 : System.TimeZoneInfo = _v767 
    let v789 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v790 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v791 : System.TimeSpan = v790 ()
    let _v789 = v791 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v794 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v795 : System.TimeSpan = v794 ()
    let _v789 = v795 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v798 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v799 : System.TimeSpan = v798 ()
    let _v789 = v799 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v802 : US2 = US2_0
    let v803 : US3 = US3_3(v802)
    let v804 : string = $"date_time.get_utc_offset / target: {v803}"
    let v805 : System.TimeSpan = failwith<System.TimeSpan> v804
    let _v789 = v805 
    #endif
#if FABLE_COMPILER_PYTHON
    let v806 : US2 = US2_0
    let v807 : US3 = US3_4(v806)
    let v808 : string = $"date_time.get_utc_offset / target: {v807}"
    let v809 : System.TimeSpan = failwith<System.TimeSpan> v808
    let _v789 = v809 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v810 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v811 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v812 : string = "0i64.into()"
    let v813 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v812 
    let _v811 = v813 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v814 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v811 = v814 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v817 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v811 = v817 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v820 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v811 = v820 
    #endif
#if FABLE_COMPILER_PYTHON
    let v823 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v811 = v823 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v826 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v811 = v826 
    #endif
#else
    let v827 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v811 = v827 
    #endif
    let v828 : System.TimeZoneInfo = _v811 
    let v833 : (System.DateTime -> System.TimeSpan) = v810 v828
    let v834 : System.TimeSpan = v833 v1
    let _v789 = v834 
    #endif
#else
    let v835 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v836 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v837 : string = "0i64.into()"
    let v838 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v837 
    let _v836 = v838 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v839 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v836 = v839 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v842 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v836 = v842 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v845 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v836 = v845 
    #endif
#if FABLE_COMPILER_PYTHON
    let v848 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v836 = v848 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v851 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v836 = v851 
    #endif
#else
    let v852 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v836 = v852 
    #endif
    let v853 : System.TimeZoneInfo = _v836 
    let v858 : (System.DateTime -> System.TimeSpan) = v835 v853
    let v859 : System.TimeSpan = v858 v1
    let _v789 = v859 
    #endif
    let v860 : System.TimeSpan = _v789 
    let v866 : (System.TimeSpan -> int32) = _.Hours
    let v867 : int32 = v866 v860
    let v870 : bool = v867 > 0
    let v871 : uint8 =
        if v870 then
            1uy
        else
            0uy
    let v872 : string = method4()
    let v873 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v874 : string = v860.ToString v872 
    let _v873 = v874 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v875 : string = v860.ToString v872 
    let _v873 = v875 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v876 : string = v860.ToString v872 
    let _v873 = v876 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v877 : string = v860.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v873 = v877 
    #endif
#if FABLE_COMPILER_PYTHON
    let v878 : string = v860.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v873 = v878 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v879 : string = v860.ToString v872 
    let _v873 = v879 
    #endif
#else
    let v880 : string = v860.ToString v872 
    let _v873 = v880 
    #endif
    let v881 : string = _v873 
    let v884 : string = $"{v871}{v881}"
    let v885 : (System.Guid -> string) = _.ToString()
    let v886 : string = v885 v0
    let v889 : System.Guid = System.Guid $"{v764}{v884}{v886.[v764.Length + v884.Length..]}"
    let _v2 = v889 
    #endif
#else
    let v890 : string = method3()
    let v891 : (string -> string) = v1.ToString
    let v892 : string = v891 v890
    let v895 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v896 : string = "0i64.into()"
    let v897 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v896 
    let _v895 = v897 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v898 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v895 = v898 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v901 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v895 = v901 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v904 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v895 = v904 
    #endif
#if FABLE_COMPILER_PYTHON
    let v907 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v895 = v907 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v910 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v895 = v910 
    #endif
#else
    let v911 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v895 = v911 
    #endif
    let v912 : System.TimeZoneInfo = _v895 
    let v917 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v918 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v919 : System.TimeSpan = v918 ()
    let _v917 = v919 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v922 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v923 : System.TimeSpan = v922 ()
    let _v917 = v923 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v926 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v927 : System.TimeSpan = v926 ()
    let _v917 = v927 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v930 : US2 = US2_0
    let v931 : US3 = US3_3(v930)
    let v932 : string = $"date_time.get_utc_offset / target: {v931}"
    let v933 : System.TimeSpan = failwith<System.TimeSpan> v932
    let _v917 = v933 
    #endif
#if FABLE_COMPILER_PYTHON
    let v934 : US2 = US2_0
    let v935 : US3 = US3_4(v934)
    let v936 : string = $"date_time.get_utc_offset / target: {v935}"
    let v937 : System.TimeSpan = failwith<System.TimeSpan> v936
    let _v917 = v937 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v938 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v939 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v940 : string = "0i64.into()"
    let v941 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v940 
    let _v939 = v941 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v942 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v939 = v942 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v945 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v939 = v945 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v948 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v939 = v948 
    #endif
#if FABLE_COMPILER_PYTHON
    let v951 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v939 = v951 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v954 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v939 = v954 
    #endif
#else
    let v955 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v939 = v955 
    #endif
    let v956 : System.TimeZoneInfo = _v939 
    let v961 : (System.DateTime -> System.TimeSpan) = v938 v956
    let v962 : System.TimeSpan = v961 v1
    let _v917 = v962 
    #endif
#else
    let v963 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v964 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v965 : string = "0i64.into()"
    let v966 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v965 
    let _v964 = v966 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v967 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v964 = v967 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v970 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v964 = v970 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v973 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v964 = v973 
    #endif
#if FABLE_COMPILER_PYTHON
    let v976 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v964 = v976 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v979 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v964 = v979 
    #endif
#else
    let v980 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v964 = v980 
    #endif
    let v981 : System.TimeZoneInfo = _v964 
    let v986 : (System.DateTime -> System.TimeSpan) = v963 v981
    let v987 : System.TimeSpan = v986 v1
    let _v917 = v987 
    #endif
    let v988 : System.TimeSpan = _v917 
    let v994 : (System.TimeSpan -> int32) = _.Hours
    let v995 : int32 = v994 v988
    let v998 : bool = v995 > 0
    let v999 : uint8 =
        if v998 then
            1uy
        else
            0uy
    let v1000 : string = method4()
    let v1001 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1002 : string = v988.ToString v1000 
    let _v1001 = v1002 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1003 : string = v988.ToString v1000 
    let _v1001 = v1003 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1004 : string = v988.ToString v1000 
    let _v1001 = v1004 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1005 : string = v988.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1001 = v1005 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1006 : string = v988.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1001 = v1006 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1007 : string = v988.ToString v1000 
    let _v1001 = v1007 
    #endif
#else
    let v1008 : string = v988.ToString v1000 
    let _v1001 = v1008 
    #endif
    let v1009 : string = _v1001 
    let v1012 : string = $"{v999}{v1009}"
    let v1013 : (System.Guid -> string) = _.ToString()
    let v1014 : string = v1013 v0
    let v1017 : System.Guid = System.Guid $"{v892}{v1012}{v1014.[v892.Length + v1012.Length..]}"
    let _v2 = v1017 
    #endif
    let v1018 : System.Guid = _v2 
    v1018
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
