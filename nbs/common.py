from __future__ import annotations
from typing import (Any, List, Callable, Optional)
from fable_modules.fable_library.date import (to_string, now, get_ticks, create)
from fable_modules.fable_library.long import op_subtraction
from fable_modules.fable_library.reflection import (TypeInfo, union_type)
from fable_modules.fable_library.string_ import (trim_end, trim_start, to_text, interpolate)
from fable_modules.fable_library.time_span import (from_ticks, hours, minutes, seconds, milliseconds, microseconds)
from fable_modules.fable_library.types import (Array, Union, int64)
from fable_modules.fable_library.util import (create_atom, compare)

nl: str = "\n"

q: str = "\""

def _expr0() -> TypeInfo:
    return union_type("Polyglot.Common.TraceLevel", [], TraceLevel, lambda: [[], [], [], [], []])


class TraceLevel(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> List[str]:
        return ["Verbose", "Debug", "Info", "Warning", "Critical"]


TraceLevel_reflection = _expr0

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
        print(("" + fn()) + "")



def repl_start(__unit: None=None) -> Optional[int64]:
    return None


def trace(level: TraceLevel, fn: Callable[[], str], get_locals: Callable[[], str]) -> None:
    def fn_1(__unit: None=None, level: TraceLevel=level, fn: Any=fn, get_locals: Any=get_locals) -> str:
        trim_chars_2: Array[str] = [" ", "/"]
        def _arrow1(__unit: None=None) -> Any:
            match_value: Optional[int64] = repl_start()
            if match_value is None:
                return now()

            else: 
                repl_start_1: int64 = match_value
                t: Any = from_ticks(op_subtraction(get_ticks(now()), repl_start_1))
                return create(1, 1, 1, hours(t), minutes(t), seconds(t), milliseconds(t), microseconds(t))


        return trim_end(trim_start(to_text(interpolate("%P() #%P() [%A%P()] %s%P() / %s%P()", [to_string(_arrow1(), "HH:mm:ss"), trace_count(), level, fn(), get_locals()]))), *trim_chars_2)

    trace_raw(level, fn_1)


