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
        pub fn method1(v0_1: string) -> string {
            v0_1
        }
        pub fn method2() -> string {
            string("explorer-backend-mainnet-prod-24ktefolwq-uc.a.run.app")
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) -> Ui::US1 {
            Ui::US1::US1_0
        }
        pub fn method3() -> Func0<Ui::US1> {
            Func0::new(move || Ui::closure3((), ()))
        }
        pub fn method4(v0_1: rexie::Rexie) -> Ui::US2 {
            Ui::US2::US2_1(v0_1)
        }
        pub fn method5(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure4(
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
                        let v13: Ui::US2 = Ui::method4(v10.unwrap());
                        v13
                    }
                });
                {
                    let v16: std::pin::Pin<Box<dyn std::future::Future<Output = Ui::US2>>> =
                        __future_init;
                    let v18: Ui::US2 = v16.await;
                    let v25: rexie::Rexie = Ui::method5(match &v18 {
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
        pub fn method7(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
        ) -> leptos::Resource<Ui::US1, rexie::Rexie> {
            v0_1
        }
        pub fn closure5(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Ui::US1, rexie::Rexie> = Ui::method7(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method6(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure5(v0_1.clone(), ())
            })
        }
        pub fn closure7(unitVar: (), v0_1: rexie::Rexie) -> Ui::US4 {
            Ui::US4::US4_1(v0_1)
        }
        pub fn method8(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure8(unitVar: (), v0_1: serde_json::Value) -> Ui::US5 {
            Ui::US5::US5_1(v0_1)
        }
        pub fn method9(v0_1: serde_json::Value) -> serde_json::Value {
            v0_1
        }
        pub fn method10(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method11(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure9(unitVar: (), v0_1: bool) -> Ui::US3 {
            Ui::US3::US3_1(v0_1)
        }
        pub fn method12(v0_1: Result<Ui::US3, rexie::Error>) -> Result<Ui::US3, rexie::Error> {
            v0_1
        }
        pub fn method13(v0_1: Ui::US3) -> Ui::US3 {
            v0_1
        }
        pub fn closure6(
            unitVar: (),
            v0_1: Option<rexie::Rexie>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Ui::US3>>> {
            let __future_init = Box::pin(async {
                //;
                {
                    let v4: string =
                    append(append(string("ui.dark_mode_toggle () / dark_mode create_local_resource / database: "),
                                  toString(format!("{:?}", &v0_1))),
                           string(""));
                    leptos::logging::log!("{}", &v4);
                    {
                        let v8: Ui::US4 = defaultValue(
                            Ui::US4::US4_0,
                            map(Func1::new(move |v: rexie::Rexie| Ui::closure7((), v)), v0_1),
                        );
                        let v96: Ui::US3 = Ui::method13(match &v8 {
                            Ui::US4::US4_1(v8_1_0) => {
                                leptos::logging::log!("{}", &string("ui.get_dark_mode ()"));
                                {
                                    let v12: rexie::Rexie = Ui::method8(v8_1_0.clone());
                                    let __future_init = Box::pin(async {
                                        //;
                                        {
                                            let v15: rexie::Transaction = v12.transaction(
                                                &["store"],
                                                rexie::TransactionMode::ReadOnly,
                                            )?;
                                            let v17: rexie::Store = v15.store("store")?;
                                            let v19: string = string("r#\"data\"#");
                                            let v20: &str = r#"data"#;
                                            let v22: &wasm_bindgen::JsValue = &v20.into();
                                            let v24: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = Result<
                                                            wasm_bindgen::JsValue,
                                                            rexie::Error,
                                                        >,
                                                    >,
                                                >,
                                            > = Box::pin(rexie::Store::get(&v17, v22));
                                            let v26: Result<wasm_bindgen::JsValue, rexie::Error> =
                                                v24.await;
                                            let v28: wasm_bindgen::JsValue = v26?;
                                            fn v31(v_1: serde_json::Value) -> Ui::US5 {
                                                Ui::closure8((), v_1)
                                            }
                                            let v33: Ui::US5 = defaultValue(
                                                Ui::US5::US5_0,
                                                map(
                                                    Func1::from(v31),
                                                    serde_wasm_bindgen::from_value(v28).unwrap(),
                                                ),
                                            );
                                            let v77: Ui::US6 = match &v33 {
                                                Ui::US5::US5_1(v33_1_0) => {
                                                    let v35: serde_json::Value =
                                                        Ui::method9(v33_1_0.clone());
                                                    let v37: Vec<u8> =
                                                        serde_json::from_value(v35).unwrap();
                                                    let v40: string = append(
                                                        append(
                                                            string("ui.get_dark_mode () / data: "),
                                                            toString(format!("{:?}", &v37)),
                                                        ),
                                                        string(""),
                                                    );
                                                    leptos::logging::log!("{}", &v40);
                                                    {
                                                        let v42: Vec<u8> = Ui::method10(v37);
                                                        let v44: std::string::String =
                                                            borsh::BorshDeserialize::deserialize(
                                                                &mut v42.as_slice(),
                                                            )
                                                            .unwrap();
                                                        let v45: string = append(
                                                            append(
                                                                string(
                                                                    "ui.get_dark_mode () / json: ",
                                                                ),
                                                                toString(v44.clone()),
                                                            ),
                                                            string(""),
                                                        );
                                                        leptos::logging::log!("{}", &v45);
                                                        {
                                                            let v47: std::string::String =
                                                                Ui::method11(v44);
                                                            let v50:
                                                                                 string =
                                                                             Ui::method1(fable_library_rust::String_::fromString(v47));
                                                            let v52:
                                                                                 &str =
                                                                             fable_library_rust::String_::LrcStr::as_str(&v50);
                                                            let v54: std::string::String =
                                                                String::from(v52);
                                                            let v56: Result<
                                                                serde_json::Value,
                                                                serde_json::Error,
                                                            > = serde_json::from_str(&v54);
                                                            let v60: Ui::US5 = defaultValue(
                                                                Ui::US5::US5_0,
                                                                map(Func1::from(v31), v56.ok()),
                                                            );
                                                            let v64:
                                                                                 serde_json::Value =
                                                                             match &v60
                                                                                 {
                                                                                 Ui::US5::US5_1(v60_1_0)
                                                                                 =>
                                                                                 v60_1_0.clone(),
                                                                                 _
                                                                                 =>
                                                                                 panic!("{}",
                                                                                        string("Option does not have a value."),),
                                                                             };
                                                            let v66: string =
                                                                string("r#\"dark-mode\"#");
                                                            let v67: &str = r#"dark-mode"#;
                                                            Ui::US6::US6_1(defaultValue(
                                                                Ui::US3::US3_0,
                                                                map(
                                                                    Func1::new(move |v_2: bool| {
                                                                        Ui::closure9((), v_2)
                                                                    }),
                                                                    v64[v67].as_bool(),
                                                                ),
                                                            ))
                                                        }
                                                    }
                                                }
                                                _ => Ui::US6::US6_1(Ui::US3::US3_0),
                                            };
                                            let v84: Result<Ui::US3, rexie::Error> =
                                                Ui::method12(match &v77 {
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
        pub fn method15() -> web_sys::Window {
            leptos::leptos_dom::window()
        }
        pub fn method17(v0_1: web_sys::Window) -> web_sys::Window {
            v0_1
        }
        pub fn method16(
            v0_1: web_sys::Window,
        ) -> Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> {
            let v1: web_sys::Window = Ui::method17(v0_1);
            v1.local_storage()
        }
        pub fn closure11(unitVar: (), v0_1: Option<web_sys::Storage>) -> Ui::US7 {
            Ui::US7::US7_1(v0_1)
        }
        pub fn closure12(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Ui::US7 {
            Ui::US7::US7_0(v0_1)
        }
        pub fn closure13(unitVar: (), v0_1: web_sys::Storage) -> Ui::US9 {
            Ui::US9::US9_1(v0_1)
        }
        pub fn method18(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Ui::US3>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Ui::US3> {
            v0_1
        }
        pub fn closure14(unitVar: (), v0_1: Ui::US3) -> Ui::US10 {
            Ui::US10::US10_1(v0_1)
        }
        pub fn method19(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method20() -> string {
            string("dark-mode")
        }
        pub fn closure15(unitVar: (), v0_1: Option<std::string::String>) -> Ui::US11 {
            Ui::US11::US11_1(v0_1)
        }
        pub fn closure16(unitVar: (), v0_1: std::string::String) -> Ui::US13 {
            Ui::US13::US13_1(v0_1)
        }
        pub fn method21(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method22(
            v0_1: leptos::RwSignal<leptos::RwSignal<bool>>,
        ) -> leptos::RwSignal<leptos::RwSignal<bool>> {
            v0_1
        }
        pub fn method23(v0_1: bool) -> bool {
            v0_1
        }
        pub fn method24(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure10(
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
                    Ui::method16(Ui::method15());
                let v8: Ui::US7 = match &v5 {
                    Err(v5_1_0) => Ui::closure12((), v5_1_0.clone()),
                    Ok(v5_0_0) => Ui::closure11((), v5_0_0.clone()),
                };
                let v17: Ui::US8 = match &v8 {
                    Ui::US7::US7_1(v8_1_0) => Ui::US8::US8_1(defaultValue(
                        Ui::US9::US9_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Ui::closure13((), v_2)),
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
                        let v20: leptos::Resource<Option<rexie::Rexie>, Ui::US3> = Ui::method18(v1);
                        let v25: Ui::US10 = defaultValue(
                            Ui::US10::US10_0,
                            map(
                                Func1::new(move |v_3: Ui::US3| Ui::closure14((), v_3)),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v28: string =
                            append(append(string("ui.dark_mode_toggle () / dark_mode effect 0 / ##1.1 / dark_mode1: "),
                                          toString(format!("{:?}", &v25))),
                                   string(""));
                        leptos::logging::log!("{}", &v28);
                        {
                            let v142: Ui::US3 = if let Ui::US10::US10_1(v25_1_0) = &v25 {
                                let v30: Ui::US3 = match &v25 {
                                    Ui::US10::US10_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Ui::US3::US3_1(v30_1_0) = &v30 {
                                    Ui::US3::US3_1(match &v30 {
                                        Ui::US3::US3_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    let v33: web_sys::Storage = Ui::method19(v19.clone());
                                    let v34: string = Ui::method20();
                                    let v36: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v34);
                                    let v38: Result<
                                        Option<std::string::String>,
                                        wasm_bindgen::JsValue,
                                    > = web_sys::Storage::get_item(&v33, v36);
                                    let v43: Ui::US11 = defaultValue(
                                        Ui::US11::US11_0,
                                        map(
                                            Func1::new(move |v_4: Option<std::string::String>| {
                                                Ui::closure15((), v_4)
                                            }),
                                            v38.ok(),
                                        ),
                                    );
                                    let v51: Ui::US12 = match &v43 {
                                        Ui::US11::US11_1(v43_1_0) => {
                                            Ui::US12::US12_1(defaultValue(
                                                Ui::US13::US13_0,
                                                map(
                                                    Func1::new(move |v_5: std::string::String| {
                                                        Ui::closure16((), v_5)
                                                    }),
                                                    v43_1_0.clone(),
                                                ),
                                            ))
                                        }
                                        _ => Ui::US12::US12_0,
                                    };
                                    let v58: Ui::US13 = if let Ui::US12::US12_1(v51_1_0) = &v51 {
                                        let v52: Ui::US13 = match &v51 {
                                            Ui::US12::US12_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Ui::US13::US13_1(v52_1_0) = &v52 {
                                            Ui::US13::US13_1(match &v52 {
                                                Ui::US13::US13_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Ui::US13::US13_0
                                        }
                                    } else {
                                        Ui::US13::US13_0
                                    };
                                    let v79: Ui::US10 = match &v58 {
                                        Ui::US13::US13_1(v58_1_0) => {
                                            let v61: std::string::String =
                                                Ui::method11(Ui::method21(v58_1_0.clone()));
                                            let v64: string = Ui::method1(
                                                fable_library_rust::String_::fromString(v61),
                                            );
                                            let v66: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v64);
                                            let v68: std::string::String = String::from(v66);
                                            let v70: Result<bool, serde_json::Error> =
                                                serde_json::from_str(&v68);
                                            Ui::US10::US10_1(defaultValue(
                                                Ui::US3::US3_0,
                                                map(
                                                    Func1::new(move |v_6: bool| {
                                                        Ui::closure9((), v_6)
                                                    }),
                                                    v70.ok(),
                                                ),
                                            ))
                                        }
                                        _ => Ui::US10::US10_0,
                                    };
                                    if let Ui::US10::US10_1(v79_1_0) = &v79 {
                                        let v80: Ui::US3 = match &v79 {
                                            Ui::US10::US10_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Ui::US3::US3_1(v80_1_0) = &v80 {
                                            Ui::US3::US3_1(match &v80 {
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
                                let v88: web_sys::Storage = Ui::method19(v19);
                                let v89: string = Ui::method20();
                                let v91: &str = fable_library_rust::String_::LrcStr::as_str(&v89);
                                let v93: Result<
                                    Option<std::string::String>,
                                    wasm_bindgen::JsValue,
                                > = web_sys::Storage::get_item(&v88, v91);
                                let v98: Ui::US11 = defaultValue(
                                    Ui::US11::US11_0,
                                    map(
                                        Func1::new(move |v_7: Option<std::string::String>| {
                                            Ui::closure15((), v_7)
                                        }),
                                        v93.ok(),
                                    ),
                                );
                                let v106: Ui::US12 = match &v98 {
                                    Ui::US11::US11_1(v98_1_0) => Ui::US12::US12_1(defaultValue(
                                        Ui::US13::US13_0,
                                        map(
                                            Func1::new(move |v_8: std::string::String| {
                                                Ui::closure16((), v_8)
                                            }),
                                            v98_1_0.clone(),
                                        ),
                                    )),
                                    _ => Ui::US12::US12_0,
                                };
                                let v113: Ui::US13 = if let Ui::US12::US12_1(v106_1_0) = &v106 {
                                    let v107: Ui::US13 = match &v106 {
                                        Ui::US12::US12_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Ui::US13::US13_1(v107_1_0) = &v107 {
                                        Ui::US13::US13_1(match &v107 {
                                            Ui::US13::US13_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    } else {
                                        Ui::US13::US13_0
                                    }
                                } else {
                                    Ui::US13::US13_0
                                };
                                let v134: Ui::US10 = match &v113 {
                                    Ui::US13::US13_1(v113_1_0) => {
                                        let v116: std::string::String =
                                            Ui::method11(Ui::method21(v113_1_0.clone()));
                                        let v119: string = Ui::method1(
                                            fable_library_rust::String_::fromString(v116),
                                        );
                                        let v121: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v119);
                                        let v123: std::string::String = String::from(v121);
                                        let v125: Result<bool, serde_json::Error> =
                                            serde_json::from_str(&v123);
                                        Ui::US10::US10_1(defaultValue(
                                            Ui::US3::US3_0,
                                            map(
                                                Func1::new(move |v_9: bool| Ui::closure9((), v_9)),
                                                v125.ok(),
                                            ),
                                        ))
                                    }
                                    _ => Ui::US10::US10_0,
                                };
                                if let Ui::US10::US10_1(v134_1_0) = &v134 {
                                    let v135: Ui::US3 = match &v134 {
                                        Ui::US10::US10_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Ui::US3::US3_1(v135_1_0) = &v135 {
                                        Ui::US3::US3_1(match &v135 {
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
                            let v145: string =
                                append(append(string("ui.dark_mode_toggle () / dark_mode effect 0 / ##1.1 / dark_mode2: "),
                                              toString(format!("{:?}", &v142))),
                                       string(""));
                            leptos::logging::log!("{}", &v145);
                            if let Ui::US3::US3_1(v142_1_0) = &v142 {
                                let v149: leptos::RwSignal<leptos::RwSignal<bool>> =
                                    Ui::method22(v0_1.l1.clone());
                                let v151: leptos::RwSignal<bool> =
                                    leptos::SignalGetUntracked::get_untracked(&v149);
                                let v152: bool = Ui::method23(match &v142 {
                                    Ui::US3::US3_1(x) => x.clone(),
                                    _ => unreachable!(),
                                });
                                let v153: leptos::RwSignal<bool> = Ui::method24(v151);
                                leptos::SignalSet::set(&v153, v152);
                                ()
                            }
                        }
                    }
                }
            }
        }
        pub fn method14(
            v0_1: LrcPtr<Ui::Heap0>,
            v1: leptos::Resource<Option<rexie::Rexie>, Ui::US3>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure10(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method26(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn method27(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn method28() {
            ();
        }
        pub fn closure17(
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
                let v4: leptos::Resource<Ui::US1, rexie::Rexie> = Ui::method7(v0_1);
                let v9: Ui::US4 = defaultValue(
                    Ui::US4::US4_0,
                    map(
                        Func1::new(move |v: rexie::Rexie| Ui::closure7((), v)),
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
                            let v17: rexie::Rexie = Ui::method26(v13);
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
                                                Ui::method27(Ok(()));
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
                                Ui::method28();
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
        pub fn method25(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
        ) -> Func1<bool, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Ui::closure17(v0_1.clone(), v)
            })
        }
        pub fn method30(
            v0_1: leptos::RwSignal<std::collections::HashMap<string, leptos::RwSignal<bool>>>,
        ) -> leptos::RwSignal<std::collections::HashMap<string, leptos::RwSignal<bool>>> {
            v0_1
        }
        pub fn closure18(
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
                > = Ui::method30(v0_1.l0.clone());
                leptos::SignalGetUntracked::get_untracked(&v4)
            }
        }
        pub fn method29(
            v0_1: LrcPtr<Ui::Heap0>,
        ) -> Func0<std::collections::HashMap<string, leptos::RwSignal<bool>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure18(v0_1.clone(), ())
            })
        }
        pub fn method32(v0_1: leptos::ReadSignal<bool>) -> leptos::ReadSignal<bool> {
            v0_1
        }
        pub fn method33(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn method34() -> string {
            string("dark-mode")
        }
        pub fn closure20(unitVar: (), v0_1: leptos::RwSignal<bool>) -> Ui::US14 {
            Ui::US14::US14_1(v0_1)
        }
        pub fn method35() -> bool {
            true
        }
        pub fn method36(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method37(v0_1: bool) -> bool {
            v0_1
        }
        pub fn method38(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn closure19(
            v0_1: LrcPtr<Ui::Heap0>,
            v1: leptos::Action<bool, ()>,
            v2: leptos::Memo<std::collections::HashMap<string, leptos::RwSignal<bool>>>,
            v3: leptos::WriteSignal<bool>,
            v4: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v5: leptos::ReadSignal<bool> = Ui::method32(v4);
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
                let v11: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method22(v0_1.l1.clone());
                let v14: leptos::RwSignal<bool> =
                    Ui::method33(leptos::SignalGetUntracked::get_untracked(&v11));
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
                    let v21: string = Ui::method34();
                    let v26: Ui::US14 = defaultValue(
                        Ui::US14::US14_0,
                        map(
                            Func1::new(move |v: leptos::RwSignal<bool>| Ui::closure20((), v)),
                            std::collections::HashMap::get(&v20, &v21).map(|x| *x),
                        ),
                    );
                    let v34: Ui::US3 = match &v26 {
                        Ui::US14::US14_1(v26_1_0) => {
                            let v28: leptos::RwSignal<bool> = Ui::method33(v26_1_0.clone());
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
                            let v42: bool = Ui::method35();
                            let v43: leptos::WriteSignal<bool> = Ui::method36(v3);
                            leptos::SignalSet::set(&v43, v42);
                            ()
                        } else {
                            let v45: string =
                                append(append(string("ui.dark_mode_toggle () / create_effect 2 / ##4 / dark_mode: "),
                                              ofBoolean(v16)), string(""));
                            leptos::logging::log!("{}", &v45);
                            {
                                let v48: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                                    Ui::method16(Ui::method15());
                                let v51: Ui::US7 = match &v48 {
                                    Err(v48_1_0) => Ui::closure12((), v48_1_0.clone()),
                                    Ok(v48_0_0) => Ui::closure11((), v48_0_0.clone()),
                                };
                                let v60: Ui::US8 = match &v51 {
                                    Ui::US7::US7_1(v51_1_0) => Ui::US8::US8_1(defaultValue(
                                        Ui::US9::US9_0,
                                        map(
                                            Func1::new(move |v_3: web_sys::Storage| {
                                                Ui::closure13((), v_3)
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
                                        let v63: bool = Ui::method37(v16);
                                        leptos::Action::dispatch(&v1, v63);
                                        {
                                            let v65: web_sys::Storage = Ui::method38(match &v61 {
                                                Ui::US9::US9_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            });
                                            let v66: string = Ui::method20();
                                            let v68: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v66);
                                            let v71: std::string::String =
                                                Ui::method11(format!("{}", &v16));
                                            let v74: string = Ui::method1(
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
        pub fn method31(
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
                    Ui::closure19(
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
        pub fn method40(
            v0_1: leptos::RwSignal<leptos::RwSignal<bool>>,
        ) -> leptos::RwSignal<leptos::RwSignal<bool>> {
            v0_1
        }
        pub fn closure22(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method41() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Ui::closure22((), v))
        }
        pub fn method42(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure21(v0_1: LrcPtr<Ui::Heap0>, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method40(v0_1.l1.clone());
            let v5: leptos::RwSignal<bool> = leptos::SignalGet::get(&v3);
            let v6 = Ui::method41();
            let v7: leptos::RwSignal<bool> = Ui::method42(v5);
            leptos::SignalUpdate::update(&v7, |x| *x = v6(*x));
            ()
        }
        pub fn method39(v0_1: LrcPtr<Ui::Heap0>) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Ui::closure21(v0_1.clone(), v)
            })
        }
        pub fn closure23(v0_1: LrcPtr<Ui::Heap0>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method40(v0_1.l1.clone());
            let v5: leptos::RwSignal<bool> = Ui::method33(leptos::SignalGet::get(&v2));
            leptos::SignalGet::get(&v5)
        }
        pub fn method43(v0_1: LrcPtr<Ui::Heap0>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure23(v0_1.clone(), ())
            })
        }
        pub fn method44() -> string {
            string("view")
        }
        pub fn method45(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn method46() -> string {
            string("connection")
        }
        pub fn method47(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn closure24(v0_1: LrcPtr<Ui::Heap0>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method40(v0_1.l1.clone());
            let v5: leptos::RwSignal<bool> = Ui::method33(leptos::SignalGet::get(&v2));
            leptos::SignalGet::get(&v5)
        }
        pub fn method48(v0_1: LrcPtr<Ui::Heap0>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure24(v0_1.clone(), ())
            })
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
                    let v16: LrcPtr<Ui::Heap0> =
                        leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into();
                    let v18: string = Ui::method1(toString(14_i32));
                    let v20: &str = fable_library_rust::String_::LrcStr::as_str(&v18);
                    let v21: string = Ui::method2();
                    let v23: &str = fable_library_rust::String_::LrcStr::as_str(&v21);
                    let v25: std::string::String = String::from(v23);
                    let patternInput: (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ) = leptos::create_signal(v25);
                    let v29: string =
                        string("leptos::view! { <input class=\"bg-gray-50 dark:bg-gray-900 flex-1 h-8\" prop:value=$0 on:keyup=move |event: web_sys::KeyboardEvent| { $1(leptos::event_target_value(&event)) } /> }");
                    let v32: leptos::HtmlElement<leptos::html::Input> = leptos::view! { <input class="bg-gray-50 dark:bg-gray-900 flex-1 h-8" prop:value=patternInput.0.clone() on:keyup=move |event: web_sys::KeyboardEvent| { patternInput.1.clone()(leptos::event_target_value(&event)) } /> };
                    leptos::logging::log!("{}", &string("ui.dark_mode_toggle ()"));
                    {
                        let v36: LrcPtr<Ui::Heap0> =
                            leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into();
                        let v37 = Ui::method3();
                        let v40: leptos::Resource<Ui::US1, rexie::Rexie> =
                            leptos::create_local_resource(
                                move || v37(),
                                |x| async move {
                                    Func1::new(move |v: Ui::US1| Ui::closure4((), v))(x).await
                                },
                            );
                        let v41 = Ui::method6(v40.clone());
                        let v45 = Ui::method14(
                            v36.clone(),
                            leptos::create_local_resource(
                                move || v41(),
                                |x| async move {
                                    Func1::new(move |v_1: Option<rexie::Rexie>| {
                                        Ui::closure6((), v_1)
                                    })(x)
                                    .await
                                },
                            ),
                        );
                        leptos::create_effect(move |_| v45());
                        {
                            let v47 = Ui::method25(v40);
                            let v49: leptos::Action<bool, ()> =
                                leptos::create_action(move |value: &bool| v47(*value));
                            let v50 = Ui::method29(v36.clone());
                            let v52: leptos::Memo<
                                std::collections::HashMap<string, leptos::RwSignal<bool>>,
                            > = leptos::create_memo(move |_| v50());
                            let patternInput_1: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(false);
                            let v56 = Ui::method31(
                                v36.clone(),
                                v49,
                                v52,
                                patternInput_1.1.clone(),
                                patternInput_1.0.clone(),
                            );
                            leptos::create_effect(move |_| v56());
                            {
                                let v58 = Ui::method39(v36.clone());
                                let v59 = Ui::method43(v36);
                                let v60: string =
                                    string("<label for=\"AcceptConditions\" class=\"relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\"><input type=\"checkbox\" id=\"AcceptConditions\" class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\" on:change=move |event| v58(event) prop:checked={move || v59()} /><span class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-green-600\"><svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg><svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg></span><span class=\"absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-green-500\"></span></label>");
                                let v61: string =
                                    append(append(string("leptos::view! { "), v60), string(" }"));
                                let v63: leptos::HtmlElement<leptos::html::Label> = leptos::view! { <label for="AcceptConditions" class="relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"><input type="checkbox" id="AcceptConditions" class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" on:change=move |event| v58(event) prop:checked={move || v59()} /><span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-green-600"><svg data-unchecked-icon xmlns="http://www.w3.org/2000/svg" class="h-4 w-4" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" clip-rule="evenodd" /></svg><svg data-checked-icon xmlns="http://www.w3.org/2000/svg" class="hidden h-4 w-4" viewBox="0 0 20 20" fill="currentColor"> <path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" /></svg></span><span class="absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-green-500"></span></label> };
                                let v65: string =
                                    string("leptos::view! { <div class=\"flex items-center\"><div>dark_mode:</div>{v63}</div> }");
                                let v67: leptos::HtmlElement<leptos::html::Div> = leptos::view! { <div class="flex items-center"><div>dark_mode:</div>{v63}</div> };
                                let v68: string = Ui::method44();
                                let v70: &str = fable_library_rust::String_::LrcStr::as_str(&v68);
                                let v72: std::string::String = String::from(v70);
                                let v73: leptos::HtmlElement<leptos::html::Div> = Ui::method45(v67);
                                let v74: string =
                                    string("<details class=\"group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between rounded-lg px-4 py-2 text-gray-500 hover:bg-gray-100 hover:text-gray-700 dark:text-gray-400 dark:hover:bg-gray-800 dark:hover:text-gray-200\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v72}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\"><svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg></span></summary>{v73}</details>");
                                let v75: string =
                                    append(append(string("leptos::view! { "), v74), string(" }"));
                                let v77: leptos::HtmlElement<leptos::html::Details> = leptos::view! { <details class="group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between rounded-lg px-4 py-2 text-gray-500 hover:bg-gray-100 hover:text-gray-700 dark:text-gray-400 dark:hover:bg-gray-800 dark:hover:text-gray-200"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v72}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180"><svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg></span></summary>{v73}</details> };
                                let v78: string =
                                    string("<div class=\"flex items-baseline\" style=\"align-items: baseline;\"><div>explorer_backend_host:</div>{v32}</div>");
                                let v79: string =
                                    append(append(string("leptos::view! { "), v78), string(" }"));
                                let v81: leptos::HtmlElement<leptos::html::Div> = leptos::view! { <div class="flex items-baseline" style="align-items: baseline;"><div>explorer_backend_host:</div>{v32}</div> };
                                let v82: string = Ui::method46();
                                let v84: &str = fable_library_rust::String_::LrcStr::as_str(&v82);
                                let v86: std::string::String = String::from(v84);
                                let v87: leptos::HtmlElement<leptos::html::Div> = Ui::method47(v81);
                                let v88: string =
                                    string("<details class=\"group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between rounded-lg px-4 py-2 text-gray-500 hover:bg-gray-100 hover:text-gray-700 dark:text-gray-400 dark:hover:bg-gray-800 dark:hover:text-gray-200\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v86}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\"><svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg></span></summary>{v87}</details>");
                                let v89: string =
                                    append(append(string("leptos::view! { "), v88), string(" }"));
                                let v91: leptos::HtmlElement<leptos::html::Details> = leptos::view! { <details class="group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between rounded-lg px-4 py-2 text-gray-500 hover:bg-gray-100 hover:text-gray-700 dark:text-gray-400 dark:hover:bg-gray-800 dark:hover:text-gray-200"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v86}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180"><svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg></span></summary>{v87}</details> };
                                let v92: string =
                                    string("leptos::view! { <div class=\"bg-gray-50 dark:bg-gray-900 flex flex-1 flex-col items-stretch min-h-screen min-w-full text-gray-700 dark:text-gray-200 text-sm\" style=\"font-size: \".to_owned() + *$0 + \"px;\">{v77}{v91}</div> }");
                                let v95: leptos::HtmlElement<leptos::html::Div> = leptos::view! { <div class="bg-gray-50 dark:bg-gray-900 flex flex-1 flex-col items-stretch min-h-screen min-w-full text-gray-700 dark:text-gray-200 text-sm" style="font-size: ".to_owned() + *&v20 + "px;">{v77}{v91}</div> };
                                let v96 = Ui::method48(v16);
                                let v98: string =
                                    string("leptos::view! { <div class=\"flex flex-1\" class:dark={move || v96()}>{v95}</div> }");
                                let v100: leptos::HtmlElement<leptos::html::Div> = leptos::view! { <div class="flex flex-1" class:dark={move || v96()}>{v95}</div> };
                                leptos::IntoView::into_view(v100)
                            }
                        }
                    }
                }
            }
        }
        pub fn method0() {
            leptos::mount_to_body(|| Func0::new(move || Ui::closure2((), ()))());
            ()
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) {
            Ui::method0();
        }
        pub fn method49() -> Func0<()> {
            Func0::new(move || Ui::closure25((), ()))
        }
        pub fn method50(v0_1: Box<dyn Fn()>) -> Box<dyn Fn()> {
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
                let v12: string = append(
                    append(
                        string("main / mount_to_body / body: "),
                        toString(format!("{:?}", &v9)),
                    ),
                    string(""),
                );
                leptos::logging::log!("{}", &v12);
                if let Ui::US0::US0_1(v9_1_0) = &v9 {
                    Ui::method0()
                } else {
                    let v15 = Ui::method49();
                    let v18: Box<dyn Fn()> = Ui::method50(Box::new(move || v15()));
                    let v20: wasm_bindgen::closure::Closure<dyn Fn()> =
                        wasm_bindgen::closure::Closure::wrap(v18);
                    let v22: &wasm_bindgen::JsValue = wasm_bindgen::closure::Closure::as_ref(&v20);
                    let v24: &js_sys::Function = wasm_bindgen::JsCast::unchecked_ref(v22);
                    leptos::document()
                        .add_event_listener_with_callback("DOMContentLoaded", v24)
                        .unwrap();
                    v20.forget();
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
