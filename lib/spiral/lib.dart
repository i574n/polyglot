// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../../../../../../../lib/spiral/file_system.fsx' as file_system;
import '../../../../../../../../lib/spiral/sm.fsx' as sm;
import '../../../../../../../../lib/spiral/trace.fsx' as trace;

types.Tuple5<trace.Mut0, trace.Mut1, trace.Mut1, trace.Mut2, types.Some<int>?> SpiralTrace_get_trace_state() => trace.get_trace_state();

void Function(String Function()) Function(String Function()) SpiralTrace_trace(trace.US0 x) => trace.trace(x);

const trace.US0 SpiralTrace_US0_0 = trace.US0(/* US0_0 */ 0);

const trace.US0 SpiralTrace_US0_1 = trace.US0(/* US0_1 */ 1);

const trace.US0 SpiralTrace_US0_2 = trace.US0(/* US0_2 */ 2);

const trace.US0 SpiralTrace_US0_3 = trace.US0(/* US0_3 */ 3);

const trace.US0 SpiralTrace_US0_4 = trace.US0(/* US0_4 */ 4);

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

String SpiralFileSystem_get_source_directory() => file_system.get_source_directory();

String Function(String) Function(bool) SpiralFileSystem_find_parent(String x) => file_system.find_parent(x);

types.Tuple2<String, types.IDisposable> SpiralFileSystem_create_temp_directory() => file_system.create_temp_directory();

String SpiralFileSystem_create_temp_directory_name() => file_system.create_temp_directory_name();

