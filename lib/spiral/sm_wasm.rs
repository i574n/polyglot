pub mod Sm {
    use super::*;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::List_::cons;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::foldBack;
    use fable_library_rust::List_::ofArray as ofArray_1;
    use fable_library_rust::List_::toArray as toArray_1;
    use fable_library_rust::List_::List;
    use fable_library_rust::NativeArray_::count;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_init;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Func2;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
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
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum UH0 {
        UH0_0,
        UH0_1(char, LrcPtr<Sm::UH0>),
    }
    impl core::fmt::Display for Sm::UH0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
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
    pub fn closure1(v0: string, v1: string) -> bool {
        contains_1(v1, v0)
    }
    pub fn closure0(unitVar: (), v0: string) -> Func1<string, bool> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| Sm::closure1(v0.clone(), v)
        })
    }
    pub fn closure3(v0: string, v1: string) -> bool {
        endsWith(v1, v0, false)
    }
    pub fn closure2(unitVar: (), v0: string) -> Func1<string, bool> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| Sm::closure3(v0.clone(), v)
        })
    }
    pub fn closure6(v0: i32, v1: char, v2: string) -> string {
        padLeft(v2, v0, v1)
    }
    pub fn closure5(v0: i32, v1: char) -> Func1<string, string> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: string| Sm::closure6(v0, v1, v)
        })
    }
    pub fn closure4(unitVar: (), v0: i32) -> Func1<char, Func1<string, string>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: char| Sm::closure5(v0, v)
        })
    }
    pub fn closure9(v0: i32, v1: char, v2: string) -> string {
        padRight(v2, v0, v1)
    }
    pub fn closure8(v0: i32, v1: char) -> Func1<string, string> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: string| Sm::closure9(v0, v1, v)
        })
    }
    pub fn closure7(unitVar: (), v0: i32) -> Func1<char, Func1<string, string>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: char| Sm::closure8(v0, v)
        })
    }
    pub fn closure12(v0: string, v1: string, v2: string) -> string {
        replace_1(v2, v0, v1)
    }
    pub fn closure11(v0: string, v1: string) -> Func1<string, string> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: string| Sm::closure12(v0.clone(), v1.clone(), v)
        })
    }
    pub fn closure10(unitVar: (), v0: string) -> Func1<string, Func1<string, string>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| Sm::closure11(v0.clone(), v)
        })
    }
    pub fn method0(v0: string) -> string {
        v0
    }
    pub fn method1(v0: string) -> string {
        v0
    }
    pub fn method2(v0: string) -> string {
        v0
    }
    pub fn closure15(v0: string, v1: string, v2: string) -> string {
        let v3: string = Sm::method0(v1);
        let _v6: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v6.set(Some(x))
        }
        match &_v6.get().clone() {
            None => panic!("{}", string("base.run_target / _v6=None"),),
            Some(_v6_0_0) => _v6_0_0.clone(),
        }
    }
    pub fn closure14(v0: string, v1: string) -> Func1<string, string> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: string| Sm::closure15(v0.clone(), v1.clone(), v)
        })
    }
    pub fn closure13(unitVar: (), v0: string) -> Func1<string, Func1<string, string>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| Sm::closure14(v0.clone(), v)
        })
    }
    pub fn closure18(v0: i32, v1: i32, v2: string) -> string {
        getSlice(v2, Some(v0), Some(v1))
    }
    pub fn closure17(v0: i32, v1: i32) -> Func1<string, string> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: string| Sm::closure18(v0, v1, v)
        })
    }
    pub fn closure16(unitVar: (), v0: i32) -> Func1<i32, Func1<string, string>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: i32| Sm::closure17(v0, v)
        })
    }
    pub fn closure20(v0: string, v1: string) -> Array<string> {
        split_1(v1, v0, -1_i32, 0_i32)
    }
    pub fn closure19(unitVar: (), v0: string) -> Func1<string, Array<string>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| Sm::closure20(v0.clone(), v)
        })
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn closure22(v0: Array<string>, v1: string) -> Array<string> {
        let _v4: MutCell<Option<Array<string>>> = MutCell::new(None::<Array<string>>);
        let v29_1: LrcPtr<dyn IEnumerable_1<string>> = ofArray(v0);
        {
            let x: Array<string> = split_1(v1, join(Sm::method3(), toArray(v29_1)), -1_i32, 0_i32);
            _v4.set(Some(x))
        }
        match &_v4.get().clone() {
            None => panic!("{}", string("base.run_target / _v4=None"),),
            Some(_v4_0_0) => _v4_0_0.clone(),
        }
    }
    pub fn closure21(unitVar: (), v0: Array<string>) -> Func1<string, Array<string>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| Sm::closure22(v0.clone(), v)
        })
    }
    pub fn closure24(v0: string, v1: string) -> bool {
        startsWith(v1, v0, false)
    }
    pub fn closure23(unitVar: (), v0: string) -> Func1<string, bool> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| Sm::closure24(v0.clone(), v)
        })
    }
    pub fn closure27(v0: i32, v1: i32, v2: string) -> string {
        substring2(v2, v0, v1)
    }
    pub fn closure26(v0: i32, v1: i32) -> Func1<string, string> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: string| Sm::closure27(v0, v1, v)
        })
    }
    pub fn closure25(unitVar: (), v0: i32) -> Func1<i32, Func1<string, string>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: i32| Sm::closure26(v0, v)
        })
    }
    pub fn closure28(unitVar: (), v0: string) -> string {
        toLower(v0)
    }
    pub fn closure29(unitVar: (), v0: string) -> string {
        toUpper(v0)
    }
    pub fn closure30(unitVar: (), v0: string) -> string {
        trim_1(v0)
    }
    pub fn closure33(v0: char, v1: LrcPtr<Sm::UH0>) -> LrcPtr<Sm::UH0> {
        LrcPtr::new(Sm::UH0::UH0_1(v0, v1))
    }
    pub fn closure32(unitVar: (), v0: char) -> Func1<LrcPtr<Sm::UH0>, LrcPtr<Sm::UH0>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: LrcPtr<Sm::UH0>| Sm::closure33(v0, v)
        })
    }
    pub fn method4() -> Func1<char, Func1<LrcPtr<Sm::UH0>, LrcPtr<Sm::UH0>>> {
        Func1::new(move |v: char| Sm::closure32((), v))
    }
    pub fn method5(v0: LrcPtr<Sm::UH0>, v1: List<char>) -> List<char> {
        match v0.as_ref() {
            Sm::UH0::UH0_0 => v1.clone(),
            Sm::UH0::UH0_1(v0_1_0, v0_1_1) => cons(
                match v0.as_ref() {
                    Sm::UH0::UH0_1(x, _) => x.clone(),
                    _ => unreachable!(),
                },
                Sm::method5(
                    match v0.as_ref() {
                        Sm::UH0::UH0_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                    v1.clone(),
                ),
            ),
        }
    }
    pub fn closure34(v0: LrcPtr<Sm::UH0>, v1: string) -> string {
        trimEndChars(v1, toArray_1(Sm::method5(v0, empty::<char>())))
    }
    pub fn closure31(unitVar: (), v0: Array<char>) -> Func1<string, string> {
        let v1: List<char> = ofArray_1(v0);
        let v9: LrcPtr<Sm::UH0> = foldBack(
            Func2::new(move |b0: char, b1: LrcPtr<Sm::UH0>| (Sm::method4())(b0)(b1)),
            v1,
            LrcPtr::new(Sm::UH0::UH0_0),
        );
        Func1::new({
            let v9 = v9.clone();
            move |v: string| Sm::closure34(v9.clone(), v)
        })
    }
    pub fn closure36(v0: LrcPtr<Sm::UH0>, v1: string) -> string {
        trimStartChars(v1, toArray_1(Sm::method5(v0, empty::<char>())))
    }
    pub fn closure35(unitVar: (), v0: Array<char>) -> Func1<string, string> {
        let v1: List<char> = ofArray_1(v0);
        let v9: LrcPtr<Sm::UH0> = foldBack(
            Func2::new(move |b0: char, b1: LrcPtr<Sm::UH0>| (Sm::method4())(b0)(b1)),
            v1,
            LrcPtr::new(Sm::UH0::UH0_0),
        );
        Func1::new({
            let v9 = v9.clone();
            move |v: string| Sm::closure36(v9.clone(), v)
        })
    }
    pub fn closure38(v0: i32, v1: string) -> string {
        if length(v1.clone()) <= v0 {
            v1.clone()
        } else {
            append(getSlice(v1, Some(0_i32), Some(v0 - 1_i32)), string("..."))
        }
    }
    pub fn closure37(unitVar: (), v0: i32) -> Func1<string, string> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| Sm::closure38(v0, v)
        })
    }
    pub fn method6(v0: i64, v1: string) -> string {
        let v2: i64 = length(v1.clone()) as i64;
        if v2 <= v0 {
            v1.clone()
        } else {
            let v6: f64 = v0 as f64 / 2.0_f64;
            let v10: i64 = v6.ceil() as i64;
            let v14: i64 = v6.floor() as i64;
            join(
                string(""),
                toArray(ofArray(new_array(&[
                    getSlice(v1.clone(), Some(0_i64 as i32), Some((v10 - 1_i64) as i32)),
                    string("..."),
                    getSlice(v1, Some((v2 - v14) as i32), Some((v2 - 1_i64) as i32)),
                ]))),
            )
        }
    }
    pub fn closure40(v0: i64, v1: string) -> string {
        Sm::method6(v0, v1)
    }
    pub fn closure39(unitVar: (), v0: i64) -> Func1<string, string> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| Sm::closure40(v0, v)
        })
    }
    pub fn closure41(unitVar: (), v0: LrcPtr<Exception>) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v0);
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method7(v0: i32, v1: LrcPtr<Sm::Mut0>) -> bool {
        v1.l0.get().clone() < v0
    }
    pub fn closure43(v0: string, v1: Array<string>) -> string {
        let v2: i32 = count(v1.clone());
        let v4: LrcPtr<Sm::Mut0> = LrcPtr::new(Sm::Mut0 {
            l0: MutCell::new(0_i32),
            l1: MutCell::new(string("")),
        });
        while Sm::method7(v2, v4.clone()) {
            let v6: i32 = v4.l0.get().clone();
            let v9: string = append(
                append(append(v4.l1.get().clone(), v1[v6].clone()), v0.clone()),
                string(""),
            );
            let v10: i32 = v6 + 1_i32;
            v4.l0.set(v10);
            v4.l1.set(v9);
            ()
        }
        v4.l1.get().clone()
    }
    pub fn closure42(unitVar: (), v0: string) -> Func1<Array<string>, string> {
        Func1::new({
            let v0 = v0.clone();
            move |v: Array<string>| Sm::closure43(v0.clone(), v)
        })
    }
    pub fn closure45(v0: string, v1: LrcPtr<dyn IEnumerable_1<string>>) -> string {
        join(v0, toArray(v1))
    }
    pub fn closure44(unitVar: (), v0: string) -> Func1<LrcPtr<dyn IEnumerable_1<string>>, string> {
        Func1::new({
            let v0 = v0.clone();
            move |v: LrcPtr<dyn IEnumerable_1<string>>| Sm::closure45(v0.clone(), v)
        })
    }
    pub fn closure47(v0: string, v1: Array<string>) -> string {
        join(v0, v1)
    }
    pub fn closure46(unitVar: (), v0: string) -> Func1<Array<string>, string> {
        Func1::new({
            let v0 = v0.clone();
            move |v: Array<string>| Sm::closure47(v0.clone(), v)
        })
    }
    pub fn method8(v0: i32, v1: LrcPtr<Sm::Mut1>) -> bool {
        v1.l0.get().clone() < v0
    }
    pub fn closure48(unitVar: (), v0: string) -> Array<char> {
        let v1: i32 = length(v0.clone());
        let v2: Array<char> = new_init(&'\u{0000}', v1);
        let v3: LrcPtr<Sm::Mut1> = LrcPtr::new(Sm::Mut1 {
            l0: MutCell::new(0_i32),
        });
        while Sm::method8(v1, v3.clone()) {
            let v5: i32 = v3.l0.get().clone();
            let v6: char = getCharAt(v0.clone(), v5);
            v2.get_mut()[v5 as usize] = v6;
            {
                let v7: i32 = v5 + 1_i32;
                v3.l0.set(v7);
                ()
            }
        }
        v2.clone()
    }
    pub fn v24() -> Func1<string, Func1<string, bool>> {
        static v24: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v24.get_or_init(|| Func1::new(move |v: string| Sm::closure0((), v)))
            .clone()
    }
    pub fn contains(x: string) -> Func1<string, bool> {
        (Sm::v24())(x)
    }
    pub fn v25() -> Func1<string, Func1<string, bool>> {
        static v25: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v25.get_or_init(|| Func1::new(move |v: string| Sm::closure2((), v)))
            .clone()
    }
    pub fn ends_with(x: string) -> Func1<string, bool> {
        (Sm::v25())(x)
    }
    pub fn v26() -> Func1<i32, Func1<char, Func1<string, string>>> {
        static v26: OnceInit<Func1<i32, Func1<char, Func1<string, string>>>> = OnceInit::new();
        v26.get_or_init(|| Func1::new(move |v: i32| Sm::closure4((), v)))
            .clone()
    }
    pub fn pad_left(x: i32) -> Func1<char, Func1<string, string>> {
        (Sm::v26())(x)
    }
    pub fn v27() -> Func1<i32, Func1<char, Func1<string, string>>> {
        static v27: OnceInit<Func1<i32, Func1<char, Func1<string, string>>>> = OnceInit::new();
        v27.get_or_init(|| Func1::new(move |v: i32| Sm::closure7((), v)))
            .clone()
    }
    pub fn pad_right(x: i32) -> Func1<char, Func1<string, string>> {
        (Sm::v27())(x)
    }
    pub fn v28() -> Func1<string, Func1<string, Func1<string, string>>> {
        static v28: OnceInit<Func1<string, Func1<string, Func1<string, string>>>> = OnceInit::new();
        v28.get_or_init(|| Func1::new(move |v: string| Sm::closure10((), v)))
            .clone()
    }
    pub fn replace(x: string) -> Func1<string, Func1<string, string>> {
        (Sm::v28())(x)
    }
    pub fn v29() -> Func1<string, Func1<string, Func1<string, string>>> {
        static v29: OnceInit<Func1<string, Func1<string, Func1<string, string>>>> = OnceInit::new();
        v29.get_or_init(|| Func1::new(move |v: string| Sm::closure13((), v)))
            .clone()
    }
    pub fn replace_regex(x: string) -> Func1<string, Func1<string, string>> {
        (Sm::v29())(x)
    }
    pub fn v30() -> Func1<i32, Func1<i32, Func1<string, string>>> {
        static v30: OnceInit<Func1<i32, Func1<i32, Func1<string, string>>>> = OnceInit::new();
        v30.get_or_init(|| Func1::new(move |v: i32| Sm::closure16((), v)))
            .clone()
    }
    pub fn slice(x: i32) -> Func1<i32, Func1<string, string>> {
        (Sm::v30())(x)
    }
    pub fn v31() -> Func1<string, Func1<string, Array<string>>> {
        static v31: OnceInit<Func1<string, Func1<string, Array<string>>>> = OnceInit::new();
        v31.get_or_init(|| Func1::new(move |v: string| Sm::closure19((), v)))
            .clone()
    }
    pub fn split(x: string) -> Func1<string, Array<string>> {
        (Sm::v31())(x)
    }
    pub fn v32() -> Func1<Array<string>, Func1<string, Array<string>>> {
        static v32: OnceInit<Func1<Array<string>, Func1<string, Array<string>>>> = OnceInit::new();
        v32.get_or_init(|| Func1::new(move |v: Array<string>| Sm::closure21((), v)))
            .clone()
    }
    pub fn split_string(x: Array<string>) -> Func1<string, Array<string>> {
        (Sm::v32())(x)
    }
    pub fn v33() -> Func1<string, Func1<string, bool>> {
        static v33: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v33.get_or_init(|| Func1::new(move |v: string| Sm::closure23((), v)))
            .clone()
    }
    pub fn starts_with(x: string) -> Func1<string, bool> {
        (Sm::v33())(x)
    }
    pub fn v34() -> Func1<i32, Func1<i32, Func1<string, string>>> {
        static v34: OnceInit<Func1<i32, Func1<i32, Func1<string, string>>>> = OnceInit::new();
        v34.get_or_init(|| Func1::new(move |v: i32| Sm::closure25((), v)))
            .clone()
    }
    pub fn substring(x: i32) -> Func1<i32, Func1<string, string>> {
        (Sm::v34())(x)
    }
    pub fn v35() -> Func1<string, string> {
        static v35: OnceInit<Func1<string, string>> = OnceInit::new();
        v35.get_or_init(|| Func1::new(move |v: string| Sm::closure28((), v)))
            .clone()
    }
    pub fn to_lower(x: string) -> string {
        (Sm::v35())(x)
    }
    pub fn v36() -> Func1<string, string> {
        static v36: OnceInit<Func1<string, string>> = OnceInit::new();
        v36.get_or_init(|| Func1::new(move |v: string| Sm::closure29((), v)))
            .clone()
    }
    pub fn to_upper(x: string) -> string {
        (Sm::v36())(x)
    }
    pub fn v37() -> Func1<string, string> {
        static v37: OnceInit<Func1<string, string>> = OnceInit::new();
        v37.get_or_init(|| Func1::new(move |v: string| Sm::closure30((), v)))
            .clone()
    }
    pub fn trim(x: string) -> string {
        (Sm::v37())(x)
    }
    pub fn v38() -> Func1<Array<char>, Func1<string, string>> {
        static v38: OnceInit<Func1<Array<char>, Func1<string, string>>> = OnceInit::new();
        v38.get_or_init(|| Func1::new(move |v: Array<char>| Sm::closure31((), v)))
            .clone()
    }
    pub fn trim_end(x: Array<char>) -> Func1<string, string> {
        (Sm::v38())(x)
    }
    pub fn v39() -> Func1<Array<char>, Func1<string, string>> {
        static v39: OnceInit<Func1<Array<char>, Func1<string, string>>> = OnceInit::new();
        v39.get_or_init(|| Func1::new(move |v: Array<char>| Sm::closure35((), v)))
            .clone()
    }
    pub fn trim_start(x: Array<char>) -> Func1<string, string> {
        (Sm::v39())(x)
    }
    pub fn v40() -> Func1<i32, Func1<string, string>> {
        static v40: OnceInit<Func1<i32, Func1<string, string>>> = OnceInit::new();
        v40.get_or_init(|| Func1::new(move |v: i32| Sm::closure37((), v)))
            .clone()
    }
    pub fn ellipsis(x: i32) -> Func1<string, string> {
        (Sm::v40())(x)
    }
    pub fn v41() -> Func1<i64, Func1<string, string>> {
        static v41: OnceInit<Func1<i64, Func1<string, string>>> = OnceInit::new();
        v41.get_or_init(|| Func1::new(move |v: i64| Sm::closure39((), v)))
            .clone()
    }
    pub fn ellipsis_end(x: i64) -> Func1<string, string> {
        (Sm::v41())(x)
    }
    pub fn v42() -> Func1<LrcPtr<Exception>, string> {
        static v42: OnceInit<Func1<LrcPtr<Exception>, string>> = OnceInit::new();
        v42.get_or_init(|| Func1::new(move |v: LrcPtr<Exception>| Sm::closure41((), v)))
            .clone()
    }
    pub fn format_exception(x: LrcPtr<Exception>) -> string {
        (Sm::v42())(x)
    }
    pub fn v43() -> Func1<string, Func1<Array<string>, string>> {
        static v43: OnceInit<Func1<string, Func1<Array<string>, string>>> = OnceInit::new();
        v43.get_or_init(|| Func1::new(move |v: string| Sm::closure42((), v)))
            .clone()
    }
    pub fn concat_array_trailing(x: string) -> Func1<Array<string>, string> {
        (Sm::v43())(x)
    }
    pub fn v44() -> Func1<string, Func1<LrcPtr<dyn IEnumerable_1<string>>, string>> {
        static v44: OnceInit<Func1<string, Func1<LrcPtr<dyn IEnumerable_1<string>>, string>>> =
            OnceInit::new();
        v44.get_or_init(|| Func1::new(move |v: string| Sm::closure44((), v)))
            .clone()
    }
    pub fn concat(x: string) -> Func1<LrcPtr<dyn IEnumerable_1<string>>, string> {
        (Sm::v44())(x)
    }
    pub fn v45() -> Func1<string, Func1<Array<string>, string>> {
        static v45: OnceInit<Func1<string, Func1<Array<string>, string>>> = OnceInit::new();
        v45.get_or_init(|| Func1::new(move |v: string| Sm::closure46((), v)))
            .clone()
    }
    pub fn join_(x: string) -> Func1<Array<string>, string> {
        (Sm::v45())(x)
    }
    pub fn v46() -> Func1<string, Array<char>> {
        static v46: OnceInit<Func1<string, Array<char>>> = OnceInit::new();
        v46.get_or_init(|| Func1::new(move |v: string| Sm::closure48((), v)))
            .clone()
    }
    pub fn to_char_array(x: string) -> Array<char> {
        (Sm::v46())(x)
    }
    on_startup!(());
}
