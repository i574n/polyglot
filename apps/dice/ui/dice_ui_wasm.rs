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
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_eef1bd43 {
    pub mod Dice_ui {
        use super::*;
        use fable_library_rust::NativeArray_::count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::defaultOf;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::ofBoolean;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toString;
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0,
            US0_1(web_sys::HtmlElement),
        }
        impl core::fmt::Display for Dice_ui::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize)]
        pub struct Heap0 {
            pub l0: leptos::RwSignal<bool>,
            pub l1: leptos::RwSignal<std::string::String>,
        }
        impl core::fmt::Display for Dice_ui::Heap0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize)]
        pub struct Heap1 {
            pub l0: leptos::RwSignal<std::string::String>,
        }
        impl core::fmt::Display for Dice_ui::Heap1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize, PartialEq)]
        pub struct Heap2 {
            pub l0: leptos::RwSignal<Dice_ui::Heap0>,
            pub l1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            pub l2: leptos::RwSignal<Dice_ui::Heap1>,
        }
        impl core::fmt::Display for Dice_ui::Heap2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US1 {
            US1_0,
            US1_1,
        }
        impl core::fmt::Display for Dice_ui::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US2 {
            US2_0(rexie::Error),
            US2_1(rexie::Rexie),
        }
        impl core::fmt::Display for Dice_ui::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(
            Clone,
            Debug,
            Default,
            serde::Serialize,
            serde::Deserialize,
            borsh::BorshSerialize,
            borsh::BorshDeserialize,
        )]
        pub struct Heap3 {
            pub l0: bool,
            pub l1: std::string::String,
        }
        impl core::fmt::Display for Dice_ui::Heap3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US3 {
            US3_0,
            US3_1(Dice_ui::Heap3),
        }
        impl core::fmt::Display for Dice_ui::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US4 {
            US4_0,
            US4_1(rexie::Rexie),
        }
        impl core::fmt::Display for Dice_ui::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US5 {
            US5_0,
            US5_1(serde_json::Value),
        }
        impl core::fmt::Display for Dice_ui::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(rexie::Error),
            US6_1(Dice_ui::US3),
        }
        impl core::fmt::Display for Dice_ui::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(
            Clone,
            Debug,
            Default,
            serde::Serialize,
            serde::Deserialize,
            borsh::BorshSerialize,
            borsh::BorshDeserialize,
        )]
        pub struct Heap4 {
            pub l0: std::string::String,
        }
        impl core::fmt::Display for Dice_ui::Heap4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0,
            US7_1(Dice_ui::Heap4),
        }
        impl core::fmt::Display for Dice_ui::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(rexie::Error),
            US8_1(Dice_ui::US7),
        }
        impl core::fmt::Display for Dice_ui::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(wasm_bindgen::JsValue),
            US9_1(Option<web_sys::Storage>),
        }
        impl core::fmt::Display for Dice_ui::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0,
            US11_1(web_sys::Storage),
        }
        impl core::fmt::Display for Dice_ui::US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(wasm_bindgen::JsValue),
            US10_1(Dice_ui::US11),
        }
        impl core::fmt::Display for Dice_ui::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0,
            US12_1(Dice_ui::US3),
        }
        impl core::fmt::Display for Dice_ui::US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(wasm_bindgen::JsValue),
            US13_1(Option<std::string::String>),
        }
        impl core::fmt::Display for Dice_ui::US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0,
            US15_1(std::string::String),
        }
        impl core::fmt::Display for Dice_ui::US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US14 {
            US14_0(wasm_bindgen::JsValue),
            US14_1(Dice_ui::US15),
        }
        impl core::fmt::Display for Dice_ui::US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0,
            US16_1(Dice_ui::US15),
        }
        impl core::fmt::Display for Dice_ui::US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0,
            US17_1(Dice_ui::US7),
        }
        impl core::fmt::Display for Dice_ui::US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US18 {
            US18_0(rexie::Error),
            US18_1,
        }
        impl core::fmt::Display for Dice_ui::US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US19 {
            US19_0,
            US19_1(leptos::RwSignal<bool>),
        }
        impl core::fmt::Display for Dice_ui::US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US20 {
            US20_0,
            US20_1(bool),
        }
        impl core::fmt::Display for Dice_ui::US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US21 {
            US21_0,
            US21_1,
            US21_2,
        }
        impl core::fmt::Display for Dice_ui::US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US22 {
            US22_0(std::string::String),
            US22_1(leptos_router::Url),
        }
        impl core::fmt::Display for Dice_ui::US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US24 {
            US24_0(i32, string, u32, string, string),
            US24_1(i32, string, u32, string, string),
        }
        impl core::fmt::Display for Dice_ui::US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US23 {
            US23_0,
            US23_1(Dice_ui::US24),
        }
        impl core::fmt::Display for Dice_ui::US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US27 {
            US27_0,
            US27_1(u8, string),
        }
        impl core::fmt::Display for Dice_ui::US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US29 {
            US29_0,
            US29_1(string),
        }
        impl core::fmt::Display for Dice_ui::US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US30 {
            US30_0,
            US30_1(Array<string>),
        }
        impl core::fmt::Display for Dice_ui::US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US28 {
            US28_0(u8, Dice_ui::US29, Dice_ui::US30, string, string),
            US28_1(string),
            US28_2(string, string, u64, string),
            US28_3(string),
        }
        impl core::fmt::Display for Dice_ui::US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US26 {
            US26_0(u64, u64),
            US26_1(string, bool, u64, string),
            US26_2(
                Dice_ui::US27,
                Array<(
                    Array<Dice_ui::US28>,
                    string,
                    u64,
                    string,
                    string,
                    string,
                    string,
                )>,
            ),
        }
        impl core::fmt::Display for Dice_ui::US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US25 {
            US25_0,
            US25_1(Dice_ui::US26),
        }
        impl core::fmt::Display for Dice_ui::US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub struct Mut0 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Dice_ui::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US31 {
            US31_0,
            US31_1(dice_ui::model::near::backend::DataWrapper),
        }
        impl core::fmt::Display for Dice_ui::US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US32 {
            US32_0,
            US32_1(Vec<std::string::String>),
        }
        impl core::fmt::Display for Dice_ui::US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US33 {
            US33_0,
            US33_1(dice_ui::model::near::backend::TransactionCursor),
        }
        impl core::fmt::Display for Dice_ui::US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0,
            US34_1(dice_ui::model::near::backend::ErrorWrapperEnum),
        }
        impl core::fmt::Display for Dice_ui::US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US35 {
            US35_0(std::string::String),
            US35_1(std::string::String),
        }
        impl core::fmt::Display for Dice_ui::US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn closure1(unitVar: (), v0_1: web_sys::HtmlElement) -> Dice_ui::US0 {
            Dice_ui::US0::US0_1(v0_1)
        }
        pub fn method1() -> string {
            string("")
        }
        pub fn method2(v0_1: string) -> string {
            v0_1
        }
        pub fn method3() -> string {
            string("explorer-backend-mainnet-prod-24ktefolwq-uc.a.run.app")
        }
        pub fn method4(v0_1: Dice_ui::Heap2) -> Dice_ui::Heap2 {
            v0_1
        }
        pub fn method7() -> string {
            string("")
        }
        pub fn method8(v0_1: string) -> string {
            v0_1
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> Dice_ui::US1 {
            Dice_ui::US1::US1_0
        }
        pub fn method10() -> Func0<Dice_ui::US1> {
            Func0::new(move || Dice_ui::closure6((), ()))
        }
        pub fn closure8(unitVar: (), v0_1: rexie::Rexie) -> Dice_ui::US2 {
            Dice_ui::US2::US2_1(v0_1)
        }
        pub fn closure9(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US2 {
            Dice_ui::US2::US2_0(v0_1)
        }
        pub fn method11(v0_1: rexie::Rexie) -> Dice_ui::US2 {
            Dice_ui::US2::US2_1(v0_1)
        }
        pub fn method12(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure7(
            unitVar: (),
            v0_1: Dice_ui::US1,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = rexie::Rexie>>> {
            let __future_init = Box::pin(async {
                //;
                leptos::logging::log!(
                    "{}",
                    &string("state.use_database () / database create_local_resource")
                );
                leptos::logging::log!("{}", &string("state.build_database ()"));
                let __future_init = Box::pin(async {
                    //;
                    {
                        let v7: string =
                    string("Box::pin(rexie::Rexie::builder(\"database\").version(1).add_object_store(rexie::ObjectStore::new(\"store\")).build())");
                        let v8: std::pin::Pin<
                            Box<
                                dyn std::future::Future<
                                    Output = Result<rexie::Rexie, rexie::Error>,
                                >,
                            >,
                        > = Box::pin(
                            rexie::Rexie::builder("database")
                                .version(1)
                                .add_object_store(rexie::ObjectStore::new("store"))
                                .build(),
                        );
                        let v10: Result<rexie::Rexie, rexie::Error> = v8.await;
                        let v13: Dice_ui::US2 = match &v10 {
                            Err(v10_1_0) => Dice_ui::closure9((), v10_1_0.clone()),
                            Ok(v10_0_0) => Dice_ui::closure8((), v10_0_0.clone()),
                        };
                        let v20: Dice_ui::US2 = Dice_ui::method11(match &v13 {
                            Dice_ui::US2::US2_1(v13_1_0) => v13_1_0.clone(),
                            Dice_ui::US2::US2_0(v13_0_0) => {
                                panic!("{}", sprintf!("Result value was Error: {}", v13_0_0),)
                            }
                        });
                        v20
                    }
                });
                {
                    let v23: std::pin::Pin<Box<dyn std::future::Future<Output = Dice_ui::US2>>> =
                        __future_init;
                    let v25: Dice_ui::US2 = v23.await;
                    let v32: rexie::Rexie = Dice_ui::method12(match &v25 {
                        Dice_ui::US2::US2_1(v25_1_0) => v25_1_0.clone(),
                        Dice_ui::US2::US2_0(v25_0_0) => {
                            panic!("{}", sprintf!("Result value was Error: {}", v25_0_0),)
                        }
                    });
                    v32
                }
            });
            {
                {
                    // ;
                    __future_init
                }
            }
        }
        pub fn method14(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> leptos::Resource<Dice_ui::US1, rexie::Rexie> {
            v0_1
        }
        pub fn closure10(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method14(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method13(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure10(v0_1.clone(), ())
            })
        }
        pub fn closure12(unitVar: (), v0_1: rexie::Rexie) -> Dice_ui::US4 {
            Dice_ui::US4::US4_1(v0_1)
        }
        pub fn method15(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure13(unitVar: (), v0_1: serde_json::Value) -> Dice_ui::US5 {
            Dice_ui::US5::US5_1(v0_1)
        }
        pub fn method16(v0_1: serde_json::Value) -> serde_json::Value {
            v0_1
        }
        pub fn method17(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn closure14(unitVar: (), v0_1: Dice_ui::Heap3) -> Dice_ui::US3 {
            Dice_ui::US3::US3_1(v0_1)
        }
        pub fn method18(
            v0_1: Result<Dice_ui::US3, rexie::Error>,
        ) -> Result<Dice_ui::US3, rexie::Error> {
            v0_1
        }
        pub fn closure15(unitVar: (), v0_1: Dice_ui::US3) -> Dice_ui::US6 {
            Dice_ui::US6::US6_1(v0_1)
        }
        pub fn closure16(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US6 {
            Dice_ui::US6::US6_0(v0_1)
        }
        pub fn method19(v0_1: Dice_ui::US3) -> Dice_ui::US3 {
            v0_1
        }
        pub fn closure11(
            unitVar: (),
            v0_1: Option<rexie::Rexie>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Dice_ui::US3>>> {
            let __future_init = Box::pin(async {
                //;
                {
                    let v3: string =
                    append(append(string("state.use_database () / core_state_data create_local_resource / database: "),
                                  sprintf!("{:?}", &v0_1)), string(""));
                    leptos::logging::log!("{}", &v3);
                    {
                        let v7: Dice_ui::US4 = defaultValue(
                            Dice_ui::US4::US4_0,
                            map(
                                Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                                v0_1,
                            ),
                        );
                        let v82: Dice_ui::US3 = Dice_ui::method19(match &v7 {
                            Dice_ui::US4::US4_1(v7_1_0) => {
                                let v10: string = string("state.get_data () / id: core-state-data");
                                leptos::logging::log!("{}", &v10);
                                {
                                    let v12: rexie::Rexie = Dice_ui::method15(v7_1_0.clone());
                                    let __future_init = Box::pin(async {
                                        //;
                                        {
                                            let v15: rexie::Transaction = v12.transaction(
                                                &["store"],
                                                rexie::TransactionMode::ReadOnly,
                                            )?;
                                            let v17: rexie::Store = v15.store("store")?;
                                            let v18: string = string("r#\"core-state-data\"#");
                                            let v19: &str = r#"core-state-data"#;
                                            let v21: &wasm_bindgen::JsValue = &v19.into();
                                            let v23: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = Result<
                                                            wasm_bindgen::JsValue,
                                                            rexie::Error,
                                                        >,
                                                    >,
                                                >,
                                            > = Box::pin(rexie::Store::get(&v17, v21));
                                            let v25: Result<wasm_bindgen::JsValue, rexie::Error> =
                                                v23.await;
                                            let v27: wasm_bindgen::JsValue = v25?;
                                            let v32: Dice_ui::US5 = defaultValue(
                                                Dice_ui::US5::US5_0,
                                                map(
                                                    Func1::new(move |v_1: serde_json::Value| {
                                                        Dice_ui::closure13((), v_1)
                                                    }),
                                                    serde_wasm_bindgen::from_value(v27).unwrap(),
                                                ),
                                            );
                                            let v56: Dice_ui::US6 = match &v32 {
                                                Dice_ui::US5::US5_1(v32_1_0) => {
                                                    let v34: serde_json::Value =
                                                        Dice_ui::method16(v32_1_0.clone());
                                                    let v36: Vec<u8> =
                                                        serde_json::from_value(v34).unwrap();
                                                    let v38: string = append(
                                                        append(
                                                            string("state.get_data () / data: "),
                                                            sprintf!("{:?}", &v36),
                                                        ),
                                                        string(""),
                                                    );
                                                    leptos::logging::log!("{}", &v38);
                                                    {
                                                        let v40: Vec<u8> = Dice_ui::method17(v36);
                                                        let v42: Result<
                                                            Dice_ui::Heap3,
                                                            std::sync::Arc<borsh::io::Error>,
                                                        > = borsh::BorshDeserialize::deserialize(
                                                            &mut v40.as_slice(),
                                                        )
                                                        .map_err(|x| std::sync::Arc::new(x));
                                                        let v45: string = append(
                                                            append(
                                                                string(
                                                                    "state.get_data () / data: ",
                                                                ),
                                                                toString(format!("{:#?}", &v42)),
                                                            ),
                                                            string(""),
                                                        );
                                                        leptos::logging::log!("{}", &v45);
                                                        Dice_ui::US6::US6_1(defaultValue(
                                                            Dice_ui::US3::US3_0,
                                                            map(
                                                                Func1::new(
                                                                    move |v_2: Dice_ui::Heap3| {
                                                                        Dice_ui::closure14((), v_2)
                                                                    },
                                                                ),
                                                                v42.ok(),
                                                            ),
                                                        ))
                                                    }
                                                }
                                                _ => Dice_ui::US6::US6_1(Dice_ui::US3::US3_0),
                                            };
                                            let v63: Result<Dice_ui::US3, rexie::Error> =
                                                Dice_ui::method18(match &v56 {
                                                    Dice_ui::US6::US6_1(v56_1_0) => {
                                                        Ok(v56_1_0.clone())
                                                    }
                                                    Dice_ui::US6::US6_0(v56_0_0) => {
                                                        Err(v56_0_0.clone())
                                                    }
                                                });
                                            v63
                                        }
                                    });
                                    {
                                        // ;
                                        {
                                            let v67: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = Result<Dice_ui::US3, rexie::Error>,
                                                    >,
                                                >,
                                            > = __future_init;
                                            let v69: Result<Dice_ui::US3, rexie::Error> = v67.await;
                                            let v72: Dice_ui::US6 = match &v69 {
                                                Err(v69_1_0) => {
                                                    Dice_ui::closure16((), v69_1_0.clone())
                                                }
                                                Ok(v69_0_0) => {
                                                    Dice_ui::closure15((), v69_0_0.clone())
                                                }
                                            };
                                            match &v72 {
                                                Dice_ui::US6::US6_1(v72_1_0) => v72_1_0.clone(),
                                                Dice_ui::US6::US6_0(v72_0_0) => panic!(
                                                    "{}",
                                                    sprintf!("Result value was Error: {}", v72_0_0),
                                                ),
                                            }
                                        }
                                    }
                                }
                            }
                            _ => Dice_ui::US3::US3_0,
                        });
                        v82
                    }
                }
            });
            {
                {
                    // ;
                    __future_init
                }
            }
        }
        pub fn closure17(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method14(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method20(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure17(v0_1.clone(), ())
            })
        }
        pub fn closure19(unitVar: (), v0_1: Dice_ui::Heap4) -> Dice_ui::US7 {
            Dice_ui::US7::US7_1(v0_1)
        }
        pub fn method21(
            v0_1: Result<Dice_ui::US7, rexie::Error>,
        ) -> Result<Dice_ui::US7, rexie::Error> {
            v0_1
        }
        pub fn closure20(unitVar: (), v0_1: Dice_ui::US7) -> Dice_ui::US8 {
            Dice_ui::US8::US8_1(v0_1)
        }
        pub fn closure21(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US8 {
            Dice_ui::US8::US8_0(v0_1)
        }
        pub fn method22(v0_1: Dice_ui::US7) -> Dice_ui::US7 {
            v0_1
        }
        pub fn closure18(
            unitVar: (),
            v0_1: Option<rexie::Rexie>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Dice_ui::US7>>> {
            let __future_init = Box::pin(async {
                //;
                {
                    let v3: string =
                    append(append(string("state.use_database () / state_data create_local_resource / database: "),
                                  sprintf!("{:?}", &v0_1)), string(""));
                    leptos::logging::log!("{}", &v3);
                    {
                        let v7: Dice_ui::US4 = defaultValue(
                            Dice_ui::US4::US4_0,
                            map(
                                Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                                v0_1,
                            ),
                        );
                        let v82: Dice_ui::US7 = Dice_ui::method22(match &v7 {
                            Dice_ui::US4::US4_1(v7_1_0) => {
                                let v10: string = string("state.get_data () / id: state-data");
                                leptos::logging::log!("{}", &v10);
                                {
                                    let v12: rexie::Rexie = Dice_ui::method15(v7_1_0.clone());
                                    let __future_init = Box::pin(async {
                                        //;
                                        {
                                            let v15: rexie::Transaction = v12.transaction(
                                                &["store"],
                                                rexie::TransactionMode::ReadOnly,
                                            )?;
                                            let v17: rexie::Store = v15.store("store")?;
                                            let v18: string = string("r#\"state-data\"#");
                                            let v19: &str = r#"state-data"#;
                                            let v21: &wasm_bindgen::JsValue = &v19.into();
                                            let v23: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = Result<
                                                            wasm_bindgen::JsValue,
                                                            rexie::Error,
                                                        >,
                                                    >,
                                                >,
                                            > = Box::pin(rexie::Store::get(&v17, v21));
                                            let v25: Result<wasm_bindgen::JsValue, rexie::Error> =
                                                v23.await;
                                            let v27: wasm_bindgen::JsValue = v25?;
                                            let v32: Dice_ui::US5 = defaultValue(
                                                Dice_ui::US5::US5_0,
                                                map(
                                                    Func1::new(move |v_1: serde_json::Value| {
                                                        Dice_ui::closure13((), v_1)
                                                    }),
                                                    serde_wasm_bindgen::from_value(v27).unwrap(),
                                                ),
                                            );
                                            let v56: Dice_ui::US8 = match &v32 {
                                                Dice_ui::US5::US5_1(v32_1_0) => {
                                                    let v34: serde_json::Value =
                                                        Dice_ui::method16(v32_1_0.clone());
                                                    let v36: Vec<u8> =
                                                        serde_json::from_value(v34).unwrap();
                                                    let v38: string = append(
                                                        append(
                                                            string("state.get_data () / data: "),
                                                            sprintf!("{:?}", &v36),
                                                        ),
                                                        string(""),
                                                    );
                                                    leptos::logging::log!("{}", &v38);
                                                    {
                                                        let v40: Vec<u8> = Dice_ui::method17(v36);
                                                        let v42: Result<
                                                            Dice_ui::Heap4,
                                                            std::sync::Arc<borsh::io::Error>,
                                                        > = borsh::BorshDeserialize::deserialize(
                                                            &mut v40.as_slice(),
                                                        )
                                                        .map_err(|x| std::sync::Arc::new(x));
                                                        let v45: string = append(
                                                            append(
                                                                string(
                                                                    "state.get_data () / data: ",
                                                                ),
                                                                toString(format!("{:#?}", &v42)),
                                                            ),
                                                            string(""),
                                                        );
                                                        leptos::logging::log!("{}", &v45);
                                                        Dice_ui::US8::US8_1(defaultValue(
                                                            Dice_ui::US7::US7_0,
                                                            map(
                                                                Func1::new(
                                                                    move |v_2: Dice_ui::Heap4| {
                                                                        Dice_ui::closure19((), v_2)
                                                                    },
                                                                ),
                                                                v42.ok(),
                                                            ),
                                                        ))
                                                    }
                                                }
                                                _ => Dice_ui::US8::US8_1(Dice_ui::US7::US7_0),
                                            };
                                            let v63: Result<Dice_ui::US7, rexie::Error> =
                                                Dice_ui::method21(match &v56 {
                                                    Dice_ui::US8::US8_1(v56_1_0) => {
                                                        Ok(v56_1_0.clone())
                                                    }
                                                    Dice_ui::US8::US8_0(v56_0_0) => {
                                                        Err(v56_0_0.clone())
                                                    }
                                                });
                                            v63
                                        }
                                    });
                                    {
                                        // ;
                                        {
                                            let v67: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = Result<Dice_ui::US7, rexie::Error>,
                                                    >,
                                                >,
                                            > = __future_init;
                                            let v69: Result<Dice_ui::US7, rexie::Error> = v67.await;
                                            let v72: Dice_ui::US8 = match &v69 {
                                                Err(v69_1_0) => {
                                                    Dice_ui::closure21((), v69_1_0.clone())
                                                }
                                                Ok(v69_0_0) => {
                                                    Dice_ui::closure20((), v69_0_0.clone())
                                                }
                                            };
                                            match &v72 {
                                                Dice_ui::US8::US8_1(v72_1_0) => v72_1_0.clone(),
                                                Dice_ui::US8::US8_0(v72_0_0) => panic!(
                                                    "{}",
                                                    sprintf!("Result value was Error: {}", v72_0_0),
                                                ),
                                            }
                                        }
                                    }
                                }
                            }
                            _ => Dice_ui::US7::US7_0,
                        });
                        v82
                    }
                }
            });
            {
                {
                    // ;
                    __future_init
                }
            }
        }
        pub fn method24() -> web_sys::Window {
            leptos::leptos_dom::window()
        }
        pub fn method26(v0_1: web_sys::Window) -> web_sys::Window {
            v0_1
        }
        pub fn method25(
            v0_1: web_sys::Window,
        ) -> Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> {
            let v1: web_sys::Window = Dice_ui::method26(v0_1);
            v1.local_storage()
        }
        pub fn closure23(unitVar: (), v0_1: Option<web_sys::Storage>) -> Dice_ui::US9 {
            Dice_ui::US9::US9_1(v0_1)
        }
        pub fn closure24(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Dice_ui::US9 {
            Dice_ui::US9::US9_0(v0_1)
        }
        pub fn closure25(unitVar: (), v0_1: web_sys::Storage) -> Dice_ui::US11 {
            Dice_ui::US11::US11_1(v0_1)
        }
        pub fn method27(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3> {
            v0_1
        }
        pub fn closure26(unitVar: (), v0_1: Dice_ui::US3) -> Dice_ui::US12 {
            Dice_ui::US12::US12_1(v0_1)
        }
        pub fn method28(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method29() -> string {
            string("core-state-data")
        }
        pub fn closure27(unitVar: (), v0_1: Option<std::string::String>) -> Dice_ui::US13 {
            Dice_ui::US13::US13_1(v0_1)
        }
        pub fn closure28(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Dice_ui::US13 {
            Dice_ui::US13::US13_0(v0_1)
        }
        pub fn method30(v0_1: Option<std::string::String>) -> Option<std::string::String> {
            v0_1
        }
        pub fn closure29(unitVar: (), v0_1: std::string::String) -> Dice_ui::US15 {
            Dice_ui::US15::US15_1(v0_1)
        }
        pub fn method31(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method32(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method33(
            v0_1: leptos::RwSignal<Dice_ui::Heap0>,
        ) -> leptos::RwSignal<Dice_ui::Heap0> {
            v0_1
        }
        pub fn closure30(v0_1: Dice_ui::Heap3, v1: bool) -> bool {
            v0_1.l0
        }
        pub fn method34(v0_1: Dice_ui::Heap3) -> Func1<bool, bool> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice_ui::closure30(v0_1.clone(), v)
            })
        }
        pub fn method35(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure31(v0_1: Dice_ui::Heap3, v1: std::string::String) -> std::string::String {
            v0_1.l1.clone()
        }
        pub fn method36(v0_1: Dice_ui::Heap3) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure31(v0_1.clone(), v)
            })
        }
        pub fn method37(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn closure22(
            v0_1: Dice_ui::Heap2,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3>,
            unitVar: (),
        ) {
            leptos::logging::log!(
                "{}",
                &string("state.use_database () / effect core_state_data / ##1")
            );
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method25(Dice_ui::method24());
                let v8: Dice_ui::US9 = match &v5 {
                    Err(v5_1_0) => Dice_ui::closure24((), v5_1_0.clone()),
                    Ok(v5_0_0) => Dice_ui::closure23((), v5_0_0.clone()),
                };
                let v17: Dice_ui::US10 = match &v8 {
                    Dice_ui::US9::US9_1(v8_1_0) => Dice_ui::US10::US10_1(defaultValue(
                        Dice_ui::US11::US11_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure25((), v_2)),
                            v8_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US9::US9_0(v8_0_0) => Dice_ui::US10::US10_0(v8_0_0.clone()),
                };
                if let Dice_ui::US10::US10_1(v17_1_0) = &v17 {
                    let v18: Dice_ui::US11 = match &v17 {
                        Dice_ui::US10::US10_1(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Dice_ui::US11::US11_1(v18_1_0) = &v18 {
                        let v19: web_sys::Storage = match &v18 {
                            Dice_ui::US11::US11_1(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v20: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3> =
                            Dice_ui::method27(v1);
                        let v25: Dice_ui::US12 = defaultValue(
                            Dice_ui::US12::US12_0,
                            map(
                                Func1::new(move |v_3: Dice_ui::US3| Dice_ui::closure26((), v_3)),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v27: string =
                            append(append(string("state.use_database () / effect core_state_data / ##2 / core_state_data: "),
                                          sprintf!("{:?}", &v25)),
                                   string(""));
                        leptos::logging::log!("{}", &v27);
                        {
                            let v159: Dice_ui::US3 = if let Dice_ui::US12::US12_1(v25_1_0) = &v25 {
                                let v29: Dice_ui::US3 = match &v25 {
                                    Dice_ui::US12::US12_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Dice_ui::US3::US3_1(v29_1_0) = &v29 {
                                    Dice_ui::US3::US3_1(match &v29 {
                                        Dice_ui::US3::US3_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    let v32: web_sys::Storage = Dice_ui::method28(v19.clone());
                                    let v33: string = Dice_ui::method29();
                                    let v35: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v33);
                                    let v37: Result<
                                        Option<std::string::String>,
                                        wasm_bindgen::JsValue,
                                    > = web_sys::Storage::get_item(&v32, v35);
                                    let v40: Dice_ui::US13 = match &v37 {
                                        Err(v37_1_0) => Dice_ui::closure28((), v37_1_0.clone()),
                                        Ok(v37_0_0) => Dice_ui::closure27((), v37_0_0.clone()),
                                    };
                                    let v52: Dice_ui::US14 = match &v40 {
                                        Dice_ui::US13::US13_1(v40_1_0) => {
                                            let v42: Option<std::string::String> =
                                                Dice_ui::method30(v40_1_0.clone());
                                            Dice_ui::US14::US14_1(defaultValue(
                                                Dice_ui::US15::US15_0,
                                                map(
                                                    Func1::new(move |v_6: std::string::String| {
                                                        Dice_ui::closure29((), v_6)
                                                    }),
                                                    serde_json::from_value(v42.into()).unwrap(),
                                                ),
                                            ))
                                        }
                                        Dice_ui::US13::US13_0(v40_0_0) => {
                                            Dice_ui::US14::US14_0(v40_0_0.clone())
                                        }
                                    };
                                    let v58: Dice_ui::US16 = match &v52 {
                                        Dice_ui::US14::US14_1(v52_1_0) => {
                                            Dice_ui::US16::US16_1(v52_1_0.clone())
                                        }
                                        _ => Dice_ui::US16::US16_0,
                                    };
                                    let v65: Dice_ui::US15 =
                                        if let Dice_ui::US16::US16_1(v58_1_0) = &v58 {
                                            let v59: Dice_ui::US15 = match &v58 {
                                                Dice_ui::US16::US16_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if let Dice_ui::US15::US15_1(v59_1_0) = &v59 {
                                                Dice_ui::US15::US15_1(match &v59 {
                                                    Dice_ui::US15::US15_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            } else {
                                                Dice_ui::US15::US15_0
                                            }
                                        } else {
                                            Dice_ui::US15::US15_0
                                        };
                                    let v87: Dice_ui::US12 = match &v65 {
                                        Dice_ui::US15::US15_1(v65_1_0) => {
                                            let v68: std::string::String = Dice_ui::method32(
                                                Dice_ui::method31(v65_1_0.clone()),
                                            );
                                            let v72: string = Dice_ui::method2(Dice_ui::method8(
                                                fable_library_rust::String_::fromString(v68),
                                            ));
                                            let v74: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v72);
                                            let v76: std::string::String = String::from(v74);
                                            let v78: Result<Dice_ui::Heap3, serde_json::Error> =
                                                serde_json::from_str(&v76);
                                            Dice_ui::US12::US12_1(defaultValue(
                                                Dice_ui::US3::US3_0,
                                                map(
                                                    Func1::new(move |v_7: Dice_ui::Heap3| {
                                                        Dice_ui::closure14((), v_7)
                                                    }),
                                                    v78.ok(),
                                                ),
                                            ))
                                        }
                                        _ => Dice_ui::US12::US12_0,
                                    };
                                    if let Dice_ui::US12::US12_1(v87_1_0) = &v87 {
                                        let v88: Dice_ui::US3 = match &v87 {
                                            Dice_ui::US12::US12_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US3::US3_1(v88_1_0) = &v88 {
                                            Dice_ui::US3::US3_1(match &v88 {
                                                Dice_ui::US3::US3_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Dice_ui::US3::US3_0
                                        }
                                    } else {
                                        Dice_ui::US3::US3_0
                                    }
                                }
                            } else {
                                let v96: web_sys::Storage = Dice_ui::method28(v19);
                                let v97: string = Dice_ui::method29();
                                let v99: &str = fable_library_rust::String_::LrcStr::as_str(&v97);
                                let v101: Result<
                                    Option<std::string::String>,
                                    wasm_bindgen::JsValue,
                                > = web_sys::Storage::get_item(&v96, v99);
                                let v104: Dice_ui::US13 = match &v101 {
                                    Err(v101_1_0) => Dice_ui::closure28((), v101_1_0.clone()),
                                    Ok(v101_0_0) => Dice_ui::closure27((), v101_0_0.clone()),
                                };
                                let v116: Dice_ui::US14 = match &v104 {
                                    Dice_ui::US13::US13_1(v104_1_0) => {
                                        let v106: Option<std::string::String> =
                                            Dice_ui::method30(v104_1_0.clone());
                                        Dice_ui::US14::US14_1(defaultValue(
                                            Dice_ui::US15::US15_0,
                                            map(
                                                Func1::new(move |v_10: std::string::String| {
                                                    Dice_ui::closure29((), v_10)
                                                }),
                                                serde_json::from_value(v106.into()).unwrap(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US13::US13_0(v104_0_0) => {
                                        Dice_ui::US14::US14_0(v104_0_0.clone())
                                    }
                                };
                                let v122: Dice_ui::US16 = match &v116 {
                                    Dice_ui::US14::US14_1(v116_1_0) => {
                                        Dice_ui::US16::US16_1(v116_1_0.clone())
                                    }
                                    _ => Dice_ui::US16::US16_0,
                                };
                                let v129: Dice_ui::US15 =
                                    if let Dice_ui::US16::US16_1(v122_1_0) = &v122 {
                                        let v123: Dice_ui::US15 = match &v122 {
                                            Dice_ui::US16::US16_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US15::US15_1(v123_1_0) = &v123 {
                                            Dice_ui::US15::US15_1(match &v123 {
                                                Dice_ui::US15::US15_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Dice_ui::US15::US15_0
                                        }
                                    } else {
                                        Dice_ui::US15::US15_0
                                    };
                                let v151: Dice_ui::US12 = match &v129 {
                                    Dice_ui::US15::US15_1(v129_1_0) => {
                                        let v132: std::string::String =
                                            Dice_ui::method32(Dice_ui::method31(v129_1_0.clone()));
                                        let v136: string = Dice_ui::method2(Dice_ui::method8(
                                            fable_library_rust::String_::fromString(v132),
                                        ));
                                        let v138: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v136);
                                        let v140: std::string::String = String::from(v138);
                                        let v142: Result<Dice_ui::Heap3, serde_json::Error> =
                                            serde_json::from_str(&v140);
                                        Dice_ui::US12::US12_1(defaultValue(
                                            Dice_ui::US3::US3_0,
                                            map(
                                                Func1::new(move |v_11: Dice_ui::Heap3| {
                                                    Dice_ui::closure14((), v_11)
                                                }),
                                                v142.ok(),
                                            ),
                                        ))
                                    }
                                    _ => Dice_ui::US12::US12_0,
                                };
                                if let Dice_ui::US12::US12_1(v151_1_0) = &v151 {
                                    let v152: Dice_ui::US3 = match &v151 {
                                        Dice_ui::US12::US12_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Dice_ui::US3::US3_1(v152_1_0) = &v152 {
                                        Dice_ui::US3::US3_1(match &v152 {
                                            Dice_ui::US3::US3_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    } else {
                                        Dice_ui::US3::US3_0
                                    }
                                } else {
                                    Dice_ui::US3::US3_0
                                }
                            };
                            let v161: string =
                                append(append(string("state.use_database () / effect core_state_data / ##3 / core_state_data: "),
                                              sprintf!("{:?}", &v159)),
                                       string(""));
                            leptos::logging::log!("{}", &v161);
                            if let Dice_ui::US3::US3_1(v159_1_0) = &v159 {
                                let v163: Dice_ui::Heap3 = match &v159 {
                                    Dice_ui::US3::US3_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v164: leptos::RwSignal<Dice_ui::Heap0> = v0_1.l0.clone();
                                let v165: leptos::RwSignal<Dice_ui::Heap0> =
                                    Dice_ui::method33(v164.clone());
                                let v167: Dice_ui::Heap0 =
                                    leptos::SignalGetUntracked::get_untracked(&v165);
                                let v169 = Dice_ui::method34(v163.clone());
                                let v170: leptos::RwSignal<bool> =
                                    Dice_ui::method35(v167.l0.clone());
                                let v171: string =
                                    string("leptos::SignalUpdate::update(&v170, |x| { let result = v169(x.clone()); if result != *x { *x = result } })");
                                leptos::SignalUpdate::update(&v170, |x| {
                                    let result = v169(x.clone());
                                    if result != *x {
                                        *x = result
                                    }
                                });
                                {
                                    let v172: leptos::RwSignal<Dice_ui::Heap0> =
                                        Dice_ui::method33(v164);
                                    let v174: Dice_ui::Heap0 =
                                        leptos::SignalGetUntracked::get_untracked(&v172);
                                    let v176 = Dice_ui::method36(v163);
                                    let v177: leptos::RwSignal<std::string::String> =
                                        Dice_ui::method37(v174.l1.clone());
                                    let v178: string =
                                        string("leptos::SignalUpdate::update(&v177, |x| { let result = v176(x.clone()); if result != *x { *x = result } })");
                                    leptos::SignalUpdate::update(&v177, |x| {
                                        let result = v176(x.clone());
                                        if result != *x {
                                            *x = result
                                        }
                                    });
                                    ()
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn method23(
            v0_1: Dice_ui::Heap2,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure22(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method39(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7> {
            v0_1
        }
        pub fn closure33(unitVar: (), v0_1: Dice_ui::US7) -> Dice_ui::US17 {
            Dice_ui::US17::US17_1(v0_1)
        }
        pub fn method40(
            v0_1: leptos::RwSignal<Dice_ui::Heap1>,
        ) -> leptos::RwSignal<Dice_ui::Heap1> {
            v0_1
        }
        pub fn closure34(v0_1: Dice_ui::Heap4, v1: std::string::String) -> std::string::String {
            v0_1.l0.clone()
        }
        pub fn method41(v0_1: Dice_ui::Heap4) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure34(v0_1.clone(), v)
            })
        }
        pub fn closure32(
            v0_1: Dice_ui::Heap2,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7>,
            unitVar: (),
        ) {
            leptos::logging::log!(
                "{}",
                &string("state.use_database () / effect state_data / ##1")
            );
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method25(Dice_ui::method24());
                let v8: Dice_ui::US9 = match &v5 {
                    Err(v5_1_0) => Dice_ui::closure24((), v5_1_0.clone()),
                    Ok(v5_0_0) => Dice_ui::closure23((), v5_0_0.clone()),
                };
                let v17: Dice_ui::US10 = match &v8 {
                    Dice_ui::US9::US9_1(v8_1_0) => Dice_ui::US10::US10_1(defaultValue(
                        Dice_ui::US11::US11_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure25((), v_2)),
                            v8_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US9::US9_0(v8_0_0) => Dice_ui::US10::US10_0(v8_0_0.clone()),
                };
                if let Dice_ui::US10::US10_1(v17_1_0) = &v17 {
                    if let Dice_ui::US11::US11_1(_) = &match &v17 {
                        Dice_ui::US10::US10_1(x) => x.clone(),
                        _ => unreachable!(),
                    } {
                        let v20: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7> =
                            Dice_ui::method39(v1);
                        let v25: Dice_ui::US17 = defaultValue(
                            Dice_ui::US17::US17_0,
                            map(
                                Func1::new(move |v_3: Dice_ui::US7| Dice_ui::closure33((), v_3)),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v32: Dice_ui::US7 = if let Dice_ui::US17::US17_1(v25_1_0) = &v25 {
                            let v26: Dice_ui::US7 = match &v25 {
                                Dice_ui::US17::US17_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Dice_ui::US7::US7_1(v26_1_0) = &v26 {
                                Dice_ui::US7::US7_1(match &v26 {
                                    Dice_ui::US7::US7_1(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            } else {
                                Dice_ui::US7::US7_0
                            }
                        } else {
                            Dice_ui::US7::US7_0
                        };
                        let v34: string =
                            append(append(string("state.use_database () / effect state_data / ##2 / state_data: "),
                                          sprintf!("{:?}", &v32)),
                                   string(""));
                        leptos::logging::log!("{}", &v34);
                        {
                            let v37: string =
                                append(append(string("state.use_database () / effect state_data / ##3 / state_data: "),
                                              sprintf!("{:?}", &v32)),
                                       string(""));
                            leptos::logging::log!("{}", &v37);
                            if let Dice_ui::US7::US7_1(v32_1_0) = &v32 {
                                let v41: leptos::RwSignal<Dice_ui::Heap1> =
                                    Dice_ui::method40(v0_1.l2.clone());
                                let v43: Dice_ui::Heap1 =
                                    leptos::SignalGetUntracked::get_untracked(&v41);
                                let v45 = Dice_ui::method41(match &v32 {
                                    Dice_ui::US7::US7_1(x) => x.clone(),
                                    _ => unreachable!(),
                                });
                                let v46: leptos::RwSignal<std::string::String> =
                                    Dice_ui::method37(v43.l0.clone());
                                let v47: string =
                                    string("leptos::SignalUpdate::update(&v46, |x| { let result = v45(x.clone()); if result != *x { *x = result } })");
                                leptos::SignalUpdate::update(&v46, |x| {
                                    let result = v45(x.clone());
                                    if result != *x {
                                        *x = result
                                    }
                                });
                                ()
                            }
                        }
                    };
                }
            }
        }
        pub fn method38(
            v0_1: Dice_ui::Heap2,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure32(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method43(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn method44(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> Dice_ui::US18 {
            Dice_ui::US18::US18_1
        }
        pub fn closure37(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US18 {
            Dice_ui::US18::US18_0(v0_1)
        }
        pub fn method45() {
            ();
        }
        pub fn closure35(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            v1: Dice_ui::Heap3,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v3: std::string::String = format!("{:?}", &v1);
            let v4: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method14(v0_1);
            let v9: Dice_ui::US4 = defaultValue(
                Dice_ui::US4::US4_0,
                map(
                    Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                    leptos::SignalGet::get(&v4),
                ),
            );
            let __future_init = Box::pin(async move {
                //;
                match &v9 {
                    Dice_ui::US4::US4_1(v9_1_0) => {
                        let v12: string = append(
                            append(
                                string(
                                    "state.use_database () / set_core_state_data_action / value: ",
                                ),
                                toString(v3),
                            ),
                            string(""),
                        );
                        leptos::logging::log!("{}", &v12);
                        {
                            let v16: string = append(
                                append(
                                    string("state.set_data () / data: "),
                                    toString(format!("{:?}", &v1)),
                                ),
                                string(""),
                            );
                            leptos::logging::log!("{}", &v16);
                            {
                                let v18: rexie::Rexie = Dice_ui::method43(v9_1_0.clone());
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v21: rexie::Transaction = v18.transaction(
                                            &["store"],
                                            rexie::TransactionMode::ReadWrite,
                                        )?;
                                        let v23: rexie::Store = v21.store("store")?;
                                        let mut data = Vec::new();
                                        borsh::BorshSerialize::serialize(&v1, &mut data).unwrap();
                                        {
                                            let v27: Vec<u8> = data;
                                            let v29: wasm_bindgen::JsValue =
                                                serde_wasm_bindgen::to_value(&v27).unwrap();
                                            let v30: string = Dice_ui::method29();
                                            let v32: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v30);
                                            v23.put(&v29, Some(&v32.into())).await?;
                                            v21.done().await?;
                                            {
                                                let v36: Result<(), rexie::Error> =
                                                    Dice_ui::method44(Ok(()));
                                                v36
                                            }
                                        }
                                    }
                                });
                                {
                                    {
                                        {
                                            //;
                                            {
                                                let v39: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<(), rexie::Error>,
                                                        >,
                                                    >,
                                                > = __future_init;
                                                let v41: Result<(), rexie::Error> = v39.await;
                                                let v44: Dice_ui::US18 = match &v41 {
                                                    Err(v41_1_0) => {
                                                        Dice_ui::closure37((), v41_1_0.clone())
                                                    }
                                                    _ => Dice_ui::closure36((), ()),
                                                };
                                                match &v44 {
                                                    Dice_ui::US18::US18_1 => (),
                                                    Dice_ui::US18::US18_0(v44_0_0) => panic!(
                                                        "{}",
                                                        sprintf!(
                                                            "Result value was Error: {}",
                                                            v44_0_0
                                                        ),
                                                    ),
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    _ => {
                        leptos::logging::log!("{}", &string("state.use_database () / set_core_state_data_action / database=None"));
                        ()
                    }
                }
                Dice_ui::method45();
                ()
            });
            // ;
            __future_init
        }
        pub fn method42(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func1<Dice_ui::Heap3, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Dice_ui::Heap3| Dice_ui::closure35(v0_1.clone(), v)
            })
        }
        pub fn method47() -> string {
            string("state-data")
        }
        pub fn closure38(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            v1: Dice_ui::Heap4,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v3: std::string::String = format!("{:?}", &v1);
            let v4: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method14(v0_1);
            let v9: Dice_ui::US4 = defaultValue(
                Dice_ui::US4::US4_0,
                map(
                    Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                    leptos::SignalGet::get(&v4),
                ),
            );
            let __future_init = Box::pin(async move {
                //;
                match &v9 {
                    Dice_ui::US4::US4_1(v9_1_0) => {
                        let v12: string =
                        append(append(string("state.use_database () / set_state_data_action / database=Some(_) / value: "),
                                      toString(v3)), string(""));
                        leptos::logging::log!("{}", &v12);
                        {
                            let v16: string = append(
                                append(
                                    string("state.set_data () / data: "),
                                    toString(format!("{:?}", &v1)),
                                ),
                                string(""),
                            );
                            leptos::logging::log!("{}", &v16);
                            {
                                let v18: rexie::Rexie = Dice_ui::method43(v9_1_0.clone());
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v21: rexie::Transaction = v18.transaction(
                                            &["store"],
                                            rexie::TransactionMode::ReadWrite,
                                        )?;
                                        let v23: rexie::Store = v21.store("store")?;
                                        let mut data = Vec::new();
                                        borsh::BorshSerialize::serialize(&v1, &mut data).unwrap();
                                        {
                                            let v27: Vec<u8> = data;
                                            let v29: wasm_bindgen::JsValue =
                                                serde_wasm_bindgen::to_value(&v27).unwrap();
                                            let v30: string = Dice_ui::method47();
                                            let v32: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v30);
                                            v23.put(&v29, Some(&v32.into())).await?;
                                            v21.done().await?;
                                            {
                                                let v36: Result<(), rexie::Error> =
                                                    Dice_ui::method44(Ok(()));
                                                v36
                                            }
                                        }
                                    }
                                });
                                {
                                    {
                                        {
                                            //;
                                            {
                                                let v39: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<(), rexie::Error>,
                                                        >,
                                                    >,
                                                > = __future_init;
                                                let v41: Result<(), rexie::Error> = v39.await;
                                                let v44: Dice_ui::US18 = match &v41 {
                                                    Err(v41_1_0) => {
                                                        Dice_ui::closure37((), v41_1_0.clone())
                                                    }
                                                    _ => Dice_ui::closure36((), ()),
                                                };
                                                match &v44 {
                                                    Dice_ui::US18::US18_1 => (),
                                                    Dice_ui::US18::US18_0(v44_0_0) => panic!(
                                                        "{}",
                                                        sprintf!(
                                                            "Result value was Error: {}",
                                                            v44_0_0
                                                        ),
                                                    ),
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    _ => {
                        leptos::logging::log!(
                            "{}",
                            &string(
                                "state.use_database () / set_state_data_action / database=None"
                            )
                        );
                        ()
                    }
                }
                Dice_ui::method45();
                ()
            });
            // ;
            __future_init
        }
        pub fn method46(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func1<Dice_ui::Heap4, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Dice_ui::Heap4| Dice_ui::closure38(v0_1.clone(), v)
            })
        }
        pub fn method49(
            v0_1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::RwSignal<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn closure39(
            v0_1: Dice_ui::Heap2,
            unitVar: (),
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> {
            leptos::logging::log!("{}", &string("state.use_database () / loading create_memo"));
            {
                let v4: leptos::RwSignal<
                    std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                > = Dice_ui::method49(v0_1.l1.clone());
                leptos::SignalGetUntracked::get_untracked(&v4)
            }
        }
        pub fn method48(
            v0_1: Dice_ui::Heap2,
        ) -> Func0<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure39(v0_1.clone(), ())
            })
        }
        pub fn method50() -> bool {
            false
        }
        pub fn method52(v0_1: leptos::ReadSignal<bool>) -> leptos::ReadSignal<bool> {
            v0_1
        }
        pub fn method53(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn method54(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method55(
            v0_1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::Memo<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn method56() -> string {
            string("dark_mode_key")
        }
        pub fn method57(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure41(unitVar: (), v0_1: leptos::RwSignal<bool>) -> Dice_ui::US19 {
            Dice_ui::US19::US19_1(v0_1)
        }
        pub fn method58() -> bool {
            true
        }
        pub fn method59(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method60(v0_1: Dice_ui::Heap3) -> Dice_ui::Heap3 {
            v0_1
        }
        pub fn method61(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method62(v0_1: Dice_ui::Heap3) -> Dice_ui::Heap3 {
            v0_1
        }
        pub fn method63(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure40(
            v0_1: Dice_ui::Heap2,
            v1: leptos::Action<Dice_ui::Heap3, ()>,
            v2: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            v3: leptos::WriteSignal<bool>,
            v4: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v5: leptos::ReadSignal<bool> = Dice_ui::method52(v4);
            let v7: bool = leptos::SignalGet::get(&v5);
            let v8: string = append(
                append(
                    string("state.use_database () / effect new_core_state_data / ##1 / loaded: "),
                    ofBoolean(v7),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v8);
            {
                let v10: leptos::RwSignal<Dice_ui::Heap0> = v0_1.l0.clone();
                let v11: leptos::RwSignal<Dice_ui::Heap0> = Dice_ui::method33(v10.clone());
                let v15: leptos::RwSignal<bool> =
                    Dice_ui::method53((leptos::SignalGetUntracked::get_untracked(&v11)).l0.clone());
                let v17: bool = leptos::SignalGet::get(&v15);
                let v18: leptos::RwSignal<Dice_ui::Heap0> = Dice_ui::method33(v10);
                let v22: leptos::RwSignal<std::string::String> =
                    Dice_ui::method54((leptos::SignalGetUntracked::get_untracked(&v18)).l1.clone());
                let v25: Dice_ui::Heap3 = Dice_ui::Heap3 {
                    l0: v17,
                    l1: leptos::SignalGet::get(&v22),
                };
                let v28: string =
                    append(append(string("state.use_database () / effect new_core_state_data / ##2 / new_core_state_data: "),
                                  toString(format!("{:?}", &v25))),
                           string(""));
                leptos::logging::log!("{}", &v28);
                {
                    let v30: leptos::Memo<
                        std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                    > = Dice_ui::method55(v2);
                    let v32: std::collections::HashMap<
                        std::string::String,
                        leptos::RwSignal<bool>,
                    > = v30();
                    let v34: string = Dice_ui::method2(Dice_ui::method56());
                    let v36: &str = fable_library_rust::String_::LrcStr::as_str(&v34);
                    let v39: std::string::String = Dice_ui::method57(String::from(v36));
                    let v44: Dice_ui::US19 = defaultValue(
                        Dice_ui::US19::US19_0,
                        map(
                            Func1::new(move |v: leptos::RwSignal<bool>| Dice_ui::closure41((), v)),
                            std::collections::HashMap::get(&v32, &v39).map(|x| *x),
                        ),
                    );
                    let v52: Dice_ui::US20 = match &v44 {
                        Dice_ui::US19::US19_1(v44_1_0) => {
                            let v46: leptos::RwSignal<bool> = Dice_ui::method53(v44_1_0.clone());
                            Dice_ui::US20::US20_1(leptos::SignalGet::get(&v46))
                        }
                        _ => Dice_ui::US20::US20_0,
                    };
                    let v55: bool = match &v52 {
                        Dice_ui::US20::US20_1(v52_1_0) => v52_1_0.clone(),
                        _ => false,
                    };
                    let v56: string =
                        append(append(string("state.use_database () / effect new_core_state_data / ##3 / dark_mode_loading: "),
                                      ofBoolean(v55)), string(""));
                    leptos::logging::log!("{}", &v56);
                    if v55 == false {
                        if v7 == false {
                            let v60: bool = Dice_ui::method58();
                            let v61: leptos::WriteSignal<bool> = Dice_ui::method59(v3);
                            leptos::SignalSet::set(&v61, v60);
                            ()
                        } else {
                            leptos::logging::log!(
                                "{}",
                                &string("state.use_database () / effect new_core_state_data / ##4")
                            );
                            {
                                let v66: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                                    Dice_ui::method25(Dice_ui::method24());
                                let v69: Dice_ui::US9 = match &v66 {
                                    Err(v66_1_0) => Dice_ui::closure24((), v66_1_0.clone()),
                                    Ok(v66_0_0) => Dice_ui::closure23((), v66_0_0.clone()),
                                };
                                let v78: Dice_ui::US10 = match &v69 {
                                    Dice_ui::US9::US9_1(v69_1_0) => {
                                        Dice_ui::US10::US10_1(defaultValue(
                                            Dice_ui::US11::US11_0,
                                            map(
                                                Func1::new(move |v_3: web_sys::Storage| {
                                                    Dice_ui::closure25((), v_3)
                                                }),
                                                v69_1_0.clone(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US9::US9_0(v69_0_0) => {
                                        Dice_ui::US10::US10_0(v69_0_0.clone())
                                    }
                                };
                                if let Dice_ui::US10::US10_1(v78_1_0) = &v78 {
                                    let v79: Dice_ui::US11 = match &v78 {
                                        Dice_ui::US10::US10_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Dice_ui::US11::US11_1(v79_1_0) = &v79 {
                                        let v81: Dice_ui::Heap3 = Dice_ui::method60(v25.clone());
                                        leptos::Action::dispatch(&v1, v81);
                                        {
                                            let v83: web_sys::Storage =
                                                Dice_ui::method61(match &v79 {
                                                    Dice_ui::US11::US11_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                });
                                            let v84: string = Dice_ui::method29();
                                            let v86: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v84);
                                            let v87: Dice_ui::Heap3 = Dice_ui::method62(v25);
                                            let v90: std::string::String = Dice_ui::method63(
                                                serde_json::json!(v87).to_string(),
                                            );
                                            let v92: &str = v90.as_str();
                                            web_sys::Storage::set(&v83, v86, v92).unwrap();
                                            ()
                                        }
                                    }
                                }
                            }
                        };
                    }
                }
            }
        }
        pub fn method51(
            v0_1: Dice_ui::Heap2,
            v1: leptos::Action<Dice_ui::Heap3, ()>,
            v2: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            v3: leptos::WriteSignal<bool>,
            v4: leptos::ReadSignal<bool>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move || {
                    Dice_ui::closure40(
                        v0_1.clone(),
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method65(v0_1: Dice_ui::Heap4) -> Dice_ui::Heap4 {
            v0_1
        }
        pub fn closure42(
            v0_1: Dice_ui::Heap2,
            v1: leptos::Action<Dice_ui::Heap4, ()>,
            v2: leptos::WriteSignal<bool>,
            v3: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v4: leptos::ReadSignal<bool> = Dice_ui::method52(v3);
            let v6: bool = leptos::SignalGet::get(&v4);
            let v7: string = append(
                append(
                    string("state.use_database () / effect new_state_data / ##1 / loaded: "),
                    ofBoolean(v6),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v7);
            {
                let v10: leptos::RwSignal<Dice_ui::Heap1> = Dice_ui::method40(v0_1.l2.clone());
                let v14: leptos::RwSignal<std::string::String> =
                    Dice_ui::method54((leptos::SignalGetUntracked::get_untracked(&v10)).l0.clone());
                let v17: Dice_ui::Heap4 = Dice_ui::Heap4 {
                    l0: leptos::SignalGet::get(&v14),
                };
                let v20: string =
                    append(append(string("state.use_database () / effect new_state_data / ##2 / new_state_data: "),
                                  toString(format!("{:?}", &v17))),
                           string(""));
                leptos::logging::log!("{}", &v20);
                if v6 == false {
                    let v23: bool = Dice_ui::method58();
                    let v24: leptos::WriteSignal<bool> = Dice_ui::method59(v2);
                    leptos::SignalSet::set(&v24, v23);
                    ()
                } else {
                    leptos::logging::log!(
                        "{}",
                        &string("state.use_database () / effect new_state_data / ##4")
                    );
                    {
                        let v29: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                            Dice_ui::method25(Dice_ui::method24());
                        let v32: Dice_ui::US9 = match &v29 {
                            Err(v29_1_0) => Dice_ui::closure24((), v29_1_0.clone()),
                            Ok(v29_0_0) => Dice_ui::closure23((), v29_0_0.clone()),
                        };
                        let v41: Dice_ui::US10 = match &v32 {
                            Dice_ui::US9::US9_1(v32_1_0) => Dice_ui::US10::US10_1(defaultValue(
                                Dice_ui::US11::US11_0,
                                map(
                                    Func1::new(move |v_2: web_sys::Storage| {
                                        Dice_ui::closure25((), v_2)
                                    }),
                                    v32_1_0.clone(),
                                ),
                            )),
                            Dice_ui::US9::US9_0(v32_0_0) => Dice_ui::US10::US10_0(v32_0_0.clone()),
                        };
                        if let Dice_ui::US10::US10_1(v41_1_0) = &v41 {
                            if let Dice_ui::US11::US11_1(_) = &match &v41 {
                                Dice_ui::US10::US10_1(x) => x.clone(),
                                _ => unreachable!(),
                            } {
                                let v44: Dice_ui::Heap4 = Dice_ui::method65(v17);
                                leptos::Action::dispatch(&v1, v44);
                                ()
                            };
                        }
                    }
                }
            }
        }
        pub fn method64(
            v0_1: Dice_ui::Heap2,
            v1: leptos::Action<Dice_ui::Heap4, ()>,
            v2: leptos::WriteSignal<bool>,
            v3: leptos::ReadSignal<bool>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move || Dice_ui::closure42(v0_1.clone(), v1.clone(), v2.clone(), v3.clone(), ())
            })
        }
        pub fn closure43(v0_1: Dice_ui::Heap2, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<Dice_ui::Heap0> = Dice_ui::method33(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method53((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method66(v0_1: Dice_ui::Heap2) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure43(v0_1.clone(), ())
            })
        }
        pub fn method68(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method69(
            v0_1: leptos::Memo<std::string::String>,
        ) -> leptos::Memo<std::string::String> {
            v0_1
        }
        pub fn method70(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method71() -> Dice_ui::US21 {
            Dice_ui::US21::US21_0
        }
        pub fn method73(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method74(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure46(v0_1: string, v1: std::string::String) -> std::string::String {
            let v3: string = Dice_ui::method2(Dice_ui::method8(v0_1));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            String::from(v5)
        }
        pub fn method75(v0_1: string) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure46(v0_1.clone(), v)
            })
        }
        pub fn closure45(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: Dice_ui::Heap2,
            v4: leptos::WriteSignal<bool>,
            v5: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v6: leptos::ReadSignal<bool> = Dice_ui::method52(v5);
            let v8: bool = leptos::SignalGet::get(&v6);
            let v9: leptos_router::Location = Dice_ui::method73(v0_1);
            let v12: leptos::Memo<std::string::String> = Dice_ui::method69(v9.hash);
            let v14: std::string::String = v12();
            let v15: string = sprintf!("{}{}", &v2, &v14);
            let v16: string = append(
                append(
                    append(
                        append(
                            string("content.render () / effect 1 / new_url_hash: "),
                            v15.clone(),
                        ),
                        string(" / loaded: "),
                    ),
                    ofBoolean(v8),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v16);
            if v8 == false {
                let v19: std::string::String = Dice_ui::method74(v14);
                if v19 == "" {
                    let v23: leptos::RwSignal<Dice_ui::Heap0> = Dice_ui::method33(v3.l0.clone());
                    let v27: leptos::RwSignal<std::string::String> = Dice_ui::method54(
                        (leptos::SignalGetUntracked::get_untracked(&v23)).l1.clone(),
                    );
                    let v30: std::string::String = Dice_ui::method32(leptos::SignalGet::get(&v27));
                    let v32: string = fable_library_rust::String_::fromString(v30);
                    let v33: string = append(
                        append(
                            string("content.render () / effect 1 / url_hash: "),
                            v32.clone(),
                        ),
                        string(""),
                    );
                    leptos::logging::log!("{}", &v33);
                    if contains(v32.clone(), string("#")) {
                        let v37: string = Dice_ui::method2(v32);
                        let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
                        v1(v39, Default::default());
                        ()
                    }
                }
                {
                    let v41: bool = Dice_ui::method58();
                    let v42: leptos::WriteSignal<bool> = Dice_ui::method59(v4);
                    leptos::SignalSet::set(&v42, v41);
                    ()
                }
            } else {
                let v45: leptos::RwSignal<Dice_ui::Heap0> = Dice_ui::method33(v3.l0.clone());
                let v47: Dice_ui::Heap0 = leptos::SignalGetUntracked::get_untracked(&v45);
                let v49 = Dice_ui::method75(v15);
                let v50: leptos::RwSignal<std::string::String> = Dice_ui::method37(v47.l1.clone());
                let v51: string =
                    string("leptos::SignalUpdate::update(&v50, |x| { let result = v49(x.clone()); if result != *x { *x = result } })");
                leptos::SignalUpdate::update(&v50, |x| {
                    let result = v49(x.clone());
                    if result != *x {
                        *x = result
                    }
                });
                ()
            }
        }
        pub fn method72(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: Dice_ui::Heap2,
            v4: leptos::WriteSignal<bool>,
            v5: leptos::ReadSignal<bool>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                move || {
                    Dice_ui::closure45(
                        v0_1.clone(),
                        v1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method77(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method78(v0_1: &str) -> &str {
            v0_1
        }
        pub fn closure48(unitVar: (), v0_1: leptos_router::Url) -> Dice_ui::US22 {
            Dice_ui::US22::US22_1(v0_1)
        }
        pub fn closure49(unitVar: (), v0_1: std::string::String) -> Dice_ui::US22 {
            Dice_ui::US22::US22_0(v0_1)
        }
        pub fn method79() -> string {
            string("/settings")
        }
        pub fn method80(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure50(v0_1: Dice_ui::US21, v1: Dice_ui::US21) -> Dice_ui::US21 {
            v0_1
        }
        pub fn method81(v0_1: Dice_ui::US21) -> Func1<Dice_ui::US21, Dice_ui::US21> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Dice_ui::US21| Dice_ui::closure50(v0_1.clone(), v)
            })
        }
        pub fn method82(
            v0_1: leptos::WriteSignal<Dice_ui::US21>,
        ) -> leptos::WriteSignal<Dice_ui::US21> {
            v0_1
        }
        pub fn closure47(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US21>,
            unitVar: (),
        ) {
            let v2: leptos_router::Location = Dice_ui::method73(v0_1);
            let v5: leptos::Memo<std::string::String> = Dice_ui::method69(v2.hash);
            let v8: std::string::String = Dice_ui::method77(v5());
            let v10: Option<&str> = v8.strip_prefix('#');
            let v12: string = string("r#\"\"#");
            let v13: &str = r#""#;
            let v16: &str = Dice_ui::method78(v10.unwrap_or(v13));
            let v18: Result<leptos_router::Url, std::string::String> =
                leptos_router::Url::try_from(v16);
            let v21: Dice_ui::US22 = match &v18 {
                Err(v18_1_0) => Dice_ui::closure49((), v18_1_0.clone()),
                Ok(v18_0_0) => Dice_ui::closure48((), v18_0_0.clone()),
            };
            let v27: leptos_router::Url = match &v21 {
                Dice_ui::US22::US22_1(v21_1_0) => v21_1_0.clone(),
                Dice_ui::US22::US22_0(v21_0_0) => {
                    panic!("{}", sprintf!("Result value was Error: {}", v21_0_0),)
                }
            };
            let v30: string = append(
                append(
                    string("content.render () / effect 2 / hash_url: "),
                    toString(format!("{:#?}", &v27)),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v30);
            {
                let v33: std::string::String = v27.pathname;
                let v35: string = Dice_ui::method2(Dice_ui::method79());
                let v37: &str = fable_library_rust::String_::LrcStr::as_str(&v35);
                let v39: std::string::String = String::from(v37);
                let v40: std::string::String = Dice_ui::method80(v33);
                let v45: Dice_ui::US21 = if v40.starts_with(&v39) {
                    Dice_ui::US21::US21_2
                } else {
                    Dice_ui::US21::US21_1
                };
                let v48: string = append(
                    append(
                        string("content.render () / effect 2 / new_tab: "),
                        toString(format!("{:#?}", &v45)),
                    ),
                    string(""),
                );
                leptos::logging::log!("{}", &v48);
                {
                    let v50 = Dice_ui::method81(v45);
                    let v51: leptos::WriteSignal<Dice_ui::US21> = Dice_ui::method82(v1);
                    let v52: string =
                        string("leptos::SignalUpdate::update(&v51, |x| { let result = v50(x.clone()); if result != *x { *x = result } })");
                    leptos::SignalUpdate::update(&v51, |x| {
                        let result = v50(x.clone());
                        if result != *x {
                            *x = result
                        }
                    });
                    ()
                }
            }
        }
        pub fn method76(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US21>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure47(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure54(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::ReadSignal<Dice_ui::US21> {
            v0_1
        }
        pub fn method86(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
        ) -> Func0<leptos::ReadSignal<Dice_ui::US21>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure54(v0_1.clone(), ())
            })
        }
        pub fn method88(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
        ) -> leptos::ReadSignal<Dice_ui::US21> {
            v0_1
        }
        pub fn method90() -> string {
            string("0")
        }
        pub fn method91() -> string {
            string("i574n.near")
        }
        pub fn method92(
            v0_1: dice_ui::model::near::backend::InputData,
        ) -> dice_ui::model::near::backend::InputData {
            v0_1
        }
        pub fn method93() -> string {
            string("1")
        }
        pub fn method94() -> string {
            string("2")
        }
        pub fn method95(
            v0_1: Option<dice_ui::model::near::backend::TransactionCursor>,
        ) -> Option<dice_ui::model::near::backend::TransactionCursor> {
            v0_1
        }
        pub fn method96(
            v0_1: Array<(
                std::string::String,
                std::rc::Rc<dice_ui::model::near::backend::InputData>,
            )>,
        ) -> Array<(
            std::string::String,
            std::rc::Rc<dice_ui::model::near::backend::InputData>,
        )> {
            v0_1
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> std::string::String {
            let v1: string = Dice_ui::method2(Dice_ui::method90());
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1);
            let v5: std::string::String = String::from(v3);
            let v7: string = Dice_ui::method2(Dice_ui::method91());
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: dice_ui::model::near::backend::IdInput =
                dice_ui::model::near::backend::IdInput { id: v11 };
            let v16: dice_ui::model::near::backend::InputData =
                Dice_ui::method92(dice_ui::model::near::backend::InputData::IdInput(v13));
            let v18: std::rc::Rc<dice_ui::model::near::backend::InputData> = std::rc::Rc::new(v16);
            let v20: string = Dice_ui::method2(Dice_ui::method93());
            let v22: &str = fable_library_rust::String_::LrcStr::as_str(&v20);
            let v24: std::string::String = String::from(v22);
            let v26: string = Dice_ui::method2(Dice_ui::method91());
            let v28: &str = fable_library_rust::String_::LrcStr::as_str(&v26);
            let v30: std::string::String = String::from(v28);
            let v32: dice_ui::model::near::backend::IdInput =
                dice_ui::model::near::backend::IdInput { id: v30 };
            let v35: dice_ui::model::near::backend::InputData =
                Dice_ui::method92(dice_ui::model::near::backend::InputData::IdInput(v32));
            let v37: std::rc::Rc<dice_ui::model::near::backend::InputData> = std::rc::Rc::new(v35);
            let v39: string = Dice_ui::method2(Dice_ui::method94());
            let v41: &str = fable_library_rust::String_::LrcStr::as_str(&v39);
            let v43: std::string::String = String::from(v41);
            let v45: string = Dice_ui::method2(Dice_ui::method91());
            let v47: &str = fable_library_rust::String_::LrcStr::as_str(&v45);
            let v49: std::string::String = String::from(v47);
            let v51: Option<dice_ui::model::near::backend::TransactionCursor> =
                Dice_ui::method95(None::<dice_ui::model::near::backend::TransactionCursor>);
            let v52: string =
                string("dice_ui::model::near::backend::TransactionListByAccountIdInput { account_id: v49, limit: 10, cursor: v51 }");
            let v53: dice_ui::model::near::backend::TransactionListByAccountIdInput =
                dice_ui::model::near::backend::TransactionListByAccountIdInput {
                    account_id: v49,
                    limit: 10,
                    cursor: v51,
                };
            let v56: dice_ui::model::near::backend::InputData = Dice_ui::method92(
                dice_ui::model::near::backend::InputData::TransactionListByAccountIdInput(v53),
            );
            let v60: Array<(
                std::string::String,
                std::rc::Rc<dice_ui::model::near::backend::InputData>,
            )> = Dice_ui::method96(new_array(&[
                (v5, v18),
                (v24, v37),
                (v43, std::rc::Rc::new(v56)),
            ]));
            let v62: std::collections::HashMap<
                std::string::String,
                std::rc::Rc<dice_ui::model::near::backend::InputData>,
            > = std::collections::HashMap::from_iter(v60.to_vec());
            let v64: Result<std::string::String, serde_json::Error> = serde_json::to_string(&v62);
            let v66: std::string::String = v64.unwrap();
            let v68: js_sys::JsString = js_sys::encode_uri_component(&v66);
            format!("{}", &v68)
        }
        pub fn method89() -> Func0<std::string::String> {
            Func0::new(move || Dice_ui::closure56((), ()))
        }
        pub fn closure57(
            v0_1: Dice_ui::Heap2,
            v1: leptos::Memo<std::string::String>,
            unitVar: (),
        ) -> string {
            let v3: leptos::RwSignal<Dice_ui::Heap1> = Dice_ui::method40(v0_1.l2.clone());
            let v7: leptos::RwSignal<std::string::String> =
                Dice_ui::method54((leptos::SignalGetUntracked::get_untracked(&v3)).l0.clone());
            let v9: std::string::String = leptos::SignalGet::get(&v7);
            let v10: leptos::Memo<std::string::String> = Dice_ui::method69(v1);
            let v12: std::string::String = v10();
            let v13: string =
                append(append(append(append(string("https://"), toString(v9)),
                                     string("/trpc/account.transactionsCount,contract.byId,transaction.listByAccountId?batch=1&input=")),
                              toString(v12)), string(""));
            let v14: string = append(
                append(string("history.render () / url: "), v13.clone()),
                string(""),
            );
            leptos::logging::log!("{}", &v14);
            v13
        }
        pub fn method97(
            v0_1: Dice_ui::Heap2,
            v1: leptos::Memo<std::string::String>,
        ) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure57(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method99(v0_1: leptos::Memo<string>) -> leptos::Memo<string> {
            v0_1
        }
        pub fn closure58(v0_1: leptos::Memo<string>, unitVar: ()) -> string {
            let v1: leptos::Memo<string> = Dice_ui::method99(v0_1);
            v1()
        }
        pub fn method98(v0_1: leptos::Memo<string>) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure58(v0_1.clone(), ())
            })
        }
        pub fn method100(v0_1: string) -> string {
            v0_1
        }
        pub fn method101(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure60(unitVar: (), v0_1: reqwest_wasm::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method102() -> Func1<reqwest_wasm::Error, std::string::String> {
            Func1::new(move |v: reqwest_wasm::Error| Dice_ui::closure60((), v))
        }
        pub fn closure61(unitVar: (), v0_1: serde_json::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method103() -> Func1<serde_json::Error, std::string::String> {
            Func1::new(move |v: serde_json::Error| Dice_ui::closure61((), v))
        }
        pub fn method104(v0_1: i32, v1: Dice_ui::Mut0) -> bool {
            v1.l0.get() < v0_1
        }
        pub fn method105(
            v0_1: std::rc::Rc<dice_ui::model::near::backend::ResultWrapper>,
        ) -> std::rc::Rc<dice_ui::model::near::backend::ResultWrapper> {
            v0_1
        }
        pub fn closure62(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::DataWrapper,
        ) -> Dice_ui::US31 {
            Dice_ui::US31::US31_1(v0_1)
        }
        pub fn method106(
            v0_1: dice_ui::model::near::backend::DataWrapper,
        ) -> dice_ui::model::near::backend::DataWrapper {
            v0_1
        }
        pub fn method107(
            v0_1: dice_ui::model::near::backend::ResultData,
        ) -> dice_ui::model::near::backend::ResultData {
            v0_1
        }
        pub fn method109(
            v0_1: dice_ui::model::near::backend::AccountTransactionsCount,
        ) -> dice_ui::model::near::backend::AccountTransactionsCount {
            v0_1
        }
        pub fn closure63(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::AccountTransactionsCount,
        ) -> (u64, u64) {
            let v1: dice_ui::model::near::backend::AccountTransactionsCount =
                Dice_ui::method109(v0_1);
            (v1.in_transactions_count, v1.out_transactions_count)
        }
        pub fn method108(
        ) -> Func1<dice_ui::model::near::backend::AccountTransactionsCount, (u64, u64)> {
            Func1::new(
                move |v: dice_ui::model::near::backend::AccountTransactionsCount| {
                    Dice_ui::closure63((), v)
                },
            )
        }
        pub fn method111(
            v0_1: dice_ui::model::near::backend::ContractById,
        ) -> dice_ui::model::near::backend::ContractById {
            v0_1
        }
        pub fn closure64(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::ContractById,
        ) -> (string, bool, u64, string) {
            let v1: dice_ui::model::near::backend::ContractById = Dice_ui::method111(v0_1);
            let v4: std::string::String = Dice_ui::method32(v1.code_hash);
            let v6: string = fable_library_rust::String_::fromString(v4);
            let v9: std::string::String = Dice_ui::method32(v1.transaction_hash);
            let v11: string = fable_library_rust::String_::fromString(v9);
            let v13: u64 = v1.timestamp;
            (v6, v1.locked, v13, v11)
        }
        pub fn method110(
        ) -> Func1<dice_ui::model::near::backend::ContractById, (string, bool, u64, string)>
        {
            Func1::new(move |v: dice_ui::model::near::backend::ContractById| {
                Dice_ui::closure64((), v)
            })
        }
        pub fn method113(
            v0_1: dice_ui::model::near::backend::TransactionListByAccountId,
        ) -> dice_ui::model::near::backend::TransactionListByAccountId {
            v0_1
        }
        pub fn method115(
            v0_1: dice_ui::model::near::backend::Transaction,
        ) -> dice_ui::model::near::backend::Transaction {
            v0_1
        }
        pub fn method117(
            v0_1: dice_ui::model::near::backend::TransactionAction,
        ) -> dice_ui::model::near::backend::TransactionAction {
            v0_1
        }
        pub fn method119(
            v0_1: dice_ui::model::near::backend::FunctionCallArgs,
        ) -> dice_ui::model::near::backend::FunctionCallArgs {
            v0_1
        }
        pub fn closure68(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::FunctionCallArgs,
        ) -> (string, string, u64, string) {
            let v1: dice_ui::model::near::backend::FunctionCallArgs = Dice_ui::method119(v0_1);
            let v4: std::string::String = Dice_ui::method32(v1.method_name);
            let v6: string = fable_library_rust::String_::fromString(v4);
            let v9: std::string::String = Dice_ui::method32(v1.args);
            let v11: string = fable_library_rust::String_::fromString(v9);
            let v13: u64 = v1.gas;
            let v16: std::string::String = Dice_ui::method32(v1.deposit);
            (v11, fable_library_rust::String_::fromString(v16), v13, v6)
        }
        pub fn method118(
        ) -> Func1<dice_ui::model::near::backend::FunctionCallArgs, (string, string, u64, string)>
        {
            Func1::new(move |v: dice_ui::model::near::backend::FunctionCallArgs| {
                Dice_ui::closure68((), v)
            })
        }
        pub fn method121(
            v0_1: dice_ui::model::near::backend::AddKeyArgs,
        ) -> dice_ui::model::near::backend::AddKeyArgs {
            v0_1
        }
        pub fn method122(
            v0_1: dice_ui::model::near::backend::AccessKey,
        ) -> dice_ui::model::near::backend::AccessKey {
            v0_1
        }
        pub fn method123(
            v0_1: dice_ui::model::near::backend::Permission,
        ) -> dice_ui::model::near::backend::Permission {
            v0_1
        }
        pub fn method124(v0_1: Dice_ui::US29) -> Dice_ui::US29 {
            v0_1
        }
        pub fn closure70(unitVar: (), v0_1: Vec<std::string::String>) -> Dice_ui::US32 {
            Dice_ui::US32::US32_1(v0_1)
        }
        pub fn method125(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method126(v0_1: Dice_ui::US30) -> Dice_ui::US30 {
            v0_1
        }
        pub fn closure69(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::AddKeyArgs,
        ) -> (u8, Dice_ui::US29, Dice_ui::US30, string, string) {
            let v1: dice_ui::model::near::backend::AddKeyArgs = Dice_ui::method121(v0_1);
            let v4: std::string::String = Dice_ui::method32(v1.public_key);
            let v6: string = fable_library_rust::String_::fromString(v4);
            let v9: dice_ui::model::near::backend::AccessKey = Dice_ui::method122(v1.access_key);
            let v11: u8 = v9.nonce;
            let v14: dice_ui::model::near::backend::Permission = Dice_ui::method123(v9.permission);
            let v17: std::string::String = Dice_ui::method32(v14.permission_type);
            let v19: string = fable_library_rust::String_::fromString(v17);
            let v24: Dice_ui::US15 = defaultValue(
                Dice_ui::US15::US15_0,
                map(
                    Func1::new(move |v: std::string::String| Dice_ui::closure29((), v)),
                    v14.contract_id,
                ),
            );
            let v33: Dice_ui::US29 = Dice_ui::method124(match &v24 {
                Dice_ui::US15::US15_1(v24_1_0) => {
                    let v26: std::string::String = Dice_ui::method32(v24_1_0.clone());
                    Dice_ui::US29::US29_1(fable_library_rust::String_::fromString(v26))
                }
                _ => Dice_ui::US29::US29_0,
            });
            let v38: Dice_ui::US32 = defaultValue(
                Dice_ui::US32::US32_0,
                map(
                    Func1::new(move |v_1: Vec<std::string::String>| Dice_ui::closure70((), v_1)),
                    v14.method_names,
                ),
            );
            (
                v11,
                v33,
                Dice_ui::method126(match &v38 {
                    Dice_ui::US32::US32_1(v38_1_0) => {
                        let v40: Vec<std::string::String> = Dice_ui::method125(v38_1_0.clone());
                        let v42: Array<std::string::String> =
                            fable_library_rust::NativeArray_::array_from(v40);
                        let v43: i32 = count(v42.clone());
                        let v44: Array<string> = new_init(&string(""), v43);
                        let v45: Dice_ui::Mut0 = Dice_ui::Mut0 {
                            l0: MutCell::new(0_i32),
                        };
                        while Dice_ui::method104(v43, v45.clone()) {
                            let v47: i32 = v45.l0.get();
                            let v49: std::string::String = Dice_ui::method32(v42[v47].clone());
                            let v51: string = fable_library_rust::String_::fromString(v49);
                            v44.get_mut()[v47 as usize] = v51;
                            {
                                let v52: i32 = v47 + 1_i32;
                                v45.l0.set(v52);
                                ()
                            }
                        }
                        Dice_ui::US30::US30_1(v44.clone())
                    }
                    _ => Dice_ui::US30::US30_0,
                }),
                v19,
                v6,
            )
        }
        pub fn method120() -> Func1<
            dice_ui::model::near::backend::AddKeyArgs,
            (u8, Dice_ui::US29, Dice_ui::US30, string, string),
        > {
            Func1::new(move |v: dice_ui::model::near::backend::AddKeyArgs| {
                Dice_ui::closure69((), v)
            })
        }
        pub fn method128(
            v0_1: dice_ui::model::near::backend::DeployContractArgs,
        ) -> dice_ui::model::near::backend::DeployContractArgs {
            v0_1
        }
        pub fn closure71(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::DeployContractArgs,
        ) -> string {
            let v1: dice_ui::model::near::backend::DeployContractArgs = Dice_ui::method128(v0_1);
            let v4: std::string::String = Dice_ui::method32(v1.code);
            fable_library_rust::String_::fromString(v4)
        }
        pub fn method127() -> Func1<dice_ui::model::near::backend::DeployContractArgs, string> {
            Func1::new(
                move |v: dice_ui::model::near::backend::DeployContractArgs| {
                    Dice_ui::closure71((), v)
                },
            )
        }
        pub fn method130(
            v0_1: dice_ui::model::near::backend::TransferArgs,
        ) -> dice_ui::model::near::backend::TransferArgs {
            v0_1
        }
        pub fn closure72(unitVar: (), v0_1: dice_ui::model::near::backend::TransferArgs) -> string {
            let v1: dice_ui::model::near::backend::TransferArgs = Dice_ui::method130(v0_1);
            let v4: std::string::String = Dice_ui::method32(v1.deposit);
            fable_library_rust::String_::fromString(v4)
        }
        pub fn method129() -> Func1<dice_ui::model::near::backend::TransferArgs, string> {
            Func1::new(move |v: dice_ui::model::near::backend::TransferArgs| {
                Dice_ui::closure72((), v)
            })
        }
        pub fn closure73(unitVar: (), _arg: (string, string, u64, string)) -> Dice_ui::US28 {
            Dice_ui::US28::US28_2(
                _arg.0.clone(),
                _arg.1.clone(),
                _arg.2.clone(),
                _arg.3.clone(),
            )
        }
        pub fn method131() -> Func1<(string, string, u64, string), Dice_ui::US28> {
            Func1::new(move |arg10_0040: (string, string, u64, string)| {
                Dice_ui::closure73((), arg10_0040)
            })
        }
        pub fn closure74(
            unitVar: (),
            _arg: (u8, Dice_ui::US29, Dice_ui::US30, string, string),
        ) -> Dice_ui::US28 {
            Dice_ui::US28::US28_0(
                _arg.0.clone(),
                _arg.1.clone(),
                _arg.2.clone(),
                _arg.3.clone(),
                _arg.4.clone(),
            )
        }
        pub fn method132(
        ) -> Func1<(u8, Dice_ui::US29, Dice_ui::US30, string, string), Dice_ui::US28> {
            Func1::new(
                move |arg10_0040: (u8, Dice_ui::US29, Dice_ui::US30, string, string)| {
                    Dice_ui::closure74((), arg10_0040)
                },
            )
        }
        pub fn closure75(unitVar: (), v0_1: string) -> Dice_ui::US28 {
            Dice_ui::US28::US28_1(v0_1)
        }
        pub fn method133() -> Func1<string, Dice_ui::US28> {
            Func1::new(move |v: string| Dice_ui::closure75((), v))
        }
        pub fn closure76(unitVar: (), v0_1: string) -> Dice_ui::US28 {
            Dice_ui::US28::US28_3(v0_1)
        }
        pub fn method134() -> Func1<string, Dice_ui::US28> {
            Func1::new(move |v: string| Dice_ui::closure76((), v))
        }
        pub fn closure67(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::TransactionAction,
        ) -> Dice_ui::US28 {
            let v1: dice_ui::model::near::backend::TransactionAction = Dice_ui::method117(v0_1);
            let v2 = Dice_ui::method118();
            let v3 = Dice_ui::method120();
            let v4 = Dice_ui::method127();
            let v5 = Dice_ui::method129();
            let v6 = Dice_ui::method131();
            let v7 = Dice_ui::method132();
            let v8 = Dice_ui::method133();
            let v9 = Dice_ui::method134();
            let v10: string =
                string("match v1 { dice_ui::model::near::backend::TransactionAction::FunctionCall(x) => v6(v2(x)), dice_ui::model::near::backend::TransactionAction::AddKey(x) => v7(v3(x)), dice_ui::model::near::backend::TransactionAction::DeployContract(x) => v8(v4(x)), dice_ui::model::near::backend::TransactionAction::Transfer(x) => v9(v5(x)) }");
            match v1 {
                dice_ui::model::near::backend::TransactionAction::FunctionCall(x) => v6(v2(x)),
                dice_ui::model::near::backend::TransactionAction::AddKey(x) => v7(v3(x)),
                dice_ui::model::near::backend::TransactionAction::DeployContract(x) => v8(v4(x)),
                dice_ui::model::near::backend::TransactionAction::Transfer(x) => v9(v5(x)),
            }
        }
        pub fn method116() -> Func1<dice_ui::model::near::backend::TransactionAction, Dice_ui::US28>
        {
            Func1::new(move |v: dice_ui::model::near::backend::TransactionAction| {
                Dice_ui::closure67((), v)
            })
        }
        pub fn method135(v0_1: Vec<Dice_ui::US28>) -> Vec<Dice_ui::US28> {
            v0_1
        }
        pub fn closure66(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::Transaction,
        ) -> (
            Array<Dice_ui::US28>,
            string,
            u64,
            string,
            string,
            string,
            string,
        ) {
            let v1: dice_ui::model::near::backend::Transaction = Dice_ui::method115(v0_1);
            let v4: std::string::String = Dice_ui::method32(v1.hash.clone());
            let v6: string = fable_library_rust::String_::fromString(v4);
            let v9: std::string::String = Dice_ui::method32(v1.signer_id.clone());
            let v11: string = fable_library_rust::String_::fromString(v9);
            let v14: std::string::String = Dice_ui::method32(v1.receiver_id.clone());
            let v16: string = fable_library_rust::String_::fromString(v14);
            let v19: std::string::String = Dice_ui::method32(v1.block_hash.clone());
            let v21: string = fable_library_rust::String_::fromString(v19);
            let v23: u64 = v1.block_timestamp.clone();
            let v24 = Dice_ui::method116();
            let v27: Vec<Dice_ui::US28> =
                Dice_ui::method135(v1.actions.into_iter().map(|x| v24(x)).collect());
            let v29: Array<Dice_ui::US28> = fable_library_rust::NativeArray_::array_from(v27);
            let v32: std::string::String = Dice_ui::method32(v1.status.clone());
            (
                v29,
                v21,
                v23,
                v6,
                v16,
                v11,
                fable_library_rust::String_::fromString(v32),
            )
        }
        pub fn method114() -> Func1<
            dice_ui::model::near::backend::Transaction,
            (
                Array<Dice_ui::US28>,
                string,
                u64,
                string,
                string,
                string,
                string,
            ),
        > {
            Func1::new(move |v: dice_ui::model::near::backend::Transaction| {
                Dice_ui::closure66((), v)
            })
        }
        pub fn method136(
            v0_1: Vec<(
                Array<Dice_ui::US28>,
                string,
                u64,
                string,
                string,
                string,
                string,
            )>,
        ) -> Vec<(
            Array<Dice_ui::US28>,
            string,
            u64,
            string,
            string,
            string,
            string,
        )> {
            v0_1
        }
        pub fn closure77(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::TransactionCursor,
        ) -> Dice_ui::US33 {
            Dice_ui::US33::US33_1(v0_1)
        }
        pub fn method137(
            v0_1: dice_ui::model::near::backend::TransactionCursor,
        ) -> dice_ui::model::near::backend::TransactionCursor {
            v0_1
        }
        pub fn method138(v0_1: Dice_ui::US27) -> Dice_ui::US27 {
            v0_1
        }
        pub fn closure65(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::TransactionListByAccountId,
        ) -> (
            Dice_ui::US27,
            Array<(
                Array<Dice_ui::US28>,
                string,
                u64,
                string,
                string,
                string,
                string,
            )>,
        ) {
            let v1: dice_ui::model::near::backend::TransactionListByAccountId =
                Dice_ui::method113(v0_1);
            let v2 = Dice_ui::method114();
            let v5: Vec<(
                Array<Dice_ui::US28>,
                string,
                u64,
                string,
                string,
                string,
                string,
            )> = Dice_ui::method136(v1.items.into_iter().map(|x| v2(x)).collect());
            let v7: Array<(
                Array<Dice_ui::US28>,
                string,
                u64,
                string,
                string,
                string,
                string,
            )> = fable_library_rust::NativeArray_::array_from(v5);
            let v12: Dice_ui::US33 = defaultValue(
                Dice_ui::US33::US33_0,
                map(
                    Func1::new(move |v: dice_ui::model::near::backend::TransactionCursor| {
                        Dice_ui::closure77((), v)
                    }),
                    v1.cursor,
                ),
            );
            (
                Dice_ui::method138(match &v12 {
                    Dice_ui::US33::US33_1(v12_1_0) => {
                        let v14: dice_ui::model::near::backend::TransactionCursor =
                            Dice_ui::method137(v12_1_0.clone());
                        let v17: std::string::String = Dice_ui::method32(v14.timestamp);
                        let v19: string = fable_library_rust::String_::fromString(v17);
                        Dice_ui::US27::US27_1(v14.index_in_chunk, v19)
                    }
                    _ => Dice_ui::US27::US27_0,
                }),
                v7,
            )
        }
        pub fn method112() -> Func1<
            dice_ui::model::near::backend::TransactionListByAccountId,
            (
                Dice_ui::US27,
                Array<(
                    Array<Dice_ui::US28>,
                    string,
                    u64,
                    string,
                    string,
                    string,
                    string,
                )>,
            ),
        > {
            Func1::new(
                move |v: dice_ui::model::near::backend::TransactionListByAccountId| {
                    Dice_ui::closure65((), v)
                },
            )
        }
        pub fn closure78(unitVar: (), _arg: (u64, u64)) -> Dice_ui::US26 {
            Dice_ui::US26::US26_0(_arg.0.clone(), _arg.1.clone())
        }
        pub fn method139() -> Func1<(u64, u64), Dice_ui::US26> {
            Func1::new(move |arg10_0040: (u64, u64)| Dice_ui::closure78((), arg10_0040))
        }
        pub fn closure79(unitVar: (), _arg: (string, bool, u64, string)) -> Dice_ui::US26 {
            Dice_ui::US26::US26_1(
                _arg.0.clone(),
                _arg.1.clone(),
                _arg.2.clone(),
                _arg.3.clone(),
            )
        }
        pub fn method140() -> Func1<(string, bool, u64, string), Dice_ui::US26> {
            Func1::new(move |arg10_0040: (string, bool, u64, string)| {
                Dice_ui::closure79((), arg10_0040)
            })
        }
        pub fn closure80(
            unitVar: (),
            _arg: (
                Dice_ui::US27,
                Array<(
                    Array<Dice_ui::US28>,
                    string,
                    u64,
                    string,
                    string,
                    string,
                    string,
                )>,
            ),
        ) -> Dice_ui::US26 {
            Dice_ui::US26::US26_2(_arg.0.clone(), _arg.1.clone())
        }
        pub fn method141() -> Func1<
            (
                Dice_ui::US27,
                Array<(
                    Array<Dice_ui::US28>,
                    string,
                    u64,
                    string,
                    string,
                    string,
                    string,
                )>,
            ),
            Dice_ui::US26,
        > {
            Func1::new(
                move |arg10_0040: (
                    Dice_ui::US27,
                    Array<(
                        Array<Dice_ui::US28>,
                        string,
                        u64,
                        string,
                        string,
                        string,
                        string,
                    )>,
                )| Dice_ui::closure80((), arg10_0040),
            )
        }
        pub fn closure81(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::ErrorWrapperEnum,
        ) -> Dice_ui::US34 {
            Dice_ui::US34::US34_1(v0_1)
        }
        pub fn method142(
            v0_1: dice_ui::model::near::backend::ErrorWrapperEnum,
        ) -> dice_ui::model::near::backend::ErrorWrapperEnum {
            v0_1
        }
        pub fn method144(
            v0_1: dice_ui::model::near::backend::ErrorWrapper,
        ) -> dice_ui::model::near::backend::ErrorWrapper {
            v0_1
        }
        pub fn method145(
            v0_1: dice_ui::model::near::backend::ErrorData,
        ) -> dice_ui::model::near::backend::ErrorData {
            v0_1
        }
        pub fn closure82(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::ErrorWrapper,
        ) -> (i32, string, u32, string, string) {
            let v1: dice_ui::model::near::backend::ErrorWrapper = Dice_ui::method144(v0_1);
            let v4: dice_ui::model::near::backend::ErrorData = Dice_ui::method145(v1.error);
            let v7: std::string::String = Dice_ui::method32(v4.message);
            let v9: string = fable_library_rust::String_::fromString(v7);
            let v11: i32 = v4.code;
            let v13: dice_ui::model::near::backend::ErrorDataInner = v4.data;
            let v16: std::string::String = Dice_ui::method32(v13.code);
            let v18: string = fable_library_rust::String_::fromString(v16);
            let v20: u32 = v13.http_status;
            let v23: std::string::String = Dice_ui::method32(v13.path);
            (
                v11,
                v18,
                v20,
                fable_library_rust::String_::fromString(v23),
                v9,
            )
        }
        pub fn method143(
        ) -> Func1<dice_ui::model::near::backend::ErrorWrapper, (i32, string, u32, string, string)>
        {
            Func1::new(move |v: dice_ui::model::near::backend::ErrorWrapper| {
                Dice_ui::closure82((), v)
            })
        }
        pub fn closure83(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::ErrorData,
        ) -> (i32, string, u32, string, string) {
            let v1: dice_ui::model::near::backend::ErrorData = Dice_ui::method145(v0_1);
            let v4: std::string::String = Dice_ui::method32(v1.message);
            let v6: string = fable_library_rust::String_::fromString(v4);
            let v8: i32 = v1.code;
            let v10: dice_ui::model::near::backend::ErrorDataInner = v1.data;
            let v13: std::string::String = Dice_ui::method32(v10.code);
            let v15: string = fable_library_rust::String_::fromString(v13);
            let v17: u32 = v10.http_status;
            let v20: std::string::String = Dice_ui::method32(v10.path);
            (
                v8,
                v15,
                v17,
                fable_library_rust::String_::fromString(v20),
                v6,
            )
        }
        pub fn method146(
        ) -> Func1<dice_ui::model::near::backend::ErrorData, (i32, string, u32, string, string)>
        {
            Func1::new(move |v: dice_ui::model::near::backend::ErrorData| Dice_ui::closure83((), v))
        }
        pub fn closure84(unitVar: (), _arg: (i32, string, u32, string, string)) -> Dice_ui::US24 {
            Dice_ui::US24::US24_1(
                _arg.0.clone(),
                _arg.1.clone(),
                _arg.2.clone(),
                _arg.3.clone(),
                _arg.4.clone(),
            )
        }
        pub fn method147() -> Func1<(i32, string, u32, string, string), Dice_ui::US24> {
            Func1::new(move |arg10_0040: (i32, string, u32, string, string)| {
                Dice_ui::closure84((), arg10_0040)
            })
        }
        pub fn closure85(unitVar: (), _arg: (i32, string, u32, string, string)) -> Dice_ui::US24 {
            Dice_ui::US24::US24_0(
                _arg.0.clone(),
                _arg.1.clone(),
                _arg.2.clone(),
                _arg.3.clone(),
                _arg.4.clone(),
            )
        }
        pub fn method148() -> Func1<(i32, string, u32, string, string), Dice_ui::US24> {
            Func1::new(move |arg10_0040: (i32, string, u32, string, string)| {
                Dice_ui::closure85((), arg10_0040)
            })
        }
        pub fn method149(
            v0_1: Result<Array<(Dice_ui::US23, Dice_ui::US25)>, std::string::String>,
        ) -> Result<Array<(Dice_ui::US23, Dice_ui::US25)>, std::string::String> {
            v0_1
        }
        pub fn closure59(
            unitVar: (),
            v0_1: string,
        ) -> std::pin::Pin<
            Box<
                dyn std::future::Future<
                    Output = Result<Array<(Dice_ui::US23, Dice_ui::US25)>, std::string::String>,
                >,
            >,
        > {
            let __future_init = Box::pin(async {
                //;
                leptos::logging::log!(
                    "{}",
                    &string("history.render () / response create_local_resource")
                );
                {
                    let v6: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method100(v0_1)));
                    let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
                    let v11: std::string::String = Dice_ui::method101(String::from(v8));
                    let v13: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                Output = Result<reqwest_wasm::Response, reqwest_wasm::Error>,
                            >,
                        >,
                    > = Box::pin(
                        reqwest_wasm::Client::builder()
                            .build()
                            .map_err(|err| err.to_string())?
                            .get(v11)
                            .send(),
                    );
                    let v15: Result<reqwest_wasm::Response, reqwest_wasm::Error> = v13.await;
                    let v16 = Dice_ui::method102();
                    let v18: Result<reqwest_wasm::Response, std::string::String> =
                        v15.map_err(|x| v16(x));
                    let v20: reqwest_wasm::Response = v18?;
                    let v22: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                Output = Result<std::string::String, reqwest_wasm::Error>,
                            >,
                        >,
                    > = Box::pin(reqwest_wasm::Response::text(v20));
                    let v24: Result<std::string::String, reqwest_wasm::Error> = v22.await;
                    let v25 = Dice_ui::method102();
                    let v27: Result<std::string::String, std::string::String> =
                        v24.map_err(|x| v25(x));
                    let v30: std::string::String = Dice_ui::method32(v27?);
                    let v34: string = Dice_ui::method2(Dice_ui::method8(
                        fable_library_rust::String_::fromString(v30),
                    ));
                    let v36: &str = fable_library_rust::String_::LrcStr::as_str(&v34);
                    let v38: std::string::String = String::from(v36);
                    let v40: Result<
                        Vec<dice_ui::model::near::backend::ResultWrapper>,
                        serde_json::Error,
                    > = serde_json::from_str(&v38);
                    let v41 = Dice_ui::method103();
                    let v43: Result<
                        Vec<dice_ui::model::near::backend::ResultWrapper>,
                        std::string::String,
                    > = v40.map_err(|x| v41(x));
                    let v45: Vec<dice_ui::model::near::backend::ResultWrapper> = v43?;
                    let v47: Array<std::rc::Rc<dice_ui::model::near::backend::ResultWrapper>> =
                        fable_library_rust::NativeArray_::array_from(
                            v45.into_iter().map(std::rc::Rc::new).collect(),
                        );
                    let v48: i32 = count(v47.clone());
                    let v49: Array<(Dice_ui::US23, Dice_ui::US25)> =
                        new_init(&defaultOf::<(Dice_ui::US23, Dice_ui::US25)>(), v48);
                    let v50: Dice_ui::Mut0 = Dice_ui::Mut0 {
                        l0: MutCell::new(0_i32),
                    };
                    while Dice_ui::method104(v48, v50.clone()) {
                        let v52: i32 = v50.l0.get();
                        let v54: std::rc::Rc<dice_ui::model::near::backend::ResultWrapper> =
                            Dice_ui::method105(v47[v52].clone());
                        let v59: Dice_ui::US31 = defaultValue(
                            Dice_ui::US31::US31_0,
                            map(
                                Func1::new(move |v: dice_ui::model::near::backend::DataWrapper| {
                                    Dice_ui::closure62((), v)
                                }),
                                v54.result.clone(),
                            ),
                        );
                        let v76: Dice_ui::US25 = match &v59 {
                            Dice_ui::US31::US31_1(v59_1_0) => {
                                let v61: dice_ui::model::near::backend::DataWrapper =
                                    Dice_ui::method106(v59_1_0.clone());
                                let v64: dice_ui::model::near::backend::ResultData =
                                    Dice_ui::method107(v61.data);
                                let v65 = Dice_ui::method108();
                                let v66 = Dice_ui::method110();
                                let v67 = Dice_ui::method112();
                                let v68 = Dice_ui::method139();
                                let v69 = Dice_ui::method140();
                                let v70 = Dice_ui::method141();
                                let v71: string =
                                    string("match v64 { dice_ui::model::near::backend::ResultData::AccountTransactionsCount(x) => v68(v65(x)), dice_ui::model::near::backend::ResultData::ContractById(x) => v69(v66(x)), dice_ui::model::near::backend::ResultData::TransactionListByAccountId(x) => v70(v67(x)) }");
                                Dice_ui::US25::US25_1(match v64 { dice_ui::model::near::backend::ResultData::AccountTransactionsCount(x) => v68(v65(x)), dice_ui::model::near::backend::ResultData::ContractById(x) => v69(v66(x)), dice_ui::model::near::backend::ResultData::TransactionListByAccountId(x) => v70(v67(x)) })
                            }
                            _ => Dice_ui::US25::US25_0,
                        };
                        let v81: Dice_ui::US34 = defaultValue(
                            Dice_ui::US34::US34_0,
                            map(
                                Func1::new(
                                    move |v_1: dice_ui::model::near::backend::ErrorWrapperEnum| {
                                        Dice_ui::closure81((), v_1)
                                    },
                                ),
                                v54.error.clone(),
                            ),
                        );
                        let v93: Dice_ui::US23 = match &v81 {
                            Dice_ui::US34::US34_1(v81_1_0) => {
                                let v83: dice_ui::model::near::backend::ErrorWrapperEnum =
                                    Dice_ui::method142(v81_1_0.clone());
                                let v84 = Dice_ui::method143();
                                let v85 = Dice_ui::method146();
                                let v86 = Dice_ui::method147();
                                let v87 = Dice_ui::method148();
                                let v88: string =
                                    string("match v83 { dice_ui::model::near::backend::ErrorWrapperEnum::ErrorWrapper(x) => v86(v84(x)), dice_ui::model::near::backend::ErrorWrapperEnum::ErrorData(x) => v87(v85(x)) }");
                                Dice_ui::US23::US23_1(match v83 { dice_ui::model::near::backend::ErrorWrapperEnum::ErrorWrapper(x) => v86(v84(x)), dice_ui::model::near::backend::ErrorWrapperEnum::ErrorData(x) => v87(v85(x)) })
                            }
                            _ => Dice_ui::US23::US23_0,
                        };
                        v49.get_mut()[v52 as usize] = (v93, v76);
                        {
                            let v94: i32 = v52 + 1_i32;
                            v50.l0.set(v94);
                            ()
                        }
                    }
                    leptos::logging::log!(
                        "{}",
                        &string("history.render () / response create_local_resource / end")
                    );
                    {
                        let v98: Result<
                            Array<(Dice_ui::US23, Dice_ui::US25)>,
                            std::string::String,
                        > = Dice_ui::method149(Ok(v49.clone()));
                        v98
                    }
                }
            });
            {
                {
                    // ;
                    __future_init
                }
            }
        }
        pub fn method151(
            v0_1: leptos::Resource<
                string,
                Result<Array<(Dice_ui::US23, Dice_ui::US25)>, std::string::String>,
            >,
        ) -> leptos::Resource<
            string,
            Result<Array<(Dice_ui::US23, Dice_ui::US25)>, std::string::String>,
        > {
            v0_1
        }
        pub fn closure86(
            v0_1: leptos::Resource<
                string,
                Result<Array<(Dice_ui::US23, Dice_ui::US25)>, std::string::String>,
            >,
            unitVar: (),
        ) -> string {
            let v1: leptos::Resource<
                string,
                Result<Array<(Dice_ui::US23, Dice_ui::US25)>, std::string::String>,
            > = Dice_ui::method151(v0_1);
            let v3: Option<Result<Array<(Dice_ui::US23, Dice_ui::US25)>, std::string::String>> =
                leptos::SignalGet::get(&v1);
            let v6: std::string::String = Dice_ui::method32(format!("{:#?}", &v3));
            fable_library_rust::String_::fromString(v6)
        }
        pub fn method150(
            v0_1: leptos::Resource<
                string,
                Result<Array<(Dice_ui::US23, Dice_ui::US25)>, std::string::String>,
            >,
        ) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure86(v0_1.clone(), ())
            })
        }
        pub fn method152() -> string {
            string("History")
        }
        pub fn closure89(v0_1: leptos::Memo<string>, unitVar: ()) -> leptos::Memo<string> {
            v0_1
        }
        pub fn method155(v0_1: leptos::Memo<string>) -> Func0<leptos::Memo<string>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure89(v0_1.clone(), ())
            })
        }
        pub fn method157(v0_1: string) -> string {
            v0_1
        }
        pub fn closure90(unitVar: (), v0_1: leptos::Memo<string>) -> leptos::Fragment {
            let v1: leptos::Memo<string> = Dice_ui::method99(v0_1);
            let v6: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method157(v1())));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method156() -> Func1<leptos::Memo<string>, leptos::Fragment> {
            Func1::new(move |v: leptos::Memo<string>| Dice_ui::closure90((), v))
        }
        pub fn closure88(v0_1: leptos::Memo<string>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method155(v0_1);
            let v2 = Dice_ui::method156();
            let v4 = {
                let clo = move || v2(v1());
                Func1::new({
                    let clo = clo.clone();
                    move |arg: ()| clo()
                })
            };
            let v6: leptos::View = leptos::IntoView::into_view(move || v4(()));
            leptos::Fragment::new(vec![v6])
        }
        pub fn method154(v0_1: leptos::Memo<string>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure88(v0_1.clone(), ())
            })
        }
        pub fn method158(
            v0_1: leptos::HtmlElement<leptos::html::Pre>,
        ) -> leptos::HtmlElement<leptos::html::Pre> {
            v0_1
        }
        pub fn closure87(v0_1: leptos::Memo<string>, unitVar: ()) -> leptos::Fragment {
            let v3: string = string(" class=\"[padding:7px] [font-size:11px] [line-height:11px]\"");
            let v4 = Dice_ui::method154(v0_1);
            let v7: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v3), string(">{v4()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v10: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method158(
                leptos::view! { <pre  class="[padding:7px] [font-size:11px] [line-height:11px]">{v4()}</pre> },
            );
            let v12: leptos::View = leptos::IntoView::into_view(v10);
            leptos::Fragment::new(vec![v12])
        }
        pub fn method153(v0_1: leptos::Memo<string>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure87(v0_1.clone(), ())
            })
        }
        pub fn method159(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
        ) -> leptos::HtmlElement<leptos::html::Details> {
            v0_1
        }
        pub fn method160() -> string {
            string("View")
        }
        pub fn method164() -> string {
            string("Dark Mode")
        }
        pub fn closure95(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method166() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure95((), v))
        }
        pub fn closure94(v0_1: Dice_ui::Heap2, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<Dice_ui::Heap0> = Dice_ui::method33(v0_1.l0.clone());
            let v5: Dice_ui::Heap0 = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method166();
            let v8: leptos::RwSignal<bool> = Dice_ui::method35(v5.l0.clone());
            let v9: string =
                string("leptos::SignalUpdate::update(&v8, |x| { let result = v7(x.clone()); if result != *x { *x = result } })");
            leptos::SignalUpdate::update(&v8, |x| {
                let result = v7(x.clone());
                if result != *x {
                    *x = result
                }
            });
            ()
        }
        pub fn method165(v0_1: Dice_ui::Heap2) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure94(v0_1.clone(), v)
            })
        }
        pub fn closure96(v0_1: Dice_ui::Heap2, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<Dice_ui::Heap0> = Dice_ui::method33(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method53((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method167(v0_1: Dice_ui::Heap2) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure96(v0_1.clone(), ())
            })
        }
        pub fn method168(
            v0_1: leptos::HtmlElement<leptos::html::Label>,
        ) -> leptos::HtmlElement<leptos::html::Label> {
            v0_1
        }
        pub fn closure98(v0_1: leptos::Fragment, unitVar: ()) -> leptos::Fragment {
            v0_1
        }
        pub fn method170(v0_1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure98(v0_1.clone(), ())
            })
        }
        pub fn method171(
            v0_1: leptos::HtmlElement<leptos::html::Dt>,
        ) -> leptos::HtmlElement<leptos::html::Dt> {
            v0_1
        }
        pub fn closure99(v0_1: leptos::Fragment, unitVar: ()) -> leptos::Fragment {
            v0_1
        }
        pub fn method172(v0_1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure99(v0_1.clone(), ())
            })
        }
        pub fn method173(
            v0_1: leptos::HtmlElement<leptos::html::Dd>,
        ) -> leptos::HtmlElement<leptos::html::Dd> {
            v0_1
        }
        pub fn method174(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn closure97(
            v0_1: leptos::Fragment,
            v1: leptos::Fragment,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(" class=\"font-medium text-gray-700\"");
            let v5 = Dice_ui::method170(v0_1);
            let v8: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dt "), v4), string(">{v5()}</")),
                            string("dt"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v11: leptos::HtmlElement<leptos::html::Dt> = Dice_ui::method171(
                leptos::view! { <dt  class="font-medium text-gray-700">{v5()}</dt> },
            );
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            let v15: string = string(" class=\"text-gray-700 md:col-span-2 flex flex-1\"");
            let v16 = Dice_ui::method172(v1);
            let v19: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dd "), v15), string(">{v16()}</")),
                            string("dd"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v22: leptos::HtmlElement<leptos::html::Dd> = Dice_ui::method173(
                leptos::view! { <dd  class="text-gray-700 md:col-span-2 flex flex-1">{v16()}</dd> },
            );
            let v26: Array<leptos::View> =
                Dice_ui::method174(new_array(&[v13, leptos::IntoView::into_view(v22)]));
            leptos::Fragment::new(v26.to_vec())
        }
        pub fn method169(v0_1: leptos::Fragment, v1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure97(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method175(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn closure93(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v3: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method164()));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: leptos::leptos_dom::Text = leptos::html::text(v7);
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            let v13: leptos::Fragment = leptos::Fragment::new(vec![v11]);
            leptos::logging::log!("{}", &string("dark_mode_toggle.render ()"));
            {
                let v17: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                let v19: Dice_ui::Heap2 = v17.unwrap();
                let v20 = Dice_ui::method165(v19.clone());
                let v21 = Dice_ui::method167(v19);
                let v24: string = Dice_ui::method2(Dice_ui::method8(string("v20")));
                let v26: &str = fable_library_rust::String_::LrcStr::as_str(&v24);
                let v28: std::string::String = String::from(v26);
                let v29: string =
                    string("<label for={v28.clone()} class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\"><input type=\"checkbox\" id={v28} class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\" on:change=move |event| v20(event) prop:checked={move || v21()} /><span class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-gray-200\"><svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg><svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg></span><span class=\"absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-gray-200\"></span></label>");
                let v30: string = append(append(string("leptos::view! { "), v29), string(" }"));
                let v33: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method168(
                    leptos::view! { <label for={v28.clone()} class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"><input type="checkbox" id={v28} class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" on:change=move |event| v20(event) prop:checked={move || v21()} /><span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-gray-200"><svg data-unchecked-icon xmlns="http://www.w3.org/2000/svg" class="h-4 w-4" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" clip-rule="evenodd" /></svg><svg data-checked-icon xmlns="http://www.w3.org/2000/svg" class="hidden h-4 w-4" viewBox="0 0 20 20" fill="currentColor"> <path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" /></svg></span><span class="absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-gray-200"></span></label> },
                );
                let v35: leptos::View = leptos::IntoView::into_view(v33);
                let v40: string =
                    string(" class=\"grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] pt-[10px] pr-[12px] pb-[12px] pl-[12px] items-center\"");
                let v41 = Dice_ui::method169(v13, leptos::Fragment::new(vec![v35]));
                let v44: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v40), string(">{v41()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v47: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method175(
                    leptos::view! { <div  class="grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] pt-[10px] pr-[12px] pb-[12px] pl-[12px] items-center">{v41()}</div> },
                );
                let v49: leptos::View = leptos::IntoView::into_view(v47);
                leptos::Fragment::new(vec![v49])
            }
        }
        pub fn method163() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure93((), ()))
        }
        pub fn method176(
            v0_1: leptos::HtmlElement<leptos::html::Dl>,
        ) -> leptos::HtmlElement<leptos::html::Dl> {
            v0_1
        }
        pub fn closure92(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string(" class=\"flex flex-1 divide-y divide-gray-100 text-sm\"");
            let v3 = Dice_ui::method163();
            let v6: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v2), string(">{v3()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v9: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method176(
                leptos::view! { <dl  class="flex flex-1 divide-y divide-gray-100 text-sm">{v3()}</dl> },
            );
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method162() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure92((), ()))
        }
        pub fn closure91(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string(" class=\"[flex:1] flow-root\"");
            let v3 = Dice_ui::method162();
            let v6: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v2), string(">{v3()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v9: leptos::HtmlElement<leptos::html::Div> =
                Dice_ui::method175(leptos::view! { <div  class="[flex:1] flow-root">{v3()}</div> });
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method161() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure91((), ()))
        }
        pub fn method177() -> string {
            string("Connection")
        }
        pub fn method181() -> string {
            string("Explorer Backend Host")
        }
        pub fn method183(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method184(
            v0_1: leptos::ReadSignal<std::string::String>,
        ) -> leptos::ReadSignal<std::string::String> {
            v0_1
        }
        pub fn closure103(v0_1: Dice_ui::Heap2, unitVar: ()) -> std::string::String {
            let v2: leptos::RwSignal<Dice_ui::Heap1> = Dice_ui::method40(v0_1.l2.clone());
            let v6: leptos::RwSignal<std::string::String> =
                Dice_ui::method183((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            let v9: leptos::ReadSignal<std::string::String> =
                Dice_ui::method184(leptos::RwSignal::read_only(&v6));
            leptos::SignalGet::get(&v9)
        }
        pub fn method182(v0_1: Dice_ui::Heap2) -> Func0<std::string::String> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure103(v0_1.clone(), ())
            })
        }
        pub fn method186(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method187(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method188(
            v0_1: leptos::WriteSignal<std::string::String>,
        ) -> leptos::WriteSignal<std::string::String> {
            v0_1
        }
        pub fn closure104(v0_1: Dice_ui::Heap2, v1: std::string::String) {
            let v3: leptos::RwSignal<Dice_ui::Heap1> = Dice_ui::method40(v0_1.l2.clone());
            let v7: leptos::RwSignal<std::string::String> =
                Dice_ui::method186((leptos::SignalGetUntracked::get_untracked(&v3)).l0.clone());
            let v9: leptos::WriteSignal<std::string::String> = leptos::RwSignal::write_only(&v7);
            let v10: std::string::String = Dice_ui::method187(v1);
            let v11: leptos::WriteSignal<std::string::String> = Dice_ui::method188(v9);
            leptos::SignalSet::set(&v11, v10);
            ()
        }
        pub fn method185(v0_1: Dice_ui::Heap2) -> Func1<std::string::String, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure104(v0_1.clone(), v)
            })
        }
        pub fn method189(
            v0_1: leptos::HtmlElement<leptos::html::Input>,
        ) -> leptos::HtmlElement<leptos::html::Input> {
            v0_1
        }
        pub fn closure102(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v3: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method181()));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: leptos::leptos_dom::Text = leptos::html::text(v7);
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            let v13: leptos::Fragment = leptos::Fragment::new(vec![v11]);
            let v15: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
            let v17: Dice_ui::Heap2 = v15.unwrap();
            let v18 = Dice_ui::method182(v17.clone());
            let v19 = Dice_ui::method185(v17);
            let v29: string =
                string("leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v19(leptos::event_target_value(&event)) prop:value=move || v18() class=\"bg-gray-50 flex-1 h-[27px]\" /> }");
            let v32: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method189(
                leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v19(leptos::event_target_value(&event)) prop:value=move || v18() class="bg-gray-50 flex-1 h-[27px]" /> },
            );
            let v34: leptos::View = leptos::IntoView::into_view(v32);
            let v38: string =
                string(" class=\"grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] pt-[10px] pr-[12px] pb-[12px] pl-[12px] items-baseline\"");
            let v39 = Dice_ui::method169(v13, leptos::Fragment::new(vec![v34]));
            let v42: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v38), string(">{v39()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v45: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method175(
                leptos::view! { <div  class="grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] pt-[10px] pr-[12px] pb-[12px] pl-[12px] items-baseline">{v39()}</div> },
            );
            let v47: leptos::View = leptos::IntoView::into_view(v45);
            leptos::Fragment::new(vec![v47])
        }
        pub fn method180() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure102((), ()))
        }
        pub fn closure101(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string(" class=\"flex flex-1 divide-y divide-gray-100 text-sm\"");
            let v3 = Dice_ui::method180();
            let v6: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v2), string(">{v3()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v9: leptos::HtmlElement<leptos::html::Dl> = Dice_ui::method176(
                leptos::view! { <dl  class="flex flex-1 divide-y divide-gray-100 text-sm">{v3()}</dl> },
            );
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method179() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure101((), ()))
        }
        pub fn closure100(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string(" class=\"[flex:1] flow-root\"");
            let v3 = Dice_ui::method179();
            let v6: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v2), string(">{v3()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v9: leptos::HtmlElement<leptos::html::Div> =
                Dice_ui::method175(leptos::view! { <div  class="[flex:1] flow-root">{v3()}</div> });
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method178() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure100((), ()))
        }
        pub fn method190() -> string {
            string("Global State")
        }
        pub fn method193(v0_1: Dice_ui::Heap2) -> Dice_ui::Heap2 {
            v0_1
        }
        pub fn closure107(unitVar: (), v0_1: std::string::String) -> Dice_ui::US35 {
            Dice_ui::US35::US35_1(v0_1)
        }
        pub fn closure108(unitVar: (), v0_1: std::string::String) -> Dice_ui::US35 {
            Dice_ui::US35::US35_0(v0_1)
        }
        pub fn closure106(v0_1: Dice_ui::Heap2, unitVar: ()) -> string {
            leptos::logging::log!(
                "{}",
                &string("settings.global_state_log_render () / global_state_json memo")
            );
            {
                let v3: Dice_ui::Heap2 = Dice_ui::method193(v0_1);
                let v5: Result<std::string::String, std::string::String> =
                    serde_json::to_string_pretty(&v3).map_err(|x| x.to_string());
                let v8: Dice_ui::US35 = match &v5 {
                    Err(v5_1_0) => Dice_ui::closure108((), v5_1_0.clone()),
                    Ok(v5_0_0) => Dice_ui::closure107((), v5_0_0.clone()),
                };
                match &v8 {
                    Dice_ui::US35::US35_1(v8_1_0) => {
                        let v10: std::string::String = Dice_ui::method32(v8_1_0.clone());
                        fable_library_rust::String_::fromString(v10)
                    }
                    Dice_ui::US35::US35_0(v8_0_0) => append(
                        append(string("Error: "), toString(v8_0_0.clone())),
                        string(""),
                    ),
                }
            }
        }
        pub fn method192(v0_1: Dice_ui::Heap2) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure106(v0_1.clone(), ())
            })
        }
        pub fn closure110(v0_1: leptos::Memo<string>, unitVar: ()) -> leptos::Memo<string> {
            v0_1
        }
        pub fn method195(v0_1: leptos::Memo<string>) -> Func0<leptos::Memo<string>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure110(v0_1.clone(), ())
            })
        }
        pub fn closure111(
            v0_1: leptos::Memo<string>,
            v1: leptos::Memo<string>,
        ) -> leptos::Fragment {
            let v2: leptos::Memo<string> = Dice_ui::method99(v0_1);
            let v7: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method157(v2())));
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method196(
            v0_1: leptos::Memo<string>,
        ) -> Func1<leptos::Memo<string>, leptos::Fragment> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::Memo<string>| Dice_ui::closure111(v0_1.clone(), v)
            })
        }
        pub fn closure109(v0_1: leptos::Memo<string>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method195(v0_1.clone());
            let v2 = Dice_ui::method196(v0_1);
            let v4 = {
                let clo = move || v2(v1());
                Func1::new({
                    let clo = clo.clone();
                    move |arg: ()| clo()
                })
            };
            let v6: leptos::View = leptos::IntoView::into_view(move || v4(()));
            leptos::Fragment::new(vec![v6])
        }
        pub fn method194(v0_1: leptos::Memo<string>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure109(v0_1.clone(), ())
            })
        }
        pub fn closure105(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("settings.global_state_log_render ()"));
            {
                let v3: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                let v6 = Dice_ui::method192(v3.unwrap());
                let v11: string =
                    string(" class=\"[padding:7px] [font-size:11px] [line-height:11px]\"");
                let v12 = Dice_ui::method194(leptos::create_memo(move |_| v6()));
                let v15: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<pre "), v11), string(">{v12()}</")),
                                string("pre"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v18: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method158(
                    leptos::view! { <pre  class="[padding:7px] [font-size:11px] [line-height:11px]">{v12()}</pre> },
                );
                let v20: leptos::View = leptos::IntoView::into_view(v18);
                leptos::Fragment::new(vec![v20])
            }
        }
        pub fn method191() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure105((), ()))
        }
        pub fn closure55(unitVar: (), v0_1: leptos::ReadSignal<Dice_ui::US21>) -> leptos::Fragment {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method88(v0_1);
            let v3: Dice_ui::US21 = leptos::SignalGet::get(&v1);
            let v108: leptos::View = match &v3 {
                Dice_ui::US21::US21_1 => {
                    leptos::logging::log!("{}", &string("history.render ()"));
                    {
                        let v7: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                        let v9: Dice_ui::Heap2 = v7.unwrap();
                        let v10 = Dice_ui::method89();
                        let v13 = Dice_ui::method97(v9, leptos::create_memo(move |_| v10()));
                        let v16 = Dice_ui::method98(leptos::create_memo(move |_| v13()));
                        let v20 = Dice_ui::method150(leptos::create_local_resource(
                            move || v16(),
                            |x| async move {
                                Func1::new(move |v: string| Dice_ui::closure59((), v))(x).await
                            },
                        ));
                        let v22: leptos::Memo<string> = leptos::create_memo(move |_| v20());
                        let v24: string = Dice_ui::method2(Dice_ui::method152());
                        let v26: &str = fable_library_rust::String_::LrcStr::as_str(&v24);
                        let v28: std::string::String = String::from(v26);
                        let v29 = Dice_ui::method153(v22);
                        let v30: string =
                                string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                        let v31: string =
                            append(append(string("leptos::view! { "), v30), string(" }"));
                        let v33: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                        let v34: string =
                                string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v28}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v33}</span></summary><div class=\"[display:flex] [flex:1] [overflow:auto]\">{v29()}</div></details>");
                        let v35: string =
                            append(append(string("leptos::view! { "), v34), string(" }"));
                        let v38: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method159(
                            leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v28}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v33}</span></summary><div class="[display:flex] [flex:1] [overflow:auto]">{v29()}</div></details> },
                        );
                        leptos::IntoView::into_view(v38)
                    }
                }
                Dice_ui::US21::US21_2 => {
                    let v42: string = Dice_ui::method2(Dice_ui::method160());
                    let v44: &str = fable_library_rust::String_::LrcStr::as_str(&v42);
                    let v46: std::string::String = String::from(v44);
                    let v47 = Dice_ui::method161();
                    let v48: string =
                            string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                    let v49: string = append(append(string("leptos::view! { "), v48), string(" }"));
                    let v51: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                    let v52: string =
                            string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v46}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v51}</span></summary><div class=\"[display:flex] [flex:1] [overflow:auto]\">{v47()}</div></details>");
                    let v53: string = append(append(string("leptos::view! { "), v52), string(" }"));
                    let v56: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method159(
                        leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v46}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v51}</span></summary><div class="[display:flex] [flex:1] [overflow:auto]">{v47()}</div></details> },
                    );
                    let v58: leptos::View = leptos::IntoView::into_view(v56);
                    let v60: string = Dice_ui::method2(Dice_ui::method177());
                    let v62: &str = fable_library_rust::String_::LrcStr::as_str(&v60);
                    let v64: std::string::String = String::from(v62);
                    let v65 = Dice_ui::method178();
                    let v66: string =
                            string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                    let v67: string = append(append(string("leptos::view! { "), v66), string(" }"));
                    let v69: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                    let v70: string =
                            string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v64}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v69}</span></summary><div class=\"[display:flex] [flex:1] [overflow:auto]\">{v65()}</div></details>");
                    let v71: string = append(append(string("leptos::view! { "), v70), string(" }"));
                    let v74: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method159(
                        leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v64}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v69}</span></summary><div class="[display:flex] [flex:1] [overflow:auto]">{v65()}</div></details> },
                    );
                    let v76: leptos::View = leptos::IntoView::into_view(v74);
                    let v78: string = Dice_ui::method2(Dice_ui::method190());
                    let v80: &str = fable_library_rust::String_::LrcStr::as_str(&v78);
                    let v82: std::string::String = String::from(v80);
                    let v83 = Dice_ui::method191();
                    let v84: string =
                            string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                    let v85: string = append(append(string("leptos::view! { "), v84), string(" }"));
                    let v87: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                    let v88: string =
                            string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v82}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v87}</span></summary><div class=\"[display:flex] [flex:1] [overflow:auto]\">{v83()}</div></details>");
                    let v89: string = append(append(string("leptos::view! { "), v88), string(" }"));
                    let v92: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method159(
                        leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v82}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v87}</span></summary><div class="[display:flex] [flex:1] [overflow:auto]">{v83()}</div></details> },
                    );
                    let v96: Array<leptos::View> = Dice_ui::method174(new_array(&[
                        v58,
                        v76,
                        leptos::IntoView::into_view(v92),
                    ]));
                    let v98: leptos::Fragment = leptos::Fragment::new(v96.to_vec());
                    leptos::IntoView::into_view(v98)
                }
                _ => {
                    let v102: Array<leptos::View> = Dice_ui::method174(new_empty::<leptos::View>());
                    let v104: leptos::Fragment = leptos::Fragment::new(v102.to_vec());
                    leptos::IntoView::into_view(v104)
                }
            };
            leptos::Fragment::new(vec![v108])
        }
        pub fn method87() -> Func1<leptos::ReadSignal<Dice_ui::US21>, leptos::Fragment> {
            Func1::new(move |v: leptos::ReadSignal<Dice_ui::US21>| Dice_ui::closure55((), v))
        }
        pub fn closure53(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method86(v0_1);
            let v2 = Dice_ui::method87();
            let v4 = {
                let clo = move || v2(v1());
                Func1::new({
                    let clo = clo.clone();
                    move |arg: ()| clo()
                })
            };
            let v6: leptos::View = leptos::IntoView::into_view(move || v4(()));
            leptos::Fragment::new(vec![v6])
        }
        pub fn method85(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure53(v0_1.clone(), ())
            })
        }
        pub fn method201() -> string {
            string("Tab")
        }
        pub fn closure115(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method201()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method200() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure115((), ()))
        }
        pub fn closure117(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method88(v0_1);
            if let Dice_ui::US21::US21_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method203(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure117(v0_1.clone(), ())
            })
        }
        pub fn method205() -> string {
            string("History")
        }
        pub fn closure118(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method205()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method204() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure118((), ()))
        }
        pub fn method206(
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::HtmlElement<leptos::html::Option_> {
            v0_1
        }
        pub fn closure119(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method88(v0_1);
            if let Dice_ui::US21::US21_2 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method207(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure119(v0_1.clone(), ())
            })
        }
        pub fn method209() -> string {
            string("Settings")
        }
        pub fn closure120(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method209()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method208() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure120((), ()))
        }
        pub fn closure116(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method203(v0_1.clone());
            let v4: string = string(" select=v1()");
            let v5 = Dice_ui::method204();
            let v8: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<option "), v4), string(">{v5()}</")),
                            string("option"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v11: leptos::HtmlElement<leptos::html::Option_> =
                Dice_ui::method206(leptos::view! { <option  select=v1()>{v5()}</option> });
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            let v14 = Dice_ui::method207(v0_1);
            let v16: string = string(" select=v14()");
            let v17 = Dice_ui::method208();
            let v19: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<option "), v16), string(">{v17()}</")),
                            string("option"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v22: leptos::HtmlElement<leptos::html::Option_> =
                Dice_ui::method206(leptos::view! { <option  select=v14()>{v17()}</option> });
            let v26: Array<leptos::View> =
                Dice_ui::method174(new_array(&[v13, leptos::IntoView::into_view(v22)]));
            leptos::Fragment::new(v26.to_vec())
        }
        pub fn method202(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure116(v0_1.clone(), ())
            })
        }
        pub fn method210(
            v0_1: leptos::HtmlElement<leptos::html::Select>,
        ) -> leptos::HtmlElement<leptos::html::Select> {
            v0_1
        }
        pub fn closure114(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"sr-only\" for=\"Tab\"");
            let v6 = Dice_ui::method200();
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<label "), v5), string(">{v6()}</")),
                            string("label"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method168(
                leptos::view! { <label  class="sr-only" for="Tab">{v6()}</label> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v18: string = string(" class=\"w-full rounded-md border-gray-200\" id=\"Tab\"");
            let v19 = Dice_ui::method202(v0_1);
            let v22: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<select "), v18), string(">{v19()}</")),
                            string("select"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v25: leptos::HtmlElement<leptos::html::Select> = Dice_ui::method210(
                leptos::view! { <select  class="w-full rounded-md border-gray-200" id="Tab">{v19()}</select> },
            );
            let v29: Array<leptos::View> =
                Dice_ui::method174(new_array(&[v14, leptos::IntoView::into_view(v25)]));
            leptos::Fragment::new(v29.to_vec())
        }
        pub fn method199(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure114(v0_1.clone(), ())
            })
        }
        pub fn closure124(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method88(v0_1);
            if let Dice_ui::US21::US21_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method214(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure124(v0_1.clone(), ())
            })
        }
        pub fn method215(v0_1: Func0<bool>) -> Func0<bool> {
            v0_1
        }
        pub fn closure125(v0_1: Func0<bool>, unitVar: ()) -> &'static str {
            if v0_1() {
                let v3: string = string("r#\"border-grey-200 text-grey-900\"#");
                r#"border-grey-200 text-grey-900"#
            } else {
                let v6: string =
                    string("r#\"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700\"#");
                r#"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700"#
            }
        }
        pub fn method216(v0_1: Func0<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure125(v0_1.clone(), ())
            })
        }
        pub fn method218(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> leptos::HtmlElement<leptos::svg::Svg> {
            v0_1
        }
        pub fn closure126(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method218(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v6: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method205()));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v16: Array<leptos::View> =
                Dice_ui::method174(new_array(&[v3, leptos::IntoView::into_view(v12)]));
            leptos::Fragment::new(v16.to_vec())
        }
        pub fn method217(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure126(v0_1.clone(), ())
            })
        }
        pub fn method219(
            v0_1: leptos::HtmlElement<leptos::html::A>,
        ) -> leptos::HtmlElement<leptos::html::A> {
            v0_1
        }
        pub fn closure127(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method88(v0_1);
            if let Dice_ui::US21::US21_2 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method220(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure127(v0_1.clone(), ())
            })
        }
        pub fn closure128(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method218(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v6: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method209()));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v16: Array<leptos::View> =
                Dice_ui::method174(new_array(&[v3, leptos::IntoView::into_view(v12)]));
            leptos::Fragment::new(v16.to_vec())
        }
        pub fn method221(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure128(v0_1.clone(), ())
            })
        }
        pub fn closure123(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string = append(v1.clone(), string("#/history"));
            let v3: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z\"/></svg>");
            let v4: string = append(append(string("leptos::view! { "), v3), string(" }"));
            let v6: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="h-5 w-5"><path stroke-linecap="round" stroke-linejoin="round" d="M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z"/></svg> };
            let v8: string = Dice_ui::method2(Dice_ui::method8(v2));
            let v10: &str = fable_library_rust::String_::LrcStr::as_str(&v8);
            let v12: std::string::String = String::from(v10);
            let v13 = Dice_ui::method214(v0_1.clone());
            let v14 = Dice_ui::method215(v13.clone());
            let v15 = Dice_ui::method216(v13);
            let v17: string =
                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium \".to_owned() + v15()}");
            let v22: string = append(
                append(
                    string(" aria-current={move || if v14() { \"page\" } else { \"\" }}"),
                    append(
                        append(append(string(" "), v17), string(" href=v12")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v23 = Dice_ui::method217(v6);
            let v26: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<a "), v22), string(">{v23()}</")),
                            string("a"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v29: leptos::HtmlElement<leptos::html::A> = Dice_ui::method219(
                leptos::view! { <a  aria-current={move || if v14() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium ".to_owned() + v15()} href=v12>{v23()}</a> },
            );
            let v31: leptos::View = leptos::IntoView::into_view(v29);
            let v32: string = append(v1, string("#/settings"));
            let v33: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\"/><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M15 12a3 3 0 11-6 0 3 3 0 016 0z\"/></svg>");
            let v34: string = append(append(string("leptos::view! { "), v33), string(" }"));
            let v36: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="h-5 w-5"><path stroke-linecap="round" stroke-linejoin="round" d="M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z"/><path stroke-linecap="round" stroke-linejoin="round" d="M15 12a3 3 0 11-6 0 3 3 0 016 0z"/></svg> };
            let v38: string = Dice_ui::method2(Dice_ui::method8(v32));
            let v40: &str = fable_library_rust::String_::LrcStr::as_str(&v38);
            let v42: std::string::String = String::from(v40);
            let v43 = Dice_ui::method220(v0_1);
            let v44 = Dice_ui::method215(v43.clone());
            let v45 = Dice_ui::method216(v43);
            let v47: string =
                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium \".to_owned() + v45()}");
            let v51: string = append(
                append(
                    string(" aria-current={move || if v44() { \"page\" } else { \"\" }}"),
                    append(
                        append(append(string(" "), v47), string(" href=v42")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v52 = Dice_ui::method221(v36);
            let v54: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<a "), v51), string(">{v52()}</")),
                            string("a"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v57: leptos::HtmlElement<leptos::html::A> = Dice_ui::method219(
                leptos::view! { <a  aria-current={move || if v44() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium ".to_owned() + v45()} href=v42>{v52()}</a> },
            );
            let v61: Array<leptos::View> =
                Dice_ui::method174(new_array(&[v31, leptos::IntoView::into_view(v57)]));
            leptos::Fragment::new(v61.to_vec())
        }
        pub fn method213(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure123(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method222(
            v0_1: leptos::HtmlElement<leptos::html::Nav>,
        ) -> leptos::HtmlElement<leptos::html::Nav> {
            v0_1
        }
        pub fn closure122(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string =
                string("class=\"-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]\"");
            let v6: string = append(
                append(
                    string(" aria-label=\"Tabs\""),
                    append(append(append(string(" "), v2), string("")), string("")),
                ),
                string(""),
            );
            let v7 = Dice_ui::method213(v0_1, v1);
            let v10: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<nav "), v6), string(">{v7()}</")),
                            string("nav"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v13: leptos::HtmlElement<leptos::html::Nav> = Dice_ui::method222(
                leptos::view! { <nav  aria-label="Tabs" class="-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]">{v7()}</nav> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method212(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure122(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure121(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 border-t border-gray-200\"");
            let v5 = Dice_ui::method212(v0_1, v1);
            let v8: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v4), string(">{v5()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v11: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method175(
                leptos::view! { <div  class="flex flex-1 border-t border-gray-200">{v5()}</div> },
            );
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            leptos::Fragment::new(vec![v13])
        }
        pub fn method211(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure121(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure113(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: leptos_router::Location = leptos_router::use_location();
            let v3: leptos_router::Location = Dice_ui::method68(v2.clone());
            let v6: leptos::Memo<std::string::String> = Dice_ui::method69(v3.pathname);
            let v9: std::string::String = Dice_ui::method32(v6());
            let v11: string = fable_library_rust::String_::fromString(v9);
            let v12: leptos_router::Location = Dice_ui::method70(v2);
            let v15: leptos::Memo<std::string::String> = Dice_ui::method69(v12.search);
            let v18: std::string::String = Dice_ui::method32(v15());
            let v20: string = fable_library_rust::String_::fromString(v18);
            let v26: string = append(
                v11,
                (if v20.clone() == string("") {
                    string("")
                } else {
                    sprintf!("?{}", &v20)
                }),
            );
            let v29: string = string(" class=\"hidden\"");
            let v30 = Dice_ui::method199(v0_1.clone());
            let v33: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v29), string(">{v30()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v36: leptos::HtmlElement<leptos::html::Div> =
                Dice_ui::method175(leptos::view! { <div  class="hidden">{v30()}</div> });
            let v38: leptos::View = leptos::IntoView::into_view(v36);
            let v40: string =
                string(" class=\"flex flex-1 [overflow-x:auto] [overflow-y:hidden]\"");
            let v41 = Dice_ui::method211(v0_1, v26);
            let v43: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v40), string(">{v41()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v46: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method175(
                leptos::view! { <div  class="flex flex-1 [overflow-x:auto] [overflow-y:hidden]">{v41()}</div> },
            );
            let v50: Array<leptos::View> =
                Dice_ui::method174(new_array(&[v38, leptos::IntoView::into_view(v46)]));
            leptos::Fragment::new(v50.to_vec())
        }
        pub fn method198(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure113(v0_1.clone(), ())
            })
        }
        pub fn closure112(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v3: string = string(" class=\"flex flex-1 [align-items:flex-end]\"");
            let v4 = Dice_ui::method198(v0_1);
            let v7: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v3), string(">{v4()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v10: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method175(
                leptos::view! { <div  class="flex flex-1 [align-items:flex-end]">{v4()}</div> },
            );
            let v12: leptos::View = leptos::IntoView::into_view(v10);
            leptos::Fragment::new(vec![v12])
        }
        pub fn method197(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure112(v0_1.clone(), ())
            })
        }
        pub fn closure52(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> leptos::Fragment {
            let v3: string = string(" class=\"flex flex-100 flex-col [overflow-y:auto]\"");
            let v4 = Dice_ui::method85(v0_1.clone());
            let v7: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v3), string(">{v4()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v10: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method175(
                leptos::view! { <div  class="flex flex-100 flex-col [overflow-y:auto]">{v4()}</div> },
            );
            let v12: leptos::View = leptos::IntoView::into_view(v10);
            let v14: string = string(" class=\"flex flex-1\"");
            let v15 = Dice_ui::method197(v0_1);
            let v17: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v14), string(">{v15()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v20: leptos::HtmlElement<leptos::html::Div> =
                Dice_ui::method175(leptos::view! { <div  class="flex flex-1">{v15()}</div> });
            let v24: Array<leptos::View> =
                Dice_ui::method174(new_array(&[v12, leptos::IntoView::into_view(v20)]));
            leptos::Fragment::new(v24.to_vec())
        }
        pub fn method84(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure52(v0_1.clone(), ())
            })
        }
        pub fn closure51(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> leptos::Fragment {
            let v1: string =
                string("class=\"[width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100vh] max-[60px]:[min-height:600px] bg-gray-50 flex flex-1 flex-col items-stretch text-gray-700 text-sm\"");
            let v3: string = append(append(append(string(" "), v1), string("")), string(""));
            let v4 = Dice_ui::method84(v0_1);
            let v7: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v3), string(">{v4()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v10: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method175(
                leptos::view! { <div  class="[width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100vh] max-[60px]:[min-height:600px] bg-gray-50 flex flex-1 flex-col items-stretch text-gray-700 text-sm">{v4()}</div> },
            );
            let v12: leptos::View = leptos::IntoView::into_view(v10);
            leptos::Fragment::new(vec![v12])
        }
        pub fn method83(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure51(v0_1.clone(), ())
            })
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("content.render ()"));
            {
                let v3: leptos_router::Location = leptos_router::use_location();
                let v5: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)> =
                    std::sync::Arc::new(leptos_router::use_navigate());
                let v7: leptos_router::Location = leptos_router::use_location();
                let v8: leptos_router::Location = Dice_ui::method68(v7.clone());
                let v11: leptos::Memo<std::string::String> = Dice_ui::method69(v8.pathname);
                let v14: std::string::String = Dice_ui::method32(v11());
                let v16: string = fable_library_rust::String_::fromString(v14);
                let v17: leptos_router::Location = Dice_ui::method70(v7);
                let v20: leptos::Memo<std::string::String> = Dice_ui::method69(v17.search);
                let v23: std::string::String = Dice_ui::method32(v20());
                let v25: string = fable_library_rust::String_::fromString(v23);
                let v31: string = append(
                    v16,
                    (if v25.clone() == string("") {
                        string("")
                    } else {
                        sprintf!("?{}", &v25)
                    }),
                );
                let v33: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                let v35: Dice_ui::Heap2 = v33.unwrap();
                let v36: Dice_ui::US21 = Dice_ui::method71();
                let patternInput: (
                    leptos::ReadSignal<Dice_ui::US21>,
                    leptos::WriteSignal<Dice_ui::US21>,
                ) = leptos::create_signal(v36);
                let v40: bool = Dice_ui::method50();
                let patternInput_1: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                    leptos::create_signal(v40);
                let v44 = Dice_ui::method72(
                    v3.clone(),
                    v5,
                    v31,
                    v35,
                    patternInput_1.1.clone(),
                    patternInput_1.0.clone(),
                );
                leptos::create_effect(move |_| v44());
                {
                    let v46 = Dice_ui::method76(v3, patternInput.1.clone());
                    leptos::create_effect(move |_| v46());
                    {
                        let v50: string =
                            string(" class=\"flex flex-1 max-[100px]:[overflow-x:auto]\"");
                        let v51 = Dice_ui::method83(patternInput.0.clone());
                        let v54: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v50), string(">{v51()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v57: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method175(
                            leptos::view! { <div  class="flex flex-1 max-[100px]:[overflow-x:auto]">{v51()}</div> },
                        );
                        let v59: leptos::View = leptos::IntoView::into_view(v57);
                        leptos::Fragment::new(vec![v59])
                    }
                }
            }
        }
        pub fn method67() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure44((), ()))
        }
        pub fn closure5(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(1_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                let v7: Dice_ui::Heap2 = v5.unwrap();
                let v8 = Dice_ui::method10();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method13(v11.clone());
                let v15: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3> =
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move
                                                                                                 |v_1:
                                                                                                      Option<rexie::Rexie>|
                                                                                                 Dice_ui::closure11((),
                                                                                                                    v_1))(x).await
                        },
                    );
                let v16 = Dice_ui::method20(v11.clone());
                let v19: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7> =
                    leptos::create_local_resource(
                        move || v16(),
                        |x| async move {
                            Func1::new(move
                                                                                                 |v_2:
                                                                                                      Option<rexie::Rexie>|
                                                                                                 Dice_ui::closure18((),
                                                                                                                    v_2))(x).await
                        },
                    );
                let v20 = Dice_ui::method23(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Dice_ui::method38(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method42(v11.clone());
                        let v26: leptos::Action<Dice_ui::Heap3, ()> =
                            leptos::create_action(move |value: &Heap3| v24(value.clone()));
                        let v27 = Dice_ui::method46(v11);
                        let v29: leptos::Action<Dice_ui::Heap4, ()> =
                            leptos::create_action(move |value: &Heap4| v27(value.clone()));
                        let v30 = Dice_ui::method48(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Dice_ui::method50();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Dice_ui::method51(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Dice_ui::method64(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                                let v46 = Dice_ui::method66(v42.unwrap());
                                let v51: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v52 = Dice_ui::method67();
                                let v55: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v51),
                                                    string(">{v52()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v58: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method175(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v52()}</div> },
                                    );
                                let v60: leptos::View = leptos::IntoView::into_view(v58);
                                leptos::Fragment::new(vec![v60])
                            }
                        }
                    }
                }
            }
        }
        pub fn method9() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure5((), ()))
        }
        pub fn closure129(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: Array<leptos::View> = Dice_ui::method174(new_empty::<leptos::View>());
            leptos::Fragment::new(v1.to_vec())
        }
        pub fn method223() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure129((), ()))
        }
        pub fn method224() -> string {
            string("/")
        }
        pub fn closure130(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(2_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                let v7: Dice_ui::Heap2 = v5.unwrap();
                let v8 = Dice_ui::method10();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method13(v11.clone());
                let v15: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3> =
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move
                                                                                                 |v_1:
                                                                                                      Option<rexie::Rexie>|
                                                                                                 Dice_ui::closure11((),
                                                                                                                    v_1))(x).await
                        },
                    );
                let v16 = Dice_ui::method20(v11.clone());
                let v19: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7> =
                    leptos::create_local_resource(
                        move || v16(),
                        |x| async move {
                            Func1::new(move
                                                                                                 |v_2:
                                                                                                      Option<rexie::Rexie>|
                                                                                                 Dice_ui::closure18((),
                                                                                                                    v_2))(x).await
                        },
                    );
                let v20 = Dice_ui::method23(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Dice_ui::method38(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method42(v11.clone());
                        let v26: leptos::Action<Dice_ui::Heap3, ()> =
                            leptos::create_action(move |value: &Heap3| v24(value.clone()));
                        let v27 = Dice_ui::method46(v11);
                        let v29: leptos::Action<Dice_ui::Heap4, ()> =
                            leptos::create_action(move |value: &Heap4| v27(value.clone()));
                        let v30 = Dice_ui::method48(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Dice_ui::method50();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Dice_ui::method51(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Dice_ui::method64(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                                let v46 = Dice_ui::method66(v42.unwrap());
                                let v51: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v52 = Dice_ui::method67();
                                let v55: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v51),
                                                    string(">{v52()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v58: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method175(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v52()}</div> },
                                    );
                                let v60: leptos::View = leptos::IntoView::into_view(v58);
                                leptos::Fragment::new(vec![v60])
                            }
                        }
                    }
                }
            }
        }
        pub fn method225() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure130((), ()))
        }
        pub fn method226() -> string {
            string("/*")
        }
        pub fn closure131(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(3_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                let v7: Dice_ui::Heap2 = v5.unwrap();
                let v8 = Dice_ui::method10();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method13(v11.clone());
                let v15: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3> =
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move
                                                                                                 |v_1:
                                                                                                      Option<rexie::Rexie>|
                                                                                                 Dice_ui::closure11((),
                                                                                                                    v_1))(x).await
                        },
                    );
                let v16 = Dice_ui::method20(v11.clone());
                let v19: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7> =
                    leptos::create_local_resource(
                        move || v16(),
                        |x| async move {
                            Func1::new(move
                                                                                                 |v_2:
                                                                                                      Option<rexie::Rexie>|
                                                                                                 Dice_ui::closure18((),
                                                                                                                    v_2))(x).await
                        },
                    );
                let v20 = Dice_ui::method23(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Dice_ui::method38(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method42(v11.clone());
                        let v26: leptos::Action<Dice_ui::Heap3, ()> =
                            leptos::create_action(move |value: &Heap3| v24(value.clone()));
                        let v27 = Dice_ui::method46(v11);
                        let v29: leptos::Action<Dice_ui::Heap4, ()> =
                            leptos::create_action(move |value: &Heap4| v27(value.clone()));
                        let v30 = Dice_ui::method48(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Dice_ui::method50();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Dice_ui::method51(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Dice_ui::method64(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                                let v46 = Dice_ui::method66(v42.unwrap());
                                let v51: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v52 = Dice_ui::method67();
                                let v55: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v51),
                                                    string(">{v52()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v58: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method175(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v52()}</div> },
                                    );
                                let v60: leptos::View = leptos::IntoView::into_view(v58);
                                leptos::Fragment::new(vec![v60])
                            }
                        }
                    }
                }
            }
        }
        pub fn method227() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure131((), ()))
        }
        pub fn method228() -> string {
            string("*")
        }
        pub fn closure132(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(4_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                let v7: Dice_ui::Heap2 = v5.unwrap();
                let v8 = Dice_ui::method10();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method13(v11.clone());
                let v15: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3> =
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move
                                                                                                 |v_1:
                                                                                                      Option<rexie::Rexie>|
                                                                                                 Dice_ui::closure11((),
                                                                                                                    v_1))(x).await
                        },
                    );
                let v16 = Dice_ui::method20(v11.clone());
                let v19: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7> =
                    leptos::create_local_resource(
                        move || v16(),
                        |x| async move {
                            Func1::new(move
                                                                                                 |v_2:
                                                                                                      Option<rexie::Rexie>|
                                                                                                 Dice_ui::closure18((),
                                                                                                                    v_2))(x).await
                        },
                    );
                let v20 = Dice_ui::method23(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Dice_ui::method38(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method42(v11.clone());
                        let v26: leptos::Action<Dice_ui::Heap3, ()> =
                            leptos::create_action(move |value: &Heap3| v24(value.clone()));
                        let v27 = Dice_ui::method46(v11);
                        let v29: leptos::Action<Dice_ui::Heap4, ()> =
                            leptos::create_action(move |value: &Heap4| v27(value.clone()));
                        let v30 = Dice_ui::method48(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Dice_ui::method50();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Dice_ui::method51(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Dice_ui::method64(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<Dice_ui::Heap2> = leptos::use_context::<Heap2>();
                                let v46 = Dice_ui::method66(v42.unwrap());
                                let v51: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v52 = Dice_ui::method67();
                                let v55: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v51),
                                                    string(">{v52()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v58: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method175(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v52()}</div> },
                                    );
                                let v60: leptos::View = leptos::IntoView::into_view(v58);
                                leptos::Fragment::new(vec![v60])
                            }
                        }
                    }
                }
            }
        }
        pub fn method229() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure132((), ()))
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method7()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method9();
            let v8 = Dice_ui::method223();
            let v16: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v7() path=v6 /> })");
            let v17: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v7() path=v6 /> },
            );
            let v20: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method224()));
            let v22: &str = fable_library_rust::String_::LrcStr::as_str(&v20);
            let v24: std::string::String = String::from(v22);
            let v25 = Dice_ui::method225();
            let v26 = Dice_ui::method223();
            let v32: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v25() path=v24 /> })");
            let v33: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v25() path=v24 /> },
            );
            let v36: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method226()));
            let v38: &str = fable_library_rust::String_::LrcStr::as_str(&v36);
            let v40: std::string::String = String::from(v38);
            let v41 = Dice_ui::method227();
            let v42 = Dice_ui::method223();
            let v48: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v41() path=v40 /> })");
            let v49: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v41() path=v40 /> },
            );
            let v52: string = Dice_ui::method2(Dice_ui::method8(Dice_ui::method228()));
            let v54: &str = fable_library_rust::String_::LrcStr::as_str(&v52);
            let v56: std::string::String = String::from(v54);
            let v57 = Dice_ui::method229();
            let v58 = Dice_ui::method223();
            let v64: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v57() path=v56 /> })");
            let v67: Array<leptos::View> = Dice_ui::method174(new_array(&[
                v17,
                v33,
                v49,
                leptos::IntoView::into_view(
                    leptos::view! { <leptos_router::Route  view=move || v57() path=v56 /> },
                ),
            ]));
            leptos::Fragment::new(v67.to_vec())
        }
        pub fn method6() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure4((), ()))
        }
        pub fn method230(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method230(Dice_ui::method6());
            let v7: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> })");
            let v8: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> },
            );
            leptos::Fragment::new(vec![v8])
        }
        pub fn method5() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure3((), ()))
        }
        pub fn method231(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
            leptos::logging::log!("{}", &string("app.render ()"));
            leptos_meta::provide_meta_context();
            {
                let v4: leptos::RwSignal<bool> = leptos::create_rw_signal(false);
                let v6: string = Dice_ui::method2(Dice_ui::method1());
                let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
                let v10: std::string::String = String::from(v8);
                let v13: Dice_ui::Heap0 = Dice_ui::Heap0 {
                    l0: v4,
                    l1: leptos::create_rw_signal(v10),
                };
                let v15: leptos::RwSignal<Dice_ui::Heap0> = leptos::create_rw_signal(v13);
                let v17: string = Dice_ui::method2(Dice_ui::method3());
                let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
                let v21: std::string::String = String::from(v19);
                let v24: Dice_ui::Heap1 = Dice_ui::Heap1 {
                    l0: leptos::create_rw_signal(v21),
                };
                let v26: leptos::RwSignal<Dice_ui::Heap1> = leptos::create_rw_signal(v24);
                let v28: std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> =
                    std::collections::HashMap::new();
                let v32: Dice_ui::Heap2 = Dice_ui::method4(Dice_ui::Heap2 {
                    l0: v15,
                    l1: leptos::create_rw_signal(v28),
                    l2: v26,
                });
                leptos::provide_context::<Heap2>(v32);
                {
                    let v35 = Dice_ui::method231(Dice_ui::method5());
                    let v41: string =
                        string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Router  children=Box::new(move || v35()) /> })");
                    leptos::IntoView::into_view(
                        leptos::view! { <leptos_router::Router  children=Box::new(move || v35()) /> },
                    )
                }
            }
        }
        pub fn method0() {
            leptos::mount_to_body(|| Func0::new(move || Dice_ui::closure2((), ()))());
            ()
        }
        pub fn closure133(unitVar: (), unitVar_1: ()) {
            Dice_ui::method0();
        }
        pub fn method232() -> Func0<()> {
            Func0::new(move || Dice_ui::closure133((), ()))
        }
        pub fn method233(v0_1: Box<dyn Fn()>) -> Box<dyn Fn()> {
            v0_1
        }
        pub fn closure0(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1: string = append(append(string("main / args: "), toString(v0_1)), string(""));
            leptos::logging::log!("{}", &v1);
            let _ = console_log::init_with_level(log::Level::Debug);
            console_error_panic_hook::set_once();
            {
                let v9: Dice_ui::US0 = defaultValue(
                    Dice_ui::US0::US0_0,
                    map(
                        Func1::new(move |v: web_sys::HtmlElement| Dice_ui::closure1((), v)),
                        leptos::document().body(),
                    ),
                );
                let v11: string = append(
                    append(
                        string("main / mount_to_body / body: "),
                        sprintf!("{:?}", &v9),
                    ),
                    string(""),
                );
                leptos::logging::log!("{}", &v11);
                if let Dice_ui::US0::US0_1(v9_1_0) = &v9 {
                    Dice_ui::method0()
                } else {
                    let v14 = Dice_ui::method232();
                    let v17: Box<dyn Fn()> = Dice_ui::method233(Box::new(move || v14()));
                    let v19: wasm_bindgen::closure::Closure<dyn Fn()> =
                        wasm_bindgen::closure::Closure::wrap(v17);
                    let v21: &wasm_bindgen::JsValue = wasm_bindgen::closure::Closure::as_ref(&v19);
                    let v23: &js_sys::Function = wasm_bindgen::JsCast::unchecked_ref(v21);
                    leptos::document()
                        .add_event_listener_with_callback("DOMContentLoaded", v23)
                        .unwrap();
                    v19.forget();
                    ()
                }
                0_i32
            }
        }
        pub fn v0() -> Func1<Array<string>, i32> {
            static v0: MutCell<Option<Func1<Array<string>, i32>>> = MutCell::new(None);
            v0.get_or_init(|| Func1::new(move |v: Array<string>| Dice_ui::closure0((), v)))
        }
        pub fn main(args: Array<string>) -> i32 {
            (Dice_ui::v0())(args)
        }
    }
}
pub use module_eef1bd43::*;
#[path = "../../../lib/fsharp/CommonWasm.rs"]
mod module_8cb3e09e;
pub use module_8cb3e09e::*;
pub mod Polyglot {
    // pub use crate::module_8cb3e09e::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Dice_ui::main(array_from(args));
}
