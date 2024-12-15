pub mod Lib {
    use super::*;
    use crate::Common::Mut0 as Mut0_3;
    use crate::Common::Mut1 as Mut1_3;
    use crate::Common::Mut2 as Mut2_3;
    use crate::Common::Mut3 as Mut3_3;
    use crate::Common::Mut4 as Mut4_3;
    use crate::Common::TraceState::trace_state as trace_state_3;
    use crate::Common::US0 as US0_4;
    use crate::File_system::Mut0 as Mut0_1;
    use crate::File_system::Mut1 as Mut1_1;
    use crate::File_system::Mut2 as Mut2_1;
    use crate::File_system::Mut3 as Mut3_1;
    use crate::File_system::Mut4 as Mut4_1;
    use crate::File_system::TraceState::trace_state as trace_state_1;
    use crate::File_system::US0 as US0_2;
    use crate::Networking::Mut0;
    use crate::Networking::Mut1;
    use crate::Networking::Mut2;
    use crate::Networking::Mut3;
    use crate::Networking::Mut4;
    use crate::Networking::TraceState::trace_state;
    use crate::Networking::US0 as US0_1;
    use crate::Runtime::Mut0 as Mut0_2;
    use crate::Runtime::Mut1 as Mut1_2;
    use crate::Runtime::Mut2 as Mut2_2;
    use crate::Runtime::Mut3 as Mut3_2;
    use crate::Runtime::Mut4 as Mut4_2;
    use crate::Runtime::TraceState::trace_state as trace_state_2;
    use crate::Runtime::US0 as US0_3;
    use crate::Trace::Mut0 as Mut0_4;
    use crate::Trace::Mut1 as Mut1_4;
    use crate::Trace::Mut2 as Mut2_4;
    use crate::Trace::Mut3 as Mut3_4;
    use crate::Trace::Mut4 as Mut4_4;
    use crate::Trace::TraceState::trace_state as trace_state_4;
    use crate::Trace::US0;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Option_::defaultWith;
    use fable_library_rust::Option_::iterate;
    use fable_library_rust::Option_::map;
    use fable_library_rust::String_::string;
    pub mod SpiralTrace {
        use super::*;
        use crate::Trace::trace as trace_1;
        pub fn trace(x: US0) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
            trace_1(x)
        }
    }
    pub mod SpiralCrypto {
        use super::*;
        use crate::Crypto::hash_text as hash_text_1;
        use crate::Crypto::hash_to_port as hash_to_port_1;
        pub fn hash_text(x: string) -> string {
            hash_text_1(x)
        }
        pub fn hash_to_port(x: string) -> u16 {
            hash_to_port_1(x)
        }
    }
    pub mod SpiralSm {
        use super::*;
        use crate::Sm::concat as concat_1;
        use crate::Sm::contains as contains_1;
        use crate::Sm::ellipsis as ellipsis_1;
        use crate::Sm::ellipsis_end as ellipsis_end_1;
        use crate::Sm::ends_with as ends_with_1;
        use crate::Sm::format_exception as format_exception_1;
        use crate::Sm::replace as replace_1;
        use crate::Sm::replace_regex as replace_regex_1;
        use crate::Sm::slice as slice_1;
        use crate::Sm::split as split_1;
        use crate::Sm::split_string as split_string_1;
        use crate::Sm::starts_with as starts_with_1;
        use crate::Sm::substring as substring_1;
        use crate::Sm::to_lower as to_lower_1;
        use crate::Sm::trim as trim_1;
        use crate::Sm::trim_end as trim_end_1;
        use crate::Sm::trim_start as trim_start_1;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::System::Exception;
        pub fn concat(x: string) -> Func1<LrcPtr<dyn IEnumerable_1<string>>, string> {
            concat_1(x)
        }
        pub fn contains(x: string) -> Func1<string, bool> {
            contains_1(x)
        }
        pub fn ellipsis(x: i32) -> Func1<string, string> {
            ellipsis_1(x)
        }
        pub fn ellipsis_end(x: i64) -> Func1<string, string> {
            ellipsis_end_1(x)
        }
        pub fn ends_with(x: string) -> Func1<string, bool> {
            ends_with_1(x)
        }
        pub fn format_exception(x: LrcPtr<Exception>) -> string {
            format_exception_1(x)
        }
        pub fn replace(x: string) -> Func1<string, Func1<string, string>> {
            replace_1(x)
        }
        pub fn replace_regex(x: string) -> Func1<string, Func1<string, string>> {
            replace_regex_1(x)
        }
        pub fn slice(x: i32) -> Func1<i32, Func1<string, string>> {
            slice_1(x)
        }
        pub fn split(x: string) -> Func1<string, Array<string>> {
            split_1(x)
        }
        pub fn split_string(x: Array<string>) -> Func1<string, Array<string>> {
            split_string_1(x)
        }
        pub fn starts_with(x: string) -> Func1<string, bool> {
            starts_with_1(x)
        }
        pub fn substring(x: i32) -> Func1<i32, Func1<string, string>> {
            substring_1(x)
        }
        pub fn to_lower(x: string) -> string {
            to_lower_1(x)
        }
        pub fn trim(x: string) -> string {
            trim_1(x)
        }
        pub fn trim_start(x: Array<char>) -> Func1<string, string> {
            trim_start_1(x)
        }
        pub fn trim_end(x: Array<char>) -> Func1<string, string> {
            trim_end_1(x)
        }
    }
    pub mod SpiralFileSystem {
        use super::*;
        use crate::File_system::create_temp_dir as create_temp_dir_1;
        use crate::File_system::create_temp_dir_ as create_temp_dir__1;
        use crate::File_system::create_temp_path as create_temp_path_1;
        use crate::File_system::get_source_directory as get_source_directory_1;
        use crate::File_system::get_workspace_root as get_workspace_root_1;
        use crate::File_system::new_file_uri as new_file_uri_1;
        use crate::File_system::normalize_path as normalize_path_1;
        use fable_library_rust::System::IDisposable;
        pub fn get_workspace_root() -> string {
            get_workspace_root_1()
        }
        pub fn get_source_directory() -> string {
            get_source_directory_1()
        }
        pub fn normalize_path(x: string) -> string {
            normalize_path_1(x)
        }
        pub fn new_file_uri(x: string) -> string {
            new_file_uri_1(x)
        }
        pub fn create_temp_dir() -> (string, LrcPtr<dyn IDisposable>) {
            create_temp_dir_1()
        }
        pub fn create_temp_dir_(x: string) -> (string, LrcPtr<dyn IDisposable>) {
            create_temp_dir__1(x)
        }
        pub fn create_temp_path() -> string {
            create_temp_path_1()
        }
    }
    pub fn set_trace_level(new_level: US0) {
        iterate(
            Func1::new({
                let new_level = new_level.clone();
                move |_arg: (
                    LrcPtr<Mut0>,
                    LrcPtr<Mut1>,
                    LrcPtr<Mut2>,
                    LrcPtr<Mut3>,
                    LrcPtr<Mut4>,
                    Option<i64>,
                )| {
                    (_arg.4.clone()).l0.set(match &new_level {
                        US0::US0_1 => US0_1::US0_1,
                        US0::US0_2 => US0_1::US0_2,
                        US0::US0_3 => US0_1::US0_3,
                        US0::US0_4 => US0_1::US0_4,
                        _ => US0_1::US0_0,
                    })
                }
            }),
            trace_state().get().clone(),
        );
        iterate(
            Func1::new({
                let new_level = new_level.clone();
                move |_arg_1: (
                    LrcPtr<Mut0_1>,
                    LrcPtr<Mut1_1>,
                    LrcPtr<Mut2_1>,
                    LrcPtr<Mut3_1>,
                    LrcPtr<Mut4_1>,
                    Option<i64>,
                )| {
                    (_arg_1.4.clone()).l0.set(match &new_level {
                        US0::US0_1 => US0_2::US0_1,
                        US0::US0_2 => US0_2::US0_2,
                        US0::US0_3 => US0_2::US0_3,
                        US0::US0_4 => US0_2::US0_4,
                        _ => US0_2::US0_0,
                    })
                }
            }),
            trace_state_1().get().clone(),
        );
        iterate(
            Func1::new({
                let new_level = new_level.clone();
                move |_arg_2: (
                    LrcPtr<Mut0_2>,
                    LrcPtr<Mut1_2>,
                    LrcPtr<Mut2_2>,
                    LrcPtr<Mut3_2>,
                    LrcPtr<Mut4_2>,
                    Option<i64>,
                )| {
                    (_arg_2.4.clone()).l0.set(match &new_level {
                        US0::US0_1 => US0_3::US0_1,
                        US0::US0_2 => US0_3::US0_2,
                        US0::US0_3 => US0_3::US0_3,
                        US0::US0_4 => US0_3::US0_4,
                        _ => US0_3::US0_0,
                    })
                }
            }),
            trace_state_2().get().clone(),
        );
        iterate(
            Func1::new({
                let new_level = new_level.clone();
                move |_arg_3: (
                    LrcPtr<Mut0_3>,
                    LrcPtr<Mut1_3>,
                    LrcPtr<Mut2_3>,
                    LrcPtr<Mut3_3>,
                    LrcPtr<Mut4_3>,
                    Option<i64>,
                )| {
                    (_arg_3.4.clone()).l0.set(match &new_level {
                        US0::US0_1 => US0_4::US0_1,
                        US0::US0_2 => US0_4::US0_2,
                        US0::US0_3 => US0_4::US0_3,
                        US0::US0_4 => US0_4::US0_4,
                        _ => US0_4::US0_0,
                    })
                }
            }),
            trace_state_3().get().clone(),
        );
        iterate(
            Func1::new({
                let new_level = new_level.clone();
                move |_arg_4: (
                    LrcPtr<Mut0_4>,
                    LrcPtr<Mut1_4>,
                    LrcPtr<Mut2_4>,
                    LrcPtr<Mut3_4>,
                    LrcPtr<Mut4_4>,
                    Option<i64>,
                )| (_arg_4.4.clone()).l0.set(new_level.clone())
            }),
            trace_state_4().get().clone(),
        )
    }
    pub fn get_trace_level() -> US0 {
        defaultWith(
            Func0::new(move || panic!("{}", string("lib.get_trace_level / trace_state=None"),)),
            map(
                Func1::new(
                    move |_arg: (
                        LrcPtr<Mut0_4>,
                        LrcPtr<Mut1_4>,
                        LrcPtr<Mut2_4>,
                        LrcPtr<Mut3_4>,
                        LrcPtr<Mut4_4>,
                        Option<i64>,
                    )| (_arg.4.clone()).l0.get().clone(),
                ),
                trace_state_4().get().clone(),
            ),
        )
    }
}
