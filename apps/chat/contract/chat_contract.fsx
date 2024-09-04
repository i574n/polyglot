#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("*/ $0 /*")>]
#endif
type TypeEmit<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_sdk::store::LookupMap<$0, $1>")>]
#endif
type near_sdk_store_LookupMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>]
#endif
type std_collections_HashMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_sdk::AccountId")>]
#endif
type near_sdk_AccountId = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
let rec closure1 () (v0 : char) : bool =
    let v1 : string = $"$0.is_alphanumeric()"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1 
    if v2 then
        true
    else
        let v3 : bool = v0 = '-'
        v3
and closure2 () (v0 : std_string_String) : bool =
    let v1 : string = "fable_library_rust::String_::fromString($0)"
    let v2 : string = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : int32 = v2.Length
    let v4 : bool = v3 > 0
    if v4 then
        let v5 : bool = v3 < 64
        if v5 then
            let v6 : string = "-"
            let v7 : bool = v2.StartsWith v6 
            let v10 : bool = v7 = false
            if v10 then
                let v11 : bool = v2.EndsWith v6 
                let v12 : bool = v11 = false
                if v12 then
                    let v13 : string = "&*$0"
                    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v13 
                    let v15 : string = $"$0.chars()"
                    let v16 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v14 v15 
                    let v17 : string = "true; // 1"
                    let v18 : bool = Fable.Core.RustInterop.emitRustExpr () v17 
                    let v19 : string = "let mut v16 = v16"
                    Fable.Core.RustInterop.emitRustExpr () v19 
                    let v20 : string = $"v16.all(|x| $0(x))"
                    let v21 : (char -> bool) = closure1()
                    let v22 : bool = Fable.Core.RustInterop.emitRustExpr v21 v20 
                    v22
                else
                    false
            else
                false
        else
            false
    else
        false
and method0 () : (std_string_String -> bool) =
    closure2()
and closure0 () () : unit =
    let v0 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v2 
    let v3 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v3 
    let v4 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v4 
    let v5 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v5 
    let v6 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v6 
    let v7 : string = "pub struct State ( //"
    Fable.Core.RustInterop.emitRustExpr () v7 
    let v8 : string = "/*"
    Fable.Core.RustInterop.emitRustExpr () v8 
    let v9 : TypeEmit<struct (uint32 * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>)>>
    let v12 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v12 
    let v13 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "true; /*"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v22 : string = "true; */"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "l"
    let v25 : string = "b\"" + v24 + "\""
    let v26 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "near_sdk::store::LookupMap::new(v26)"
    let v28 : near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "c"
    let v30 : string = "b\"" + v29 + "\""
    let v31 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "near_sdk::store::LookupMap::new(v31)"
    let v33 : near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v32 
    let _result = struct (1u, v28, v33) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v34 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v35 
    let v36 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v36 
    let v37 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v38 : bool = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v40 : bool = Fable.Core.RustInterop.emitRustExpr () v39 
    let v41 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v41 
    let v42 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "fn is_valid_alias(alias: String) -> bool { //"
    Fable.Core.RustInterop.emitRustExpr () v43 
    let v44 : string = $"alias"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "fable_library_rust::String_::fromString($0)"
    let v47 : string = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : int32 = v47.Length
    let v49 : bool = v48 > 0
    let v71 : bool =
        if v49 then
            let v50 : bool = v48 < 64
            if v50 then
                let v51 : string = "-"
                let v52 : bool = v47.StartsWith v51 
                let v55 : bool = v52 = false
                if v55 then
                    let v56 : bool = v47.EndsWith v51 
                    let v57 : bool = v56 = false
                    if v57 then
                        let v58 : string = "&*$0"
                        let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v47 v58 
                        let v60 : string = $"$0.chars()"
                        let v61 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v59 v60 
                        let v62 : string = "true; // 1"
                        let v63 : bool = Fable.Core.RustInterop.emitRustExpr () v62 
                        let v64 : string = "let mut v61 = v61"
                        Fable.Core.RustInterop.emitRustExpr () v64 
                        let v65 : string = $"v61.all(|x| $0(x))"
                        let v66 : (char -> bool) = closure1()
                        let v67 : bool = Fable.Core.RustInterop.emitRustExpr v66 v65 
                        v67
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let _result = v71 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v72 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v72 
    let v73 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v73 
    let v74 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr () v74 
    let v76 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 1uy"
    let v77 : bool = Fable.Core.RustInterop.emitRustExpr () v76 
    let v78 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v78 
    let v79 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v79 
    let v80 : string = "pub fn generate_cid( //"
    Fable.Core.RustInterop.emitRustExpr () v80 
    let v81 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v81 
    let v82 : string = "  content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v82 
    let v83 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v83 
    let v84 : string = $"content"
    let v85 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v84 
    let v86 : string = "  fn encode_u64(value: u64) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v86 
    let v87 : string = "    let mut buffer = unsigned_varint::encode::u64_buffer(); //"
    Fable.Core.RustInterop.emitRustExpr () v87 
    let v88 : string = "    unsigned_varint::encode::u64(value, &mut buffer).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v88 
    let v89 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v89 
    let v90 : string = "  fn sha256_hash(content: &[u8]) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v90 
    let v91 : string = "    let mut hasher: sha2::Sha256 = sha2::Digest::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v91 
    let v92 : string = "    sha2::Digest::update(&mut hasher, content); //"
    Fable.Core.RustInterop.emitRustExpr () v92 
    let v93 : string = "    sha2::Digest::finalize(hasher).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v93 
    let v94 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v94 
    let v95 : string = "  let version: u8 = 1; //"
    Fable.Core.RustInterop.emitRustExpr () v95 
    let v96 : string = "  let codec_raw: u64 = 0x55; //"
    Fable.Core.RustInterop.emitRustExpr () v96 
    let v97 : string = "  let codec_bytes = encode_u64(codec_raw); //"
    Fable.Core.RustInterop.emitRustExpr () v97 
    let v98 : string = "  let hash_result = sha256_hash(&v85); //"
    Fable.Core.RustInterop.emitRustExpr () v98 
    let v99 : string = "  let multihash = std::iter::once(0x12) //"
    Fable.Core.RustInterop.emitRustExpr () v99 
    let v100 : string = "    .chain(std::iter::once(32)) //"
    Fable.Core.RustInterop.emitRustExpr () v100 
    let v101 : string = "    .chain(hash_result.into_iter()) //"
    Fable.Core.RustInterop.emitRustExpr () v101 
    let v102 : string = "    .collect(); //"
    Fable.Core.RustInterop.emitRustExpr () v102 
    let v103 : string = "  let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //"
    Fable.Core.RustInterop.emitRustExpr () v103 
    let v104 : string = "  let result = multibase::encode(multibase::Base::Base32Lower, &cid_bytes); //"
    Fable.Core.RustInterop.emitRustExpr () v104 
    let v105 : string = "result"
    let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v105 
    let _result = v106 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v107 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v107 
    let v108 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v108 
    let v109 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy"
    let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109 
    let v111 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 3uy / n: 2uy"
    let v112 : bool = Fable.Core.RustInterop.emitRustExpr () v111 
    let v113 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v113 
    let v114 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v114 
    let v115 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v115 
    let v116 : string = "pub fn generate_cid_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v116 
    let v117 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v117 
    let v118 : string = "  #[serializer(borsh)] content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v118 
    let v119 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v119 
    let v120 : string = "  self.generate_cid(content) //"
    Fable.Core.RustInterop.emitRustExpr () v120 
    let v121 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v121 
    let v122 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v122 
    let v123 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy"
    let v124 : bool = Fable.Core.RustInterop.emitRustExpr () v123 
    let v125 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 5uy / n: 1uy"
    let v126 : bool = Fable.Core.RustInterop.emitRustExpr () v125 
    let v127 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v127 
    let v128 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v128 
    let v129 : string = "pub fn claim_alias( //"
    Fable.Core.RustInterop.emitRustExpr () v129 
    let v130 : string = "  &mut self, //"
    Fable.Core.RustInterop.emitRustExpr () v130 
    let v131 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v131 
    let v132 : string = ") { //"
    Fable.Core.RustInterop.emitRustExpr () v132 
    let v133 : string = $"&mut self.0"
    let v134 : Ref<Mut<struct (uint32 * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>)>> = Fable.Core.RustInterop.emitRustExpr () v133 
    let v135 : string = $"alias"
    let v136 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v135 
    let v137 : string = $"&mut v134.2"
    let v138 : Ref<Mut<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v137 
    let v139 : string = $"&mut v134.1"
    let v140 : Ref<Mut<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>>> = Fable.Core.RustInterop.emitRustExpr () v139 
    let v141 : string = "  let account_id = near_sdk::env::signer_account_id(); //"
    Fable.Core.RustInterop.emitRustExpr () v141 
    let v142 : string = "  let timestamp = near_sdk::env::block_timestamp(); //"
    Fable.Core.RustInterop.emitRustExpr () v142 
    let v143 : string = "  near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v143 
    let v144 : string = "    \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v144 
    let v145 : string = "    format!( //"
    Fable.Core.RustInterop.emitRustExpr () v145 
    let v146 : string = "      \"claim_alias "
    Fable.Core.RustInterop.emitRustExpr () v146 
    let v147 : string = "            alias: {v136:#?} "
    Fable.Core.RustInterop.emitRustExpr () v147 
    let v148 : string = "            account_id: {account_id:#?} "
    Fable.Core.RustInterop.emitRustExpr () v148 
    let v149 : string = "            timestamp: {timestamp:#?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v149 
    let v150 : string = "    ) //"
    Fable.Core.RustInterop.emitRustExpr () v150 
    let v151 : string = "  ); //"
    Fable.Core.RustInterop.emitRustExpr () v151 
    let v152 : (std_string_String -> bool) = method0()
    let v153 : string = "  if !v152(v136.clone()) { //"
    Fable.Core.RustInterop.emitRustExpr () v153 
    let v154 : string = "    near_sdk::env::panic_str(\"Invalid alias\"); //"
    Fable.Core.RustInterop.emitRustExpr () v154 
    let v155 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v155 
    let v156 : string = "  if let Some(previous_alias) = v138.get(&account_id) { //"
    Fable.Core.RustInterop.emitRustExpr () v156 
    let v157 : string = "    if *previous_alias == v136 { //"
    Fable.Core.RustInterop.emitRustExpr () v157 
    let v158 : string = "      near_sdk::log!(\"{}\", \"Alias already claimed\"); //"
    Fable.Core.RustInterop.emitRustExpr () v158 
    let v159 : string = "      return; //"
    Fable.Core.RustInterop.emitRustExpr () v159 
    let v160 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v160 
    let v161 : string = "    v140 //"
    Fable.Core.RustInterop.emitRustExpr () v161 
    let v162 : string = "      .get_mut(previous_alias) //"
    Fable.Core.RustInterop.emitRustExpr () v162 
    let v163 : string = "      .unwrap() //"
    Fable.Core.RustInterop.emitRustExpr () v163 
    let v164 : string = "      .remove(&account_id); //"
    Fable.Core.RustInterop.emitRustExpr () v164 
    let v165 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v165 
    let v166 : string = "  v138.insert(account_id.clone(), v136.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v166 
    let v167 : string = "  let new_alias_account_map = match v140.get(&v136) { //"
    Fable.Core.RustInterop.emitRustExpr () v167 
    let v168 : string = "    None => { //"
    Fable.Core.RustInterop.emitRustExpr () v168 
    let v169 : string = "      let mut new_map = std::collections::HashMap::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v169 
    let v170 : string = "      new_map.insert(account_id, (timestamp, 0u32)); //"
    Fable.Core.RustInterop.emitRustExpr () v170 
    let v171 : string = "      new_map //"
    Fable.Core.RustInterop.emitRustExpr () v171 
    let v172 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v172 
    let v173 : string = "    Some(accounts) => { //"
    Fable.Core.RustInterop.emitRustExpr () v173 
    let v174 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
    Fable.Core.RustInterop.emitRustExpr () v174 
    let v175 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
    Fable.Core.RustInterop.emitRustExpr () v175 
    let v176 : string = "      let mut new_map = accounts_vec //"
    Fable.Core.RustInterop.emitRustExpr () v176 
    let v177 : string = "        .iter() //"
    Fable.Core.RustInterop.emitRustExpr () v177 
    let v178 : string = "        .enumerate() //"
    Fable.Core.RustInterop.emitRustExpr () v178 
    let v179 : string = "        .map(|(i, (account_id, (timestamp, _)))| { //"
    Fable.Core.RustInterop.emitRustExpr () v179 
    let v180 : string = "          ((*account_id).clone(), (*timestamp, i as u32)) //"
    Fable.Core.RustInterop.emitRustExpr () v180 
    let v181 : string = "        }) //"
    Fable.Core.RustInterop.emitRustExpr () v181 
    let v182 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
    Fable.Core.RustInterop.emitRustExpr () v182 
    let v183 : string = "      new_map.insert(account_id, (timestamp, accounts_vec.len() as u32)); //"
    Fable.Core.RustInterop.emitRustExpr () v183 
    let v184 : string = "      new_map //"
    Fable.Core.RustInterop.emitRustExpr () v184 
    let v185 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v185 
    let v186 : string = "  }; //"
    Fable.Core.RustInterop.emitRustExpr () v186 
    let v187 : string = "  v140.insert(v136, new_alias_account_map); //"
    Fable.Core.RustInterop.emitRustExpr () v187 
    let v188 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v188 
    let v189 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v189 
    let v190 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v190 
    let v191 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v191 
    let v192 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy"
    let v193 : bool = Fable.Core.RustInterop.emitRustExpr () v192 
    let v194 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy"
    let v195 : bool = Fable.Core.RustInterop.emitRustExpr () v194 
    let v196 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v196 
    let v197 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v197 
    let v198 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v198 
    let v199 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v199 
    let v200 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v200 
    let v201 : string = ") -> Option<(String, (u64, u32))> { //"
    Fable.Core.RustInterop.emitRustExpr () v201 
    let v202 : string = $"&self.0.2"
    let v203 : Ref<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v202 
    let v204 : string = $"&self.0.1"
    let v205 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v204 
    let v206 : string = "  near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v206 
    let v207 : string = "    \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v207 
    let v208 : string = "    format!(\"get_account_info / account_id: {account_id:#?}\") //"
    Fable.Core.RustInterop.emitRustExpr () v208 
    let v209 : string = "  ); //"
    Fable.Core.RustInterop.emitRustExpr () v209 
    let v210 : string = "  v203.get(&account_id).and_then(|alias| { //"
    Fable.Core.RustInterop.emitRustExpr () v210 
    let v211 : string = "    v205 //"
    Fable.Core.RustInterop.emitRustExpr () v211 
    let v212 : string = "      .get(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v212 
    let v213 : string = "      .map(|accounts| (alias.clone(), *accounts.get(&account_id).unwrap())) //"
    Fable.Core.RustInterop.emitRustExpr () v213 
    let v214 : string = "  }) //"
    Fable.Core.RustInterop.emitRustExpr () v214 
    let v215 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v215 
    let v216 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v216 
    let v217 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v217 
    let v218 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 2uy"
    let v219 : bool = Fable.Core.RustInterop.emitRustExpr () v218 
    let v220 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 2uy"
    let v221 : bool = Fable.Core.RustInterop.emitRustExpr () v220 
    let v222 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v222 
    let v223 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v223 
    let v224 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v224 
    let v225 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v225 
    let v226 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v226 
    let v227 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v227 
    let v228 : string = $"&self.0.1"
    let v229 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v228 
    let v230 : string = "  near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v230 
    let v231 : string = "    \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v231 
    let v232 : string = "    format!(\"get_alias_map / alias: {alias:#?}\") //"
    Fable.Core.RustInterop.emitRustExpr () v232 
    let v233 : string = "  ); //"
    Fable.Core.RustInterop.emitRustExpr () v233 
    let v234 : string = "  v229.get(&alias).cloned() //"
    Fable.Core.RustInterop.emitRustExpr () v234 
    let v235 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v235 
    let v236 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v236 
    let v237 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v237 
    let v238 : string = "true; // ??? / i: 7uy / i': 1uy / acc: 11uy / n: 2uy"
    let v239 : bool = Fable.Core.RustInterop.emitRustExpr () v238 
    let v240 : string = "true; */ // ???? / i: 7uy / i': 2uy / acc: 11uy / n: 2uy"
    let v241 : bool = Fable.Core.RustInterop.emitRustExpr () v240 
    let v242 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v242 
    let v243 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v243 
    let v244 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v244 
    let v245 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v245 
    let v246 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v246 
    let v247 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v247 
    let v248 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v248 
    let v249 : string = "  self.get_alias_map(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v249 
    let v250 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v250 
    let v251 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v251 
    let v252 : string = "true; // ??? / i: 8uy / i': 1uy / acc: 13uy / n: 1uy"
    let v253 : bool = Fable.Core.RustInterop.emitRustExpr () v252 
    let v254 : string = "true; */ // ???? / i: 8uy / i': 2uy / acc: 13uy / n: 1uy"
    let v255 : bool = Fable.Core.RustInterop.emitRustExpr () v254 
    let v256 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v256 
    let v257 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v257 
    let v258 : string = "true; { (); // ?? / i': 1uy / n: 14uy"
    let v259 : bool = Fable.Core.RustInterop.emitRustExpr () v258 
    let v260 : string = "true; { (); // ?? / i': 2uy / n: 14uy"
    let v261 : bool = Fable.Core.RustInterop.emitRustExpr () v260 
    let v262 : string = "true; { (); // ?? / i': 3uy / n: 14uy"
    let v263 : bool = Fable.Core.RustInterop.emitRustExpr () v262 
    let v264 : string = "true; { (); // ?? / i': 4uy / n: 14uy"
    let v265 : bool = Fable.Core.RustInterop.emitRustExpr () v264 
    let v266 : string = "true; { (); // ?? / i': 5uy / n: 14uy"
    let v267 : bool = Fable.Core.RustInterop.emitRustExpr () v266 
    let v268 : string = "true; { (); // ?? / i': 6uy / n: 14uy"
    let v269 : bool = Fable.Core.RustInterop.emitRustExpr () v268 
    let v270 : string = "true; { (); // ?? / i': 7uy / n: 14uy"
    let v271 : bool = Fable.Core.RustInterop.emitRustExpr () v270 
    let v272 : string = "true; { (); // ?? / i': 8uy / n: 14uy"
    let v273 : bool = Fable.Core.RustInterop.emitRustExpr () v272 
    let v274 : string = "true; { (); // ?? / i': 9uy / n: 14uy"
    let v275 : bool = Fable.Core.RustInterop.emitRustExpr () v274 
    let v276 : string = "true; { (); // ?? / i': 10uy / n: 14uy"
    let v277 : bool = Fable.Core.RustInterop.emitRustExpr () v276 
    let v278 : string = "true; { (); // ?? / i': 11uy / n: 14uy"
    let v279 : bool = Fable.Core.RustInterop.emitRustExpr () v278 
    let v280 : string = "true; { (); // ?? / i': 12uy / n: 14uy"
    let v281 : bool = Fable.Core.RustInterop.emitRustExpr () v280 
    let v282 : string = "true; { (); // ?? / i': 13uy / n: 14uy"
    let v283 : bool = Fable.Core.RustInterop.emitRustExpr () v282 
    let v284 : string = "true; { (); // ?? / i': 14uy / n: 14uy"
    let v285 : bool = Fable.Core.RustInterop.emitRustExpr () v284 
    let v286 : string = "true; { { (); // ? / i': 15uy / n: 14uy"
    let v287 : bool = Fable.Core.RustInterop.emitRustExpr () v286 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
