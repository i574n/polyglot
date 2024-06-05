pub mod Date_time {
    use super::*;
    use fable_library_rust::Convert_::toInt64;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Guid_::new_guid;
    use fable_library_rust::Guid_::parse;
    use fable_library_rust::Guid_::Guid;
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
    impl Date_time::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<Date_time::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<Date_time::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl Date_time::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<Date_time::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<Date_time::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl Date_time::US2 {
        pub fn get_IsUS2_0(this_: &MutCell<Date_time::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_1(this_: &MutCell<Date_time::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_2(this_: &MutCell<Date_time::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl Date_time::US3 {
        pub fn get_IsUS3_0(this_: &MutCell<Date_time::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_1(this_: &MutCell<Date_time::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_2(this_: &MutCell<Date_time::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_3(this_: &MutCell<Date_time::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_4(this_: &MutCell<Date_time::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Date_time::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method1(v0_1: chrono::DateTime<chrono::Utc>) -> chrono::DateTime<chrono::Utc> {
        v0_1
    }
    pub fn method2(v0_1: chrono::DateTime<chrono::Local>) -> chrono::DateTime<chrono::Local> {
        v0_1
    }
    pub fn method3() -> string {
        string("hh:mm")
    }
    pub fn method4() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method5() -> string {
        string("hhmm")
    }
    pub fn method0(v0_1: Guid, v1_1: DateTime) -> Guid {
        let _v2: MutCell<Option<Guid>> = MutCell::new(None::<Guid>);
        let v5_1: DateTime = {
            let _arg: DateTime =
                DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
            _arg.toUniversalTime()
        };
        let v15: i64 = ({
            let _arg_2: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                _arg_1.toUniversalTime()
            };
            _arg_2.ticks()
        } - v5_1.ticks())
            / 10_i64;
        let v17: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v15);
        let _v18: LrcPtr<MutCell<Option<Date_time::US0>>> = refCell(None::<Date_time::US0>);
        {
            let x_2: Option<Date_time::US0> = match &v17 {
                None => None::<Date_time::US0>,
                Some(v17_0_0) => {
                    let x: chrono::DateTime<chrono::Utc> = v17_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Date_time::US0::US0_0(x.clone())
                    }))())
                }
            };
            _v18.set(x_2)
        }
        {
            let v23: Date_time::US0 = defaultValue(Date_time::US0::US0_1, _v18.get().clone());
            let v42: Date_time::US1 = match &v23 {
                Date_time::US0::US0_0(v23_0_0) => {
                    let v25: chrono::DateTime<chrono::Utc> = Date_time::method1(match &v23 {
                        Date_time::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    });
                    let v27: chrono::NaiveDateTime = v25.naive_utc();
                    let v29: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v27);
                    let v31: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                    let v32: &str = r#"%Y%m%d-%H%M-%S%f"#;
                    let v33: chrono::DateTime<chrono::Local> = Date_time::method2(v29);
                    let v35: std::string::String = v33.format(v32).to_string();
                    let v37: string = fable_library_rust::String_::fromString(v35);
                    Date_time::US1::US1_0(sprintf!(
                        "{}-{}-{}",
                        getSlice(v37.clone(), Some(0_i32), Some(17_i32)),
                        getSlice(v37.clone(), Some(18_i32), Some(21_i32)),
                        getCharAt(v37, 22_i32)
                    ))
                }
                _ => Date_time::US1::US1_1,
            };
            let v46: string = match &v42 {
                Date_time::US1::US1_0(v42_0_0) => match &v42 {
                    Date_time::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            };
            let _v47: MutCell<Option<LrcPtr<TimeZoneInfo>>> =
                MutCell::new(None::<LrcPtr<TimeZoneInfo>>);
            {
                let x_3: LrcPtr<TimeZoneInfo> = 0i64.into();
                _v47.set(Some(x_3))
            }
            {
                let v55: LrcPtr<TimeZoneInfo> = match &_v47.get().clone() {
                    None => panic!("{}", string("base.run_target / _v47=None"),),
                    Some(_v47_0_0) => _v47_0_0.clone(),
                };
                let _v56: MutCell<Option<TimeSpan>> = MutCell::new(None::<TimeSpan>);
                _v56.set(Some(zero));
                {
                    let v83: TimeSpan = match &_v56.get().clone() {
                        None => panic!("{}", string("base.run_target / _v56=None"),),
                        Some(_v56_0_0) => _v56_0_0.clone(),
                    };
                    let v87: u8 = if v83.hours() > 0_i32 { 1_u8 } else { 0_u8 };
                    let v88: string = Date_time::method3();
                    let _v89: MutCell<Option<string>> = MutCell::new(None::<string>);
                    {
                        let x_7: string = v83.to_string(v88);
                        _v89.set(Some(x_7))
                    }
                    {
                        let v96: string = match &_v89.get().clone() {
                            None => panic!("{}", string("base.run_target / _v89=None"),),
                            Some(_v89_0_0) => _v89_0_0.clone(),
                        };
                        let v97: string = sprintf!(
                            "{}{}{}",
                            v87,
                            getSlice(v96.clone(), Some(0_i32), Some(1_i32)),
                            getSlice(v96, Some(3_i32), Some(4_i32))
                        );
                        {
                            let x_9: Guid = parse(sprintf!(
                                "{}{}{}",
                                v46.clone(),
                                v97.clone(),
                                getSlice(
                                    toString(v0_1),
                                    Some(length(v46) + length(v97)),
                                    None::<i32>
                                )
                            ));
                            _v2.set(Some(x_9))
                        }
                        match &_v2.get().clone() {
                            None => panic!("{}", string("base.run_target / _v2=None"),),
                            Some(_v2_0_0) => _v2_0_0.clone(),
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
    pub fn method6() -> Func1<string, Func1<string, Func1<string, string>>> {
        Func1::new(move |v: string| Date_time::closure3((), v))
    }
    pub fn closure2(unitVar: (), v0_1: Guid) -> DateTime {
        let v2_1: string = toString(v0_1);
        let _v4: MutCell<Option<DateTime>> = MutCell::new(None::<DateTime>);
        {
            let x: DateTime = DateTime::parse((Date_time::method6())(string("-"))(string(""))(
                getSlice(v2_1, None::<i32>, Some(24_i32)),
            ));
            _v4.set(Some(x))
        }
        match &_v4.get().clone() {
            None => panic!("{}", string("base.run_target / _v4=None"),),
            Some(_v4_0_0) => _v4_0_0.clone(),
        }
    }
    pub fn closure7(v0_1: Guid, v1_1: i64) -> Guid {
        let v3_1: string = toString(v0_1);
        let v6_1: string = padLeft(toString(v1_1), 18_i32, '0');
        parse(sprintf!(
            "{}-{}-{}-{}{}",
            getSlice(v6_1.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v6_1.clone(), Some(8_i32), Some(11_i32)),
            getSlice(v6_1.clone(), Some(12_i32), Some(15_i32)),
            getSlice(v6_1, Some(16_i32), Some(17_i32)),
            getSlice(v3_1, Some(21_i32), None::<i32>)
        ))
    }
    pub fn closure6(unitVar: (), v0_1: Guid) -> Func1<i64, Guid> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i64| Date_time::closure7(v0_1.clone(), v)
        })
    }
    pub fn closure8(unitVar: (), v0_1: Guid) -> i64 {
        let v2_1: string = toString(v0_1);
        toInt64(sprintf!(
            "{}{}{}{}",
            getSlice(v2_1.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v2_1.clone(), Some(9_i32), Some(12_i32)),
            getSlice(v2_1.clone(), Some(14_i32), Some(17_i32)),
            getSlice(v2_1, Some(19_i32), Some(20_i32))
        ))
    }
    pub fn closure9(unitVar: (), v0_1: DateTime) -> Guid {
        Date_time::method0(new_guid(), v0_1)
    }
    pub fn closure10(unitVar: (), v0_1: i64) -> Guid {
        let v4_1: string = toString(new_guid());
        let v7_1: string = padLeft(toString(v0_1), 18_i32, '0');
        parse(sprintf!(
            "{}-{}-{}-{}{}",
            getSlice(v7_1.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v7_1.clone(), Some(8_i32), Some(11_i32)),
            getSlice(v7_1.clone(), Some(12_i32), Some(15_i32)),
            getSlice(v7_1, Some(16_i32), Some(17_i32)),
            getSlice(v4_1, Some(21_i32), None::<i32>)
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
