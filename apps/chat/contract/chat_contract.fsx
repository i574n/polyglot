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
    let v7 : string = "pub struct State { //"
    Fable.Core.RustInterop.emitRustExpr () v7 
    let v8 : string = "    state: /*"
    Fable.Core.RustInterop.emitRustExpr () v8 
    let v9 : TypeEmit<struct (uint32 * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>)>>
    let v12 : string = "*/ } //"
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
    let _result = struct (1u, v28, v33) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"State {{ state: $0 }} // x") // 2
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
    let v43 : string = "fn is_valid_alias(alias: &str) -> bool { //"
    Fable.Core.RustInterop.emitRustExpr () v43 
    let v44 : string = $"alias"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let v50 : int32 = v49.Length
    let v51 : bool = v50 > 0
    let v71 : bool =
        if v51 then
            let v52 : bool = v50 < 64
            if v52 then
                let v53 : string = "-"
                let v54 : bool = v49.StartsWith v53 
                let v57 : bool = v54 = false
                if v57 then
                    let v58 : bool = v49.EndsWith v53 
                    let v59 : bool = v58 = false
                    if v59 then
                        let v60 : string = $"v45.chars()"
                        let v61 : Mut<_> = Fable.Core.RustInterop.emitRustExpr () v60 
                        let v62 : string = "true; // 1"
                        let v63 : bool = Fable.Core.RustInterop.emitRustExpr () v62 
                        let v64 : string = "let mut v61 = v61;"
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
    let v84 : string = "  fn encode_u64(value: u64) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v84 
    let v85 : string = "    let mut buffer = unsigned_varint::encode::u64_buffer(); //"
    Fable.Core.RustInterop.emitRustExpr () v85 
    let v86 : string = "    unsigned_varint::encode::u64(value, &mut buffer).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v86 
    let v87 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v87 
    let v88 : string = "  fn sha256_hash(content: &[u8]) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v88 
    let v89 : string = "    let mut hasher: sha2::Sha256 = sha2::Digest::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v89 
    let v90 : string = "    sha2::Digest::update(&mut hasher, content); //"
    Fable.Core.RustInterop.emitRustExpr () v90 
    let v91 : string = "    sha2::Digest::finalize(hasher).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v91 
    let v92 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v92 
    let v93 : string = "  let version: u8 = 1; //"
    Fable.Core.RustInterop.emitRustExpr () v93 
    let v94 : string = "  let codec_raw: u64 = 0x55; //"
    Fable.Core.RustInterop.emitRustExpr () v94 
    let v95 : string = "  let codec_bytes = encode_u64(codec_raw); //"
    Fable.Core.RustInterop.emitRustExpr () v95 
    let v96 : string = "  let hash_result = sha256_hash(&content); //"
    Fable.Core.RustInterop.emitRustExpr () v96 
    let v97 : string = "  let multihash = std::iter::once(0x12) //"
    Fable.Core.RustInterop.emitRustExpr () v97 
    let v98 : string = "    .chain(std::iter::once(32)) //"
    Fable.Core.RustInterop.emitRustExpr () v98 
    let v99 : string = "    .chain(hash_result.into_iter()) //"
    Fable.Core.RustInterop.emitRustExpr () v99 
    let v100 : string = "    .collect(); //"
    Fable.Core.RustInterop.emitRustExpr () v100 
    let v101 : string = "  let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //"
    Fable.Core.RustInterop.emitRustExpr () v101 
    let v102 : string = "  multibase::encode(multibase::Base::Base32Lower, &cid_bytes) //"
    Fable.Core.RustInterop.emitRustExpr () v102 
    let v103 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v103 
    let v104 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v104 
    let v105 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 1uy"
    let v106 : bool = Fable.Core.RustInterop.emitRustExpr () v105 
    let v107 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 3uy / n: 1uy"
    let v108 : bool = Fable.Core.RustInterop.emitRustExpr () v107 
    let v109 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v109 
    let v110 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v110 
    let v111 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v111 
    let v112 : string = "pub fn generate_cid_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v112 
    let v113 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v113 
    let v114 : string = "  #[serializer(borsh)] content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v114 
    let v115 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v115 
    let v116 : string = "  self.generate_cid(content) //"
    Fable.Core.RustInterop.emitRustExpr () v116 
    let v117 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v117 
    let v118 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v118 
    let v119 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 4uy / n: 1uy"
    let v120 : bool = Fable.Core.RustInterop.emitRustExpr () v119 
    let v121 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 4uy / n: 1uy"
    let v122 : bool = Fable.Core.RustInterop.emitRustExpr () v121 
    let v123 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v123 
    let v124 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v124 
    let v125 : string = "pub fn claim_alias( //"
    Fable.Core.RustInterop.emitRustExpr () v125 
    let v126 : string = "  &mut self, //"
    Fable.Core.RustInterop.emitRustExpr () v126 
    let v127 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v127 
    let v128 : string = ") { //"
    Fable.Core.RustInterop.emitRustExpr () v128 
    let v129 : string = $"&mut self.state.2"
    let v130 : Ref<Mut<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : string = $"&mut self.state.1"
    let v132 : Ref<Mut<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>>> = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = "  let account_id = near_sdk::env::signer_account_id(); //"
    Fable.Core.RustInterop.emitRustExpr () v133 
    let v134 : string = "  let timestamp = near_sdk::env::block_timestamp(); //"
    Fable.Core.RustInterop.emitRustExpr () v134 
    let v135 : string = "  near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v135 
    let v136 : string = "    \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v136 
    let v137 : string = "    format!( //"
    Fable.Core.RustInterop.emitRustExpr () v137 
    let v138 : string = "      \"claim_alias "
    Fable.Core.RustInterop.emitRustExpr () v138 
    let v139 : string = "            alias: {alias:#?} "
    Fable.Core.RustInterop.emitRustExpr () v139 
    let v140 : string = "            account_id: {account_id:#?} "
    Fable.Core.RustInterop.emitRustExpr () v140 
    let v141 : string = "            timestamp: {timestamp:#?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v141 
    let v142 : string = "    ) //"
    Fable.Core.RustInterop.emitRustExpr () v142 
    let v143 : string = "  ); //"
    Fable.Core.RustInterop.emitRustExpr () v143 
    let v144 : string = "  if !Self::is_valid_alias(&alias) { //"
    Fable.Core.RustInterop.emitRustExpr () v144 
    let v145 : string = "    near_sdk::env::panic_str(\"Invalid alias\"); //"
    Fable.Core.RustInterop.emitRustExpr () v145 
    let v146 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v146 
    let v147 : string = "  if let Some(previous_alias) = v130.get(&account_id) { //"
    Fable.Core.RustInterop.emitRustExpr () v147 
    let v148 : string = "    if *previous_alias == alias { //"
    Fable.Core.RustInterop.emitRustExpr () v148 
    let v149 : string = "      near_sdk::log!(\"{}\", \"Alias already claimed\"); //"
    Fable.Core.RustInterop.emitRustExpr () v149 
    let v150 : string = "      return; //"
    Fable.Core.RustInterop.emitRustExpr () v150 
    let v151 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v151 
    let v152 : string = "    v132 //"
    Fable.Core.RustInterop.emitRustExpr () v152 
    let v153 : string = "      .get_mut(previous_alias) //"
    Fable.Core.RustInterop.emitRustExpr () v153 
    let v154 : string = "      .unwrap() //"
    Fable.Core.RustInterop.emitRustExpr () v154 
    let v155 : string = "      .remove(&account_id); //"
    Fable.Core.RustInterop.emitRustExpr () v155 
    let v156 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v156 
    let v157 : string = "  v130.insert(account_id.clone(), alias.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v157 
    let v158 : string = "  let new_alias_account_map = match v132.get(&alias) { //"
    Fable.Core.RustInterop.emitRustExpr () v158 
    let v159 : string = "    None => { //"
    Fable.Core.RustInterop.emitRustExpr () v159 
    let v160 : string = "      let mut new_map = std::collections::HashMap::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v160 
    let v161 : string = "      new_map.insert(account_id, (timestamp, 0u32)); //"
    Fable.Core.RustInterop.emitRustExpr () v161 
    let v162 : string = "      new_map //"
    Fable.Core.RustInterop.emitRustExpr () v162 
    let v163 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v163 
    let v164 : string = "    Some(accounts) => { //"
    Fable.Core.RustInterop.emitRustExpr () v164 
    let v165 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
    Fable.Core.RustInterop.emitRustExpr () v165 
    let v166 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
    Fable.Core.RustInterop.emitRustExpr () v166 
    let v167 : string = "      let mut new_map = accounts_vec //"
    Fable.Core.RustInterop.emitRustExpr () v167 
    let v168 : string = "        .iter() //"
    Fable.Core.RustInterop.emitRustExpr () v168 
    let v169 : string = "        .enumerate() //"
    Fable.Core.RustInterop.emitRustExpr () v169 
    let v170 : string = "        .map(|(i, (account_id, (timestamp, _)))| { //"
    Fable.Core.RustInterop.emitRustExpr () v170 
    let v171 : string = "          ((*account_id).clone(), (*timestamp, i as u32)) //"
    Fable.Core.RustInterop.emitRustExpr () v171 
    let v172 : string = "        }) //"
    Fable.Core.RustInterop.emitRustExpr () v172 
    let v173 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
    Fable.Core.RustInterop.emitRustExpr () v173 
    let v174 : string = "      new_map.insert(account_id, (timestamp, accounts_vec.len() as u32)); //"
    Fable.Core.RustInterop.emitRustExpr () v174 
    let v175 : string = "      new_map //"
    Fable.Core.RustInterop.emitRustExpr () v175 
    let v176 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v176 
    let v177 : string = "  }; //"
    Fable.Core.RustInterop.emitRustExpr () v177 
    let v178 : string = "  v132.insert(alias, new_alias_account_map); //"
    Fable.Core.RustInterop.emitRustExpr () v178 
    let v179 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v179 
    let v180 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v180 
    let v181 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v181 
    let v182 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 5uy / n: 2uy"
    let v183 : bool = Fable.Core.RustInterop.emitRustExpr () v182 
    let v184 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 5uy / n: 2uy"
    let v185 : bool = Fable.Core.RustInterop.emitRustExpr () v184 
    let v186 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v186 
    let v187 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v187 
    let v188 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v188 
    let v189 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v189 
    let v190 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v190 
    let v191 : string = ") -> Option<(String, (u64, u32))> { //"
    Fable.Core.RustInterop.emitRustExpr () v191 
    let v192 : string = $"&self.state.2"
    let v193 : Ref<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v192 
    let v194 : string = $"&self.state.1"
    let v195 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v194 
    let v196 : string = "  near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v196 
    let v197 : string = "    \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v197 
    let v198 : string = "    format!(\"get_account_info / account_id: {account_id:#?}\") //"
    Fable.Core.RustInterop.emitRustExpr () v198 
    let v199 : string = "  ); //"
    Fable.Core.RustInterop.emitRustExpr () v199 
    let v200 : string = "  v193.get(&account_id).and_then(|alias| { //"
    Fable.Core.RustInterop.emitRustExpr () v200 
    let v201 : string = "    v195 //"
    Fable.Core.RustInterop.emitRustExpr () v201 
    let v202 : string = "      .get(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v202 
    let v203 : string = "      .map(|accounts| (alias.clone(), *accounts.get(&account_id).unwrap())) //"
    Fable.Core.RustInterop.emitRustExpr () v203 
    let v204 : string = "  }) //"
    Fable.Core.RustInterop.emitRustExpr () v204 
    let v205 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v205 
    let v206 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v206 
    let v207 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v207 
    let v208 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 7uy / n: 2uy"
    let v209 : bool = Fable.Core.RustInterop.emitRustExpr () v208 
    let v210 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 7uy / n: 2uy"
    let v211 : bool = Fable.Core.RustInterop.emitRustExpr () v210 
    let v212 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v212 
    let v213 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v213 
    let v214 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v214 
    let v215 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v215 
    let v216 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v216 
    let v217 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v217 
    let v218 : string = $"&self.state.1"
    let v219 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v218 
    let v220 : string = "  near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v220 
    let v221 : string = "    \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v221 
    let v222 : string = "    format!(\"get_alias_map / alias: {alias:#?}\") //"
    Fable.Core.RustInterop.emitRustExpr () v222 
    let v223 : string = "  ); //"
    Fable.Core.RustInterop.emitRustExpr () v223 
    let v224 : string = "  v219.get(&alias).cloned() //"
    Fable.Core.RustInterop.emitRustExpr () v224 
    let v225 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v225 
    let v226 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v226 
    let v227 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v227 
    let v228 : string = "true; // ??? / i: 7uy / i': 1uy / acc: 9uy / n: 2uy"
    let v229 : bool = Fable.Core.RustInterop.emitRustExpr () v228 
    let v230 : string = "true; */ // ???? / i: 7uy / i': 2uy / acc: 9uy / n: 2uy"
    let v231 : bool = Fable.Core.RustInterop.emitRustExpr () v230 
    let v232 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v232 
    let v233 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v233 
    let v234 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v234 
    let v235 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v235 
    let v236 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v236 
    let v237 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v237 
    let v238 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v238 
    let v239 : string = "  self.get_alias_map(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v239 
    let v240 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v240 
    let v241 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v241 
    let v242 : string = "true; // ??? / i: 8uy / i': 1uy / acc: 11uy / n: 1uy"
    let v243 : bool = Fable.Core.RustInterop.emitRustExpr () v242 
    let v244 : string = "true; */ // ???? / i: 8uy / i': 2uy / acc: 11uy / n: 1uy"
    let v245 : bool = Fable.Core.RustInterop.emitRustExpr () v244 
    let v246 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v246 
    let v247 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v247 
    let v248 : string = "true; { (); // ?? / i': 1uy / n: 12uy"
    let v249 : bool = Fable.Core.RustInterop.emitRustExpr () v248 
    let v250 : string = "true; { (); // ?? / i': 2uy / n: 12uy"
    let v251 : bool = Fable.Core.RustInterop.emitRustExpr () v250 
    let v252 : string = "true; { (); // ?? / i': 3uy / n: 12uy"
    let v253 : bool = Fable.Core.RustInterop.emitRustExpr () v252 
    let v254 : string = "true; { (); // ?? / i': 4uy / n: 12uy"
    let v255 : bool = Fable.Core.RustInterop.emitRustExpr () v254 
    let v256 : string = "true; { (); // ?? / i': 5uy / n: 12uy"
    let v257 : bool = Fable.Core.RustInterop.emitRustExpr () v256 
    let v258 : string = "true; { (); // ?? / i': 6uy / n: 12uy"
    let v259 : bool = Fable.Core.RustInterop.emitRustExpr () v258 
    let v260 : string = "true; { (); // ?? / i': 7uy / n: 12uy"
    let v261 : bool = Fable.Core.RustInterop.emitRustExpr () v260 
    let v262 : string = "true; { (); // ?? / i': 8uy / n: 12uy"
    let v263 : bool = Fable.Core.RustInterop.emitRustExpr () v262 
    let v264 : string = "true; { (); // ?? / i': 9uy / n: 12uy"
    let v265 : bool = Fable.Core.RustInterop.emitRustExpr () v264 
    let v266 : string = "true; { (); // ?? / i': 10uy / n: 12uy"
    let v267 : bool = Fable.Core.RustInterop.emitRustExpr () v266 
    let v268 : string = "true; { (); // ?? / i': 11uy / n: 12uy"
    let v269 : bool = Fable.Core.RustInterop.emitRustExpr () v268 
    let v270 : string = "true; { (); // ?? / i': 12uy / n: 12uy"
    let v271 : bool = Fable.Core.RustInterop.emitRustExpr () v270 
    let v272 : string = "true; { { (); // ? / i': 13uy / n: 12uy"
    let v273 : bool = Fable.Core.RustInterop.emitRustExpr () v272 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
