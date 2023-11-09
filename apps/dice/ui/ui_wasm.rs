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
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toString;
        pub fn closure1(unitVar: (), unitVar_1: ()) -> impl leptos::IntoView {
            let v0_1: string = toString(30_i32);
            let v2: &str = fable_library_rust::String_::LrcStr::as_str(&v0_1);
            let v6: leptos::HtmlElement<leptos::html::Div> =
                leptos::view! { <div style="font-size: ".to_owned() + *&v2 + "px">2</div> };
            let v8: leptos::View = leptos::IntoView::into_view(v6);
            let v10: string = string("leptos::view! { <div>{v8}</div> }");
            leptos::view! { <div>{v8}</div> }
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
