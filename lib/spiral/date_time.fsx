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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v81 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v66 = v81 
    #endif
#else
    let v82 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v66 = v82 
    #endif
    let v83 : System.TimeZoneInfo = _v66 
    let v88 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v90 : System.TimeSpan = v89 ()
    let _v88 = v90 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v93 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v94 : System.TimeSpan = v93 ()
    let _v88 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v97 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v98 : System.TimeSpan = v97 ()
    let _v88 = v98 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v101 : US2 = US2_0
    let v102 : US3 = US3_3(v101)
    let v103 : string = $"date_time.get_utc_offset / target: {v102}"
    let v104 : System.TimeSpan = failwith<System.TimeSpan> v103
    let _v88 = v104 
    #endif
#if FABLE_COMPILER_PYTHON
    let v105 : US2 = US2_0
    let v106 : US3 = US3_4(v105)
    let v107 : string = $"date_time.get_utc_offset / target: {v106}"
    let v108 : System.TimeSpan = failwith<System.TimeSpan> v107
    let _v88 = v108 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v109 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v110 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : string = "0i64.into()"
    let v112 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v111 
    let _v110 = v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v110 = v113 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v116 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v110 = v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v119 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v110 = v119 
    #endif
#if FABLE_COMPILER_PYTHON
    let v122 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v110 = v122 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v125 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v110 = v125 
    #endif
#else
    let v126 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v110 = v126 
    #endif
    let v127 : System.TimeZoneInfo = _v110 
    let v132 : (System.DateTime -> System.TimeSpan) = v109 v127
    let v133 : System.TimeSpan = v132 v13
    let _v88 = v133 
    #endif
#else
    let v134 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v135 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v136 : string = "0i64.into()"
    let v137 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v136 
    let _v135 = v137 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v138 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v135 = v138 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v135 = v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v135 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v147 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v135 = v147 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v150 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v135 = v150 
    #endif
#else
    let v151 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v135 = v151 
    #endif
    let v152 : System.TimeZoneInfo = _v135 
    let v157 : (System.DateTime -> System.TimeSpan) = v134 v152
    let v158 : System.TimeSpan = v157 v13
    let _v88 = v158 
    #endif
    let v159 : System.TimeSpan = _v88 
    let v165 : (System.TimeSpan -> int32) = _.Hours
    let v166 : int32 = v165 v159
    let v169 : bool = v166 > 0
    let v170 : uint8 =
        if v169 then
            1uy
        else
            0uy
    let v171 : string = method2()
    let v172 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v173 : string = v159.ToString v171 
    let _v172 = v173 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v174 : string = v159.ToString v171 
    let _v172 = v174 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v175 : string = v159.ToString v171 
    let _v172 = v175 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v176 : string = v159.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v172 = v176 
    #endif
#if FABLE_COMPILER_PYTHON
    let v177 : string = v159.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v172 = v177 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v178 : string = v159.ToString v171 
    let _v172 = v178 
    #endif
#else
    let v179 : string = v159.ToString v171 
    let _v172 = v179 
    #endif
    let v180 : string = _v172 
    let v183 : string = $"{v170}{v180.[0..1]}{v180.[3..4]}"
    let v184 : (System.Guid -> string) = _.ToString()
    let v185 : string = v184 v0
    let v188 : System.Guid = System.Guid $"{v65}{v183}{v185.[v65.Length + v183.Length..]}"
    let _v2 = v188 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v189 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v192 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v193 : System.DateTime = v192 v189
    let v196 : System.DateTimeKind = System.DateTimeKind.Local
    let v197 : System.DateTime = System.DateTime.SpecifyKind (v1, v196)
    let v198 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v199 : System.DateTime = v198 v197
    let v202 : (System.DateTime -> int64) = _.Ticks
    let v203 : int64 = v202 v199
    let v206 : (System.DateTime -> int64) = _.Ticks
    let v207 : int64 = v206 v193
    let v210 : int64 = v203 - v207
    let v211 : int64 = v210 / 10L
    let v212 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v213 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v211 v212 
    let v214 : (chrono_DateTime<chrono_Utc> -> US0) = method1()
    let v215 : US0 option = v213 |> Option.map v214 
    let v226 : US0 = US0_1
    let v227 : US0 = v215 |> Option.defaultValue v226 
    let v247 : US1 =
        match v227 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v231) -> (* Some *)
            let v232 : string = "$0.naive_utc()"
            let v233 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v231 v232 
            let v234 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v235 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v233 v234 
            let v236 : string = "%Y%m%d-%H%M-%S%f"
            let v237 : string = "r#\"" + v236 + "\"#"
            let v238 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v237 
            let v239 : string = "$0.format($1).to_string()"
            let v240 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v235, v238) v239 
            let v241 : string = "fable_library_rust::String_::fromString($0)"
            let v242 : string = Fable.Core.RustInterop.emitRustExpr v240 v241 
            let v243 : string = $"{v242.[0..17]}-{v242.[18..21]}-{v242.[22]}"
            US1_0(v243)
    let v251 : string =
        match v247 with
        | US1_1 -> (* None *)
            let v249 : string = ""
            v249
        | US1_0(v248) -> (* Some *)
            v248
    let v252 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v253 : string = "0i64.into()"
    let v254 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v253 
    let _v252 = v254 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v255 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v252 = v255 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v258 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v252 = v258 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v261 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v252 = v261 
    #endif
#if FABLE_COMPILER_PYTHON
    let v264 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v252 = v264 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v267 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v252 = v267 
    #endif
#else
    let v268 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v252 = v268 
    #endif
    let v269 : System.TimeZoneInfo = _v252 
    let v274 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v275 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v276 : System.TimeSpan = v275 ()
    let _v274 = v276 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v279 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v280 : System.TimeSpan = v279 ()
    let _v274 = v280 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v283 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v284 : System.TimeSpan = v283 ()
    let _v274 = v284 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v287 : US2 = US2_0
    let v288 : US3 = US3_3(v287)
    let v289 : string = $"date_time.get_utc_offset / target: {v288}"
    let v290 : System.TimeSpan = failwith<System.TimeSpan> v289
    let _v274 = v290 
    #endif
#if FABLE_COMPILER_PYTHON
    let v291 : US2 = US2_0
    let v292 : US3 = US3_4(v291)
    let v293 : string = $"date_time.get_utc_offset / target: {v292}"
    let v294 : System.TimeSpan = failwith<System.TimeSpan> v293
    let _v274 = v294 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v295 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v296 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v297 : string = "0i64.into()"
    let v298 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v297 
    let _v296 = v298 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v299 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v296 = v299 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v302 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v296 = v302 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v305 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v296 = v305 
    #endif
#if FABLE_COMPILER_PYTHON
    let v308 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v296 = v308 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v311 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v296 = v311 
    #endif
#else
    let v312 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v296 = v312 
    #endif
    let v313 : System.TimeZoneInfo = _v296 
    let v318 : (System.DateTime -> System.TimeSpan) = v295 v313
    let v319 : System.TimeSpan = v318 v199
    let _v274 = v319 
    #endif
#else
    let v320 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v321 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v322 : string = "0i64.into()"
    let v323 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v322 
    let _v321 = v323 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v324 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v321 = v324 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v327 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v321 = v327 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v330 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v321 = v330 
    #endif
#if FABLE_COMPILER_PYTHON
    let v333 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v321 = v333 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v336 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v321 = v336 
    #endif
#else
    let v337 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v321 = v337 
    #endif
    let v338 : System.TimeZoneInfo = _v321 
    let v343 : (System.DateTime -> System.TimeSpan) = v320 v338
    let v344 : System.TimeSpan = v343 v199
    let _v274 = v344 
    #endif
    let v345 : System.TimeSpan = _v274 
    let v351 : (System.TimeSpan -> int32) = _.Hours
    let v352 : int32 = v351 v345
    let v355 : bool = v352 > 0
    let v356 : uint8 =
        if v355 then
            1uy
        else
            0uy
    let v357 : string = method2()
    let v358 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v359 : string = v345.ToString v357 
    let _v358 = v359 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v360 : string = v345.ToString v357 
    let _v358 = v360 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v361 : string = v345.ToString v357 
    let _v358 = v361 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v362 : string = v345.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v358 = v362 
    #endif
#if FABLE_COMPILER_PYTHON
    let v363 : string = v345.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v358 = v363 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v364 : string = v345.ToString v357 
    let _v358 = v364 
    #endif
#else
    let v365 : string = v345.ToString v357 
    let _v358 = v365 
    #endif
    let v366 : string = _v358 
    let v369 : string = $"{v356}{v366.[0..1]}{v366.[3..4]}"
    let v370 : (System.Guid -> string) = _.ToString()
    let v371 : string = v370 v0
    let v374 : System.Guid = System.Guid $"{v251}{v369}{v371.[v251.Length + v369.Length..]}"
    let _v2 = v374 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v375 : System.Guid = null |> unbox<System.Guid>
    let _v2 = v375 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v378 : string = method3()
    let v379 : (string -> string) = v1.ToString
    let v380 : string = v379 v378
    let v383 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v384 : string = "0i64.into()"
    let v385 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v384 
    let _v383 = v385 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v386 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v383 = v386 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v389 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v383 = v389 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v392 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v383 = v392 
    #endif
#if FABLE_COMPILER_PYTHON
    let v395 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v383 = v395 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v398 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v383 = v398 
    #endif
#else
    let v399 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v383 = v399 
    #endif
    let v400 : System.TimeZoneInfo = _v383 
    let v405 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v406 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v407 : System.TimeSpan = v406 ()
    let _v405 = v407 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v410 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v411 : System.TimeSpan = v410 ()
    let _v405 = v411 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v414 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v415 : System.TimeSpan = v414 ()
    let _v405 = v415 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v418 : US2 = US2_0
    let v419 : US3 = US3_3(v418)
    let v420 : string = $"date_time.get_utc_offset / target: {v419}"
    let v421 : System.TimeSpan = failwith<System.TimeSpan> v420
    let _v405 = v421 
    #endif
#if FABLE_COMPILER_PYTHON
    let v422 : US2 = US2_0
    let v423 : US3 = US3_4(v422)
    let v424 : string = $"date_time.get_utc_offset / target: {v423}"
    let v425 : System.TimeSpan = failwith<System.TimeSpan> v424
    let _v405 = v425 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v426 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v442 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v427 = v442 
    #endif
#else
    let v443 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v427 = v443 
    #endif
    let v444 : System.TimeZoneInfo = _v427 
    let v449 : (System.DateTime -> System.TimeSpan) = v426 v444
    let v450 : System.TimeSpan = v449 v1
    let _v405 = v450 
    #endif
#else
    let v451 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v452 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v453 : string = "0i64.into()"
    let v454 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v453 
    let _v452 = v454 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v455 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v452 = v455 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v458 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v452 = v458 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v461 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v452 = v461 
    #endif
#if FABLE_COMPILER_PYTHON
    let v464 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v452 = v464 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v467 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v452 = v467 
    #endif
#else
    let v468 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v452 = v468 
    #endif
    let v469 : System.TimeZoneInfo = _v452 
    let v474 : (System.DateTime -> System.TimeSpan) = v451 v469
    let v475 : System.TimeSpan = v474 v1
    let _v405 = v475 
    #endif
    let v476 : System.TimeSpan = _v405 
    let v482 : (System.TimeSpan -> int32) = _.Hours
    let v483 : int32 = v482 v476
    let v486 : bool = v483 > 0
    let v487 : uint8 =
        if v486 then
            1uy
        else
            0uy
    let v488 : string = method4()
    let v489 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v490 : string = v476.ToString v488 
    let _v489 = v490 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v491 : string = v476.ToString v488 
    let _v489 = v491 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v492 : string = v476.ToString v488 
    let _v489 = v492 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v493 : string = v476.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v489 = v493 
    #endif
#if FABLE_COMPILER_PYTHON
    let v494 : string = v476.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v489 = v494 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v495 : string = v476.ToString v488 
    let _v489 = v495 
    #endif
#else
    let v496 : string = v476.ToString v488 
    let _v489 = v496 
    #endif
    let v497 : string = _v489 
    let v500 : string = $"{v487}{v497}"
    let v501 : (System.Guid -> string) = _.ToString()
    let v502 : string = v501 v0
    let v505 : System.Guid = System.Guid $"{v380}{v500}{v502.[v380.Length + v500.Length..]}"
    let _v2 = v505 
    #endif
#if FABLE_COMPILER_PYTHON
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
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
#else
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
    let v890 : System.Guid = _v2 
    v890
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
