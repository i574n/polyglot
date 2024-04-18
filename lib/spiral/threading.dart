// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

class US0 implements types.Union {
    final int tag;
    const US0(this.tag);
    @override
    bool operator ==(Object other) => (other is US0) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
}

class US0_US0_0 extends US0 {
    final CancellationToken f0_0;
    const US0_US0_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US0_US0_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
}

bool US0__get_IsUS0_0(types.FSharpRef<US0, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US0__get_IsUS0_1(types.FSharpRef<US0, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

US0 closure1(void unitVar, CancellationToken v0_1) => US0_US0_0(v0_1);

US0 Function(CancellationToken) method0() => (CancellationToken v) => closure1(util.ignore(), v);

void closure2(CancellationTokenSource v0_1, void unitVar) {
    types.Some<void>? _v1;
    null;
    _v1 = types.Some(util.ignore());
    types.value(_v1);
}

types.Tuple2<CancellationToken, types.IDisposable> closure0(void unitVar, types.Some<CancellationToken>? v0_1) {
    types.Some<types.Tuple2<CancellationToken, types.IDisposable>>? _v1;
    const patternInput = types.Tuple2(null, null);
    _v1 = types.Some(types.Tuple2(patternInput.item1, patternInput.item2));
    final patternInput_1 = types.value(_v1);
    return types.Tuple2(patternInput_1.item1, patternInput_1.item2);
}

types.Tuple2<CancellationToken, types.IDisposable> v0(types.Some<CancellationToken>? v) => closure0(util.ignore(), v);

types.Tuple2<CancellationToken, types.IDisposable> new_disposable_token(types.Some<CancellationToken>? x) => v0(x);

