let rec method0 () : struct (string * string * string * bool) =
    let v0 : string = ""
    let v1 : obj = v0
    struct (v0, v0, v0, true)
and method1 (v0 : string) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "($0).to_string()"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method2 (v0 : Types.rocket.http.uri.Segments<Types.rocket.http.uri.fmt.Path>) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "format!(\"{:?}\", $0)"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method4 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method4(v0, v4)
    else
        v1
and method5 (v0 : uint8) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "format!(\"{:?}\", $0)"
    let v2 : Types.std.string.String = Fable.Core.Rust.emitExpr v0 v1
    let v3 : Types.EmitType<Types.std.string.String> = v2 |> unbox<Types.EmitType<Types.std.string.String>>
    v3
and method6 (v0 : (Types.EmitType<Types.std.string.String> [])) : Types.EmitType<Types.std.string.String> =
    let v1 : string = "core::ops::Deref::deref($0)"
    let v2 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v0 v1
    let v3 : string = "&***$0"
    let v4 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v2 v3
    let v5 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v4 v3
    let v6 : string = "format!(\"{:?}\", $0)"
    let v7 : Types.std.string.String = Fable.Core.Rust.emitExpr v5 v6
    let v8 : Types.EmitType<Types.std.string.String> = v7 |> unbox<Types.EmitType<Types.std.string.String>>
    v8
and method7 (v0 : string) : string =
    v0
and method8 () : string =
    let v0 : string = "$1=$2"
    v0
and method9 () : string =
    let v0 : string = "[$1]"
    v0
and method10 () : string =
    let v0 : string = "\""
    v0
and method11 () : string =
    let v0 : string = " "
    v0
and method12 () : string =
    let v0 : string = "006666"
    v0
and method13 () : string =
    let v0 : string = "385779"
    v0
and method3 (v0 : int64, v1 : (Types.EmitType<Types.std.string.String> [])) : unit =
    let v2 : string = "chrono::Utc::now()"
    let v3 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v2
    let v4 : string = "($0).timestamp()"
    let v5 : int64 = Fable.Core.Rust.emitExpr v3 v4
    let v6 : int64 = v5 - v0
    let v7 : string = (v6).ToString ()
    let v8 : int32 = 6
    let v9 : string = method4(v8, v7)
    let v10 : string = "rand::random::<u8>()"
    let v11 : uint8 = Fable.Core.Rust.emitExpr () v10
    let v12 : string = "timestamp"
    let v13 : Types.EmitType<Types.std.string.String> = method1(v12)
    let v14 : Types.EmitType<Types.std.string.String> = method1(v9)
    let v15 : string = "run_id"
    let v16 : Types.EmitType<Types.std.string.String> = method1(v15)
    let v17 : Types.EmitType<Types.std.string.String> = method5(v11)
    let v18 : string = "log_level"
    let v19 : Types.EmitType<Types.std.string.String> = method1(v18)
    let v20 : string = "Debug"
    let v21 : Types.EmitType<Types.std.string.String> = method1(v20)
    let v22 : (Types.EmitType<Types.std.string.String> []) = [|v13; v14; v16; v17; v19; v21|]
    let v23 : Types.EmitType<Types.std.string.String> = method6(v22)
    let v24 : string = "> parseUrls ()"
    let v25 : Types.EmitType<Types.std.string.String> = method1(v24)
    let v26 : (Types.EmitType<Types.std.string.String> []) = [|v25|]
    let v27 : string = "core::ops::Deref::deref($0)"
    let v28 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v26 v27
    let v29 : string = "&***$0"
    let v30 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v28 v29
    let v31 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v30 v29
    let v32 : string = "format!(\"{:?}\", $0)"
    let v33 : Types.std.string.String = Fable.Core.Rust.emitExpr v31 v32
    let v34 : Types.EmitType<Types.std.string.String> = v33 |> unbox<Types.EmitType<Types.std.string.String>>
    let v35 : string = "format!(\"{}\", $0)"
    let v36 : Types.std.string.String = Fable.Core.Rust.emitExpr v34 v35
    let v37 : string = (v36).ToString ()
    let v38 : string = "\"([^\"]+)\", \"([^\"]+)\""
    let v39 : string = $"r#\"{v38}\"#"
    let v40 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v39
    let v41 : string = "regex::RegexBuilder::new($0)"
    let v42 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v40 v41
    let v43 : string = "$0.build().unwrap()"
    let v44 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v42 v43
    let v45 : string = method7(v37)
    let v46 : string = "$0.as_str()"
    let v47 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v45 v46
    let v48 : string = method8()
    let v49 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v48 v46
    let v50 : string = "$0.replace_all(&$1, $2).to_string()"
    let v51 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v44, v47, v49) v50
    let v52 : obj = v51
    let v53 : string = "fable_library_rust::String_::fromStr($0)"
    let v54 : string = Fable.Core.Rust.emitExpr v52 v53
    let v55 : string = "\\[\"(.*?)\"\\]"
    let v56 : string = $"r#\"{v55}\"#"
    let v57 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v56
    let v58 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v57 v41
    let v59 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v58 v43
    let v60 : string = method7(v54)
    let v61 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v60 v46
    let v62 : string = method9()
    let v63 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v62 v46
    let v64 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v59, v61, v63) v50
    let v65 : obj = v64
    let v66 : string = Fable.Core.Rust.emitExpr v65 v53
    let v67 : string = "\\\\\""
    let v68 : string = $"r#\"{v67}\"#"
    let v69 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v68
    let v70 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v69 v41
    let v71 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v70 v43
    let v72 : string = method7(v66)
    let v73 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v72 v46
    let v74 : string = method10()
    let v75 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v74 v46
    let v76 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v71, v73, v75) v50
    let v77 : obj = v76
    let v78 : string = Fable.Core.Rust.emitExpr v77 v53
    let v79 : string = ", "
    let v80 : string = $"r#\"{v79}\"#"
    let v81 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v80
    let v82 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v81 v41
    let v83 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v82 v43
    let v84 : string = method7(v78)
    let v85 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v84 v46
    let v86 : string = method11()
    let v87 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v86 v46
    let v88 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v83, v85, v87) v50
    let v89 : obj = v88
    let v90 : string = Fable.Core.Rust.emitExpr v89 v53
    let v91 : Types.EmitType<Types.std.string.String> = method1(v90)
    let v92 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v1 v27
    let v93 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v92 v29
    let v94 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v93 v29
    let v95 : Types.std.string.String = Fable.Core.Rust.emitExpr v94 v32
    let v96 : Types.EmitType<Types.std.string.String> = v95 |> unbox<Types.EmitType<Types.std.string.String>>
    let v97 : Types.std.string.String = Fable.Core.Rust.emitExpr v96 v35
    let v98 : string = (v97).ToString ()
    let v99 : string = $"r#\"{v38}\"#"
    let v100 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v99
    let v101 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v100 v41
    let v102 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v101 v43
    let v103 : string = method7(v98)
    let v104 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v103 v46
    let v105 : string = method8()
    let v106 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v105 v46
    let v107 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v102, v104, v106) v50
    let v108 : obj = v107
    let v109 : string = Fable.Core.Rust.emitExpr v108 v53
    let v110 : string = $"r#\"{v55}\"#"
    let v111 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v110
    let v112 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v111 v41
    let v113 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v112 v43
    let v114 : string = method7(v109)
    let v115 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v114 v46
    let v116 : string = method9()
    let v117 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v116 v46
    let v118 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v113, v115, v117) v50
    let v119 : obj = v118
    let v120 : string = Fable.Core.Rust.emitExpr v119 v53
    let v121 : string = $"r#\"{v67}\"#"
    let v122 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v121
    let v123 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v122 v41
    let v124 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v123 v43
    let v125 : string = method7(v120)
    let v126 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v125 v46
    let v127 : string = method10()
    let v128 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v127 v46
    let v129 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v124, v126, v128) v50
    let v130 : obj = v129
    let v131 : string = Fable.Core.Rust.emitExpr v130 v53
    let v132 : string = $"r#\"{v79}\"#"
    let v133 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v132
    let v134 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v133 v41
    let v135 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v134 v43
    let v136 : string = method7(v131)
    let v137 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v136 v46
    let v138 : string = method11()
    let v139 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v138 v46
    let v140 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v135, v137, v139) v50
    let v141 : obj = v140
    let v142 : string = Fable.Core.Rust.emitExpr v141 v53
    let v143 : Types.EmitType<Types.std.string.String> = method1(v142)
    let v144 : Types.std.string.String = Fable.Core.Rust.emitExpr v23 v35
    let v145 : string = (v144).ToString ()
    let v146 : string = $"r#\"{v38}\"#"
    let v147 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v146
    let v148 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v147 v41
    let v149 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v148 v43
    let v150 : string = method7(v145)
    let v151 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v150 v46
    let v152 : string = method8()
    let v153 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v152 v46
    let v154 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v149, v151, v153) v50
    let v155 : obj = v154
    let v156 : string = Fable.Core.Rust.emitExpr v155 v53
    let v157 : string = $"r#\"{v55}\"#"
    let v158 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v157
    let v159 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v158 v41
    let v160 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v159 v43
    let v161 : string = method7(v156)
    let v162 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v161 v46
    let v163 : string = method9()
    let v164 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v163 v46
    let v165 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v160, v162, v164) v50
    let v166 : obj = v165
    let v167 : string = Fable.Core.Rust.emitExpr v166 v53
    let v168 : string = $"r#\"{v67}\"#"
    let v169 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v168
    let v170 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v169 v41
    let v171 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v170 v43
    let v172 : string = method7(v167)
    let v173 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v172 v46
    let v174 : string = method10()
    let v175 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v174 v46
    let v176 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v171, v173, v175) v50
    let v177 : obj = v176
    let v178 : string = Fable.Core.Rust.emitExpr v177 v53
    let v179 : string = $"r#\"{v79}\"#"
    let v180 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v179
    let v181 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v180 v41
    let v182 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v181 v43
    let v183 : string = method7(v178)
    let v184 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v183 v46
    let v185 : string = method11()
    let v186 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v185 v46
    let v187 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v182, v184, v186) v50
    let v188 : obj = v187
    let v189 : string = Fable.Core.Rust.emitExpr v188 v53
    let v190 : Types.EmitType<Types.std.string.String> = method1(v189)
    let v191 : string = method12()
    let v192 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v191 v46
    let v193 : unativeint = unativeint 0
    let v194 : unativeint = unativeint 2
    let v195 : string = "&$0[$1..$2]"
    let v196 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v192, v193, v194) v195
    let v197 : obj = v196
    let v198 : string = Fable.Core.Rust.emitExpr v197 v53
    let v199 : string = "u8::from_str_radix($0, 16).unwrap()"
    let v200 : uint8 = Fable.Core.Rust.emitExpr v198 v199
    let v201 : string = method12()
    let v202 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v201 v46
    let v203 : unativeint = unativeint 2
    let v204 : unativeint = unativeint 4
    let v205 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v202, v203, v204) v195
    let v206 : obj = v205
    let v207 : string = Fable.Core.Rust.emitExpr v206 v53
    let v208 : uint8 = Fable.Core.Rust.emitExpr v207 v199
    let v209 : string = method12()
    let v210 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v209 v46
    let v211 : unativeint = unativeint 4
    let v212 : unativeint = unativeint 6
    let v213 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v210, v211, v212) v195
    let v214 : obj = v213
    let v215 : string = Fable.Core.Rust.emitExpr v214 v53
    let v216 : uint8 = Fable.Core.Rust.emitExpr v215 v199
    let v217 : string = "colored::Colorize::truecolor(&*$0.to_string(), $1, $2, $3)"
    let v218 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v143, v200, v208, v216) v217
    let v219 : Types.std.string.String = Fable.Core.Rust.emitExpr v218 v35
    let v220 : string = method13()
    let v221 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v220 v46
    let v222 : unativeint = unativeint 0
    let v223 : unativeint = unativeint 2
    let v224 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v221, v222, v223) v195
    let v225 : obj = v224
    let v226 : string = Fable.Core.Rust.emitExpr v225 v53
    let v227 : uint8 = Fable.Core.Rust.emitExpr v226 v199
    let v228 : string = method13()
    let v229 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v228 v46
    let v230 : unativeint = unativeint 2
    let v231 : unativeint = unativeint 4
    let v232 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v229, v230, v231) v195
    let v233 : obj = v232
    let v234 : string = Fable.Core.Rust.emitExpr v233 v53
    let v235 : uint8 = Fable.Core.Rust.emitExpr v234 v199
    let v236 : string = method13()
    let v237 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v236 v46
    let v238 : unativeint = unativeint 4
    let v239 : unativeint = unativeint 6
    let v240 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v237, v238, v239) v195
    let v241 : obj = v240
    let v242 : string = Fable.Core.Rust.emitExpr v241 v53
    let v243 : uint8 = Fable.Core.Rust.emitExpr v242 v199
    let v244 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v190, v227, v235, v243) v217
    let v245 : Types.std.string.String = Fable.Core.Rust.emitExpr v244 v35
    let v246 : string = $"{v91} {v219} {v245}"
    System.Console.WriteLine v246
    ()
and closure1 () (v0 : Types.rocket.http.uri.Segments<Types.rocket.http.uri.fmt.Path>) : unit =
    let struct (v1 : string, v2 : string, v3 : string, v4 : bool) = method0()
    let v5 : string = "chrono::Utc::now()"
    let v6 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v5
    let v7 : string = "($0).timestamp()"
    let v8 : int64 = Fable.Core.Rust.emitExpr v6 v7
    let v9 : string = "uri"
    let v10 : Types.EmitType<Types.std.string.String> = method1(v9)
    let v11 : Types.EmitType<Types.std.string.String> = method2(v0)
    let v12 : (Types.EmitType<Types.std.string.String> []) = [|v10; v11|]
    method3(v8, v12)
and method15 () : string =
    let v0 : string = "666666"
    v0
and method14 (v0 : int64, v1 : (Types.EmitType<Types.std.string.String> [])) : unit =
    let v2 : string = "chrono::Utc::now()"
    let v3 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v2
    let v4 : string = "($0).timestamp()"
    let v5 : int64 = Fable.Core.Rust.emitExpr v3 v4
    let v6 : int64 = v5 - v0
    let v7 : string = (v6).ToString ()
    let v8 : int32 = 6
    let v9 : string = method4(v8, v7)
    let v10 : string = "rand::random::<u8>()"
    let v11 : uint8 = Fable.Core.Rust.emitExpr () v10
    let v12 : string = "timestamp"
    let v13 : Types.EmitType<Types.std.string.String> = method1(v12)
    let v14 : Types.EmitType<Types.std.string.String> = method1(v9)
    let v15 : string = "run_id"
    let v16 : Types.EmitType<Types.std.string.String> = method1(v15)
    let v17 : Types.EmitType<Types.std.string.String> = method5(v11)
    let v18 : string = "log_level"
    let v19 : Types.EmitType<Types.std.string.String> = method1(v18)
    let v20 : string = "Debug"
    let v21 : Types.EmitType<Types.std.string.String> = method1(v20)
    let v22 : (Types.EmitType<Types.std.string.String> []) = [|v13; v14; v16; v17; v19; v21|]
    let v23 : Types.EmitType<Types.std.string.String> = method6(v22)
    let v24 : string = "> init ()"
    let v25 : Types.EmitType<Types.std.string.String> = method1(v24)
    let v26 : (Types.EmitType<Types.std.string.String> []) = [|v25|]
    let v27 : string = "core::ops::Deref::deref($0)"
    let v28 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v26 v27
    let v29 : string = "&***$0"
    let v30 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v28 v29
    let v31 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v30 v29
    let v32 : string = "format!(\"{:?}\", $0)"
    let v33 : Types.std.string.String = Fable.Core.Rust.emitExpr v31 v32
    let v34 : Types.EmitType<Types.std.string.String> = v33 |> unbox<Types.EmitType<Types.std.string.String>>
    let v35 : string = "format!(\"{}\", $0)"
    let v36 : Types.std.string.String = Fable.Core.Rust.emitExpr v34 v35
    let v37 : string = (v36).ToString ()
    let v38 : string = "\"([^\"]+)\", \"([^\"]+)\""
    let v39 : string = $"r#\"{v38}\"#"
    let v40 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v39
    let v41 : string = "regex::RegexBuilder::new($0)"
    let v42 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v40 v41
    let v43 : string = "$0.build().unwrap()"
    let v44 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v42 v43
    let v45 : string = method7(v37)
    let v46 : string = "$0.as_str()"
    let v47 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v45 v46
    let v48 : string = method8()
    let v49 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v48 v46
    let v50 : string = "$0.replace_all(&$1, $2).to_string()"
    let v51 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v44, v47, v49) v50
    let v52 : obj = v51
    let v53 : string = "fable_library_rust::String_::fromStr($0)"
    let v54 : string = Fable.Core.Rust.emitExpr v52 v53
    let v55 : string = "\\[\"(.*?)\"\\]"
    let v56 : string = $"r#\"{v55}\"#"
    let v57 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v56
    let v58 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v57 v41
    let v59 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v58 v43
    let v60 : string = method7(v54)
    let v61 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v60 v46
    let v62 : string = method9()
    let v63 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v62 v46
    let v64 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v59, v61, v63) v50
    let v65 : obj = v64
    let v66 : string = Fable.Core.Rust.emitExpr v65 v53
    let v67 : string = "\\\\\""
    let v68 : string = $"r#\"{v67}\"#"
    let v69 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v68
    let v70 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v69 v41
    let v71 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v70 v43
    let v72 : string = method7(v66)
    let v73 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v72 v46
    let v74 : string = method10()
    let v75 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v74 v46
    let v76 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v71, v73, v75) v50
    let v77 : obj = v76
    let v78 : string = Fable.Core.Rust.emitExpr v77 v53
    let v79 : string = ", "
    let v80 : string = $"r#\"{v79}\"#"
    let v81 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v80
    let v82 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v81 v41
    let v83 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v82 v43
    let v84 : string = method7(v78)
    let v85 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v84 v46
    let v86 : string = method11()
    let v87 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v86 v46
    let v88 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v83, v85, v87) v50
    let v89 : obj = v88
    let v90 : string = Fable.Core.Rust.emitExpr v89 v53
    let v91 : Types.EmitType<Types.std.string.String> = method1(v90)
    let v92 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v1 v27
    let v93 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v92 v29
    let v94 : Types.Ref<obj> = Fable.Core.Rust.emitExpr v93 v29
    let v95 : Types.std.string.String = Fable.Core.Rust.emitExpr v94 v32
    let v96 : Types.EmitType<Types.std.string.String> = v95 |> unbox<Types.EmitType<Types.std.string.String>>
    let v97 : Types.std.string.String = Fable.Core.Rust.emitExpr v96 v35
    let v98 : string = (v97).ToString ()
    let v99 : string = $"r#\"{v38}\"#"
    let v100 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v99
    let v101 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v100 v41
    let v102 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v101 v43
    let v103 : string = method7(v98)
    let v104 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v103 v46
    let v105 : string = method8()
    let v106 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v105 v46
    let v107 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v102, v104, v106) v50
    let v108 : obj = v107
    let v109 : string = Fable.Core.Rust.emitExpr v108 v53
    let v110 : string = $"r#\"{v55}\"#"
    let v111 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v110
    let v112 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v111 v41
    let v113 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v112 v43
    let v114 : string = method7(v109)
    let v115 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v114 v46
    let v116 : string = method9()
    let v117 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v116 v46
    let v118 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v113, v115, v117) v50
    let v119 : obj = v118
    let v120 : string = Fable.Core.Rust.emitExpr v119 v53
    let v121 : string = $"r#\"{v67}\"#"
    let v122 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v121
    let v123 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v122 v41
    let v124 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v123 v43
    let v125 : string = method7(v120)
    let v126 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v125 v46
    let v127 : string = method10()
    let v128 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v127 v46
    let v129 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v124, v126, v128) v50
    let v130 : obj = v129
    let v131 : string = Fable.Core.Rust.emitExpr v130 v53
    let v132 : string = $"r#\"{v79}\"#"
    let v133 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v132
    let v134 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v133 v41
    let v135 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v134 v43
    let v136 : string = method7(v131)
    let v137 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v136 v46
    let v138 : string = method11()
    let v139 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v138 v46
    let v140 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v135, v137, v139) v50
    let v141 : obj = v140
    let v142 : string = Fable.Core.Rust.emitExpr v141 v53
    let v143 : Types.EmitType<Types.std.string.String> = method1(v142)
    let v144 : Types.std.string.String = Fable.Core.Rust.emitExpr v23 v35
    let v145 : string = (v144).ToString ()
    let v146 : string = $"r#\"{v38}\"#"
    let v147 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v146
    let v148 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v147 v41
    let v149 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v148 v43
    let v150 : string = method7(v145)
    let v151 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v150 v46
    let v152 : string = method8()
    let v153 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v152 v46
    let v154 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v149, v151, v153) v50
    let v155 : obj = v154
    let v156 : string = Fable.Core.Rust.emitExpr v155 v53
    let v157 : string = $"r#\"{v55}\"#"
    let v158 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v157
    let v159 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v158 v41
    let v160 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v159 v43
    let v161 : string = method7(v156)
    let v162 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v161 v46
    let v163 : string = method9()
    let v164 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v163 v46
    let v165 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v160, v162, v164) v50
    let v166 : obj = v165
    let v167 : string = Fable.Core.Rust.emitExpr v166 v53
    let v168 : string = $"r#\"{v67}\"#"
    let v169 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v168
    let v170 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v169 v41
    let v171 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v170 v43
    let v172 : string = method7(v167)
    let v173 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v172 v46
    let v174 : string = method10()
    let v175 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v174 v46
    let v176 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v171, v173, v175) v50
    let v177 : obj = v176
    let v178 : string = Fable.Core.Rust.emitExpr v177 v53
    let v179 : string = $"r#\"{v79}\"#"
    let v180 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v179
    let v181 : Types.regex.RegexBuilder = Fable.Core.Rust.emitExpr v180 v41
    let v182 : Types.Ref<Types.regex.Regex> = Fable.Core.Rust.emitExpr v181 v43
    let v183 : string = method7(v178)
    let v184 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v183 v46
    let v185 : string = method11()
    let v186 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v185 v46
    let v187 : Types.std.string.String = Fable.Core.Rust.emitExpr struct (v182, v184, v186) v50
    let v188 : obj = v187
    let v189 : string = Fable.Core.Rust.emitExpr v188 v53
    let v190 : Types.EmitType<Types.std.string.String> = method1(v189)
    let v191 : string = method15()
    let v192 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v191 v46
    let v193 : unativeint = unativeint 0
    let v194 : unativeint = unativeint 2
    let v195 : string = "&$0[$1..$2]"
    let v196 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v192, v193, v194) v195
    let v197 : obj = v196
    let v198 : string = Fable.Core.Rust.emitExpr v197 v53
    let v199 : string = "u8::from_str_radix($0, 16).unwrap()"
    let v200 : uint8 = Fable.Core.Rust.emitExpr v198 v199
    let v201 : string = method15()
    let v202 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v201 v46
    let v203 : unativeint = unativeint 2
    let v204 : unativeint = unativeint 4
    let v205 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v202, v203, v204) v195
    let v206 : obj = v205
    let v207 : string = Fable.Core.Rust.emitExpr v206 v53
    let v208 : uint8 = Fable.Core.Rust.emitExpr v207 v199
    let v209 : string = method15()
    let v210 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v209 v46
    let v211 : unativeint = unativeint 4
    let v212 : unativeint = unativeint 6
    let v213 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v210, v211, v212) v195
    let v214 : obj = v213
    let v215 : string = Fable.Core.Rust.emitExpr v214 v53
    let v216 : uint8 = Fable.Core.Rust.emitExpr v215 v199
    let v217 : string = "colored::Colorize::truecolor(&*$0.to_string(), $1, $2, $3)"
    let v218 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v143, v200, v208, v216) v217
    let v219 : Types.std.string.String = Fable.Core.Rust.emitExpr v218 v35
    let v220 : string = method13()
    let v221 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v220 v46
    let v222 : unativeint = unativeint 0
    let v223 : unativeint = unativeint 2
    let v224 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v221, v222, v223) v195
    let v225 : obj = v224
    let v226 : string = Fable.Core.Rust.emitExpr v225 v53
    let v227 : uint8 = Fable.Core.Rust.emitExpr v226 v199
    let v228 : string = method13()
    let v229 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v228 v46
    let v230 : unativeint = unativeint 2
    let v231 : unativeint = unativeint 4
    let v232 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v229, v230, v231) v195
    let v233 : obj = v232
    let v234 : string = Fable.Core.Rust.emitExpr v233 v53
    let v235 : uint8 = Fable.Core.Rust.emitExpr v234 v199
    let v236 : string = method13()
    let v237 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr v236 v46
    let v238 : unativeint = unativeint 4
    let v239 : unativeint = unativeint 6
    let v240 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr struct (v237, v238, v239) v195
    let v241 : obj = v240
    let v242 : string = Fable.Core.Rust.emitExpr v241 v53
    let v243 : uint8 = Fable.Core.Rust.emitExpr v242 v199
    let v244 : Types.colored.ColoredString = Fable.Core.Rust.emitExpr struct (v190, v227, v235, v243) v217
    let v245 : Types.std.string.String = Fable.Core.Rust.emitExpr v244 v35
    let v246 : string = $"{v91} {v219} {v245}"
    System.Console.WriteLine v246
    ()
and closure0 () () : int32 =
    let struct (v0 : string, v1 : string, v2 : string, v3 : bool) = method0()
    let v4 : string = "chrono::Utc::now()"
    let v5 : Types.chrono.DateTime<Types.chrono.Utc> = Fable.Core.Rust.emitExpr () v4
    let v6 : string = "($0).timestamp()"
    let v7 : int64 = Fable.Core.Rust.emitExpr v5 v6
    let v8 : string = "#[rocket::get(\"/<uri..>\")]"
    let v9 : string = " async fn proxy("
    let v10 : string = v8 + v9
    let v11 : string = "   uri: rocket::http::uri::Segments<'_, rocket::http::uri::fmt::Path>,"
    let v12 : string = v10 + v11
    let v13 : string = "   client: &rocket::State<reqwest::Client>"
    let v14 : string = v12 + v13
    let v15 : string = " ) -> Result<rocket::response::content::RawHtml<String>, rocket::http::Status> {"
    let v16 : string = v14 + v15
    let v17 : (Types.rocket.http.uri.Segments<Types.rocket.http.uri.fmt.Path> -> unit) = closure1()
    let v18 : string = "   v17(uri.clone());"
    let v19 : string = v16 + v18
    let v20 : string = "   let uri = uri.collect::<Vec<_>>();"
    let v21 : string = v19 + v20
    let v22 : string = "   let uri = uri.join(\"/\");"
    let v23 : string = v21 + v22
    let v24 : string = "   let uri = uri.replace(\":/\", \"://\");"
    let v25 : string = v23 + v24
    let v26 : string = "   let (host_url, url) = uri.split_once('|').unwrap_or((\"\", &uri));"
    let v27 : string = v25 + v26
    let v28 : string = "   let (host_protocol, host_host) = host_url.split_once(\"://\").unwrap_or((\"https\", \"www.github.com\"));"
    let v29 : string = v27 + v28
    let v30 : string = "   let (protocol, suffix) = url.split_once(\"://\").unwrap_or((host_protocol, url));"
    let v31 : string = v29 + v30
    let v32 : string = "   let (host, path) = match (url.split_once(\"://\"), suffix.split_once(\"/\")) {"
    let v33 : string = v31 + v32
    let v34 : string = "     (Some(_), None) if suffix != \"\" => (suffix, \"\"),"
    let v35 : string = v33 + v34
    let v36 : string = "     _ => (host_host, suffix),"
    let v37 : string = v35 + v36
    let v38 : string = "   };"
    let v39 : string = v37 + v38
    let v40 : string = "   let new_url = match path {"
    let v41 : string = v39 + v40
    let v42 : string = "     \"\" => format!(\"{protocol}://{host}\"),"
    let v43 : string = v41 + v42
    let v44 : string = "     _ => format!(\"{protocol}://{host}/{path}\"),"
    let v45 : string = v43 + v44
    let v46 : string = "   };"
    let v47 : string = v45 + v46
    let v48 : string = "   println!(\"uri={uri}; new_url={new_url}; host={host}; path={path}; suffix={suffix}; host_url={host_url}; url={url}; host_host={host_host}; host_protocol={host_protocol}; protocol={protocol}\");"
    let v49 : string = v47 + v48
    let v50 : string = "   let res = client"
    let v51 : string = v49 + v50
    let v52 : string = "     .get(new_url)"
    let v53 : string = v51 + v52
    let v54 : string = "     .send()"
    let v55 : string = v53 + v54
    let v56 : string = "     .await"
    let v57 : string = v55 + v56
    let v58 : string = "     .map_err(|_| rocket::http::Status::NotFound);"
    let v59 : string = v57 + v58
    let v60 : string = "   match res {"
    let v61 : string = v59 + v60
    let v62 : string = "       Ok(res) => {"
    let v63 : string = v61 + v62
    let v64 : string = "           let content = res.text();"
    let v65 : string = v63 + v64
    let v66 : string = "           let content = content.await;"
    let v67 : string = v65 + v66
    let v68 : string = "           let content = content.map_err(|_| rocket::http::Status::InternalServerError);"
    let v69 : string = v67 + v68
    let v70 : string = "           let content = content.unwrap();"
    let v71 : string = v69 + v70
    let v72 : string = "           Ok(rocket::response::content::RawHtml(content))"
    let v73 : string = v71 + v72
    let v74 : string = "       }"
    let v75 : string = v73 + v74
    let v76 : string = "       Err(status) => Err(status),"
    let v77 : string = v75 + v76
    let v78 : string = "   }"
    let v79 : string = v77 + v78
    let v80 : string = "} ()"
    let v81 : string = v79 + v80
    Fable.Core.Rust.emitExpr () v81
    let v82 : string = "#[rocket::get(\"/file/<file..>\")]"
    let v83 : string = " async fn file("
    let v84 : string = v82 + v83
    let v85 : string = "   file: std::path::PathBuf,"
    let v86 : string = v84 + v85
    let v87 : string = "   client: &rocket::State<reqwest::Client>"
    let v88 : string = v86 + v87
    let v89 : string = " ) -> std::option::Option<rocket::fs::NamedFile> {"
    let v90 : string = v88 + v89
    let v91 : string = "   rocket::fs::NamedFile::open(std::path::Path::new(\"./\").join(file))"
    let v92 : string = v90 + v91
    let v93 : string = "     .await"
    let v94 : string = v92 + v93
    let v95 : string = "     .ok()"
    let v96 : string = v94 + v95
    let v97 : string = "} ()"
    let v98 : string = v96 + v97
    Fable.Core.Rust.emitExpr () v98
    let v99 : string = "#[rocket::launch]"
    let v100 : string = " fn rocket() -> _ {"
    let v101 : string = v99 + v100
    let v102 : string = "    rocket::build()"
    let v103 : string = v101 + v102
    let v104 : string = "      .manage(reqwest::Client::new())"
    let v105 : string = v103 + v104
    let v106 : string = "      .mount(\"/\", rocket::routes![proxy, file])"
    let v107 : string = v105 + v106
    let v108 : string = "} ()"
    let v109 : string = v107 + v108
    Fable.Core.Rust.emitExpr () v109
    let v110 : string = "app end"
    let v111 : Types.EmitType<Types.std.string.String> = method1(v110)
    let v112 : string = "???"
    let v113 : Types.EmitType<Types.std.string.String> = method1(v112)
    let v114 : (Types.EmitType<Types.std.string.String> []) = [|v111; v113|]
    method14(v7, v114)
    0
let v0 : (unit -> int32) = closure0()
()