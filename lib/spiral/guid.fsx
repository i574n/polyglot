let rec closure0 () (v0 : string) : System.Guid =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : System.Guid = v0 |> System.Guid 
    let _run_target_args'_v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : System.Guid = v0 |> System.Guid 
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : System.Guid = v0 |> System.Guid 
    let _run_target_args'_v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : System.Guid = v0 |> System.Guid 
    let _run_target_args'_v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : System.Guid = v0 |> System.Guid 
    let _run_target_args'_v1 = v17 
    #endif
#else
    let v20 : System.Guid = v0 |> System.Guid 
    let _run_target_args'_v1 = v20 
    #endif
    let v23 : System.Guid = _run_target_args'_v1 
    v23
and closure2 (v0 : int32, v1 : string, v2 : int32) (v3 : string) : string =
    let v4 : bool = v2 >= v0
    if v4 then
        v3
    else
        let v5 : int32 = v2 + 1
        let v6 : (string -> string) = method1(v0, v1, v5)
        let v7 : string = v3 + v1 
        v6 v7
and method1 (v0 : int32, v1 : string, v2 : int32) : (string -> string) =
    closure2(v0, v1, v2)
and method0 (v0 : string) : System.Guid =
    let v1 : (char -> string) = _.ToString()
    let v2 : string = v1 '0'
    let v5 : int32 = v0.Length
    let v6 : int32 = 32 - v5
    let v7 : int32 = 0
    let v8 : (string -> string) = method1(v6, v2, v7)
    let v9 : string = ""
    let v10 : string = v8 v9
    let v11 : string = v10 + v0 
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : int32 = 0 |> int32 
    let v20 : int32 = 8 |> int32 
    let v27 : int32 = v20 - 1
    let v28 : string = v11.[int v13..int v27]
    let v32 : int32 = 8 |> int32 
    let v39 : int32 = 12 |> int32 
    let v46 : int32 = v39 - 1
    let v47 : string = v11.[int v32..int v46]
    let v51 : int32 = 12 |> int32 
    let v58 : int32 = 16 |> int32 
    let v65 : int32 = v58 - 1
    let v66 : string = v11.[int v51..int v65]
    let v70 : int32 = 16 |> int32 
    let v77 : int32 = 20 |> int32 
    let v84 : int32 = v77 - 1
    let v85 : string = v11.[int v70..int v84]
    let v89 : int32 = 20 |> int32 
    let v96 : int32 = 32 |> int32 
    let v103 : int32 = v96 - 1
    let v104 : string = v11.[int v89..int v103]
    let v108 : string = $"{v28}-{v47}-{v66}-{v85}-{v104}"
    (* run_target_args'
    let v109 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v110 : System.Guid = v108 |> System.Guid 
    let _run_target_args'_v109 = v110 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : System.Guid = v108 |> System.Guid 
    let _run_target_args'_v109 = v113 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v116 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v109 = v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v119 : System.Guid = v108 |> System.Guid 
    let _run_target_args'_v109 = v119 
    #endif
#if FABLE_COMPILER_PYTHON
    let v122 : System.Guid = v108 |> System.Guid 
    let _run_target_args'_v109 = v122 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v125 : System.Guid = v108 |> System.Guid 
    let _run_target_args'_v109 = v125 
    #endif
#else
    let v128 : System.Guid = v108 |> System.Guid 
    let _run_target_args'_v109 = v128 
    #endif
    let v131 : System.Guid = _run_target_args'_v109 
    let _run_target_args'_v12 = v131 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v136 : int32 = 0 |> int32 
    let v143 : int32 = 8 |> int32 
    let v150 : int32 = v143 - 1
    let v151 : string = v11.[int v136..int v150]
    let v155 : int32 = 8 |> int32 
    let v162 : int32 = 12 |> int32 
    let v169 : int32 = v162 - 1
    let v170 : string = v11.[int v155..int v169]
    let v174 : int32 = 12 |> int32 
    let v181 : int32 = 16 |> int32 
    let v188 : int32 = v181 - 1
    let v189 : string = v11.[int v174..int v188]
    let v193 : int32 = 16 |> int32 
    let v200 : int32 = 20 |> int32 
    let v207 : int32 = v200 - 1
    let v208 : string = v11.[int v193..int v207]
    let v212 : int32 = 20 |> int32 
    let v219 : int32 = 32 |> int32 
    let v226 : int32 = v219 - 1
    let v227 : string = v11.[int v212..int v226]
    let v231 : string = $"{v151}-{v170}-{v189}-{v208}-{v227}"
    (* run_target_args'
    let v232 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v233 : System.Guid = v231 |> System.Guid 
    let _run_target_args'_v232 = v233 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v236 : System.Guid = v231 |> System.Guid 
    let _run_target_args'_v232 = v236 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v239 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v232 = v239 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v242 : System.Guid = v231 |> System.Guid 
    let _run_target_args'_v232 = v242 
    #endif
#if FABLE_COMPILER_PYTHON
    let v245 : System.Guid = v231 |> System.Guid 
    let _run_target_args'_v232 = v245 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v248 : System.Guid = v231 |> System.Guid 
    let _run_target_args'_v232 = v248 
    #endif
#else
    let v251 : System.Guid = v231 |> System.Guid 
    let _run_target_args'_v232 = v251 
    #endif
    let v254 : System.Guid = _run_target_args'_v232 
    let _run_target_args'_v12 = v254 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v259 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v12 = v259 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v262 : int32 = 0 |> int32 
    let v269 : int32 = 8 |> int32 
    let v276 : int32 = v269 - 1
    let v277 : string = v11.[int v262..int v276]
    let v281 : int32 = 8 |> int32 
    let v288 : int32 = 12 |> int32 
    let v295 : int32 = v288 - 1
    let v296 : string = v11.[int v281..int v295]
    let v300 : int32 = 12 |> int32 
    let v307 : int32 = 16 |> int32 
    let v314 : int32 = v307 - 1
    let v315 : string = v11.[int v300..int v314]
    let v319 : int32 = 16 |> int32 
    let v326 : int32 = 20 |> int32 
    let v333 : int32 = v326 - 1
    let v334 : string = v11.[int v319..int v333]
    let v338 : int32 = 20 |> int32 
    let v345 : int32 = 32 |> int32 
    let v352 : int32 = v345 - 1
    let v353 : string = v11.[int v338..int v352]
    let v357 : string = $"{v277}-{v296}-{v315}-{v334}-{v353}"
    (* run_target_args'
    let v358 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v359 : System.Guid = v357 |> System.Guid 
    let _run_target_args'_v358 = v359 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v362 : System.Guid = v357 |> System.Guid 
    let _run_target_args'_v358 = v362 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v365 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v358 = v365 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v368 : System.Guid = v357 |> System.Guid 
    let _run_target_args'_v358 = v368 
    #endif
#if FABLE_COMPILER_PYTHON
    let v371 : System.Guid = v357 |> System.Guid 
    let _run_target_args'_v358 = v371 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v374 : System.Guid = v357 |> System.Guid 
    let _run_target_args'_v358 = v374 
    #endif
#else
    let v377 : System.Guid = v357 |> System.Guid 
    let _run_target_args'_v358 = v377 
    #endif
    let v380 : System.Guid = _run_target_args'_v358 
    let _run_target_args'_v12 = v380 
    #endif
#if FABLE_COMPILER_PYTHON
    let v385 : int32 = 0 |> int32 
    let v392 : int32 = 8 |> int32 
    let v399 : int32 = v392 - 1
    let v400 : string = v11.[int v385..int v399]
    let v404 : int32 = 8 |> int32 
    let v411 : int32 = 12 |> int32 
    let v418 : int32 = v411 - 1
    let v419 : string = v11.[int v404..int v418]
    let v423 : int32 = 12 |> int32 
    let v430 : int32 = 16 |> int32 
    let v437 : int32 = v430 - 1
    let v438 : string = v11.[int v423..int v437]
    let v442 : int32 = 16 |> int32 
    let v449 : int32 = 20 |> int32 
    let v456 : int32 = v449 - 1
    let v457 : string = v11.[int v442..int v456]
    let v461 : int32 = 20 |> int32 
    let v468 : int32 = 32 |> int32 
    let v475 : int32 = v468 - 1
    let v476 : string = v11.[int v461..int v475]
    let v480 : string = $"{v400}-{v419}-{v438}-{v457}-{v476}"
    (* run_target_args'
    let v481 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v482 : System.Guid = v480 |> System.Guid 
    let _run_target_args'_v481 = v482 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v485 : System.Guid = v480 |> System.Guid 
    let _run_target_args'_v481 = v485 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v488 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v481 = v488 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v491 : System.Guid = v480 |> System.Guid 
    let _run_target_args'_v481 = v491 
    #endif
#if FABLE_COMPILER_PYTHON
    let v494 : System.Guid = v480 |> System.Guid 
    let _run_target_args'_v481 = v494 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v497 : System.Guid = v480 |> System.Guid 
    let _run_target_args'_v481 = v497 
    #endif
#else
    let v500 : System.Guid = v480 |> System.Guid 
    let _run_target_args'_v481 = v500 
    #endif
    let v503 : System.Guid = _run_target_args'_v481 
    let _run_target_args'_v12 = v503 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v508 : int32 = 0 |> int32 
    let v515 : int32 = 8 |> int32 
    let v522 : int32 = v515 - 1
    let v523 : string = v11.[int v508..int v522]
    let v527 : int32 = 8 |> int32 
    let v534 : int32 = 12 |> int32 
    let v541 : int32 = v534 - 1
    let v542 : string = v11.[int v527..int v541]
    let v546 : int32 = 12 |> int32 
    let v553 : int32 = 16 |> int32 
    let v560 : int32 = v553 - 1
    let v561 : string = v11.[int v546..int v560]
    let v565 : int32 = 16 |> int32 
    let v572 : int32 = 20 |> int32 
    let v579 : int32 = v572 - 1
    let v580 : string = v11.[int v565..int v579]
    let v584 : int32 = 20 |> int32 
    let v591 : int32 = 32 |> int32 
    let v598 : int32 = v591 - 1
    let v599 : string = v11.[int v584..int v598]
    let v603 : string = $"{v523}-{v542}-{v561}-{v580}-{v599}"
    (* run_target_args'
    let v604 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v605 : System.Guid = v603 |> System.Guid 
    let _run_target_args'_v604 = v605 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v608 : System.Guid = v603 |> System.Guid 
    let _run_target_args'_v604 = v608 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v611 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v604 = v611 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v614 : System.Guid = v603 |> System.Guid 
    let _run_target_args'_v604 = v614 
    #endif
#if FABLE_COMPILER_PYTHON
    let v617 : System.Guid = v603 |> System.Guid 
    let _run_target_args'_v604 = v617 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v620 : System.Guid = v603 |> System.Guid 
    let _run_target_args'_v604 = v620 
    #endif
#else
    let v623 : System.Guid = v603 |> System.Guid 
    let _run_target_args'_v604 = v623 
    #endif
    let v626 : System.Guid = _run_target_args'_v604 
    let _run_target_args'_v12 = v626 
    #endif
#else
    let v631 : int32 = 0 |> int32 
    let v638 : int32 = 8 |> int32 
    let v645 : int32 = v638 - 1
    let v646 : string = v11.[int v631..int v645]
    let v650 : int32 = 8 |> int32 
    let v657 : int32 = 12 |> int32 
    let v664 : int32 = v657 - 1
    let v665 : string = v11.[int v650..int v664]
    let v669 : int32 = 12 |> int32 
    let v676 : int32 = 16 |> int32 
    let v683 : int32 = v676 - 1
    let v684 : string = v11.[int v669..int v683]
    let v688 : int32 = 16 |> int32 
    let v695 : int32 = 20 |> int32 
    let v702 : int32 = v695 - 1
    let v703 : string = v11.[int v688..int v702]
    let v707 : int32 = 20 |> int32 
    let v714 : int32 = 32 |> int32 
    let v721 : int32 = v714 - 1
    let v722 : string = v11.[int v707..int v721]
    let v726 : string = $"{v646}-{v665}-{v684}-{v703}-{v722}"
    (* run_target_args'
    let v727 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v728 : System.Guid = v726 |> System.Guid 
    let _run_target_args'_v727 = v728 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v731 : System.Guid = v726 |> System.Guid 
    let _run_target_args'_v727 = v731 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v734 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v727 = v734 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v737 : System.Guid = v726 |> System.Guid 
    let _run_target_args'_v727 = v737 
    #endif
#if FABLE_COMPILER_PYTHON
    let v740 : System.Guid = v726 |> System.Guid 
    let _run_target_args'_v727 = v740 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v743 : System.Guid = v726 |> System.Guid 
    let _run_target_args'_v727 = v743 
    #endif
#else
    let v746 : System.Guid = v726 |> System.Guid 
    let _run_target_args'_v727 = v746 
    #endif
    let v749 : System.Guid = _run_target_args'_v727 
    let _run_target_args'_v12 = v749 
    #endif
    let v754 : System.Guid = _run_target_args'_v12 
    v754
and closure1 () (v0 : string) : System.Guid =
    method0(v0)
and closure3 () () : System.Guid =
    let v0 : (unit -> System.Guid) = System.Guid.NewGuid
    v0 ()
let v0 : (string -> System.Guid) = closure0()
let new_guid x = v0 x
let v1 : (string -> System.Guid) = closure1()
let hash_guid x = v1 x
let v2 : (unit -> System.Guid) = closure3()
let new_raw_guid x = v2 x
()
