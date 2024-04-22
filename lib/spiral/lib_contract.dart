// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../../../../../../../lib/spiral/common.fsx' as common;
import '../../../../../../../../lib/spiral/crypto.fsx' as crypto;
import '../../../../../../../../lib/spiral/file_system.fsx' as file_system;
import '../../../../../../../../lib/spiral/networking.fsx' as networking;
import '../../../../../../../../lib/spiral/runtime.fsx' as runtime;
import '../../../../../../../../lib/spiral/sm.fsx' as sm;
import '../../../../../../../../lib/spiral/trace.fsx' as trace;

void Function(String Function()) Function(String Function()) SpiralTrace_trace(trace.US0 x) => trace.trace(x);

String SpiralCrypto_hash_text(String x) => crypto.hash_text(x);

String Function(Iterable<String>) SpiralSm_concat(String x) => sm.concat(x);

bool Function(String) SpiralSm_contains(String x) => sm.contains(x);

String Function(String) SpiralSm_ellipsis(int x) => sm.ellipsis(x);

String Function(String) SpiralSm_ellipsis_end(int x) => sm.ellipsis_end(x);

bool Function(String) SpiralSm_ends_with(String x) => sm.ends_with(x);

String SpiralSm_format_exception(dynamic x) => sm.format_exception(x);

String Function(String) Function(String) SpiralSm_replace(String x) => sm.replace(x);

String Function(String) Function(int) SpiralSm_slice(int x) => sm.slice(x);

List<String> Function(String) SpiralSm_split(String x) => sm.split(x);

List<String> Function(String) SpiralSm_split_string(List<String> x) => sm.split_string(x);

bool Function(String) SpiralSm_starts_with(String x) => sm.starts_with(x);

String Function(String) Function(int) SpiralSm_substring(int x) => sm.substring(x);

String SpiralSm_to_lower(String x) => sm.to_lower(x);

String SpiralSm_trim(String x) => sm.trim(x);

String Function(String) SpiralSm_trim_start(List<int> x) => sm.trim_start(x);

String Function(String) SpiralSm_trim_end(List<int> x) => sm.trim_end(x);

String SpiralFileSystem_get_repository_root() => file_system.get_repository_root();

String SpiralFileSystem_get_source_directory() => file_system.get_source_directory();

String Function(String) Function(bool) SpiralFileSystem_find_parent(String x) => file_system.find_parent(x);

String SpiralFileSystem_normalize_path(String x) => file_system.normalize_path(x);

String SpiralFileSystem_new_file_uri(String x) => file_system.new_file_uri(x);

types.Tuple2<String, types.IDisposable> SpiralFileSystem_create_temp_directory() => file_system.create_temp_directory();

String SpiralFileSystem_create_temp_directory_name() => file_system.create_temp_directory_name();

void set_trace_level(trace.US0 new_level) {
    switch (new_level.tag) {
        case 1:
            types.value(file_system.State_trace_state).item3.l0 = const file_system.US0(/* US0_1 */ 1);
            break;
        case 2:
            types.value(file_system.State_trace_state).item3.l0 = const file_system.US0(/* US0_2 */ 2);
            break;
        case 3:
            types.value(file_system.State_trace_state).item3.l0 = const file_system.US0(/* US0_3 */ 3);
            break;
        case 4:
            types.value(file_system.State_trace_state).item3.l0 = const file_system.US0(/* US0_4 */ 4);
            break;
        default:
            types.value(file_system.State_trace_state).item3.l0 = const file_system.US0(/* US0_0 */ 0);
    }
    switch (new_level.tag) {
        case 1:
            types.value(networking.State_trace_state).item3.l0 = const networking.US0(/* US0_1 */ 1);
            break;
        case 2:
            types.value(networking.State_trace_state).item3.l0 = const networking.US0(/* US0_2 */ 2);
            break;
        case 3:
            types.value(networking.State_trace_state).item3.l0 = const networking.US0(/* US0_3 */ 3);
            break;
        case 4:
            types.value(networking.State_trace_state).item3.l0 = const networking.US0(/* US0_4 */ 4);
            break;
        default:
            types.value(networking.State_trace_state).item3.l0 = const networking.US0(/* US0_0 */ 0);
    }
    switch (new_level.tag) {
        case 1:
            types.value(runtime.State_trace_state).item3.l0 = const runtime.US0(/* US0_1 */ 1);
            break;
        case 2:
            types.value(runtime.State_trace_state).item3.l0 = const runtime.US0(/* US0_2 */ 2);
            break;
        case 3:
            types.value(runtime.State_trace_state).item3.l0 = const runtime.US0(/* US0_3 */ 3);
            break;
        case 4:
            types.value(runtime.State_trace_state).item3.l0 = const runtime.US0(/* US0_4 */ 4);
            break;
        default:
            types.value(runtime.State_trace_state).item3.l0 = const runtime.US0(/* US0_0 */ 0);
    }
    switch (new_level.tag) {
        case 1:
            types.value(common.State_trace_state).item3.l0 = const common.US0(/* US0_1 */ 1);
            break;
        case 2:
            types.value(common.State_trace_state).item3.l0 = const common.US0(/* US0_2 */ 2);
            break;
        case 3:
            types.value(common.State_trace_state).item3.l0 = const common.US0(/* US0_3 */ 3);
            break;
        case 4:
            types.value(common.State_trace_state).item3.l0 = const common.US0(/* US0_4 */ 4);
            break;
        default:
            types.value(common.State_trace_state).item3.l0 = const common.US0(/* US0_0 */ 0);
    }
    types.value(trace.State_trace_state).item3.l0 = new_level;
}

trace.US0 get_trace_level() => types.value(trace.State_trace_state).item3.l0;

