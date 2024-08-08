pub mod File_system {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Guid_::new_guid;
    use fable_library_rust::Guid_::parse;
    use fable_library_rust::Guid_::Guid;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::singleton;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::interface_cast;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::ofChar;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::toString;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Exception;
    use fable_library_rust::TimeSpan_::zero;
    use fable_library_rust::TimeSpan_::TimeSpan;
    type TimeZoneInfo = i64;
    pub mod State {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    LrcPtr<File_system::Mut3>,
                    Option<i64>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<File_system::Mut0>,
                            LrcPtr<File_system::Mut1>,
                            LrcPtr<File_system::Mut2>,
                            LrcPtr<File_system::Mut3>,
                            Option<i64>,
                        )>,
                    >,
                >,
            > = OnceInit::new();
            trace_state
                .get_or_init(|| {
                    LrcPtr::new(MutCell::new(
                        None::<(
                            LrcPtr<File_system::Mut0>,
                            LrcPtr<File_system::Mut1>,
                            LrcPtr<File_system::Mut2>,
                            LrcPtr<File_system::Mut3>,
                            Option<i64>,
                        )>,
                    ))
                })
                .clone()
        }
    }
    pub trait IOsEnviron {
        fn environ(&self) -> LrcPtr<dyn Any>;
    }
    impl<V: IOsEnviron + Clone + 'static> IOsEnviron for LrcPtr<V> {
        #[inline]
        fn environ(&self) -> LrcPtr<dyn Any> {
            (**self).environ()
        }
    }
    pub trait IFsExistsSync {
        fn existsSync(&self, path: string) -> bool;
    }
    impl<V: IFsExistsSync + Clone + 'static> IFsExistsSync for LrcPtr<V> {
        #[inline]
        fn existsSync(&self, path: string) -> bool {
            (**self).existsSync(path)
        }
    }
    pub trait IPathJoin {
        fn join(&self, paths: Array<string>) -> string;
    }
    impl<V: IPathJoin + Clone + 'static> IPathJoin for LrcPtr<V> {
        #[inline]
        fn join(&self, paths: Array<string>) -> string {
            (**self).join(paths)
        }
    }
    #[derive(Clone, Debug)]
    pub struct Disposable {
        f: Func0<()>,
    }
    impl File_system::Disposable {
        pub fn _ctor__3A5B6456(f: Func0<()>) -> LrcPtr<File_system::Disposable> {
            let f_1;
            ();
            f_1 = f;
            ();
            LrcPtr::new(File_system::Disposable { f: f_1 })
        }
    }
    impl core::fmt::Display for File_system::Disposable {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    impl IDisposable for Disposable {
        fn Dispose(&self) {
            (self.f)();
        }
    }
    pub trait IPathDirname {
        fn dirname(&self, path: string) -> string;
    }
    impl<V: IPathDirname + Clone + 'static> IPathDirname for LrcPtr<V> {
        #[inline]
        fn dirname(&self, path: string) -> string {
            (**self).dirname(path)
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0,
        US0_1,
        US0_2,
        US0_3,
        US0_4,
    }
    impl core::fmt::Display for File_system::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for File_system::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut1 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for File_system::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for File_system::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<File_system::US0>,
    }
    impl core::fmt::Display for File_system::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(string),
        US1_1,
    }
    impl core::fmt::Display for File_system::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(File_system::US0),
        US2_1,
    }
    impl core::fmt::Display for File_system::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(i64),
        US3_1,
    }
    impl core::fmt::Display for File_system::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US4 {
        US4_0,
        US4_1,
        US4_2,
    }
    impl core::fmt::Display for File_system::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US5 {
        US5_0(File_system::US4),
        US5_1(File_system::US4),
        US5_2(File_system::US4),
        US5_3(File_system::US4),
        US5_4(File_system::US4),
    }
    impl core::fmt::Display for File_system::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for File_system::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US7 {
        US7_0,
        US7_1,
        US7_2,
    }
    impl core::fmt::Display for File_system::US7 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US8 {
        US8_0,
        US8_1,
        US8_2,
        US8_3,
        US8_4,
    }
    impl core::fmt::Display for File_system::US8 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US6 {
        US6_0(File_system::US7, File_system::US8),
        US6_1,
    }
    impl core::fmt::Display for File_system::US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US9 {
        US9_0(i64),
        US9_1(LrcPtr<Exception>),
    }
    impl core::fmt::Display for File_system::US9 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US10 {
        US10_0(i64),
        US10_1(LrcPtr<Exception>),
    }
    impl core::fmt::Display for File_system::US10 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US11 {
        US11_0(chrono::DateTime<chrono::Utc>),
        US11_1,
    }
    impl core::fmt::Display for File_system::US11 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US12 {
        US12_0,
        US12_1(std::string::String),
    }
    impl core::fmt::Display for File_system::US12 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US13 {
        US13_0(string),
        US13_1(string),
    }
    impl core::fmt::Display for File_system::US13 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method1() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn method2(v0_1: string) -> string {
        let v18_1: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v20_1: bool = true;
        let _result = v18_1.map(|x| {
            //;
            let v22_1: std::string::String = x;
            let v24_1: string = fable_library_rust::String_::fromString(v22_1);
            let v26_1: bool = true;
            v24_1
        });
        let v28_1: Result<string, std::env::VarError> = _result;
        let v29_1: string = File_system::method3();
        v28_1.unwrap_or(v29_1)
    }
    pub fn method4() -> string {
        string("AUTOMATION")
    }
    pub fn closure0(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(
        v0_1: File_system::US0,
    ) -> (
        LrcPtr<File_system::Mut0>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut2>,
        LrcPtr<File_system::Mut3>,
        Option<i64>,
    ) {
        let _v1: (File_system::US2, File_system::US3) =
            (File_system::US2::US2_1, File_system::US3::US3_1);
        let v295: File_system::US3 = _v1.1.clone();
        let v294: File_system::US2 = _v1.0.clone();
        (
            LrcPtr::new(File_system::Mut0 {
                l0: MutCell::new(0_i64),
            }),
            LrcPtr::new(File_system::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| File_system::closure0((), v))),
            }),
            LrcPtr::new(File_system::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(match &v294 {
                    File_system::US2::US2_0(v294_0_0) => match &v294 {
                        File_system::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v295 {
                File_system::US3::US3_0(v295_0_0) => Some(match &v295 {
                    File_system::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<i64>,
            },
        )
    }
    pub fn method7(v0_1: string) -> string {
        v0_1
    }
    pub fn method8(v0_1: string) -> bool {
        unbox::<bool>(&defaultOf())
    }
    pub fn method6(v0_1: bool, v1: string) {
        ();
        ()
    }
    pub fn method9() -> string {
        string("hh:mm:ss")
    }
    pub fn method10() -> string {
        string("HH:mm:ss")
    }
    pub fn method11() -> string {
        string("\u{001b}[0m")
    }
    pub fn method12(v0_1: string) -> string {
        panic!(
            "{}",
            sprintf!(
                "file_system.get_file_name / target: {} / path: {}",
                File_system::US5::US5_2(File_system::US4::US4_1),
                v0_1
            ),
        )
    }
    pub fn method13() -> string {
        string("")
    }
    pub fn closure2(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.delete_directory_async")
    }
    pub fn method5(v0_1: string, v1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure1(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure5(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.wait_for_file_access")
    }
    pub fn method14(
        v0_1: string,
        v1: File_system::US8,
        v2: File_system::US7,
        v3: i64,
    ) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure4(v0_1: File_system::US6, v1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure3(unitVar: (), v0_1: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure4(v0_1.clone(), v)
        })
    }
    pub fn method15(v0_1: string, v1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure6(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure7(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        defaultOf()
    }
    pub fn method17(v0_1: string) -> bool {
        unbox::<bool>(&defaultOf())
    }
    pub fn method18(v0_1: Vec<u8>) -> Vec<u8> {
        v0_1
    }
    pub fn method16(v0_1: string, v1: string) -> bool {
        unbox::<bool>(&defaultOf())
    }
    pub fn closure9(v0_1: string, v1: string) -> bool {
        File_system::method16(v0_1, v1)
    }
    pub fn closure8(unitVar: (), v0_1: string) -> Func1<string, bool> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure9(v0_1.clone(), v)
        })
    }
    pub fn closure11(v0_1: string, v1: string) -> Arc<Async<()>> {
        defaultOf()
    }
    pub fn closure10(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure11(v0_1.clone(), v)
        })
    }
    pub fn closure13(v0_1: string, v1: string) -> Arc<Async<()>> {
        defaultOf()
    }
    pub fn closure12(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure13(v0_1.clone(), v)
        })
    }
    pub fn closure15(unitVar: (), unitVar_1: ()) -> string {
        string("delete_file_async")
    }
    pub fn method19(v0_1: string, v1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure14(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure18(unitVar: (), unitVar_1: ()) -> string {
        string("move_file_async")
    }
    pub fn method20(v0_1: string, v1: string, v2: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure17(v0_1: string, v1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure16(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure17(v0_1.clone(), v)
        })
    }
    pub fn closure20(unitVar: (), v0_1: i64) -> File_system::US9 {
        File_system::US9::US9_0(v0_1)
    }
    pub fn closure21(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US9 {
        File_system::US9::US9_1(v0_1)
    }
    pub fn closure22(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async")
    }
    pub fn closure23(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async**")
    }
    pub fn closure24(unitVar: (), unitVar_1: ()) -> string {
        string("read_all_text_retry_async")
    }
    pub fn method21(v0_1: string, v1: i64) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure19(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn method24() -> string {
        string("hh:mm")
    }
    pub fn method25() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method26() -> string {
        string("hhmm")
    }
    pub fn method23(v0_1: Guid, v1: DateTime) -> Guid {
        let v167: DateTime = {
            let _arg: DateTime =
                DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
            _arg.toUniversalTime()
        };
        let v185: i64 = ({
            let _arg_2: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1, 2_i32);
                _arg_1.toUniversalTime()
            };
            _arg_2.ticks()
        } - v167.ticks())
            / 10_i64;
        let v187: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v185);
        let _v188: LrcPtr<MutCell<Option<File_system::US11>>> = refCell(None::<File_system::US11>);
        {
            let x_2: Option<File_system::US11> = match &v187 {
                None => None::<File_system::US11>,
                Some(v187_0_0) => {
                    let x: chrono::DateTime<chrono::Utc> = v187_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || File_system::US11::US11_0(x.clone())
                    }))())
                }
            };
            _v188.set(x_2)
        }
        {
            let v203: File_system::US11 =
                defaultValue(File_system::US11::US11_1, _v188.get().clone());
            let v223: File_system::US1 = match &v203 {
                File_system::US11::US11_0(v203_0_0) => {
                    let v209: chrono::NaiveDateTime = match &v203 {
                        File_system::US11::US11_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .naive_utc();
                    let v211: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v209);
                    let v213: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                    let v214: &str = r#"%Y%m%d-%H%M-%S%f"#;
                    let v216: std::string::String = v211.format(v214).to_string();
                    let v218: string = fable_library_rust::String_::fromString(v216);
                    File_system::US1::US1_0(sprintf!(
                        "{}-{}-{}",
                        getSlice(v218.clone(), Some(0_i32), Some(17_i32)),
                        getSlice(v218.clone(), Some(18_i32), Some(21_i32)),
                        getCharAt(v218, 22_i32)
                    ))
                }
                _ => File_system::US1::US1_1,
            };
            let v227: string = match &v223 {
                File_system::US1::US1_0(v223_0_0) => match &v223 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            };
            let v231: LrcPtr<TimeZoneInfo> = defaultOf();
            let v305: u8 = if zero.hours() > 0_i32 { 1_u8 } else { 0_u8 };
            let v306: string = File_system::method24();
            let v314: string = zero.to_string(v306);
            let v317: string = sprintf!(
                "{}{}{}",
                v305,
                getSlice(v314.clone(), Some(0_i32), Some(1_i32)),
                getSlice(v314, Some(3_i32), Some(4_i32))
            );
            parse(sprintf!(
                "{}{}{}",
                v227.clone(),
                v317.clone(),
                getSlice(
                    toString(v0_1),
                    Some(length(v227) + length(v317)),
                    None::<i32>
                )
            ))
        }
    }
    pub fn method28() -> string {
        panic!(
            "{}",
            sprintf!(
                "file_system.get_temp_path / target: {}",
                File_system::US5::US5_2(File_system::US4::US4_1)
            ),
        )
    }
    pub fn method29() -> string {
        string("!create_temp_path_")
    }
    pub fn method32(v0_1: string) -> string {
        v0_1
    }
    pub fn method31(v0_1: string, v1: string) -> (string, string) {
        (v1, File_system::method32(v0_1))
    }
    pub fn method30(v0_1: string, v1: string) -> string {
        panic!(
            "{}",
            sprintf!(
                "file_system.(</>) / target: {} / a: {} / b: {}",
                File_system::US5::US5_2(File_system::US4::US4_1),
                v0_1,
                v1
            ),
        )
    }
    pub fn method34() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method33() -> string {
        File_system::method2(File_system::method34())
    }
    pub fn method27(v0_1: Guid) -> string {
        File_system::method30(
            File_system::method30(
                File_system::method30(File_system::method28(), File_system::method29()),
                File_system::method33(),
            ),
            toString(v0_1),
        )
    }
    pub fn method22() -> string {
        let v10: DateTime = DateTime::now();
        File_system::method27(File_system::method23(new_guid(), v10))
    }
    pub fn closure25(unitVar: (), unitVar_1: ()) -> string {
        File_system::method22()
    }
    pub fn method36(v0_1: string) -> string {
        v0_1
    }
    pub fn closure27(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        format!("{}", v0_1)
    }
    pub fn method37() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure27((), v))
    }
    pub fn closure28(unitVar: (), unitVar_1: ()) -> File_system::US12 {
        File_system::US12::US12_0
    }
    pub fn closure29(unitVar: (), v0_1: std::string::String) -> File_system::US12 {
        File_system::US12::US12_1(v0_1)
    }
    pub fn closure30(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure32(v0_1: string, unitVar: ()) {
        File_system::method6(true, v0_1);
    }
    pub fn method38(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure32(v0_1.clone(), ())
        })
    }
    pub fn method39(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure32(v0_1.clone(), ())
        })
    }
    pub fn closure33(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure34(v0_1: string, unitVar: ()) {
        let v5: Arc<Async<i64>> = defaultOf();
        let v28_1: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn method40(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure34(v0_1.clone(), ())
        })
    }
    pub fn method41(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure34(v0_1.clone(), ())
        })
    }
    pub fn method35(v0_1: string) -> LrcPtr<dyn IDisposable> {
        interface_cast!(
            defaultOf::<std::sync::Arc<dyn IDisposable>>(),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure26(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method22();
        (v0_1.clone(), File_system::method35(v0_1))
    }
    pub fn method42(v0_1: string) -> Guid {
        let v19_1: string = padLeft(v0_1, 32_i32, '0');
        parse(sprintf!(
            "{}-{}-{}-{}-{}",
            getSlice(v19_1.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v19_1.clone(), Some(8_i32), Some(11_i32)),
            getSlice(v19_1.clone(), Some(12_i32), Some(15_i32)),
            getSlice(v19_1.clone(), Some(16_i32), Some(19_i32)),
            getSlice(v19_1, Some(20_i32), Some(31_i32))
        ))
    }
    pub fn closure35(unitVar: (), v0_1: string) -> (string, LrcPtr<dyn IDisposable>) {
        let v2: string = File_system::method27(File_system::method42(v0_1));
        (v2.clone(), File_system::method35(v2))
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn method43(v0_1: string) -> string {
        if v0_1 == string("") {
            string("")
        } else {
            let v29_1: string = unbox::<string>(&defaultOf());
            replace(
                sprintf!(
                    "{}{}",
                    toLower(ofChar(getCharAt(v29_1.clone(), 0_i32))),
                    getSlice(v29_1, Some(1_i32), None::<i32>)
                ),
                string("\\"),
                string("/"),
            )
        }
    }
    pub fn closure37(unitVar: (), v0_1: string) -> string {
        File_system::method43(v0_1)
    }
    pub fn closure38(unitVar: (), v0_1: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0_1, toArray(singleton('/'))))
    }
    pub fn method46(v0_1: string) -> Option<string> {
        let v229: File_system::US1 = unbox::<File_system::US1>(&defaultOf());
        match &v229 {
            File_system::US1::US1_0(v229_0_0) => Some(match &v229 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => None::<string>,
        }
    }
    pub fn closure40(unitVar: (), v0_1: string) -> Option<string> {
        File_system::method46(v0_1)
    }
    pub fn method45() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure40((), v))
    }
    pub fn method47(v0_1: string, v1: string, v2: string) -> File_system::US13 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        let v2: MutCell<string> = MutCell::new(v2.clone());
        '_method47: loop {
            break '_method47 (if File_system::method8(File_system::method30(
                v2.get().clone(),
                v0_1.get().clone(),
            )) {
                File_system::US13::US13_0(v2.get().clone())
            } else {
                let v7: Option<string> = (File_system::method45())(v2.get().clone());
                let _v8: LrcPtr<MutCell<Option<File_system::US1>>> =
                    refCell(None::<File_system::US1>);
                {
                    let x_2: Option<File_system::US1> = match &v7 {
                        None => None::<File_system::US1>,
                        Some(v7_0_0) => {
                            let x: string = v7_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || File_system::US1::US1_0(x.clone())
                            }))())
                        }
                    };
                    _v8.set(x_2)
                }
                {
                    let v23_1: File_system::US1 =
                        defaultValue(File_system::US1::US1_1, _v8.get().clone());
                    match &v23_1 {
                        File_system::US1::US1_0(v23_1_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_temp: string = v1.get().clone();
                            let v2_temp: string = match &v23_1 {
                                File_system::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            v2.set(v2_temp);
                            continue '_method47;
                        }
                        _ => File_system::US13::US13_1(sprintf!(
                            "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                            string("dir"),
                            v0_1.get().clone(),
                            v1.get().clone(),
                            v2.get().clone()
                        )),
                    }
                }
            });
        }
    }
    pub fn method44(v0_1: string, v1: string) -> File_system::US13 {
        if File_system::method8(File_system::method30(v1.clone(), v0_1.clone())) {
            File_system::US13::US13_0(v1.clone())
        } else {
            let v6: Option<string> = (File_system::method45())(v1.clone());
            let _v7: LrcPtr<MutCell<Option<File_system::US1>>> = refCell(None::<File_system::US1>);
            {
                let x_2: Option<File_system::US1> = match &v6 {
                    None => None::<File_system::US1>,
                    Some(v6_0_0) => {
                        let x: string = v6_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US1::US1_0(x.clone())
                        }))())
                    }
                };
                _v7.set(x_2)
            }
            {
                let v22_1: File_system::US1 =
                    defaultValue(File_system::US1::US1_1, _v7.get().clone());
                match &v22_1 {
                    File_system::US1::US1_0(v22_1_0_0) => File_system::method47(
                        v0_1.clone(),
                        v1.clone(),
                        match &v22_1 {
                            File_system::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    ),
                    _ => File_system::US13::US13_1(sprintf!(
                        "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                        string("dir"),
                        v0_1.clone(),
                        v1.clone(),
                        v1.clone()
                    )),
                }
            }
        }
    }
    pub fn closure41(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.get_workspace_root")
    }
    pub fn method48() -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn closure39(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US13 = File_system::method44(
            File_system::method30(string("polyglot"), string(".devcontainer")),
            string("C:\\home\\git\\polyglot\\lib\\spiral"),
        );
        let v682: File_system::US1 = match &v4 {
            File_system::US13::US13_0(v4_0_0) => File_system::US1::US1_0(v4_0_0.clone()),
            File_system::US13::US13_1(v4_1_0) => {
                if File_system::State::trace_state().get().clone().is_none() {
                    let patternInput: (
                        LrcPtr<File_system::Mut0>,
                        LrcPtr<File_system::Mut1>,
                        LrcPtr<File_system::Mut2>,
                        LrcPtr<File_system::Mut3>,
                        Option<i64>,
                    ) = File_system::method0(File_system::US0::US0_0);
                    File_system::State::trace_state().set(Some((
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                        patternInput.3.clone(),
                        patternInput.4.clone(),
                    )));
                    ()
                }
                {
                    let patternInput_1: (
                        LrcPtr<File_system::Mut0>,
                        LrcPtr<File_system::Mut1>,
                        LrcPtr<File_system::Mut2>,
                        LrcPtr<File_system::Mut3>,
                        Option<i64>,
                    ) = getValue(File_system::State::trace_state().get().clone());
                    let v20_1: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
                    if File_system::State::trace_state().get().clone().is_none() {
                        let patternInput_2: (
                            LrcPtr<File_system::Mut0>,
                            LrcPtr<File_system::Mut1>,
                            LrcPtr<File_system::Mut2>,
                            LrcPtr<File_system::Mut3>,
                            Option<i64>,
                        ) = File_system::method0(File_system::US0::US0_0);
                        File_system::State::trace_state().set(Some((
                            patternInput_2.0.clone(),
                            patternInput_2.1.clone(),
                            patternInput_2.2.clone(),
                            patternInput_2.3.clone(),
                            patternInput_2.4.clone(),
                        )));
                        ()
                    }
                    {
                        let patternInput_3: (
                            LrcPtr<File_system::Mut0>,
                            LrcPtr<File_system::Mut1>,
                            LrcPtr<File_system::Mut2>,
                            LrcPtr<File_system::Mut3>,
                            Option<i64>,
                        ) = getValue(File_system::State::trace_state().get().clone());
                        let v62: File_system::US0 = (patternInput_3.3.clone()).l0.get().clone();
                        if if (patternInput_3.2.clone()).l0.get().clone() == false {
                            false
                        } else {
                            3_i32
                                >= find(
                                    v62,
                                    ofSeq(ofList(ofArray(new_array(&[
                                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                                    ])))),
                                )
                        } {
                            let v69: i64 = v20_1.l0.get().clone() + 1_i64;
                            v20_1.l0.set(v69);
                            if File_system::State::trace_state().get().clone().is_none() {
                                let patternInput_4: (
                                    LrcPtr<File_system::Mut0>,
                                    LrcPtr<File_system::Mut1>,
                                    LrcPtr<File_system::Mut2>,
                                    LrcPtr<File_system::Mut3>,
                                    Option<i64>,
                                ) = File_system::method0(File_system::US0::US0_0);
                                File_system::State::trace_state().set(Some((
                                    patternInput_4.0.clone(),
                                    patternInput_4.1.clone(),
                                    patternInput_4.2.clone(),
                                    patternInput_4.3.clone(),
                                    patternInput_4.4.clone(),
                                )));
                                ()
                            }
                            {
                                let patternInput_5: (
                                    LrcPtr<File_system::Mut0>,
                                    LrcPtr<File_system::Mut1>,
                                    LrcPtr<File_system::Mut2>,
                                    LrcPtr<File_system::Mut3>,
                                    Option<i64>,
                                ) = getValue(File_system::State::trace_state().get().clone());
                                let v86: Option<i64> = patternInput_5.4.clone();
                                let _v161: LrcPtr<MutCell<Option<File_system::US3>>> =
                                    refCell(None::<File_system::US3>);
                                {
                                    let x_2: Option<File_system::US3> = match &v86 {
                                        None => None::<File_system::US3>,
                                        Some(v86_0_0) => {
                                            let x: i64 = v86_0_0.clone();
                                            Some((Func0::new({
                                                let x = x.clone();
                                                move || File_system::US3::US3_0(x)
                                            }))())
                                        }
                                    };
                                    _v161.set(x_2)
                                }
                                {
                                    let v176: File_system::US3 =
                                        defaultValue(File_system::US3::US3_1, _v161.get().clone());
                                    let v216: DateTime = match &v176 {
                                        File_system::US3::US3_0(v176_0_0) => {
                                            let v190: TimeSpan = TimeSpan::new_ticks(
                                                {
                                                    let _arg: DateTime = DateTime::now();
                                                    _arg.ticks()
                                                } - match &v176 {
                                                    File_system::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                            );
                                            DateTime::new_ymdhms_milli(
                                                1_i32,
                                                1_i32,
                                                1_i32,
                                                v190.hours(),
                                                v190.minutes(),
                                                v190.seconds(),
                                                v190.milliseconds(),
                                            )
                                        }
                                        _ => DateTime::now(),
                                    };
                                    let v221: string = {
                                        let provider: string = File_system::method9();
                                        v216.toString(provider)
                                    };
                                    let v520: string =
                                        padLeft(toLower(string("Warning")), 7_i32, ' ');
                                    let v547: &str = inline_colorization::color_yellow;
                                    let v549: &str = &*v520;
                                    let v551: &str = inline_colorization::color_reset;
                                    let v553: string = string("format!(\"{v547}{v549}{v551}\")");
                                    let v554: std::string::String = format!("{v547}{v549}{v551}");
                                    let v556: string =
                                        fable_library_rust::String_::fromString(v554);
                                    let v586: i64 = (patternInput_5.0.clone()).l0.get().clone();
                                    let v588: LrcPtr<File_system::Mut4> =
                                        LrcPtr::new(File_system::Mut4 {
                                            l0: MutCell::new(File_system::method13()),
                                        });
                                    let v590: string = sprintf!("{}", string("{ "));
                                    let v594: string = append(v588.l0.get().clone(), v590);
                                    v588.l0.set(v594);
                                    {
                                        let v596: string = sprintf!("{}", string("error"));
                                        let v600: string = append(v588.l0.get().clone(), v596);
                                        v588.l0.set(v600);
                                        {
                                            let v602: string = sprintf!("{}", string(" = "));
                                            let v606: string = append(v588.l0.get().clone(), v602);
                                            v588.l0.set(v606);
                                            {
                                                let v607: string = sprintf!("{}", v4_1_0.clone());
                                                let v611: string =
                                                    append(v588.l0.get().clone(), v607);
                                                v588.l0.set(v611);
                                                {
                                                    let v613: string = sprintf!("{}", string(" }"));
                                                    let v617: string =
                                                        append(v588.l0.get().clone(), v613);
                                                    v588.l0.set(v617);
                                                    {
                                                        let v618: string = v588.l0.get().clone();
                                                        let v657: string = trimEndChars(
                                                            trimStartChars(
                                                                sprintf!(
                                                                    "{} {} #{} {} / {}",
                                                                    v221,
                                                                    v556,
                                                                    v586,
                                                                    File_system::closure41((), ()),
                                                                    v618
                                                                ),
                                                                toArray(empty::<char>()),
                                                            ),
                                                            toArray(ofArray(new_array(&[
                                                                ' ', '/',
                                                            ]))),
                                                        );
                                                        println!("{}", v657.clone());
                                                        ();
                                                        ((patternInput_1.1.clone())
                                                            .l0
                                                            .get()
                                                            .clone())(
                                                            v657
                                                        )
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        File_system::US1::US1_1
                    }
                }
            }
        };
        let v1367: File_system::US1 = match &v682 {
            File_system::US1::US1_0(v682_0_0) => File_system::US1::US1_0(match &v682 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v685: string = File_system::method48();
                let v687: File_system::US13 = File_system::method44(
                    File_system::method30(string("polyglot"), string(".devcontainer")),
                    v685,
                );
                match &v687 {
                    File_system::US13::US13_0(v687_0_0) => {
                        File_system::US1::US1_0(v687_0_0.clone())
                    }
                    File_system::US13::US13_1(v687_1_0) => {
                        if File_system::State::trace_state().get().clone().is_none() {
                            let patternInput_6: (
                                LrcPtr<File_system::Mut0>,
                                LrcPtr<File_system::Mut1>,
                                LrcPtr<File_system::Mut2>,
                                LrcPtr<File_system::Mut3>,
                                Option<i64>,
                            ) = File_system::method0(File_system::US0::US0_0);
                            File_system::State::trace_state().set(Some((
                                patternInput_6.0.clone(),
                                patternInput_6.1.clone(),
                                patternInput_6.2.clone(),
                                patternInput_6.3.clone(),
                                patternInput_6.4.clone(),
                            )));
                            ()
                        }
                        {
                            let patternInput_7: (
                                LrcPtr<File_system::Mut0>,
                                LrcPtr<File_system::Mut1>,
                                LrcPtr<File_system::Mut2>,
                                LrcPtr<File_system::Mut3>,
                                Option<i64>,
                            ) = getValue(File_system::State::trace_state().get().clone());
                            let v703: LrcPtr<File_system::Mut0> = patternInput_7.0.clone();
                            if File_system::State::trace_state().get().clone().is_none() {
                                let patternInput_8: (
                                    LrcPtr<File_system::Mut0>,
                                    LrcPtr<File_system::Mut1>,
                                    LrcPtr<File_system::Mut2>,
                                    LrcPtr<File_system::Mut3>,
                                    Option<i64>,
                                ) = File_system::method0(File_system::US0::US0_0);
                                File_system::State::trace_state().set(Some((
                                    patternInput_8.0.clone(),
                                    patternInput_8.1.clone(),
                                    patternInput_8.2.clone(),
                                    patternInput_8.3.clone(),
                                    patternInput_8.4.clone(),
                                )));
                                ()
                            }
                            {
                                let patternInput_9: (
                                    LrcPtr<File_system::Mut0>,
                                    LrcPtr<File_system::Mut1>,
                                    LrcPtr<File_system::Mut2>,
                                    LrcPtr<File_system::Mut3>,
                                    Option<i64>,
                                ) = getValue(File_system::State::trace_state().get().clone());
                                let v745: File_system::US0 =
                                    (patternInput_9.3.clone()).l0.get().clone();
                                if if (patternInput_9.2.clone()).l0.get().clone() == false {
                                    false
                                } else {
                                    3_i32
                                        >= find(
                                            v745,
                                            ofSeq(ofList(ofArray(new_array(&[
                                                LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                                                LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                                                LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                                                LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                                                LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                                            ])))),
                                        )
                                } {
                                    let v752: i64 = v703.l0.get().clone() + 1_i64;
                                    v703.l0.set(v752);
                                    if File_system::State::trace_state().get().clone().is_none() {
                                        let patternInput_10: (
                                            LrcPtr<File_system::Mut0>,
                                            LrcPtr<File_system::Mut1>,
                                            LrcPtr<File_system::Mut2>,
                                            LrcPtr<File_system::Mut3>,
                                            Option<i64>,
                                        ) = File_system::method0(File_system::US0::US0_0);
                                        File_system::State::trace_state().set(Some((
                                            patternInput_10.0.clone(),
                                            patternInput_10.1.clone(),
                                            patternInput_10.2.clone(),
                                            patternInput_10.3.clone(),
                                            patternInput_10.4.clone(),
                                        )));
                                        ()
                                    }
                                    {
                                        let patternInput_11: (
                                            LrcPtr<File_system::Mut0>,
                                            LrcPtr<File_system::Mut1>,
                                            LrcPtr<File_system::Mut2>,
                                            LrcPtr<File_system::Mut3>,
                                            Option<i64>,
                                        ) = getValue(
                                            File_system::State::trace_state().get().clone(),
                                        );
                                        let v769: Option<i64> = patternInput_11.4.clone();
                                        let _v844: LrcPtr<MutCell<Option<File_system::US3>>> =
                                            refCell(None::<File_system::US3>);
                                        {
                                            let x_5: Option<File_system::US3> = match &v769 {
                                                None => None::<File_system::US3>,
                                                Some(v769_0_0) => {
                                                    let x_3: i64 = v769_0_0.clone();
                                                    Some((Func0::new({
                                                        let x_3 = x_3.clone();
                                                        move || File_system::US3::US3_0(x_3)
                                                    }))(
                                                    ))
                                                }
                                            };
                                            _v844.set(x_5)
                                        }
                                        {
                                            let v859: File_system::US3 = defaultValue(
                                                File_system::US3::US3_1,
                                                _v844.get().clone(),
                                            );
                                            let v899: DateTime = match &v859 {
                                                File_system::US3::US3_0(v859_0_0) => {
                                                    let v873: TimeSpan = TimeSpan::new_ticks(
                                                        {
                                                            let _arg_5: DateTime = DateTime::now();
                                                            _arg_5.ticks()
                                                        } - match &v859 {
                                                            File_system::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                    );
                                                    DateTime::new_ymdhms_milli(
                                                        1_i32,
                                                        1_i32,
                                                        1_i32,
                                                        v873.hours(),
                                                        v873.minutes(),
                                                        v873.seconds(),
                                                        v873.milliseconds(),
                                                    )
                                                }
                                                _ => DateTime::now(),
                                            };
                                            let v904: string = {
                                                let provider_1: string = File_system::method9();
                                                v899.toString(provider_1)
                                            };
                                            let v1203: string =
                                                padLeft(toLower(string("Warning")), 7_i32, ' ');
                                            let v1230: &str = inline_colorization::color_yellow;
                                            let v1232: &str = &*v1203;
                                            let v1234: &str = inline_colorization::color_reset;
                                            let v1236: string =
                                                string("format!(\"{v1230}{v1232}{v1234}\")");
                                            let v1237: std::string::String =
                                                format!("{v1230}{v1232}{v1234}");
                                            let v1239: string =
                                                fable_library_rust::String_::fromString(v1237);
                                            let v1269: i64 =
                                                (patternInput_11.0.clone()).l0.get().clone();
                                            let v1271: LrcPtr<File_system::Mut4> =
                                                LrcPtr::new(File_system::Mut4 {
                                                    l0: MutCell::new(File_system::method13()),
                                                });
                                            let v1273: string = sprintf!("{}", string("{ "));
                                            let v1277: string =
                                                append(v1271.l0.get().clone(), v1273);
                                            v1271.l0.set(v1277);
                                            {
                                                let v1279: string = sprintf!("{}", string("error"));
                                                let v1283: string =
                                                    append(v1271.l0.get().clone(), v1279);
                                                v1271.l0.set(v1283);
                                                {
                                                    let v1285: string =
                                                        sprintf!("{}", string(" = "));
                                                    let v1289: string =
                                                        append(v1271.l0.get().clone(), v1285);
                                                    v1271.l0.set(v1289);
                                                    {
                                                        let v1290: string =
                                                            sprintf!("{}", v687_1_0.clone());
                                                        let v1294: string =
                                                            append(v1271.l0.get().clone(), v1290);
                                                        v1271.l0.set(v1294);
                                                        {
                                                            let v1296: string =
                                                                sprintf!("{}", string(" }"));
                                                            let v1300: string = append(
                                                                v1271.l0.get().clone(),
                                                                v1296,
                                                            );
                                                            v1271.l0.set(v1300);
                                                            {
                                                                let v1301: string =
                                                                    v1271.l0.get().clone();
                                                                let v1340: string = trimEndChars(
                                                                    trimStartChars(
                                                                        sprintf!(
                                                                            "{} {} #{} {} / {}",
                                                                            v904,
                                                                            v1239,
                                                                            v1269,
                                                                            File_system::closure41(
                                                                                (),
                                                                                ()
                                                                            ),
                                                                            v1301
                                                                        ),
                                                                        toArray(empty::<char>()),
                                                                    ),
                                                                    toArray(ofArray(new_array(&[
                                                                        ' ', '/',
                                                                    ]))),
                                                                );
                                                                println!("{}", v1340.clone());
                                                                ();
                                                                ((patternInput_7.1.clone())
                                                                    .l0
                                                                    .get()
                                                                    .clone())(
                                                                    v1340
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                File_system::US1::US1_1
                            }
                        }
                    }
                }
            }
        };
        File_system::method30(
            match &v1367 {
                File_system::US1::US1_0(v1367_0_0) => match &v1367 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            },
            string("polyglot"),
        )
    }
    pub fn method49(v0_1: string) {
        ();
        ()
    }
    pub fn closure43(unitVar: (), v0_1: string) {
        File_system::method49(v0_1);
    }
    pub fn closure42(unitVar: (), v0_1: bool) {
        if File_system::State::trace_state().get().clone().is_none() {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = File_system::method0(File_system::US0::US0_0);
            File_system::State::trace_state().set(Some((
                patternInput.0.clone(),
                patternInput.1.clone(),
                patternInput.2.clone(),
                patternInput.3.clone(),
                patternInput.4.clone(),
            )));
            ()
        }
        {
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v30_1 = if v0_1 {
                Func1::new(move |v: string| File_system::closure43((), v))
            } else {
                Func1::new(move |v_1: string| File_system::closure0((), v_1))
            };
            (patternInput_1.1.clone()).l0.set(v30_1);
            ()
        }
    }
    pub fn closure45(v0_1: string, v1: string) -> string {
        File_system::method30(v0_1, v1)
    }
    pub fn closure44(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure45(v0_1.clone(), v)
        })
    }
    pub fn v0() -> bool {
        static v0: OnceInit<bool> = OnceInit::new();
        v0.get_or_init(|| File_system::State::trace_state().get().clone().is_none())
            .clone()
    }
    on_startup!(if File_system::v0() {
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = File_system::method0(File_system::US0::US0_0);
        File_system::State::trace_state().set(Some((
            patternInput.0.clone(),
            patternInput.1.clone(),
            patternInput.2.clone(),
            patternInput.3.clone(),
            patternInput.4.clone(),
        )));
        ()
    });
    pub fn v12() -> Func1<string, Arc<Async<i64>>> {
        static v12: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v12.get_or_init(|| Func1::new(move |v: string| File_system::closure1((), v)))
            .clone()
    }
    pub fn delete_directory_async(x: string) -> Arc<Async<i64>> {
        (File_system::v12())(x)
    }
    pub fn v13() -> Func1<File_system::US6, Func1<string, Arc<Async<i64>>>> {
        static v13: OnceInit<Func1<File_system::US6, Func1<string, Arc<Async<i64>>>>> =
            OnceInit::new();
        v13.get_or_init(|| Func1::new(move |v: File_system::US6| File_system::closure3((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v13())(x)
    }
    pub fn v14() -> Func1<string, Arc<Async<i64>>> {
        static v14: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v14.get_or_init(|| Func1::new(move |v: string| File_system::closure6((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v14())(x)
    }
    pub fn v15() -> Func1<string, Arc<Async<string>>> {
        static v15: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v15.get_or_init(|| Func1::new(move |v: string| File_system::closure7((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v15())(x)
    }
    pub fn v16() -> Func1<string, Func1<string, bool>> {
        static v16: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: string| File_system::closure8((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, bool> {
        (File_system::v16())(x)
    }
    pub fn v17() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v17: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: string| File_system::closure10((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v17())(x)
    }
    pub fn v18() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v18: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: string| File_system::closure12((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v18())(x)
    }
    pub fn v19() -> Func1<string, Arc<Async<i64>>> {
        static v19: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: string| File_system::closure14((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v19())(x)
    }
    pub fn v20() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v20: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v20.get_or_init(|| Func1::new(move |v: string| File_system::closure16((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v20())(x)
    }
    pub fn v21() -> Func1<string, Arc<Async<Option<string>>>> {
        static v21: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v21.get_or_init(|| Func1::new(move |v: string| File_system::closure19((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v21())(x)
    }
    pub fn v22() -> Func0<string> {
        static v22: OnceInit<Func0<string>> = OnceInit::new();
        v22.get_or_init(|| Func0::new(move || File_system::closure25((), ())))
            .clone()
    }
    pub fn create_temp_path() -> string {
        (File_system::v22())()
    }
    pub fn v23() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v23: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v23.get_or_init(|| Func0::new(move || File_system::closure26((), ())))
            .clone()
    }
    pub fn create_temp_dir() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v23())()
    }
    pub fn v24() -> Func1<string, (string, LrcPtr<dyn IDisposable>)> {
        static v24: OnceInit<Func1<string, (string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v24.get_or_init(|| Func1::new(move |v: string| File_system::closure35((), v)))
            .clone()
    }
    pub fn create_temp_dir_(x: string) -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v24())(x)
    }
    pub fn v25() -> Func0<string> {
        static v25: OnceInit<Func0<string>> = OnceInit::new();
        v25.get_or_init(|| Func0::new(move || File_system::closure36((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v25())()
    }
    pub fn v26() -> Func1<string, string> {
        static v26: OnceInit<Func1<string, string>> = OnceInit::new();
        v26.get_or_init(|| Func1::new(move |v: string| File_system::closure37((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v26())(x)
    }
    pub fn v27() -> Func1<string, string> {
        static v27: OnceInit<Func1<string, string>> = OnceInit::new();
        v27.get_or_init(|| Func1::new(move |v: string| File_system::closure38((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v27())(x)
    }
    pub fn v28() -> Func0<string> {
        static v28: OnceInit<Func0<string>> = OnceInit::new();
        v28.get_or_init(|| Func0::new(move || File_system::closure39((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v28())()
    }
    pub fn v29() -> Func1<bool, ()> {
        static v29: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v29.get_or_init(|| Func1::new(move |v: bool| File_system::closure42((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v29())(x);
    }
    pub fn v30() -> Func1<string, Func1<string, string>> {
        static v30: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v30.get_or_init(|| Func1::new(move |v: string| File_system::closure44((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v30())(x)
    }
    on_startup!(());
}
