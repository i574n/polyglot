// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

bool closure0(void unitVar, void unitVar_1) {
    types.Some<bool>? _v0;
    _v0 = const types.Some(false);
    return types.value(_v0);
}

String closure1(void unitVar, void unitVar_1) {
    types.Some<bool>? _v0;
    _v0 = const types.Some(false);
    if (types.value(_v0)) {
        return '.exe';
    } else {
        return '';
    }
}

bool v0() => closure0(util.ignore(), util.ignore());

bool is_windows() => v0();

String v1() => closure1(util.ignore(), util.ignore());

String get_executable_suffix() => v1();

