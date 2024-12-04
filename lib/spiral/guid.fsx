let rec closure0 () (v0 : string) : System.Guid =
    let v1 : System.Guid = v0 |> System.Guid 
    v1
and method0 (v0 : string) : System.Guid =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = v0.PadLeft (32, '0')
    let v16 : int32 = 0 |> int32 
    let v23 : int32 = 8 |> int32 
    let v30 : int32 = v23 - 1
    let v31 : string = v2.[int v16..int v30]
    let v35 : int32 = 8 |> int32 
    let v42 : int32 = 12 |> int32 
    let v49 : int32 = v42 - 1
    let v50 : string = v2.[int v35..int v49]
    let v54 : int32 = 12 |> int32 
    let v61 : int32 = 16 |> int32 
    let v68 : int32 = v61 - 1
    let v69 : string = v2.[int v54..int v68]
    let v73 : int32 = 16 |> int32 
    let v80 : int32 = 20 |> int32 
    let v87 : int32 = v80 - 1
    let v88 : string = v2.[int v73..int v87]
    let v92 : int32 = 20 |> int32 
    let v99 : int32 = 32 |> int32 
    let v106 : int32 = v99 - 1
    let v107 : string = v2.[int v92..int v106]
    let v111 : string = $"{v31}-{v50}-{v69}-{v88}-{v107}"
    let _v1 = v111 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v112 : string = v0.PadLeft (32, '0')
    let v126 : int32 = 0 |> int32 
    let v133 : int32 = 8 |> int32 
    let v140 : int32 = v133 - 1
    let v141 : string = v112.[int v126..int v140]
    let v145 : int32 = 8 |> int32 
    let v152 : int32 = 12 |> int32 
    let v159 : int32 = v152 - 1
    let v160 : string = v112.[int v145..int v159]
    let v164 : int32 = 12 |> int32 
    let v171 : int32 = 16 |> int32 
    let v178 : int32 = v171 - 1
    let v179 : string = v112.[int v164..int v178]
    let v183 : int32 = 16 |> int32 
    let v190 : int32 = 20 |> int32 
    let v197 : int32 = v190 - 1
    let v198 : string = v112.[int v183..int v197]
    let v202 : int32 = 20 |> int32 
    let v209 : int32 = 32 |> int32 
    let v216 : int32 = v209 - 1
    let v217 : string = v112.[int v202..int v216]
    let v221 : string = $"{v141}-{v160}-{v179}-{v198}-{v217}"
    let _v1 = v221 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v222 : string = null |> unbox<string>
    let _v1 = v222 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v225 : string = v0.PadLeft (32, '0')
    let v239 : int32 = 0 |> int32 
    let v246 : int32 = 8 |> int32 
    let v253 : int32 = v246 - 1
    let v254 : string = v225.[int v239..int v253]
    let v258 : int32 = 8 |> int32 
    let v265 : int32 = 12 |> int32 
    let v272 : int32 = v265 - 1
    let v273 : string = v225.[int v258..int v272]
    let v277 : int32 = 12 |> int32 
    let v284 : int32 = 16 |> int32 
    let v291 : int32 = v284 - 1
    let v292 : string = v225.[int v277..int v291]
    let v296 : int32 = 16 |> int32 
    let v303 : int32 = 20 |> int32 
    let v310 : int32 = v303 - 1
    let v311 : string = v225.[int v296..int v310]
    let v315 : int32 = 20 |> int32 
    let v322 : int32 = 32 |> int32 
    let v329 : int32 = v322 - 1
    let v330 : string = v225.[int v315..int v329]
    let v334 : string = $"{v254}-{v273}-{v292}-{v311}-{v330}"
    let _v1 = v334 
    #endif
#if FABLE_COMPILER_PYTHON
    let v335 : string = v0.PadLeft (32, '0')
    let v349 : int32 = 0 |> int32 
    let v356 : int32 = 8 |> int32 
    let v363 : int32 = v356 - 1
    let v364 : string = v335.[int v349..int v363]
    let v368 : int32 = 8 |> int32 
    let v375 : int32 = 12 |> int32 
    let v382 : int32 = v375 - 1
    let v383 : string = v335.[int v368..int v382]
    let v387 : int32 = 12 |> int32 
    let v394 : int32 = 16 |> int32 
    let v401 : int32 = v394 - 1
    let v402 : string = v335.[int v387..int v401]
    let v406 : int32 = 16 |> int32 
    let v413 : int32 = 20 |> int32 
    let v420 : int32 = v413 - 1
    let v421 : string = v335.[int v406..int v420]
    let v425 : int32 = 20 |> int32 
    let v432 : int32 = 32 |> int32 
    let v439 : int32 = v432 - 1
    let v440 : string = v335.[int v425..int v439]
    let v444 : string = $"{v364}-{v383}-{v402}-{v421}-{v440}"
    let _v1 = v444 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v445 : string = v0.PadLeft (32, '0')
    let v459 : int32 = 0 |> int32 
    let v466 : int32 = 8 |> int32 
    let v473 : int32 = v466 - 1
    let v474 : string = v445.[int v459..int v473]
    let v478 : int32 = 8 |> int32 
    let v485 : int32 = 12 |> int32 
    let v492 : int32 = v485 - 1
    let v493 : string = v445.[int v478..int v492]
    let v497 : int32 = 12 |> int32 
    let v504 : int32 = 16 |> int32 
    let v511 : int32 = v504 - 1
    let v512 : string = v445.[int v497..int v511]
    let v516 : int32 = 16 |> int32 
    let v523 : int32 = 20 |> int32 
    let v530 : int32 = v523 - 1
    let v531 : string = v445.[int v516..int v530]
    let v535 : int32 = 20 |> int32 
    let v542 : int32 = 32 |> int32 
    let v549 : int32 = v542 - 1
    let v550 : string = v445.[int v535..int v549]
    let v554 : string = $"{v474}-{v493}-{v512}-{v531}-{v550}"
    let _v1 = v554 
    #endif
#else
    let v555 : string = v0.PadLeft (32, '0')
    let v569 : int32 = 0 |> int32 
    let v576 : int32 = 8 |> int32 
    let v583 : int32 = v576 - 1
    let v584 : string = v555.[int v569..int v583]
    let v588 : int32 = 8 |> int32 
    let v595 : int32 = 12 |> int32 
    let v602 : int32 = v595 - 1
    let v603 : string = v555.[int v588..int v602]
    let v607 : int32 = 12 |> int32 
    let v614 : int32 = 16 |> int32 
    let v621 : int32 = v614 - 1
    let v622 : string = v555.[int v607..int v621]
    let v626 : int32 = 16 |> int32 
    let v633 : int32 = 20 |> int32 
    let v640 : int32 = v633 - 1
    let v641 : string = v555.[int v626..int v640]
    let v645 : int32 = 20 |> int32 
    let v652 : int32 = 32 |> int32 
    let v659 : int32 = v652 - 1
    let v660 : string = v555.[int v645..int v659]
    let v664 : string = $"{v584}-{v603}-{v622}-{v641}-{v660}"
    let _v1 = v664 
    #endif
    let v665 : string = _v1 
    let v777 : System.Guid = v665 |> System.Guid 
    v777
and closure1 () (v0 : string) : System.Guid =
    method0(v0)
and closure2 () () : System.Guid =
    let v0 : (unit -> System.Guid) = System.Guid.NewGuid
    v0 ()
let v0 : (string -> System.Guid) = closure0()
let new_guid x = v0 x
let v1 : (string -> System.Guid) = closure1()
let hash_guid x = v1 x
let v2 : (unit -> System.Guid) = closure2()
let new_raw_guid x = v2 x
()
