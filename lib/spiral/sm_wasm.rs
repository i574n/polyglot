pub mod Sm {
    use super::*;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::NativeArray_::count;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_init;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofArray;
    use fable_library_rust::Seq_::toArray;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::contains as contains_1;
    use fable_library_rust::String_::endsWith;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::join;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::padRight;
    use fable_library_rust::String_::replace as replace_1;
    use fable_library_rust::String_::split as split_1;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::startsWith;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::substring2;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::toUpper;
    use fable_library_rust::String_::trim as trim_1;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Exception;
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i32>,
        pub l1: MutCell<string>,
    }
    impl core::fmt::Display for Sm::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<i32>,
    }
    impl core::fmt::Display for Sm::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn closure1(v0_1: string, v1_1: string) -> bool {
        contains_1(v1_1, v0_1)
    }
    pub fn closure0(unitVar: (), v0_1: string) -> Func1<string, bool> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Sm::closure1(v0_1.clone(), v)
        })
    }
    pub fn closure3(v0_1: string, v1_1: string) -> bool {
        endsWith(v1_1, v0_1, false)
    }
    pub fn closure2(unitVar: (), v0_1: string) -> Func1<string, bool> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Sm::closure3(v0_1.clone(), v)
        })
    }
    pub fn closure6(v0_1: i32, v1_1: char, v2_1: string) -> string {
        padLeft(v2_1, v0_1, v1_1)
    }
    pub fn closure5(v0_1: i32, v1_1: char) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Sm::closure6(v0_1, v1_1, v)
        })
    }
    pub fn closure4(unitVar: (), v0_1: i32) -> Func1<char, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: char| Sm::closure5(v0_1, v)
        })
    }
    pub fn closure9(v0_1: i32, v1_1: char, v2_1: string) -> string {
        padRight(v2_1, v0_1, v1_1)
    }
    pub fn closure8(v0_1: i32, v1_1: char) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Sm::closure9(v0_1, v1_1, v)
        })
    }
    pub fn closure7(unitVar: (), v0_1: i32) -> Func1<char, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: char| Sm::closure8(v0_1, v)
        })
    }
    pub fn closure12(v0_1: string, v1_1: string, v2_1: string) -> string {
        replace_1(v2_1, v0_1, v1_1)
    }
    pub fn closure11(v0_1: string, v1_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Sm::closure12(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure10(unitVar: (), v0_1: string) -> Func1<string, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Sm::closure11(v0_1.clone(), v)
        })
    }
    pub fn method0(v0_1: string) -> string {
        v0_1
    }
    pub fn method1(v0_1: string) -> string {
        v0_1
    }
    pub fn method2(v0_1: string) -> string {
        v0_1
    }
    pub fn closure15(v0_1: string, v1_1: string, v2_1: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v3.set(Some(x))
        }
        getValue(_v3.get().clone())
    }
    pub fn closure14(v0_1: string, v1_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Sm::closure15(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure13(unitVar: (), v0_1: string) -> Func1<string, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Sm::closure14(v0_1.clone(), v)
        })
    }
    pub fn closure18(v0_1: i32, v1_1: i32, v2_1: string) -> string {
        getSlice(v2_1, Some(v0_1), Some(v1_1))
    }
    pub fn closure17(v0_1: i32, v1_1: i32) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Sm::closure18(v0_1, v1_1, v)
        })
    }
    pub fn closure16(unitVar: (), v0_1: i32) -> Func1<i32, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Sm::closure17(v0_1, v)
        })
    }
    pub fn closure20(v0_1: string, v1_1: string) -> Array<string> {
        split_1(v1_1, v0_1, -1_i32, 0_i32)
    }
    pub fn closure19(unitVar: (), v0_1: string) -> Func1<string, Array<string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Sm::closure20(v0_1.clone(), v)
        })
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn closure22(v0_1: Array<string>, v1_1: string) -> Array<string> {
        let _v2: MutCell<Option<Array<string>>> = MutCell::new(None::<Array<string>>);
        let v12_1: LrcPtr<dyn IEnumerable_1<string>> = ofArray(v0_1);
        {
            let x: Array<string> =
                split_1(v1_1, join(Sm::method3(), toArray(v12_1)), -1_i32, 0_i32);
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure21(unitVar: (), v0_1: Array<string>) -> Func1<string, Array<string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Sm::closure22(v0_1.clone(), v)
        })
    }
    pub fn closure24(v0_1: string, v1_1: string) -> bool {
        startsWith(v1_1, v0_1, false)
    }
    pub fn closure23(unitVar: (), v0_1: string) -> Func1<string, bool> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Sm::closure24(v0_1.clone(), v)
        })
    }
    pub fn closure27(v0_1: i32, v1_1: i32, v2_1: string) -> string {
        substring2(v2_1, v0_1, v1_1)
    }
    pub fn closure26(v0_1: i32, v1_1: i32) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Sm::closure27(v0_1, v1_1, v)
        })
    }
    pub fn closure25(unitVar: (), v0_1: i32) -> Func1<i32, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Sm::closure26(v0_1, v)
        })
    }
    pub fn closure28(unitVar: (), v0_1: string) -> string {
        toLower(v0_1)
    }
    pub fn closure29(unitVar: (), v0_1: string) -> string {
        toUpper(v0_1)
    }
    pub fn closure30(unitVar: (), v0_1: string) -> string {
        trim_1(v0_1)
    }
    pub fn closure32(v0_1: Array<char>, v1_1: string) -> string {
        trimEndChars(v1_1, v0_1)
    }
    pub fn closure31(unitVar: (), v0_1: Array<char>) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Sm::closure32(v0_1.clone(), v)
        })
    }
    pub fn closure34(v0_1: Array<char>, v1_1: string) -> string {
        trimStartChars(v1_1, v0_1)
    }
    pub fn closure33(unitVar: (), v0_1: Array<char>) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Sm::closure34(v0_1.clone(), v)
        })
    }
    pub fn closure36(v0_1: i32, v1_1: string) -> string {
        if length(v1_1.clone()) <= v0_1 {
            v1_1.clone()
        } else {
            append(
                getSlice(v1_1, Some(0_i32), Some(v0_1 - 1_i32)),
                string("..."),
            )
        }
    }
    pub fn closure35(unitVar: (), v0_1: i32) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Sm::closure36(v0_1, v)
        })
    }
    pub fn closure38(v0_1: i64, v1_1: string) -> string {
        let v2_1: i64 = length(v1_1.clone()) as i64;
        if v2_1 <= v0_1 {
            v1_1.clone()
        } else {
            let v5_1: f64 = v0_1 as f64 / 2.0_f64;
            let v8_1: i64 = v5_1.ceil() as i64;
            let v11_1: i64 = v5_1.floor() as i64;
            let v20_1: LrcPtr<dyn IEnumerable_1<string>> = ofArray(new_array(&[
                getSlice(
                    v1_1.clone(),
                    Some(0_i64 as i32),
                    Some((v8_1 - 1_i64) as i32),
                ),
                string("..."),
                getSlice(
                    v1_1,
                    Some((v2_1 - v11_1) as i32),
                    Some((v2_1 - 1_i64) as i32),
                ),
            ]));
            join(Sm::method3(), toArray(v20_1))
        }
    }
    pub fn closure37(unitVar: (), v0_1: i64) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Sm::closure38(v0_1, v)
        })
    }
    pub fn closure39(unitVar: (), v0_1: LrcPtr<Exception>) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v0_1);
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn method4(v0_1: i32, v1_1: LrcPtr<Sm::Mut0>) -> bool {
        v1_1.l0.get().clone() < v0_1
    }
    pub fn closure41(v0_1: string, v1_1: Array<string>) -> string {
        let v2_1: i32 = count(v1_1.clone());
        let v4_1: LrcPtr<Sm::Mut0> = LrcPtr::new(Sm::Mut0 {
            l0: MutCell::new(0_i32),
            l1: MutCell::new(string("")),
        });
        while Sm::method4(v2_1, v4_1.clone()) {
            let v6_1: i32 = v4_1.l0.get().clone();
            let v9_1: string = append(
                append(
                    append(v4_1.l1.get().clone(), v1_1[v6_1].clone()),
                    v0_1.clone(),
                ),
                string(""),
            );
            let v10_1: i32 = v6_1 + 1_i32;
            v4_1.l0.set(v10_1);
            v4_1.l1.set(v9_1);
            ()
        }
        v4_1.l1.get().clone()
    }
    pub fn closure40(unitVar: (), v0_1: string) -> Func1<Array<string>, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Array<string>| Sm::closure41(v0_1.clone(), v)
        })
    }
    pub fn method5(v0_1: string) -> string {
        v0_1
    }
    pub fn closure43(v0_1: string, v1_1: LrcPtr<dyn IEnumerable_1<string>>) -> string {
        join(Sm::method5(v0_1), toArray(v1_1))
    }
    pub fn closure42(
        unitVar: (),
        v0_1: string,
    ) -> Func1<LrcPtr<dyn IEnumerable_1<string>>, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: LrcPtr<dyn IEnumerable_1<string>>| Sm::closure43(v0_1.clone(), v)
        })
    }
    pub fn closure45(v0_1: string, v1_1: Array<string>) -> string {
        join(v0_1, v1_1)
    }
    pub fn closure44(unitVar: (), v0_1: string) -> Func1<Array<string>, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Array<string>| Sm::closure45(v0_1.clone(), v)
        })
    }
    pub fn method6(v0_1: i32, v1_1: LrcPtr<Sm::Mut1>) -> bool {
        v1_1.l0.get().clone() < v0_1
    }
    pub fn closure46(unitVar: (), v0_1: string) -> Array<char> {
        let v1_1: i32 = length(v0_1.clone());
        let v2_1: Array<char> = new_init(&'\u{0000}', v1_1);
        let v3_1: LrcPtr<Sm::Mut1> = LrcPtr::new(Sm::Mut1 {
            l0: MutCell::new(0_i32),
        });
        while Sm::method6(v1_1, v3_1.clone()) {
            let v5_1: i32 = v3_1.l0.get().clone();
            let v6_1: char = getCharAt(v0_1.clone(), v5_1);
            v2_1.get_mut()[v5_1 as usize] = v6_1;
            {
                let v7_1: i32 = v5_1 + 1_i32;
                v3_1.l0.set(v7_1);
                ()
            }
        }
        v2_1.clone()
    }
    pub fn v0() -> Func1<string, Func1<string, bool>> {
        static v0: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v0.get_or_init(|| Func1::new(move |v: string| Sm::closure0((), v)))
            .clone()
    }
    pub fn contains(x: string) -> Func1<string, bool> {
        (Sm::v0())(x)
    }
    pub fn v1() -> Func1<string, Func1<string, bool>> {
        static v1: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v1.get_or_init(|| Func1::new(move |v: string| Sm::closure2((), v)))
            .clone()
    }
    pub fn ends_with(x: string) -> Func1<string, bool> {
        (Sm::v1())(x)
    }
    pub fn v2() -> Func1<i32, Func1<char, Func1<string, string>>> {
        static v2: OnceInit<Func1<i32, Func1<char, Func1<string, string>>>> = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: i32| Sm::closure4((), v)))
            .clone()
    }
    pub fn pad_left(x: i32) -> Func1<char, Func1<string, string>> {
        (Sm::v2())(x)
    }
    pub fn v3() -> Func1<i32, Func1<char, Func1<string, string>>> {
        static v3: OnceInit<Func1<i32, Func1<char, Func1<string, string>>>> = OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: i32| Sm::closure7((), v)))
            .clone()
    }
    pub fn pad_right(x: i32) -> Func1<char, Func1<string, string>> {
        (Sm::v3())(x)
    }
    pub fn v4() -> Func1<string, Func1<string, Func1<string, string>>> {
        static v4: OnceInit<Func1<string, Func1<string, Func1<string, string>>>> = OnceInit::new();
        v4.get_or_init(|| Func1::new(move |v: string| Sm::closure10((), v)))
            .clone()
    }
    pub fn replace(x: string) -> Func1<string, Func1<string, string>> {
        (Sm::v4())(x)
    }
    pub fn v5() -> Func1<string, Func1<string, Func1<string, string>>> {
        static v5: OnceInit<Func1<string, Func1<string, Func1<string, string>>>> = OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: string| Sm::closure13((), v)))
            .clone()
    }
    pub fn replace_regex(x: string) -> Func1<string, Func1<string, string>> {
        (Sm::v5())(x)
    }
    pub fn v6() -> Func1<i32, Func1<i32, Func1<string, string>>> {
        static v6: OnceInit<Func1<i32, Func1<i32, Func1<string, string>>>> = OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: i32| Sm::closure16((), v)))
            .clone()
    }
    pub fn slice(x: i32) -> Func1<i32, Func1<string, string>> {
        (Sm::v6())(x)
    }
    pub fn v7() -> Func1<string, Func1<string, Array<string>>> {
        static v7: OnceInit<Func1<string, Func1<string, Array<string>>>> = OnceInit::new();
        v7.get_or_init(|| Func1::new(move |v: string| Sm::closure19((), v)))
            .clone()
    }
    pub fn split(x: string) -> Func1<string, Array<string>> {
        (Sm::v7())(x)
    }
    pub fn v8() -> Func1<Array<string>, Func1<string, Array<string>>> {
        static v8: OnceInit<Func1<Array<string>, Func1<string, Array<string>>>> = OnceInit::new();
        v8.get_or_init(|| Func1::new(move |v: Array<string>| Sm::closure21((), v)))
            .clone()
    }
    pub fn split_string(x: Array<string>) -> Func1<string, Array<string>> {
        (Sm::v8())(x)
    }
    pub fn v9() -> Func1<string, Func1<string, bool>> {
        static v9: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v9.get_or_init(|| Func1::new(move |v: string| Sm::closure23((), v)))
            .clone()
    }
    pub fn starts_with(x: string) -> Func1<string, bool> {
        (Sm::v9())(x)
    }
    pub fn v10() -> Func1<i32, Func1<i32, Func1<string, string>>> {
        static v10: OnceInit<Func1<i32, Func1<i32, Func1<string, string>>>> = OnceInit::new();
        v10.get_or_init(|| Func1::new(move |v: i32| Sm::closure25((), v)))
            .clone()
    }
    pub fn substring(x: i32) -> Func1<i32, Func1<string, string>> {
        (Sm::v10())(x)
    }
    pub fn v11() -> Func1<string, string> {
        static v11: OnceInit<Func1<string, string>> = OnceInit::new();
        v11.get_or_init(|| Func1::new(move |v: string| Sm::closure28((), v)))
            .clone()
    }
    pub fn to_lower(x: string) -> string {
        (Sm::v11())(x)
    }
    pub fn v12() -> Func1<string, string> {
        static v12: OnceInit<Func1<string, string>> = OnceInit::new();
        v12.get_or_init(|| Func1::new(move |v: string| Sm::closure29((), v)))
            .clone()
    }
    pub fn to_upper(x: string) -> string {
        (Sm::v12())(x)
    }
    pub fn v13() -> Func1<string, string> {
        static v13: OnceInit<Func1<string, string>> = OnceInit::new();
        v13.get_or_init(|| Func1::new(move |v: string| Sm::closure30((), v)))
            .clone()
    }
    pub fn trim(x: string) -> string {
        (Sm::v13())(x)
    }
    pub fn v14() -> Func1<Array<char>, Func1<string, string>> {
        static v14: OnceInit<Func1<Array<char>, Func1<string, string>>> = OnceInit::new();
        v14.get_or_init(|| Func1::new(move |v: Array<char>| Sm::closure31((), v)))
            .clone()
    }
    pub fn trim_end(x: Array<char>) -> Func1<string, string> {
        (Sm::v14())(x)
    }
    pub fn v15() -> Func1<Array<char>, Func1<string, string>> {
        static v15: OnceInit<Func1<Array<char>, Func1<string, string>>> = OnceInit::new();
        v15.get_or_init(|| Func1::new(move |v: Array<char>| Sm::closure33((), v)))
            .clone()
    }
    pub fn trim_start(x: Array<char>) -> Func1<string, string> {
        (Sm::v15())(x)
    }
    pub fn v16() -> Func1<i32, Func1<string, string>> {
        static v16: OnceInit<Func1<i32, Func1<string, string>>> = OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: i32| Sm::closure35((), v)))
            .clone()
    }
    pub fn ellipsis(x: i32) -> Func1<string, string> {
        (Sm::v16())(x)
    }
    pub fn v17() -> Func1<i64, Func1<string, string>> {
        static v17: OnceInit<Func1<i64, Func1<string, string>>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: i64| Sm::closure37((), v)))
            .clone()
    }
    pub fn ellipsis_end(x: i64) -> Func1<string, string> {
        (Sm::v17())(x)
    }
    pub fn v18() -> Func1<LrcPtr<Exception>, string> {
        static v18: OnceInit<Func1<LrcPtr<Exception>, string>> = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: LrcPtr<Exception>| Sm::closure39((), v)))
            .clone()
    }
    pub fn format_exception(x: LrcPtr<Exception>) -> string {
        (Sm::v18())(x)
    }
    pub fn v19() -> Func1<string, Func1<Array<string>, string>> {
        static v19: OnceInit<Func1<string, Func1<Array<string>, string>>> = OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: string| Sm::closure40((), v)))
            .clone()
    }
    pub fn concat_array_trailing(x: string) -> Func1<Array<string>, string> {
        (Sm::v19())(x)
    }
    pub fn v20() -> Func1<string, Func1<LrcPtr<dyn IEnumerable_1<string>>, string>> {
        static v20: OnceInit<Func1<string, Func1<LrcPtr<dyn IEnumerable_1<string>>, string>>> =
            OnceInit::new();
        v20.get_or_init(|| Func1::new(move |v: string| Sm::closure42((), v)))
            .clone()
    }
    pub fn concat(x: string) -> Func1<LrcPtr<dyn IEnumerable_1<string>>, string> {
        (Sm::v20())(x)
    }
    pub fn v21() -> Func1<string, Func1<Array<string>, string>> {
        static v21: OnceInit<Func1<string, Func1<Array<string>, string>>> = OnceInit::new();
        v21.get_or_init(|| Func1::new(move |v: string| Sm::closure44((), v)))
            .clone()
    }
    pub fn join_(x: string) -> Func1<Array<string>, string> {
        (Sm::v21())(x)
    }
    pub fn v22() -> Func1<string, Array<char>> {
        static v22: OnceInit<Func1<string, Array<char>>> = OnceInit::new();
        v22.get_or_init(|| Func1::new(move |v: string| Sm::closure46((), v)))
            .clone()
    }
    pub fn to_char_array(x: string) -> Array<char> {
        (Sm::v22())(x)
    }
    on_startup!(());
}
