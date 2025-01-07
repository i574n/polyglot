from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.async_builder import (singleton, CancellationToken, Async)

def method0(v0_1: CancellationToken) -> Async[CancellationToken]:
    def _arrow100(__unit: None=None, v0_1: Any=v0_1) -> Async[CancellationToken]:
        return singleton.Return(None)

    return singleton.Delay(_arrow100)


def closure0(unit_var: None, v0_1: CancellationToken) -> Async[CancellationToken]:
    return method0(v0_1)


def _arrow101(v: CancellationToken) -> Async[CancellationToken]:
    return closure0(None, v)


v0: Callable[[CancellationToken], Async[CancellationToken]] = _arrow101

def merge_cancellation_token_with_default_async(x: CancellationToken) -> Async[CancellationToken]:
    return v0(x)


