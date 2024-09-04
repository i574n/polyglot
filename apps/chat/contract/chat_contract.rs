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
        use fable_library_rust::Native_::defaultOf;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::String_::endsWith;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::startsWith;
        use fable_library_rust::String_::string;
        pub fn closure1(unitVar: (), v0_1: char) -> bool {
            if v0_1.is_alphanumeric() {
                true
            } else {
                v0_1 == '-'
            }
        }
        pub fn closure2(unitVar: (), v0_1: std::string::String) -> bool {
            let v2: string = fable_library_rust::String_::fromString(v0_1);
            let v3: i32 = length(v2.clone());
            if v3 > 0_i32 {
                if v3 < 64_i32 {
                    if startsWith(v2.clone(), string("-"), false) == false {
                        if endsWith(v2.clone(), string("-"), false) == false {
                            let v14: &str = &*v2;
                            let v16 = v14.chars();
                            let v18: bool = true; // 1;
                            let mut v16 = v16;
                            v16.all(|x| {
                                Func1::new(move |v: char| Chat_contract::closure1((), v))(x)
                            })
                        } else {
                            false
                        }
                    } else {
                        false
                    }
                } else {
                    false
                }
            } else {
                false
            }
        }
        pub fn method0() -> Func1<std::string::String, bool> {
            Func1::new(move |v: std::string::String| Chat_contract::closure2((), v))
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {} //;
        #[near_sdk::near_bindgen] //;
        #[derive(
            //;
            near_sdk::PanicOnDefault, //;
            borsh::BorshDeserialize,  //;
            borsh::BorshSerialize,    //;
        )] //;
        pub struct State(
            //;
            /*;
            {
                let v9:
                        */
            (
                u32,
                near_sdk::store::LookupMap<
                    std::string::String,
                    std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                >,
                near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
            ), /* =
                  defaultOf::<()>();
               */
        );
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[init] //;
            pub fn new() -> Self {
                // 1;
                {
                    let v18: bool = true; /*;
                                          let v19: */
                    () /* = defaultOf();
                    let v23: bool = true; */;
                    let v25: string = string("b\"l\"");
                    let v26: &[u8] = b"l";
                    let v28: near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = near_sdk::store::LookupMap::new(v26);
                    let v30: string = string("b\"c\"");
                    let v31: &[u8] = b"c";
                    {
                        let x: (
                            u32,
                            near_sdk::store::LookupMap<
                                std::string::String,
                                std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                            >,
                            near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                        ) = (1_u32, v28, near_sdk::store::LookupMap::new(v31));
                        Self(x) // x
                    }
                } // 2.;
            } // 1.;
        } /* c;
          {
              let v38: bool =
                  true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy;
              let v40: bool =
                  true; */
 // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            fn is_valid_alias(alias: String) -> bool {
                //;
                {
                    let v45: std::string::String = alias;
                    let v47: string = fable_library_rust::String_::fromString(v45);
                    let v48: i32 = length(v47.clone());
                    {
                        let x_1: bool = if v48 > 0_i32 {
                            if v48 < 64_i32 {
                                if startsWith(v47.clone(), string("-"), false) == false {
                                    if endsWith(v47.clone(), string("-"), false) == false {
                                        let v59: &str = &*v47;
                                        let v61 = v59.chars();
                                        let v63: bool = true; // 1;
                                        let mut v61 = v61;
                                        v61.all(|x| {
                                            Func1::new(move |v: char| {
                                                Chat_contract::closure1((), v)
                                            })(x)
                                        })
                                    } else {
                                        false
                                    }
                                } else {
                                    false
                                }
                            } else {
                                false
                            }
                        } else {
                            false
                        };
                        x_1
                    }
                }
            } //;
        } /* c;
          {
              let v75: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy;
              let v77: bool =
                  true; */
 // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_cid(
                //;
                &self,            //;
                content: Vec<u8>, //;
            ) -> String {
                //;
                {
                    let v85: Vec<u8> = content;
                    fn encode_u64(value: u64) -> Vec<u8> {
                        //;
                        let mut buffer = unsigned_varint::encode::u64_buffer(); //;
                        unsigned_varint::encode::u64(value, &mut buffer).to_vec()
                        //;
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
                    let hash_result = sha256_hash(&v85); //;
                    let multihash = std::iter::once(0x12) //;
                        .chain(std::iter::once(32)) //;
                        .chain(hash_result.into_iter()) //;
                        .collect(); //;
                    let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //;
                    let result = multibase::encode(multibase::Base::Base32Lower, &cid_bytes); //;
                    {
                        let x_2: std::string::String = result;
                        x_2
                    }
                }
            } //;
        } /* c;
          {
              let v110: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy;
              let v112: bool =
                  true; */
 // ???? / i: 3uy / i': 2uy / acc: 3uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[result_serializer(borsh)] //;
            pub fn generate_cid_borsh(
                //;
                &self,                                 //;
                #[serializer(borsh)] content: Vec<u8>, //;
            ) -> String {
                //;
                self.generate_cid(content) //;
            } //;
        } /* c;
          {
              let v124: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy;
              let v126: bool =
                  true; */
 // ???? / i: 4uy / i': 2uy / acc: 5uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn claim_alias(
                //;
                &mut self,     //;
                alias: String, //;
            ) {
                //;
                {
                    let v134: &mut (
                        u32,
                        near_sdk::store::LookupMap<
                            std::string::String,
                            std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                        >,
                        near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                    ) = &mut self.0;
                    let v136: std::string::String = alias;
                    let v138: &mut near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &mut v134.2;
                    let v140: &mut near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &mut v134.1;
                    let account_id = near_sdk::env::signer_account_id(); //;
                    let timestamp = near_sdk::env::block_timestamp(); //;
                    near_sdk::log!(
                        //;
                        "{}", //;
                        format!(
                            //;
                            "claim_alias ;
                                                            alias: {v136:#?} ;
                                                            account_id: {account_id:#?} ;
                                                            timestamp: {timestamp:#?}" //;
                        )  //;
                    ); //;
                    {
                        let v152 = Chat_contract::method0();
                        if !v152(v136.clone()) {
                            //;
                            near_sdk::env::panic_str("Invalid alias"); //;
                        } //;
                        if let Some(previous_alias) = v138.get(&account_id) {
                            //;
                            if *previous_alias == v136 {
                                //;
                                near_sdk::log!("{}", "Alias already claimed"); //;
                                return; //;
                            } //;
                            v140 //;
                                .get_mut(previous_alias) //;
                                .unwrap() //;
                                .remove(&account_id); //;
                        } //;
                        v138.insert(account_id.clone(), v136.clone()); //;
                        let new_alias_account_map = match v140.get(&v136) {
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
                        v140.insert(v136, new_alias_account_map); //;
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v193: bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy;
              let v195: bool =
                  true; */
 // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn get_account_info(
                //;
                &self,                           //;
                account_id: near_sdk::AccountId, //;
            ) -> Option<(String, (u64, u32))> {
                //;
                {
                    let v203: &near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &self.0 .2;
                    let v205: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &self.0 .1;
                    near_sdk::log!(
                        //;
                        "{}",                                                      //;
                        format!("get_account_info / account_id: {account_id:#?}")  //;
                    ); //;
                    v203.get(&account_id).and_then(|alias| { //;
                                                                v205 //;
                                                                  .get(alias) //;
                                                                  .map(|accounts| (alias.clone(), *accounts.get(&account_id).unwrap())) //;
                                                              }) //;
                } //;
            } //;
        } /* c;
          {
              let v219:
                      bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 2uy;
              let v221:
                      bool =
                  true; */
 // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn get_alias_map(
                //;
                &self,         //;
                alias: String, //;
            ) -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> {
                //;
                {
                    let v229: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &self.0 .1;
                    near_sdk::log!(
                        //;
                        "{}",                                         //;
                        format!("get_alias_map / alias: {alias:#?}")  //;
                    ); //;
                    v229.get(&alias).cloned() //;
                } //;
            } //;
        } /* c;
          {
              let v239:
                      bool =
                  true; // ??? / i: 7uy / i': 1uy / acc: 11uy / n: 2uy;
              let v241:
                      bool =
                  true; */
 // ???? / i: 7uy / i': 2uy / acc: 11uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[result_serializer(borsh)] //;
            pub fn get_alias_map_borsh(
                //;
                &self,                              //;
                #[serializer(borsh)] alias: String, //;
            ) -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> {
                //;
                self.get_alias_map(alias) //;
            } //;
        } /* c;
          {
              let v253:
                      bool =
                  true; // ??? / i: 8uy / i': 1uy / acc: 13uy / n: 1uy;
              let v255:
                      bool =
                  true; */
 // ???? / i: 8uy / i': 2uy / acc: 13uy / n: 1uy;
        fn _main() //;
        {
            //;
            {
                let v259: bool = true;
                {
                    (); // ?? / i': 1uy / n: 14uy;
                    let v261: bool = true;
                    {
                        (); // ?? / i': 2uy / n: 14uy;
                        let v263: bool = true;
                        {
                            (); // ?? / i': 3uy / n: 14uy;
                            let v265: bool = true;
                            {
                                (); // ?? / i': 4uy / n: 14uy;
                                let v267: bool = true;
                                {
                                    (); // ?? / i': 5uy / n: 14uy;
                                    let v269: bool = true;
                                    {
                                        (); // ?? / i': 6uy / n: 14uy;
                                        let v271: bool = true;
                                        {
                                            (); // ?? / i': 7uy / n: 14uy;
                                            let v273: bool = true;
                                            {
                                                (); // ?? / i': 8uy / n: 14uy;
                                                let v275: bool = true;
                                                {
                                                    (); // ?? / i': 9uy / n: 14uy;
                                                    let v277: bool = true;
                                                    {
                                                        (); // ?? / i': 10uy / n: 14uy;
                                                        let v279: bool = true;
                                                        {
                                                            (); // ?? / i': 11uy / n: 14uy;
                                                            let v281: bool = true;
                                                            {
                                                                (); // ?? / i': 12uy / n: 14uy;
                                                                let v283: bool = true;
                                                                {
                                                                    (); // ?? / i': 13uy / n: 14uy;
                                                                    let v285: bool = true;
                                                                    {
                                                                        (); // ?? / i': 14uy / n: 14uy;
                                                                        let v287: bool = true;
                                                                        {
                                                                            {
                                                                                (); // ? / i': 15uy / n: 14uy;
                                                                                ()
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
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
#[path = "../../../lib/fsharp/Common_contract.rs"]
mod module_ad43931;
pub use module_ad43931::*;
#[path = "../../../lib/spiral/async__contract.rs"]
mod module_67c461a2;
pub use module_67c461a2::*;
#[path = "../../../lib/spiral/common_contract.rs"]
mod module_181b15d6;
pub use module_181b15d6::*;
#[path = "../../../lib/spiral/crypto_contract.rs"]
mod module_90d9c778;
pub use module_90d9c778::*;
#[path = "../../../lib/spiral/date_time_contract.rs"]
mod module_e43a8385;
pub use module_e43a8385::*;
#[path = "../../../lib/spiral/file_system_contract.rs"]
mod module_a7db9b47;
pub use module_a7db9b47::*;
#[path = "../../../lib/spiral/lib_contract.rs"]
mod module_98e448fc;
pub use module_98e448fc::*;
#[path = "../../../lib/spiral/networking_contract.rs"]
mod module_268024e5;
pub use module_268024e5::*;
#[path = "../../../lib/spiral/platform_contract.rs"]
mod module_7d8ad484;
pub use module_7d8ad484::*;
#[path = "../../../lib/spiral/runtime_contract.rs"]
mod module_485aae07;
pub use module_485aae07::*;
#[path = "../../../lib/spiral/sm_contract.rs"]
mod module_582b4305;
pub use module_582b4305::*;
#[path = "../../../lib/spiral/threading_contract.rs"]
mod module_d5afb6f5;
pub use module_d5afb6f5::*;
#[path = "../../../lib/spiral/trace_contract.rs"]
mod module_9e77af3a;
pub use module_9e77af3a::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
