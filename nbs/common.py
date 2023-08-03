from __future__ import annotations
from typing import (Any, List, Optional, Callable)
from fable_modules.fable_library.date import (to_string, now, op_subtraction, create)
from fable_modules.fable_library.reflection import (TypeInfo, union_type)
from fable_modules.fable_library.string_ import trim_end
from fable_modules.fable_library.time_span import (hours, minutes, seconds, milliseconds, microseconds)
from fable_modules.fable_library.types import (Array, Union)
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
        return ["Verbose", "Debug", "Info", "Warn", "Error"]


TraceLevel_reflection = _expr0

trace_enabled: bool = create_atom(True)

trace_count: int = create_atom(0)

trace_level: TraceLevel = create_atom(TraceLevel(0))

def repl_start(__unit: None=None) -> Optional[Any]:
    return None


def trace(level: TraceLevel, fn: Callable[[], str], get_locals: Callable[[], str]) -> None:
    if (compare(level, trace_level()) >= 0) if trace_enabled() else False:
        trace_count(trace_count() + 1)
        def _arrow2(__unit: None=None, level: TraceLevel=level, fn: Any=fn, get_locals: Any=get_locals) -> str:
            trim_chars: Array[str] = [" ", "/"]
            def _arrow1(__unit: None=None) -> Any:
                match_value: Optional[Any] = repl_start()
                if match_value is None:
                    return now()

                else: 
                    date_time: Any = match_value
                    t: Any = op_subtraction(now(), date_time)
                    return create(1, 1, 1, hours(t), minutes(t), seconds(t), milliseconds(t), microseconds(t))


            return trim_end(((((((((("" + to_string(_arrow1(), "HH:mm:ss")) + " #") + str(trace_count())) + " [") + str(level)) + "] ") + fn()) + " / ") + get_locals()) + "", *trim_chars)

        print(_arrow2())



