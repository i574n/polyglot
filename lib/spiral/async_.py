from collections.abc import Callable
from fable_modules.fable_library.async_builder import (CancellationToken, Async)

def closure0(unit_var: None, v0_1: CancellationToken) -> Async[CancellationToken]:
    return None


def _arrow117(v: CancellationToken) -> Async[CancellationToken]:
    return closure0(None, v)


v0: Callable[[CancellationToken], Async[CancellationToken]] = _arrow117

def merge_cancellation_token_with_default_async(x: CancellationToken) -> Async[CancellationToken]:
    return v0(x)


