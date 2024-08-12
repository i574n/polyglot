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
let rec closure2 (v0 : US0 option ref) (v1 : US0 option) : US0 option ref =
    v0.Value <- v1 
    v0
and closure3 (v0 : chrono_DateTime<chrono_Utc> option, v1 : (US0 option -> US0 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : chrono_DateTime<chrono_Utc> = x
    let v3 : US0 = US0_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and method1 () : string =
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
    let v29 : US0 option ref = _v28 
    let v30 : (US0 option -> US0 option ref) = closure2(v29)
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure3(v27, v30)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v36 : US0 option = _v28.Value 
    let v47 : US0 = US0_1
    let v48 : US0 = v36 |> Option.defaultValue v47 
    let v68 : US1 =
        match v48 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v52) -> (* Some *)
            let v53 : string = "$0.naive_utc()"
            let v54 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v52 v53 
            let v55 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v56 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v54 v55 
            let v57 : string = "%Y%m%d-%H%M-%S%f"
            let v58 : string = "r#\"" + v57 + "\"#"
            let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v58 
            let v60 : string = "$0.format($1).to_string()"
            let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v56, v59) v60 
            let v62 : string = "fable_library_rust::String_::fromString($0)"
            let v63 : string = Fable.Core.RustInterop.emitRustExpr v61 v62 
            let v64 : string = $"{v63.[0..17]}-{v63.[18..21]}-{v63.[22]}"
            US1_0(v64)
    let v72 : string =
        match v68 with
        | US1_1 -> (* None *)
            let v70 : string = ""
            v70
        | US1_0(v69) -> (* Some *)
            v69
    let v73 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v74 : string = "0i64.into()"
    let v75 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v74 
    let _v73 = v75 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v76 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v73 = v76 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v73 = v79 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v82 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v73 = v82 
    #endif
#if FABLE_COMPILER_PYTHON
    let v85 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v73 = v85 
    #endif
#else
    let v88 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v73 = v88 
    #endif
    let v89 : System.TimeZoneInfo = _v73 
    let v94 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v96 : System.TimeSpan = v95 ()
    let _v94 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v99 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v100 : System.TimeSpan = v99 ()
    let _v94 = v100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v103 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v104 : System.TimeSpan = v103 ()
    let _v94 = v104 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v107 : US2 = US2_0
    let v108 : US3 = US3_3(v107)
    let v109 : string = $"date_time.get_utc_offset / target: {v108}"
    let v110 : System.TimeSpan = failwith<System.TimeSpan> v109
    let _v94 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : US2 = US2_0
    let v112 : US3 = US3_4(v111)
    let v113 : string = $"date_time.get_utc_offset / target: {v112}"
    let v114 : System.TimeSpan = failwith<System.TimeSpan> v113
    let _v94 = v114 
    #endif
#else
    let v115 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v116 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v117 : string = "0i64.into()"
    let v118 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v117 
    let _v116 = v118 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v119 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v116 = v119 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v122 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v116 = v122 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v125 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v116 = v125 
    #endif
#if FABLE_COMPILER_PYTHON
    let v128 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v116 = v128 
    #endif
#else
    let v131 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v116 = v131 
    #endif
    let v132 : System.TimeZoneInfo = _v116 
    let v137 : (System.DateTime -> System.TimeSpan) = v115 v132
    let v138 : System.TimeSpan = v137 v13
    let _v94 = v138 
    #endif
    let v139 : System.TimeSpan = _v94 
    let v145 : (System.TimeSpan -> int32) = _.Hours
    let v146 : int32 = v145 v139
    let v149 : bool = v146 > 0
    let v150 : uint8 =
        if v149 then
            1uy
        else
            0uy
    let v151 : string = method1()
    let v152 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v153 : string = v139.ToString v151 
    let _v152 = v153 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v154 : string = v139.ToString v151 
    let _v152 = v154 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v155 : string = v139.ToString v151 
    let _v152 = v155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v156 : string = v139.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v152 = v156 
    #endif
#if FABLE_COMPILER_PYTHON
    let v157 : string = v139.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v152 = v157 
    #endif
#else
    let v158 : string = v139.ToString v151 
    let _v152 = v158 
    #endif
    let v159 : string = _v152 
    let v162 : string = $"{v150}{v159.[0..1]}{v159.[3..4]}"
    let v163 : (System.Guid -> string) = _.ToString()
    let v164 : string = v163 v0
    let v167 : System.Guid = System.Guid $"{v72}{v162}{v164.[v72.Length + v162.Length..]}"
    let _v2 = v167 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v168 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v171 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v172 : System.DateTime = v171 v168
    let v175 : System.DateTimeKind = System.DateTimeKind.Local
    let v176 : System.DateTime = System.DateTime.SpecifyKind (v1, v175)
    let v177 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v178 : System.DateTime = v177 v176
    let v181 : (System.DateTime -> int64) = _.Ticks
    let v182 : int64 = v181 v178
    let v185 : (System.DateTime -> int64) = _.Ticks
    let v186 : int64 = v185 v172
    let v189 : int64 = v182 - v186
    let v190 : int64 = v189 / 10L
    let v191 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v192 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v190 v191 
    let v193 : US0 option = None
    let _v193 = ref v193 
    let v194 : US0 option ref = _v193 
    let v195 : (US0 option -> US0 option ref) = closure2(v194)
    let v196 : unit = ()
    let v197 : (unit -> unit) = closure3(v192, v195)
    let v198 : unit = (fun () -> v197 (); v196) ()
    let v201 : US0 option = _v193.Value 
    let v212 : US0 = US0_1
    let v213 : US0 = v201 |> Option.defaultValue v212 
    let v233 : US1 =
        match v213 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v217) -> (* Some *)
            let v218 : string = "$0.naive_utc()"
            let v219 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v217 v218 
            let v220 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v221 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v219 v220 
            let v222 : string = "%Y%m%d-%H%M-%S%f"
            let v223 : string = "r#\"" + v222 + "\"#"
            let v224 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v223 
            let v225 : string = "$0.format($1).to_string()"
            let v226 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v221, v224) v225 
            let v227 : string = "fable_library_rust::String_::fromString($0)"
            let v228 : string = Fable.Core.RustInterop.emitRustExpr v226 v227 
            let v229 : string = $"{v228.[0..17]}-{v228.[18..21]}-{v228.[22]}"
            US1_0(v229)
    let v237 : string =
        match v233 with
        | US1_1 -> (* None *)
            let v235 : string = ""
            v235
        | US1_0(v234) -> (* Some *)
            v234
    let v238 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v239 : string = "0i64.into()"
    let v240 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v239 
    let _v238 = v240 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v241 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v238 = v241 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v244 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v238 = v244 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v247 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v238 = v247 
    #endif
#if FABLE_COMPILER_PYTHON
    let v250 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v238 = v250 
    #endif
#else
    let v253 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v238 = v253 
    #endif
    let v254 : System.TimeZoneInfo = _v238 
    let v259 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v260 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v261 : System.TimeSpan = v260 ()
    let _v259 = v261 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v264 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v265 : System.TimeSpan = v264 ()
    let _v259 = v265 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v268 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v269 : System.TimeSpan = v268 ()
    let _v259 = v269 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v272 : US2 = US2_0
    let v273 : US3 = US3_3(v272)
    let v274 : string = $"date_time.get_utc_offset / target: {v273}"
    let v275 : System.TimeSpan = failwith<System.TimeSpan> v274
    let _v259 = v275 
    #endif
#if FABLE_COMPILER_PYTHON
    let v276 : US2 = US2_0
    let v277 : US3 = US3_4(v276)
    let v278 : string = $"date_time.get_utc_offset / target: {v277}"
    let v279 : System.TimeSpan = failwith<System.TimeSpan> v278
    let _v259 = v279 
    #endif
#else
    let v280 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v281 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v282 : string = "0i64.into()"
    let v283 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v282 
    let _v281 = v283 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v284 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v281 = v284 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v287 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v281 = v287 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v290 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v281 = v290 
    #endif
#if FABLE_COMPILER_PYTHON
    let v293 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v281 = v293 
    #endif
#else
    let v296 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v281 = v296 
    #endif
    let v297 : System.TimeZoneInfo = _v281 
    let v302 : (System.DateTime -> System.TimeSpan) = v280 v297
    let v303 : System.TimeSpan = v302 v178
    let _v259 = v303 
    #endif
    let v304 : System.TimeSpan = _v259 
    let v310 : (System.TimeSpan -> int32) = _.Hours
    let v311 : int32 = v310 v304
    let v314 : bool = v311 > 0
    let v315 : uint8 =
        if v314 then
            1uy
        else
            0uy
    let v316 : string = method1()
    let v317 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v318 : string = v304.ToString v316 
    let _v317 = v318 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v319 : string = v304.ToString v316 
    let _v317 = v319 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v320 : string = v304.ToString v316 
    let _v317 = v320 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v321 : string = v304.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v317 = v321 
    #endif
#if FABLE_COMPILER_PYTHON
    let v322 : string = v304.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v317 = v322 
    #endif
#else
    let v323 : string = v304.ToString v316 
    let _v317 = v323 
    #endif
    let v324 : string = _v317 
    let v327 : string = $"{v315}{v324.[0..1]}{v324.[3..4]}"
    let v328 : (System.Guid -> string) = _.ToString()
    let v329 : string = v328 v0
    let v332 : System.Guid = System.Guid $"{v237}{v327}{v329.[v237.Length + v327.Length..]}"
    let _v2 = v332 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v333 : System.Guid = null |> unbox<System.Guid>
    let _v2 = v333 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v336 : string = method2()
    let v337 : (string -> string) = v1.ToString
    let v338 : string = v337 v336
    let v341 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v342 : string = "0i64.into()"
    let v343 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v342 
    let _v341 = v343 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v344 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v341 = v344 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v347 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v341 = v347 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v350 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v341 = v350 
    #endif
#if FABLE_COMPILER_PYTHON
    let v353 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v341 = v353 
    #endif
#else
    let v356 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v341 = v356 
    #endif
    let v357 : System.TimeZoneInfo = _v341 
    let v362 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v363 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v364 : System.TimeSpan = v363 ()
    let _v362 = v364 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v367 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v368 : System.TimeSpan = v367 ()
    let _v362 = v368 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v371 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v372 : System.TimeSpan = v371 ()
    let _v362 = v372 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v375 : US2 = US2_0
    let v376 : US3 = US3_3(v375)
    let v377 : string = $"date_time.get_utc_offset / target: {v376}"
    let v378 : System.TimeSpan = failwith<System.TimeSpan> v377
    let _v362 = v378 
    #endif
#if FABLE_COMPILER_PYTHON
    let v379 : US2 = US2_0
    let v380 : US3 = US3_4(v379)
    let v381 : string = $"date_time.get_utc_offset / target: {v380}"
    let v382 : System.TimeSpan = failwith<System.TimeSpan> v381
    let _v362 = v382 
    #endif
#else
    let v383 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v384 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v385 : string = "0i64.into()"
    let v386 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v385 
    let _v384 = v386 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v387 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v384 = v387 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v390 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v384 = v390 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v393 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v384 = v393 
    #endif
#if FABLE_COMPILER_PYTHON
    let v396 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v384 = v396 
    #endif
#else
    let v399 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v384 = v399 
    #endif
    let v400 : System.TimeZoneInfo = _v384 
    let v405 : (System.DateTime -> System.TimeSpan) = v383 v400
    let v406 : System.TimeSpan = v405 v1
    let _v362 = v406 
    #endif
    let v407 : System.TimeSpan = _v362 
    let v413 : (System.TimeSpan -> int32) = _.Hours
    let v414 : int32 = v413 v407
    let v417 : bool = v414 > 0
    let v418 : uint8 =
        if v417 then
            1uy
        else
            0uy
    let v419 : string = method3()
    let v420 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v421 : string = v407.ToString v419 
    let _v420 = v421 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v422 : string = v407.ToString v419 
    let _v420 = v422 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v423 : string = v407.ToString v419 
    let _v420 = v423 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v424 : string = v407.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v420 = v424 
    #endif
#if FABLE_COMPILER_PYTHON
    let v425 : string = v407.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v420 = v425 
    #endif
#else
    let v426 : string = v407.ToString v419 
    let _v420 = v426 
    #endif
    let v427 : string = _v420 
    let v430 : string = $"{v418}{v427}"
    let v431 : (System.Guid -> string) = _.ToString()
    let v432 : string = v431 v0
    let v435 : System.Guid = System.Guid $"{v338}{v430}{v432.[v338.Length + v430.Length..]}"
    let _v2 = v435 
    #endif
#if FABLE_COMPILER_PYTHON
    let v436 : string = method2()
    let v437 : (string -> string) = v1.ToString
    let v438 : string = v437 v436
    let v441 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v442 : string = "0i64.into()"
    let v443 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v442 
    let _v441 = v443 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v444 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v441 = v444 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v447 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v441 = v447 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v450 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v441 = v450 
    #endif
#if FABLE_COMPILER_PYTHON
    let v453 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v441 = v453 
    #endif
#else
    let v456 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v441 = v456 
    #endif
    let v457 : System.TimeZoneInfo = _v441 
    let v462 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v463 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v464 : System.TimeSpan = v463 ()
    let _v462 = v464 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v467 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v468 : System.TimeSpan = v467 ()
    let _v462 = v468 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v471 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v472 : System.TimeSpan = v471 ()
    let _v462 = v472 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v475 : US2 = US2_0
    let v476 : US3 = US3_3(v475)
    let v477 : string = $"date_time.get_utc_offset / target: {v476}"
    let v478 : System.TimeSpan = failwith<System.TimeSpan> v477
    let _v462 = v478 
    #endif
#if FABLE_COMPILER_PYTHON
    let v479 : US2 = US2_0
    let v480 : US3 = US3_4(v479)
    let v481 : string = $"date_time.get_utc_offset / target: {v480}"
    let v482 : System.TimeSpan = failwith<System.TimeSpan> v481
    let _v462 = v482 
    #endif
#else
    let v483 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v484 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v485 : string = "0i64.into()"
    let v486 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v485 
    let _v484 = v486 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v487 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v484 = v487 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v490 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v484 = v490 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v493 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v484 = v493 
    #endif
#if FABLE_COMPILER_PYTHON
    let v496 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v484 = v496 
    #endif
#else
    let v499 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v484 = v499 
    #endif
    let v500 : System.TimeZoneInfo = _v484 
    let v505 : (System.DateTime -> System.TimeSpan) = v483 v500
    let v506 : System.TimeSpan = v505 v1
    let _v462 = v506 
    #endif
    let v507 : System.TimeSpan = _v462 
    let v513 : (System.TimeSpan -> int32) = _.Hours
    let v514 : int32 = v513 v507
    let v517 : bool = v514 > 0
    let v518 : uint8 =
        if v517 then
            1uy
        else
            0uy
    let v519 : string = method3()
    let v520 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v521 : string = v507.ToString v519 
    let _v520 = v521 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v522 : string = v507.ToString v519 
    let _v520 = v522 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v523 : string = v507.ToString v519 
    let _v520 = v523 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v524 : string = v507.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v520 = v524 
    #endif
#if FABLE_COMPILER_PYTHON
    let v525 : string = v507.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v520 = v525 
    #endif
#else
    let v526 : string = v507.ToString v519 
    let _v520 = v526 
    #endif
    let v527 : string = _v520 
    let v530 : string = $"{v518}{v527}"
    let v531 : (System.Guid -> string) = _.ToString()
    let v532 : string = v531 v0
    let v535 : System.Guid = System.Guid $"{v438}{v530}{v532.[v438.Length + v530.Length..]}"
    let _v2 = v535 
    #endif
#else
    let v536 : string = method2()
    let v537 : (string -> string) = v1.ToString
    let v538 : string = v537 v536
    let v541 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v542 : string = "0i64.into()"
    let v543 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v542 
    let _v541 = v543 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v544 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v541 = v544 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v547 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v541 = v547 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v550 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v541 = v550 
    #endif
#if FABLE_COMPILER_PYTHON
    let v553 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v541 = v553 
    #endif
#else
    let v556 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v541 = v556 
    #endif
    let v557 : System.TimeZoneInfo = _v541 
    let v562 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v563 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v564 : System.TimeSpan = v563 ()
    let _v562 = v564 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v567 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v568 : System.TimeSpan = v567 ()
    let _v562 = v568 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v571 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v572 : System.TimeSpan = v571 ()
    let _v562 = v572 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v575 : US2 = US2_0
    let v576 : US3 = US3_3(v575)
    let v577 : string = $"date_time.get_utc_offset / target: {v576}"
    let v578 : System.TimeSpan = failwith<System.TimeSpan> v577
    let _v562 = v578 
    #endif
#if FABLE_COMPILER_PYTHON
    let v579 : US2 = US2_0
    let v580 : US3 = US3_4(v579)
    let v581 : string = $"date_time.get_utc_offset / target: {v580}"
    let v582 : System.TimeSpan = failwith<System.TimeSpan> v581
    let _v562 = v582 
    #endif
#else
    let v583 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v584 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v585 : string = "0i64.into()"
    let v586 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v585 
    let _v584 = v586 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v587 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v584 = v587 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v590 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v584 = v590 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v593 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v584 = v593 
    #endif
#if FABLE_COMPILER_PYTHON
    let v596 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v584 = v596 
    #endif
#else
    let v599 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v584 = v599 
    #endif
    let v600 : System.TimeZoneInfo = _v584 
    let v605 : (System.DateTime -> System.TimeSpan) = v583 v600
    let v606 : System.TimeSpan = v605 v1
    let _v562 = v606 
    #endif
    let v607 : System.TimeSpan = _v562 
    let v613 : (System.TimeSpan -> int32) = _.Hours
    let v614 : int32 = v613 v607
    let v617 : bool = v614 > 0
    let v618 : uint8 =
        if v617 then
            1uy
        else
            0uy
    let v619 : string = method3()
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
#else
    let v626 : string = v607.ToString v619 
    let _v620 = v626 
    #endif
    let v627 : string = _v620 
    let v630 : string = $"{v618}{v627}"
    let v631 : (System.Guid -> string) = _.ToString()
    let v632 : string = v631 v0
    let v635 : System.Guid = System.Guid $"{v538}{v630}{v632.[v538.Length + v630.Length..]}"
    let _v2 = v635 
    #endif
    let v636 : System.Guid = _v2 
    v636
and closure1 (v0 : System.Guid) (v1 : System.DateTime) : System.Guid =
    method0(v0, v1)
and closure0 () (v0 : System.Guid) : (System.DateTime -> System.Guid) =
    closure1(v0)
and closure5 () (v0 : string) : string =
    let v1 : string = "-"
    let v2 : string = ""
    let v3 : string = v0.Replace (v1, v2)
    v3
and closure4 () (v0 : System.Guid) : System.DateTime =
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v5 : (string -> string) = closure5()
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
and closure7 (v0 : System.Guid) (v1 : int64) : System.Guid =
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v0
    let v6 : (int64 -> string) = _.ToString()
    let v7 : string = v6 v1
    let v10 : string = v7.PadLeft (18, '0')
    let v24 : System.Guid = System.Guid $"{v10.[0..7]}-{v10.[8..11]}-{v10.[12..15]}-{v10.[16..17]}{v3.[21..]}"
    v24
and closure6 () (v0 : System.Guid) : (int64 -> System.Guid) =
    closure7(v0)
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
    let v13 : string = v10.PadLeft (18, '0')
    let v27 : System.Guid = System.Guid $"{v13.[0..7]}-{v13.[8..11]}-{v13.[12..15]}-{v13.[16..17]}{v6.[21..]}"
    v27
and closure12 (v0 : string) (v1 : System.DateTime) : string =
    let v2 : (string -> string) = v1.ToString
    v2 v0
and closure11 () (v0 : string) : (System.DateTime -> string) =
    closure12(v0)
and closure13 () (v0 : System.DateTime) : string =
    let v1 : (string -> string) = v0.ToString
    let v2 : string = "yyyy-MM-ddTHH-mm-ss.fff"
    v1 v2
let v0 : (System.Guid -> (System.DateTime -> System.Guid)) = closure0()
let date_time_guid_from_date_time x = v0 x
let v1 : (System.Guid -> System.DateTime) = closure4()
let date_time_from_guid x = v1 x
let v2 : (System.Guid -> (int64 -> System.Guid)) = closure6()
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
