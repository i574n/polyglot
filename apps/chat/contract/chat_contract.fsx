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
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>]
#endif
type std_collections_HashMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_sdk::AccountId")>]
#endif
type near_sdk_AccountId = class end
let rec closure0 () () : unit =
    let v0 : string = "l"
    let v1 : string = "b\"" + v0 + "\""
    let v2 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "near_sdk::store::LookupMap::new(v2)"
    let v4 : near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "c"
    let v6 : string = "b\"" + v5 + "\""
    let v7 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "near_sdk::store::LookupMap::new(v7)"
    let v9 : near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v12 : bool = true
    let mutable _v12 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "format!(\"{:#?}\", $0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (1u, v4, v9) v13 
    v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = "format!(\"{:#?}\", $0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (1u, v4, v9) v15 
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : string = "format!(\"{:#?}\", $0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (1u, v4, v9) v17 
    v18 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
#else
    let v39 : std_string_String = null |> unbox<std_string_String>
    v39 
    #endif
    |> fun x -> _v12 <- Some x
    let v46 : std_string_String = match _v12 with Some x -> x | None -> failwith "base.run_target / _v12=None"
    let v61 : string = $"value: {v46}"
    v61 |> System.Console.WriteLine
    let v68 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v68 
    let v69 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v69 
    let v70 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v70 
    let v71 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v71 
    let v72 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v72 
    let v73 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v73 
    let v74 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v74 
    let v75 : string = "pub struct State { //"
    Fable.Core.RustInterop.emitRustExpr () v75 
    let v76 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v76 
    let v77 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v77 
    let v78 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v78 
    let v79 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v79 
    let v80 : string = "pub fn new() -> Self { //"
    Fable.Core.RustInterop.emitRustExpr () v80 
    let v81 : string = "  Self { //"
    Fable.Core.RustInterop.emitRustExpr () v81 
    let v82 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v82 
    let v83 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v83 
    let v84 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v84 
    let v85 : string = "pub fn generate_cid_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v85 
    let v86 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v86 
    let v87 : string = "  #[serializer(borsh)] content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v87 
    let v88 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v88 
    let v89 : string = "\"\".to_string() //"
    Fable.Core.RustInterop.emitRustExpr () v89 
    let v90 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v90 
    let v91 : string = "pub fn claim_alias( //"
    Fable.Core.RustInterop.emitRustExpr () v91 
    let v92 : string = "  &mut self, //"
    Fable.Core.RustInterop.emitRustExpr () v92 
    let v93 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v93 
    let v94 : string = ") { //"
    Fable.Core.RustInterop.emitRustExpr () v94 
    let v95 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v95 
    let v96 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v96 
    let v97 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v97 
    let v98 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v98 
    let v99 : string = ") -> Option<(String, (u64, u32))> { //"
    Fable.Core.RustInterop.emitRustExpr () v99 
    let v100 : string = "None //"
    Fable.Core.RustInterop.emitRustExpr () v100 
    let v101 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v101 
    let v102 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v102 
    let v103 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v103 
    let v104 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v104 
    let v105 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v105 
    let v106 : string = "None //"
    Fable.Core.RustInterop.emitRustExpr () v106 
    let v107 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v107 
    let v108 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v108 
    let v109 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v109 
    let v110 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v110 
    let v111 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v111 
    let v112 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v112 
    let v113 : string = "None //"
    Fable.Core.RustInterop.emitRustExpr () v113 
    let v114 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v114 
    let v115 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v115 
    let v116 : string = "fn _main() { //"
    Fable.Core.RustInterop.emitRustExpr () v116 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
