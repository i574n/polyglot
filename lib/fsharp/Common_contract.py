from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.reflection import (TypeInfo, union_type)
from fable_modules.fable_library.string_ import (to_text, interpolate)
from fable_modules.fable_library.types import (Array, Union, int64)
from fable_modules.fable_library.util import (create_atom, compare)
from ......lib.spiral.lib import (SpiralSm_trim_end, SpiralSm_trim_start)

nl: str = "\n"

q: str = "\""

def _expr82() -> TypeInfo:
    return union_type("Polyglot.Common.TraceLevel", [], TraceLevel, lambda: [[], [], [], [], []])


class TraceLevel(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["Verbose", "Debug", "Info", "Warning", "Critical"]


TraceLevel_reflection = _expr82

def TraceLevel__get_IsVerbose(this: TraceLevel, unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def TraceLevel__get_IsDebug(this: TraceLevel, unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def TraceLevel__get_IsInfo(this: TraceLevel, unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def TraceLevel__get_IsWarning(this: TraceLevel, unit_arg: None) -> bool:
    if this.tag == 3:
        return True

    else: 
        return False



def TraceLevel__get_IsCritical(this: TraceLevel, unit_arg: None) -> bool:
    if this.tag == 4:
        return True

    else: 
        return False



trace_enabled: bool = create_atom(True)

trace_count: int = create_atom(0)

trace_level: TraceLevel = create_atom(TraceLevel(0))

trace_dump: bool = create_atom(False)

def test_trace_level(level: TraceLevel) -> bool:
    if trace_enabled():
        return compare(level, trace_level()) >= 0

    else: 
        return False



def trace_raw(level: TraceLevel, fn: Callable[[], str]) -> None:
    if test_trace_level(level):
        trace_count(trace_count() + 1)
        print(("" + fn(None)) + "")



def repl_start(__unit: None=None) -> int64 | None:
    return None


def trace(level: TraceLevel, fn: Callable[[], str], get_locals: Callable[[], str]) -> None:
    def fn_1(__unit: None=None, level: Any=level, fn: Any=fn, get_locals: Any=get_locals) -> str:
        return SpiralSm_trim_end([" ", "/"])(SpiralSm_trim_start([])(to_text(interpolate("%P() #%P() [%A%P()] %s%P() / %s%P()", ["", trace_count(), level, fn(None), get_locals(None)]))))

    trace_raw(level, fn_1)


