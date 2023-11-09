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
        use fable_library_rust::String_::append;
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
        pub fn closure3(unitVar: (), v0_1: bool) -> bool {
            v0_1 == false
        }
        pub fn method4() -> Func1<bool, bool> {
            Func1::new(move |v: bool| Ui::closure3((), v))
        }
        pub fn method5(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure2(v0_1: LrcPtr<Ui::Heap0>, v1: leptos::ev::MouseEvent) {
            let v3: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method3(v0_1.l0.clone());
            let v5: leptos::RwSignal<bool> = leptos::SignalGet::get(&v3);
            let v6 = Ui::method4();
            let v7: leptos::RwSignal<bool> = Ui::method5(v5);
            leptos::SignalUpdate::update(&v7, |x| *x = v6(*x));
            ()
        }
        pub fn method2(v0_1: LrcPtr<Ui::Heap0>) -> Func1<leptos::ev::MouseEvent, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: leptos::ev::MouseEvent| Ui::closure2(v0_1.clone(), v)
            })
        }
        pub fn method7(v0_1: leptos::RwSignal<bool>) -> leptos::RwSignal<bool> {
            v0_1
        }
        pub fn closure4(v0_1: LrcPtr<Ui::Heap0>, unitVar: ()) -> bool {
            let v2: leptos::RwSignal<leptos::RwSignal<bool>> = Ui::method3(v0_1.l0.clone());
            let v5: leptos::RwSignal<bool> = Ui::method7(leptos::SignalGet::get(&v2));
            leptos::SignalGet::get(&v5)
        }
        pub fn method6(v0_1: LrcPtr<Ui::Heap0>) -> Func0<bool> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Ui::closure4(v0_1.clone(), ())
            })
        }
        pub fn closure1(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
            leptos_meta::provide_meta_context();
            {
                let v2: leptos::RwSignal<bool> = leptos::create_rw_signal(true);
                let v5: LrcPtr<Ui::Heap0> = LrcPtr::new(Ui::Heap0 {
                    l0: leptos::create_rw_signal(v2),
                });
                leptos::provide_context::<std::rc::Rc<Heap0>>(v5);
                {
                    let v8: LrcPtr<Ui::Heap0> =
                        leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into();
                    let v10: string = Ui::method0(toString(30_i32));
                    let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
                    let v13: string = Ui::method1();
                    let v15: &str = fable_library_rust::String_::LrcStr::as_str(&v13);
                    let v17: std::string::String = String::from(v15);
                    let patternInput = leptos::create_signal(v17);
                    let v21: string =
                        string("leptos::view! { <input class=\"bg-gray-50 dark:bg-gray-900 text-gray-700 dark:text-gray-200 flex-1 h-8\" prop:value=$0 on:keyup=move |event: web_sys::KeyboardEvent| { $1(leptos::event_target_value(&event)) } /> }");
                    let v24: leptos::HtmlElement<leptos::html::Input> = leptos::view! { <input class="bg-gray-50 dark:bg-gray-900 text-gray-700 dark:text-gray-200 flex-1 h-8" prop:value=patternInput.0.clone() on:keyup=move |event: web_sys::KeyboardEvent| { patternInput.1.clone()(leptos::event_target_value(&event)) } /> };
                    let v28: leptos::HtmlElement<leptos::html::Div> = leptos::view! { <div class="flex flex-1" style="font-size: ".to_owned() + *&v12 + "px">2{v24}</div> };
                    let v31 =
                        Ui::method2(leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into());
                    let v32: string =
                        string("leptos::view! { <button class=\"fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full\" on:click=move |mouse_event| v31(mouse_event)>{(|| { leptos::logging::log!(\"button () / render\"); leptos::view! {<></>} })()}{\"🌓︎\"}</button> }");
                    let v35: leptos::HtmlElement<leptos::html::Button> = leptos::view! { <button class="fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full" on:click=move |mouse_event| v31(mouse_event)>{(|| { leptos::logging::log!("button () / render"); leptos::view! {<></>} })()}{"🌓︎"}</button> };
                    let v37: string =
                        string("leptos::view! { <div class=\"flex flex-1\">{v28}{v35}</div> }");
                    let v39: leptos::HtmlElement<leptos::html::Div> =
                        leptos::view! { <div class="flex flex-1">{v28}{v35}</div> };
                    let v40 = Ui::method6(v8);
                    let v42: string =
                        string("leptos::view! { <div class=\"flex flex-1\" class:dark={move || v40()}>{v39}</div> }");
                    leptos::view! { <div class="flex flex-1" class:dark={move || v40()}>{v39}</div> }
                }
            }
        }
        pub fn closure0(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1: string = append(append(string("args: "), toString(v0_1)), string(""));
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
