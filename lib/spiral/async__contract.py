from collections.abc import Callable
from fable_modules.fable_library.async_builder import (CancellationToken, Async)
from fable_modules.fable_library.option import value as value_1

def closure0(unit_var: None, v0_1: CancellationToken) -> Async[CancellationToken]:
    _v1: Async[CancellationToken] | None = None
    _v1 = None
    return value_1(_v1)


def _arrow29(v: CancellationToken) -> Async[CancellationToken]:
    return closure0(None, v)


v0: Callable[[CancellationToken], Async[CancellationToken]] = _arrow29

def merge_cancellation_token_with_default_async(x: CancellationToken) -> Async[CancellationToken]:
    return v0(x)


