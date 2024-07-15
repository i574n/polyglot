from collections.abc import Callable
from fable_modules.fable_library.async_builder import (CancellationToken, Async)

def closure0(unit_var: None, v0_1: CancellationToken) -> Async[CancellationToken]:
    _v3: Async[CancellationToken] | None = None
    _v3 = None
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        return _v3



def _arrow26(v: CancellationToken) -> Async[CancellationToken]:
    return closure0(None, v)


v0: Callable[[CancellationToken], Async[CancellationToken]] = _arrow26

def merge_cancellation_token_with_default_async(x: CancellationToken) -> Async[CancellationToken]:
    return v0(x)


