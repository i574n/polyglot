pub mod Threading {
    use super::*;
    use fable_library_rust::Native_::getZero;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::System::IDisposable;
    use fable_library_rust::System::Threading::CancellationToken;
    type CancellationTokenSource = ();
    #[derive(Clone, Debug)]
    pub struct Disposable {
        f: Func0<()>,
    }
    impl Disposable {
        pub fn _ctor__3A5B6456(f: Func0<()>) -> LrcPtr<Threading::Disposable> {
            let f_1;
            ();
            f_1 = f;
            ();
            LrcPtr::new(Threading::Disposable { f: f_1 })
        }
    }
    impl core::fmt::Display for Disposable {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    impl IDisposable for Disposable {
        fn Dispose(&self) {
            (self.f)();
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US0 {
        US0_0(CancellationToken),
        US0_1,
    }
    impl core::fmt::Display for US0 {
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
        getZero::<()>();
        ()
    }
    pub fn method1(v0_1: LrcPtr<CancellationTokenSource>) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || Threading::closure2(v0_1.clone(), ())
        })
    }
    pub fn method2(v0_1: LrcPtr<CancellationTokenSource>) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || Threading::closure2(v0_1.clone(), ())
        })
    }
    pub fn closure0(
        unitVar: (),
        v0_1: Option<CancellationToken>,
    ) -> (CancellationToken, LrcPtr<dyn IDisposable>) {
        let patternInput: (CancellationToken, LrcPtr<dyn IDisposable>) =
            unbox::<(CancellationToken, LrcPtr<dyn IDisposable>)>(&getZero());
        let _run_target_args__v1: (CancellationToken, LrcPtr<dyn IDisposable>) =
            (patternInput.0.clone(), patternInput.1.clone());
        (
            _run_target_args__v1.0.clone(),
            _run_target_args__v1.1.clone(),
        )
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
