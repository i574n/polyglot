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
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::length;
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
            pub l0: leptos::RwSignal<std::string::String>,
        }
        impl core::fmt::Display for Dice_ui::Heap1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize, PartialEq)]
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
            US7_1(LrcPtr<Dice_ui::Heap4>),
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
        pub enum US23 {
            US23_0,
            US23_1(Result<Array<dice_ui::model::near::backend::ResultWrapper>, string>),
        }
        impl core::fmt::Display for Dice_ui::US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US24 {
            US24_0(string),
            US24_1(string),
        }
        impl core::fmt::Display for Dice_ui::US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(string),
            US25_1(Array<dice_ui::model::near::backend::ResultWrapper>),
        }
        impl core::fmt::Display for Dice_ui::US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US29 {
            US29_0(
                i32,
                std::string::String,
                u32,
                std::string::String,
                std::string::String,
            ),
            US29_1(
                i32,
                std::string::String,
                u32,
                std::string::String,
                std::string::String,
            ),
        }
        impl core::fmt::Display for Dice_ui::US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US28 {
            US28_0,
            US28_1(Dice_ui::US29),
        }
        impl core::fmt::Display for Dice_ui::US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US32 {
            US32_0,
            US32_1(u64),
        }
        impl core::fmt::Display for Dice_ui::US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US33 {
            US33_0,
            US33_1(u8, std::string::String),
        }
        impl core::fmt::Display for Dice_ui::US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US35 {
            US35_0,
            US35_1(Array<std::string::String>),
        }
        impl core::fmt::Display for Dice_ui::US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0(
                u8,
                Dice_ui::US15,
                Dice_ui::US35,
                std::string::String,
                std::string::String,
            ),
            US34_1(std::string::String),
            US34_2(
                std::string::String,
                std::string::String,
                u64,
                std::string::String,
            ),
            US34_3(std::string::String),
        }
        impl core::fmt::Display for Dice_ui::US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US31 {
            US31_0(u64, u64),
            US31_1(std::string::String, bool, Dice_ui::US32, Dice_ui::US15),
            US31_2(
                Dice_ui::US33,
                Array<(
                    Array<Dice_ui::US34>,
                    std::string::String,
                    u64,
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
        pub enum US27 {
            US27_0(string),
            US27_1(Array<(Dice_ui::US28, Dice_ui::US30)>),
        }
        impl core::fmt::Display for Dice_ui::US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0,
            US26_1(Dice_ui::US27),
        }
        impl core::fmt::Display for Dice_ui::US26 {
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
        pub enum US36 {
            US36_0,
            US36_1(dice_ui::model::near::backend::DataWrapper),
        }
        impl core::fmt::Display for Dice_ui::US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US37 {
            US37_0,
            US37_1(Vec<std::string::String>),
        }
        impl core::fmt::Display for Dice_ui::US37 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US38 {
            US38_0,
            US38_1(Array<std::string::String>),
        }
        impl core::fmt::Display for Dice_ui::US38 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US39 {
            US39_0,
            US39_1(dice_ui::model::near::backend::TransactionCursor),
        }
        impl core::fmt::Display for Dice_ui::US39 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US40 {
            US40_0,
            US40_1(dice_ui::model::near::backend::ErrorWrapperEnum),
        }
        impl core::fmt::Display for Dice_ui::US40 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US42 {
            US42_0(string),
            US42_1(Dice_ui::US31),
        }
        impl core::fmt::Display for Dice_ui::US42 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US41 {
            US41_0,
            US41_1(Dice_ui::US42),
        }
        impl core::fmt::Display for Dice_ui::US41 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US43 {
            US43_0(string),
            US43_1(Dice_ui::US42),
        }
        impl core::fmt::Display for Dice_ui::US43 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US44 {
            US44_0,
            US44_1(Dice_ui::US31),
        }
        impl core::fmt::Display for Dice_ui::US44 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<Dice_ui::US44>,
        }
        impl core::fmt::Display for Dice_ui::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US46 {
            US46_0(string),
            US46_1(u64, u64),
        }
        impl core::fmt::Display for Dice_ui::US46 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US45 {
            US45_0,
            US45_1(Dice_ui::US46),
        }
        impl core::fmt::Display for Dice_ui::US45 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US49 {
            US49_0,
            US49_1(u64, u64),
        }
        impl core::fmt::Display for Dice_ui::US49 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US48 {
            US48_0(string),
            US48_1(Dice_ui::US49),
        }
        impl core::fmt::Display for Dice_ui::US48 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US47 {
            US47_0,
            US47_1(Dice_ui::US48),
        }
        impl core::fmt::Display for Dice_ui::US47 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US51 {
            US51_0(string),
            US51_1(
                Dice_ui::US33,
                Array<(
                    Array<Dice_ui::US34>,
                    std::string::String,
                    u64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            ),
        }
        impl core::fmt::Display for Dice_ui::US51 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US50 {
            US50_0,
            US50_1(Dice_ui::US51),
        }
        impl core::fmt::Display for Dice_ui::US50 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US54 {
            US54_0,
            US54_1(
                Dice_ui::US33,
                Array<(
                    Array<Dice_ui::US34>,
                    std::string::String,
                    u64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            ),
        }
        impl core::fmt::Display for Dice_ui::US54 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US53 {
            US53_0(string),
            US53_1(Dice_ui::US54),
        }
        impl core::fmt::Display for Dice_ui::US53 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US52 {
            US52_0,
            US52_1(Dice_ui::US53),
        }
        impl core::fmt::Display for Dice_ui::US52 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US56 {
            US56_0(string),
            US56_1(u8, std::string::String),
        }
        impl core::fmt::Display for Dice_ui::US56 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US55 {
            US55_0,
            US55_1(Dice_ui::US56),
        }
        impl core::fmt::Display for Dice_ui::US55 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US57 {
            US57_0(string),
            US57_1(Dice_ui::US56),
        }
        impl core::fmt::Display for Dice_ui::US57 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US59 {
            US59_0(string),
            US59_1(
                Array<(
                    Array<Dice_ui::US34>,
                    std::string::String,
                    u64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            ),
        }
        impl core::fmt::Display for Dice_ui::US59 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US58 {
            US58_0,
            US58_1(Dice_ui::US59),
        }
        impl core::fmt::Display for Dice_ui::US58 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US60 {
            US60_0,
            US60_1(chrono::NaiveDateTime),
        }
        impl core::fmt::Display for Dice_ui::US60 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US61 {
            US61_0,
            US61_1(string),
        }
        impl core::fmt::Display for Dice_ui::US61 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US62 {
            US62_0(std::string::String),
            US62_1(std::string::String),
        }
        impl core::fmt::Display for Dice_ui::US62 {
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
        pub fn method5() -> string {
            string("")
        }
        pub fn method6(v0_1: string) -> string {
            v0_1
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> Dice_ui::US1 {
            Dice_ui::US1::US1_0
        }
        pub fn method8() -> Func0<Dice_ui::US1> {
            Func0::new(move || Dice_ui::closure6((), ()))
        }
        pub fn closure8(unitVar: (), v0_1: rexie::Rexie) -> Dice_ui::US2 {
            Dice_ui::US2::US2_1(v0_1)
        }
        pub fn closure9(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US2 {
            Dice_ui::US2::US2_0(v0_1)
        }
        pub fn method9(v0_1: rexie::Rexie) -> Dice_ui::US2 {
            Dice_ui::US2::US2_1(v0_1)
        }
        pub fn method10(v0_1: rexie::Rexie) -> rexie::Rexie {
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
                        let v20: Dice_ui::US2 = Dice_ui::method9(match &v13 {
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
                    let v32: rexie::Rexie = Dice_ui::method10(match &v25 {
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
        pub fn method12(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> leptos::Resource<Dice_ui::US1, rexie::Rexie> {
            v0_1
        }
        pub fn closure10(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method12(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method11(
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
        pub fn method13(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure13(unitVar: (), v0_1: serde_json::Value) -> Dice_ui::US5 {
            Dice_ui::US5::US5_1(v0_1)
        }
        pub fn method14(v0_1: serde_json::Value) -> serde_json::Value {
            v0_1
        }
        pub fn method15(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn closure14(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap3>) -> Dice_ui::US3 {
            Dice_ui::US3::US3_1(v0_1)
        }
        pub fn method16(
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
        pub fn method17(v0_1: Dice_ui::US3) -> Dice_ui::US3 {
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
                        let v82: Dice_ui::US3 = Dice_ui::method17(match &v7 {
                            Dice_ui::US4::US4_1(v7_1_0) => {
                                let v10: string = string("state.get_data () / id: core-state-data");
                                leptos::logging::log!("{}", &v10);
                                {
                                    let v12: rexie::Rexie = Dice_ui::method13(v7_1_0.clone());
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
                                                        Dice_ui::method14(v32_1_0.clone());
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
                                                        let v40: Vec<u8> = Dice_ui::method15(v36);
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
                                                Dice_ui::method16(match &v56 {
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
            let v1: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method12(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method18(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure17(v0_1.clone(), ())
            })
        }
        pub fn closure19(unitVar: (), v0_1: LrcPtr<Dice_ui::Heap4>) -> Dice_ui::US7 {
            Dice_ui::US7::US7_1(v0_1)
        }
        pub fn method19(
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
        pub fn method20(v0_1: Dice_ui::US7) -> Dice_ui::US7 {
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
                        let v82: Dice_ui::US7 = Dice_ui::method20(match &v7 {
                            Dice_ui::US4::US4_1(v7_1_0) => {
                                let v10: string = string("state.get_data () / id: state-data");
                                leptos::logging::log!("{}", &v10);
                                {
                                    let v12: rexie::Rexie = Dice_ui::method13(v7_1_0.clone());
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
                                                        Dice_ui::method14(v32_1_0.clone());
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
                                                        let v40: Vec<u8> = Dice_ui::method15(v36);
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
                                                        Dice_ui::US8::US8_1(defaultValue(Dice_ui::US7::US7_0,
                                                                                                           map(Func1::new(move
                                                                                                                              |v_2:
                                                                                                                                   LrcPtr<Dice_ui::Heap4>|
                                                                                                                              Dice_ui::closure19((),
                                                                                                                                                 v_2)),
                                                                                                               v42.ok())))
                                                    }
                                                }
                                                _ => Dice_ui::US8::US8_1(Dice_ui::US7::US7_0),
                                            };
                                            let v63: Result<Dice_ui::US7, rexie::Error> =
                                                Dice_ui::method19(match &v56 {
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
        pub fn method22() -> web_sys::Window {
            leptos::leptos_dom::window()
        }
        pub fn method24(v0_1: web_sys::Window) -> web_sys::Window {
            v0_1
        }
        pub fn method23(
            v0_1: web_sys::Window,
        ) -> Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> {
            let v1: web_sys::Window = Dice_ui::method24(v0_1);
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
        pub fn method25(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3> {
            v0_1
        }
        pub fn closure26(unitVar: (), v0_1: Dice_ui::US3) -> Dice_ui::US12 {
            Dice_ui::US12::US12_1(v0_1)
        }
        pub fn method26(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method27() -> string {
            string("core-state-data")
        }
        pub fn closure27(unitVar: (), v0_1: Option<std::string::String>) -> Dice_ui::US13 {
            Dice_ui::US13::US13_1(v0_1)
        }
        pub fn closure28(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Dice_ui::US13 {
            Dice_ui::US13::US13_0(v0_1)
        }
        pub fn method28(v0_1: Option<std::string::String>) -> Option<std::string::String> {
            v0_1
        }
        pub fn closure29(unitVar: (), v0_1: std::string::String) -> Dice_ui::US15 {
            Dice_ui::US15::US15_1(v0_1)
        }
        pub fn method29(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method30(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method31(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> {
            v0_1
        }
        pub fn closure30(v0_1: LrcPtr<Dice_ui::Heap3>, v1: bool) -> bool {
            v0_1.l0
        }
        pub fn method32(v0_1: LrcPtr<Dice_ui::Heap3>) -> Func1<bool, bool> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice_ui::closure30(v0_1.clone(), v)
            })
        }
        pub fn method33(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure31(v0_1: LrcPtr<Dice_ui::Heap3>, v1: bool) -> bool {
            v0_1.l1
        }
        pub fn method34(v0_1: LrcPtr<Dice_ui::Heap3>) -> Func1<bool, bool> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Dice_ui::closure31(v0_1.clone(), v)
            })
        }
        pub fn closure32(
            v0_1: LrcPtr<Dice_ui::Heap3>,
            v1: std::string::String,
        ) -> std::string::String {
            v0_1.l2.clone()
        }
        pub fn method35(
            v0_1: LrcPtr<Dice_ui::Heap3>,
        ) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure32(v0_1.clone(), v)
            })
        }
        pub fn method36(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn closure22(
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
                    Dice_ui::method23(Dice_ui::method22());
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
                            Dice_ui::method25(v1);
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
                                    let v32: web_sys::Storage = Dice_ui::method26(v19.clone());
                                    let v33: string = Dice_ui::method27();
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
                                                Dice_ui::method28(v40_1_0.clone());
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
                                            let v68: std::string::String = Dice_ui::method30(
                                                Dice_ui::method29(v65_1_0.clone()),
                                            );
                                            let v72: string = Dice_ui::method2(Dice_ui::method6(
                                                fable_library_rust::String_::fromString(v68),
                                            ));
                                            let v74: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v72);
                                            let v76: std::string::String = String::from(v74);
                                            let v78: Result<
                                                LrcPtr<Dice_ui::Heap3>,
                                                serde_json::Error,
                                            > = serde_json::from_str(&v76);
                                            Dice_ui::US12::US12_1(defaultValue(
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
                                let v96: web_sys::Storage = Dice_ui::method26(v19);
                                let v97: string = Dice_ui::method27();
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
                                            Dice_ui::method28(v104_1_0.clone());
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
                                            Dice_ui::method30(Dice_ui::method29(v129_1_0.clone()));
                                        let v136: string = Dice_ui::method2(Dice_ui::method6(
                                            fable_library_rust::String_::fromString(v132),
                                        ));
                                        let v138: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v136);
                                        let v140: std::string::String = String::from(v138);
                                        let v142: Result<
                                            LrcPtr<Dice_ui::Heap3>,
                                            serde_json::Error,
                                        > = serde_json::from_str(&v140);
                                        Dice_ui::US12::US12_1(defaultValue(
                                            Dice_ui::US3::US3_0,
                                            map(
                                                Func1::new(move |v_11: LrcPtr<Dice_ui::Heap3>| {
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
                                let v163: LrcPtr<Dice_ui::Heap3> = match &v159 {
                                    Dice_ui::US3::US3_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v164: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                                    v0_1.l0.clone();
                                let v165: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                                    Dice_ui::method31(v164.clone());
                                let v167: LrcPtr<Dice_ui::Heap0> =
                                    leptos::SignalGetUntracked::get_untracked(&v165);
                                let v169 = Dice_ui::method32(v163.clone());
                                let v170: leptos::RwSignal<bool> =
                                    Dice_ui::method33(v167.l0.clone());
                                let v171: string =
                                    string("leptos::SignalUpdate::update(&v170, |x| { let result = v169(x.clone()); if result != *x { *x = result } })");
                                leptos::SignalUpdate::update(&v170, |x| {
                                    let result = v169(x.clone());
                                    if result != *x {
                                        *x = result
                                    }
                                });
                                {
                                    let v172: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                                        Dice_ui::method31(v164.clone());
                                    let v174: LrcPtr<Dice_ui::Heap0> =
                                        leptos::SignalGetUntracked::get_untracked(&v172);
                                    let v176 = Dice_ui::method34(v163.clone());
                                    let v177: leptos::RwSignal<bool> =
                                        Dice_ui::method33(v174.l1.clone());
                                    let v178: string =
                                        string("leptos::SignalUpdate::update(&v177, |x| { let result = v176(x.clone()); if result != *x { *x = result } })");
                                    leptos::SignalUpdate::update(&v177, |x| {
                                        let result = v176(x.clone());
                                        if result != *x {
                                            *x = result
                                        }
                                    });
                                    {
                                        let v179: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                                            Dice_ui::method31(v164);
                                        let v181: LrcPtr<Dice_ui::Heap0> =
                                            leptos::SignalGetUntracked::get_untracked(&v179);
                                        let v183 = Dice_ui::method35(v163);
                                        let v184: leptos::RwSignal<std::string::String> =
                                            Dice_ui::method36(v181.l2.clone());
                                        let v185: string =
                                            string("leptos::SignalUpdate::update(&v184, |x| { let result = v183(x.clone()); if result != *x { *x = result } })");
                                        leptos::SignalUpdate::update(&v184, |x| {
                                            let result = v183(x.clone());
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
        }
        pub fn method21(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US3>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure22(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method38(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7> {
            v0_1
        }
        pub fn closure34(unitVar: (), v0_1: Dice_ui::US7) -> Dice_ui::US17 {
            Dice_ui::US17::US17_1(v0_1)
        }
        pub fn method39(
            v0_1: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>>,
        ) -> leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> {
            v0_1
        }
        pub fn closure35(
            v0_1: LrcPtr<Dice_ui::Heap4>,
            v1: std::string::String,
        ) -> std::string::String {
            v0_1.l0.clone()
        }
        pub fn method40(
            v0_1: LrcPtr<Dice_ui::Heap4>,
        ) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure35(v0_1.clone(), v)
            })
        }
        pub fn closure33(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7>,
            unitVar: (),
        ) {
            leptos::logging::log!(
                "{}",
                &string("state.use_database () / effect state_data / ##1")
            );
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Dice_ui::method23(Dice_ui::method22());
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
                            Dice_ui::method38(v1);
                        let v25: Dice_ui::US17 = defaultValue(
                            Dice_ui::US17::US17_0,
                            map(
                                Func1::new(move |v_3: Dice_ui::US7| Dice_ui::closure34((), v_3)),
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
                                let v41: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> =
                                    Dice_ui::method39(v0_1.l2.clone());
                                let v43: LrcPtr<Dice_ui::Heap1> =
                                    leptos::SignalGetUntracked::get_untracked(&v41);
                                let v45 = Dice_ui::method40(match &v32 {
                                    Dice_ui::US7::US7_1(x) => x.clone(),
                                    _ => unreachable!(),
                                });
                                let v46: leptos::RwSignal<std::string::String> =
                                    Dice_ui::method36(v43.l0.clone());
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
        pub fn method37(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Resource<Option<rexie::Rexie>, Dice_ui::US7>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure33(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method42(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn method43(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> Dice_ui::US18 {
            Dice_ui::US18::US18_1
        }
        pub fn closure38(unitVar: (), v0_1: rexie::Error) -> Dice_ui::US18 {
            Dice_ui::US18::US18_0(v0_1)
        }
        pub fn method44() {
            ();
        }
        pub fn closure36(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            v1: LrcPtr<Dice_ui::Heap3>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v2: string = sprintf!("{:?}", &v1);
            let v3: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method12(v0_1);
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
                                let v16: rexie::Rexie = Dice_ui::method42(v8_1_0.clone());
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
                                            let v28: string = Dice_ui::method27();
                                            let v30: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v28);
                                            v21.put(&v27, Some(&v30.into())).await?;
                                            v19.done().await?;
                                            {
                                                let v34: Result<(), rexie::Error> =
                                                    Dice_ui::method43(Ok(()));
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
                                                        Dice_ui::closure38((), v39_1_0.clone())
                                                    }
                                                    _ => Dice_ui::closure37((), ()),
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
                Dice_ui::method44();
                ()
            });
            // ;
            __future_init
        }
        pub fn method41(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func1<LrcPtr<Dice_ui::Heap3>, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_ui::Heap3>| Dice_ui::closure36(v0_1.clone(), v)
            })
        }
        pub fn method46() -> string {
            string("state-data")
        }
        pub fn closure39(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
            v1: LrcPtr<Dice_ui::Heap4>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v2: string = sprintf!("{:?}", &v1);
            let v3: leptos::Resource<Dice_ui::US1, rexie::Rexie> = Dice_ui::method12(v0_1);
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
                                let v16: rexie::Rexie = Dice_ui::method42(v8_1_0.clone());
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
                                            let v28: string = Dice_ui::method46();
                                            let v30: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v28);
                                            v21.put(&v27, Some(&v30.into())).await?;
                                            v19.done().await?;
                                            {
                                                let v34: Result<(), rexie::Error> =
                                                    Dice_ui::method43(Ok(()));
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
                                                        Dice_ui::closure38((), v39_1_0.clone())
                                                    }
                                                    _ => Dice_ui::closure37((), ()),
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
                Dice_ui::method44();
                ()
            });
            // ;
            __future_init
        }
        pub fn method45(
            v0_1: leptos::Resource<Dice_ui::US1, rexie::Rexie>,
        ) -> Func1<LrcPtr<Dice_ui::Heap4>, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice_ui::Heap4>| Dice_ui::closure39(v0_1.clone(), v)
            })
        }
        pub fn method48(
            v0_1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::RwSignal<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn closure40(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            unitVar: (),
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> {
            leptos::logging::log!("{}", &string("state.use_database () / loading create_memo"));
            {
                let v4: leptos::RwSignal<
                    std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                > = Dice_ui::method48(v0_1.l1.clone());
                leptos::SignalGetUntracked::get_untracked(&v4)
            }
        }
        pub fn method47(
            v0_1: LrcPtr<Dice_ui::Heap2>,
        ) -> Func0<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure40(v0_1.clone(), ())
            })
        }
        pub fn method49() -> bool {
            false
        }
        pub fn method51(v0_1: leptos::ReadSignal<bool>) -> leptos::ReadSignal<bool> {
            v0_1
        }
        pub fn method52(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn method53(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method54(
            v0_1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::Memo<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn method55() -> string {
            string("dark_mode_key")
        }
        pub fn method56(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure42(unitVar: (), v0_1: leptos::RwSignal<bool>) -> Dice_ui::US19 {
            Dice_ui::US19::US19_1(v0_1)
        }
        pub fn method57() -> bool {
            true
        }
        pub fn method58(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method59(v0_1: LrcPtr<Dice_ui::Heap3>) -> LrcPtr<Dice_ui::Heap3> {
            v0_1
        }
        pub fn method60(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method61(v0_1: LrcPtr<Dice_ui::Heap3>) -> LrcPtr<Dice_ui::Heap3> {
            v0_1
        }
        pub fn method62(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure41(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()>,
            v2: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            v3: leptos::WriteSignal<bool>,
            v4: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v5: leptos::ReadSignal<bool> = Dice_ui::method51(v4);
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
                let v11: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method31(v10.clone());
                let v15: leptos::RwSignal<bool> =
                    Dice_ui::method52((leptos::SignalGetUntracked::get_untracked(&v11)).l0.clone());
                let v17: bool = leptos::SignalGet::get(&v15);
                let v18: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method31(v10.clone());
                let v22: leptos::RwSignal<bool> =
                    Dice_ui::method52((leptos::SignalGetUntracked::get_untracked(&v18)).l1.clone());
                let v24: bool = leptos::SignalGet::get(&v22);
                let v25: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method31(v10);
                let v29: leptos::RwSignal<std::string::String> =
                    Dice_ui::method53((leptos::SignalGetUntracked::get_untracked(&v25)).l2.clone());
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
                    > = Dice_ui::method54(v2);
                    let v38: std::collections::HashMap<
                        std::string::String,
                        leptos::RwSignal<bool>,
                    > = v36();
                    let v40: string = Dice_ui::method2(Dice_ui::method55());
                    let v42: &str = fable_library_rust::String_::LrcStr::as_str(&v40);
                    let v45: std::string::String = Dice_ui::method56(String::from(v42));
                    let v50: Dice_ui::US19 = defaultValue(
                        Dice_ui::US19::US19_0,
                        map(
                            Func1::new(move |v: leptos::RwSignal<bool>| Dice_ui::closure42((), v)),
                            std::collections::HashMap::get(&v38, &v45).map(|x| *x),
                        ),
                    );
                    let v58: Dice_ui::US20 = match &v50 {
                        Dice_ui::US19::US19_1(v50_1_0) => {
                            let v52: leptos::RwSignal<bool> = Dice_ui::method52(v50_1_0.clone());
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
                            let v66: bool = Dice_ui::method57();
                            let v67: leptos::WriteSignal<bool> = Dice_ui::method58(v3);
                            leptos::SignalSet::set(&v67, v66);
                            ()
                        } else {
                            leptos::logging::log!(
                                "{}",
                                &string("state.use_database () / effect new_core_state_data / ##4")
                            );
                            {
                                let v72: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                                    Dice_ui::method23(Dice_ui::method22());
                                let v75: Dice_ui::US9 = match &v72 {
                                    Err(v72_1_0) => Dice_ui::closure24((), v72_1_0.clone()),
                                    Ok(v72_0_0) => Dice_ui::closure23((), v72_0_0.clone()),
                                };
                                let v84: Dice_ui::US10 = match &v75 {
                                    Dice_ui::US9::US9_1(v75_1_0) => {
                                        Dice_ui::US10::US10_1(defaultValue(
                                            Dice_ui::US11::US11_0,
                                            map(
                                                Func1::new(move |v_3: web_sys::Storage| {
                                                    Dice_ui::closure25((), v_3)
                                                }),
                                                v75_1_0.clone(),
                                            ),
                                        ))
                                    }
                                    Dice_ui::US9::US9_0(v75_0_0) => {
                                        Dice_ui::US10::US10_0(v75_0_0.clone())
                                    }
                                };
                                if let Dice_ui::US10::US10_1(v84_1_0) = &v84 {
                                    let v85: Dice_ui::US11 = match &v84 {
                                        Dice_ui::US10::US10_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Dice_ui::US11::US11_1(v85_1_0) = &v85 {
                                        let v87: LrcPtr<Dice_ui::Heap3> =
                                            Dice_ui::method59(v32.clone());
                                        leptos::Action::dispatch(&v1, v87);
                                        {
                                            let v89: web_sys::Storage =
                                                Dice_ui::method60(match &v85 {
                                                    Dice_ui::US11::US11_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                });
                                            let v90: string = Dice_ui::method27();
                                            let v92: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v90);
                                            let v93: LrcPtr<Dice_ui::Heap3> =
                                                Dice_ui::method61(v32);
                                            let v96: std::string::String = Dice_ui::method62(
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
        pub fn method50(
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
        pub fn method64(v0_1: LrcPtr<Dice_ui::Heap4>) -> LrcPtr<Dice_ui::Heap4> {
            v0_1
        }
        pub fn closure43(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap4>, ()>,
            v2: leptos::WriteSignal<bool>,
            v3: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v4: leptos::ReadSignal<bool> = Dice_ui::method51(v3);
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
                    Dice_ui::method39(v0_1.l2.clone());
                let v14: leptos::RwSignal<std::string::String> =
                    Dice_ui::method53((leptos::SignalGetUntracked::get_untracked(&v10)).l0.clone());
                let v17: LrcPtr<Dice_ui::Heap4> = LrcPtr::new(Dice_ui::Heap4 {
                    l0: leptos::SignalGet::get(&v14),
                });
                let v19: string =
                    append(append(string("state.use_database () / effect new_state_data / ##2 / new_state_data: "),
                                  sprintf!("{:?}", &v17)), string(""));
                leptos::logging::log!("{}", &v19);
                if v6 == false {
                    let v22: bool = Dice_ui::method57();
                    let v23: leptos::WriteSignal<bool> = Dice_ui::method58(v2);
                    leptos::SignalSet::set(&v23, v22);
                    ()
                } else {
                    leptos::logging::log!(
                        "{}",
                        &string("state.use_database () / effect new_state_data / ##4")
                    );
                    {
                        let v28: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                            Dice_ui::method23(Dice_ui::method22());
                        let v31: Dice_ui::US9 = match &v28 {
                            Err(v28_1_0) => Dice_ui::closure24((), v28_1_0.clone()),
                            Ok(v28_0_0) => Dice_ui::closure23((), v28_0_0.clone()),
                        };
                        let v40: Dice_ui::US10 = match &v31 {
                            Dice_ui::US9::US9_1(v31_1_0) => Dice_ui::US10::US10_1(defaultValue(
                                Dice_ui::US11::US11_0,
                                map(
                                    Func1::new(move |v_2: web_sys::Storage| {
                                        Dice_ui::closure25((), v_2)
                                    }),
                                    v31_1_0.clone(),
                                ),
                            )),
                            Dice_ui::US9::US9_0(v31_0_0) => Dice_ui::US10::US10_0(v31_0_0.clone()),
                        };
                        if let Dice_ui::US10::US10_1(v40_1_0) = &v40 {
                            if let Dice_ui::US11::US11_1(_) = &match &v40 {
                                Dice_ui::US10::US10_1(x) => x.clone(),
                                _ => unreachable!(),
                            } {
                                let v43: LrcPtr<Dice_ui::Heap4> = Dice_ui::method64(v17);
                                leptos::Action::dispatch(&v1, v43);
                                ()
                            };
                        }
                    }
                }
            }
        }
        pub fn method63(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Action<LrcPtr<Dice_ui::Heap4>, ()>,
            v2: leptos::WriteSignal<bool>,
            v3: leptos::ReadSignal<bool>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move || Dice_ui::closure43(v0_1.clone(), v1.clone(), v2.clone(), v3.clone(), ())
            })
        }
        pub fn closure44(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method31(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method52((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method65(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure44(v0_1.clone(), ())
            })
        }
        pub fn method67(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method68(
            v0_1: leptos::Memo<std::string::String>,
        ) -> leptos::Memo<std::string::String> {
            v0_1
        }
        pub fn method69(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method70() -> Dice_ui::US21 {
            Dice_ui::US21::US21_0
        }
        pub fn method72(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method73(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure47(v0_1: string, v1: std::string::String) -> std::string::String {
            let v3: string = Dice_ui::method2(Dice_ui::method6(v0_1));
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            String::from(v5)
        }
        pub fn method74(v0_1: string) -> Func1<std::string::String, std::string::String> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure47(v0_1.clone(), v)
            })
        }
        pub fn closure46(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: LrcPtr<Dice_ui::Heap2>,
            v4: leptos::WriteSignal<bool>,
            v5: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v6: leptos::ReadSignal<bool> = Dice_ui::method51(v5);
            let v8: bool = leptos::SignalGet::get(&v6);
            let v9: leptos_router::Location = Dice_ui::method72(v0_1);
            let v12: leptos::Memo<std::string::String> = Dice_ui::method68(v9.hash);
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
                let v19: std::string::String = Dice_ui::method73(v14);
                if v19 == "" {
                    let v23: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                        Dice_ui::method31(v3.l0.clone());
                    let v27: leptos::RwSignal<std::string::String> = Dice_ui::method53(
                        (leptos::SignalGetUntracked::get_untracked(&v23)).l2.clone(),
                    );
                    let v30: std::string::String = Dice_ui::method30(leptos::SignalGet::get(&v27));
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
                    let v41: bool = Dice_ui::method57();
                    let v42: leptos::WriteSignal<bool> = Dice_ui::method58(v4);
                    leptos::SignalSet::set(&v42, v41);
                    ()
                }
            } else {
                let v45: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                    Dice_ui::method31(v3.l0.clone());
                let v47: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v45);
                let v49 = Dice_ui::method74(v15);
                let v50: leptos::RwSignal<std::string::String> = Dice_ui::method36(v47.l2.clone());
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
        pub fn method71(
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
        pub fn method76(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method77(v0_1: &str) -> &str {
            v0_1
        }
        pub fn closure49(unitVar: (), v0_1: leptos_router::Url) -> Dice_ui::US22 {
            Dice_ui::US22::US22_1(v0_1)
        }
        pub fn closure50(unitVar: (), v0_1: std::string::String) -> Dice_ui::US22 {
            Dice_ui::US22::US22_0(v0_1)
        }
        pub fn method78() -> string {
            string("/settings")
        }
        pub fn method79(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure51(v0_1: Dice_ui::US21, v1: Dice_ui::US21) -> Dice_ui::US21 {
            v0_1
        }
        pub fn method80(v0_1: Dice_ui::US21) -> Func1<Dice_ui::US21, Dice_ui::US21> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Dice_ui::US21| Dice_ui::closure51(v0_1.clone(), v)
            })
        }
        pub fn method81(
            v0_1: leptos::WriteSignal<Dice_ui::US21>,
        ) -> leptos::WriteSignal<Dice_ui::US21> {
            v0_1
        }
        pub fn closure48(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US21>,
            unitVar: (),
        ) {
            let v2: leptos_router::Location = Dice_ui::method72(v0_1);
            let v5: leptos::Memo<std::string::String> = Dice_ui::method68(v2.hash);
            let v8: std::string::String = Dice_ui::method76(v5());
            let v10: Option<&str> = v8.strip_prefix('#');
            let v12: string = string("r#\"\"#");
            let v13: &str = r#""#;
            let v16: &str = Dice_ui::method77(v10.unwrap_or(v13));
            let v18: Result<leptos_router::Url, std::string::String> =
                leptos_router::Url::try_from(v16);
            let v21: Dice_ui::US22 = match &v18 {
                Err(v18_1_0) => Dice_ui::closure50((), v18_1_0.clone()),
                Ok(v18_0_0) => Dice_ui::closure49((), v18_0_0.clone()),
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
                let v35: string = Dice_ui::method2(Dice_ui::method78());
                let v37: &str = fable_library_rust::String_::LrcStr::as_str(&v35);
                let v39: std::string::String = String::from(v37);
                let v40: std::string::String = Dice_ui::method79(v33);
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
                    let v50 = Dice_ui::method80(v45);
                    let v51: leptos::WriteSignal<Dice_ui::US21> = Dice_ui::method81(v1);
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
        pub fn method75(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Dice_ui::US21>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure48(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure55(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::ReadSignal<Dice_ui::US21> {
            v0_1
        }
        pub fn method85(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
        ) -> Func0<leptos::ReadSignal<Dice_ui::US21>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure55(v0_1.clone(), ())
            })
        }
        pub fn method87(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
        ) -> leptos::ReadSignal<Dice_ui::US21> {
            v0_1
        }
        pub fn method89() -> string {
            string("0")
        }
        pub fn method90() -> string {
            string("i574n.near")
        }
        pub fn method91(
            v0_1: dice_ui::model::near::backend::InputData,
        ) -> dice_ui::model::near::backend::InputData {
            v0_1
        }
        pub fn method92() -> string {
            string("1")
        }
        pub fn method93() -> string {
            string("2")
        }
        pub fn method94(
            v0_1: Option<dice_ui::model::near::backend::TransactionCursor>,
        ) -> Option<dice_ui::model::near::backend::TransactionCursor> {
            v0_1
        }
        pub fn method95(
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
        pub fn closure57(unitVar: (), unitVar_1: ()) -> std::string::String {
            leptos::logging::log!("{}", &string("history.render () / url_input create_memo"));
            {
                let v3: string = Dice_ui::method2(Dice_ui::method89());
                let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
                let v7: std::string::String = String::from(v5);
                let v9: string = Dice_ui::method2(Dice_ui::method90());
                let v11: &str = fable_library_rust::String_::LrcStr::as_str(&v9);
                let v13: std::string::String = String::from(v11);
                let v15: dice_ui::model::near::backend::IdInput =
                    dice_ui::model::near::backend::IdInput { id: v13 };
                let v18: dice_ui::model::near::backend::InputData =
                    Dice_ui::method91(dice_ui::model::near::backend::InputData::IdInput(v15));
                let v20: std::rc::Rc<dice_ui::model::near::backend::InputData> =
                    std::rc::Rc::new(v18);
                let v22: string = Dice_ui::method2(Dice_ui::method92());
                let v24: &str = fable_library_rust::String_::LrcStr::as_str(&v22);
                let v26: std::string::String = String::from(v24);
                let v28: string = Dice_ui::method2(Dice_ui::method90());
                let v30: &str = fable_library_rust::String_::LrcStr::as_str(&v28);
                let v32: std::string::String = String::from(v30);
                let v34: dice_ui::model::near::backend::IdInput =
                    dice_ui::model::near::backend::IdInput { id: v32 };
                let v37: dice_ui::model::near::backend::InputData =
                    Dice_ui::method91(dice_ui::model::near::backend::InputData::IdInput(v34));
                let v39: std::rc::Rc<dice_ui::model::near::backend::InputData> =
                    std::rc::Rc::new(v37);
                let v41: string = Dice_ui::method2(Dice_ui::method93());
                let v43: &str = fable_library_rust::String_::LrcStr::as_str(&v41);
                let v45: std::string::String = String::from(v43);
                let v47: string = Dice_ui::method2(Dice_ui::method90());
                let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
                let v51: std::string::String = String::from(v49);
                let v53: Option<dice_ui::model::near::backend::TransactionCursor> =
                    Dice_ui::method94(None::<dice_ui::model::near::backend::TransactionCursor>);
                let v54: string =
                    string("dice_ui::model::near::backend::TransactionListByAccountIdInput { account_id: v51, limit: 10, cursor: v53 }");
                let v55: dice_ui::model::near::backend::TransactionListByAccountIdInput =
                    dice_ui::model::near::backend::TransactionListByAccountIdInput {
                        account_id: v51,
                        limit: 10,
                        cursor: v53,
                    };
                let v58: dice_ui::model::near::backend::InputData = Dice_ui::method91(
                    dice_ui::model::near::backend::InputData::TransactionListByAccountIdInput(v55),
                );
                let v63: Array<(
                    std::string::String,
                    std::rc::Rc<dice_ui::model::near::backend::InputData>,
                )> = Dice_ui::method96(Dice_ui::method95(new_array(&[
                    (v7, v20),
                    (v26, v39),
                    (v45, std::rc::Rc::new(v58)),
                ])));
                let v65: std::collections::HashMap<
                    std::string::String,
                    std::rc::Rc<dice_ui::model::near::backend::InputData>,
                > = std::collections::HashMap::from_iter(v63.to_vec());
                let v67: Result<std::string::String, serde_json::Error> =
                    serde_json::to_string(&v65);
                let v69: std::string::String = v67.unwrap();
                let v71: js_sys::JsString = js_sys::encode_uri_component(&v69);
                let v73: std::string::String = format!("{}", &v71);
                let v74: string = append(
                    append(
                        string("history.render () / url_input create_memo / result: "),
                        toString(v73.clone()),
                    ),
                    string(""),
                );
                leptos::logging::log!("{}", &v74);
                v73
            }
        }
        pub fn method88() -> Func0<std::string::String> {
            Func0::new(move || Dice_ui::closure57((), ()))
        }
        pub fn closure58(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<std::string::String>,
            unitVar: (),
        ) -> string {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method39(v0_1.l2.clone());
            let v7: leptos::RwSignal<std::string::String> =
                Dice_ui::method53((leptos::SignalGetUntracked::get_untracked(&v3)).l0.clone());
            let v9: std::string::String = leptos::SignalGet::get(&v7);
            let v10: leptos::Memo<std::string::String> = Dice_ui::method68(v1);
            let v12: std::string::String = v10();
            let v13: string =
                append(append(append(append(string("https://"), toString(v9)),
                                     string("/trpc/account.transactionsCount,contract.byId,transaction.listByAccountId?batch=1&input=")),
                              toString(v12)), string(""));
            let v14: string = append(
                append(
                    string("history.render () / url create_memo / url: "),
                    v13.clone(),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v14);
            v13
        }
        pub fn method97(
            v0_1: LrcPtr<Dice_ui::Heap2>,
            v1: leptos::Memo<std::string::String>,
        ) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure58(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method99(v0_1: leptos::Memo<string>) -> leptos::Memo<string> {
            v0_1
        }
        pub fn closure59(v0_1: leptos::Memo<string>, unitVar: ()) -> string {
            let v1: leptos::Memo<string> = Dice_ui::method99(v0_1);
            v1()
        }
        pub fn method98(v0_1: leptos::Memo<string>) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure59(v0_1.clone(), ())
            })
        }
        pub fn method100(v0_1: string) -> string {
            v0_1
        }
        pub fn method101(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure61(unitVar: (), v0_1: reqwest_wasm::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method102() -> Func1<reqwest_wasm::Error, std::string::String> {
            Func1::new(move |v: reqwest_wasm::Error| Dice_ui::closure61((), v))
        }
        pub fn method103(v0_1: Result<string, string>) -> Result<string, string> {
            v0_1
        }
        pub fn closure60(
            unitVar: (),
            v0_1: string,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<string, string>>>> {
            let v1: string = append(
                append(
                    string("history.render () / json create_local_resource / url.len: "),
                    toString(length(v0_1.clone())),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v1);
            let __future_init = Box::pin(async {
                //;
                {
                    let v6: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method100(v0_1)));
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
                    let v30: std::string::String = Dice_ui::method30(v27?);
                    let v34: Result<string, string> =
                        Dice_ui::method103(Ok(fable_library_rust::String_::fromString(v30)));
                    v34
                }
            });
            {
                // ;
                __future_init
            }
        }
        pub fn method105(
            v0_1: leptos::Resource<string, Result<string, string>>,
        ) -> leptos::Resource<string, Result<string, string>> {
            v0_1
        }
        pub fn method106(v0_1: Option<Result<string, string>>) -> Option<Result<string, string>> {
            v0_1
        }
        pub fn closure64(unitVar: (), v0_1: string) -> Dice_ui::US24 {
            Dice_ui::US24::US24_1(v0_1)
        }
        pub fn closure65(unitVar: (), v0_1: string) -> Dice_ui::US24 {
            Dice_ui::US24::US24_0(v0_1)
        }
        pub fn closure66(unitVar: (), v0_1: serde_json::Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method108() -> Func1<serde_json::Error, std::string::String> {
            Func1::new(move |v: serde_json::Error| Dice_ui::closure66((), v))
        }
        pub fn method109(
            v0_1: Vec<dice_ui::model::near::backend::ResultWrapper>,
        ) -> Vec<dice_ui::model::near::backend::ResultWrapper> {
            v0_1
        }
        pub fn closure63(
            unitVar: (),
            v0_1: Result<string, string>,
        ) -> Result<Array<dice_ui::model::near::backend::ResultWrapper>, string> {
            let v3: Dice_ui::US24 = match &v0_1 {
                Err(v0_1_1_0) => Dice_ui::closure65((), v0_1_1_0.clone()),
                Ok(v0_1_0_0) => Dice_ui::closure64((), v0_1_0_0.clone()),
            };
            let v25: Dice_ui::US25 = match &v3 {
                Dice_ui::US24::US24_1(v3_1_0) => {
                    let v6: string = Dice_ui::method2(Dice_ui::method6(v3_1_0.clone()));
                    let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
                    let v10: std::string::String = String::from(v8);
                    let v12: Result<
                        Vec<dice_ui::model::near::backend::ResultWrapper>,
                        serde_json::Error,
                    > = serde_json::from_str(&v10);
                    let v13 = Dice_ui::method108();
                    let v15: Result<
                        Vec<dice_ui::model::near::backend::ResultWrapper>,
                        std::string::String,
                    > = v12.map_err(|x| v13(x));
                    let v18: Vec<dice_ui::model::near::backend::ResultWrapper> =
                        Dice_ui::method109(v15?);
                    Dice_ui::US25::US25_1(fable_library_rust::NativeArray_::array_from(v18))
                }
                Dice_ui::US24::US24_0(v3_0_0) => Dice_ui::US25::US25_0(v3_0_0.clone()),
            };
            match &v25 {
                Dice_ui::US25::US25_1(v25_1_0) => Ok(v25_1_0.clone()),
                Dice_ui::US25::US25_0(v25_0_0) => Err(v25_0_0.clone()),
            }
        }
        pub fn method107() -> Func1<
            Result<string, string>,
            Result<Array<dice_ui::model::near::backend::ResultWrapper>, string>,
        > {
            Func1::new(move |v: Result<string, string>| Dice_ui::closure63((), v))
        }
        pub fn closure67(
            unitVar: (),
            v0_1: Result<Array<dice_ui::model::near::backend::ResultWrapper>, string>,
        ) -> Dice_ui::US23 {
            Dice_ui::US23::US23_1(v0_1)
        }
        pub fn closure62(
            v0_1: leptos::Resource<string, Result<string, string>>,
            unitVar: (),
        ) -> Dice_ui::US23 {
            let v1: leptos::Resource<string, Result<string, string>> = Dice_ui::method105(v0_1);
            let v4: Option<Result<string, string>> =
                Dice_ui::method106(leptos::SignalGet::get(&v1));
            let v5 = Dice_ui::method107();
            let v10: Dice_ui::US23 = defaultValue(
                Dice_ui::US23::US23_0,
                map(
                    Func1::new(
                        move |v: Result<
                            Array<dice_ui::model::near::backend::ResultWrapper>,
                            string,
                        >| Dice_ui::closure67((), v),
                    ),
                    v4.map(|x| v5(x)),
                ),
            );
            let v12: string = append(
                append(
                    string("history.render () / result_wrapper create_memo / result: "),
                    sprintf!("{:?}", &v10),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v12);
            v10
        }
        pub fn method104(
            v0_1: leptos::Resource<string, Result<string, string>>,
        ) -> Func0<Dice_ui::US23> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure62(v0_1.clone(), ())
            })
        }
        pub fn closure68(
            v0_1: leptos::Memo<Dice_ui::US23>,
            unitVar: (),
        ) -> leptos::Memo<Dice_ui::US23> {
            v0_1
        }
        pub fn method110(v0_1: leptos::Memo<Dice_ui::US23>) -> Func0<leptos::Memo<Dice_ui::US23>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure68(v0_1.clone(), ())
            })
        }
        pub fn method112(v0_1: leptos::Memo<Dice_ui::US23>) -> leptos::Memo<Dice_ui::US23> {
            v0_1
        }
        pub fn closure70(
            unitVar: (),
            v0_1: Array<dice_ui::model::near::backend::ResultWrapper>,
        ) -> Dice_ui::US25 {
            Dice_ui::US25::US25_1(v0_1)
        }
        pub fn closure71(unitVar: (), v0_1: string) -> Dice_ui::US25 {
            Dice_ui::US25::US25_0(v0_1)
        }
        pub fn method113(v0_1: i32, v1: LrcPtr<Dice_ui::Mut0>) -> bool {
            v1.l0.get() < v0_1
        }
        pub fn method114(
            v0_1: dice_ui::model::near::backend::ResultWrapper,
        ) -> dice_ui::model::near::backend::ResultWrapper {
            v0_1
        }
        pub fn closure72(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::DataWrapper,
        ) -> Dice_ui::US36 {
            Dice_ui::US36::US36_1(v0_1)
        }
        pub fn method115(
            v0_1: dice_ui::model::near::backend::DataWrapper,
        ) -> dice_ui::model::near::backend::DataWrapper {
            v0_1
        }
        pub fn method116(
            v0_1: dice_ui::model::near::backend::ResultData,
        ) -> dice_ui::model::near::backend::ResultData {
            v0_1
        }
        pub fn method118(
            v0_1: dice_ui::model::near::backend::AccountTransactionsCount,
        ) -> dice_ui::model::near::backend::AccountTransactionsCount {
            v0_1
        }
        pub fn closure73(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::AccountTransactionsCount,
        ) -> (u64, u64) {
            let v1: dice_ui::model::near::backend::AccountTransactionsCount =
                Dice_ui::method118(v0_1);
            (v1.in_transactions_count, v1.out_transactions_count)
        }
        pub fn method117(
        ) -> Func1<dice_ui::model::near::backend::AccountTransactionsCount, (u64, u64)> {
            Func1::new(
                move |v: dice_ui::model::near::backend::AccountTransactionsCount| {
                    Dice_ui::closure73((), v)
                },
            )
        }
        pub fn method120(
            v0_1: dice_ui::model::near::backend::ContractById,
        ) -> dice_ui::model::near::backend::ContractById {
            v0_1
        }
        pub fn closure75(unitVar: (), v0_1: u64) -> Dice_ui::US32 {
            Dice_ui::US32::US32_1(v0_1)
        }
        pub fn closure74(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::ContractById,
        ) -> (std::string::String, bool, Dice_ui::US32, Dice_ui::US15) {
            let v1: dice_ui::model::near::backend::ContractById = Dice_ui::method120(v0_1);
            let v3: std::string::String = v1.code_hash;
            let v8: Dice_ui::US15 = defaultValue(
                Dice_ui::US15::US15_0,
                map(
                    Func1::new(move |v: std::string::String| Dice_ui::closure29((), v)),
                    v1.transaction_hash,
                ),
            );
            let v13: Dice_ui::US32 = defaultValue(
                Dice_ui::US32::US32_0,
                map(
                    Func1::new(move |v_1: u64| Dice_ui::closure75((), v_1)),
                    v1.timestamp,
                ),
            );
            (v3, v1.locked, v13, v8)
        }
        pub fn method119() -> Func1<
            dice_ui::model::near::backend::ContractById,
            (std::string::String, bool, Dice_ui::US32, Dice_ui::US15),
        > {
            Func1::new(move |v: dice_ui::model::near::backend::ContractById| {
                Dice_ui::closure74((), v)
            })
        }
        pub fn method122(
            v0_1: dice_ui::model::near::backend::TransactionListByAccountId,
        ) -> dice_ui::model::near::backend::TransactionListByAccountId {
            v0_1
        }
        pub fn method124(
            v0_1: dice_ui::model::near::backend::Transaction,
        ) -> dice_ui::model::near::backend::Transaction {
            v0_1
        }
        pub fn method126(
            v0_1: dice_ui::model::near::backend::TransactionAction,
        ) -> dice_ui::model::near::backend::TransactionAction {
            v0_1
        }
        pub fn method128(
            v0_1: dice_ui::model::near::backend::FunctionCallArgs,
        ) -> dice_ui::model::near::backend::FunctionCallArgs {
            v0_1
        }
        pub fn closure79(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::FunctionCallArgs,
        ) -> (
            std::string::String,
            std::string::String,
            u64,
            std::string::String,
        ) {
            let v1: dice_ui::model::near::backend::FunctionCallArgs = Dice_ui::method128(v0_1);
            let v3: std::string::String = v1.method_name;
            let v5: std::string::String = v1.args;
            let v7: u64 = v1.gas;
            (v5, v1.deposit, v7, v3)
        }
        pub fn method127() -> Func1<
            dice_ui::model::near::backend::FunctionCallArgs,
            (
                std::string::String,
                std::string::String,
                u64,
                std::string::String,
            ),
        > {
            Func1::new(move |v: dice_ui::model::near::backend::FunctionCallArgs| {
                Dice_ui::closure79((), v)
            })
        }
        pub fn method130(
            v0_1: dice_ui::model::near::backend::AddKeyArgs,
        ) -> dice_ui::model::near::backend::AddKeyArgs {
            v0_1
        }
        pub fn method131(
            v0_1: dice_ui::model::near::backend::AccessKey,
        ) -> dice_ui::model::near::backend::AccessKey {
            v0_1
        }
        pub fn method132(
            v0_1: dice_ui::model::near::backend::Permission,
        ) -> dice_ui::model::near::backend::Permission {
            v0_1
        }
        pub fn method133(v0_1: Dice_ui::US15) -> Dice_ui::US15 {
            v0_1
        }
        pub fn closure81(unitVar: (), v0_1: Vec<std::string::String>) -> Dice_ui::US37 {
            Dice_ui::US37::US37_1(v0_1)
        }
        pub fn method134(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method135(v0_1: Array<std::string::String>) -> Array<std::string::String> {
            v0_1
        }
        pub fn method136(v0_1: Dice_ui::US35) -> Dice_ui::US35 {
            v0_1
        }
        pub fn closure80(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::AddKeyArgs,
        ) -> (
            u8,
            Dice_ui::US15,
            Dice_ui::US35,
            std::string::String,
            std::string::String,
        ) {
            let v1: dice_ui::model::near::backend::AddKeyArgs = Dice_ui::method130(v0_1);
            let v3: std::string::String = v1.public_key;
            let v6: dice_ui::model::near::backend::AccessKey = Dice_ui::method131(v1.access_key);
            let v8: u8 = v6.nonce;
            let v11: dice_ui::model::near::backend::Permission = Dice_ui::method132(v6.permission);
            let v13: std::string::String = v11.permission_type;
            let v19: Dice_ui::US15 = Dice_ui::method133(defaultValue(
                Dice_ui::US15::US15_0,
                map(
                    Func1::new(move |v: std::string::String| Dice_ui::closure29((), v)),
                    v11.contract_id,
                ),
            ));
            let v24: Dice_ui::US37 = defaultValue(
                Dice_ui::US37::US37_0,
                map(
                    Func1::new(move |v_1: Vec<std::string::String>| Dice_ui::closure81((), v_1)),
                    v11.method_names,
                ),
            );
            let v32: Dice_ui::US38 = match &v24 {
                Dice_ui::US37::US37_1(v24_1_0) => {
                    let v26: Vec<std::string::String> = Dice_ui::method134(v24_1_0.clone());
                    Dice_ui::US38::US38_1(fable_library_rust::NativeArray_::array_from(v26))
                }
                _ => Dice_ui::US38::US38_0,
            };
            (
                v8,
                v19,
                Dice_ui::method136(match &v32 {
                    Dice_ui::US38::US38_1(v32_1_0) => {
                        Dice_ui::US35::US35_1(Dice_ui::method135(v32_1_0.clone()))
                    }
                    _ => Dice_ui::US35::US35_0,
                }),
                v13,
                v3,
            )
        }
        pub fn method129() -> Func1<
            dice_ui::model::near::backend::AddKeyArgs,
            (
                u8,
                Dice_ui::US15,
                Dice_ui::US35,
                std::string::String,
                std::string::String,
            ),
        > {
            Func1::new(move |v: dice_ui::model::near::backend::AddKeyArgs| {
                Dice_ui::closure80((), v)
            })
        }
        pub fn method138(
            v0_1: dice_ui::model::near::backend::DeployContractArgs,
        ) -> dice_ui::model::near::backend::DeployContractArgs {
            v0_1
        }
        pub fn closure82(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::DeployContractArgs,
        ) -> std::string::String {
            let v1: dice_ui::model::near::backend::DeployContractArgs = Dice_ui::method138(v0_1);
            v1.code
        }
        pub fn method137(
        ) -> Func1<dice_ui::model::near::backend::DeployContractArgs, std::string::String> {
            Func1::new(
                move |v: dice_ui::model::near::backend::DeployContractArgs| {
                    Dice_ui::closure82((), v)
                },
            )
        }
        pub fn method140(
            v0_1: dice_ui::model::near::backend::TransferArgs,
        ) -> dice_ui::model::near::backend::TransferArgs {
            v0_1
        }
        pub fn closure83(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::TransferArgs,
        ) -> std::string::String {
            let v1: dice_ui::model::near::backend::TransferArgs = Dice_ui::method140(v0_1);
            v1.deposit
        }
        pub fn method139() -> Func1<dice_ui::model::near::backend::TransferArgs, std::string::String>
        {
            Func1::new(move |v: dice_ui::model::near::backend::TransferArgs| {
                Dice_ui::closure83((), v)
            })
        }
        pub fn closure84(
            unitVar: (),
            _arg: (
                std::string::String,
                std::string::String,
                u64,
                std::string::String,
            ),
        ) -> Dice_ui::US34 {
            Dice_ui::US34::US34_2(
                _arg.0.clone(),
                _arg.1.clone(),
                _arg.2.clone(),
                _arg.3.clone(),
            )
        }
        pub fn method141() -> Func1<
            (
                std::string::String,
                std::string::String,
                u64,
                std::string::String,
            ),
            Dice_ui::US34,
        > {
            Func1::new(
                move |arg10_0040: (
                    std::string::String,
                    std::string::String,
                    u64,
                    std::string::String,
                )| Dice_ui::closure84((), arg10_0040),
            )
        }
        pub fn closure85(
            unitVar: (),
            _arg: (
                u8,
                Dice_ui::US15,
                Dice_ui::US35,
                std::string::String,
                std::string::String,
            ),
        ) -> Dice_ui::US34 {
            Dice_ui::US34::US34_0(
                _arg.0.clone(),
                _arg.1.clone(),
                _arg.2.clone(),
                _arg.3.clone(),
                _arg.4.clone(),
            )
        }
        pub fn method142() -> Func1<
            (
                u8,
                Dice_ui::US15,
                Dice_ui::US35,
                std::string::String,
                std::string::String,
            ),
            Dice_ui::US34,
        > {
            Func1::new(
                move |arg10_0040: (
                    u8,
                    Dice_ui::US15,
                    Dice_ui::US35,
                    std::string::String,
                    std::string::String,
                )| Dice_ui::closure85((), arg10_0040),
            )
        }
        pub fn closure86(unitVar: (), v0_1: std::string::String) -> Dice_ui::US34 {
            Dice_ui::US34::US34_1(v0_1)
        }
        pub fn method143() -> Func1<std::string::String, Dice_ui::US34> {
            Func1::new(move |v: std::string::String| Dice_ui::closure86((), v))
        }
        pub fn closure87(unitVar: (), v0_1: std::string::String) -> Dice_ui::US34 {
            Dice_ui::US34::US34_3(v0_1)
        }
        pub fn method144() -> Func1<std::string::String, Dice_ui::US34> {
            Func1::new(move |v: std::string::String| Dice_ui::closure87((), v))
        }
        pub fn closure78(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::TransactionAction,
        ) -> Dice_ui::US34 {
            let v1: dice_ui::model::near::backend::TransactionAction = Dice_ui::method126(v0_1);
            let v2 = Dice_ui::method127();
            let v3 = Dice_ui::method129();
            let v4 = Dice_ui::method137();
            let v5 = Dice_ui::method139();
            let v6 = Dice_ui::method141();
            let v7 = Dice_ui::method142();
            let v8 = Dice_ui::method143();
            let v9 = Dice_ui::method144();
            let v10: string =
                string("match v1 { dice_ui::model::near::backend::TransactionAction::FunctionCall(x) => v6(v2(x)), dice_ui::model::near::backend::TransactionAction::AddKey(x) => v7(v3(x)), dice_ui::model::near::backend::TransactionAction::DeployContract(x) => v8(v4(x)), dice_ui::model::near::backend::TransactionAction::Transfer(x) => v9(v5(x)) }");
            match v1 {
                dice_ui::model::near::backend::TransactionAction::FunctionCall(x) => v6(v2(x)),
                dice_ui::model::near::backend::TransactionAction::AddKey(x) => v7(v3(x)),
                dice_ui::model::near::backend::TransactionAction::DeployContract(x) => v8(v4(x)),
                dice_ui::model::near::backend::TransactionAction::Transfer(x) => v9(v5(x)),
            }
        }
        pub fn method125() -> Func1<dice_ui::model::near::backend::TransactionAction, Dice_ui::US34>
        {
            Func1::new(move |v: dice_ui::model::near::backend::TransactionAction| {
                Dice_ui::closure78((), v)
            })
        }
        pub fn method145(v0_1: Vec<Dice_ui::US34>) -> Vec<Dice_ui::US34> {
            v0_1
        }
        pub fn method146(v0_1: Array<Dice_ui::US34>) -> Array<Dice_ui::US34> {
            v0_1
        }
        pub fn closure77(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::Transaction,
        ) -> (
            Array<Dice_ui::US34>,
            std::string::String,
            u64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        ) {
            let v1: dice_ui::model::near::backend::Transaction = Dice_ui::method124(v0_1);
            let v3: std::string::String = v1.hash.clone();
            let v5: std::string::String = v1.signer_id.clone();
            let v7: std::string::String = v1.receiver_id.clone();
            let v9: std::string::String = v1.block_hash.clone();
            let v11: u64 = v1.block_timestamp.clone();
            let v12 = Dice_ui::method125();
            let v15: Vec<Dice_ui::US34> =
                Dice_ui::method145(v1.actions.into_iter().map(|x| v12(x)).collect());
            (
                Dice_ui::method146(fable_library_rust::NativeArray_::array_from(v15)),
                v9,
                v11,
                v3,
                v7,
                v5,
                v1.status.clone(),
            )
        }
        pub fn method123() -> Func1<
            dice_ui::model::near::backend::Transaction,
            (
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
        > {
            Func1::new(move |v: dice_ui::model::near::backend::Transaction| {
                Dice_ui::closure77((), v)
            })
        }
        pub fn method147(
            v0_1: Vec<(
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Vec<(
            Array<Dice_ui::US34>,
            std::string::String,
            u64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn method148(
            v0_1: Array<(
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Array<(
            Array<Dice_ui::US34>,
            std::string::String,
            u64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn closure88(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::TransactionCursor,
        ) -> Dice_ui::US39 {
            Dice_ui::US39::US39_1(v0_1)
        }
        pub fn method149(
            v0_1: dice_ui::model::near::backend::TransactionCursor,
        ) -> dice_ui::model::near::backend::TransactionCursor {
            v0_1
        }
        pub fn method150(v0_1: Dice_ui::US33) -> Dice_ui::US33 {
            v0_1
        }
        pub fn closure76(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::TransactionListByAccountId,
        ) -> (
            Dice_ui::US33,
            Array<(
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) {
            let v1: dice_ui::model::near::backend::TransactionListByAccountId =
                Dice_ui::method122(v0_1);
            let v2 = Dice_ui::method123();
            let v5: Vec<(
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )> = Dice_ui::method147(v1.items.into_iter().map(|x| v2(x)).collect());
            let v8: Array<(
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )> = Dice_ui::method148(fable_library_rust::NativeArray_::array_from(v5));
            let v13: Dice_ui::US39 = defaultValue(
                Dice_ui::US39::US39_0,
                map(
                    Func1::new(move |v: dice_ui::model::near::backend::TransactionCursor| {
                        Dice_ui::closure88((), v)
                    }),
                    v1.cursor,
                ),
            );
            (
                Dice_ui::method150(match &v13 {
                    Dice_ui::US39::US39_1(v13_1_0) => {
                        let v15: dice_ui::model::near::backend::TransactionCursor =
                            Dice_ui::method149(v13_1_0.clone());
                        let v17: std::string::String = v15.timestamp;
                        Dice_ui::US33::US33_1(v15.index_in_chunk, v17)
                    }
                    _ => Dice_ui::US33::US33_0,
                }),
                v8,
            )
        }
        pub fn method121() -> Func1<
            dice_ui::model::near::backend::TransactionListByAccountId,
            (
                Dice_ui::US33,
                Array<(
                    Array<Dice_ui::US34>,
                    std::string::String,
                    u64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            ),
        > {
            Func1::new(
                move |v: dice_ui::model::near::backend::TransactionListByAccountId| {
                    Dice_ui::closure76((), v)
                },
            )
        }
        pub fn closure89(unitVar: (), _arg: (u64, u64)) -> Dice_ui::US31 {
            Dice_ui::US31::US31_0(_arg.0.clone(), _arg.1.clone())
        }
        pub fn method151() -> Func1<(u64, u64), Dice_ui::US31> {
            Func1::new(move |arg10_0040: (u64, u64)| Dice_ui::closure89((), arg10_0040))
        }
        pub fn closure90(
            unitVar: (),
            _arg: (std::string::String, bool, Dice_ui::US32, Dice_ui::US15),
        ) -> Dice_ui::US31 {
            Dice_ui::US31::US31_1(
                _arg.0.clone(),
                _arg.1.clone(),
                _arg.2.clone(),
                _arg.3.clone(),
            )
        }
        pub fn method152(
        ) -> Func1<(std::string::String, bool, Dice_ui::US32, Dice_ui::US15), Dice_ui::US31>
        {
            Func1::new(
                move |arg10_0040: (std::string::String, bool, Dice_ui::US32, Dice_ui::US15)| {
                    Dice_ui::closure90((), arg10_0040)
                },
            )
        }
        pub fn closure91(
            unitVar: (),
            _arg: (
                Dice_ui::US33,
                Array<(
                    Array<Dice_ui::US34>,
                    std::string::String,
                    u64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            ),
        ) -> Dice_ui::US31 {
            Dice_ui::US31::US31_2(_arg.0.clone(), _arg.1.clone())
        }
        pub fn method153() -> Func1<
            (
                Dice_ui::US33,
                Array<(
                    Array<Dice_ui::US34>,
                    std::string::String,
                    u64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )>,
            ),
            Dice_ui::US31,
        > {
            Func1::new(
                move |arg10_0040: (
                    Dice_ui::US33,
                    Array<(
                        Array<Dice_ui::US34>,
                        std::string::String,
                        u64,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                        std::string::String,
                    )>,
                )| Dice_ui::closure91((), arg10_0040),
            )
        }
        pub fn closure92(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::ErrorWrapperEnum,
        ) -> Dice_ui::US40 {
            Dice_ui::US40::US40_1(v0_1)
        }
        pub fn method154(
            v0_1: dice_ui::model::near::backend::ErrorWrapperEnum,
        ) -> dice_ui::model::near::backend::ErrorWrapperEnum {
            v0_1
        }
        pub fn method156(
            v0_1: dice_ui::model::near::backend::ErrorWrapper,
        ) -> dice_ui::model::near::backend::ErrorWrapper {
            v0_1
        }
        pub fn method157(
            v0_1: dice_ui::model::near::backend::ErrorData,
        ) -> dice_ui::model::near::backend::ErrorData {
            v0_1
        }
        pub fn closure93(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::ErrorWrapper,
        ) -> (
            i32,
            std::string::String,
            u32,
            std::string::String,
            std::string::String,
        ) {
            let v1: dice_ui::model::near::backend::ErrorWrapper = Dice_ui::method156(v0_1);
            let v4: dice_ui::model::near::backend::ErrorData = Dice_ui::method157(v1.error);
            let v6: std::string::String = v4.message;
            let v8: i32 = v4.code;
            let v10: dice_ui::model::near::backend::ErrorDataInner = v4.data;
            (v8, v10.code, v10.http_status, v10.path, v6)
        }
        pub fn method155() -> Func1<
            dice_ui::model::near::backend::ErrorWrapper,
            (
                i32,
                std::string::String,
                u32,
                std::string::String,
                std::string::String,
            ),
        > {
            Func1::new(move |v: dice_ui::model::near::backend::ErrorWrapper| {
                Dice_ui::closure93((), v)
            })
        }
        pub fn closure94(
            unitVar: (),
            v0_1: dice_ui::model::near::backend::ErrorData,
        ) -> (
            i32,
            std::string::String,
            u32,
            std::string::String,
            std::string::String,
        ) {
            let v1: dice_ui::model::near::backend::ErrorData = Dice_ui::method157(v0_1);
            let v3: std::string::String = v1.message;
            let v5: i32 = v1.code;
            let v7: dice_ui::model::near::backend::ErrorDataInner = v1.data;
            (v5, v7.code, v7.http_status, v7.path, v3)
        }
        pub fn method158() -> Func1<
            dice_ui::model::near::backend::ErrorData,
            (
                i32,
                std::string::String,
                u32,
                std::string::String,
                std::string::String,
            ),
        > {
            Func1::new(move |v: dice_ui::model::near::backend::ErrorData| Dice_ui::closure94((), v))
        }
        pub fn closure95(
            unitVar: (),
            _arg: (
                i32,
                std::string::String,
                u32,
                std::string::String,
                std::string::String,
            ),
        ) -> Dice_ui::US29 {
            Dice_ui::US29::US29_1(
                _arg.0.clone(),
                _arg.1.clone(),
                _arg.2.clone(),
                _arg.3.clone(),
                _arg.4.clone(),
            )
        }
        pub fn method159() -> Func1<
            (
                i32,
                std::string::String,
                u32,
                std::string::String,
                std::string::String,
            ),
            Dice_ui::US29,
        > {
            Func1::new(
                move |arg10_0040: (
                    i32,
                    std::string::String,
                    u32,
                    std::string::String,
                    std::string::String,
                )| Dice_ui::closure95((), arg10_0040),
            )
        }
        pub fn closure96(
            unitVar: (),
            _arg: (
                i32,
                std::string::String,
                u32,
                std::string::String,
                std::string::String,
            ),
        ) -> Dice_ui::US29 {
            Dice_ui::US29::US29_0(
                _arg.0.clone(),
                _arg.1.clone(),
                _arg.2.clone(),
                _arg.3.clone(),
                _arg.4.clone(),
            )
        }
        pub fn method160() -> Func1<
            (
                i32,
                std::string::String,
                u32,
                std::string::String,
                std::string::String,
            ),
            Dice_ui::US29,
        > {
            Func1::new(
                move |arg10_0040: (
                    i32,
                    std::string::String,
                    u32,
                    std::string::String,
                    std::string::String,
                )| Dice_ui::closure96((), arg10_0040),
            )
        }
        pub fn closure69(
            v0_1: leptos::Memo<Dice_ui::US23>,
            v1: leptos::Memo<Dice_ui::US23>,
        ) -> Dice_ui::US26 {
            let v2: leptos::Memo<Dice_ui::US23> = Dice_ui::method112(v0_1);
            let v4: Dice_ui::US23 = v2();
            let v65: Dice_ui::US26 = match &v4 {
                Dice_ui::US23::US23_1(v4_1_0) => {
                    let v5: Result<Array<dice_ui::model::near::backend::ResultWrapper>, string> =
                        v4_1_0.clone();
                    let v8: Dice_ui::US25 = match &v5 {
                        Err(v5_1_0) => Dice_ui::closure71((), v5_1_0.clone()),
                        Ok(v5_0_0) => Dice_ui::closure70((), v5_0_0.clone()),
                    };
                    Dice_ui::US26::US26_1(match &v8 {
                        Dice_ui::US25::US25_1(v8_1_0) => {
                            let v9: Array<dice_ui::model::near::backend::ResultWrapper> =
                                v8_1_0.clone();
                            let v10: i32 = count(v9.clone());
                            let v11: Array<(Dice_ui::US28, Dice_ui::US30)> =
                                new_init(&defaultOf::<(Dice_ui::US28, Dice_ui::US30)>(), v10);
                            let v12: LrcPtr<Dice_ui::Mut0> = LrcPtr::new(Dice_ui::Mut0 {
                                l0: MutCell::new(0_i32),
                            });
                            while Dice_ui::method113(v10, v12.clone()) {
                                let v14: i32 = v12.l0.get();
                                let v16: dice_ui::model::near::backend::ResultWrapper =
                                    Dice_ui::method114(v9[v14].clone());
                                let v21:
                                                                  Dice_ui::US36 =
                                                              defaultValue(Dice_ui::US36::US36_0,
                                                                           map(Func1::new(move
                                                                                              |v_2:
                                                                                                   dice_ui::model::near::backend::DataWrapper|
                                                                                              Dice_ui::closure72((),
                                                                                                                 v_2)),
                                                                               v16.result.clone()));
                                let v38: Dice_ui::US30 = match &v21 {
                                    Dice_ui::US36::US36_1(v21_1_0) => {
                                        let v23: dice_ui::model::near::backend::DataWrapper =
                                            Dice_ui::method115(v21_1_0.clone());
                                        let v26: dice_ui::model::near::backend::ResultData =
                                            Dice_ui::method116(v23.data);
                                        let v27 = Dice_ui::method117();
                                        let v28 = Dice_ui::method119();
                                        let v29 = Dice_ui::method121();
                                        let v30 = Dice_ui::method151();
                                        let v31 = Dice_ui::method152();
                                        let v32 = Dice_ui::method153();
                                        let v33:
                                                                              string =
                                                                          string("match v26 { dice_ui::model::near::backend::ResultData::AccountTransactionsCount(x) => v30(v27(x)), dice_ui::model::near::backend::ResultData::ContractById(x) => v31(v28(x)), dice_ui::model::near::backend::ResultData::TransactionListByAccountId(x) => v32(v29(x)) }");
                                        Dice_ui::US30::US30_1(match v26 { dice_ui::model::near::backend::ResultData::AccountTransactionsCount(x) => v30(v27(x)), dice_ui::model::near::backend::ResultData::ContractById(x) => v31(v28(x)), dice_ui::model::near::backend::ResultData::TransactionListByAccountId(x) => v32(v29(x)) })
                                    }
                                    _ => Dice_ui::US30::US30_0,
                                };
                                let v43:
                                                                  Dice_ui::US40 =
                                                              defaultValue(Dice_ui::US40::US40_0,
                                                                           map(Func1::new(move
                                                                                              |v_3:
                                                                                                   dice_ui::model::near::backend::ErrorWrapperEnum|
                                                                                              Dice_ui::closure92((),
                                                                                                                 v_3)),
                                                                               v16.error.clone()));
                                let v55: Dice_ui::US28 = match &v43 {
                                    Dice_ui::US40::US40_1(v43_1_0) => {
                                        let v45: dice_ui::model::near::backend::ErrorWrapperEnum =
                                            Dice_ui::method154(v43_1_0.clone());
                                        let v46 = Dice_ui::method155();
                                        let v47 = Dice_ui::method158();
                                        let v48 = Dice_ui::method159();
                                        let v49 = Dice_ui::method160();
                                        let v50:
                                                                              string =
                                                                          string("match v45 { dice_ui::model::near::backend::ErrorWrapperEnum::ErrorWrapper(x) => v48(v46(x)), dice_ui::model::near::backend::ErrorWrapperEnum::ErrorData(x) => v49(v47(x)) }");
                                        Dice_ui::US28::US28_1(match v45 { dice_ui::model::near::backend::ErrorWrapperEnum::ErrorWrapper(x) => v48(v46(x)), dice_ui::model::near::backend::ErrorWrapperEnum::ErrorData(x) => v49(v47(x)) })
                                    }
                                    _ => Dice_ui::US28::US28_0,
                                };
                                v11.get_mut()[v14 as usize] = (v55, v38);
                                {
                                    let v56: i32 = v14 + 1_i32;
                                    v12.l0.set(v56);
                                    ()
                                }
                            }
                            Dice_ui::US27::US27_1(v11.clone())
                        }
                        Dice_ui::US25::US25_0(v8_0_0) => Dice_ui::US27::US27_0(v8_0_0.clone()),
                    })
                }
                _ => Dice_ui::US26::US26_0,
            };
            let v67: string = append(
                append(
                    string("history.render () / result_wrapper move / result: "),
                    sprintf!("{:?}", &v65),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v67);
            v65
        }
        pub fn method111(
            v0_1: leptos::Memo<Dice_ui::US23>,
        ) -> Func1<leptos::Memo<Dice_ui::US23>, Dice_ui::US26> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::Memo<Dice_ui::US23>| Dice_ui::closure69(v0_1.clone(), v)
            })
        }
        pub fn closure97(v0_1: Func0<Dice_ui::US26>, unitVar: ()) -> Func0<Dice_ui::US26> {
            v0_1
        }
        pub fn method161(v0_1: Func0<Dice_ui::US26>) -> Func0<Func0<Dice_ui::US26>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure97(v0_1.clone(), ())
            })
        }
        pub fn method163(v0_1: Func0<Dice_ui::US26>) -> Func0<Dice_ui::US26> {
            v0_1
        }
        pub fn method164(v0_1: i32, v1: LrcPtr<Dice_ui::Mut1>) -> bool {
            v1.l0.get() < v0_1
        }
        pub fn closure98(unitVar: (), v0_1: Func0<Dice_ui::US26>) -> Dice_ui::US41 {
            let v1: Func0<Dice_ui::US26> = Dice_ui::method163(v0_1);
            let v3: Dice_ui::US26 = v1();
            let v46: Dice_ui::US41 = match &v3 {
                Dice_ui::US26::US26_1(v3_1_0) => {
                    let v4: Dice_ui::US27 = v3_1_0.clone();
                    let v37: Dice_ui::US43 = match &v4 {
                        Dice_ui::US27::US27_1(v4_1_0) => {
                            let v5: Array<(Dice_ui::US28, Dice_ui::US30)> = v4_1_0.clone();
                            let v6: i32 = count(v5.clone());
                            let v8: LrcPtr<Dice_ui::Mut1> = LrcPtr::new(Dice_ui::Mut1 {
                                l0: MutCell::new(0_i32),
                                l1: MutCell::new(Dice_ui::US44::US44_0),
                            });
                            while Dice_ui::method164(v6, v8.clone()) {
                                let v10: i32 = v8.l0.get();
                                let v13: i32 = -v10 + v6 - 1_i32;
                                let v14: Dice_ui::US44 = v8.l1.get().clone();
                                let v16: Dice_ui::US30 = (v5[v13].clone()).1.clone();
                                let v24: Dice_ui::US44 = match &v14 {
                                    Dice_ui::US44::US44_1(v14_1_0) => v14.clone(),
                                    _ => match &v16 {
                                        Dice_ui::US30::US30_1(v16_1_0) => {
                                            Dice_ui::US44::US44_1(v16_1_0.clone())
                                        }
                                        _ => Dice_ui::US44::US44_0,
                                    },
                                };
                                let v25: i32 = v10 + 1_i32;
                                v8.l0.set(v25);
                                v8.l1.set(v24);
                                ()
                            }
                            {
                                let v26: Dice_ui::US44 = v8.l1.get().clone();
                                Dice_ui::US43::US43_1(match &v26 {
                                    Dice_ui::US44::US44_1(v26_1_0) => {
                                        Dice_ui::US42::US42_1(v26_1_0.clone())
                                    }
                                    _ => Dice_ui::US42::US42_0(string(
                                        "Option does not have a value.",
                                    )),
                                })
                            }
                        }
                        Dice_ui::US27::US27_0(v4_0_0) => Dice_ui::US43::US43_0(v4_0_0.clone()),
                    };
                    Dice_ui::US41::US41_1(match &v37 {
                        Dice_ui::US43::US43_1(v37_1_0) => v37_1_0.clone(),
                        Dice_ui::US43::US43_0(v37_0_0) => Dice_ui::US42::US42_0(v37_0_0.clone()),
                    })
                }
                _ => Dice_ui::US41::US41_0,
            };
            let v48: string = append(
                append(
                    string("history.render () / result_data move / result: "),
                    sprintf!("{:?}", &v46),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v48);
            v46
        }
        pub fn method162() -> Func1<Func0<Dice_ui::US26>, Dice_ui::US41> {
            Func1::new(move |v: Func0<Dice_ui::US26>| Dice_ui::closure98((), v))
        }
        pub fn closure99(v0_1: Func0<Dice_ui::US41>, unitVar: ()) -> Func0<Dice_ui::US41> {
            v0_1
        }
        pub fn method165(v0_1: Func0<Dice_ui::US41>) -> Func0<Func0<Dice_ui::US41>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure99(v0_1.clone(), ())
            })
        }
        pub fn method167(v0_1: Func0<Dice_ui::US41>) -> Func0<Dice_ui::US41> {
            v0_1
        }
        pub fn closure100(v0_1: Func0<Dice_ui::US41>, v1: Func0<Dice_ui::US41>) -> Dice_ui::US45 {
            let v2: Func0<Dice_ui::US41> = Dice_ui::method167(v0_1);
            let v4: Dice_ui::US41 = v2();
            let v20: Dice_ui::US47 = match &v4 {
                Dice_ui::US41::US41_1(v4_1_0) => {
                    let v5: Dice_ui::US42 = v4_1_0.clone();
                    Dice_ui::US47::US47_1(match &v5 {
                        Dice_ui::US42::US42_1(v5_1_0) => {
                            let v6: Dice_ui::US31 = v5_1_0.clone();
                            Dice_ui::US48::US48_1(
                                if let Dice_ui::US31::US31_0(v6_0_0, v6_0_1) = &v6 {
                                    Dice_ui::US49::US49_1(
                                        match &v6 {
                                            Dice_ui::US31::US31_0(x, _) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        match &v6 {
                                            Dice_ui::US31::US31_0(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                    )
                                } else {
                                    Dice_ui::US49::US49_0
                                },
                            )
                        }
                        Dice_ui::US42::US42_0(v5_0_0) => Dice_ui::US48::US48_0(v5_0_0.clone()),
                    })
                }
                _ => Dice_ui::US47::US47_0,
            };
            let v32: Dice_ui::US45 = if let Dice_ui::US47::US47_1(v20_1_0) = &v20 {
                let v21: Dice_ui::US48 = match &v20 {
                    Dice_ui::US47::US47_1(x) => x.clone(),
                    _ => unreachable!(),
                };
                if let Dice_ui::US48::US48_1(v21_1_0) = &v21 {
                    let v22: Dice_ui::US49 = match &v21 {
                        Dice_ui::US48::US48_1(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Dice_ui::US49::US49_1(v22_1_0, v22_1_1) = &v22 {
                        Dice_ui::US45::US45_1(Dice_ui::US46::US46_1(
                            match &v22 {
                                Dice_ui::US49::US49_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            },
                            match &v22 {
                                Dice_ui::US49::US49_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            },
                        ))
                    } else {
                        Dice_ui::US45::US45_0
                    }
                } else {
                    Dice_ui::US45::US45_0
                }
            } else {
                Dice_ui::US45::US45_0
            };
            let v34: string = append(
                append(
                    string("history.render () / transaction_count move / result: "),
                    sprintf!("{:?}", &v32),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v34);
            v32
        }
        pub fn method166(v0_1: Func0<Dice_ui::US41>) -> Func1<Func0<Dice_ui::US41>, Dice_ui::US45> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Func0<Dice_ui::US41>| Dice_ui::closure100(v0_1.clone(), v)
            })
        }
        pub fn closure101(v0_1: Func0<Dice_ui::US41>, unitVar: ()) -> Func0<Dice_ui::US41> {
            v0_1
        }
        pub fn method168(v0_1: Func0<Dice_ui::US41>) -> Func0<Func0<Dice_ui::US41>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure101(v0_1.clone(), ())
            })
        }
        pub fn closure102(v0_1: Func0<Dice_ui::US41>, v1: Func0<Dice_ui::US41>) -> Dice_ui::US50 {
            let v2: Func0<Dice_ui::US41> = Dice_ui::method167(v0_1);
            let v4: Dice_ui::US41 = v2();
            let v20: Dice_ui::US52 = match &v4 {
                Dice_ui::US41::US41_1(v4_1_0) => {
                    let v5: Dice_ui::US42 = v4_1_0.clone();
                    Dice_ui::US52::US52_1(match &v5 {
                        Dice_ui::US42::US42_1(v5_1_0) => {
                            let v6: Dice_ui::US31 = v5_1_0.clone();
                            Dice_ui::US53::US53_1(
                                if let Dice_ui::US31::US31_2(v6_2_0, v6_2_1) = &v6 {
                                    Dice_ui::US54::US54_1(
                                        match &v6 {
                                            Dice_ui::US31::US31_2(x, _) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        match &v6 {
                                            Dice_ui::US31::US31_2(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                    )
                                } else {
                                    Dice_ui::US54::US54_0
                                },
                            )
                        }
                        Dice_ui::US42::US42_0(v5_0_0) => Dice_ui::US53::US53_0(v5_0_0.clone()),
                    })
                }
                _ => Dice_ui::US52::US52_0,
            };
            let v32: Dice_ui::US50 = if let Dice_ui::US52::US52_1(v20_1_0) = &v20 {
                let v21: Dice_ui::US53 = match &v20 {
                    Dice_ui::US52::US52_1(x) => x.clone(),
                    _ => unreachable!(),
                };
                if let Dice_ui::US53::US53_1(v21_1_0) = &v21 {
                    let v22: Dice_ui::US54 = match &v21 {
                        Dice_ui::US53::US53_1(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Dice_ui::US54::US54_1(v22_1_0, v22_1_1) = &v22 {
                        Dice_ui::US50::US50_1(Dice_ui::US51::US51_1(
                            match &v22 {
                                Dice_ui::US54::US54_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            },
                            match &v22 {
                                Dice_ui::US54::US54_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            },
                        ))
                    } else {
                        Dice_ui::US50::US50_0
                    }
                } else {
                    Dice_ui::US50::US50_0
                }
            } else {
                Dice_ui::US50::US50_0
            };
            let v34: string = append(
                append(
                    string("history.render () / transaction_list move / result: "),
                    sprintf!("{:?}", &v32),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v34);
            v32
        }
        pub fn method169(v0_1: Func0<Dice_ui::US41>) -> Func1<Func0<Dice_ui::US41>, Dice_ui::US50> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Func0<Dice_ui::US41>| Dice_ui::closure102(v0_1.clone(), v)
            })
        }
        pub fn closure103(v0_1: Func0<Dice_ui::US50>, unitVar: ()) -> Func0<Dice_ui::US50> {
            v0_1
        }
        pub fn method170(v0_1: Func0<Dice_ui::US50>) -> Func0<Func0<Dice_ui::US50>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure103(v0_1.clone(), ())
            })
        }
        pub fn method172(v0_1: Func0<Dice_ui::US50>) -> Func0<Dice_ui::US50> {
            v0_1
        }
        pub fn closure104(v0_1: Func0<Dice_ui::US50>, v1: Func0<Dice_ui::US50>) -> Dice_ui::US55 {
            let v2: Func0<Dice_ui::US50> = Dice_ui::method172(v0_1);
            let v4: Dice_ui::US50 = v2();
            let v28: Dice_ui::US55 = match &v4 {
                Dice_ui::US50::US50_1(v4_1_0) => {
                    let v5: Dice_ui::US51 = v4_1_0.clone();
                    let v19: Dice_ui::US57 = match &v5 {
                        Dice_ui::US51::US51_1(v5_1_0, v5_1_1) => {
                            let v6: Dice_ui::US33 = v5_1_0.clone();
                            Dice_ui::US57::US57_1(match &v6 {
                                Dice_ui::US33::US33_1(v6_1_0, v6_1_1) => {
                                    Dice_ui::US56::US56_1(v6_1_0.clone(), v6_1_1.clone())
                                }
                                _ => Dice_ui::US56::US56_0(string("Option does not have a value.")),
                            })
                        }
                        Dice_ui::US51::US51_0(v5_0_0) => Dice_ui::US57::US57_0(v5_0_0.clone()),
                    };
                    Dice_ui::US55::US55_1(match &v19 {
                        Dice_ui::US57::US57_1(v19_1_0) => v19_1_0.clone(),
                        Dice_ui::US57::US57_0(v19_0_0) => Dice_ui::US56::US56_0(v19_0_0.clone()),
                    })
                }
                _ => Dice_ui::US55::US55_0,
            };
            let v30: string = append(
                append(
                    string("history.render () / cursor move / result: "),
                    sprintf!("{:?}", &v28),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v30);
            v28
        }
        pub fn method171(v0_1: Func0<Dice_ui::US50>) -> Func1<Func0<Dice_ui::US50>, Dice_ui::US55> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Func0<Dice_ui::US50>| Dice_ui::closure104(v0_1.clone(), v)
            })
        }
        pub fn closure105(unitVar: (), unitVar_1: ()) -> i32 {
            0_i32
        }
        pub fn method173() -> Func0<i32> {
            Func0::new(move || Dice_ui::closure105((), ()))
        }
        pub fn closure106(v0_1: Func0<Dice_ui::US50>, v1: i32) -> Dice_ui::US58 {
            let v2: Func0<Dice_ui::US50> = Dice_ui::method172(v0_1);
            let v4: Dice_ui::US50 = v2();
            let v16: Dice_ui::US58 = match &v4 {
                Dice_ui::US50::US50_1(v4_1_0) => {
                    let v5: Dice_ui::US51 = v4_1_0.clone();
                    Dice_ui::US58::US58_1(match &v5 {
                        Dice_ui::US51::US51_1(v5_1_0, v5_1_1) => {
                            Dice_ui::US59::US59_1(v5_1_1.clone())
                        }
                        Dice_ui::US51::US51_0(v5_0_0) => Dice_ui::US59::US59_0(v5_0_0.clone()),
                    })
                }
                _ => Dice_ui::US58::US58_0,
            };
            let v18: string = append(
                append(
                    string("history.render () / transactions move / result: "),
                    sprintf!("{:?}", &v16),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v18);
            v16
        }
        pub fn method174(v0_1: Func0<Dice_ui::US50>) -> Func1<i32, Dice_ui::US58> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: i32| Dice_ui::closure106(v0_1.clone(), v)
            })
        }
        pub fn method175() -> string {
            string("History")
        }
        pub fn closure108(v0_1: Func0<Dice_ui::US58>, unitVar: ()) -> Func0<Dice_ui::US58> {
            v0_1
        }
        pub fn method177(v0_1: Func0<Dice_ui::US58>) -> Func0<Func0<Dice_ui::US58>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure108(v0_1.clone(), ())
            })
        }
        pub fn method179(v0_1: Func0<Dice_ui::US58>) -> Func0<Dice_ui::US58> {
            v0_1
        }
        pub fn method180(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> leptos::HtmlElement<leptos::svg::Svg> {
            v0_1
        }
        pub fn method181(v0_1: string) -> string {
            v0_1
        }
        pub fn method182(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method183(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method184(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method186(
            v0_1: Array<(
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Array<(
            Array<Dice_ui::US34>,
            std::string::String,
            u64,
            std::string::String,
            std::string::String,
            std::string::String,
            std::string::String,
        )> {
            v0_1
        }
        pub fn closure111(
            unitVar: (),
            _arg: (
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
        ) -> std::string::String {
            _arg.3.clone()
        }
        pub fn method187() -> Func1<
            (
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
            std::string::String,
        > {
            Func1::new(
                move |arg10_0040: (
                    Array<Dice_ui::US34>,
                    std::string::String,
                    u64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )| Dice_ui::closure111((), arg10_0040),
            )
        }
        pub fn method191() -> string {
            string("Transaction")
        }
        pub fn closure114(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method191()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method190() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure114((), ()))
        }
        pub fn method192(
            v0_1: leptos::HtmlElement<leptos::html::Span>,
        ) -> leptos::HtmlElement<leptos::html::Span> {
            v0_1
        }
        pub fn method195() -> string {
            string("Block Timestamp")
        }
        pub fn closure116(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method195()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method194() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure116((), ()))
        }
        pub fn method197(v0_1: u64) -> u64 {
            v0_1
        }
        pub fn closure118(unitVar: (), v0_1: chrono::NaiveDateTime) -> Dice_ui::US60 {
            Dice_ui::US60::US60_1(v0_1)
        }
        pub fn method198(v0_1: chrono::NaiveDateTime) -> chrono::NaiveDateTime {
            v0_1
        }
        pub fn method199(v0_1: chrono::DateTime<chrono::Local>) -> chrono::DateTime<chrono::Local> {
            v0_1
        }
        pub fn closure117(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7: u64 = Dice_ui::method197(v2);
            let v12: Dice_ui::US60 = defaultValue(
                Dice_ui::US60::US60_0,
                map(
                    Func1::new(move |v: chrono::NaiveDateTime| Dice_ui::closure118((), v)),
                    chrono::NaiveDateTime::from_timestamp_millis(v7.try_into().unwrap()),
                ),
            );
            let v29: Dice_ui::US61 = match &v12 {
                Dice_ui::US60::US60_1(v12_1_0) => {
                    let v14: chrono::NaiveDateTime = Dice_ui::method198(v12_1_0.clone());
                    let v16: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v14);
                    let v18: string = string("r#\"%Y-%m-%d %H:%M:%S\"#");
                    let v19: &str = r#"%Y-%m-%d %H:%M:%S"#;
                    let v20: chrono::DateTime<chrono::Local> = Dice_ui::method199(v16);
                    let v23: std::string::String = Dice_ui::method30(v20.format(v19).to_string());
                    Dice_ui::US61::US61_1(fable_library_rust::String_::fromString(v23))
                }
                _ => Dice_ui::US61::US61_0,
            };
            let v35: Dice_ui::US24 = match &v29 {
                Dice_ui::US61::US61_1(v29_1_0) => Dice_ui::US24::US24_1(v29_1_0.clone()),
                _ => Dice_ui::US24::US24_0(string("Option does not have a value.")),
            };
            let v43: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(match &v35 {
                Dice_ui::US24::US24_1(v35_1_0) => v35_1_0.clone(),
                Dice_ui::US24::US24_0(v35_0_0) => {
                    append(append(string("Error: "), v35_0_0.clone()), string(""))
                }
            })));
            let v45: &str = fable_library_rust::String_::LrcStr::as_str(&v43);
            let v47: std::string::String = String::from(v45);
            let v49: leptos::leptos_dom::Text = leptos::html::text(v47);
            let v51: leptos::View = leptos::IntoView::into_view(v49);
            leptos::Fragment::new(vec![v51])
        }
        pub fn method196(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                move || {
                    Dice_ui::closure117(
                        v0_1.clone(),
                        v1.clone(),
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method201(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method202(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn method203(
            v0_1: leptos::HtmlElement<leptos::html::Dt>,
        ) -> leptos::HtmlElement<leptos::html::Dt> {
            v0_1
        }
        pub fn method204(
            v0_1: leptos::HtmlElement<leptos::html::Dd>,
        ) -> leptos::HtmlElement<leptos::html::Dd> {
            v0_1
        }
        pub fn closure119(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"[font-size:11px] text-gray-400\"");
            let v6 = Dice_ui::method202(Dice_ui::method201(v0_1));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dt "), v5), string(">{v6()}</")),
                            string("dt"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Dt> = Dice_ui::method203(
                leptos::view! { <dt  class="[font-size:11px] text-gray-400">{v6()}</dt> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v17: string =
                string(" class=\"[max-height:50vh] [overflow:auto] text-gray-700 md:col-span-2 flex flex-1\"");
            let v18 = Dice_ui::method202(Dice_ui::method201(v1));
            let v21: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dd "), v17), string(">{v18()}</")),
                            string("dd"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v24: leptos::HtmlElement<leptos::html::Dd> = Dice_ui::method204(
                leptos::view! { <dd  class="[max-height:50vh] [overflow:auto] text-gray-700 md:col-span-2 flex flex-1">{v18()}</dd> },
            );
            let v30: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v14,
                    leptos::IntoView::into_view(v24),
                ]))));
            leptos::Fragment::new(v30.to_vec())
        }
        pub fn method200(
            v0_1: Func0<leptos::Fragment>,
            v1: Func0<leptos::Fragment>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure119(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method205(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn method207() -> string {
            string("Signer")
        }
        pub fn closure120(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method207()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method206() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure120((), ()))
        }
        pub fn closure121(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7: std::string::String = Dice_ui::method30(v5);
            let v12: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(
                fable_library_rust::String_::fromString(v7),
            )));
            let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
            let v16: std::string::String = String::from(v14);
            let v18: leptos::leptos_dom::Text = leptos::html::text(v16);
            let v20: leptos::View = leptos::IntoView::into_view(v18);
            leptos::Fragment::new(vec![v20])
        }
        pub fn method208(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                move || {
                    Dice_ui::closure121(
                        v0_1.clone(),
                        v1.clone(),
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method210() -> string {
            string("Receiver")
        }
        pub fn closure122(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method210()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method209() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure122((), ()))
        }
        pub fn closure123(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7: std::string::String = Dice_ui::method30(v4);
            let v12: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(
                fable_library_rust::String_::fromString(v7),
            )));
            let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
            let v16: std::string::String = String::from(v14);
            let v18: leptos::leptos_dom::Text = leptos::html::text(v16);
            let v20: leptos::View = leptos::IntoView::into_view(v18);
            leptos::Fragment::new(vec![v20])
        }
        pub fn method211(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                move || {
                    Dice_ui::closure123(
                        v0_1.clone(),
                        v1.clone(),
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method213() -> string {
            string("Actions")
        }
        pub fn closure124(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method213()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method212() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure124((), ()))
        }
        pub fn method217() -> string {
            string("Add Key")
        }
        pub fn closure127(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method217()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method216() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure127((), ()))
        }
        pub fn closure128(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v4: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(append(
                append(string("Public Key: "), toString(v0_1)),
                string(""),
            ))));
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: leptos::leptos_dom::Text = leptos::html::text(v8);
            let v12: leptos::View = leptos::IntoView::into_view(v10);
            leptos::Fragment::new(vec![v12])
        }
        pub fn method218(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure128(v0_1.clone(), ())
            })
        }
        pub fn method220() -> string {
            string("Contract Deploy")
        }
        pub fn closure129(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method220()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method219() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure129((), ()))
        }
        pub fn closure130(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method30(v0_1);
            let v6: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(
                fable_library_rust::String_::fromString(v1),
            )));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method221(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure130(v0_1.clone(), ())
            })
        }
        pub fn method223() -> string {
            string("Function Call")
        }
        pub fn closure131(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method223()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method222() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure131((), ()))
        }
        pub fn method226(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure133(unitVar: (), v0_1: base64::DecodeError) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method227() -> Func1<base64::DecodeError, std::string::String> {
            Func1::new(move |v: base64::DecodeError| Dice_ui::closure133((), v))
        }
        pub fn closure134(unitVar: (), v0_1: std::str::Utf8Error) -> std::string::String {
            format!("{}", &v0_1)
        }
        pub fn method228() -> Func1<std::str::Utf8Error, std::string::String> {
            Func1::new(move |v: std::str::Utf8Error| Dice_ui::closure134((), v))
        }
        pub fn method225(
            v0_1: std::string::String,
        ) -> Result<std::string::String, std::string::String> {
            let v1: std::string::String = Dice_ui::method226(v0_1);
            let v3: Result<Vec<u8>, base64::DecodeError> =
                base64::Engine::decode(&base64::engine::general_purpose::STANDARD, v1);
            let v4 = Dice_ui::method227();
            let v6: Result<Vec<u8>, std::string::String> = v3.map_err(|x| v4(x));
            let v8: Vec<u8> = v6?;
            let v10: Result<std::string::String, std::str::Utf8Error> =
                std::str::from_utf8(&v8).map(String::from);
            let v11 = Dice_ui::method228();
            v10.map_err(|x| v11(x))
        }
        pub fn closure135(unitVar: (), v0_1: std::string::String) -> Dice_ui::US62 {
            Dice_ui::US62::US62_1(v0_1)
        }
        pub fn closure136(unitVar: (), v0_1: std::string::String) -> Dice_ui::US62 {
            Dice_ui::US62::US62_0(v0_1)
        }
        pub fn closure132(
            v0_1: std::string::String,
            v1: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: Result<std::string::String, std::string::String> = Dice_ui::method225(v0_1);
            let v5: Dice_ui::US62 = match &v2 {
                Err(v2_1_0) => Dice_ui::closure136((), v2_1_0.clone()),
                Ok(v2_0_0) => Dice_ui::closure135((), v2_0_0.clone()),
            };
            let v13: string = match &v5 {
                Dice_ui::US62::US62_1(v5_1_0) => {
                    let v7: std::string::String = Dice_ui::method30(v5_1_0.clone());
                    fable_library_rust::String_::fromString(v7)
                }
                Dice_ui::US62::US62_0(v5_0_0) => append(
                    append(string("Error: "), toString(v5_0_0.clone())),
                    string(""),
                ),
            };
            let v17: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(append(
                append(append(append(string(""), toString(v1)), string("(")), v13),
                string(")"),
            ))));
            let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
            let v21: std::string::String = String::from(v19);
            let v23: leptos::leptos_dom::Text = leptos::html::text(v21);
            let v25: leptos::View = leptos::IntoView::into_view(v23);
            leptos::Fragment::new(vec![v25])
        }
        pub fn method224(
            v0_1: std::string::String,
            v1: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure132(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method230() -> string {
            string("Transfer")
        }
        pub fn closure137(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method230()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method229() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure137((), ()))
        }
        pub fn closure138(v0_1: std::string::String, unitVar: ()) -> leptos::Fragment {
            let v1: std::string::String = Dice_ui::method30(v0_1);
            let v6: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(
                fable_library_rust::String_::fromString(v1),
            )));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method231(v0_1: std::string::String) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure138(v0_1.clone(), ())
            })
        }
        pub fn closure126(unitVar: (), v0_1: Dice_ui::US34) -> leptos::View {
            match &v0_1 {
                Dice_ui::US34::US34_1(v0_1_1_0) => {
                    let v49: string =
                        string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  \"");
                    let v50 = Dice_ui::method202(Dice_ui::method200(
                        Dice_ui::method219(),
                        Dice_ui::method221(v0_1_1_0.clone()),
                    ));
                    let v53: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<div "), v49), string(">{v50()}</")),
                                    string("div"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v56: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                        leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  ">{v50()}</div> },
                    );
                    leptos::IntoView::into_view(v56)
                }
                Dice_ui::US34::US34_2(v0_1_2_0, v0_1_2_1, v0_1_2_2, v0_1_2_3) => {
                    let v11: string =
                        string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  \"");
                    let v12 = Dice_ui::method202(Dice_ui::method200(
                        Dice_ui::method222(),
                        Dice_ui::method224(v0_1_2_0.clone(), v0_1_2_3.clone()),
                    ));
                    let v15: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<div "), v11), string(">{v12()}</")),
                                    string("div"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v18: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                        leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  ">{v12()}</div> },
                    );
                    leptos::IntoView::into_view(v18)
                }
                Dice_ui::US34::US34_3(v0_1_3_0) => {
                    let v66: string =
                        string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  \"");
                    let v67 = Dice_ui::method202(Dice_ui::method200(
                        Dice_ui::method229(),
                        Dice_ui::method231(v0_1_3_0.clone()),
                    ));
                    let v70: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<div "), v66), string(">{v67()}</")),
                                    string("div"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v73: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                        leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  ">{v67()}</div> },
                    );
                    leptos::IntoView::into_view(v73)
                }
                Dice_ui::US34::US34_0(v0_1_0_0, v0_1_0_1, v0_1_0_2, v0_1_0_3, v0_1_0_4) => {
                    let v32: string =
                        string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  \"");
                    let v33 = Dice_ui::method202(Dice_ui::method200(
                        Dice_ui::method216(),
                        Dice_ui::method218(v0_1_0_4.clone()),
                    ));
                    let v36: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<div "), v32), string(">{v33()}</")),
                                    string("div"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    let v39: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                        leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  ">{v33()}</div> },
                    );
                    leptos::IntoView::into_view(v39)
                }
            }
        }
        pub fn method215() -> Func1<Dice_ui::US34, leptos::View> {
            Func1::new(move |v: Dice_ui::US34| Dice_ui::closure126((), v))
        }
        pub fn method232(v0_1: Array<Dice_ui::US34>) -> Array<Dice_ui::US34> {
            v0_1
        }
        pub fn method233(v0_1: Vec<leptos::View>) -> Vec<leptos::View> {
            v0_1
        }
        pub fn closure125(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7 = Dice_ui::method215();
            let v8: Array<Dice_ui::US34> = Dice_ui::method232(v0_1);
            let v11: Vec<leptos::View> =
                Dice_ui::method233(v8.to_vec().iter().map(|x| v7(x.clone())).collect());
            let v15: Array<leptos::View> = Dice_ui::method184(Dice_ui::method183(
                fable_library_rust::NativeArray_::array_from(v11),
            ));
            leptos::Fragment::new(v15.to_vec())
        }
        pub fn method214(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                move || {
                    Dice_ui::closure125(
                        v0_1.clone(),
                        v1.clone(),
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6.clone(),
                        (),
                    )
                }
            })
        }
        pub fn method235() -> string {
            string("Status")
        }
        pub fn closure139(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method235()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method234() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure139((), ()))
        }
        pub fn closure140(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7: std::string::String = Dice_ui::method30(v6);
            let v12: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(
                fable_library_rust::String_::fromString(v7),
            )));
            let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
            let v16: std::string::String = String::from(v14);
            let v18: leptos::leptos_dom::Text = leptos::html::text(v16);
            let v20: leptos::View = leptos::IntoView::into_view(v18);
            leptos::Fragment::new(vec![v20])
        }
        pub fn method236(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                move || {
                    Dice_ui::closure140(
                        v0_1.clone(),
                        v1.clone(),
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure115(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v13: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  \"");
            let v14 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method194(),
                Dice_ui::method196(
                    v0_1.clone(),
                    v1.clone(),
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6.clone(),
                ),
            ));
            let v17: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v13), string(">{v14()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v20: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  ">{v14()}</div> },
            );
            let v22: leptos::View = leptos::IntoView::into_view(v20);
            let v28: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  \"");
            let v29 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method206(),
                Dice_ui::method208(
                    v0_1.clone(),
                    v1.clone(),
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6.clone(),
                ),
            ));
            let v31: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v28), string(">{v29()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v34: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  ">{v29()}</div> },
            );
            let v36: leptos::View = leptos::IntoView::into_view(v34);
            let v42: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  \"");
            let v43 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method209(),
                Dice_ui::method211(
                    v0_1.clone(),
                    v1.clone(),
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6.clone(),
                ),
            ));
            let v45: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v42), string(">{v43()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v48: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  ">{v43()}</div> },
            );
            let v50: leptos::View = leptos::IntoView::into_view(v48);
            let v56: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  \"");
            let v57 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method212(),
                Dice_ui::method214(
                    v0_1.clone(),
                    v1.clone(),
                    v2,
                    v3.clone(),
                    v4.clone(),
                    v5.clone(),
                    v6.clone(),
                ),
            ));
            let v59: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v56), string(">{v57()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v62: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  ">{v57()}</div> },
            );
            let v64: leptos::View = leptos::IntoView::into_view(v62);
            let v70: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  \"");
            let v71 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method234(),
                Dice_ui::method236(v0_1, v1, v2, v3, v4, v5, v6),
            ));
            let v73: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v70), string(">{v71()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v76: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%]  ">{v71()}</div> },
            );
            let v82: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v22,
                    v36,
                    v50,
                    v64,
                    leptos::IntoView::into_view(v76),
                ]))));
            leptos::Fragment::new(v82.to_vec())
        }
        pub fn method193(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                move || {
                    Dice_ui::closure115(
                        v0_1.clone(),
                        v1.clone(),
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure113(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
            unitVar: (),
        ) -> leptos::Fragment {
            let v7 = Dice_ui::method190();
            let v8: string =
                string("<span class=\"flex items-center pb-[2px]\"><span class=\"pr-6 [font-size:14px]\">{v7()}</span><span class=\"h-px flex-1 bg-gray-300\"></span></span>");
            let v9: string = append(append(string("leptos::view! { "), v8), string(" }"));
            let v12: leptos::HtmlElement<leptos::html::Span> = Dice_ui::method192(
                leptos::view! { <span class="flex items-center pb-[2px]"><span class="pr-6 [font-size:14px]">{v7()}</span><span class="h-px flex-1 bg-gray-300"></span></span> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v18: string = string(" class=\"grid flex-1\"");
            let v19 = Dice_ui::method202(Dice_ui::method193(v0_1, v1, v2, v3, v4, v5, v6));
            let v22: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v18), string(">{v19()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v25: leptos::HtmlElement<leptos::html::Div> =
                Dice_ui::method205(leptos::view! { <div  class="grid flex-1">{v19()}</div> });
            let v31: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v14,
                    leptos::IntoView::into_view(v25),
                ]))));
            leptos::Fragment::new(v31.to_vec())
        }
        pub fn method189(
            v0_1: Array<Dice_ui::US34>,
            v1: std::string::String,
            v2: u64,
            v3: std::string::String,
            v4: std::string::String,
            v5: std::string::String,
            v6: std::string::String,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                let v6 = v6.clone();
                move || {
                    Dice_ui::closure113(
                        v0_1.clone(),
                        v1.clone(),
                        v2,
                        v3.clone(),
                        v4.clone(),
                        v5.clone(),
                        v6.clone(),
                        (),
                    )
                }
            })
        }
        pub fn closure112(
            unitVar: (),
            _arg: (
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
        ) -> leptos::Fragment {
            let v10: string = string(" class=\"flex flex-1 flex-col\"");
            let v11 = Dice_ui::method202(Dice_ui::method189(
                _arg.0.clone(),
                _arg.1.clone(),
                _arg.2.clone(),
                _arg.3.clone(),
                _arg.4.clone(),
                _arg.5.clone(),
                _arg.6.clone(),
            ));
            let v14: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v10), string(">{v11()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v17: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="flex flex-1 flex-col">{v11()}</div> },
            );
            let v19: leptos::View = leptos::IntoView::into_view(v17);
            leptos::Fragment::new(vec![v19])
        }
        pub fn method188() -> Func1<
            (
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            ),
            leptos::Fragment,
        > {
            Func1::new(
                move |arg10_0040: (
                    Array<Dice_ui::US34>,
                    std::string::String,
                    u64,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                    std::string::String,
                )| Dice_ui::closure112((), arg10_0040),
            )
        }
        pub fn closure110(
            v0_1: Array<(
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: Array<(
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )> = Dice_ui::method186(v0_1);
            let v2 = Dice_ui::method187();
            let v3 = Dice_ui::method188();
            let v15: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos::For  children=move |x| v3(x) let:x key=move |x| v2(x.to_owned()) each=move || v1.to_vec() /> })");
            let v16: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos::For  children=move |x| v3(x) let:x key=move |x| v2(x.to_owned()) each=move || v1.to_vec() /> },
            );
            leptos::Fragment::new(vec![v16])
        }
        pub fn method185(
            v0_1: Array<(
                Array<Dice_ui::US34>,
                std::string::String,
                u64,
                std::string::String,
                std::string::String,
                std::string::String,
                std::string::String,
            )>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure110(v0_1.clone(), ())
            })
        }
        pub fn closure142(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string =
                string("<svg version=\"1.1\" id=\"Layer_1\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" x=\"0px\" y=\"0px\" width=\"24px\" height=\"30px\" viewBox=\"0 0 24 30\" style=\"enable-background:new 0 0 50 50;\" xml:space=\"preserve\"><rect x=\"0\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\" opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect><rect x=\"8\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\"  opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0.15s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect><rect x=\"16\" y=\"10\" width=\"4\" height=\"10\" fill=\"#333\"  opacity=\"0.2\"><animate attributeName=\"opacity\" attributeType=\"XML\" values=\"0.2; 1; .2\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"height\" attributeType=\"XML\" values=\"10; 20; 10\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /><animate attributeName=\"y\" attributeType=\"XML\" values=\"10; 5; 10\" begin=\"0.3s\" dur=\"0.6s\" repeatCount=\"indefinite\" /></rect></svg>");
            let v1: string = append(append(string("leptos::view! { "), v0_1), string(" }"));
            let v4: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method180(
                leptos::view! { <svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" width="24px" height="30px" viewBox="0 0 24 30" style="enable-background:new 0 0 50 50;" xml:space="preserve"><rect x="0" y="10" width="4" height="10" fill="#333" opacity="0.2"><animate attributeName="opacity" attributeType="XML" values="0.2; 1; .2" begin="0s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="height" attributeType="XML" values="10; 20; 10" begin="0s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="y" attributeType="XML" values="10; 5; 10" begin="0s" dur="0.6s" repeatCount="indefinite" /></rect><rect x="8" y="10" width="4" height="10" fill="#333"  opacity="0.2"><animate attributeName="opacity" attributeType="XML" values="0.2; 1; .2" begin="0.15s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="height" attributeType="XML" values="10; 20; 10" begin="0.15s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="y" attributeType="XML" values="10; 5; 10" begin="0.15s" dur="0.6s" repeatCount="indefinite" /></rect><rect x="16" y="10" width="4" height="10" fill="#333"  opacity="0.2"><animate attributeName="opacity" attributeType="XML" values="0.2; 1; .2" begin="0.3s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="height" attributeType="XML" values="10; 20; 10" begin="0.3s" dur="0.6s" repeatCount="indefinite" /><animate attributeName="y" attributeType="XML" values="10; 5; 10" begin="0.3s" dur="0.6s" repeatCount="indefinite" /></rect></svg> },
            );
            let v6: leptos::View = leptos::IntoView::into_view(v4);
            let v10: string =
                Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(string("Loading..."))));
            let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
            let v14: std::string::String = String::from(v12);
            let v16: leptos::leptos_dom::Text = leptos::html::text(v14);
            let v22: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v6,
                    leptos::IntoView::into_view(v16),
                ]))));
            leptos::Fragment::new(v22.to_vec())
        }
        pub fn method238() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure142((), ()))
        }
        pub fn closure141(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v3: string = string(" class=\"flex flex-1 [gap:4px] items-center\"");
            let v4 = Dice_ui::method202(Dice_ui::method238());
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
            let v10: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="flex flex-1 [gap:4px] items-center">{v4()}</div> },
            );
            let v12: leptos::View = leptos::IntoView::into_view(v10);
            leptos::Fragment::new(vec![v12])
        }
        pub fn method237() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure141((), ()))
        }
        pub fn closure109(unitVar: (), v0_1: Func0<Dice_ui::US58>) -> leptos::Fragment {
            let v1: Func0<Dice_ui::US58> = Dice_ui::method179(v0_1);
            let v3: Dice_ui::US58 = v1();
            if let Dice_ui::US58::US58_1(v3_1_0) = &v3 {
                let v4: Dice_ui::US59 = match &v3 {
                    Dice_ui::US58::US58_1(x) => x.clone(),
                    _ => unreachable!(),
                };
                match &v4 {
                    Dice_ui::US59::US59_1(v4_1_0) => {
                        let v9: string =
                            string(" class=\"grid flex-1 p-[10px] [gap:10px] [grid-template-columns:repeat(auto-fill,minmax(400px,1fr))]\"");
                        let v10 = Dice_ui::method202(Dice_ui::method185(v4_1_0.clone()));
                        let v13: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v9), string(">{v10()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v16: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                            leptos::view! { <div  class="grid flex-1 p-[10px] [gap:10px] [grid-template-columns:repeat(auto-fill,minmax(400px,1fr))]">{v10()}</div> },
                        );
                        let v18: leptos::View = leptos::IntoView::into_view(v16);
                        leptos::Fragment::new(vec![v18])
                    }
                    Dice_ui::US59::US59_0(v4_0_0) => {
                        let v22: string =
                            string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"[height:100%] text-red-700\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M6 18L18 6M6 6l12 12\" /></svg>");
                        let v23: string =
                            append(append(string("leptos::view! { "), v22), string(" }"));
                        let v26: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method180(
                            leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="[height:100%] text-red-700"><path stroke-linecap="round" stroke-linejoin="round" d="M6 18L18 6M6 6l12 12" /></svg> },
                        );
                        let v28: leptos::View = leptos::IntoView::into_view(v26);
                        let v31: string =
                            Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(v4_0_0.clone())));
                        let v33: &str = fable_library_rust::String_::LrcStr::as_str(&v31);
                        let v35: std::string::String = String::from(v33);
                        let v37: leptos::leptos_dom::Text = leptos::html::text(v35);
                        let v43: Array<leptos::View> = Dice_ui::method184(Dice_ui::method183(
                            Dice_ui::method182(new_array(&[v28, leptos::IntoView::into_view(v37)])),
                        ));
                        leptos::Fragment::new(v43.to_vec())
                    }
                }
            } else {
                let v51: string = string(" class=\"grid place-content-center py-[10vh]\"");
                let v52 = Dice_ui::method202(Dice_ui::method237());
                let v55: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v51), string(">{v52()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v58: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                    leptos::view! { <div  class="grid place-content-center py-[10vh]">{v52()}</div> },
                );
                let v60: leptos::View = leptos::IntoView::into_view(v58);
                leptos::Fragment::new(vec![v60])
            }
        }
        pub fn method178() -> Func1<Func0<Dice_ui::US58>, leptos::Fragment> {
            Func1::new(move |v: Func0<Dice_ui::US58>| Dice_ui::closure109((), v))
        }
        pub fn method239(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure107(v0_1: Func0<Dice_ui::US58>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method177(v0_1);
            let v2 = Dice_ui::method178();
            let v5: Func0<leptos::Fragment> = Dice_ui::method239(Func0::new(move || v2(v1())));
            let v7: leptos::View = leptos::IntoView::into_view(move || v5());
            leptos::Fragment::new(vec![v7])
        }
        pub fn method176(v0_1: Func0<Dice_ui::US58>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure107(v0_1.clone(), ())
            })
        }
        pub fn method240(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
        ) -> leptos::HtmlElement<leptos::html::Details> {
            v0_1
        }
        pub fn method241() -> string {
            string("Debug")
        }
        pub fn method244() -> string {
            string("JSON")
        }
        pub fn closure144(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method244()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method243() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure144((), ()))
        }
        pub fn closure146(
            v0_1: leptos::Resource<string, Result<string, string>>,
            unitVar: (),
        ) -> leptos::Resource<string, Result<string, string>> {
            v0_1
        }
        pub fn method246(
            v0_1: leptos::Resource<string, Result<string, string>>,
        ) -> Func0<leptos::Resource<string, Result<string, string>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure146(v0_1.clone(), ())
            })
        }
        pub fn closure148(v0_1: leptos::Fragment, unitVar: ()) -> leptos::Fragment {
            v0_1
        }
        pub fn method248(v0_1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure148(v0_1.clone(), ())
            })
        }
        pub fn method249(
            v0_1: leptos::HtmlElement<leptos::html::Pre>,
        ) -> leptos::HtmlElement<leptos::html::Pre> {
            v0_1
        }
        pub fn closure147(
            unitVar: (),
            v0_1: leptos::Resource<string, Result<string, string>>,
        ) -> leptos::Fragment {
            let v1: leptos::Resource<string, Result<string, string>> = Dice_ui::method105(v0_1);
            let v3: Option<Result<string, string>> = leptos::SignalGet::get(&v1);
            let v6: std::string::String = Dice_ui::method30(format!("{:#?}", &v3));
            let v11: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(
                fable_library_rust::String_::fromString(v6),
            )));
            let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
            let v15: std::string::String = String::from(v13);
            let v17: leptos::leptos_dom::Text = leptos::html::text(v15);
            let v19: leptos::View = leptos::IntoView::into_view(v17);
            let v25: string = string(
                " class=\"[padding:7px] [font-size:11px] [line-height:11px] [text-wrap:pretty]\"",
            );
            let v26 = Dice_ui::method202(Dice_ui::method248(leptos::Fragment::new(vec![v19])));
            let v29: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v25), string(">{v26()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v32: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method249(
                leptos::view! { <pre  class="[padding:7px] [font-size:11px] [line-height:11px] [text-wrap:pretty]">{v26()}</pre> },
            );
            let v34: leptos::View = leptos::IntoView::into_view(v32);
            leptos::Fragment::new(vec![v34])
        }
        pub fn method247(
        ) -> Func1<leptos::Resource<string, Result<string, string>>, leptos::Fragment> {
            Func1::new(move |v: leptos::Resource<string, Result<string, string>>| {
                Dice_ui::closure147((), v)
            })
        }
        pub fn closure145(
            v0_1: leptos::Resource<string, Result<string, string>>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method246(v0_1);
            let v2 = Dice_ui::method247();
            let v5: Func0<leptos::Fragment> = Dice_ui::method239(Func0::new(move || v2(v1())));
            let v7: leptos::View = leptos::IntoView::into_view(move || v5());
            leptos::Fragment::new(vec![v7])
        }
        pub fn method245(
            v0_1: leptos::Resource<string, Result<string, string>>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure145(v0_1.clone(), ())
            })
        }
        pub fn method251() -> string {
            string("Result Wrapper")
        }
        pub fn closure149(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method251()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method250() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure149((), ()))
        }
        pub fn closure151(v0_1: Func0<Dice_ui::US26>, unitVar: ()) -> Func0<Dice_ui::US26> {
            v0_1
        }
        pub fn method253(v0_1: Func0<Dice_ui::US26>) -> Func0<Func0<Dice_ui::US26>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure151(v0_1.clone(), ())
            })
        }
        pub fn closure152(unitVar: (), v0_1: Func0<Dice_ui::US26>) -> leptos::Fragment {
            let v1: Func0<Dice_ui::US26> = Dice_ui::method163(v0_1);
            let v3: Dice_ui::US26 = v1();
            let v6: std::string::String = Dice_ui::method30(format!("{:#?}", &v3));
            let v11: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(
                fable_library_rust::String_::fromString(v6),
            )));
            let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
            let v15: std::string::String = String::from(v13);
            let v17: leptos::leptos_dom::Text = leptos::html::text(v15);
            let v19: leptos::View = leptos::IntoView::into_view(v17);
            let v25: string = string(
                " class=\"[padding:7px] [font-size:11px] [line-height:11px] [text-wrap:pretty]\"",
            );
            let v26 = Dice_ui::method202(Dice_ui::method248(leptos::Fragment::new(vec![v19])));
            let v29: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v25), string(">{v26()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v32: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method249(
                leptos::view! { <pre  class="[padding:7px] [font-size:11px] [line-height:11px] [text-wrap:pretty]">{v26()}</pre> },
            );
            let v34: leptos::View = leptos::IntoView::into_view(v32);
            leptos::Fragment::new(vec![v34])
        }
        pub fn method254() -> Func1<Func0<Dice_ui::US26>, leptos::Fragment> {
            Func1::new(move |v: Func0<Dice_ui::US26>| Dice_ui::closure152((), v))
        }
        pub fn closure150(v0_1: Func0<Dice_ui::US26>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method253(v0_1);
            let v2 = Dice_ui::method254();
            let v5: Func0<leptos::Fragment> = Dice_ui::method239(Func0::new(move || v2(v1())));
            let v7: leptos::View = leptos::IntoView::into_view(move || v5());
            leptos::Fragment::new(vec![v7])
        }
        pub fn method252(v0_1: Func0<Dice_ui::US26>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure150(v0_1.clone(), ())
            })
        }
        pub fn method256() -> string {
            string("Transactions Count")
        }
        pub fn closure153(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method256()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method255() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure153((), ()))
        }
        pub fn closure155(v0_1: Func0<Dice_ui::US45>, unitVar: ()) -> Func0<Dice_ui::US45> {
            v0_1
        }
        pub fn method258(v0_1: Func0<Dice_ui::US45>) -> Func0<Func0<Dice_ui::US45>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure155(v0_1.clone(), ())
            })
        }
        pub fn method260(v0_1: Func0<Dice_ui::US45>) -> Func0<Dice_ui::US45> {
            v0_1
        }
        pub fn closure156(unitVar: (), v0_1: Func0<Dice_ui::US45>) -> leptos::Fragment {
            let v1: Func0<Dice_ui::US45> = Dice_ui::method260(v0_1);
            let v3: Dice_ui::US45 = v1();
            let v6: std::string::String = Dice_ui::method30(format!("{:#?}", &v3));
            let v11: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(
                fable_library_rust::String_::fromString(v6),
            )));
            let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
            let v15: std::string::String = String::from(v13);
            let v17: leptos::leptos_dom::Text = leptos::html::text(v15);
            let v19: leptos::View = leptos::IntoView::into_view(v17);
            let v25: string = string(
                " class=\"[padding:7px] [font-size:11px] [line-height:11px] [text-wrap:pretty]\"",
            );
            let v26 = Dice_ui::method202(Dice_ui::method248(leptos::Fragment::new(vec![v19])));
            let v29: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v25), string(">{v26()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v32: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method249(
                leptos::view! { <pre  class="[padding:7px] [font-size:11px] [line-height:11px] [text-wrap:pretty]">{v26()}</pre> },
            );
            let v34: leptos::View = leptos::IntoView::into_view(v32);
            leptos::Fragment::new(vec![v34])
        }
        pub fn method259() -> Func1<Func0<Dice_ui::US45>, leptos::Fragment> {
            Func1::new(move |v: Func0<Dice_ui::US45>| Dice_ui::closure156((), v))
        }
        pub fn closure154(v0_1: Func0<Dice_ui::US45>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method258(v0_1);
            let v2 = Dice_ui::method259();
            let v5: Func0<leptos::Fragment> = Dice_ui::method239(Func0::new(move || v2(v1())));
            let v7: leptos::View = leptos::IntoView::into_view(move || v5());
            leptos::Fragment::new(vec![v7])
        }
        pub fn method257(v0_1: Func0<Dice_ui::US45>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure154(v0_1.clone(), ())
            })
        }
        pub fn method262() -> string {
            string("Cursor")
        }
        pub fn closure157(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method262()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method261() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure157((), ()))
        }
        pub fn closure159(v0_1: Func0<Dice_ui::US55>, unitVar: ()) -> Func0<Dice_ui::US55> {
            v0_1
        }
        pub fn method264(v0_1: Func0<Dice_ui::US55>) -> Func0<Func0<Dice_ui::US55>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure159(v0_1.clone(), ())
            })
        }
        pub fn method266(v0_1: Func0<Dice_ui::US55>) -> Func0<Dice_ui::US55> {
            v0_1
        }
        pub fn closure160(unitVar: (), v0_1: Func0<Dice_ui::US55>) -> leptos::Fragment {
            let v1: Func0<Dice_ui::US55> = Dice_ui::method266(v0_1);
            let v3: Dice_ui::US55 = v1();
            let v6: std::string::String = Dice_ui::method30(format!("{:#?}", &v3));
            let v11: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(
                fable_library_rust::String_::fromString(v6),
            )));
            let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
            let v15: std::string::String = String::from(v13);
            let v17: leptos::leptos_dom::Text = leptos::html::text(v15);
            let v19: leptos::View = leptos::IntoView::into_view(v17);
            let v25: string = string(
                " class=\"[padding:7px] [font-size:11px] [line-height:11px] [text-wrap:pretty]\"",
            );
            let v26 = Dice_ui::method202(Dice_ui::method248(leptos::Fragment::new(vec![v19])));
            let v29: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v25), string(">{v26()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v32: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method249(
                leptos::view! { <pre  class="[padding:7px] [font-size:11px] [line-height:11px] [text-wrap:pretty]">{v26()}</pre> },
            );
            let v34: leptos::View = leptos::IntoView::into_view(v32);
            leptos::Fragment::new(vec![v34])
        }
        pub fn method265() -> Func1<Func0<Dice_ui::US55>, leptos::Fragment> {
            Func1::new(move |v: Func0<Dice_ui::US55>| Dice_ui::closure160((), v))
        }
        pub fn closure158(v0_1: Func0<Dice_ui::US55>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method264(v0_1);
            let v2 = Dice_ui::method265();
            let v5: Func0<leptos::Fragment> = Dice_ui::method239(Func0::new(move || v2(v1())));
            let v7: leptos::View = leptos::IntoView::into_view(move || v5());
            leptos::Fragment::new(vec![v7])
        }
        pub fn method263(v0_1: Func0<Dice_ui::US55>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure158(v0_1.clone(), ())
            })
        }
        pub fn method268() -> string {
            string("Transactions")
        }
        pub fn closure161(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method268()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method267() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure161((), ()))
        }
        pub fn closure163(v0_1: Func0<Dice_ui::US50>, unitVar: ()) -> Func0<Dice_ui::US50> {
            v0_1
        }
        pub fn method270(v0_1: Func0<Dice_ui::US50>) -> Func0<Func0<Dice_ui::US50>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure163(v0_1.clone(), ())
            })
        }
        pub fn closure164(unitVar: (), v0_1: Func0<Dice_ui::US50>) -> leptos::Fragment {
            let v1: Func0<Dice_ui::US50> = Dice_ui::method172(v0_1);
            let v3: Dice_ui::US50 = v1();
            let v6: std::string::String = Dice_ui::method30(format!("{:#?}", &v3));
            let v11: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(
                fable_library_rust::String_::fromString(v6),
            )));
            let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
            let v15: std::string::String = String::from(v13);
            let v17: leptos::leptos_dom::Text = leptos::html::text(v15);
            let v19: leptos::View = leptos::IntoView::into_view(v17);
            let v25: string = string(
                " class=\"[padding:7px] [font-size:11px] [line-height:11px] [text-wrap:pretty]\"",
            );
            let v26 = Dice_ui::method202(Dice_ui::method248(leptos::Fragment::new(vec![v19])));
            let v29: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<pre "), v25), string(">{v26()}</")),
                            string("pre"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v32: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method249(
                leptos::view! { <pre  class="[padding:7px] [font-size:11px] [line-height:11px] [text-wrap:pretty]">{v26()}</pre> },
            );
            let v34: leptos::View = leptos::IntoView::into_view(v32);
            leptos::Fragment::new(vec![v34])
        }
        pub fn method271() -> Func1<Func0<Dice_ui::US50>, leptos::Fragment> {
            Func1::new(move |v: Func0<Dice_ui::US50>| Dice_ui::closure164((), v))
        }
        pub fn closure162(v0_1: Func0<Dice_ui::US50>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method270(v0_1);
            let v2 = Dice_ui::method271();
            let v5: Func0<leptos::Fragment> = Dice_ui::method239(Func0::new(move || v2(v1())));
            let v7: leptos::View = leptos::IntoView::into_view(move || v5());
            leptos::Fragment::new(vec![v7])
        }
        pub fn method269(v0_1: Func0<Dice_ui::US50>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure162(v0_1.clone(), ())
            })
        }
        pub fn closure143(
            v0_1: leptos::Resource<string, Result<string, string>>,
            v1: Func0<Dice_ui::US26>,
            v2: Func0<Dice_ui::US45>,
            v3: Func0<Dice_ui::US50>,
            v4: Func0<Dice_ui::US55>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v12: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] \"");
            let v13 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method243(),
                Dice_ui::method245(v0_1),
            ));
            let v16: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v12), string(">{v13()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v19: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] ">{v13()}</div> },
            );
            let v21: leptos::View = leptos::IntoView::into_view(v19);
            let v27: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] \"");
            let v28 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method250(),
                Dice_ui::method252(v1),
            ));
            let v30: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v27), string(">{v28()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v33: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] ">{v28()}</div> },
            );
            let v35: leptos::View = leptos::IntoView::into_view(v33);
            let v41: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] \"");
            let v42 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method255(),
                Dice_ui::method257(v2),
            ));
            let v44: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v41), string(">{v42()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v47: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] ">{v42()}</div> },
            );
            let v49: leptos::View = leptos::IntoView::into_view(v47);
            let v55: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] \"");
            let v56 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method261(),
                Dice_ui::method263(v4),
            ));
            let v58: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v55), string(">{v56()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v61: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] ">{v56()}</div> },
            );
            let v63: leptos::View = leptos::IntoView::into_view(v61);
            let v69: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] \"");
            let v70 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method267(),
                Dice_ui::method269(v3),
            ));
            let v72: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v69), string(">{v70()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v75: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] ">{v70()}</div> },
            );
            let v81: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v21,
                    v35,
                    v49,
                    v63,
                    leptos::IntoView::into_view(v75),
                ]))));
            leptos::Fragment::new(v81.to_vec())
        }
        pub fn method242(
            v0_1: leptos::Resource<string, Result<string, string>>,
            v1: Func0<Dice_ui::US26>,
            v2: Func0<Dice_ui::US45>,
            v3: Func0<Dice_ui::US50>,
            v4: Func0<Dice_ui::US55>,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move || {
                    Dice_ui::closure143(
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
        pub fn method272(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method273(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn method274() -> string {
            string("View")
        }
        pub fn method279() -> string {
            string("Dark Mode")
        }
        pub fn closure168(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method279()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method278() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure168((), ()))
        }
        pub fn method281() -> string {
            string("dark-mode")
        }
        pub fn closure171(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method283() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Dice_ui::closure171((), v))
        }
        pub fn closure170(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method31(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method283();
            let v8: leptos::RwSignal<bool> = Dice_ui::method33(v5.l0.clone());
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
        pub fn method282(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure170(v0_1.clone(), v)
            })
        }
        pub fn closure172(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method31(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method52((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method284(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure172(v0_1.clone(), ())
            })
        }
        pub fn method285(
            v0_1: leptos::HtmlElement<leptos::html::Label>,
        ) -> leptos::HtmlElement<leptos::html::Label> {
            v0_1
        }
        pub fn closure169(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method281());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method282(v0_1.clone());
            let v8 = Dice_ui::method284(v0_1);
            let v9: string =
                string("<label for={v6.clone()} class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\"><input type=\"checkbox\" id={v6} class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-gray-200\"><svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg><svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg></span><span class=\"absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-gray-200\"></span></label>");
            let v10: string = append(append(string("leptos::view! { "), v9), string(" }"));
            let v13: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method285(
                leptos::view! { <label for={v6.clone()} class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"><input type="checkbox" id={v6} class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-gray-200"><svg data-unchecked-icon xmlns="http://www.w3.org/2000/svg" class="h-4 w-4" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" clip-rule="evenodd" /></svg><svg data-checked-icon xmlns="http://www.w3.org/2000/svg" class="hidden h-4 w-4" viewBox="0 0 20 20" fill="currentColor"> <path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" /></svg></span><span class="absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-gray-200"></span></label> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method280(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure169(v0_1.clone(), ())
            })
        }
        pub fn method287() -> string {
            string("Debug")
        }
        pub fn closure173(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method287()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method286() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure173((), ()))
        }
        pub fn method289() -> string {
            string("debug")
        }
        pub fn closure175(v0_1: LrcPtr<Dice_ui::Heap2>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method31(v0_1.l0.clone());
            let v5: LrcPtr<Dice_ui::Heap0> = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Dice_ui::method283();
            let v8: leptos::RwSignal<bool> = Dice_ui::method33(v5.l1.clone());
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
        pub fn method290(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Dice_ui::closure175(v0_1.clone(), v)
            })
        }
        pub fn closure176(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = Dice_ui::method31(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Dice_ui::method52((leptos::SignalGetUntracked::get_untracked(&v2)).l1.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method291(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure176(v0_1.clone(), ())
            })
        }
        pub fn closure174(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method289());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method290(v0_1.clone());
            let v8 = Dice_ui::method291(v0_1);
            let v9: string =
                string("<label for={v6.clone()} class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\"><input type=\"checkbox\" id={v6} class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-gray-200\"><svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg><svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg></span><span class=\"absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-gray-200\"></span></label>");
            let v10: string = append(append(string("leptos::view! { "), v9), string(" }"));
            let v13: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method285(
                leptos::view! { <label for={v6.clone()} class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"><input type="checkbox" id={v6} class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" on:change=move |event| v7(event) prop:checked={move || v8()} /><span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-gray-200"><svg data-unchecked-icon xmlns="http://www.w3.org/2000/svg" class="h-4 w-4" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" clip-rule="evenodd" /></svg><svg data-checked-icon xmlns="http://www.w3.org/2000/svg" class="hidden h-4 w-4" viewBox="0 0 20 20" fill="currentColor"> <path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" /></svg></span><span class="absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-gray-200"></span></label> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method288(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure174(v0_1.clone(), ())
            })
        }
        pub fn closure167(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v9: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] items-center\"");
            let v10 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method278(),
                Dice_ui::method280(v0_1.clone()),
            ));
            let v13: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v9), string(">{v10()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] items-center">{v10()}</div> },
            );
            let v18: leptos::View = leptos::IntoView::into_view(v16);
            let v25: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] items-center\"");
            let v26 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method286(),
                Dice_ui::method288(v0_1),
            ));
            let v28: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v25), string(">{v26()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v31: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] items-center">{v26()}</div> },
            );
            let v37: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v18,
                    leptos::IntoView::into_view(v31),
                ]))));
            leptos::Fragment::new(v37.to_vec())
        }
        pub fn method277(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure167(v0_1.clone(), ())
            })
        }
        pub fn method292(
            v0_1: leptos::HtmlElement<leptos::html::Dl>,
        ) -> leptos::HtmlElement<leptos::html::Dl> {
            v0_1
        }
        pub fn closure166(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1\"");
            let v5 = Dice_ui::method202(Dice_ui::method277(v0_1));
            let v8: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v4), string(">{v5()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v11: leptos::HtmlElement<leptos::html::Dl> =
                Dice_ui::method292(leptos::view! { <dl  class="flex flex-1">{v5()}</dl> });
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            leptos::Fragment::new(vec![v13])
        }
        pub fn method276(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure166(v0_1.clone(), ())
            })
        }
        pub fn closure165(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"[flex:1] flow-root\"");
            let v5 = Dice_ui::method202(Dice_ui::method276(v0_1));
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
            let v11: leptos::HtmlElement<leptos::html::Div> =
                Dice_ui::method205(leptos::view! { <div  class="[flex:1] flow-root">{v5()}</div> });
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            leptos::Fragment::new(vec![v13])
        }
        pub fn method275(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure165(v0_1.clone(), ())
            })
        }
        pub fn method293() -> string {
            string("Connection")
        }
        pub fn method298() -> string {
            string("Explorer Backend Host")
        }
        pub fn closure180(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method298()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method297() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure180((), ()))
        }
        pub fn method301(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method302(
            v0_1: leptos::ReadSignal<std::string::String>,
        ) -> leptos::ReadSignal<std::string::String> {
            v0_1
        }
        pub fn closure182(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> std::string::String {
            let v2: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method39(v0_1.l2.clone());
            let v6: leptos::RwSignal<std::string::String> =
                Dice_ui::method301((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            let v9: leptos::ReadSignal<std::string::String> =
                Dice_ui::method302(leptos::RwSignal::read_only(&v6));
            leptos::SignalGet::get(&v9)
        }
        pub fn method300(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<std::string::String> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure182(v0_1.clone(), ())
            })
        }
        pub fn method304(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method305(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method306(
            v0_1: leptos::WriteSignal<std::string::String>,
        ) -> leptos::WriteSignal<std::string::String> {
            v0_1
        }
        pub fn closure183(v0_1: LrcPtr<Dice_ui::Heap2>, v1: std::string::String) {
            let v3: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = Dice_ui::method39(v0_1.l2.clone());
            let v7: leptos::RwSignal<std::string::String> =
                Dice_ui::method304((leptos::SignalGetUntracked::get_untracked(&v3)).l0.clone());
            let v9: leptos::WriteSignal<std::string::String> = leptos::RwSignal::write_only(&v7);
            let v10: std::string::String = Dice_ui::method305(v1);
            let v11: leptos::WriteSignal<std::string::String> = Dice_ui::method306(v9);
            leptos::SignalSet::set(&v11, v10);
            ()
        }
        pub fn method303(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func1<std::string::String, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Dice_ui::closure183(v0_1.clone(), v)
            })
        }
        pub fn method307(
            v0_1: leptos::HtmlElement<leptos::html::Input>,
        ) -> leptos::HtmlElement<leptos::html::Input> {
            v0_1
        }
        pub fn closure181(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method300(v0_1.clone());
            let v2 = Dice_ui::method303(v0_1);
            let v12: string =
                string("leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v2(leptos::event_target_value(&event)) prop:value=move || v1() class=\"bg-gray-50 flex-1 h-[27px]\" /> }");
            let v15: leptos::HtmlElement<leptos::html::Input> = Dice_ui::method307(
                leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v2(leptos::event_target_value(&event)) prop:value=move || v1() class="bg-gray-50 flex-1 h-[27px]" /> },
            );
            let v17: leptos::View = leptos::IntoView::into_view(v15);
            leptos::Fragment::new(vec![v17])
        }
        pub fn method299(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure181(v0_1.clone(), ())
            })
        }
        pub fn closure179(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v9: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] items-baseline\"");
            let v10 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method297(),
                Dice_ui::method299(v0_1),
            ));
            let v13: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v9), string(">{v10()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v16: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] items-baseline">{v10()}</div> },
            );
            let v18: leptos::View = leptos::IntoView::into_view(v16);
            leptos::Fragment::new(vec![v18])
        }
        pub fn method296(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure179(v0_1.clone(), ())
            })
        }
        pub fn closure178(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1\"");
            let v5 = Dice_ui::method202(Dice_ui::method296(v0_1));
            let v8: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<dl "), v4), string(">{v5()}</")),
                            string("dl"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v11: leptos::HtmlElement<leptos::html::Dl> =
                Dice_ui::method292(leptos::view! { <dl  class="flex flex-1">{v5()}</dl> });
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            leptos::Fragment::new(vec![v13])
        }
        pub fn method295(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure178(v0_1.clone(), ())
            })
        }
        pub fn closure177(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"[flex:1] flow-root\"");
            let v5 = Dice_ui::method202(Dice_ui::method295(v0_1));
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
            let v11: leptos::HtmlElement<leptos::html::Div> =
                Dice_ui::method205(leptos::view! { <div  class="[flex:1] flow-root">{v5()}</div> });
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            leptos::Fragment::new(vec![v13])
        }
        pub fn method294(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure177(v0_1.clone(), ())
            })
        }
        pub fn method310() -> string {
            string("Global State")
        }
        pub fn closure185(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method310()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method309() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure185((), ()))
        }
        pub fn method313(v0_1: LrcPtr<Dice_ui::Heap2>) -> LrcPtr<Dice_ui::Heap2> {
            v0_1
        }
        pub fn closure187(v0_1: LrcPtr<Dice_ui::Heap2>, unitVar: ()) -> string {
            leptos::logging::log!(
                "{}",
                &string("settings.global_state_log_render () / global_state_json memo")
            );
            {
                let v3: LrcPtr<Dice_ui::Heap2> = Dice_ui::method313(v0_1);
                let v5: Result<std::string::String, std::string::String> =
                    serde_json::to_string_pretty(&v3).map_err(|x| x.to_string());
                let v8: Dice_ui::US62 = match &v5 {
                    Err(v5_1_0) => Dice_ui::closure136((), v5_1_0.clone()),
                    Ok(v5_0_0) => Dice_ui::closure135((), v5_0_0.clone()),
                };
                match &v8 {
                    Dice_ui::US62::US62_1(v8_1_0) => {
                        let v10: std::string::String = Dice_ui::method30(v8_1_0.clone());
                        fable_library_rust::String_::fromString(v10)
                    }
                    Dice_ui::US62::US62_0(v8_0_0) => append(
                        append(string("Error: "), toString(v8_0_0.clone())),
                        string(""),
                    ),
                }
            }
        }
        pub fn method312(v0_1: LrcPtr<Dice_ui::Heap2>) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure187(v0_1.clone(), ())
            })
        }
        pub fn closure189(v0_1: leptos::Memo<string>, unitVar: ()) -> leptos::Memo<string> {
            v0_1
        }
        pub fn method315(v0_1: leptos::Memo<string>) -> Func0<leptos::Memo<string>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure189(v0_1.clone(), ())
            })
        }
        pub fn closure190(unitVar: (), v0_1: leptos::Memo<string>) -> leptos::Fragment {
            let v1: leptos::Memo<string> = Dice_ui::method99(v0_1);
            let v6: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method181(v1())));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method316() -> Func1<leptos::Memo<string>, leptos::Fragment> {
            Func1::new(move |v: leptos::Memo<string>| Dice_ui::closure190((), v))
        }
        pub fn closure188(v0_1: leptos::Memo<string>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method315(v0_1);
            let v2 = Dice_ui::method316();
            let v5: Func0<leptos::Fragment> = Dice_ui::method239(Func0::new(move || v2(v1())));
            let v7: leptos::View = leptos::IntoView::into_view(move || v5());
            leptos::Fragment::new(vec![v7])
        }
        pub fn method314(v0_1: leptos::Memo<string>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure188(v0_1.clone(), ())
            })
        }
        pub fn closure186(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("settings.global_state_log_render ()"));
            {
                let v3: Option<LrcPtr<Dice_ui::Heap2>> =
                    leptos::use_context::<std::rc::Rc<Heap2>>();
                let v6 = Dice_ui::method312(v3.unwrap());
                let v12: string =
                    string(" class=\"[padding:7px] [font-size:11px] [line-height:11px]\"");
                let v13 =
                    Dice_ui::method202(Dice_ui::method314(leptos::create_memo(move |_| v6())));
                let v16: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<pre "), v12), string(">{v13()}</")),
                                string("pre"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v19: leptos::HtmlElement<leptos::html::Pre> = Dice_ui::method249(
                    leptos::view! { <pre  class="[padding:7px] [font-size:11px] [line-height:11px]">{v13()}</pre> },
                );
                let v21: leptos::View = leptos::IntoView::into_view(v19);
                leptos::Fragment::new(vec![v21])
            }
        }
        pub fn method311() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure186((), ()))
        }
        pub fn closure184(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v7: string =
                string(" class=\"grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] \"");
            let v8 = Dice_ui::method202(Dice_ui::method200(
                Dice_ui::method309(),
                Dice_ui::method311(),
            ));
            let v11: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v7), string(">{v8()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v14: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="grid items-center gap-[1px] md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] [width:100%] pt-[8px] pr-[10px] pb-[10px] pl-[10px] ">{v8()}</div> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            leptos::Fragment::new(vec![v16])
        }
        pub fn method308() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure184((), ()))
        }
        pub fn closure56(unitVar: (), v0_1: leptos::ReadSignal<Dice_ui::US21>) -> leptos::Fragment {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method87(v0_1);
            let v3: Dice_ui::US21 = leptos::SignalGet::get(&v1);
            let v192: leptos::View = match &v3 {
                Dice_ui::US21::US21_1 => {
                    leptos::logging::log!("{}", &string("history.render ()"));
                    {
                        let v7: Option<LrcPtr<Dice_ui::Heap2>> =
                            leptos::use_context::<std::rc::Rc<Heap2>>();
                        let v9: LrcPtr<Dice_ui::Heap2> = v7.unwrap();
                        let v10 = Dice_ui::method88();
                        let v13 =
                            Dice_ui::method97(v9.clone(), leptos::create_memo(move |_| v10()));
                        let v16 = Dice_ui::method98(leptos::create_memo(move |_| v13()));
                        let v19: leptos::Resource<string, Result<string, string>> =
                            leptos::create_local_resource(
                                move || v16(),
                                |x| async move {
                                    Func1::new(move |v: string| Dice_ui::closure60((), v))(x).await
                                },
                            );
                        let v20 = Dice_ui::method104(v19.clone());
                        let v22: leptos::Memo<Dice_ui::US23> = leptos::create_memo(move |_| v20());
                        let v23 = Dice_ui::method110(v22.clone());
                        let v24 = Dice_ui::method111(v22);
                        let v26: Func0<Dice_ui::US26> = Func0::new(move || v24(v23()));
                        let v27 = Dice_ui::method161(v26.clone());
                        let v28 = Dice_ui::method162();
                        let v30: Func0<Dice_ui::US41> = Func0::new(move || v28(v27()));
                        let v31 = Dice_ui::method165(v30.clone());
                        let v32 = Dice_ui::method166(v30.clone());
                        let v34: Func0<Dice_ui::US45> = Func0::new(move || v32(v31()));
                        let v35 = Dice_ui::method168(v30.clone());
                        let v36 = Dice_ui::method169(v30);
                        let v38: Func0<Dice_ui::US50> = Func0::new(move || v36(v35()));
                        let v39 = Dice_ui::method170(v38.clone());
                        let v40 = Dice_ui::method171(v38.clone());
                        let v42: Func0<Dice_ui::US55> = Func0::new(move || v40(v39()));
                        let v43 = Dice_ui::method173();
                        let v44 = Dice_ui::method174(v38.clone());
                        let v46: Func0<Dice_ui::US58> = Func0::new(move || v44(v43()));
                        let v48: string = Dice_ui::method2(Dice_ui::method175());
                        let v50: &str = fable_library_rust::String_::LrcStr::as_str(&v48);
                        let v52: std::string::String = String::from(v50);
                        let v53 = Dice_ui::method176(v46);
                        let v54: string =
                                string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                        let v55: string =
                            append(append(string("leptos::view! { "), v54), string(" }"));
                        let v57: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                        let v58: string =
                                string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v52}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v57}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column] [overflow:auto]\">{v53()}</div></details>");
                        let v59: string =
                            append(append(string("leptos::view! { "), v58), string(" }"));
                        let v62: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method240(
                            leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v52}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v57}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column] [overflow:auto]">{v53()}</div></details> },
                        );
                        let v64: leptos::View = leptos::IntoView::into_view(v62);
                        let v66: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                            Dice_ui::method31(v9.l0.clone());
                        let v70: leptos::RwSignal<bool> = Dice_ui::method52(
                            (leptos::SignalGetUntracked::get_untracked(&v66)).l1.clone(),
                        );
                        let v101: Array<leptos::View> = Dice_ui::method273(Dice_ui::method272(
                            Dice_ui::method182(new_array(&[
                                v64,
                                if leptos::SignalGet::get(&v70) {
                                    let v74: string = Dice_ui::method2(Dice_ui::method241());
                                    let v76: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v74);
                                    let v78: std::string::String = String::from(v76);
                                    let v79 = Dice_ui::method242(v19, v26, v34, v38, v42);
                                    let v80:
                                                                                                                 string =
                                                                                                             string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                                    let v81: string = append(
                                        append(string("leptos::view! { "), v80),
                                        string(" }"),
                                    );
                                    let v83: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                                    let v84:
                                                                                                                 string =
                                                                                                             string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v78}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v83}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column] [overflow:auto]\">{v79()}</div></details>");
                                    let v85: string = append(
                                        append(string("leptos::view! { "), v84),
                                        string(" }"),
                                    );
                                    let v88: leptos::HtmlElement<leptos::html::Details> =
                                        Dice_ui::method240(
                                            leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v78}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v83}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column] [overflow:auto]">{v79()}</div></details> },
                                        );
                                    leptos::IntoView::into_view(v88)
                                } else {
                                    let v94: Array<leptos::View> =
                                        Dice_ui::method273(Dice_ui::method272(Dice_ui::method182(
                                            new_empty::<leptos::View>(),
                                        )));
                                    leptos::CollectView::collect_view(v94.to_vec())
                                },
                            ])),
                        ));
                        leptos::CollectView::collect_view(v101.to_vec())
                    }
                }
                Dice_ui::US21::US21_2 => {
                    leptos::logging::log!("{}", &string("settings.render ()"));
                    {
                        let v107: Option<LrcPtr<Dice_ui::Heap2>> =
                            leptos::use_context::<std::rc::Rc<Heap2>>();
                        let v109: LrcPtr<Dice_ui::Heap2> = v107.unwrap();
                        let v111: string = Dice_ui::method2(Dice_ui::method274());
                        let v113: &str = fable_library_rust::String_::LrcStr::as_str(&v111);
                        let v115: std::string::String = String::from(v113);
                        let v116 = Dice_ui::method275(v109.clone());
                        let v117: string =
                                string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                        let v118: string =
                            append(append(string("leptos::view! { "), v117), string(" }"));
                        let v120: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                        let v121: string =
                                string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v115}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v120}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column] [overflow:auto]\">{v116()}</div></details>");
                        let v122: string =
                            append(append(string("leptos::view! { "), v121), string(" }"));
                        let v125: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method240(
                            leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v115}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v120}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column] [overflow:auto]">{v116()}</div></details> },
                        );
                        let v127: leptos::View = leptos::IntoView::into_view(v125);
                        let v129: string = Dice_ui::method2(Dice_ui::method293());
                        let v131: &str = fable_library_rust::String_::LrcStr::as_str(&v129);
                        let v133: std::string::String = String::from(v131);
                        let v134 = Dice_ui::method294(v109.clone());
                        let v135: string =
                                string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                        let v136: string =
                            append(append(string("leptos::view! { "), v135), string(" }"));
                        let v138: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                        let v139: string =
                                string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v133}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v138}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column] [overflow:auto]\">{v134()}</div></details>");
                        let v140: string =
                            append(append(string("leptos::view! { "), v139), string(" }"));
                        let v143: leptos::HtmlElement<leptos::html::Details> = Dice_ui::method240(
                            leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v133}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v138}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column] [overflow:auto]">{v134()}</div></details> },
                        );
                        let v145: leptos::View = leptos::IntoView::into_view(v143);
                        let v147: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> =
                            Dice_ui::method31(v109.l0.clone());
                        let v151: leptos::RwSignal<bool> = Dice_ui::method52(
                            (leptos::SignalGetUntracked::get_untracked(&v147))
                                .l1
                                .clone(),
                        );
                        let v182: Array<leptos::View> = Dice_ui::method273(Dice_ui::method272(
                            Dice_ui::method182(new_array(&[
                                v127,
                                v145,
                                if leptos::SignalGet::get(&v151) {
                                    let v155: string = Dice_ui::method2(Dice_ui::method241());
                                    let v157: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v155);
                                    let v159: std::string::String = String::from(v157);
                                    let v160 = Dice_ui::method308();
                                    let v161:
                                                                                                                 string =
                                                                                                             string("<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg>");
                                    let v162: string = append(
                                        append(string("leptos::view! { "), v161),
                                        string(" }"),
                                    );
                                    let v164: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg> };
                                    let v165:
                                                                                                                 string =
                                                                                                             string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open=true><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v159}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\">{v164}</span></summary><div class=\"[display:flex] [flex:1] [flex-direction:column] [overflow:auto]\">{v160()}</div></details>");
                                    let v166: string = append(
                                        append(string("leptos::view! { "), v165),
                                        string(" }"),
                                    );
                                    let v169: leptos::HtmlElement<leptos::html::Details> =
                                        Dice_ui::method240(
                                            leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open=true><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v159}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180">{v164}</span></summary><div class="[display:flex] [flex:1] [flex-direction:column] [overflow:auto]">{v160()}</div></details> },
                                        );
                                    leptos::IntoView::into_view(v169)
                                } else {
                                    let v175: Array<leptos::View> =
                                        Dice_ui::method273(Dice_ui::method272(Dice_ui::method182(
                                            new_empty::<leptos::View>(),
                                        )));
                                    leptos::CollectView::collect_view(v175.to_vec())
                                },
                            ])),
                        ));
                        leptos::CollectView::collect_view(v182.to_vec())
                    }
                }
                _ => {
                    let v188: Array<leptos::View> =
                        Dice_ui::method273(Dice_ui::method272(Dice_ui::method182(new_empty::<
                            leptos::View,
                        >(
                        ))));
                    leptos::CollectView::collect_view(v188.to_vec())
                }
            };
            leptos::Fragment::new(vec![v192])
        }
        pub fn method86() -> Func1<leptos::ReadSignal<Dice_ui::US21>, leptos::Fragment> {
            Func1::new(move |v: leptos::ReadSignal<Dice_ui::US21>| Dice_ui::closure56((), v))
        }
        pub fn closure54(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method85(v0_1);
            let v2 = Dice_ui::method86();
            let v5: Func0<leptos::Fragment> = Dice_ui::method239(Func0::new(move || v2(v1())));
            let v7: leptos::View = leptos::IntoView::into_view(move || v5());
            leptos::Fragment::new(vec![v7])
        }
        pub fn method84(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure54(v0_1.clone(), ())
            })
        }
        pub fn method321() -> string {
            string("Tab")
        }
        pub fn closure194(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method321()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method320() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure194((), ()))
        }
        pub fn closure196(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method87(v0_1);
            if let Dice_ui::US21::US21_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method323(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure196(v0_1.clone(), ())
            })
        }
        pub fn method325() -> string {
            string("History")
        }
        pub fn closure197(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method325()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method324() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure197((), ()))
        }
        pub fn method326(
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::HtmlElement<leptos::html::Option_> {
            v0_1
        }
        pub fn closure198(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method87(v0_1);
            if let Dice_ui::US21::US21_2 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method327(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure198(v0_1.clone(), ())
            })
        }
        pub fn method329() -> string {
            string("Settings")
        }
        pub fn closure199(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method329()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            leptos::Fragment::new(vec![v10])
        }
        pub fn method328() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure199((), ()))
        }
        pub fn closure195(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1 = Dice_ui::method323(v0_1.clone());
            let v5: string = string(" select=v1()");
            let v6 = Dice_ui::method202(Dice_ui::method324());
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<option "), v5), string(">{v6()}</")),
                            string("option"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Option_> =
                Dice_ui::method326(leptos::view! { <option  select=v1()>{v6()}</option> });
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v15 = Dice_ui::method327(v0_1);
            let v18: string = string(" select=v15()");
            let v19 = Dice_ui::method202(Dice_ui::method328());
            let v21: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<option "), v18), string(">{v19()}</")),
                            string("option"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v24: leptos::HtmlElement<leptos::html::Option_> =
                Dice_ui::method326(leptos::view! { <option  select=v15()>{v19()}</option> });
            let v30: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v14,
                    leptos::IntoView::into_view(v24),
                ]))));
            leptos::Fragment::new(v30.to_vec())
        }
        pub fn method322(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure195(v0_1.clone(), ())
            })
        }
        pub fn method330(
            v0_1: leptos::HtmlElement<leptos::html::Select>,
        ) -> leptos::HtmlElement<leptos::html::Select> {
            v0_1
        }
        pub fn closure193(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v6: string = string(" class=\"sr-only\" for=\"Tab\"");
            let v7 = Dice_ui::method202(Dice_ui::method320());
            let v10: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<label "), v6), string(">{v7()}</")),
                            string("label"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v13: leptos::HtmlElement<leptos::html::Label> = Dice_ui::method285(
                leptos::view! { <label  class="sr-only" for="Tab">{v7()}</label> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            let v20: string = string(" class=\"w-full rounded-md border-gray-200\" id=\"Tab\"");
            let v21 = Dice_ui::method202(Dice_ui::method322(v0_1));
            let v24: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<select "), v20), string(">{v21()}</")),
                            string("select"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v27: leptos::HtmlElement<leptos::html::Select> = Dice_ui::method330(
                leptos::view! { <select  class="w-full rounded-md border-gray-200" id="Tab">{v21()}</select> },
            );
            let v33: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v15,
                    leptos::IntoView::into_view(v27),
                ]))));
            leptos::Fragment::new(v33.to_vec())
        }
        pub fn method319(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure193(v0_1.clone(), ())
            })
        }
        pub fn closure203(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method87(v0_1);
            if let Dice_ui::US21::US21_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method334(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure203(v0_1.clone(), ())
            })
        }
        pub fn method335(v0_1: Func0<bool>) -> Func0<bool> {
            v0_1
        }
        pub fn closure204(v0_1: Func0<bool>, unitVar: ()) -> &'static str {
            if v0_1() {
                let v3: string = string("r#\"border-grey-200 text-grey-900\"#");
                r#"border-grey-200 text-grey-900"#
            } else {
                let v6: string =
                    string("r#\"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700\"#");
                r#"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700"#
            }
        }
        pub fn method336(v0_1: Func0<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure204(v0_1.clone(), ())
            })
        }
        pub fn closure205(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method180(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v6: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method325()));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v18: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v3,
                    leptos::IntoView::into_view(v12),
                ]))));
            leptos::Fragment::new(v18.to_vec())
        }
        pub fn method337(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure205(v0_1.clone(), ())
            })
        }
        pub fn method338(
            v0_1: leptos::HtmlElement<leptos::html::A>,
        ) -> leptos::HtmlElement<leptos::html::A> {
            v0_1
        }
        pub fn closure206(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Dice_ui::US21> = Dice_ui::method87(v0_1);
            if let Dice_ui::US21::US21_2 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method339(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure206(v0_1.clone(), ())
            })
        }
        pub fn closure207(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Dice_ui::method180(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v6: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method329()));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v18: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v3,
                    leptos::IntoView::into_view(v12),
                ]))));
            leptos::Fragment::new(v18.to_vec())
        }
        pub fn method340(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure207(v0_1.clone(), ())
            })
        }
        pub fn closure202(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string = append(v1.clone(), string("#/history"));
            let v3: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z\"/></svg>");
            let v4: string = append(append(string("leptos::view! { "), v3), string(" }"));
            let v6: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="h-5 w-5"><path stroke-linecap="round" stroke-linejoin="round" d="M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z"/></svg> };
            let v8: string = Dice_ui::method2(Dice_ui::method6(v2));
            let v10: &str = fable_library_rust::String_::LrcStr::as_str(&v8);
            let v12: std::string::String = String::from(v10);
            let v13 = Dice_ui::method334(v0_1.clone());
            let v14 = Dice_ui::method335(v13.clone());
            let v15 = Dice_ui::method336(v13);
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
            let v24 = Dice_ui::method202(Dice_ui::method337(v6));
            let v27: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<a "), v23), string(">{v24()}</")),
                            string("a"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v30: leptos::HtmlElement<leptos::html::A> = Dice_ui::method338(
                leptos::view! { <a  aria-current={move || if v14() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium ".to_owned() + v15()} href=v12>{v24()}</a> },
            );
            let v32: leptos::View = leptos::IntoView::into_view(v30);
            let v33: string = append(v1, string("#/settings"));
            let v34: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\"/><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M15 12a3 3 0 11-6 0 3 3 0 016 0z\"/></svg>");
            let v35: string = append(append(string("leptos::view! { "), v34), string(" }"));
            let v37: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="h-5 w-5"><path stroke-linecap="round" stroke-linejoin="round" d="M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z"/><path stroke-linecap="round" stroke-linejoin="round" d="M15 12a3 3 0 11-6 0 3 3 0 016 0z"/></svg> };
            let v39: string = Dice_ui::method2(Dice_ui::method6(v33));
            let v41: &str = fable_library_rust::String_::LrcStr::as_str(&v39);
            let v43: std::string::String = String::from(v41);
            let v44 = Dice_ui::method339(v0_1);
            let v45 = Dice_ui::method335(v44.clone());
            let v46 = Dice_ui::method336(v44);
            let v48: string =
                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium \".to_owned() + v46()}");
            let v53: string = append(
                append(
                    string(" aria-current={move || if v45() { \"page\" } else { \"\" }}"),
                    append(
                        append(append(string(" "), v48), string(" href=v43")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v54 = Dice_ui::method202(Dice_ui::method340(v37));
            let v56: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<a "), v53), string(">{v54()}</")),
                            string("a"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v59: leptos::HtmlElement<leptos::html::A> = Dice_ui::method338(
                leptos::view! { <a  aria-current={move || if v45() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[10px] pl-[10px] text-sm font-medium ".to_owned() + v46()} href=v43>{v54()}</a> },
            );
            let v65: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v32,
                    leptos::IntoView::into_view(v59),
                ]))));
            leptos::Fragment::new(v65.to_vec())
        }
        pub fn method333(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure202(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method341(
            v0_1: leptos::HtmlElement<leptos::html::Nav>,
        ) -> leptos::HtmlElement<leptos::html::Nav> {
            v0_1
        }
        pub fn closure201(
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
            let v8 = Dice_ui::method202(Dice_ui::method333(v0_1, v1));
            let v11: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<nav "), v7), string(">{v8()}</")),
                            string("nav"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v14: leptos::HtmlElement<leptos::html::Nav> = Dice_ui::method341(
                leptos::view! { <nav  aria-label="Tabs" class="-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]">{v8()}</nav> },
            );
            let v16: leptos::View = leptos::IntoView::into_view(v14);
            leptos::Fragment::new(vec![v16])
        }
        pub fn method332(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure201(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure200(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v5: string = string(" class=\"flex flex-1 border-t border-gray-200\"");
            let v6 = Dice_ui::method202(Dice_ui::method332(v0_1, v1));
            let v9: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v5), string(">{v6()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v12: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="flex flex-1 border-t border-gray-200">{v6()}</div> },
            );
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method331(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Dice_ui::closure200(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure192(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("menu_tabs.render ()"));
            {
                let v4: leptos_router::Location = leptos_router::use_location();
                let v5: leptos_router::Location = Dice_ui::method67(v4.clone());
                let v8: leptos::Memo<std::string::String> = Dice_ui::method68(v5.pathname);
                let v11: std::string::String = Dice_ui::method30(v8());
                let v13: string = fable_library_rust::String_::fromString(v11);
                let v14: leptos_router::Location = Dice_ui::method69(v4);
                let v17: leptos::Memo<std::string::String> = Dice_ui::method68(v14.search);
                let v20: std::string::String = Dice_ui::method30(v17());
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
                let v33 = Dice_ui::method202(Dice_ui::method319(v0_1.clone()));
                let v36: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v32), string(">{v33()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v39: leptos::HtmlElement<leptos::html::Div> =
                    Dice_ui::method205(leptos::view! { <div  class="hidden">{v33()}</div> });
                let v41: leptos::View = leptos::IntoView::into_view(v39);
                let v44: string =
                    string(" class=\"flex flex-1 [overflow-x:auto] [overflow-y:hidden]\"");
                let v45 = Dice_ui::method202(Dice_ui::method331(v0_1, v28));
                let v47: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v44), string(">{v45()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v50: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                    leptos::view! { <div  class="flex flex-1 [overflow-x:auto] [overflow-y:hidden]">{v45()}</div> },
                );
                let v56: Array<leptos::View> =
                    Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                        v41,
                        leptos::IntoView::into_view(v50),
                    ]))));
                leptos::Fragment::new(v56.to_vec())
            }
        }
        pub fn method318(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure192(v0_1.clone(), ())
            })
        }
        pub fn closure191(
            v0_1: leptos::ReadSignal<Dice_ui::US21>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 [align-items:flex-end]\"");
            let v5 = Dice_ui::method202(Dice_ui::method318(v0_1));
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
            let v11: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="flex flex-1 [align-items:flex-end]">{v5()}</div> },
            );
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            leptos::Fragment::new(vec![v13])
        }
        pub fn method317(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure191(v0_1.clone(), ())
            })
        }
        pub fn closure53(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-100 flex-col [overflow-y:auto]\"");
            let v5 = Dice_ui::method202(Dice_ui::method84(v0_1.clone()));
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
            let v11: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="flex flex-100 flex-col [overflow-y:auto]">{v5()}</div> },
            );
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            let v16: string = string(" class=\"flex flex-1\"");
            let v17 = Dice_ui::method202(Dice_ui::method317(v0_1));
            let v19: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v16), string(">{v17()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v22: leptos::HtmlElement<leptos::html::Div> =
                Dice_ui::method205(leptos::view! { <div  class="flex flex-1">{v17()}</div> });
            let v28: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v13,
                    leptos::IntoView::into_view(v22),
                ]))));
            leptos::Fragment::new(v28.to_vec())
        }
        pub fn method83(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure53(v0_1.clone(), ())
            })
        }
        pub fn closure52(v0_1: leptos::ReadSignal<Dice_ui::US21>, unitVar: ()) -> leptos::Fragment {
            let v1: string =
                string("class=\"[width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100vh] max-[60px]:[min-height:600px] bg-gray-50 flex flex-1 flex-col items-stretch text-gray-700 text-sm\"");
            let v4: string = append(append(append(string(" "), v1), string("")), string(""));
            let v5 = Dice_ui::method202(Dice_ui::method83(v0_1));
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
            let v11: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                leptos::view! { <div  class="[width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100vh] max-[60px]:[min-height:600px] bg-gray-50 flex flex-1 flex-col items-stretch text-gray-700 text-sm">{v5()}</div> },
            );
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            leptos::Fragment::new(vec![v13])
        }
        pub fn method82(v0_1: leptos::ReadSignal<Dice_ui::US21>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Dice_ui::closure52(v0_1.clone(), ())
            })
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("content.render ()"));
            {
                let v3: leptos_router::Location = leptos_router::use_location();
                let v5: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)> =
                    std::sync::Arc::new(leptos_router::use_navigate());
                let v7: leptos_router::Location = leptos_router::use_location();
                let v8: leptos_router::Location = Dice_ui::method67(v7.clone());
                let v11: leptos::Memo<std::string::String> = Dice_ui::method68(v8.pathname);
                let v14: std::string::String = Dice_ui::method30(v11());
                let v16: string = fable_library_rust::String_::fromString(v14);
                let v17: leptos_router::Location = Dice_ui::method69(v7);
                let v20: leptos::Memo<std::string::String> = Dice_ui::method68(v17.search);
                let v23: std::string::String = Dice_ui::method30(v20());
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
                let v36: Dice_ui::US21 = Dice_ui::method70();
                let patternInput: (
                    leptos::ReadSignal<Dice_ui::US21>,
                    leptos::WriteSignal<Dice_ui::US21>,
                ) = leptos::create_signal(v36);
                let v40: bool = Dice_ui::method49();
                let patternInput_1: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                    leptos::create_signal(v40);
                let v44 = Dice_ui::method71(
                    v3.clone(),
                    v5,
                    v31,
                    v35,
                    patternInput_1.1.clone(),
                    patternInput_1.0.clone(),
                );
                leptos::create_effect(move |_| v44());
                {
                    let v46 = Dice_ui::method75(v3, patternInput.1.clone());
                    leptos::create_effect(move |_| v46());
                    {
                        let v51: string =
                            string(" class=\"flex flex-1 max-[100px]:[overflow-x:auto]\"");
                        let v52 = Dice_ui::method202(Dice_ui::method82(patternInput.0.clone()));
                        let v55: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v51), string(">{v52()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v58: leptos::HtmlElement<leptos::html::Div> = Dice_ui::method205(
                            leptos::view! { <div  class="flex flex-1 max-[100px]:[overflow-x:auto]">{v52()}</div> },
                        );
                        let v60: leptos::View = leptos::IntoView::into_view(v58);
                        leptos::Fragment::new(vec![v60])
                    }
                }
            }
        }
        pub fn method66() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure45((), ()))
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
                let v8 = Dice_ui::method8();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method11(v11.clone());
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
                let v16 = Dice_ui::method18(v11.clone());
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
                let v20 = Dice_ui::method21(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Dice_ui::method37(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method41(v11.clone());
                        let v26: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                v24(value.clone())
                            });
                        let v27 = Dice_ui::method45(v11);
                        let v29: leptos::Action<LrcPtr<Dice_ui::Heap4>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap4>| {
                                v27(value.clone())
                            });
                        let v30 = Dice_ui::method47(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Dice_ui::method49();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Dice_ui::method50(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Dice_ui::method63(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<LrcPtr<Dice_ui::Heap2>> =
                                    leptos::use_context::<std::rc::Rc<Heap2>>();
                                let v46 = Dice_ui::method65(v42.unwrap());
                                let v52: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v53 = Dice_ui::method202(Dice_ui::method66());
                                let v56: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v52),
                                                    string(">{v53()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v59: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method205(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v53()}</div> },
                                    );
                                let v61: leptos::View = leptos::IntoView::into_view(v59);
                                leptos::Fragment::new(vec![v61])
                            }
                        }
                    }
                }
            }
        }
        pub fn method7() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure5((), ()))
        }
        pub fn closure208(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v3: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_empty::<
                    leptos::View,
                >())));
            leptos::Fragment::new(v3.to_vec())
        }
        pub fn method342() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure208((), ()))
        }
        pub fn method343() -> string {
            string("/")
        }
        pub fn closure209(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
                let v8 = Dice_ui::method8();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method11(v11.clone());
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
                let v16 = Dice_ui::method18(v11.clone());
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
                let v20 = Dice_ui::method21(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Dice_ui::method37(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method41(v11.clone());
                        let v26: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                v24(value.clone())
                            });
                        let v27 = Dice_ui::method45(v11);
                        let v29: leptos::Action<LrcPtr<Dice_ui::Heap4>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap4>| {
                                v27(value.clone())
                            });
                        let v30 = Dice_ui::method47(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Dice_ui::method49();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Dice_ui::method50(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Dice_ui::method63(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<LrcPtr<Dice_ui::Heap2>> =
                                    leptos::use_context::<std::rc::Rc<Heap2>>();
                                let v46 = Dice_ui::method65(v42.unwrap());
                                let v52: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v53 = Dice_ui::method202(Dice_ui::method66());
                                let v56: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v52),
                                                    string(">{v53()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v59: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method205(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v53()}</div> },
                                    );
                                let v61: leptos::View = leptos::IntoView::into_view(v59);
                                leptos::Fragment::new(vec![v61])
                            }
                        }
                    }
                }
            }
        }
        pub fn method344() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure209((), ()))
        }
        pub fn method345() -> string {
            string("/*")
        }
        pub fn closure210(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
                let v8 = Dice_ui::method8();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method11(v11.clone());
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
                let v16 = Dice_ui::method18(v11.clone());
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
                let v20 = Dice_ui::method21(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Dice_ui::method37(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method41(v11.clone());
                        let v26: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                v24(value.clone())
                            });
                        let v27 = Dice_ui::method45(v11);
                        let v29: leptos::Action<LrcPtr<Dice_ui::Heap4>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap4>| {
                                v27(value.clone())
                            });
                        let v30 = Dice_ui::method47(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Dice_ui::method49();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Dice_ui::method50(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Dice_ui::method63(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<LrcPtr<Dice_ui::Heap2>> =
                                    leptos::use_context::<std::rc::Rc<Heap2>>();
                                let v46 = Dice_ui::method65(v42.unwrap());
                                let v52: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v53 = Dice_ui::method202(Dice_ui::method66());
                                let v56: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v52),
                                                    string(">{v53()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v59: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method205(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v53()}</div> },
                                    );
                                let v61: leptos::View = leptos::IntoView::into_view(v59);
                                leptos::Fragment::new(vec![v61])
                            }
                        }
                    }
                }
            }
        }
        pub fn method346() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure210((), ()))
        }
        pub fn method347() -> string {
            string("*")
        }
        pub fn closure211(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
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
                let v8 = Dice_ui::method8();
                let v11: leptos::Resource<Dice_ui::US1, rexie::Rexie> =
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v: Dice_ui::US1| Dice_ui::closure7((), v))(x).await
                        },
                    );
                let v12 = Dice_ui::method11(v11.clone());
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
                let v16 = Dice_ui::method18(v11.clone());
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
                let v20 = Dice_ui::method21(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Dice_ui::method37(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Dice_ui::method41(v11.clone());
                        let v26: leptos::Action<LrcPtr<Dice_ui::Heap3>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap3>| {
                                v24(value.clone())
                            });
                        let v27 = Dice_ui::method45(v11);
                        let v29: leptos::Action<LrcPtr<Dice_ui::Heap4>, ()> =
                            leptos::create_action(move |value: &std::rc::Rc<Heap4>| {
                                v27(value.clone())
                            });
                        let v30 = Dice_ui::method47(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Dice_ui::method49();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Dice_ui::method50(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Dice_ui::method63(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<LrcPtr<Dice_ui::Heap2>> =
                                    leptos::use_context::<std::rc::Rc<Heap2>>();
                                let v46 = Dice_ui::method65(v42.unwrap());
                                let v52: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v53 = Dice_ui::method202(Dice_ui::method66());
                                let v56: string = append(
                                    append(
                                        string("leptos::view! { "),
                                        append(
                                            append(
                                                append(
                                                    append(string("<div "), v52),
                                                    string(">{v53()}</"),
                                                ),
                                                string("div"),
                                            ),
                                            string(">"),
                                        ),
                                    ),
                                    string(" }"),
                                );
                                let v59: leptos::HtmlElement<leptos::html::Div> =
                                    Dice_ui::method205(
                                        leptos::view! { <div  class:dark={move || v46()} class="flex flex-1">{v53()}</div> },
                                    );
                                let v61: leptos::View = leptos::IntoView::into_view(v59);
                                leptos::Fragment::new(vec![v61])
                            }
                        }
                    }
                }
            }
        }
        pub fn method348() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure211((), ()))
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method5()));
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v7 = Dice_ui::method7();
            let v8 = Dice_ui::method342();
            let v16: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v7() path=v6 /> })");
            let v17: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v7() path=v6 /> },
            );
            let v20: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method343()));
            let v22: &str = fable_library_rust::String_::LrcStr::as_str(&v20);
            let v24: std::string::String = String::from(v22);
            let v25 = Dice_ui::method344();
            let v26 = Dice_ui::method342();
            let v32: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v25() path=v24 /> })");
            let v33: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v25() path=v24 /> },
            );
            let v36: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method345()));
            let v38: &str = fable_library_rust::String_::LrcStr::as_str(&v36);
            let v40: std::string::String = String::from(v38);
            let v41 = Dice_ui::method346();
            let v42 = Dice_ui::method342();
            let v48: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v41() path=v40 /> })");
            let v49: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v41() path=v40 /> },
            );
            let v52: string = Dice_ui::method2(Dice_ui::method6(Dice_ui::method347()));
            let v54: &str = fable_library_rust::String_::LrcStr::as_str(&v52);
            let v56: std::string::String = String::from(v54);
            let v57 = Dice_ui::method348();
            let v58 = Dice_ui::method342();
            let v64: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v57() path=v56 /> })");
            let v69: Array<leptos::View> =
                Dice_ui::method184(Dice_ui::method183(Dice_ui::method182(new_array(&[
                    v17,
                    v33,
                    v49,
                    leptos::IntoView::into_view(
                        leptos::view! { <leptos_router::Route  view=move || v57() path=v56 /> },
                    ),
                ]))));
            leptos::Fragment::new(v69.to_vec())
        }
        pub fn method4() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure4((), ()))
        }
        pub fn method349(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1 = Dice_ui::method349(Dice_ui::method4());
            let v7: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> })");
            let v8: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> },
            );
            leptos::Fragment::new(vec![v8])
        }
        pub fn method3() -> Func0<leptos::Fragment> {
            Func0::new(move || Dice_ui::closure3((), ()))
        }
        pub fn method350(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
            leptos::logging::log!("{}", &string("app.render ()"));
            leptos_meta::provide_meta_context();
            {
                let v4: leptos::RwSignal<bool> = leptos::create_rw_signal(false);
                let v6: leptos::RwSignal<bool> = leptos::create_rw_signal(false);
                let v8: string = Dice_ui::method2(Dice_ui::method1());
                let v10: &str = fable_library_rust::String_::LrcStr::as_str(&v8);
                let v12: std::string::String = String::from(v10);
                let v15: LrcPtr<Dice_ui::Heap0> = LrcPtr::new(Dice_ui::Heap0 {
                    l0: v4,
                    l1: v6,
                    l2: leptos::create_rw_signal(v12),
                });
                let v17: leptos::RwSignal<LrcPtr<Dice_ui::Heap0>> = leptos::create_rw_signal(v15);
                let v19: string = string("include_str!(\"../../near/explorer_backend_host.txt\")");
                let v20: &str = include_str!("../../near/explorer_backend_host.txt");
                let v22: std::string::String = String::from(v20);
                let v25: LrcPtr<Dice_ui::Heap1> = LrcPtr::new(Dice_ui::Heap1 {
                    l0: leptos::create_rw_signal(v22),
                });
                let v27: leptos::RwSignal<LrcPtr<Dice_ui::Heap1>> = leptos::create_rw_signal(v25);
                let v29: std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> =
                    std::collections::HashMap::new();
                let v32: LrcPtr<Dice_ui::Heap2> = LrcPtr::new(Dice_ui::Heap2 {
                    l0: v17,
                    l1: leptos::create_rw_signal(v29),
                    l2: v27,
                });
                leptos::provide_context::<std::rc::Rc<Heap2>>(v32);
                {
                    let v35 = Dice_ui::method350(Dice_ui::method3());
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
        pub fn closure212(unitVar: (), unitVar_1: ()) {
            Dice_ui::method0();
        }
        pub fn method351() -> Func0<()> {
            Func0::new(move || Dice_ui::closure212((), ()))
        }
        pub fn method352(v0_1: Box<dyn Fn()>) -> Box<dyn Fn()> {
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
                    let v14 = Dice_ui::method351();
                    let v17: Box<dyn Fn()> = Dice_ui::method352(Box::new(move || v14()));
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
