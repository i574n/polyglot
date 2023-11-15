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
            pub l0: leptos::RwSignal<std::collections::HashMap<string, leptos::RwSignal<bool>>>,
            pub l1: leptos::RwSignal<leptos::RwSignal<bool>>,
        }
        impl core::fmt::Display for Ui::Heap0 {
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US3 {
            US3_0,
            US3_1(bool),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
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
            US11_0,
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
            US12_0,
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
            US14_1(leptos::RwSignal<bool>),
        }
        impl core::fmt::Display for Ui::US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn closure1(unitVar: (), v0_1: web_sys::HtmlElement) -> Ui::US0 {
            Ui::US0::US0_1(v0_1)
        }
        pub fn method2(
            v0_1: leptos::RwSignal<leptos::RwSignal<bool>>,
        ) -> leptos::RwSignal<leptos::RwSignal<bool>> {
            v0_1
        }
        pub fn method3(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure3(v0_1: LrcPtr<Ui::Heap0>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method2(v0_1.l1.clone());
            let v5: leptos::RwSignal<bool> = Ui::method3(leptos::SignalGet::get(&v2));
            leptos::SignalGet::get(&v5)
        }
        pub fn method1(v0_1: LrcPtr<Ui::Heap0>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure3(v0_1.clone(), ())
            })
        }
        pub fn method5() -> string {
            string("View")
        }
        pub fn method6(v0_1: string) -> string {
            v0_1
        }
        pub fn closure8(unitVar: (), unitVar_1: ()) -> Ui::US1 {
            Ui::US1::US1_0
        }
        pub fn method10() -> Func0<Ui::US1> {
            Func0::new(move || Ui::closure8((), ()))
        }
        pub fn method11(v0_1: rexie::Rexie) -> Ui::US2 {
            Ui::US2::US2_1(v0_1)
        }
        pub fn method12(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure9(
            unitVar: (),
            v0_1: Ui::US1,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = rexie::Rexie>>> {
            let __future_init = Box::pin(async {
                //;
                leptos::logging::log!(
                    "{}",
                    &string("ui.dark_mode_toggle () / database create_local_resource")
                );
                leptos::logging::log!("{}", &string("ui.build_database ()"));
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
        pub fn closure10(
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
                move || Ui::closure10(v0_1.clone(), ())
            })
        }
        pub fn closure12(unitVar: (), v0_1: rexie::Rexie) -> Ui::US4 {
            Ui::US4::US4_1(v0_1)
        }
        pub fn method15(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure13(unitVar: (), v0_1: serde_json::Value) -> Ui::US5 {
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
        pub fn closure14(unitVar: (), v0_1: bool) -> Ui::US3 {
            Ui::US3::US3_1(v0_1)
        }
        pub fn method19(v0_1: Result<Ui::US3, rexie::Error>) -> Result<Ui::US3, rexie::Error> {
            v0_1
        }
        pub fn method20(v0_1: Ui::US3) -> Ui::US3 {
            v0_1
        }
        pub fn closure11(
            unitVar: (),
            v0_1: Option<rexie::Rexie>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Ui::US3>>> {
            let __future_init = Box::pin(async {
                //;
                {
                    let v3: string =
                    append(append(string("ui.dark_mode_toggle () / dark_mode create_local_resource / database: "),
                                  sprintf!("{:?}", &v0_1)), string(""));
                    leptos::logging::log!("{}", &v3);
                    {
                        let v7: Ui::US4 = defaultValue(
                            Ui::US4::US4_0,
                            map(
                                Func1::new(move |v: rexie::Rexie| Ui::closure12((), v)),
                                v0_1,
                            ),
                        );
                        let v94: Ui::US3 = Ui::method20(match &v7 {
                            Ui::US4::US4_1(v7_1_0) => {
                                leptos::logging::log!("{}", &string("ui.get_dark_mode ()"));
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
                                                Ui::closure13((), v_1)
                                            }
                                            let v32: Ui::US5 = defaultValue(
                                                Ui::US5::US5_0,
                                                map(
                                                    Func1::from(v30),
                                                    serde_wasm_bindgen::from_value(v27).unwrap(),
                                                ),
                                            );
                                            let v75: Ui::US6 = match &v32 {
                                                Ui::US5::US5_1(v32_1_0) => {
                                                    let v34: serde_json::Value =
                                                        Ui::method16(v32_1_0.clone());
                                                    let v36: Vec<u8> =
                                                        serde_json::from_value(v34).unwrap();
                                                    let v38: string = append(
                                                        append(
                                                            string("ui.get_dark_mode () / data: "),
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
                                                        let v43: string = append(
                                                            append(
                                                                string(
                                                                    "ui.get_dark_mode () / json: ",
                                                                ),
                                                                toString(v42.clone()),
                                                            ),
                                                            string(""),
                                                        );
                                                        leptos::logging::log!("{}", &v43);
                                                        {
                                                            let v45: std::string::String =
                                                                Ui::method18(v42);
                                                            let v48:
                                                                                 string =
                                                                             Ui::method6(fable_library_rust::String_::fromString(v45));
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
                                                                string("r#\"dark-mode\"#");
                                                            let v65: &str = r#"dark-mode"#;
                                                            Ui::US6::US6_1(defaultValue(
                                                                Ui::US3::US3_0,
                                                                map(
                                                                    Func1::new(move |v_2: bool| {
                                                                        Ui::closure14((), v_2)
                                                                    }),
                                                                    v62[v65].as_bool(),
                                                                ),
                                                            ))
                                                        }
                                                    }
                                                }
                                                _ => Ui::US6::US6_1(Ui::US3::US3_0),
                                            };
                                            let v82: Result<Ui::US3, rexie::Error> =
                                                Ui::method19(match &v75 {
                                                    Ui::US6::US6_1(v75_1_0) => Ok(v75_1_0.clone()),
                                                    Ui::US6::US6_0(v75_0_0) => Err(v75_0_0.clone()),
                                                });
                                            v82
                                        }
                                    });
                                    {
                                        // ;
                                        {
                                            let v86: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = Result<Ui::US3, rexie::Error>,
                                                    >,
                                                >,
                                            > = __future_init;
                                            let v88: Result<Ui::US3, rexie::Error> = v86.await;
                                            v88.unwrap()
                                        }
                                    }
                                }
                            }
                            _ => Ui::US3::US3_0,
                        });
                        v94
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
        pub fn closure16(unitVar: (), v0_1: Option<web_sys::Storage>) -> Ui::US7 {
            Ui::US7::US7_1(v0_1)
        }
        pub fn closure17(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Ui::US7 {
            Ui::US7::US7_0(v0_1)
        }
        pub fn closure18(unitVar: (), v0_1: web_sys::Storage) -> Ui::US9 {
            Ui::US9::US9_1(v0_1)
        }
        pub fn method25(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Ui::US3>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Ui::US3> {
            v0_1
        }
        pub fn closure19(unitVar: (), v0_1: Ui::US3) -> Ui::US10 {
            Ui::US10::US10_1(v0_1)
        }
        pub fn method26(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method27() -> string {
            string("dark-mode")
        }
        pub fn closure20(unitVar: (), v0_1: Option<std::string::String>) -> Ui::US11 {
            Ui::US11::US11_1(v0_1)
        }
        pub fn closure21(unitVar: (), v0_1: std::string::String) -> Ui::US13 {
            Ui::US13::US13_1(v0_1)
        }
        pub fn method28(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method29(
            v0_1: leptos::RwSignal<leptos::RwSignal<bool>>,
        ) -> leptos::RwSignal<leptos::RwSignal<bool>> {
            v0_1
        }
        pub fn method30(v0_1: bool) -> bool {
            v0_1
        }
        pub fn method31(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure15(
            v0_1: LrcPtr<Ui::Heap0>,
            v1: leptos::Resource<Option<rexie::Rexie>, Ui::US3>,
            unitVar: (),
        ) {
            leptos::logging::log!(
                "{}",
                &string("ui.dark_mode_toggle () / create_effect 1 / ##1")
            );
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Ui::method23(Ui::method22());
                let v8: Ui::US7 = match &v5 {
                    Err(v5_1_0) => Ui::closure17((), v5_1_0.clone()),
                    Ok(v5_0_0) => Ui::closure16((), v5_0_0.clone()),
                };
                let v17: Ui::US8 = match &v8 {
                    Ui::US7::US7_1(v8_1_0) => Ui::US8::US8_1(defaultValue(
                        Ui::US9::US9_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Ui::closure18((), v_2)),
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
                                Func1::new(move |v_3: Ui::US3| Ui::closure19((), v_3)),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v27: string =
                            append(append(string("ui.dark_mode_toggle () / dark_mode effect 0 / ##1.1 / dark_mode1: "),
                                          sprintf!("{:?}", &v25)),
                                   string(""));
                        leptos::logging::log!("{}", &v27);
                        {
                            let v141: Ui::US3 = if let Ui::US10::US10_1(v25_1_0) = &v25 {
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
                                    let v42: Ui::US11 = defaultValue(
                                        Ui::US11::US11_0,
                                        map(
                                            Func1::new(move |v_4: Option<std::string::String>| {
                                                Ui::closure20((), v_4)
                                            }),
                                            v37.ok(),
                                        ),
                                    );
                                    let v50: Ui::US12 = match &v42 {
                                        Ui::US11::US11_1(v42_1_0) => {
                                            Ui::US12::US12_1(defaultValue(
                                                Ui::US13::US13_0,
                                                map(
                                                    Func1::new(move |v_5: std::string::String| {
                                                        Ui::closure21((), v_5)
                                                    }),
                                                    v42_1_0.clone(),
                                                ),
                                            ))
                                        }
                                        _ => Ui::US12::US12_0,
                                    };
                                    let v57: Ui::US13 = if let Ui::US12::US12_1(v50_1_0) = &v50 {
                                        let v51: Ui::US13 = match &v50 {
                                            Ui::US12::US12_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Ui::US13::US13_1(v51_1_0) = &v51 {
                                            Ui::US13::US13_1(match &v51 {
                                                Ui::US13::US13_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Ui::US13::US13_0
                                        }
                                    } else {
                                        Ui::US13::US13_0
                                    };
                                    let v78: Ui::US10 = match &v57 {
                                        Ui::US13::US13_1(v57_1_0) => {
                                            let v60: std::string::String =
                                                Ui::method18(Ui::method28(v57_1_0.clone()));
                                            let v63: string = Ui::method6(
                                                fable_library_rust::String_::fromString(v60),
                                            );
                                            let v65: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v63);
                                            let v67: std::string::String = String::from(v65);
                                            let v69: Result<bool, serde_json::Error> =
                                                serde_json::from_str(&v67);
                                            Ui::US10::US10_1(defaultValue(
                                                Ui::US3::US3_0,
                                                map(
                                                    Func1::new(move |v_6: bool| {
                                                        Ui::closure14((), v_6)
                                                    }),
                                                    v69.ok(),
                                                ),
                                            ))
                                        }
                                        _ => Ui::US10::US10_0,
                                    };
                                    if let Ui::US10::US10_1(v78_1_0) = &v78 {
                                        let v79: Ui::US3 = match &v78 {
                                            Ui::US10::US10_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Ui::US3::US3_1(v79_1_0) = &v79 {
                                            Ui::US3::US3_1(match &v79 {
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
                                let v87: web_sys::Storage = Ui::method26(v19);
                                let v88: string = Ui::method27();
                                let v90: &str = fable_library_rust::String_::LrcStr::as_str(&v88);
                                let v92: Result<
                                    Option<std::string::String>,
                                    wasm_bindgen::JsValue,
                                > = web_sys::Storage::get_item(&v87, v90);
                                let v97: Ui::US11 = defaultValue(
                                    Ui::US11::US11_0,
                                    map(
                                        Func1::new(move |v_7: Option<std::string::String>| {
                                            Ui::closure20((), v_7)
                                        }),
                                        v92.ok(),
                                    ),
                                );
                                let v105: Ui::US12 = match &v97 {
                                    Ui::US11::US11_1(v97_1_0) => Ui::US12::US12_1(defaultValue(
                                        Ui::US13::US13_0,
                                        map(
                                            Func1::new(move |v_8: std::string::String| {
                                                Ui::closure21((), v_8)
                                            }),
                                            v97_1_0.clone(),
                                        ),
                                    )),
                                    _ => Ui::US12::US12_0,
                                };
                                let v112: Ui::US13 = if let Ui::US12::US12_1(v105_1_0) = &v105 {
                                    let v106: Ui::US13 = match &v105 {
                                        Ui::US12::US12_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Ui::US13::US13_1(v106_1_0) = &v106 {
                                        Ui::US13::US13_1(match &v106 {
                                            Ui::US13::US13_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    } else {
                                        Ui::US13::US13_0
                                    }
                                } else {
                                    Ui::US13::US13_0
                                };
                                let v133: Ui::US10 = match &v112 {
                                    Ui::US13::US13_1(v112_1_0) => {
                                        let v115: std::string::String =
                                            Ui::method18(Ui::method28(v112_1_0.clone()));
                                        let v118: string = Ui::method6(
                                            fable_library_rust::String_::fromString(v115),
                                        );
                                        let v120: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v118);
                                        let v122: std::string::String = String::from(v120);
                                        let v124: Result<bool, serde_json::Error> =
                                            serde_json::from_str(&v122);
                                        Ui::US10::US10_1(defaultValue(
                                            Ui::US3::US3_0,
                                            map(
                                                Func1::new(move |v_9: bool| Ui::closure14((), v_9)),
                                                v124.ok(),
                                            ),
                                        ))
                                    }
                                    _ => Ui::US10::US10_0,
                                };
                                if let Ui::US10::US10_1(v133_1_0) = &v133 {
                                    let v134: Ui::US3 = match &v133 {
                                        Ui::US10::US10_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Ui::US3::US3_1(v134_1_0) = &v134 {
                                        Ui::US3::US3_1(match &v134 {
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
                            let v143: string =
                                append(append(string("ui.dark_mode_toggle () / dark_mode effect 0 / ##1.1 / dark_mode2: "),
                                              sprintf!("{:?}", &v141)),
                                       string(""));
                            leptos::logging::log!("{}", &v143);
                            if let Ui::US3::US3_1(v141_1_0) = &v141 {
                                let v147: leptos::RwSignal<leptos::RwSignal<bool>> =
                                    Ui::method29(v0_1.l1.clone());
                                let v149: leptos::RwSignal<bool> =
                                    leptos::SignalGetUntracked::get_untracked(&v147);
                                let v150: bool = Ui::method30(match &v141 {
                                    Ui::US3::US3_1(x) => x.clone(),
                                    _ => unreachable!(),
                                });
                                let v151: leptos::RwSignal<bool> = Ui::method31(v149);
                                leptos::SignalSet::set(&v151, v150);
                                ()
                            }
                        }
                    }
                }
            }
        }
        pub fn method21(
            v0_1: LrcPtr<Ui::Heap0>,
            v1: leptos::Resource<Option<rexie::Rexie>, Ui::US3>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure15(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method33(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn method34(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn method35() {
            ();
        }
        pub fn closure22(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
            v1: bool,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v2: string = append(
                append(
                    string("ui.dark_mode_toggle () / set_dark_mode_action / value: "),
                    ofBoolean(v1),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v2);
            {
                let v4: leptos::Resource<Ui::US1, rexie::Rexie> = Ui::method14(v0_1);
                let v9: Ui::US4 = defaultValue(
                    Ui::US4::US4_0,
                    map(
                        Func1::new(move |v: rexie::Rexie| Ui::closure12((), v)),
                        leptos::SignalGet::get(&v4),
                    ),
                );
                let v13: rexie::Rexie = match &v9 {
                    Ui::US4::US4_1(v9_1_0) => v9_1_0.clone(),
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let __future_init = Box::pin(async move {
                    //;
                    {
                        let v15: string = append(
                            append(string("ui.set_dark_mode () / mode: "), ofBoolean(v1)),
                            string(""),
                        );
                        leptos::logging::log!("{}", &v15);
                        {
                            let v17: rexie::Rexie = Ui::method33(v13);
                            let __future_init = Box::pin(async {
                                //;
                                {
                                    let v20: rexie::Transaction = v17.transaction(
                                        &["store"],
                                        rexie::TransactionMode::ReadWrite,
                                    )?;
                                    let v22: rexie::Store = v20.store("store")?;
                                    let v24: string = string("r#\"dark-mode\"#");
                                    let v25: &str = r#"dark-mode"#;
                                    let v27: std::string::String =
                                        serde_json::json!({ v25: v1 }).to_string();
                                    let mut data = Vec::new();
                                    borsh::BorshSerialize::serialize(&v27, &mut data).unwrap();
                                    {
                                        let v31: Vec<u8> = data;
                                        let v33: wasm_bindgen::JsValue =
                                            serde_wasm_bindgen::to_value(&v31).unwrap();
                                        v22.put(&v33, Some(&"data".into())).await?;
                                        v20.done().await?;
                                        {
                                            let v37: Result<(), rexie::Error> =
                                                Ui::method34(Ok(()));
                                            v37
                                        }
                                    }
                                }
                            });
                            {
                                let v40: std::pin::Pin<
                                    Box<dyn std::future::Future<Output = Result<(), rexie::Error>>>,
                                > = __future_init;
                                let v42: Result<(), rexie::Error> = v40.await;
                                v42.unwrap();
                                Ui::method35();
                                ()
                            }
                        }
                    }
                });
                {
                    {
                        {
                            {
                                {
                                    {
                                        // ;
                                        __future_init
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn method32(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
        ) -> Func1<bool, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Ui::closure22(v0_1.clone(), v)
            })
        }
        pub fn method37(
            v0_1: leptos::RwSignal<std::collections::HashMap<string, leptos::RwSignal<bool>>>,
        ) -> leptos::RwSignal<std::collections::HashMap<string, leptos::RwSignal<bool>>> {
            v0_1
        }
        pub fn closure23(
            v0_1: LrcPtr<Ui::Heap0>,
            unitVar: (),
        ) -> std::collections::HashMap<string, leptos::RwSignal<bool>> {
            leptos::logging::log!(
                "{}",
                &string("ui.dark_mode_toggle () / loading create_memo")
            );
            {
                let v4: leptos::RwSignal<
                    std::collections::HashMap<string, leptos::RwSignal<bool>>,
                > = Ui::method37(v0_1.l0.clone());
                leptos::SignalGetUntracked::get_untracked(&v4)
            }
        }
        pub fn method36(
            v0_1: LrcPtr<Ui::Heap0>,
        ) -> Func0<std::collections::HashMap<string, leptos::RwSignal<bool>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure23(v0_1.clone(), ())
            })
        }
        pub fn method39(v0_1: leptos::ReadSignal<bool>) -> leptos::ReadSignal<bool> {
            v0_1
        }
        pub fn method40() -> string {
            string("dark-mode")
        }
        pub fn closure25(unitVar: (), v0_1: leptos::RwSignal<bool>) -> Ui::US14 {
            Ui::US14::US14_1(v0_1)
        }
        pub fn method41() -> bool {
            true
        }
        pub fn method42(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method43(v0_1: bool) -> bool {
            v0_1
        }
        pub fn method44(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn closure24(
            v0_1: LrcPtr<Ui::Heap0>,
            v1: leptos::Action<bool, ()>,
            v2: leptos::Memo<std::collections::HashMap<string, leptos::RwSignal<bool>>>,
            v3: leptos::WriteSignal<bool>,
            v4: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v5: leptos::ReadSignal<bool> = Ui::method39(v4);
            let v7: bool = leptos::SignalGet::get(&v5);
            let v8: string = append(
                append(
                    string("ui.dark_mode_toggle () / create_effect 2 / ##1 / loaded: "),
                    ofBoolean(v7),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v8);
            {
                let v11: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method29(v0_1.l1.clone());
                let v14: leptos::RwSignal<bool> =
                    Ui::method3(leptos::SignalGetUntracked::get_untracked(&v11));
                let v16: bool = leptos::SignalGet::get(&v14);
                let v17: string = append(
                    append(
                        string("ui.dark_mode_toggle () / create_effect 2 / ##2 / dark_mode: "),
                        ofBoolean(v16),
                    ),
                    string(""),
                );
                leptos::logging::log!("{}", &v17);
                {
                    let v20: std::collections::HashMap<string, leptos::RwSignal<bool>> = v2();
                    let v21: string = Ui::method40();
                    let v26: Ui::US14 = defaultValue(
                        Ui::US14::US14_0,
                        map(
                            Func1::new(move |v: leptos::RwSignal<bool>| Ui::closure25((), v)),
                            std::collections::HashMap::get(&v20, &v21).map(|x| *x),
                        ),
                    );
                    let v34: Ui::US3 = match &v26 {
                        Ui::US14::US14_1(v26_1_0) => {
                            let v28: leptos::RwSignal<bool> = Ui::method3(v26_1_0.clone());
                            Ui::US3::US3_1(leptos::SignalGet::get(&v28))
                        }
                        _ => Ui::US3::US3_0,
                    };
                    let v37: bool = match &v34 {
                        Ui::US3::US3_1(v34_1_0) => v34_1_0.clone(),
                        _ => false,
                    };
                    let v38: string =
                        append(append(string("ui.dark_mode_toggle () / create_effect 2 / ##3 / dark_mode_loading: "),
                                      ofBoolean(v37)), string(""));
                    leptos::logging::log!("{}", &v38);
                    if v37 == false {
                        if v7 == false {
                            let v42: bool = Ui::method41();
                            let v43: leptos::WriteSignal<bool> = Ui::method42(v3);
                            leptos::SignalSet::set(&v43, v42);
                            ()
                        } else {
                            let v45: string =
                                append(append(string("ui.dark_mode_toggle () / create_effect 2 / ##4 / dark_mode: "),
                                              ofBoolean(v16)), string(""));
                            leptos::logging::log!("{}", &v45);
                            {
                                let v48: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                                    Ui::method23(Ui::method22());
                                let v51: Ui::US7 = match &v48 {
                                    Err(v48_1_0) => Ui::closure17((), v48_1_0.clone()),
                                    Ok(v48_0_0) => Ui::closure16((), v48_0_0.clone()),
                                };
                                let v60: Ui::US8 = match &v51 {
                                    Ui::US7::US7_1(v51_1_0) => Ui::US8::US8_1(defaultValue(
                                        Ui::US9::US9_0,
                                        map(
                                            Func1::new(move |v_3: web_sys::Storage| {
                                                Ui::closure18((), v_3)
                                            }),
                                            v51_1_0.clone(),
                                        ),
                                    )),
                                    Ui::US7::US7_0(v51_0_0) => Ui::US8::US8_0(v51_0_0.clone()),
                                };
                                if let Ui::US8::US8_1(v60_1_0) = &v60 {
                                    let v61: Ui::US9 = match &v60 {
                                        Ui::US8::US8_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Ui::US9::US9_1(v61_1_0) = &v61 {
                                        let v63: bool = Ui::method43(v16);
                                        leptos::Action::dispatch(&v1, v63);
                                        {
                                            let v65: web_sys::Storage = Ui::method44(match &v61 {
                                                Ui::US9::US9_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            });
                                            let v66: string = Ui::method27();
                                            let v68: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v66);
                                            let v71: std::string::String =
                                                Ui::method18(format!("{}", &v16));
                                            let v74: string = Ui::method6(
                                                fable_library_rust::String_::fromString(v71),
                                            );
                                            let v76: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v74);
                                            web_sys::Storage::set(&v65, v68, v76).unwrap();
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
        pub fn method38(
            v0_1: LrcPtr<Ui::Heap0>,
            v1: leptos::Action<bool, ()>,
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
                    Ui::closure24(
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
        pub fn closure27(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method46() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Ui::closure27((), v))
        }
        pub fn method47(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure26(v0_1: LrcPtr<Ui::Heap0>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method2(v0_1.l1.clone());
            let v5: leptos::RwSignal<bool> = leptos::SignalGet::get(&v3);
            let v6 = Ui::method46();
            let v7: leptos::RwSignal<bool> = Ui::method47(v5);
            leptos::SignalUpdate::update(&v7, |x| *x = v6(*x));
            ()
        }
        pub fn method45(v0_1: LrcPtr<Ui::Heap0>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Ui::closure26(v0_1.clone(), v)
            })
        }
        pub fn closure28(v0_1: LrcPtr<Ui::Heap0>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method2(v0_1.l1.clone());
            let v5: leptos::RwSignal<bool> = Ui::method3(leptos::SignalGet::get(&v2));
            leptos::SignalGet::get(&v5)
        }
        pub fn method48(v0_1: LrcPtr<Ui::Heap0>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure28(v0_1.clone(), ())
            })
        }
        pub fn method49(
            v0_1: leptos::HtmlElement<leptos::html::Label>,
        ) -> leptos::HtmlElement<leptos::html::Label> {
            v0_1
        }
        pub fn method50(v0_1: leptos::View) -> leptos::View {
            v0_1
        }
        pub fn method51(v0_1: leptos::View) -> leptos::View {
            v0_1
        }
        pub fn closure30(v0_1: leptos::View, unitVar: ()) -> leptos::View {
            v0_1
        }
        pub fn method53(v0_1: leptos::View) -> Func0<leptos::View> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure30(v0_1.clone(), ())
            })
        }
        pub fn method54(
            v0_1: leptos::HtmlElement<leptos::html::Dt>,
        ) -> leptos::HtmlElement<leptos::html::Dt> {
            v0_1
        }
        pub fn closure31(v0_1: leptos::View, unitVar: ()) -> leptos::View {
            v0_1
        }
        pub fn method55(v0_1: leptos::View) -> Func0<leptos::View> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure31(v0_1.clone(), ())
            })
        }
        pub fn method56(
            v0_1: leptos::HtmlElement<leptos::html::Dd>,
        ) -> leptos::HtmlElement<leptos::html::Dd> {
            v0_1
        }
        pub fn closure29(v0_1: leptos::View, v1: leptos::View, unitVar: ()) -> leptos::View {
            let v4: string = string(" class=\"font-medium text-gray-700\"");
            let v5 = Ui::method53(v0_1);
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
                Ui::method54(leptos::view! { <dt  class="font-medium text-gray-700">{v5()}</dt> });
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            let v15: string =
                string(" class=\"text-gray-700 md:col-span-2 flex flex-1 [overflow:auto]\"");
            let v16 = Ui::method55(v1);
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
            let v22: leptos::HtmlElement<leptos::html::Dd> = Ui::method56(
                leptos::view! { <dd  class="text-gray-700 md:col-span-2 flex flex-1 [overflow:auto]">{v16()}</dd> },
            );
            let v25: Array<leptos::View> = new_array(&[v13, leptos::IntoView::into_view(v22)]);
            let v27: leptos::Fragment = leptos::Fragment::new(v25.to_vec());
            leptos::IntoView::into_view(v27)
        }
        pub fn method52(v0_1: leptos::View, v1: leptos::View) -> Func0<leptos::View> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure29(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method57(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn closure7(unitVar: (), unitVar_1: ()) -> leptos::View {
            let v2: string = string("r#\"Dark Mode\"#");
            let v3: &str = r#"Dark Mode"#;
            let v5: leptos::leptos_dom::Text = leptos::html::text(v3);
            let v7: leptos::View = leptos::IntoView::into_view(v5);
            leptos::logging::log!("{}", &string("ui.dark_mode_toggle ()"));
            {
                let v11: LrcPtr<Ui::Heap0> =
                    leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into();
                let v12 = Ui::method10();
                let v15: leptos::Resource<Ui::US1, rexie::Rexie> = leptos::create_local_resource(
                    move || v12(),
                    |x| async move { Func1::new(move |v: Ui::US1| Ui::closure9((), v))(x).await },
                );
                let v16 = Ui::method13(v15.clone());
                let v20 = Ui::method21(
                    v11.clone(),
                    leptos::create_local_resource(
                        move || v16(),
                        |x| async move {
                            Func1::new(move |v_1: Option<rexie::Rexie>| Ui::closure11((), v_1))(x)
                                .await
                        },
                    ),
                );
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Ui::method32(v15);
                    let v24: leptos::Action<bool, ()> =
                        leptos::create_action(move |value: &bool| v22(*value));
                    let v25 = Ui::method36(v11.clone());
                    let v27: leptos::Memo<
                        std::collections::HashMap<string, leptos::RwSignal<bool>>,
                    > = leptos::create_memo(move |_| v25());
                    let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                        leptos::create_signal(false);
                    let v31 = Ui::method38(
                        v11.clone(),
                        v24,
                        v27,
                        patternInput.1.clone(),
                        patternInput.0.clone(),
                    );
                    leptos::create_effect(move |_| v31());
                    {
                        let v34: string = string("r#\"dark-mode\"#");
                        let v35: &str = r#"dark-mode"#;
                        let v36 = Ui::method45(v11.clone());
                        let v37 = Ui::method48(v11);
                        let v38: string =
                            string("<label for={v35} class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\"><input type=\"checkbox\" id={v35} class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\" on:change=move |event| v36(event) prop:checked={move || v37()} /><span class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-green-600\"><svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg><svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg></span><span class=\"absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-green-500\"></span></label>");
                        let v39: string =
                            append(append(string("leptos::view! { "), v38), string(" }"));
                        let v42: leptos::HtmlElement<leptos::html::Label> = Ui::method49(
                            leptos::view! { <label for={v35} class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"><input type="checkbox" id={v35} class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" on:change=move |event| v36(event) prop:checked={move || v37()} /><span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-green-600"><svg data-unchecked-icon xmlns="http://www.w3.org/2000/svg" class="h-4 w-4" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" clip-rule="evenodd" /></svg><svg data-checked-icon xmlns="http://www.w3.org/2000/svg" class="hidden h-4 w-4" viewBox="0 0 20 20" fill="currentColor"> <path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" /></svg></span><span class="absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-green-500"></span></label> },
                        );
                        let v44: leptos::View = leptos::IntoView::into_view(v42);
                        let v49: string =
                            string(" class=\"grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-center\"");
                        let v50 = Ui::method52(Ui::method50(v7), Ui::method51(v44));
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
                        let v56: leptos::HtmlElement<leptos::html::Div> = Ui::method57(
                            leptos::view! { <div  class="grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-center">{v50()}</div> },
                        );
                        leptos::IntoView::into_view(v56)
                    }
                }
            }
        }
        pub fn method9() -> Func0<leptos::View> {
            Func0::new(move || Ui::closure7((), ()))
        }
        pub fn method58(
            v0_1: leptos::HtmlElement<leptos::html::Dl>,
        ) -> leptos::HtmlElement<leptos::html::Dl> {
            v0_1
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> leptos::View {
            let v2: string = string(" class=\"flex flex-1 divide-y divide-gray-100 text-sm\"");
            let v3 = Ui::method9();
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
            let v9: leptos::HtmlElement<leptos::html::Dl> = Ui::method58(
                leptos::view! { <dl  class="flex flex-1 divide-y divide-gray-100 text-sm">{v3()}</dl> },
            );
            leptos::IntoView::into_view(v9)
        }
        pub fn method8() -> Func0<leptos::View> {
            Func0::new(move || Ui::closure6((), ()))
        }
        pub fn closure5(unitVar: (), unitVar_1: ()) -> leptos::HtmlElement<leptos::html::Div> {
            let v2: string = string(" class=\"flow-root\"");
            let v3 = Ui::method8();
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
        pub fn method7() -> Func0<leptos::HtmlElement<leptos::html::Div>> {
            Func0::new(move || Ui::closure5((), ()))
        }
        pub fn method59() -> string {
            string("Connection")
        }
        pub fn method63() -> string {
            string("explorer-backend-mainnet-prod-24ktefolwq-uc.a.run.app")
        }
        pub fn method64(
            v0_1: leptos::ReadSignal<std::string::String>,
        ) -> leptos::ReadSignal<std::string::String> {
            v0_1
        }
        pub fn method65(
            v0_1: leptos::WriteSignal<std::string::String>,
        ) -> leptos::WriteSignal<std::string::String> {
            v0_1
        }
        pub fn method66(
            v0_1: leptos::HtmlElement<leptos::html::Input>,
        ) -> leptos::HtmlElement<leptos::html::Input> {
            v0_1
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> leptos::View {
            let v2: string = string("r#\"Explorer Backend Host\"#");
            let v3: &str = r#"Explorer Backend Host"#;
            let v5: leptos::leptos_dom::Text = leptos::html::text(v3);
            let v7: leptos::View = leptos::IntoView::into_view(v5);
            let v8: string = Ui::method63();
            let v10: &str = fable_library_rust::String_::LrcStr::as_str(&v8);
            let v12: std::string::String = String::from(v10);
            let patternInput: (
                leptos::ReadSignal<std::string::String>,
                leptos::WriteSignal<std::string::String>,
            ) = leptos::create_signal(v12);
            let v16: leptos::ReadSignal<std::string::String> = Ui::method64(patternInput.0.clone());
            let v17: leptos::WriteSignal<std::string::String> =
                Ui::method65(patternInput.1.clone());
            let v27: string =
                string("leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v17(leptos::event_target_value(&event)) prop:value=v16 class=\"bg-gray-50 flex-1 h-[27px]\" /> }");
            let v30: leptos::HtmlElement<leptos::html::Input> = Ui::method66(
                leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v17(leptos::event_target_value(&event)) prop:value=v16 class="bg-gray-50 flex-1 h-[27px]" /> },
            );
            let v32: leptos::View = leptos::IntoView::into_view(v30);
            let v36: string =
                string(" class=\"grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-baseline\"");
            let v37 = Ui::method52(Ui::method50(v7), Ui::method51(v32));
            let v40: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v36), string(">{v37()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v43: leptos::HtmlElement<leptos::html::Div> = Ui::method57(
                leptos::view! { <div  class="grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-baseline">{v37()}</div> },
            );
            leptos::IntoView::into_view(v43)
        }
        pub fn method62() -> Func0<leptos::View> {
            Func0::new(move || Ui::closure34((), ()))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> leptos::View {
            let v2: string = string(" class=\"flex flex-1 divide-y divide-gray-100 text-sm\"");
            let v3 = Ui::method62();
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
            let v9: leptos::HtmlElement<leptos::html::Dl> = Ui::method58(
                leptos::view! { <dl  class="flex flex-1 divide-y divide-gray-100 text-sm">{v3()}</dl> },
            );
            leptos::IntoView::into_view(v9)
        }
        pub fn method61() -> Func0<leptos::View> {
            Func0::new(move || Ui::closure33((), ()))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> leptos::HtmlElement<leptos::html::Div> {
            let v2: string = string(" class=\"flow-root\"");
            let v3 = Ui::method61();
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
        pub fn method60() -> Func0<leptos::HtmlElement<leptos::html::Div>> {
            Func0::new(move || Ui::closure32((), ()))
        }
        pub fn method68(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
        ) -> leptos::HtmlElement<leptos::html::Details> {
            v0_1
        }
        pub fn closure35(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
            v1: leptos::HtmlElement<leptos::html::Details>,
            unitVar: (),
        ) -> leptos::View {
            let v2: leptos::HtmlElement<leptos::html::Details> = Ui::method68(v0_1);
            let v4: leptos::View = leptos::IntoView::into_view(v2);
            let v5: leptos::HtmlElement<leptos::html::Details> = Ui::method68(v1);
            let v8: Array<leptos::View> = new_array(&[v4, leptos::IntoView::into_view(v5)]);
            let v10: leptos::Fragment = leptos::Fragment::new(v8.to_vec());
            leptos::IntoView::into_view(v10)
        }
        pub fn method67(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
            v1: leptos::HtmlElement<leptos::html::Details>,
        ) -> Func0<leptos::View> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure35(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method69(v0_1: Func0<leptos::View>) -> Func0<leptos::View> {
            v0_1
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> leptos::View {
            let v1: string = Ui::method6(Ui::method5());
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1);
            let v5: std::string::String = String::from(v3);
            let v6 = Ui::method7();
            let v7: string =
                string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v5}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\"><svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg></span></summary>{v6()}</details>");
            let v8: string = append(append(string("leptos::view! { "), v7), string(" }"));
            let v10: leptos::HtmlElement<leptos::html::Details> = leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v5}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180"><svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg></span></summary>{v6()}</details> };
            let v12: string = Ui::method6(Ui::method59());
            let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
            let v16: std::string::String = String::from(v14);
            let v17 = Ui::method60();
            let v18: string =
                string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v16}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\"><svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg></span></summary>{v17()}</details>");
            let v19: string = append(append(string("leptos::view! { "), v18), string(" }"));
            let v21: leptos::HtmlElement<leptos::html::Details> = leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v16}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180"><svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg></span></summary>{v17()}</details> };
            let v23: string = Ui::method6(toString(14_i32));
            let v25: &str = fable_library_rust::String_::LrcStr::as_str(&v23);
            let v31: string =
                string(" style=\"font-size: \".to_owned() + v25 + \"px;\" class=\"bg-gray-50 flex flex-1 flex-col items-stretch min-h-screen text-gray-700 text-sm\"");
            let v32 = Ui::method69(Ui::method67(v10, v21));
            let v35: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v31), string(">{v32()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v38: leptos::HtmlElement<leptos::html::Div> = Ui::method57(
                leptos::view! { <div  style="font-size: ".to_owned() + v25 + "px;" class="bg-gray-50 flex flex-1 flex-col items-stretch min-h-screen text-gray-700 text-sm">{v32()}</div> },
            );
            leptos::IntoView::into_view(v38)
        }
        pub fn method4() -> Func0<leptos::View> {
            Func0::new(move || Ui::closure4((), ()))
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
            leptos::logging::log!("{}", &string("ui.app ()"));
            leptos_meta::provide_meta_context();
            {
                let v4: leptos::RwSignal<bool> = leptos::create_rw_signal(true);
                let v6: leptos::RwSignal<leptos::RwSignal<bool>> = leptos::create_rw_signal(v4);
                let v8: std::collections::HashMap<string, leptos::RwSignal<bool>> =
                    std::collections::HashMap::new();
                let v11: LrcPtr<Ui::Heap0> = LrcPtr::new(Ui::Heap0 {
                    l0: leptos::create_rw_signal(v8),
                    l1: v6,
                });
                leptos::provide_context::<std::rc::Rc<Heap0>>(v11);
                leptos::logging::log!("{}", &string("ui.home ()"));
                {
                    let v18 =
                        Ui::method1(leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into());
                    let v23: string = string(" class:dark={move || v18()} class=\"flex flex-1\"");
                    let v24 = Ui::method4();
                    let v27: string = append(
                        append(
                            string("leptos::view! { "),
                            append(
                                append(
                                    append(append(string("<div "), v23), string(">{v24()}</")),
                                    string("div"),
                                ),
                                string(">"),
                            ),
                        ),
                        string(" }"),
                    );
                    leptos::view! { <div  class:dark={move || v18()} class="flex flex-1">{v24()}</div> }
                }
            }
        }
        pub fn method0() {
            leptos::mount_to_body(|| Func0::new(move || Ui::closure2((), ()))());
            ()
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) {
            Ui::method0();
        }
        pub fn method70() -> Func0<()> {
            Func0::new(move || Ui::closure36((), ()))
        }
        pub fn method71(v0_1: Box<dyn Fn()>) -> Box<dyn Fn()> {
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
                    let v14 = Ui::method70();
                    let v17: Box<dyn Fn()> = Ui::method71(Box::new(move || v14()));
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
