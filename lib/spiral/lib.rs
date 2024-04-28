pub mod Lib {
    use super::*;
    use crate::Common::Mut0 as Mut0_3;
    use crate::Common::Mut1 as Mut1_3;
    use crate::Common::Mut2 as Mut2_3;
    use crate::Common::Mut3 as Mut3_3;
    use crate::Common::State as State_3;
    use crate::Common::US0 as US0_4;
    use crate::File_system::Mut0;
    use crate::File_system::Mut1;
    use crate::File_system::Mut2;
    use crate::File_system::Mut3;
    use crate::File_system::State;
    use crate::File_system::US0 as US0_1;
    use crate::Networking::Mut0 as Mut0_1;
    use crate::Networking::Mut1 as Mut1_1;
    use crate::Networking::Mut2 as Mut2_1;
    use crate::Networking::Mut3 as Mut3_1;
    use crate::Networking::State as State_1;
    use crate::Networking::US0 as US0_2;
    use crate::Runtime::Mut0 as Mut0_2;
    use crate::Runtime::Mut1 as Mut1_2;
    use crate::Runtime::Mut2 as Mut2_2;
    use crate::Runtime::Mut3 as Mut3_2;
    use crate::Runtime::State as State_2;
    use crate::Runtime::US0 as US0_3;
    use crate::Trace::Mut0 as Mut0_4;
    use crate::Trace::Mut1 as Mut1_4;
    use crate::Trace::Mut2 as Mut2_4;
    use crate::Trace::Mut3 as Mut3_4;
    use crate::Trace::State as State_4;
    use crate::Trace::US0;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Option_::getValue;
    pub mod SpiralTrace {
        use super::*;
        use crate::Trace;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::String_::string;
        pub fn trace(x: US0) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
            Trace::trace(x)
        }
    }
    pub mod SpiralCrypto {
        use super::*;
        use crate::Crypto;
        use fable_library_rust::String_::string;
        pub fn hash_text(x: string) -> string {
            Crypto::hash_text(x)
        }
    }
    pub mod SpiralSm {
        use super::*;
        use crate::Sm;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::String_::string;
        use fable_library_rust::System::Exception;
        pub fn concat(x: string) -> Func1<LrcPtr<dyn IEnumerable_1<string>>, string> {
            Sm::concat(x)
        }
        pub fn contains(x: string) -> Func1<string, bool> {
            Sm::contains(x)
        }
        pub fn ellipsis(x: i32) -> Func1<string, string> {
            Sm::ellipsis(x)
        }
        pub fn ellipsis_end(x: i64) -> Func1<string, string> {
            Sm::ellipsis_end(x)
        }
        pub fn ends_with(x: string) -> Func1<string, bool> {
            Sm::ends_with(x)
        }
        pub fn format_exception(x: LrcPtr<Exception>) -> string {
            Sm::format_exception(x)
        }
        pub fn replace(x: string) -> Func1<string, Func1<string, string>> {
            Sm::replace(x)
        }
        pub fn replace_regex(x: string) -> Func1<string, Func1<string, string>> {
            Sm::replace_regex(x)
        }
        pub fn slice(x: i32) -> Func1<i32, Func1<string, string>> {
            Sm::slice(x)
        }
        pub fn split(x: string) -> Func1<string, Array<string>> {
            Sm::split(x)
        }
        pub fn split_string(x: Array<string>) -> Func1<string, Array<string>> {
            Sm::split_string(x)
        }
        pub fn starts_with(x: string) -> Func1<string, bool> {
            Sm::starts_with(x)
        }
        pub fn substring(x: i32) -> Func1<i32, Func1<string, string>> {
            Sm::substring(x)
        }
        pub fn to_lower(x: string) -> string {
            Sm::to_lower(x)
        }
        pub fn trim(x: string) -> string {
            Sm::trim(x)
        }
        pub fn trim_start(x: Array<char>) -> Func1<string, string> {
            Sm::trim_start(x)
        }
        pub fn trim_end(x: Array<char>) -> Func1<string, string> {
            Sm::trim_end(x)
        }
    }
    pub mod SpiralFileSystem {
        use super::*;
        use crate::File_system;
        use fable_library_rust::Interfaces_::System::IDisposable;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::String_::string;
        pub fn get_repository_root() -> string {
            File_system::get_repository_root()
        }
        pub fn get_source_directory() -> string {
            File_system::get_source_directory()
        }
        pub fn find_parent(x: string) -> Func1<bool, Func1<string, string>> {
            File_system::find_parent(x)
        }
        pub fn normalize_path(x: string) -> string {
            File_system::normalize_path(x)
        }
        pub fn new_file_uri(x: string) -> string {
            File_system::new_file_uri(x)
        }
        pub fn create_temp_directory() -> (string, LrcPtr<dyn IDisposable>) {
            File_system::create_temp_directory()
        }
        pub fn create_temp_directory_name() -> string {
            File_system::create_temp_directory_name()
        }
    }
    pub fn set_trace_level(new_level: US0) {
        let patternInput: (
            LrcPtr<Mut0>,
            LrcPtr<Mut1>,
            LrcPtr<Mut2>,
            Option<i64>,
            LrcPtr<Mut3>,
        ) = getValue(State::trace_state().get().clone());
        (patternInput.2.clone()).l0.set(match &new_level {
            US0::US0_1 => US0_1::US0_1,
            US0::US0_2 => US0_1::US0_2,
            US0::US0_3 => US0_1::US0_3,
            US0::US0_4 => US0_1::US0_4,
            _ => US0_1::US0_0,
        });
        {
            let patternInput_1: (
                LrcPtr<Mut0_1>,
                LrcPtr<Mut1_1>,
                LrcPtr<Mut2_1>,
                Option<i64>,
                LrcPtr<Mut3_1>,
            ) = getValue(State_1::trace_state().get().clone());
            (patternInput_1.2.clone()).l0.set(match &new_level {
                US0::US0_1 => US0_2::US0_1,
                US0::US0_2 => US0_2::US0_2,
                US0::US0_3 => US0_2::US0_3,
                US0::US0_4 => US0_2::US0_4,
                _ => US0_2::US0_0,
            });
            {
                let patternInput_2: (
                    LrcPtr<Mut0_2>,
                    LrcPtr<Mut1_2>,
                    LrcPtr<Mut2_2>,
                    Option<i64>,
                    LrcPtr<Mut3_2>,
                ) = getValue(State_2::trace_state().get().clone());
                (patternInput_2.2.clone()).l0.set(match &new_level {
                    US0::US0_1 => US0_3::US0_1,
                    US0::US0_2 => US0_3::US0_2,
                    US0::US0_3 => US0_3::US0_3,
                    US0::US0_4 => US0_3::US0_4,
                    _ => US0_3::US0_0,
                });
                {
                    let patternInput_3: (
                        LrcPtr<Mut0_3>,
                        LrcPtr<Mut1_3>,
                        LrcPtr<Mut2_3>,
                        Option<i64>,
                        LrcPtr<Mut3_3>,
                    ) = getValue(State_3::trace_state().get().clone());
                    (patternInput_3.2.clone()).l0.set(match &new_level {
                        US0::US0_1 => US0_4::US0_1,
                        US0::US0_2 => US0_4::US0_2,
                        US0::US0_3 => US0_4::US0_3,
                        US0::US0_4 => US0_4::US0_4,
                        _ => US0_4::US0_0,
                    });
                    {
                        let patternInput_4: (
                            LrcPtr<Mut0_4>,
                            LrcPtr<Mut1_4>,
                            LrcPtr<Mut2_4>,
                            Option<i64>,
                            LrcPtr<Mut3_4>,
                        ) = getValue(State_4::trace_state().get().clone());
                        (patternInput_4.2.clone()).l0.set(new_level.clone())
                    }
                }
            }
        }
    }
    pub fn get_trace_level() -> US0 {
        let patternInput: (
            LrcPtr<Mut0_4>,
            LrcPtr<Mut1_4>,
            LrcPtr<Mut2_4>,
            Option<i64>,
            LrcPtr<Mut3_4>,
        ) = getValue(State_4::trace_state().get().clone());
        (patternInput.2.clone()).l0.get().clone()
    }
}
