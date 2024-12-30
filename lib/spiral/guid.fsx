let rec closure0 () (v0 : string) : System.Guid =
    let v1 : unit = ()
    
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
    let v112 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v113 : System.Guid = v111 |> System.Guid 
    let _run_target_args'_v112 = v113 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v116 : System.Guid = v111 |> System.Guid 
    let _run_target_args'_v112 = v116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v119 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v112 = v119 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v122 : System.Guid = v111 |> System.Guid 
    let _run_target_args'_v112 = v122 
    #endif
#if FABLE_COMPILER_PYTHON
    let v125 : System.Guid = v111 |> System.Guid 
    let _run_target_args'_v112 = v125 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v128 : System.Guid = v111 |> System.Guid 
    let _run_target_args'_v112 = v128 
    #endif
#else
    let v131 : System.Guid = v111 |> System.Guid 
    let _run_target_args'_v112 = v131 
    #endif
    let v134 : System.Guid = _run_target_args'_v112 
    let _run_target_args'_v1 = v134 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : string = v0.PadLeft (32, '0')
    let v153 : int32 = 0 |> int32 
    let v160 : int32 = 8 |> int32 
    let v167 : int32 = v160 - 1
    let v168 : string = v139.[int v153..int v167]
    let v172 : int32 = 8 |> int32 
    let v179 : int32 = 12 |> int32 
    let v186 : int32 = v179 - 1
    let v187 : string = v139.[int v172..int v186]
    let v191 : int32 = 12 |> int32 
    let v198 : int32 = 16 |> int32 
    let v205 : int32 = v198 - 1
    let v206 : string = v139.[int v191..int v205]
    let v210 : int32 = 16 |> int32 
    let v217 : int32 = 20 |> int32 
    let v224 : int32 = v217 - 1
    let v225 : string = v139.[int v210..int v224]
    let v229 : int32 = 20 |> int32 
    let v236 : int32 = 32 |> int32 
    let v243 : int32 = v236 - 1
    let v244 : string = v139.[int v229..int v243]
    let v248 : string = $"{v168}-{v187}-{v206}-{v225}-{v244}"
    let v249 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v250 : System.Guid = v248 |> System.Guid 
    let _run_target_args'_v249 = v250 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v253 : System.Guid = v248 |> System.Guid 
    let _run_target_args'_v249 = v253 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v256 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v249 = v256 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v259 : System.Guid = v248 |> System.Guid 
    let _run_target_args'_v249 = v259 
    #endif
#if FABLE_COMPILER_PYTHON
    let v262 : System.Guid = v248 |> System.Guid 
    let _run_target_args'_v249 = v262 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v265 : System.Guid = v248 |> System.Guid 
    let _run_target_args'_v249 = v265 
    #endif
#else
    let v268 : System.Guid = v248 |> System.Guid 
    let _run_target_args'_v249 = v268 
    #endif
    let v271 : System.Guid = _run_target_args'_v249 
    let _run_target_args'_v1 = v271 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v276 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v1 = v276 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v279 : string = v0.PadLeft (32, '0')
    let v293 : int32 = 0 |> int32 
    let v300 : int32 = 8 |> int32 
    let v307 : int32 = v300 - 1
    let v308 : string = v279.[int v293..int v307]
    let v312 : int32 = 8 |> int32 
    let v319 : int32 = 12 |> int32 
    let v326 : int32 = v319 - 1
    let v327 : string = v279.[int v312..int v326]
    let v331 : int32 = 12 |> int32 
    let v338 : int32 = 16 |> int32 
    let v345 : int32 = v338 - 1
    let v346 : string = v279.[int v331..int v345]
    let v350 : int32 = 16 |> int32 
    let v357 : int32 = 20 |> int32 
    let v364 : int32 = v357 - 1
    let v365 : string = v279.[int v350..int v364]
    let v369 : int32 = 20 |> int32 
    let v376 : int32 = 32 |> int32 
    let v383 : int32 = v376 - 1
    let v384 : string = v279.[int v369..int v383]
    let v388 : string = $"{v308}-{v327}-{v346}-{v365}-{v384}"
    let v389 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v390 : System.Guid = v388 |> System.Guid 
    let _run_target_args'_v389 = v390 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v393 : System.Guid = v388 |> System.Guid 
    let _run_target_args'_v389 = v393 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v396 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v389 = v396 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v399 : System.Guid = v388 |> System.Guid 
    let _run_target_args'_v389 = v399 
    #endif
#if FABLE_COMPILER_PYTHON
    let v402 : System.Guid = v388 |> System.Guid 
    let _run_target_args'_v389 = v402 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v405 : System.Guid = v388 |> System.Guid 
    let _run_target_args'_v389 = v405 
    #endif
#else
    let v408 : System.Guid = v388 |> System.Guid 
    let _run_target_args'_v389 = v408 
    #endif
    let v411 : System.Guid = _run_target_args'_v389 
    let _run_target_args'_v1 = v411 
    #endif
#if FABLE_COMPILER_PYTHON
    let v416 : string = v0.PadLeft (32, '0')
    let v430 : int32 = 0 |> int32 
    let v437 : int32 = 8 |> int32 
    let v444 : int32 = v437 - 1
    let v445 : string = v416.[int v430..int v444]
    let v449 : int32 = 8 |> int32 
    let v456 : int32 = 12 |> int32 
    let v463 : int32 = v456 - 1
    let v464 : string = v416.[int v449..int v463]
    let v468 : int32 = 12 |> int32 
    let v475 : int32 = 16 |> int32 
    let v482 : int32 = v475 - 1
    let v483 : string = v416.[int v468..int v482]
    let v487 : int32 = 16 |> int32 
    let v494 : int32 = 20 |> int32 
    let v501 : int32 = v494 - 1
    let v502 : string = v416.[int v487..int v501]
    let v506 : int32 = 20 |> int32 
    let v513 : int32 = 32 |> int32 
    let v520 : int32 = v513 - 1
    let v521 : string = v416.[int v506..int v520]
    let v525 : string = $"{v445}-{v464}-{v483}-{v502}-{v521}"
    let v526 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v527 : System.Guid = v525 |> System.Guid 
    let _run_target_args'_v526 = v527 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v530 : System.Guid = v525 |> System.Guid 
    let _run_target_args'_v526 = v530 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v533 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v526 = v533 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v536 : System.Guid = v525 |> System.Guid 
    let _run_target_args'_v526 = v536 
    #endif
#if FABLE_COMPILER_PYTHON
    let v539 : System.Guid = v525 |> System.Guid 
    let _run_target_args'_v526 = v539 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v542 : System.Guid = v525 |> System.Guid 
    let _run_target_args'_v526 = v542 
    #endif
#else
    let v545 : System.Guid = v525 |> System.Guid 
    let _run_target_args'_v526 = v545 
    #endif
    let v548 : System.Guid = _run_target_args'_v526 
    let _run_target_args'_v1 = v548 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v553 : string = v0.PadLeft (32, '0')
    let v567 : int32 = 0 |> int32 
    let v574 : int32 = 8 |> int32 
    let v581 : int32 = v574 - 1
    let v582 : string = v553.[int v567..int v581]
    let v586 : int32 = 8 |> int32 
    let v593 : int32 = 12 |> int32 
    let v600 : int32 = v593 - 1
    let v601 : string = v553.[int v586..int v600]
    let v605 : int32 = 12 |> int32 
    let v612 : int32 = 16 |> int32 
    let v619 : int32 = v612 - 1
    let v620 : string = v553.[int v605..int v619]
    let v624 : int32 = 16 |> int32 
    let v631 : int32 = 20 |> int32 
    let v638 : int32 = v631 - 1
    let v639 : string = v553.[int v624..int v638]
    let v643 : int32 = 20 |> int32 
    let v650 : int32 = 32 |> int32 
    let v657 : int32 = v650 - 1
    let v658 : string = v553.[int v643..int v657]
    let v662 : string = $"{v582}-{v601}-{v620}-{v639}-{v658}"
    let v663 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v664 : System.Guid = v662 |> System.Guid 
    let _run_target_args'_v663 = v664 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v667 : System.Guid = v662 |> System.Guid 
    let _run_target_args'_v663 = v667 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v670 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v663 = v670 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v673 : System.Guid = v662 |> System.Guid 
    let _run_target_args'_v663 = v673 
    #endif
#if FABLE_COMPILER_PYTHON
    let v676 : System.Guid = v662 |> System.Guid 
    let _run_target_args'_v663 = v676 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v679 : System.Guid = v662 |> System.Guid 
    let _run_target_args'_v663 = v679 
    #endif
#else
    let v682 : System.Guid = v662 |> System.Guid 
    let _run_target_args'_v663 = v682 
    #endif
    let v685 : System.Guid = _run_target_args'_v663 
    let _run_target_args'_v1 = v685 
    #endif
#else
    let v690 : string = v0.PadLeft (32, '0')
    let v704 : int32 = 0 |> int32 
    let v711 : int32 = 8 |> int32 
    let v718 : int32 = v711 - 1
    let v719 : string = v690.[int v704..int v718]
    let v723 : int32 = 8 |> int32 
    let v730 : int32 = 12 |> int32 
    let v737 : int32 = v730 - 1
    let v738 : string = v690.[int v723..int v737]
    let v742 : int32 = 12 |> int32 
    let v749 : int32 = 16 |> int32 
    let v756 : int32 = v749 - 1
    let v757 : string = v690.[int v742..int v756]
    let v761 : int32 = 16 |> int32 
    let v768 : int32 = 20 |> int32 
    let v775 : int32 = v768 - 1
    let v776 : string = v690.[int v761..int v775]
    let v780 : int32 = 20 |> int32 
    let v787 : int32 = 32 |> int32 
    let v794 : int32 = v787 - 1
    let v795 : string = v690.[int v780..int v794]
    let v799 : string = $"{v719}-{v738}-{v757}-{v776}-{v795}"
    let v800 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v801 : System.Guid = v799 |> System.Guid 
    let _run_target_args'_v800 = v801 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v804 : System.Guid = v799 |> System.Guid 
    let _run_target_args'_v800 = v804 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v807 : System.Guid = null |> unbox<System.Guid>
    let _run_target_args'_v800 = v807 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v810 : System.Guid = v799 |> System.Guid 
    let _run_target_args'_v800 = v810 
    #endif
#if FABLE_COMPILER_PYTHON
    let v813 : System.Guid = v799 |> System.Guid 
    let _run_target_args'_v800 = v813 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v816 : System.Guid = v799 |> System.Guid 
    let _run_target_args'_v800 = v816 
    #endif
#else
    let v819 : System.Guid = v799 |> System.Guid 
    let _run_target_args'_v800 = v819 
    #endif
    let v822 : System.Guid = _run_target_args'_v800 
    let _run_target_args'_v1 = v822 
    #endif
    let v827 : System.Guid = _run_target_args'_v1 
    v827
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
