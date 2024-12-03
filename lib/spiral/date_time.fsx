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
    let v514 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v515 : string = "0i64.into()"
    let v516 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v515 
    let _v514 = v516 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v517 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v514 = v517 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v520 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v514 = v520 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v523 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v514 = v523 
    #endif
#if FABLE_COMPILER_PYTHON
    let v526 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v514 = v526 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v529 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v514 = v529 
    #endif
#else
    let v530 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v514 = v530 
    #endif
    let v531 : System.TimeZoneInfo = _v514 
    let v536 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v537 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v538 : System.TimeSpan = v537 ()
    let _v536 = v538 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v541 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v542 : System.TimeSpan = v541 ()
    let _v536 = v542 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v545 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v546 : System.TimeSpan = v545 ()
    let _v536 = v546 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v549 : US2 = US2_0
    let v550 : US3 = US3_3(v549)
    let v551 : string = $"date_time.get_utc_offset / target: {v550}"
    let v552 : System.TimeSpan = failwith<System.TimeSpan> v551
    let _v536 = v552 
    #endif
#if FABLE_COMPILER_PYTHON
    let v553 : US2 = US2_0
    let v554 : US3 = US3_4(v553)
    let v555 : string = $"date_time.get_utc_offset / target: {v554}"
    let v556 : System.TimeSpan = failwith<System.TimeSpan> v555
    let _v536 = v556 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v557 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v558 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v559 : string = "0i64.into()"
    let v560 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v559 
    let _v558 = v560 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v561 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v558 = v561 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v564 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v558 = v564 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v567 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v558 = v567 
    #endif
#if FABLE_COMPILER_PYTHON
    let v570 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v558 = v570 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v573 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v558 = v573 
    #endif
#else
    let v574 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v558 = v574 
    #endif
    let v575 : System.TimeZoneInfo = _v558 
    let v580 : (System.DateTime -> System.TimeSpan) = v557 v575
    let v581 : System.TimeSpan = v580 v1
    let _v536 = v581 
    #endif
#else
    let v582 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v583 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v584 : string = "0i64.into()"
    let v585 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v584 
    let _v583 = v585 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v586 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v583 = v586 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v589 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v583 = v589 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v592 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v583 = v592 
    #endif
#if FABLE_COMPILER_PYTHON
    let v595 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v583 = v595 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v598 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v583 = v598 
    #endif
#else
    let v599 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v583 = v599 
    #endif
    let v600 : System.TimeZoneInfo = _v583 
    let v605 : (System.DateTime -> System.TimeSpan) = v582 v600
    let v606 : System.TimeSpan = v605 v1
    let _v536 = v606 
    #endif
    let v607 : System.TimeSpan = _v536 
    let v613 : (System.TimeSpan -> int32) = _.Hours
    let v614 : int32 = v613 v607
    let v617 : bool = v614 > 0
    let v618 : uint8 =
        if v617 then
            1uy
        else
            0uy
    let v619 : string = method4()
    let v620 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v621 : string = v607.ToString v619 
    let _v620 = v621 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v622 : string = v607.ToString v619 
    let _v620 = v622 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v623 : string = v607.ToString v619 
    let _v620 = v623 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v624 : string = v607.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v620 = v624 
    #endif
#if FABLE_COMPILER_PYTHON
    let v625 : string = v607.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v620 = v625 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v626 : string = v607.ToString v619 
    let _v620 = v626 
    #endif
#else
    let v627 : string = v607.ToString v619 
    let _v620 = v627 
    #endif
    let v628 : string = _v620 
    let v631 : string = $"{v618}{v628}"
    let v632 : (System.Guid -> string) = _.ToString()
    let v633 : string = v632 v0
    let v636 : System.Guid = System.Guid $"{v508}{v631}{v633.[v508.Length + v631.Length..]}"
    let _v2 = v636 
    #endif
#if FABLE_COMPILER_PYTHON
    let v637 : string = method3()
    let v638 : (string -> string) = v1.ToString
    let v639 : string = v638 v637
    let v645 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v646 : string = "0i64.into()"
    let v647 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v646 
    let _v645 = v647 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v648 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v645 = v648 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v651 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v645 = v651 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v654 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v645 = v654 
    #endif
#if FABLE_COMPILER_PYTHON
    let v657 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v645 = v657 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v660 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v645 = v660 
    #endif
#else
    let v661 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v645 = v661 
    #endif
    let v662 : System.TimeZoneInfo = _v645 
    let v667 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v668 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v669 : System.TimeSpan = v668 ()
    let _v667 = v669 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v672 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v673 : System.TimeSpan = v672 ()
    let _v667 = v673 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v676 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v677 : System.TimeSpan = v676 ()
    let _v667 = v677 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v680 : US2 = US2_0
    let v681 : US3 = US3_3(v680)
    let v682 : string = $"date_time.get_utc_offset / target: {v681}"
    let v683 : System.TimeSpan = failwith<System.TimeSpan> v682
    let _v667 = v683 
    #endif
#if FABLE_COMPILER_PYTHON
    let v684 : US2 = US2_0
    let v685 : US3 = US3_4(v684)
    let v686 : string = $"date_time.get_utc_offset / target: {v685}"
    let v687 : System.TimeSpan = failwith<System.TimeSpan> v686
    let _v667 = v687 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v688 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v689 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v690 : string = "0i64.into()"
    let v691 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v690 
    let _v689 = v691 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v692 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v689 = v692 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v695 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v689 = v695 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v698 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v689 = v698 
    #endif
#if FABLE_COMPILER_PYTHON
    let v701 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v689 = v701 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v704 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v689 = v704 
    #endif
#else
    let v705 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v689 = v705 
    #endif
    let v706 : System.TimeZoneInfo = _v689 
    let v711 : (System.DateTime -> System.TimeSpan) = v688 v706
    let v712 : System.TimeSpan = v711 v1
    let _v667 = v712 
    #endif
#else
    let v713 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v714 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v715 : string = "0i64.into()"
    let v716 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v715 
    let _v714 = v716 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v717 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v714 = v717 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v720 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v714 = v720 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v723 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v714 = v723 
    #endif
#if FABLE_COMPILER_PYTHON
    let v726 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v714 = v726 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v729 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v714 = v729 
    #endif
#else
    let v730 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v714 = v730 
    #endif
    let v731 : System.TimeZoneInfo = _v714 
    let v736 : (System.DateTime -> System.TimeSpan) = v713 v731
    let v737 : System.TimeSpan = v736 v1
    let _v667 = v737 
    #endif
    let v738 : System.TimeSpan = _v667 
    let v744 : (System.TimeSpan -> int32) = _.Hours
    let v745 : int32 = v744 v738
    let v748 : bool = v745 > 0
    let v749 : uint8 =
        if v748 then
            1uy
        else
            0uy
    let v750 : string = method4()
    let v751 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v752 : string = v738.ToString v750 
    let _v751 = v752 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v753 : string = v738.ToString v750 
    let _v751 = v753 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v754 : string = v738.ToString v750 
    let _v751 = v754 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v755 : string = v738.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v751 = v755 
    #endif
#if FABLE_COMPILER_PYTHON
    let v756 : string = v738.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v751 = v756 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v757 : string = v738.ToString v750 
    let _v751 = v757 
    #endif
#else
    let v758 : string = v738.ToString v750 
    let _v751 = v758 
    #endif
    let v759 : string = _v751 
    let v762 : string = $"{v749}{v759}"
    let v763 : (System.Guid -> string) = _.ToString()
    let v764 : string = v763 v0
    let v767 : System.Guid = System.Guid $"{v639}{v762}{v764.[v639.Length + v762.Length..]}"
    let _v2 = v767 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v768 : string = method3()
    let v769 : (string -> string) = v1.ToString
    let v770 : string = v769 v768
    let v776 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v777 : string = "0i64.into()"
    let v778 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v777 
    let _v776 = v778 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v779 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v776 = v779 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v782 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v776 = v782 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v785 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v776 = v785 
    #endif
#if FABLE_COMPILER_PYTHON
    let v788 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v776 = v788 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v791 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v776 = v791 
    #endif
#else
    let v792 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v776 = v792 
    #endif
    let v793 : System.TimeZoneInfo = _v776 
    let v798 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v799 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v800 : System.TimeSpan = v799 ()
    let _v798 = v800 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v803 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v804 : System.TimeSpan = v803 ()
    let _v798 = v804 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v807 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v808 : System.TimeSpan = v807 ()
    let _v798 = v808 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v811 : US2 = US2_0
    let v812 : US3 = US3_3(v811)
    let v813 : string = $"date_time.get_utc_offset / target: {v812}"
    let v814 : System.TimeSpan = failwith<System.TimeSpan> v813
    let _v798 = v814 
    #endif
#if FABLE_COMPILER_PYTHON
    let v815 : US2 = US2_0
    let v816 : US3 = US3_4(v815)
    let v817 : string = $"date_time.get_utc_offset / target: {v816}"
    let v818 : System.TimeSpan = failwith<System.TimeSpan> v817
    let _v798 = v818 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v819 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v820 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v821 : string = "0i64.into()"
    let v822 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v821 
    let _v820 = v822 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v823 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v820 = v823 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v826 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v820 = v826 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v829 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v820 = v829 
    #endif
#if FABLE_COMPILER_PYTHON
    let v832 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v820 = v832 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v835 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v820 = v835 
    #endif
#else
    let v836 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v820 = v836 
    #endif
    let v837 : System.TimeZoneInfo = _v820 
    let v842 : (System.DateTime -> System.TimeSpan) = v819 v837
    let v843 : System.TimeSpan = v842 v1
    let _v798 = v843 
    #endif
#else
    let v844 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v845 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v846 : string = "0i64.into()"
    let v847 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v846 
    let _v845 = v847 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v848 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v845 = v848 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v851 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v845 = v851 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v854 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v845 = v854 
    #endif
#if FABLE_COMPILER_PYTHON
    let v857 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v845 = v857 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v860 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v845 = v860 
    #endif
#else
    let v861 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v845 = v861 
    #endif
    let v862 : System.TimeZoneInfo = _v845 
    let v867 : (System.DateTime -> System.TimeSpan) = v844 v862
    let v868 : System.TimeSpan = v867 v1
    let _v798 = v868 
    #endif
    let v869 : System.TimeSpan = _v798 
    let v875 : (System.TimeSpan -> int32) = _.Hours
    let v876 : int32 = v875 v869
    let v879 : bool = v876 > 0
    let v880 : uint8 =
        if v879 then
            1uy
        else
            0uy
    let v881 : string = method4()
    let v882 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v883 : string = v869.ToString v881 
    let _v882 = v883 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v884 : string = v869.ToString v881 
    let _v882 = v884 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v885 : string = v869.ToString v881 
    let _v882 = v885 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v886 : string = v869.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v882 = v886 
    #endif
#if FABLE_COMPILER_PYTHON
    let v887 : string = v869.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v882 = v887 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v888 : string = v869.ToString v881 
    let _v882 = v888 
    #endif
#else
    let v889 : string = v869.ToString v881 
    let _v882 = v889 
    #endif
    let v890 : string = _v882 
    let v893 : string = $"{v880}{v890}"
    let v894 : (System.Guid -> string) = _.ToString()
    let v895 : string = v894 v0
    let v898 : System.Guid = System.Guid $"{v770}{v893}{v895.[v770.Length + v893.Length..]}"
    let _v2 = v898 
    #endif
#else
    let v899 : string = method3()
    let v900 : (string -> string) = v1.ToString
    let v901 : string = v900 v899
    let v907 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v908 : string = "0i64.into()"
    let v909 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v908 
    let _v907 = v909 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v910 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v907 = v910 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v913 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v907 = v913 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v916 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v907 = v916 
    #endif
#if FABLE_COMPILER_PYTHON
    let v919 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v907 = v919 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v922 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v907 = v922 
    #endif
#else
    let v923 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v907 = v923 
    #endif
    let v924 : System.TimeZoneInfo = _v907 
    let v929 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v930 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v931 : System.TimeSpan = v930 ()
    let _v929 = v931 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v934 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v935 : System.TimeSpan = v934 ()
    let _v929 = v935 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v938 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v939 : System.TimeSpan = v938 ()
    let _v929 = v939 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v942 : US2 = US2_0
    let v943 : US3 = US3_3(v942)
    let v944 : string = $"date_time.get_utc_offset / target: {v943}"
    let v945 : System.TimeSpan = failwith<System.TimeSpan> v944
    let _v929 = v945 
    #endif
#if FABLE_COMPILER_PYTHON
    let v946 : US2 = US2_0
    let v947 : US3 = US3_4(v946)
    let v948 : string = $"date_time.get_utc_offset / target: {v947}"
    let v949 : System.TimeSpan = failwith<System.TimeSpan> v948
    let _v929 = v949 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v950 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v951 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v952 : string = "0i64.into()"
    let v953 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v952 
    let _v951 = v953 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v954 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v951 = v954 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v957 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v951 = v957 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v960 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v951 = v960 
    #endif
#if FABLE_COMPILER_PYTHON
    let v963 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v951 = v963 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v966 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v951 = v966 
    #endif
#else
    let v967 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v951 = v967 
    #endif
    let v968 : System.TimeZoneInfo = _v951 
    let v973 : (System.DateTime -> System.TimeSpan) = v950 v968
    let v974 : System.TimeSpan = v973 v1
    let _v929 = v974 
    #endif
#else
    let v975 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v976 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v977 : string = "0i64.into()"
    let v978 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v977 
    let _v976 = v978 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v979 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v976 = v979 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v982 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v976 = v982 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v985 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v976 = v985 
    #endif
#if FABLE_COMPILER_PYTHON
    let v988 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v976 = v988 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v991 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v976 = v991 
    #endif
#else
    let v992 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v976 = v992 
    #endif
    let v993 : System.TimeZoneInfo = _v976 
    let v998 : (System.DateTime -> System.TimeSpan) = v975 v993
    let v999 : System.TimeSpan = v998 v1
    let _v929 = v999 
    #endif
    let v1000 : System.TimeSpan = _v929 
    let v1006 : (System.TimeSpan -> int32) = _.Hours
    let v1007 : int32 = v1006 v1000
    let v1010 : bool = v1007 > 0
    let v1011 : uint8 =
        if v1010 then
            1uy
        else
            0uy
    let v1012 : string = method4()
    let v1013 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1014 : string = v1000.ToString v1012 
    let _v1013 = v1014 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1015 : string = v1000.ToString v1012 
    let _v1013 = v1015 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1016 : string = v1000.ToString v1012 
    let _v1013 = v1016 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1017 : string = v1000.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1013 = v1017 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1018 : string = v1000.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1013 = v1018 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1019 : string = v1000.ToString v1012 
    let _v1013 = v1019 
    #endif
#else
    let v1020 : string = v1000.ToString v1012 
    let _v1013 = v1020 
    #endif
    let v1021 : string = _v1013 
    let v1024 : string = $"{v1011}{v1021}"
    let v1025 : (System.Guid -> string) = _.ToString()
    let v1026 : string = v1025 v0
    let v1029 : System.Guid = System.Guid $"{v901}{v1024}{v1026.[v901.Length + v1024.Length..]}"
    let _v2 = v1029 
    #endif
    let v1030 : System.Guid = _v2 
    v1030
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
