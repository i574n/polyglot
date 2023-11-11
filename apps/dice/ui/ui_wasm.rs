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
        pub enum US0 {
            US0_0,
            US0_1,
        }
        impl core::fmt::Display for Ui::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US1 {
            US1_0(rexie::Error),
            US1_1(rexie::Rexie),
        }
        impl core::fmt::Display for Ui::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US2 {
            US2_0,
            US2_1(bool),
        }
        impl core::fmt::Display for Ui::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US3 {
            US3_0,
            US3_1(rexie::Rexie),
        }
        impl core::fmt::Display for Ui::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US4 {
            US4_0,
            US4_1(serde_json::Value),
        }
        impl core::fmt::Display for Ui::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US5 {
            US5_0(rexie::Error),
            US5_1(Ui::US2),
        }
        impl core::fmt::Display for Ui::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(wasm_bindgen::JsValue),
            US6_1(Option<web_sys::Storage>),
        }
        impl core::fmt::Display for Ui::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0,
            US8_1(web_sys::Storage),
        }
        impl core::fmt::Display for Ui::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0(wasm_bindgen::JsValue),
            US7_1(Ui::US8),
        }
        impl core::fmt::Display for Ui::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US9 {
            US9_0,
            US9_1(Ui::US2),
        }
        impl core::fmt::Display for Ui::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0,
            US10_1(leptos::RwSignal<bool>),
        }
        impl core::fmt::Display for Ui::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0(v0_1: string) -> string {
            v0_1
        }
        pub fn method1() -> string {
            string("explorer-backend-mainnet-prod-24ktefolwq-uc.a.run.app")
        }
        pub fn method3(
            v0_1: leptos::RwSignal<leptos::RwSignal<bool>>,
        ) -> leptos::RwSignal<leptos::RwSignal<bool>> {
            v0_1
        }
        pub fn method4(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure2(v0_1: LrcPtr<Ui::Heap0>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method3(v0_1.l1.clone());
            let v5: leptos::RwSignal<bool> = Ui::method4(leptos::SignalGet::get(&v2));
            leptos::SignalGet::get(&v5)
        }
        pub fn method2(v0_1: LrcPtr<Ui::Heap0>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure2(v0_1.clone(), ())
            })
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) -> Ui::US0 {
            Ui::US0::US0_0
        }
        pub fn method5() -> Func0<Ui::US0> {
            Func0::new(move || Ui::closure3((), ()))
        }
        pub fn method6(v0_1: rexie::Rexie) -> Ui::US1 {
            Ui::US1::US1_1(v0_1)
        }
        pub fn method7(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure4(
            unitVar: (),
            v0_1: Ui::US0,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = rexie::Rexie>>> {
            let __future_init = Box::pin(async {
                //;
                leptos::logging::log!(
                    "{}",
                    &string("ui.dark_mode_button () / database create_local_resource")
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
                        let v13: Ui::US1 = Ui::method6(v10.unwrap());
                        v13
                    }
                });
                {
                    let v16: std::pin::Pin<Box<dyn std::future::Future<Output = Ui::US1>>> =
                        __future_init;
                    let v18: Ui::US1 = v16.await;
                    let v25: rexie::Rexie = Ui::method7(match &v18 {
                        Ui::US1::US1_1(v18_1_0) => v18_1_0.clone(),
                        Ui::US1::US1_0(v18_0_0) => {
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
        pub fn method9(
            v0_1: leptos::Resource<Ui::US0, rexie::Rexie>,
        ) -> leptos::Resource<Ui::US0, rexie::Rexie> {
            v0_1
        }
        pub fn closure5(
            v0_1: leptos::Resource<Ui::US0, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Ui::US0, rexie::Rexie> = Ui::method9(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method8(
            v0_1: leptos::Resource<Ui::US0, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure5(v0_1.clone(), ())
            })
        }
        pub fn closure7(unitVar: (), v0_1: rexie::Rexie) -> Ui::US3 {
            Ui::US3::US3_1(v0_1)
        }
        pub fn method10(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure8(unitVar: (), v0_1: serde_json::Value) -> Ui::US4 {
            Ui::US4::US4_1(v0_1)
        }
        pub fn method11(v0_1: serde_json::Value) -> serde_json::Value {
            v0_1
        }
        pub fn method12(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn closure9(unitVar: (), v0_1: bool) -> Ui::US2 {
            Ui::US2::US2_1(v0_1)
        }
        pub fn method13(v0_1: Result<Ui::US2, rexie::Error>) -> Result<Ui::US2, rexie::Error> {
            v0_1
        }
        pub fn method14(v0_1: Ui::US2) -> Ui::US2 {
            v0_1
        }
        pub fn closure6(
            unitVar: (),
            v0_1: Option<rexie::Rexie>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Ui::US2>>> {
            let __future_init = Box::pin(async {
                //;
                {
                    let v4: string =
                    append(append(string("ui.dark_mode_button () / dark_mode create_local_resource / database: "),
                                  toString(format!("{:?}", &v0_1))),
                           string(""));
                    leptos::logging::log!("{}", &v4);
                    {
                        let v8: Ui::US3 = defaultValue(
                            Ui::US3::US3_0,
                            map(Func1::new(move |v: rexie::Rexie| Ui::closure7((), v)), v0_1),
                        );
                        let v80: Ui::US2 = Ui::method14(match &v8 {
                            Ui::US3::US3_1(v8_1_0) => {
                                leptos::logging::log!("{}", &string("ui.get_dark_mode ()"));
                                {
                                    let v12: rexie::Rexie = Ui::method10(v8_1_0.clone());
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
                                            let v33: Ui::US4 = defaultValue(
                                                Ui::US4::US4_0,
                                                map(
                                                    Func1::new(move |v_1: serde_json::Value| {
                                                        Ui::closure8((), v_1)
                                                    }),
                                                    serde_wasm_bindgen::from_value(v28).unwrap(),
                                                ),
                                            );
                                            let v61: Ui::US5 = match &v33 {
                                                Ui::US4::US4_1(v33_1_0) => {
                                                    let v35: serde_json::Value =
                                                        Ui::method11(v33_1_0.clone());
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
                                                        let v42: Vec<u8> = Ui::method12(v37);
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
                                                            let v48: serde_json::Value =
                                                                serde_json::from_str::<
                                                                    serde_json::Value,
                                                                >(
                                                                    &v44
                                                                )
                                                                .unwrap();
                                                            let v50: string =
                                                                string("r#\"dark-mode\"#");
                                                            let v51: &str = r#"dark-mode"#;
                                                            Ui::US5::US5_1(defaultValue(
                                                                Ui::US2::US2_0,
                                                                map(
                                                                    Func1::new(move |v_2: bool| {
                                                                        Ui::closure9((), v_2)
                                                                    }),
                                                                    v48[v51].as_bool(),
                                                                ),
                                                            ))
                                                        }
                                                    }
                                                }
                                                _ => Ui::US5::US5_1(Ui::US2::US2_0),
                                            };
                                            let v68: Result<Ui::US2, rexie::Error> =
                                                Ui::method13(match &v61 {
                                                    Ui::US5::US5_1(v61_1_0) => Ok(v61_1_0.clone()),
                                                    Ui::US5::US5_0(v61_0_0) => Err(v61_0_0.clone()),
                                                });
                                            v68
                                        }
                                    });
                                    {
                                        // ;
                                        {
                                            let v72: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = Result<Ui::US2, rexie::Error>,
                                                    >,
                                                >,
                                            > = __future_init;
                                            let v74: Result<Ui::US2, rexie::Error> = v72.await;
                                            v74.unwrap()
                                        }
                                    }
                                }
                            }
                            _ => Ui::US2::US2_0,
                        });
                        v80
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
        pub fn method16() -> web_sys::Window {
            leptos::leptos_dom::window()
        }
        pub fn method18(v0_1: web_sys::Window) -> web_sys::Window {
            v0_1
        }
        pub fn method17(
            v0_1: web_sys::Window,
        ) -> Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> {
            let v1: web_sys::Window = Ui::method18(v0_1);
            v1.local_storage()
        }
        pub fn closure11(unitVar: (), v0_1: Option<web_sys::Storage>) -> Ui::US6 {
            Ui::US6::US6_1(v0_1)
        }
        pub fn closure12(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Ui::US6 {
            Ui::US6::US6_0(v0_1)
        }
        pub fn closure13(unitVar: (), v0_1: web_sys::Storage) -> Ui::US8 {
            Ui::US8::US8_1(v0_1)
        }
        pub fn method19(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Ui::US2>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Ui::US2> {
            v0_1
        }
        pub fn closure14(unitVar: (), v0_1: Ui::US2) -> Ui::US9 {
            Ui::US9::US9_1(v0_1)
        }
        pub fn method20(
            v0_1: leptos::RwSignal<leptos::RwSignal<bool>>,
        ) -> leptos::RwSignal<leptos::RwSignal<bool>> {
            v0_1
        }
        pub fn method21(v0_1: bool) -> bool {
            v0_1
        }
        pub fn method22(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure10(
            v0_1: LrcPtr<Ui::Heap0>,
            v1: leptos::Resource<Option<rexie::Rexie>, Ui::US2>,
            unitVar: (),
        ) {
            leptos::logging::log!(
                "{}",
                &string("ui.dark_mode_button () / create_effect 1 / ##1")
            );
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Ui::method17(Ui::method16());
                let v8: Ui::US6 = match &v5 {
                    Err(v5_1_0) => Ui::closure12((), v5_1_0.clone()),
                    Ok(v5_0_0) => Ui::closure11((), v5_0_0.clone()),
                };
                let v17: Ui::US7 = match &v8 {
                    Ui::US6::US6_1(v8_1_0) => Ui::US7::US7_1(defaultValue(
                        Ui::US8::US8_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Ui::closure13((), v_2)),
                            v8_1_0.clone(),
                        ),
                    )),
                    Ui::US6::US6_0(v8_0_0) => Ui::US7::US7_0(v8_0_0.clone()),
                };
                if let Ui::US7::US7_1(v17_1_0) = &v17 {
                    if let Ui::US8::US8_1(_) = &match &v17 {
                        Ui::US7::US7_1(x) => x.clone(),
                        _ => unreachable!(),
                    } {
                        let v20: leptos::Resource<Option<rexie::Rexie>, Ui::US2> = Ui::method19(v1);
                        let v25: Ui::US9 = defaultValue(
                            Ui::US9::US9_0,
                            map(
                                Func1::new(move |v_3: Ui::US2| Ui::closure14((), v_3)),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v28: string =
                            append(append(string("ui.dark_mode_button () / dark_mode effect 0 / ##1.1 / dark_mode: "),
                                          toString(format!("{:?}", &v25))),
                                   string(""));
                        leptos::logging::log!("{}", &v28);
                        if let Ui::US9::US9_1(v25_1_0) = &v25 {
                            let v30: Ui::US2 = match &v25 {
                                Ui::US9::US9_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Ui::US2::US2_1(v30_1_0) = &v30 {
                                let v33: leptos::RwSignal<leptos::RwSignal<bool>> =
                                    Ui::method20(v0_1.l1.clone());
                                let v35: leptos::RwSignal<bool> =
                                    leptos::SignalGetUntracked::get_untracked(&v33);
                                let v36: bool = Ui::method21(match &v30 {
                                    Ui::US2::US2_1(x) => x.clone(),
                                    _ => unreachable!(),
                                });
                                let v37: leptos::RwSignal<bool> = Ui::method22(v35);
                                leptos::SignalSet::set(&v37, v36);
                                ()
                            }
                        }
                    };
                }
            }
        }
        pub fn method15(
            v0_1: LrcPtr<Ui::Heap0>,
            v1: leptos::Resource<Option<rexie::Rexie>, Ui::US2>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure10(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method24(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn method25(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn method26() {
            ();
        }
        pub fn closure15(
            v0_1: leptos::Resource<Ui::US0, rexie::Rexie>,
            v1: bool,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v2: string = append(
                append(
                    string("ui.dark_mode_button () / set_dark_mode_action / value: "),
                    ofBoolean(v1),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v2);
            {
                let v4: leptos::Resource<Ui::US0, rexie::Rexie> = Ui::method9(v0_1);
                let v9: Ui::US3 = defaultValue(
                    Ui::US3::US3_0,
                    map(
                        Func1::new(move |v: rexie::Rexie| Ui::closure7((), v)),
                        leptos::SignalGet::get(&v4),
                    ),
                );
                let v13: rexie::Rexie = match &v9 {
                    Ui::US3::US3_1(v9_1_0) => v9_1_0.clone(),
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
                            let v17: rexie::Rexie = Ui::method24(v13);
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
                                                Ui::method25(Ok(()));
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
                                Ui::method26();
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
        pub fn method23(
            v0_1: leptos::Resource<Ui::US0, rexie::Rexie>,
        ) -> Func1<bool, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: bool| Ui::closure15(v0_1.clone(), v)
            })
        }
        pub fn method28(
            v0_1: leptos::RwSignal<std::collections::HashMap<string, leptos::RwSignal<bool>>>,
        ) -> leptos::RwSignal<std::collections::HashMap<string, leptos::RwSignal<bool>>> {
            v0_1
        }
        pub fn closure16(
            v0_1: LrcPtr<Ui::Heap0>,
            unitVar: (),
        ) -> std::collections::HashMap<string, leptos::RwSignal<bool>> {
            leptos::logging::log!(
                "{}",
                &string("ui.dark_mode_button () / loading create_memo")
            );
            {
                let v4: leptos::RwSignal<
                    std::collections::HashMap<string, leptos::RwSignal<bool>>,
                > = Ui::method28(v0_1.l0.clone());
                leptos::SignalGetUntracked::get_untracked(&v4)
            }
        }
        pub fn method27(
            v0_1: LrcPtr<Ui::Heap0>,
        ) -> Func0<std::collections::HashMap<string, leptos::RwSignal<bool>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure16(v0_1.clone(), ())
            })
        }
        pub fn method30(v0_1: leptos::ReadSignal<bool>) -> leptos::ReadSignal<bool> {
            v0_1
        }
        pub fn method31() -> string {
            string("dark-mode")
        }
        pub fn closure18(unitVar: (), v0_1: leptos::RwSignal<bool>) -> Ui::US10 {
            Ui::US10::US10_1(v0_1)
        }
        pub fn method32() -> bool {
            true
        }
        pub fn method33(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method34(v0_1: bool) -> bool {
            v0_1
        }
        pub fn closure17(
            v0_1: LrcPtr<Ui::Heap0>,
            v1: leptos::Action<bool, ()>,
            v2: leptos::Memo<std::collections::HashMap<string, leptos::RwSignal<bool>>>,
            v3: leptos::WriteSignal<bool>,
            v4: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v5: leptos::ReadSignal<bool> = Ui::method30(v4);
            let v7: bool = leptos::SignalGet::get(&v5);
            let v8: string = append(
                append(
                    string("ui.dark_mode_button () / create_effect 2 / ##1 / loaded: "),
                    ofBoolean(v7),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v8);
            {
                let v11: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method20(v0_1.l1.clone());
                let v14: leptos::RwSignal<bool> =
                    Ui::method4(leptos::SignalGetUntracked::get_untracked(&v11));
                let v16: bool = leptos::SignalGet::get(&v14);
                let v17: string = append(
                    append(
                        string("ui.dark_mode_button () / create_effect 2 / ##2 / dark_mode: "),
                        ofBoolean(v16),
                    ),
                    string(""),
                );
                leptos::logging::log!("{}", &v17);
                {
                    let v20: std::collections::HashMap<string, leptos::RwSignal<bool>> = v2();
                    let v21: string = Ui::method31();
                    let v26: Ui::US10 = defaultValue(
                        Ui::US10::US10_0,
                        map(
                            Func1::new(move |v: leptos::RwSignal<bool>| Ui::closure18((), v)),
                            std::collections::HashMap::get(&v20, &v21).map(|x| *x),
                        ),
                    );
                    let v34: Ui::US2 = match &v26 {
                        Ui::US10::US10_1(v26_1_0) => {
                            let v28: leptos::RwSignal<bool> = Ui::method4(v26_1_0.clone());
                            Ui::US2::US2_1(leptos::SignalGet::get(&v28))
                        }
                        _ => Ui::US2::US2_0,
                    };
                    let v37: bool = match &v34 {
                        Ui::US2::US2_1(v34_1_0) => v34_1_0.clone(),
                        _ => false,
                    };
                    let v38: string =
                        append(append(string("ui.dark_mode_button () / create_effect 2 / ##3 / dark_mode_loading: "),
                                      ofBoolean(v37)), string(""));
                    leptos::logging::log!("{}", &v38);
                    if v37 == false {
                        if v7 == false {
                            let v42: bool = Ui::method32();
                            let v43: leptos::WriteSignal<bool> = Ui::method33(v3);
                            leptos::SignalSet::set(&v43, v42);
                            ()
                        } else {
                            let v45: string =
                                append(append(string("ui.dark_mode_button () / create_effect 2 / ##4 / dark_mode: "),
                                              ofBoolean(v16)), string(""));
                            leptos::logging::log!("{}", &v45);
                            {
                                let v48: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                                    Ui::method17(Ui::method16());
                                let v51: Ui::US6 = match &v48 {
                                    Err(v48_1_0) => Ui::closure12((), v48_1_0.clone()),
                                    Ok(v48_0_0) => Ui::closure11((), v48_0_0.clone()),
                                };
                                let v60: Ui::US7 = match &v51 {
                                    Ui::US6::US6_1(v51_1_0) => Ui::US7::US7_1(defaultValue(
                                        Ui::US8::US8_0,
                                        map(
                                            Func1::new(move |v_3: web_sys::Storage| {
                                                Ui::closure13((), v_3)
                                            }),
                                            v51_1_0.clone(),
                                        ),
                                    )),
                                    Ui::US6::US6_0(v51_0_0) => Ui::US7::US7_0(v51_0_0.clone()),
                                };
                                if let Ui::US7::US7_1(v60_1_0) = &v60 {
                                    if let Ui::US8::US8_1(_) = &match &v60 {
                                        Ui::US7::US7_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    } {
                                        let v63: bool = Ui::method34(v16);
                                        leptos::Action::dispatch(&v1, v63);
                                        ()
                                    };
                                }
                            }
                        };
                    }
                }
            }
        }
        pub fn method29(
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
                    Ui::closure17(
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
        pub fn closure20(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method36() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Ui::closure20((), v))
        }
        pub fn method37(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure19(v0_1: LrcPtr<Ui::Heap0>, v1: leptos::ev::MouseEvent) {
            let v3: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method3(v0_1.l1.clone());
            let v5: leptos::RwSignal<bool> = leptos::SignalGet::get(&v3);
            let v6 = Ui::method36();
            let v7: leptos::RwSignal<bool> = Ui::method37(v5);
            leptos::SignalUpdate::update(&v7, |x| *x = v6(*x));
            ()
        }
        pub fn method35(v0_1: LrcPtr<Ui::Heap0>) -> Func1<leptos::ev::MouseEvent, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::MouseEvent| Ui::closure19(v0_1.clone(), v)
            })
        }
        pub fn closure1(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
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
                    let v18: string = Ui::method0(toString(14_i32));
                    let v20: &str = fable_library_rust::String_::LrcStr::as_str(&v18);
                    let v21: string = Ui::method1();
                    let v23: &str = fable_library_rust::String_::LrcStr::as_str(&v21);
                    let v25: std::string::String = String::from(v23);
                    let patternInput: (
                        leptos::ReadSignal<std::string::String>,
                        leptos::WriteSignal<std::string::String>,
                    ) = leptos::create_signal(v25);
                    let v29: string =
                        string("leptos::view! { <input class=\"bg-gray-50 dark:bg-gray-900 flex-1 h-8\" prop:value=$0 on:keyup=move |event: web_sys::KeyboardEvent| { $1(leptos::event_target_value(&event)) } /> }");
                    let v32: leptos::HtmlElement<leptos::html::Input> = leptos::view! { <input class="bg-gray-50 dark:bg-gray-900 flex-1 h-8" prop:value=patternInput.0.clone() on:keyup=move |event: web_sys::KeyboardEvent| { patternInput.1.clone()(leptos::event_target_value(&event)) } /> };
                    let v33: string =
                        string("leptos::view! { <div class=\"bg-gray-50 dark:bg-gray-900 flex flex-1 min-h-screen min-w-full place-items-baseline text-gray-700 dark:text-gray-200 text-sm\" style=\"font-size: \".to_owned() + *$0 + \"px; place-items: baseline;\">label:{v32}</div> }");
                    let v36: leptos::HtmlElement<leptos::html::Div> = leptos::view! { <div class="bg-gray-50 dark:bg-gray-900 flex flex-1 min-h-screen min-w-full place-items-baseline text-gray-700 dark:text-gray-200 text-sm" style="font-size: ".to_owned() + *&v20 + "px; place-items: baseline;">label:{v32}</div> };
                    let v37 = Ui::method2(v16);
                    leptos::logging::log!("{}", &string("ui.dark_mode_button ()"));
                    {
                        let v41: LrcPtr<Ui::Heap0> =
                            leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into();
                        let v42 = Ui::method5();
                        let v45: leptos::Resource<Ui::US0, rexie::Rexie> =
                            leptos::create_local_resource(
                                move || v42(),
                                |x| async move {
                                    Func1::new(move |v: Ui::US0| Ui::closure4((), v))(x).await
                                },
                            );
                        let v46 = Ui::method8(v45.clone());
                        let v50 = Ui::method15(
                            v41.clone(),
                            leptos::create_local_resource(
                                move || v46(),
                                |x| async move {
                                    Func1::new(move |v_1: Option<rexie::Rexie>| {
                                        Ui::closure6((), v_1)
                                    })(x)
                                    .await
                                },
                            ),
                        );
                        leptos::create_effect(move |_| v50());
                        {
                            let v52 = Ui::method23(v45);
                            let v54: leptos::Action<bool, ()> =
                                leptos::create_action(move |value: &bool| v52(*value));
                            let v55 = Ui::method27(v41.clone());
                            let v57: leptos::Memo<
                                std::collections::HashMap<string, leptos::RwSignal<bool>>,
                            > = leptos::create_memo(move |_| v55());
                            let patternInput_1: (
                                leptos::ReadSignal<bool>,
                                leptos::WriteSignal<bool>,
                            ) = leptos::create_signal(false);
                            let v61 = Ui::method29(
                                v41.clone(),
                                v54,
                                v57,
                                patternInput_1.1.clone(),
                                patternInput_1.0.clone(),
                            );
                            leptos::create_effect(move |_| v61());
                            {
                                let v63 = Ui::method35(v41);
                                let v64: string =
                                    string("<button class=\"fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full\" on:click=move |mouse_event| v63(mouse_event)>{(|| { leptos::logging::log!(\"button () / render\"); leptos::view! {<></>} })()}{\"🌓︎\"}</button>");
                                let v65: string =
                                    append(append(string("leptos::view! { "), v64), string(" }"));
                                let v67: leptos::HtmlElement<leptos::html::Button> = leptos::view! { <button class="fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full" on:click=move |mouse_event| v63(mouse_event)>{(|| { leptos::logging::log!("button () / render"); leptos::view! {<></>} })()}{"🌓︎"}</button> };
                                let v69: string =
                                    string("leptos::view! { <div class=\"flex flex-1\" class:dark={move || v37()}>{v67}{v36}</div> }");
                                let v71: leptos::HtmlElement<leptos::html::Div> = leptos::view! { <div class="flex flex-1" class:dark={move || v37()}>{v67}{v36}</div> };
                                leptos::IntoView::into_view(v71)
                            }
                        }
                    }
                }
            }
        }
        pub fn closure0(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1: string = append(append(string("main / args: "), toString(v0_1)), string(""));
            leptos::logging::log!("{}", &v1);
            let _ = console_log::init_with_level(log::Level::Debug);
            console_error_panic_hook::set_once();
            {
                let v6: string = string("leptos::logging::log!(\"main / mount_to_body\")");
                leptos::logging::log!("main / mount_to_body");
                leptos::mount_to_body(|| Func0::new(move || Ui::closure1((), ()))());
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
