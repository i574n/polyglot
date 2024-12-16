pub mod Async_ {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::Native_::getZero;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::System::Threading::CancellationToken;
    pub fn method0(v0_1: CancellationToken) -> Arc<Async<CancellationToken>> {
        getZero()
    }
    pub fn closure0(unitVar: (), v0_1: CancellationToken) -> Arc<Async<CancellationToken>> {
        Async_::method0(v0_1)
    }
    pub fn v0() -> Func1<CancellationToken, Arc<Async<CancellationToken>>> {
        static v0: OnceInit<Func1<CancellationToken, Arc<Async<CancellationToken>>>> =
            OnceInit::new();
        v0.get_or_init(|| Func1::new(move |v: CancellationToken| Async_::closure0((), v)))
            .clone()
    }
    pub fn merge_cancellation_token_with_default_async(
        x: CancellationToken,
    ) -> Arc<Async<CancellationToken>> {
        (Async_::v0())(x)
    }
    on_startup!(());
}
