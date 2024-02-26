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
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        pub fn nl() -> string {
            static nl: OnceInit<string> = OnceInit::new();
            nl.get_or_insert_with(|| string("\n")).clone()
        }
        pub fn q() -> string {
            static q: OnceInit<string> = OnceInit::new();
            q.get_or_insert_with(|| string("\"")).clone()
        }
        pub mod String_ {
            use super::*;
            use fable_library_rust::String_::length as length_1;
            use fable_library_rust::String_::substring2;
            pub fn ellipsis(max: i32, value: string) -> string {
                if length_1(value.clone()) <= max {
                    value.clone()
                } else {
                    sprintf!("{}...", &substring2(value, 0_i32, max))
                }
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum TraceLevel {
            Verbose,
            Debug,
            Info,
            Warning,
            Critical,
        }
        impl Polyglot::Common::TraceLevel {
            pub fn get_IsVerbose(this_: LrcPtr<Polyglot::Common::TraceLevel>, unitArg: ()) -> bool {
                if let Polyglot::Common::TraceLevel::Verbose = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsDebug(this_: LrcPtr<Polyglot::Common::TraceLevel>, unitArg: ()) -> bool {
                if let Polyglot::Common::TraceLevel::Debug = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsInfo(this_: LrcPtr<Polyglot::Common::TraceLevel>, unitArg: ()) -> bool {
                if let Polyglot::Common::TraceLevel::Info = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsWarning(this_: LrcPtr<Polyglot::Common::TraceLevel>, unitArg: ()) -> bool {
                if let Polyglot::Common::TraceLevel::Warning = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsCritical(
                this_: LrcPtr<Polyglot::Common::TraceLevel>,
                unitArg: (),
            ) -> bool {
                if let Polyglot::Common::TraceLevel::Critical = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Polyglot::Common::TraceLevel {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn traceEnabled() -> LrcPtr<MutCell<bool>> {
            static traceEnabled: OnceInit<LrcPtr<MutCell<bool>>> = OnceInit::new();
            traceEnabled
                .get_or_insert_with(|| LrcPtr::new(MutCell::new(true)))
                .clone()
        }
        pub fn traceCount() -> LrcPtr<MutCell<i32>> {
            static traceCount: OnceInit<LrcPtr<MutCell<i32>>> = OnceInit::new();
            traceCount
                .get_or_insert_with(|| LrcPtr::new(MutCell::new(0_i32)))
                .clone()
        }
        pub fn traceLevel() -> LrcPtr<MutCell<LrcPtr<Polyglot::Common::TraceLevel>>> {
            static traceLevel: OnceInit<LrcPtr<MutCell<LrcPtr<Polyglot::Common::TraceLevel>>>> =
                OnceInit::new();
            traceLevel
                .get_or_insert_with(|| {
                    LrcPtr::new(MutCell::new(LrcPtr::new(
                        Polyglot::Common::TraceLevel::Verbose,
                    )))
                })
                .clone()
        }
        pub fn traceDump() -> LrcPtr<MutCell<bool>> {
            static traceDump: OnceInit<LrcPtr<MutCell<bool>>> = OnceInit::new();
            traceDump
                .get_or_insert_with(|| LrcPtr::new(MutCell::new(false)))
                .clone()
        }
        pub fn testTraceLevel(level: LrcPtr<Polyglot::Common::TraceLevel>) -> bool {
            if Polyglot::Common::traceEnabled().get().clone() {
                compare(level, Polyglot::Common::traceLevel().get().clone()) >= 0_i32
            } else {
                false
            }
        }
        pub fn traceRaw(level: LrcPtr<Polyglot::Common::TraceLevel>, r#fn: Func0<string>) {
            if Polyglot::Common::testTraceLevel(level) {
                Polyglot::Common::traceCount()
                    .set(Polyglot::Common::traceCount().get().clone() + 1_i32);
                {
                    let text: string = sprintf!("{}", &r#fn());
                    println!("{0}", text,)
                }
            };
        }
        fn replStart() -> Option<i64> {
            None::<i64>
        }
        pub fn trace(
            level: LrcPtr<Polyglot::Common::TraceLevel>,
            r#fn: Func0<string>,
            getLocals: Func0<string>,
        ) {
            let fn_1 = Func0::new({
                let r#fn = r#fn.clone();
                let getLocals = getLocals.clone();
                let level = level.clone();
                move || {
                    let trimChars_2: Array<char> = new_array(&[' ', '/']);
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} #{} [{:?}] {} / {}",
                                &string(""),
                                &Polyglot::Common::traceCount().get().clone(),
                                &level,
                                &r#fn(),
                                &getLocals()
                            ),
                            new_empty::<char>(),
                        ),
                        trimChars_2,
                    )
                }
            });
            Polyglot::Common::traceRaw(level.clone(), fn_1)
        }
    }
}
