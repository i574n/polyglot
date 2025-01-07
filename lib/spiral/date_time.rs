pub mod Date_time {
    use super::*;
    use fable_library_rust::Convert_::toInt64;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Guid_::new_guid;
    use fable_library_rust::Guid_::parse;
    use fable_library_rust::Guid_::Guid;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::map;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::concat;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::ofChar;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toString;
    use fable_library_rust::TimeSpan_::TimeSpan;
    type TimeZoneInfo = i64;
    #[derive(Clone, Debug)]
    pub enum US0 {
        US0_0(chrono::DateTime<chrono::Utc>),
        US0_1,
    }
    impl core::fmt::Display for US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US1 {
        US1_0(string),
        US1_1,
    }
    impl core::fmt::Display for US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US2 {
        US2_0,
        US2_1,
        US2_2,
    }
    impl core::fmt::Display for US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US3 {
        US3_0(Date_time::US2),
        US3_1(Date_time::US2),
        US3_2(Date_time::US2),
        US3_3(Date_time::US2),
        US3_4(Date_time::US2),
    }
    impl core::fmt::Display for US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn closure2(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> Date_time::US0 {
        Date_time::US0::US0_0(v0_1)
    }
    pub fn method1() -> Func1<chrono::DateTime<chrono::Utc>, Date_time::US0> {
        Func1::new(move |v: chrono::DateTime<chrono::Utc>| Date_time::closure2((), v))
    }
    pub fn method2() -> string {
        string("hh:mm")
    }
    pub fn method3() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method4() -> string {
        string("hhmm")
    }
    pub fn method0(v0_1: Guid, v1_1: DateTime) -> Guid {
        let v7_1: DateTime = {
            let _arg: DateTime = DateTime::unixEpoch();
            _arg.toUniversalTime()
        };
        let v15: DateTime = {
            let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
            _arg_1.toUniversalTime()
        };
        let v91: i64 = ((v15.ticks()) - (v7_1.ticks())) / 10_i64;
        let v93: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v91);
        let v107: Date_time::US0 =
            defaultValue(Date_time::US0::US0_1, map(Date_time::method1(), v93));
        let v127: Date_time::US1 = match &v107 {
            Date_time::US0::US0_0(v107_0_0) => {
                let v113: chrono::NaiveDateTime = match &v107 {
                    Date_time::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone()
                .naive_utc();
                let v115: chrono::DateTime<chrono::Local> =
                    chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v113);
                let v117: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                let v118: &str = r#"%Y%m%d-%H%M-%S%f"#;
                let v120: std::string::String = v115.format(v118).to_string();
                let v122: string = fable_library_rust::String_::fromString(v120);
                Date_time::US1::US1_0(sprintf!(
                    "{}-{}-{}",
                    getSlice(v122.clone(), Some(0_i32), Some(17_i32)),
                    getSlice(v122.clone(), Some(18_i32), Some(21_i32)),
                    getCharAt(v122, 22_i32)
                ))
            }
            _ => Date_time::US1::US1_1,
        };
        let v131: string = match &v127 {
            Date_time::US1::US1_0(v127_0_0) => match &v127 {
                Date_time::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }
            .clone(),
            _ => string(""),
        };
        let v134: LrcPtr<TimeZoneInfo> = std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(
            chrono::Local::now().offset(),
        ) as i64);
        let v157: i64 = v15.ticks();
        let v188: string =
            string("chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))");
        let v299: TimeSpan = TimeSpan::new_ticks(chrono::FixedOffset::local_minus_utc(
            &chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(
                &chrono::DateTime::from_timestamp_nanos(v157),
            )),
        ) as i64);
        let v312: u8 = if (v299.hours()) > 0_i32 { 1_u8 } else { 0_u8 };
        let v313: string = Date_time::method2();
        let v332: string = v299.to_string(v313);
        let v337: string = sprintf!(
            "{}{}{}",
            v312,
            getSlice(v332.clone(), Some(0_i32), Some(1_i32)),
            getSlice(v332, Some(3_i32), Some(4_i32))
        );
        let v339: string = toString(v0_1);
        parse(concat(new_array(&[
            v131.clone(),
            v337.clone(),
            getSlice(
                v339.clone(),
                Some((length(v131)) + (length(v337))),
                Some((length(v339)) - 1_i32),
            ),
        ])))
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
    pub fn closure4(unitVar: (), v0_1: string) -> string {
        replace(v0_1, string("-"), string(""))
    }
    pub fn closure3(unitVar: (), v0_1: Guid) -> DateTime {
        DateTime::parse(Date_time::closure4(
            (),
            getSlice(toString(v0_1), None::<i32>, Some(24_i32)),
        ))
    }
    pub fn closure7(v0_1: i32, v1_1: string, v2_1: i32, v3_1: string) -> string {
        if (v2_1) >= (v0_1) {
            v3_1.clone()
        } else {
            (Date_time::method5(v0_1, v1_1.clone(), (v2_1) + 1_i32))(append((v3_1), (v1_1)))
        }
    }
    pub fn method5(v0_1: i32, v1_1: string, v2_1: i32) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            let v2_1 = v2_1.clone();
            move |v: string| Date_time::closure7(v0_1, v1_1.clone(), v2_1, v)
        })
    }
    pub fn closure6(v0_1: Guid, v1_1: i64) -> Guid {
        let v3_1: string = toString(v0_1);
        let v7_1: string = toString(v1_1);
        let v11: string = ofChar('0');
        let v20: string = append(
            ((Date_time::method5(18_i32 - (length(v7_1.clone())), v11, 0_i32))(string(""))),
            (v7_1),
        );
        parse(sprintf!(
            "{}-{}-{}-{}{}",
            getSlice(v20.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v20.clone(), Some(8_i32), Some(11_i32)),
            getSlice(v20.clone(), Some(12_i32), Some(15_i32)),
            getSlice(v20, Some(16_i32), Some(17_i32)),
            getSlice(v3_1, Some(21_i32), None::<i32>)
        ))
    }
    pub fn closure5(unitVar: (), v0_1: Guid) -> Func1<i64, Guid> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i64| Date_time::closure6(v0_1.clone(), v)
        })
    }
    pub fn closure8(unitVar: (), v0_1: Guid) -> i64 {
        let v2_1: string = toString(v0_1);
        toInt64(concat(new_array(&[
            getSlice(v2_1.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v2_1.clone(), Some(9_i32), Some(12_i32)),
            getSlice(v2_1.clone(), Some(14_i32), Some(17_i32)),
            getSlice(v2_1, Some(19_i32), Some(20_i32)),
        ])))
    }
    pub fn closure9(unitVar: (), v0_1: DateTime) -> Guid {
        Date_time::method0(new_guid(), v0_1)
    }
    pub fn closure10(unitVar: (), v0_1: i64) -> Guid {
        let v6_1: string = toString(new_guid());
        let v10: string = toString(v0_1);
        let v14: string = ofChar('0');
        let v23: string = append(
            ((Date_time::method5(18_i32 - (length(v10.clone())), v14, 0_i32))(string(""))),
            (v10),
        );
        parse(sprintf!(
            "{}-{}-{}-{}{}",
            getSlice(v23.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v23.clone(), Some(8_i32), Some(11_i32)),
            getSlice(v23.clone(), Some(12_i32), Some(15_i32)),
            getSlice(v23, Some(16_i32), Some(17_i32)),
            getSlice(v6_1, Some(21_i32), None::<i32>)
        ))
    }
    pub fn closure12(v0_1: string, v1_1: DateTime) -> string {
        let provider: string = if (v0_1.clone()) == string("") {
            string("M-d-y hh:mm:ss tt")
        } else {
            v0_1
        };
        v1_1.toString(provider)
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
        v1.get_or_init(|| Func1::new(move |v: Guid| Date_time::closure3((), v)))
            .clone()
    }
    pub fn date_time_from_guid(x: Guid) -> DateTime {
        (Date_time::v1())(x)
    }
    pub fn v2() -> Func1<Guid, Func1<i64, Guid>> {
        static v2: OnceInit<Func1<Guid, Func1<i64, Guid>>> = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: Guid| Date_time::closure5((), v)))
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
