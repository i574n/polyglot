pub mod Date_time {
    use super::*;
    use fable_library_rust::Convert_::toInt64;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Guid_::new_guid;
    use fable_library_rust::Guid_::parse;
    use fable_library_rust::Guid_::Guid;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toString;
    use fable_library_rust::TimeSpan_::zero;
    use fable_library_rust::TimeSpan_::TimeSpan;
    type TimeZoneInfo = i64;
    #[derive(Clone, Debug)]
    pub enum US0 {
        US0_0(chrono::DateTime<chrono::Utc>),
        US0_1,
    }
    impl core::fmt::Display for Date_time::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(string),
        US1_1,
    }
    impl core::fmt::Display for Date_time::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0,
        US2_1,
        US2_2,
    }
    impl core::fmt::Display for Date_time::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(Date_time::US2),
        US3_1(Date_time::US2),
        US3_2(Date_time::US2),
        US3_3(Date_time::US2),
        US3_4(Date_time::US2),
    }
    impl core::fmt::Display for Date_time::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method1() -> string {
        string("hh:mm")
    }
    pub fn method2() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method3() -> string {
        string("hhmm")
    }
    pub fn method0(v0_1: Guid, v1_1: DateTime) -> Guid {
        let _v4: MutCell<Option<Guid>> = MutCell::new(None::<Guid>);
        let v339: DateTime = {
            let _arg: DateTime =
                DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
            _arg.toUniversalTime()
        };
        let v379: i64 = ({
            let _arg_2: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                _arg_1.toUniversalTime()
            };
            _arg_2.ticks()
        } - v339.ticks())
            / 10_i64;
        let v381: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v379);
        let _v384: LrcPtr<MutCell<Option<Date_time::US0>>> = refCell(None::<Date_time::US0>);
        {
            let x_2: Option<Date_time::US0> = match &v381 {
                None => None::<Date_time::US0>,
                Some(v381_0_0) => {
                    let x: chrono::DateTime<chrono::Utc> = v381_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Date_time::US0::US0_0(x.clone())
                    }))())
                }
            };
            _v384.set(x_2)
        }
        {
            let v411: Date_time::US0 = defaultValue(Date_time::US0::US0_1, _v384.get().clone());
            let v435: Date_time::US1 = match &v411 {
                Date_time::US0::US0_0(v411_0_0) => {
                    let v421: chrono::NaiveDateTime = match &v411 {
                        Date_time::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .naive_utc();
                    let v423: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v421);
                    let v425: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                    let v426: &str = r#"%Y%m%d-%H%M-%S%f"#;
                    let v428: std::string::String = v423.format(v426).to_string();
                    let v430: string = fable_library_rust::String_::fromString(v428);
                    Date_time::US1::US1_0(sprintf!(
                        "{}-{}-{}",
                        getSlice(v430.clone(), Some(0_i32), Some(17_i32)),
                        getSlice(v430.clone(), Some(18_i32), Some(21_i32)),
                        getCharAt(v430, 22_i32)
                    ))
                }
                _ => Date_time::US1::US1_1,
            };
            let v439: string = match &v435 {
                Date_time::US1::US1_0(v435_0_0) => match &v435 {
                    Date_time::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            };
            let _v442: MutCell<Option<LrcPtr<TimeZoneInfo>>> =
                MutCell::new(None::<LrcPtr<TimeZoneInfo>>);
            {
                let x_3: LrcPtr<TimeZoneInfo> = defaultOf();
                _v442.set(Some(x_3))
            }
            {
                let v482: LrcPtr<TimeZoneInfo> = match &_v442.get().clone() {
                    None => panic!("{}", string("base.run_target / _v442=None"),),
                    Some(_v442_0_0) => _v442_0_0.clone(),
                };
                let _v499: MutCell<Option<TimeSpan>> = MutCell::new(None::<TimeSpan>);
                _v499.set(Some(zero));
                {
                    let v598: TimeSpan = match &_v499.get().clone() {
                        None => panic!("{}", string("base.run_target / _v499=None"),),
                        Some(_v499_0_0) => _v499_0_0.clone(),
                    };
                    let v619: u8 = if v598.hours() > 0_i32 { 1_u8 } else { 0_u8 };
                    let v620: string = Date_time::method1();
                    let _v623: MutCell<Option<string>> = MutCell::new(None::<string>);
                    {
                        let x_7: string = v598.to_string(v620);
                        _v623.set(Some(x_7))
                    }
                    {
                        let v630: string = match &_v623.get().clone() {
                            None => panic!("{}", string("base.run_target / _v623=None"),),
                            Some(_v623_0_0) => _v623_0_0.clone(),
                        };
                        let v637: string = sprintf!(
                            "{}{}{}",
                            v619,
                            getSlice(v630.clone(), Some(0_i32), Some(1_i32)),
                            getSlice(v630, Some(3_i32), Some(4_i32))
                        );
                        {
                            let x_9: Guid = parse(sprintf!(
                                "{}{}{}",
                                v439.clone(),
                                v637.clone(),
                                getSlice(
                                    toString(v0_1),
                                    Some(length(v439) + length(v637)),
                                    None::<i32>
                                )
                            ));
                            _v4.set(Some(x_9))
                        }
                        match &_v4.get().clone() {
                            None => panic!("{}", string("base.run_target / _v4=None"),),
                            Some(_v4_0_0) => _v4_0_0.clone(),
                        }
                    }
                }
            }
        }
    }
    pub fn closure1(v0_1: Guid, v1_1: DateTime) -> Guid {
        Date_time::method0(v0_1, v1_1)
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
    pub fn method4() -> Func1<string, Func1<string, Func1<string, string>>> {
        Func1::new(move |v: string| Date_time::closure3((), v))
    }
    pub fn closure2(unitVar: (), v0_1: Guid) -> DateTime {
        let v4_1: string = toString(v0_1);
        let _v14: MutCell<Option<DateTime>> = MutCell::new(None::<DateTime>);
        {
            let x: DateTime = DateTime::parse((Date_time::method4())(string("-"))(string(""))(
                getSlice(v4_1, None::<i32>, Some(24_i32)),
            ));
            _v14.set(Some(x))
        }
        match &_v14.get().clone() {
            None => panic!("{}", string("base.run_target / _v14=None"),),
            Some(_v14_0_0) => _v14_0_0.clone(),
        }
    }
    pub fn closure7(v0_1: Guid, v1_1: i64) -> Guid {
        let v5_1: string = toString(v0_1);
        let v24: string = padLeft(toString(v1_1), 18_i32, '0');
        parse(sprintf!(
            "{}-{}-{}-{}{}",
            getSlice(v24.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v24.clone(), Some(8_i32), Some(11_i32)),
            getSlice(v24.clone(), Some(12_i32), Some(15_i32)),
            getSlice(v24, Some(16_i32), Some(17_i32)),
            getSlice(v5_1, Some(21_i32), None::<i32>)
        ))
    }
    pub fn closure6(unitVar: (), v0_1: Guid) -> Func1<i64, Guid> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i64| Date_time::closure7(v0_1.clone(), v)
        })
    }
    pub fn closure8(unitVar: (), v0_1: Guid) -> i64 {
        let v4_1: string = toString(v0_1);
        toInt64(sprintf!(
            "{}{}{}{}",
            getSlice(v4_1.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v4_1.clone(), Some(9_i32), Some(12_i32)),
            getSlice(v4_1.clone(), Some(14_i32), Some(17_i32)),
            getSlice(v4_1, Some(19_i32), Some(20_i32))
        ))
    }
    pub fn closure9(unitVar: (), v0_1: DateTime) -> Guid {
        Date_time::method0(new_guid(), v0_1)
    }
    pub fn closure10(unitVar: (), v0_1: i64) -> Guid {
        let v14: string = toString(new_guid());
        let v33: string = padLeft(toString(v0_1), 18_i32, '0');
        parse(sprintf!(
            "{}-{}-{}-{}{}",
            getSlice(v33.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v33.clone(), Some(8_i32), Some(11_i32)),
            getSlice(v33.clone(), Some(12_i32), Some(15_i32)),
            getSlice(v33, Some(16_i32), Some(17_i32)),
            getSlice(v14, Some(21_i32), None::<i32>)
        ))
    }
    pub fn closure12(v0_1: string, v1_1: DateTime) -> string {
        v1_1.toString(v0_1)
    }
    pub fn closure11(unitVar: (), v0_1: string) -> Func1<DateTime, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: DateTime| Date_time::closure12(v0_1.clone(), v)
        })
    }
    pub fn closure13(unitVar: (), v0_1: DateTime) -> string {
        v0_1.toString(string("yyyy-MM-ddTHH-mm-ss.fff"))
    }
    pub fn v0() -> Func1<Guid, Func1<DateTime, Guid>> {
        static v0: OnceInit<Func1<Guid, Func1<DateTime, Guid>>> = OnceInit::new();
        v0.get_or_init(|| Func1::new(move |v: Guid| Date_time::closure0((), v)))
            .clone()
    }
    pub fn date_time_guid_from_date_time(x: Guid) -> Func1<DateTime, Guid> {
        (Date_time::v0())(x)
    }
    pub fn v1() -> Func1<Guid, DateTime> {
        static v1: OnceInit<Func1<Guid, DateTime>> = OnceInit::new();
        v1.get_or_init(|| Func1::new(move |v: Guid| Date_time::closure2((), v)))
            .clone()
    }
    pub fn date_time_from_guid(x: Guid) -> DateTime {
        (Date_time::v1())(x)
    }
    pub fn v2() -> Func1<Guid, Func1<i64, Guid>> {
        static v2: OnceInit<Func1<Guid, Func1<i64, Guid>>> = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: Guid| Date_time::closure6((), v)))
            .clone()
    }
    pub fn timestamp_guid_from_timestamp(x: Guid) -> Func1<i64, Guid> {
        (Date_time::v2())(x)
    }
    pub fn v3() -> Func1<Guid, i64> {
        static v3: OnceInit<Func1<Guid, i64>> = OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: Guid| Date_time::closure8((), v)))
            .clone()
    }
    pub fn timestamp_from_guid(x: Guid) -> i64 {
        (Date_time::v3())(x)
    }
    pub fn v4() -> Func1<DateTime, Guid> {
        static v4: OnceInit<Func1<DateTime, Guid>> = OnceInit::new();
        v4.get_or_init(|| Func1::new(move |v: DateTime| Date_time::closure9((), v)))
            .clone()
    }
    pub fn new_guid_from_date_time(x: DateTime) -> Guid {
        (Date_time::v4())(x)
    }
    pub fn v5() -> Func1<i64, Guid> {
        static v5: OnceInit<Func1<i64, Guid>> = OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: i64| Date_time::closure10((), v)))
            .clone()
    }
    pub fn new_guid_from_timestamp(x: i64) -> Guid {
        (Date_time::v5())(x)
    }
    pub fn v6() -> Func1<string, Func1<DateTime, string>> {
        static v6: OnceInit<Func1<string, Func1<DateTime, string>>> = OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: string| Date_time::closure11((), v)))
            .clone()
    }
    pub fn format(x: string) -> Func1<DateTime, string> {
        (Date_time::v6())(x)
    }
    pub fn v7() -> Func1<DateTime, string> {
        static v7: OnceInit<Func1<DateTime, string>> = OnceInit::new();
        v7.get_or_init(|| Func1::new(move |v: DateTime| Date_time::closure13((), v)))
            .clone()
    }
    pub fn format_iso8601(x: DateTime) -> string {
        (Date_time::v7())(x)
    }
    on_startup!(());
}
