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
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::NativeArray_::count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Seq_::ofArray;
        use fable_library_rust::Seq_::toArray;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::join;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofBoolean;
        use fable_library_rust::String_::replace;
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
            pub l1: leptos::RwSignal<bool>,
            pub l2: leptos::RwSignal<std::string::String>,
        }
        impl core::fmt::Display for Dice_ui::Heap0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize, serde::Deserialize)]
        pub struct Heap1 {
            pub l0: leptos::RwSignal<
                std::collections::HashMap<
                    std::string::String,
                    leptos::RwSignal<std::string::String>,
                >,
            >,
        }
        impl core::fmt::Display for Dice_ui::Heap1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize)]
        pub struct Heap2 {
            pub l0: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
            pub l1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            pub l2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>>,
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
            pub l1: bool,
            pub l2: std::string::String,
        }
        impl core::fmt::Display for Dice_ui::Heap3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US3 {
            US3_0,
            US3_1(LrcPtr<Dice_ui::Heap3>),
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
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0(wasm_bindgen::JsValue),
            US7_1(Option<web_sys::Storage>),
        }
        impl core::fmt::Display for Dice_ui::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0,
            US9_1(web_sys::Storage),
        }
        impl core::fmt::Display for Dice_ui::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(wasm_bindgen::JsValue),
            US8_1(Dice_ui::US9),
        }
        impl core::fmt::Display for Dice_ui::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0,
            US10_1(Dice_ui::US3),
        }
        impl core::fmt::Display for Dice_ui::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(wasm_bindgen::JsValue),
            US11_1(Option<std::string::String>),
        }
        impl core::fmt::Display for Dice_ui::US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0,
            US13_1(std::string::String),
        }
        impl core::fmt::Display for Dice_ui::US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(wasm_bindgen::JsValue),
            US12_1(Dice_ui::US13),
        }
        impl core::fmt::Display for Dice_ui::US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US14 {
            US14_0,
            US14_1(Dice_ui::US13),
        }
        impl core::fmt::Display for Dice_ui::US14 {
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
            pub l0: std::collections::HashMap<std::string::String, std::string::String>,
        }
        impl core::fmt::Display for Dice_ui::Heap4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0,
            US15_1(LrcPtr<Dice_ui::Heap4>),
        }
        impl core::fmt::Display for Dice_ui::US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0(rexie::Error),
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
            US17_1(Dice_ui::US15),
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
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0(std::string::String),
            US23_1(std::string::String),
        }
        impl core::fmt::Display for Dice_ui::US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US24 {
            US24_0,
            US24_1(string),
        }
        impl core::fmt::Display for Dice_ui::US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US25 {
            US25_0,
            US25_1(Result<Option<string>, string>),
        }
        impl core::fmt::Display for Dice_ui::US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0,
            US27_1(crate::model::near::nearblocks::Root),
        }
        impl core::fmt::Display for Dice_ui::US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(string),
            US26_1(Dice_ui::US27),
        }
        impl core::fmt::Display for Dice_ui::US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US28 {
            US28_0(string),
            US28_1(Option<string>),
        }
        impl core::fmt::Display for Dice_ui::US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US29 {
            US29_0(string),
            US29_1(Option<crate::model::near::nearblocks::Root>),
        }
        impl core::fmt::Display for Dice_ui::US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US31 {
            US31_0(string),
            US31_1(
                Array<(
                    Array<(std::string::String, Dice_ui::US13)>,
                    u64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            ),
        }
        impl core::fmt::Display for Dice_ui::US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US30 {
            US30_0,
            US30_1(Dice_ui::US31),
        }
        impl core::fmt::Display for Dice_ui::US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US33 {
            US33_0,
            US33_1(
                Array<(
                    Array<(std::string::String, Dice_ui::US13)>,
                    u64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            ),
        }
        impl core::fmt::Display for Dice_ui::US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US32 {
            US32_0(string),
            US32_1(Dice_ui::US33),
        }
        impl core::fmt::Display for Dice_ui::US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Heap5 {
            pub l0: Array<(std::string::String, Dice_ui::US13)>,
            pub l1: u64,
            pub l2: u32,
            pub l3: std::string::String,
            pub l4: std::string::String,
            pub l5: Array<std::string::String>,
            pub l6: bool,
            pub l7: f64,
            pub l8: std::string::String,
            pub l9: std::string::String,
            pub l10: std::string::String,
            pub l11: std::string::String,
        }
        impl core::fmt::Display for Dice_ui::Heap5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US35 {
            US35_0(string),
            US35_1(Array<(usize, LrcPtr<Dice_ui::Heap5>)>),
        }
        impl core::fmt::Display for Dice_ui::US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0,
            US34_1(Dice_ui::US35),
        }
        impl core::fmt::Display for Dice_ui::US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US38 {
            US38_0,
            US38_1(Array<(usize, LrcPtr<Dice_ui::Heap5>)>),
        }
        impl core::fmt::Display for Dice_ui::US38 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US37 {
            US37_0(string),
            US37_1(Dice_ui::US38),
        }
        impl core::fmt::Display for Dice_ui::US37 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US36 {
            US36_0,
            US36_1(Dice_ui::US37),
        }
        impl core::fmt::Display for Dice_ui::US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US39 {
            US39_0,
            US39_1(chrono::NaiveDateTime),
        }
        impl core::fmt::Display for Dice_ui::US39 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US40 {
            US40_0(string),
            US40_1(string),
        }
        impl core::fmt::Display for Dice_ui::US40 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn closure1(unitVar: (), v0_1: web_sys::HtmlElement) -> Dice_ui::US0 {
            Dice_ui::US0::US0_1(v0_1)
        }
        pub fn method0() -> string {
            string("")
        }
        pub fn method1(v0_1: web_sys::HtmlElement) -> web_sys::HtmlElement {
            v0_1
        }
        pub fn method3() -> bool {
            false
        }
        pub fn method4() -> string {
            string("")
        }
        pub fn method5(v0_1: string) -> string {
            v0_1
        }
        pub fn method6(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method7(v0_1: LrcPtr<Dice_ui::Heap0>) -> LrcPtr<Dice_ui::Heap0> {
            v0_1
        }
        pub fn method8(
            v0_1: std::collections::HashMap<
                std::string::String,
                leptos::RwSignal<std::string::String>,
            >,
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<std::string::String>>
        {
            v0_1
        }
        pub fn method9(v0_1: LrcPtr<Dice_ui::Heap1>) -> LrcPtr<Dice_ui::Heap1> {
            v0_1
        }
        pub fn method10(
            v0_1: std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> {
            v0_1
        }
        pub fn method13() -> string {
            string("")
        }
        pub fn method14(v0_1: string) -> string {
            v0_1
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> Dice_ui::US1 {
            Dice_ui::US1::US1_0
        }
        pub fn method16() -> Func0<Dice_ui::US1> {
            Func0::new(move || Dice_ui::closure6((), ()))
        }
        pub fn closure8(unitVar: (), v0_1: rexie::Rexie) -> Dice_ui::US2 {
            Dice_ui::US2::US2_1(v0_1)
        }
        pub fn closure9(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US2 {
            Dice_ui::US2::US2_0(v0_1)
        }
        pub fn method17(v0_1: rexie::Rexie) -> Dice_ui::US2 {
            Dice_ui::US2::US2_1(v0_1)
        }
        pub fn method18(v0_1: rexie::Rexie) -> rexie::Rexie {
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
                        let v20: Dice_ui::US2 = Dice_ui::method17(match &v13 {
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
                    let v32: rexie::Rexie = Dice_ui::method18(match &v25 {
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
        pub fn method20(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> leptos::Resource<Dice_ui::US1, rexie::Rexie> {
            v0_1
        }
        pub fn closure10(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method20(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method19(
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
        pub fn method21(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure13(unitVar: (), v0_1: serde_json::Value) -> Dice_ui::US5 {
            Dice_ui::US5::US5_1(v0_1)
        }
        pub fn method22(v0_1: serde_json::Value) -> serde_json::Value {
            v0_1
        }
        pub fn method23(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn closure14(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap3>) -> Dice_ui::US3 {
            Dice_ui::US3::US3_1(v0_1)
        }
        pub fn method24(
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
        pub fn method25(v0_1: Dice_ui::US3) -> Dice_ui::US3 {
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
                        let v82: Dice_ui::US3 = Dice_ui::method25(match &v7 {
                            Dice_ui::US4::US4_1(v7_1_0) => {
                                let v10: string = string("state.get_data () / id: core-state-data");
                                leptos::logging::log!("{}", &v10);
                                {
                                    let v12: rexie::Rexie = Dice_ui::method21(v7_1_0.clone());
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
                                                        Dice_ui::method22(v32_1_0.clone());
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
                                                        let v40: Vec<u8> = Dice_ui::method23(v36);
                                                        let v42: Result<
                                                            LrcPtr<Dice_ui::Heap3>,
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
                                                        Dice_ui::US6::US6_1(defaultValue(Dice_ui::US3::US3_0,
                                                                                                           map(Func1::new(move
                                                                                                                              |v_2:
                                                                                                                                   LrcPtr<Dice_ui::Heap3>|
                                                                                                                              Dice_ui::closure14((),
                                                                                                                                                 v_2)),
                                                                                                               v42.ok())))
                                                    }
                                                }
                                                _ => Dice_ui::US6::US6_1(Dice_ui::US3::US3_0),
                                            };
                                            let v63: Result<Dice_ui::US3, rexie::Error> =
                                                Dice_ui::method24(match &v56 {
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
        pub fn method27() -> web_sys::Window {
            leptos::leptos_dom::window()
        }
        pub fn method29(v0_1: web_sys::Window) -> web_sys::Window {
            v0_1
        }
        pub fn method28(
            v0_1: web_sys::Window,
        ) -> Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> {
            let v1: web_sys::Window = Dice_ui::method29(v0_1);
            v1.local_storage()
        }
        pub fn closure18(unitVar: (), v0_1: Option<web_sys::Storage>) -> Dice_ui::US7 {
            Dice_ui::US7::US7_1(v0_1)
        }
        pub fn closure19(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Dice_ui::US7 {
            Dice_ui::US7::US7_0(v0_1)
        }
        pub fn closure20(unitVar: (), v0_1: web_sys::Storage) -> Dice_ui::US9 {
            Dice_ui::US9::US9_1(v0_1)
        }
        pub fn method30(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3> {
            v0_1
        }
        pub fn closure21(unitVar: (), v0_1: Dice_ui::US3) -> Dice_ui::US10 {
            Dice_ui::US10::US10_1(v0_1)
        }
        pub fn method31(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method32() -> string {
            string("core-state-data")
        }
        pub fn closure22(unitVar: (), v0_1: Option<std::string::String>) -> Dice_ui::US11 {
            Dice_ui::US11::US11_1(v0_1)
        }
        pub fn closure23(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Dice_ui::US11 {
            Dice_ui::US11::US11_0(v0_1)
        }
        pub fn method33(v0_1: Option<std::string::String>) -> Option<std::string::String> {
            v0_1
        }
        pub fn closure24(unitVar: (), v0_1: std::string::String) -> Dice_ui::US13 {
            Dice_ui::US13::US13_1(v0_1)
        }
        pub fn method34(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method35(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method37(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn closure26(v0_1: LrcPtr<Dice_ui::Heap3>, v1: bool) -> bool {
            v0_1.l0
        }
        pub fn method38(v0_1: LrcPtr<Dice_ui::Heap3>) -> Func1<bool, bool> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice_ui::closure26(v0_1.clone(), v)
            })
        }
        pub fn method39(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure27(v0_1: LrcPtr<Dice_ui::Heap3>, v1: bool) -> bool {
            v0_1.l1
        }
        pub fn method40(v0_1: LrcPtr<Dice_ui::Heap3>) -> Func1<bool, bool> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice_ui::closure27(v0_1.clone(), v)
            })
        }
        pub fn closure28(
            v0_1: LrcPtr<Dice_ui::Heap3>,
            v1: std::string::String,
        ) -> std::string::String {
            v0_1.l2.clone()
        }
        pub fn method41(
            v0_1: LrcPtr<Dice_ui::Heap3>,
        ) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure28(v0_1.clone(), v)
            })
        }
        pub fn method42(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn closure25(v0_1: LrcPtr<Dice_ui::Heap2>, v1: LrcPtr<Dice_ui::Heap3>, unitVar: ()) {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = v0_1.l0.clone();
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v2.clone());
            let v5: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method38(v1.clone());
            let v8: leptos::RwSignal<bool> = Dice_ui::method39(v5.l0.clone());
            let v9: string =
                string("leptos::SignalUpdate::update(&v8, |x| { let result = v7(x.clone()); if result != *x { *x = result } })");
            leptos::SignalUpdate::update(&v8, |x| {
                let result = v7(x.clone());
                if result != *x {
                    *x = result
                }
            });
            {
                let v10: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v2.clone());
                let v12: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v10);
                let v14 = Dice_ui::method40(v1.clone());
                let v15: leptos::RwSignal<bool> = Dice_ui::method39(v12.l1.clone());
                let v16: string =
                    string("leptos::SignalUpdate::update(&v15, |x| { let result = v14(x.clone()); if result != *x { *x = result } })");
                leptos::SignalUpdate::update(&v15, |x| {
                    let result = v14(x.clone());
                    if result != *x {
                        *x = result
                    }
                });
                {
                    let v17: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v2);
                    let v19: LrcPtr<Dice_ui::Heap0> =
                        leptos::SignalGetUntracked::get_untracked(&v17);
                    let v21 = Dice_ui::method41(v1);
                    let v22: leptos::RwSignal<std::string::String> =
                        Dice_ui::method42(v19.l2.clone());
                    let v23: string =
                        string("leptos::SignalUpdate::update(&v22, |x| { let result = v21(x.clone()); if result != *x { *x = result } })");
                    leptos::SignalUpdate::update(&v22, |x| {
                        let result = v21(x.clone());
                        if result != *x {
                            *x = result
                        }
                    });
                    ()
                }
            }
        }
        pub fn method36(v0_1: LrcPtr<Dice_ui::Heap2>, v1: LrcPtr<Dice_ui::Heap3>) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure25(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method43(v0_1: Func0<()>) -> Func0<()> {
            v0_1
        }
        pub fn closure17(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3>,
            unitVar: (),
        ) {
            leptos::logging::log!(
                "{}",
                &string("state.use_database () / effect core_state_data / ##1")
            );
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method28(Dice_ui::method27());
                let v8: Dice_ui::US7 = match &v5 {
                    Err(v5_1_0) => Dice_ui::closure19((), v5_1_0.clone()),
                    Ok(v5_0_0) => Dice_ui::closure18((), v5_0_0.clone()),
                };
                let v17: Dice_ui::US8 = match &v8 {
                    Dice_ui::US7::US7_1(v8_1_0) => Dice_ui::US8::US8_1(defaultValue(
                        Dice_ui::US9::US9_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure20((), v_2)),
                            v8_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US7::US7_0(v8_0_0) => Dice_ui::US8::US8_0(v8_0_0.clone()),
                };
                if let Dice_ui::US8::US8_1(v17_1_0) = &v17 {
                    let v18: Dice_ui::US9 = match &v17 {
                        Dice_ui::US8::US8_1(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Dice_ui::US9::US9_1(v18_1_0) = &v18 {
                        let v19: web_sys::Storage = match &v18 {
                            Dice_ui::US9::US9_1(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v20: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3> =
                            Dice_ui::method30(v1);
                        let v25: Dice_ui::US10 = defaultValue(
                            Dice_ui::US10::US10_0,
                            map(
                                Func1::new(move |v_3: Dice_ui::US3| Dice_ui::closure21((), v_3)),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v27: string =
                            append(append(string("state.use_database () / effect core_state_data / ##2 / core_state_data: "),
                                          sprintf!("{:?}", &v25)),
                                   string(""));
                        leptos::logging::log!("{}", &v27);
                        {
                            let v159: Dice_ui::US3 = if let Dice_ui::US10::US10_1(v25_1_0) = &v25 {
                                let v29: Dice_ui::US3 = match &v25 {
                                    Dice_ui::US10::US10_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Dice_ui::US3::US3_1(v29_1_0) = &v29 {
                                    Dice_ui::US3::US3_1(match &v29 {
                                        Dice_ui::US3::US3_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    let v32: web_sys::Storage = Dice_ui::method31(v19.clone());
                                    let v33: string = Dice_ui::method32();
                                    let v35: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v33);
                                    let v37: Result<
                                        Option<std::string::String>,
                                        wasm_bindgen::JsValue,
                                    > = web_sys::Storage::get_item(&v32, v35);
                                    let v40: Dice_ui::US11 = match &v37 {
                                        Err(v37_1_0) => Dice_ui::closure23((), v37_1_0.clone()),
                                        Ok(v37_0_0) => Dice_ui::closure22((), v37_0_0.clone()),
                                    };
                                    let v52: Dice_ui::US12 = match &v40 {
                                        Dice_ui::US11::US11_1(v40_1_0) => {
                                            let v42: Option<std::string::String> =
                                                Dice_ui::method33(v40_1_0.clone());
                                            Dice_ui::US12::US12_1(defaultValue(
                                                Dice_ui::US13::US13_0,
                                                map(
                                                    Func1::new(move |v_6: std::string::String| {
                                                        Dice_ui::closure24((), v_6)
                                                    }),
                                                    serde_json::from_value(v42.into()).unwrap(),
                                                ),
                                            ))
                                        }
                                        Dice_ui::US11::US11_0(v40_0_0) => {
                                            Dice_ui::US12::US12_0(v40_0_0.clone())
                                        }
                                    };
                                    let v58: Dice_ui::US14 = match &v52 {
                                        Dice_ui::US12::US12_1(v52_1_0) => {
                                            Dice_ui::US14::US14_1(v52_1_0.clone())
                                        }
                                        _ => Dice_ui::US14::US14_0,
                                    };
                                    let v65: Dice_ui::US13 =
                                        if let Dice_ui::US14::US14_1(v58_1_0) = &v58 {
                                            let v59: Dice_ui::US13 = match &v58 {
                                                Dice_ui::US14::US14_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if let Dice_ui::US13::US13_1(v59_1_0) = &v59 {
                                                Dice_ui::US13::US13_1(match &v59 {
                                                    Dice_ui::US13::US13_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            } else {
                                                Dice_ui::US13::US13_0
                                            }
                                        } else {
                                            Dice_ui::US13::US13_0
                                        };
                                    let v87: Dice_ui::US10 = match &v65 {
                                        Dice_ui::US13::US13_1(v65_1_0) => {
                                            let v68: std::string::String = Dice_ui::method35(
                                                Dice_ui::method34(v65_1_0.clone()),
                                            );
                                            let v72: string = Dice_ui::method5(Dice_ui::method14(
                                                fable_library_rust::String_::fromString(v68),
                                            ));
                                            let v74: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v72);
                                            let v76: std::string::String = String::from(v74);
                                            let v78: Result<
                                                LrcPtr<Dice_ui::Heap3>,
                                                serde_json::Error,
                                            > = serde_json::from_str(&v76);
                                            Dice_ui::US10::US10_1(defaultValue(
                                                Dice_ui::US3::US3_0,
                                                map(
                                                    Func1::new(
                                                        move |v_7: LrcPtr<Dice_ui::Heap3>| {
                                                            Dice_ui::closure14((), v_7)
                                                        },
                                                    ),
                                                    v78.ok(),
                                                ),
                                            ))
                                        }
                                        _ => Dice_ui::US10::US10_0,
                                    };
                                    if let Dice_ui::US10::US10_1(v87_1_0) = &v87 {
                                        let v88: Dice_ui::US3 = match &v87 {
                                            Dice_ui::US10::US10_1(x) => x.clone(),
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
                                let v96: web_sys::Storage = Dice_ui::method31(v19);
                                let v97: string = Dice_ui::method32();
                                let v99: &str = fable_library_rust::String_::LrcStr::as_str(&v97);
                                let v101: Result<
                                    Option<std::string::String>,
                                    wasm_bindgen::JsValue,
                                > = web_sys::Storage::get_item(&v96, v99);
                                let v104: Dice_ui::US11 = match &v101 {
                                    Err(v101_1_0) => Dice_ui::closure23((), v101_1_0.clone()),
                                    Ok(v101_0_0) => Dice_ui::closure22((), v101_0_0.clone()),
                                };
                                let v116: Dice_ui::US12 = match &v104 {
                                    Dice_ui::US11::US11_1(v104_1_0) => {
                                        let v106: Option<std::string::String> =
                                            Dice_ui::method33(v104_1_0.clone());
                                        Dice_ui::US12::US12_1(defaultValue(
                                            Dice_ui::US13::US13_0,
                                            map(
                                                Func1::new(move |v_10: std::string::String| {
                                                    Dice_ui::closure24((), v_10)
                                                }),
                                                serde_json::from_value(v106.into()).unwrap(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US11::US11_0(v104_0_0) => {
                                        Dice_ui::US12::US12_0(v104_0_0.clone())
                                    }
                                };
                                let v122: Dice_ui::US14 = match &v116 {
                                    Dice_ui::US12::US12_1(v116_1_0) => {
                                        Dice_ui::US14::US14_1(v116_1_0.clone())
                                    }
                                    _ => Dice_ui::US14::US14_0,
                                };
                                let v129: Dice_ui::US13 =
                                    if let Dice_ui::US14::US14_1(v122_1_0) = &v122 {
                                        let v123: Dice_ui::US13 = match &v122 {
                                            Dice_ui::US14::US14_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US13::US13_1(v123_1_0) = &v123 {
                                            Dice_ui::US13::US13_1(match &v123 {
                                                Dice_ui::US13::US13_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Dice_ui::US13::US13_0
                                        }
                                    } else {
                                        Dice_ui::US13::US13_0
                                    };
                                let v151: Dice_ui::US10 = match &v129 {
                                    Dice_ui::US13::US13_1(v129_1_0) => {
                                        let v132: std::string::String =
                                            Dice_ui::method35(Dice_ui::method34(v129_1_0.clone()));
                                        let v136: string = Dice_ui::method5(Dice_ui::method14(
                                            fable_library_rust::String_::fromString(v132),
                                        ));
                                        let v138: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v136);
                                        let v140: std::string::String = String::from(v138);
                                        let v142: Result<
                                            LrcPtr<Dice_ui::Heap3>,
                                            serde_json::Error,
                                        > = serde_json::from_str(&v140);
                                        Dice_ui::US10::US10_1(defaultValue(
                                            Dice_ui::US3::US3_0,
                                            map(
                                                Func1::new(move |v_11: LrcPtr<Dice_ui::Heap3>| {
                                                    Dice_ui::closure14((), v_11)
                                                }),
                                                v142.ok(),
                                            ),
                                        ))
                                    }
                                    _ => Dice_ui::US10::US10_0,
                                };
                                if let Dice_ui::US10::US10_1(v151_1_0) = &v151 {
                                    let v152: Dice_ui::US3 = match &v151 {
                                        Dice_ui::US10::US10_1(x) => x.clone(),
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
                                let v164 = Dice_ui::method36(
                                    v0_1,
                                    match &v159 {
                                        Dice_ui::US3::US3_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                );
                                let v167: Func0<()> = Dice_ui::method43(Func0::new(move || v164()));
                                leptos::batch(move || v167());
                                ()
                            }
                        }
                    }
                }
            }
        }
        pub fn method26(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure17(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure29(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method20(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method44(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure29(v0_1.clone(), ())
            })
        }
        pub fn closure31(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap4>) -> Dice_ui::US15 {
            Dice_ui::US15::US15_1(v0_1)
        }
        pub fn method45(
            v0_1: Result<Dice_ui::US15, rexie::Error>,
        ) -> Result<Dice_ui::US15, rexie::Error> {
            v0_1
        }
        pub fn closure32(unitVar: (), v0_1: Dice_ui::US15) -> Dice_ui::US16 {
            Dice_ui::US16::US16_1(v0_1)
        }
        pub fn closure33(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US16 {
            Dice_ui::US16::US16_0(v0_1)
        }
        pub fn method46(v0_1: Dice_ui::US15) -> Dice_ui::US15 {
            v0_1
        }
        pub fn closure30(
            unitVar: (),
            v0_1: Option<rexie::Rexie>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Dice_ui::US15>>> {
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
                        let v82: Dice_ui::US15 = Dice_ui::method46(match &v7 {
                            Dice_ui::US4::US4_1(v7_1_0) => {
                                let v10: string = string("state.get_data () / id: state-data");
                                leptos::logging::log!("{}", &v10);
                                {
                                    let v12: rexie::Rexie = Dice_ui::method21(v7_1_0.clone());
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
                                            let v56: Dice_ui::US16 = match &v32 {
                                                Dice_ui::US5::US5_1(v32_1_0) => {
                                                    let v34: serde_json::Value =
                                                        Dice_ui::method22(v32_1_0.clone());
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
                                                        let v40: Vec<u8> = Dice_ui::method23(v36);
                                                        let v42: Result<
                                                            LrcPtr<Dice_ui::Heap4>,
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
                                                        Dice_ui::US16::US16_1(defaultValue(Dice_ui::US15::US15_0,
                                                                                                             map(Func1::new(move
                                                                                                                                |v_2:
                                                                                                                                     LrcPtr<Dice_ui::Heap4>|
                                                                                                                                Dice_ui::closure31((),
                                                                                                                                                   v_2)),
                                                                                                                 v42.ok())))
                                                    }
                                                }
                                                _ => Dice_ui::US16::US16_1(Dice_ui::US15::US15_0),
                                            };
                                            let v63: Result<Dice_ui::US15, rexie::Error> =
                                                Dice_ui::method45(match &v56 {
                                                    Dice_ui::US16::US16_1(v56_1_0) => {
                                                        Ok(v56_1_0.clone())
                                                    }
                                                    Dice_ui::US16::US16_0(v56_0_0) => {
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
                                                        Output = Result<
                                                            Dice_ui::US15,
                                                            rexie::Error,
                                                        >,
                                                    >,
                                                >,
                                            > = __future_init;
                                            let v69: Result<Dice_ui::US15, rexie::Error> =
                                                v67.await;
                                            let v72: Dice_ui::US16 = match &v69 {
                                                Err(v69_1_0) => {
                                                    Dice_ui::closure33((), v69_1_0.clone())
                                                }
                                                Ok(v69_0_0) => {
                                                    Dice_ui::closure32((), v69_0_0.clone())
                                                }
                                            };
                                            match &v72 {
                                                Dice_ui::US16::US16_1(v72_1_0) => v72_1_0.clone(),
                                                Dice_ui::US16::US16_0(v72_0_0) => panic!(
                                                    "{}",
                                                    sprintf!("Result value was Error: {}", v72_0_0),
                                                ),
                                            }
                                        }
                                    }
                                }
                            }
                            _ => Dice_ui::US15::US15_0,
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
        pub fn method48(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US15>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Dice_ui::US15> {
            v0_1
        }
        pub fn closure35(unitVar: (), v0_1: Dice_ui::US15) -> Dice_ui::US17 {
            Dice_ui::US17::US17_1(v0_1)
        }
        pub fn method50(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> {
            v0_1
        }
        pub fn method53(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure38(
            unitVar: (),
            v0_1: std::string::String,
        ) -> leptos::RwSignal<std::string::String> {
            let v2: std::string::String = Dice_ui::method6(Dice_ui::method53(v0_1));
            leptos::create_rw_signal(v2)
        }
        pub fn method52() -> Func1<std::string::String, leptos::RwSignal<std::string::String>> {
            Func1::new(move |v: std::string::String| Dice_ui::closure38((), v))
        }
        pub fn method54(
            v0_1: std::collections::HashMap<std::string::String, std::string::String>,
        ) -> std::collections::HashMap<std::string::String, std::string::String> {
            v0_1
        }
        pub fn closure37(
            v0_1: LrcPtr<Dice_ui::Heap4>,
            v1: std::collections::HashMap<
                std::string::String,
                leptos::RwSignal<std::string::String>,
            >,
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<std::string::String>>
        {
            let v3 = Dice_ui::method52();
            let v4: std::collections::HashMap<std::string::String, std::string::String> =
                Dice_ui::method54(v0_1.l0.clone());
            v4.into_iter().map(|(k, v)| (k, v3(v))).collect()
        }
        pub fn method51(
            v0_1: LrcPtr<Dice_ui::Heap4>,
        ) -> Func1<
            std::collections::HashMap<std::string::String, leptos::RwSignal<std::string::String>>,
            std::collections::HashMap<std::string::String, leptos::RwSignal<std::string::String>>,
        > {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::collections::HashMap<
                    std::string::String,
                    leptos::RwSignal<std::string::String>,
                >| Dice_ui::closure37(v0_1.clone(), v)
            })
        }
        pub fn method55(
            v0_1: leptos::RwSignal<
                std::collections::HashMap<
                    std::string::String,
                    leptos::RwSignal<std::string::String>,
                >,
            >,
        ) -> leptos::RwSignal<
            std::collections::HashMap<std::string::String, leptos::RwSignal<std::string::String>>,
        > {
            v0_1
        }
        pub fn closure36(v0_1: LrcPtr<Dice_ui::Heap2>, v1: LrcPtr<Dice_ui::Heap4>, unitVar: ()) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method50(v0_1.l2.clone());
            let v5: LrcPtr<Dice_ui::Heap1> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method51(v1);
            let v8: leptos::RwSignal<
                std::collections::HashMap<
                    std::string::String,
                    leptos::RwSignal<std::string::String>,
                >,
            > = Dice_ui::method55(v5.l0.clone());
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
        pub fn method49(v0_1: LrcPtr<Dice_ui::Heap2>, v1: LrcPtr<Dice_ui::Heap4>) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure36(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure34(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US15>,
            unitVar: (),
        ) {
            leptos::logging::log!(
                "{}",
                &string("state.use_database () / effect state_data / ##1")
            );
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method28(Dice_ui::method27());
                let v8: Dice_ui::US7 = match &v5 {
                    Err(v5_1_0) => Dice_ui::closure19((), v5_1_0.clone()),
                    Ok(v5_0_0) => Dice_ui::closure18((), v5_0_0.clone()),
                };
                let v17: Dice_ui::US8 = match &v8 {
                    Dice_ui::US7::US7_1(v8_1_0) => Dice_ui::US8::US8_1(defaultValue(
                        Dice_ui::US9::US9_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure20((), v_2)),
                            v8_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US7::US7_0(v8_0_0) => Dice_ui::US8::US8_0(v8_0_0.clone()),
                };
                if let Dice_ui::US8::US8_1(v17_1_0) = &v17 {
                    if let Dice_ui::US9::US9_1(_) = &match &v17 {
                        Dice_ui::US8::US8_1(x) => x.clone(),
                        _ => unreachable!(),
                    } {
                        let v20: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US15> =
                            Dice_ui::method48(v1);
                        let v25: Dice_ui::US17 = defaultValue(
                            Dice_ui::US17::US17_0,
                            map(
                                Func1::new(move |v_3: Dice_ui::US15| Dice_ui::closure35((), v_3)),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v32: Dice_ui::US15 = if let Dice_ui::US17::US17_1(v25_1_0) = &v25 {
                            let v26: Dice_ui::US15 = match &v25 {
                                Dice_ui::US17::US17_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Dice_ui::US15::US15_1(v26_1_0) = &v26 {
                                Dice_ui::US15::US15_1(match &v26 {
                                    Dice_ui::US15::US15_1(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            } else {
                                Dice_ui::US15::US15_0
                            }
                        } else {
                            Dice_ui::US15::US15_0
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
                            if let Dice_ui::US15::US15_1(v32_1_0) = &v32 {
                                let v40 = Dice_ui::method49(
                                    v0_1,
                                    match &v32 {
                                        Dice_ui::US15::US15_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                );
                                let v43: Func0<()> = Dice_ui::method43(Func0::new(move || v40()));
                                leptos::batch(move || v43());
                                ()
                            }
                        }
                    };
                }
            }
        }
        pub fn method47(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US15>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure34(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method57(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn method58(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> Dice_ui::US18 {
            Dice_ui::US18::US18_1
        }
        pub fn closure41(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US18 {
            Dice_ui::US18::US18_0(v0_1)
        }
        pub fn method59() {
            ();
        }
        pub fn closure39(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            v1: LrcPtr<Dice_ui::Heap3>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v2: string = sprintf!("{:?}", &v1);
            let v3: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method20(v0_1);
            let v8: Dice_ui::US4 = defaultValue(
                Dice_ui::US4::US4_0,
                map(
                    Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                    leptos::SignalGet::get(&v3),
                ),
            );
            let __future_init = Box::pin(async move {
                //;
                match &v8 {
                    Dice_ui::US4::US4_1(v8_1_0) => {
                        let v11: string = append(
                            append(
                                string(
                                    "state.use_database () / set_core_state_data_action / value: ",
                                ),
                                v2,
                            ),
                            string(""),
                        );
                        leptos::logging::log!("{}", &v11);
                        {
                            let v14: string = append(
                                append(string("state.set_data () / data: "), sprintf!("{:?}", &v1)),
                                string(""),
                            );
                            leptos::logging::log!("{}", &v14);
                            {
                                let v16: rexie::Rexie = Dice_ui::method57(v8_1_0.clone());
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v19: rexie::Transaction = v16.transaction(
                                            &["store"],
                                            rexie::TransactionMode::ReadWrite,
                                        )?;
                                        let v21: rexie::Store = v19.store("store")?;
                                        let mut data = Vec::new();
                                        borsh::BorshSerialize::serialize(&v1, &mut data).unwrap();
                                        {
                                            let v25: Vec<u8> = data;
                                            let v27: wasm_bindgen::JsValue =
                                                serde_wasm_bindgen::to_value(&v25).unwrap();
                                            let v28: string = Dice_ui::method32();
                                            let v30: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v28);
                                            v21.put(&v27, Some(&v30.into())).await?;
                                            v19.done().await?;
                                            {
                                                let v34: Result<(), rexie::Error> =
                                                    Dice_ui::method58(Ok(()));
                                                v34
                                            }
                                        }
                                    }
                                });
                                {
                                    {
                                        {
                                            //;
                                            {
                                                let v37: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<(), rexie::Error>,
                                                        >,
                                                    >,
                                                > = __future_init;
                                                let v39: Result<(), rexie::Error> = v37.await;
                                                let v42: Dice_ui::US18 = match &v39 {
                                                    Err(v39_1_0) => {
                                                        Dice_ui::closure41((), v39_1_0.clone())
                                                    }
                                                    _ => Dice_ui::closure40((), ()),
                                                };
                                                match &v42 {
                                                    Dice_ui::US18::US18_1 => (),
                                                    Dice_ui::US18::US18_0(v42_0_0) => panic!(
                                                        "{}",
                                                        sprintf!(
                                                            "Result value was Error: {}",
                                                            v42_0_0
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
                Dice_ui::method59();
                ()
            });
            // ;
            __future_init
        }
        pub fn method56(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func1<LrcPtr<Dice_ui::Heap3>, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_ui::Heap3>| Dice_ui::closure39(v0_1.clone(), v)
            })
        }
        pub fn method61(
            v0_1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::RwSignal<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn closure42(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            unitVar: (),
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> {
            leptos::logging::log!("{}", &string("state.use_database () / loading create_memo"));
            {
                let v4: leptos::RwSignal<
                    std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                > = Dice_ui::method61(v0_1.l1.clone());
                leptos::SignalGetUntracked::get_untracked(&v4)
            }
        }
        pub fn method60(
            v0_1: LrcPtr<Dice_ui::Heap2>,
        ) -> Func0<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure42(v0_1.clone(), ())
            })
        }
        pub fn method62() -> bool {
            false
        }
        pub fn method64(v0_1: leptos::ReadSignal<bool>) -> leptos::ReadSignal<bool> {
            v0_1
        }
        pub fn method65(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn method66(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method67(
            v0_1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::Memo<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn method68() -> string {
            string("dark_mode_key")
        }
        pub fn method69(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure44(unitVar: (), v0_1: leptos::RwSignal<bool>) -> Dice_ui::US19 {
            Dice_ui::US19::US19_1(v0_1)
        }
        pub fn method70() -> bool {
            true
        }
        pub fn method71(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method72(v0_1: LrcPtr<Dice_ui::Heap3>) -> LrcPtr<Dice_ui::Heap3> {
            v0_1
        }
        pub fn method73(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method74(v0_1: LrcPtr<Dice_ui::Heap3>) -> LrcPtr<Dice_ui::Heap3> {
            v0_1
        }
        pub fn method75(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure43(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()>,
            v2: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            v3: leptos::WriteSignal<bool>,
            v4: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v5: leptos::ReadSignal<bool> = Dice_ui::method64(v4);
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
                let v10: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = v0_1.l0.clone();
                let v11: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v10.clone());
                let v15: leptos::RwSignal<bool> =
                    Dice_ui::method65((leptos::SignalGetUntracked::get_untracked(&v11)).l0.clone());
                let v17: bool = leptos::SignalGet::get(&v15);
                let v18: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v10.clone());
                let v22: leptos::RwSignal<bool> =
                    Dice_ui::method65((leptos::SignalGetUntracked::get_untracked(&v18)).l1.clone());
                let v24: bool = leptos::SignalGet::get(&v22);
                let v25: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v10);
                let v29: leptos::RwSignal<std::string::String> =
                    Dice_ui::method66((leptos::SignalGetUntracked::get_untracked(&v25)).l2.clone());
                let v32: LrcPtr<Dice_ui::Heap3> = LrcPtr::new(Dice_ui::Heap3 {
                    l0: v17,
                    l1: v24,
                    l2: leptos::SignalGet::get(&v29),
                });
                let v34: string =
                    append(append(string("state.use_database () / effect new_core_state_data / ##2 / new_core_state_data: "),
                                  sprintf!("{:?}", &v32)), string(""));
                leptos::logging::log!("{}", &v34);
                {
                    let v36: leptos::Memo<
                        std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                    > = Dice_ui::method67(v2);
                    let v38: std::collections::HashMap<
                        std::string::String,
                        leptos::RwSignal<bool>,
                    > = v36();
                    let v40: string = Dice_ui::method5(Dice_ui::method68());
                    let v42: &str = fable_library_rust::String_::LrcStr::as_str(&v40);
                    let v45: std::string::String = Dice_ui::method69(String::from(v42));
                    let v50: Dice_ui::US19 = defaultValue(
                        Dice_ui::US19::US19_0,
                        map(
                            Func1::new(move |v: leptos::RwSignal<bool>| Dice_ui::closure44((), v)),
                            std::collections::HashMap::get(&v38, &v45).map(|x| *x),
                        ),
                    );
                    let v58: Dice_ui::US20 = match &v50 {
                        Dice_ui::US19::US19_1(v50_1_0) => {
                            let v52: leptos::RwSignal<bool> = Dice_ui::method65(v50_1_0.clone());
                            Dice_ui::US20::US20_1(leptos::SignalGet::get(&v52))
                        }
                        _ => Dice_ui::US20::US20_0,
                    };
                    let v61: bool = match &v58 {
                        Dice_ui::US20::US20_1(v58_1_0) => v58_1_0.clone(),
                        _ => false,
                    };
                    let v62: string =
                        append(append(string("state.use_database () / effect new_core_state_data / ##3 / dark_mode_loading: "),
                                      ofBoolean(v61)), string(""));
                    leptos::logging::log!("{}", &v62);
                    if v61 == false {
                        if v7 == false {
                            let v66: bool = Dice_ui::method70();
                            let v67: leptos::WriteSignal<bool> = Dice_ui::method71(v3);
                            leptos::SignalSet::set(&v67, v66);
                            ()
                        } else {
                            leptos::logging::log!(
                                "{}",
                                &string("state.use_database () / effect new_core_state_data / ##4")
                            );
                            {
                                let v72: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                                    Dice_ui::method28(Dice_ui::method27());
                                let v75: Dice_ui::US7 = match &v72 {
                                    Err(v72_1_0) => Dice_ui::closure19((), v72_1_0.clone()),
                                    Ok(v72_0_0) => Dice_ui::closure18((), v72_0_0.clone()),
                                };
                                let v84: Dice_ui::US8 = match &v75 {
                                    Dice_ui::US7::US7_1(v75_1_0) => {
                                        Dice_ui::US8::US8_1(defaultValue(
                                            Dice_ui::US9::US9_0,
                                            map(
                                                Func1::new(move |v_3: web_sys::Storage| {
                                                    Dice_ui::closure20((), v_3)
                                                }),
                                                v75_1_0.clone(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US7::US7_0(v75_0_0) => {
                                        Dice_ui::US8::US8_0(v75_0_0.clone())
                                    }
                                };
                                if let Dice_ui::US8::US8_1(v84_1_0) = &v84 {
                                    let v85: Dice_ui::US9 = match &v84 {
                                        Dice_ui::US8::US8_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Dice_ui::US9::US9_1(v85_1_0) = &v85 {
                                        let v87: LrcPtr<Dice_ui::Heap3> =
                                            Dice_ui::method72(v32.clone());
                                        leptos::Action::dispatch(&v1, v87);
                                        {
                                            let v89: web_sys::Storage =
                                                Dice_ui::method73(match &v85 {
                                                    Dice_ui::US9::US9_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                });
                                            let v90: string = Dice_ui::method32();
                                            let v92: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v90);
                                            let v93: LrcPtr<Dice_ui::Heap3> =
                                                Dice_ui::method74(v32);
                                            let v96: std::string::String = Dice_ui::method75(
                                                serde_json::json!(v93).to_string(),
                                            );
                                            let v98: &str = v96.as_str();
                                            web_sys::Storage::set(&v89, v92, v98).unwrap();
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
        pub fn method63(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()>,
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
                    Dice_ui::closure43(
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
        pub fn method77() -> string {
            string("state-data")
        }
        pub fn closure45(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            v1: LrcPtr<Dice_ui::Heap4>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v2: string = sprintf!("{:?}", &v1);
            let v3: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method20(v0_1);
            let v8: Dice_ui::US4 = defaultValue(
                Dice_ui::US4::US4_0,
                map(
                    Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                    leptos::SignalGet::get(&v3),
                ),
            );
            let __future_init = Box::pin(async move {
                //;
                match &v8 {
                    Dice_ui::US4::US4_1(v8_1_0) => {
                        let v11: string =
                        append(append(string("state.use_database () / set_state_data_action / database=Some(_) / value: "),
                                      v2), string(""));
                        leptos::logging::log!("{}", &v11);
                        {
                            let v14: string = append(
                                append(string("state.set_data () / data: "), sprintf!("{:?}", &v1)),
                                string(""),
                            );
                            leptos::logging::log!("{}", &v14);
                            {
                                let v16: rexie::Rexie = Dice_ui::method57(v8_1_0.clone());
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v19: rexie::Transaction = v16.transaction(
                                            &["store"],
                                            rexie::TransactionMode::ReadWrite,
                                        )?;
                                        let v21: rexie::Store = v19.store("store")?;
                                        let mut data = Vec::new();
                                        borsh::BorshSerialize::serialize(&v1, &mut data).unwrap();
                                        {
                                            let v25: Vec<u8> = data;
                                            let v27: wasm_bindgen::JsValue =
                                                serde_wasm_bindgen::to_value(&v25).unwrap();
                                            let v28: string = Dice_ui::method77();
                                            let v30: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v28);
                                            v21.put(&v27, Some(&v30.into())).await?;
                                            v19.done().await?;
                                            {
                                                let v34: Result<(), rexie::Error> =
                                                    Dice_ui::method58(Ok(()));
                                                v34
                                            }
                                        }
                                    }
                                });
                                {
                                    {
                                        {
                                            //;
                                            {
                                                let v37: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<(), rexie::Error>,
                                                        >,
                                                    >,
                                                > = __future_init;
                                                let v39: Result<(), rexie::Error> = v37.await;
                                                let v42: Dice_ui::US18 = match &v39 {
                                                    Err(v39_1_0) => {
                                                        Dice_ui::closure41((), v39_1_0.clone())
                                                    }
                                                    _ => Dice_ui::closure40((), ()),
                                                };
                                                match &v42 {
                                                    Dice_ui::US18::US18_1 => (),
                                                    Dice_ui::US18::US18_0(v42_0_0) => panic!(
                                                        "{}",
                                                        sprintf!(
                                                            "Result value was Error: {}",
                                                            v42_0_0
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
                Dice_ui::method59();
                ()
            });
            // ;
            __future_init
        }
        pub fn method76(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func1<LrcPtr<Dice_ui::Heap4>, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_ui::Heap4>| Dice_ui::closure45(v0_1.clone(), v)
            })
        }
        pub fn method79(
            v0_1: leptos::RwSignal<
                std::collections::HashMap<
                    std::string::String,
                    leptos::RwSignal<std::string::String>,
                >,
            >,
        ) -> leptos::RwSignal<
            std::collections::HashMap<std::string::String, leptos::RwSignal<std::string::String>>,
        > {
            v0_1
        }
        pub fn closure47(
            unitVar: (),
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> std::string::String {
            let v1: leptos::RwSignal<std::string::String> = Dice_ui::method66(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method80() -> Func1<leptos::RwSignal<std::string::String>, std::string::String> {
            Func1::new(move |v: leptos::RwSignal<std::string::String>| Dice_ui::closure47((), v))
        }
        pub fn method81(
            v0_1: std::collections::HashMap<
                std::string::String,
                leptos::RwSignal<std::string::String>,
            >,
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<std::string::String>>
        {
            v0_1
        }
        pub fn method82(v0_1: LrcPtr<Dice_ui::Heap4>) -> LrcPtr<Dice_ui::Heap4> {
            v0_1
        }
        pub fn closure46(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::WriteSignal<bool>,
            v2: leptos::ReadSignal<bool>,
            v3: leptos::Action<LrcPtr<Dice_ui::Heap4>, ()>,
            unitVar: (),
        ) {
            let v4: leptos::ReadSignal<bool> = Dice_ui::method64(v2);
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
                let v10: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                    Dice_ui::method50(v0_1.l2.clone());
                let v14: leptos::RwSignal<
                    std::collections::HashMap<
                        std::string::String,
                        leptos::RwSignal<std::string::String>,
                    >,
                > = Dice_ui::method79((leptos::SignalGetUntracked::get_untracked(&v10)).l0.clone());
                let v16: std::collections::HashMap<
                    std::string::String,
                    leptos::RwSignal<std::string::String>,
                > = leptos::SignalGet::get(&v14);
                let v17 = Dice_ui::method80();
                let v18: std::collections::HashMap<
                    std::string::String,
                    leptos::RwSignal<std::string::String>,
                > = Dice_ui::method81(v16);
                let v21: LrcPtr<Dice_ui::Heap4> = LrcPtr::new(Dice_ui::Heap4 {
                    l0: v18.into_iter().map(|(k, v)| (k, v17(v))).collect(),
                });
                let v23: string =
                    append(append(string("state.use_database () / effect new_state_data / ##2 / new_state_data: "),
                                  sprintf!("{:?}", &v21)), string(""));
                leptos::logging::log!("{}", &v23);
                if v6 == false {
                    let v26: bool = Dice_ui::method70();
                    let v27: leptos::WriteSignal<bool> = Dice_ui::method71(v1);
                    leptos::SignalSet::set(&v27, v26);
                    ()
                } else {
                    leptos::logging::log!(
                        "{}",
                        &string("state.use_database () / effect new_state_data / ##4")
                    );
                    {
                        let v32: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                            Dice_ui::method28(Dice_ui::method27());
                        let v35: Dice_ui::US7 = match &v32 {
                            Err(v32_1_0) => Dice_ui::closure19((), v32_1_0.clone()),
                            Ok(v32_0_0) => Dice_ui::closure18((), v32_0_0.clone()),
                        };
                        let v44: Dice_ui::US8 = match &v35 {
                            Dice_ui::US7::US7_1(v35_1_0) => Dice_ui::US8::US8_1(defaultValue(
                                Dice_ui::US9::US9_0,
                                map(
                                    Func1::new(move |v_2: web_sys::Storage| {
                                        Dice_ui::closure20((), v_2)
                                    }),
                                    v35_1_0.clone(),
                                ),
                            )),
                            Dice_ui::US7::US7_0(v35_0_0) => Dice_ui::US8::US8_0(v35_0_0.clone()),
                        };
                        if let Dice_ui::US8::US8_1(v44_1_0) = &v44 {
                            if let Dice_ui::US9::US9_1(_) = &match &v44 {
                                Dice_ui::US8::US8_1(x) => x.clone(),
                                _ => unreachable!(),
                            } {
                                let v47: LrcPtr<Dice_ui::Heap4> = Dice_ui::method82(v21);
                                leptos::Action::dispatch(&v3, v47);
                                ()
                            };
                        }
                    }
                }
            }
        }
        pub fn method78(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::WriteSignal<bool>,
            v2: leptos::ReadSignal<bool>,
            v3: leptos::Action<LrcPtr<Dice_ui::Heap4>, ()>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move || Dice_ui::closure46(v0_1.clone(), v1.clone(), v2.clone(), v3.clone(), ())
            })
        }
        pub fn closure48(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method65((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method83(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure48(v0_1.clone(), ())
            })
        }
        pub fn method85(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method86(
            v0_1: leptos::Memo<std::string::String>,
        ) -> leptos::Memo<std::string::String> {
            v0_1
        }
        pub fn method87(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method88() -> Dice_ui::US21 {
            Dice_ui::US21::US21_0
        }
        pub fn method90(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method91(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure51(v0_1: string, v1: std::string::String) -> std::string::String {
            let v3: string = Dice_ui::method5(Dice_ui::method14(v0_1));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            String::from(v5)
        }
        pub fn method92(v0_1: string) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure51(v0_1.clone(), v)
            })
        }
        pub fn closure50(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: LrcPtr<Dice_ui::Heap2>,
            v4: leptos::WriteSignal<bool>,
            v5: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v6: leptos::ReadSignal<bool> = Dice_ui::method64(v5);
            let v8: bool = leptos::SignalGet::get(&v6);
            let v9: leptos_router::Location = Dice_ui::method90(v0_1);
            let v12: leptos::Memo<std::string::String> = Dice_ui::method86(v9.hash);
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
                let v19: std::string::String = Dice_ui::method91(v14);
                if v19 == "" {
                    let v23: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                        Dice_ui::method37(v3.l0.clone());
                    let v27: leptos::RwSignal<std::string::String> = Dice_ui::method66(
                        (leptos::SignalGetUntracked::get_untracked(&v23)).l2.clone(),
                    );
                    let v30: std::string::String = Dice_ui::method35(leptos::SignalGet::get(&v27));
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
                        let v37: string = Dice_ui::method5(v32);
                        let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
                        v1(v39, Default::default());
                        ()
                    }
                }
                {
                    let v41: bool = Dice_ui::method70();
                    let v42: leptos::WriteSignal<bool> = Dice_ui::method71(v4);
                    leptos::SignalSet::set(&v42, v41);
                    ()
                }
            } else {
                let v45: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                    Dice_ui::method37(v3.l0.clone());
                let v47: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v45);
                let v49 = Dice_ui::method92(v15);
                let v50: leptos::RwSignal<std::string::String> = Dice_ui::method42(v47.l2.clone());
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
        pub fn method89(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: LrcPtr<Dice_ui::Heap2>,
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
                    Dice_ui::closure50(
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
        pub fn method94(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method95(v0_1: &str) -> &str {
            v0_1
        }
        pub fn closure53(unitVar: (), v0_1: leptos_router::Url) -> Dice_ui::US22 {
            Dice_ui::US22::US22_1(v0_1)
        }
        pub fn closure54(unitVar: (), v0_1: std::string::String) -> Dice_ui::US22 {
            Dice_ui::US22::US22_0(v0_1)
        }
        pub fn method96() -> string {
            string("/settings")
        }
        pub fn method97(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure55(v0_1: Dice_ui::US21, v1: Dice_ui::US21) -> Dice_ui::US21 {
            v0_1
        }
        pub fn method98(v0_1: Dice_ui::US21) -> Func1<Dice_ui::US21, Dice_ui::US21> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Dice_ui::US21| Dice_ui::closure55(v0_1.clone(), v)
            })
        }
        pub fn method99(
            v0_1: leptos::WriteSignal<Dice_ui::US21>,
        ) -> leptos::WriteSignal<Dice_ui::US21> {
            v0_1
        }
        pub fn closure52(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US21>,
            unitVar: (),
        ) {
            let v2: leptos_router::Location = Dice_ui::method90(v0_1);
            let v5: leptos::Memo<std::string::String> = Dice_ui::method86(v2.hash);
            let v8: std::string::String = Dice_ui::method94(v5());
            let v10: Option<&str> = v8.strip_prefix('#');
            let v12: string = string("r#\"\"#");
            let v13: &str = r#""#;
            let v16: &str = Dice_ui::method95(v10.unwrap_or(v13));
            let v18: Result<leptos_router::Url, std::string::String> =
                leptos_router::Url::try_from(v16);
            let v21: Dice_ui::US22 = match &v18 {
                Err(v18_1_0) => Dice_ui::closure54((), v18_1_0.clone()),
                Ok(v18_0_0) => Dice_ui::closure53((), v18_0_0.clone()),
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
                let v35: string = Dice_ui::method5(Dice_ui::method96());
                let v37: &str = fable_library_rust::String_::LrcStr::as_str(&v35);
                let v39: std::string::String = String::from(v37);
                let v40: std::string::String = Dice_ui::method97(v33);
                let v45: Dice_ui::US21 = if v40.starts_with(&v39) {
                    Dice_ui::US21::US21_1
                } else {
                    Dice_ui::US21::US21_2
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
                    let v50 = Dice_ui::method98(v45);
                    let v51: leptos::WriteSignal<Dice_ui::US21> = Dice_ui::method99(v1);
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
        pub fn method93(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US21>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure52(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method103(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
        ) -> leptos::ReadSignal<Dice_ui::US21> {
            v0_1
        }
        pub fn method105() -> string {
            string("View")
        }
        pub fn method108() -> string {
            string("Dark Mode")
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method108()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method107() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure61((), ()))
        }
        pub fn method110() -> string {
            string("dark-mode")
        }
        pub fn closure64(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method112() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure64((), v))
        }
        pub fn closure63(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method112();
            let v8: leptos::RwSignal<bool> = Dice_ui::method39(v5.l0.clone());
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
        pub fn method111(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure63(v0_1.clone(), v)
            })
        }
        pub fn closure65(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method65((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method113(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure65(v0_1.clone(), ())
            })
        }
        pub fn method114(
            v0_1: leptos::HtmlElement<leptos::html::Label>,
        ) -> leptos::HtmlElement<leptos::html::Label> {
            v0_1
        }
        pub fn closure62(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method110());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method111(v0_1.clone());
            let v8 = Dice_ui::method113(v0_1);
            let v9: string =
                string("<label for={v6.clone()} class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\"><input type=\"checkbox\" id={v6} class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"><svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg><svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg></span><span class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"></span></label>");
            let v10: string = append(append(string("leptos::view! { "), v9), string(" }"));
            let v13: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method114(
                leptos::view! { <label for={v6.clone()} class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"><input type="checkbox" id={v6} class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400"><svg data-unchecked-icon xmlns="http://www.w3.org/2000/svg" class="h-4 w-4" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" clip-rule="evenodd" /></svg><svg data-checked-icon xmlns="http://www.w3.org/2000/svg" class="hidden h-4 w-4" viewBox="0 0 20 20" fill="currentColor"> <path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" /></svg></span><span class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300"></span></label> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method109(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure62(v0_1.clone(), ())
            })
        }
        pub fn method116(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method117(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method119(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method120(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure67(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method119(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method120(Func0::new(move || v1()));
            let v6: leptos::View = leptos::IntoView::into_view(move || v4());
            leptos::Fragment::new(vec![v6])
        }
        pub fn method118(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure67(v0_1.clone(), ())
            })
        }
        pub fn method121(
            v0_1: leptos::HtmlElement<leptos::html::Dt>,
        ) -> leptos::HtmlElement<leptos::html::Dt> {
            v0_1
        }
        pub fn method122(
            v0_1: leptos::HtmlElement<leptos::html::Dd>,
        ) -> leptos::HtmlElement<leptos::html::Dd> {
            v0_1
        }
        pub fn method123(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method124(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method125(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn closure66(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"[font-size:11px] text-gray-400\"");
            let v7 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method116(v0_1)));
            let v10: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dt "), v5), string(">{v7()}</")),
                            string("dt"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v13: leptos::HtmlElement<leptos::html::Dt> = Dice_ui::method121(
                leptos::view! { <dt  class="[font-size:11px] text-gray-400">{v7()}</dt> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            let v18: string =
                string(" class=\"[overflow:auto] text-gray-700 sm:col-span-2 flex flex-1\"");
            let v20 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method116(v1)));
            let v23: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dd "), v18), string(">{v20()}</")),
                            string("dd"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v26: leptos::HtmlElement<leptos::html::Dd> = Dice_ui::method122(
                leptos::view! { <dd  class="[overflow:auto] text-gray-700 sm:col-span-2 flex flex-1">{v20()}</dd> },
            );
            let v32: Array<leptos::View> =
                Dice_ui::method125(Dice_ui::method124(Dice_ui::method123(new_array(&[
                    v15,
                    leptos::IntoView::into_view(v26),
                ]))));
            leptos::Fragment::new(v32.to_vec())
        }
        pub fn method115(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure66(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method127() -> string {
            string("Debug")
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method127()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method126() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure68((), ()))
        }
        pub fn method129() -> string {
            string("debug")
        }
        pub fn closure70(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method112();
            let v8: leptos::RwSignal<bool> = Dice_ui::method39(v5.l1.clone());
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
        pub fn method130(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure70(v0_1.clone(), v)
            })
        }
        pub fn closure71(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method65((leptos::SignalGetUntracked::get_untracked(&v2)).l1.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method131(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure71(v0_1.clone(), ())
            })
        }
        pub fn closure69(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method129());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method130(v0_1.clone());
            let v8 = Dice_ui::method131(v0_1);
            let v9: string =
                string("<label for={v6.clone()} class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\"><input type=\"checkbox\" id={v6} class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"><svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg><svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg></span><span class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"></span></label>");
            let v10: string = append(append(string("leptos::view! { "), v9), string(" }"));
            let v13: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method114(
                leptos::view! { <label for={v6.clone()} class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"><input type="checkbox" id={v6} class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400"><svg data-unchecked-icon xmlns="http://www.w3.org/2000/svg" class="h-4 w-4" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" clip-rule="evenodd" /></svg><svg data-checked-icon xmlns="http://www.w3.org/2000/svg" class="hidden h-4 w-4" viewBox="0 0 20 20" fill="currentColor"> <path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" /></svg></span><span class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300"></span></label> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method128(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure69(v0_1.clone(), ())
            })
        }
        pub fn method132(
            v0_1: Array<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn method134(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn closure72(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method133() -> Func1<leptos::HtmlElement<leptos::html::Div>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Div>| Dice_ui::closure72((), v))
        }
        pub fn method135(
            v0_1: Array<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn method136(v0_1: Vec<leptos::View>) -> Vec<leptos::View> {
            v0_1
        }
        pub fn closure60(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v10: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] items-center\"");
            let v12 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method107(),
                Dice_ui::method109(v0_1.clone()),
            )));
            let v15: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v10), string(">{v12()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v17: leptos::HtmlElement<leptos::html::Div> = leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] items-center">{v12()}</div> };
            let v24: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] items-center\"");
            let v26 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method126(),
                Dice_ui::method128(v0_1),
            )));
            let v28: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v24), string(">{v26()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v32: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method132(new_array(
                &[
                    v17,
                    leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] items-center">{v26()}</div> },
                ],
            ));
            let v33 = Dice_ui::method133();
            let v34: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method135(v32);
            let v37: Vec<leptos::View> =
                Dice_ui::method136(v34.to_vec().iter().map(|x| v33(x.clone())).collect());
            let v41: Array<leptos::View> = Dice_ui::method125(Dice_ui::method124(
                fable_library_rust::NativeArray_::array_from(v37),
            ));
            leptos::Fragment::new(v41.to_vec())
        }
        pub fn method106(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure60(v0_1.clone(), ())
            })
        }
        pub fn closure73(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method119(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method120(Func0::new(move || v1()));
            let v6: leptos::View = leptos::IntoView::into_view(move || v4());
            leptos::Fragment::new(vec![v6])
        }
        pub fn method137(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure73(v0_1.clone(), ())
            })
        }
        pub fn method138(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
        ) -> leptos::HtmlElement<leptos::html::Details> {
            v0_1
        }
        pub fn method139() -> string {
            string("Debug")
        }
        pub fn method142() -> string {
            string("Global State")
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method142()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method141() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure75((), ()))
        }
        pub fn method145(v0_1: LrcPtr<Dice_ui::Heap2>) -> LrcPtr<Dice_ui::Heap2> {
            v0_1
        }
        pub fn closure78(unitVar: (), v0_1: std::string::String) -> Dice_ui::US23 {
            Dice_ui::US23::US23_1(v0_1)
        }
        pub fn closure79(unitVar: (), v0_1: std::string::String) -> Dice_ui::US23 {
            Dice_ui::US23::US23_0(v0_1)
        }
        pub fn closure77(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> string {
            leptos::logging::log!(
                "{}",
                &string("settings.global_state_log_render () / global_state_json memo")
            );
            {
                let v3: LrcPtr<Dice_ui::Heap2> = Dice_ui::method145(v0_1);
                let v5: Result<std::string::String, std::string::String> =
                    serde_json::to_string_pretty(&v3).map_err(|x| x.to_string());
                let v8: Dice_ui::US23 = match &v5 {
                    Err(v5_1_0) => Dice_ui::closure79((), v5_1_0.clone()),
                    Ok(v5_0_0) => Dice_ui::closure78((), v5_0_0.clone()),
                };
                match &v8 {
                    Dice_ui::US23::US23_1(v8_1_0) => {
                        let v10: std::string::String = Dice_ui::method35(v8_1_0.clone());
                        fable_library_rust::String_::fromString(v10)
                    }
                    Dice_ui::US23::US23_0(v8_0_0) => append(
                        append(string("Error: "), toString(v8_0_0.clone())),
                        string(""),
                    ),
                }
            }
        }
        pub fn method144(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure77(v0_1.clone(), ())
            })
        }
        pub fn method147(v0_1: leptos::Memo<string>) -> leptos::Memo<string> {
            v0_1
        }
        pub fn method148(v0_1: string) -> string {
            v0_1
        }
        pub fn closure80(v0_1: leptos::Memo<string>, unitVar: ()) -> leptos::Fragment {
            let v1: leptos::Memo<string> = Dice_ui::method147(v0_1);
            let v6: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(v1())));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method146(v0_1: leptos::Memo<string>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure80(v0_1.clone(), ())
            })
        }
        pub fn method149(
            v0_1: leptos::HtmlElement<leptos::html::Pre>,
        ) -> leptos::HtmlElement<leptos::html::Pre> {
            v0_1
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("settings.global_state_log_render ()"));
            {
                let v3: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v6 = Dice_ui::method144(v3.unwrap());
                let v12: string =
                    string(" class=\"[padding:7px] [font-size:11px] [line-height:11px]\"");
                let v14 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method146(
                    leptos::create_memo(move |_| v6()),
                )));
                let v17: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<pre "), v12), string(">{v14()}</")),
                                string("pre"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v20: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method149(
                    leptos::view! { <pre  class="[padding:7px] [font-size:11px] [line-height:11px]">{v14()}</pre> },
                );
                let v22: leptos::View = leptos::IntoView::into_view(v20);
                leptos::Fragment::new(vec![v22])
            }
        }
        pub fn method143() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure76((), ()))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] \"");
            let v10 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method141(),
                Dice_ui::method143(),
            )));
            let v13: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v8), string(">{v10()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] ">{v10()}</div> },
            );
            let v18: leptos::View = leptos::IntoView::into_view(v16);
            leptos::Fragment::new(vec![v18])
        }
        pub fn method140() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure74((), ()))
        }
        pub fn method150(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method151(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("settings.render ()"));
            {
                let v3: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v5: LrcPtr<Dice_ui::Heap2> = v3.unwrap();
                let v7: string = Dice_ui::method5(Dice_ui::method105());
                let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
                let v11: std::string::String = String::from(v9);
                let v13 = Dice_ui::method137(Dice_ui::method106(v5.clone()));
                let v14: string =
                    string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                let v15: string = append(append(string("leptos::view! { "), v14), string(" }"));
                let v17: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                let v18: string =
                    string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v11}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v17}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column]\">{v13()}</div></details>");
                let v19: string = append(append(string("leptos::view! { "), v18), string(" }"));
                let v22: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method138(
                    leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v11}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v17}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column]">{v13()}</div></details> },
                );
                let v24: leptos::View = leptos::IntoView::into_view(v22);
                let v26: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                    Dice_ui::method37(v5.l0.clone());
                let v30: leptos::RwSignal<bool> =
                    Dice_ui::method65((leptos::SignalGetUntracked::get_untracked(&v26)).l1.clone());
                let v62: Array<leptos::View> = Dice_ui::method125(Dice_ui::method124(
                    Dice_ui::method123(new_array(&[
                        v24,
                        if leptos::SignalGet::get(&v30) {
                            let v34: string = Dice_ui::method5(Dice_ui::method139());
                            let v36: &str = fable_library_rust::String_::LrcStr::as_str(&v34);
                            let v38: std::string::String = String::from(v36);
                            let v40 = Dice_ui::method137(Dice_ui::method140());
                            let v41:
                                                                                                     string =
                                                                                                 string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                            let v42: string =
                                append(append(string("leptos::view! { "), v41), string(" }"));
                            let v44: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                            let v45:
                                                                                                     string =
                                                                                                 string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v38}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v44}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column]\">{v40()}</div></details>");
                            let v46: string =
                                append(append(string("leptos::view! { "), v45), string(" }"));
                            let v49: leptos::HtmlElement<leptos::html::Details> =
                                Dice_ui::method138(
                                    leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v38}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v44}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column]">{v40()}</div></details> },
                                );
                            leptos::IntoView::into_view(v49)
                        } else {
                            let v55: Array<leptos::View> = Dice_ui::method151(Dice_ui::method150(
                                Dice_ui::method123(new_empty::<leptos::View>()),
                            ));
                            leptos::CollectView::collect_view(v55.to_vec())
                        },
                    ])),
                ));
                leptos::Fragment::new(v62.to_vec())
            }
        }
        pub fn method104() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure59((), ()))
        }
        pub fn closure82(unitVar: (), unitVar_1: ()) -> Option<string> {
            let v2: Option<string> =
                Some(string("https://api2.nearblocks.io/v1/account/i574n.near/txns?&order=desc&page=1&per_page=25"));
            let v4: string = append(
                append(
                    string("transactions.render () / url create_memo / result: "),
                    sprintf!("{:?}", &v2),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v4);
            v2
        }
        pub fn method153() -> Func0<Option<string>> {
            Func0::new(move || Dice_ui::closure82((), ()))
        }
        pub fn method155(v0_1: leptos::Memo<Option<string>>) -> leptos::Memo<Option<string>> {
            v0_1
        }
        pub fn closure83(v0_1: leptos::Memo<Option<string>>, unitVar: ()) -> Option<string> {
            let v1: leptos::Memo<Option<string>> = Dice_ui::method155(v0_1);
            v1()
        }
        pub fn method154(v0_1: leptos::Memo<Option<string>>) -> Func0<Option<string>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure83(v0_1.clone(), ())
            })
        }
        pub fn closure85(unitVar: (), v0_1: string) -> Dice_ui::US24 {
            Dice_ui::US24::US24_1(v0_1)
        }
        pub fn method156(v0_1: string) -> string {
            v0_1
        }
        pub fn method157(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure86(unitVar: (), v0_1: reqwest_wasm::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method158() -> Func1<reqwest_wasm::Error, std::string::String> {
            Func1::new(move |v: reqwest_wasm::Error| Dice_ui::closure86((), v))
        }
        pub fn method159(v0_1: Result<Option<string>, string>) -> Result<Option<string>, string> {
            v0_1
        }
        pub fn closure84(
            unitVar: (),
            v0_1: Option<string>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<Option<string>, string>>>>
        {
            leptos::logging::log!("{}", &string("use_request () / json create_local_resource"));
            let __future_init = Box::pin(async move {
                //;
                {
                    let v6: Dice_ui::US24 = defaultValue(
                        Dice_ui::US24::US24_0,
                        map(Func1::new(move |v: string| Dice_ui::closure85((), v)), v0_1),
                    );
                    let v40: Dice_ui::US24 = match &v6 {
                        Dice_ui::US24::US24_1(v6_1_0) => {
                            let v10: string = Dice_ui::method5(Dice_ui::method14(
                                Dice_ui::method156(v6_1_0.clone()),
                            ));
                            let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
                            let v15: std::string::String = Dice_ui::method157(String::from(v12));
                            let v17: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                        Output = Result<
                                            reqwest_wasm::Response,
                                            reqwest_wasm::Error,
                                        >,
                                    >,
                                >,
                            > = Box::pin(
                                reqwest_wasm::Client::builder()
                                    .build()
                                    .map_err(|err| err.to_string())?
                                    .get(v15)
                                    .send(),
                            );
                            let v19: Result<reqwest_wasm::Response, reqwest_wasm::Error> =
                                v17.await;
                            let v20 = Dice_ui::method158();
                            let v22: Result<reqwest_wasm::Response, std::string::String> =
                                v19.map_err(|x| v20(x));
                            let v24: reqwest_wasm::Response = v22?;
                            let v26: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                        Output = Result<std::string::String, reqwest_wasm::Error>,
                                    >,
                                >,
                            > = Box::pin(reqwest_wasm::Response::text(v24));
                            let v28: Result<std::string::String, reqwest_wasm::Error> = v26.await;
                            let v29 = Dice_ui::method158();
                            let v31: Result<std::string::String, std::string::String> =
                                v28.map_err(|x| v29(x));
                            let v34: std::string::String = Dice_ui::method35(v31?);
                            Dice_ui::US24::US24_1(fable_library_rust::String_::fromString(v34))
                        }
                        _ => Dice_ui::US24::US24_0,
                    };
                    let v47: Result<Option<string>, string> = Dice_ui::method159(Ok(match &v40 {
                        Dice_ui::US24::US24_1(v40_1_0) => Some(v40_1_0.clone()),
                        _ => None::<string>,
                    }));
                    v47
                }
            });
            {
                // ;
                __future_init
            }
        }
        pub fn method161(
            v0_1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
        ) -> leptos::Resource<Option<string>, Result<Option<string>, string>> {
            v0_1
        }
        pub fn closure88(unitVar: (), v0_1: Result<Option<string>, string>) -> Dice_ui::US25 {
            Dice_ui::US25::US25_1(v0_1)
        }
        pub fn closure89(unitVar: (), v0_1: Option<string>) -> Dice_ui::US28 {
            Dice_ui::US28::US28_1(v0_1)
        }
        pub fn closure90(unitVar: (), v0_1: string) -> Dice_ui::US28 {
            Dice_ui::US28::US28_0(v0_1)
        }
        pub fn closure91(unitVar: (), v0_1: serde_json::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method162() -> Func1<serde_json::Error, std::string::String> {
            Func1::new(move |v: serde_json::Error| Dice_ui::closure91((), v))
        }
        pub fn closure87(
            v0_1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            unitVar: (),
        ) -> Result<Option<crate::model::near::nearblocks::Root>, string> {
            let v1: leptos::Resource<Option<string>, Result<Option<string>, string>> =
                Dice_ui::method161(v0_1);
            let v6: Dice_ui::US25 = defaultValue(
                Dice_ui::US25::US25_0,
                map(
                    Func1::new(move |v: Result<Option<string>, string>| Dice_ui::closure88((), v)),
                    leptos::SignalGet::get(&v1),
                ),
            );
            let v41: Dice_ui::US26 = match &v6 {
                Dice_ui::US25::US25_1(v6_1_0) => {
                    let v9: Result<Option<string>, string> = v6_1_0.clone();
                    let v12: Dice_ui::US28 = match &v9 {
                        Err(v9_1_0) => Dice_ui::closure90((), v9_1_0.clone()),
                        Ok(v9_0_0) => Dice_ui::closure89((), v9_0_0.clone()),
                    };
                    match &v12 {
                        Dice_ui::US28::US28_1(v12_1_0) => {
                            let v16: Dice_ui::US24 = defaultValue(
                                Dice_ui::US24::US24_0,
                                map(
                                    Func1::new(move |v_3: string| Dice_ui::closure85((), v_3)),
                                    v12_1_0.clone(),
                                ),
                            );
                            Dice_ui::US26::US26_1(match &v16 {
                                Dice_ui::US24::US24_1(v16_1_0) => {
                                    let v19: string =
                                        Dice_ui::method5(Dice_ui::method14(v16_1_0.clone()));
                                    let v21: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v19);
                                    let v23: std::string::String = String::from(v21);
                                    let v25: Result<
                                        crate::model::near::nearblocks::Root,
                                        serde_json::Error,
                                    > = serde_json::from_str(&v23);
                                    let v26 = Dice_ui::method162();
                                    let v28: Result<
                                        crate::model::near::nearblocks::Root,
                                        std::string::String,
                                    > = v25.map_err(|x| v26(x));
                                    Dice_ui::US27::US27_1(v28?)
                                }
                                _ => Dice_ui::US27::US27_0,
                            })
                        }
                        Dice_ui::US28::US28_0(v12_0_0) => Dice_ui::US26::US26_0(v12_0_0.clone()),
                    }
                }
                _ => Dice_ui::US26::US26_1(Dice_ui::US27::US27_0),
            };
            let v52: Dice_ui::US29 = match &v41 {
                Dice_ui::US26::US26_1(v41_1_0) => {
                    let v42: Dice_ui::US27 = v41_1_0.clone();
                    Dice_ui::US29::US29_1(match &v42 {
                        Dice_ui::US27::US27_1(v42_1_0) => Some(v42_1_0.clone()),
                        _ => None::<crate::model::near::nearblocks::Root>,
                    })
                }
                Dice_ui::US26::US26_0(v41_0_0) => Dice_ui::US29::US29_0(v41_0_0.clone()),
            };
            let v58: Result<Option<crate::model::near::nearblocks::Root>, string> = match &v52 {
                Dice_ui::US29::US29_1(v52_1_0) => Ok(v52_1_0.clone()),
                Dice_ui::US29::US29_0(v52_0_0) => Err(v52_0_0.clone()),
            };
            let v60: string = append(
                append(
                    string("use_request () / result create_memo / result length: "),
                    toString(length(sprintf!("{:?}", &v58))),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v60);
            v58
        }
        pub fn method160(
            v0_1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
        ) -> Func0<Result<Option<crate::model::near::nearblocks::Root>, string>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure87(v0_1.clone(), ())
            })
        }
        pub fn method164(
            v0_1: leptos::Memo<Result<Option<crate::model::near::nearblocks::Root>, string>>,
        ) -> leptos::Memo<Result<Option<crate::model::near::nearblocks::Root>, string>> {
            v0_1
        }
        pub fn closure93(
            unitVar: (),
            v0_1: Option<crate::model::near::nearblocks::Root>,
        ) -> Dice_ui::US29 {
            Dice_ui::US29::US29_1(v0_1)
        }
        pub fn closure94(unitVar: (), v0_1: string) -> Dice_ui::US29 {
            Dice_ui::US29::US29_0(v0_1)
        }
        pub fn closure95(unitVar: (), v0_1: crate::model::near::nearblocks::Root) -> Dice_ui::US27 {
            Dice_ui::US27::US27_1(v0_1)
        }
        pub fn method165(
            v0_1: crate::model::near::nearblocks::Root,
        ) -> crate::model::near::nearblocks::Root {
            v0_1
        }
        pub fn method167(
            v0_1: crate::model::near::nearblocks::Txn,
        ) -> crate::model::near::nearblocks::Txn {
            v0_1
        }
        pub fn method168(
            v0_1: crate::model::near::nearblocks::Block,
        ) -> crate::model::near::nearblocks::Block {
            v0_1
        }
        pub fn method170(
            v0_1: crate::model::near::nearblocks::Action,
        ) -> crate::model::near::nearblocks::Action {
            v0_1
        }
        pub fn closure97(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Action,
        ) -> (std::string::String, Dice_ui::US13) {
            let v1: crate::model::near::nearblocks::Action = Dice_ui::method170(v0_1);
            (
                v1.action,
                defaultValue(
                    Dice_ui::US13::US13_0,
                    map(
                        Func1::new(move |v: std::string::String| Dice_ui::closure24((), v)),
                        v1.method,
                    ),
                ),
            )
        }
        pub fn method169(
        ) -> Func1<crate::model::near::nearblocks::Action, (std::string::String, Dice_ui::US13)>
        {
            Func1::new(move |v: crate::model::near::nearblocks::Action| Dice_ui::closure97((), v))
        }
        pub fn method171(
            v0_1: Vec<(std::string::String, Dice_ui::US13)>,
        ) -> Vec<(std::string::String, Dice_ui::US13)> {
            v0_1
        }
        pub fn method172(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
        ) -> Array<(std::string::String, Dice_ui::US13)> {
            v0_1
        }
        pub fn method173(
            v0_1: crate::model::near::nearblocks::ActionsAgg,
        ) -> crate::model::near::nearblocks::ActionsAgg {
            v0_1
        }
        pub fn method174(
            v0_1: crate::model::near::nearblocks::Outcomes,
        ) -> crate::model::near::nearblocks::Outcomes {
            v0_1
        }
        pub fn method175(
            v0_1: crate::model::near::nearblocks::OutcomesAgg,
        ) -> crate::model::near::nearblocks::OutcomesAgg {
            v0_1
        }
        pub fn method176(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method177(v0_1: Array<std::string::String>) -> Array<std::string::String> {
            v0_1
        }
        pub fn closure96(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Txn,
        ) -> (
            Array<(std::string::String, Dice_ui::US13)>,
            u64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        ) {
            let v1: crate::model::near::nearblocks::Txn = Dice_ui::method167(v0_1);
            let v3: std::string::String = v1.receipt_id;
            let v5: std::string::String = v1.predecessor_account_id;
            let v7: std::string::String = v1.receiver_account_id;
            let v9: std::string::String = v1.transaction_hash;
            let v11: std::string::String = v1.included_in_block_hash;
            let v13: std::string::String = v1.block_timestamp;
            let v16: crate::model::near::nearblocks::Block = Dice_ui::method168(v1.block);
            let v18: u32 = v16.block_height;
            let v19 = Dice_ui::method169();
            let v22: Vec<(std::string::String, Dice_ui::US13)> =
                Dice_ui::method171(v1.actions.into_iter().map(|x| v19(x)).collect());
            let v25: Array<(std::string::String, Dice_ui::US13)> =
                Dice_ui::method172(fable_library_rust::NativeArray_::array_from(v22));
            let v28: crate::model::near::nearblocks::ActionsAgg =
                Dice_ui::method173(v1.actions_agg);
            let v30: u64 = v28.deposit;
            let v33: crate::model::near::nearblocks::Outcomes = Dice_ui::method174(v1.outcomes);
            let v35: bool = v33.status;
            let v38: crate::model::near::nearblocks::OutcomesAgg =
                Dice_ui::method175(v1.outcomes_agg);
            let v40: f64 = v38.transaction_fee;
            let v43: Vec<std::string::String> = Dice_ui::method176(v1.logs);
            (
                v25,
                v30,
                v18,
                v13,
                v11,
                Dice_ui::method177(fable_library_rust::NativeArray_::array_from(v43)),
                v35,
                v40,
                v5,
                v3,
                v7,
                v9,
            )
        }
        pub fn method166() -> Func1<
            crate::model::near::nearblocks::Txn,
            (
                Array<(std::string::String, Dice_ui::US13)>,
                u64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
        > {
            Func1::new(move |v: crate::model::near::nearblocks::Txn| Dice_ui::closure96((), v))
        }
        pub fn method178(
            v0_1: Vec<(
                Array<(std::string::String, Dice_ui::US13)>,
                u64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Vec<(
            Array<(std::string::String, Dice_ui::US13)>,
            u64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn method179(
            v0_1: Array<(
                Array<(std::string::String, Dice_ui::US13)>,
                u64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Array<(
            Array<(std::string::String, Dice_ui::US13)>,
            u64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn closure92(
            v0_1: leptos::Memo<Result<Option<crate::model::near::nearblocks::Root>, string>>,
            unitVar: (),
        ) -> Dice_ui::US30 {
            let v1: leptos::Memo<Result<Option<crate::model::near::nearblocks::Root>, string>> =
                Dice_ui::method164(v0_1);
            let v3: Result<Option<crate::model::near::nearblocks::Root>, string> = v1();
            let v6: Dice_ui::US29 = match &v3 {
                Err(v3_1_0) => Dice_ui::closure94((), v3_1_0.clone()),
                Ok(v3_0_0) => Dice_ui::closure93((), v3_0_0.clone()),
            };
            let v28: Dice_ui::US32 = match &v6 {
                Dice_ui::US29::US29_1(v6_1_0) => {
                    let v10: Dice_ui::US27 = defaultValue(
                        Dice_ui::US27::US27_0,
                        map(
                            Func1::new(move |v_2: crate::model::near::nearblocks::Root| {
                                Dice_ui::closure95((), v_2)
                            }),
                            v6_1_0.clone(),
                        ),
                    );
                    Dice_ui::US32::US32_1(match &v10 {
                        Dice_ui::US27::US27_1(v10_1_0) => {
                            let v12: crate::model::near::nearblocks::Root =
                                Dice_ui::method165(v10_1_0.clone());
                            let v13 = Dice_ui::method166();
                            let v16: Vec<(
                                Array<(std::string::String, Dice_ui::US13)>,
                                u64,
                                u32,
                                std::string::String,
                                std::string::String,
                                Array<std::string::String>,
                                bool,
                                f64,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                            )> = Dice_ui::method178(v12.txns.into_iter().map(|x| v13(x)).collect());
                            Dice_ui::US33::US33_1(Dice_ui::method179(
                                fable_library_rust::NativeArray_::array_from(v16),
                            ))
                        }
                        _ => Dice_ui::US33::US33_0,
                    })
                }
                Dice_ui::US29::US29_0(v6_0_0) => Dice_ui::US32::US32_0(v6_0_0.clone()),
            };
            let v39: Dice_ui::US30 = match &v28 {
                Dice_ui::US32::US32_1(v28_1_0) => {
                    let v29: Dice_ui::US33 = v28_1_0.clone();
                    if let Dice_ui::US33::US33_1(v29_1_0) = &v29 {
                        Dice_ui::US30::US30_1(Dice_ui::US31::US31_1(match &v29 {
                            Dice_ui::US33::US33_1(x) => x.clone(),
                            _ => unreachable!(),
                        }))
                    } else {
                        Dice_ui::US30::US30_0
                    }
                }
                Dice_ui::US32::US32_0(v28_0_0) => {
                    Dice_ui::US30::US30_1(Dice_ui::US31::US31_0(v28_0_0.clone()))
                }
            };
            let v41: string = append(
                append(
                    string("use_request () / result move / result length: "),
                    toString(length(sprintf!("{:?}", &v39))),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v41);
            v39
        }
        pub fn method163(
            v0_1: leptos::Memo<Result<Option<crate::model::near::nearblocks::Root>, string>>,
        ) -> Func0<Dice_ui::US30> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure92(v0_1.clone(), ())
            })
        }
        pub fn method181(v0_1: Func0<Dice_ui::US30>) -> Func0<Dice_ui::US30> {
            v0_1
        }
        pub fn method182(
            v0_1: Array<(
                Array<(std::string::String, Dice_ui::US13)>,
                u64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Array<(
            Array<(std::string::String, Dice_ui::US13)>,
            u64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn method183(
            v0_1: Vec<
                LrcPtr<(
                    usize,
                    (
                        Array<(std::string::String, Dice_ui::US13)>,
                        u64,
                        u32,
                        std::string::String,
                        std::string::String,
                        Array<std::string::String>,
                        bool,
                        f64,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                    ),
                )>,
            >,
        ) -> Vec<
            LrcPtr<(
                usize,
                (
                    Array<(std::string::String, Dice_ui::US13)>,
                    u64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                ),
            )>,
        > {
            v0_1
        }
        pub fn closure99(
            unitVar: (),
            v0_: usize,
            v0__1: (
                Array<(std::string::String, Dice_ui::US13)>,
                u64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
        ) -> (
            usize,
            Array<(std::string::String, Dice_ui::US13)>,
            u64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        ) {
            let v0_1: LrcPtr<(
                usize,
                (
                    Array<(std::string::String, Dice_ui::US13)>,
                    u64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                ),
            )> = LrcPtr::new((v0_, v0__1));
            let b: (
                Array<(std::string::String, Dice_ui::US13)>,
                u64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ) = v0_1.1.clone();
            (
                v0_1.0.clone(),
                b.0.clone(),
                b.1.clone(),
                b.2.clone(),
                b.3.clone(),
                b.4.clone(),
                b.5.clone(),
                b.6.clone(),
                b.7.clone(),
                b.8.clone(),
                b.9.clone(),
                b.10.clone(),
                b.11.clone(),
            )
        }
        pub fn method184() -> Func1<
            LrcPtr<(
                usize,
                (
                    Array<(std::string::String, Dice_ui::US13)>,
                    u64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                ),
            )>,
            (
                usize,
                Array<(std::string::String, Dice_ui::US13)>,
                u64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
        > {
            Func1::new(
                move |tupledArg: LrcPtr<(
                    usize,
                    (
                        Array<(std::string::String, Dice_ui::US13)>,
                        u64,
                        u32,
                        std::string::String,
                        std::string::String,
                        Array<std::string::String>,
                        bool,
                        f64,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                    ),
                )>| {
                    Dice_ui::closure99((), tupledArg.0.clone(), tupledArg.1.clone())
                },
            )
        }
        pub fn method185(
            v0_1: Array<
                LrcPtr<(
                    usize,
                    (
                        Array<(std::string::String, Dice_ui::US13)>,
                        u64,
                        u32,
                        std::string::String,
                        std::string::String,
                        Array<std::string::String>,
                        bool,
                        f64,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                    ),
                )>,
            >,
        ) -> Array<
            LrcPtr<(
                usize,
                (
                    Array<(std::string::String, Dice_ui::US13)>,
                    u64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                ),
            )>,
        > {
            v0_1
        }
        pub fn method186(
            v0_1: Vec<(
                usize,
                Array<(std::string::String, Dice_ui::US13)>,
                u64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Vec<(
            usize,
            Array<(std::string::String, Dice_ui::US13)>,
            u64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn closure100(
            unitVar: (),
            _arg: (
                usize,
                Array<(std::string::String, Dice_ui::US13)>,
                u64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
        ) -> (usize, LrcPtr<Dice_ui::Heap5>) {
            (
                _arg.0.clone(),
                LrcPtr::new(Dice_ui::Heap5 {
                    l0: _arg.1.clone(),
                    l1: _arg.2.clone(),
                    l2: _arg.3.clone(),
                    l3: _arg.4.clone(),
                    l4: _arg.5.clone(),
                    l5: _arg.6.clone(),
                    l6: _arg.7.clone(),
                    l7: _arg.8.clone(),
                    l8: _arg.9.clone(),
                    l9: _arg.10.clone(),
                    l10: _arg.11.clone(),
                    l11: _arg.12.clone(),
                }),
            )
        }
        pub fn method187() -> Func1<
            (
                usize,
                Array<(std::string::String, Dice_ui::US13)>,
                u64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
            (usize, LrcPtr<Dice_ui::Heap5>),
        > {
            Func1::new(
                move |arg10_0040: (
                    usize,
                    Array<(std::string::String, Dice_ui::US13)>,
                    u64,
                    u32,
                    std::string::String,
                    std::string::String,
                    Array<std::string::String>,
                    bool,
                    f64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )| Dice_ui::closure100((), arg10_0040),
            )
        }
        pub fn method188(
            v0_1: Array<(
                usize,
                Array<(std::string::String, Dice_ui::US13)>,
                u64,
                u32,
                std::string::String,
                std::string::String,
                Array<std::string::String>,
                bool,
                f64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Array<(
            usize,
            Array<(std::string::String, Dice_ui::US13)>,
            u64,
            u32,
            std::string::String,
            std::string::String,
            Array<std::string::String>,
            bool,
            f64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn method189(
            v0_1: Vec<(usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Vec<(usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn closure98(v0_1: Func0<Dice_ui::US30>, unitVar: ()) -> Dice_ui::US34 {
            let v1: Func0<Dice_ui::US30> = Dice_ui::method181(v0_1);
            let v3: Dice_ui::US30 = v1();
            let v35: Dice_ui::US36 = match &v3 {
                Dice_ui::US30::US30_1(v3_1_0) => {
                    let v4: Dice_ui::US31 = v3_1_0.clone();
                    Dice_ui::US36::US36_1(match &v4 {
                        Dice_ui::US31::US31_1(v4_1_0) => {
                            let v6: Array<(
                                Array<(std::string::String, Dice_ui::US13)>,
                                u64,
                                u32,
                                std::string::String,
                                std::string::String,
                                Array<std::string::String>,
                                bool,
                                f64,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                            )> = Dice_ui::method182(v4_1_0.clone());
                            let v9: Vec<
                                LrcPtr<(
                                    usize,
                                    (
                                        Array<(std::string::String, Dice_ui::US13)>,
                                        u64,
                                        u32,
                                        std::string::String,
                                        std::string::String,
                                        Array<std::string::String>,
                                        bool,
                                        f64,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                    ),
                                )>,
                            > = Dice_ui::method183(
                                v6.to_vec()
                                    .into_iter()
                                    .enumerate()
                                    .map(std::rc::Rc::new)
                                    .collect(),
                            );
                            let v11: Array<
                                LrcPtr<(
                                    usize,
                                    (
                                        Array<(std::string::String, Dice_ui::US13)>,
                                        u64,
                                        u32,
                                        std::string::String,
                                        std::string::String,
                                        Array<std::string::String>,
                                        bool,
                                        f64,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                    ),
                                )>,
                            > = fable_library_rust::NativeArray_::array_from(v9);
                            let v12 = Dice_ui::method184();
                            let v13: Array<
                                LrcPtr<(
                                    usize,
                                    (
                                        Array<(std::string::String, Dice_ui::US13)>,
                                        u64,
                                        u32,
                                        std::string::String,
                                        std::string::String,
                                        Array<std::string::String>,
                                        bool,
                                        f64,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                        std::string::String,
                                    ),
                                )>,
                            > = Dice_ui::method185(v11);
                            let v16: Vec<(
                                usize,
                                Array<(std::string::String, Dice_ui::US13)>,
                                u64,
                                u32,
                                std::string::String,
                                std::string::String,
                                Array<std::string::String>,
                                bool,
                                f64,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                            )> = Dice_ui::method186(
                                v13.to_vec().iter().map(|x| v12(x.clone())).collect(),
                            );
                            let v18: Array<(
                                usize,
                                Array<(std::string::String, Dice_ui::US13)>,
                                u64,
                                u32,
                                std::string::String,
                                std::string::String,
                                Array<std::string::String>,
                                bool,
                                f64,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                            )> = fable_library_rust::NativeArray_::array_from(v16);
                            let v19 = Dice_ui::method187();
                            let v20: Array<(
                                usize,
                                Array<(std::string::String, Dice_ui::US13)>,
                                u64,
                                u32,
                                std::string::String,
                                std::string::String,
                                Array<std::string::String>,
                                bool,
                                f64,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                                std::string::String,
                            )> = Dice_ui::method188(v18);
                            let v23: Vec<(usize, LrcPtr<Dice_ui::Heap5>)> = Dice_ui::method189(
                                v20.to_vec().iter().map(|x| v19(x.clone())).collect(),
                            );
                            Dice_ui::US37::US37_1(Dice_ui::US38::US38_1(
                                fable_library_rust::NativeArray_::array_from(v23),
                            ))
                        }
                        Dice_ui::US31::US31_0(v4_0_0) => Dice_ui::US37::US37_0(v4_0_0.clone()),
                    })
                }
                _ => Dice_ui::US36::US36_0,
            };
            let v46: Dice_ui::US34 = if let Dice_ui::US36::US36_1(v35_1_0) = &v35 {
                let v36: Dice_ui::US37 = match &v35 {
                    Dice_ui::US36::US36_1(x) => x.clone(),
                    _ => unreachable!(),
                };
                if let Dice_ui::US37::US37_1(v36_1_0) = &v36 {
                    let v37: Dice_ui::US38 = match &v36 {
                        Dice_ui::US37::US37_1(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Dice_ui::US38::US38_1(v37_1_0) = &v37 {
                        Dice_ui::US34::US34_1(Dice_ui::US35::US35_1(match &v37 {
                            Dice_ui::US38::US38_1(x) => x.clone(),
                            _ => unreachable!(),
                        }))
                    } else {
                        Dice_ui::US34::US34_0
                    }
                } else {
                    Dice_ui::US34::US34_0
                }
            } else {
                Dice_ui::US34::US34_0
            };
            let v48: string = append(
                append(
                    string("transactions.render () / txns move / result length: "),
                    toString(length(sprintf!("{:?}", &v46))),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v48);
            v46
        }
        pub fn method180(v0_1: Func0<Dice_ui::US30>) -> Func0<Dice_ui::US34> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure98(v0_1.clone(), ())
            })
        }
        pub fn method190() -> string {
            string("Transactions")
        }
        pub fn method192(v0_1: Func0<Dice_ui::US34>) -> Func0<Dice_ui::US34> {
            v0_1
        }
        pub fn method193(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> leptos::HtmlElement<leptos::svg::Svg> {
            v0_1
        }
        pub fn method195(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
        ) -> Array<(usize, LrcPtr<Dice_ui::Heap5>)> {
            v0_1
        }
        pub fn closure103(
            unitVar: (),
            _arg: (usize, LrcPtr<Dice_ui::Heap5>),
        ) -> std::string::String {
            (_arg.1.clone()).l11.clone()
        }
        pub fn method196() -> Func1<(usize, LrcPtr<Dice_ui::Heap5>), std::string::String> {
            Func1::new(move |arg10_0040: (usize, LrcPtr<Dice_ui::Heap5>)| {
                Dice_ui::closure103((), arg10_0040)
            })
        }
        pub fn closure106(v0_1: i64, unitVar: ()) -> leptos::Fragment {
            let v4: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(append(
                append(string("Transaction "), toString(v0_1 + 1_i64)),
                string(""),
            ))));
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: leptos::leptos_dom::Text = leptos::html::text(v8);
            let v12: leptos::View = leptos::IntoView::into_view(v10);
            leptos::Fragment::new(vec![v12])
        }
        pub fn method199(v0_1: i64) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure106(v0_1, ())
            })
        }
        pub fn closure107(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method119(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method120(Func0::new(move || v1()));
            let v6: leptos::View = leptos::IntoView::into_view(move || v4());
            leptos::Fragment::new(vec![v6])
        }
        pub fn method200(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure107(v0_1.clone(), ())
            })
        }
        pub fn method201(
            v0_1: leptos::HtmlElement<leptos::html::Span>,
        ) -> leptos::HtmlElement<leptos::html::Span> {
            v0_1
        }
        pub fn method204() -> string {
            string("Block Timestamp")
        }
        pub fn closure109(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method204()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method203() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure109((), ()))
        }
        pub fn method206(v0_1: i64) -> i64 {
            v0_1
        }
        pub fn closure111(unitVar: (), v0_1: chrono::NaiveDateTime) -> Dice_ui::US39 {
            Dice_ui::US39::US39_1(v0_1)
        }
        pub fn method207(v0_1: chrono::NaiveDateTime) -> chrono::NaiveDateTime {
            v0_1
        }
        pub fn method208(v0_1: chrono::DateTime<chrono::Local>) -> chrono::DateTime<chrono::Local> {
            v0_1
        }
        pub fn closure110(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v14: i64 = Dice_ui::method206(v3.parse().unwrap());
            let v19: Dice_ui::US39 = defaultValue(
                Dice_ui::US39::US39_0,
                map(
                    Func1::new(move |v: chrono::NaiveDateTime| Dice_ui::closure111((), v)),
                    chrono::NaiveDateTime::from_timestamp_micros(v14 / 1000i64),
                ),
            );
            let v36: Dice_ui::US24 = match &v19 {
                Dice_ui::US39::US39_1(v19_1_0) => {
                    let v21: chrono::NaiveDateTime = Dice_ui::method207(v19_1_0.clone());
                    let v23: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v21);
                    let v25: string = string("r#\"%Y-%m-%d %H:%M:%S\"#");
                    let v26: &str = r#"%Y-%m-%d %H:%M:%S"#;
                    let v27: chrono::DateTime<chrono::Local> = Dice_ui::method208(v23);
                    let v30: std::string::String = Dice_ui::method35(v27.format(v26).to_string());
                    Dice_ui::US24::US24_1(fable_library_rust::String_::fromString(v30))
                }
                _ => Dice_ui::US24::US24_0,
            };
            let v42: Dice_ui::US40 = match &v36 {
                Dice_ui::US24::US24_1(v36_1_0) => Dice_ui::US40::US40_1(v36_1_0.clone()),
                _ => Dice_ui::US40::US40_0(string("Option does not have a value.")),
            };
            let v50: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(match &v42 {
                Dice_ui::US40::US40_1(v42_1_0) => v42_1_0.clone(),
                Dice_ui::US40::US40_0(v42_0_0) => {
                    append(append(string("Error: "), v42_0_0.clone()), string(""))
                }
            })));
            let v52: &str = fable_library_rust::String_::LrcStr::as_str(&v50);
            let v54: std::string::String = String::from(v52);
            let v56: leptos::leptos_dom::Text = leptos::html::text(v54);
            let v58: leptos::View = leptos::IntoView::into_view(v56);
            leptos::Fragment::new(vec![v58])
        }
        pub fn method205(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure110(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method210() -> string {
            string("Predecessor")
        }
        pub fn closure112(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method210()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method209() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure112((), ()))
        }
        pub fn closure113(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: std::string::String = Dice_ui::method35(v8);
            let v17: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            leptos::Fragment::new(vec![v25])
        }
        pub fn method211(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure113(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method213() -> string {
            string("Receiver")
        }
        pub fn closure114(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method213()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method212() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure114((), ()))
        }
        pub fn closure115(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: std::string::String = Dice_ui::method35(v10);
            let v17: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            leptos::Fragment::new(vec![v25])
        }
        pub fn method214(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure115(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method216() -> string {
            string("Actions")
        }
        pub fn closure116(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method216()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method215() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure116((), ()))
        }
        pub fn closure119(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method35(v0_1);
            let v3: string = fable_library_rust::String_::fromString(v1);
            let v15: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(
                if string("FUNCTION_CALL") == v3.clone() {
                    string("Function Call:")
                } else {
                    if string("DEPLOY_CONTRACT") == v3.clone() {
                        string("Contract Deploy:")
                    } else {
                        if string("TRANSFER") == v3.clone() {
                            string("Transfer:")
                        } else {
                            v3
                        }
                    }
                },
            )));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            leptos::Fragment::new(vec![v23])
        }
        pub fn method219(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure119(v0_1.clone(), ())
            })
        }
        pub fn method223() -> string {
            string("Method")
        }
        pub fn closure122(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method223()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method222() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure122((), ()))
        }
        pub fn method225() -> string {
            string("None")
        }
        pub fn closure123(v0_1: Dice_ui::US13, unitVar: ()) -> leptos::Fragment {
            match &v0_1 {
                Dice_ui::US13::US13_1(v0_1_1_0) => {
                    let v2: std::string::String = Dice_ui::method35(v0_1_1_0.clone());
                    let v7: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(
                        fable_library_rust::String_::fromString(v2),
                    )));
                    let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
                    let v11: std::string::String = String::from(v9);
                    let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
                    let v15: leptos::View = leptos::IntoView::into_view(v13);
                    leptos::Fragment::new(vec![v15])
                }
                _ => {
                    let v20: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method225()));
                    let v22: &str = fable_library_rust::String_::LrcStr::as_str(&v20);
                    let v24: std::string::String = String::from(v22);
                    let v26: leptos::leptos_dom::Text = leptos::html::text(v24);
                    let v28: leptos::View = leptos::IntoView::into_view(v26);
                    leptos::Fragment::new(vec![v28])
                }
            }
        }
        pub fn method224(v0_1: Dice_ui::US13) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure123(v0_1.clone(), ())
            })
        }
        pub fn closure121(v0_1: Dice_ui::US13, unitVar: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  \"");
            let v10 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method222(),
                Dice_ui::method224(v0_1),
            )));
            let v13: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v8), string(">{v10()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  ">{v10()}</div> },
            );
            let v22: Array<leptos::View> =
                Dice_ui::method125(Dice_ui::method124(Dice_ui::method123(new_array(&[
                    leptos::IntoView::into_view(v16),
                ]))));
            leptos::Fragment::new(v22.to_vec())
        }
        pub fn method221(v0_1: Dice_ui::US13) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure121(v0_1.clone(), ())
            })
        }
        pub fn closure120(v0_1: Dice_ui::US13, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 flex-col\"");
            let v6 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method221(v0_1)));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v4), string(">{v6()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="flex flex-1 flex-col">{v6()}</div> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method220(v0_1: Dice_ui::US13) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure120(v0_1.clone(), ())
            })
        }
        pub fn closure118(
            unitVar: (),
            _arg: (std::string::String, Dice_ui::US13),
        ) -> leptos::HtmlElement<leptos::html::Div> {
            let v9: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%]  items-center \"");
            let v11 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method219(_arg.0.clone()),
                Dice_ui::method220(_arg.1.clone()),
            )));
            let v14: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v9), string(">{v11()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%]  items-center ">{v11()}</div> }
        }
        pub fn method218(
        ) -> Func1<(std::string::String, Dice_ui::US13), leptos::HtmlElement<leptos::html::Div>>
        {
            Func1::new(move |arg10_0040: (std::string::String, Dice_ui::US13)| {
                Dice_ui::closure118((), arg10_0040)
            })
        }
        pub fn method226(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
        ) -> Array<(std::string::String, Dice_ui::US13)> {
            v0_1
        }
        pub fn method227(
            v0_1: Vec<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Vec<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn closure117(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12 = Dice_ui::method218();
            let v13: Array<(std::string::String, Dice_ui::US13)> = Dice_ui::method226(v0_1);
            let v16: Vec<leptos::HtmlElement<leptos::html::Div>> =
                Dice_ui::method227(v13.to_vec().iter().map(|x| v12(x.clone())).collect());
            let v18: Array<leptos::HtmlElement<leptos::html::Div>> =
                fable_library_rust::NativeArray_::array_from(v16);
            let v19 = Dice_ui::method133();
            let v20: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method135(v18);
            let v23: Vec<leptos::View> =
                Dice_ui::method136(v20.to_vec().iter().map(|x| v19(x.clone())).collect());
            let v27: Array<leptos::View> = Dice_ui::method125(Dice_ui::method124(
                fable_library_rust::NativeArray_::array_from(v23),
            ));
            leptos::Fragment::new(v27.to_vec())
        }
        pub fn method217(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure117(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method229() -> string {
            string("Deposit")
        }
        pub fn closure124(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method229()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method228() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure124((), ()))
        }
        pub fn closure125(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v15: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(toString(v1))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            leptos::Fragment::new(vec![v23])
        }
        pub fn method230(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure125(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method232() -> string {
            string("Outcome Status")
        }
        pub fn closure126(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method232()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method231() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure126((), ()))
        }
        pub fn closure127(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v15: string =
                Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(ofBoolean(v6))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            leptos::Fragment::new(vec![v23])
        }
        pub fn method233(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure127(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method235() -> string {
            string("Fee")
        }
        pub fn closure128(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method235()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method234() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure128((), ()))
        }
        pub fn closure129(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v15: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(toString(v7))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            leptos::Fragment::new(vec![v23])
        }
        pub fn method236(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure129(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method238() -> string {
            string("Block Height")
        }
        pub fn closure130(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method238()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method237() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure130((), ()))
        }
        pub fn closure131(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v15: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(toString(v2))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            leptos::Fragment::new(vec![v23])
        }
        pub fn method239(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure131(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method241() -> string {
            string("Hash")
        }
        pub fn closure132(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method241()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method240() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure132((), ()))
        }
        pub fn closure133(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: std::string::String = Dice_ui::method35(v11);
            let v17: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            leptos::Fragment::new(vec![v25])
        }
        pub fn method242(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure133(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method244() -> string {
            string("Block Hash")
        }
        pub fn closure134(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method244()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method243() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure134((), ()))
        }
        pub fn closure135(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: std::string::String = Dice_ui::method35(v4);
            let v17: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            leptos::Fragment::new(vec![v25])
        }
        pub fn method245(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure135(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method247() -> string {
            string("Receipt ID")
        }
        pub fn closure136(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method247()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method246() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure136((), ()))
        }
        pub fn closure137(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: std::string::String = Dice_ui::method35(v9);
            let v17: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            leptos::Fragment::new(vec![v25])
        }
        pub fn method248(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure137(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method250() -> string {
            string("Logs")
        }
        pub fn closure138(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method250()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method249() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure138((), ()))
        }
        pub fn closure140(unitVar: (), v0_1: std::string::String) -> string {
            let v1: std::string::String = Dice_ui::method35(v0_1);
            fable_library_rust::String_::fromString(v1)
        }
        pub fn method252() -> Func1<std::string::String, string> {
            Func1::new(move |v: std::string::String| Dice_ui::closure140((), v))
        }
        pub fn method253(v0_1: Array<std::string::String>) -> Array<std::string::String> {
            v0_1
        }
        pub fn method254(v0_1: Vec<string>) -> Vec<string> {
            v0_1
        }
        pub fn closure141(v0_1: string, unitVar: ()) -> leptos::Fragment {
            let v3: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(v0_1)));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: leptos::leptos_dom::Text = leptos::html::text(v7);
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method255(v0_1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure141(v0_1.clone(), ())
            })
        }
        pub fn closure139(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12 = Dice_ui::method252();
            let v13: Array<std::string::String> = Dice_ui::method253(v5);
            let v16: Vec<string> =
                Dice_ui::method254(v13.to_vec().iter().map(|x| v12(x.clone())).collect());
            let v27: string =
                string(" class=\"[padding:1px] [font-size:11px] [line-height:11px] [text-wrap:pretty] [max-height:20vh]\"");
            let v29 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method255(replace(
                join(
                    string("\n"),
                    toArray(ofArray(fable_library_rust::NativeArray_::array_from(v16))),
                ),
                string("\\n"),
                string("\n"),
            ))));
            let v32: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v27), string(">{v29()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v35: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method149(
                leptos::view! { <pre  class="[padding:1px] [font-size:11px] [line-height:11px] [text-wrap:pretty] [max-height:20vh]">{v29()}</pre> },
            );
            let v37: leptos::View = leptos::IntoView::into_view(v35);
            leptos::Fragment::new(vec![v37])
        }
        pub fn method251(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure139(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure108(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            v12: LrcPtr<Dice_ui::Heap2>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v21: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v23 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method203(),
                Dice_ui::method205(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v26: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v21), string(">{v23()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v29: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v23()}</div> },
            );
            let v31: leptos::View = leptos::IntoView::into_view(v29);
            let v37: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v39 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method209(),
                Dice_ui::method211(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v41: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v37), string(">{v39()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v44: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v39()}</div> },
            );
            let v46: leptos::View = leptos::IntoView::into_view(v44);
            let v52: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v54 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method212(),
                Dice_ui::method214(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v56: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v52), string(">{v54()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v59: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v54()}</div> },
            );
            let v61: leptos::View = leptos::IntoView::into_view(v59);
            let v68: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] sm:pr-[10px] items-center py-[4px]\"");
            let v70 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method215(),
                Dice_ui::method217(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v72: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v68), string(">{v70()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v75: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] sm:pr-[10px] items-center py-[4px]">{v70()}</div> },
            );
            let v77: leptos::View = leptos::IntoView::into_view(v75);
            let v83: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v85 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method228(),
                Dice_ui::method230(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v87: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v83), string(">{v85()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v90: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v85()}</div> },
            );
            let v92: leptos::View = leptos::IntoView::into_view(v90);
            let v98: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v100 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method231(),
                Dice_ui::method233(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v102: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v98), string(">{v100()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v105: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v100()}</div> },
            );
            let v107: leptos::View = leptos::IntoView::into_view(v105);
            let v113: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v115 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method234(),
                Dice_ui::method236(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v117: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v113), string(">{v115()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v120: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v115()}</div> },
            );
            let v122: leptos::View = leptos::IntoView::into_view(v120);
            let v128: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v130 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method237(),
                Dice_ui::method239(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v132: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v128), string(">{v130()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v135: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v130()}</div> },
            );
            let v137: leptos::View = leptos::IntoView::into_view(v135);
            let v143: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v145 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method240(),
                Dice_ui::method242(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v147: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v143), string(">{v145()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v150: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v145()}</div> },
            );
            let v152: leptos::View = leptos::IntoView::into_view(v150);
            let v158: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v160 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method243(),
                Dice_ui::method245(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v162: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v158), string(">{v160()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v165: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v160()}</div> },
            );
            let v167: leptos::View = leptos::IntoView::into_view(v165);
            let v173: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v175 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method246(),
                Dice_ui::method248(
                    v0_1.clone(),
                    v1,
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6,
                    v7,
                    v8.clone(),
                    v9.clone(),
                    v10.clone(),
                    v11.clone(),
                ),
            )));
            let v177: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v173), string(">{v175()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v180: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v175()}</div> },
            );
            let v182: leptos::View = leptos::IntoView::into_view(v180);
            let v184: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method37(v12.l0.clone());
            let v188: leptos::RwSignal<bool> = Dice_ui::method65(
                (leptos::SignalGetUntracked::get_untracked(&v184))
                    .l1
                    .clone(),
            );
            let v225: Array<leptos::View> = Dice_ui::method125(Dice_ui::method124(
                Dice_ui::method123(new_array(&[
                    v31,
                    v46,
                    v61,
                    v77,
                    v92,
                    v107,
                    v122,
                    v137,
                    v152,
                    v167,
                    v182,
                    if leptos::SignalGet::get(&v188) {
                        if count(v5.clone()) as u64 == 0_u64 {
                            let v196: Array<leptos::View> = Dice_ui::method151(Dice_ui::method150(
                                Dice_ui::method123(new_empty::<leptos::View>()),
                            ));
                            leptos::CollectView::collect_view(v196.to_vec())
                        } else {
                            let v204:
                                                                                                     string =
                                                                                                 string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
                            let v206 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                                Dice_ui::method249(),
                                Dice_ui::method251(
                                    v0_1, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11,
                                ),
                            )));
                            let v208: string = append(
                                append(
                                    string("leptos::view! { "),
                                    append(
                                        append(
                                            append(
                                                append(string("<div "), v204),
                                                string(">{v206()}</"),
                                            ),
                                            string("div"),
                                        ),
                                        string(">"),
                                    ),
                                ),
                                string(" }"),
                            );
                            let v211: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v206()}</div> },
                            );
                            leptos::IntoView::into_view(v211)
                        }
                    } else {
                        let v218: Array<leptos::View> = Dice_ui::method151(Dice_ui::method150(
                            Dice_ui::method123(new_empty::<leptos::View>()),
                        ));
                        leptos::CollectView::collect_view(v218.to_vec())
                    },
                ])),
            ));
            leptos::Fragment::new(v225.to_vec())
        }
        pub fn method202(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
            v1: u64,
            v2: u32,
            v3: std::string::String,
            v4: std::string::String,
            v5: Array<std::string::String>,
            v6: bool,
            v7: f64,
            v8: std::string::String,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            v12: LrcPtr<Dice_ui::Heap2>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v12 = v12.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure108(
                        v0_1.clone(),
                        v1,
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6,
                        v7,
                        v8.clone(),
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        v12.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure105(
            v0_1: i64,
            v1: Array<(std::string::String, Dice_ui::US13)>,
            v2: u64,
            v3: u32,
            v4: std::string::String,
            v5: std::string::String,
            v6: Array<std::string::String>,
            v7: bool,
            v8: f64,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            v12: std::string::String,
            v13: LrcPtr<Dice_ui::Heap2>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v15 = Dice_ui::method200(Dice_ui::method199(v0_1));
            let v16: string =
                string("<span class=\"flex items-center pb-[6px]\"><span class=\"pr-[15px] [font-size:14px]\">{v15()}</span><span class=\"h-px flex-1 bg-gray-300\"></span></span>");
            let v17: string = append(append(string("leptos::view! { "), v16), string(" }"));
            let v20: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method201(
                leptos::view! { <span class="flex items-center pb-[6px]"><span class="pr-[15px] [font-size:14px]">{v15()}</span><span class="h-px flex-1 bg-gray-300"></span></span> },
            );
            let v22: leptos::View = leptos::IntoView::into_view(v20);
            let v26: string = string(" class=\"grid flex-1 divide-y-[1px] divide-gray-500/[.10]\"");
            let v28 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method202(
                v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13,
            )));
            let v31: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v26), string(">{v28()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v34: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="grid flex-1 divide-y-[1px] divide-gray-500/[.10]">{v28()}</div> },
            );
            let v40: Array<leptos::View> =
                Dice_ui::method125(Dice_ui::method124(Dice_ui::method123(new_array(&[
                    v22,
                    leptos::IntoView::into_view(v34),
                ]))));
            leptos::Fragment::new(v40.to_vec())
        }
        pub fn method198(
            v0_1: i64,
            v1: Array<(std::string::String, Dice_ui::US13)>,
            v2: u64,
            v3: u32,
            v4: std::string::String,
            v5: std::string::String,
            v6: Array<std::string::String>,
            v7: bool,
            v8: f64,
            v9: std::string::String,
            v10: std::string::String,
            v11: std::string::String,
            v12: std::string::String,
            v13: LrcPtr<Dice_ui::Heap2>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v10 = v10.clone();
                let v11 = v11.clone();
                let v12 = v12.clone();
                let v13 = v13.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                let v7 = v7.clone();
                let v8 = v8.clone();
                let v9 = v9.clone();
                move || {
                    Dice_ui::closure105(
                        v0_1,
                        v1.clone(),
                        v2,
                        v3,
                        v4.clone(),
                        v5.clone(),
                        v6.clone(),
                        v7,
                        v8,
                        v9.clone(),
                        v10.clone(),
                        v11.clone(),
                        v12.clone(),
                        v13.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure104(unitVar: (), _arg: (usize, LrcPtr<Dice_ui::Heap5>)) -> leptos::Fragment {
            let v1: LrcPtr<Dice_ui::Heap5> = _arg.1.clone();
            let v14: i64 = _arg.0.clone() as i64;
            let v16: Option<LrcPtr<Dice_ui::Heap2>> = leptos::use_context::<std::rc::Rc<Heap2>>();
            let v22: string = string(" class=\"flex flex-1 flex-col\"");
            let v24 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method198(
                v14,
                v1.l0.clone(),
                v1.l1,
                v1.l2,
                v1.l3.clone(),
                v1.l4.clone(),
                v1.l5.clone(),
                v1.l6,
                v1.l7,
                v1.l8.clone(),
                v1.l9.clone(),
                v1.l10.clone(),
                v1.l11.clone(),
                v16.unwrap(),
            )));
            let v27: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v22), string(">{v24()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v30: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="flex flex-1 flex-col">{v24()}</div> },
            );
            let v32: leptos::View = leptos::IntoView::into_view(v30);
            leptos::Fragment::new(vec![v32])
        }
        pub fn method197() -> Func1<(usize, LrcPtr<Dice_ui::Heap5>), leptos::Fragment> {
            Func1::new(move |arg10_0040: (usize, LrcPtr<Dice_ui::Heap5>)| {
                Dice_ui::closure104((), arg10_0040)
            })
        }
        pub fn closure102(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: Array<(usize, LrcPtr<Dice_ui::Heap5>)> = Dice_ui::method195(v0_1);
            let v2 = Dice_ui::method196();
            let v3 = Dice_ui::method197();
            let v15: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos::For  children=move |x| v3(x) let:x key=move |x| v2(x.to_owned()) each=move || v1.to_vec() /> })");
            let v16: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos::For  children=move |x| v3(x) let:x key=move |x| v2(x.to_owned()) each=move || v1.to_vec() /> },
            );
            leptos::Fragment::new(vec![v16])
        }
        pub fn method194(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap5>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure102(v0_1.clone(), ())
            })
        }
        pub fn closure143(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string =
                string("<svg version=\"1.1\" id=\"Layer_1\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" x=\"0px\" y=\"0px\" width=\"24px\" height=\"30px\" viewBox=\"0 0 24 30\" style=\"enable-background:new 0 0 50 50;\" xml:space=\"preserve\"><rect x=\"0\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\" opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect><rect x=\"8\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\"  opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect><rect x=\"16\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\"  opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect></svg>");
            let v1: string = append(append(string("leptos::view! { "), v0_1), string(" }"));
            let v4: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method193(
                leptos::view! { <svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" width="24px" height="30px" viewBox="0 0 24 30" style="enable-background:new 0 0 50 50;" xml:space="preserve"><rect x="0" y="10" width="4" height="10" fill="#333" opacity="0.2"><animate attributeName="opacity" attributeType="XML" values="0.2; 1; .2" begin="0s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="height" attributeType="XML" values="10; 20; 10" begin="0s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="y" attributeType="XML" values="10; 5; 10" begin="0s" dur="0.6s" repeatCount="indefinite" /></rect><rect x="8" y="10" width="4" height="10" fill="#333"  opacity="0.2"><animate attributeName="opacity" attributeType="XML" values="0.2; 1; .2" begin="0.15s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="height" attributeType="XML" values="10; 20; 10" begin="0.15s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="y" attributeType="XML" values="10; 5; 10" begin="0.15s" dur="0.6s" repeatCount="indefinite" /></rect><rect x="16" y="10" width="4" height="10" fill="#333"  opacity="0.2"><animate attributeName="opacity" attributeType="XML" values="0.2; 1; .2" begin="0.3s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="height" attributeType="XML" values="10; 20; 10" begin="0.3s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="y" attributeType="XML" values="10; 5; 10" begin="0.3s" dur="0.6s" repeatCount="indefinite" /></rect></svg> },
            );
            let v6: leptos::View = leptos::IntoView::into_view(v4);
            let v10: string =
                Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(string("Loading..."))));
            let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
            let v14: std::string::String = String::from(v12);
            let v16: leptos::leptos_dom::Text = leptos::html::text(v14);
            let v22: Array<leptos::View> =
                Dice_ui::method125(Dice_ui::method124(Dice_ui::method123(new_array(&[
                    v6,
                    leptos::IntoView::into_view(v16),
                ]))));
            leptos::Fragment::new(v22.to_vec())
        }
        pub fn method257() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure143((), ()))
        }
        pub fn closure142(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v3: string = string(" class=\"flex flex-1 [gap:4px] items-center\"");
            let v5 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method257()));
            let v8: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v3), string(">{v5()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v11: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="flex flex-1 [gap:4px] items-center">{v5()}</div> },
            );
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            leptos::Fragment::new(vec![v13])
        }
        pub fn method256() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure142((), ()))
        }
        pub fn closure101(v0_1: Func0<Dice_ui::US34>, unitVar: ()) -> leptos::Fragment {
            let v1: Func0<Dice_ui::US34> = Dice_ui::method192(v0_1);
            let v3: Dice_ui::US34 = v1();
            if let Dice_ui::US34::US34_1(v3_1_0) = &v3 {
                let v4: Dice_ui::US35 = match &v3 {
                    Dice_ui::US34::US34_1(x) => x.clone(),
                    _ => unreachable!(),
                };
                match &v4 {
                    Dice_ui::US35::US35_1(v4_1_0) => {
                        let v6: string =
                            string("class=\"grid flex-1 py-[10px] px-[12px] [gap:15px] sm:[grid-template-columns:repeat(auto-fill,minmax(500px,1fr))]\"");
                        let v9: string =
                            append(append(append(string(" "), v6), string("")), string(""));
                        let v11 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method194(
                            v4_1_0.clone(),
                        )));
                        let v14: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v9), string(">{v11()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v17: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                            leptos::view! { <div  class="grid flex-1 py-[10px] px-[12px] [gap:15px] sm:[grid-template-columns:repeat(auto-fill,minmax(500px,1fr))]">{v11()}</div> },
                        );
                        let v19: leptos::View = leptos::IntoView::into_view(v17);
                        leptos::Fragment::new(vec![v19])
                    }
                    Dice_ui::US35::US35_0(v4_0_0) => {
                        let v23: string =
                            string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"[height:100%] text-red-700\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M6 18L18 6M6 6l12 12\" /></svg>");
                        let v24: string =
                            append(append(string("leptos::view! { "), v23), string(" }"));
                        let v27: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method193(
                            leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="[height:100%] text-red-700"><path stroke-linecap="round" stroke-linejoin="round" d="M6 18L18 6M6 6l12 12" /></svg> },
                        );
                        let v29: leptos::View = leptos::IntoView::into_view(v27);
                        let v32: string =
                            Dice_ui::method5(Dice_ui::method14(Dice_ui::method148(v4_0_0.clone())));
                        let v34: &str = fable_library_rust::String_::LrcStr::as_str(&v32);
                        let v36: std::string::String = String::from(v34);
                        let v38: leptos::leptos_dom::Text = leptos::html::text(v36);
                        let v44: Array<leptos::View> = Dice_ui::method125(Dice_ui::method124(
                            Dice_ui::method123(new_array(&[v29, leptos::IntoView::into_view(v38)])),
                        ));
                        leptos::Fragment::new(v44.to_vec())
                    }
                }
            } else {
                let v52: string = string(" class=\"grid place-content-center py-[10vh]\"");
                let v54 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method256()));
                let v57: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v52), string(">{v54()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v60: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                    leptos::view! { <div  class="grid place-content-center py-[10vh]">{v54()}</div> },
                );
                let v62: leptos::View = leptos::IntoView::into_view(v60);
                leptos::Fragment::new(vec![v62])
            }
        }
        pub fn method191(v0_1: Func0<Dice_ui::US34>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure101(v0_1.clone(), ())
            })
        }
        pub fn method260() -> string {
            string("Transactions")
        }
        pub fn closure145(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method260()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method259() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure145((), ()))
        }
        pub fn closure146(v0_1: Func0<Dice_ui::US34>, unitVar: ()) -> leptos::Fragment {
            let v1: Func0<Dice_ui::US34> = Dice_ui::method192(v0_1);
            let v3: Dice_ui::US34 = v1();
            let v6: std::string::String = Dice_ui::method35(format!("{:#?}", &v3));
            let v13: string =
                string(" class=\"[padding:1px] [font-size:11px] [line-height:11px] [text-wrap:pretty] [max-height:70vh]\"");
            let v15 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method255(
                fable_library_rust::String_::fromString(v6),
            )));
            let v18: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v13), string(">{v15()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v21: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method149(
                leptos::view! { <pre  class="[padding:1px] [font-size:11px] [line-height:11px] [text-wrap:pretty] [max-height:70vh]">{v15()}</pre> },
            );
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            leptos::Fragment::new(vec![v23])
        }
        pub fn method261(v0_1: Func0<Dice_ui::US34>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure146(v0_1.clone(), ())
            })
        }
        pub fn closure144(v0_1: Func0<Dice_ui::US34>, unitVar: ()) -> leptos::Fragment {
            let v9: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] \"");
            let v11 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method115(
                Dice_ui::method259(),
                Dice_ui::method261(v0_1),
            )));
            let v14: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v9), string(">{v11()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v18: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method132(new_array(
                &[
                    leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] ">{v11()}</div> },
                ],
            ));
            let v19 = Dice_ui::method133();
            let v20: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method135(v18);
            let v23: Vec<leptos::View> =
                Dice_ui::method136(v20.to_vec().iter().map(|x| v19(x.clone())).collect());
            let v27: Array<leptos::View> = Dice_ui::method125(Dice_ui::method124(
                fable_library_rust::NativeArray_::array_from(v23),
            ));
            leptos::Fragment::new(v27.to_vec())
        }
        pub fn method258(v0_1: Func0<Dice_ui::US34>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure144(v0_1.clone(), ())
            })
        }
        pub fn closure81(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("transactions.render ()"));
            {
                let v3: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v5: LrcPtr<Dice_ui::Heap2> = v3.unwrap();
                let v6 = Dice_ui::method153();
                let v9 = Dice_ui::method154(leptos::create_memo(move |_| v6()));
                let v13 = Dice_ui::method160(leptos::create_local_resource(
                    move || v9(),
                    |x| async move {
                        Func1::new(move |v: Option<string>| Dice_ui::closure84((), v))(x).await
                    },
                ));
                let v16 = Dice_ui::method163(leptos::create_memo(move |_| v13()));
                let v19 = Dice_ui::method180(Func0::new(move || v16()));
                let v21: Func0<Dice_ui::US34> = Func0::new(move || v19());
                let v23: string = Dice_ui::method5(Dice_ui::method190());
                let v25: &str = fable_library_rust::String_::LrcStr::as_str(&v23);
                let v27: std::string::String = String::from(v25);
                let v29 = Dice_ui::method137(Dice_ui::method191(v21.clone()));
                let v30: string =
                    string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                let v31: string = append(append(string("leptos::view! { "), v30), string(" }"));
                let v33: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                let v34: string =
                    string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v27}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v33}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column]\">{v29()}</div></details>");
                let v35: string = append(append(string("leptos::view! { "), v34), string(" }"));
                let v38: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method138(
                    leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v27}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v33}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column]">{v29()}</div></details> },
                );
                let v40: leptos::View = leptos::IntoView::into_view(v38);
                let v42: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                    Dice_ui::method37(v5.l0.clone());
                let v46: leptos::RwSignal<bool> =
                    Dice_ui::method65((leptos::SignalGetUntracked::get_untracked(&v42)).l1.clone());
                let v78: Array<leptos::View> = Dice_ui::method125(Dice_ui::method124(
                    Dice_ui::method123(new_array(&[
                        v40,
                        if leptos::SignalGet::get(&v46) {
                            let v50: string = Dice_ui::method5(Dice_ui::method139());
                            let v52: &str = fable_library_rust::String_::LrcStr::as_str(&v50);
                            let v54: std::string::String = String::from(v52);
                            let v56 = Dice_ui::method137(Dice_ui::method258(v21));
                            let v57:
                                                                                                     string =
                                                                                                 string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                            let v58: string =
                                append(append(string("leptos::view! { "), v57), string(" }"));
                            let v60: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                            let v61:
                                                                                                     string =
                                                                                                 string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v54}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v60}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column]\">{v56()}</div></details>");
                            let v62: string =
                                append(append(string("leptos::view! { "), v61), string(" }"));
                            let v65: leptos::HtmlElement<leptos::html::Details> =
                                Dice_ui::method138(
                                    leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v54}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v60}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column]">{v56()}</div></details> },
                                );
                            leptos::IntoView::into_view(v65)
                        } else {
                            let v71: Array<leptos::View> = Dice_ui::method151(Dice_ui::method150(
                                Dice_ui::method123(new_empty::<leptos::View>()),
                            ));
                            leptos::CollectView::collect_view(v71.to_vec())
                        },
                    ])),
                ));
                leptos::Fragment::new(v78.to_vec())
            }
        }
        pub fn method152() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure81((), ()))
        }
        pub fn closure58(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> leptos::Fragment {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method103(v0_1);
            let v3: Dice_ui::US21 = leptos::SignalGet::get(&v1);
            let v39: leptos::View = match &v3 {
                Dice_ui::US21::US21_1 => {
                    let v21: string = string(" class=\"flex flex-1 flex-col [overflow-y:auto]\"");
                    let v23 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method104()));
                    let v26: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<div "), v21), string(">{v23()}</")),
                                    string("div"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v29: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                        leptos::view! { <div  class="flex flex-1 flex-col [overflow-y:auto]">{v23()}</div> },
                    );
                    leptos::IntoView::into_view(v29)
                }
                Dice_ui::US21::US21_2 => {
                    let v7: string = string(" class=\"flex flex-1 flex-col [overflow-y:auto]\"");
                    let v9 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method152()));
                    let v12: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<div "), v7), string(">{v9()}</")),
                                    string("div"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v15: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                        leptos::view! { <div  class="flex flex-1 flex-col [overflow-y:auto]">{v9()}</div> },
                    );
                    leptos::IntoView::into_view(v15)
                }
                _ => {
                    let v35: Array<leptos::View> =
                        Dice_ui::method151(Dice_ui::method150(Dice_ui::method123(new_empty::<
                            leptos::View,
                        >(
                        ))));
                    leptos::CollectView::collect_view(v35.to_vec())
                }
            };
            leptos::Fragment::new(vec![v39])
        }
        pub fn method102(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure58(v0_1.clone(), ())
            })
        }
        pub fn method265() -> string {
            string("Tab")
        }
        pub fn closure149(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method265()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method264() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure149((), ()))
        }
        pub fn closure151(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method103(v0_1);
            if let Dice_ui::US21::US21_2 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method267(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure151(v0_1.clone(), ())
            })
        }
        pub fn closure152(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method260()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method268() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure152((), ()))
        }
        pub fn closure153(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method103(v0_1);
            if let Dice_ui::US21::US21_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method269(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure153(v0_1.clone(), ())
            })
        }
        pub fn method271() -> string {
            string("Settings")
        }
        pub fn closure154(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method271()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method270() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure154((), ()))
        }
        pub fn method272(
            v0_1: Array<leptos::HtmlElement<leptos::html::Option_>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Option_>> {
            v0_1
        }
        pub fn method274(
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::HtmlElement<leptos::html::Option_> {
            v0_1
        }
        pub fn closure155(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Option_> = Dice_ui::method274(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method273() -> Func1<leptos::HtmlElement<leptos::html::Option_>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Option_>| {
                Dice_ui::closure155((), v)
            })
        }
        pub fn method275(
            v0_1: Array<leptos::HtmlElement<leptos::html::Option_>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Option_>> {
            v0_1
        }
        pub fn closure150(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method267(v0_1.clone());
            let v5: string = string(" select=v1()");
            let v7 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method268()));
            let v10: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<option "), v5), string(">{v7()}</")),
                            string("option"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Option_> =
                leptos::view! { <option  select=v1()>{v7()}</option> };
            let v13 = Dice_ui::method269(v0_1);
            let v16: string = string(" select=v13()");
            let v18 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method270()));
            let v20: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<option "), v16), string(">{v18()}</")),
                            string("option"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v24: Array<leptos::HtmlElement<leptos::html::Option_>> =
                Dice_ui::method272(new_array(&[
                    v12,
                    leptos::view! { <option  select=v13()>{v18()}</option> },
                ]));
            let v25 = Dice_ui::method273();
            let v26: Array<leptos::HtmlElement<leptos::html::Option_>> = Dice_ui::method275(v24);
            let v29: Vec<leptos::View> =
                Dice_ui::method136(v26.to_vec().iter().map(|x| v25(x.clone())).collect());
            let v33: Array<leptos::View> = Dice_ui::method125(Dice_ui::method124(
                fable_library_rust::NativeArray_::array_from(v29),
            ));
            leptos::Fragment::new(v33.to_vec())
        }
        pub fn method266(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure150(v0_1.clone(), ())
            })
        }
        pub fn method276(
            v0_1: leptos::HtmlElement<leptos::html::Select>,
        ) -> leptos::HtmlElement<leptos::html::Select> {
            v0_1
        }
        pub fn closure148(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string(" class=\"sr-only\" for=\"Tab\"");
            let v8 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method264()));
            let v11: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<label "), v6), string(">{v8()}</")),
                            string("label"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v14: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method114(
                leptos::view! { <label  class="sr-only" for="Tab">{v8()}</label> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v21: string = string(" class=\"w-full rounded-md border-gray-200\" id=\"Tab\"");
            let v23 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method266(v0_1)));
            let v26: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<select "), v21), string(">{v23()}</")),
                            string("select"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v29: leptos::HtmlElement<leptos::html::Select> = Dice_ui::method276(
                leptos::view! { <select  class="w-full rounded-md border-gray-200" id="Tab">{v23()}</select> },
            );
            let v35: Array<leptos::View> =
                Dice_ui::method125(Dice_ui::method124(Dice_ui::method123(new_array(&[
                    v16,
                    leptos::IntoView::into_view(v29),
                ]))));
            leptos::Fragment::new(v35.to_vec())
        }
        pub fn method263(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure148(v0_1.clone(), ())
            })
        }
        pub fn closure159(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method103(v0_1);
            if let Dice_ui::US21::US21_2 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method280(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure159(v0_1.clone(), ())
            })
        }
        pub fn method281(v0_1: Func0<bool>) -> Func0<bool> {
            v0_1
        }
        pub fn closure160(v0_1: Func0<bool>, unitVar: ()) -> &'static str {
            if v0_1() {
                let v3: string = string("r#\"border-grey-200 text-grey-900\"#");
                r#"border-grey-200 text-grey-900"#
            } else {
                let v6: string =
                    string("r#\"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700\"#");
                r#"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700"#
            }
        }
        pub fn method282(v0_1: Func0<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure160(v0_1.clone(), ())
            })
        }
        pub fn closure161(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method193(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v6: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method260()));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v18: Array<leptos::View> =
                Dice_ui::method125(Dice_ui::method124(Dice_ui::method123(new_array(&[
                    v3,
                    leptos::IntoView::into_view(v12),
                ]))));
            leptos::Fragment::new(v18.to_vec())
        }
        pub fn method283(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure161(v0_1.clone(), ())
            })
        }
        pub fn closure162(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method103(v0_1);
            if let Dice_ui::US21::US21_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method284(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure162(v0_1.clone(), ())
            })
        }
        pub fn closure163(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method193(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v6: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method271()));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v18: Array<leptos::View> =
                Dice_ui::method125(Dice_ui::method124(Dice_ui::method123(new_array(&[
                    v3,
                    leptos::IntoView::into_view(v12),
                ]))));
            leptos::Fragment::new(v18.to_vec())
        }
        pub fn method285(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure163(v0_1.clone(), ())
            })
        }
        pub fn method286(
            v0_1: Array<leptos::HtmlElement<leptos::html::A>>,
        ) -> Array<leptos::HtmlElement<leptos::html::A>> {
            v0_1
        }
        pub fn method288(
            v0_1: leptos::HtmlElement<leptos::html::A>,
        ) -> leptos::HtmlElement<leptos::html::A> {
            v0_1
        }
        pub fn closure164(unitVar: (), v0_1: leptos::HtmlElement<leptos::html::A>) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::A> = Dice_ui::method288(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method287() -> Func1<leptos::HtmlElement<leptos::html::A>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::A>| Dice_ui::closure164((), v))
        }
        pub fn method289(
            v0_1: Array<leptos::HtmlElement<leptos::html::A>>,
        ) -> Array<leptos::HtmlElement<leptos::html::A>> {
            v0_1
        }
        pub fn closure158(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string = append(v1.clone(), string("#/transactions"));
            let v3: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z\"/></svg>");
            let v4: string = append(append(string("leptos::view! { "), v3), string(" }"));
            let v6: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="h-5 w-5"><path stroke-linecap="round" stroke-linejoin="round" d="M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z"/></svg> };
            let v8: string = Dice_ui::method5(Dice_ui::method14(v2));
            let v10: &str = fable_library_rust::String_::LrcStr::as_str(&v8);
            let v12: std::string::String = String::from(v10);
            let v13 = Dice_ui::method280(v0_1.clone());
            let v14 = Dice_ui::method281(v13.clone());
            let v15 = Dice_ui::method282(v13);
            let v17: string =
                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium \".to_owned() + v15()}");
            let v23: string = append(
                append(
                    string(" aria-current={move || if v14() { \"page\" } else { \"\" }}"),
                    append(
                        append(append(string(" "), v17), string(" href=v12")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v25 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method283(v6)));
            let v28: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<a "), v23), string(">{v25()}</")),
                            string("a"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v30: leptos::HtmlElement<leptos::html::A> = leptos::view! { <a  aria-current={move || if v14() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium ".to_owned() + v15()} href=v12>{v25()}</a> };
            let v31: string = append(v1, string("#/settings"));
            let v32: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\"/><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M15 12a3 3 0 11-6 0 3 3 0 016 0z\"/></svg>");
            let v33: string = append(append(string("leptos::view! { "), v32), string(" }"));
            let v35: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="h-5 w-5"><path stroke-linecap="round" stroke-linejoin="round" d="M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z"/><path stroke-linecap="round" stroke-linejoin="round" d="M15 12a3 3 0 11-6 0 3 3 0 016 0z"/></svg> };
            let v37: string = Dice_ui::method5(Dice_ui::method14(v31));
            let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
            let v41: std::string::String = String::from(v39);
            let v42 = Dice_ui::method284(v0_1);
            let v43 = Dice_ui::method281(v42.clone());
            let v44 = Dice_ui::method282(v42);
            let v46: string =
                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium \".to_owned() + v44()}");
            let v51: string = append(
                append(
                    string(" aria-current={move || if v43() { \"page\" } else { \"\" }}"),
                    append(
                        append(append(string(" "), v46), string(" href=v41")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v53 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method285(v35)));
            let v55: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<a "), v51), string(">{v53()}</")),
                            string("a"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v59: Array<leptos::HtmlElement<leptos::html::A>> = Dice_ui::method286(new_array(
                &[
                    v30,
                    leptos::view! { <a  aria-current={move || if v43() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium ".to_owned() + v44()} href=v41>{v53()}</a> },
                ],
            ));
            let v60 = Dice_ui::method287();
            let v61: Array<leptos::HtmlElement<leptos::html::A>> = Dice_ui::method289(v59);
            let v64: Vec<leptos::View> =
                Dice_ui::method136(v61.to_vec().iter().map(|x| v60(x.clone())).collect());
            let v68: Array<leptos::View> = Dice_ui::method125(Dice_ui::method124(
                fable_library_rust::NativeArray_::array_from(v64),
            ));
            leptos::Fragment::new(v68.to_vec())
        }
        pub fn method279(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure158(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method290(
            v0_1: leptos::HtmlElement<leptos::html::Nav>,
        ) -> leptos::HtmlElement<leptos::html::Nav> {
            v0_1
        }
        pub fn closure157(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string =
                string("class=\"-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]\"");
            let v7: string = append(
                append(
                    string(" aria-label=\"Tabs\""),
                    append(append(append(string(" "), v2), string("")), string("")),
                ),
                string(""),
            );
            let v9 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method279(v0_1, v1)));
            let v12: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<nav "), v7), string(">{v9()}</")),
                            string("nav"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v15: leptos::HtmlElement<leptos::html::Nav> = Dice_ui::method290(
                leptos::view! { <nav  aria-label="Tabs" class="-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]">{v9()}</nav> },
            );
            let v17: leptos::View = leptos::IntoView::into_view(v15);
            leptos::Fragment::new(vec![v17])
        }
        pub fn method278(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure157(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure156(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"flex flex-1 border-t border-gray-200\"");
            let v7 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method278(v0_1, v1)));
            let v10: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v5), string(">{v7()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v13: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="flex flex-1 border-t border-gray-200">{v7()}</div> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method277(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure156(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure147(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("menu_tabs.render ()"));
            {
                let v4: leptos_router::Location = leptos_router::use_location();
                let v5: leptos_router::Location = Dice_ui::method85(v4.clone());
                let v8: leptos::Memo<std::string::String> = Dice_ui::method86(v5.pathname);
                let v11: std::string::String = Dice_ui::method35(v8());
                let v13: string = fable_library_rust::String_::fromString(v11);
                let v14: leptos_router::Location = Dice_ui::method87(v4);
                let v17: leptos::Memo<std::string::String> = Dice_ui::method86(v14.search);
                let v20: std::string::String = Dice_ui::method35(v17());
                let v22: string = fable_library_rust::String_::fromString(v20);
                let v28: string = append(
                    v13,
                    (if v22.clone() == string("") {
                        string("")
                    } else {
                        sprintf!("?{}", &v22)
                    }),
                );
                let v32: string = string(" class=\"hidden\"");
                let v34 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method263(v0_1.clone())));
                let v37: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v32), string(">{v34()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v39: leptos::HtmlElement<leptos::html::Div> =
                    leptos::view! { <div  class="hidden">{v34()}</div> };
                let v42: string =
                    string(" class=\"flex flex-1 [overflow-x:auto] [overflow-y:hidden]\"");
                let v44 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method277(v0_1, v28)));
                let v46: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v42), string(">{v44()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v50: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method132(
                    new_array(&[
                        v39,
                        leptos::view! { <div  class="flex flex-1 [overflow-x:auto] [overflow-y:hidden]">{v44()}</div> },
                    ]),
                );
                let v51 = Dice_ui::method133();
                let v52: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method135(v50);
                let v55: Vec<leptos::View> =
                    Dice_ui::method136(v52.to_vec().iter().map(|x| v51(x.clone())).collect());
                let v59: Array<leptos::View> = Dice_ui::method125(Dice_ui::method124(
                    fable_library_rust::NativeArray_::array_from(v55),
                ));
                leptos::Fragment::new(v59.to_vec())
            }
        }
        pub fn method262(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure147(v0_1.clone(), ())
            })
        }
        pub fn closure57(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 flex-col [overflow:hidden]\"");
            let v6 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method102(v0_1.clone())));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v4), string(">{v6()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="flex flex-1 flex-col [overflow:hidden]">{v6()}</div> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"flex\"");
            let v19 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method262(v0_1)));
            let v21: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v17), string(">{v19()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v24: leptos::HtmlElement<leptos::html::Div> =
                Dice_ui::method134(leptos::view! { <div  class="flex">{v19()}</div> });
            let v30: Array<leptos::View> =
                Dice_ui::method125(Dice_ui::method124(Dice_ui::method123(new_array(&[
                    v14,
                    leptos::IntoView::into_view(v24),
                ]))));
            leptos::Fragment::new(v30.to_vec())
        }
        pub fn method101(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure57(v0_1.clone(), ())
            })
        }
        pub fn closure56(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> leptos::Fragment {
            let v1: string =
                string("class=\"flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100vh] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm\"");
            let v4: string = append(append(append(string(" "), v1), string("")), string(""));
            let v6 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method101(v0_1)));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v4), string(">{v6()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                leptos::view! { <div  class="flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100vh] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm">{v6()}</div> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method100(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure56(v0_1.clone(), ())
            })
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("content.render ()"));
            {
                let v3: leptos_router::Location = leptos_router::use_location();
                let v5: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)> =
                    std::sync::Arc::new(leptos_router::use_navigate());
                let v7: leptos_router::Location = leptos_router::use_location();
                let v8: leptos_router::Location = Dice_ui::method85(v7.clone());
                let v11: leptos::Memo<std::string::String> = Dice_ui::method86(v8.pathname);
                let v14: std::string::String = Dice_ui::method35(v11());
                let v16: string = fable_library_rust::String_::fromString(v14);
                let v17: leptos_router::Location = Dice_ui::method87(v7);
                let v20: leptos::Memo<std::string::String> = Dice_ui::method86(v17.search);
                let v23: std::string::String = Dice_ui::method35(v20());
                let v25: string = fable_library_rust::String_::fromString(v23);
                let v31: string = append(
                    v16,
                    (if v25.clone() == string("") {
                        string("")
                    } else {
                        sprintf!("?{}", &v25)
                    }),
                );
                let v33: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v35: LrcPtr<Dice_ui::Heap2> = v33.unwrap();
                let v36: Dice_ui::US21 = Dice_ui::method88();
                let patternInput: (
                    leptos::ReadSignal<Dice_ui::US21>,
                    leptos::WriteSignal<Dice_ui::US21>,
                ) = leptos::create_signal(v36);
                let v40: bool = Dice_ui::method62();
                let patternInput_1: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                    leptos::create_signal(v40);
                let v44 = Dice_ui::method89(
                    v3.clone(),
                    v5,
                    v31,
                    v35,
                    patternInput_1.1.clone(),
                    patternInput_1.0.clone(),
                );
                leptos::create_effect(move |_| v44());
                {
                    let v46 = Dice_ui::method93(v3, patternInput.1.clone());
                    leptos::create_effect(move |_| v46());
                    {
                        let v51: string =
                            string(" class=\"flex flex-1 max-[100px]:[overflow-x:auto]\"");
                        let v53 = Dice_ui::method118(Dice_ui::method117(Dice_ui::method100(
                            patternInput.0.clone(),
                        )));
                        let v56: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v51), string(">{v53()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v59: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method134(
                            leptos::view! { <div  class="flex flex-1 max-[100px]:[overflow-x:auto]">{v53()}</div> },
                        );
                        let v61: leptos::View = leptos::IntoView::into_view(v59);
                        leptos::Fragment::new(vec![v61])
                    }
                }
            }
        }
        pub fn method84() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure49((), ()))
        }
        pub fn closure5(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(1_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v7: LrcPtr<Dice_ui::Heap2> = v5.unwrap();
                let v8 = Dice_ui::method16();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method19(v11.clone());
                let v16 = Dice_ui::method26(
                    v7.clone(),
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move
                                                                                                                   |v_1:
                                                                                                                        Option<rexie::Rexie>|
                                                                                                                   Dice_ui::closure11((),
                                                                                                                                      v_1))(x).await
                        },
                    ),
                );
                leptos::create_effect(move |_| v16());
                {
                    let v18 = Dice_ui::method44(v11.clone());
                    let v22 = Dice_ui::method47(
                        v7.clone(),
                        leptos::create_local_resource(
                            move || v18(),
                            |x| async move {
                                Func1::new(move |v_2: Option<rexie::Rexie>| {
                                    Dice_ui::closure30((), v_2)
                                })(x)
                                .await
                            },
                        ),
                    );
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method56(v11.clone());
                        let v26: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                v24(value.clone())
                            });
                        let v27 = Dice_ui::method60(v7.clone());
                        let v29: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v27());
                        let v30: bool = Dice_ui::method62();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v30);
                        let v33: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v32: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v34 = Dice_ui::method63(v7.clone(), v26, v29, v33.clone(), v32.clone());
                        leptos::create_effect(move |_| v34());
                        {
                            let v36 = Dice_ui::method76(v11);
                            let v39 = Dice_ui::method78(
                                v7,
                                v33,
                                v32,
                                leptos::create_action(move |value: &std::rc::Rc<Heap4>| {
                                    v36(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<LrcPtr<Dice_ui::Heap2>> =
                                    leptos::use_context::<std::rc::Rc<Heap2>>();
                                let v46 = Dice_ui::method83(v42.unwrap());
                                let v52: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v54 =
                                    Dice_ui::method118(Dice_ui::method117(Dice_ui::method84()));
                                let v57: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v52),
                                                    string(">{v54()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v60: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method134(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v54()}</div> },
                                    );
                                let v62: leptos::View = leptos::IntoView::into_view(v60);
                                leptos::Fragment::new(vec![v62])
                            }
                        }
                    }
                }
            }
        }
        pub fn method15() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure5((), ()))
        }
        pub fn closure165(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v3: Array<leptos::View> =
                Dice_ui::method125(Dice_ui::method124(Dice_ui::method123(new_empty::<
                    leptos::View,
                >())));
            leptos::Fragment::new(v3.to_vec())
        }
        pub fn method291() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure165((), ()))
        }
        pub fn method292() -> string {
            string("/")
        }
        pub fn closure166(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(2_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v7: LrcPtr<Dice_ui::Heap2> = v5.unwrap();
                let v8 = Dice_ui::method16();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method19(v11.clone());
                let v16 = Dice_ui::method26(
                    v7.clone(),
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move
                                                                                                                   |v_1:
                                                                                                                        Option<rexie::Rexie>|
                                                                                                                   Dice_ui::closure11((),
                                                                                                                                      v_1))(x).await
                        },
                    ),
                );
                leptos::create_effect(move |_| v16());
                {
                    let v18 = Dice_ui::method44(v11.clone());
                    let v22 = Dice_ui::method47(
                        v7.clone(),
                        leptos::create_local_resource(
                            move || v18(),
                            |x| async move {
                                Func1::new(move |v_2: Option<rexie::Rexie>| {
                                    Dice_ui::closure30((), v_2)
                                })(x)
                                .await
                            },
                        ),
                    );
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method56(v11.clone());
                        let v26: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                v24(value.clone())
                            });
                        let v27 = Dice_ui::method60(v7.clone());
                        let v29: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v27());
                        let v30: bool = Dice_ui::method62();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v30);
                        let v33: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v32: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v34 = Dice_ui::method63(v7.clone(), v26, v29, v33.clone(), v32.clone());
                        leptos::create_effect(move |_| v34());
                        {
                            let v36 = Dice_ui::method76(v11);
                            let v39 = Dice_ui::method78(
                                v7,
                                v33,
                                v32,
                                leptos::create_action(move |value: &std::rc::Rc<Heap4>| {
                                    v36(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<LrcPtr<Dice_ui::Heap2>> =
                                    leptos::use_context::<std::rc::Rc<Heap2>>();
                                let v46 = Dice_ui::method83(v42.unwrap());
                                let v52: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v54 =
                                    Dice_ui::method118(Dice_ui::method117(Dice_ui::method84()));
                                let v57: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v52),
                                                    string(">{v54()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v60: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method134(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v54()}</div> },
                                    );
                                let v62: leptos::View = leptos::IntoView::into_view(v60);
                                leptos::Fragment::new(vec![v62])
                            }
                        }
                    }
                }
            }
        }
        pub fn method293() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure166((), ()))
        }
        pub fn method294() -> string {
            string("/*")
        }
        pub fn closure167(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(3_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v7: LrcPtr<Dice_ui::Heap2> = v5.unwrap();
                let v8 = Dice_ui::method16();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method19(v11.clone());
                let v16 = Dice_ui::method26(
                    v7.clone(),
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move
                                                                                                                   |v_1:
                                                                                                                        Option<rexie::Rexie>|
                                                                                                                   Dice_ui::closure11((),
                                                                                                                                      v_1))(x).await
                        },
                    ),
                );
                leptos::create_effect(move |_| v16());
                {
                    let v18 = Dice_ui::method44(v11.clone());
                    let v22 = Dice_ui::method47(
                        v7.clone(),
                        leptos::create_local_resource(
                            move || v18(),
                            |x| async move {
                                Func1::new(move |v_2: Option<rexie::Rexie>| {
                                    Dice_ui::closure30((), v_2)
                                })(x)
                                .await
                            },
                        ),
                    );
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method56(v11.clone());
                        let v26: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                v24(value.clone())
                            });
                        let v27 = Dice_ui::method60(v7.clone());
                        let v29: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v27());
                        let v30: bool = Dice_ui::method62();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v30);
                        let v33: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v32: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v34 = Dice_ui::method63(v7.clone(), v26, v29, v33.clone(), v32.clone());
                        leptos::create_effect(move |_| v34());
                        {
                            let v36 = Dice_ui::method76(v11);
                            let v39 = Dice_ui::method78(
                                v7,
                                v33,
                                v32,
                                leptos::create_action(move |value: &std::rc::Rc<Heap4>| {
                                    v36(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<LrcPtr<Dice_ui::Heap2>> =
                                    leptos::use_context::<std::rc::Rc<Heap2>>();
                                let v46 = Dice_ui::method83(v42.unwrap());
                                let v52: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v54 =
                                    Dice_ui::method118(Dice_ui::method117(Dice_ui::method84()));
                                let v57: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v52),
                                                    string(">{v54()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v60: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method134(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v54()}</div> },
                                    );
                                let v62: leptos::View = leptos::IntoView::into_view(v60);
                                leptos::Fragment::new(vec![v62])
                            }
                        }
                    }
                }
            }
        }
        pub fn method295() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure167((), ()))
        }
        pub fn method296() -> string {
            string("*")
        }
        pub fn closure168(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(4_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v7: LrcPtr<Dice_ui::Heap2> = v5.unwrap();
                let v8 = Dice_ui::method16();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method19(v11.clone());
                let v16 = Dice_ui::method26(
                    v7.clone(),
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move
                                                                                                                   |v_1:
                                                                                                                        Option<rexie::Rexie>|
                                                                                                                   Dice_ui::closure11((),
                                                                                                                                      v_1))(x).await
                        },
                    ),
                );
                leptos::create_effect(move |_| v16());
                {
                    let v18 = Dice_ui::method44(v11.clone());
                    let v22 = Dice_ui::method47(
                        v7.clone(),
                        leptos::create_local_resource(
                            move || v18(),
                            |x| async move {
                                Func1::new(move |v_2: Option<rexie::Rexie>| {
                                    Dice_ui::closure30((), v_2)
                                })(x)
                                .await
                            },
                        ),
                    );
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method56(v11.clone());
                        let v26: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                v24(value.clone())
                            });
                        let v27 = Dice_ui::method60(v7.clone());
                        let v29: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v27());
                        let v30: bool = Dice_ui::method62();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v30);
                        let v33: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v32: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v34 = Dice_ui::method63(v7.clone(), v26, v29, v33.clone(), v32.clone());
                        leptos::create_effect(move |_| v34());
                        {
                            let v36 = Dice_ui::method76(v11);
                            let v39 = Dice_ui::method78(
                                v7,
                                v33,
                                v32,
                                leptos::create_action(move |value: &std::rc::Rc<Heap4>| {
                                    v36(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<LrcPtr<Dice_ui::Heap2>> =
                                    leptos::use_context::<std::rc::Rc<Heap2>>();
                                let v46 = Dice_ui::method83(v42.unwrap());
                                let v52: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v54 =
                                    Dice_ui::method118(Dice_ui::method117(Dice_ui::method84()));
                                let v57: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v52),
                                                    string(">{v54()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v60: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method134(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v54()}</div> },
                                    );
                                let v62: leptos::View = leptos::IntoView::into_view(v60);
                                leptos::Fragment::new(vec![v62])
                            }
                        }
                    }
                }
            }
        }
        pub fn method297() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure168((), ()))
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method13()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method15();
            let v8 = Dice_ui::method291();
            let v18: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v8()) view=move || v7() path=v6 /> })");
            let v19: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  children=Box::new(move || v8()) view=move || v7() path=v6 /> },
            );
            let v22: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method292()));
            let v24: &str = fable_library_rust::String_::LrcStr::as_str(&v22);
            let v26: std::string::String = String::from(v24);
            let v27 = Dice_ui::method293();
            let v28 = Dice_ui::method291();
            let v36: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v28()) view=move || v27() path=v26 /> })");
            let v37: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  children=Box::new(move || v28()) view=move || v27() path=v26 /> },
            );
            let v40: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method294()));
            let v42: &str = fable_library_rust::String_::LrcStr::as_str(&v40);
            let v44: std::string::String = String::from(v42);
            let v45 = Dice_ui::method295();
            let v46 = Dice_ui::method291();
            let v54: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v46()) view=move || v45() path=v44 /> })");
            let v55: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  children=Box::new(move || v46()) view=move || v45() path=v44 /> },
            );
            let v58: string = Dice_ui::method5(Dice_ui::method14(Dice_ui::method296()));
            let v60: &str = fable_library_rust::String_::LrcStr::as_str(&v58);
            let v62: std::string::String = String::from(v60);
            let v63 = Dice_ui::method297();
            let v64 = Dice_ui::method291();
            let v72: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v64()) view=move || v63() path=v62 /> })");
            let v77: Array<leptos::View> = Dice_ui::method125(Dice_ui::method124(
                Dice_ui::method123(new_array(&[
                    v19,
                    v37,
                    v55,
                    leptos::IntoView::into_view(
                        leptos::view! { <leptos_router::Route  children=Box::new(move || v64()) view=move || v63() path=v62 /> },
                    ),
                ])),
            ));
            leptos::Fragment::new(v77.to_vec())
        }
        pub fn method12() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure4((), ()))
        }
        pub fn method298(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method298(Dice_ui::method12());
            let v7: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> })");
            let v8: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> },
            );
            leptos::Fragment::new(vec![v8])
        }
        pub fn method11() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure3((), ()))
        }
        pub fn method299(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
            leptos::logging::log!("{}", &string("app.render ()"));
            leptos_meta::provide_meta_context();
            {
                let v3: bool = Dice_ui::method3();
                let v5: leptos::RwSignal<bool> = leptos::create_rw_signal(v3);
                let v6: bool = Dice_ui::method3();
                let v8: leptos::RwSignal<bool> = leptos::create_rw_signal(v6);
                let v10: string = Dice_ui::method5(Dice_ui::method4());
                let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
                let v15: std::string::String = Dice_ui::method6(String::from(v12));
                let v19: LrcPtr<Dice_ui::Heap0> = Dice_ui::method7(LrcPtr::new(Dice_ui::Heap0 {
                    l0: v5,
                    l1: v8,
                    l2: leptos::create_rw_signal(v15),
                }));
                let v21: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = leptos::create_rw_signal(v19);
                let v24: std::collections::HashMap<
                    std::string::String,
                    leptos::RwSignal<std::string::String>,
                > = Dice_ui::method8(std::collections::HashMap::new());
                let v28: LrcPtr<Dice_ui::Heap1> = Dice_ui::method9(LrcPtr::new(Dice_ui::Heap1 {
                    l0: leptos::create_rw_signal(v24),
                }));
                let v30: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = leptos::create_rw_signal(v28);
                let v33: std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> =
                    Dice_ui::method10(std::collections::HashMap::new());
                let v36: LrcPtr<Dice_ui::Heap2> = LrcPtr::new(Dice_ui::Heap2 {
                    l0: v21,
                    l1: leptos::create_rw_signal(v33),
                    l2: v30,
                });
                leptos::provide_context::<std::rc::Rc<Heap2>>(v36);
                {
                    let v39 = Dice_ui::method299(Dice_ui::method11());
                    let v45: string =
                        string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Router  children=Box::new(move || v39()) /> })");
                    leptos::IntoView::into_view(
                        leptos::view! { <leptos_router::Router  children=Box::new(move || v39()) /> },
                    )
                }
            }
        }
        pub fn method2() {
            leptos::mount_to_body(|| Func0::new(move || Dice_ui::closure2((), ()))());
            ()
        }
        pub fn closure169(unitVar: (), unitVar_1: ()) {
            Dice_ui::method2();
        }
        pub fn method300() -> Func0<()> {
            Func0::new(move || Dice_ui::closure169((), ()))
        }
        pub fn method301(v0_1: Box<dyn Fn()>) -> Box<dyn Fn()> {
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
                    let v14: string = Dice_ui::method0();
                    let v16: &str = fable_library_rust::String_::LrcStr::as_str(&v14);
                    let v17: web_sys::HtmlElement = Dice_ui::method1(match &v9 {
                        Dice_ui::US0::US0_1(x) => x.clone(),
                        _ => unreachable!(),
                    });
                    v17.set_inner_html(v16);
                    Dice_ui::method2()
                } else {
                    let v19 = Dice_ui::method300();
                    let v22: Box<dyn Fn()> = Dice_ui::method301(Box::new(move || v19()));
                    let v24: wasm_bindgen::closure::Closure<dyn Fn()> =
                        wasm_bindgen::closure::Closure::wrap(v22);
                    let v26: &wasm_bindgen::JsValue = wasm_bindgen::closure::Closure::as_ref(&v24);
                    let v28: &js_sys::Function = wasm_bindgen::JsCast::unchecked_ref(v26);
                    leptos::document()
                        .add_event_listener_with_callback("DOMContentLoaded", v28)
                        .unwrap();
                    v24.forget();
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
