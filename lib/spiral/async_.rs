pub mod Async_ {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    type CancellationToken = ();
    pub fn closure0(unitVar: (), v0_1: CancellationToken) -> Arc<Async<CancellationToken>> {
        let _v1: MutCell<Option<Arc<Async<CancellationToken>>>> =
            MutCell::new(None::<Arc<Async<CancellationToken>>>);
        {
            let x: Arc<Async<CancellationToken>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn v0() -> Func1<CancellationToken, Arc<Async<CancellationToken>>> {
        static v0: OnceInit<Func1<CancellationToken, Arc<Async<CancellationToken>>>> =
            OnceInit::new();
        v0.get_or_insert_with(|| Func1::new(move |v: CancellationToken| Async_::closure0((), v)))
            .clone()
    }
    pub fn merge_cancellation_token_with_default_async(
        x: CancellationToken,
    ) -> Arc<Async<CancellationToken>> {
        (Async_::v0())(x)
    }
    on_startup!((),);
}
