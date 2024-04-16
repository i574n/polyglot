pub mod Threading {
    use super::*;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    type CancellationToken = ();
    type CancellationTokenSource = ();
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0(CancellationToken),
        US0_1,
    }
    impl Threading::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<Threading::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<Threading::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Threading::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn closure1(unitVar: (), v0_1: CancellationToken) -> Threading::US0 {
        Threading::US0::US0_0(v0_1)
    }
    pub fn method0() -> Func1<CancellationToken, Threading::US0> {
        Func1::new(move |v: CancellationToken| Threading::closure1((), v))
    }
    pub fn closure2(v0_1: LrcPtr<CancellationTokenSource>, unitVar: ()) {
        let _v1: MutCell<Option<()>> = MutCell::new(None::<()>);
        defaultOf::<()>();
        _v1.set(Some(()));
        getValue(_v1.get().clone());
        ()
    }
    pub fn closure0(
        unitVar: (),
        v0_1: Option<CancellationToken>,
    ) -> (CancellationToken, LrcPtr<dyn IDisposable>) {
        let _v1: MutCell<Option<(CancellationToken, LrcPtr<dyn IDisposable>)>> =
            MutCell::new(None::<(CancellationToken, LrcPtr<dyn IDisposable>)>);
        let patternInput: (CancellationToken, LrcPtr<dyn IDisposable>) =
            unbox::<(CancellationToken, LrcPtr<dyn IDisposable>)>(&defaultOf());
        _v1.set(Some((patternInput.0.clone(), patternInput.1.clone())));
        {
            let patternInput_1: (CancellationToken, LrcPtr<dyn IDisposable>) =
                getValue(_v1.get().clone());
            (patternInput_1.0.clone(), patternInput_1.1.clone())
        }
    }
    pub fn v0() -> Func1<Option<CancellationToken>, (CancellationToken, LrcPtr<dyn IDisposable>)> {
        static v0: OnceInit<
            Func1<Option<CancellationToken>, (CancellationToken, LrcPtr<dyn IDisposable>)>,
        > = OnceInit::new();
        v0.get_or_init(|| {
            Func1::new(move |v: Option<CancellationToken>| Threading::closure0((), v))
        })
        .clone()
    }
    pub fn new_disposable_token(
        x: Option<CancellationToken>,
    ) -> (CancellationToken, LrcPtr<dyn IDisposable>) {
        (Threading::v0())(x)
    }
    on_startup!(());
}
