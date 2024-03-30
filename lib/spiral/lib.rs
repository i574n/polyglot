pub mod Lib {
    use super::*;
    pub mod Sm {
        use super::*;
        use crate::Sm;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
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
    pub mod File_system {
        use super::*;
        use crate::File_system;
        use fable_library_rust::String_::string;
        pub fn create_temp_directory_name() -> string {
            File_system::create_temp_directory_name()
        }
    }
}
