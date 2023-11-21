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
        impl core::fmt::Display for Ui::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize)]
        pub struct Heap0 {
            pub l0: leptos::RwSignal<bool>,
            pub l1: leptos::RwSignal<std::string::String>,
        }
        impl core::fmt::Display for Ui::Heap0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize)]
        pub struct Heap1 {
            pub l0: leptos::RwSignal<std::string::String>,
        }
        impl core::fmt::Display for Ui::Heap1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, serde::Serialize, PartialEq)]
        pub struct Heap2 {
            pub l0: leptos::RwSignal<Ui::Heap0>,
            pub l1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            pub l2: leptos::RwSignal<Ui::Heap1>,
        }
        impl core::fmt::Display for Ui::Heap2 {
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
        impl core::fmt::Display for Ui::Heap3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US3 {
            US3_0,
            US3_1(Ui::Heap3),
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
        impl core::fmt::Display for Ui::Heap4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0,
            US7_1(Ui::Heap4),
        }
        impl core::fmt::Display for Ui::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(rexie::Error),
            US8_1(Ui::US7),
        }
        impl core::fmt::Display for Ui::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(wasm_bindgen::JsValue),
            US9_1(Option<web_sys::Storage>),
        }
        impl core::fmt::Display for Ui::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0,
            US11_1(web_sys::Storage),
        }
        impl core::fmt::Display for Ui::US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(wasm_bindgen::JsValue),
            US10_1(Ui::US11),
        }
        impl core::fmt::Display for Ui::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0,
            US12_1(Ui::US3),
        }
        impl core::fmt::Display for Ui::US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(wasm_bindgen::JsValue),
            US13_1(Option<std::string::String>),
        }
        impl core::fmt::Display for Ui::US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0,
            US15_1(std::string::String),
        }
        impl core::fmt::Display for Ui::US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US14 {
            US14_0(wasm_bindgen::JsValue),
            US14_1(Ui::US15),
        }
        impl core::fmt::Display for Ui::US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0,
            US16_1(Ui::US15),
        }
        impl core::fmt::Display for Ui::US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0,
            US17_1(Ui::US7),
        }
        impl core::fmt::Display for Ui::US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US18 {
            US18_0,
            US18_1(leptos::RwSignal<bool>),
        }
        impl core::fmt::Display for Ui::US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US19 {
            US19_0,
            US19_1(bool),
        }
        impl core::fmt::Display for Ui::US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US20 {
            US20_0,
            US20_1,
        }
        impl core::fmt::Display for Ui::US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(std::string::String),
            US21_1(std::string::String),
        }
        impl core::fmt::Display for Ui::US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn closure1(unitVar: (), v0_1: web_sys::HtmlElement) -> Ui::US0 {
            Ui::US0::US0_1(v0_1)
        }
        pub fn method1() -> string {
            string("")
        }
        pub fn method2() -> string {
            string("explorer-backend-mainnet-prod-24ktefolwq-uc.a.run.app")
        }
        pub fn method3(v0_1: Ui::Heap2) -> Ui::Heap2 {
            v0_1
        }
        pub fn method6() -> string {
            string("")
        }
        pub fn method7(v0_1: string) -> string {
            v0_1
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> Ui::US1 {
            Ui::US1::US1_0
        }
        pub fn method9() -> Func0<Ui::US1> {
            Func0::new(move || Ui::closure6((), ()))
        }
        pub fn method10(v0_1: rexie::Rexie) -> Ui::US2 {
            Ui::US2::US2_1(v0_1)
        }
        pub fn method11(v0_1: rexie::Rexie) -> rexie::Rexie {
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
                        let v13: Ui::US2 = Ui::method10(v10.unwrap());
                        v13
                    }
                });
                {
                    let v16: std::pin::Pin<Box<dyn std::future::Future<Output = Ui::US2>>> =
                        __future_init;
                    let v18: Ui::US2 = v16.await;
                    let v25: rexie::Rexie = Ui::method11(match &v18 {
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
        pub fn method13(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
        ) -> leptos::Resource<Ui::US1, rexie::Rexie> {
            v0_1
        }
        pub fn closure8(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Ui::US1, rexie::Rexie> = Ui::method13(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method12(
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
        pub fn method14(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn closure11(unitVar: (), v0_1: serde_json::Value) -> Ui::US5 {
            Ui::US5::US5_1(v0_1)
        }
        pub fn method15(v0_1: serde_json::Value) -> serde_json::Value {
            v0_1
        }
        pub fn method16(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn closure12(unitVar: (), v0_1: Ui::Heap3) -> Ui::US3 {
            Ui::US3::US3_1(v0_1)
        }
        pub fn method17(v0_1: Result<Ui::US3, rexie::Error>) -> Result<Ui::US3, rexie::Error> {
            v0_1
        }
        pub fn method18(v0_1: Ui::US3) -> Ui::US3 {
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
                    append(append(string("state.use_database () / core_state_data create_local_resource / database: "),
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
                        let v75: Ui::US3 = Ui::method18(match &v7 {
                            Ui::US4::US4_1(v7_1_0) => {
                                let v10: string = string("state.get_data () / id: core-state-data");
                                leptos::logging::log!("{}", &v10);
                                {
                                    let v12: rexie::Rexie = Ui::method14(v7_1_0.clone());
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
                                            let v32: Ui::US5 = defaultValue(
                                                Ui::US5::US5_0,
                                                map(
                                                    Func1::new(move |v_1: serde_json::Value| {
                                                        Ui::closure11((), v_1)
                                                    }),
                                                    serde_wasm_bindgen::from_value(v27).unwrap(),
                                                ),
                                            );
                                            let v56: Ui::US6 = match &v32 {
                                                Ui::US5::US5_1(v32_1_0) => {
                                                    let v34: serde_json::Value =
                                                        Ui::method15(v32_1_0.clone());
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
                                                        let v40: Vec<u8> = Ui::method16(v36);
                                                        let v42: Result<
                                                            Ui::Heap3,
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
                                                        Ui::US6::US6_1(defaultValue(
                                                            Ui::US3::US3_0,
                                                            map(
                                                                Func1::new(
                                                                    move |v_2: Ui::Heap3| {
                                                                        Ui::closure12((), v_2)
                                                                    },
                                                                ),
                                                                v42.ok(),
                                                            ),
                                                        ))
                                                    }
                                                }
                                                _ => Ui::US6::US6_1(Ui::US3::US3_0),
                                            };
                                            let v63: Result<Ui::US3, rexie::Error> =
                                                Ui::method17(match &v56 {
                                                    Ui::US6::US6_1(v56_1_0) => Ok(v56_1_0.clone()),
                                                    Ui::US6::US6_0(v56_0_0) => Err(v56_0_0.clone()),
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
                                                        Output = Result<Ui::US3, rexie::Error>,
                                                    >,
                                                >,
                                            > = __future_init;
                                            let v69: Result<Ui::US3, rexie::Error> = v67.await;
                                            v69.unwrap()
                                        }
                                    }
                                }
                            }
                            _ => Ui::US3::US3_0,
                        });
                        v75
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
        pub fn closure13(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
            unitVar: (),
        ) -> Option<rexie::Rexie> {
            let v1: leptos::Resource<Ui::US1, rexie::Rexie> = Ui::method13(v0_1);
            leptos::SignalGet::get(&v1)
        }
        pub fn method19(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
        ) -> Func0<Option<rexie::Rexie>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure13(v0_1.clone(), ())
            })
        }
        pub fn closure15(unitVar: (), v0_1: Ui::Heap4) -> Ui::US7 {
            Ui::US7::US7_1(v0_1)
        }
        pub fn method20(v0_1: Result<Ui::US7, rexie::Error>) -> Result<Ui::US7, rexie::Error> {
            v0_1
        }
        pub fn method21(v0_1: Ui::US7) -> Ui::US7 {
            v0_1
        }
        pub fn closure14(
            unitVar: (),
            v0_1: Option<rexie::Rexie>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Ui::US7>>> {
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
                        let v75: Ui::US7 = Ui::method21(match &v7 {
                            Ui::US4::US4_1(v7_1_0) => {
                                let v10: string = string("state.get_data () / id: state-data");
                                leptos::logging::log!("{}", &v10);
                                {
                                    let v12: rexie::Rexie = Ui::method14(v7_1_0.clone());
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
                                            let v32: Ui::US5 = defaultValue(
                                                Ui::US5::US5_0,
                                                map(
                                                    Func1::new(move |v_1: serde_json::Value| {
                                                        Ui::closure11((), v_1)
                                                    }),
                                                    serde_wasm_bindgen::from_value(v27).unwrap(),
                                                ),
                                            );
                                            let v56: Ui::US8 = match &v32 {
                                                Ui::US5::US5_1(v32_1_0) => {
                                                    let v34: serde_json::Value =
                                                        Ui::method15(v32_1_0.clone());
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
                                                        let v40: Vec<u8> = Ui::method16(v36);
                                                        let v42: Result<
                                                            Ui::Heap4,
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
                                                        Ui::US8::US8_1(defaultValue(
                                                            Ui::US7::US7_0,
                                                            map(
                                                                Func1::new(
                                                                    move |v_2: Ui::Heap4| {
                                                                        Ui::closure15((), v_2)
                                                                    },
                                                                ),
                                                                v42.ok(),
                                                            ),
                                                        ))
                                                    }
                                                }
                                                _ => Ui::US8::US8_1(Ui::US7::US7_0),
                                            };
                                            let v63: Result<Ui::US7, rexie::Error> =
                                                Ui::method20(match &v56 {
                                                    Ui::US8::US8_1(v56_1_0) => Ok(v56_1_0.clone()),
                                                    Ui::US8::US8_0(v56_0_0) => Err(v56_0_0.clone()),
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
                                                        Output = Result<Ui::US7, rexie::Error>,
                                                    >,
                                                >,
                                            > = __future_init;
                                            let v69: Result<Ui::US7, rexie::Error> = v67.await;
                                            v69.unwrap()
                                        }
                                    }
                                }
                            }
                            _ => Ui::US7::US7_0,
                        });
                        v75
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
        pub fn method23() -> web_sys::Window {
            leptos::leptos_dom::window()
        }
        pub fn method25(v0_1: web_sys::Window) -> web_sys::Window {
            v0_1
        }
        pub fn method24(
            v0_1: web_sys::Window,
        ) -> Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> {
            let v1: web_sys::Window = Ui::method25(v0_1);
            v1.local_storage()
        }
        pub fn closure17(unitVar: (), v0_1: Option<web_sys::Storage>) -> Ui::US9 {
            Ui::US9::US9_1(v0_1)
        }
        pub fn closure18(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Ui::US9 {
            Ui::US9::US9_0(v0_1)
        }
        pub fn closure19(unitVar: (), v0_1: web_sys::Storage) -> Ui::US11 {
            Ui::US11::US11_1(v0_1)
        }
        pub fn method26(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Ui::US3>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Ui::US3> {
            v0_1
        }
        pub fn closure20(unitVar: (), v0_1: Ui::US3) -> Ui::US12 {
            Ui::US12::US12_1(v0_1)
        }
        pub fn method27(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method28() -> string {
            string("core-state-data")
        }
        pub fn closure21(unitVar: (), v0_1: Option<std::string::String>) -> Ui::US13 {
            Ui::US13::US13_1(v0_1)
        }
        pub fn closure22(unitVar: (), v0_1: wasm_bindgen::JsValue) -> Ui::US13 {
            Ui::US13::US13_0(v0_1)
        }
        pub fn method29(v0_1: Option<std::string::String>) -> Option<std::string::String> {
            v0_1
        }
        pub fn closure23(unitVar: (), v0_1: std::string::String) -> Ui::US15 {
            Ui::US15::US15_1(v0_1)
        }
        pub fn method30(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method31(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method32(v0_1: leptos::RwSignal<Ui::Heap0>) -> leptos::RwSignal<Ui::Heap0> {
            v0_1
        }
        pub fn method33(v0_1: bool) -> bool {
            v0_1
        }
        pub fn method34(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn method35(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method36(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn closure16(
            v0_1: Ui::Heap2,
            v1: leptos::Resource<Option<rexie::Rexie>, Ui::US3>,
            unitVar: (),
        ) {
            leptos::logging::log!(
                "{}",
                &string("state.use_database () / effect core_state_data / ##1")
            );
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Ui::method24(Ui::method23());
                let v8: Ui::US9 = match &v5 {
                    Err(v5_1_0) => Ui::closure18((), v5_1_0.clone()),
                    Ok(v5_0_0) => Ui::closure17((), v5_0_0.clone()),
                };
                let v17: Ui::US10 = match &v8 {
                    Ui::US9::US9_1(v8_1_0) => Ui::US10::US10_1(defaultValue(
                        Ui::US11::US11_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Ui::closure19((), v_2)),
                            v8_1_0.clone(),
                        ),
                    )),
                    Ui::US9::US9_0(v8_0_0) => Ui::US10::US10_0(v8_0_0.clone()),
                };
                if let Ui::US10::US10_1(v17_1_0) = &v17 {
                    let v18: Ui::US11 = match &v17 {
                        Ui::US10::US10_1(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Ui::US11::US11_1(v18_1_0) = &v18 {
                        let v19: web_sys::Storage = match &v18 {
                            Ui::US11::US11_1(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v20: leptos::Resource<Option<rexie::Rexie>, Ui::US3> = Ui::method26(v1);
                        let v25: Ui::US12 = defaultValue(
                            Ui::US12::US12_0,
                            map(
                                Func1::new(move |v_3: Ui::US3| Ui::closure20((), v_3)),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v27: string =
                            append(append(string("state.use_database () / effect core_state_data / ##2 / core_state_data: "),
                                          sprintf!("{:?}", &v25)),
                                   string(""));
                        leptos::logging::log!("{}", &v27);
                        {
                            let v157: Ui::US3 = if let Ui::US12::US12_1(v25_1_0) = &v25 {
                                let v29: Ui::US3 = match &v25 {
                                    Ui::US12::US12_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Ui::US3::US3_1(v29_1_0) = &v29 {
                                    Ui::US3::US3_1(match &v29 {
                                        Ui::US3::US3_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    let v32: web_sys::Storage = Ui::method27(v19.clone());
                                    let v33: string = Ui::method28();
                                    let v35: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v33);
                                    let v37: Result<
                                        Option<std::string::String>,
                                        wasm_bindgen::JsValue,
                                    > = web_sys::Storage::get_item(&v32, v35);
                                    let v40: Ui::US13 = match &v37 {
                                        Err(v37_1_0) => Ui::closure22((), v37_1_0.clone()),
                                        Ok(v37_0_0) => Ui::closure21((), v37_0_0.clone()),
                                    };
                                    let v52: Ui::US14 = match &v40 {
                                        Ui::US13::US13_1(v40_1_0) => {
                                            let v42: Option<std::string::String> =
                                                Ui::method29(v40_1_0.clone());
                                            Ui::US14::US14_1(defaultValue(
                                                Ui::US15::US15_0,
                                                map(
                                                    Func1::new(move |v_6: std::string::String| {
                                                        Ui::closure23((), v_6)
                                                    }),
                                                    serde_json::from_value(v42.into()).unwrap(),
                                                ),
                                            ))
                                        }
                                        Ui::US13::US13_0(v40_0_0) => {
                                            Ui::US14::US14_0(v40_0_0.clone())
                                        }
                                    };
                                    let v58: Ui::US16 = match &v52 {
                                        Ui::US14::US14_1(v52_1_0) => {
                                            Ui::US16::US16_1(v52_1_0.clone())
                                        }
                                        _ => Ui::US16::US16_0,
                                    };
                                    let v65: Ui::US15 = if let Ui::US16::US16_1(v58_1_0) = &v58 {
                                        let v59: Ui::US15 = match &v58 {
                                            Ui::US16::US16_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if let Ui::US15::US15_1(v59_1_0) = &v59 {
                                            Ui::US15::US15_1(match &v59 {
                                                Ui::US15::US15_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        } else {
                                            Ui::US15::US15_0
                                        }
                                    } else {
                                        Ui::US15::US15_0
                                    };
                                    let v86: Ui::US12 = match &v65 {
                                        Ui::US15::US15_1(v65_1_0) => {
                                            let v68: std::string::String =
                                                Ui::method31(Ui::method30(v65_1_0.clone()));
                                            let v71: string = Ui::method7(
                                                fable_library_rust::String_::fromString(v68),
                                            );
                                            let v73: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v71);
                                            let v75: std::string::String = String::from(v73);
                                            let v77: Result<Ui::Heap3, serde_json::Error> =
                                                serde_json::from_str(&v75);
                                            Ui::US12::US12_1(defaultValue(
                                                Ui::US3::US3_0,
                                                map(
                                                    Func1::new(move |v_7: Ui::Heap3| {
                                                        Ui::closure12((), v_7)
                                                    }),
                                                    v77.ok(),
                                                ),
                                            ))
                                        }
                                        _ => Ui::US12::US12_0,
                                    };
                                    if let Ui::US12::US12_1(v86_1_0) = &v86 {
                                        let v87: Ui::US3 = match &v86 {
                                            Ui::US12::US12_1(x) => x.clone(),
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
                                let v95: web_sys::Storage = Ui::method27(v19);
                                let v96: string = Ui::method28();
                                let v98: &str = fable_library_rust::String_::LrcStr::as_str(&v96);
                                let v100: Result<
                                    Option<std::string::String>,
                                    wasm_bindgen::JsValue,
                                > = web_sys::Storage::get_item(&v95, v98);
                                let v103: Ui::US13 = match &v100 {
                                    Err(v100_1_0) => Ui::closure22((), v100_1_0.clone()),
                                    Ok(v100_0_0) => Ui::closure21((), v100_0_0.clone()),
                                };
                                let v115: Ui::US14 = match &v103 {
                                    Ui::US13::US13_1(v103_1_0) => {
                                        let v105: Option<std::string::String> =
                                            Ui::method29(v103_1_0.clone());
                                        Ui::US14::US14_1(defaultValue(
                                            Ui::US15::US15_0,
                                            map(
                                                Func1::new(move |v_10: std::string::String| {
                                                    Ui::closure23((), v_10)
                                                }),
                                                serde_json::from_value(v105.into()).unwrap(),
                                            ),
                                        ))
                                    }
                                    Ui::US13::US13_0(v103_0_0) => {
                                        Ui::US14::US14_0(v103_0_0.clone())
                                    }
                                };
                                let v121: Ui::US16 = match &v115 {
                                    Ui::US14::US14_1(v115_1_0) => {
                                        Ui::US16::US16_1(v115_1_0.clone())
                                    }
                                    _ => Ui::US16::US16_0,
                                };
                                let v128: Ui::US15 = if let Ui::US16::US16_1(v121_1_0) = &v121 {
                                    let v122: Ui::US15 = match &v121 {
                                        Ui::US16::US16_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Ui::US15::US15_1(v122_1_0) = &v122 {
                                        Ui::US15::US15_1(match &v122 {
                                            Ui::US15::US15_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    } else {
                                        Ui::US15::US15_0
                                    }
                                } else {
                                    Ui::US15::US15_0
                                };
                                let v149: Ui::US12 = match &v128 {
                                    Ui::US15::US15_1(v128_1_0) => {
                                        let v131: std::string::String =
                                            Ui::method31(Ui::method30(v128_1_0.clone()));
                                        let v134: string = Ui::method7(
                                            fable_library_rust::String_::fromString(v131),
                                        );
                                        let v136: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v134);
                                        let v138: std::string::String = String::from(v136);
                                        let v140: Result<Ui::Heap3, serde_json::Error> =
                                            serde_json::from_str(&v138);
                                        Ui::US12::US12_1(defaultValue(
                                            Ui::US3::US3_0,
                                            map(
                                                Func1::new(move |v_11: Ui::Heap3| {
                                                    Ui::closure12((), v_11)
                                                }),
                                                v140.ok(),
                                            ),
                                        ))
                                    }
                                    _ => Ui::US12::US12_0,
                                };
                                if let Ui::US12::US12_1(v149_1_0) = &v149 {
                                    let v150: Ui::US3 = match &v149 {
                                        Ui::US12::US12_1(x) => x.clone(),
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
                                append(append(string("state.use_database () / effect core_state_data / ##3 / core_state_data: "),
                                              sprintf!("{:?}", &v157)),
                                       string(""));
                            leptos::logging::log!("{}", &v159);
                            if let Ui::US3::US3_1(v157_1_0) = &v157 {
                                let v161: Ui::Heap3 = match &v157 {
                                    Ui::US3::US3_1(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v162: leptos::RwSignal<Ui::Heap0> = v0_1.l0.clone();
                                let v163: leptos::RwSignal<Ui::Heap0> = Ui::method32(v162.clone());
                                let v165: Ui::Heap0 =
                                    leptos::SignalGetUntracked::get_untracked(&v163);
                                let v168: bool = Ui::method33(v161.l0);
                                let v169: leptos::RwSignal<bool> = Ui::method34(v165.l0.clone());
                                leptos::SignalSet::set(&v169, v168);
                                {
                                    let v171: leptos::RwSignal<Ui::Heap0> = Ui::method32(v162);
                                    let v173: Ui::Heap0 =
                                        leptos::SignalGetUntracked::get_untracked(&v171);
                                    let v176: std::string::String = Ui::method35(v161.l1.clone());
                                    let v177: leptos::RwSignal<std::string::String> =
                                        Ui::method36(v173.l1.clone());
                                    leptos::SignalSet::set(&v177, v176);
                                    ()
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn method22(
            v0_1: Ui::Heap2,
            v1: leptos::Resource<Option<rexie::Rexie>, Ui::US3>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure16(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method38(
            v0_1: leptos::Resource<Option<rexie::Rexie>, Ui::US7>,
        ) -> leptos::Resource<Option<rexie::Rexie>, Ui::US7> {
            v0_1
        }
        pub fn closure25(unitVar: (), v0_1: Ui::US7) -> Ui::US17 {
            Ui::US17::US17_1(v0_1)
        }
        pub fn method39(v0_1: leptos::RwSignal<Ui::Heap1>) -> leptos::RwSignal<Ui::Heap1> {
            v0_1
        }
        pub fn closure24(
            v0_1: Ui::Heap2,
            v1: leptos::Resource<Option<rexie::Rexie>, Ui::US7>,
            unitVar: (),
        ) {
            leptos::logging::log!(
                "{}",
                &string("state.use_database () / effect state_data / ##1")
            );
            {
                let v5: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                    Ui::method24(Ui::method23());
                let v8: Ui::US9 = match &v5 {
                    Err(v5_1_0) => Ui::closure18((), v5_1_0.clone()),
                    Ok(v5_0_0) => Ui::closure17((), v5_0_0.clone()),
                };
                let v17: Ui::US10 = match &v8 {
                    Ui::US9::US9_1(v8_1_0) => Ui::US10::US10_1(defaultValue(
                        Ui::US11::US11_0,
                        map(
                            Func1::new(move |v_2: web_sys::Storage| Ui::closure19((), v_2)),
                            v8_1_0.clone(),
                        ),
                    )),
                    Ui::US9::US9_0(v8_0_0) => Ui::US10::US10_0(v8_0_0.clone()),
                };
                if let Ui::US10::US10_1(v17_1_0) = &v17 {
                    if let Ui::US11::US11_1(_) = &match &v17 {
                        Ui::US10::US10_1(x) => x.clone(),
                        _ => unreachable!(),
                    } {
                        let v20: leptos::Resource<Option<rexie::Rexie>, Ui::US7> = Ui::method38(v1);
                        let v25: Ui::US17 = defaultValue(
                            Ui::US17::US17_0,
                            map(
                                Func1::new(move |v_3: Ui::US7| Ui::closure25((), v_3)),
                                leptos::SignalGet::get(&v20),
                            ),
                        );
                        let v32: Ui::US7 = if let Ui::US17::US17_1(v25_1_0) = &v25 {
                            let v26: Ui::US7 = match &v25 {
                                Ui::US17::US17_1(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Ui::US7::US7_1(v26_1_0) = &v26 {
                                Ui::US7::US7_1(match &v26 {
                                    Ui::US7::US7_1(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            } else {
                                Ui::US7::US7_0
                            }
                        } else {
                            Ui::US7::US7_0
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
                            if let Ui::US7::US7_1(v32_1_0) = &v32 {
                                let v41: leptos::RwSignal<Ui::Heap1> =
                                    Ui::method39(v0_1.l2.clone());
                                let v43: Ui::Heap1 =
                                    leptos::SignalGetUntracked::get_untracked(&v41);
                                let v46: std::string::String = Ui::method35(
                                    (match &v32 {
                                        Ui::US7::US7_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                    .l0
                                    .clone(),
                                );
                                let v47: leptos::RwSignal<std::string::String> =
                                    Ui::method36(v43.l0.clone());
                                leptos::SignalSet::set(&v47, v46);
                                ()
                            }
                        }
                    };
                }
            }
        }
        pub fn method37(
            v0_1: Ui::Heap2,
            v1: leptos::Resource<Option<rexie::Rexie>, Ui::US7>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure24(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method41(v0_1: rexie::Rexie) -> rexie::Rexie {
            v0_1
        }
        pub fn method42(v0_1: Result<(), rexie::Error>) -> Result<(), rexie::Error> {
            v0_1
        }
        pub fn method43() {
            ();
        }
        pub fn closure26(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
            v1: Ui::Heap3,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v3: std::string::String = format!("{:?}", &v1);
            let v4: leptos::Resource<Ui::US1, rexie::Rexie> = Ui::method13(v0_1);
            let v9: Ui::US4 = defaultValue(
                Ui::US4::US4_0,
                map(
                    Func1::new(move |v: rexie::Rexie| Ui::closure10((), v)),
                    leptos::SignalGet::get(&v4),
                ),
            );
            let __future_init = Box::pin(async move {
                //;
                match &v9 {
                    Ui::US4::US4_1(v9_1_0) => {
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
                                let v18: rexie::Rexie = Ui::method41(v9_1_0.clone());
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
                                            let v30: string = Ui::method28();
                                            let v32: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v30);
                                            v23.put(&v29, Some(&v32.into())).await?;
                                            v21.done().await?;
                                            {
                                                let v36: Result<(), rexie::Error> =
                                                    Ui::method42(Ok(()));
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
                                                v41.unwrap();
                                                ()
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
                Ui::method43();
                ()
            });
            // ;
            __future_init
        }
        pub fn method40(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
        ) -> Func1<Ui::Heap3, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Ui::Heap3| Ui::closure26(v0_1.clone(), v)
            })
        }
        pub fn method45() -> string {
            string("state-data")
        }
        pub fn closure27(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
            v1: Ui::Heap4,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>> {
            let v3: std::string::String = format!("{:?}", &v1);
            let v4: leptos::Resource<Ui::US1, rexie::Rexie> = Ui::method13(v0_1);
            let v9: Ui::US4 = defaultValue(
                Ui::US4::US4_0,
                map(
                    Func1::new(move |v: rexie::Rexie| Ui::closure10((), v)),
                    leptos::SignalGet::get(&v4),
                ),
            );
            let __future_init = Box::pin(async move {
                //;
                match &v9 {
                    Ui::US4::US4_1(v9_1_0) => {
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
                                let v18: rexie::Rexie = Ui::method41(v9_1_0.clone());
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
                                            let v30: string = Ui::method45();
                                            let v32: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v30);
                                            v23.put(&v29, Some(&v32.into())).await?;
                                            v21.done().await?;
                                            {
                                                let v36: Result<(), rexie::Error> =
                                                    Ui::method42(Ok(()));
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
                                                v41.unwrap();
                                                ()
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
                Ui::method43();
                ()
            });
            // ;
            __future_init
        }
        pub fn method44(
            v0_1: leptos::Resource<Ui::US1, rexie::Rexie>,
        ) -> Func1<Ui::Heap4, std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Ui::Heap4| Ui::closure27(v0_1.clone(), v)
            })
        }
        pub fn method47(
            v0_1: leptos::RwSignal<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::RwSignal<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn closure28(
            v0_1: Ui::Heap2,
            unitVar: (),
        ) -> std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> {
            leptos::logging::log!("{}", &string("state.use_database () / loading create_memo"));
            {
                let v4: leptos::RwSignal<
                    std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                > = Ui::method47(v0_1.l1.clone());
                leptos::SignalGetUntracked::get_untracked(&v4)
            }
        }
        pub fn method46(
            v0_1: Ui::Heap2,
        ) -> Func0<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure28(v0_1.clone(), ())
            })
        }
        pub fn method48() -> bool {
            false
        }
        pub fn method50(v0_1: leptos::ReadSignal<bool>) -> leptos::ReadSignal<bool> {
            v0_1
        }
        pub fn method51(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn method52(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method53(
            v0_1: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
        ) -> leptos::Memo<std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>>
        {
            v0_1
        }
        pub fn method54() -> string {
            string("dark_mode_key")
        }
        pub fn method55(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure30(unitVar: (), v0_1: leptos::RwSignal<bool>) -> Ui::US18 {
            Ui::US18::US18_1(v0_1)
        }
        pub fn method56() -> bool {
            true
        }
        pub fn method57(v0_1: leptos::WriteSignal<bool>) -> leptos::WriteSignal<bool> {
            v0_1
        }
        pub fn method58(v0_1: Ui::Heap3) -> Ui::Heap3 {
            v0_1
        }
        pub fn method59(v0_1: web_sys::Storage) -> web_sys::Storage {
            v0_1
        }
        pub fn method60(v0_1: Ui::Heap3) -> Ui::Heap3 {
            v0_1
        }
        pub fn method61(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure29(
            v0_1: Ui::Heap2,
            v1: leptos::Action<Ui::Heap3, ()>,
            v2: leptos::Memo<
                std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
            >,
            v3: leptos::WriteSignal<bool>,
            v4: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v5: leptos::ReadSignal<bool> = Ui::method50(v4);
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
                let v10: leptos::RwSignal<Ui::Heap0> = v0_1.l0.clone();
                let v11: leptos::RwSignal<Ui::Heap0> = Ui::method32(v10.clone());
                let v15: leptos::RwSignal<bool> =
                    Ui::method51((leptos::SignalGetUntracked::get_untracked(&v11)).l0.clone());
                let v17: bool = leptos::SignalGet::get(&v15);
                let v18: leptos::RwSignal<Ui::Heap0> = Ui::method32(v10);
                let v22: leptos::RwSignal<std::string::String> =
                    Ui::method52((leptos::SignalGetUntracked::get_untracked(&v18)).l1.clone());
                let v25: Ui::Heap3 = Ui::Heap3 {
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
                    > = Ui::method53(v2);
                    let v32: std::collections::HashMap<
                        std::string::String,
                        leptos::RwSignal<bool>,
                    > = v30();
                    let v33: string = Ui::method54();
                    let v35: &str = fable_library_rust::String_::LrcStr::as_str(&v33);
                    let v38: std::string::String = Ui::method55(String::from(v35));
                    let v43: Ui::US18 = defaultValue(
                        Ui::US18::US18_0,
                        map(
                            Func1::new(move |v: leptos::RwSignal<bool>| Ui::closure30((), v)),
                            std::collections::HashMap::get(&v32, &v38).map(|x| *x),
                        ),
                    );
                    let v51: Ui::US19 = match &v43 {
                        Ui::US18::US18_1(v43_1_0) => {
                            let v45: leptos::RwSignal<bool> = Ui::method51(v43_1_0.clone());
                            Ui::US19::US19_1(leptos::SignalGet::get(&v45))
                        }
                        _ => Ui::US19::US19_0,
                    };
                    let v54: bool = match &v51 {
                        Ui::US19::US19_1(v51_1_0) => v51_1_0.clone(),
                        _ => false,
                    };
                    let v55: string =
                        append(append(string("state.use_database () / effect new_core_state_data / ##3 / dark_mode_loading: "),
                                      ofBoolean(v54)), string(""));
                    leptos::logging::log!("{}", &v55);
                    if v54 == false {
                        if v7 == false {
                            let v59: bool = Ui::method56();
                            let v60: leptos::WriteSignal<bool> = Ui::method57(v3);
                            leptos::SignalSet::set(&v60, v59);
                            ()
                        } else {
                            leptos::logging::log!(
                                "{}",
                                &string("state.use_database () / effect new_core_state_data / ##4")
                            );
                            {
                                let v65: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                                    Ui::method24(Ui::method23());
                                let v68: Ui::US9 = match &v65 {
                                    Err(v65_1_0) => Ui::closure18((), v65_1_0.clone()),
                                    Ok(v65_0_0) => Ui::closure17((), v65_0_0.clone()),
                                };
                                let v77: Ui::US10 = match &v68 {
                                    Ui::US9::US9_1(v68_1_0) => Ui::US10::US10_1(defaultValue(
                                        Ui::US11::US11_0,
                                        map(
                                            Func1::new(move |v_3: web_sys::Storage| {
                                                Ui::closure19((), v_3)
                                            }),
                                            v68_1_0.clone(),
                                        ),
                                    )),
                                    Ui::US9::US9_0(v68_0_0) => Ui::US10::US10_0(v68_0_0.clone()),
                                };
                                if let Ui::US10::US10_1(v77_1_0) = &v77 {
                                    let v78: Ui::US11 = match &v77 {
                                        Ui::US10::US10_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Ui::US11::US11_1(v78_1_0) = &v78 {
                                        let v80: Ui::Heap3 = Ui::method58(v25.clone());
                                        leptos::Action::dispatch(&v1, v80);
                                        {
                                            let v82: web_sys::Storage = Ui::method59(match &v78 {
                                                Ui::US11::US11_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            });
                                            let v83: string = Ui::method28();
                                            let v85: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v83);
                                            let v86: Ui::Heap3 = Ui::method60(v25);
                                            let v89: std::string::String =
                                                Ui::method61(serde_json::json!(v86).to_string());
                                            let v91: &str = v89.as_str();
                                            web_sys::Storage::set(&v82, v85, v91).unwrap();
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
        pub fn method49(
            v0_1: Ui::Heap2,
            v1: leptos::Action<Ui::Heap3, ()>,
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
                    Ui::closure29(
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
        pub fn method63(v0_1: Ui::Heap4) -> Ui::Heap4 {
            v0_1
        }
        pub fn closure31(
            v0_1: Ui::Heap2,
            v1: leptos::Action<Ui::Heap4, ()>,
            v2: leptos::WriteSignal<bool>,
            v3: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v4: leptos::ReadSignal<bool> = Ui::method50(v3);
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
                let v10: leptos::RwSignal<Ui::Heap1> = Ui::method39(v0_1.l2.clone());
                let v14: leptos::RwSignal<std::string::String> =
                    Ui::method52((leptos::SignalGetUntracked::get_untracked(&v10)).l0.clone());
                let v17: Ui::Heap4 = Ui::Heap4 {
                    l0: leptos::SignalGet::get(&v14),
                };
                let v20: string =
                    append(append(string("state.use_database () / effect new_state_data / ##2 / new_state_data: "),
                                  toString(format!("{:?}", &v17))),
                           string(""));
                leptos::logging::log!("{}", &v20);
                if v6 == false {
                    let v23: bool = Ui::method56();
                    let v24: leptos::WriteSignal<bool> = Ui::method57(v2);
                    leptos::SignalSet::set(&v24, v23);
                    ()
                } else {
                    leptos::logging::log!(
                        "{}",
                        &string("state.use_database () / effect new_state_data / ##4")
                    );
                    {
                        let v29: Result<Option<web_sys::Storage>, wasm_bindgen::JsValue> =
                            Ui::method24(Ui::method23());
                        let v32: Ui::US9 = match &v29 {
                            Err(v29_1_0) => Ui::closure18((), v29_1_0.clone()),
                            Ok(v29_0_0) => Ui::closure17((), v29_0_0.clone()),
                        };
                        let v41: Ui::US10 = match &v32 {
                            Ui::US9::US9_1(v32_1_0) => Ui::US10::US10_1(defaultValue(
                                Ui::US11::US11_0,
                                map(
                                    Func1::new(move |v_2: web_sys::Storage| Ui::closure19((), v_2)),
                                    v32_1_0.clone(),
                                ),
                            )),
                            Ui::US9::US9_0(v32_0_0) => Ui::US10::US10_0(v32_0_0.clone()),
                        };
                        if let Ui::US10::US10_1(v41_1_0) = &v41 {
                            if let Ui::US11::US11_1(_) = &match &v41 {
                                Ui::US10::US10_1(x) => x.clone(),
                                _ => unreachable!(),
                            } {
                                let v44: Ui::Heap4 = Ui::method63(v17);
                                leptos::Action::dispatch(&v1, v44);
                                ()
                            };
                        }
                    }
                }
            }
        }
        pub fn method62(
            v0_1: Ui::Heap2,
            v1: leptos::Action<Ui::Heap4, ()>,
            v2: leptos::WriteSignal<bool>,
            v3: leptos::ReadSignal<bool>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move || Ui::closure31(v0_1.clone(), v1.clone(), v2.clone(), v3.clone(), ())
            })
        }
        pub fn closure32(v0_1: Ui::Heap2, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<Ui::Heap0> = Ui::method32(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Ui::method51((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method64(v0_1: Ui::Heap2) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure32(v0_1.clone(), ())
            })
        }
        pub fn method66(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method67(
            v0_1: leptos::Memo<std::string::String>,
        ) -> leptos::Memo<std::string::String> {
            v0_1
        }
        pub fn method68(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method69() -> Ui::US20 {
            Ui::US20::US20_0
        }
        pub fn method71(v0_1: leptos_router::Location) -> leptos_router::Location {
            v0_1
        }
        pub fn method72(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn closure34(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: Ui::Heap2,
            v4: leptos::WriteSignal<bool>,
            v5: leptos::ReadSignal<bool>,
            unitVar: (),
        ) {
            let v6: leptos::ReadSignal<bool> = Ui::method50(v5);
            let v8: bool = leptos::SignalGet::get(&v6);
            let v9: leptos_router::Location = Ui::method71(v0_1);
            let v12: leptos::Memo<std::string::String> = Ui::method67(v9.hash);
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
                let v19: std::string::String = Ui::method72(v14);
                if v19 == "" {
                    let v23: leptos::RwSignal<Ui::Heap0> = Ui::method32(v3.l0.clone());
                    let v27: leptos::RwSignal<std::string::String> =
                        Ui::method52((leptos::SignalGetUntracked::get_untracked(&v23)).l1.clone());
                    let v30: std::string::String = Ui::method31(leptos::SignalGet::get(&v27));
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
                        let v37: string = Ui::method7(v32);
                        let v39: &str = fable_library_rust::String_::LrcStr::as_str(&v37);
                        v1(v39, Default::default());
                        ()
                    }
                }
                {
                    let v41: bool = Ui::method56();
                    let v42: leptos::WriteSignal<bool> = Ui::method57(v4);
                    leptos::SignalSet::set(&v42, v41);
                    ()
                }
            } else {
                let v45: leptos::RwSignal<Ui::Heap0> = Ui::method32(v3.l0.clone());
                let v47: Ui::Heap0 = leptos::SignalGetUntracked::get_untracked(&v45);
                let v49: string = Ui::method7(v15);
                let v51: &str = fable_library_rust::String_::LrcStr::as_str(&v49);
                let v54: std::string::String = Ui::method35(String::from(v51));
                let v55: leptos::RwSignal<std::string::String> = Ui::method36(v47.l1.clone());
                leptos::SignalSet::set(&v55, v54);
                ()
            }
        }
        pub fn method70(
            v0_1: leptos_router::Location,
            v1: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)>,
            v2: string,
            v3: Ui::Heap2,
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
                    Ui::closure34(
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
        pub fn method74(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method75(v0_1: &str) -> &str {
            v0_1
        }
        pub fn method76() -> string {
            string("/settings")
        }
        pub fn method77(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method78(v0_1: Ui::US20) -> Ui::US20 {
            v0_1
        }
        pub fn method79(v0_1: leptos::WriteSignal<Ui::US20>) -> leptos::WriteSignal<Ui::US20> {
            v0_1
        }
        pub fn closure35(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Ui::US20>,
            unitVar: (),
        ) {
            let v2: leptos_router::Location = Ui::method71(v0_1);
            let v5: leptos::Memo<std::string::String> = Ui::method67(v2.hash);
            let v8: std::string::String = Ui::method74(v5());
            let v10: Option<&str> = v8.strip_prefix('#');
            let v12: string = string("r#\"\"#");
            let v13: &str = r#""#;
            let v16: &str = Ui::method75(v10.unwrap_or(v13));
            let v18: Result<leptos_router::Url, std::string::String> =
                leptos_router::Url::try_from(v16);
            let v20: leptos_router::Url = v18.unwrap();
            let v23: string = append(
                append(
                    string("content.render () / effect 2 / hash_url: "),
                    toString(format!("{:#?}", &v20)),
                ),
                string(""),
            );
            leptos::logging::log!("{}", &v23);
            {
                let v26: std::string::String = v20.pathname;
                let v27: string = Ui::method76();
                let v29: &str = fable_library_rust::String_::LrcStr::as_str(&v27);
                let v31: std::string::String = String::from(v29);
                let v32: std::string::String = Ui::method77(v26);
                let v37: Ui::US20 = if v32.starts_with(&v31) {
                    Ui::US20::US20_1
                } else {
                    Ui::US20::US20_0
                };
                let v40: string = append(
                    append(
                        string("content.render () / effect 2 / new_tab: "),
                        toString(format!("{:#?}", &v37)),
                    ),
                    string(""),
                );
                leptos::logging::log!("{}", &v40);
                {
                    let v42: Ui::US20 = Ui::method78(v37);
                    let v43: leptos::WriteSignal<Ui::US20> = Ui::method79(v1);
                    leptos::SignalSet::set(&v43, v42);
                    ()
                }
            }
        }
        pub fn method73(
            v0_1: leptos_router::Location,
            v1: leptos::WriteSignal<Ui::US20>,
        ) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure35(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure37(
            v0_1: leptos::ReadSignal<Ui::US20>,
            unitVar: (),
        ) -> leptos::ReadSignal<Ui::US20> {
            v0_1
        }
        pub fn method81(v0_1: leptos::ReadSignal<Ui::US20>) -> Func0<leptos::ReadSignal<Ui::US20>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure37(v0_1.clone(), ())
            })
        }
        pub fn method83(v0_1: leptos::ReadSignal<Ui::US20>) -> leptos::ReadSignal<Ui::US20> {
            v0_1
        }
        pub fn method84() -> string {
            string("")
        }
        pub fn method85() -> string {
            string("View")
        }
        pub fn method89() -> string {
            string("Dark Mode")
        }
        pub fn closure43(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method91() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Ui::closure43((), v))
        }
        pub fn method92(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure42(v0_1: Ui::Heap2, v1: leptos::ev::Event) {
            let v3: leptos::RwSignal<Ui::Heap0> = Ui::method32(v0_1.l0.clone());
            let v5: Ui::Heap0 = leptos::SignalGetUntracked::get_untracked(&v3);
            let v7 = Ui::method91();
            let v8: leptos::RwSignal<bool> = Ui::method92(v5.l0.clone());
            leptos::SignalUpdate::update(&v8, |x| *x = v7(*x));
            ()
        }
        pub fn method90(v0_1: Ui::Heap2) -> Func1<leptos::ev::Event, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::Event| Ui::closure42(v0_1.clone(), v)
            })
        }
        pub fn closure44(v0_1: Ui::Heap2, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<Ui::Heap0> = Ui::method32(v0_1.l0.clone());
            let v6: leptos::RwSignal<bool> =
                Ui::method51((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            leptos::SignalGet::get(&v6)
        }
        pub fn method93(v0_1: Ui::Heap2) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure44(v0_1.clone(), ())
            })
        }
        pub fn method94(
            v0_1: leptos::HtmlElement<leptos::html::Label>,
        ) -> leptos::HtmlElement<leptos::html::Label> {
            v0_1
        }
        pub fn method95(v0_1: leptos::Fragment) -> leptos::Fragment {
            v0_1
        }
        pub fn method96(v0_1: leptos::Fragment) -> leptos::Fragment {
            v0_1
        }
        pub fn closure46(v0_1: leptos::Fragment, unitVar: ()) -> leptos::Fragment {
            v0_1
        }
        pub fn method98(v0_1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure46(v0_1.clone(), ())
            })
        }
        pub fn method99(
            v0_1: leptos::HtmlElement<leptos::html::Dt>,
        ) -> leptos::HtmlElement<leptos::html::Dt> {
            v0_1
        }
        pub fn closure47(v0_1: leptos::Fragment, unitVar: ()) -> leptos::Fragment {
            v0_1
        }
        pub fn method100(v0_1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure47(v0_1.clone(), ())
            })
        }
        pub fn method101(
            v0_1: leptos::HtmlElement<leptos::html::Dd>,
        ) -> leptos::HtmlElement<leptos::html::Dd> {
            v0_1
        }
        pub fn method102(v0_1: Array<leptos::View>) -> Array<leptos::View> {
            v0_1
        }
        pub fn closure45(
            v0_1: leptos::Fragment,
            v1: leptos::Fragment,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(" class=\"font-medium text-gray-700\"");
            let v5 = Ui::method98(v0_1);
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
                Ui::method99(leptos::view! { <dt  class="font-medium text-gray-700">{v5()}</dt> });
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            let v15: string = string(" class=\"text-gray-700 md:col-span-2 flex flex-1\"");
            let v16 = Ui::method100(v1);
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
            let v22: leptos::HtmlElement<leptos::html::Dd> = Ui::method101(
                leptos::view! { <dd  class="text-gray-700 md:col-span-2 flex flex-1">{v16()}</dd> },
            );
            let v26: Array<leptos::View> =
                Ui::method102(new_array(&[v13, leptos::IntoView::into_view(v22)]));
            leptos::Fragment::new(v26.to_vec())
        }
        pub fn method97(v0_1: leptos::Fragment, v1: leptos::Fragment) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure45(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method103(
            v0_1: leptos::HtmlElement<leptos::html::Div>,
        ) -> leptos::HtmlElement<leptos::html::Div> {
            v0_1
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Ui::method7(Ui::method89());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            let v12: leptos::Fragment = leptos::Fragment::new(vec![v10]);
            leptos::logging::log!("{}", &string("dark_mode_toggle.render ()"));
            {
                let v16: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
                let v18: Ui::Heap2 = v16.unwrap();
                let v19 = Ui::method90(v18.clone());
                let v20 = Ui::method93(v18);
                let v22: string = Ui::method7(string("v19"));
                let v24: &str = fable_library_rust::String_::LrcStr::as_str(&v22);
                let v26: std::string::String = String::from(v24);
                let v27: string =
                    string("<label for={v26.clone()} class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\"><input type=\"checkbox\" id={v26} class=\"peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden\" on:change=move |event| v19(event) prop:checked={move || v20()} /><span class=\"absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-gray-200\"><svg data-unchecked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg><svg data-checked-icon xmlns=\"http://www.w3.org/2000/svg\" class=\"hidden h-4 w-4\" viewBox=\"0 0 20 20\" fill=\"currentColor\"> <path fill-rule=\"evenodd\" d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\" clip-rule=\"evenodd\" /></svg></span><span class=\"absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-gray-200\"></span></label>");
                let v28: string = append(append(string("leptos::view! { "), v27), string(" }"));
                let v31: leptos::HtmlElement<leptos::html::Label> = Ui::method94(
                    leptos::view! { <label for={v26.clone()} class="block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]"><input type="checkbox" id={v26} class="peer sr-only [&:checked_+_span_svg[data-checked-icon]]:block [&:checked_+_span_svg[data-unchecked-icon]]:hidden" on:change=move |event| v19(event) prop:checked={move || v20()} /><span class="absolute inset-y-0 start-0 z-10 m-1 inline-flex h-6 w-6 items-center justify-center rounded-full bg-white text-gray-400 transition-all peer-checked:start-6 peer-checked:text-gray-200"><svg data-unchecked-icon xmlns="http://www.w3.org/2000/svg" class="h-4 w-4" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z" clip-rule="evenodd" /></svg><svg data-checked-icon xmlns="http://www.w3.org/2000/svg" class="hidden h-4 w-4" viewBox="0 0 20 20" fill="currentColor"> <path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" /></svg></span><span class="absolute inset-0 rounded-full bg-gray-300 transition peer-checked:bg-gray-200"></span></label> },
                );
                let v33: leptos::View = leptos::IntoView::into_view(v31);
                let v35: leptos::Fragment = leptos::Fragment::new(vec![v33]);
                let v40: string =
                    string(" class=\"grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-center\"");
                let v41 = Ui::method97(Ui::method95(v12), Ui::method96(v35));
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
                let v47: leptos::HtmlElement<leptos::html::Div> = Ui::method103(
                    leptos::view! { <div  class="grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-center">{v41()}</div> },
                );
                let v49: leptos::View = leptos::IntoView::into_view(v47);
                leptos::Fragment::new(vec![v49])
            }
        }
        pub fn method88() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure41((), ()))
        }
        pub fn method104(
            v0_1: leptos::HtmlElement<leptos::html::Dl>,
        ) -> leptos::HtmlElement<leptos::html::Dl> {
            v0_1
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string(" class=\"flex flex-1 divide-y divide-gray-100 text-sm\"");
            let v3 = Ui::method88();
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
            let v9: leptos::HtmlElement<leptos::html::Dl> = Ui::method104(
                leptos::view! { <dl  class="flex flex-1 divide-y divide-gray-100 text-sm">{v3()}</dl> },
            );
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method87() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure40((), ()))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string(" class=\"flow-root\"");
            let v3 = Ui::method87();
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
                Ui::method103(leptos::view! { <div  class="flow-root">{v3()}</div> });
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method86() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure39((), ()))
        }
        pub fn method105(
            v0_1: leptos::HtmlElement<leptos::html::Details>,
        ) -> leptos::HtmlElement<leptos::html::Details> {
            v0_1
        }
        pub fn method106() -> string {
            string("Connection")
        }
        pub fn method110() -> string {
            string("Explorer Backend Host")
        }
        pub fn method112(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method113(
            v0_1: leptos::ReadSignal<std::string::String>,
        ) -> leptos::ReadSignal<std::string::String> {
            v0_1
        }
        pub fn closure51(v0_1: Ui::Heap2, unitVar: ()) -> std::string::String {
            let v2: leptos::RwSignal<Ui::Heap1> = Ui::method39(v0_1.l2.clone());
            let v6: leptos::RwSignal<std::string::String> =
                Ui::method112((leptos::SignalGetUntracked::get_untracked(&v2)).l0.clone());
            let v9: leptos::ReadSignal<std::string::String> =
                Ui::method113(leptos::RwSignal::read_only(&v6));
            leptos::SignalGet::get(&v9)
        }
        pub fn method111(v0_1: Ui::Heap2) -> Func0<std::string::String> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure51(v0_1.clone(), ())
            })
        }
        pub fn method115(
            v0_1: leptos::RwSignal<std::string::String>,
        ) -> leptos::RwSignal<std::string::String> {
            v0_1
        }
        pub fn method116(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method117(
            v0_1: leptos::WriteSignal<std::string::String>,
        ) -> leptos::WriteSignal<std::string::String> {
            v0_1
        }
        pub fn closure52(v0_1: Ui::Heap2, v1: std::string::String) {
            let v3: leptos::RwSignal<Ui::Heap1> = Ui::method39(v0_1.l2.clone());
            let v7: leptos::RwSignal<std::string::String> =
                Ui::method115((leptos::SignalGetUntracked::get_untracked(&v3)).l0.clone());
            let v9: leptos::WriteSignal<std::string::String> = leptos::RwSignal::write_only(&v7);
            let v10: std::string::String = Ui::method116(v1);
            let v11: leptos::WriteSignal<std::string::String> = Ui::method117(v9);
            leptos::SignalSet::set(&v11, v10);
            ()
        }
        pub fn method114(v0_1: Ui::Heap2) -> Func1<std::string::String, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: std::string::String| Ui::closure52(v0_1.clone(), v)
            })
        }
        pub fn method118(
            v0_1: leptos::HtmlElement<leptos::html::Input>,
        ) -> leptos::HtmlElement<leptos::html::Input> {
            v0_1
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = Ui::method7(Ui::method110());
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: leptos::leptos_dom::Text = leptos::html::text(v6);
            let v10: leptos::View = leptos::IntoView::into_view(v8);
            let v12: leptos::Fragment = leptos::Fragment::new(vec![v10]);
            let v14: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
            let v16: Ui::Heap2 = v14.unwrap();
            let v17 = Ui::method111(v16.clone());
            let v18 = Ui::method114(v16);
            let v28: string =
                string("leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v18(leptos::event_target_value(&event)) prop:value=move || v17() class=\"bg-gray-50 flex-1 h-[27px]\" /> }");
            let v31: leptos::HtmlElement<leptos::html::Input> = Ui::method118(
                leptos::view! { <input  on:keyup=move |event: web_sys::KeyboardEvent| v18(leptos::event_target_value(&event)) prop:value=move || v17() class="bg-gray-50 flex-1 h-[27px]" /> },
            );
            let v33: leptos::View = leptos::IntoView::into_view(v31);
            let v35: leptos::Fragment = leptos::Fragment::new(vec![v33]);
            let v39: string =
                string(" class=\"grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-baseline\"");
            let v40 = Ui::method97(Ui::method95(v12), Ui::method96(v35));
            let v43: string = append(
                append(
                    string("leptos::view! { "),
                    append(
                        append(
                            append(append(string("<div "), v39), string(">{v40()}</")),
                            string("div"),
                        ),
                        string(">"),
                    ),
                ),
                string(" }"),
            );
            let v46: leptos::HtmlElement<leptos::html::Div> = Ui::method103(
                leptos::view! { <div  class="grid gap-1 md:gap-4 flex-1 even:bg-gray-50 md:grid-cols-[150px_repeat(2,minmax(0,1fr))] [inline-size:max-content] mt-[10px] mr-[14px] mb-[11px] ml-[12px] items-baseline">{v40()}</div> },
            );
            let v48: leptos::View = leptos::IntoView::into_view(v46);
            leptos::Fragment::new(vec![v48])
        }
        pub fn method109() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure50((), ()))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string(" class=\"flex flex-1 divide-y divide-gray-100 text-sm\"");
            let v3 = Ui::method109();
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
            let v9: leptos::HtmlElement<leptos::html::Dl> = Ui::method104(
                leptos::view! { <dl  class="flex flex-1 divide-y divide-gray-100 text-sm">{v3()}</dl> },
            );
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method108() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure49((), ()))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v2: string = string(" class=\"flow-root\"");
            let v3 = Ui::method108();
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
                Ui::method103(leptos::view! { <div  class="flow-root">{v3()}</div> });
            let v11: leptos::View = leptos::IntoView::into_view(v9);
            leptos::Fragment::new(vec![v11])
        }
        pub fn method107() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure48((), ()))
        }
        pub fn method119() -> string {
            string("Global State")
        }
        pub fn method122(v0_1: Ui::Heap2) -> Ui::Heap2 {
            v0_1
        }
        pub fn closure55(unitVar: (), v0_1: std::string::String) -> Ui::US21 {
            Ui::US21::US21_1(v0_1)
        }
        pub fn closure56(unitVar: (), v0_1: std::string::String) -> Ui::US21 {
            Ui::US21::US21_0(v0_1)
        }
        pub fn closure54(v0_1: Ui::Heap2, unitVar: ()) -> string {
            leptos::logging::log!(
                "{}",
                &string("settings.global_state_log_render () / global_state_json memo")
            );
            {
                let v3: Ui::Heap2 = Ui::method122(v0_1);
                let v5: Result<std::string::String, std::string::String> =
                    serde_json::to_string_pretty(&v3).map_err(|x| x.to_string());
                let v8: Ui::US21 = match &v5 {
                    Err(v5_1_0) => Ui::closure56((), v5_1_0.clone()),
                    Ok(v5_0_0) => Ui::closure55((), v5_0_0.clone()),
                };
                match &v8 {
                    Ui::US21::US21_1(v8_1_0) => {
                        let v10: std::string::String = Ui::method31(v8_1_0.clone());
                        fable_library_rust::String_::fromString(v10)
                    }
                    Ui::US21::US21_0(v8_0_0) => append(
                        append(string("Error: "), toString(v8_0_0.clone())),
                        string(""),
                    ),
                }
            }
        }
        pub fn method121(v0_1: Ui::Heap2) -> Func0<string> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure54(v0_1.clone(), ())
            })
        }
        pub fn closure58(v0_1: leptos::Memo<string>, unitVar: ()) -> leptos::Memo<string> {
            v0_1
        }
        pub fn method124(v0_1: leptos::Memo<string>) -> Func0<leptos::Memo<string>> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure58(v0_1.clone(), ())
            })
        }
        pub fn method126(v0_1: leptos::Memo<string>) -> leptos::Memo<string> {
            v0_1
        }
        pub fn method127(v0_1: string) -> string {
            v0_1
        }
        pub fn closure59(v0_1: leptos::Memo<string>, v1: leptos::Memo<string>) -> leptos::Fragment {
            let v2: leptos::Memo<string> = Ui::method126(v0_1);
            let v6: string = Ui::method7(Ui::method127(v2()));
            let v8: &str = fable_library_rust::String_::LrcStr::as_str(&v6);
            let v10: std::string::String = String::from(v8);
            let v12: leptos::leptos_dom::Text = leptos::html::text(v10);
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            leptos::Fragment::new(vec![v14])
        }
        pub fn method125(
            v0_1: leptos::Memo<string>,
        ) -> Func1<leptos::Memo<string>, leptos::Fragment> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::Memo<string>| Ui::closure59(v0_1.clone(), v)
            })
        }
        pub fn closure57(v0_1: leptos::Memo<string>, unitVar: ()) -> leptos::Fragment {
            let v1 = Ui::method124(v0_1.clone());
            let v2 = Ui::method125(v0_1);
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
        pub fn method123(v0_1: leptos::Memo<string>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure57(v0_1.clone(), ())
            })
        }
        pub fn method128(
            v0_1: leptos::HtmlElement<leptos::html::Pre>,
        ) -> leptos::HtmlElement<leptos::html::Pre> {
            v0_1
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("settings.global_state_log_render ()"));
            {
                let v3: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
                let v6 = Ui::method121(v3.unwrap());
                let v11: string =
                    string(" class=\"[padding:7px] [font-size:11px] [line-height:11px]\"");
                let v12 = Ui::method123(leptos::create_memo(move |_| v6()));
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
                let v18: leptos::HtmlElement<leptos::html::Pre> = Ui::method128(
                    leptos::view! { <pre  class="[padding:7px] [font-size:11px] [line-height:11px]">{v12()}</pre> },
                );
                let v20: leptos::View = leptos::IntoView::into_view(v18);
                leptos::Fragment::new(vec![v20])
            }
        }
        pub fn method120() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure53((), ()))
        }
        pub fn closure38(unitVar: (), v0_1: leptos::ReadSignal<Ui::US20>) -> leptos::View {
            let v1: leptos::ReadSignal<Ui::US20> = Ui::method83(v0_1);
            let v3: Ui::US20 = leptos::SignalGet::get(&v1);
            match &v3 {
                Ui::US20::US20_1 => {
                    let v15: string = Ui::method7(Ui::method85());
                    let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
                    let v19: std::string::String = String::from(v17);
                    let v20 = Ui::method86();
                    let v21: string =
                        string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v19}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\"><svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg></span></summary>{v20()}</details>");
                    let v22: string = append(append(string("leptos::view! { "), v21), string(" }"));
                    let v25: leptos::HtmlElement<leptos::html::Details> = Ui::method105(
                        leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v19}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180"><svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg></span></summary>{v20()}</details> },
                    );
                    let v27: leptos::View = leptos::IntoView::into_view(v25);
                    let v29: string = Ui::method7(Ui::method106());
                    let v31: &str = fable_library_rust::String_::LrcStr::as_str(&v29);
                    let v33: std::string::String = String::from(v31);
                    let v34 = Ui::method107();
                    let v35: string =
                        string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v33}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\"><svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg></span></summary>{v34()}</details>");
                    let v36: string = append(append(string("leptos::view! { "), v35), string(" }"));
                    let v39: leptos::HtmlElement<leptos::html::Details> = Ui::method105(
                        leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v33}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180"><svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg></span></summary>{v34()}</details> },
                    );
                    let v41: leptos::View = leptos::IntoView::into_view(v39);
                    let v43: string = Ui::method7(Ui::method119());
                    let v45: &str = fable_library_rust::String_::LrcStr::as_str(&v43);
                    let v47: std::string::String = String::from(v45);
                    let v48 = Ui::method120();
                    let v49: string =
                        string("<details class=\"flex group [&_summary::-webkit-details-marker]:hidden\" open><summary class=\"group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700\"><div class=\"flex items-center gap-2\"><span class=\"text-sm font-medium\">{v47}</span></div><span class=\"shrink-0 transition duration-300 group-open:-rotate-180\"><svg xmlns=\"http://www.w3.org/2000/svg\" class=\"h-5 w-5\" viewBox=\"0 0 20 20\" fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\" clip-rule=\"evenodd\" /></svg></span></summary>{v48()}</details>");
                    let v50: string = append(append(string("leptos::view! { "), v49), string(" }"));
                    let v53: leptos::HtmlElement<leptos::html::Details> = Ui::method105(
                        leptos::view! { <details class="flex group [&_summary::-webkit-details-marker]:hidden" open><summary class="group flex items-center justify-between px-4 py-2 cursor-pointer text-gray-500 bg-gray-100 hover:bg-gray-200 hover:text-gray-700"><div class="flex items-center gap-2"><span class="text-sm font-medium">{v47}</span></div><span class="shrink-0 transition duration-300 group-open:-rotate-180"><svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor"><path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" /></svg></span></summary>{v48()}</details> },
                    );
                    let v57: Array<leptos::View> =
                        Ui::method102(new_array(&[v27, v41, leptos::IntoView::into_view(v53)]));
                    let v59: leptos::Fragment = leptos::Fragment::new(v57.to_vec());
                    leptos::IntoView::into_view(v59)
                }
                _ => {
                    let v5: string = Ui::method7(Ui::method84());
                    let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
                    let v9: std::string::String = String::from(v7);
                    let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
                    leptos::IntoView::into_view(v11)
                }
            }
        }
        pub fn method82() -> Func1<leptos::ReadSignal<Ui::US20>, leptos::View> {
            Func1::new(move |v: leptos::ReadSignal<Ui::US20>| Ui::closure38((), v))
        }
        pub fn method133() -> string {
            string("Tab")
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Ui::method7(Ui::method133());
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1);
            let v5: std::string::String = String::from(v3);
            let v7: leptos::leptos_dom::Text = leptos::html::text(v5);
            let v9: leptos::View = leptos::IntoView::into_view(v7);
            leptos::Fragment::new(vec![v9])
        }
        pub fn method132() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure63((), ()))
        }
        pub fn closure65(v0_1: leptos::ReadSignal<Ui::US20>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Ui::US20> = Ui::method83(v0_1);
            if let Ui::US20::US20_0 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method135(v0_1: leptos::ReadSignal<Ui::US20>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure65(v0_1.clone(), ())
            })
        }
        pub fn method137() -> string {
            string("History")
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Ui::method7(Ui::method137());
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1);
            let v5: std::string::String = String::from(v3);
            let v7: leptos::leptos_dom::Text = leptos::html::text(v5);
            let v9: leptos::View = leptos::IntoView::into_view(v7);
            leptos::Fragment::new(vec![v9])
        }
        pub fn method136() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure66((), ()))
        }
        pub fn method138(
            v0_1: leptos::HtmlElement<leptos::html::Option_>,
        ) -> leptos::HtmlElement<leptos::html::Option_> {
            v0_1
        }
        pub fn closure67(v0_1: leptos::ReadSignal<Ui::US20>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Ui::US20> = Ui::method83(v0_1);
            if let Ui::US20::US20_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method139(v0_1: leptos::ReadSignal<Ui::US20>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure67(v0_1.clone(), ())
            })
        }
        pub fn method141() -> string {
            string("Settings")
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Ui::method7(Ui::method141());
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1);
            let v5: std::string::String = String::from(v3);
            let v7: leptos::leptos_dom::Text = leptos::html::text(v5);
            let v9: leptos::View = leptos::IntoView::into_view(v7);
            leptos::Fragment::new(vec![v9])
        }
        pub fn method140() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure68((), ()))
        }
        pub fn closure64(v0_1: leptos::ReadSignal<Ui::US20>, unitVar: ()) -> leptos::Fragment {
            let v1 = Ui::method135(v0_1.clone());
            let v4: string = string(" select=v1()");
            let v5 = Ui::method136();
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
                Ui::method138(leptos::view! { <option  select=v1()>{v5()}</option> });
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            let v14 = Ui::method139(v0_1);
            let v16: string = string(" select=v14()");
            let v17 = Ui::method140();
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
                Ui::method138(leptos::view! { <option  select=v14()>{v17()}</option> });
            let v26: Array<leptos::View> =
                Ui::method102(new_array(&[v13, leptos::IntoView::into_view(v22)]));
            leptos::Fragment::new(v26.to_vec())
        }
        pub fn method134(v0_1: leptos::ReadSignal<Ui::US20>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure64(v0_1.clone(), ())
            })
        }
        pub fn method142(
            v0_1: leptos::HtmlElement<leptos::html::Select>,
        ) -> leptos::HtmlElement<leptos::html::Select> {
            v0_1
        }
        pub fn closure62(v0_1: leptos::ReadSignal<Ui::US20>, unitVar: ()) -> leptos::Fragment {
            let v5: string = string(" class=\"sr-only\" for=\"Tab\"");
            let v6 = Ui::method132();
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
                Ui::method94(leptos::view! { <label  class="sr-only" for="Tab">{v6()}</label> });
            let v14: leptos::View = leptos::IntoView::into_view(v12);
            let v18: string = string(" class=\"w-full rounded-md border-gray-200\" id=\"Tab\"");
            let v19 = Ui::method134(v0_1);
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
            let v25: leptos::HtmlElement<leptos::html::Select> = Ui::method142(
                leptos::view! { <select  class="w-full rounded-md border-gray-200" id="Tab">{v19()}</select> },
            );
            let v29: Array<leptos::View> =
                Ui::method102(new_array(&[v14, leptos::IntoView::into_view(v25)]));
            leptos::Fragment::new(v29.to_vec())
        }
        pub fn method131(v0_1: leptos::ReadSignal<Ui::US20>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure62(v0_1.clone(), ())
            })
        }
        pub fn closure72(v0_1: leptos::ReadSignal<Ui::US20>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Ui::US20> = Ui::method83(v0_1);
            if let Ui::US20::US20_0 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method146(v0_1: leptos::ReadSignal<Ui::US20>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure72(v0_1.clone(), ())
            })
        }
        pub fn method147(v0_1: Func0<bool>) -> Func0<bool> {
            v0_1
        }
        pub fn closure73(v0_1: Func0<bool>, unitVar: ()) -> &'static str {
            if v0_1() {
                let v3: string = string("r#\"border-grey-200 text-grey-900\"#");
                r#"border-grey-200 text-grey-900"#
            } else {
                let v6: string =
                    string("r#\"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700\"#");
                r#"border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700"#
            }
        }
        pub fn method148(v0_1: Func0<bool>) -> Func0<&'static str> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure73(v0_1.clone(), ())
            })
        }
        pub fn method150(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
        ) -> leptos::HtmlElement<leptos::svg::Svg> {
            v0_1
        }
        pub fn closure74(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Ui::method150(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v5: string = Ui::method7(Ui::method137());
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v15: Array<leptos::View> =
                Ui::method102(new_array(&[v3, leptos::IntoView::into_view(v11)]));
            leptos::Fragment::new(v15.to_vec())
        }
        pub fn method149(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure74(v0_1.clone(), ())
            })
        }
        pub fn method151(
            v0_1: leptos::HtmlElement<leptos::html::A>,
        ) -> leptos::HtmlElement<leptos::html::A> {
            v0_1
        }
        pub fn closure75(v0_1: leptos::ReadSignal<Ui::US20>, unitVar: ()) -> bool {
            let v1: leptos::ReadSignal<Ui::US20> = Ui::method83(v0_1);
            if let Ui::US20::US20_1 = &leptos::SignalGet::get(&v1) {
                true
            } else {
                false
            }
        }
        pub fn method152(v0_1: leptos::ReadSignal<Ui::US20>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure75(v0_1.clone(), ())
            })
        }
        pub fn closure76(
            v0_1: leptos::HtmlElement<leptos::svg::Svg>,
            unitVar: (),
        ) -> leptos::Fragment {
            let v1: leptos::HtmlElement<leptos::svg::Svg> = Ui::method150(v0_1);
            let v3: leptos::View = leptos::IntoView::into_view(v1);
            let v5: string = Ui::method7(Ui::method141());
            let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
            let v9: std::string::String = String::from(v7);
            let v11: leptos::leptos_dom::Text = leptos::html::text(v9);
            let v15: Array<leptos::View> =
                Ui::method102(new_array(&[v3, leptos::IntoView::into_view(v11)]));
            leptos::Fragment::new(v15.to_vec())
        }
        pub fn method153(v0_1: leptos::HtmlElement<leptos::svg::Svg>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure76(v0_1.clone(), ())
            })
        }
        pub fn closure71(
            v0_1: leptos::ReadSignal<Ui::US20>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v2: string = append(v1.clone(), string("#/history"));
            let v3: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z\"/></svg>");
            let v4: string = append(append(string("leptos::view! { "), v3), string(" }"));
            let v6: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="h-5 w-5"><path stroke-linecap="round" stroke-linejoin="round" d="M2.25 13.5h3.86a2.25 2.25 0 012.012 1.244l.256.512a2.25 2.25 0 002.013 1.244h3.218a2.25 2.25 0 002.013-1.244l.256-.512a2.25 2.25 0 012.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 002.25 2.25h15A2.25 2.25 0 0021.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 00-2.15-1.588H6.911a2.25 2.25 0 00-2.15 1.588L2.35 13.177a2.25 2.25 0 00-.1.661z"/></svg> };
            let v7: string = Ui::method7(v2);
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v12 = Ui::method146(v0_1.clone());
            let v13 = Ui::method147(v12.clone());
            let v14 = Ui::method148(v12);
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
            let v22 = Ui::method149(v6);
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
            let v28: leptos::HtmlElement<leptos::html::A> = Ui::method151(
                leptos::view! { <a  aria-current={move || if v13() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] pt-[8px] pr-[10px] pb-[11px] pl-[10px] text-sm font-medium ".to_owned() + v14()} href=v11>{v22()}</a> },
            );
            let v30: leptos::View = leptos::IntoView::into_view(v28);
            let v31: string = append(v1, string("#/settings"));
            let v32: string =
                string("<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"h-5 w-5\"><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\"/><path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M15 12a3 3 0 11-6 0 3 3 0 016 0z\"/></svg>");
            let v33: string = append(append(string("leptos::view! { "), v32), string(" }"));
            let v35: leptos::HtmlElement<leptos::svg::Svg> = leptos::view! { <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="h-5 w-5"><path stroke-linecap="round" stroke-linejoin="round" d="M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z"/><path stroke-linecap="round" stroke-linejoin="round" d="M15 12a3 3 0 11-6 0 3 3 0 016 0z"/></svg> };
            let v36: string = Ui::method7(v31);
            let v38: &str = fable_library_rust::String_::LrcStr::as_str(&v36);
            let v40: std::string::String = String::from(v38);
            let v41 = Ui::method152(v0_1);
            let v42 = Ui::method147(v41.clone());
            let v43 = Ui::method148(v41);
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
            let v50 = Ui::method153(v35);
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
            let v55: leptos::HtmlElement<leptos::html::A> = Ui::method151(
                leptos::view! { <a  aria-current={move || if v42() { "page" } else { "" }} class={move || "inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] pt-[8px] pr-[10px] pb-[11px] pl-[10px] text-sm font-medium ".to_owned() + v43()} href=v40>{v50()}</a> },
            );
            let v59: Array<leptos::View> =
                Ui::method102(new_array(&[v30, leptos::IntoView::into_view(v55)]));
            leptos::Fragment::new(v59.to_vec())
        }
        pub fn method145(
            v0_1: leptos::ReadSignal<Ui::US20>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure71(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn method154(
            v0_1: leptos::HtmlElement<leptos::html::Nav>,
        ) -> leptos::HtmlElement<leptos::html::Nav> {
            v0_1
        }
        pub fn closure70(
            v0_1: leptos::ReadSignal<Ui::US20>,
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
            let v7 = Ui::method145(v0_1, v1);
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
            let v13: leptos::HtmlElement<leptos::html::Nav> = Ui::method154(
                leptos::view! { <nav  aria-label="Tabs" class="-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]">{v7()}</nav> },
            );
            let v15: leptos::View = leptos::IntoView::into_view(v13);
            leptos::Fragment::new(vec![v15])
        }
        pub fn method144(
            v0_1: leptos::ReadSignal<Ui::US20>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure70(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure69(
            v0_1: leptos::ReadSignal<Ui::US20>,
            v1: string,
            unitVar: (),
        ) -> leptos::Fragment {
            let v4: string = string(" class=\"flex flex-1 border-t border-gray-200\"");
            let v5 = Ui::method144(v0_1, v1);
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
            let v11: leptos::HtmlElement<leptos::html::Div> = Ui::method103(
                leptos::view! { <div  class="flex flex-1 border-t border-gray-200">{v5()}</div> },
            );
            let v13: leptos::View = leptos::IntoView::into_view(v11);
            leptos::Fragment::new(vec![v13])
        }
        pub fn method143(
            v0_1: leptos::ReadSignal<Ui::US20>,
            v1: string,
        ) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move || Ui::closure69(v0_1.clone(), v1.clone(), ())
            })
        }
        pub fn closure61(v0_1: leptos::ReadSignal<Ui::US20>, unitVar: ()) -> leptos::Fragment {
            let v2: leptos_router::Location = leptos_router::use_location();
            let v3: leptos_router::Location = Ui::method66(v2.clone());
            let v6: leptos::Memo<std::string::String> = Ui::method67(v3.pathname);
            let v9: std::string::String = Ui::method31(v6());
            let v11: string = fable_library_rust::String_::fromString(v9);
            let v12: leptos_router::Location = Ui::method68(v2);
            let v15: leptos::Memo<std::string::String> = Ui::method67(v12.search);
            let v18: std::string::String = Ui::method31(v15());
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
            let v30 = Ui::method131(v0_1.clone());
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
                Ui::method103(leptos::view! { <div  class="hidden">{v30()}</div> });
            let v38: leptos::View = leptos::IntoView::into_view(v36);
            let v40: string =
                string(" class=\"flex flex-1 [overflow-x:auto] [overflow-y:hidden]\"");
            let v41 = Ui::method143(v0_1, v26);
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
            let v46: leptos::HtmlElement<leptos::html::Div> = Ui::method103(
                leptos::view! { <div  class="flex flex-1 [overflow-x:auto] [overflow-y:hidden]">{v41()}</div> },
            );
            let v50: Array<leptos::View> =
                Ui::method102(new_array(&[v38, leptos::IntoView::into_view(v46)]));
            leptos::Fragment::new(v50.to_vec())
        }
        pub fn method130(v0_1: leptos::ReadSignal<Ui::US20>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure61(v0_1.clone(), ())
            })
        }
        pub fn closure60(v0_1: leptos::ReadSignal<Ui::US20>, unitVar: ()) -> leptos::Fragment {
            let v3: string = string(" class=\"flex flex-1 [align-items:flex-end]\"");
            let v4 = Ui::method130(v0_1);
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
            let v10: leptos::HtmlElement<leptos::html::Div> = Ui::method103(
                leptos::view! { <div  class="flex flex-1 [align-items:flex-end]">{v4()}</div> },
            );
            let v12: leptos::View = leptos::IntoView::into_view(v10);
            leptos::Fragment::new(vec![v12])
        }
        pub fn method129(v0_1: leptos::ReadSignal<Ui::US20>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure60(v0_1.clone(), ())
            })
        }
        pub fn closure36(v0_1: leptos::ReadSignal<Ui::US20>, unitVar: ()) -> leptos::Fragment {
            let v1 = Ui::method81(v0_1.clone());
            let v2 = Ui::method82();
            let v4 = {
                let clo = move || v2(v1());
                Func1::new({
                    let clo = clo.clone();
                    move |arg: ()| clo()
                })
            };
            let v6: leptos::View = leptos::IntoView::into_view(move || v4(()));
            let v9: string = string(" class=\"flex flex-1 min-w-max\"");
            let v10 = Ui::method129(v0_1);
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
                Ui::method103(leptos::view! { <div  class="flex flex-1 min-w-max">{v10()}</div> });
            let v20: Array<leptos::View> =
                Ui::method102(new_array(&[v6, leptos::IntoView::into_view(v16)]));
            leptos::Fragment::new(v20.to_vec())
        }
        pub fn method80(v0_1: leptos::ReadSignal<Ui::US20>) -> Func0<leptos::Fragment> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure36(v0_1.clone(), ())
            })
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            leptos::logging::log!("{}", &string("content.render ()"));
            {
                let v3: leptos_router::Location = leptos_router::use_location();
                let v5: std::sync::Arc<dyn Fn(&str, leptos_router::NavigateOptions)> =
                    std::sync::Arc::new(leptos_router::use_navigate());
                let v7: leptos_router::Location = leptos_router::use_location();
                let v8: leptos_router::Location = Ui::method66(v7.clone());
                let v11: leptos::Memo<std::string::String> = Ui::method67(v8.pathname);
                let v14: std::string::String = Ui::method31(v11());
                let v16: string = fable_library_rust::String_::fromString(v14);
                let v17: leptos_router::Location = Ui::method68(v7);
                let v20: leptos::Memo<std::string::String> = Ui::method67(v17.search);
                let v23: std::string::String = Ui::method31(v20());
                let v25: string = fable_library_rust::String_::fromString(v23);
                let v31: string = append(
                    v16,
                    (if v25.clone() == string("") {
                        string("")
                    } else {
                        sprintf!("?{}", &v25)
                    }),
                );
                let v33: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
                let v35: Ui::Heap2 = v33.unwrap();
                let v36: Ui::US20 = Ui::method69();
                let patternInput: (leptos::ReadSignal<Ui::US20>, leptos::WriteSignal<Ui::US20>) =
                    leptos::create_signal(v36);
                let v40: bool = Ui::method48();
                let patternInput_1: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                    leptos::create_signal(v40);
                let v44 = Ui::method70(
                    v3.clone(),
                    v5,
                    v31,
                    v35,
                    patternInput_1.1.clone(),
                    patternInput_1.0.clone(),
                );
                leptos::create_effect(move |_| v44());
                {
                    let v46 = Ui::method73(v3, patternInput.1.clone());
                    leptos::create_effect(move |_| v46());
                    {
                        let v50: string =
                            string(" class=\"bg-gray-50 flex flex-1 flex-col items-stretch min-h-screen text-gray-700 text-sm\"");
                        let v51 = Ui::method80(patternInput.0.clone());
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
                        let v57: leptos::HtmlElement<leptos::html::Div> = Ui::method103(
                            leptos::view! { <div  class="bg-gray-50 flex flex-1 flex-col items-stretch min-h-screen text-gray-700 text-sm">{v51()}</div> },
                        );
                        let v59: leptos::View = leptos::IntoView::into_view(v57);
                        leptos::Fragment::new(vec![v59])
                    }
                }
            }
        }
        pub fn method65() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure33((), ()))
        }
        pub fn closure5(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(1_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
                let v7: Ui::Heap2 = v5.unwrap();
                let v8 = Ui::method9();
                let v11: leptos::Resource<Ui::US1, rexie::Rexie> = leptos::create_local_resource(
                    move || v8(),
                    |x| async move { Func1::new(move |v: Ui::US1| Ui::closure7((), v))(x).await },
                );
                let v12 = Ui::method12(v11.clone());
                let v15: leptos::Resource<Option<rexie::Rexie>, Ui::US3> =
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move |v_1: Option<rexie::Rexie>| Ui::closure9((), v_1))(x)
                                .await
                        },
                    );
                let v16 = Ui::method19(v11.clone());
                let v19: leptos::Resource<Option<rexie::Rexie>, Ui::US7> =
                    leptos::create_local_resource(
                        move || v16(),
                        |x| async move {
                            Func1::new(move |v_2: Option<rexie::Rexie>| Ui::closure14((), v_2))(x)
                                .await
                        },
                    );
                let v20 = Ui::method22(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Ui::method37(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Ui::method40(v11.clone());
                        let v26: leptos::Action<Ui::Heap3, ()> =
                            leptos::create_action(move |value: &Heap3| v24(value.clone()));
                        let v27 = Ui::method44(v11);
                        let v29: leptos::Action<Ui::Heap4, ()> =
                            leptos::create_action(move |value: &Heap4| v27(value.clone()));
                        let v30 = Ui::method46(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Ui::method48();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Ui::method49(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Ui::method62(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
                                let v46 = Ui::method64(v42.unwrap());
                                let v51: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v52 = Ui::method65();
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
                                let v58: leptos::HtmlElement<leptos::html::Div> = Ui::method103(
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
        pub fn method8() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure5((), ()))
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: Array<leptos::View> = Ui::method102(new_empty::<leptos::View>());
            leptos::Fragment::new(v1.to_vec())
        }
        pub fn method155() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure77((), ()))
        }
        pub fn method156() -> string {
            string("/")
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(2_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
                let v7: Ui::Heap2 = v5.unwrap();
                let v8 = Ui::method9();
                let v11: leptos::Resource<Ui::US1, rexie::Rexie> = leptos::create_local_resource(
                    move || v8(),
                    |x| async move { Func1::new(move |v: Ui::US1| Ui::closure7((), v))(x).await },
                );
                let v12 = Ui::method12(v11.clone());
                let v15: leptos::Resource<Option<rexie::Rexie>, Ui::US3> =
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move |v_1: Option<rexie::Rexie>| Ui::closure9((), v_1))(x)
                                .await
                        },
                    );
                let v16 = Ui::method19(v11.clone());
                let v19: leptos::Resource<Option<rexie::Rexie>, Ui::US7> =
                    leptos::create_local_resource(
                        move || v16(),
                        |x| async move {
                            Func1::new(move |v_2: Option<rexie::Rexie>| Ui::closure14((), v_2))(x)
                                .await
                        },
                    );
                let v20 = Ui::method22(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Ui::method37(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Ui::method40(v11.clone());
                        let v26: leptos::Action<Ui::Heap3, ()> =
                            leptos::create_action(move |value: &Heap3| v24(value.clone()));
                        let v27 = Ui::method44(v11);
                        let v29: leptos::Action<Ui::Heap4, ()> =
                            leptos::create_action(move |value: &Heap4| v27(value.clone()));
                        let v30 = Ui::method46(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Ui::method48();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Ui::method49(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Ui::method62(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
                                let v46 = Ui::method64(v42.unwrap());
                                let v51: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v52 = Ui::method65();
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
                                let v58: leptos::HtmlElement<leptos::html::Div> = Ui::method103(
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
        pub fn method157() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure78((), ()))
        }
        pub fn method158() -> string {
            string("/*")
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(3_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
                let v7: Ui::Heap2 = v5.unwrap();
                let v8 = Ui::method9();
                let v11: leptos::Resource<Ui::US1, rexie::Rexie> = leptos::create_local_resource(
                    move || v8(),
                    |x| async move { Func1::new(move |v: Ui::US1| Ui::closure7((), v))(x).await },
                );
                let v12 = Ui::method12(v11.clone());
                let v15: leptos::Resource<Option<rexie::Rexie>, Ui::US3> =
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move |v_1: Option<rexie::Rexie>| Ui::closure9((), v_1))(x)
                                .await
                        },
                    );
                let v16 = Ui::method19(v11.clone());
                let v19: leptos::Resource<Option<rexie::Rexie>, Ui::US7> =
                    leptos::create_local_resource(
                        move || v16(),
                        |x| async move {
                            Func1::new(move |v_2: Option<rexie::Rexie>| Ui::closure14((), v_2))(x)
                                .await
                        },
                    );
                let v20 = Ui::method22(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Ui::method37(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Ui::method40(v11.clone());
                        let v26: leptos::Action<Ui::Heap3, ()> =
                            leptos::create_action(move |value: &Heap3| v24(value.clone()));
                        let v27 = Ui::method44(v11);
                        let v29: leptos::Action<Ui::Heap4, ()> =
                            leptos::create_action(move |value: &Heap4| v27(value.clone()));
                        let v30 = Ui::method46(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Ui::method48();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Ui::method49(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Ui::method62(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
                                let v46 = Ui::method64(v42.unwrap());
                                let v51: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v52 = Ui::method65();
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
                                let v58: leptos::HtmlElement<leptos::html::Div> = Ui::method103(
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
        pub fn method159() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure79((), ()))
        }
        pub fn method160() -> string {
            string("*")
        }
        pub fn closure80(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v0_1: string = append(
                append(string("home.render () / router: "), toString(4_i32)),
                string(""),
            );
            leptos::logging::log!("{}", &v0_1);
            leptos::logging::log!("{}", &string("state.use_database ()"));
            {
                let v5: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
                let v7: Ui::Heap2 = v5.unwrap();
                let v8 = Ui::method9();
                let v11: leptos::Resource<Ui::US1, rexie::Rexie> = leptos::create_local_resource(
                    move || v8(),
                    |x| async move { Func1::new(move |v: Ui::US1| Ui::closure7((), v))(x).await },
                );
                let v12 = Ui::method12(v11.clone());
                let v15: leptos::Resource<Option<rexie::Rexie>, Ui::US3> =
                    leptos::create_local_resource(
                        move || v12(),
                        |x| async move {
                            Func1::new(move |v_1: Option<rexie::Rexie>| Ui::closure9((), v_1))(x)
                                .await
                        },
                    );
                let v16 = Ui::method19(v11.clone());
                let v19: leptos::Resource<Option<rexie::Rexie>, Ui::US7> =
                    leptos::create_local_resource(
                        move || v16(),
                        |x| async move {
                            Func1::new(move |v_2: Option<rexie::Rexie>| Ui::closure14((), v_2))(x)
                                .await
                        },
                    );
                let v20 = Ui::method22(v7.clone(), v15);
                leptos::create_effect(move |_| v20());
                {
                    let v22 = Ui::method37(v7.clone(), v19);
                    leptos::create_effect(move |_| v22());
                    {
                        let v24 = Ui::method40(v11.clone());
                        let v26: leptos::Action<Ui::Heap3, ()> =
                            leptos::create_action(move |value: &Heap3| v24(value.clone()));
                        let v27 = Ui::method44(v11);
                        let v29: leptos::Action<Ui::Heap4, ()> =
                            leptos::create_action(move |value: &Heap4| v27(value.clone()));
                        let v30 = Ui::method46(v7.clone());
                        let v32: leptos::Memo<
                            std::collections::HashMap<std::string::String, leptos::RwSignal<bool>>,
                        > = leptos::create_memo(move |_| v30());
                        let v33: bool = Ui::method48();
                        let patternInput: (leptos::ReadSignal<bool>, leptos::WriteSignal<bool>) =
                            leptos::create_signal(v33);
                        let v36: leptos::WriteSignal<bool> = patternInput.1.clone();
                        let v35: leptos::ReadSignal<bool> = patternInput.0.clone();
                        let v37 = Ui::method49(v7.clone(), v26, v32, v36.clone(), v35.clone());
                        leptos::create_effect(move |_| v37());
                        {
                            let v39 = Ui::method62(v7, v29, v36, v35);
                            leptos::create_effect(move |_| v39());
                            {
                                let v42: Option<Ui::Heap2> = leptos::use_context::<Heap2>();
                                let v46 = Ui::method64(v42.unwrap());
                                let v51: string =
                                    string(" class:dark={move || v46()} class=\"flex flex-1\"");
                                let v52 = Ui::method65();
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
                                let v58: leptos::HtmlElement<leptos::html::Div> = Ui::method103(
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
        pub fn method161() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure80((), ()))
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1: string = Ui::method7(Ui::method6());
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1);
            let v5: std::string::String = String::from(v3);
            let v6 = Ui::method8();
            let v7 = Ui::method155();
            let v15: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v6() path=v5 /> })");
            let v16: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v6() path=v5 /> },
            );
            let v18: string = Ui::method7(Ui::method156());
            let v20: &str = fable_library_rust::String_::LrcStr::as_str(&v18);
            let v22: std::string::String = String::from(v20);
            let v23 = Ui::method157();
            let v24 = Ui::method155();
            let v30: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v23() path=v22 /> })");
            let v31: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v23() path=v22 /> },
            );
            let v33: string = Ui::method7(Ui::method158());
            let v35: &str = fable_library_rust::String_::LrcStr::as_str(&v33);
            let v37: std::string::String = String::from(v35);
            let v38 = Ui::method159();
            let v39 = Ui::method155();
            let v45: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v38() path=v37 /> })");
            let v46: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Route  view=move || v38() path=v37 /> },
            );
            let v48: string = Ui::method7(Ui::method160());
            let v50: &str = fable_library_rust::String_::LrcStr::as_str(&v48);
            let v52: std::string::String = String::from(v50);
            let v53 = Ui::method161();
            let v54 = Ui::method155();
            let v60: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Route  view=move || v53() path=v52 /> })");
            let v63: Array<leptos::View> = Ui::method102(new_array(&[
                v16,
                v31,
                v46,
                leptos::IntoView::into_view(
                    leptos::view! { <leptos_router::Route  view=move || v53() path=v52 /> },
                ),
            ]));
            leptos::Fragment::new(v63.to_vec())
        }
        pub fn method5() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure4((), ()))
        }
        pub fn method162(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) -> leptos::Fragment {
            let v1 = Ui::method162(Ui::method5());
            let v7: string =
                string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> })");
            let v8: leptos::View = leptos::IntoView::into_view(
                leptos::view! { <leptos_router::Routes  children=Box::new(move || v1()) /> },
            );
            leptos::Fragment::new(vec![v8])
        }
        pub fn method4() -> Func0<leptos::Fragment> {
            Func0::new(move || Ui::closure3((), ()))
        }
        pub fn method163(v0_1: Func0<leptos::Fragment>) -> Func0<leptos::Fragment> {
            v0_1
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
            leptos::logging::log!("{}", &string("app.render ()"));
            leptos_meta::provide_meta_context();
            {
                let v4: leptos::RwSignal<bool> = leptos::create_rw_signal(false);
                let v5: string = Ui::method1();
                let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
                let v9: std::string::String = String::from(v7);
                let v12: Ui::Heap0 = Ui::Heap0 {
                    l0: v4,
                    l1: leptos::create_rw_signal(v9),
                };
                let v14: leptos::RwSignal<Ui::Heap0> = leptos::create_rw_signal(v12);
                let v15: string = Ui::method2();
                let v17: &str = fable_library_rust::String_::LrcStr::as_str(&v15);
                let v19: std::string::String = String::from(v17);
                let v22: Ui::Heap1 = Ui::Heap1 {
                    l0: leptos::create_rw_signal(v19),
                };
                let v24: leptos::RwSignal<Ui::Heap1> = leptos::create_rw_signal(v22);
                let v26: std::collections::HashMap<std::string::String, leptos::RwSignal<bool>> =
                    std::collections::HashMap::new();
                let v30: Ui::Heap2 = Ui::method3(Ui::Heap2 {
                    l0: v14,
                    l1: leptos::create_rw_signal(v26),
                    l2: v24,
                });
                leptos::provide_context::<Heap2>(v30);
                {
                    let v33 = Ui::method163(Ui::method4());
                    let v39: string =
                        string("leptos::IntoView::into_view(leptos::view! { <leptos_router::Router  children=Box::new(move || v33()) /> })");
                    leptos::IntoView::into_view(
                        leptos::view! { <leptos_router::Router  children=Box::new(move || v33()) /> },
                    )
                }
            }
        }
        pub fn method0() {
            leptos::mount_to_body(|| Func0::new(move || Ui::closure2((), ()))());
            ()
        }
        pub fn closure81(unitVar: (), unitVar_1: ()) {
            Ui::method0();
        }
        pub fn method164() -> Func0<()> {
            Func0::new(move || Ui::closure81((), ()))
        }
        pub fn method165(v0_1: Box<dyn Fn()>) -> Box<dyn Fn()> {
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
                    let v14 = Ui::method164();
                    let v17: Box<dyn Fn()> = Ui::method165(Box::new(move || v14()));
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
