type UH0 =
    | UH0_0 of uint64 * (unit -> UH0)
    | UH0_1
and UH1 =
    | UH1_0 of uint64 * UH1
    | UH1_1
and [<Struct>] US0 =
    | US0_0 of f0_0 : UH0
    | US0_1 of f1_0 : (unit -> UH0)
and Mut0 = {mutable l0 : US0}
and Mut1 = {mutable l0 : int32}
and [<Struct>] US1 =
    | US1_0
    | US1_1 of f1_0 : uint64
and [<Struct>] US2 =
    | US2_0
    | US2_1 of f1_0 : (string -> unit)
and [<Struct>] US3 =
    | US3_0
    | US3_1 of f1_0 : uint64 * f1_1 : UH1
let rec closure2 (v0 : UH0) () : UH0 =
    v0
and method1 (v0 : uint64, v1 : UH0, v2 : UH0) : UH0 =
    match v1 with
    | UH0_0(v3, v4) -> (* StreamCons *)
        let v5 : UH0 = v4 ()
        let v6 : UH0 = method1(v0, v5, v2)
        let v7 : uint64 = v3 - 1UL
        let v8 : uint64 = v7 + v0
        let v9 : uint64 = v8 % v0
        let v10 : uint64 = v9 + 1UL
        let v11 : (unit -> UH0) = closure2(v6)
        UH0_0(v10, v11)
    | UH0_1 -> (* StreamNil *)
        v2
and closure1 (v0 : uint64) (v1 : UH0) : UH0 =
    let v2 : UH0 = UH0_1
    method1(v0, v1, v2)
and closure0 () (v0 : uint64) : (UH0 -> UH0) =
    closure1(v0)
and method2 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : UH1 = UH1_0(v2, v1)
        method2(v3, v4)
    | UH1_1 -> (* Nil *)
        v1
and method3 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : UH1 = method3(v3, v1)
        UH1_0(v2, v4)
    | UH1_1 -> (* Nil *)
        v1
and closure4 (v0 : UH0) () : UH0 =
    v0
and method4 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : UH0 = method4(v3, v1)
        let v5 : (unit -> UH0) = closure4(v4)
        UH0_0(v2, v5)
    | UH1_1 -> (* Nil *)
        v1
and closure5 (v0 : UH0) () : UH0 =
    v0
and closure6 (v0 : UH0, v1 : Mut0) () : UH0 =
    let v2 : US0 = v1.l0
    match v2 with
    | US0_0(v3) -> (* Computed *)
        v3
    | US0_1(v4) -> (* NotComputed *)
        let v5 : UH0 = v4 ()
        let v12 : UH0 =
            match v5 with
            | UH0_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH0) = method5(v0, v8)
                UH0_0(v7, v9)
            | UH0_1 -> (* StreamNil *)
                UH0_1
        let v13 : US0 = US0_0(v12)
        v1.l0 <- v13
        v12
and method5 (v0 : UH0, v1 : (unit -> UH0)) : (unit -> UH0) =
    let v2 : US0 = US0_1(v1)
    let v3 : Mut0 = {l0 = v2} : Mut0
    closure6(v0, v3)
and method7 (v0 : int32, v1 : UH0) : US1 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0
        if v4 then
            US1_1(v2)
        else
            let v6 : int32 = v0 - 1
            let v7 : UH0 = v3 ()
            method7(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US1_0
and method6 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1) : uint64 =
    let v4 : UH0 = v0 ()
    let v5 : int32 = v1.l0
    let v6 : US1 = method7(v5, v4)
    match v6 with
    | US1_0 -> (* None *)
        let v10 : int32 = v3.l0
        let v11 : bool = v10 = -1
        if v11 then
            let v12 : int32 = v1.l0
            v3.l0 <- v12
            ()
        let v13 : int32 = v2.l0
        let v14 : int32 = v3.l0
        let v15 : bool = v13 >= v14
        let v18 : int32 =
            if v15 then
                1
            else
                let v16 : int32 = v2.l0
                let v17 : int32 = v16 + 1
                v17
        v2.l0 <- v18
        let v19 : int32 = v2.l0
        let v20 : int32 = v19 - 1
        v1.l0 <- v20
        method6(v0, v1, v2, v3)
    | US1_1(v7) -> (* Some *)
        let v8 : int32 = v1.l0
        let v9 : int32 = v8 + 1
        v1.l0 <- v9
        v7
and closure7 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1) () : uint64 =
    method6(v0, v1, v2, v3)
and closure3 () (v0 : UH1) : (unit -> uint64) =
    let v1 : UH1 = UH1_1
    let v2 : UH1 = method2(v0, v1)
    let v3 : UH1 = method3(v0, v2)
    let v4 : UH0 = UH0_1
    let v5 : UH0 = method4(v3, v4)
    let v6 : (unit -> UH0) = closure5(v5)
    let v7 : (unit -> UH0) = method5(v5, v6)
    let v8 : Mut1 = {l0 = 0} : Mut1
    let v9 : Mut1 = {l0 = 1} : Mut1
    let v10 : Mut1 = {l0 = -1} : Mut1
    closure7(v7, v8, v9, v10)
and method8 (v0 : US2, v1 : uint64, v2 : int64, v3 : uint64) : int64 =
    let v4 : bool = v3 > 0UL
    let v6 : bool =
        if v4 then
            let v5 : bool = v3 < v1
            v5
        else
            false
    if v6 then
        let v7 : int64 = v2 + 1L
        let v8 : uint64 = v3 * 6UL
        method8(v0, v1, v7, v8)
    else
        let v10 : string = $"calculate_dice_count / max: {v1} / n: {v2} / p: {v3}"
        match v0 with
        | US2_0 -> (* None *)
            ()
        | US2_1(v11) -> (* Some *)
            v11 v10
        v2
and closure75 () () : UH0 =
    let v0 : (unit -> UH0) = closure75()
    UH0_0(0UL, v0)
and closure74 () () : UH0 =
    let v0 : (unit -> UH0) = closure75()
    UH0_0(9223372036854775808UL, v0)
and closure73 () () : UH0 =
    let v0 : (unit -> UH0) = closure74()
    UH0_0(4611686018427387904UL, v0)
and closure72 () () : UH0 =
    let v0 : (unit -> UH0) = closure73()
    UH0_0(6917529027641081856UL, v0)
and closure71 () () : UH0 =
    let v0 : (unit -> UH0) = closure72()
    UH0_0(1152921504606846976UL, v0)
and closure70 () () : UH0 =
    let v0 : (unit -> UH0) = closure71()
    UH0_0(15564440312192434176UL, v0)
and closure69 () () : UH0 =
    let v0 : (unit -> UH0) = closure70()
    UH0_0(11817445422220181504UL, v0)
and closure68 () () : UH0 =
    let v0 : (unit -> UH0) = closure69()
    UH0_0(5044031582654955520UL, v0)
and closure67 () () : UH0 =
    let v0 : (unit -> UH0) = closure68()
    UH0_0(6989586621679009792UL, v0)
and closure66 () () : UH0 =
    let v0 : (unit -> UH0) = closure67()
    UH0_0(16537217831704461312UL, v0)
and closure65 () () : UH0 =
    let v0 : (unit -> UH0) = closure66()
    UH0_0(11979575008805519360UL, v0)
and closure64 () () : UH0 =
    let v0 : (unit -> UH0) = closure65()
    UH0_0(14294425217273954304UL, v0)
and closure63 () () : UH0 =
    let v0 : (unit -> UH0) = closure64()
    UH0_0(2382404202878992384UL, v0)
and closure62 () () : UH0 =
    let v0 : (unit -> UH0) = closure63()
    UH0_0(6545982058383015936UL, v0)
and closure61 () () : UH0 =
    let v0 : (unit -> UH0) = closure62()
    UH0_0(10314369046585278464UL, v0)
and closure60 () () : UH0 =
    let v0 : (unit -> UH0) = closure61()
    UH0_0(4793518853382471680UL, v0)
and closure59 () () : UH0 =
    let v0 : (unit -> UH0) = closure60()
    UH0_0(3873377154515337216UL, v0)
and closure58 () () : UH0 =
    let v0 : (unit -> UH0) = closure59()
    UH0_0(645562859085889536UL, v0)
and closure57 () () : UH0 =
    let v0 : (unit -> UH0) = closure58()
    UH0_0(107593809847648256UL, v0)
and closure56 () () : UH0 =
    let v0 : (unit -> UH0) = closure57()
    UH0_0(3092389647259533312UL, v0)
and closure55 () () : UH0 =
    let v0 : (unit -> UH0) = closure56()
    UH0_0(9738770311398031360UL, v0)
and closure54 () () : UH0 =
    let v0 : (unit -> UH0) = closure55()
    UH0_0(16995415113324298240UL, v0)
and closure53 () () : UH0 =
    let v0 : (unit -> UH0) = closure54()
    UH0_0(8981483876790566912UL, v0)
and closure52 () () : UH0 =
    let v0 : (unit -> UH0) = closure53()
    UH0_0(13794743361938128896UL, v0)
and closure51 () () : UH0 =
    let v0 : (unit -> UH0) = closure52()
    UH0_0(2299123893656354816UL, v0)
and closure50 () () : UH0 =
    let v0 : (unit -> UH0) = closure51()
    UH0_0(3457644661227651072UL, v0)
and closure49 () () : UH0 =
    let v0 : (unit -> UH0) = closure50()
    UH0_0(576274110204608512UL, v0)
and closure48 () () : UH0 =
    let v0 : (unit -> UH0) = closure49()
    UH0_0(6244960376270618624UL, v0)
and closure47 () () : UH0 =
    let v0 : (unit -> UH0) = closure48()
    UH0_0(13338656111851470848UL, v0)
and closure46 () () : UH0 =
    let v0 : (unit -> UH0) = closure47()
    UH0_0(14520938734448279552UL, v0)
and closure45 () () : UH0 =
    let v0 : (unit -> UH0) = closure46()
    UH0_0(14717985838214414336UL, v0)
and closure44 () () : UH0 =
    let v0 : (unit -> UH0) = closure45()
    UH0_0(5527454985320660992UL, v0)
and closure43 () () : UH0 =
    let v0 : (unit -> UH0) = closure44()
    UH0_0(16293529225644736512UL, v0)
and closure42 () () : UH0 =
    let v0 : (unit -> UH0) = closure43()
    UH0_0(11938960241128898560UL, v0)
and closure41 () () : UH0 =
    let v0 : (unit -> UH0) = closure42()
    UH0_0(8138741398091333632UL, v0)
and closure40 () () : UH0 =
    let v0 : (unit -> UH0) = closure41()
    UH0_0(7505371590918406144UL, v0)
and closure39 () () : UH0 =
    let v0 : (unit -> UH0) = closure40()
    UH0_0(16623181993244360704UL, v0)
and closure38 () () : UH0 =
    let v0 : (unit -> UH0) = closure39()
    UH0_0(8919445023443910656UL, v0)
and closure37 () () : UH0 =
    let v0 : (unit -> UH0) = closure38()
    UH0_0(4561031516192243712UL, v0)
and closure36 () () : UH0 =
    let v0 : (unit -> UH0) = closure37()
    UH0_0(9983543956220149760UL, v0)
and closure35 () () : UH0 =
    let v0 : (unit -> UH0) = closure36()
    UH0_0(4738381338321616896UL, v0)
and closure34 () () : UH0 =
    let v0 : (unit -> UH0) = closure35()
    UH0_0(789730223053602816UL, v0)
and closure33 () () : UH0 =
    let v0 : (unit -> UH0) = closure34()
    UH0_0(131621703842267136UL, v0)
and closure32 () () : UH0 =
    let v0 : (unit -> UH0) = closure33()
    UH0_0(21936950640377856UL, v0)
and closure31 () () : UH0 =
    let v0 : (unit -> UH0) = closure32()
    UH0_0(3656158440062976UL, v0)
and closure30 () () : UH0 =
    let v0 : (unit -> UH0) = closure31()
    UH0_0(609359740010496UL, v0)
and closure29 () () : UH0 =
    let v0 : (unit -> UH0) = closure30()
    UH0_0(101559956668416UL, v0)
and closure28 () () : UH0 =
    let v0 : (unit -> UH0) = closure29()
    UH0_0(16926659444736UL, v0)
and closure27 () () : UH0 =
    let v0 : (unit -> UH0) = closure28()
    UH0_0(2821109907456UL, v0)
and closure26 () () : UH0 =
    let v0 : (unit -> UH0) = closure27()
    UH0_0(470184984576UL, v0)
and closure25 () () : UH0 =
    let v0 : (unit -> UH0) = closure26()
    UH0_0(78364164096UL, v0)
and closure24 () () : UH0 =
    let v0 : (unit -> UH0) = closure25()
    UH0_0(13060694016UL, v0)
and closure23 () () : UH0 =
    let v0 : (unit -> UH0) = closure24()
    UH0_0(2176782336UL, v0)
and closure22 () () : UH0 =
    let v0 : (unit -> UH0) = closure23()
    UH0_0(362797056UL, v0)
and closure21 () () : UH0 =
    let v0 : (unit -> UH0) = closure22()
    UH0_0(60466176UL, v0)
and closure20 () () : UH0 =
    let v0 : (unit -> UH0) = closure21()
    UH0_0(10077696UL, v0)
and closure19 () () : UH0 =
    let v0 : (unit -> UH0) = closure20()
    UH0_0(1679616UL, v0)
and closure18 () () : UH0 =
    let v0 : (unit -> UH0) = closure19()
    UH0_0(279936UL, v0)
and closure17 () () : UH0 =
    let v0 : (unit -> UH0) = closure18()
    UH0_0(46656UL, v0)
and closure16 () () : UH0 =
    let v0 : (unit -> UH0) = closure17()
    UH0_0(7776UL, v0)
and closure15 () () : UH0 =
    let v0 : (unit -> UH0) = closure16()
    UH0_0(1296UL, v0)
and closure14 () () : UH0 =
    let v0 : (unit -> UH0) = closure15()
    UH0_0(216UL, v0)
and closure13 () () : UH0 =
    let v0 : (unit -> UH0) = closure14()
    UH0_0(36UL, v0)
and closure12 () () : UH0 =
    let v0 : (unit -> UH0) = closure13()
    UH0_0(6UL, v0)
and method11 (v0 : int64, v1 : UH0) : US1 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US1_1(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method11(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US1_0
and method10 (v0 : US2, v1 : int64, v2 : UH1, v3 : uint64) : US3 =
    let v4 : bool = v1 < 0L
    if v4 then
        let v5 : string = $"accumulate_dice_rolls / power: {v1} / acc: {v3}"
        match v0 with
        | US2_0 -> (* None *)
            ()
        | US2_1(v6) -> (* Some *)
            v6 v5
        let v7 : uint64 = v3 + 1UL
        US3_1(v7, v2)
    else
        match v2 with
        | UH1_0(v10, v11) -> (* Cons *)
            let v12 : bool = v10 > 1UL
            if v12 then
                let v13 : uint64 = 1UL
                let v14 : (unit -> UH0) = closure12()
                let v15 : UH0 = UH0_0(v13, v14)
                let v16 : US1 = method11(v1, v15)
                let v20 : uint64 =
                    match v16 with
                    | US1_0 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US1_1(v17) -> (* Some *)
                        v17
                let v21 : uint64 = v10 - 1UL
                let v22 : uint64 = v21 * v20
                let v23 : string = $"accumulate_dice_rolls / power: {v1} / acc: {v3} / roll: {v10} / value: {v22}"
                match v0 with
                | US2_0 -> (* None *)
                    ()
                | US2_1(v24) -> (* Some *)
                    v24 v23
                let v25 : uint64 = v3 + v22
                let v26 : int64 = v1 - 1L
                method10(v0, v26, v11, v25)
            else
                let v28 : string = $"accumulate_dice_rolls / power: {v1} / acc: {v3} / roll: {v10}"
                match v0 with
                | US2_0 -> (* None *)
                    ()
                | US2_1(v29) -> (* Some *)
                    v29 v28
                let v30 : int64 = v1 - 1L
                method10(v0, v30, v11, v3)
        | UH1_1 -> (* Nil *)
            US3_0
and method12 (v0 : int64, v1 : (unit -> uint64), v2 : int64) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v1 ()
        let v5 : int64 = v2 + 1L
        let v6 : UH1 = method12(v0, v1, v5)
        UH1_0(v4, v6)
    else
        UH1_1
and method13 (v0 : US2, v1 : (unit -> uint64), v2 : bool, v3 : uint64, v4 : int64, v5 : UH1) : uint64 =
    let v6 : int64 = v4 + 1L
    let v7 : bool = v4 < v6
    if v7 then
        let v8 : uint64 = v1 ()
        let v9 : UH1 = UH1_0(v8, v5)
        method9(v0, v1, v2, v3, v4, v9, v6)
    else
        let v11 : uint64 = 0UL
        let v12 : US3 = method10(v0, v4, v5, v11)
        match v12 with
        | US3_1(v13, v14) -> (* Some *)
            let v15 : bool = v13 <= v3
            if v15 then
                v13
            else
                if v2 then
                    let v16 : int64 = 0L
                    let v17 : UH1 = method12(v4, v1, v16)
                    method13(v0, v1, v2, v3, v4, v17)
                else
                    let v19 : uint64 = v1 ()
                    let v20 : UH1 = UH1_0(v19, v5)
                    method9(v0, v1, v2, v3, v4, v20, v6)
        | _ ->
            if v2 then
                let v24 : int64 = 0L
                let v25 : UH1 = method12(v4, v1, v24)
                method13(v0, v1, v2, v3, v4, v25)
            else
                let v27 : uint64 = v1 ()
                let v28 : UH1 = UH1_0(v27, v5)
                method9(v0, v1, v2, v3, v4, v28, v6)
and method9 (v0 : US2, v1 : (unit -> uint64), v2 : bool, v3 : uint64, v4 : int64, v5 : UH1, v6 : int64) : uint64 =
    let v7 : int64 = v4 + 1L
    let v8 : bool = v6 < v7
    if v8 then
        let v9 : uint64 = v1 ()
        let v10 : UH1 = UH1_0(v9, v5)
        let v11 : int64 = v6 + 1L
        method9(v0, v1, v2, v3, v4, v10, v11)
    else
        let v13 : uint64 = 0UL
        let v14 : US3 = method10(v0, v4, v5, v13)
        match v14 with
        | US3_1(v15, v16) -> (* Some *)
            let v17 : bool = v15 <= v3
            if v17 then
                v15
            else
                if v2 then
                    let v18 : int64 = 0L
                    let v19 : UH1 = method12(v4, v1, v18)
                    method13(v0, v1, v2, v3, v4, v19)
                else
                    let v21 : uint64 = v1 ()
                    let v22 : UH1 = UH1_0(v21, v5)
                    let v23 : int64 = v6 + 1L
                    method9(v0, v1, v2, v3, v4, v22, v23)
        | _ ->
            if v2 then
                let v27 : int64 = 0L
                let v28 : UH1 = method12(v4, v1, v27)
                method13(v0, v1, v2, v3, v4, v28)
            else
                let v30 : uint64 = v1 ()
                let v31 : UH1 = UH1_0(v30, v5)
                let v32 : int64 = v6 + 1L
                method9(v0, v1, v2, v3, v4, v31, v32)
and closure11 (v0 : US2, v1 : (unit -> uint64), v2 : bool) (v3 : uint64) : uint64 =
    let v4 : bool = v3 = 1UL
    let v8 : int64 =
        if v4 then
            1L
        else
            let v5 : int64 = 0L
            let v6 : uint64 = 1UL
            method8(v0, v3, v5, v6)
    let v9 : int64 = v8 - 1L
    let v10 : UH1 = UH1_1
    let v11 : int64 = 0L
    method9(v0, v1, v2, v3, v9, v10, v11)
and closure10 (v0 : US2, v1 : (unit -> uint64)) (v2 : bool) : (uint64 -> uint64) =
    closure11(v0, v1, v2)
and closure9 (v0 : US2) (v1 : (unit -> uint64)) : (bool -> (uint64 -> uint64)) =
    closure10(v0, v1)
and closure8 () (v0 : US2) : ((unit -> uint64) -> (bool -> (uint64 -> uint64))) =
    closure9(v0)
and method14 (v0 : UH1, v1 : int64) : int64 =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : int64 = v1 + 1L
        method14(v3, v4)
    | UH1_1 -> (* Nil *)
        v1
and closure78 (v0 : US2, v1 : uint64) (v2 : UH1) : US1 =
    let v3 : int64 = 0L
    let v4 : int64 = method14(v2, v3)
    let v5 : int64 = v4 - 1L
    let v6 : uint64 = 0UL
    let v7 : US3 = method10(v0, v5, v2, v6)
    match v7 with
    | US3_1(v8, v9) -> (* Some *)
        let v10 : bool = v8 >= 1UL
        let v12 : bool =
            if v10 then
                let v11 : bool = v8 <= v1
                v11
            else
                false
        if v12 then
            US1_1(v8)
        else
            US1_0
    | _ ->
        US1_0
and closure77 (v0 : US2) (v1 : uint64) : (UH1 -> US1) =
    closure78(v0, v1)
and closure76 () (v0 : US2) : (uint64 -> (UH1 -> US1)) =
    closure77(v0)
and method0 () : unit =
    let v0 : (uint64 -> (UH0 -> UH0)) = closure0()
    let v1 : (UH1 -> (unit -> uint64)) = closure3()
    let v2 : (US2 -> ((unit -> uint64) -> (bool -> (uint64 -> uint64)))) = closure8()
    let v3 : (US2 -> (uint64 -> (UH1 -> US1))) = closure76()
    ()
method0()
let main _args = 0
()
