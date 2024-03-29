pub mod Date_time {
    use super::*;
    use fable_library_rust::Convert_::toInt64;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Guid_::new_guid;
    use fable_library_rust::Guid_::parse;
    use fable_library_rust::Guid_::Guid;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toString;
    pub fn closure1(v0_1: Guid, v1_1: DateTime) -> Guid {
        let v2_1: string = toString(v0_1);
        let v3_1: string = v1_1.toString(string("yyyyMMdd-HHmm-ssff-ffff-f"));
        parse(sprintf!(
            "{}{}",
            v3_1.clone(),
            getSlice(v2_1, Some(length(v3_1)), None::<i32>)
        ))
    }
    pub fn closure0(unitVar: (), v0_1: Guid) -> Func1<DateTime, Guid> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: DateTime| Date_time::closure1(v0_1.clone(), v)
        })
    }
    pub fn closure5(v0_1: string, v1_1: string, v2_1: string) -> string {
        replace(v2_1, v0_1, v1_1)
    }
    pub fn closure4(v0_1: string, v1_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Date_time::closure5(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure3(unitVar: (), v0_1: string) -> Func1<string, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Date_time::closure4(v0_1.clone(), v)
        })
    }
    pub fn method0() -> Func1<string, Func1<string, Func1<string, string>>> {
        Func1::new(move |v: string| Date_time::closure3((), v))
    }
    pub fn closure2(unitVar: (), v0_1: Guid) -> DateTime {
        let v1_1: string = toString(v0_1);
        let result: MutCell<Option<DateTime>> = MutCell::new(None::<DateTime>);
        {
            let x: DateTime = DateTime::parse((Date_time::method0())(string("-"))(string(""))(
                getSlice(v1_1, None::<i32>, Some(24_i32)),
            ));
            result.set(Some(x))
        }
        getValue(result.get().clone())
    }
    pub fn closure7(v0_1: Guid, v1_1: i64) -> Guid {
        let v2_1: string = toString(v0_1);
        let v4_1: string = padLeft(toString(v1_1), 18_i32, '0');
        parse(sprintf!(
            "{}-{}-{}-{}{}",
            getSlice(v4_1.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v4_1.clone(), Some(8_i32), Some(11_i32)),
            getSlice(v4_1.clone(), Some(12_i32), Some(15_i32)),
            getSlice(v4_1, Some(16_i32), Some(17_i32)),
            getSlice(v2_1, Some(21_i32), None::<i32>)
        ))
    }
    pub fn closure6(unitVar: (), v0_1: Guid) -> Func1<i64, Guid> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i64| Date_time::closure7(v0_1.clone(), v)
        })
    }
    pub fn closure8(unitVar: (), v0_1: Guid) -> i64 {
        let v1_1: string = toString(v0_1);
        toInt64(sprintf!(
            "{}{}{}{}",
            getSlice(v1_1.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v1_1.clone(), Some(9_i32), Some(12_i32)),
            getSlice(v1_1.clone(), Some(14_i32), Some(17_i32)),
            getSlice(v1_1, Some(19_i32), Some(20_i32))
        ))
    }
    pub fn closure9(unitVar: (), v0_1: DateTime) -> Guid {
        let v2_1: string = toString(new_guid());
        let v3_1: string = v0_1.toString(string("yyyyMMdd-HHmm-ssff-ffff-f"));
        parse(sprintf!(
            "{}{}",
            v3_1.clone(),
            getSlice(v2_1, Some(length(v3_1)), None::<i32>)
        ))
    }
    pub fn closure10(unitVar: (), v0_1: i64) -> Guid {
        let v2_1: string = toString(new_guid());
        let v4_1: string = padLeft(toString(v0_1), 18_i32, '0');
        parse(sprintf!(
            "{}-{}-{}-{}{}",
            getSlice(v4_1.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v4_1.clone(), Some(8_i32), Some(11_i32)),
            getSlice(v4_1.clone(), Some(12_i32), Some(15_i32)),
            getSlice(v4_1, Some(16_i32), Some(17_i32)),
            getSlice(v2_1, Some(21_i32), None::<i32>)
        ))
    }
    pub fn v0() -> Func1<Guid, Func1<DateTime, Guid>> {
        static v0: OnceInit<Func1<Guid, Func1<DateTime, Guid>>> = OnceInit::new();
        v0.get_or_insert_with(|| Func1::new(move |v: Guid| Date_time::closure0((), v)))
            .clone()
    }
    pub fn date_time_guid_from_date_time(x: Guid) -> Func1<DateTime, Guid> {
        (Date_time::v0())(x)
    }
    pub fn v1() -> Func1<Guid, DateTime> {
        static v1: OnceInit<Func1<Guid, DateTime>> = OnceInit::new();
        v1.get_or_insert_with(|| Func1::new(move |v: Guid| Date_time::closure2((), v)))
            .clone()
    }
    pub fn date_time_from_guid(x: Guid) -> DateTime {
        (Date_time::v1())(x)
    }
    pub fn v2() -> Func1<Guid, Func1<i64, Guid>> {
        static v2: OnceInit<Func1<Guid, Func1<i64, Guid>>> = OnceInit::new();
        v2.get_or_insert_with(|| Func1::new(move |v: Guid| Date_time::closure6((), v)))
            .clone()
    }
    pub fn ticks_guid_from_ticks(x: Guid) -> Func1<i64, Guid> {
        (Date_time::v2())(x)
    }
    pub fn v3() -> Func1<Guid, i64> {
        static v3: OnceInit<Func1<Guid, i64>> = OnceInit::new();
        v3.get_or_insert_with(|| Func1::new(move |v: Guid| Date_time::closure8((), v)))
            .clone()
    }
    pub fn ticks_from_guid(x: Guid) -> i64 {
        (Date_time::v3())(x)
    }
    pub fn v4() -> Func1<DateTime, Guid> {
        static v4: OnceInit<Func1<DateTime, Guid>> = OnceInit::new();
        v4.get_or_insert_with(|| Func1::new(move |v: DateTime| Date_time::closure9((), v)))
            .clone()
    }
    pub fn new_guid_from_date_time(x: DateTime) -> Guid {
        (Date_time::v4())(x)
    }
    pub fn v5() -> Func1<i64, Guid> {
        static v5: OnceInit<Func1<i64, Guid>> = OnceInit::new();
        v5.get_or_insert_with(|| Func1::new(move |v: i64| Date_time::closure10((), v)))
            .clone()
    }
    pub fn new_guid_from_ticks(x: i64) -> Guid {
        (Date_time::v5())(x)
    }
    on_startup!((),);
}
