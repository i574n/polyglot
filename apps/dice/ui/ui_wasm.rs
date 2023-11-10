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
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toString;
        #[derive(Clone, Debug, Default)]
        pub struct Heap0 {
            pub l0: leptos::RwSignal<leptos::RwSignal<bool>>,
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
            let v2: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method3(v0_1.l0.clone());
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
        pub fn method10(v0_1: Result<Ui::US2, rexie::Error>) -> Result<Ui::US2, rexie::Error> {
            v0_1
        }
        pub fn method11(v0_1: Ui::US2) -> Ui::US2 {
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
                        let v27: Ui::US2 = Ui::method11(match &v8 {
                            Ui::US3::US3_1(v8_1_0) => {
                                leptos::logging::log!("{}", &string("ui.get_dark_mode ()"));
                                let __future_init = Box::pin(async {
                                    //;
                                    {
                                        let v15: Result<Ui::US2, rexie::Error> =
                                            Ui::method10(Ok(Ui::US2::US2_1(true)));
                                        v15
                                    }
                                });
                                {
                                    // ;
                                    {
                                        let v19: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<Ui::US2, rexie::Error>,
                                                >,
                                            >,
                                        > = __future_init;
                                        let v21: Result<Ui::US2, rexie::Error> = v19.await;
                                        v21.unwrap()
                                    }
                                }
                            }
                            _ => Ui::US2::US2_0,
                        });
                        v27
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
        pub fn closure9(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method13() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Ui::closure9((), v))
        }
        pub fn method14(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure8(v0_1: LrcPtr<Ui::Heap0>, v1: leptos::ev::MouseEvent) {
            let v3: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method3(v0_1.l0.clone());
            let v5: leptos::RwSignal<bool> = leptos::SignalGet::get(&v3);
            let v6 = Ui::method13();
            let v7: leptos::RwSignal<bool> = Ui::method14(v5);
            leptos::SignalUpdate::update(&v7, |x| *x = v6(*x));
            ()
        }
        pub fn method12(v0_1: LrcPtr<Ui::Heap0>) -> Func1<leptos::ev::MouseEvent, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::MouseEvent| Ui::closure8(v0_1.clone(), v)
            })
        }
        pub fn closure1(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
            leptos::logging::log!("{}", &string("ui.app ()"));
            leptos_meta::provide_meta_context();
            {
                let v4: leptos::RwSignal<bool> = leptos::create_rw_signal(true);
                let v7: LrcPtr<Ui::Heap0> = LrcPtr::new(Ui::Heap0 {
                    l0: leptos::create_rw_signal(v4),
                });
                leptos::provide_context::<std::rc::Rc<Heap0>>(v7);
                leptos::logging::log!("{}", &string("ui.home ()"));
                {
                    let v12: LrcPtr<Ui::Heap0> =
                        leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into();
                    let v14: string = Ui::method0(toString(14_i32));
                    let v16: &str = fable_library_rust::String_::LrcStr::as_str(&v14);
                    let v17: string = Ui::method1();
                    let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
                    let v21: std::string::String = String::from(v19);
                    let patternInput = leptos::create_signal(v21);
                    let v25: string =
                        string("leptos::view! { <input class=\"bg-gray-50 dark:bg-gray-900 flex-1 h-8\" prop:value=$0 on:keyup=move |event: web_sys::KeyboardEvent| { $1(leptos::event_target_value(&event)) } /> }");
                    let v28: leptos::HtmlElement<leptos::html::Input> = leptos::view! { <input class="bg-gray-50 dark:bg-gray-900 flex-1 h-8" prop:value=patternInput.0.clone() on:keyup=move |event: web_sys::KeyboardEvent| { patternInput.1.clone()(leptos::event_target_value(&event)) } /> };
                    let v29: string =
                        string("leptos::view! { <div class=\"bg-gray-50 dark:bg-gray-900 flex flex-1 min-h-screen min-w-full place-items-baseline text-gray-700 dark:text-gray-200 text-sm\" style=\"font-size: \".to_owned() + *$0 + \"px; place-items: baseline;\">label:{v28}</div> }");
                    let v32: leptos::HtmlElement<leptos::html::Div> = leptos::view! { <div class="bg-gray-50 dark:bg-gray-900 flex flex-1 min-h-screen min-w-full place-items-baseline text-gray-700 dark:text-gray-200 text-sm" style="font-size: ".to_owned() + *&v16 + "px; place-items: baseline;">label:{v28}</div> };
                    let v33 = Ui::method2(v12);
                    leptos::logging::log!("{}", &string("ui.dark_mode_button ()"));
                    {
                        let v37: LrcPtr<Ui::Heap0> =
                            leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into();
                        let v38 = Ui::method5();
                        let v42 = Ui::method8(leptos::create_local_resource(
                            move || v38(),
                            |x| async move {
                                Func1::new(move |v: Ui::US0| Ui::closure4((), v))(x).await
                            },
                        ));
                        let v45: leptos::Resource<Option<rexie::Rexie>, Ui::US2> =
                            leptos::create_local_resource(
                                move || v42(),
                                |x| async move {
                                    Func1::new(move |v_1: Option<rexie::Rexie>| {
                                        Ui::closure6((), v_1)
                                    })(x)
                                    .await
                                },
                            );
                        let v46 = Ui::method12(v37);
                        let v47: string =
                            string("<button class=\"fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full\" on:click=move |mouse_event| v46(mouse_event)>{(|| { leptos::logging::log!(\"button () / render\"); leptos::view! {<></>} })()}{\"🌓︎\"}</button>");
                        let v48: string =
                            append(append(string("leptos::view! { "), v47), string(" }"));
                        let v50: leptos::HtmlElement<leptos::html::Button> = leptos::view! { <button class="fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full" on:click=move |mouse_event| v46(mouse_event)>{(|| { leptos::logging::log!("button () / render"); leptos::view! {<></>} })()}{"🌓︎"}</button> };
                        let v52: string =
                            string("leptos::view! { <div class=\"flex flex-1\" class:dark={move || v33()}>{v50}{v32}</div> }");
                        let v54: leptos::HtmlElement<leptos::html::Div> = leptos::view! { <div class="flex flex-1" class:dark={move || v33()}>{v50}{v32}</div> };
                        leptos::IntoView::into_view(v54)
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
