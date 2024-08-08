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
    let v8 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v8 
    let v9 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v9 
    let v10 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v11 
    let v12 : string = "pub fn new() -> Self { //"
    Fable.Core.RustInterop.emitRustExpr () v12 
    let v13 : string = "  Self { //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "pub fn generate_cid_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v17 
    let v18 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v18 
    let v19 : string = "  #[serializer(borsh)] content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v19 
    let v20 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v20 
    let v21 : string = "\"\".to_string() //"
    Fable.Core.RustInterop.emitRustExpr () v21 
    let v22 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "pub fn claim_alias( //"
    Fable.Core.RustInterop.emitRustExpr () v23 
    let v24 : string = "  &mut self, //"
    Fable.Core.RustInterop.emitRustExpr () v24 
    let v25 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v25 
    let v26 : string = ") { //"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v27 
    let v28 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v28 
    let v29 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v29 
    let v30 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = ") -> Option<(String, (u64, u32))> { //"
    Fable.Core.RustInterop.emitRustExpr () v31 
    let v32 : string = "None //"
    Fable.Core.RustInterop.emitRustExpr () v32 
    let v33 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v33 
    let v34 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v35 
    let v36 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v36 
    let v37 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v37 
    let v38 : string = "None //"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v39 
    let v40 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v40 
    let v41 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v41 
    let v42 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v43 
    let v44 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v44 
    let v45 : string = "None //"
    Fable.Core.RustInterop.emitRustExpr () v45 
    let v46 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v47 
    let v48 : string = "fn _main() { //"
    Fable.Core.RustInterop.emitRustExpr () v48 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
