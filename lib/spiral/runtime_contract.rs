pub mod Runtime {
    use super::*;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::String_::string;
    pub fn closure0(unitVar: (), unitVar_1: ()) -> bool {
        let _v0: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v0.set(Some(x))
        }
        getValue(_v0.get().clone())
    }
    pub fn closure1(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v0.set(Some(x))
        }
        if getValue(_v0.get().clone()) {
            string(".exe")
        } else {
            string("")
        }
    }
    pub fn v0() -> Func0<bool> {
        static v0: OnceInit<Func0<bool>> = OnceInit::new();
        v0.get_or_insert_with(|| Func0::new(move || Runtime::closure0((), ())))
            .clone()
    }
    pub fn is_windows() -> bool {
        (Runtime::v0())()
    }
    pub fn v1() -> Func0<string> {
        static v1: OnceInit<Func0<string>> = OnceInit::new();
        v1.get_or_insert_with(|| Func0::new(move || Runtime::closure1((), ())))
            .clone()
    }
    pub fn get_executable_suffix() -> string {
        (Runtime::v1())()
    }
    on_startup!((),);
}
