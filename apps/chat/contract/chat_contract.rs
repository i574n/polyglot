#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
mod module_31a2fc18 {
    pub mod Chat_contract {
        use super::*;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::OnceInit;
        pub fn closure0(unitVar: (), unitVar_1: ()) {} //;
        #[near_sdk::near_bindgen] //;
        #[derive(
            //;
            near_sdk::PanicOnDefault, //;
            borsh::BorshDeserialize,  //;
            borsh::BorshSerialize,    //;
        )] //;
        pub struct State {
            //;
            version: u32, //;
            alias_map: near_sdk::store::LookupMap<
                //;
                String,                                                     //;
                std::collections::HashMap<near_sdk::AccountId, (u64, u32)>, //;
            >, //;
            account_map: near_sdk::store::LookupMap<near_sdk::AccountId, String>, //;
        } //;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[init] //;
            pub fn new() -> Self {
                //;
                Self {
                    //;
                    version: 1,                                         //;
                    alias_map: near_sdk::store::LookupMap::new(b"l"),   //;
                    account_map: near_sdk::store::LookupMap::new(b"c"), //;
                } //;
            } //;
            fn is_valid_alias(alias: &str) -> bool {
                //;
                alias.len() > 0 //;
                && alias.len() < 64 //;
                && !alias.starts_with('-') //;
                && !alias.ends_with('-') //;
                && alias.chars().all(|c| c.is_alphanumeric() || c == '-') //;
            } //;
            pub fn generate_cid(
                //;
                &self,            //;
                content: Vec<u8>, //;
            ) -> String {
                //;
                fn encode_u64(value: u64) -> Vec<u8> {
                    //;
                    let mut buffer = unsigned_varint::encode::u64_buffer(); //;
                    unsigned_varint::encode::u64(value, &mut buffer).to_vec() //;
                } //;
                fn sha256_hash(content: &[u8]) -> Vec<u8> {
                    //;
                    let mut hasher: sha2::Sha256 = sha2::Digest::new(); //;
                    sha2::Digest::update(&mut hasher, content); //;
                    sha2::Digest::finalize(hasher).to_vec() //;
                } //;
                let version: u8 = 1; //;
                let codec_raw: u64 = 0x55; //;
                let codec_bytes = encode_u64(codec_raw); //;
                let hash_result = sha256_hash(&content); //;
                let multihash = std::iter::once(0x12) //;
                    .chain(std::iter::once(32)) //;
                    .chain(hash_result.into_iter()) //;
                    .collect(); //;
                let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //;
                multibase::encode(multibase::Base::Base32Lower, &cid_bytes) //;
            } //;
            #[result_serializer(borsh)] //;
            pub fn generate_cid_borsh(
                //;
                &self,                                 //;
                #[serializer(borsh)] content: Vec<u8>, //;
            ) -> String {
                //;
                self.generate_cid(content) //;
            } //;
            pub fn claim_alias(
                //;
                &mut self,     //;
                alias: String, //;
            ) {
                //;
                let account_id = near_sdk::env::signer_account_id(); //;
                let timestamp = near_sdk::env::block_timestamp(); //;
                near_sdk::log!(
                    //;
                    "{}", //;
                    format!(
                        //;
                        "claim_alias ;
                        alias: {alias:#?} ;
                        account_id: {account_id:#?} ;
                        timestamp: {timestamp:#?}" //;
                    )  //;
                ); //;
                if !Self::is_valid_alias(&alias) {
                    //;
                    near_sdk::env::panic_str("Invalid alias"); //;
                } //;
                if let Some(previous_alias) = self.account_map.get(&account_id) {
                    //;
                    if *previous_alias == alias {
                        //;
                        near_sdk::log!("{}", "Alias already claimed"); //;
                        return; //;
                    } //;
                    self.alias_map //;
                        .get_mut(previous_alias) //;
                        .unwrap() //;
                        .remove(&account_id); //;
                } //;
                self.account_map.insert(account_id.clone(), alias.clone()); //;
                let new_alias_account_map = match self.alias_map.get(&alias) {
                    //;
                    None => {
                        //;
                        let mut new_map = std::collections::HashMap::new(); //;
                        new_map.insert(account_id, (timestamp, 0u32)); //;
                        new_map //;
                    } //;
                    Some(accounts) => {
                        //;
                        let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //;
                        accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //;
                        let mut new_map = accounts_vec //;
                    .iter() //;
                    .enumerate() //;
                    .map(|(i, (account_id, (timestamp, _)))| { //;
                      ((*account_id).clone(), (*timestamp, i as u32)) //;
                    }) //;
                    .collect::<std::collections::HashMap<_, _>>(); //;
                        new_map.insert(account_id, (timestamp, accounts_vec.len() as u32)); //;
                        new_map //;
                    } //;
                }; //;
                self.alias_map.insert(alias, new_alias_account_map); //;
            } //;
            pub fn get_account_info(
                //;
                &self,                           //;
                account_id: near_sdk::AccountId, //;
            ) -> Option<(String, (u64, u32))> {
                //;
                near_sdk::log!(
                    //;
                    "{}",                                                      //;
                    format!("get_account_info / account_id: {account_id:#?}")  //;
                ); //;
                self.account_map.get(&account_id).and_then(|alias| {
                    //;
                    self.alias_map //;
                  .get(alias) //;
                  .map(|accounts| (alias.clone(), *accounts.get(&account_id).unwrap()))
                    //;
                }) //;
            } //;
            pub fn get_alias_map(
                //;
                &self,         //;
                alias: String, //;
            ) -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> {
                //;
                near_sdk::log!(
                    //;
                    "{}",                                         //;
                    format!("get_alias_map / alias: {alias:#?}")  //;
                ); //;
                self.alias_map.get(&alias).cloned() //;
            } //;
            #[result_serializer(borsh)] //;
            pub fn get_alias_map_borsh(
                //;
                &self,                              //;
                #[serializer(borsh)] alias: String, //;
            ) -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> {
                //;
                self.get_alias_map(alias) //;
            } //;
        } //;
        fn _main() {
            //;
            ()
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Chat_contract::closure0((), ())))
                .clone()
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
