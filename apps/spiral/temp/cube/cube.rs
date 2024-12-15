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
#![allow(unused_assignments)]
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_62c167ba {
    pub mod Cube {
        use super::*;
        use fable_library_rust::Async_::Async;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::List;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::getZero;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Arc;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Seq_::append;
        use fable_library_rust::Seq_::choose;
        use fable_library_rust::Seq_::collect;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::empty;
        use fable_library_rust::Seq_::enumerateWhile;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::singleton;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofChar;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::string;
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::System::Text::StringBuilder;
        pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US0 {
            US0_0,
            US0_1,
            US0_2,
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US1 {
            US1_0(Cube::US0),
            US1_1(Cube::US0),
            US1_2(Cube::US0),
            US1_3(Cube::US0),
            US1_4(Cube::US0),
        }
        impl core::fmt::Display for US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US2 {
            US2_0(string),
            US2_1,
        }
        impl core::fmt::Display for US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd)]
        pub struct Mut0 {
            pub l0: MutCell<f64>,
        }
        impl core::fmt::Display for Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd)]
        pub enum US3 {
            US3_0(i32, f64, char),
            US3_1,
        }
        impl core::fmt::Display for US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd)]
        pub enum US4 {
            US4_0(f64, char),
            US4_1,
        }
        impl core::fmt::Display for US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> string {
            string("VSCODE_PID")
        }
        pub fn method2(v0_1: string) -> string {
            v0_1
        }
        pub fn method3() -> string {
            string("")
        }
        pub fn closure1(unitVar: (), v0_1: string) -> Cube::US2 {
            Cube::US2::US2_0(v0_1)
        }
        pub fn method4() -> Func1<string, Cube::US2> {
            Func1::new(move |v: string| Cube::closure1((), v))
        }
        pub fn method1(v0_1: string) -> string {
            let v2: string = Cube::method2(v0_1);
            let v4: Result<std::string::String, std::env::VarError> = std::env::var(&*v2);
            let v6: bool = true;
            let _result_map_ = v4.map(|x| {
                //;
                let v8: std::string::String = x;
                let v10: string = fable_library_rust::String_::fromString(v8);
                let v12: bool = true;
                v10
            });
            let v14: Result<string, std::env::VarError> = _result_map_;
            let v15: string = Cube::method3();
            v14.unwrap_or(v15)
        }
        pub fn method7(v0_1: f64, v1: f64, v2: f64) -> (f64, f64, f64) {
            (v0_1, v1, v2)
        }
        pub fn method9(v0_1: f64, v1: LrcPtr<Cube::Mut0>) -> bool {
            (v1.l0.get().clone()) < (v0_1)
        }
        pub fn method10(v0_1: LrcPtr<dyn IEnumerable_1<f64>>) -> LrcPtr<dyn IEnumerable_1<f64>> {
            v0_1
        }
        pub fn method12(
            v0_1: f64,
            v1: f64,
            v2: f64,
            v3: char,
            v4: f64,
            v5: f64,
            v6: f64,
            v7: f64,
        ) -> Cube::US3 {
            let v8: f64 = v4.sin();
            let v9: f64 = (v1) * (v8);
            let v10: f64 = v5.sin();
            let v11: f64 = (v9) * (v10);
            let v12: f64 = v6.cos();
            let v13: f64 = (v11) * (v12);
            let v14: f64 = v4.cos();
            let v15: f64 = (v2) * (v14);
            let v16: f64 = (v15) * (v10);
            let v18: f64 = (v13) - ((v16) * (v12));
            let v19: f64 = (v1) * (v14);
            let v20: f64 = v6.sin();
            let v23: f64 = (v2) * (v8);
            let v25: f64 = ((v18) + ((v19) * (v20))) + ((v23) * (v20));
            let v26: f64 = v5.cos();
            let v27: f64 = (v0_1) * (v26);
            let v45: f64 =
                1.0_f64 / (((((v15) * (v26)) - ((v9) * (v26))) + ((v0_1) * (v10))) + 100.0_f64);
            let v52: f64 = 40.0_f64 * (v45);
            let v78: i32 = (((((160_i32 as f64) / 2.0_f64) + (v7))
                + (((v52) * ((v25) + ((v27) * (v12)))) * 2.0_f64))
                as i32)
                + (((((44_i32 as f64) / 2.0_f64)
                    + ((v52)
                        * ((((((v19) * (v12)) + ((v23) * (v12))) - ((v11) * (v20)))
                            + ((v16) * (v20)))
                            - ((v27) * (v20))))) as i32)
                    * 160_i32);
            if if (v78) >= 0_i32 {
                (v78) < 7040_i32
            } else {
                false
            } {
                Cube::US3::US3_0(v78, v45, v3)
            } else {
                Cube::US3::US3_1
            }
        }
        pub fn closure4(
            v0_1: f64,
            v1: f64,
            v2: f64,
            v3: f64,
            v4: f64,
            v5: f64,
            v6: f64,
        ) -> List<Cube::US3> {
            let v7: f64 = -v3;
            let v12: f64 = -v5;
            ofArray(new_array(&[
                Cube::method12(v5, v6, v7, ';', v0_1, v1, v2, v4),
                Cube::method12(v3, v6, v5, '\\', v0_1, v1, v2, v4),
                Cube::method12(v7, v6, v12, '/', v0_1, v1, v2, v4),
                Cube::method12(v12, v6, v3, '=', v0_1, v1, v2, v4),
                Cube::method12(v5, v7, -v6, '>', v0_1, v1, v2, v4),
                Cube::method12(v5, v3, v6, '<', v0_1, v1, v2, v4),
            ]))
        }
        pub fn closure3(
            v0_1: f64,
            v1: f64,
            v2: f64,
            v3: f64,
            v4: f64,
            v5: f64,
        ) -> Func1<f64, List<Cube::US3>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                move |v: f64| Cube::closure4(v0_1, v1, v2, v3, v4, v5, v)
            })
        }
        pub fn method11(
            v0_1: f64,
            v1: f64,
            v2: f64,
            v3: f64,
            v4: f64,
        ) -> Func1<f64, Func1<f64, List<Cube::US3>>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move |v: f64| Cube::closure3(v0_1, v1, v2, v3, v4, v)
            })
        }
        pub fn closure5(unitVar: (), v0_1: Cube::US3) -> Option<(i32, f64, char)> {
            match &v0_1 {
                Cube::US3::US3_0(v0_1_0_0, v0_1_0_1, v0_1_0_2) => Some((
                    match &v0_1 {
                        Cube::US3::US3_0(x, _, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    match &v0_1 {
                        Cube::US3::US3_0(_, x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    match &v0_1 {
                        Cube::US3::US3_0(_, _, x) => x.clone(),
                        _ => unreachable!(),
                    },
                )),
                _ => None::<(i32, f64, char)>,
            }
        }
        pub fn method13() -> Func1<Cube::US3, Option<(i32, f64, char)>> {
            Func1::new(move |v: Cube::US3| Cube::closure5((), v))
        }
        pub fn closure2(
            v0_1: f64,
            v1: f64,
            v2: f64,
            _arg: (f64, f64),
        ) -> LrcPtr<dyn IEnumerable_1<(i32, f64, char)>> {
            let v3: f64 = _arg.0.clone();
            let v5: f64 = -v3;
            let v53: LrcPtr<dyn IEnumerable_1<f64>> = Cube::method10(delay(Func0::new({
                let v3 = v3.clone();
                let v5 = v5.clone();
                move || {
                    let v9: LrcPtr<Cube::Mut0> = LrcPtr::new(Cube::Mut0 {
                        l0: MutCell::new(v5),
                    });
                    enumerateWhile(
                        Func0::new({
                            let v9 = v9.clone();
                            move || Cube::method9(v3, v9.clone())
                        }),
                        delay(Func0::new({
                            let v9 = v9.clone();
                            move || {
                                append(
                                    singleton(v9.l0.get().clone()),
                                    delay(Func0::new({
                                        let v9 = v9.clone();
                                        move || {
                                            let v13: f64 = (v9.l0.get().clone()) + 0.6_f64;
                                            v9.l0.set(v13);
                                            ();
                                            empty::<f64>()
                                        }
                                    })),
                                )
                            }
                        })),
                    )
                }
            })));
            let v54 = Cube::method11(v0_1, v1, v2, v3, _arg.1.clone());
            let v55 = Cube::method13();
            delay(Func0::new({
                let v53 = v53.clone();
                let v54 = v54.clone();
                let v55 = v55.clone();
                move || {
                    collect(
                        Func1::new({
                            let v53 = v53.clone();
                            let v54 = v54.clone();
                            let v55 = v55.clone();
                            move |cube_x: f64| {
                                collect(
                                    Func1::new({
                                        let cube_x = cube_x.clone();
                                        let v54 = v54.clone();
                                        let v55 = v55.clone();
                                        move |cube_y: f64| {
                                            choose(v55.clone(), ofList(v54(cube_x)(cube_y)))
                                        }
                                    }),
                                    v53.clone(),
                                )
                            }
                        }),
                        v53.clone(),
                    )
                }
            }))
        }
        pub fn method8(
            v0_1: f64,
            v1: f64,
            v2: f64,
        ) -> Func1<(f64, f64), LrcPtr<dyn IEnumerable_1<(i32, f64, char)>>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move |arg10_0040: (f64, f64)| Cube::closure2(v0_1, v1, v2, arg10_0040)
            })
        }
        pub fn closure7(v0_1: Array<Cube::US4>, v1: i32, _arg: (f64, char)) {
            let v3: char = _arg.1.clone();
            let v2: f64 = _arg.0.clone();
            let v4: Cube::US4 = v0_1[v1].clone();
            if let Cube::US4::US4_0(v4_0_0, v4_0_1) = &v4 {
                if (v4_0_0.clone()) >= (v2) {
                    ()
                } else {
                    v0_1.get_mut()[v1 as usize] = Cube::US4::US4_0(v2, v3);
                    ()
                }
            } else {
                v0_1.get_mut()[v1 as usize] = Cube::US4::US4_0(v2, v3);
                ()
            }
        }
        pub fn closure6(v0_1: Array<Cube::US4>, v1: i32) -> Func1<(f64, char), ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1 = v1.clone();
                move |arg10_0040: (f64, char)| Cube::closure7(v0_1.clone(), v1, arg10_0040)
            })
        }
        pub fn method14() -> string {
            string("")
        }
        pub fn closure9(v0_1: Array<Cube::US4>, v1: LrcPtr<StringBuilder>, v2: i32, v3: i32) {
            let v5: i32 = (v3) + ((v2) * 160_i32);
            let v6: Cube::US4 = v0_1[v5].clone();
            let v18: LrcPtr<StringBuilder> = {
                let value: string = ofChar(match &v6 {
                    Cube::US4::US4_0(v6_0_0, v6_0_1) => match &v6 {
                        Cube::US4::US4_0(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => '.',
                });
                v1.Append_Z721C83C5(value)
            };
            ()
        }
        pub fn closure8(v0_1: Array<Cube::US4>, v1: LrcPtr<StringBuilder>, v2: i32) {
            for col in 0_i32..=160_i32 - 1_i32 {
                Cube::closure9(v0_1.clone(), v1.clone(), v2, col);
            }
            {
                let v4: LrcPtr<StringBuilder> = v1.AppendLine();
                ()
            }
        }
        pub fn closure10(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn method6(v0_1: i32, v1: i32, v2: f64, v3: f64, v4: f64) -> Arc<Async<()>> {
            getZero()
        }
        pub fn method5(v0_1: i32, v1: i32, v2: f64, v3: f64, v4: f64) -> Arc<Async<()>> {
            Cube::method6(v0_1, v1, v2, v3, v4)
        }
        pub fn closure0(unitVar: (), v0_1: Array<string>) {
            let v56: bool = if 0_i32 == (length(Cube::method1(Cube::method0()))) {
                0_i32 == (length(Cube::method1(string("AUTOMATION"))))
            } else {
                false
            };
            if v56 {
                print!("\x1B[?25l");
                ()
            }
            {
                let v79: Arc<Async<()>> = Cube::method5(
                    if v56 { -1_i32 } else { 50_i32 },
                    1_i32,
                    0.0_f64,
                    0.0_f64,
                    0.0_f64,
                );
                let v82: Arc<Async<Arc<Async<()>>>> = getZero();
                ()
            }
        }
        pub fn v0() -> Func1<Array<string>, ()> {
            static v0: OnceInit<Func1<Array<string>, ()>> = OnceInit::new();
            v0.get_or_init(|| Func1::new(move |v: Array<string>| Cube::closure0((), v)))
                .clone()
        }
        pub fn main_() -> Func1<Array<string>, ()> {
            static main_: OnceInit<Func1<Array<string>, ()>> = OnceInit::new();
            main_.get_or_init(|| Cube::v0()).clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Cube::main_())(new_empty::<string>());
            0_i32
        }
    }
}
pub use module_62c167ba::*;
#[path = "./lib/fsharp/Common.rs"]
mod module_ad43931;
pub use module_ad43931::*;
#[path = "./lib/spiral/async_.rs"]
mod module_67c461a2;
pub use module_67c461a2::*;
#[path = "./lib/spiral/common.rs"]
mod module_181b15d6;
pub use module_181b15d6::*;
#[path = "./lib/spiral/crypto.rs"]
mod module_90d9c778;
pub use module_90d9c778::*;
#[path = "./lib/spiral/date_time.rs"]
mod module_e43a8385;
pub use module_e43a8385::*;
#[path = "./lib/spiral/file_system.rs"]
mod module_a7db9b47;
pub use module_a7db9b47::*;
#[path = "./lib/spiral/lib.rs"]
mod module_98e448fc;
pub use module_98e448fc::*;
#[path = "./lib/spiral/networking.rs"]
mod module_268024e5;
pub use module_268024e5::*;
#[path = "./lib/spiral/platform.rs"]
mod module_7d8ad484;
pub use module_7d8ad484::*;
#[path = "./lib/spiral/runtime.rs"]
mod module_485aae07;
pub use module_485aae07::*;
#[path = "./lib/spiral/sm.rs"]
mod module_582b4305;
pub use module_582b4305::*;
#[path = "./lib/spiral/threading.rs"]
mod module_d5afb6f5;
pub use module_d5afb6f5::*;
#[path = "./lib/spiral/trace.rs"]
mod module_9e77af3a;
pub use module_9e77af3a::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Cube::main(array_from(args));
}
