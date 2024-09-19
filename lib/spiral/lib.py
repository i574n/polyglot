from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.option import (to_array, default_arg_with, map)
from fable_modules.fable_library.seq import iterate
from fable_modules.fable_library.types import (uint16, int64, Array)
from fable_modules.fable_library.util import (IEnumerable_1, IDisposable)
from ........polyglot.lib.spiral.common import (US0 as US0_4, Mut0 as Mut0_3, Mut1 as Mut1_3, Mut2 as Mut2_3, Mut3 as Mut3_3, Mut4 as Mut4_3, TraceState_trace_state as TraceState_trace_state_3)
from ........polyglot.lib.spiral.crypto import (hash_text, hash_to_port)
from ........polyglot.lib.spiral.file_system import (get_workspace_root, get_source_directory, normalize_path, new_file_uri, create_temp_dir, create_temp_dir_0027, create_temp_path, US0 as US0_2, Mut0 as Mut0_1, Mut1 as Mut1_1, Mut2 as Mut2_1, Mut3 as Mut3_1, Mut4 as Mut4_1, TraceState_trace_state as TraceState_trace_state_1)
from ........polyglot.lib.spiral.networking import (US0 as US0_1, Mut0, Mut1, Mut2, Mut3, Mut4, TraceState_trace_state)
from ........polyglot.lib.spiral.runtime import (US0 as US0_3, Mut0 as Mut0_2, Mut1 as Mut1_2, Mut2 as Mut2_2, Mut3 as Mut3_2, Mut4 as Mut4_2, TraceState_trace_state as TraceState_trace_state_2)
from ........polyglot.lib.spiral.sm import (concat, contains, ellipsis, ellipsis_end, ends_with, format_exception, replace, replace_regex, slice, split, split_string, starts_with, substring, to_lower, trim, trim_start, trim_end)
from ........polyglot.lib.spiral.trace import (trace, US0, Mut0 as Mut0_4, Mut1 as Mut1_4, Mut2 as Mut2_4, Mut3 as Mut3_4, Mut4 as Mut4_4, TraceState_trace_state as TraceState_trace_state_4)

def SpiralTrace_trace(x: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return trace(x)


def SpiralCrypto_hash_text(x: str) -> str:
    return hash_text(x)


def SpiralCrypto_hash_to_port(x: str) -> uint16:
    return hash_to_port(x)


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


def SpiralSm_replace_regex(x: str) -> Callable[[str, str], str]:
    return replace_regex(x)


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


def SpiralFileSystem_normalize_path(x: str) -> str:
    return normalize_path(x)


def SpiralFileSystem_new_file_uri(x: str) -> str:
    return new_file_uri(x)


def SpiralFileSystem_create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return create_temp_dir()


def SpiralFileSystem_create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return create_temp_dir_0027(x)


def SpiralFileSystem_create_temp_path(__unit: None=None) -> str:
    return create_temp_path()


def set_trace_level(new_level: US0) -> None:
    def action(_arg: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None], new_level: Any=new_level) -> None:
        _arg[4].l0 = US0_1(1) if (new_level.tag == 1) else (US0_1(2) if (new_level.tag == 2) else (US0_1(3) if (new_level.tag == 3) else (US0_1(4) if (new_level.tag == 4) else US0_1(0))))

    iterate(action, to_array(TraceState_trace_state()))
    def action_1(_arg_1: tuple[Mut0_1, Mut1_1, Mut2_1, Mut3_1, Mut4_1, int64 | None], new_level: Any=new_level) -> None:
        _arg_1[4].l0 = US0_2(1) if (new_level.tag == 1) else (US0_2(2) if (new_level.tag == 2) else (US0_2(3) if (new_level.tag == 3) else (US0_2(4) if (new_level.tag == 4) else US0_2(0))))

    iterate(action_1, to_array(TraceState_trace_state_1()))
    def action_2(_arg_2: tuple[Mut0_2, Mut1_2, Mut2_2, Mut3_2, Mut4_2, int64 | None], new_level: Any=new_level) -> None:
        _arg_2[4].l0 = US0_3(1) if (new_level.tag == 1) else (US0_3(2) if (new_level.tag == 2) else (US0_3(3) if (new_level.tag == 3) else (US0_3(4) if (new_level.tag == 4) else US0_3(0))))

    iterate(action_2, to_array(TraceState_trace_state_2()))
    def action_3(_arg_3: tuple[Mut0_3, Mut1_3, Mut2_3, Mut3_3, Mut4_3, int64 | None], new_level: Any=new_level) -> None:
        _arg_3[4].l0 = US0_4(1) if (new_level.tag == 1) else (US0_4(2) if (new_level.tag == 2) else (US0_4(3) if (new_level.tag == 3) else (US0_4(4) if (new_level.tag == 4) else US0_4(0))))

    iterate(action_3, to_array(TraceState_trace_state_3()))
    def action_4(_arg_4: tuple[Mut0_4, Mut1_4, Mut2_4, Mut3_4, Mut4_4, int64 | None], new_level: Any=new_level) -> None:
        _arg_4[4].l0 = new_level

    iterate(action_4, to_array(TraceState_trace_state_4()))


def get_trace_level(__unit: None=None) -> US0:
    def mapping(_arg: tuple[Mut0_4, Mut1_4, Mut2_4, Mut3_4, Mut4_4, int64 | None]) -> US0:
        return _arg[4].l0

    def def_thunk(__unit: None=None) -> US0:
        raise Exception("lib.get_trace_level / trace_state=None")

    return default_arg_with(map(mapping, TraceState_trace_state_4()), def_thunk)


