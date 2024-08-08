#![allow(dead_code,)]
#![allow(non_camel_case_types,)]
#![allow(non_snake_case,)]
#![allow(non_upper_case_globals,)]
#![allow(unreachable_code,)]
#![allow(unused_attributes,)]
#![allow(unused_imports,)]
#![allow(unused_macros,)]
#![allow(unused_parens,)]
#![allow(unused_variables,)]
mod module_31a2fc18 {
    pub mod Chat_contract {
        use super::*;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Native_::on_startup;
        pub fn closure0(unitVar: (), unitVar_1: ()) {
            } //;
            #[near_sdk::near_bindgen] //;
            #[derive( //;
              near_sdk::PanicOnDefault, //;
              borsh::BorshDeserialize, //;
              borsh::BorshSerialize, //;
            )] //;
            pub struct State { //;
            } //;
            #[near_sdk::near_bindgen] //;
            impl State { //;
            #[init] //;
            pub fn new() -> Self { //;
              Self { //;
              } //;
            } //;
            #[result_serializer(borsh)] //;
            pub fn generate_cid_borsh( //;
              &self, //;
              #[serializer(borsh)] content: Vec<u8>, //;
            ) -> String { //;
            "".to_string() //;
            } //;
            pub fn claim_alias( //;
              &mut self, //;
              alias: String, //;
            ) { //;
            } //;
            pub fn get_account_info( //;
              &self, //;
              account_id: near_sdk::AccountId, //;
            ) -> Option<(String, (u64, u32))> { //;
            None //;
            } //;
            pub fn get_alias_map( //;
              &self, //;
              alias: String, //;
            ) -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //;
            None //;
            } //;
            #[result_serializer(borsh)] //;
            pub fn get_alias_map_borsh( //;
              &self, //;
              #[serializer(borsh)] alias: String, //;
            ) -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //;
            None //;
            } //;
            } //;
            fn _main() { //;
            ()
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(||
                               Func0::new(move ||
                                              Chat_contract::closure0((),
                                                                      ()))).clone()
        }
        on_startup!(());
    }
}
pub use module_31a2fc18::*;
#[path = "../../lib/fsharp/Common_contract.rs"]
mod module_ad43931;
pub use module_ad43931::*;
#[path = "../../lib/spiral/async__contract.rs"]
mod module_67c461a2;
pub use module_67c461a2::*;
#[path = "../../lib/spiral/common_contract.rs"]
mod module_181b15d6;
pub use module_181b15d6::*;
#[path = "../../lib/spiral/crypto_contract.rs"]
mod module_90d9c778;
pub use module_90d9c778::*;
#[path = "../../lib/spiral/date_time_contract.rs"]
mod module_e43a8385;
pub use module_e43a8385::*;
#[path = "../../lib/spiral/file_system_contract.rs"]
mod module_a7db9b47;
pub use module_a7db9b47::*;
#[path = "../../lib/spiral/lib_contract.rs"]
mod module_98e448fc;
pub use module_98e448fc::*;
#[path = "../../lib/spiral/networking_contract.rs"]
mod module_268024e5;
pub use module_268024e5::*;
#[path = "../../lib/spiral/platform_contract.rs"]
mod module_7d8ad484;
pub use module_7d8ad484::*;
#[path = "../../lib/spiral/runtime_contract.rs"]
mod module_485aae07;
pub use module_485aae07::*;
#[path = "../../lib/spiral/sm_contract.rs"]
mod module_582b4305;
pub use module_582b4305::*;
#[path = "../../lib/spiral/threading_contract.rs"]
mod module_d5afb6f5;
pub use module_d5afb6f5::*;
#[path = "../../lib/spiral/trace_contract.rs"]
mod module_9e77af3a;
pub use module_9e77af3a::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
