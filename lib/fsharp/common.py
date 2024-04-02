from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.date import (to_string, now, ticks as ticks_1, create as create_1)
from fable_modules.fable_library.long import op_subtraction
from fable_modules.fable_library.reflection import (TypeInfo, union_type)
from fable_modules.fable_library.string_ import (to_text, interpolate)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (Array, Union, int64)
from fable_modules.fable_library.util import (create_atom, compare)
from .....lib.spiral.lib import (trim_end, trim_start)

nl: str = "\n"

q: str = "\""

def _expr70() -> TypeInfo:
    return union_type("Polyglot.Common.TraceLevel", [], TraceLevel, lambda: [[], [], [], [], []])


class TraceLevel(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["Verbose", "Debug", "Info", "Warning", "Critical"]


TraceLevel_reflection = _expr70

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
        def _arrow71(__unit: None=None) -> Any:
            match_value: int64 | None = repl_start()
            if match_value is None:
                return now()

            else: 
                repl_start_1: int64 = match_value
                t: Any = create(op_subtraction(ticks_1(now()), repl_start_1))
                return create_1(1, 1, 1, hours(t), minutes(t), seconds(t), milliseconds(t))


        time: str = to_string(_arrow71(), "HH:mm:ss")
        return trim_end([" ", "/"])(trim_start([])(to_text(interpolate("%P() #%P() [%A%P()] %s%P() / %s%P()", [time, trace_count(), level, fn(None), get_locals(None)]))))

    trace_raw(level, fn_1)


