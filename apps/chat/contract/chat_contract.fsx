let rec closure0 () () : unit =
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
    let v8 : string = "    version: u32, //"
    Fable.Core.RustInterop.emitRustExpr () v8 
    let v9 : string = "    alias_map: near_sdk::store::LookupMap< //"
    Fable.Core.RustInterop.emitRustExpr () v9 
    let v10 : string = "      String, //"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "      std::collections::HashMap<near_sdk::AccountId, (u64, u32)>, //"
    Fable.Core.RustInterop.emitRustExpr () v11 
    let v12 : string = "    >, //"
    Fable.Core.RustInterop.emitRustExpr () v12 
    let v13 : string = "    account_map: near_sdk::store::LookupMap<near_sdk::AccountId, String>, //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v17 
    let v18 : string = "pub fn new() -> Self { //"
    Fable.Core.RustInterop.emitRustExpr () v18 
    let v19 : string = "  Self { //"
    Fable.Core.RustInterop.emitRustExpr () v19 
    let v20 : string = "    version: 1, //"
    Fable.Core.RustInterop.emitRustExpr () v20 
    let v21 : string = "    alias_map: near_sdk::store::LookupMap::new(b\"l\"), //"
    Fable.Core.RustInterop.emitRustExpr () v21 
    let v22 : string = "    account_map: near_sdk::store::LookupMap::new(b\"c\"), //"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v23 
    let v24 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v24 
    let v25 : string = "fn is_valid_alias(alias: &str) -> bool { //"
    Fable.Core.RustInterop.emitRustExpr () v25 
    let v26 : string = "  alias.len() > 0 //"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "    && alias.len() < 64 //"
    Fable.Core.RustInterop.emitRustExpr () v27 
    let v28 : string = "    && !alias.starts_with('-') //"
    Fable.Core.RustInterop.emitRustExpr () v28 
    let v29 : string = "    && !alias.ends_with('-') //"
    Fable.Core.RustInterop.emitRustExpr () v29 
    let v30 : string = "    && alias.chars().all(|c| c.is_alphanumeric() || c == '-') //"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v31 
    let v32 : string = "pub fn generate_cid( //"
    Fable.Core.RustInterop.emitRustExpr () v32 
    let v33 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v33 
    let v34 : string = "  content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v35 
    let v36 : string = "  fn encode_u64(value: u64) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v36 
    let v37 : string = "    let mut buffer = unsigned_varint::encode::u64_buffer(); //"
    Fable.Core.RustInterop.emitRustExpr () v37 
    let v38 : string = "    unsigned_varint::encode::u64(value, &mut buffer).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v39 
    let v40 : string = "  fn sha256_hash(content: &[u8]) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v40 
    let v41 : string = "    let mut hasher: sha2::Sha256 = sha2::Digest::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v41 
    let v42 : string = "    sha2::Digest::update(&mut hasher, content); //"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "    sha2::Digest::finalize(hasher).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v43 
    let v44 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v44 
    let v45 : string = "  let version: u8 = 1; //"
    Fable.Core.RustInterop.emitRustExpr () v45 
    let v46 : string = "  let codec_raw: u64 = 0x55; //"
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = "  let codec_bytes = encode_u64(codec_raw); //"
    Fable.Core.RustInterop.emitRustExpr () v47 
    let v48 : string = "  let hash_result = sha256_hash(&content); //"
    Fable.Core.RustInterop.emitRustExpr () v48 
    let v49 : string = "  let multihash = std::iter::once(0x12) //"
    Fable.Core.RustInterop.emitRustExpr () v49 
    let v50 : string = "    .chain(std::iter::once(32)) //"
    Fable.Core.RustInterop.emitRustExpr () v50 
    let v51 : string = "    .chain(hash_result.into_iter()) //"
    Fable.Core.RustInterop.emitRustExpr () v51 
    let v52 : string = "    .collect(); //"
    Fable.Core.RustInterop.emitRustExpr () v52 
    let v53 : string = "  let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //"
    Fable.Core.RustInterop.emitRustExpr () v53 
    let v54 : string = "  multibase::encode(multibase::Base::Base32Lower, &cid_bytes) //"
    Fable.Core.RustInterop.emitRustExpr () v54 
    let v55 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v55 
    let v56 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v56 
    let v57 : string = "pub fn generate_cid_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v57 
    let v58 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v58 
    let v59 : string = "  #[serializer(borsh)] content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v59 
    let v60 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v60 
    let v61 : string = "  self.generate_cid(content) //"
    Fable.Core.RustInterop.emitRustExpr () v61 
    let v62 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v62 
    let v63 : string = "pub fn claim_alias( //"
    Fable.Core.RustInterop.emitRustExpr () v63 
    let v64 : string = "  &mut self, //"
    Fable.Core.RustInterop.emitRustExpr () v64 
    let v65 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v65 
    let v66 : string = ") { //"
    Fable.Core.RustInterop.emitRustExpr () v66 
    let v67 : string = "  let account_id = near_sdk::env::signer_account_id(); //"
    Fable.Core.RustInterop.emitRustExpr () v67 
    let v68 : string = "  let timestamp = near_sdk::env::block_timestamp(); //"
    Fable.Core.RustInterop.emitRustExpr () v68 
    let v69 : string = "  near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v69 
    let v70 : string = "    \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v70 
    let v71 : string = "    format!( //"
    Fable.Core.RustInterop.emitRustExpr () v71 
    let v72 : string = "      \"claim_alias "
    Fable.Core.RustInterop.emitRustExpr () v72 
    let v73 : string = "            alias: {alias:#?} "
    Fable.Core.RustInterop.emitRustExpr () v73 
    let v74 : string = "            account_id: {account_id:#?} "
    Fable.Core.RustInterop.emitRustExpr () v74 
    let v75 : string = "            timestamp: {timestamp:#?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v75 
    let v76 : string = "    ) //"
    Fable.Core.RustInterop.emitRustExpr () v76 
    let v77 : string = "  ); //"
    Fable.Core.RustInterop.emitRustExpr () v77 
    let v78 : string = "  if !Self::is_valid_alias(&alias) { //"
    Fable.Core.RustInterop.emitRustExpr () v78 
    let v79 : string = "    near_sdk::env::panic_str(\"Invalid alias\"); //"
    Fable.Core.RustInterop.emitRustExpr () v79 
    let v80 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v80 
    let v81 : string = "  if let Some(previous_alias) = self.account_map.get(&account_id) { //"
    Fable.Core.RustInterop.emitRustExpr () v81 
    let v82 : string = "    if *previous_alias == alias { //"
    Fable.Core.RustInterop.emitRustExpr () v82 
    let v83 : string = "      near_sdk::log!(\"{}\", \"Alias already claimed\"); //"
    Fable.Core.RustInterop.emitRustExpr () v83 
    let v84 : string = "      return; //"
    Fable.Core.RustInterop.emitRustExpr () v84 
    let v85 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v85 
    let v86 : string = "    self.alias_map //"
    Fable.Core.RustInterop.emitRustExpr () v86 
    let v87 : string = "      .get_mut(previous_alias) //"
    Fable.Core.RustInterop.emitRustExpr () v87 
    let v88 : string = "      .unwrap() //"
    Fable.Core.RustInterop.emitRustExpr () v88 
    let v89 : string = "      .remove(&account_id); //"
    Fable.Core.RustInterop.emitRustExpr () v89 
    let v90 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v90 
    let v91 : string = "  self.account_map.insert(account_id.clone(), alias.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v91 
    let v92 : string = "  let new_alias_account_map = match self.alias_map.get(&alias) { //"
    Fable.Core.RustInterop.emitRustExpr () v92 
    let v93 : string = "    None => { //"
    Fable.Core.RustInterop.emitRustExpr () v93 
    let v94 : string = "      let mut new_map = std::collections::HashMap::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v94 
    let v95 : string = "      new_map.insert(account_id, (timestamp, 0u32)); //"
    Fable.Core.RustInterop.emitRustExpr () v95 
    let v96 : string = "      new_map //"
    Fable.Core.RustInterop.emitRustExpr () v96 
    let v97 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v97 
    let v98 : string = "    Some(accounts) => { //"
    Fable.Core.RustInterop.emitRustExpr () v98 
    let v99 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
    Fable.Core.RustInterop.emitRustExpr () v99 
    let v100 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
    Fable.Core.RustInterop.emitRustExpr () v100 
    let v101 : string = "      let mut new_map = accounts_vec //"
    Fable.Core.RustInterop.emitRustExpr () v101 
    let v102 : string = "        .iter() //"
    Fable.Core.RustInterop.emitRustExpr () v102 
    let v103 : string = "        .enumerate() //"
    Fable.Core.RustInterop.emitRustExpr () v103 
    let v104 : string = "        .map(|(i, (account_id, (timestamp, _)))| { //"
    Fable.Core.RustInterop.emitRustExpr () v104 
    let v105 : string = "          ((*account_id).clone(), (*timestamp, i as u32)) //"
    Fable.Core.RustInterop.emitRustExpr () v105 
    let v106 : string = "        }) //"
    Fable.Core.RustInterop.emitRustExpr () v106 
    let v107 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
    Fable.Core.RustInterop.emitRustExpr () v107 
    let v108 : string = "      new_map.insert(account_id, (timestamp, accounts_vec.len() as u32)); //"
    Fable.Core.RustInterop.emitRustExpr () v108 
    let v109 : string = "      new_map //"
    Fable.Core.RustInterop.emitRustExpr () v109 
    let v110 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v110 
    let v111 : string = "  }; //"
    Fable.Core.RustInterop.emitRustExpr () v111 
    let v112 : string = "  self.alias_map.insert(alias, new_alias_account_map); //"
    Fable.Core.RustInterop.emitRustExpr () v112 
    let v113 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v113 
    let v114 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v114 
    let v115 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v115 
    let v116 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v116 
    let v117 : string = ") -> Option<(String, (u64, u32))> { //"
    Fable.Core.RustInterop.emitRustExpr () v117 
    let v118 : string = "  near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v118 
    let v119 : string = "    \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v119 
    let v120 : string = "    format!(\"get_account_info / account_id: {account_id:#?}\") //"
    Fable.Core.RustInterop.emitRustExpr () v120 
    let v121 : string = "); //"
    Fable.Core.RustInterop.emitRustExpr () v121 
    let v122 : string = "  self.account_map.get(&account_id).and_then(|alias| { //"
    Fable.Core.RustInterop.emitRustExpr () v122 
    let v123 : string = "    self.alias_map //"
    Fable.Core.RustInterop.emitRustExpr () v123 
    let v124 : string = "      .get(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v124 
    let v125 : string = "      .map(|accounts| (alias.clone(), *accounts.get(&account_id).unwrap())) //"
    Fable.Core.RustInterop.emitRustExpr () v125 
    let v126 : string = "  }) //"
    Fable.Core.RustInterop.emitRustExpr () v126 
    let v127 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v127 
    let v128 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v128 
    let v129 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v129 
    let v130 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v130 
    let v131 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v131 
    let v132 : string = "  near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v132 
    let v133 : string = "    \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v133 
    let v134 : string = "    format!(\"get_alias_map / alias: {alias:#?}\") //"
    Fable.Core.RustInterop.emitRustExpr () v134 
    let v135 : string = "  ); //"
    Fable.Core.RustInterop.emitRustExpr () v135 
    let v136 : string = "  self.alias_map.get(&alias).cloned() //"
    Fable.Core.RustInterop.emitRustExpr () v136 
    let v137 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v137 
    let v138 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v138 
    let v139 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v139 
    let v140 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v140 
    let v141 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v141 
    let v142 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v142 
    let v143 : string = "  self.get_alias_map(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v143 
    let v144 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v144 
    let v145 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v145 
    let v146 : string = "fn _main() { //"
    Fable.Core.RustInterop.emitRustExpr () v146 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
