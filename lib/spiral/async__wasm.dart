// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

Async<CancellationToken> closure0(void unitVar, CancellationToken v0_1) {
    types.Some<Async<CancellationToken>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

Async<CancellationToken> v0(CancellationToken v) => closure0(util.ignore(), v);

Async<CancellationToken> merge_cancellation_token_with_default_async(CancellationToken x) => v0(x);

