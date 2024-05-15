from __future__ import annotations
from collections.abc import Callable
from fable_modules.fable_library.option import value
from fable_modules.fable_library.string_ import (to_console, printf)
from fable_modules.fable_library.types import (int64, Array)
from fable_modules.fable_library.util import (IEnumerable_1, IDisposable, equals)
from ......lib.spiral.crypto import hash_text
from ......lib.spiral.file_system import (get_workspace_root, get_source_directory, find_parent, create_temp_directory, create_temp_directory_name, State_trace_state, Mut0, Mut1, Mut2, US0 as US0_1)
from ......lib.spiral.networking import (State_trace_state as State_trace_state_1, Mut0 as Mut0_1, Mut1 as Mut1_1, Mut2 as Mut2_1, US0 as US0_2)
from ......lib.spiral.runtime import (State_trace_state as State_trace_state_2, Mut0 as Mut0_2, Mut1 as Mut1_2, Mut2 as Mut2_2, US0 as US0_3)
from ......lib.spiral.sm import (concat, contains, ellipsis, ellipsis_end, ends_with, format_exception, replace, slice, split, split_string, starts_with, substring, to_lower, trim, trim_start, trim_end)
from ......lib.spiral.trace import (trace, US0, State_trace_state as State_trace_state_3, Mut0 as Mut0_3, Mut1 as Mut1_3, Mut2 as Mut2_3)

def SpiralTrace_trace(x: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return trace(x)


def SpiralCrypto_hash_text(x: str) -> str:
    return hash_text(x)


def SpiralSm_concat(x: str) -> Callable[[IEnumerable_1[str]], str]:
    return concat(x)


def SpiralSm_contains(x: str) -> Callable[[str], bool]:
    return contains(x)


def SpiralSm_ellipsis(x: int) -> Callable[[str], str]:
    return ellipsis(x)


def SpiralSm_ellipsis_end(x: int64) -> Callable[[str], str]:
    return ellipsis_end(x)


def SpiralSm_ends_with(x: str) -> Callable[[str], bool]:
    return ends_with(x)


def SpiralSm_format_exception(x: Exception) -> str:
    return format_exception(x)


def SpiralSm_replace(x: str) -> Callable[[str, str], str]:
    return replace(x)


def SpiralSm_slice(x: int) -> Callable[[int, str], str]:
    return slice(x)


def SpiralSm_split(x: str) -> Callable[[str], Array[str]]:
    return split(x)


def SpiralSm_split_string(x: Array[str]) -> Callable[[str], Array[str]]:
    return split_string(x)


def SpiralSm_starts_with(x: str) -> Callable[[str], bool]:
    return starts_with(x)


def SpiralSm_substring(x: int) -> Callable[[int, str], str]:
    return substring(x)


def SpiralSm_to_lower(x: str) -> str:
    return to_lower(x)


def SpiralSm_trim(x: str) -> str:
    return trim(x)


def SpiralSm_trim_start(x: Array[str]) -> Callable[[str], str]:
    return trim_start(x)


def SpiralSm_trim_end(x: Array[str]) -> Callable[[str], str]:
    return trim_end(x)


def SpiralFileSystem_get_workspace_root(__unit: None=None) -> str:
    return get_workspace_root()


def SpiralFileSystem_get_source_directory(__unit: None=None) -> str:
    return get_source_directory()


def SpiralFileSystem_find_parent(x: str) -> Callable[[bool, str], str]:
    return find_parent(x)


def SpiralFileSystem_create_temp_directory(__unit: None=None) -> tuple[str, IDisposable]:
    return create_temp_directory()


def SpiralFileSystem_create_temp_directory_name(__unit: None=None) -> str:
    return create_temp_directory_name()


def set_trace_level(new_level: US0) -> None:
    if equals(State_trace_state(), None):
        to_console(printf("@1"))

    else:
        pattern_input: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] = value(State_trace_state())
        pattern_input[3].l0 = US0_1(1) if (new_level.tag == 1) else (US0_1(2) if (new_level.tag == 2) else (US0_1(3) if (new_level.tag == 3) else (US0_1(4) if (new_level.tag == 4) else US0_1(0))))

    if equals(State_trace_state_1(), None):
        to_console(printf("@2"))

    else:
        pattern_input_1: tuple[Mut0_1, Mut1_1, Mut1_1, Mut2_1, int64 | None] = value(State_trace_state_1())
        pattern_input_1[3].l0 = US0_2(1) if (new_level.tag == 1) else (US0_2(2) if (new_level.tag == 2) else (US0_2(3) if (new_level.tag == 3) else (US0_2(4) if (new_level.tag == 4) else US0_2(0))))

    if equals(State_trace_state_2(), None):
        to_console(printf("@3"))

    else:
        pattern_input_2: tuple[Mut0_2, Mut1_2, Mut1_2, Mut2_2, int64 | None] = value(State_trace_state_2())
        pattern_input_2[3].l0 = US0_3(1) if (new_level.tag == 1) else (US0_3(2) if (new_level.tag == 2) else (US0_3(3) if (new_level.tag == 3) else (US0_3(4) if (new_level.tag == 4) else US0_3(0))))

    if equals(State_trace_state_3(), None):
        to_console(printf("@4"))

    else:
        pattern_input_3: tuple[Mut0_3, Mut1_3, Mut1_3, Mut2_3, int64 | None] = value(State_trace_state_3())
        pattern_input_3[3].l0 = new_level



def get_trace_level(__unit: None=None) -> US0:
    if equals(State_trace_state_3(), None):
        to_console(printf("@6"))
        return US0(0)

    else:
        pattern_input: tuple[Mut0_3, Mut1_3, Mut1_3, Mut2_3, int64 | None] = value(State_trace_state_3())
        return pattern_input[3].l0
