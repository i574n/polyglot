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
mod module_d5f62357 {
    pub mod Ui {
        use super::*;
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
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::ofBoolean;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toString;
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0,
            US0_1(web_sys::HtmlElement),
        }
        impl core::fmt::Display for Ui::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default)]
        pub struct Heap0 {
            pub l0: leptos::RwSignal<bool>,
            pub l1: leptos::RwSignal<string>,
        }
        impl core::fmt::Display for Ui::Heap0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default)]
        pub struct Heap1 {
            pub l0: leptos::RwSignal<std::collections::HashMap<string, leptos::RwSignal<bool>>>,
            pub l1: leptos::RwSignal<LrcPtr<Ui::Heap0>>,
        }
        impl core::fmt::Display for Ui::Heap1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US1 {
            US1_0,
            US1_1,
        }
        impl core::fmt::Display for Ui::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US2 {
            US2_0(rexie::Error),
            US2_1(rexie::Rexie),
        }
        impl core::fmt::Display for Ui::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize, serde::Deserialize)]
        pub struct Heap2 {
            pub l0: bool,
            pub l1: std::string::String,
        }
        impl core::fmt::Display for Ui::Heap2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US3 {
            US3_0,
            US3_1(LrcPtr<Ui::Heap2>),
        }
        impl core::fmt::Display for Ui::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US4 {
            US4_0,
            US4_1(rexie::Rexie),
        }
        impl core::fmt::Display for Ui::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US5 {
            US5_0,
            US5_1(serde_json::Value),
        }
        impl core::fmt::Display for Ui::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(rexie::Error),
            US6_1(Ui::US3),
        }
        impl core::fmt::Display for Ui::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0(wasm_bindgen::JsValue),
            US7_1(Option<web_sys::Storage>),
        }
        impl core::fmt::Display for Ui::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0,
            US9_1(web_sys::Storage),
        }
        impl core::fmt::Display for Ui::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(wasm_bindgen::JsValue),
            US8_1(Ui::US9),
        }
        impl core::fmt::Display for Ui::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0,
            US10_1(Ui::US3),
        }
        impl core::fmt::Display for Ui::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(wasm_bindgen::JsValue),
            US11_1(Option<std::string::String>),
        }
        impl core::fmt::Display for Ui::US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0,
            US13_1(std::string::String),
        }
        impl core::fmt::Display for Ui::US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(wasm_bindgen::JsValue),
            US12_1(Ui::US13),
        }
        impl core::fmt::Display for Ui::US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US14 {
            US14_0,
            US14_1(Ui::US13),
        }
        impl core::fmt::Display for Ui::US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0,
            US15_1(leptos::RwSignal<bool>),
        }
        impl core::fmt::Display for Ui::US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US16 {
            US16_0,
            US16_1(bool),
        }
        impl core::fmt::Display for Ui::US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US17 {
            US17_0,
            US17_1,
        }
        impl core::fmt::Display for Ui::US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn closure1(unitVar: (), v0_1: web_sys::HtmlElement) -> Ui::US0 {
            Ui::US0::US0_1(v0_1)
        }
        pub fn method1() -> bool {
            false
        }
        pub fn method2() -> string {
            string("")
        }
        pub fn method3(v0_1: LrcPtr<Ui::Heap0>) -> LrcPtr<Ui::Heap0> {
            v0_1
        }
        pub fn method4(
            v0_1: std::collections::HashMap<string, leptos::RwSignal<bool>>,
        ) -> std::collections::HashMap<string, leptos::RwSignal<bool>> {
            v0_1
        }
        pub fn method7() -> string {
            string("")
        }
        pub fn method8(v0_1: string) -> string {
            v0_1
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> Ui::US1 {
            Ui::US1::US1_0
        }
        pub fn method10() -> Func0<Ui::US1> {
            Func0::new(move || Ui::closure6((), ()))
        }
        pub fn method11(v0_1: rexie::Rexie) -> Ui::US2 {
            Ui::US2::US2_1(v0_1)
        }
        pub fn method12(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure7(
            unitVar: (),
            v0_1: Ui::US1,
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
                        let v13: Ui::US2 = Ui::method11(v10.unwrap());
                        v13
                    }
                });
                {
                    let v16: std::pin::Pin<Box<dyn std::future::Future<Output = Ui::US2>>> =
                        __future_init;
                    let v18: Ui::US2 = v16.await;
                    let v25: rexie::Rexie = Ui::method12(match &v18 {
                        Ui::US2::US2_1(v18_1_0) => v18_1_0.clone(),
                        Ui::US2::US2_0(v18_0_0) => {
                            panic!("{}", sprintf!("Result value was Error: {}", v18_0_0),)
                        }
                    });
                    v25
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
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
        ) -> leptos::Resource<Ui::US1, rexie::Rexie> {
            v0_1
        }
        pub fn closure8(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Ui::US1, rexie::Rexie> = Ui::method14(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method13(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure8(v0_1.clone(), ())
            })
        }
        pub fn closure10(unitVar: (), v0_1: rexie::Rexie) -> Ui::US4 {
            Ui::US4::US4_1(v0_1)
        }
        pub fn method15(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure11(unitVar: (), v0_1: serde_json::Value) -> Ui::US5 {
            Ui::US5::US5_1(v0_1)
        }
        pub fn method16(v0_1: serde_json::Value) -> serde_json::Value {
            v0_1
        }
        pub fn method17(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method18(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure12(unitVar: (), v0_1: LrcPtr<Ui::Heap2>) -> Ui::US3 {
            Ui::US3::US3_1(v0_1)
        }
        pub fn method19(v0_1: Result<Ui::US3, rexie::Error>) -> Result<Ui::US3, rexie::Error> {
            v0_1
        }
        pub fn method20(v0_1: Ui::US3) -> Ui::US3 {
            v0_1
        }
        pub fn closure9(
            unitVar: (),
            v0_1: Option<rexie::Rexie>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Ui::US3>>> {
            let __future_init = Box::pin(async {
                //;
                {
                    let v3: string =
                    append(append(string("state.use_database () / state_data create_local_resource / database: "),
                                  sprintf!("{:?}", &v0_1)), string(""));
                    leptos::logging::log!("{}", &v3);
                    {
                        let v7: Ui::US4 = defaultValue(
                            Ui::US4::US4_0,
                            map(
                                Func1::new(move |v: rexie::Rexie| Ui::closure10((), v)),
                                v0_1,
                            ),
                        );
                        let v96: Ui::US3 = Ui::method20(match &v7 {
                            Ui::US4::US4_1(v7_1_0) => {
                                leptos::logging::log!("{}", &string("state.get_state_data ()"));
                                {
                                    let v11: rexie::Rexie = Ui::method15(v7_1_0.clone());
                                    let __future_init = Box::pin(async {
                                        //;
                                        {
                                            let v14: rexie::Transaction = v11.transaction(
                                                &["store"],
                                                rexie::TransactionMode::ReadOnly,
                                            )?;
                                            let v16: rexie::Store = v14.store("store")?;
                                            let v18: string = string("r#\"data\"#");
                                            let v19: &str = r#"data"#;
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
                                            > = Box::pin(rexie::Store::get(&v16, v21));
                                            let v25: Result<wasm_bindgen::JsValue, rexie::Error> =
                                                v23.await;
                                            let v27: wasm_bindgen::JsValue = v25?;
                                            fn v30(v_1: serde_json::Value) -> Ui::US5 {
                                                Ui::closure11((), v_1)
                                            }
                                            let v32: Ui::US5 = defaultValue(
                                                Ui::US5::US5_0,
                                                map(
                                                    Func1::from(v30),
                                                    serde_wasm_bindgen::from_value(v27).unwrap(),
                                                ),
                                            );
                                            let v77: Ui::US6 = match &v32 {
                                                Ui::US5::US5_1(v32_1_0) => {
                                                    let v34: serde_json::Value =
                                                        Ui::method16(v32_1_0.clone());
                                                    let v36: Vec<u8> =
                                                        serde_json::from_value(v34).unwrap();
                                                    let v38: string = append(
                                                        append(
                                                            string(
                                                                "state.get_state_data () / data: ",
                                                            ),
                                                            sprintf!("{:?}", &v36),
                                                        ),
                                                        string(""),
                                                    );
                                                    leptos::logging::log!("{}", &v38);
                                                    {
                                                        let v40: Vec<u8> = Ui::method17(v36);
                                                        let v42: std::string::String =
                                                            borsh::BorshDeserialize::deserialize(
                                                                &mut v40.as_slice(),
                                                            )
                                                            .unwrap();
                                                        let v43:
                                                                             string =
                                                                         append(append(string("state.get_state_data () / json: "),
                                                                                       toString(v42.clone())),
                                                                                string(""));
                                                        leptos::logging::log!("{}", &v43);
                                                        {
                                                            let v45: std::string::String =
                                                                Ui::method18(v42);
                                                            let v48:
                                                                                 string =
                                                                             Ui::method8(fable_library_rust::String_::fromString(v45));
                                                            let v50:
                                                                                 &str =
                                                                             fable_library_rust::String_::LrcStr::as_str(&v48);
                                                            let v52: std::string::String =
                                                                String::from(v50);
                                                            let v54: Result<
                                                                serde_json::Value,
                                                                serde_json::Error,
                                                            > = serde_json::from_str(&v52);
                                                            let v58: Ui::US5 = defaultValue(
                                                                Ui::US5::US5_0,
                                                                map(Func1::from(v30), v54.ok()),
                                                            );
                                                            let v62:
                                                                                 serde_json::Value =
                                                                             match &v58
                                                                                 {
                                                                                 Ui::US5::US5_1(v58_1_0)
                                                                                 =>
                                                                                 v58_1_0.clone(),
                                                                                 _
                                                                                 =>
                                                                                 panic!("{}",
                                                                                        string("Option does not have a value."),),
                                                                             };
                                                            let v64: string =
                                                                string("r#\"state-data\"#");
                                                            let v65: &str = r#"state-data"#;
                                                            let v67: &serde_json::Value = &v62[v65];
                                                            Ui::US6::US6_1(defaultValue(Ui::US3::US3_0,
                                                                                                     map(Func1::new(move
                                                                                                                        |v_2:
                                                                                                                             LrcPtr<Ui::Heap2>|
                                                                                                                        Ui::closure12((),
                                                                                                                                      v_2)),
                                                                                                         serde_json::from_value(v67.clone()).unwrap())))
                                                        }
                                                    }
                                                }
                                                _ => Ui::US6::US6_1(Ui::US3::US3_0),
                                            };
                                            let v84: Result<Ui::US3, rexie::Error> =
                                                Ui::method19(match &v77 {
                                                    Ui::US6::US6_1(v77_1_0) => Ok(v77_1_0.clone()),
                                                    Ui::US6::US6_0(v77_0_0) => Err(v77_0_0.clone()),
                                                });
                                            v84
                                        }
                                    });
                                    {
                                        // ;
                                        {
                                            let v88: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = Result<Ui::US3, rexie::Error>,
                                                    >,
                                                >,
                                            > = __future_init;
                                            let v90: Result<Ui::US3, rexie::Error> = v88.await;
                                            v90.unwrap()
                                        }
                                    }
                                }
                            }
                            _ => Ui::US3::US3_0,
                        });
                        v96
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
            let v1: web_sys::Window = Ui::method24(v0_1);
            v1.local_storage()
        }
        pub fn closure14(unitVar: (), v0_1: Option<web_sys::Storage>) -> Ui::US7 {
            Ui::US7::US7_1(v0_1)
        }
        pub fn closure15(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Ui::US7 {
            Ui::US7::US7_0(v0_1)
        }
        pub fn closure16(unitVar: (), v0_1: web_sys::Storage) -> Ui::US9 {
            Ui::US9::US9_1(v0_1)
        }
        pub fn method25(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Ui::US3>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Ui::US3> {
            v0_1
        }
        pub fn closure17(unitVar: (), v0_1: Ui::US3) -> Ui::US10 {
            Ui::US10::US10_1(v0_1)
        }
        pub fn method26(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method27() -> string {
            string("state-data")
        }
        pub fn closure18(unitVar: (), v0_1: Option<std::string::String>) -> Ui::US11 {
            Ui::US11::US11_1(v0_1)
        }
        pub fn closure19(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Ui::US11 {
            Ui::US11::US11_0(v0_1)
        }
        pub fn method28(v0_1: Option<std::string::String>) -> Option<std::string::String> {
            v0_1
        }
        pub fn closure20(unitVar: (), v0_1: std::string::String) -> Ui::US13 {
            Ui::US13::US13_1(v0_1)
        }
        pub fn method29(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method30(
            v0_1: leptos::RwSignal<LrcPtr<Ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Ui::Heap0>> {
            v0_1
        }
        pub fn method31(v0_1: bool) -> bool {
            v0_1
        }
        pub fn method32(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn method33(v0_1: string) -> string {
            v0_1
        }
        pub fn method34(v0_1: leptos::RwSignal<string>) -> leptos::RwSignal<string> {
            v0_1
        }
        pub fn closure13(
            v0_1: LrcPtr<Ui::Heap1>,
            v1: leptos::Resource<Option<rexie::Rexie>, Ui::US3>,
            unitVar: (),
        ) {
            leptos::logging::log!(
                "{}",
                &string("state.use_database () / create_effect 1 / ##1")
            );
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Ui::method23(Ui::method22());
                let v8: Ui::US7 = match &v5 {
                    Err(v5_1_0) => Ui::closure15((), v5_1_0.clone()),
                    Ok(v5_0_0) => Ui::closure14((), v5_0_0.clone()),
                };
                let v17: Ui::US8 = match &v8 {
                    Ui::US7::US7_1(v8_1_0) => Ui::US8::US8_1(defaultValue(
                        Ui::US9::US9_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Ui::closure16((), v_2)),
                            v8_1_0.clone(),
                        ),
                    )),
                    Ui::US7::US7_0(v8_0_0) => Ui::US8::US8_0(v8_0_0.clone()),
                };
                if let Ui::US8::US8_1(v17_1_0) = &v17 {
                    let v18: Ui::US9 = match &v17 {
                        Ui::US8::US8_1(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Ui::US9::US9_1(v18_1_0) = &v18 {
                        let v19: web_sys::Storage = match &v18 {
                            Ui::US9::US9_1(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v20: leptos::Resource<Option<rexie::Rexie>, Ui::US3> = Ui::method25(v1);
                        let v25: Ui::US10 = defaultValue(
                            Ui::US10::US10_0,
                            map(
                                Func1::new(move |v_3: Ui::US3| Ui::closure17((), v_3)),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v27: string =
                            append(append(string("state.use_database () / state_data effect 0 / ##1.1 / state_data1: "),
                                          sprintf!("{:?}", &v25)),
                                   string(""));
                        leptos::logging::log!("{}", &v27);
                        {
                            let v157: Ui::US3 = if let Ui::US10::US10_1(v25_1_0) = &v25 {
                                let v29: Ui::US3 = match &v25 {
                                    Ui::US10::US10_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Ui::US3::US3_1(v29_1_0) = &v29 {
                                    Ui::US3::US3_1(match &v29 {
                                        Ui::US3::US3_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    let v32: web_sys::Storage = Ui::method26(v19.clone());
                                    let v33: string = Ui::method27();
                                    let v35: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v33);
                                    let v37: Result<
                                        Option<std::string::String>,
                                        wasm_bindgen::JsValue,
                                    > = web_sys::Storage::get_item(&v32, v35);
                                    let v40: Ui::US11 = match &v37 {
                                        Err(v37_1_0) => Ui::closure19((), v37_1_0.clone()),
                                        Ok(v37_0_0) => Ui::closure18((), v37_0_0.clone()),
                                    };
                                    let v52: Ui::US12 = match &v40 {
                                        Ui::US11::US11_1(v40_1_0) => {
                                            let v42: Option<std::string::String> =
                                                Ui::method28(v40_1_0.clone());
                                            Ui::US12::US12_1(defaultValue(
                                                Ui::US13::US13_0,
                                                map(
                                                    Func1::new(move |v_6: std::string::String| {
                                                        Ui::closure20((), v_6)
                                                    }),
                                                    serde_json::from_value(v42.into()).unwrap(),
                                                ),
                                            ))
                                        }
                                        Ui::US11::US11_0(v40_0_0) => {
                                            Ui::US12::US12_0(v40_0_0.clone())
                                        }
                                    };
                                    let v58: Ui::US14 = match &v52 {
                                        Ui::US12::US12_1(v52_1_0) => {
                                            Ui::US14::US14_1(v52_1_0.clone())
                                        }
                                        _ => Ui::US14::US14_0,
                                    };
                                    let v65: Ui::US13 = if let Ui::US14::US14_1(v58_1_0) = &v58 {
                                        let v59: Ui::US13 = match &v58 {
                                            Ui::US14::US14_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Ui::US13::US13_1(v59_1_0) = &v59 {
                                            Ui::US13::US13_1(match &v59 {
                                                Ui::US13::US13_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Ui::US13::US13_0
                                        }
                                    } else {
                                        Ui::US13::US13_0
                                    };
                                    let v86: Ui::US10 = match &v65 {
                                        Ui::US13::US13_1(v65_1_0) => {
                                            let v68: std::string::String =
                                                Ui::method18(Ui::method29(v65_1_0.clone()));
                                            let v71: string = Ui::method8(
                                                fable_library_rust::String_::fromString(v68),
                                            );
                                            let v73: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v71);
                                            let v75: std::string::String = String::from(v73);
                                            let v77: Result<LrcPtr<Ui::Heap2>, serde_json::Error> =
                                                serde_json::from_str(&v75);
                                            Ui::US10::US10_1(defaultValue(
                                                Ui::US3::US3_0,
                                                map(
                                                    Func1::new(move |v_7: LrcPtr<Ui::Heap2>| {
                                                        Ui::closure12((), v_7)
                                                    }),
                                                    v77.ok(),
                                                ),
                                            ))
                                        }
                                        _ => Ui::US10::US10_0,
                                    };
                                    if let Ui::US10::US10_1(v86_1_0) = &v86 {
                                        let v87: Ui::US3 = match &v86 {
                                            Ui::US10::US10_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Ui::US3::US3_1(v87_1_0) = &v87 {
                                            Ui::US3::US3_1(match &v87 {
                                                Ui::US3::US3_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Ui::US3::US3_0
                                        }
                                    } else {
                                        Ui::US3::US3_0
                                    }
                                }
                            } else {
                                let v95: web_sys::Storage = Ui::method26(v19);
                                let v96: string = Ui::method27();
                                let v98: &str = fable_library_rust::String_::LrcStr::as_str(&v96);
                                let v100: Result<
                                    Option<std::string::String>,
                                    wasm_bindgen::JsValue,
                                > = web_sys::Storage::get_item(&v95, v98);
                                let v103: Ui::US11 = match &v100 {
                                    Err(v100_1_0) => Ui::closure19((), v100_1_0.clone()),
                                    Ok(v100_0_0) => Ui::closure18((), v100_0_0.clone()),
                                };
                                let v115: Ui::US12 = match &v103 {
                                    Ui::US11::US11_1(v103_1_0) => {
                                        let v105: Option<std::string::String> =
                                            Ui::method28(v103_1_0.clone());
                                        Ui::US12::US12_1(defaultValue(
                                            Ui::US13::US13_0,
                                            map(
                                                Func1::new(move |v_10: std::string::String| {
                                                    Ui::closure20((), v_10)
                                                }),
                                                serde_json::from_value(v105.into()).unwrap(),
                                            ),
                                        ))
                                    }
                                    Ui::US11::US11_0(v103_0_0) => {
                                        Ui::US12::US12_0(v103_0_0.clone())
                                    }
                                };
                                let v121: Ui::US14 = match &v115 {
                                    Ui::US12::US12_1(v115_1_0) => {
                                        Ui::US14::US14_1(v115_1_0.clone())
                                    }
                                    _ => Ui::US14::US14_0,
                                };
                                let v128: Ui::US13 = if let Ui::US14::US14_1(v121_1_0) = &v121 {
                                    let v122: Ui::US13 = match &v121 {
                                        Ui::US14::US14_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Ui::US13::US13_1(v122_1_0) = &v122 {
                                        Ui::US13::US13_1(match &v122 {
                                            Ui::US13::US13_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    } else {
                                        Ui::US13::US13_0
                                    }
                                } else {
                                    Ui::US13::US13_0
                                };
                                let v149: Ui::US10 = match &v128 {
                                    Ui::US13::US13_1(v128_1_0) => {
                                        let v131: std::string::String =
                                            Ui::method18(Ui::method29(v128_1_0.clone()));
                                        let v134: string = Ui::method8(
                                            fable_library_rust::String_::fromString(v131),
                                        );
                                        let v136: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v134);
                                        let v138: std::string::String = String::from(v136);
                                        let v140: Result<LrcPtr<Ui::Heap2>, serde_json::Error> =
                                            serde_json::from_str(&v138);
                                        Ui::US10::US10_1(defaultValue(
                                            Ui::US3::US3_0,
                                            map(
                                                Func1::new(move |v_11: LrcPtr<Ui::Heap2>| {
                                                    Ui::closure12((), v_11)
                                                }),
                                                v140.ok(),
                                            ),
                                        ))
                                    }
                                    _ => Ui::US10::US10_0,
                                };
                                if let Ui::US10::US10_1(v149_1_0) = &v149 {
                                    let v150: Ui::US3 = match &v149 {
                                        Ui::US10::US10_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Ui::US3::US3_1(v150_1_0) = &v150 {
                                        Ui::US3::US3_1(match &v150 {
                                            Ui::US3::US3_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    } else {
                                        Ui::US3::US3_0
                                    }
                                } else {
                                    Ui::US3::US3_0
                                }
                            };
                            let v159: string =
                                append(append(string("state.use_database () / state_data effect 0 / ##1.1 / state_data2: "),
                                              sprintf!("{:?}", &v157)),
                                       string(""));
                            leptos::logging::log!("{}", &v159);
                            if let Ui::US3::US3_1(v157_1_0) = &v157 {
                                let v161: LrcPtr<Ui::Heap2> = match &v157 {
                                    Ui::US3::US3_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v162: leptos::RwSignal<LrcPtr<Ui::Heap0>> = v0_1.l1.clone();
                                let v163: leptos::RwSignal<LrcPtr<Ui::Heap0>> =
                                    Ui::method30(v162.clone());
                                let v165: LrcPtr<Ui::Heap0> =
                                    leptos::SignalGetUntracked::get_untracked(&v163);
                                let v168: bool = Ui::method31(v161.l0);
                                let v169: leptos::RwSignal<bool> = Ui::method32(v165.l0.clone());
                                leptos::SignalSet::set(&v169, v168);
                                {
                                    let v171: leptos::RwSignal<LrcPtr<Ui::Heap0>> =
                                        Ui::method30(v162);
                                    let v173: LrcPtr<Ui::Heap0> =
                                        leptos::SignalGetUntracked::get_untracked(&v171);
                                    let v176: std::string::String = Ui::method18(v161.l1.clone());
                                    let v179: string =
                                        Ui::method33(fable_library_rust::String_::fromString(v176));
                                    let v180: leptos::RwSignal<string> =
                                        Ui::method34(v173.l1.clone());
                                    leptos::SignalSet::set(&v180, v179);
                                    ()
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn method21(
            v0_1: LrcPtr<Ui::Heap1>,
            v1: leptos::Resource<Option<rexie::Rexie>, Ui::US3>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure13(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method36(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn method37(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn method38() {
            ();
        }
        pub fn closure21(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
            v1: LrcPtr<Ui::Heap2>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v4: string = append(
                append(
                    string("state.use_database () / set_state_data_action / value: "),
                    toString(format!("{:?}", &v1)),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v4);
            {
                let v6: leptos::Resource<Ui::US1, rexie::Rexie> = Ui::method14(v0_1);
                let v11: Ui::US4 = defaultValue(
                    Ui::US4::US4_0,
                    map(
                        Func1::new(move |v: rexie::Rexie| Ui::closure10((), v)),
                        leptos::SignalGet::get(&v6),
                    ),
                );
                let __future_init = Box::pin(async move {
                    //;
                    match &v11 {
                        Ui::US4::US4_1(v11_1_0) => {
                            let v16: string = append(
                                append(
                                    string("state.set_state_data () / state_data: "),
                                    toString(format!("{:?}", &v1)),
                                ),
                                string(""),
                            );
                            leptos::logging::log!("{}", &v16);
                            {
                                let v18: rexie::Rexie = Ui::method36(v11_1_0.clone());
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v21: rexie::Transaction = v18.transaction(
                                            &["store"],
                                            rexie::TransactionMode::ReadWrite,
                                        )?;
                                        let v23: rexie::Store = v21.store("store")?;
                                        let v25: string = string("r#\"state-data\"#");
                                        let v26: &str = r#"state-data"#;
                                        let v28: std::string::String =
                                            serde_json::json!({ v26: v1 }).to_string();
                                        let mut data = Vec::new();
                                        borsh::BorshSerialize::serialize(&v28, &mut data).unwrap();
                                        {
                                            let v32: Vec<u8> = data;
                                            let v34: wasm_bindgen::JsValue =
                                                serde_wasm_bindgen::to_value(&v32).unwrap();
                                            v23.put(&v34, Some(&"data".into())).await?;
                                            v21.done().await?;
                                            {
                                                let v38: Result<(), rexie::Error> =
                                                    Ui::method37(Ok(()));
                                                v38
                                            }
                                        }
                                    }
                                });
                                {
                                    {
                                        {
                                            //;
                                            {
                                                let v41: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<(), rexie::Error>,
                                                        >,
                                                    >,
                                                > = __future_init;
                                                let v43: Result<(), rexie::Error> = v41.await;
                                                v43.unwrap();
                                                ()
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
                    Ui::method38();
                    ()
                });
                // ;
                __future_init
            }
        }
        pub fn method35(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
        ) -> Func1<LrcPtr<Ui::Heap2>, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Ui::Heap2>| Ui::closure21(v0_1.clone(), v)
            })
        }
        pub fn method40(
            v0_1: leptos::RwSignal<std::collections::HashMap<string, leptos::RwSignal<bool>>>,
        ) -> leptos::RwSignal<std::collections::HashMap<string, leptos::RwSignal<bool>>> {
            v0_1
        }
        pub fn closure22(
            v0_1: LrcPtr<Ui::Heap1>,
            unitVar: (),
        ) -> std::collections::HashMap<string, leptos::RwSignal<bool>> {
            leptos::logging::log!("{}", &string("state.use_database () / loading create_memo"));
            {
                let v4: leptos::RwSignal<
                    std::collections::HashMap<string, leptos::RwSignal<bool>>,
                > = Ui::method40(v0_1.l0.clone());
                leptos::SignalGetUntracked::get_untracked(&v4)
            }
        }
        pub fn method39(
            v0_1: LrcPtr<Ui::Heap1>,
        ) -> Func0<std::collections::HashMap<string, leptos::RwSignal<bool>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure22(v0_1.clone(), ())
            })
        }
        pub fn method41() -> bool {
            false
        }
        pub fn method43(v0_1: leptos::ReadSignal<bool>) -> leptos::ReadSignal<bool> {
            v0_1
        }
        pub fn method44(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn method45(v0_1: leptos::RwSignal<string>) -> leptos::RwSignal<string> {
            v0_1
        }
        pub fn method46() -> string {
            string("dark_mode_key")
        }
        pub fn closure24(unitVar: (), v0_1: leptos::RwSignal<bool>) -> Ui::US15 {
            Ui::US15::US15_1(v0_1)
        }
        pub fn method47() -> bool {
            true
        }
        pub fn method48(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method49(v0_1: LrcPtr<Ui::Heap2>) -> LrcPtr<Ui::Heap2> {
            v0_1
        }
        pub fn method50(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method51(v0_1: LrcPtr<Ui::Heap2>) -> LrcPtr<Ui::Heap2> {
            v0_1
        }
        pub fn method52(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure23(
            v0_1: LrcPtr<Ui::Heap1>,
            v1: leptos::Action<LrcPtr<Ui::Heap2>, ()>,
            v2: leptos::Memo<std::collections::HashMap<string, leptos::RwSignal<bool>>>,
            v3: leptos::WriteSignal<bool>,
            v4: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v5: leptos::ReadSignal<bool> = Ui::method43(v4);
            let v7: bool = leptos::SignalGet::get(&v5);
            let v8: string = append(
                append(
                    string("state.use_database () / create_effect 2 / ##1 / loaded: "),
                    ofBoolean(v7),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v8);
            {
                let v10: leptos::RwSignal<LrcPtr<Ui::Heap0>> = v0_1.l1.clone();
                let v11: leptos::RwSignal<LrcPtr<Ui::Heap0>> = Ui::method30(v10.clone());
                let v15: leptos::RwSignal<bool> =
                    Ui::method44((leptos::SignalGetUntracked::get_untracked(&v11)).l0.clone());
                let v17: bool = leptos::SignalGet::get(&v15);
                let v18: leptos::RwSignal<LrcPtr<Ui::Heap0>> = Ui::method30(v10);
                let v22: leptos::RwSignal<string> =
                    Ui::method45((leptos::SignalGetUntracked::get_untracked(&v18)).l1.clone());
                let v25: string = Ui::method8(leptos::SignalGet::get(&v22));
                let v27: &str = fable_library_rust::String_::LrcStr::as_str(&v25);
                let v30: LrcPtr<Ui::Heap2> = LrcPtr::new(Ui::Heap2 {
                    l0: v17,
                    l1: String::from(v27),
                });
                let v33: string = append(
                    append(
                        string("state.use_database () / create_effect 2 / ##2 / new_state_data: "),
                        toString(format!("{:?}", &v30)),
                    ),
                    string(""),
                );
                leptos::logging::log!("{}", &v33);
                {
                    let v36: std::collections::HashMap<string, leptos::RwSignal<bool>> = v2();
                    let v37: string = Ui::method46();
                    let v42: Ui::US15 = defaultValue(
                        Ui::US15::US15_0,
                        map(
                            Func1::new(move |v: leptos::RwSignal<bool>| Ui::closure24((), v)),
                            std::collections::HashMap::get(&v36, &v37).map(|x| *x),
                        ),
                    );
                    let v50: Ui::US16 = match &v42 {
                        Ui::US15::US15_1(v42_1_0) => {
                            let v44: leptos::RwSignal<bool> = Ui::method44(v42_1_0.clone());
                            Ui::US16::US16_1(leptos::SignalGet::get(&v44))
                        }
                        _ => Ui::US16::US16_0,
                    };
                    let v53: bool = match &v50 {
                        Ui::US16::US16_1(v50_1_0) => v50_1_0.clone(),
                        _ => false,
                    };
                    let v54: string =
                        append(append(string("state.use_database () / create_effect 2 / ##3 / dark_mode_loading: "),
                                      ofBoolean(v53)), string(""));
                    leptos::logging::log!("{}", &v54);
                    if v53 == false {
                        if v7 == false {
                            let v58: bool = Ui::method47();
                            let v59: leptos::WriteSignal<bool> = Ui::method48(v3);
                            leptos::SignalSet::set(&v59, v58);
                            ()
                        } else {
                            leptos::logging::log!(
                                "{}",
                                &string("state.use_database () / create_effect 2 / ##4")
                            );
                            {
                                let v64: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                                    Ui::method23(Ui::method22());
                                let v67: Ui::US7 = match &v64 {
                                    Err(v64_1_0) => Ui::closure15((), v64_1_0.clone()),
                                    Ok(v64_0_0) => Ui::closure14((), v64_0_0.clone()),
                                };
                                let v76: Ui::US8 = match &v67 {
                                    Ui::US7::US7_1(v67_1_0) => Ui::US8::US8_1(defaultValue(
                                        Ui::US9::US9_0,
                                        map(
                                            Func1::new(move |v_3: web_sys::Storage| {
                                                Ui::closure16((), v_3)
                                            }),
                                            v67_1_0.clone(),
                                        ),
                                    )),
                                    Ui::US7::US7_0(v67_0_0) => Ui::US8::US8_0(v67_0_0.clone()),
                                };
                                if let Ui::US8::US8_1(v76_1_0) = &v76 {
                                    let v77: Ui::US9 = match &v76 {
                                        Ui::US8::US8_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Ui::US9::US9_1(v77_1_0) = &v77 {
                                        let v79: LrcPtr<Ui::Heap2> = Ui::method49(v30.clone());
                                        leptos::Action::dispatch(&v1, v79);
                                        {
                                            let v81: web_sys::Storage = Ui::method50(match &v77 {
                                                Ui::US9::US9_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            });
                                            let v82: string = Ui::method27();
                                            let v84: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v82);
                                            let v85: LrcPtr<Ui::Heap2> = Ui::method51(v30);
                                            let v88: std::string::String =
                                                Ui::method52(serde_json::json!(v85).to_string());
                                            let v90: &str = v88.as_str();
                                            web_sys::Storage::set(&v81, v84, v90).unwrap();
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
        pub fn method42(
            v0_1: LrcPtr<Ui::Heap1>,
            v1: leptos::Action<LrcPtr<Ui::Heap2>, ()>,
            v2: leptos::Memo<std::collections::HashMap<string, leptos::RwSignal<bool>>>,
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
                    Ui::closure23(
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
        pub fn method54(
            v0_1: leptos::RwSignal<LrcPtr<Ui::Heap0>>,
        ) -> leptos::RwSignal<LrcPtr<Ui::Heap0>> {
            v0_1
        }
        pub fn closure25(v0_1: LrcPtr<Ui::Heap1>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Ui::Heap0>> = Ui::method54(v0_1.l1.clone());
            let v6: leptos::RwSignal<bool> = Ui::method44((leptos::SignalGet::get(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method53(v0_1: LrcPtr<Ui::Heap1>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure25(v0_1.clone(), ())
            })
        }
        pub fn method56(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method57(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method58() -> Ui::US17 {
            Ui::US17::US17_0
        }
        pub fn method60(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn closure27(
            v0_1: leptos_router::Location,
            v1: string,
            v2: LrcPtr<Ui::Heap1>,
            unitVar: (),
        ) {
            let v3: leptos_router::Location = Ui::method60(v0_1);
            let v5: leptos::Memo<std::string::String> = v3.hash;
            let v8: string = sprintf!("{}{}", &v1, v5());
            let v9: string = append(
                append(
                    string("content.render () / effect / new_url_hash: "),
                    v8.clone(),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v9);
            {
                let v12: leptos::RwSignal<LrcPtr<Ui::Heap0>> = Ui::method54(v2.l1.clone());
                let v14: LrcPtr<Ui::Heap0> = leptos::SignalGet::get(&v12);
                let v16: string = Ui::method33(v8);
                let v17: leptos::RwSignal<string> = Ui::method34(v14.l1.clone());
                leptos::SignalSet::set(&v17, v16);
                ()
            }
        }
        pub fn method59(
            v0_1: leptos_router::Location,
            v1: string,
            v2: LrcPtr<Ui::Heap1>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Ui::closure27(v0_1.clone(), v1.clone(), v2.clone(), ())
            })
        }
        pub fn method62(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method63(v0_1: &str) -> &str {
            v0_1
        }
        pub fn method64() -> string {
            string("/settings")
        }
        pub fn method65(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method66(v0_1: Ui::US17) -> Ui::US17 {
            v0_1
        }
        pub fn method67(v0_1: leptos::WriteSignal<Ui::US17>) -> leptos::WriteSignal<Ui::US17> {
            v0_1
        }
        pub fn closure28(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Ui::US17>,
            unitVar: (),
        ) {
            let v2: leptos_router::Location = Ui::method60(v0_1);
            let v4: leptos::Memo<std::string::String> = v2.hash;
            let v7: std::string::String = Ui::method62(v4());
            let v9: Option<&str> = v7.strip_prefix('#');
            let v11: string = string("r#\"\"#");
            let v12: &str = r#""#;
            let v15: &str = Ui::method63(v9.unwrap_or(v12));
            let v17: Result<leptos_router::Url, std::string::String> =
                leptos_router::Url::try_from(v15);
            let v19: leptos_router::Url = v17.unwrap();
            let v22: string = append(
                append(
                    string("content.render () / effect / hash_url: "),
                    toString(format!("{:#?}", &v19)),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v22);
            {
                let v25: std::string::String = v19.pathname;
                let v26: string = Ui::method64();
                let v28: &str = fable_library_rust::String_::LrcStr::as_str(&v26);
                let v30: std::string::String = String::from(v28);
                let v31: std::string::String = Ui::method65(v25);
                let v36: Ui::US17 = if v31.starts_with(&v30) {
                    Ui::US17::US17_1
                } else {
                    Ui::US17::US17_0
                };
                let v39: string = append(
                    append(
                        string("content.render () / effect / new_tab: "),
                        toString(format!("{:#?}", &v36)),
                    ),
                    string(""),
                );
                leptos::logging::log!("{}", &v39);
                {
                    let v41: Ui::US17 = Ui::method66(v36);
                    let v42: leptos::WriteSignal<Ui::US17> = Ui::method67(v1);
                    leptos::SignalSet::set(&v42, v41);
                    ()
                }
            }
        }
        pub fn method61(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Ui::US17>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure28(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure30(
            v0_1: leptos::ReadSignal<Ui::US17>,
            unitVar: (),
        ) -> leptos::ReadSignal<Ui::US17> {
            v0_1
        }
        pub fn method69(v0_1: leptos::ReadSignal<Ui::US17>) -> Func0<leptos::ReadSignal<Ui::US17>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure30(v0_1.clone(), ())
            })
        }
        pub fn method71(v0_1: leptos::ReadSignal<Ui::US17>) -> leptos::ReadSignal<Ui::US17> {
            v0_1
        }
        pub fn method72() -> string {
            string("View")
        }
        pub fn closure36(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method77() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Ui::closure36((), v))
        }
        pub fn method78(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure35(v0_1: LrcPtr<Ui::Heap1>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<LrcPtr<Ui::Heap0>> = Ui::method54(v0_1.l1.clone());
            let v5: LrcPtr<Ui::Heap0> = leptos::SignalGet::get(&v3);
            let v7 = Ui::method77();
            let v8: leptos::RwSignal<bool> = Ui::method78(v5.l0.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(*x));
            ()
        }
        pub fn method76(v0_1: LrcPtr<Ui::Heap1>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Ui::closure35(v0_1.clone(), v)
            })
        }
        pub fn closure37(v0_1: LrcPtr<Ui::Heap1>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<LrcPtr<Ui::Heap0>> = Ui::method54(v0_1.l1.clone());
            let v6: leptos::RwSignal<bool> = Ui::method44((leptos::SignalGet::get(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method79(v0_1: LrcPtr<Ui::Heap1>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure37(v0_1.clone(), ())
            })
        }
        pub fn method80(
            v0_1: leptos::HtmlElement<leptos::html::Label>,
        ) -> leptos::HtmlElement<leptos::html::Label> {
            v0_1
        }
        pub fn method81(v0_1: leptos::Fragment) -> leptos::Fragment {
            v0_1
        }
        pub fn method82(v0_1: leptos::Fragment) -> leptos::Fragment {
            v0_1
        }
        pub fn closure39(v0_1: leptos::Fragment, unitVar: ()) -> leptos::Fragment {
            v0_1
        }
        pub fn method84(v0_1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure39(v0_1.clone(), ())
            })
        }
        pub fn method85(
            v0_1: leptos::HtmlElement<leptos::html::Dt>,
        ) -> leptos::HtmlElement<leptos::html::Dt> {
            v0_1
        }
        pub fn closure40(v0_1: leptos::Fragment, unitVar: ()) -> leptos::Fragment {
            v0_1
        }
        pub fn method86(v0_1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure40(v0_1.clone(), ())
            })
        }
        pub fn method87(
            v0_1: leptos::HtmlElement<leptos::html::Dd>,
        ) -> leptos::HtmlElement<leptos::html::Dd> {
            v0_1
        }
        pub fn method88(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn closure38(
            v0_1: leptos::Fragment,
            v1: leptos::Fragment,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(" class=\"font-medium text-gray-700\"");
            let v5 = Ui::method84(v0_1);
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
            let v11: leptos::HtmlElement<leptos::html::Dt> =
                Ui::method85(leptos::view! { <dt  class="font-medium text-gray-700">{v5()}</dt> });
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            let v15: string = string(" class=\"text-gray-700 md:col-span-2 flex flex-1\"");
            let v16 = Ui::method86(v1);
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
            let v22: leptos::HtmlElement<leptos::html::Dd> = Ui::method87(
                leptos::view! { <dd  class="text-gray-700 md:col-span-2 flex flex-1">{v16()}</dd> },
            );
            let v26: Array<leptos::View> =
                Ui::method88(new_array(&[v13, leptos::IntoView::into_view(v22)]));
            leptos::Fragment::new(v26.to_vec())
        }
        pub fn method83(v0_1: leptos::Fragment, v1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure38(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method89(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string("r#\"Dark Mode\"#");
            let v3: &str = r#"Dark Mode"#;
            let v5: leptos::leptos_dom::Text = leptos::html::text(v3);
            let v7: leptos::View = leptos::IntoView::into_view(v5);
            let v9: leptos::Fragment = leptos::Fragment::new(vec![v7]);
            leptos::logging::log!("{}", &string("dark_mode_toggle.render ()"));
            {
                let v13: LrcPtr<Ui::Heap1> =
                    leptos::use_context::<std::rc::Rc<Heap1>>().unwrap().into();
                let v14 = Ui::method76(v13.clone());
                let v15 = Ui::method79(v13);
                let v17: string = Ui::method8(string("v14"));
                let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
                let v21: std::string::String = String::from(v19);
                let v22: string =
                    string("<label for={v21.clone()} class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\"><input type=\"checkbox\" id={v21} class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\" on:change=move |event| v14(event) prop:checked={move || v15()} /><span class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-gray-200\"><svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg><svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg></span><span class=\"absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-gray-200\"></span></label>");
                let v23: string = append(append(string("leptos::view! { "), v22), string(" }"));
                let v26: leptos::HtmlElement<leptos::html::Label> = Ui::method80(
                    leptos::view! { <label for={v21.clone()} class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"><input type="checkbox" id={v21} class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" on:change=move |event| v14(event) prop:checked={move || v15()} /><span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-gray-200"><svg data-unchecked-icon xmlns="http://www.w3.org/2000/svg" class="h-4 w-4" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" clip-rule="evenodd" /></svg><svg data-checked-icon xmlns="http://www.w3.org/2000/svg" class="hidden h-4 w-4" viewBox="0 0 20 20" fill="currentColor"> <path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" /></svg></span><span class="absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-gray-200"></span></label> },
                );
                let v28: leptos::View = leptos::IntoView::into_view(v26);
                let v30: leptos::Fragment = leptos::Fragment::new(vec![v28]);
                let v35: string =
                    string(" class=\"grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-center\"");
                let v36 = Ui::method83(Ui::method81(v9), Ui::method82(v30));
                let v39: string = append(
                    append(
                        string("leptos::view! { "),
                        append(
                            append(
                                append(append(string("<div "), v35), string(">{v36()}</")),
                                string("div"),
                            ),
                            string(">"),
                        ),
                    ),
                    string(" }"),
                );
                let v42: leptos::HtmlElement<leptos::html::Div> = Ui::method89(
                    leptos::view! { <div  class="grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-center">{v36()}</div> },
                );
                let v44: leptos::View = leptos::IntoView::into_view(v42);
                leptos::Fragment::new(vec![v44])
            }
        }
        pub fn method75() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure34((), ()))
        }
        pub fn method90(
            v0_1: leptos::HtmlElement<leptos::html::Dl>,
        ) -> leptos::HtmlElement<leptos::html::Dl> {
            v0_1
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string(" class=\"flex flex-1 divide-y divide-gray-100 text-sm\"");
            let v3 = Ui::method75();
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
            let v9: leptos::HtmlElement<leptos::html::Dl> = Ui::method90(
                leptos::view! { <dl  class="flex flex-1 divide-y divide-gray-100 text-sm">{v3()}</dl> },
            );
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method74() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure33((), ()))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> leptos::HtmlElement<leptos::html::Div> {
            let v2: string = string(" class=\"flow-root\"");
            let v3 = Ui::method74();
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
            leptos::view! { <div  class="flow-root">{v3()}</div> }
        }
        pub fn method73() -> Func0<leptos::HtmlElement<leptos::html::Div>> {
            Func0::new(move || Ui::closure32((), ()))
        }
        pub fn method91(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
        ) -> leptos::HtmlElement<leptos::html::Details> {
            v0_1
        }
        pub fn method92() -> string {
            string("Connection")
        }
        pub fn method96() -> string {
            string("explorer-backend-mainnet-prod-24ktefolwq-uc.a.run.app")
        }
        pub fn method97(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method98(
            v0_1: leptos::ReadSignal<std::string::String>,
        ) -> leptos::ReadSignal<std::string::String> {
            v0_1
        }
        pub fn method99(
            v0_1: leptos::WriteSignal<std::string::String>,
        ) -> leptos::WriteSignal<std::string::String> {
            v0_1
        }
        pub fn method100(
            v0_1: leptos::HtmlElement<leptos::html::Input>,
        ) -> leptos::HtmlElement<leptos::html::Input> {
            v0_1
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string("r#\"Explorer Backend Host\"#");
            let v3: &str = r#"Explorer Backend Host"#;
            let v5: leptos::leptos_dom::Text = leptos::html::text(v3);
            let v7: leptos::View = leptos::IntoView::into_view(v5);
            let v9: leptos::Fragment = leptos::Fragment::new(vec![v7]);
            let v10: string = Ui::method96();
            let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
            let v15: std::string::String = Ui::method97(String::from(v12));
            let patternInput: (
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ) = leptos::create_signal(v15);
            let v19: leptos::ReadSignal<std::string::String> = Ui::method98(patternInput.0.clone());
            let v20: leptos::WriteSignal<std::string::String> =
                Ui::method99(patternInput.1.clone());
            let v30: string =
                string("leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v20(leptos::event_target_value(&event)) prop:value=v19 class=\"bg-gray-50 flex-1 h-[27px]\" /> }");
            let v33: leptos::HtmlElement<leptos::html::Input> = Ui::method100(
                leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v20(leptos::event_target_value(&event)) prop:value=v19 class="bg-gray-50 flex-1 h-[27px]" /> },
            );
            let v35: leptos::View = leptos::IntoView::into_view(v33);
            let v37: leptos::Fragment = leptos::Fragment::new(vec![v35]);
            let v41: string =
                string(" class=\"grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-baseline\"");
            let v42 = Ui::method83(Ui::method81(v9), Ui::method82(v37));
            let v45: string = append(
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
            let v48: leptos::HtmlElement<leptos::html::Div> = Ui::method89(
                leptos::view! { <div  class="grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-baseline">{v42()}</div> },
            );
            let v50: leptos::View = leptos::IntoView::into_view(v48);
            leptos::Fragment::new(vec![v50])
        }
        pub fn method95() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure43((), ()))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string(" class=\"flex flex-1 divide-y divide-gray-100 text-sm\"");
            let v3 = Ui::method95();
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
            let v9: leptos::HtmlElement<leptos::html::Dl> = Ui::method90(
                leptos::view! { <dl  class="flex flex-1 divide-y divide-gray-100 text-sm">{v3()}</dl> },
            );
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method94() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure42((), ()))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> leptos::HtmlElement<leptos::html::Div> {
            let v2: string = string(" class=\"flow-root\"");
            let v3 = Ui::method94();
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
            leptos::view! { <div  class="flow-root">{v3()}</div> }
        }
        pub fn method93() -> Func0<leptos::HtmlElement<leptos::html::Div>> {
            Func0::new(move || Ui::closure41((), ()))
        }
        pub fn closure31(unitVar: (), v0_1: leptos::ReadSignal<Ui::US17>) -> leptos::View {
            let v1: leptos::ReadSignal<Ui::US17> = Ui::method71(v0_1);
            let v3: Ui::US17 = leptos::SignalGet::get(&v1);
            match &v3 {
                Ui::US17::US17_1 => {
                    let v12: string = Ui::method8(Ui::method72());
                    let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
                    let v16: std::string::String = String::from(v14);
                    let v17 = Ui::method73();
                    let v18: string =
                        string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v16}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\"><svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg></span></summary>{v17()}</details>");
                    let v19: string = append(append(string("leptos::view! { "), v18), string(" }"));
                    let v22: leptos::HtmlElement<leptos::html::Details> = Ui::method91(
                        leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v16}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180"><svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg></span></summary>{v17()}</details> },
                    );
                    let v24: leptos::View = leptos::IntoView::into_view(v22);
                    let v26: string = Ui::method8(Ui::method92());
                    let v28: &str = fable_library_rust::String_::LrcStr::as_str(&v26);
                    let v30: std::string::String = String::from(v28);
                    let v31 = Ui::method93();
                    let v32: string =
                        string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v30}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\"><svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg></span></summary>{v31()}</details>");
                    let v33: string = append(append(string("leptos::view! { "), v32), string(" }"));
                    let v36: leptos::HtmlElement<leptos::html::Details> = Ui::method91(
                        leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v30}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180"><svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg></span></summary>{v31()}</details> },
                    );
                    let v40: Array<leptos::View> =
                        Ui::method88(new_array(&[v24, leptos::IntoView::into_view(v36)]));
                    let v42: leptos::Fragment = leptos::Fragment::new(v40.to_vec());
                    leptos::IntoView::into_view(v42)
                }
                _ => {
                    let v5: string = string("r#\"\"#");
                    let v6: &str = r#""#;
                    let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
                    leptos::IntoView::into_view(v8)
                }
            }
        }
        pub fn method70() -> Func1<leptos::ReadSignal<Ui::US17>, leptos::View> {
            Func1::new(move |v: leptos::ReadSignal<Ui::US17>| Ui::closure31((), v))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = string("r#\"Tab\"#");
            let v2: &str = r#"Tab"#;
            let v4: leptos::leptos_dom::Text = leptos::html::text(v2);
            let v6: leptos::View = leptos::IntoView::into_view(v4);
            leptos::Fragment::new(vec![v6])
        }
        pub fn method104() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure47((), ()))
        }
        pub fn closure49(v0_1: leptos::ReadSignal<Ui::US17>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Ui::US17> = Ui::method71(v0_1);
            if let Ui::US17::US17_0 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method106(v0_1: leptos::ReadSignal<Ui::US17>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure49(v0_1.clone(), ())
            })
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = string("r#\"History\"#");
            let v2: &str = r#"History"#;
            let v4: leptos::leptos_dom::Text = leptos::html::text(v2);
            let v6: leptos::View = leptos::IntoView::into_view(v4);
            leptos::Fragment::new(vec![v6])
        }
        pub fn method107() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure50((), ()))
        }
        pub fn method108(
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::HtmlElement<leptos::html::Option_> {
            v0_1
        }
        pub fn closure51(v0_1: leptos::ReadSignal<Ui::US17>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Ui::US17> = Ui::method71(v0_1);
            if let Ui::US17::US17_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method109(v0_1: leptos::ReadSignal<Ui::US17>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure51(v0_1.clone(), ())
            })
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = string("r#\"Settings\"#");
            let v2: &str = r#"Settings"#;
            let v4: leptos::leptos_dom::Text = leptos::html::text(v2);
            let v6: leptos::View = leptos::IntoView::into_view(v4);
            leptos::Fragment::new(vec![v6])
        }
        pub fn method110() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure52((), ()))
        }
        pub fn closure48(v0_1: leptos::ReadSignal<Ui::US17>, unitVar: ()) -> leptos::Fragment {
            let v1 = Ui::method106(v0_1.clone());
            let v4: string = string(" select=v1()");
            let v5 = Ui::method107();
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
                Ui::method108(leptos::view! { <option  select=v1()>{v5()}</option> });
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            let v14 = Ui::method109(v0_1);
            let v16: string = string(" select=v14()");
            let v17 = Ui::method110();
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
                Ui::method108(leptos::view! { <option  select=v14()>{v17()}</option> });
            let v26: Array<leptos::View> =
                Ui::method88(new_array(&[v13, leptos::IntoView::into_view(v22)]));
            leptos::Fragment::new(v26.to_vec())
        }
        pub fn method105(v0_1: leptos::ReadSignal<Ui::US17>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure48(v0_1.clone(), ())
            })
        }
        pub fn method111(
            v0_1: leptos::HtmlElement<leptos::html::Select>,
        ) -> leptos::HtmlElement<leptos::html::Select> {
            v0_1
        }
        pub fn closure46(v0_1: leptos::ReadSignal<Ui::US17>, unitVar: ()) -> leptos::Fragment {
            let v5: string = string(" class=\"sr-only\" for=\"Tab\"");
            let v6 = Ui::method104();
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
            let v12: leptos::HtmlElement<leptos::html::Label> =
                Ui::method80(leptos::view! { <label  class="sr-only" for="Tab">{v6()}</label> });
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v18: string = string(" class=\"w-full rounded-md border-gray-200\" id=\"Tab\"");
            let v19 = Ui::method105(v0_1);
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
            let v25: leptos::HtmlElement<leptos::html::Select> = Ui::method111(
                leptos::view! { <select  class="w-full rounded-md border-gray-200" id="Tab">{v19()}</select> },
            );
            let v29: Array<leptos::View> =
                Ui::method88(new_array(&[v14, leptos::IntoView::into_view(v25)]));
            leptos::Fragment::new(v29.to_vec())
        }
        pub fn method103(v0_1: leptos::ReadSignal<Ui::US17>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure46(v0_1.clone(), ())
            })
        }
        pub fn closure56(v0_1: leptos::ReadSignal<Ui::US17>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Ui::US17> = Ui::method71(v0_1);
            if let Ui::US17::US17_0 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method115(v0_1: leptos::ReadSignal<Ui::US17>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure56(v0_1.clone(), ())
            })
        }
        pub fn method116(v0_1: Func0<bool>) -> Func0<bool> {
            v0_1
        }
        pub fn closure57(v0_1: Func0<bool>, unitVar: ()) -> &'static str {
            if v0_1() {
                let v3: string = string("r#\"border-grey-200 text-grey-900\"#");
                r#"border-grey-200 text-grey-900"#
            } else {
                let v6: string =
                    string("r#\"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700\"#");
                r#"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700"#
            }
        }
        pub fn method117(v0_1: Func0<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure57(v0_1.clone(), ())
            })
        }
        pub fn method119(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> leptos::HtmlElement<leptos::svg::Svg> {
            v0_1
        }
        pub fn closure58(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Ui::method119(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v5: string = string("r#\"History\"#");
            let v6: &str = r#"History"#;
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v12: Array<leptos::View> =
                Ui::method88(new_array(&[v3, leptos::IntoView::into_view(v8)]));
            leptos::Fragment::new(v12.to_vec())
        }
        pub fn method118(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure58(v0_1.clone(), ())
            })
        }
        pub fn method120(
            v0_1: leptos::HtmlElement<leptos::html::A>,
        ) -> leptos::HtmlElement<leptos::html::A> {
            v0_1
        }
        pub fn closure59(v0_1: leptos::ReadSignal<Ui::US17>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Ui::US17> = Ui::method71(v0_1);
            if let Ui::US17::US17_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method121(v0_1: leptos::ReadSignal<Ui::US17>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure59(v0_1.clone(), ())
            })
        }
        pub fn closure60(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Ui::method119(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v5: string = string("r#\"Settings\"#");
            let v6: &str = r#"Settings"#;
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v12: Array<leptos::View> =
                Ui::method88(new_array(&[v3, leptos::IntoView::into_view(v8)]));
            leptos::Fragment::new(v12.to_vec())
        }
        pub fn method122(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure60(v0_1.clone(), ())
            })
        }
        pub fn closure55(
            v0_1: leptos::ReadSignal<Ui::US17>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string = append(v1.clone(), string("#/history"));
            let v3: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z\"/></svg>");
            let v4: string = append(append(string("leptos::view! { "), v3), string(" }"));
            let v6: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="h-5 w-5"><path stroke-linecap="round" stroke-linejoin="round" d="M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z"/></svg> };
            let v7: string = Ui::method8(v2);
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v12 = Ui::method115(v0_1.clone());
            let v13 = Ui::method116(v12.clone());
            let v14 = Ui::method117(v12);
            let v16: string =
                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] pt-[8px] pr-[10px] pb-[11px] pl-[10px] text-sm font-medium \".to_owned() + v14()}");
            let v21: string = append(
                append(
                    string(" aria-current={move || if v13() { \"page\" } else { \"\" }}"),
                    append(
                        append(append(string(" "), v16), string(" href=v11")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v22 = Ui::method118(v6);
            let v25: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<a "), v21), string(">{v22()}</")),
                            string("a"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v28: leptos::HtmlElement<leptos::html::A> = Ui::method120(
                leptos::view! { <a  aria-current={move || if v13() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] pt-[8px] pr-[10px] pb-[11px] pl-[10px] text-sm font-medium ".to_owned() + v14()} href=v11>{v22()}</a> },
            );
            let v30: leptos::View = leptos::IntoView::into_view(v28);
            let v31: string = append(v1, string("#/settings"));
            let v32: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\"/><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M15 12a3 3 0 11-6 0 3 3 0 016 0z\"/></svg>");
            let v33: string = append(append(string("leptos::view! { "), v32), string(" }"));
            let v35: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="h-5 w-5"><path stroke-linecap="round" stroke-linejoin="round" d="M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z"/><path stroke-linecap="round" stroke-linejoin="round" d="M15 12a3 3 0 11-6 0 3 3 0 016 0z"/></svg> };
            let v36: string = Ui::method8(v31);
            let v38: &str = fable_library_rust::String_::LrcStr::as_str(&v36);
            let v40: std::string::String = String::from(v38);
            let v41 = Ui::method121(v0_1);
            let v42 = Ui::method116(v41.clone());
            let v43 = Ui::method117(v41);
            let v45: string =
                string("class={move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] pt-[8px] pr-[10px] pb-[11px] pl-[10px] text-sm font-medium \".to_owned() + v43()}");
            let v49: string = append(
                append(
                    string(" aria-current={move || if v42() { \"page\" } else { \"\" }}"),
                    append(
                        append(append(string(" "), v45), string(" href=v40")),
                        string(""),
                    ),
                ),
                string(""),
            );
            let v50 = Ui::method122(v35);
            let v52: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<a "), v49), string(">{v50()}</")),
                            string("a"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v55: leptos::HtmlElement<leptos::html::A> = Ui::method120(
                leptos::view! { <a  aria-current={move || if v42() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] pt-[8px] pr-[10px] pb-[11px] pl-[10px] text-sm font-medium ".to_owned() + v43()} href=v40>{v50()}</a> },
            );
            let v59: Array<leptos::View> =
                Ui::method88(new_array(&[v30, leptos::IntoView::into_view(v55)]));
            leptos::Fragment::new(v59.to_vec())
        }
        pub fn method114(
            v0_1: leptos::ReadSignal<Ui::US17>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure55(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method123(
            v0_1: leptos::HtmlElement<leptos::html::Nav>,
        ) -> leptos::HtmlElement<leptos::html::Nav> {
            v0_1
        }
        pub fn closure54(
            v0_1: leptos::ReadSignal<Ui::US17>,
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
            let v7 = Ui::method114(v0_1, v1);
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
            let v13: leptos::HtmlElement<leptos::html::Nav> = Ui::method123(
                leptos::view! { <nav  aria-label="Tabs" class="-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]">{v7()}</nav> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method113(
            v0_1: leptos::ReadSignal<Ui::US17>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure54(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure53(
            v0_1: leptos::ReadSignal<Ui::US17>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 border-t border-gray-200\"");
            let v5 = Ui::method113(v0_1, v1);
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
            let v11: leptos::HtmlElement<leptos::html::Div> = Ui::method89(
                leptos::view! { <div  class="flex flex-1 border-t border-gray-200">{v5()}</div> },
            );
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            leptos::Fragment::new(vec![v13])
        }
        pub fn method112(
            v0_1: leptos::ReadSignal<Ui::US17>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure53(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure45(v0_1: leptos::ReadSignal<Ui::US17>, unitVar: ()) -> leptos::Fragment {
            let v2: leptos_router::Location = leptos_router::use_location();
            let v3: leptos_router::Location = Ui::method56(v2.clone());
            let v5: leptos::Memo<std::string::String> = v3.pathname;
            let v8: std::string::String = Ui::method18(v5());
            let v10: string = fable_library_rust::String_::fromString(v8);
            let v11: leptos_router::Location = Ui::method57(v2);
            let v13: leptos::Memo<std::string::String> = v11.search;
            let v16: std::string::String = Ui::method18(v13());
            let v18: string = fable_library_rust::String_::fromString(v16);
            let v24: string = append(
                v10,
                (if v18.clone() == string("") {
                    string("")
                } else {
                    sprintf!("?{}", &v18)
                }),
            );
            let v27: string = string(" class=\"hidden\"");
            let v28 = Ui::method103(v0_1.clone());
            let v31: string = append(
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
            let v34: leptos::HtmlElement<leptos::html::Div> =
                Ui::method89(leptos::view! { <div  class="hidden">{v28()}</div> });
            let v36: leptos::View = leptos::IntoView::into_view(v34);
            let v38: string =
                string(" class=\"flex flex-1 [overflow-x:auto] [overflow-y:hidden]\"");
            let v39 = Ui::method112(v0_1, v24);
            let v41: string = append(
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
            let v44: leptos::HtmlElement<leptos::html::Div> = Ui::method89(
                leptos::view! { <div  class="flex flex-1 [overflow-x:auto] [overflow-y:hidden]">{v39()}</div> },
            );
            let v48: Array<leptos::View> =
                Ui::method88(new_array(&[v36, leptos::IntoView::into_view(v44)]));
            leptos::Fragment::new(v48.to_vec())
        }
        pub fn method102(v0_1: leptos::ReadSignal<Ui::US17>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure45(v0_1.clone(), ())
            })
        }
        pub fn closure44(v0_1: leptos::ReadSignal<Ui::US17>, unitVar: ()) -> leptos::Fragment {
            let v3: string = string(" class=\"flex flex-1 [align-items:flex-end]\"");
            let v4 = Ui::method102(v0_1);
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
            let v10: leptos::HtmlElement<leptos::html::Div> = Ui::method89(
                leptos::view! { <div  class="flex flex-1 [align-items:flex-end]">{v4()}</div> },
            );
            let v12: leptos::View = leptos::IntoView::into_view(v10);
            leptos::Fragment::new(vec![v12])
        }
        pub fn method101(v0_1: leptos::ReadSignal<Ui::US17>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure44(v0_1.clone(), ())
            })
        }
        pub fn closure29(v0_1: leptos::ReadSignal<Ui::US17>, unitVar: ()) -> leptos::Fragment {
            let v1 = Ui::method69(v0_1.clone());
            let v2 = Ui::method70();
            let v4 = {
                let clo = move || v2(v1());
                Func1::new({
                    let clo = clo.clone();
                    move |arg: ()| clo()
                })
            };
            let v6: leptos::View = leptos::IntoView::into_view(move || v4(()));
            let v9: string = string(" class=\"flex flex-1 min-w-max\"");
            let v10 = Ui::method101(v0_1);
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
            let v16: leptos::HtmlElement<leptos::html::Div> =
                Ui::method89(leptos::view! { <div  class="flex flex-1 min-w-max">{v10()}</div> });
            let v20: Array<leptos::View> =
                Ui::method88(new_array(&[v6, leptos::IntoView::into_view(v16)]));
            leptos::Fragment::new(v20.to_vec())
        }
        pub fn method68(v0_1: leptos::ReadSignal<Ui::US17>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure29(v0_1.clone(), ())
            })
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("content.render ()"));
            {
                let v3: leptos_router::Location = leptos_router::use_location();
                let v5: leptos_router::Location = leptos_router::use_location();
                let v6: leptos_router::Location = Ui::method56(v5.clone());
                let v8: leptos::Memo<std::string::String> = v6.pathname;
                let v11: std::string::String = Ui::method18(v8());
                let v13: string = fable_library_rust::String_::fromString(v11);
                let v14: leptos_router::Location = Ui::method57(v5);
                let v16: leptos::Memo<std::string::String> = v14.search;
                let v19: std::string::String = Ui::method18(v16());
                let v21: string = fable_library_rust::String_::fromString(v19);
                let v27: string = append(
                    v13,
                    (if v21.clone() == string("") {
                        string("")
                    } else {
                        sprintf!("?{}", &v21)
                    }),
                );
                let v29: LrcPtr<Ui::Heap1> =
                    leptos::use_context::<std::rc::Rc<Heap1>>().unwrap().into();
                let v30: Ui::US17 = Ui::method58();
                let patternInput: (leptos::ReadSignal<Ui::US17>, leptos::WriteSignal<Ui::US17>) =
                    leptos::create_signal(v30);
                let v34 = Ui::method59(v3.clone(), v27, v29);
                leptos::create_effect(move |_| v34());
                {
                    let v36 = Ui::method61(v3, patternInput.1.clone());
                    leptos::create_effect(move |_| v36());
                    {
                        let v40: string =
                            string(" class=\"bg-gray-50 flex flex-1 flex-col items-stretch min-h-screen text-gray-700 text-sm\"");
                        let v41 = Ui::method68(patternInput.0.clone());
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
                        let v47: leptos::HtmlElement<leptos::html::Div> = Ui::method89(
                            leptos::view! { <div  class="bg-gray-50 flex flex-1 flex-col items-stretch min-h-screen text-gray-700 text-sm">{v41()}</div> },
                        );
                        let v49: leptos::View = leptos::IntoView::into_view(v47);
                        leptos::Fragment::new(vec![v49])
                    }
                }
            }
        }
        pub fn method55() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure26((), ()))
        }
        pub fn closure5(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(1_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            {
                let v3: LrcPtr<Ui::Heap1> =
                    leptos::use_context::<std::rc::Rc<Heap1>>().unwrap().into();
                let v4 = Ui::method10();
                let v7: leptos::Resource<Ui::US1, rexie::Rexie> = leptos::create_local_resource(
                    move || v4(),
                    |x| async move { Func1::new(move |v: Ui::US1| Ui::closure7((), v))(x).await },
                );
                let v8 = Ui::method13(v7.clone());
                let v12 = Ui::method21(
                    v3.clone(),
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v_1: Option<rexie::Rexie>| Ui::closure9((), v_1))(x)
                                .await
                        },
                    ),
                );
                leptos::create_effect(move |_| v12());
                {
                    let v14 = Ui::method35(v7);
                    let v16: leptos::Action<LrcPtr<Ui::Heap2>, ()> =
                        leptos::create_action(move |value: &std::rc::Rc<Heap2>| {
                            v14((*value).clone().into())
                        });
                    let v17 = Ui::method39(v3.clone());
                    let v19: leptos::Memo<
                        std::collections::HashMap<string, leptos::RwSignal<bool>>,
                    > = leptos::create_memo(move |_| v17());
                    let v20: bool = Ui::method41();
                    let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                        leptos::create_signal(v20);
                    let v24 =
                        Ui::method42(v3, v16, v19, patternInput.1.clone(), patternInput.0.clone());
                    leptos::create_effect(move |_| v24());
                    {
                        let v29 = Ui::method53(
                            leptos::use_context::<std::rc::Rc<Heap1>>().unwrap().into(),
                        );
                        let v34: string =
                            string(" class:dark={move || v29()} class=\"flex flex-1\"");
                        let v35 = Ui::method55();
                        let v38: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v34), string(">{v35()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v41: leptos::HtmlElement<leptos::html::Div> = Ui::method89(
                            leptos::view! { <div  class:dark={move || v29()} class="flex flex-1">{v35()}</div> },
                        );
                        let v43: leptos::View = leptos::IntoView::into_view(v41);
                        leptos::Fragment::new(vec![v43])
                    }
                }
            }
        }
        pub fn method9() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure5((), ()))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: Array<leptos::View> = Ui::method88(new_empty::<leptos::View>());
            leptos::Fragment::new(v1.to_vec())
        }
        pub fn method124() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure61((), ()))
        }
        pub fn method125() -> string {
            string("/")
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(2_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            {
                let v3: LrcPtr<Ui::Heap1> =
                    leptos::use_context::<std::rc::Rc<Heap1>>().unwrap().into();
                let v4 = Ui::method10();
                let v7: leptos::Resource<Ui::US1, rexie::Rexie> = leptos::create_local_resource(
                    move || v4(),
                    |x| async move { Func1::new(move |v: Ui::US1| Ui::closure7((), v))(x).await },
                );
                let v8 = Ui::method13(v7.clone());
                let v12 = Ui::method21(
                    v3.clone(),
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v_1: Option<rexie::Rexie>| Ui::closure9((), v_1))(x)
                                .await
                        },
                    ),
                );
                leptos::create_effect(move |_| v12());
                {
                    let v14 = Ui::method35(v7);
                    let v16: leptos::Action<LrcPtr<Ui::Heap2>, ()> =
                        leptos::create_action(move |value: &std::rc::Rc<Heap2>| {
                            v14((*value).clone().into())
                        });
                    let v17 = Ui::method39(v3.clone());
                    let v19: leptos::Memo<
                        std::collections::HashMap<string, leptos::RwSignal<bool>>,
                    > = leptos::create_memo(move |_| v17());
                    let v20: bool = Ui::method41();
                    let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                        leptos::create_signal(v20);
                    let v24 =
                        Ui::method42(v3, v16, v19, patternInput.1.clone(), patternInput.0.clone());
                    leptos::create_effect(move |_| v24());
                    {
                        let v29 = Ui::method53(
                            leptos::use_context::<std::rc::Rc<Heap1>>().unwrap().into(),
                        );
                        let v34: string =
                            string(" class:dark={move || v29()} class=\"flex flex-1\"");
                        let v35 = Ui::method55();
                        let v38: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v34), string(">{v35()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v41: leptos::HtmlElement<leptos::html::Div> = Ui::method89(
                            leptos::view! { <div  class:dark={move || v29()} class="flex flex-1">{v35()}</div> },
                        );
                        let v43: leptos::View = leptos::IntoView::into_view(v41);
                        leptos::Fragment::new(vec![v43])
                    }
                }
            }
        }
        pub fn method126() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure62((), ()))
        }
        pub fn method127() -> string {
            string("/*")
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(3_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            {
                let v3: LrcPtr<Ui::Heap1> =
                    leptos::use_context::<std::rc::Rc<Heap1>>().unwrap().into();
                let v4 = Ui::method10();
                let v7: leptos::Resource<Ui::US1, rexie::Rexie> = leptos::create_local_resource(
                    move || v4(),
                    |x| async move { Func1::new(move |v: Ui::US1| Ui::closure7((), v))(x).await },
                );
                let v8 = Ui::method13(v7.clone());
                let v12 = Ui::method21(
                    v3.clone(),
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v_1: Option<rexie::Rexie>| Ui::closure9((), v_1))(x)
                                .await
                        },
                    ),
                );
                leptos::create_effect(move |_| v12());
                {
                    let v14 = Ui::method35(v7);
                    let v16: leptos::Action<LrcPtr<Ui::Heap2>, ()> =
                        leptos::create_action(move |value: &std::rc::Rc<Heap2>| {
                            v14((*value).clone().into())
                        });
                    let v17 = Ui::method39(v3.clone());
                    let v19: leptos::Memo<
                        std::collections::HashMap<string, leptos::RwSignal<bool>>,
                    > = leptos::create_memo(move |_| v17());
                    let v20: bool = Ui::method41();
                    let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                        leptos::create_signal(v20);
                    let v24 =
                        Ui::method42(v3, v16, v19, patternInput.1.clone(), patternInput.0.clone());
                    leptos::create_effect(move |_| v24());
                    {
                        let v29 = Ui::method53(
                            leptos::use_context::<std::rc::Rc<Heap1>>().unwrap().into(),
                        );
                        let v34: string =
                            string(" class:dark={move || v29()} class=\"flex flex-1\"");
                        let v35 = Ui::method55();
                        let v38: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v34), string(">{v35()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v41: leptos::HtmlElement<leptos::html::Div> = Ui::method89(
                            leptos::view! { <div  class:dark={move || v29()} class="flex flex-1">{v35()}</div> },
                        );
                        let v43: leptos::View = leptos::IntoView::into_view(v41);
                        leptos::Fragment::new(vec![v43])
                    }
                }
            }
        }
        pub fn method128() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure63((), ()))
        }
        pub fn method129() -> string {
            string("*")
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(4_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            {
                let v3: LrcPtr<Ui::Heap1> =
                    leptos::use_context::<std::rc::Rc<Heap1>>().unwrap().into();
                let v4 = Ui::method10();
                let v7: leptos::Resource<Ui::US1, rexie::Rexie> = leptos::create_local_resource(
                    move || v4(),
                    |x| async move { Func1::new(move |v: Ui::US1| Ui::closure7((), v))(x).await },
                );
                let v8 = Ui::method13(v7.clone());
                let v12 = Ui::method21(
                    v3.clone(),
                    leptos::create_local_resource(
                        move || v8(),
                        |x| async move {
                            Func1::new(move |v_1: Option<rexie::Rexie>| Ui::closure9((), v_1))(x)
                                .await
                        },
                    ),
                );
                leptos::create_effect(move |_| v12());
                {
                    let v14 = Ui::method35(v7);
                    let v16: leptos::Action<LrcPtr<Ui::Heap2>, ()> =
                        leptos::create_action(move |value: &std::rc::Rc<Heap2>| {
                            v14((*value).clone().into())
                        });
                    let v17 = Ui::method39(v3.clone());
                    let v19: leptos::Memo<
                        std::collections::HashMap<string, leptos::RwSignal<bool>>,
                    > = leptos::create_memo(move |_| v17());
                    let v20: bool = Ui::method41();
                    let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                        leptos::create_signal(v20);
                    let v24 =
                        Ui::method42(v3, v16, v19, patternInput.1.clone(), patternInput.0.clone());
                    leptos::create_effect(move |_| v24());
                    {
                        let v29 = Ui::method53(
                            leptos::use_context::<std::rc::Rc<Heap1>>().unwrap().into(),
                        );
                        let v34: string =
                            string(" class:dark={move || v29()} class=\"flex flex-1\"");
                        let v35 = Ui::method55();
                        let v38: string = append(
                            append(
                                string("leptos::view! { "),
                                append(
                                    append(
                                        append(append(string("<div "), v34), string(">{v35()}</")),
                                        string("div"),
                                    ),
                                    string(">"),
                                ),
                            ),
                            string(" }"),
                        );
                        let v41: leptos::HtmlElement<leptos::html::Div> = Ui::method89(
                            leptos::view! { <div  class:dark={move || v29()} class="flex flex-1">{v35()}</div> },
                        );
                        let v43: leptos::View = leptos::IntoView::into_view(v41);
                        leptos::Fragment::new(vec![v43])
                    }
                }
            }
        }
        pub fn method130() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure64((), ()))
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Ui::method8(Ui::method7());
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1);
            let v5: std::string::String = String::from(v3);
            let v6 = Ui::method9();
            let v7 = Ui::method124();
            let v15: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v6() path=v5 /> })");
            let v16: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v6() path=v5 /> },
            );
            let v18: string = Ui::method8(Ui::method125());
            let v20: &str = fable_library_rust::String_::LrcStr::as_str(&v18);
            let v22: std::string::String = String::from(v20);
            let v23 = Ui::method126();
            let v24 = Ui::method124();
            let v30: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v23() path=v22 /> })");
            let v31: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v23() path=v22 /> },
            );
            let v33: string = Ui::method8(Ui::method127());
            let v35: &str = fable_library_rust::String_::LrcStr::as_str(&v33);
            let v37: std::string::String = String::from(v35);
            let v38 = Ui::method128();
            let v39 = Ui::method124();
            let v45: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v38() path=v37 /> })");
            let v46: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v38() path=v37 /> },
            );
            let v48: string = Ui::method8(Ui::method129());
            let v50: &str = fable_library_rust::String_::LrcStr::as_str(&v48);
            let v52: std::string::String = String::from(v50);
            let v53 = Ui::method130();
            let v54 = Ui::method124();
            let v60: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v53() path=v52 /> })");
            let v63: Array<leptos::View> = Ui::method88(new_array(&[
                v16,
                v31,
                v46,
                leptos::IntoView::into_view(
                    leptos::view! { <leptos_router::Route  view=move || v53() path=v52 /> },
                ),
            ]));
            leptos::Fragment::new(v63.to_vec())
        }
        pub fn method6() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure4((), ()))
        }
        pub fn method131(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1 = Ui::method131(Ui::method6());
            let v7: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> })");
            let v8: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> },
            );
            leptos::Fragment::new(vec![v8])
        }
        pub fn method5() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure3((), ()))
        }
        pub fn method132(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
            leptos::logging::log!("{}", &string("app.render ()"));
            leptos_meta::provide_meta_context();
            {
                let v3: bool = Ui::method1();
                let v5: leptos::RwSignal<bool> = leptos::create_rw_signal(v3);
                let v6: string = Ui::method2();
                let v10: LrcPtr<Ui::Heap0> = Ui::method3(LrcPtr::new(Ui::Heap0 {
                    l0: v5,
                    l1: leptos::create_rw_signal(v6),
                }));
                let v12: leptos::RwSignal<LrcPtr<Ui::Heap0>> = leptos::create_rw_signal(v10);
                let v15: std::collections::HashMap<string, leptos::RwSignal<bool>> =
                    Ui::method4(std::collections::HashMap::new());
                let v18: LrcPtr<Ui::Heap1> = LrcPtr::new(Ui::Heap1 {
                    l0: leptos::create_rw_signal(v15),
                    l1: v12,
                });
                leptos::provide_context::<std::rc::Rc<Heap1>>(v18);
                {
                    let v21 = Ui::method132(Ui::method5());
                    let v27: string =
                        string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Router  children=Box::new(move || v21()) /> })");
                    leptos::IntoView::into_view(
                        leptos::view! { <leptos_router::Router  children=Box::new(move || v21()) /> },
                    )
                }
            }
        }
        pub fn method0() {
            leptos::mount_to_body(|| Func0::new(move || Ui::closure2((), ()))());
            ()
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) {
            Ui::method0();
        }
        pub fn method133() -> Func0<()> {
            Func0::new(move || Ui::closure65((), ()))
        }
        pub fn method134(v0_1: Box<dyn Fn()>) -> Box<dyn Fn()> {
            v0_1
        }
        pub fn closure0(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1: string = append(append(string("main / args: "), toString(v0_1)), string(""));
            leptos::logging::log!("{}", &v1);
            let _ = console_log::init_with_level(log::Level::Debug);
            console_error_panic_hook::set_once();
            {
                let v9: Ui::US0 = defaultValue(
                    Ui::US0::US0_0,
                    map(
                        Func1::new(move |v: web_sys::HtmlElement| Ui::closure1((), v)),
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
                if let Ui::US0::US0_1(v9_1_0) = &v9 {
                    Ui::method0()
                } else {
                    let v14 = Ui::method133();
                    let v17: Box<dyn Fn()> = Ui::method134(Box::new(move || v14()));
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
            v0.get_or_init(|| Func1::new(move |v: Array<string>| Ui::closure0((), v)))
        }
        pub fn main(args: Array<string>) -> i32 {
            (Ui::v0())(args)
        }
    }
}
pub use module_d5f62357::*;
#[path = "../../../lib/fsharp/CommonWasm.rs"]
mod module_8cb3e09e;
pub use module_8cb3e09e::*;
pub mod Polyglot {
    // pub use crate::module_8cb3e09e::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Ui::main(array_from(args));
}
