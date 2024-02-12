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
        use fable_library_rust::String_::substring2;
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
        #[derive(Clone, Debug, Default, serde::Serialize)]
        pub struct Heap1 {
            pub l0: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
            pub l1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        }
        impl core::fmt::Display for Dice_ui::Heap1 {
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
        pub struct Heap2 {
            pub l0: bool,
            pub l1: bool,
            pub l2: std::string::String,
        }
        impl core::fmt::Display for Dice_ui::Heap2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US3 {
            US3_0,
            US3_1(LrcPtr<Dice_ui::Heap2>),
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
            US6_0(std::string::String),
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
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(rexie::Error),
            US15_1,
        }
        impl core::fmt::Display for Dice_ui::US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0,
            US16_1(leptos::RwSignal<bool>),
        }
        impl core::fmt::Display for Dice_ui::US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US17 {
            US17_0,
            US17_1(bool),
        }
        impl core::fmt::Display for Dice_ui::US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US18 {
            US18_0,
            US18_1,
            US18_2,
        }
        impl core::fmt::Display for Dice_ui::US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US19 {
            US19_0(std::string::String),
            US19_1(leptos_router::Url),
        }
        impl core::fmt::Display for Dice_ui::US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US20 {
            US20_0(std::string::String),
            US20_1(std::string::String),
        }
        impl core::fmt::Display for Dice_ui::US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US21 {
            US21_0,
            US21_1(string),
        }
        impl core::fmt::Display for Dice_ui::US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US22 {
            US22_0(string),
            US22_1(Option<string>),
        }
        impl core::fmt::Display for Dice_ui::US22 {
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
            PartialEq,
        )]
        pub struct Heap3 {
            pub l0: std::string::String,
        }
        impl core::fmt::Display for Dice_ui::Heap3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0,
            US23_1(LrcPtr<Dice_ui::Heap3>),
        }
        impl core::fmt::Display for Dice_ui::US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0(std::string::String),
            US24_1(Dice_ui::US23),
        }
        impl core::fmt::Display for Dice_ui::US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0,
            US25_1(Option<LrcPtr<Dice_ui::Heap3>>),
        }
        impl core::fmt::Display for Dice_ui::US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0,
            US26_1(Dice_ui::US23),
        }
        impl core::fmt::Display for Dice_ui::US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US27 {
            US27_0,
            US27_1(Result<Option<string>, string>),
        }
        impl core::fmt::Display for Dice_ui::US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US28 {
            US28_0,
            US28_1(Dice_ui::US22),
        }
        impl core::fmt::Display for Dice_ui::US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US30 {
            US30_0(string),
            US30_1(Dice_ui::US21),
        }
        impl core::fmt::Display for Dice_ui::US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US29 {
            US29_0,
            US29_1(Dice_ui::US30),
        }
        impl core::fmt::Display for Dice_ui::US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US31 {
            US31_0(std::string::String),
            US31_1(Dice_ui::US13),
        }
        impl core::fmt::Display for Dice_ui::US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Heap4 {
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
        impl core::fmt::Display for Dice_ui::Heap4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US33 {
            US33_0,
            US33_1(Array<(usize, LrcPtr<Dice_ui::Heap4>)>),
        }
        impl core::fmt::Display for Dice_ui::US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US32 {
            US32_0(std::string::String),
            US32_1(Dice_ui::US33),
        }
        impl core::fmt::Display for Dice_ui::US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0(std::string::String),
            US34_1(
                Option<
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
                >,
            ),
        }
        impl core::fmt::Display for Dice_ui::US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US35 {
            US35_0,
            US35_1(
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
        impl core::fmt::Display for Dice_ui::US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US36 {
            US36_0,
            US36_1(chrono::NaiveDateTime),
        }
        impl core::fmt::Display for Dice_ui::US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US37 {
            US37_0(string),
            US37_1(string),
        }
        impl core::fmt::Display for Dice_ui::US37 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0(v0_1: string) -> string {
            v0_1
        }
        pub fn closure1(unitVar: (), v0_1: web_sys::HtmlElement) -> Dice_ui::US0 {
            Dice_ui::US0::US0_1(v0_1)
        }
        pub fn method1() -> string {
            string("")
        }
        pub fn method2(v0_1: web_sys::HtmlElement) -> web_sys::HtmlElement {
            v0_1
        }
        pub fn method4() -> bool {
            false
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn method6(v0_1: string) -> string {
            v0_1
        }
        pub fn method7(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method8(v0_1: LrcPtr<Dice_ui::Heap0>) -> LrcPtr<Dice_ui::Heap0> {
            v0_1
        }
        pub fn method9(
            v0_1: std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> {
            v0_1
        }
        pub fn method12() -> string {
            string("")
        }
        pub fn method13(v0_1: string) -> string {
            v0_1
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> Dice_ui::US1 {
            Dice_ui::US1::US1_0
        }
        pub fn method15() -> Func0<Dice_ui::US1> {
            Func0::new(move || Dice_ui::closure6((), ()))
        }
        pub fn closure8(unitVar: (), v0_1: rexie::Rexie) -> Dice_ui::US2 {
            Dice_ui::US2::US2_1(v0_1)
        }
        pub fn closure9(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US2 {
            Dice_ui::US2::US2_0(v0_1)
        }
        pub fn method16(v0_1: Dice_ui::US2) -> Dice_ui::US2 {
            v0_1
        }
        pub fn method17(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure7(
            unitVar: (),
            v0_1: Dice_ui::US1,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = rexie::Rexie>>> {
            let __future_init = Box::pin(async move {
                //;
                {
                    let v3: string = Dice_ui::method0(string(
                        "state.use_database (2) / database create_local_resource",
                    ));
                    leptos::logging::log!("{}", v3);
                    {
                        let v6: string = Dice_ui::method0(string("state.build_database ()"));
                        leptos::logging::log!("{}", v6);
                        let __future_init = Box::pin(async {
                            //;
                            {
                                let v9: string =
                            string("Box::pin(rexie::Rexie::builder(\"database\").version(1).add_object_store(rexie::ObjectStore::new(\"store\")).build())");
                                let v10: std::pin::Pin<
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
                                let v12: Result<rexie::Rexie, rexie::Error> = v10.await;
                                let v16: Dice_ui::US2 = Dice_ui::method16(match &v12 {
                                    Err(v12_1_0) => Dice_ui::closure9((), v12_1_0.clone()),
                                    Ok(v12_0_0) => Dice_ui::closure8((), v12_0_0.clone()),
                                });
                                v16
                            }
                        });
                        {
                            let v19: std::pin::Pin<
                                Box<dyn std::future::Future<Output = Dice_ui::US2>>,
                            > = __future_init;
                            let v21: Dice_ui::US2 = v19.await;
                            let v27: rexie::Rexie = match &v21 {
                                Dice_ui::US2::US2_1(v21_1_0) => v21_1_0.clone(),
                                Dice_ui::US2::US2_0(v21_0_0) => {
                                    panic!("{}", sprintf!("Result value was Error: {}", v21_0_0),)
                                }
                            };
                            let v30: string =
                                Dice_ui::method0(append(append(string("state.use_database (3) / database create_local_resource / result: "),
                                                               sprintf!("{:?}",
                                                                        &v27)),
                                                        string("")));
                            leptos::logging::log!("{}", v30);
                            {
                                let v32: rexie::Rexie = Dice_ui::method17(v27);
                                v32
                            }
                        }
                    }
                }
            });
            {
                {
                    {
                        {
                            {
                                //;
                                __future_init
                            }
                        }
                    }
                }
            }
        }
        pub fn method19(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> leptos::Resource<Dice_ui::US1, rexie::Rexie> {
            v0_1
        }
        pub fn closure10(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method19(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method18(
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
        pub fn method20(v0_1: Array<string>) -> Array<string> {
            v0_1
        }
        pub fn closure13(unitVar: (), v0_1: string) -> std::string::String {
            let v2: string = Dice_ui::method6(Dice_ui::method13(v0_1));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            String::from(v4)
        }
        pub fn method21() -> Func1<string, std::string::String> {
            Func1::new(move |v: string| Dice_ui::closure13((), v))
        }
        pub fn method22(v0_1: Array<string>) -> Array<string> {
            v0_1
        }
        pub fn method23(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method24(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure14(unitVar: (), v0_1: rexie::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method25() -> Func1<rexie::Error, std::string::String> {
            Func1::new(move |v: rexie::Error| Dice_ui::closure14((), v))
        }
        pub fn method26() -> string {
            string("store")
        }
        pub fn closure15(unitVar: (), v0_1: rexie::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method27() -> Func1<rexie::Error, std::string::String> {
            Func1::new(move |v: rexie::Error| Dice_ui::closure15((), v))
        }
        pub fn method28() -> string {
            string("core-state-data")
        }
        pub fn closure16(unitVar: (), v0_1: rexie::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method29() -> Func1<rexie::Error, std::string::String> {
            Func1::new(move |v: rexie::Error| Dice_ui::closure16((), v))
        }
        pub fn method30(v0_1: wasm_bindgen::JsValue) -> wasm_bindgen::JsValue {
            v0_1
        }
        pub fn closure17(unitVar: (), v0_1: serde_wasm_bindgen::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method31() -> Func1<serde_wasm_bindgen::Error, std::string::String> {
            Func1::new(move |v: serde_wasm_bindgen::Error| Dice_ui::closure17((), v))
        }
        pub fn closure18(unitVar: (), v0_1: serde_json::Value) -> Dice_ui::US5 {
            Dice_ui::US5::US5_1(v0_1)
        }
        pub fn method32(v0_1: serde_json::Value) -> serde_json::Value {
            v0_1
        }
        pub fn closure19(unitVar: (), v0_1: serde_json::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method33() -> Func1<serde_json::Error, std::string::String> {
            Func1::new(move |v: serde_json::Error| Dice_ui::closure19((), v))
        }
        pub fn method34(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method35(v0_1: Array<u8>) -> Array<u8> {
            v0_1
        }
        pub fn closure20(unitVar: (), v0_1: borsh::io::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method36() -> Func1<borsh::io::Error, std::string::String> {
            Func1::new(move |v: borsh::io::Error| Dice_ui::closure20((), v))
        }
        pub fn method37(
            v0_1: Result<Dice_ui::US3, std::string::String>,
        ) -> Result<Dice_ui::US3, std::string::String> {
            v0_1
        }
        pub fn closure21(unitVar: (), v0_1: Dice_ui::US3) -> Dice_ui::US6 {
            Dice_ui::US6::US6_1(v0_1)
        }
        pub fn closure22(unitVar: (), v0_1: std::string::String) -> Dice_ui::US6 {
            Dice_ui::US6::US6_0(v0_1)
        }
        pub fn method38(v0_1: Dice_ui::US3) -> Dice_ui::US3 {
            v0_1
        }
        pub fn closure11(
            unitVar: (),
            v0_1: Option<rexie::Rexie>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Dice_ui::US3>>> {
            let __future_init = Box::pin(async {
                //;
                {
                    let v4: string =
                    Dice_ui::method0(append(append(string("state.use_core_database (2) / core_state_data create_local_resource / database: "),
                                                   sprintf!("{:?}", &v0_1)),
                                            string("")));
                    leptos::logging::log!("{}", v4);
                    {
                        let v8: Dice_ui::US4 = defaultValue(
                            Dice_ui::US4::US4_0,
                            map(
                                Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                                v0_1,
                            ),
                        );
                        let v122: Dice_ui::US3 = Dice_ui::method38(match &v8 {
                            Dice_ui::US4::US4_1(v8_1_0) => {
                                let v12: string = Dice_ui::method0(string(
                                    "state.get_data () / id: core-state-data",
                                ));
                                leptos::logging::log!("{}", v12);
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v17: Array<string> =
                                            Dice_ui::method20(new_array(&[string("store")]));
                                        let v18 = Dice_ui::method21();
                                        let v19: Array<string> = Dice_ui::method22(v17);
                                        let v21: Vec<string> = v19.to_vec();
                                        let v24: Vec<std::string::String> = Dice_ui::method23(
                                            v21.iter().map(|x| v18(x.clone())).collect(),
                                        );
                                        let v26: Array<std::string::String> =
                                            fable_library_rust::NativeArray_::array_from(v24);
                                        let v27: rexie::Rexie = Dice_ui::method24(v8_1_0.clone());
                                        let v29: Result<rexie::Transaction, rexie::Error> =
                                            v27.transaction(&v26, rexie::TransactionMode::ReadOnly);
                                        let v30 = Dice_ui::method25();
                                        let v32: Result<rexie::Transaction, std::string::String> =
                                            v29.map_err(|x| v30(x));
                                        let v34: rexie::Transaction = v32?;
                                        let v35: string = Dice_ui::method26();
                                        let v37: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v35);
                                        let v39: Result<rexie::Store, rexie::Error> =
                                            v34.store(v37);
                                        let v40 = Dice_ui::method27();
                                        let v42: Result<rexie::Store, std::string::String> =
                                            v39.map_err(|x| v40(x));
                                        let v44: rexie::Store = v42?;
                                        let v45: string = Dice_ui::method28();
                                        let v47: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v45);
                                        let v49: wasm_bindgen::JsValue =
                                            wasm_bindgen::JsValue::from_str(v47);
                                        let v51: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<
                                                        wasm_bindgen::JsValue,
                                                        rexie::Error,
                                                    >,
                                                >,
                                            >,
                                        > = Box::pin(rexie::Store::get(&v44, &v49));
                                        let v53: Result<wasm_bindgen::JsValue, rexie::Error> =
                                            v51.await;
                                        let v54 = Dice_ui::method29();
                                        let v56: Result<
                                            wasm_bindgen::JsValue,
                                            std::string::String,
                                        > = v53.map_err(|x| v54(x));
                                        let v59: wasm_bindgen::JsValue = Dice_ui::method30(v56?);
                                        let v61: Result<
                                            Option<serde_json::Value>,
                                            serde_wasm_bindgen::Error,
                                        > = serde_wasm_bindgen::from_value(v59);
                                        let v62 = Dice_ui::method31();
                                        let v64: Result<
                                            Option<serde_json::Value>,
                                            std::string::String,
                                        > = v61.map_err(|x| v62(x));
                                        let v69: Dice_ui::US5 = defaultValue(
                                            Dice_ui::US5::US5_0,
                                            map(
                                                Func1::new(move |v_1: serde_json::Value| {
                                                    Dice_ui::closure18((), v_1)
                                                }),
                                                v64?,
                                            ),
                                        );
                                        let v104: Result<Dice_ui::US3, std::string::String> =
                                            Dice_ui::method37(Ok(match &v69 {
                                                Dice_ui::US5::US5_1(v69_1_0) => {
                                                    let v71: serde_json::Value =
                                                        Dice_ui::method32(v69_1_0.clone());
                                                    let v73: Result<Vec<u8>, serde_json::Error> =
                                                        serde_json::from_value(v71);
                                                    let v74 = Dice_ui::method33();
                                                    let v76: Result<Vec<u8>, std::string::String> =
                                                        v73.map_err(|x| v74(x));
                                                    let v79: Vec<u8> = Dice_ui::method34(v76?);
                                                    let v81:
                                                                                               Array<u8> =
                                                                                           fable_library_rust::NativeArray_::array_from(v79);
                                                    let v84: string = Dice_ui::method0(append(
                                                        append(
                                                            string(
                                                                "state.get_data () / data_len: ",
                                                            ),
                                                            toString(count(v81.clone())),
                                                        ),
                                                        string(""),
                                                    ));
                                                    leptos::logging::log!("{}", v84);
                                                    {
                                                        let v86: Array<u8> = Dice_ui::method35(v81);
                                                        let v88: Vec<u8> = v86.to_vec();
                                                        let v90: &[u8] = v88.as_slice();
                                                        let mut v90 = v90;
                                                        {
                                                            let v93:
                                                                                                       Result<LrcPtr<Dice_ui::Heap2>,
                                                                                                              borsh::io::Error> =
                                                                                                   borsh::BorshDeserialize::deserialize(&mut v90);
                                                            let v94 = Dice_ui::method36();
                                                            let v96: Result<
                                                                LrcPtr<Dice_ui::Heap2>,
                                                                std::string::String,
                                                            > = v93.map_err(|x| v94(x));
                                                            Dice_ui::US3::US3_1(v96?)
                                                        }
                                                    }
                                                }
                                                _ => Dice_ui::US3::US3_0,
                                            }));
                                        v104
                                    }
                                });
                                {
                                    //;
                                    {
                                        let v107: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<
                                                        Dice_ui::US3,
                                                        std::string::String,
                                                    >,
                                                >,
                                            >,
                                        > = __future_init;
                                        let v109: Result<Dice_ui::US3, std::string::String> =
                                            v107.await;
                                        let v112: Dice_ui::US6 = match &v109 {
                                            Err(v109_1_0) => {
                                                Dice_ui::closure22((), v109_1_0.clone())
                                            }
                                            Ok(v109_0_0) => {
                                                Dice_ui::closure21((), v109_0_0.clone())
                                            }
                                        };
                                        match &v112 {
                                            Dice_ui::US6::US6_1(v112_1_0) => v112_1_0.clone(),
                                            Dice_ui::US6::US6_0(v112_0_0) => panic!(
                                                "{}",
                                                sprintf!("Result value was Error: {}", v112_0_0),
                                            ),
                                        }
                                    }
                                }
                            }
                            _ => Dice_ui::US3::US3_0,
                        });
                        v122
                    }
                }
            });
            {
                {
                    //;
                    __future_init
                }
            }
        }
        pub fn method40() -> web_sys::Window {
            leptos::leptos_dom::window()
        }
        pub fn method42(v0_1: web_sys::Window) -> web_sys::Window {
            v0_1
        }
        pub fn method41(
            v0_1: web_sys::Window,
        ) -> Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> {
            let v1: web_sys::Window = Dice_ui::method42(v0_1);
            v1.local_storage()
        }
        pub fn closure24(unitVar: (), v0_1: Option<web_sys::Storage>) -> Dice_ui::US7 {
            Dice_ui::US7::US7_1(v0_1)
        }
        pub fn closure25(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Dice_ui::US7 {
            Dice_ui::US7::US7_0(v0_1)
        }
        pub fn closure26(unitVar: (), v0_1: web_sys::Storage) -> Dice_ui::US9 {
            Dice_ui::US9::US9_1(v0_1)
        }
        pub fn method43(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3> {
            v0_1
        }
        pub fn closure27(unitVar: (), v0_1: Dice_ui::US3) -> Dice_ui::US10 {
            Dice_ui::US10::US10_1(v0_1)
        }
        pub fn method44(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn closure28(unitVar: (), v0_1: Option<std::string::String>) -> Dice_ui::US11 {
            Dice_ui::US11::US11_1(v0_1)
        }
        pub fn closure29(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Dice_ui::US11 {
            Dice_ui::US11::US11_0(v0_1)
        }
        pub fn method45(v0_1: Option<std::string::String>) -> Option<std::string::String> {
            v0_1
        }
        pub fn closure30(unitVar: (), v0_1: std::string::String) -> Dice_ui::US13 {
            Dice_ui::US13::US13_1(v0_1)
        }
        pub fn method46(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method47(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure31(unitVar: (), v0_1: serde_json::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method48() -> Func1<serde_json::Error, std::string::String> {
            Func1::new(move |v: serde_json::Error| Dice_ui::closure31((), v))
        }
        pub fn closure32(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap2>) -> Dice_ui::US3 {
            Dice_ui::US3::US3_1(v0_1)
        }
        pub fn method50(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn closure34(v0_1: LrcPtr<Dice_ui::Heap2>, v1: bool) -> bool {
            let v3: string = Dice_ui::method0(string(
                "state.use_core_database (5.1) / effect core_state_data / dark_mode signal_update",
            ));
            leptos::logging::log!("{}", v3);
            v0_1.l0
        }
        pub fn method51(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<bool, bool> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice_ui::closure34(v0_1.clone(), v)
            })
        }
        pub fn method52(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure35(v0_1: LrcPtr<Dice_ui::Heap2>, v1: bool) -> bool {
            let v3: string = Dice_ui::method0(string(
                "state.use_core_database (5.2) / effect core_state_data / debug signal_update",
            ));
            leptos::logging::log!("{}", v3);
            v0_1.l1
        }
        pub fn method53(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<bool, bool> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice_ui::closure35(v0_1.clone(), v)
            })
        }
        pub fn closure36(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: std::string::String,
        ) -> std::string::String {
            let v3: string = Dice_ui::method0(string(
                "state.use_core_database (5.3) / effect core_state_data / url_hash signal_update",
            ));
            leptos::logging::log!("{}", v3);
            v0_1.l2.clone()
        }
        pub fn method54(
            v0_1: LrcPtr<Dice_ui::Heap2>,
        ) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure36(v0_1.clone(), v)
            })
        }
        pub fn method55(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn closure33(v0_1: LrcPtr<Dice_ui::Heap1>, v1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = v0_1.l0.clone();
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method50(v2.clone());
            let v5: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method51(v1.clone());
            let v8: leptos::RwSignal<bool> = Dice_ui::method52(v5.l0.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            {
                let v10: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method50(v2.clone());
                let v12: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v10);
                let v14 = Dice_ui::method53(v1.clone());
                let v15: leptos::RwSignal<bool> = Dice_ui::method52(v12.l1.clone());
                leptos::SignalUpdate::update(&v15, |x| *x = v14(x.clone()));
                {
                    let v17: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method50(v2);
                    let v19: LrcPtr<Dice_ui::Heap0> =
                        leptos::SignalGetUntracked::get_untracked(&v17);
                    let v21 = Dice_ui::method54(v1);
                    let v22: leptos::RwSignal<std::string::String> =
                        Dice_ui::method55(v19.l2.clone());
                    leptos::SignalUpdate::update(&v22, |x| *x = v21(x.clone()));
                    ()
                }
            }
        }
        pub fn method49(v0_1: LrcPtr<Dice_ui::Heap1>, v1: LrcPtr<Dice_ui::Heap2>) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure33(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method56(v0_1: Func0<()>) -> Func0<()> {
            v0_1
        }
        pub fn closure23(
            v0_1: LrcPtr<Dice_ui::Heap1>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3>,
            unitVar: (),
        ) {
            let v3: string = Dice_ui::method0(string(
                "state.use_core_database (3) / effect core_state_data / ##1",
            ));
            leptos::logging::log!("{}", v3);
            {
                let v6: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method41(Dice_ui::method40());
                let v9: Dice_ui::US7 = match &v6 {
                    Err(v6_1_0) => Dice_ui::closure25((), v6_1_0.clone()),
                    Ok(v6_0_0) => Dice_ui::closure24((), v6_0_0.clone()),
                };
                let v18: Dice_ui::US8 = match &v9 {
                    Dice_ui::US7::US7_1(v9_1_0) => Dice_ui::US8::US8_1(defaultValue(
                        Dice_ui::US9::US9_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure26((), v_2)),
                            v9_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US7::US7_0(v9_0_0) => Dice_ui::US8::US8_0(v9_0_0.clone()),
                };
                if let Dice_ui::US8::US8_1(v18_1_0) = &v18 {
                    let v19: Dice_ui::US9 = match &v18 {
                        Dice_ui::US8::US8_1(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Dice_ui::US9::US9_1(v19_1_0) = &v19 {
                        let v20: web_sys::Storage = match &v19 {
                            Dice_ui::US9::US9_1(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v21: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3> =
                            Dice_ui::method43(v1);
                        let v26: Dice_ui::US10 = defaultValue(
                            Dice_ui::US10::US10_0,
                            map(
                                Func1::new(move |v_3: Dice_ui::US3| Dice_ui::closure27((), v_3)),
                                leptos::SignalGet::get(&v21),
                            ),
                        );
                        let v29: string =
                            Dice_ui::method0(append(append(string("state.use_core_database (4) / effect core_state_data / ##2 / core_state_data: "),
                                                           sprintf!("{:?}",
                                                                    &v26)),
                                                    string("")));
                        leptos::logging::log!("{}", v29);
                        {
                            let v161: Dice_ui::US3 = if let Dice_ui::US10::US10_1(v26_1_0) = &v26 {
                                let v31: Dice_ui::US3 = match &v26 {
                                    Dice_ui::US10::US10_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Dice_ui::US3::US3_1(v31_1_0) = &v31 {
                                    Dice_ui::US3::US3_1(match &v31 {
                                        Dice_ui::US3::US3_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    let v34: web_sys::Storage = Dice_ui::method44(v20.clone());
                                    let v35: string = Dice_ui::method28();
                                    let v37: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v35);
                                    let v39: Result<
                                        Option<std::string::String>,
                                        wasm_bindgen::JsValue,
                                    > = web_sys::Storage::get_item(&v34, v37);
                                    let v42: Dice_ui::US11 = match &v39 {
                                        Err(v39_1_0) => Dice_ui::closure29((), v39_1_0.clone()),
                                        Ok(v39_0_0) => Dice_ui::closure28((), v39_0_0.clone()),
                                    };
                                    let v54: Dice_ui::US12 = match &v42 {
                                        Dice_ui::US11::US11_1(v42_1_0) => {
                                            let v44: Option<std::string::String> =
                                                Dice_ui::method45(v42_1_0.clone());
                                            Dice_ui::US12::US12_1(defaultValue(
                                                Dice_ui::US13::US13_0,
                                                map(
                                                    Func1::new(move |v_6: std::string::String| {
                                                        Dice_ui::closure30((), v_6)
                                                    }),
                                                    serde_json::from_value(v44.into()).unwrap(),
                                                ),
                                            ))
                                        }
                                        Dice_ui::US11::US11_0(v42_0_0) => {
                                            Dice_ui::US12::US12_0(v42_0_0.clone())
                                        }
                                    };
                                    let v60: Dice_ui::US14 = match &v54 {
                                        Dice_ui::US12::US12_1(v54_1_0) => {
                                            Dice_ui::US14::US14_1(v54_1_0.clone())
                                        }
                                        _ => Dice_ui::US14::US14_0,
                                    };
                                    let v67: Dice_ui::US13 =
                                        if let Dice_ui::US14::US14_1(v60_1_0) = &v60 {
                                            let v61: Dice_ui::US13 = match &v60 {
                                                Dice_ui::US14::US14_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if let Dice_ui::US13::US13_1(v61_1_0) = &v61 {
                                                Dice_ui::US13::US13_1(match &v61 {
                                                    Dice_ui::US13::US13_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            } else {
                                                Dice_ui::US13::US13_0
                                            }
                                        } else {
                                            Dice_ui::US13::US13_0
                                        };
                                    let v89: Dice_ui::US10 = match &v67 {
                                        Dice_ui::US13::US13_1(v67_1_0) => {
                                            let v70: std::string::String = Dice_ui::method47(
                                                Dice_ui::method46(v67_1_0.clone()),
                                            );
                                            let v73: string = Dice_ui::method6(
                                                fable_library_rust::String_::fromString(v70),
                                            );
                                            let v75: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v73);
                                            let v77: Result<
                                                LrcPtr<Dice_ui::Heap2>,
                                                serde_json::Error,
                                            > = serde_json::from_str(&v75);
                                            let v78 = Dice_ui::method48();
                                            let v80: Result<
                                                LrcPtr<Dice_ui::Heap2>,
                                                std::string::String,
                                            > = v77.map_err(|x| v78(x));
                                            Dice_ui::US10::US10_1(defaultValue(
                                                Dice_ui::US3::US3_0,
                                                map(
                                                    Func1::new(
                                                        move |v_7: LrcPtr<Dice_ui::Heap2>| {
                                                            Dice_ui::closure32((), v_7)
                                                        },
                                                    ),
                                                    v80.ok(),
                                                ),
                                            ))
                                        }
                                        _ => Dice_ui::US10::US10_0,
                                    };
                                    if let Dice_ui::US10::US10_1(v89_1_0) = &v89 {
                                        let v90: Dice_ui::US3 = match &v89 {
                                            Dice_ui::US10::US10_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US3::US3_1(v90_1_0) = &v90 {
                                            Dice_ui::US3::US3_1(match &v90 {
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
                                let v98: web_sys::Storage = Dice_ui::method44(v20);
                                let v99: string = Dice_ui::method28();
                                let v101: &str = fable_library_rust::String_::LrcStr::as_str(&v99);
                                let v103: Result<
                                    Option<std::string::String>,
                                    wasm_bindgen::JsValue,
                                > = web_sys::Storage::get_item(&v98, v101);
                                let v106: Dice_ui::US11 = match &v103 {
                                    Err(v103_1_0) => Dice_ui::closure29((), v103_1_0.clone()),
                                    Ok(v103_0_0) => Dice_ui::closure28((), v103_0_0.clone()),
                                };
                                let v118: Dice_ui::US12 = match &v106 {
                                    Dice_ui::US11::US11_1(v106_1_0) => {
                                        let v108: Option<std::string::String> =
                                            Dice_ui::method45(v106_1_0.clone());
                                        Dice_ui::US12::US12_1(defaultValue(
                                            Dice_ui::US13::US13_0,
                                            map(
                                                Func1::new(move |v_10: std::string::String| {
                                                    Dice_ui::closure30((), v_10)
                                                }),
                                                serde_json::from_value(v108.into()).unwrap(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US11::US11_0(v106_0_0) => {
                                        Dice_ui::US12::US12_0(v106_0_0.clone())
                                    }
                                };
                                let v124: Dice_ui::US14 = match &v118 {
                                    Dice_ui::US12::US12_1(v118_1_0) => {
                                        Dice_ui::US14::US14_1(v118_1_0.clone())
                                    }
                                    _ => Dice_ui::US14::US14_0,
                                };
                                let v131: Dice_ui::US13 =
                                    if let Dice_ui::US14::US14_1(v124_1_0) = &v124 {
                                        let v125: Dice_ui::US13 = match &v124 {
                                            Dice_ui::US14::US14_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US13::US13_1(v125_1_0) = &v125 {
                                            Dice_ui::US13::US13_1(match &v125 {
                                                Dice_ui::US13::US13_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Dice_ui::US13::US13_0
                                        }
                                    } else {
                                        Dice_ui::US13::US13_0
                                    };
                                let v153: Dice_ui::US10 = match &v131 {
                                    Dice_ui::US13::US13_1(v131_1_0) => {
                                        let v134: std::string::String =
                                            Dice_ui::method47(Dice_ui::method46(v131_1_0.clone()));
                                        let v137: string = Dice_ui::method6(
                                            fable_library_rust::String_::fromString(v134),
                                        );
                                        let v139: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v137);
                                        let v141: Result<
                                            LrcPtr<Dice_ui::Heap2>,
                                            serde_json::Error,
                                        > = serde_json::from_str(&v139);
                                        let v142 = Dice_ui::method48();
                                        let v144: Result<
                                            LrcPtr<Dice_ui::Heap2>,
                                            std::string::String,
                                        > = v141.map_err(|x| v142(x));
                                        Dice_ui::US10::US10_1(defaultValue(
                                            Dice_ui::US3::US3_0,
                                            map(
                                                Func1::new(move |v_11: LrcPtr<Dice_ui::Heap2>| {
                                                    Dice_ui::closure32((), v_11)
                                                }),
                                                v144.ok(),
                                            ),
                                        ))
                                    }
                                    _ => Dice_ui::US10::US10_0,
                                };
                                if let Dice_ui::US10::US10_1(v153_1_0) = &v153 {
                                    let v154: Dice_ui::US3 = match &v153 {
                                        Dice_ui::US10::US10_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Dice_ui::US3::US3_1(v154_1_0) = &v154 {
                                        Dice_ui::US3::US3_1(match &v154 {
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
                            let v164: string =
                                Dice_ui::method0(append(append(string("state.use_core_database (5) / effect core_state_data / ##3 / core_state_data: "),
                                                               sprintf!("{:?}",
                                                                        &v161)),
                                                        string("")));
                            leptos::logging::log!("{}", v164);
                            if let Dice_ui::US3::US3_1(v161_1_0) = &v161 {
                                let v167 = Dice_ui::method49(
                                    v0_1,
                                    match &v161 {
                                        Dice_ui::US3::US3_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                );
                                let v170: Func0<()> = Dice_ui::method56(Func0::new(move || v167()));
                                leptos::batch(move || v170());
                                ()
                            }
                        }
                    }
                }
            }
        }
        pub fn method39(
            v0_1: LrcPtr<Dice_ui::Heap1>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure23(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method58(
            v0_1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::RwSignal<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn closure37(
            v0_1: LrcPtr<Dice_ui::Heap1>,
            unitVar: (),
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> {
            let v2: string =
                Dice_ui::method0(string("state.use_core_database (6) / loading create_memo"));
            leptos::logging::log!("{}", v2);
            {
                let v5: leptos::RwSignal<
                    std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                > = Dice_ui::method58(v0_1.l1.clone());
                leptos::SignalGetUntracked::get_untracked(&v5)
            }
        }
        pub fn method57(
            v0_1: LrcPtr<Dice_ui::Heap1>,
        ) -> Func0<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure37(v0_1.clone(), ())
            })
        }
        pub fn method59() -> bool {
            false
        }
        pub fn method61(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn method62(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> Dice_ui::US15 {
            Dice_ui::US15::US15_1
        }
        pub fn closure40(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US15 {
            Dice_ui::US15::US15_0(v0_1)
        }
        pub fn method63() {
            ();
        }
        pub fn closure38(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            v1: LrcPtr<Dice_ui::Heap2>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v2: string = sprintf!("{:?}", &v1);
            let v3: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method19(v0_1);
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
                        let v12: string =
                        Dice_ui::method0(append(append(string("state.use_core_database (7) / set_core_state_data_action / value: "),
                                                       v2), string("")));
                        leptos::logging::log!("{}", v12);
                        {
                            let v17: string = Dice_ui::method0(append(
                                append(
                                    string("state.set_data () / data_len: "),
                                    toString(length(sprintf!("{:?}", &v1)) as i64),
                                ),
                                string(""),
                            ));
                            leptos::logging::log!("{}", v17);
                            {
                                let v19: rexie::Rexie = Dice_ui::method61(v8_1_0.clone());
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v22: rexie::Transaction = v19.transaction(
                                            &["store"],
                                            rexie::TransactionMode::ReadWrite,
                                        )?;
                                        let v24: rexie::Store = v22.store("store")?;
                                        let mut data = Vec::new();
                                        borsh::BorshSerialize::serialize(&v1, &mut data).unwrap();
                                        {
                                            let v28: Vec<u8> = data;
                                            let v30: wasm_bindgen::JsValue =
                                                serde_wasm_bindgen::to_value(&v28).unwrap();
                                            let v31: string = Dice_ui::method28();
                                            let v33: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v31);
                                            v24.put(&v30, Some(&v33.into())).await?;
                                            v22.done().await?;
                                            {
                                                let v37: Result<(), rexie::Error> =
                                                    Dice_ui::method62(Ok(()));
                                                v37
                                            }
                                        }
                                    }
                                });
                                {
                                    {
                                        {
                                            //;
                                            {
                                                let v40: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<(), rexie::Error>,
                                                        >,
                                                    >,
                                                > = __future_init;
                                                let v42: Result<(), rexie::Error> = v40.await;
                                                let v45: Dice_ui::US15 = match &v42 {
                                                    Err(v42_1_0) => {
                                                        Dice_ui::closure40((), v42_1_0.clone())
                                                    }
                                                    _ => Dice_ui::closure39((), ()),
                                                };
                                                match &v45 {
                                                    Dice_ui::US15::US15_1 => (),
                                                    Dice_ui::US15::US15_0(v45_0_0) => panic!(
                                                        "{}",
                                                        sprintf!(
                                                            "Result value was Error: {}",
                                                            v45_0_0
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
                        let v49: string =
                        Dice_ui::method0(string("state.use_core_database (8) / set_core_state_data_action / database=None"));
                        leptos::logging::log!("{}", v49);
                        ()
                    }
                }
                Dice_ui::method63();
                ()
            });
            __future_init
        }
        pub fn method60(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func1<LrcPtr<Dice_ui::Heap2>, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_ui::Heap2>| Dice_ui::closure38(v0_1.clone(), v)
            })
        }
        pub fn method65(v0_1: leptos::ReadSignal<bool>) -> leptos::ReadSignal<bool> {
            v0_1
        }
        pub fn method66(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn method67(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method68(
            v0_1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::Memo<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn method69() -> string {
            string("dark_mode_key")
        }
        pub fn method70(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure42(unitVar: (), v0_1: leptos::RwSignal<bool>) -> Dice_ui::US16 {
            Dice_ui::US16::US16_1(v0_1)
        }
        pub fn closure43(unitVar: (), v0_1: bool) -> bool {
            let v2: string =
                Dice_ui::method0(string("state.use_core_database (12) / effect new_core_state_data / set_loaded |> signal_update true"));
            leptos::logging::log!("{}", v2);
            true
        }
        pub fn method71() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure43((), v))
        }
        pub fn method72(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method73(v0_1: LrcPtr<Dice_ui::Heap2>) -> LrcPtr<Dice_ui::Heap2> {
            v0_1
        }
        pub fn method74(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method75(v0_1: LrcPtr<Dice_ui::Heap2>) -> LrcPtr<Dice_ui::Heap2> {
            v0_1
        }
        pub fn method76(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure41(
            v0_1: LrcPtr<Dice_ui::Heap1>,
            v1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            v2: leptos::WriteSignal<bool>,
            v3: leptos::ReadSignal<bool>,
            v4: leptos::Action<LrcPtr<Dice_ui::Heap2>, ()>,
            unitVar: (),
        ) {
            let v5: leptos::ReadSignal<bool> = Dice_ui::method65(v3);
            let v7: bool = leptos::SignalGet::get(&v5);
            let v9: string = Dice_ui::method0(append(
                append(
                    string(
                        "state.use_core_database (9) / effect new_core_state_data / ##1 / loaded: ",
                    ),
                    ofBoolean(v7),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v9);
            {
                let v11: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = v0_1.l0.clone();
                let v12: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method50(v11.clone());
                let v16: leptos::RwSignal<bool> =
                    Dice_ui::method66((leptos::SignalGetUntracked::get_untracked(&v12)).l0.clone());
                let v18: bool = leptos::SignalGet::get(&v16);
                let v19: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method50(v11.clone());
                let v23: leptos::RwSignal<bool> =
                    Dice_ui::method66((leptos::SignalGetUntracked::get_untracked(&v19)).l1.clone());
                let v25: bool = leptos::SignalGet::get(&v23);
                let v26: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method50(v11);
                let v30: leptos::RwSignal<std::string::String> =
                    Dice_ui::method67((leptos::SignalGetUntracked::get_untracked(&v26)).l2.clone());
                let v33: LrcPtr<Dice_ui::Heap2> = LrcPtr::new(Dice_ui::Heap2 {
                    l0: v18,
                    l1: v25,
                    l2: leptos::SignalGet::get(&v30),
                });
                let v36: string =
                    Dice_ui::method0(append(append(string("state.use_core_database (10) / effect new_core_state_data / ##2 / new_core_state_data: "),
                                                   sprintf!("{:?}", &v33)),
                                            string("")));
                leptos::logging::log!("{}", v36);
                {
                    let v38: leptos::Memo<
                        std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                    > = Dice_ui::method68(v1);
                    let v40: std::collections::HashMap<
                        std::string::String,
                        leptos::RwSignal<bool>,
                    > = v38();
                    let v42: string = Dice_ui::method6(Dice_ui::method69());
                    let v44: &str = fable_library_rust::String_::LrcStr::as_str(&v42);
                    let v47: std::string::String = Dice_ui::method70(String::from(v44));
                    let v52: Dice_ui::US16 = defaultValue(
                        Dice_ui::US16::US16_0,
                        map(
                            Func1::new(move |v: leptos::RwSignal<bool>| Dice_ui::closure42((), v)),
                            std::collections::HashMap::get(&v40, &v47)
                                .map(|x| x)
                                .cloned(),
                        ),
                    );
                    let v60: Dice_ui::US17 = match &v52 {
                        Dice_ui::US16::US16_1(v52_1_0) => {
                            let v54: leptos::RwSignal<bool> = Dice_ui::method66(v52_1_0.clone());
                            Dice_ui::US17::US17_1(leptos::SignalGet::get(&v54))
                        }
                        _ => Dice_ui::US17::US17_0,
                    };
                    let v63: bool = match &v60 {
                        Dice_ui::US17::US17_1(v60_1_0) => v60_1_0.clone(),
                        _ => false,
                    };
                    let v65: string =
                        Dice_ui::method0(append(append(string("state.use_core_database (11) / effect new_core_state_data / ##3 / dark_mode_loading: "),
                                                       ofBoolean(v63)),
                                                string("")));
                    leptos::logging::log!("{}", v65);
                    if v63 == false {
                        if v7 == false {
                            let v69 = Dice_ui::method71();
                            let v70: leptos::WriteSignal<bool> = Dice_ui::method72(v2);
                            leptos::SignalUpdate::update(&v70, |x| *x = v69(x.clone()));
                            ()
                        } else {
                            let v73: string = Dice_ui::method0(string(
                                "state.use_core_database (13) / effect new_core_state_data / ##4",
                            ));
                            leptos::logging::log!("{}", v73);
                            {
                                let v76: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                                    Dice_ui::method41(Dice_ui::method40());
                                let v79: Dice_ui::US7 = match &v76 {
                                    Err(v76_1_0) => Dice_ui::closure25((), v76_1_0.clone()),
                                    Ok(v76_0_0) => Dice_ui::closure24((), v76_0_0.clone()),
                                };
                                let v88: Dice_ui::US8 = match &v79 {
                                    Dice_ui::US7::US7_1(v79_1_0) => {
                                        Dice_ui::US8::US8_1(defaultValue(
                                            Dice_ui::US9::US9_0,
                                            map(
                                                Func1::new(move |v_3: web_sys::Storage| {
                                                    Dice_ui::closure26((), v_3)
                                                }),
                                                v79_1_0.clone(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US7::US7_0(v79_0_0) => {
                                        Dice_ui::US8::US8_0(v79_0_0.clone())
                                    }
                                };
                                if let Dice_ui::US8::US8_1(v88_1_0) = &v88 {
                                    let v89: Dice_ui::US9 = match &v88 {
                                        Dice_ui::US8::US8_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Dice_ui::US9::US9_1(v89_1_0) = &v89 {
                                        let v91: LrcPtr<Dice_ui::Heap2> =
                                            Dice_ui::method73(v33.clone());
                                        leptos::Action::dispatch(&v4, v91);
                                        {
                                            let v93: web_sys::Storage =
                                                Dice_ui::method74(match &v89 {
                                                    Dice_ui::US9::US9_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                });
                                            let v94: string = Dice_ui::method28();
                                            let v96: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v94);
                                            let v97: LrcPtr<Dice_ui::Heap2> =
                                                Dice_ui::method75(v33);
                                            let v100: std::string::String = Dice_ui::method76(
                                                serde_json::json!(v97).to_string(),
                                            );
                                            let v102: &str = v100.as_str();
                                            web_sys::Storage::set(&v93, v96, v102).unwrap();
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
        pub fn method64(
            v0_1: LrcPtr<Dice_ui::Heap1>,
            v1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            v2: leptos::WriteSignal<bool>,
            v3: leptos::ReadSignal<bool>,
            v4: leptos::Action<LrcPtr<Dice_ui::Heap2>, ()>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move || {
                    Dice_ui::closure41(
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
        pub fn closure44(v0_1: LrcPtr<Dice_ui::Heap1>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method50(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method66((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method77(v0_1: LrcPtr<Dice_ui::Heap1>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure44(v0_1.clone(), ())
            })
        }
        pub fn method79(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method80(
            v0_1: leptos::Memo<std::string::String>,
        ) -> leptos::Memo<std::string::String> {
            v0_1
        }
        pub fn method81(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method82() -> Dice_ui::US18 {
            Dice_ui::US18::US18_0
        }
        pub fn method84(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method85(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method86() -> bool {
            true
        }
        pub fn method87(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method88(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method89(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn closure46(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: LrcPtr<Dice_ui::Heap1>,
            v4: leptos::WriteSignal<bool>,
            v5: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v6: leptos::ReadSignal<bool> = Dice_ui::method65(v5);
            let v8: bool = leptos::SignalGet::get(&v6);
            let v9: leptos_router::Location = Dice_ui::method84(v0_1);
            let v12: leptos::Memo<std::string::String> = Dice_ui::method80(v9.hash);
            let v14: std::string::String = v12();
            let v15: string = sprintf!("{}{}", &v2, &v14);
            let v17: string = Dice_ui::method0(append(
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
            ));
            leptos::logging::log!("{}", v17);
            if v8 == false {
                let v20: std::string::String = Dice_ui::method85(v14);
                if v20 == "" {
                    let v24: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                        Dice_ui::method50(v3.l0.clone());
                    let v28: leptos::RwSignal<std::string::String> = Dice_ui::method67(
                        (leptos::SignalGetUntracked::get_untracked(&v24)).l2.clone(),
                    );
                    let v31: std::string::String = Dice_ui::method47(leptos::SignalGet::get(&v28));
                    let v33: string = fable_library_rust::String_::fromString(v31);
                    let v35: string = Dice_ui::method0(append(
                        append(
                            string("content.render () / effect 1 / url_hash: "),
                            v33.clone(),
                        ),
                        string(""),
                    ));
                    leptos::logging::log!("{}", v35);
                    if contains(v33.clone(), string("#")) {
                        let v39: string = Dice_ui::method6(v33);
                        let v41: &str = fable_library_rust::String_::LrcStr::as_str(&v39);
                        v1(v41, Default::default());
                        ()
                    }
                }
                {
                    let v43: bool = Dice_ui::method86();
                    let v44: leptos::WriteSignal<bool> = Dice_ui::method87(v4);
                    leptos::SignalSet::set(&v44, v43);
                    ()
                }
            } else {
                let v47: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                    Dice_ui::method50(v3.l0.clone());
                let v49: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v47);
                let v52: string = Dice_ui::method6(Dice_ui::method13(v15));
                let v54: &str = fable_library_rust::String_::LrcStr::as_str(&v52);
                let v57: std::string::String = Dice_ui::method88(String::from(v54));
                let v58: leptos::RwSignal<std::string::String> = Dice_ui::method89(v49.l2.clone());
                leptos::SignalSet::set(&v58, v57);
                ()
            }
        }
        pub fn method83(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: LrcPtr<Dice_ui::Heap1>,
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
                    Dice_ui::closure46(
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
        pub fn method91(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method92(v0_1: &str) -> &str {
            v0_1
        }
        pub fn closure48(unitVar: (), v0_1: leptos_router::Url) -> Dice_ui::US19 {
            Dice_ui::US19::US19_1(v0_1)
        }
        pub fn closure49(unitVar: (), v0_1: std::string::String) -> Dice_ui::US19 {
            Dice_ui::US19::US19_0(v0_1)
        }
        pub fn method93() -> string {
            string("/settings")
        }
        pub fn method94(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method95(v0_1: Dice_ui::US18) -> Dice_ui::US18 {
            v0_1
        }
        pub fn method96(
            v0_1: leptos::WriteSignal<Dice_ui::US18>,
        ) -> leptos::WriteSignal<Dice_ui::US18> {
            v0_1
        }
        pub fn closure47(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US18>,
            unitVar: (),
        ) {
            let v2: leptos_router::Location = Dice_ui::method84(v0_1);
            let v5: leptos::Memo<std::string::String> = Dice_ui::method80(v2.hash);
            let v8: std::string::String = Dice_ui::method91(v5());
            let v10: Option<&str> = v8.strip_prefix('#');
            let v12: string = string("r#\"\"#");
            let v13: &str = r#""#;
            let v16: &str = Dice_ui::method92(v10.unwrap_or(v13));
            let v18: Result<leptos_router::Url, std::string::String> =
                leptos_router::Url::try_from(v16);
            let v21: Dice_ui::US19 = match &v18 {
                Err(v18_1_0) => Dice_ui::closure49((), v18_1_0.clone()),
                Ok(v18_0_0) => Dice_ui::closure48((), v18_0_0.clone()),
            };
            let v27: leptos_router::Url = match &v21 {
                Dice_ui::US19::US19_1(v21_1_0) => v21_1_0.clone(),
                Dice_ui::US19::US19_0(v21_0_0) => {
                    panic!("{}", sprintf!("Result value was Error: {}", v21_0_0),)
                }
            };
            let v31: string = Dice_ui::method0(append(
                append(
                    string("content.render () / effect 2 / hash_url: "),
                    toString(format!("{:#?}", &v27)),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v31);
            {
                let v34: std::string::String = v27.pathname;
                let v36: string = Dice_ui::method6(Dice_ui::method93());
                let v38: &str = fable_library_rust::String_::LrcStr::as_str(&v36);
                let v40: std::string::String = String::from(v38);
                let v41: std::string::String = Dice_ui::method94(v34);
                let v46: Dice_ui::US18 = if v41.starts_with(&v40) {
                    Dice_ui::US18::US18_1
                } else {
                    Dice_ui::US18::US18_2
                };
                let v50: string = Dice_ui::method0(append(
                    append(
                        string("content.render () / effect 2 / new_tab: "),
                        toString(format!("{:#?}", &v46)),
                    ),
                    string(""),
                ));
                leptos::logging::log!("{}", v50);
                {
                    let v52: Dice_ui::US18 = Dice_ui::method95(v46);
                    let v53: leptos::WriteSignal<Dice_ui::US18> = Dice_ui::method96(v1);
                    leptos::SignalSet::set(&v53, v52);
                    ()
                }
            }
        }
        pub fn method90(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US18>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure47(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method100(
            v0_1: leptos::ReadSignal<Dice_ui::US18>,
        ) -> leptos::ReadSignal<Dice_ui::US18> {
            v0_1
        }
        pub fn method102() -> string {
            string("View")
        }
        pub fn method105() -> string {
            string("Dark Mode")
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method105()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method104() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure55((), ()))
        }
        pub fn method107() -> string {
            string("dark-mode")
        }
        pub fn closure59(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method110() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure59((), v))
        }
        pub fn closure58(v0_1: LrcPtr<Dice_ui::Heap1>, v1: leptos::ev::Event, unitVar: ()) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method50(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method110();
            let v8: leptos::RwSignal<bool> = Dice_ui::method52(v5.l0.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            ()
        }
        pub fn method109(v0_1: LrcPtr<Dice_ui::Heap1>, v1: leptos::ev::Event) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure58(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure57(v0_1: LrcPtr<Dice_ui::Heap1>, v1: leptos::ev::Event) {
            let v2 = Dice_ui::method109(v0_1, v1);
            let v5: Func0<()> = Dice_ui::method56(Func0::new(move || v2()));
            leptos::batch(move || v5());
            ()
        }
        pub fn method108(v0_1: LrcPtr<Dice_ui::Heap1>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure57(v0_1.clone(), v)
            })
        }
        pub fn closure60(v0_1: LrcPtr<Dice_ui::Heap1>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method50(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method66((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method111(v0_1: LrcPtr<Dice_ui::Heap1>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure60(v0_1.clone(), ())
            })
        }
        pub fn method112(
            v0_1: leptos::HtmlElement<leptos::html::Label>,
        ) -> leptos::HtmlElement<leptos::html::Label> {
            v0_1
        }
        pub fn closure56(v0_1: LrcPtr<Dice_ui::Heap1>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method107());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method108(v0_1.clone());
            let v8 = Dice_ui::method111(v0_1);
            let v9: string =
                string("<label for={v6.clone()} class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\"><input type=\"checkbox\" id={v6} class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"><svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg><svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg></span><span class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"></span></label>");
            let v10: string = append(append(string("leptos::view! { "), v9), string(" }"));
            let v13: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method112(
                leptos::view! { <label for={v6.clone()} class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"><input type="checkbox" id={v6} class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400"><svg data-unchecked-icon xmlns="http://www.w3.org/2000/svg" class="h-4 w-4" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" clip-rule="evenodd" /></svg><svg data-checked-icon xmlns="http://www.w3.org/2000/svg" class="hidden h-4 w-4" viewBox="0 0 20 20" fill="currentColor"> <path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" /></svg></span><span class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300"></span></label> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method106(v0_1: LrcPtr<Dice_ui::Heap1>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure56(v0_1.clone(), ())
            })
        }
        pub fn method114(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method115(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method117(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method118(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure62(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method117(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method118(Func0::new(move || v1()));
            let v6: leptos::View = leptos::IntoView::into_view(move || v4());
            leptos::Fragment::new(vec![v6])
        }
        pub fn method116(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure62(v0_1.clone(), ())
            })
        }
        pub fn method119(
            v0_1: leptos::HtmlElement<leptos::html::Dt>,
        ) -> leptos::HtmlElement<leptos::html::Dt> {
            v0_1
        }
        pub fn method120(
            v0_1: leptos::HtmlElement<leptos::html::Dd>,
        ) -> leptos::HtmlElement<leptos::html::Dd> {
            v0_1
        }
        pub fn method121(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method122(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn closure61(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"[font-size:11px] text-gray-400\"");
            let v7 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method114(v0_1)));
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
            let v13: leptos::HtmlElement<leptos::html::Dt> = Dice_ui::method119(
                leptos::view! { <dt  class="[font-size:11px] text-gray-400">{v7()}</dt> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            let v18: string =
                string(" class=\"[overflow:auto] text-gray-700 sm:col-span-2 flex flex-1\"");
            let v20 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method114(v1)));
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
            let v26: leptos::HtmlElement<leptos::html::Dd> = Dice_ui::method120(
                leptos::view! { <dd  class="[overflow:auto] text-gray-700 sm:col-span-2 flex flex-1">{v20()}</dd> },
            );
            let v31: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                v15,
                leptos::IntoView::into_view(v26),
            ])));
            let v33: Vec<leptos::View> = v31.to_vec();
            leptos::Fragment::new(v33)
        }
        pub fn method113(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure61(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method124() -> string {
            string("Debug")
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method124()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method123() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure63((), ()))
        }
        pub fn method126() -> string {
            string("debug")
        }
        pub fn closure66(v0_1: LrcPtr<Dice_ui::Heap1>, v1: leptos::ev::Event, unitVar: ()) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method50(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method110();
            let v8: leptos::RwSignal<bool> = Dice_ui::method52(v5.l1.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(x.clone()));
            ()
        }
        pub fn method128(v0_1: LrcPtr<Dice_ui::Heap1>, v1: leptos::ev::Event) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure66(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure65(v0_1: LrcPtr<Dice_ui::Heap1>, v1: leptos::ev::Event) {
            let v2 = Dice_ui::method128(v0_1, v1);
            let v5: Func0<()> = Dice_ui::method56(Func0::new(move || v2()));
            leptos::batch(move || v5());
            ()
        }
        pub fn method127(v0_1: LrcPtr<Dice_ui::Heap1>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure65(v0_1.clone(), v)
            })
        }
        pub fn closure67(v0_1: LrcPtr<Dice_ui::Heap1>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method50(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method66((leptos::SignalGetUntracked::get_untracked(&v2)).l1.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method129(v0_1: LrcPtr<Dice_ui::Heap1>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure67(v0_1.clone(), ())
            })
        }
        pub fn closure64(v0_1: LrcPtr<Dice_ui::Heap1>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method126());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method127(v0_1.clone());
            let v8 = Dice_ui::method129(v0_1);
            let v9: string =
                string("<label for={v6.clone()} class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\"><input type=\"checkbox\" id={v6} class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400\"><svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg><svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg></span><span class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\"></span></label>");
            let v10: string = append(append(string("leptos::view! { "), v9), string(" }"));
            let v13: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method112(
                leptos::view! { <label for={v6.clone()} class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"><input type="checkbox" id={v6} class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white dark:bg-gray-400 peer-checked:bg-white text-gray-200 transition-all peer-checked:start-6 peer-checked:text-gray-400"><svg data-unchecked-icon xmlns="http://www.w3.org/2000/svg" class="h-4 w-4" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" clip-rule="evenodd" /></svg><svg data-checked-icon xmlns="http://www.w3.org/2000/svg" class="hidden h-4 w-4" viewBox="0 0 20 20" fill="currentColor"> <path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" /></svg></span><span class="absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300"></span></label> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method125(v0_1: LrcPtr<Dice_ui::Heap1>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure64(v0_1.clone(), ())
            })
        }
        pub fn method130(
            v0_1: Array<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn method132(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn closure68(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method131() -> Func1<leptos::HtmlElement<leptos::html::Div>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Div>| Dice_ui::closure68((), v))
        }
        pub fn method133(
            v0_1: Array<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn method134(v0_1: Vec<leptos::View>) -> Vec<leptos::View> {
            v0_1
        }
        pub fn closure54(v0_1: LrcPtr<Dice_ui::Heap1>, unitVar: ()) -> leptos::Fragment {
            let v10: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] items-center\"");
            let v12 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method104(),
                Dice_ui::method106(v0_1.clone()),
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
            let v26 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method123(),
                Dice_ui::method125(v0_1),
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
            let v32: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method130(new_array(
                &[
                    v17,
                    leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] items-center">{v26()}</div> },
                ],
            ));
            let v33 = Dice_ui::method131();
            let v34: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method133(v32);
            let v36: Vec<leptos::HtmlElement<leptos::html::Div>> = v34.to_vec();
            let v39: Vec<leptos::View> =
                Dice_ui::method134(v36.iter().map(|x| v33(x.clone())).collect());
            let v42: Array<leptos::View> =
                Dice_ui::method122(fable_library_rust::NativeArray_::array_from(v39));
            let v44: Vec<leptos::View> = v42.to_vec();
            leptos::Fragment::new(v44)
        }
        pub fn method103(v0_1: LrcPtr<Dice_ui::Heap1>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure54(v0_1.clone(), ())
            })
        }
        pub fn closure69(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method117(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method118(Func0::new(move || v1()));
            let v6: leptos::View = leptos::IntoView::into_view(move || v4());
            leptos::Fragment::new(vec![v6])
        }
        pub fn method135(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure69(v0_1.clone(), ())
            })
        }
        pub fn method136(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
        ) -> leptos::HtmlElement<leptos::html::Details> {
            v0_1
        }
        pub fn method137() -> string {
            string("Debug")
        }
        pub fn method140() -> string {
            string("Global State")
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method140()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method139() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure71((), ()))
        }
        pub fn method143(v0_1: LrcPtr<Dice_ui::Heap1>) -> LrcPtr<Dice_ui::Heap1> {
            v0_1
        }
        pub fn closure74(unitVar: (), v0_1: std::string::String) -> Dice_ui::US20 {
            Dice_ui::US20::US20_1(v0_1)
        }
        pub fn closure75(unitVar: (), v0_1: std::string::String) -> Dice_ui::US20 {
            Dice_ui::US20::US20_0(v0_1)
        }
        pub fn closure73(v0_1: LrcPtr<Dice_ui::Heap1>, unitVar: ()) -> string {
            let v2: string = Dice_ui::method0(string(
                "settings.global_state_log_render () / global_state_json memo",
            ));
            leptos::logging::log!("{}", v2);
            {
                let v4: LrcPtr<Dice_ui::Heap1> = Dice_ui::method143(v0_1);
                let v6: Result<std::string::String, std::string::String> =
                    serde_json::to_string_pretty(&v4).map_err(|x| x.to_string());
                let v9: Dice_ui::US20 = match &v6 {
                    Err(v6_1_0) => Dice_ui::closure75((), v6_1_0.clone()),
                    Ok(v6_0_0) => Dice_ui::closure74((), v6_0_0.clone()),
                };
                match &v9 {
                    Dice_ui::US20::US20_1(v9_1_0) => {
                        let v11: std::string::String = Dice_ui::method47(v9_1_0.clone());
                        fable_library_rust::String_::fromString(v11)
                    }
                    Dice_ui::US20::US20_0(v9_0_0) => append(
                        append(string("Error: "), toString(v9_0_0.clone())),
                        string(""),
                    ),
                }
            }
        }
        pub fn method142(v0_1: LrcPtr<Dice_ui::Heap1>) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure73(v0_1.clone(), ())
            })
        }
        pub fn method145(v0_1: leptos::Memo<string>) -> leptos::Memo<string> {
            v0_1
        }
        pub fn method146(v0_1: string) -> string {
            v0_1
        }
        pub fn closure76(v0_1: leptos::Memo<string>, unitVar: ()) -> leptos::Fragment {
            let v1: leptos::Memo<string> = Dice_ui::method145(v0_1);
            let v6: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(v1())));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method144(v0_1: leptos::Memo<string>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure76(v0_1.clone(), ())
            })
        }
        pub fn method147(
            v0_1: leptos::HtmlElement<leptos::html::Pre>,
        ) -> leptos::HtmlElement<leptos::html::Pre> {
            v0_1
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(string("settings.global_state_log_render ()"));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap1>> =
                    leptos::use_context::<std::rc::Rc<Heap1>>();
                let v7 = Dice_ui::method142(v4.unwrap());
                let v13: string =
                    string(" class=\"[padding:7px] [font-size:11px] [line-height:11px]\"");
                let v15 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method144(
                    leptos::create_memo(move |_| v7()),
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
                let v21: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method147(
                    leptos::view! { <pre  class="[padding:7px] [font-size:11px] [line-height:11px]">{v15()}</pre> },
                );
                let v23: leptos::View = leptos::IntoView::into_view(v21);
                leptos::Fragment::new(vec![v23])
            }
        }
        pub fn method141() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure72((), ()))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] \"");
            let v10 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method139(),
                Dice_ui::method141(),
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
            let v16: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] ">{v10()}</div> },
            );
            let v18: leptos::View = leptos::IntoView::into_view(v16);
            leptos::Fragment::new(vec![v18])
        }
        pub fn method138() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure70((), ()))
        }
        pub fn method148(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method149(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(string("settings.render ()"));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap1>> =
                    leptos::use_context::<std::rc::Rc<Heap1>>();
                let v6: LrcPtr<Dice_ui::Heap1> = v4.unwrap();
                let v8: string = Dice_ui::method6(Dice_ui::method102());
                let v10: &str = fable_library_rust::String_::LrcStr::as_str(&v8);
                let v12: std::string::String = String::from(v10);
                let v14 = Dice_ui::method135(Dice_ui::method103(v6.clone()));
                let v15: string =
                    string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                let v16: string = append(append(string("leptos::view! { "), v15), string(" }"));
                let v18: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                let v19: string =
                    string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v12}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v18}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column]\">{v14()}</div></details>");
                let v20: string = append(append(string("leptos::view! { "), v19), string(" }"));
                let v23: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method136(
                    leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v12}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v18}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column]">{v14()}</div></details> },
                );
                let v25: leptos::View = leptos::IntoView::into_view(v23);
                let v27: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                    Dice_ui::method50(v6.l0.clone());
                let v31: leptos::RwSignal<bool> =
                    Dice_ui::method66((leptos::SignalGetUntracked::get_untracked(&v27)).l1.clone());
                let v62: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(
                    &[
                        v25,
                        if leptos::SignalGet::get(&v31) {
                            let v35: string = Dice_ui::method6(Dice_ui::method137());
                            let v37: &str = fable_library_rust::String_::LrcStr::as_str(&v35);
                            let v39: std::string::String = String::from(v37);
                            let v41 = Dice_ui::method135(Dice_ui::method138());
                            let v42:
                                                                                  string =
                                                                              string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                            let v43: string =
                                append(append(string("leptos::view! { "), v42), string(" }"));
                            let v45: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                            let v46:
                                                                                  string =
                                                                              string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v39}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v45}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column]\">{v41()}</div></details>");
                            let v47: string =
                                append(append(string("leptos::view! { "), v46), string(" }"));
                            let v50: leptos::HtmlElement<leptos::html::Details> =
                                Dice_ui::method136(
                                    leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v39}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v45}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column]">{v41()}</div></details> },
                                );
                            leptos::IntoView::into_view(v50)
                        } else {
                            let v56: Array<leptos::View> = Dice_ui::method149(Dice_ui::method148(
                                Dice_ui::method121(new_empty::<leptos::View>()),
                            ));
                            leptos::CollectView::collect_view(v56.to_vec())
                        },
                    ],
                )));
                let v64: Vec<leptos::View> = v62.to_vec();
                leptos::Fragment::new(v64)
            }
        }
        pub fn method101() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure53((), ()))
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> Option<string> {
            let v2: Option<string> =
                Some(string("https://api2.nearblocks.io/v1/account/i574n.near/txns?&order=desc&page=1&per_page=25"));
            let v5: string = Dice_ui::method0(append(
                append(
                    string("transactions.render () / url create_memo / result: "),
                    sprintf!("{:?}", &v2),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v5);
            v2
        }
        pub fn method151() -> Func0<Option<string>> {
            Func0::new(move || Dice_ui::closure78((), ()))
        }
        pub fn method153(v0_1: leptos::Memo<Option<string>>) -> leptos::Memo<Option<string>> {
            v0_1
        }
        pub fn closure79(v0_1: leptos::Memo<Option<string>>, unitVar: ()) -> Option<string> {
            let v1: leptos::Memo<Option<string>> = Dice_ui::method153(v0_1);
            v1()
        }
        pub fn method152(v0_1: leptos::Memo<Option<string>>) -> Func0<Option<string>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure79(v0_1.clone(), ())
            })
        }
        pub fn closure81(unitVar: (), v0_1: string) -> Dice_ui::US21 {
            Dice_ui::US21::US21_1(v0_1)
        }
        pub fn method154(v0_1: string) -> string {
            v0_1
        }
        pub fn method155(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure82(unitVar: (), v0_1: reqwest_wasm::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method156() -> Func1<reqwest_wasm::Error, std::string::String> {
            Func1::new(move |v: reqwest_wasm::Error| Dice_ui::closure82((), v))
        }
        pub fn method157(v0_1: Result<Option<string>, string>) -> Result<Option<string>, string> {
            v0_1
        }
        pub fn closure80(
            unitVar: (),
            v0_1: Option<string>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<Option<string>, string>>>>
        {
            let v3: string = Dice_ui::method0(append(
                append(
                    string("state.use_request (2) / json create_local_resource / url: "),
                    sprintf!("{:?}", &v0_1),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v3);
            let __future_init = Box::pin(async move {
                //;
                {
                    let v8: Dice_ui::US21 = defaultValue(
                        Dice_ui::US21::US21_0,
                        map(Func1::new(move |v: string| Dice_ui::closure81((), v)), v0_1),
                    );
                    let v44: Dice_ui::US22 = match &v8 {
                        Dice_ui::US21::US21_1(v8_1_0) => {
                            let v12: string = Dice_ui::method6(Dice_ui::method13(
                                Dice_ui::method154(v8_1_0.clone()),
                            ));
                            let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
                            let v17: std::string::String = Dice_ui::method155(String::from(v14));
                            let v19: std::pin::Pin<
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
                                    .get(v17)
                                    .send(),
                            );
                            let v21: Result<reqwest_wasm::Response, reqwest_wasm::Error> =
                                v19.await;
                            let v22 = Dice_ui::method156();
                            let v24: Result<reqwest_wasm::Response, std::string::String> =
                                v21.map_err(|x| v22(x));
                            let v26: reqwest_wasm::Response = v24?;
                            let v28: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                        Output = Result<std::string::String, reqwest_wasm::Error>,
                                    >,
                                >,
                            > = Box::pin(reqwest_wasm::Response::text(v26));
                            let v30: Result<std::string::String, reqwest_wasm::Error> = v28.await;
                            let v31 = Dice_ui::method156();
                            let v33: Result<std::string::String, std::string::String> =
                                v30.map_err(|x| v31(x));
                            let v36: std::string::String = Dice_ui::method47(v33?);
                            Dice_ui::US22::US22_1(Some(fable_library_rust::String_::fromString(
                                v36,
                            )))
                        }
                        _ => Dice_ui::US22::US22_0(string("Invalid url")),
                    };
                    let v51: Result<Option<string>, string> = Dice_ui::method157(match &v44 {
                        Dice_ui::US22::US22_1(v44_1_0) => Ok(v44_1_0.clone()),
                        Dice_ui::US22::US22_0(v44_0_0) => Err(v44_0_0.clone()),
                    });
                    v51
                }
            });
            {
                //;
                __future_init
            }
        }
        pub fn closure83(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v2: string = Dice_ui::method0(string("state.use_request (3) / database_memo"));
            leptos::logging::log!("{}", v2);
            {
                let v4: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method19(v0_1);
                leptos::SignalGet::get(&v4)
            }
        }
        pub fn method158(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure83(v0_1.clone(), ())
            })
        }
        pub fn closure84(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> (Option<rexie::Rexie>, Option<string>) {
            let v2: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method19(v1);
            let v4: Option<rexie::Rexie> = leptos::SignalGet::get(&v2);
            let v5: leptos::Memo<Option<string>> = Dice_ui::method153(v0_1);
            (v4, v5())
        }
        pub fn method159(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func0<(Option<rexie::Rexie>, Option<string>)> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure84(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method160(
            v0_1: Result<Dice_ui::US23, std::string::String>,
        ) -> Result<Dice_ui::US23, std::string::String> {
            v0_1
        }
        pub fn closure86(unitVar: (), v0_1: Dice_ui::US23) -> Dice_ui::US24 {
            Dice_ui::US24::US24_1(v0_1)
        }
        pub fn closure87(unitVar: (), v0_1: std::string::String) -> Dice_ui::US24 {
            Dice_ui::US24::US24_0(v0_1)
        }
        pub fn method161(v0_1: Option<LrcPtr<Dice_ui::Heap3>>) -> Option<LrcPtr<Dice_ui::Heap3>> {
            v0_1
        }
        pub fn closure85(
            unitVar: (),
            _arg: (Option<rexie::Rexie>, Option<string>),
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Option<LrcPtr<Dice_ui::Heap3>>>>>
        {
            let v1: Option<string> = _arg.1.clone();
            let v0_1: Option<rexie::Rexie> = _arg.0.clone();
            let __future_init = Box::pin(async move {
                //;
                {
                    let v6: string =
                    Dice_ui::method0(append(append(append(append(string("state.use_request (4) / state_data_resource create_local_resource / url : "),
                                                                 sprintf!("{:?}",
                                                                          &v1)),
                                                          string(" / database: ")),
                                                   sprintf!("{:?}", &v0_1)),
                                            string("")));
                    leptos::logging::log!("{}", v6);
                    {
                        let v10: Dice_ui::US4 = defaultValue(
                            Dice_ui::US4::US4_0,
                            map(
                                Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                                v0_1,
                            ),
                        );
                        let v13: Dice_ui::US21 = defaultValue(
                            Dice_ui::US21::US21_0,
                            map(
                                Func1::new(move |v_1: string| Dice_ui::closure81((), v_1)),
                                v1,
                            ),
                        );
                        let v127: Dice_ui::US23 = if let Dice_ui::US4::US4_1(v10_1_0) = &v10 {
                            if let Dice_ui::US21::US21_1(v13_1_0) = &v13 {
                                let v15: string = match &v13 {
                                    Dice_ui::US21::US21_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v17: string = Dice_ui::method0(append(
                                    append(string("state.get_data () / id: "), v15.clone()),
                                    string(""),
                                ));
                                leptos::logging::log!("{}", v17);
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v22: Array<string> =
                                            Dice_ui::method20(new_array(&[string("store")]));
                                        let v23 = Dice_ui::method21();
                                        let v24: Array<string> = Dice_ui::method22(v22);
                                        let v26: Vec<string> = v24.to_vec();
                                        let v29: Vec<std::string::String> = Dice_ui::method23(
                                            v26.iter().map(|x| v23(x.clone())).collect(),
                                        );
                                        let v31: Array<std::string::String> =
                                            fable_library_rust::NativeArray_::array_from(v29);
                                        let v32: rexie::Rexie = Dice_ui::method24(match &v10 {
                                            Dice_ui::US4::US4_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        });
                                        let v34: Result<rexie::Transaction, rexie::Error> =
                                            v32.transaction(&v31, rexie::TransactionMode::ReadOnly);
                                        let v35 = Dice_ui::method25();
                                        let v37: Result<rexie::Transaction, std::string::String> =
                                            v34.map_err(|x| v35(x));
                                        let v39: rexie::Transaction = v37?;
                                        let v40: string = Dice_ui::method26();
                                        let v42: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v40);
                                        let v44: Result<rexie::Store, rexie::Error> =
                                            v39.store(v42);
                                        let v45 = Dice_ui::method27();
                                        let v47: Result<rexie::Store, std::string::String> =
                                            v44.map_err(|x| v45(x));
                                        let v49: rexie::Store = v47?;
                                        let v50: string = Dice_ui::method6(v15);
                                        let v52: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v50);
                                        let v54: wasm_bindgen::JsValue =
                                            wasm_bindgen::JsValue::from_str(v52);
                                        let v56: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<
                                                        wasm_bindgen::JsValue,
                                                        rexie::Error,
                                                    >,
                                                >,
                                            >,
                                        > = Box::pin(rexie::Store::get(&v49, &v54));
                                        let v58: Result<wasm_bindgen::JsValue, rexie::Error> =
                                            v56.await;
                                        let v59 = Dice_ui::method29();
                                        let v61: Result<
                                            wasm_bindgen::JsValue,
                                            std::string::String,
                                        > = v58.map_err(|x| v59(x));
                                        let v64: wasm_bindgen::JsValue = Dice_ui::method30(v61?);
                                        let v66: Result<
                                            Option<serde_json::Value>,
                                            serde_wasm_bindgen::Error,
                                        > = serde_wasm_bindgen::from_value(v64);
                                        let v67 = Dice_ui::method31();
                                        let v69: Result<
                                            Option<serde_json::Value>,
                                            std::string::String,
                                        > = v66.map_err(|x| v67(x));
                                        let v74: Dice_ui::US5 = defaultValue(
                                            Dice_ui::US5::US5_0,
                                            map(
                                                Func1::new(move |v_2: serde_json::Value| {
                                                    Dice_ui::closure18((), v_2)
                                                }),
                                                v69?,
                                            ),
                                        );
                                        let v109: Result<Dice_ui::US23, std::string::String> =
                                            Dice_ui::method160(Ok(match &v74 {
                                                Dice_ui::US5::US5_1(v74_1_0) => {
                                                    let v76: serde_json::Value =
                                                        Dice_ui::method32(v74_1_0.clone());
                                                    let v78: Result<Vec<u8>, serde_json::Error> =
                                                        serde_json::from_value(v76);
                                                    let v79 = Dice_ui::method33();
                                                    let v81: Result<Vec<u8>, std::string::String> =
                                                        v78.map_err(|x| v79(x));
                                                    let v84: Vec<u8> = Dice_ui::method34(v81?);
                                                    let v86:
                                                                              Array<u8> =
                                                                          fable_library_rust::NativeArray_::array_from(v84);
                                                    let v89: string = Dice_ui::method0(append(
                                                        append(
                                                            string(
                                                                "state.get_data () / data_len: ",
                                                            ),
                                                            toString(count(v86.clone())),
                                                        ),
                                                        string(""),
                                                    ));
                                                    leptos::logging::log!("{}", v89);
                                                    {
                                                        let v91: Array<u8> = Dice_ui::method35(v86);
                                                        let v93: Vec<u8> = v91.to_vec();
                                                        let v95: &[u8] = v93.as_slice();
                                                        let mut v95 = v95;
                                                        {
                                                            let v98:
                                                                                      Result<LrcPtr<Dice_ui::Heap3>,
                                                                                             borsh::io::Error> =
                                                                                  borsh::BorshDeserialize::deserialize(&mut v95);
                                                            let v99 = Dice_ui::method36();
                                                            let v101: Result<
                                                                LrcPtr<Dice_ui::Heap3>,
                                                                std::string::String,
                                                            > = v98.map_err(|x| v99(x));
                                                            Dice_ui::US23::US23_1(v101?)
                                                        }
                                                    }
                                                }
                                                _ => Dice_ui::US23::US23_0,
                                            }));
                                        v109
                                    }
                                });
                                {
                                    //;
                                    {
                                        let v112: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<
                                                        Dice_ui::US23,
                                                        std::string::String,
                                                    >,
                                                >,
                                            >,
                                        > = __future_init;
                                        let v114: Result<Dice_ui::US23, std::string::String> =
                                            v112.await;
                                        let v117: Dice_ui::US24 = match &v114 {
                                            Err(v114_1_0) => {
                                                Dice_ui::closure87((), v114_1_0.clone())
                                            }
                                            Ok(v114_0_0) => {
                                                Dice_ui::closure86((), v114_0_0.clone())
                                            }
                                        };
                                        match &v117 {
                                            Dice_ui::US24::US24_1(v117_1_0) => v117_1_0.clone(),
                                            Dice_ui::US24::US24_0(v117_0_0) => panic!(
                                                "{}",
                                                sprintf!("Result value was Error: {}", v117_0_0),
                                            ),
                                        }
                                    }
                                }
                            } else {
                                Dice_ui::US23::US23_0
                            }
                        } else {
                            Dice_ui::US23::US23_0
                        };
                        let v133: Option<LrcPtr<Dice_ui::Heap3>> =
                            Dice_ui::method161(match &v127 {
                                Dice_ui::US23::US23_1(v127_1_0) => Some(v127_1_0.clone()),
                                _ => None::<LrcPtr<Dice_ui::Heap3>>,
                            });
                        v133
                    }
                }
            });
            {
                {
                    //;
                    __future_init
                }
            }
        }
        pub fn method163(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap3>>,
            >,
        ) -> leptos::Resource<(Option<rexie::Rexie>, Option<string>), Option<LrcPtr<Dice_ui::Heap3>>>
        {
            v0_1
        }
        pub fn closure89(unitVar: (), v0_1: Option<LrcPtr<Dice_ui::Heap3>>) -> Dice_ui::US25 {
            Dice_ui::US25::US25_1(v0_1)
        }
        pub fn closure90(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap3>) -> Dice_ui::US23 {
            Dice_ui::US23::US23_1(v0_1)
        }
        pub fn closure88(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap3>>,
            >,
            unitVar: (),
        ) -> Option<LrcPtr<Dice_ui::Heap3>> {
            let v2: string = Dice_ui::method0(string("state.use_request (5) / state_data_func"));
            leptos::logging::log!("{}", v2);
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method41(Dice_ui::method40());
                let v8: Dice_ui::US7 = match &v5 {
                    Err(v5_1_0) => Dice_ui::closure25((), v5_1_0.clone()),
                    Ok(v5_0_0) => Dice_ui::closure24((), v5_0_0.clone()),
                };
                let v17: Dice_ui::US8 = match &v8 {
                    Dice_ui::US7::US7_1(v8_1_0) => Dice_ui::US8::US8_1(defaultValue(
                        Dice_ui::US9::US9_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure26((), v_2)),
                            v8_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US7::US7_0(v8_0_0) => Dice_ui::US8::US8_0(v8_0_0.clone()),
                };
                let v53: Dice_ui::US23 = if let Dice_ui::US8::US8_1(v17_1_0) = &v17 {
                    if let Dice_ui::US9::US9_1(_) = &match &v17 {
                        Dice_ui::US8::US8_1(x) => x.clone(),
                        _ => unreachable!(),
                    } {
                        let v20: leptos::Resource<
                            (Option<rexie::Rexie>, Option<string>),
                            Option<LrcPtr<Dice_ui::Heap3>>,
                        > = Dice_ui::method163(v0_1);
                        let v25: Dice_ui::US25 = defaultValue(
                            Dice_ui::US25::US25_0,
                            map(
                                Func1::new(move |v_3: Option<LrcPtr<Dice_ui::Heap3>>| {
                                    Dice_ui::closure89((), v_3)
                                }),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v33: Dice_ui::US26 = match &v25 {
                            Dice_ui::US25::US25_1(v25_1_0) => Dice_ui::US26::US26_1(defaultValue(
                                Dice_ui::US23::US23_0,
                                map(
                                    Func1::new(move |v_4: LrcPtr<Dice_ui::Heap3>| {
                                        Dice_ui::closure90((), v_4)
                                    }),
                                    v25_1_0.clone(),
                                ),
                            )),
                            _ => Dice_ui::US26::US26_0,
                        };
                        let v40: Dice_ui::US23 = if let Dice_ui::US26::US26_1(v33_1_0) = &v33 {
                            let v34: Dice_ui::US23 = match &v33 {
                                Dice_ui::US26::US26_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Dice_ui::US23::US23_1(v34_1_0) = &v34 {
                                Dice_ui::US23::US23_1(match &v34 {
                                    Dice_ui::US23::US23_1(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            } else {
                                Dice_ui::US23::US23_0
                            }
                        } else {
                            Dice_ui::US23::US23_0
                        };
                        let v41: string = sprintf!("{:?}", &v40);
                        let v48: string = Dice_ui::method0(append(
                            append(
                                string(
                                    "state.use_request (7) / new_signal_map memo / state_data: ",
                                ),
                                (if length(v41.clone()) <= 200_i32 {
                                    v41.clone()
                                } else {
                                    append(substring2(v41, 0_i32, 200_i32), string("..."))
                                }),
                            ),
                            string(""),
                        ));
                        leptos::logging::log!("{}", v48);
                        v40
                    } else {
                        Dice_ui::US23::US23_0
                    }
                } else {
                    Dice_ui::US23::US23_0
                };
                match &v53 {
                    Dice_ui::US23::US23_1(v53_1_0) => Some(v53_1_0.clone()),
                    _ => None::<LrcPtr<Dice_ui::Heap3>>,
                }
            }
        }
        pub fn method162(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap3>>,
            >,
        ) -> Func0<Option<LrcPtr<Dice_ui::Heap3>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure88(v0_1.clone(), ())
            })
        }
        pub fn method165(
            v0_1: leptos::Memo<Option<rexie::Rexie>>,
        ) -> leptos::Memo<Option<rexie::Rexie>> {
            v0_1
        }
        pub fn method166(v0_1: leptos::Memo<Option<string>>) -> leptos::Memo<Option<string>> {
            v0_1
        }
        pub fn closure91(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Memo<Option<rexie::Rexie>>,
            v2: LrcPtr<Dice_ui::Heap3>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v4: i64 = length(sprintf!("{:?}", &v2)) as i64;
            let __future_init = Box::pin(async move {
                //;
                {
                    let v7: string = Dice_ui::method0(append(
                        append(
                            string("state.use_request (8) / set_state_data_action / value_len: "),
                            toString(v4),
                        ),
                        string(""),
                    ));
                    leptos::logging::log!("{}", v7);
                    {
                        let v9: leptos::Memo<Option<rexie::Rexie>> = Dice_ui::method165(v1);
                        let v14: Dice_ui::US4 = defaultValue(
                            Dice_ui::US4::US4_0,
                            map(
                                Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                                leptos::SignalGetUntracked::get_untracked(&v9),
                            ),
                        );
                        let v15: leptos::Memo<Option<string>> = Dice_ui::method166(v0_1);
                        let v20: Dice_ui::US21 = defaultValue(
                            Dice_ui::US21::US21_0,
                            map(
                                Func1::new(move |v_1: string| Dice_ui::closure81((), v_1)),
                                leptos::SignalGetUntracked::get_untracked(&v15),
                            ),
                        );
                        if let Dice_ui::US4::US4_1(v14_1_0) = &v14 {
                            if let Dice_ui::US21::US21_1(v20_1_0) = &v20 {
                                let v22: string = match &v20 {
                                    Dice_ui::US21::US21_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v24: string =
                                Dice_ui::method0(append(append(string("state.use_request (9) / set_state_data_action / database=Some(_) / url: "),
                                                               v22.clone()),
                                                        string("")));
                                leptos::logging::log!("{}", v24);
                                {
                                    let v29: string = Dice_ui::method0(append(
                                        append(
                                            string("state.set_data () / data_len: "),
                                            toString(length(sprintf!("{:?}", &v2)) as i64),
                                        ),
                                        string(""),
                                    ));
                                    leptos::logging::log!("{}", v29);
                                    {
                                        let v31: rexie::Rexie = Dice_ui::method61(match &v14 {
                                            Dice_ui::US4::US4_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        });
                                        let __future_init = Box::pin(async {
                                            //;
                                            {
                                                let v34: rexie::Transaction = v31.transaction(
                                                    &["store"],
                                                    rexie::TransactionMode::ReadWrite,
                                                )?;
                                                let v36: rexie::Store = v34.store("store")?;
                                                let mut data = Vec::new();
                                                borsh::BorshSerialize::serialize(&v2, &mut data)
                                                    .unwrap();
                                                {
                                                    let v40: Vec<u8> = data;
                                                    let v42: wasm_bindgen::JsValue =
                                                        serde_wasm_bindgen::to_value(&v40).unwrap();
                                                    let v43: string = Dice_ui::method6(v22);
                                                    let v45: &str =
                                                        fable_library_rust::String_::LrcStr::as_str(
                                                            &v43,
                                                        );
                                                    v36.put(&v42, Some(&v45.into())).await?;
                                                    v34.done().await?;
                                                    {
                                                        let v49: Result<(), rexie::Error> =
                                                            Dice_ui::method62(Ok(()));
                                                        v49
                                                    }
                                                }
                                            }
                                        });
                                        {
                                            {
                                                {
                                                    //;
                                                    {
                                                        let v52: std::pin::Pin<
                                                            Box<
                                                                dyn std::future::Future<
                                                                    Output = Result<
                                                                        (),
                                                                        rexie::Error,
                                                                    >,
                                                                >,
                                                            >,
                                                        > = __future_init;
                                                        let v54: Result<(), rexie::Error> =
                                                            v52.await;
                                                        let v57: Dice_ui::US15 = match &v54 {
                                                            Err(v54_1_0) => Dice_ui::closure40(
                                                                (),
                                                                v54_1_0.clone(),
                                                            ),
                                                            _ => Dice_ui::closure39((), ()),
                                                        };
                                                        match &v57 {
                                                            Dice_ui::US15::US15_1 => (),
                                                            Dice_ui::US15::US15_0(v57_0_0) => panic!(
                                                                "{}",
                                                                sprintf!(
                                                                    "Result value was Error: {}",
                                                                    v57_0_0
                                                                ),
                                                            ),
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            } else {
                                let v61: string =
                                Dice_ui::method0(string("state.use_request (10) / set_state_data_action / database,url=None"));
                                leptos::logging::log!("{}", v61);
                                ()
                            }
                        } else {
                            let v64: string =
                            Dice_ui::method0(string("state.use_request (10) / set_state_data_action / database,url=None"));
                            leptos::logging::log!("{}", v64);
                            ()
                        }
                        Dice_ui::method63();
                        ()
                    }
                }
            });
            {
                {
                    //;
                    __future_init
                }
            }
        }
        pub fn method164(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Memo<Option<rexie::Rexie>>,
        ) -> Func1<LrcPtr<Dice_ui::Heap3>, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |v: LrcPtr<Dice_ui::Heap3>| Dice_ui::closure91(v0_1.clone(), v1.clone(), v)
            })
        }
        pub fn method168(
            v0_1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
        ) -> leptos::Resource<Option<string>, Result<Option<string>, string>> {
            v0_1
        }
        pub fn closure93(unitVar: (), v0_1: Result<Option<string>, string>) -> Dice_ui::US27 {
            Dice_ui::US27::US27_1(v0_1)
        }
        pub fn closure94(unitVar: (), v0_1: Option<string>) -> Dice_ui::US22 {
            Dice_ui::US22::US22_1(v0_1)
        }
        pub fn closure95(unitVar: (), v0_1: string) -> Dice_ui::US22 {
            Dice_ui::US22::US22_0(v0_1)
        }
        pub fn method169(v0_1: LrcPtr<Dice_ui::Heap3>) -> LrcPtr<Dice_ui::Heap3> {
            v0_1
        }
        pub fn closure92(
            v0_1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()>,
            unitVar: (),
        ) {
            let v3: string = Dice_ui::method0(string(
                "state.use_request (11) / effect new_state_data / ##2",
            ));
            leptos::logging::log!("{}", v3);
            {
                let v6: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method41(Dice_ui::method40());
                let v9: Dice_ui::US7 = match &v6 {
                    Err(v6_1_0) => Dice_ui::closure25((), v6_1_0.clone()),
                    Ok(v6_0_0) => Dice_ui::closure24((), v6_0_0.clone()),
                };
                let v18: Dice_ui::US8 = match &v9 {
                    Dice_ui::US7::US7_1(v9_1_0) => Dice_ui::US8::US8_1(defaultValue(
                        Dice_ui::US9::US9_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Dice_ui::closure26((), v_2)),
                            v9_1_0.clone(),
                        ),
                    )),
                    Dice_ui::US7::US7_0(v9_0_0) => Dice_ui::US8::US8_0(v9_0_0.clone()),
                };
                if let Dice_ui::US8::US8_1(v18_1_0) = &v18 {
                    if let Dice_ui::US9::US9_1(_) = &match &v18 {
                        Dice_ui::US8::US8_1(x) => x.clone(),
                        _ => unreachable!(),
                    } {
                        let v21: leptos::Resource<Option<string>, Result<Option<string>, string>> =
                            Dice_ui::method168(v0_1);
                        let v26: Dice_ui::US27 = defaultValue(
                            Dice_ui::US27::US27_0,
                            map(
                                Func1::new(move |v_3: Result<Option<string>, string>| {
                                    Dice_ui::closure93((), v_3)
                                }),
                                leptos::SignalGet::get(&v21),
                            ),
                        );
                        let v34: Dice_ui::US28 = match &v26 {
                            Dice_ui::US27::US27_1(v26_1_0) => {
                                let v27: Result<Option<string>, string> = v26_1_0.clone();
                                Dice_ui::US28::US28_1(match &v27 {
                                    Err(v27_1_0) => Dice_ui::closure95((), v27_1_0.clone()),
                                    Ok(v27_0_0) => Dice_ui::closure94((), v27_0_0.clone()),
                                })
                            }
                            _ => Dice_ui::US28::US28_0,
                        };
                        let v48: Dice_ui::US29 = match &v34 {
                            Dice_ui::US28::US28_1(v34_1_0) => {
                                let v35: Dice_ui::US22 = v34_1_0.clone();
                                Dice_ui::US29::US29_1(match &v35 {
                                    Dice_ui::US22::US22_1(v35_1_0) => {
                                        Dice_ui::US30::US30_1(defaultValue(
                                            Dice_ui::US21::US21_0,
                                            map(
                                                Func1::new(move |v_6: string| {
                                                    Dice_ui::closure81((), v_6)
                                                }),
                                                v35_1_0.clone(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US22::US22_0(v35_0_0) => {
                                        Dice_ui::US30::US30_0(v35_0_0.clone())
                                    }
                                })
                            }
                            _ => Dice_ui::US29::US29_0,
                        };
                        let v75: Dice_ui::US31 = if let Dice_ui::US29::US29_1(v48_1_0) = &v48 {
                            let v49: Dice_ui::US30 = match &v48 {
                                Dice_ui::US29::US29_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            match &v49 {
                                Dice_ui::US30::US30_1(v49_1_0) => {
                                    let v50: Dice_ui::US21 = v49_1_0.clone();
                                    if let Dice_ui::US21::US21_1(v50_1_0) = &v50 {
                                        let v53: string =
                                            Dice_ui::method6(Dice_ui::method13(match &v50 {
                                                Dice_ui::US21::US21_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            }));
                                        let v55: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v53);
                                        Dice_ui::US31::US31_1(Dice_ui::US13::US13_1(String::from(
                                            v55,
                                        )))
                                    } else {
                                        Dice_ui::US31::US31_1(Dice_ui::US13::US13_0)
                                    }
                                }
                                Dice_ui::US30::US30_0(v49_0_0) => {
                                    let v65: string =
                                        Dice_ui::method6(Dice_ui::method13(v49_0_0.clone()));
                                    let v67: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v65);
                                    Dice_ui::US31::US31_0(String::from(v67))
                                }
                            }
                        } else {
                            Dice_ui::US31::US31_1(Dice_ui::US13::US13_0)
                        };
                        let v76: string = sprintf!("{:?}", &v75);
                        let v83: string = Dice_ui::method0(append(
                            append(
                                string("state.use_request (12) / effect / json: "),
                                (if length(v76.clone()) <= 200_i32 {
                                    v76.clone()
                                } else {
                                    append(substring2(v76, 0_i32, 200_i32), string("..."))
                                }),
                            ),
                            string(""),
                        ));
                        leptos::logging::log!("{}", v83);
                        if let Dice_ui::US31::US31_1(v75_1_0) = &v75 {
                            let v85: Dice_ui::US13 = match &v75 {
                                Dice_ui::US31::US31_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Dice_ui::US13::US13_1(v85_1_0) = &v85 {
                                let v88: LrcPtr<Dice_ui::Heap3> =
                                    Dice_ui::method169(LrcPtr::new(Dice_ui::Heap3 {
                                        l0: match &v85 {
                                            Dice_ui::US13::US13_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                    }));
                                leptos::Action::dispatch(&v1, v88);
                                ()
                            }
                        }
                    };
                }
                {
                    let v91: string = Dice_ui::method0(string(
                        "state.use_request (13) / effect new_state_data / ##5",
                    ));
                    leptos::logging::log!("{}", v91);
                    ()
                }
            }
        }
        pub fn method167(
            v0_1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure92(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method171() -> string {
            string("Invalid url")
        }
        pub fn method172(
            v0_1: Func0<Option<LrcPtr<Dice_ui::Heap3>>>,
        ) -> Func0<Option<LrcPtr<Dice_ui::Heap3>>> {
            v0_1
        }
        pub fn closure97(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Root,
        ) -> Option<crate::model::near::nearblocks::Root> {
            Some(v0_1)
        }
        pub fn method173(
        ) -> Func1<crate::model::near::nearblocks::Root, Option<crate::model::near::nearblocks::Root>>
        {
            Func1::new(move |v: crate::model::near::nearblocks::Root| Dice_ui::closure97((), v))
        }
        pub fn method174(
            v0_1: Result<crate::model::near::nearblocks::Root, std::string::String>,
        ) -> Result<crate::model::near::nearblocks::Root, std::string::String> {
            v0_1
        }
        pub fn closure96(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            v2: Func0<Option<LrcPtr<Dice_ui::Heap3>>>,
            unitVar: (),
        ) -> Result<Option<crate::model::near::nearblocks::Root>, std::string::String> {
            let v3: leptos::Memo<Option<string>> = Dice_ui::method153(v0_1);
            let v5: Option<string> = v3();
            let v8: string = Dice_ui::method0(append(
                append(
                    string("state.use_request (14) / result memo / url: "),
                    sprintf!("{:?}", &v5),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v8);
            {
                fn v10(v: string) -> Dice_ui::US21 {
                    Dice_ui::closure81((), v)
                }
                let v12: Dice_ui::US21 =
                    defaultValue(Dice_ui::US21::US21_0, map(Func1::from(v10), v5));
                let v159: Result<
                    Option<crate::model::near::nearblocks::Root>,
                    std::string::String,
                > = match &v12 {
                    Dice_ui::US21::US21_1(v12_1_0) => {
                        let v15: string = Dice_ui::method0(append(
                            append(
                                string("state.use_request (15) / result memo / url: "),
                                v12_1_0.clone(),
                            ),
                            string(""),
                        ));
                        leptos::logging::log!("{}", v15);
                        {
                            let v17: Func0<Option<LrcPtr<Dice_ui::Heap3>>> = Dice_ui::method172(v2);
                            let v22: Dice_ui::US23 = defaultValue(
                                Dice_ui::US23::US23_0,
                                map(
                                    Func1::new(move |v_1: LrcPtr<Dice_ui::Heap3>| {
                                        Dice_ui::closure90((), v_1)
                                    }),
                                    (move || v17())(),
                                ),
                            );
                            let v23: string = sprintf!("{:?}", &v22);
                            let v30: string = Dice_ui::method0(append(
                                append(
                                    string("state.use_request (16) / result_memo / state_data: "),
                                    (if length(v23.clone()) <= 200_i32 {
                                        v23.clone()
                                    } else {
                                        append(substring2(v23, 0_i32, 200_i32), string("..."))
                                    }),
                                ),
                                string(""),
                            ));
                            leptos::logging::log!("{}", v30);
                            {
                                let v32: leptos::Resource<
                                    Option<string>,
                                    Result<Option<string>, string>,
                                > = Dice_ui::method168(v1);
                                let v37: Dice_ui::US27 = defaultValue(
                                    Dice_ui::US27::US27_0,
                                    map(
                                        Func1::new(move |v_2: Result<Option<string>, string>| {
                                            Dice_ui::closure93((), v_2)
                                        }),
                                        leptos::SignalGet::get(&v32),
                                    ),
                                );
                                let v45: Dice_ui::US28 = match &v37 {
                                    Dice_ui::US27::US27_1(v37_1_0) => {
                                        let v38: Result<Option<string>, string> = v37_1_0.clone();
                                        Dice_ui::US28::US28_1(match &v38 {
                                            Err(v38_1_0) => Dice_ui::closure95((), v38_1_0.clone()),
                                            Ok(v38_0_0) => Dice_ui::closure94((), v38_0_0.clone()),
                                        })
                                    }
                                    _ => Dice_ui::US28::US28_0,
                                };
                                let v58: Dice_ui::US29 = match &v45 {
                                    Dice_ui::US28::US28_1(v45_1_0) => {
                                        let v46: Dice_ui::US22 = v45_1_0.clone();
                                        Dice_ui::US29::US29_1(match &v46 {
                                            Dice_ui::US22::US22_1(v46_1_0) => {
                                                Dice_ui::US30::US30_1(defaultValue(
                                                    Dice_ui::US21::US21_0,
                                                    map(Func1::from(v10), v46_1_0.clone()),
                                                ))
                                            }
                                            Dice_ui::US22::US22_0(v46_0_0) => {
                                                Dice_ui::US30::US30_0(v46_0_0.clone())
                                            }
                                        })
                                    }
                                    _ => Dice_ui::US29::US29_0,
                                };
                                let v73: Dice_ui::US30 =
                                    if let Dice_ui::US29::US29_1(v58_1_0) = &v58 {
                                        let v59: Dice_ui::US30 = match &v58 {
                                            Dice_ui::US29::US29_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        match &v59 {
                                            Dice_ui::US30::US30_1(v59_1_0) => {
                                                let v62: Dice_ui::US21 = v59_1_0.clone();
                                                if let Dice_ui::US21::US21_1(v62_1_0) = &v62 {
                                                    Dice_ui::US30::US30_1(Dice_ui::US21::US21_1(
                                                        match &v62 {
                                                            Dice_ui::US21::US21_1(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                    ))
                                                } else {
                                                    Dice_ui::US30::US30_1(Dice_ui::US21::US21_0)
                                                }
                                            }
                                            Dice_ui::US30::US30_0(v59_0_0) => {
                                                Dice_ui::US30::US30_0(v59_0_0.clone())
                                            }
                                        }
                                    } else {
                                        Dice_ui::US30::US30_1(Dice_ui::US21::US21_0)
                                    };
                                let v74: string = sprintf!("{:?}", &v73);
                                let v81: string = Dice_ui::method0(append(
                                    append(
                                        string("state.use_request (16.1) / effect / json: "),
                                        (if length(v74.clone()) <= 200_i32 {
                                            v74.clone()
                                        } else {
                                            append(substring2(v74, 0_i32, 200_i32), string("..."))
                                        }),
                                    ),
                                    string(""),
                                ));
                                leptos::logging::log!("{}", v81);
                                {
                                    let v91: Dice_ui::US21 = match &v22 {
                                        Dice_ui::US23::US23_1(v22_1_0) => {
                                            let v85: std::string::String =
                                                Dice_ui::method47((v22_1_0).l0.clone());
                                            Dice_ui::US21::US21_1(
                                                fable_library_rust::String_::fromString(v85),
                                            )
                                        }
                                        _ => Dice_ui::US21::US21_0,
                                    };
                                    if let Dice_ui::US30::US30_1(v73_1_0) = &v73 {
                                        let v92: Dice_ui::US21 = match &v73 {
                                            Dice_ui::US30::US30_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Dice_ui::US21::US21_1(v92_1_0) = &v92 {
                                            let v94: string = Dice_ui::method6(match &v92 {
                                                Dice_ui::US21::US21_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            });
                                            let v96: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v94);
                                            let v98: Result<
                                                crate::model::near::nearblocks::Root,
                                                serde_json::Error,
                                            > = serde_json::from_str(&v96);
                                            let v99 = Dice_ui::method48();
                                            let v101: Result<
                                                crate::model::near::nearblocks::Root,
                                                std::string::String,
                                            > = v98.map_err(|x| v99(x));
                                            let v102 = Dice_ui::method173();
                                            let v103: Result<
                                                crate::model::near::nearblocks::Root,
                                                std::string::String,
                                            > = Dice_ui::method174(v101);
                                            v103.map(|x| v102(x))
                                        } else {
                                            if let Dice_ui::US21::US21_1(v91_1_0) = &v91 {
                                                let v107: string = Dice_ui::method6(match &v91 {
                                                    Dice_ui::US21::US21_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                });
                                                let v109: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v107,
                                                    );
                                                let v111: Result<
                                                    crate::model::near::nearblocks::Root,
                                                    serde_json::Error,
                                                > = serde_json::from_str(&v109);
                                                let v112 = Dice_ui::method48();
                                                let v114: Result<
                                                    crate::model::near::nearblocks::Root,
                                                    std::string::String,
                                                > = v111.map_err(|x| v112(x));
                                                let v115 = Dice_ui::method173();
                                                let v116: Result<
                                                    crate::model::near::nearblocks::Root,
                                                    std::string::String,
                                                > = Dice_ui::method174(v114);
                                                v116.map(|x| v115(x))
                                            } else {
                                                let v121: string =
                                                        Dice_ui::method0(append(append(string("state.use_request (17) / json Error / value: "),
                                                                                       sprintf!("{:?}",
                                                                                                &(v73.clone(),
                                                                                                  v91.clone()))),
                                                                                string("")));
                                                leptos::logging::log!("{}", v121);
                                                Ok(None::<crate::model::near::nearblocks::Root>)
                                            }
                                        }
                                    } else {
                                        if let Dice_ui::US21::US21_1(v91_1_0) = &v91 {
                                            let v128: string = Dice_ui::method6(match &v91 {
                                                Dice_ui::US21::US21_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            });
                                            let v130: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v128);
                                            let v132: Result<
                                                crate::model::near::nearblocks::Root,
                                                serde_json::Error,
                                            > = serde_json::from_str(&v130);
                                            let v133 = Dice_ui::method48();
                                            let v135: Result<
                                                crate::model::near::nearblocks::Root,
                                                std::string::String,
                                            > = v132.map_err(|x| v133(x));
                                            let v136 = Dice_ui::method173();
                                            let v137: Result<
                                                crate::model::near::nearblocks::Root,
                                                std::string::String,
                                            > = Dice_ui::method174(v135);
                                            v137.map(|x| v136(x))
                                        } else {
                                            if let Dice_ui::US30::US30_0(v73_0_0) = &v73 {
                                                let v142: string = Dice_ui::method6(
                                                    Dice_ui::method13(match &v73 {
                                                        Dice_ui::US30::US30_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }),
                                                );
                                                let v144: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v142,
                                                    );
                                                Err(String::from(v144))
                                            } else {
                                                panic!("{}", string("Match failure"),)
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    _ => {
                        let v152: string = Dice_ui::method6(Dice_ui::method171());
                        let v154: &str = fable_library_rust::String_::LrcStr::as_str(&v152);
                        Err(String::from(v154))
                    }
                };
                let v160: string = sprintf!("{:?}", &v159);
                let v167: string = Dice_ui::method0(append(
                    append(
                        string("state.use_request (18) / result create_memo / json_cache_obj: "),
                        (if length(v160.clone()) <= 200_i32 {
                            v160.clone()
                        } else {
                            append(substring2(v160, 0_i32, 200_i32), string("..."))
                        }),
                    ),
                    string(""),
                ));
                leptos::logging::log!("{}", v167);
                v159
            }
        }
        pub fn method170(
            v0_1: leptos::Memo<Option<string>>,
            v1: leptos::Resource<Option<string>, Result<Option<string>, string>>,
            v2: Func0<Option<LrcPtr<Dice_ui::Heap3>>>,
        ) -> Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>
        {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure96(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method176(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> leptos::Resource<Dice_ui::US1, rexie::Rexie> {
            v0_1
        }
        pub fn method177(v0_1: leptos::Signal<bool>) -> leptos::Signal<bool> {
            v0_1
        }
        pub fn method178(
            v0_1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap3>>,
            >,
        ) -> leptos::Resource<(Option<rexie::Rexie>, Option<string>), Option<LrcPtr<Dice_ui::Heap3>>>
        {
            v0_1
        }
        pub fn method179(
            v0_1: Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
        ) -> Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>
        {
            v0_1
        }
        pub fn method181(
            v0_1: Option<crate::model::near::nearblocks::Root>,
        ) -> Option<crate::model::near::nearblocks::Root> {
            v0_1
        }
        pub fn method183(
            v0_1: crate::model::near::nearblocks::Root,
        ) -> crate::model::near::nearblocks::Root {
            v0_1
        }
        pub fn method185(
            v0_1: crate::model::near::nearblocks::Txn,
        ) -> crate::model::near::nearblocks::Txn {
            v0_1
        }
        pub fn method186(
            v0_1: crate::model::near::nearblocks::Block,
        ) -> crate::model::near::nearblocks::Block {
            v0_1
        }
        pub fn method188(
            v0_1: crate::model::near::nearblocks::Action,
        ) -> crate::model::near::nearblocks::Action {
            v0_1
        }
        pub fn closure102(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Action,
        ) -> (std::string::String, Dice_ui::US13) {
            let v1: crate::model::near::nearblocks::Action = Dice_ui::method188(v0_1);
            (
                v1.action,
                defaultValue(
                    Dice_ui::US13::US13_0,
                    map(
                        Func1::new(move |v: std::string::String| Dice_ui::closure30((), v)),
                        v1.method,
                    ),
                ),
            )
        }
        pub fn method187(
        ) -> Func1<crate::model::near::nearblocks::Action, (std::string::String, Dice_ui::US13)>
        {
            Func1::new(move |v: crate::model::near::nearblocks::Action| Dice_ui::closure102((), v))
        }
        pub fn method189(
            v0_1: Vec<(std::string::String, Dice_ui::US13)>,
        ) -> Vec<(std::string::String, Dice_ui::US13)> {
            v0_1
        }
        pub fn method190(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
        ) -> Array<(std::string::String, Dice_ui::US13)> {
            v0_1
        }
        pub fn method191(
            v0_1: crate::model::near::nearblocks::ActionsAgg,
        ) -> crate::model::near::nearblocks::ActionsAgg {
            v0_1
        }
        pub fn method192(
            v0_1: crate::model::near::nearblocks::Outcomes,
        ) -> crate::model::near::nearblocks::Outcomes {
            v0_1
        }
        pub fn method193(
            v0_1: crate::model::near::nearblocks::OutcomesAgg,
        ) -> crate::model::near::nearblocks::OutcomesAgg {
            v0_1
        }
        pub fn method194(v0_1: Array<std::string::String>) -> Array<std::string::String> {
            v0_1
        }
        pub fn closure101(
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
            let v1: crate::model::near::nearblocks::Txn = Dice_ui::method185(v0_1);
            let v3: std::string::String = v1.receipt_id;
            let v5: std::string::String = v1.predecessor_account_id;
            let v7: std::string::String = v1.receiver_account_id;
            let v9: std::string::String = v1.transaction_hash;
            let v11: std::string::String = v1.included_in_block_hash;
            let v13: std::string::String = v1.block_timestamp;
            let v16: crate::model::near::nearblocks::Block = Dice_ui::method186(v1.block);
            let v18: u32 = v16.block_height;
            let v19 = Dice_ui::method187();
            let v22: Vec<(std::string::String, Dice_ui::US13)> =
                Dice_ui::method189(v1.actions.into_iter().map(|x| v19(x)).collect());
            let v25: Array<(std::string::String, Dice_ui::US13)> =
                Dice_ui::method190(fable_library_rust::NativeArray_::array_from(v22));
            let v28: crate::model::near::nearblocks::ActionsAgg =
                Dice_ui::method191(v1.actions_agg);
            let v30: u64 = v28.deposit;
            let v33: crate::model::near::nearblocks::Outcomes = Dice_ui::method192(v1.outcomes);
            let v35: bool = v33.status;
            let v38: crate::model::near::nearblocks::OutcomesAgg =
                Dice_ui::method193(v1.outcomes_agg);
            let v40: f64 = v38.transaction_fee;
            let v43: Vec<std::string::String> = Dice_ui::method23(v1.logs);
            (
                v25,
                v30,
                v18,
                v13,
                v11,
                Dice_ui::method194(fable_library_rust::NativeArray_::array_from(v43)),
                v35,
                v40,
                v5,
                v3,
                v7,
                v9,
            )
        }
        pub fn method184() -> Func1<
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
            Func1::new(move |v: crate::model::near::nearblocks::Txn| Dice_ui::closure101((), v))
        }
        pub fn method195(
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
        pub fn method196(
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
        pub fn closure100(
            unitVar: (),
            v0_1: crate::model::near::nearblocks::Root,
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
            let v1: crate::model::near::nearblocks::Root = Dice_ui::method183(v0_1);
            let v2 = Dice_ui::method184();
            let v5: Vec<(
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
            )> = Dice_ui::method195(v1.txns.into_iter().map(|x| v2(x)).collect());
            Dice_ui::method196(fable_library_rust::NativeArray_::array_from(v5))
        }
        pub fn method182() -> Func1<
            crate::model::near::nearblocks::Root,
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
        > {
            Func1::new(move |v: crate::model::near::nearblocks::Root| Dice_ui::closure100((), v))
        }
        pub fn closure99(
            unitVar: (),
            v0_1: Option<crate::model::near::nearblocks::Root>,
        ) -> Option<
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
        > {
            let v1: Option<crate::model::near::nearblocks::Root> = Dice_ui::method181(v0_1);
            let v2 = Dice_ui::method182();
            v1.map(|x| v2(x))
        }
        pub fn method180() -> Func1<
            Option<crate::model::near::nearblocks::Root>,
            Option<
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
            >,
        > {
            Func1::new(move |v: Option<crate::model::near::nearblocks::Root>| {
                Dice_ui::closure99((), v)
            })
        }
        pub fn method197(
            v0_1: Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
        ) -> Result<Option<crate::model::near::nearblocks::Root>, std::string::String> {
            v0_1
        }
        pub fn closure98(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            v1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap3>>,
            >,
            v2: Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
            unitVar: (),
        ) -> Result<
            Option<
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
            >,
            std::string::String,
        > {
            let v3: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method176(v0_1.clone());
            let v6: leptos::Signal<bool> = Dice_ui::method177(leptos::Resource::loading(&v3));
            let v8: bool = leptos::SignalGet::get(&v6);
            let v9: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap3>>,
            > = Dice_ui::method178(v1.clone());
            let v12: leptos::Signal<bool> = Dice_ui::method177(leptos::Resource::loading(&v9));
            let v14: bool = leptos::SignalGet::get(&v12);
            let v15: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method19(v0_1);
            let v20: Dice_ui::US4 = defaultValue(
                Dice_ui::US4::US4_0,
                map(
                    Func1::new(move |v: rexie::Rexie| Dice_ui::closure12((), v)),
                    leptos::SignalGet::get(&v15),
                ),
            );
            let v21: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap3>>,
            > = Dice_ui::method163(v1);
            let v26: Dice_ui::US25 = defaultValue(
                Dice_ui::US25::US25_0,
                map(
                    Func1::new(move |v_1: Option<LrcPtr<Dice_ui::Heap3>>| {
                        Dice_ui::closure89((), v_1)
                    }),
                    leptos::SignalGet::get(&v21),
                ),
            );
            let v34: Dice_ui::US26 = match &v26 {
                Dice_ui::US25::US25_1(v26_1_0) => Dice_ui::US26::US26_1(defaultValue(
                    Dice_ui::US23::US23_0,
                    map(
                        Func1::new(move |v_2: LrcPtr<Dice_ui::Heap3>| Dice_ui::closure90((), v_2)),
                        v26_1_0.clone(),
                    ),
                )),
                _ => Dice_ui::US26::US26_0,
            };
            let v41: Dice_ui::US23 = if let Dice_ui::US26::US26_1(v34_1_0) = &v34 {
                let v35: Dice_ui::US23 = match &v34 {
                    Dice_ui::US26::US26_1(x) => x.clone(),
                    _ => unreachable!(),
                };
                if let Dice_ui::US23::US23_1(v35_1_0) = &v35 {
                    Dice_ui::US23::US23_1(match &v35 {
                        Dice_ui::US23::US23_1(x) => x.clone(),
                        _ => unreachable!(),
                    })
                } else {
                    Dice_ui::US23::US23_0
                }
            } else {
                Dice_ui::US23::US23_0
            };
            let v42: string = sprintf!("{:?}", &v20);
            let v47: string = if length(v42.clone()) <= 200_i32 {
                v42.clone()
            } else {
                append(substring2(v42, 0_i32, 200_i32), string("..."))
            };
            let v48: string = sprintf!("{:?}", &v41);
            let v53: string = if length(v48.clone()) <= 200_i32 {
                v48.clone()
            } else {
                append(substring2(v48, 0_i32, 200_i32), string("..."))
            };
            let v55: string = Dice_ui::method0(append(
                append(
                    append(
                        append(
                            append(
                                append(
                                    append(
                                        append(
                                            string(
                                                "state.use_request (19) / result move / database: ",
                                            ),
                                            v47,
                                        ),
                                        string(" / database_loading: "),
                                    ),
                                    ofBoolean(v8),
                                ),
                                string(" / state_data: "),
                            ),
                            v53,
                        ),
                        string(" / state_data_loading: "),
                    ),
                    ofBoolean(v14),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v55);
            {
                let v57: Func0<
                    Result<Option<crate::model::near::nearblocks::Root>, std::string::String>,
                > = Dice_ui::method179(v2);
                let v59: Result<Option<crate::model::near::nearblocks::Root>, std::string::String> =
                    (move || v57())();
                let v60 = Dice_ui::method180();
                let v61: Result<Option<crate::model::near::nearblocks::Root>, std::string::String> =
                    Dice_ui::method197(v59);
                let v63: Result<
                    Option<
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
                    >,
                    std::string::String,
                > = v61.map(|x| v60(x));
                let v64: string = sprintf!("{:?}", &v63);
                let v71: string = Dice_ui::method0(append(
                    append(
                        string("state.use_request (20) / result move / result: "),
                        (if length(v64.clone()) <= 200_i32 {
                            v64.clone()
                        } else {
                            append(substring2(v64, 0_i32, 200_i32), string("..."))
                        }),
                    ),
                    string(""),
                ));
                leptos::logging::log!("{}", v71);
                v63
            }
        }
        pub fn method175(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            v1: leptos::Resource<
                (Option<rexie::Rexie>, Option<string>),
                Option<LrcPtr<Dice_ui::Heap3>>,
            >,
            v2: Func0<Result<Option<crate::model::near::nearblocks::Root>, std::string::String>>,
        ) -> Func0<
            Result<
                Option<
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
                >,
                std::string::String,
            >,
        > {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Dice_ui::closure98(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method199(
            v0_1: Func0<
                Result<
                    Option<
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
                    >,
                    std::string::String,
                >,
            >,
        ) -> Func0<
            Result<
                Option<
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
                >,
                std::string::String,
            >,
        > {
            v0_1
        }
        pub fn closure104(
            unitVar: (),
            v0_1: Option<
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
            >,
        ) -> Dice_ui::US34 {
            Dice_ui::US34::US34_1(v0_1)
        }
        pub fn closure105(unitVar: (), v0_1: std::string::String) -> Dice_ui::US34 {
            Dice_ui::US34::US34_0(v0_1)
        }
        pub fn closure106(
            unitVar: (),
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
        ) -> Dice_ui::US35 {
            Dice_ui::US35::US35_1(v0_1)
        }
        pub fn method200(
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
        pub fn method201(
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
        pub fn closure107(
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
        pub fn method202() -> Func1<
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
                    Dice_ui::closure107((), tupledArg.0.clone(), tupledArg.1.clone())
                },
            )
        }
        pub fn method203(
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
        pub fn method204(
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
        pub fn closure108(
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
        ) -> (usize, LrcPtr<Dice_ui::Heap4>) {
            (
                _arg.0.clone(),
                LrcPtr::new(Dice_ui::Heap4 {
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
        pub fn method205() -> Func1<
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
            (usize, LrcPtr<Dice_ui::Heap4>),
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
                )| Dice_ui::closure108((), arg10_0040),
            )
        }
        pub fn method206(
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
        pub fn method207(
            v0_1: Vec<(usize, LrcPtr<Dice_ui::Heap4>)>,
        ) -> Vec<(usize, LrcPtr<Dice_ui::Heap4>)> {
            v0_1
        }
        pub fn closure103(
            v0_1: Func0<
                Result<
                    Option<
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
                    >,
                    std::string::String,
                >,
            >,
            unitVar: (),
        ) -> Dice_ui::US32 {
            let v1: Func0<
                Result<
                    Option<
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
                    >,
                    std::string::String,
                >,
            > = Dice_ui::method199(v0_1);
            let v3: Result<
                Option<
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
                >,
                std::string::String,
            > = v1();
            let v6: Dice_ui::US34 = match &v3 {
                Err(v3_1_0) => Dice_ui::closure105((), v3_1_0.clone()),
                Ok(v3_0_0) => Dice_ui::closure104((), v3_0_0.clone()),
            };
            let v46: Dice_ui::US32 = match &v6 {
                Dice_ui::US34::US34_1(v6_1_0) => {
                    let v10: Dice_ui::US35 = defaultValue(
                        Dice_ui::US35::US35_0,
                        map(
                            Func1::new(
                                move |v_2: Array<(
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
                                )>| Dice_ui::closure106((), v_2),
                            ),
                            v6_1_0.clone(),
                        ),
                    );
                    Dice_ui::US32::US32_1(match &v10 {
                        Dice_ui::US35::US35_1(v10_1_0) => {
                            let v12: Array<(
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
                            )> = Dice_ui::method200(v10_1_0.clone());
                            let v14: Vec<(
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
                            )> = v12.to_vec();
                            let v17: Vec<
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
                            > = Dice_ui::method201(
                                v14.into_iter().enumerate().map(std::rc::Rc::new).collect(),
                            );
                            let v19: Array<
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
                            > = fable_library_rust::NativeArray_::array_from(v17);
                            let v20 = Dice_ui::method202();
                            let v21: Array<
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
                            > = Dice_ui::method203(v19);
                            let v23: Vec<
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
                            > = v21.to_vec();
                            let v26: Vec<(
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
                            )> = Dice_ui::method204(v23.iter().map(|x| v20(x.clone())).collect());
                            let v28: Array<(
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
                            )> = fable_library_rust::NativeArray_::array_from(v26);
                            let v29 = Dice_ui::method205();
                            let v30: Array<(
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
                            )> = Dice_ui::method206(v28);
                            let v32: Vec<(
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
                            )> = v30.to_vec();
                            let v35: Vec<(usize, LrcPtr<Dice_ui::Heap4>)> =
                                Dice_ui::method207(v32.iter().map(|x| v29(x.clone())).collect());
                            Dice_ui::US33::US33_1(fable_library_rust::NativeArray_::array_from(v35))
                        }
                        _ => Dice_ui::US33::US33_0,
                    })
                }
                Dice_ui::US34::US34_0(v6_0_0) => Dice_ui::US32::US32_0(v6_0_0.clone()),
            };
            let v49: string = Dice_ui::method0(append(
                append(
                    string("transactions.render () / txns move / result length: "),
                    toString(length(sprintf!("{:?}", &v46))),
                ),
                string(""),
            ));
            leptos::logging::log!("{}", v49);
            v46
        }
        pub fn method198(
            v0_1: Func0<
                Result<
                    Option<
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
                    >,
                    std::string::String,
                >,
            >,
        ) -> Func0<Dice_ui::US32> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure103(v0_1.clone(), ())
            })
        }
        pub fn method208() -> string {
            string("Transactions")
        }
        pub fn method210(v0_1: Func0<Dice_ui::US32>) -> Func0<Dice_ui::US32> {
            v0_1
        }
        pub fn method213(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> leptos::HtmlElement<leptos::svg::Svg> {
            v0_1
        }
        pub fn closure111(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" height=\"100%\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"text-red-700\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M6 18L18 6M6 6l12 12\" /></svg>");
            let v1: string = append(append(string("leptos::view! { "), v0_1), string(" }"));
            let v4: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method213(
                leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" height="100%" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="text-red-700"><path stroke-linecap="round" stroke-linejoin="round" d="M6 18L18 6M6 6l12 12" /></svg> },
            );
            let v9: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                leptos::IntoView::into_view(v4),
            ])));
            let v11: Vec<leptos::View> = v9.to_vec();
            leptos::Fragment::new(v11)
        }
        pub fn method212() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure111((), ()))
        }
        pub fn method214(
            v0_1: leptos::HtmlElement<leptos::html::Span>,
        ) -> leptos::HtmlElement<leptos::html::Span> {
            v0_1
        }
        pub fn closure112(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method47(v0_1);
            let v6: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(
                fable_library_rust::String_::fromString(v1),
            )));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method215(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure112(v0_1.clone(), ())
            })
        }
        pub fn closure110(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"[height:20px]\"");
            let v6 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method212()));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<span "), v4), string(">{v6()}</")),
                            string("span"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Span> =
                Dice_ui::method214(leptos::view! { <span  class="[height:20px]">{v6()}</span> });
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"[overflow-y:auto]\"");
            let v19 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method215(v0_1)));
            let v22: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v17), string(">{v19()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v25: leptos::HtmlElement<leptos::html::Pre> =
                Dice_ui::method147(leptos::view! { <pre  class="[overflow-y:auto]">{v19()}</pre> });
            let v30: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                v14,
                leptos::IntoView::into_view(v25),
            ])));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method211(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure110(v0_1.clone(), ())
            })
        }
        pub fn method217(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap4>)>,
        ) -> Array<(usize, LrcPtr<Dice_ui::Heap4>)> {
            v0_1
        }
        pub fn closure114(
            unitVar: (),
            _arg: (usize, LrcPtr<Dice_ui::Heap4>),
        ) -> std::string::String {
            (_arg.1.clone()).l11.clone()
        }
        pub fn method218() -> Func1<(usize, LrcPtr<Dice_ui::Heap4>), std::string::String> {
            Func1::new(move |arg10_0040: (usize, LrcPtr<Dice_ui::Heap4>)| {
                Dice_ui::closure114((), arg10_0040)
            })
        }
        pub fn closure117(v0_1: i64, unitVar: ()) -> leptos::Fragment {
            let v4: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(append(
                append(string("Transaction "), toString(v0_1 + 1_i64)),
                string(""),
            ))));
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: leptos::leptos_dom::Text = leptos::html::text(v8);
            let v12: leptos::View = leptos::IntoView::into_view(v10);
            leptos::Fragment::new(vec![v12])
        }
        pub fn method221(v0_1: i64) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure117(v0_1, ())
            })
        }
        pub fn closure118(v0_1: Func0<leptos::Fragment>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method117(v0_1);
            let v4: Func0<leptos::Fragment> = Dice_ui::method118(Func0::new(move || v1()));
            let v6: leptos::View = leptos::IntoView::into_view(move || v4());
            leptos::Fragment::new(vec![v6])
        }
        pub fn method222(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure118(v0_1.clone(), ())
            })
        }
        pub fn method225() -> string {
            string("Block Timestamp")
        }
        pub fn closure120(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method225()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method224() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure120((), ()))
        }
        pub fn method227(v0_1: i64) -> i64 {
            v0_1
        }
        pub fn closure122(unitVar: (), v0_1: chrono::NaiveDateTime) -> Dice_ui::US36 {
            Dice_ui::US36::US36_1(v0_1)
        }
        pub fn method228(v0_1: chrono::NaiveDateTime) -> chrono::NaiveDateTime {
            v0_1
        }
        pub fn method229(v0_1: chrono::DateTime<chrono::Local>) -> chrono::DateTime<chrono::Local> {
            v0_1
        }
        pub fn closure121(
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
            let v14: i64 = Dice_ui::method227(v3.parse().unwrap());
            let v19: Dice_ui::US36 = defaultValue(
                Dice_ui::US36::US36_0,
                map(
                    Func1::new(move |v: chrono::NaiveDateTime| Dice_ui::closure122((), v)),
                    chrono::NaiveDateTime::from_timestamp_micros(v14 / 1000i64),
                ),
            );
            let v36: Dice_ui::US21 = match &v19 {
                Dice_ui::US36::US36_1(v19_1_0) => {
                    let v21: chrono::NaiveDateTime = Dice_ui::method228(v19_1_0.clone());
                    let v23: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v21);
                    let v25: string = string("r#\"%Y-%m-%d %H:%M:%S\"#");
                    let v26: &str = r#"%Y-%m-%d %H:%M:%S"#;
                    let v27: chrono::DateTime<chrono::Local> = Dice_ui::method229(v23);
                    let v30: std::string::String = Dice_ui::method47(v27.format(v26).to_string());
                    Dice_ui::US21::US21_1(fable_library_rust::String_::fromString(v30))
                }
                _ => Dice_ui::US21::US21_0,
            };
            let v42: Dice_ui::US37 = match &v36 {
                Dice_ui::US21::US21_1(v36_1_0) => Dice_ui::US37::US37_1(v36_1_0.clone()),
                _ => Dice_ui::US37::US37_0(string("Option does not have a value.")),
            };
            let v50: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(match &v42 {
                Dice_ui::US37::US37_1(v42_1_0) => v42_1_0.clone(),
                Dice_ui::US37::US37_0(v42_0_0) => {
                    append(append(string("Error: "), v42_0_0.clone()), string(""))
                }
            })));
            let v52: &str = fable_library_rust::String_::LrcStr::as_str(&v50);
            let v54: std::string::String = String::from(v52);
            let v56: leptos::leptos_dom::Text = leptos::html::text(v54);
            let v58: leptos::View = leptos::IntoView::into_view(v56);
            leptos::Fragment::new(vec![v58])
        }
        pub fn method226(
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
                    Dice_ui::closure121(
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
        pub fn method231() -> string {
            string("Predecessor")
        }
        pub fn closure123(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method231()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method230() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure123((), ()))
        }
        pub fn closure124(
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
            let v12: std::string::String = Dice_ui::method47(v8);
            let v17: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            leptos::Fragment::new(vec![v25])
        }
        pub fn method232(
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
                    Dice_ui::closure124(
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
        pub fn method234() -> string {
            string("Receiver")
        }
        pub fn closure125(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method234()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method233() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure125((), ()))
        }
        pub fn closure126(
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
            let v12: std::string::String = Dice_ui::method47(v10);
            let v17: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            leptos::Fragment::new(vec![v25])
        }
        pub fn method235(
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
                    Dice_ui::closure126(
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
        pub fn method237() -> string {
            string("Actions")
        }
        pub fn closure127(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method237()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method236() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure127((), ()))
        }
        pub fn closure130(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method47(v0_1);
            let v3: string = fable_library_rust::String_::fromString(v1);
            let v15: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(
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
        pub fn method240(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure130(v0_1.clone(), ())
            })
        }
        pub fn method244() -> string {
            string("Method")
        }
        pub fn closure133(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method244()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method243() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure133((), ()))
        }
        pub fn method246() -> string {
            string("None")
        }
        pub fn closure134(v0_1: Dice_ui::US13, unitVar: ()) -> leptos::Fragment {
            match &v0_1 {
                Dice_ui::US13::US13_1(v0_1_1_0) => {
                    let v2: std::string::String = Dice_ui::method47(v0_1_1_0.clone());
                    let v7: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(
                        fable_library_rust::String_::fromString(v2),
                    )));
                    let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
                    let v11: std::string::String = String::from(v9);
                    let v13: leptos::leptos_dom::Text = leptos::html::text(v11);
                    let v15: leptos::View = leptos::IntoView::into_view(v13);
                    leptos::Fragment::new(vec![v15])
                }
                _ => {
                    let v20: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method246()));
                    let v22: &str = fable_library_rust::String_::LrcStr::as_str(&v20);
                    let v24: std::string::String = String::from(v22);
                    let v26: leptos::leptos_dom::Text = leptos::html::text(v24);
                    let v28: leptos::View = leptos::IntoView::into_view(v26);
                    leptos::Fragment::new(vec![v28])
                }
            }
        }
        pub fn method245(v0_1: Dice_ui::US13) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure134(v0_1.clone(), ())
            })
        }
        pub fn closure132(v0_1: Dice_ui::US13, unitVar: ()) -> leptos::Fragment {
            let v8: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  \"");
            let v10 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method243(),
                Dice_ui::method245(v0_1),
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
            let v16: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  ">{v10()}</div> },
            );
            let v21: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method242(v0_1: Dice_ui::US13) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure132(v0_1.clone(), ())
            })
        }
        pub fn closure131(v0_1: Dice_ui::US13, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 flex-col\"");
            let v6 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method242(v0_1)));
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
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="flex flex-1 flex-col">{v6()}</div> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method241(v0_1: Dice_ui::US13) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure131(v0_1.clone(), ())
            })
        }
        pub fn closure129(
            unitVar: (),
            _arg: (std::string::String, Dice_ui::US13),
        ) -> leptos::HtmlElement<leptos::html::Div> {
            let v9: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%]  items-center \"");
            let v11 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method240(_arg.0.clone()),
                Dice_ui::method241(_arg.1.clone()),
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
        pub fn method239(
        ) -> Func1<(std::string::String, Dice_ui::US13), leptos::HtmlElement<leptos::html::Div>>
        {
            Func1::new(move |arg10_0040: (std::string::String, Dice_ui::US13)| {
                Dice_ui::closure129((), arg10_0040)
            })
        }
        pub fn method247(
            v0_1: Array<(std::string::String, Dice_ui::US13)>,
        ) -> Array<(std::string::String, Dice_ui::US13)> {
            v0_1
        }
        pub fn method248(
            v0_1: Vec<leptos::HtmlElement<leptos::html::Div>>,
        ) -> Vec<leptos::HtmlElement<leptos::html::Div>> {
            v0_1
        }
        pub fn closure128(
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
            let v12 = Dice_ui::method239();
            let v13: Array<(std::string::String, Dice_ui::US13)> = Dice_ui::method247(v0_1);
            let v15: Vec<(std::string::String, Dice_ui::US13)> = v13.to_vec();
            let v18: Vec<leptos::HtmlElement<leptos::html::Div>> =
                Dice_ui::method248(v15.iter().map(|x| v12(x.clone())).collect());
            let v20: Array<leptos::HtmlElement<leptos::html::Div>> =
                fable_library_rust::NativeArray_::array_from(v18);
            let v21 = Dice_ui::method131();
            let v22: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method133(v20);
            let v24: Vec<leptos::HtmlElement<leptos::html::Div>> = v22.to_vec();
            let v27: Vec<leptos::View> =
                Dice_ui::method134(v24.iter().map(|x| v21(x.clone())).collect());
            let v30: Array<leptos::View> =
                Dice_ui::method122(fable_library_rust::NativeArray_::array_from(v27));
            let v32: Vec<leptos::View> = v30.to_vec();
            leptos::Fragment::new(v32)
        }
        pub fn method238(
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
                    Dice_ui::closure128(
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
            string("Deposit")
        }
        pub fn closure135(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method250()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method249() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure135((), ()))
        }
        pub fn closure136(
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
            let v15: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(toString(v1))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            leptos::Fragment::new(vec![v23])
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
                    Dice_ui::closure136(
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
        pub fn method253() -> string {
            string("Outcome Status")
        }
        pub fn closure137(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method253()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method252() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure137((), ()))
        }
        pub fn closure138(
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
                Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(ofBoolean(v6))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            leptos::Fragment::new(vec![v23])
        }
        pub fn method254(
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
                    Dice_ui::closure138(
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
        pub fn method256() -> string {
            string("Fee")
        }
        pub fn closure139(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method256()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method255() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure139((), ()))
        }
        pub fn closure140(
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
            let v15: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(toString(v7))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            leptos::Fragment::new(vec![v23])
        }
        pub fn method257(
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
                    Dice_ui::closure140(
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
        pub fn method259() -> string {
            string("Block Height")
        }
        pub fn closure141(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method259()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method258() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure141((), ()))
        }
        pub fn closure142(
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
            let v15: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(toString(v2))));
            let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
            let v19: std::string::String = String::from(v17);
            let v21: leptos::leptos_dom::Text = leptos::html::text(v19);
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            leptos::Fragment::new(vec![v23])
        }
        pub fn method260(
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
                    Dice_ui::closure142(
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
        pub fn method262() -> string {
            string("Hash")
        }
        pub fn closure143(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method262()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method261() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure143((), ()))
        }
        pub fn closure144(
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
            let v12: std::string::String = Dice_ui::method47(v11);
            let v17: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            leptos::Fragment::new(vec![v25])
        }
        pub fn method263(
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
                    Dice_ui::closure144(
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
        pub fn method265() -> string {
            string("Block Hash")
        }
        pub fn closure145(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method265()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method264() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure145((), ()))
        }
        pub fn closure146(
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
            let v12: std::string::String = Dice_ui::method47(v4);
            let v17: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            leptos::Fragment::new(vec![v25])
        }
        pub fn method266(
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
                    Dice_ui::closure146(
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
        pub fn method268() -> string {
            string("Receipt ID")
        }
        pub fn closure147(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method268()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method267() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure147((), ()))
        }
        pub fn closure148(
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
            let v12: std::string::String = Dice_ui::method47(v9);
            let v17: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(
                fable_library_rust::String_::fromString(v12),
            )));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            leptos::Fragment::new(vec![v25])
        }
        pub fn method269(
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
                    Dice_ui::closure148(
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
        pub fn method271() -> string {
            string("Logs")
        }
        pub fn closure149(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method271()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method270() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure149((), ()))
        }
        pub fn closure151(unitVar: (), v0_1: std::string::String) -> string {
            let v1: std::string::String = Dice_ui::method47(v0_1);
            fable_library_rust::String_::fromString(v1)
        }
        pub fn method273() -> Func1<std::string::String, string> {
            Func1::new(move |v: std::string::String| Dice_ui::closure151((), v))
        }
        pub fn method274(v0_1: Array<std::string::String>) -> Array<std::string::String> {
            v0_1
        }
        pub fn method275(v0_1: Vec<string>) -> Vec<string> {
            v0_1
        }
        pub fn closure152(v0_1: string, unitVar: ()) -> leptos::Fragment {
            let v3: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(v0_1)));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: leptos::leptos_dom::Text = leptos::html::text(v7);
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method276(v0_1: string) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure152(v0_1.clone(), ())
            })
        }
        pub fn closure150(
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
            let v12 = Dice_ui::method273();
            let v13: Array<std::string::String> = Dice_ui::method274(v5);
            let v15: Vec<std::string::String> = v13.to_vec();
            let v18: Vec<string> = Dice_ui::method275(v15.iter().map(|x| v12(x.clone())).collect());
            let v29: string =
                string(" class=\"[padding:1px] [font-size:11px] [line-height:11px] [text-wrap:pretty] [max-height:20vh]\"");
            let v31 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method276(replace(
                join(
                    string("\n"),
                    toArray(ofArray(fable_library_rust::NativeArray_::array_from(v18))),
                ),
                string("\\n"),
                string("\n"),
            ))));
            let v34: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v29), string(">{v31()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v37: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method147(
                leptos::view! { <pre  class="[padding:1px] [font-size:11px] [line-height:11px] [text-wrap:pretty] [max-height:20vh]">{v31()}</pre> },
            );
            let v39: leptos::View = leptos::IntoView::into_view(v37);
            leptos::Fragment::new(vec![v39])
        }
        pub fn method272(
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
                    Dice_ui::closure150(
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
        pub fn closure119(
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
            let v20: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v22 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method224(),
                Dice_ui::method226(
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
            let v25: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v20), string(">{v22()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v28: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v22()}</div> },
            );
            let v30: leptos::View = leptos::IntoView::into_view(v28);
            let v36: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v38 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method230(),
                Dice_ui::method232(
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
            let v40: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v36), string(">{v38()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v43: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v38()}</div> },
            );
            let v45: leptos::View = leptos::IntoView::into_view(v43);
            let v51: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v53 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method233(),
                Dice_ui::method235(
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
            let v55: string = append(
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
            let v58: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v53()}</div> },
            );
            let v60: leptos::View = leptos::IntoView::into_view(v58);
            let v67: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] sm:pr-[10px] items-center py-[4px]\"");
            let v69 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method236(),
                Dice_ui::method238(
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
            let v71: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v67), string(">{v69()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v74: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] sm:pr-[10px] items-center py-[4px]">{v69()}</div> },
            );
            let v76: leptos::View = leptos::IntoView::into_view(v74);
            let v82: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v84 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method249(),
                Dice_ui::method251(
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
            let v86: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v82), string(">{v84()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v89: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v84()}</div> },
            );
            let v91: leptos::View = leptos::IntoView::into_view(v89);
            let v97: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v99 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method252(),
                Dice_ui::method254(
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
            let v101: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v97), string(">{v99()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v104: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v99()}</div> },
            );
            let v106: leptos::View = leptos::IntoView::into_view(v104);
            let v112: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v114 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method255(),
                Dice_ui::method257(
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
            let v116: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v112), string(">{v114()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v119: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v114()}</div> },
            );
            let v121: leptos::View = leptos::IntoView::into_view(v119);
            let v127: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v129 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method258(),
                Dice_ui::method260(
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
            let v131: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v127), string(">{v129()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v134: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v129()}</div> },
            );
            let v136: leptos::View = leptos::IntoView::into_view(v134);
            let v142: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v144 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method261(),
                Dice_ui::method263(
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
            let v146: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v142), string(">{v144()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v149: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v144()}</div> },
            );
            let v151: leptos::View = leptos::IntoView::into_view(v149);
            let v157: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v159 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method264(),
                Dice_ui::method266(
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
            let v161: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v157), string(">{v159()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v164: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v159()}</div> },
            );
            let v166: leptos::View = leptos::IntoView::into_view(v164);
            let v172: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
            let v174 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method267(),
                Dice_ui::method269(
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
            let v176: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v172), string(">{v174()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v179: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v174()}</div> },
            );
            let v208: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                v30,
                v45,
                v60,
                v76,
                v91,
                v106,
                v121,
                v136,
                v151,
                v166,
                leptos::IntoView::into_view(v179),
                if count(v5.clone()) as u64 == 0_u64 {
                    let v187: Array<leptos::View> =
                        Dice_ui::method149(Dice_ui::method148(Dice_ui::method121(new_empty::<
                            leptos::View,
                        >(
                        ))));
                    leptos::CollectView::collect_view(v187.to_vec())
                } else {
                    let v195:
                                                                              string =
                                                                          string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]\"");
                    let v197 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                        Dice_ui::method270(),
                        Dice_ui::method272(v0_1, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11),
                    )));
                    let v199: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<div "), v195), string(">{v197()}</")),
                                    string("div"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v202: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                        leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]  items-center py-[4px]">{v197()}</div> },
                    );
                    leptos::IntoView::into_view(v202)
                },
            ])));
            let v210: Vec<leptos::View> = v208.to_vec();
            leptos::Fragment::new(v210)
        }
        pub fn method223(
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
                    Dice_ui::closure119(
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
        pub fn closure116(
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
            unitVar: (),
        ) -> leptos::Fragment {
            let v14 = Dice_ui::method222(Dice_ui::method221(v0_1));
            let v15: string =
                string("<span class=\"flex items-center pb-[6px]\"><span class=\"pr-[15px] [font-size:14px]\">{v14()}</span><span class=\"h-px flex-1 bg-gray-300\"></span></span>");
            let v16: string = append(append(string("leptos::view! { "), v15), string(" }"));
            let v19: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method214(
                leptos::view! { <span class="flex items-center pb-[6px]"><span class="pr-[15px] [font-size:14px]">{v14()}</span><span class="h-px flex-1 bg-gray-300"></span></span> },
            );
            let v21: leptos::View = leptos::IntoView::into_view(v19);
            let v25: string = string(" class=\"grid flex-1 divide-y-[1px] divide-gray-500/[.10]\"");
            let v27 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method223(
                v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12,
            )));
            let v30: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v25), string(">{v27()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v33: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="grid flex-1 divide-y-[1px] divide-gray-500/[.10]">{v27()}</div> },
            );
            let v38: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                v21,
                leptos::IntoView::into_view(v33),
            ])));
            let v40: Vec<leptos::View> = v38.to_vec();
            leptos::Fragment::new(v40)
        }
        pub fn method220(
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
                    Dice_ui::closure116(
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
                        (),
                    )
                }
            })
        }
        pub fn closure115(unitVar: (), _arg: (usize, LrcPtr<Dice_ui::Heap4>)) -> leptos::Fragment {
            let v1: LrcPtr<Dice_ui::Heap4> = _arg.1.clone();
            let v14: i64 = _arg.0.clone() as i64;
            let v16: Option<LrcPtr<Dice_ui::Heap1>> = leptos::use_context::<std::rc::Rc<Heap1>>();
            let v18: LrcPtr<Dice_ui::Heap1> = v16.unwrap();
            let v22: string = string(" class=\"flex flex-1 flex-col\"");
            let v24 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method220(
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
            let v30: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="flex flex-1 flex-col">{v24()}</div> },
            );
            let v32: leptos::View = leptos::IntoView::into_view(v30);
            leptos::Fragment::new(vec![v32])
        }
        pub fn method219() -> Func1<(usize, LrcPtr<Dice_ui::Heap4>), leptos::Fragment> {
            Func1::new(move |arg10_0040: (usize, LrcPtr<Dice_ui::Heap4>)| {
                Dice_ui::closure115((), arg10_0040)
            })
        }
        pub fn closure113(
            v0_1: Array<(usize, LrcPtr<Dice_ui::Heap4>)>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: Array<(usize, LrcPtr<Dice_ui::Heap4>)> = Dice_ui::method217(v0_1);
            let v2 = Dice_ui::method218();
            let v3 = Dice_ui::method219();
            let v15: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos::For  children=move |x| v3(x) let:x key=move |x| v2(x.to_owned()) each=move || v1.to_vec() /> })");
            let v16: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos::For  children=move |x| v3(x) let:x key=move |x| v2(x.to_owned()) each=move || v1.to_vec() /> },
            );
            leptos::Fragment::new(vec![v16])
        }
        pub fn method216(v0_1: Array<(usize, LrcPtr<Dice_ui::Heap4>)>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure113(v0_1.clone(), ())
            })
        }
        pub fn closure154(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string =
                string("<svg version=\"1.1\" id=\"Layer_1\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" x=\"0px\" y=\"0px\" width=\"24px\" height=\"30px\" viewBox=\"0 0 24 30\" style=\"enable-background:new 0 0 50 50;\" xml:space=\"preserve\"><rect x=\"0\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\" opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect><rect x=\"8\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\"  opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect><rect x=\"16\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\"  opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect></svg>");
            let v1: string = append(append(string("leptos::view! { "), v0_1), string(" }"));
            let v4: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method213(
                leptos::view! { <svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" width="24px" height="30px" viewBox="0 0 24 30" style="enable-background:new 0 0 50 50;" xml:space="preserve"><rect x="0" y="10" width="4" height="10" fill="#333" opacity="0.2"><animate attributeName="opacity" attributeType="XML" values="0.2; 1; .2" begin="0s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="height" attributeType="XML" values="10; 20; 10" begin="0s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="y" attributeType="XML" values="10; 5; 10" begin="0s" dur="0.6s" repeatCount="indefinite" /></rect><rect x="8" y="10" width="4" height="10" fill="#333"  opacity="0.2"><animate attributeName="opacity" attributeType="XML" values="0.2; 1; .2" begin="0.15s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="height" attributeType="XML" values="10; 20; 10" begin="0.15s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="y" attributeType="XML" values="10; 5; 10" begin="0.15s" dur="0.6s" repeatCount="indefinite" /></rect><rect x="16" y="10" width="4" height="10" fill="#333"  opacity="0.2"><animate attributeName="opacity" attributeType="XML" values="0.2; 1; .2" begin="0.3s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="height" attributeType="XML" values="10; 20; 10" begin="0.3s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="y" attributeType="XML" values="10; 5; 10" begin="0.3s" dur="0.6s" repeatCount="indefinite" /></rect></svg> },
            );
            let v6: leptos::View = leptos::IntoView::into_view(v4);
            let v10: string =
                Dice_ui::method6(Dice_ui::method13(Dice_ui::method146(string("Loading..."))));
            let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
            let v14: std::string::String = String::from(v12);
            let v16: leptos::leptos_dom::Text = leptos::html::text(v14);
            let v21: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                v6,
                leptos::IntoView::into_view(v16),
            ])));
            let v23: Vec<leptos::View> = v21.to_vec();
            leptos::Fragment::new(v23)
        }
        pub fn method278() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure154((), ()))
        }
        pub fn closure153(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v3: string = string(" class=\"flex flex-1 [gap:4px] items-center\"");
            let v5 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method278()));
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
            let v11: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="flex flex-1 [gap:4px] items-center">{v5()}</div> },
            );
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            leptos::Fragment::new(vec![v13])
        }
        pub fn method277() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure153((), ()))
        }
        pub fn closure109(v0_1: Func0<Dice_ui::US32>, unitVar: ()) -> leptos::Fragment {
            let v1: Func0<Dice_ui::US32> = Dice_ui::method210(v0_1);
            let v3: Dice_ui::US32 = v1();
            match &v3 {
                Dice_ui::US32::US32_1(v3_1_0) => {
                    let v4: Dice_ui::US33 = v3_1_0.clone();
                    if let Dice_ui::US33::US33_1(v4_1_0) = &v4 {
                        let v6: string =
                            string("class=\"grid flex-1 py-[10px] px-[12px] [gap:15px] sm:[grid-template-columns:repeat(auto-fill,minmax(500px,1fr))]\"");
                        let v9: string =
                            append(append(append(string(" "), v6), string("")), string(""));
                        let v11 =
                            Dice_ui::method116(Dice_ui::method115(Dice_ui::method216(match &v4 {
                                Dice_ui::US33::US33_1(x) => x.clone(),
                                _ => unreachable!(),
                            })));
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
                        let v17: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                            leptos::view! { <div  class="grid flex-1 py-[10px] px-[12px] [gap:15px] sm:[grid-template-columns:repeat(auto-fill,minmax(500px,1fr))]">{v11()}</div> },
                        );
                        let v19: leptos::View = leptos::IntoView::into_view(v17);
                        leptos::Fragment::new(vec![v19])
                    } else {
                        let v25: string = string(" class=\"grid place-content-center py-[10vh]\"");
                        let v27 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method277()));
                        let v30: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v25), string(">{v27()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v33: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                            leptos::view! { <div  class="grid place-content-center py-[10vh]">{v27()}</div> },
                        );
                        let v35: leptos::View = leptos::IntoView::into_view(v33);
                        leptos::Fragment::new(vec![v35])
                    }
                }
                Dice_ui::US32::US32_0(v3_0_0) => {
                    let v43: string = string(" class=\"flex flex-1 [gap:4px] [padding:5px]\"");
                    let v45 =
                        Dice_ui::method116(Dice_ui::method115(Dice_ui::method211(v3_0_0.clone())));
                    let v48: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<div "), v43), string(">{v45()}</")),
                                    string("div"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v51: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                        leptos::view! { <div  class="flex flex-1 [gap:4px] [padding:5px]">{v45()}</div> },
                    );
                    let v53: leptos::View = leptos::IntoView::into_view(v51);
                    leptos::Fragment::new(vec![v53])
                }
            }
        }
        pub fn method209(v0_1: Func0<Dice_ui::US32>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure109(v0_1.clone(), ())
            })
        }
        pub fn method281() -> string {
            string("Transactions")
        }
        pub fn closure156(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method281()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method280() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure156((), ()))
        }
        pub fn closure157(v0_1: Func0<Dice_ui::US32>, unitVar: ()) -> leptos::Fragment {
            let v1: Func0<Dice_ui::US32> = Dice_ui::method210(v0_1);
            let v3: Dice_ui::US32 = v1();
            let v6: std::string::String = Dice_ui::method47(format!("{:#?}", &v3));
            let v13: string =
                string(" class=\"[padding:1px] [font-size:11px] [line-height:11px] [text-wrap:pretty] [max-height:70vh]\"");
            let v15 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method276(
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
            let v21: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method147(
                leptos::view! { <pre  class="[padding:1px] [font-size:11px] [line-height:11px] [text-wrap:pretty] [max-height:70vh]">{v15()}</pre> },
            );
            let v23: leptos::View = leptos::IntoView::into_view(v21);
            leptos::Fragment::new(vec![v23])
        }
        pub fn method282(v0_1: Func0<Dice_ui::US32>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure157(v0_1.clone(), ())
            })
        }
        pub fn closure155(v0_1: Func0<Dice_ui::US32>, unitVar: ()) -> leptos::Fragment {
            let v9: string =
                string(" class=\"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] \"");
            let v11 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method113(
                Dice_ui::method280(),
                Dice_ui::method282(v0_1),
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
            let v18: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method130(new_array(
                &[
                    leptos::view! { <div  class="grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] sm:grid-cols-[150px_repeat(2,minmax(0,1fr))] pt-[9px] pr-[10px] pb-[9px] pl-[10px] ">{v11()}</div> },
                ],
            ));
            let v19 = Dice_ui::method131();
            let v20: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method133(v18);
            let v22: Vec<leptos::HtmlElement<leptos::html::Div>> = v20.to_vec();
            let v25: Vec<leptos::View> =
                Dice_ui::method134(v22.iter().map(|x| v19(x.clone())).collect());
            let v28: Array<leptos::View> =
                Dice_ui::method122(fable_library_rust::NativeArray_::array_from(v25));
            let v30: Vec<leptos::View> = v28.to_vec();
            leptos::Fragment::new(v30)
        }
        pub fn method279(v0_1: Func0<Dice_ui::US32>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure155(v0_1.clone(), ())
            })
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(string("transactions.render ()"));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap1>> =
                    leptos::use_context::<std::rc::Rc<Heap1>>();
                let v6: LrcPtr<Dice_ui::Heap1> = v4.unwrap();
                let v7 = Dice_ui::method151();
                let v9: leptos::Memo<Option<string>> = leptos::create_memo(move |_| v7());
                let v11: string = Dice_ui::method0(string("state.use_request (1)"));
                leptos::logging::log!("{}", v11);
                {
                    let v14: Option<LrcPtr<Dice_ui::Heap1>> =
                        leptos::use_context::<std::rc::Rc<Heap1>>();
                    let v16: LrcPtr<Dice_ui::Heap1> = v14.unwrap();
                    let v17 = Dice_ui::method152(v9.clone());
                    let v20: leptos::Resource<Option<string>, Result<Option<string>, string>> =
                        leptos::create_local_resource(
                            move || v17(),
                            |x| async move {
                                Func1::new(move |v: Option<string>| Dice_ui::closure80((), v))(x)
                                    .await
                            },
                        );
                    let v22: string = Dice_ui::method0(string("state.use_database (1)"));
                    leptos::logging::log!("{}", v22);
                    {
                        let v24 = Dice_ui::method15();
                        let v27: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                            leptos::create_local_resource(
                                move || v24(),
                                |x| async move {
                                    Func1::new(move |v_1: Dice_ui::US1| Dice_ui::closure7((), v_1))(
                                        x,
                                    )
                                    .await
                                },
                            );
                        let v28 = Dice_ui::method158(v27.clone());
                        let v30: leptos::Memo<Option<rexie::Rexie>> =
                            leptos::create_memo(move |_| v28());
                        let v31 = Dice_ui::method159(v9.clone(), v27.clone());
                        let v34: leptos::Resource<
                            (Option<rexie::Rexie>, Option<string>),
                            Option<LrcPtr<Dice_ui::Heap3>>,
                        > = leptos::create_resource(
                            move || v31(),
                            |x| async move {
                                Func1::new(
                                    move |arg10_0040: (Option<rexie::Rexie>, Option<string>)| {
                                        Dice_ui::closure85((), arg10_0040)
                                    },
                                )(x)
                                .await
                            },
                        );
                        let v35 = Dice_ui::method162(v34.clone());
                        let v37: Func0<Option<LrcPtr<Dice_ui::Heap3>>> = Func0::new(move || v35());
                        let v38 = Dice_ui::method164(v9.clone(), v30);
                        let v41 = Dice_ui::method167(
                            v20.clone(),
                            leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                v38(value.clone())
                            }),
                        );
                        leptos::create_effect(move |_| v41());
                        {
                            let v43 = Dice_ui::method170(v9, v20, v37);
                            let v46 = Dice_ui::method175(v27, v34, Func0::new(move || v43()));
                            let v49 = Dice_ui::method198(Func0::new(move || v46()));
                            let v51: Func0<Dice_ui::US32> = Func0::new(move || v49());
                            let v53: string = Dice_ui::method6(Dice_ui::method208());
                            let v55: &str = fable_library_rust::String_::LrcStr::as_str(&v53);
                            let v57: std::string::String = String::from(v55);
                            let v59 = Dice_ui::method135(Dice_ui::method209(v51.clone()));
                            let v60: string =
                                string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                            let v61: string =
                                append(append(string("leptos::view! { "), v60), string(" }"));
                            let v63: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                            let v64: string =
                                string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v57}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v63}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column]\">{v59()}</div></details>");
                            let v65: string =
                                append(append(string("leptos::view! { "), v64), string(" }"));
                            let v68: leptos::HtmlElement<leptos::html::Details> =
                                Dice_ui::method136(
                                    leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v57}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v63}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column]">{v59()}</div></details> },
                                );
                            let v70: leptos::View = leptos::IntoView::into_view(v68);
                            let v72: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                                Dice_ui::method50(v6.l0.clone());
                            let v76: leptos::RwSignal<bool> = Dice_ui::method66(
                                (leptos::SignalGetUntracked::get_untracked(&v72)).l1.clone(),
                            );
                            let v107: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(
                                new_array(&[
                                    v70,
                                    if leptos::SignalGet::get(&v76) {
                                        let v80: string = Dice_ui::method6(Dice_ui::method137());
                                        let v82: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v80);
                                        let v84: std::string::String = String::from(v82);
                                        let v86 = Dice_ui::method135(Dice_ui::method279(v51));
                                        let v87:
                                                                                              string =
                                                                                          string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                                        let v88: string = append(
                                            append(string("leptos::view! { "), v87),
                                            string(" }"),
                                        );
                                        let v90: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                                        let v91:
                                                                                              string =
                                                                                          string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v84}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v90}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column]\">{v86()}</div></details>");
                                        let v92: string = append(
                                            append(string("leptos::view! { "), v91),
                                            string(" }"),
                                        );
                                        let v95: leptos::HtmlElement<leptos::html::Details> =
                                            Dice_ui::method136(
                                                leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v84}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v90}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column]">{v86()}</div></details> },
                                            );
                                        leptos::IntoView::into_view(v95)
                                    } else {
                                        let v101: Array<leptos::View> =
                                            Dice_ui::method149(Dice_ui::method148(
                                                Dice_ui::method121(new_empty::<leptos::View>()),
                                            ));
                                        leptos::CollectView::collect_view(v101.to_vec())
                                    },
                                ]),
                            ));
                            let v109: Vec<leptos::View> = v107.to_vec();
                            leptos::Fragment::new(v109)
                        }
                    }
                }
            }
        }
        pub fn method150() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure77((), ()))
        }
        pub fn closure52(v0_1: leptos::ReadSignal<Dice_ui::US18>, unitVar: ()) -> leptos::Fragment {
            let v1: leptos::ReadSignal<Dice_ui::US18> = Dice_ui::method100(v0_1);
            let v3: Dice_ui::US18 = leptos::SignalGet::get(&v1);
            let v39: leptos::View = match &v3 {
                Dice_ui::US18::US18_1 => {
                    let v21: string = string(" class=\"flex flex-1 flex-col [overflow-y:auto]\"");
                    let v23 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method101()));
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
                    let v29: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                        leptos::view! { <div  class="flex flex-1 flex-col [overflow-y:auto]">{v23()}</div> },
                    );
                    leptos::IntoView::into_view(v29)
                }
                Dice_ui::US18::US18_2 => {
                    let v7: string = string(" class=\"flex flex-1 flex-col [overflow-y:auto]\"");
                    let v9 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method150()));
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
                    let v15: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                        leptos::view! { <div  class="flex flex-1 flex-col [overflow-y:auto]">{v9()}</div> },
                    );
                    leptos::IntoView::into_view(v15)
                }
                _ => {
                    let v35: Array<leptos::View> =
                        Dice_ui::method149(Dice_ui::method148(Dice_ui::method121(new_empty::<
                            leptos::View,
                        >(
                        ))));
                    leptos::CollectView::collect_view(v35.to_vec())
                }
            };
            leptos::Fragment::new(vec![v39])
        }
        pub fn method99(v0_1: leptos::ReadSignal<Dice_ui::US18>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure52(v0_1.clone(), ())
            })
        }
        pub fn method286() -> string {
            string("Tab")
        }
        pub fn closure160(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method286()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method285() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure160((), ()))
        }
        pub fn closure162(v0_1: leptos::ReadSignal<Dice_ui::US18>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US18> = Dice_ui::method100(v0_1);
            if let Dice_ui::US18::US18_2 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method288(v0_1: leptos::ReadSignal<Dice_ui::US18>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure162(v0_1.clone(), ())
            })
        }
        pub fn closure163(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method281()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method289() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure163((), ()))
        }
        pub fn closure164(v0_1: leptos::ReadSignal<Dice_ui::US18>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US18> = Dice_ui::method100(v0_1);
            if let Dice_ui::US18::US18_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method290(v0_1: leptos::ReadSignal<Dice_ui::US18>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure164(v0_1.clone(), ())
            })
        }
        pub fn method292() -> string {
            string("Settings")
        }
        pub fn closure165(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method292()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method291() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure165((), ()))
        }
        pub fn method293(
            v0_1: Array<leptos::HtmlElement<leptos::html::Option_>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Option_>> {
            v0_1
        }
        pub fn method295(
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::HtmlElement<leptos::html::Option_> {
            v0_1
        }
        pub fn closure166(
            unitVar: (),
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::Option_> = Dice_ui::method295(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method294() -> Func1<leptos::HtmlElement<leptos::html::Option_>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::Option_>| {
                Dice_ui::closure166((), v)
            })
        }
        pub fn method296(
            v0_1: Array<leptos::HtmlElement<leptos::html::Option_>>,
        ) -> Array<leptos::HtmlElement<leptos::html::Option_>> {
            v0_1
        }
        pub fn closure161(
            v0_1: leptos::ReadSignal<Dice_ui::US18>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method288(v0_1.clone());
            let v5: string = string(" select=v1()");
            let v7 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method289()));
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
            let v13 = Dice_ui::method290(v0_1);
            let v16: string = string(" select=v13()");
            let v18 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method291()));
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
                Dice_ui::method293(new_array(&[
                    v12,
                    leptos::view! { <option  select=v13()>{v18()}</option> },
                ]));
            let v25 = Dice_ui::method294();
            let v26: Array<leptos::HtmlElement<leptos::html::Option_>> = Dice_ui::method296(v24);
            let v28: Vec<leptos::HtmlElement<leptos::html::Option_>> = v26.to_vec();
            let v31: Vec<leptos::View> =
                Dice_ui::method134(v28.iter().map(|x| v25(x.clone())).collect());
            let v34: Array<leptos::View> =
                Dice_ui::method122(fable_library_rust::NativeArray_::array_from(v31));
            let v36: Vec<leptos::View> = v34.to_vec();
            leptos::Fragment::new(v36)
        }
        pub fn method287(v0_1: leptos::ReadSignal<Dice_ui::US18>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure161(v0_1.clone(), ())
            })
        }
        pub fn method297(
            v0_1: leptos::HtmlElement<leptos::html::Select>,
        ) -> leptos::HtmlElement<leptos::html::Select> {
            v0_1
        }
        pub fn closure159(
            v0_1: leptos::ReadSignal<Dice_ui::US18>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string(" class=\"sr-only\" for=\"Tab\"");
            let v8 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method285()));
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
            let v14: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method112(
                leptos::view! { <label  class="sr-only" for="Tab">{v8()}</label> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            let v21: string = string(" class=\"w-full rounded-md border-gray-200\" id=\"Tab\"");
            let v23 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method287(v0_1)));
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
            let v29: leptos::HtmlElement<leptos::html::Select> = Dice_ui::method297(
                leptos::view! { <select  class="w-full rounded-md border-gray-200" id="Tab">{v23()}</select> },
            );
            let v34: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                v16,
                leptos::IntoView::into_view(v29),
            ])));
            let v36: Vec<leptos::View> = v34.to_vec();
            leptos::Fragment::new(v36)
        }
        pub fn method284(v0_1: leptos::ReadSignal<Dice_ui::US18>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure159(v0_1.clone(), ())
            })
        }
        pub fn closure170(v0_1: leptos::ReadSignal<Dice_ui::US18>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US18> = Dice_ui::method100(v0_1);
            if let Dice_ui::US18::US18_2 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method301(v0_1: leptos::ReadSignal<Dice_ui::US18>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure170(v0_1.clone(), ())
            })
        }
        pub fn method302(v0_1: Func0<bool>) -> Func0<bool> {
            v0_1
        }
        pub fn closure171(v0_1: Func0<bool>, unitVar: ()) -> &'static str {
            if v0_1() {
                let v3: string = string("r#\"border-grey-200 text-grey-900\"#");
                r#"border-grey-200 text-grey-900"#
            } else {
                let v6: string =
                    string("r#\"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700\"#");
                r#"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700"#
            }
        }
        pub fn method303(v0_1: Func0<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure171(v0_1.clone(), ())
            })
        }
        pub fn closure172(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method213(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v6: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method281()));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v17: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                v3,
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method304(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure172(v0_1.clone(), ())
            })
        }
        pub fn closure173(v0_1: leptos::ReadSignal<Dice_ui::US18>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US18> = Dice_ui::method100(v0_1);
            if let Dice_ui::US18::US18_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method305(v0_1: leptos::ReadSignal<Dice_ui::US18>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure173(v0_1.clone(), ())
            })
        }
        pub fn closure174(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method213(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v6: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method292()));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v17: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                v3,
                leptos::IntoView::into_view(v12),
            ])));
            let v19: Vec<leptos::View> = v17.to_vec();
            leptos::Fragment::new(v19)
        }
        pub fn method306(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure174(v0_1.clone(), ())
            })
        }
        pub fn method307(
            v0_1: Array<leptos::HtmlElement<leptos::html::A>>,
        ) -> Array<leptos::HtmlElement<leptos::html::A>> {
            v0_1
        }
        pub fn method309(
            v0_1: leptos::HtmlElement<leptos::html::A>,
        ) -> leptos::HtmlElement<leptos::html::A> {
            v0_1
        }
        pub fn closure175(unitVar: (), v0_1: leptos::HtmlElement<leptos::html::A>) -> leptos::View {
            let v1: leptos::HtmlElement<leptos::html::A> = Dice_ui::method309(v0_1);
            leptos::IntoView::into_view(v1)
        }
        pub fn method308() -> Func1<leptos::HtmlElement<leptos::html::A>, leptos::View> {
            Func1::new(move |v: leptos::HtmlElement<leptos::html::A>| Dice_ui::closure175((), v))
        }
        pub fn method310(
            v0_1: Array<leptos::HtmlElement<leptos::html::A>>,
        ) -> Array<leptos::HtmlElement<leptos::html::A>> {
            v0_1
        }
        pub fn closure169(
            v0_1: leptos::ReadSignal<Dice_ui::US18>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string = append(v1.clone(), string("#/transactions"));
            let v3: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z\"/></svg>");
            let v4: string = append(append(string("leptos::view! { "), v3), string(" }"));
            let v6: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="h-5 w-5"><path stroke-linecap="round" stroke-linejoin="round" d="M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z"/></svg> };
            let v8: string = Dice_ui::method6(Dice_ui::method13(v2));
            let v10: &str = fable_library_rust::String_::LrcStr::as_str(&v8);
            let v12: std::string::String = String::from(v10);
            let v13 = Dice_ui::method301(v0_1.clone());
            let v14 = Dice_ui::method302(v13.clone());
            let v15 = Dice_ui::method303(v13);
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
            let v25 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method304(v6)));
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
            let v37: string = Dice_ui::method6(Dice_ui::method13(v31));
            let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
            let v41: std::string::String = String::from(v39);
            let v42 = Dice_ui::method305(v0_1);
            let v43 = Dice_ui::method302(v42.clone());
            let v44 = Dice_ui::method303(v42);
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
            let v53 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method306(v35)));
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
            let v59: Array<leptos::HtmlElement<leptos::html::A>> = Dice_ui::method307(new_array(
                &[
                    v30,
                    leptos::view! { <a  aria-current={move || if v43() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium ".to_owned() + v44()} href=v41>{v53()}</a> },
                ],
            ));
            let v60 = Dice_ui::method308();
            let v61: Array<leptos::HtmlElement<leptos::html::A>> = Dice_ui::method310(v59);
            let v63: Vec<leptos::HtmlElement<leptos::html::A>> = v61.to_vec();
            let v66: Vec<leptos::View> =
                Dice_ui::method134(v63.iter().map(|x| v60(x.clone())).collect());
            let v69: Array<leptos::View> =
                Dice_ui::method122(fable_library_rust::NativeArray_::array_from(v66));
            let v71: Vec<leptos::View> = v69.to_vec();
            leptos::Fragment::new(v71)
        }
        pub fn method300(
            v0_1: leptos::ReadSignal<Dice_ui::US18>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure169(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method311(
            v0_1: leptos::HtmlElement<leptos::html::Nav>,
        ) -> leptos::HtmlElement<leptos::html::Nav> {
            v0_1
        }
        pub fn closure168(
            v0_1: leptos::ReadSignal<Dice_ui::US18>,
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
            let v9 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method300(v0_1, v1)));
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
            let v15: leptos::HtmlElement<leptos::html::Nav> = Dice_ui::method311(
                leptos::view! { <nav  aria-label="Tabs" class="-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]">{v9()}</nav> },
            );
            let v17: leptos::View = leptos::IntoView::into_view(v15);
            leptos::Fragment::new(vec![v17])
        }
        pub fn method299(
            v0_1: leptos::ReadSignal<Dice_ui::US18>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure168(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure167(
            v0_1: leptos::ReadSignal<Dice_ui::US18>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"flex flex-1 border-t border-gray-200\"");
            let v7 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method299(v0_1, v1)));
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
            let v13: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="flex flex-1 border-t border-gray-200">{v7()}</div> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method298(
            v0_1: leptos::ReadSignal<Dice_ui::US18>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure167(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure158(
            v0_1: leptos::ReadSignal<Dice_ui::US18>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string = Dice_ui::method0(string("menu_tabs.render ()"));
            leptos::logging::log!("{}", v2);
            {
                let v5: leptos_router::Location = leptos_router::use_location();
                let v6: leptos_router::Location = Dice_ui::method79(v5.clone());
                let v9: leptos::Memo<std::string::String> = Dice_ui::method80(v6.pathname);
                let v12: std::string::String = Dice_ui::method47(v9());
                let v14: string = fable_library_rust::String_::fromString(v12);
                let v15: leptos_router::Location = Dice_ui::method81(v5);
                let v18: leptos::Memo<std::string::String> = Dice_ui::method80(v15.search);
                let v21: std::string::String = Dice_ui::method47(v18());
                let v23: string = fable_library_rust::String_::fromString(v21);
                let v29: string = append(
                    v14,
                    (if v23.clone() == string("") {
                        string("")
                    } else {
                        sprintf!("?{}", &v23)
                    }),
                );
                let v33: string = string(" class=\"hidden\"");
                let v35 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method284(v0_1.clone())));
                let v38: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v33), string(">{v35()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v40: leptos::HtmlElement<leptos::html::Div> =
                    leptos::view! { <div  class="hidden">{v35()}</div> };
                let v43: string =
                    string(" class=\"flex flex-1 [overflow-x:auto] [overflow-y:hidden]\"");
                let v45 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method298(v0_1, v29)));
                let v47: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v43), string(">{v45()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v51: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method130(
                    new_array(&[
                        v40,
                        leptos::view! { <div  class="flex flex-1 [overflow-x:auto] [overflow-y:hidden]">{v45()}</div> },
                    ]),
                );
                let v52 = Dice_ui::method131();
                let v53: Array<leptos::HtmlElement<leptos::html::Div>> = Dice_ui::method133(v51);
                let v55: Vec<leptos::HtmlElement<leptos::html::Div>> = v53.to_vec();
                let v58: Vec<leptos::View> =
                    Dice_ui::method134(v55.iter().map(|x| v52(x.clone())).collect());
                let v61: Array<leptos::View> =
                    Dice_ui::method122(fable_library_rust::NativeArray_::array_from(v58));
                let v63: Vec<leptos::View> = v61.to_vec();
                leptos::Fragment::new(v63)
            }
        }
        pub fn method283(v0_1: leptos::ReadSignal<Dice_ui::US18>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure158(v0_1.clone(), ())
            })
        }
        pub fn closure51(v0_1: leptos::ReadSignal<Dice_ui::US18>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 flex-col [overflow:hidden]\"");
            let v6 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method99(v0_1.clone())));
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
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="flex flex-1 flex-col [overflow:hidden]">{v6()}</div> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string = string(" class=\"flex\"");
            let v19 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method283(v0_1)));
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
                Dice_ui::method132(leptos::view! { <div  class="flex">{v19()}</div> });
            let v29: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                v14,
                leptos::IntoView::into_view(v24),
            ])));
            let v31: Vec<leptos::View> = v29.to_vec();
            leptos::Fragment::new(v31)
        }
        pub fn method98(v0_1: leptos::ReadSignal<Dice_ui::US18>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure51(v0_1.clone(), ())
            })
        }
        pub fn closure50(v0_1: leptos::ReadSignal<Dice_ui::US18>, unitVar: ()) -> leptos::Fragment {
            let v1: string =
                string("class=\"flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100vh] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm\"");
            let v4: string = append(append(append(string(" "), v1), string("")), string(""));
            let v6 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method98(v0_1)));
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
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                leptos::view! { <div  class="flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100vh] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm">{v6()}</div> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method97(v0_1: leptos::ReadSignal<Dice_ui::US18>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure50(v0_1.clone(), ())
            })
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(string("content.render ()"));
            leptos::logging::log!("{}", v1);
            {
                let v4: leptos_router::Location = leptos_router::use_location();
                let v6: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)> =
                    std::sync::Arc::new(leptos_router::use_navigate());
                let v8: leptos_router::Location = leptos_router::use_location();
                let v9: leptos_router::Location = Dice_ui::method79(v8.clone());
                let v12: leptos::Memo<std::string::String> = Dice_ui::method80(v9.pathname);
                let v15: std::string::String = Dice_ui::method47(v12());
                let v17: string = fable_library_rust::String_::fromString(v15);
                let v18: leptos_router::Location = Dice_ui::method81(v8);
                let v21: leptos::Memo<std::string::String> = Dice_ui::method80(v18.search);
                let v24: std::string::String = Dice_ui::method47(v21());
                let v26: string = fable_library_rust::String_::fromString(v24);
                let v32: string = append(
                    v17,
                    (if v26.clone() == string("") {
                        string("")
                    } else {
                        sprintf!("?{}", &v26)
                    }),
                );
                let v34: Option<LrcPtr<Dice_ui::Heap1>> =
                    leptos::use_context::<std::rc::Rc<Heap1>>();
                let v36: LrcPtr<Dice_ui::Heap1> = v34.unwrap();
                let v37: Dice_ui::US18 = Dice_ui::method82();
                let patternInput: (
                    leptos::ReadSignal<Dice_ui::US18>,
                    leptos::WriteSignal<Dice_ui::US18>,
                ) = leptos::create_signal(v37);
                let v41: bool = Dice_ui::method59();
                let patternInput_1: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                    leptos::create_signal(v41);
                let v45 = Dice_ui::method83(
                    v4.clone(),
                    v6,
                    v32,
                    v36,
                    patternInput_1.1.clone(),
                    patternInput_1.0.clone(),
                );
                leptos::create_effect(move |_| v45());
                {
                    let v47 = Dice_ui::method90(v4, patternInput.1.clone());
                    leptos::create_effect(move |_| v47());
                    {
                        let v52: string =
                            string(" class=\"flex flex-1 max-[100px]:[overflow-x:auto]\"");
                        let v54 = Dice_ui::method116(Dice_ui::method115(Dice_ui::method97(
                            patternInput.0.clone(),
                        )));
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
                        let v60: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method132(
                            leptos::view! { <div  class="flex flex-1 max-[100px]:[overflow-x:auto]">{v54()}</div> },
                        );
                        let v62: leptos::View = leptos::IntoView::into_view(v60);
                        leptos::Fragment::new(vec![v62])
                    }
                }
            }
        }
        pub fn method78() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure45((), ()))
        }
        pub fn closure5(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(append(
                append(string("home.render () / router: "), toString(1_i32)),
                string(""),
            ));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap1>> =
                    leptos::use_context::<std::rc::Rc<Heap1>>();
                let v6: LrcPtr<Dice_ui::Heap1> = v4.unwrap();
                let v8: string = Dice_ui::method0(string("state.use_database (1)"));
                leptos::logging::log!("{}", v8);
                {
                    let v10 = Dice_ui::method15();
                    let v13: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                        leptos::create_local_resource(
                            move || v10(),
                            |x| async move {
                                Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                            },
                        );
                    let v15: string = Dice_ui::method0(string("state.use_core_database (1)"));
                    leptos::logging::log!("{}", v15);
                    {
                        let v17 = Dice_ui::method18(v13.clone());
                        let v21 = Dice_ui::method39(
                            v6.clone(),
                            leptos::create_local_resource(
                                move || v17(),
                                |x| async move {
                                    Func1::new(move |v_1: Option<rexie::Rexie>| {
                                        Dice_ui::closure11((), v_1)
                                    })(x)
                                    .await
                                },
                            ),
                        );
                        leptos::create_effect(move |_| v21());
                        {
                            let v23 = Dice_ui::method57(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method59();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method60(v13);
                            let v33 = Dice_ui::method64(
                                v6.clone(),
                                v25,
                                patternInput.1.clone(),
                                patternInput.0.clone(),
                                leptos::create_action(move |value: &std::rc::Rc<Heap2>| {
                                    v30(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v33());
                            {
                                let v36 = Dice_ui::method77(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method116(Dice_ui::method115(Dice_ui::method78()));
                                let v47: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v42),
                                                    string(">{v44()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v50: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method132(
                                        leptos::view! { <div  class:dark={move || v36()} class="flex flex-1">{v44()}</div> },
                                    );
                                let v52: leptos::View = leptos::IntoView::into_view(v50);
                                leptos::Fragment::new(vec![v52])
                            }
                        }
                    }
                }
            }
        }
        pub fn method14() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure5((), ()))
        }
        pub fn closure176(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: Array<leptos::View> =
                Dice_ui::method122(Dice_ui::method121(new_empty::<leptos::View>()));
            let v4: Vec<leptos::View> = v2.to_vec();
            leptos::Fragment::new(v4)
        }
        pub fn method312() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure176((), ()))
        }
        pub fn method313() -> string {
            string("/")
        }
        pub fn closure177(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(append(
                append(string("home.render () / router: "), toString(2_i32)),
                string(""),
            ));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap1>> =
                    leptos::use_context::<std::rc::Rc<Heap1>>();
                let v6: LrcPtr<Dice_ui::Heap1> = v4.unwrap();
                let v8: string = Dice_ui::method0(string("state.use_database (1)"));
                leptos::logging::log!("{}", v8);
                {
                    let v10 = Dice_ui::method15();
                    let v13: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                        leptos::create_local_resource(
                            move || v10(),
                            |x| async move {
                                Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                            },
                        );
                    let v15: string = Dice_ui::method0(string("state.use_core_database (1)"));
                    leptos::logging::log!("{}", v15);
                    {
                        let v17 = Dice_ui::method18(v13.clone());
                        let v21 = Dice_ui::method39(
                            v6.clone(),
                            leptos::create_local_resource(
                                move || v17(),
                                |x| async move {
                                    Func1::new(move |v_1: Option<rexie::Rexie>| {
                                        Dice_ui::closure11((), v_1)
                                    })(x)
                                    .await
                                },
                            ),
                        );
                        leptos::create_effect(move |_| v21());
                        {
                            let v23 = Dice_ui::method57(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method59();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method60(v13);
                            let v33 = Dice_ui::method64(
                                v6.clone(),
                                v25,
                                patternInput.1.clone(),
                                patternInput.0.clone(),
                                leptos::create_action(move |value: &std::rc::Rc<Heap2>| {
                                    v30(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v33());
                            {
                                let v36 = Dice_ui::method77(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method116(Dice_ui::method115(Dice_ui::method78()));
                                let v47: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v42),
                                                    string(">{v44()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v50: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method132(
                                        leptos::view! { <div  class:dark={move || v36()} class="flex flex-1">{v44()}</div> },
                                    );
                                let v52: leptos::View = leptos::IntoView::into_view(v50);
                                leptos::Fragment::new(vec![v52])
                            }
                        }
                    }
                }
            }
        }
        pub fn method314() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure177((), ()))
        }
        pub fn method315() -> string {
            string("/*")
        }
        pub fn closure178(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(append(
                append(string("home.render () / router: "), toString(3_i32)),
                string(""),
            ));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap1>> =
                    leptos::use_context::<std::rc::Rc<Heap1>>();
                let v6: LrcPtr<Dice_ui::Heap1> = v4.unwrap();
                let v8: string = Dice_ui::method0(string("state.use_database (1)"));
                leptos::logging::log!("{}", v8);
                {
                    let v10 = Dice_ui::method15();
                    let v13: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                        leptos::create_local_resource(
                            move || v10(),
                            |x| async move {
                                Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                            },
                        );
                    let v15: string = Dice_ui::method0(string("state.use_core_database (1)"));
                    leptos::logging::log!("{}", v15);
                    {
                        let v17 = Dice_ui::method18(v13.clone());
                        let v21 = Dice_ui::method39(
                            v6.clone(),
                            leptos::create_local_resource(
                                move || v17(),
                                |x| async move {
                                    Func1::new(move |v_1: Option<rexie::Rexie>| {
                                        Dice_ui::closure11((), v_1)
                                    })(x)
                                    .await
                                },
                            ),
                        );
                        leptos::create_effect(move |_| v21());
                        {
                            let v23 = Dice_ui::method57(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method59();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method60(v13);
                            let v33 = Dice_ui::method64(
                                v6.clone(),
                                v25,
                                patternInput.1.clone(),
                                patternInput.0.clone(),
                                leptos::create_action(move |value: &std::rc::Rc<Heap2>| {
                                    v30(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v33());
                            {
                                let v36 = Dice_ui::method77(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method116(Dice_ui::method115(Dice_ui::method78()));
                                let v47: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v42),
                                                    string(">{v44()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v50: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method132(
                                        leptos::view! { <div  class:dark={move || v36()} class="flex flex-1">{v44()}</div> },
                                    );
                                let v52: leptos::View = leptos::IntoView::into_view(v50);
                                leptos::Fragment::new(vec![v52])
                            }
                        }
                    }
                }
            }
        }
        pub fn method316() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure178((), ()))
        }
        pub fn method317() -> string {
            string("*")
        }
        pub fn closure179(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Dice_ui::method0(append(
                append(string("home.render () / router: "), toString(4_i32)),
                string(""),
            ));
            leptos::logging::log!("{}", v1);
            {
                let v4: Option<LrcPtr<Dice_ui::Heap1>> =
                    leptos::use_context::<std::rc::Rc<Heap1>>();
                let v6: LrcPtr<Dice_ui::Heap1> = v4.unwrap();
                let v8: string = Dice_ui::method0(string("state.use_database (1)"));
                leptos::logging::log!("{}", v8);
                {
                    let v10 = Dice_ui::method15();
                    let v13: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                        leptos::create_local_resource(
                            move || v10(),
                            |x| async move {
                                Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                            },
                        );
                    let v15: string = Dice_ui::method0(string("state.use_core_database (1)"));
                    leptos::logging::log!("{}", v15);
                    {
                        let v17 = Dice_ui::method18(v13.clone());
                        let v21 = Dice_ui::method39(
                            v6.clone(),
                            leptos::create_local_resource(
                                move || v17(),
                                |x| async move {
                                    Func1::new(move |v_1: Option<rexie::Rexie>| {
                                        Dice_ui::closure11((), v_1)
                                    })(x)
                                    .await
                                },
                            ),
                        );
                        leptos::create_effect(move |_| v21());
                        {
                            let v23 = Dice_ui::method57(v6.clone());
                            let v25: leptos::Memo<
                                std::collections::HashMap<
                                    std::string::String,
                                    leptos::RwSignal<bool>,
                                >,
                            > = leptos::create_memo(move |_| v23());
                            let v26: bool = Dice_ui::method59();
                            let patternInput: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(v26);
                            let v30 = Dice_ui::method60(v13);
                            let v33 = Dice_ui::method64(
                                v6.clone(),
                                v25,
                                patternInput.1.clone(),
                                patternInput.0.clone(),
                                leptos::create_action(move |value: &std::rc::Rc<Heap2>| {
                                    v30(value.clone())
                                }),
                            );
                            leptos::create_effect(move |_| v33());
                            {
                                let v36 = Dice_ui::method77(v6);
                                let v42: string =
                                    string(" class:dark={move || v36()} class=\"flex flex-1\"");
                                let v44 =
                                    Dice_ui::method116(Dice_ui::method115(Dice_ui::method78()));
                                let v47: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v42),
                                                    string(">{v44()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v50: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method132(
                                        leptos::view! { <div  class:dark={move || v36()} class="flex flex-1">{v44()}</div> },
                                    );
                                let v52: leptos::View = leptos::IntoView::into_view(v50);
                                leptos::Fragment::new(vec![v52])
                            }
                        }
                    }
                }
            }
        }
        pub fn method318() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure179((), ()))
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method12()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method14();
            let v8 = Dice_ui::method312();
            let v18: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v8()) view=move || v7() path=v6 /> })");
            let v19: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  children=Box::new(move || v8()) view=move || v7() path=v6 /> },
            );
            let v22: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method313()));
            let v24: &str = fable_library_rust::String_::LrcStr::as_str(&v22);
            let v26: std::string::String = String::from(v24);
            let v27 = Dice_ui::method314();
            let v28 = Dice_ui::method312();
            let v36: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v28()) view=move || v27() path=v26 /> })");
            let v37: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  children=Box::new(move || v28()) view=move || v27() path=v26 /> },
            );
            let v40: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method315()));
            let v42: &str = fable_library_rust::String_::LrcStr::as_str(&v40);
            let v44: std::string::String = String::from(v42);
            let v45 = Dice_ui::method316();
            let v46 = Dice_ui::method312();
            let v54: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v46()) view=move || v45() path=v44 /> })");
            let v55: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  children=Box::new(move || v46()) view=move || v45() path=v44 /> },
            );
            let v58: string = Dice_ui::method6(Dice_ui::method13(Dice_ui::method317()));
            let v60: &str = fable_library_rust::String_::LrcStr::as_str(&v58);
            let v62: std::string::String = String::from(v60);
            let v63 = Dice_ui::method318();
            let v64 = Dice_ui::method312();
            let v72: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  children=Box::new(move || v64()) view=move || v63() path=v62 /> })");
            let v76: Array<leptos::View> = Dice_ui::method122(Dice_ui::method121(new_array(&[
                v19,
                v37,
                v55,
                leptos::IntoView::into_view(
                    leptos::view! { <leptos_router::Route  children=Box::new(move || v64()) view=move || v63() path=v62 /> },
                ),
            ])));
            let v78: Vec<leptos::View> = v76.to_vec();
            leptos::Fragment::new(v78)
        }
        pub fn method11() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure4((), ()))
        }
        pub fn method319(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method319(Dice_ui::method11());
            let v7: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> })");
            let v8: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> },
            );
            leptos::Fragment::new(vec![v8])
        }
        pub fn method10() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure3((), ()))
        }
        pub fn method320(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
            let v1: string = Dice_ui::method0(string("app.render ()"));
            leptos::logging::log!("{}", v1);
            leptos_meta::provide_meta_context();
            {
                let v4: bool = Dice_ui::method4();
                let v6: leptos::RwSignal<bool> = leptos::create_rw_signal(v4);
                let v7: bool = Dice_ui::method4();
                let v9: leptos::RwSignal<bool> = leptos::create_rw_signal(v7);
                let v11: string = Dice_ui::method6(Dice_ui::method5());
                let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
                let v16: std::string::String = Dice_ui::method7(String::from(v13));
                let v20: LrcPtr<Dice_ui::Heap0> = Dice_ui::method8(LrcPtr::new(Dice_ui::Heap0 {
                    l0: v6,
                    l1: v9,
                    l2: leptos::create_rw_signal(v16),
                }));
                let v22: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = leptos::create_rw_signal(v20);
                let v25: std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> =
                    Dice_ui::method9(std::collections::HashMap::new());
                let v28: LrcPtr<Dice_ui::Heap1> = LrcPtr::new(Dice_ui::Heap1 {
                    l0: v22,
                    l1: leptos::create_rw_signal(v25),
                });
                leptos::provide_context::<std::rc::Rc<Heap1>>(v28);
                {
                    let v31 = Dice_ui::method320(Dice_ui::method10());
                    let v37: string =
                        string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Router  children=Box::new(move || v31()) /> })");
                    leptos::IntoView::into_view(
                        leptos::view! { <leptos_router::Router  children=Box::new(move || v31()) /> },
                    )
                }
            }
        }
        pub fn method3() {
            leptos::mount_to_body(|| Func0::new(move || Dice_ui::closure2((), ()))());
            ()
        }
        pub fn closure180(unitVar: (), unitVar_1: ()) {
            Dice_ui::method3();
        }
        pub fn method321() -> Func0<()> {
            Func0::new(move || Dice_ui::closure180((), ()))
        }
        pub fn method322(v0_1: Box<dyn Fn()>) -> Box<dyn Fn()> {
            v0_1
        }
        pub fn closure0(unitVar: (), v0_1: Array<string>) -> i32 {
            let v2: string = Dice_ui::method0(append(
                append(string("main / args: "), toString(v0_1)),
                string(""),
            ));
            leptos::logging::log!("{}", v2);
            let _ = console_log::init_with_level(log::Level::Debug);
            console_error_panic_hook::set_once();
            {
                let v10: Dice_ui::US0 = defaultValue(
                    Dice_ui::US0::US0_0,
                    map(
                        Func1::new(move |v: web_sys::HtmlElement| Dice_ui::closure1((), v)),
                        leptos::document().body(),
                    ),
                );
                let v13: string = Dice_ui::method0(append(
                    append(
                        string("main / mount_to_body / body: "),
                        sprintf!("{:?}", &v10),
                    ),
                    string(""),
                ));
                leptos::logging::log!("{}", v13);
                if let Dice_ui::US0::US0_1(v10_1_0) = &v10 {
                    let v16: string = Dice_ui::method1();
                    let v18: &str = fable_library_rust::String_::LrcStr::as_str(&v16);
                    let v19: web_sys::HtmlElement = Dice_ui::method2(match &v10 {
                        Dice_ui::US0::US0_1(x) => x.clone(),
                        _ => unreachable!(),
                    });
                    v19.set_inner_html(v18);
                    Dice_ui::method3()
                } else {
                    let v21 = Dice_ui::method321();
                    let v24: Box<dyn Fn()> = Dice_ui::method322(Box::new(move || v21()));
                    let v26: wasm_bindgen::closure::Closure<dyn Fn()> =
                        wasm_bindgen::closure::Closure::wrap(v24);
                    let v28: &wasm_bindgen::JsValue = wasm_bindgen::closure::Closure::as_ref(&v26);
                    let v30: &js_sys::Function = wasm_bindgen::JsCast::unchecked_ref(v28);
                    leptos::document()
                        .add_event_listener_with_callback("DOMContentLoaded", v30)
                        .unwrap();
                    v26.forget();
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
