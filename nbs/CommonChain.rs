pub mod Polyglot {
    use super::*;
    pub mod Common {
        use super::*;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::compare;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        pub fn nl() -> string {
            static nl: MutCell<Option<string>> = MutCell::new(None);
            nl.get_or_init(|| string("\n"))
        }
        pub fn q() -> string {
            static q: MutCell<Option<string>> = MutCell::new(None);
            q.get_or_init(|| string("\""))
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum TraceLevel {
            Verbose,
            Debug,
            Info,
            Warn,
            Error,
        }
        impl core::fmt::Display for Polyglot::Common::TraceLevel {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn traceEnabled() -> LrcPtr<MutCell<bool>> {
            static traceEnabled: MutCell<Option<LrcPtr<MutCell<bool>>>> = MutCell::new(None);
            traceEnabled.get_or_init(|| LrcPtr::new(MutCell::new(true)))
        }
        pub fn traceCount() -> LrcPtr<MutCell<i32>> {
            static traceCount: MutCell<Option<LrcPtr<MutCell<i32>>>> = MutCell::new(None);
            traceCount.get_or_init(|| LrcPtr::new(MutCell::new(0_i32)))
        }
        pub fn traceLevel() -> LrcPtr<MutCell<LrcPtr<Polyglot::Common::TraceLevel>>> {
            static traceLevel: MutCell<
                Option<LrcPtr<MutCell<LrcPtr<Polyglot::Common::TraceLevel>>>>,
            > = MutCell::new(None);
            traceLevel.get_or_init(|| {
                LrcPtr::new(MutCell::new(LrcPtr::new(
                    Polyglot::Common::TraceLevel::Verbose,
                )))
            })
        }
        fn replStart() -> Option<i64> {
            None::<i64>
        }
        pub fn trace(
            level: LrcPtr<Polyglot::Common::TraceLevel>,
            r#fn: Func0<string>,
            getLocals: Func0<string>,
        ) {
            if if Polyglot::Common::traceEnabled().get() {
                compare(level.clone(), Polyglot::Common::traceLevel().get()) >= 0_i32
            } else {
                false
            } {
                Polyglot::Common::traceCount().set(Polyglot::Common::traceCount().get() + 1_i32);
                {
                    let arg: string = {
                        let trimChars_2: Array<char> = new_array(&[' ', '/']);
                        trimEndChars(
                            trimStartChars(
                                sprintf!(
                                    "{} #{} [{:?}] {} / {}",
                                    &string(""),
                                    &Polyglot::Common::traceCount().get(),
                                    &level,
                                    &r#fn(),
                                    &getLocals()
                                ),
                                new_empty::<char>(),
                            ),
                            trimChars_2,
                        )
                    };
                    println!("{0}", arg,)
                }
            };
        }
    }
}