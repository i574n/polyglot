type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1 of f1_0 : US0
let rec closure0 () () : string =
    let v0 : string option = None
    let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM
    let v1 : US0 = US0_0
    let v2 : US1 = US1_0(v1)
    let v3 : string = $"create_temp_directory_name / target: {v2}"
    let v4 : string = failwith<string> v3
    v4
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : US0 = US0_1
    let v6 : US1 = US1_0(v5)
    let v7 : string = $"create_temp_directory_name / target: {v6}"
    let v8 : string = failwith<string> v7
    v8
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v9 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    let v10 : (unit -> string) = System.IO.Path.GetTempPath
    let v11 : string = v10 ()
    let v12 : string = $"!{v9}"
    let v13 : string option = None
    let mutable _v13 = v13
    #if FABLE_COMPILER_RUST && !WASM
    let v14 : US0 = US0_0
    let v15 : US1 = US1_0(v14)
    let v16 : string = $"(</>) / target: {v15}"
    let v17 : string = failwith<string> v16
    v17
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v18 : US0 = US0_1
    let v19 : US1 = US1_0(v18)
    let v20 : string = $"(</>) / target: {v19}"
    let v21 : string = failwith<string> v20
    v21
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v22 : string = System.IO.Path.Combine (v11, v12)
    v22
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v23 : US0 = US0_2
    let v24 : US1 = US1_1(v23)
    let v25 : string = $"(</>) / target: {v24}"
    let v26 : string = failwith<string> v25
    v26
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v27 : US0 = US0_1
    let v28 : US1 = US1_1(v27)
    let v29 : string = $"(</>) / target: {v28}"
    let v30 : string = failwith<string> v29
    v30
    #endif
    |> fun x -> _v13 <- Some x
    let v31 : string = _v13 |> Option.get
    let v32 : System.DateTime = System.DateTime.Now
    let v33 : System.Guid = System.Guid.NewGuid ()
    let v34 : (System.Guid -> string) = _.ToString()
    let v35 : string = v34 v33
    let v36 : string = v32.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v37 : System.Guid = System.Guid $"{v36}{v35.[v36.Length..]}"
    let v38 : (System.Guid -> string) = _.ToString()
    let v39 : string = v38 v37
    let v40 : string option = None
    let mutable _v40 = v40
    #if FABLE_COMPILER_RUST && !WASM
    let v41 : US0 = US0_0
    let v42 : US1 = US1_0(v41)
    let v43 : string = $"(</>) / target: {v42}"
    let v44 : string = failwith<string> v43
    v44
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v45 : US0 = US0_1
    let v46 : US1 = US1_0(v45)
    let v47 : string = $"(</>) / target: {v46}"
    let v48 : string = failwith<string> v47
    v48
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v49 : string = System.IO.Path.Combine (v31, v39)
    v49
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v50 : US0 = US0_2
    let v51 : US1 = US1_1(v50)
    let v52 : string = $"(</>) / target: {v51}"
    let v53 : string = failwith<string> v52
    v53
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v54 : US0 = US0_1
    let v55 : US1 = US1_1(v54)
    let v56 : string = $"(</>) / target: {v55}"
    let v57 : string = failwith<string> v56
    v57
    #endif
    |> fun x -> _v40 <- Some x
    let v58 : string = _v40 |> Option.get
    v58
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v59 : US0 = US0_2
    let v60 : US1 = US1_1(v59)
    let v61 : string = $"create_temp_directory_name / target: {v60}"
    let v62 : string = failwith<string> v61
    v62
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v63 : US0 = US0_1
    let v64 : US1 = US1_1(v63)
    let v65 : string = $"create_temp_directory_name / target: {v64}"
    let v66 : string = failwith<string> v65
    v66
    #endif
    |> fun x -> _v0 <- Some x
    let v67 : string = _v0 |> Option.get
    v67
and closure3 () () : string =
    let v0 : string = ""
    v0
and closure2 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure3()
    let v3 : string = $"temp_folder: {v0} / result: {v1} {v2 ()}"
    v3
and closure1 () () : string =
    let v0 : string option = None
    let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM
    let v1 : US0 = US0_0
    let v2 : US1 = US1_0(v1)
    let v3 : string = $"create_temp_directory / target: {v2}"
    let v4 : string = failwith<string> v3
    v4
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : US0 = US0_1
    let v6 : US1 = US1_0(v5)
    let v7 : string = $"create_temp_directory / target: {v6}"
    let v8 : string = failwith<string> v7
    v8
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v9 : string option = None
    let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM
    let v10 : US0 = US0_0
    let v11 : US1 = US1_0(v10)
    let v12 : string = $"create_temp_directory_name / target: {v11}"
    let v13 : string = failwith<string> v12
    v13
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v14 : US0 = US0_1
    let v15 : US1 = US1_0(v14)
    let v16 : string = $"create_temp_directory_name / target: {v15}"
    let v17 : string = failwith<string> v16
    v17
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v18 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    let v19 : (unit -> string) = System.IO.Path.GetTempPath
    let v20 : string = v19 ()
    let v21 : string = $"!{v18}"
    let v22 : string option = None
    let mutable _v22 = v22
    #if FABLE_COMPILER_RUST && !WASM
    let v23 : US0 = US0_0
    let v24 : US1 = US1_0(v23)
    let v25 : string = $"(</>) / target: {v24}"
    let v26 : string = failwith<string> v25
    v26
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v27 : US0 = US0_1
    let v28 : US1 = US1_0(v27)
    let v29 : string = $"(</>) / target: {v28}"
    let v30 : string = failwith<string> v29
    v30
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v31 : string = System.IO.Path.Combine (v20, v21)
    v31
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v32 : US0 = US0_2
    let v33 : US1 = US1_1(v32)
    let v34 : string = $"(</>) / target: {v33}"
    let v35 : string = failwith<string> v34
    v35
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v36 : US0 = US0_1
    let v37 : US1 = US1_1(v36)
    let v38 : string = $"(</>) / target: {v37}"
    let v39 : string = failwith<string> v38
    v39
    #endif
    |> fun x -> _v22 <- Some x
    let v40 : string = _v22 |> Option.get
    let v41 : System.DateTime = System.DateTime.Now
    let v42 : System.Guid = System.Guid.NewGuid ()
    let v43 : (System.Guid -> string) = _.ToString()
    let v44 : string = v43 v42
    let v45 : string = v41.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v46 : System.Guid = System.Guid $"{v45}{v44.[v45.Length..]}"
    let v47 : (System.Guid -> string) = _.ToString()
    let v48 : string = v47 v46
    let v49 : string option = None
    let mutable _v49 = v49
    #if FABLE_COMPILER_RUST && !WASM
    let v50 : US0 = US0_0
    let v51 : US1 = US1_0(v50)
    let v52 : string = $"(</>) / target: {v51}"
    let v53 : string = failwith<string> v52
    v53
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v54 : US0 = US0_1
    let v55 : US1 = US1_0(v54)
    let v56 : string = $"(</>) / target: {v55}"
    let v57 : string = failwith<string> v56
    v57
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v58 : string = System.IO.Path.Combine (v40, v48)
    v58
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v59 : US0 = US0_2
    let v60 : US1 = US1_1(v59)
    let v61 : string = $"(</>) / target: {v60}"
    let v62 : string = failwith<string> v61
    v62
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v63 : US0 = US0_1
    let v64 : US1 = US1_1(v63)
    let v65 : string = $"(</>) / target: {v64}"
    let v66 : string = failwith<string> v65
    v66
    #endif
    |> fun x -> _v49 <- Some x
    let v67 : string = _v49 |> Option.get
    v67
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v68 : US0 = US0_2
    let v69 : US1 = US1_1(v68)
    let v70 : string = $"create_temp_directory_name / target: {v69}"
    let v71 : string = failwith<string> v70
    v71
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v72 : US0 = US0_1
    let v73 : US1 = US1_1(v72)
    let v74 : string = $"create_temp_directory_name / target: {v73}"
    let v75 : string = failwith<string> v74
    v75
    #endif
    |> fun x -> _v9 <- Some x
    let v76 : string = _v9 |> Option.get
    let v77 : System.IO.DirectoryInfo option = None
    let mutable _v77 = v77
    #if FABLE_COMPILER_RUST && !WASM
    let v78 : US0 = US0_0
    let v79 : US1 = US1_0(v78)
    let v80 : string = $"create_directory / target: {v79}"
    let v81 : System.IO.DirectoryInfo = failwith<System.IO.DirectoryInfo> v80
    v81
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v82 : US0 = US0_1
    let v83 : US1 = US1_0(v82)
    let v84 : string = $"create_directory / target: {v83}"
    let v85 : System.IO.DirectoryInfo = failwith<System.IO.DirectoryInfo> v84
    v85
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v86 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v87 : System.IO.DirectoryInfo = v86 v76
    v87
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v88 : US0 = US0_2
    let v89 : US1 = US1_1(v88)
    let v90 : string = $"create_directory / target: {v89}"
    let v91 : System.IO.DirectoryInfo = failwith<System.IO.DirectoryInfo> v90
    v91
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v92 : US0 = US0_1
    let v93 : US1 = US1_1(v92)
    let v94 : string = $"create_directory / target: {v93}"
    let v95 : System.IO.DirectoryInfo = failwith<System.IO.DirectoryInfo> v94
    v95
    #endif
    |> fun x -> _v77 <- Some x
    let v96 : System.IO.DirectoryInfo = _v77 |> Option.get
    let v97 : bool option = None
    let mutable _v97 = v97
    #if FABLE_COMPILER_RUST && !WASM
    let v98 : US0 = US0_0
    let v99 : US1 = US1_0(v98)
    let v100 : string = $"directory_info_exists / target: {v99}"
    let v101 : bool = failwith<bool> v100
    v101
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v102 : US0 = US0_1
    let v103 : US1 = US1_0(v102)
    let v104 : string = $"directory_info_exists / target: {v103}"
    let v105 : bool = failwith<bool> v104
    v105
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v106 : bool = v96.Exists
    v106
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v107 : US0 = US0_2
    let v108 : US1 = US1_1(v107)
    let v109 : string = $"directory_info_exists / target: {v108}"
    let v110 : bool = failwith<bool> v109
    v110
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v111 : US0 = US0_1
    let v112 : US1 = US1_1(v111)
    let v113 : string = $"directory_info_exists / target: {v112}"
    let v114 : bool = failwith<bool> v113
    v114
    #endif
    |> fun x -> _v97 <- Some x
    let v115 : bool = _v97 |> Option.get
    let v116 : bool = v115 = false
    if v116 then
        let v117 : System.DateTime option = None
        let mutable _v117 = v117
        #if FABLE_COMPILER_RUST && !WASM
        let v118 : US0 = US0_0
        let v119 : US1 = US1_0(v118)
        let v120 : string = $"directory_info_creation_time / target: {v119}"
        let v121 : System.DateTime = failwith<System.DateTime> v120
        v121
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v122 : US0 = US0_1
        let v123 : US1 = US1_0(v122)
        let v124 : string = $"directory_info_creation_time / target: {v123}"
        let v125 : System.DateTime = failwith<System.DateTime> v124
        v125
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
        let v126 : System.DateTime = v96.CreationTime
        v126
        #endif
        #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
        let v127 : US0 = US0_2
        let v128 : US1 = US1_1(v127)
        let v129 : string = $"directory_info_creation_time / target: {v128}"
        let v130 : System.DateTime = failwith<System.DateTime> v129
        v130
        #endif
        #if !FABLE_COMPILER_RUST && WASM
        let v131 : US0 = US0_1
        let v132 : US1 = US1_1(v131)
        let v133 : string = $"directory_info_creation_time / target: {v132}"
        let v134 : System.DateTime = failwith<System.DateTime> v133
        v134
        #endif
        |> fun x -> _v117 <- Some x
        let v135 : System.DateTime = _v117 |> Option.get
        let v136 : obj = {| Exists = v115; CreationTime = v135 |}
        let v137 : string = $"%A{v136}"
        let v138 : (unit -> string) = closure2(v76, v137)
        let v139 : string = $"create_temp_directory / {v138 ()}"
        System.Console.WriteLine v139
        ()
    v76
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v140 : US0 = US0_2
    let v141 : US1 = US1_1(v140)
    let v142 : string = $"create_temp_directory / target: {v141}"
    let v143 : string = failwith<string> v142
    v143
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v144 : US0 = US0_1
    let v145 : US1 = US1_1(v144)
    let v146 : string = $"create_temp_directory / target: {v145}"
    let v147 : string = failwith<string> v146
    v147
    #endif
    |> fun x -> _v0 <- Some x
    let v148 : string = _v0 |> Option.get
    v148
and closure5 (v0 : string) (v1 : string) : string =
    let v2 : string option = None
    let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM
    let v3 : US0 = US0_0
    let v4 : US1 = US1_0(v3)
    let v5 : string = $"(</>) / target: {v4}"
    let v6 : string = failwith<string> v5
    v6
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v7 : US0 = US0_1
    let v8 : US1 = US1_0(v7)
    let v9 : string = $"(</>) / target: {v8}"
    let v10 : string = failwith<string> v9
    v10
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v11 : string = System.IO.Path.Combine (v0, v1)
    v11
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v12 : US0 = US0_2
    let v13 : US1 = US1_1(v12)
    let v14 : string = $"(</>) / target: {v13}"
    let v15 : string = failwith<string> v14
    v15
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v16 : US0 = US0_1
    let v17 : US1 = US1_1(v16)
    let v18 : string = $"(</>) / target: {v17}"
    let v19 : string = failwith<string> v18
    v19
    #endif
    |> fun x -> _v2 <- Some x
    let v20 : string = _v2 |> Option.get
    v20
and closure4 () (v0 : string) : (string -> string) =
    closure5(v0)
let v0 : (unit -> string) = closure0()
let create_temp_directory_name () = v0 ()
let v1 : (unit -> string) = closure1()
let create_temp_directory () = v1 ()
let v2 : (string -> (string -> string)) = closure4()
let (</>) x = v2 x
()
