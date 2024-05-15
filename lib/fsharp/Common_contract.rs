pub mod Polyglot {
    use super::*;
    pub mod Common {
        use super::*;
        use crate::Lib::SpiralTrace::trace as trace_1;
        use crate::Trace::US0;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::String_::string;
        pub fn nl() -> string {
            static nl: OnceInit<string> = OnceInit::new();
            nl.get_or_init(|| string("\n")).clone()
        }
        pub fn q() -> string {
            static q: OnceInit<string> = OnceInit::new();
            q.get_or_init(|| string("\"")).clone()
        }
        ///
        /// ## TraceLevel
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
        ///
        /// ## trace
        pub fn to_trace_level(_arg: LrcPtr<Polyglot::Common::TraceLevel>) -> US0 {
            match _arg.as_ref() {
                Polyglot::Common::TraceLevel::Debug => US0::US0_1,
                Polyglot::Common::TraceLevel::Info => US0::US0_2,
                Polyglot::Common::TraceLevel::Warning => US0::US0_3,
                Polyglot::Common::TraceLevel::Critical => US0::US0_4,
                _ => US0::US0_0,
            }
        }
        pub fn trace(
            level: LrcPtr<Polyglot::Common::TraceLevel>,
            r#fn: Func0<string>,
            locals: Func0<string>,
        ) {
            (trace_1(Polyglot::Common::to_trace_level(level)))(r#fn)(locals);
        }
    }
}
