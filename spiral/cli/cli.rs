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
pub mod Cli {
    use super::*;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::String_::string;
    pub fn method0(v0_1: Option<std::string::String>) -> Option<std::string::String> {
        v0_1
    }
    pub fn method1(v0_1: std::string::String) -> std::string::String {
        v0_1
    }
    pub fn closure1(unitVar: (), v0_1: std::string::String) -> string {
        let v1: std::string::String = Cli::method1(v0_1);
        fable_library_rust::String_::fromString(v1)
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        let v1: string = string("r#\"test1\"#");
        let v2: &str = r#"test1"#;
        let v6: Option<std::string::String> =
            Cli::method0(Some(String::from(core::ops::Deref::deref(&v2))));
        let v9: Option<string> = v6.map(&*Func1::new(move |v: std::string::String| {
            Cli::closure1((), v.clone())
        }));
        let v11: std::string::String = format!("{:?}", &v9);
        println!("{0}", &v11,);
        -1_i32
    }
    pub fn v0() -> Func0<i32> {
        static v0: MutCell<Option<Func0<i32>>> = MutCell::new(None);
        v0.get_or_init(|| Func0::new(move || Cli::closure0((), ())))
    }
    on_startup!((),);
}
#[path = "../rust/Types.rs"]
mod module_cd193dc2;
pub use module_cd193dc2::*;
