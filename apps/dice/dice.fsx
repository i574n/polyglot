type UH0 =
    | UH0_0 of uint8 * (unit -> UH0)
    | UH0_1
and UH1 =
    | UH1_0 of uint8 * UH1
    | UH1_1
and [<Struct>] US0 =
    | US0_0
    | US0_1 of f1_0 : (string -> unit)
and [<Struct>] US1 =
    | US1_0 of f0_0 : UH0
    | US1_1 of f1_0 : (unit -> UH0)
and Mut0 = {mutable l0 : US1}
and Mut1 = {mutable l0 : int64}
and [<Struct>] US2 =
    | US2_0
    | US2_1 of f1_0 : uint8
and Mut2 = {mutable l0 : US2}
and [<Struct>] US3 =
    | US3_0
    | US3_1 of f1_0 : uint64 * f1_1 : UH1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US4 =
    | US4_0
    | US4_1 of f1_0 : uint64
and [<Struct>] US5 =
    | US5_0
    | US5_1 of f1_0 : int64 * f1_1 : UH1
let rec closure2 (v0 : UH0) () : UH0 =
    v0
and method0 (v0 : int64, v1 : UH0, v2 : UH0) : UH0 =
    match v1 with
    | UH0_0(v3, v4) -> (* StreamCons *)
        let v5 : UH0 = v4 ()
        let v6 : UH0 = method0(v0, v5, v2)
        let v7 : int64 = int64 v3
        let v8 : int64 = v7 - 1L
        let v9 : int64 = v8 + v0
        let v10 : int64 = v9 % v0
        let v11 : int64 = v10 + 1L
        let v12 : uint8 = uint8 v11
        let v13 : (unit -> UH0) = closure2(v6)
        UH0_0(v12, v13)
    | UH0_1 -> (* StreamNil *)
        v2
and closure1 (v0 : int64) (v1 : UH0) : UH0 =
    let v2 : UH0 = UH0_1
    method0(v0, v1, v2)
and closure0 () (v0 : int64) : (UH0 -> UH0) =
    closure1(v0)
and closure4 () (v0 : (string -> unit)) : US0 =
    US0_1(v0)
and method1 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : UH1 = UH1_0(v2, v1)
        method1(v3, v4)
    | UH1_1 -> (* Nil *)
        v1
and method2 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : UH1 = method2(v3, v1)
        UH1_0(v2, v4)
    | UH1_1 -> (* Nil *)
        v1
and closure6 (v0 : UH0) () : UH0 =
    v0
and method3 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : UH0 = method3(v3, v1)
        let v5 : (unit -> UH0) = closure6(v4)
        UH0_0(v2, v5)
    | UH1_1 -> (* Nil *)
        v1
and closure7 (v0 : UH0) () : UH0 =
    v0
and closure8 (v0 : UH0, v1 : Mut0) () : UH0 =
    let v2 : US1 = v1.l0
    match v2 with
    | US1_0(v3) -> (* Computed *)
        v3
    | US1_1(v4) -> (* NotComputed *)
        let v5 : UH0 = v4 ()
        let v12 : UH0 =
            match v5 with
            | UH0_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH0) = method4(v0, v8)
                UH0_0(v7, v9)
            | UH0_1 -> (* StreamNil *)
                UH0_1
        let v13 : US1 = US1_0(v12)
        v1.l0 <- v13
        v12
and method4 (v0 : UH0, v1 : (unit -> UH0)) : (unit -> UH0) =
    let v2 : US1 = US1_1(v1)
    let v3 : Mut0 = {l0 = v2} : Mut0
    closure8(v0, v3)
and method6 (v0 : int64, v1 : UH0) : US2 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US2_1(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method6(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US2_0
and method5 (v0 : US0, v1 : (unit -> UH0), v2 : Mut1, v3 : Mut1, v4 : Mut1, v5 : Mut2) : uint8 =
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : int64 = v4.l0
    let v9 : US2 = v5.l0
    let v10 : string = $"create_sequential_roller / roll / current_index: {v6} / acc: {v7} / len: {v8} / last_item: %A{v9}"
    match v0 with
    | US0_0 -> (* None *)
        ()
    | US0_1(v11) -> (* Some *)
        v11 v10
    let v12 : UH0 = v1 ()
    let v13 : int64 = v2.l0
    let v14 : US2 = method6(v13, v12)
    match v14 with
    | US2_0 -> (* None *)
        let v19 : string = $"create_sequential_roller / roll / None"
        match v0 with
        | US0_0 -> (* None *)
            ()
        | US0_1(v20) -> (* Some *)
            v20 v19
        let v21 : int64 = v4.l0
        let v22 : bool = v21 = -1L
        if v22 then
            let v23 : int64 = v2.l0
            v4.l0 <- v23
            ()
        let v24 : int64 = v3.l0
        let v25 : int64 = v4.l0
        let v26 : bool = v24 >= v25
        let v29 : int64 =
            if v26 then
                1L
            else
                let v27 : int64 = v3.l0
                let v28 : int64 = v27 + 1L
                v28
        v3.l0 <- v29
        let v30 : int64 = v3.l0
        let v31 : int64 = v30 - 1L
        v2.l0 <- v31
        let v32 : US2 = US2_0
        v5.l0 <- v32
        method5(v0, v1, v2, v3, v4, v5)
    | US2_1(v15) -> (* Some *)
        let v16 : int64 = v2.l0
        let v17 : int64 = v16 + 1L
        v2.l0 <- v17
        let v18 : US2 = US2_1(v15)
        v5.l0 <- v18
        v15
and closure9 (v0 : US0, v1 : (unit -> UH0), v2 : Mut1, v3 : Mut1, v4 : Mut1, v5 : Mut2) () : uint8 =
    method5(v0, v1, v2, v3, v4, v5)
and closure5 (v0 : US0) (v1 : UH1) : (unit -> uint8) =
    let v2 : string = $"create_sequential_roller ()"
    match v0 with
    | US0_0 -> (* None *)
        ()
    | US0_1(v3) -> (* Some *)
        v3 v2
    let v4 : UH1 = UH1_1
    let v5 : UH1 = method1(v1, v4)
    let v6 : UH1 = method2(v1, v5)
    let v7 : UH0 = UH0_1
    let v8 : UH0 = method3(v6, v7)
    let v9 : (unit -> UH0) = closure7(v8)
    let v10 : (unit -> UH0) = method4(v8, v9)
    let v11 : Mut1 = {l0 = 0L} : Mut1
    let v12 : Mut1 = {l0 = 1L} : Mut1
    let v13 : Mut1 = {l0 = -1L} : Mut1
    let v14 : US2 = US2_0
    let v15 : Mut2 = {l0 = v14} : Mut2
    closure9(v0, v10, v11, v12, v13, v15)
and closure3 () (v0 : (string -> unit) option) : (UH1 -> (unit -> uint8)) =
    let v1 : ((string -> unit) -> US0) = closure4()
    let v2 : US0 = US0_0
    let v3 : US0 = v0 |> Option.map v1 |> Option.defaultValue v2
    closure5(v3)
and method7 (v0 : US0, v1 : uint64, v2 : int8, v3 : uint64) : int8 =
    let v4 : bool = v3 < v1
    if v4 then
        let v5 : uint64 = v3 * 6UL
        let v6 : bool = v5 > v3
        if v6 then
            let v7 : int8 = v2 + 1y
            method7(v0, v1, v7, v5)
        else
            let v9 : string = $"calculate_dice_count / max: {v1} / n: {v2} / p: {v3}"
            match v0 with
            | US0_0 -> (* None *)
                ()
            | US0_1(v10) -> (* Some *)
                v10 v9
            v2
    else
        let v12 : string = $"calculate_dice_count / max: {v1} / n: {v2} / p: {v3}"
        match v0 with
        | US0_0 -> (* None *)
            ()
        | US0_1(v13) -> (* Some *)
            v13 v12
        v2
and closure77 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(0UL, v0)
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(9223372036854775808UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(4611686018427387904UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_0(6917529027641081856UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_0(1152921504606846976UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_0(15564440312192434176UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_0(11817445422220181504UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_0(5044031582654955520UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_0(6989586621679009792UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_0(16537217831704461312UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_0(11979575008805519360UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_0(14294425217273954304UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_0(2382404202878992384UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_0(6545982058383015936UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_0(10314369046585278464UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_0(4793518853382471680UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_0(3873377154515337216UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_0(645562859085889536UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_0(107593809847648256UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_0(3092389647259533312UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_0(9738770311398031360UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_0(16995415113324298240UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_0(8981483876790566912UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_0(13794743361938128896UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_0(2299123893656354816UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_0(3457644661227651072UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_0(576274110204608512UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_0(6244960376270618624UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_0(13338656111851470848UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_0(14520938734448279552UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_0(14717985838214414336UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_0(5527454985320660992UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_0(16293529225644736512UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_0(11938960241128898560UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_0(8138741398091333632UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_0(7505371590918406144UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_0(16623181993244360704UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_0(8919445023443910656UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_0(4561031516192243712UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_0(9983543956220149760UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_0(4738381338321616896UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_0(789730223053602816UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_0(131621703842267136UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_0(21936950640377856UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_0(3656158440062976UL, v0)
and closure32 () () : UH2 =
    let v0 : (unit -> UH2) = closure33()
    UH2_0(609359740010496UL, v0)
and closure31 () () : UH2 =
    let v0 : (unit -> UH2) = closure32()
    UH2_0(101559956668416UL, v0)
and closure30 () () : UH2 =
    let v0 : (unit -> UH2) = closure31()
    UH2_0(16926659444736UL, v0)
and closure29 () () : UH2 =
    let v0 : (unit -> UH2) = closure30()
    UH2_0(2821109907456UL, v0)
and closure28 () () : UH2 =
    let v0 : (unit -> UH2) = closure29()
    UH2_0(470184984576UL, v0)
and closure27 () () : UH2 =
    let v0 : (unit -> UH2) = closure28()
    UH2_0(78364164096UL, v0)
and closure26 () () : UH2 =
    let v0 : (unit -> UH2) = closure27()
    UH2_0(13060694016UL, v0)
and closure25 () () : UH2 =
    let v0 : (unit -> UH2) = closure26()
    UH2_0(2176782336UL, v0)
and closure24 () () : UH2 =
    let v0 : (unit -> UH2) = closure25()
    UH2_0(362797056UL, v0)
and closure23 () () : UH2 =
    let v0 : (unit -> UH2) = closure24()
    UH2_0(60466176UL, v0)
and closure22 () () : UH2 =
    let v0 : (unit -> UH2) = closure23()
    UH2_0(10077696UL, v0)
and closure21 () () : UH2 =
    let v0 : (unit -> UH2) = closure22()
    UH2_0(1679616UL, v0)
and closure20 () () : UH2 =
    let v0 : (unit -> UH2) = closure21()
    UH2_0(279936UL, v0)
and closure19 () () : UH2 =
    let v0 : (unit -> UH2) = closure20()
    UH2_0(46656UL, v0)
and closure18 () () : UH2 =
    let v0 : (unit -> UH2) = closure19()
    UH2_0(7776UL, v0)
and closure17 () () : UH2 =
    let v0 : (unit -> UH2) = closure18()
    UH2_0(1296UL, v0)
and closure16 () () : UH2 =
    let v0 : (unit -> UH2) = closure17()
    UH2_0(216UL, v0)
and closure15 () () : UH2 =
    let v0 : (unit -> UH2) = closure16()
    UH2_0(36UL, v0)
and closure14 () () : UH2 =
    let v0 : (unit -> UH2) = closure15()
    UH2_0(6UL, v0)
and method10 (v0 : int8, v1 : UH2) : US4 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US4_1(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method10(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US4_0
and method9 (v0 : US0, v1 : int8, v2 : UH1, v3 : uint64) : US3 =
    let v4 : bool = v1 < 0y
    if v4 then
        let v5 : string = $"accumulate_dice_rolls / power: {v1} / acc: {v3}"
        match v0 with
        | US0_0 -> (* None *)
            ()
        | US0_1(v6) -> (* Some *)
            v6 v5
        let v7 : uint64 = v3 + 1UL
        US3_1(v7, v2)
    else
        match v2 with
        | UH1_0(v10, v11) -> (* Cons *)
            let v12 : bool = v10 > 1uy
            if v12 then
                let v13 : uint64 = 1UL
                let v14 : (unit -> UH2) = closure14()
                let v15 : UH2 = UH2_0(v13, v14)
                let v16 : US4 = method10(v1, v15)
                let v20 : uint64 =
                    match v16 with
                    | US4_0 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US4_1(v17) -> (* Some *)
                        v17
                let v21 : uint8 = v10 - 1uy
                let v22 : uint64 = uint64 v21
                let v23 : uint64 = v22 * v20
                let v24 : string = $"accumulate_dice_rolls / power: {v1} / acc: {v3} / roll: {v10} / value: {v23}"
                match v0 with
                | US0_0 -> (* None *)
                    ()
                | US0_1(v25) -> (* Some *)
                    v25 v24
                let v26 : uint64 = v3 + v23
                let v27 : int8 = v1 - 1y
                method9(v0, v27, v11, v26)
            else
                let v29 : string = $"accumulate_dice_rolls / power: {v1} / acc: {v3} / roll: {v10}"
                match v0 with
                | US0_0 -> (* None *)
                    ()
                | US0_1(v30) -> (* Some *)
                    v30 v29
                let v31 : int8 = v1 - 1y
                method9(v0, v31, v11, v3)
        | UH1_1 -> (* Nil *)
            US3_0
and method11 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method11(v0, v1, v5)
        UH1_0(v4, v6)
    else
        UH1_1
and method12 (v0 : US0, v1 : (unit -> uint8), v2 : bool, v3 : uint64, v4 : int8, v5 : UH1) : uint64 =
    let v6 : int8 = v4 + 1y
    let v7 : bool = v4 < v6
    if v7 then
        let v8 : uint8 = v1 ()
        let v9 : UH1 = UH1_0(v8, v5)
        method8(v0, v1, v2, v3, v4, v9, v6)
    else
        let v11 : uint64 = 0UL
        let v12 : US3 = method9(v0, v4, v5, v11)
        match v12 with
        | US3_1(v13, v14) -> (* Some *)
            let v15 : bool = v13 <= v3
            if v15 then
                v13
            else
                if v2 then
                    let v16 : int8 = 0y
                    let v17 : UH1 = method11(v4, v1, v16)
                    method12(v0, v1, v2, v3, v4, v17)
                else
                    let v19 : uint8 = v1 ()
                    let v20 : UH1 = UH1_0(v19, v5)
                    method8(v0, v1, v2, v3, v4, v20, v6)
        | _ ->
            if v2 then
                let v24 : int8 = 0y
                let v25 : UH1 = method11(v4, v1, v24)
                method12(v0, v1, v2, v3, v4, v25)
            else
                let v27 : uint8 = v1 ()
                let v28 : UH1 = UH1_0(v27, v5)
                method8(v0, v1, v2, v3, v4, v28, v6)
and method8 (v0 : US0, v1 : (unit -> uint8), v2 : bool, v3 : uint64, v4 : int8, v5 : UH1, v6 : int8) : uint64 =
    let v7 : int8 = v4 + 1y
    let v8 : bool = v6 < v7
    if v8 then
        let v9 : uint8 = v1 ()
        let v10 : UH1 = UH1_0(v9, v5)
        let v11 : int8 = v6 + 1y
        method8(v0, v1, v2, v3, v4, v10, v11)
    else
        let v13 : uint64 = 0UL
        let v14 : US3 = method9(v0, v4, v5, v13)
        match v14 with
        | US3_1(v15, v16) -> (* Some *)
            let v17 : bool = v15 <= v3
            if v17 then
                v15
            else
                if v2 then
                    let v18 : int8 = 0y
                    let v19 : UH1 = method11(v4, v1, v18)
                    method12(v0, v1, v2, v3, v4, v19)
                else
                    let v21 : uint8 = v1 ()
                    let v22 : UH1 = UH1_0(v21, v5)
                    let v23 : int8 = v6 + 1y
                    method8(v0, v1, v2, v3, v4, v22, v23)
        | _ ->
            if v2 then
                let v27 : int8 = 0y
                let v28 : UH1 = method11(v4, v1, v27)
                method12(v0, v1, v2, v3, v4, v28)
            else
                let v30 : uint8 = v1 ()
                let v31 : UH1 = UH1_0(v30, v5)
                let v32 : int8 = v6 + 1y
                method8(v0, v1, v2, v3, v4, v31, v32)
and closure13 (v0 : US0, v1 : (unit -> uint8), v2 : bool) (v3 : uint64) : uint64 =
    let v4 : bool = v3 = 1UL
    let v8 : int8 =
        if v4 then
            1y
        else
            let v5 : int8 = 0y
            let v6 : uint64 = 1UL
            method7(v0, v3, v5, v6)
    let v9 : int8 = v8 - 1y
    let v10 : UH1 = UH1_1
    let v11 : int8 = 0y
    method8(v0, v1, v2, v3, v9, v10, v11)
and closure12 (v0 : US0, v1 : (unit -> uint8)) (v2 : bool) : (uint64 -> uint64) =
    closure13(v0, v1, v2)
and closure11 (v0 : US0) (v1 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure12(v0, v1)
and closure10 () (v0 : (string -> unit) option) : ((unit -> uint8) -> (bool -> (uint64 -> uint64))) =
    let v1 : ((string -> unit) -> US0) = closure4()
    let v2 : US0 = US0_0
    let v3 : US0 = v0 |> Option.map v1 |> Option.defaultValue v2
    closure11(v3)
and method13 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method13(v3, v4)
    | UH1_1 -> (* Nil *)
        v1
and closure80 (v0 : (string -> unit) option, v1 : uint64) (v2 : UH1) : uint64 option =
    let v3 : ((string -> unit) -> US0) = closure4()
    let v4 : US0 = US0_0
    let v5 : US0 = v0 |> Option.map v3 |> Option.defaultValue v4
    let v6 : int8 = 0y
    let v7 : int8 = method13(v2, v6)
    let v8 : int8 = v7 - 1y
    let v9 : uint64 = 0UL
    let v10 : US3 = method9(v5, v8, v2, v9)
    let v20 : US4 =
        match v10 with
        | US3_1(v11, v12) -> (* Some *)
            let v13 : bool = v11 >= 1UL
            let v15 : bool =
                if v13 then
                    let v14 : bool = v11 <= v1
                    v14
                else
                    false
            if v15 then
                US4_1(v11)
            else
                US4_0
        | _ ->
            US4_0
    match v20 with
    | US4_0 -> (* None *)
        let v23 : uint64 option = None
        v23
    | US4_1(v21) -> (* Some *)
        let v22 : uint64 option = Some v21
        v22
and closure79 (v0 : (string -> unit) option) (v1 : uint64) : (UH1 -> uint64 option) =
    closure80(v0, v1)
and closure78 () (v0 : (string -> unit) option) : (uint64 -> (UH1 -> uint64 option)) =
    closure79(v0)
and method39 (v0 : UH1, v1 : int64) : US5 =
    let v2 : string = $"accumulate_dice_rolls / power: {-1y} / acc: {v1}"
    System.Console.WriteLine v2
    let v3 : int64 = v1 + 1L
    US5_1(v3, v0)
and method38 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : string = $"accumulate_dice_rolls / power: {0y} / acc: {v1} / roll: {v3} / value: {v7}"
            System.Console.WriteLine v8
            let v9 : int64 = v1 + v7
            method39(v4, v9)
        else
            let v11 : string = $"accumulate_dice_rolls / power: {0y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v11
            method39(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method37 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 6L
            let v9 : string = $"accumulate_dice_rolls / power: {1y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method38(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {1y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method38(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method36 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 36L
            let v9 : string = $"accumulate_dice_rolls / power: {2y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method37(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {2y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method37(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method35 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 216L
            let v9 : string = $"accumulate_dice_rolls / power: {3y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method36(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {3y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method36(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method34 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1296L
            let v9 : string = $"accumulate_dice_rolls / power: {4y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method35(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {4y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method35(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method33 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 7776L
            let v9 : string = $"accumulate_dice_rolls / power: {5y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method34(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {5y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method34(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method32 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 46656L
            let v9 : string = $"accumulate_dice_rolls / power: {6y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method33(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {6y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method33(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method31 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 279936L
            let v9 : string = $"accumulate_dice_rolls / power: {7y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method32(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {7y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method32(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method30 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1679616L
            let v9 : string = $"accumulate_dice_rolls / power: {8y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method31(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {8y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method31(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method29 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 10077696L
            let v9 : string = $"accumulate_dice_rolls / power: {9y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method30(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {9y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method30(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method28 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 60466176L
            let v9 : string = $"accumulate_dice_rolls / power: {10y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method29(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {10y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method29(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method27 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 362797056L
            let v9 : string = $"accumulate_dice_rolls / power: {11y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method28(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {11y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method28(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method26 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2176782336L
            let v9 : string = $"accumulate_dice_rolls / power: {12y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method27(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {12y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method27(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method25 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 13060694016L
            let v9 : string = $"accumulate_dice_rolls / power: {13y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method26(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {13y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method26(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method24 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 78364164096L
            let v9 : string = $"accumulate_dice_rolls / power: {14y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method25(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {14y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method25(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method23 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 470184984576L
            let v9 : string = $"accumulate_dice_rolls / power: {15y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method24(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {15y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method24(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method22 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2821109907456L
            let v9 : string = $"accumulate_dice_rolls / power: {16y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method23(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {16y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method23(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method21 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 16926659444736L
            let v9 : string = $"accumulate_dice_rolls / power: {17y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method22(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {17y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method22(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method20 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 101559956668416L
            let v9 : string = $"accumulate_dice_rolls / power: {18y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method21(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {18y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method21(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method19 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 609359740010496L
            let v9 : string = $"accumulate_dice_rolls / power: {19y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method20(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {19y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method20(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method18 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 3656158440062976L
            let v9 : string = $"accumulate_dice_rolls / power: {20y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method19(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {20y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method19(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method17 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 21936950640377856L
            let v9 : string = $"accumulate_dice_rolls / power: {21y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method18(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {21y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method18(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method16 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 131621703842267136L
            let v9 : string = $"accumulate_dice_rolls / power: {22y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method17(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {22y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method17(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method15 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_0(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v9 : string = $"accumulate_dice_rolls / power: {23y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method16(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {23y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method16(v4, v1)
    | UH1_1 -> (* Nil *)
        US5_0
and method14 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let mutable result = None
        #if FABLE_COMPILER_RUST
        #if !WASM
        let v3 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
        let v4 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3
        v4
        #else
        let v5 : string = "1"
        let v6 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5
        v6
        #endif
        #else
        let v7 : uint8 = System.Random().Next (1, 7) |> uint8
        v7
        #endif
        |> fun x -> result <- Some x
        let v8 : uint8 = result |> Option.get
        let v9 : UH1 = UH1_0(v8, v0)
        let v10 : int8 = v1 + 1y
        method14(v9, v10)
    else
        let v12 : int64 = 0L
        let v13 : US5 = method15(v0, v12)
        match v13 with
        | US5_1(v14, v15) -> (* Some *)
            let v16 : bool = v14 <= 9223372036854775807L
            if v16 then
                v14
            else
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v17 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v18 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v18
                #else
                let v19 : string = "1"
                let v20 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v20
                #endif
                #else
                let v21 : uint8 = System.Random().Next (1, 7) |> uint8
                v21
                #endif
                |> fun x -> result <- Some x
                let v22 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v23 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v23
                #else
                let v24 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v24
                #endif
                #else
                let v25 : uint8 = System.Random().Next (1, 7) |> uint8
                v25
                #endif
                |> fun x -> result <- Some x
                let v26 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v27 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v27
                #else
                let v28 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v28
                #endif
                #else
                let v29 : uint8 = System.Random().Next (1, 7) |> uint8
                v29
                #endif
                |> fun x -> result <- Some x
                let v30 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v31 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v31
                #else
                let v32 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v32
                #endif
                #else
                let v33 : uint8 = System.Random().Next (1, 7) |> uint8
                v33
                #endif
                |> fun x -> result <- Some x
                let v34 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v35 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v35
                #else
                let v36 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v36
                #endif
                #else
                let v37 : uint8 = System.Random().Next (1, 7) |> uint8
                v37
                #endif
                |> fun x -> result <- Some x
                let v38 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v39 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v39
                #else
                let v40 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v40
                #endif
                #else
                let v41 : uint8 = System.Random().Next (1, 7) |> uint8
                v41
                #endif
                |> fun x -> result <- Some x
                let v42 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v43 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v43
                #else
                let v44 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v44
                #endif
                #else
                let v45 : uint8 = System.Random().Next (1, 7) |> uint8
                v45
                #endif
                |> fun x -> result <- Some x
                let v46 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v47 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v47
                #else
                let v48 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v48
                #endif
                #else
                let v49 : uint8 = System.Random().Next (1, 7) |> uint8
                v49
                #endif
                |> fun x -> result <- Some x
                let v50 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v51 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v51
                #else
                let v52 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v52
                #endif
                #else
                let v53 : uint8 = System.Random().Next (1, 7) |> uint8
                v53
                #endif
                |> fun x -> result <- Some x
                let v54 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v55 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v55
                #else
                let v56 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v56
                #endif
                #else
                let v57 : uint8 = System.Random().Next (1, 7) |> uint8
                v57
                #endif
                |> fun x -> result <- Some x
                let v58 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v59 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v59
                #else
                let v60 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v60
                #endif
                #else
                let v61 : uint8 = System.Random().Next (1, 7) |> uint8
                v61
                #endif
                |> fun x -> result <- Some x
                let v62 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v63 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v63
                #else
                let v64 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v64
                #endif
                #else
                let v65 : uint8 = System.Random().Next (1, 7) |> uint8
                v65
                #endif
                |> fun x -> result <- Some x
                let v66 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v67 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v67
                #else
                let v68 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v68
                #endif
                #else
                let v69 : uint8 = System.Random().Next (1, 7) |> uint8
                v69
                #endif
                |> fun x -> result <- Some x
                let v70 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v71 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v71
                #else
                let v72 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v72
                #endif
                #else
                let v73 : uint8 = System.Random().Next (1, 7) |> uint8
                v73
                #endif
                |> fun x -> result <- Some x
                let v74 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v75 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v75
                #else
                let v76 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v76
                #endif
                #else
                let v77 : uint8 = System.Random().Next (1, 7) |> uint8
                v77
                #endif
                |> fun x -> result <- Some x
                let v78 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v79 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v79
                #else
                let v80 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v80
                #endif
                #else
                let v81 : uint8 = System.Random().Next (1, 7) |> uint8
                v81
                #endif
                |> fun x -> result <- Some x
                let v82 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v83 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v83
                #else
                let v84 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v84
                #endif
                #else
                let v85 : uint8 = System.Random().Next (1, 7) |> uint8
                v85
                #endif
                |> fun x -> result <- Some x
                let v86 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v87 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v87
                #else
                let v88 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v88
                #endif
                #else
                let v89 : uint8 = System.Random().Next (1, 7) |> uint8
                v89
                #endif
                |> fun x -> result <- Some x
                let v90 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v91 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v91
                #else
                let v92 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v92
                #endif
                #else
                let v93 : uint8 = System.Random().Next (1, 7) |> uint8
                v93
                #endif
                |> fun x -> result <- Some x
                let v94 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v95 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v95
                #else
                let v96 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v96
                #endif
                #else
                let v97 : uint8 = System.Random().Next (1, 7) |> uint8
                v97
                #endif
                |> fun x -> result <- Some x
                let v98 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v99 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v99
                #else
                let v100 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v100
                #endif
                #else
                let v101 : uint8 = System.Random().Next (1, 7) |> uint8
                v101
                #endif
                |> fun x -> result <- Some x
                let v102 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v103 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v103
                #else
                let v104 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v104
                #endif
                #else
                let v105 : uint8 = System.Random().Next (1, 7) |> uint8
                v105
                #endif
                |> fun x -> result <- Some x
                let v106 : uint8 = result |> Option.get
                let mutable result = None
                #if FABLE_COMPILER_RUST
                #if !WASM
                let v107 : uint8 = Fable.Core.RustInterop.emitRustExpr () v17
                v107
                #else
                let v108 : uint8 = Fable.Core.RustInterop.emitRustExpr () v19
                v108
                #endif
                #else
                let v109 : uint8 = System.Random().Next (1, 7) |> uint8
                v109
                #endif
                |> fun x -> result <- Some x
                let v110 : uint8 = result |> Option.get
                let v111 : UH1 = UH1_1
                let v112 : UH1 = UH1_0(v110, v111)
                let v113 : UH1 = UH1_0(v106, v112)
                let v114 : UH1 = UH1_0(v102, v113)
                let v115 : UH1 = UH1_0(v98, v114)
                let v116 : UH1 = UH1_0(v94, v115)
                let v117 : UH1 = UH1_0(v90, v116)
                let v118 : UH1 = UH1_0(v86, v117)
                let v119 : UH1 = UH1_0(v82, v118)
                let v120 : UH1 = UH1_0(v78, v119)
                let v121 : UH1 = UH1_0(v74, v120)
                let v122 : UH1 = UH1_0(v70, v121)
                let v123 : UH1 = UH1_0(v66, v122)
                let v124 : UH1 = UH1_0(v62, v123)
                let v125 : UH1 = UH1_0(v58, v124)
                let v126 : UH1 = UH1_0(v54, v125)
                let v127 : UH1 = UH1_0(v50, v126)
                let v128 : UH1 = UH1_0(v46, v127)
                let v129 : UH1 = UH1_0(v42, v128)
                let v130 : UH1 = UH1_0(v38, v129)
                let v131 : UH1 = UH1_0(v34, v130)
                let v132 : UH1 = UH1_0(v30, v131)
                let v133 : UH1 = UH1_0(v26, v132)
                let v134 : UH1 = UH1_0(v22, v133)
                let v135 : int8 = 23y
                method14(v134, v135)
        | _ ->
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v138 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v139 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v139
            #else
            let v140 : string = "1"
            let v141 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v141
            #endif
            #else
            let v142 : uint8 = System.Random().Next (1, 7) |> uint8
            v142
            #endif
            |> fun x -> result <- Some x
            let v143 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v144 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v144
            #else
            let v145 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v145
            #endif
            #else
            let v146 : uint8 = System.Random().Next (1, 7) |> uint8
            v146
            #endif
            |> fun x -> result <- Some x
            let v147 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v148 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v148
            #else
            let v149 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v149
            #endif
            #else
            let v150 : uint8 = System.Random().Next (1, 7) |> uint8
            v150
            #endif
            |> fun x -> result <- Some x
            let v151 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v152 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v152
            #else
            let v153 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v153
            #endif
            #else
            let v154 : uint8 = System.Random().Next (1, 7) |> uint8
            v154
            #endif
            |> fun x -> result <- Some x
            let v155 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v156 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v156
            #else
            let v157 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v157
            #endif
            #else
            let v158 : uint8 = System.Random().Next (1, 7) |> uint8
            v158
            #endif
            |> fun x -> result <- Some x
            let v159 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v160 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v160
            #else
            let v161 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v161
            #endif
            #else
            let v162 : uint8 = System.Random().Next (1, 7) |> uint8
            v162
            #endif
            |> fun x -> result <- Some x
            let v163 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v164 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v164
            #else
            let v165 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v165
            #endif
            #else
            let v166 : uint8 = System.Random().Next (1, 7) |> uint8
            v166
            #endif
            |> fun x -> result <- Some x
            let v167 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v168 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v168
            #else
            let v169 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v169
            #endif
            #else
            let v170 : uint8 = System.Random().Next (1, 7) |> uint8
            v170
            #endif
            |> fun x -> result <- Some x
            let v171 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v172 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v172
            #else
            let v173 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v173
            #endif
            #else
            let v174 : uint8 = System.Random().Next (1, 7) |> uint8
            v174
            #endif
            |> fun x -> result <- Some x
            let v175 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v176 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v176
            #else
            let v177 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v177
            #endif
            #else
            let v178 : uint8 = System.Random().Next (1, 7) |> uint8
            v178
            #endif
            |> fun x -> result <- Some x
            let v179 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v180 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v180
            #else
            let v181 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v181
            #endif
            #else
            let v182 : uint8 = System.Random().Next (1, 7) |> uint8
            v182
            #endif
            |> fun x -> result <- Some x
            let v183 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v184 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v184
            #else
            let v185 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v185
            #endif
            #else
            let v186 : uint8 = System.Random().Next (1, 7) |> uint8
            v186
            #endif
            |> fun x -> result <- Some x
            let v187 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v188 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v188
            #else
            let v189 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v189
            #endif
            #else
            let v190 : uint8 = System.Random().Next (1, 7) |> uint8
            v190
            #endif
            |> fun x -> result <- Some x
            let v191 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v192 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v192
            #else
            let v193 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v193
            #endif
            #else
            let v194 : uint8 = System.Random().Next (1, 7) |> uint8
            v194
            #endif
            |> fun x -> result <- Some x
            let v195 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v196 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v196
            #else
            let v197 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v197
            #endif
            #else
            let v198 : uint8 = System.Random().Next (1, 7) |> uint8
            v198
            #endif
            |> fun x -> result <- Some x
            let v199 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v200 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v200
            #else
            let v201 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v201
            #endif
            #else
            let v202 : uint8 = System.Random().Next (1, 7) |> uint8
            v202
            #endif
            |> fun x -> result <- Some x
            let v203 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v204 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v204
            #else
            let v205 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v205
            #endif
            #else
            let v206 : uint8 = System.Random().Next (1, 7) |> uint8
            v206
            #endif
            |> fun x -> result <- Some x
            let v207 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v208 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v208
            #else
            let v209 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v209
            #endif
            #else
            let v210 : uint8 = System.Random().Next (1, 7) |> uint8
            v210
            #endif
            |> fun x -> result <- Some x
            let v211 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v212 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v212
            #else
            let v213 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v213
            #endif
            #else
            let v214 : uint8 = System.Random().Next (1, 7) |> uint8
            v214
            #endif
            |> fun x -> result <- Some x
            let v215 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v216 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v216
            #else
            let v217 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v217
            #endif
            #else
            let v218 : uint8 = System.Random().Next (1, 7) |> uint8
            v218
            #endif
            |> fun x -> result <- Some x
            let v219 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v220 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v220
            #else
            let v221 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v221
            #endif
            #else
            let v222 : uint8 = System.Random().Next (1, 7) |> uint8
            v222
            #endif
            |> fun x -> result <- Some x
            let v223 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v224 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v224
            #else
            let v225 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v225
            #endif
            #else
            let v226 : uint8 = System.Random().Next (1, 7) |> uint8
            v226
            #endif
            |> fun x -> result <- Some x
            let v227 : uint8 = result |> Option.get
            let mutable result = None
            #if FABLE_COMPILER_RUST
            #if !WASM
            let v228 : uint8 = Fable.Core.RustInterop.emitRustExpr () v138
            v228
            #else
            let v229 : uint8 = Fable.Core.RustInterop.emitRustExpr () v140
            v229
            #endif
            #else
            let v230 : uint8 = System.Random().Next (1, 7) |> uint8
            v230
            #endif
            |> fun x -> result <- Some x
            let v231 : uint8 = result |> Option.get
            let v232 : UH1 = UH1_1
            let v233 : UH1 = UH1_0(v231, v232)
            let v234 : UH1 = UH1_0(v227, v233)
            let v235 : UH1 = UH1_0(v223, v234)
            let v236 : UH1 = UH1_0(v219, v235)
            let v237 : UH1 = UH1_0(v215, v236)
            let v238 : UH1 = UH1_0(v211, v237)
            let v239 : UH1 = UH1_0(v207, v238)
            let v240 : UH1 = UH1_0(v203, v239)
            let v241 : UH1 = UH1_0(v199, v240)
            let v242 : UH1 = UH1_0(v195, v241)
            let v243 : UH1 = UH1_0(v191, v242)
            let v244 : UH1 = UH1_0(v187, v243)
            let v245 : UH1 = UH1_0(v183, v244)
            let v246 : UH1 = UH1_0(v179, v245)
            let v247 : UH1 = UH1_0(v175, v246)
            let v248 : UH1 = UH1_0(v171, v247)
            let v249 : UH1 = UH1_0(v167, v248)
            let v250 : UH1 = UH1_0(v163, v249)
            let v251 : UH1 = UH1_0(v159, v250)
            let v252 : UH1 = UH1_0(v155, v251)
            let v253 : UH1 = UH1_0(v151, v252)
            let v254 : UH1 = UH1_0(v147, v253)
            let v255 : UH1 = UH1_0(v143, v254)
            let v256 : int8 = 23y
            method14(v255, v256)
and closure81 () (v0 : (string [])) : int32 =
    let v1 : string = $"calculate_dice_count / max: {9223372036854775807L} / n: {24y} / p: {4738381338321616896L}"
    System.Console.WriteLine v1
    let v2 : UH1 = UH1_1
    let v3 : int8 = 0y
    let v4 : int64 = method14(v2, v3)
    let v5 : string = $"result: {v4}"
    System.Console.WriteLine v5
    0
let v0 : (int64 -> (UH0 -> UH0)) = closure0()
let rotate_numbers x = v0 x
let v1 : ((string -> unit) option -> (UH1 -> (unit -> uint8))) = closure3()
let create_sequential_roller x = v1 x
let v2 : ((string -> unit) option -> ((unit -> uint8) -> (bool -> (uint64 -> uint64)))) = closure10()
let roll_progressively x = v2 x
let v3 : ((string -> unit) option -> (uint64 -> (UH1 -> uint64 option))) = closure78()
let roll_within_bounds x = v3 x
let v4 : ((string []) -> int32) = closure81()
let main args = v4 args
()
