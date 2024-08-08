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
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
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
#endif
type Str = class end
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
    let v28 : US0 option = None
    let _v28 = ref v28 
    match v27 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v29 : chrono_DateTime<chrono_Utc> = x
    let v30 : US0 = US0_0(v29)
    v30 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v28.Value <- x
    let v31 : US0 option = _v28.Value 
    let v42 : US0 = US0_1
    let v43 : US0 = v31 |> Option.defaultValue v42 
    let v63 : US1 =
        match v43 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v47) -> (* Some *)
            let v48 : string = "$0.naive_utc()"
            let v49 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v47 v48 
            let v50 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v51 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v49 v50 
            let v52 : string = "%Y%m%d-%H%M-%S%f"
            let v53 : string = "r#\"" + v52 + "\"#"
            let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v53 
            let v55 : string = "$0.format($1).to_string()"
            let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v51, v54) v55 
            let v57 : string = "fable_library_rust::String_::fromString($0)"
            let v58 : string = Fable.Core.RustInterop.emitRustExpr v56 v57 
            let v59 : string = $"{v58.[0..17]}-{v58.[18..21]}-{v58.[22]}"
            US1_0(v59)
    let v67 : string =
        match v63 with
        | US1_1 -> (* None *)
            let v65 : string = ""
            v65
        | US1_0(v64) -> (* Some *)
            v64
    let v68 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "0i64.into()"
    let v70 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v69 
    let _v68 = v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v68 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v68 = v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v77 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v68 = v77 
    #endif
#if FABLE_COMPILER_PYTHON
    let v80 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v68 = v80 
    #endif
#else
    let v83 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v68 = v83 
    #endif
    let v84 : System.TimeZoneInfo = _v68 
    let v89 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v91 : System.TimeSpan = v90 ()
    let _v89 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v94 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v95 : System.TimeSpan = v94 ()
    let _v89 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v98 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v99 : System.TimeSpan = v98 ()
    let _v89 = v99 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v102 : US2 = US2_0
    let v103 : US3 = US3_3(v102)
    let v104 : string = $"date_time.get_utc_offset / target: {v103}"
    let v105 : System.TimeSpan = failwith<System.TimeSpan> v104
    let _v89 = v105 
    #endif
#if FABLE_COMPILER_PYTHON
    let v106 : US2 = US2_0
    let v107 : US3 = US3_4(v106)
    let v108 : string = $"date_time.get_utc_offset / target: {v107}"
    let v109 : System.TimeSpan = failwith<System.TimeSpan> v108
    let _v89 = v109 
    #endif
#else
    let v110 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v111 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v112 : string = "0i64.into()"
    let v113 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v112 
    let _v111 = v113 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v114 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v111 = v114 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v117 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v111 = v117 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v120 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v111 = v120 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v111 = v123 
    #endif
#else
    let v126 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v111 = v126 
    #endif
    let v127 : System.TimeZoneInfo = _v111 
    let v132 : (System.DateTime -> System.TimeSpan) = v110 v127
    let v133 : System.TimeSpan = v132 v13
    let _v89 = v133 
    #endif
    let v134 : System.TimeSpan = _v89 
    let v140 : (System.TimeSpan -> int32) = _.Hours
    let v141 : int32 = v140 v134
    let v144 : bool = v141 > 0
    let v145 : uint8 =
        if v144 then
            1uy
        else
            0uy
    let v146 : string = method1()
    let v147 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v148 : string = v134.ToString v146 
    let _v147 = v148 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v149 : string = v134.ToString v146 
    let _v147 = v149 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v150 : string = v134.ToString v146 
    let _v147 = v150 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v151 : string = v134.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v147 = v151 
    #endif
#if FABLE_COMPILER_PYTHON
    let v152 : string = v134.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v147 = v152 
    #endif
#else
    let v153 : string = v134.ToString v146 
    let _v147 = v153 
    #endif
    let v154 : string = _v147 
    let v157 : string = $"{v145}{v154.[0..1]}{v154.[3..4]}"
    let v158 : (System.Guid -> string) = _.ToString()
    let v159 : string = v158 v0
    let v162 : System.Guid = System.Guid $"{v67}{v157}{v159.[v67.Length + v157.Length..]}"
    let _v2 = v162 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v163 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v166 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v167 : System.DateTime = v166 v163
    let v170 : System.DateTimeKind = System.DateTimeKind.Local
    let v171 : System.DateTime = System.DateTime.SpecifyKind (v1, v170)
    let v172 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v173 : System.DateTime = v172 v171
    let v176 : (System.DateTime -> int64) = _.Ticks
    let v177 : int64 = v176 v173
    let v180 : (System.DateTime -> int64) = _.Ticks
    let v181 : int64 = v180 v167
    let v184 : int64 = v177 - v181
    let v185 : int64 = v184 / 10L
    let v186 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v187 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v185 v186 
    let v188 : US0 option = None
    let _v188 = ref v188 
    match v187 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v189 : chrono_DateTime<chrono_Utc> = x
    let v190 : US0 = US0_0(v189)
    v190 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v188.Value <- x
    let v191 : US0 option = _v188.Value 
    let v202 : US0 = US0_1
    let v203 : US0 = v191 |> Option.defaultValue v202 
    let v223 : US1 =
        match v203 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v207) -> (* Some *)
            let v208 : string = "$0.naive_utc()"
            let v209 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v207 v208 
            let v210 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v211 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v209 v210 
            let v212 : string = "%Y%m%d-%H%M-%S%f"
            let v213 : string = "r#\"" + v212 + "\"#"
            let v214 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v213 
            let v215 : string = "$0.format($1).to_string()"
            let v216 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v211, v214) v215 
            let v217 : string = "fable_library_rust::String_::fromString($0)"
            let v218 : string = Fable.Core.RustInterop.emitRustExpr v216 v217 
            let v219 : string = $"{v218.[0..17]}-{v218.[18..21]}-{v218.[22]}"
            US1_0(v219)
    let v227 : string =
        match v223 with
        | US1_1 -> (* None *)
            let v225 : string = ""
            v225
        | US1_0(v224) -> (* Some *)
            v224
    let v228 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v229 : string = "0i64.into()"
    let v230 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v229 
    let _v228 = v230 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v231 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v228 = v231 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v234 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v228 = v234 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v237 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v228 = v237 
    #endif
#if FABLE_COMPILER_PYTHON
    let v240 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v228 = v240 
    #endif
#else
    let v243 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v228 = v243 
    #endif
    let v244 : System.TimeZoneInfo = _v228 
    let v249 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v250 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v251 : System.TimeSpan = v250 ()
    let _v249 = v251 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v254 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v255 : System.TimeSpan = v254 ()
    let _v249 = v255 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v258 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v259 : System.TimeSpan = v258 ()
    let _v249 = v259 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v262 : US2 = US2_0
    let v263 : US3 = US3_3(v262)
    let v264 : string = $"date_time.get_utc_offset / target: {v263}"
    let v265 : System.TimeSpan = failwith<System.TimeSpan> v264
    let _v249 = v265 
    #endif
#if FABLE_COMPILER_PYTHON
    let v266 : US2 = US2_0
    let v267 : US3 = US3_4(v266)
    let v268 : string = $"date_time.get_utc_offset / target: {v267}"
    let v269 : System.TimeSpan = failwith<System.TimeSpan> v268
    let _v249 = v269 
    #endif
#else
    let v270 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v271 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v272 : string = "0i64.into()"
    let v273 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v272 
    let _v271 = v273 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v274 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v271 = v274 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v277 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v271 = v277 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v280 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v271 = v280 
    #endif
#if FABLE_COMPILER_PYTHON
    let v283 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v271 = v283 
    #endif
#else
    let v286 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v271 = v286 
    #endif
    let v287 : System.TimeZoneInfo = _v271 
    let v292 : (System.DateTime -> System.TimeSpan) = v270 v287
    let v293 : System.TimeSpan = v292 v173
    let _v249 = v293 
    #endif
    let v294 : System.TimeSpan = _v249 
    let v300 : (System.TimeSpan -> int32) = _.Hours
    let v301 : int32 = v300 v294
    let v304 : bool = v301 > 0
    let v305 : uint8 =
        if v304 then
            1uy
        else
            0uy
    let v306 : string = method1()
    let v307 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v308 : string = v294.ToString v306 
    let _v307 = v308 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v309 : string = v294.ToString v306 
    let _v307 = v309 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v310 : string = v294.ToString v306 
    let _v307 = v310 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v311 : string = v294.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v307 = v311 
    #endif
#if FABLE_COMPILER_PYTHON
    let v312 : string = v294.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v307 = v312 
    #endif
#else
    let v313 : string = v294.ToString v306 
    let _v307 = v313 
    #endif
    let v314 : string = _v307 
    let v317 : string = $"{v305}{v314.[0..1]}{v314.[3..4]}"
    let v318 : (System.Guid -> string) = _.ToString()
    let v319 : string = v318 v0
    let v322 : System.Guid = System.Guid $"{v227}{v317}{v319.[v227.Length + v317.Length..]}"
    let _v2 = v322 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v323 : System.Guid = null |> unbox<System.Guid>
    let _v2 = v323 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v326 : string = method2()
    let v327 : (string -> string) = v1.ToString
    let v328 : string = v327 v326
    let v331 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v332 : string = "0i64.into()"
    let v333 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v332 
    let _v331 = v333 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v334 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v331 = v334 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v337 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v331 = v337 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v340 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v331 = v340 
    #endif
#if FABLE_COMPILER_PYTHON
    let v343 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v331 = v343 
    #endif
#else
    let v346 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v331 = v346 
    #endif
    let v347 : System.TimeZoneInfo = _v331 
    let v352 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v353 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v354 : System.TimeSpan = v353 ()
    let _v352 = v354 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v357 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v358 : System.TimeSpan = v357 ()
    let _v352 = v358 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v361 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v362 : System.TimeSpan = v361 ()
    let _v352 = v362 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v365 : US2 = US2_0
    let v366 : US3 = US3_3(v365)
    let v367 : string = $"date_time.get_utc_offset / target: {v366}"
    let v368 : System.TimeSpan = failwith<System.TimeSpan> v367
    let _v352 = v368 
    #endif
#if FABLE_COMPILER_PYTHON
    let v369 : US2 = US2_0
    let v370 : US3 = US3_4(v369)
    let v371 : string = $"date_time.get_utc_offset / target: {v370}"
    let v372 : System.TimeSpan = failwith<System.TimeSpan> v371
    let _v352 = v372 
    #endif
#else
    let v373 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v374 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v375 : string = "0i64.into()"
    let v376 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v375 
    let _v374 = v376 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v377 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v374 = v377 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v380 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v374 = v380 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v383 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v374 = v383 
    #endif
#if FABLE_COMPILER_PYTHON
    let v386 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v374 = v386 
    #endif
#else
    let v389 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v374 = v389 
    #endif
    let v390 : System.TimeZoneInfo = _v374 
    let v395 : (System.DateTime -> System.TimeSpan) = v373 v390
    let v396 : System.TimeSpan = v395 v1
    let _v352 = v396 
    #endif
    let v397 : System.TimeSpan = _v352 
    let v403 : (System.TimeSpan -> int32) = _.Hours
    let v404 : int32 = v403 v397
    let v407 : bool = v404 > 0
    let v408 : uint8 =
        if v407 then
            1uy
        else
            0uy
    let v409 : string = method3()
    let v410 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v411 : string = v397.ToString v409 
    let _v410 = v411 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v412 : string = v397.ToString v409 
    let _v410 = v412 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v413 : string = v397.ToString v409 
    let _v410 = v413 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v414 : string = v397.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v410 = v414 
    #endif
#if FABLE_COMPILER_PYTHON
    let v415 : string = v397.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v410 = v415 
    #endif
#else
    let v416 : string = v397.ToString v409 
    let _v410 = v416 
    #endif
    let v417 : string = _v410 
    let v420 : string = $"{v408}{v417}"
    let v421 : (System.Guid -> string) = _.ToString()
    let v422 : string = v421 v0
    let v425 : System.Guid = System.Guid $"{v328}{v420}{v422.[v328.Length + v420.Length..]}"
    let _v2 = v425 
    #endif
#if FABLE_COMPILER_PYTHON
    let v426 : string = method2()
    let v427 : (string -> string) = v1.ToString
    let v428 : string = v427 v426
    let v431 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v432 : string = "0i64.into()"
    let v433 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v432 
    let _v431 = v433 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v434 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v431 = v434 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v437 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v431 = v437 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v440 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v431 = v440 
    #endif
#if FABLE_COMPILER_PYTHON
    let v443 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v431 = v443 
    #endif
#else
    let v446 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v431 = v446 
    #endif
    let v447 : System.TimeZoneInfo = _v431 
    let v452 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v453 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v454 : System.TimeSpan = v453 ()
    let _v452 = v454 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v457 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v458 : System.TimeSpan = v457 ()
    let _v452 = v458 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v461 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v462 : System.TimeSpan = v461 ()
    let _v452 = v462 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v465 : US2 = US2_0
    let v466 : US3 = US3_3(v465)
    let v467 : string = $"date_time.get_utc_offset / target: {v466}"
    let v468 : System.TimeSpan = failwith<System.TimeSpan> v467
    let _v452 = v468 
    #endif
#if FABLE_COMPILER_PYTHON
    let v469 : US2 = US2_0
    let v470 : US3 = US3_4(v469)
    let v471 : string = $"date_time.get_utc_offset / target: {v470}"
    let v472 : System.TimeSpan = failwith<System.TimeSpan> v471
    let _v452 = v472 
    #endif
#else
    let v473 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v474 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v475 : string = "0i64.into()"
    let v476 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v475 
    let _v474 = v476 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v477 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v474 = v477 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v480 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v474 = v480 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v483 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v474 = v483 
    #endif
#if FABLE_COMPILER_PYTHON
    let v486 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v474 = v486 
    #endif
#else
    let v489 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v474 = v489 
    #endif
    let v490 : System.TimeZoneInfo = _v474 
    let v495 : (System.DateTime -> System.TimeSpan) = v473 v490
    let v496 : System.TimeSpan = v495 v1
    let _v452 = v496 
    #endif
    let v497 : System.TimeSpan = _v452 
    let v503 : (System.TimeSpan -> int32) = _.Hours
    let v504 : int32 = v503 v497
    let v507 : bool = v504 > 0
    let v508 : uint8 =
        if v507 then
            1uy
        else
            0uy
    let v509 : string = method3()
    let v510 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v511 : string = v497.ToString v509 
    let _v510 = v511 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v512 : string = v497.ToString v509 
    let _v510 = v512 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v513 : string = v497.ToString v509 
    let _v510 = v513 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v514 : string = v497.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v510 = v514 
    #endif
#if FABLE_COMPILER_PYTHON
    let v515 : string = v497.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v510 = v515 
    #endif
#else
    let v516 : string = v497.ToString v509 
    let _v510 = v516 
    #endif
    let v517 : string = _v510 
    let v520 : string = $"{v508}{v517}"
    let v521 : (System.Guid -> string) = _.ToString()
    let v522 : string = v521 v0
    let v525 : System.Guid = System.Guid $"{v428}{v520}{v522.[v428.Length + v520.Length..]}"
    let _v2 = v525 
    #endif
#else
    let v526 : string = method2()
    let v527 : (string -> string) = v1.ToString
    let v528 : string = v527 v526
    let v531 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v532 : string = "0i64.into()"
    let v533 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v532 
    let _v531 = v533 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v534 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v531 = v534 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v537 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v531 = v537 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v540 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v531 = v540 
    #endif
#if FABLE_COMPILER_PYTHON
    let v543 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v531 = v543 
    #endif
#else
    let v546 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v531 = v546 
    #endif
    let v547 : System.TimeZoneInfo = _v531 
    let v552 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v553 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v554 : System.TimeSpan = v553 ()
    let _v552 = v554 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v557 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v558 : System.TimeSpan = v557 ()
    let _v552 = v558 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v561 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v562 : System.TimeSpan = v561 ()
    let _v552 = v562 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v565 : US2 = US2_0
    let v566 : US3 = US3_3(v565)
    let v567 : string = $"date_time.get_utc_offset / target: {v566}"
    let v568 : System.TimeSpan = failwith<System.TimeSpan> v567
    let _v552 = v568 
    #endif
#if FABLE_COMPILER_PYTHON
    let v569 : US2 = US2_0
    let v570 : US3 = US3_4(v569)
    let v571 : string = $"date_time.get_utc_offset / target: {v570}"
    let v572 : System.TimeSpan = failwith<System.TimeSpan> v571
    let _v552 = v572 
    #endif
#else
    let v573 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v574 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v575 : string = "0i64.into()"
    let v576 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v575 
    let _v574 = v576 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v577 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v574 = v577 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v580 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v574 = v580 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v583 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v574 = v583 
    #endif
#if FABLE_COMPILER_PYTHON
    let v586 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v574 = v586 
    #endif
#else
    let v589 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v574 = v589 
    #endif
    let v590 : System.TimeZoneInfo = _v574 
    let v595 : (System.DateTime -> System.TimeSpan) = v573 v590
    let v596 : System.TimeSpan = v595 v1
    let _v552 = v596 
    #endif
    let v597 : System.TimeSpan = _v552 
    let v603 : (System.TimeSpan -> int32) = _.Hours
    let v604 : int32 = v603 v597
    let v607 : bool = v604 > 0
    let v608 : uint8 =
        if v607 then
            1uy
        else
            0uy
    let v609 : string = method3()
    let v610 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v611 : string = v597.ToString v609 
    let _v610 = v611 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v612 : string = v597.ToString v609 
    let _v610 = v612 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v613 : string = v597.ToString v609 
    let _v610 = v613 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v614 : string = v597.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v610 = v614 
    #endif
#if FABLE_COMPILER_PYTHON
    let v615 : string = v597.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v610 = v615 
    #endif
#else
    let v616 : string = v597.ToString v609 
    let _v610 = v616 
    #endif
    let v617 : string = _v610 
    let v620 : string = $"{v608}{v617}"
    let v621 : (System.Guid -> string) = _.ToString()
    let v622 : string = v621 v0
    let v625 : System.Guid = System.Guid $"{v528}{v620}{v622.[v528.Length + v620.Length..]}"
    let _v2 = v625 
    #endif
    let v626 : System.Guid = _v2 
    v626
and closure1 (v0 : System.Guid) (v1 : System.DateTime) : System.Guid =
    method0(v0, v1)
and closure0 () (v0 : System.Guid) : (System.DateTime -> System.Guid) =
    closure1(v0)
and closure3 () (v0 : string) : string =
    let v1 : string = "-"
    let v2 : string = ""
    let v3 : string = v0.Replace (v1, v2)
    v3
and closure2 () (v0 : System.Guid) : System.DateTime =
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v5 : (string -> string) = closure3()
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
and closure5 (v0 : System.Guid) (v1 : int64) : System.Guid =
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v0
    let v6 : (int64 -> string) = _.ToString()
    let v7 : string = v6 v1
    let v10 : string = v7.PadLeft (18, '0')
    let v24 : System.Guid = System.Guid $"{v10.[0..7]}-{v10.[8..11]}-{v10.[12..15]}-{v10.[16..17]}{v3.[21..]}"
    v24
and closure4 () (v0 : System.Guid) : (int64 -> System.Guid) =
    closure5(v0)
and closure6 () (v0 : System.Guid) : int64 =
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v5 : int64 = int64 $"{v2.[0..7]}{v2.[9..12]}{v2.[14..17]}{v2.[19..20]}"
    v5
and closure7 () (v0 : System.DateTime) : System.Guid =
    let v1 : (unit -> System.Guid) = System.Guid.NewGuid
    let v2 : System.Guid = v1 ()
    method0(v2, v0)
and closure8 () (v0 : int64) : System.Guid =
    let v1 : (unit -> System.Guid) = System.Guid.NewGuid
    let v2 : System.Guid = v1 ()
    let v5 : (System.Guid -> string) = _.ToString()
    let v6 : string = v5 v2
    let v9 : (int64 -> string) = _.ToString()
    let v10 : string = v9 v0
    let v13 : string = v10.PadLeft (18, '0')
    let v27 : System.Guid = System.Guid $"{v13.[0..7]}-{v13.[8..11]}-{v13.[12..15]}-{v13.[16..17]}{v6.[21..]}"
    v27
and closure10 (v0 : string) (v1 : System.DateTime) : string =
    let v2 : (string -> string) = v1.ToString
    v2 v0
and closure9 () (v0 : string) : (System.DateTime -> string) =
    closure10(v0)
and closure11 () (v0 : System.DateTime) : string =
    let v1 : (string -> string) = v0.ToString
    let v2 : string = "yyyy-MM-ddTHH-mm-ss.fff"
    v1 v2
let v0 : (System.Guid -> (System.DateTime -> System.Guid)) = closure0()
let date_time_guid_from_date_time x = v0 x
let v1 : (System.Guid -> System.DateTime) = closure2()
let date_time_from_guid x = v1 x
let v2 : (System.Guid -> (int64 -> System.Guid)) = closure4()
let timestamp_guid_from_timestamp x = v2 x
let v3 : (System.Guid -> int64) = closure6()
let timestamp_from_guid x = v3 x
let v4 : (System.DateTime -> System.Guid) = closure7()
let new_guid_from_date_time x = v4 x
let v5 : (int64 -> System.Guid) = closure8()
let new_guid_from_timestamp x = v5 x
let v6 : (string -> (System.DateTime -> string)) = closure9()
let format x = v6 x
let v7 : (System.DateTime -> string) = closure11()
let format_iso8601 x = v7 x
()
