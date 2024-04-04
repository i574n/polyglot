<?php
namespace Sm;

require_once(__FABLE_LIBRARY__.'/Array.php');
require_once(__FABLE_LIBRARY__.'/BigInt.php');
require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/Seq.php');
require_once(__FABLE_LIBRARY__.'/String.php');

use \IComparable;

#0
class Mut0 implements IComparable {
    public $l0;
    public $l1;
    function __construct($l0, $l1) {
        $this->l0 = $l0;
        $this->l1 = $l1;
    }
    static function get_l0_Type() {
        return 'Int32';
    }
    static function get_l1_Type() {
        return 'String';
    }
    function CompareTo($other) {
        $_cmp__1 = $this->l0 > $other->l0 ? 1 : ($this->l0 < $other->l0 ? -1 : 0);
        if ($_cmp__1 != 0) {
            return $_cmp__1;
        }        
        $_cmp__2 = $this->l1 > $other->l1 ? 1 : ($this->l1 < $other->l1 ? -1 : 0);
        if ($_cmp__2 != 0) {
            return $_cmp__2;
        }        
        return 0;
    }
}

#1
class Mut1 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return 'Int32';
    }
    function CompareTo($other) {
        $_cmp__3 = $this->l0 > $other->l0 ? 1 : ($this->l0 < $other->l0 ? -1 : 0);
        if ($_cmp__3 != 0) {
            return $_cmp__3;
        }        
        return 0;
    }
}

#2
function closure1($v0_1, $v1_1) {
    return $v1_1->indexOf >= 0;
}

#3
function closure0($unitVar, $v0_1) {
    return function ($v) use ($closure1, $v0_1) {     return closure1($v0_1, $v);
 };
}

#4
function closure3($v0_1, $v1_1) {
    return $v1_1->\String\endsWith($v0_1);
}

#5
function closure2($unitVar, $v0_1) {
    return function ($v) use ($closure3, $v0_1) {     return closure3($v0_1, $v);
 };
}

#6
function closure6($v0_1, $v1_1, $v2_1) {
    return $v2_1->\String\padLeft($v0_1, $v1_1);
}

#7
function closure5($v0_1, $v1_1) {
    return function ($v) use ($closure6, $v0_1, $v1_1) {     return closure6($v0_1, $v1_1, $v);
 };
}

#8
function closure4($unitVar, $v0_1) {
    return function ($v) use ($closure5, $v0_1) {     return closure5($v0_1, $v);
 };
}

#9
function closure8($v0_1, $v1_1) {
    return $v1_1->\String\padRight($v0_1);
}

#10
function closure7($unitVar, $v0_1) {
    return function ($v) use ($closure8, $v0_1) {     return closure8($v0_1, $v);
 };
}

#11
function closure11($v0_1, $v1_1, $v2_1) {
    return $v2_1->\String\replace($v0_1, $v1_1);
}

#12
function closure10($v0_1, $v1_1) {
    return function ($v) use ($closure11, $v0_1, $v1_1) {     return closure11($v0_1, $v1_1, $v);
 };
}

#13
function closure9($unitVar, $v0_1) {
    return function ($v) use ($closure10, $v0_1) {     return closure10($v0_1, $v);
 };
}

#14
function closure14($v0_1, $v1_1, $v2_1) {
    return $v2_1->slice;
}

#15
function closure13($v0_1, $v1_1) {
    return function ($v) use ($closure14, $v0_1, $v1_1) {     return closure14($v0_1, $v1_1, $v);
 };
}

#16
function closure12($unitVar, $v0_1) {
    return function ($v) use ($closure13, $v0_1) {     return closure13($v0_1, $v);
 };
}

#17
function closure16($v0_1, $v1_1) {
    return \String\split($v1_1, [ $v0_1 ], NULL, 0);
}

#18
function closure15($unitVar, $v0_1) {
    return function ($v) use ($closure16, $v0_1) {     return closure16($v0_1, $v);
 };
}

#19
function method0($unitVar) {
    return '';
}

#20
function closure18($v0_1, $v1_1) {
    $_v2 = NULL;
    $v20_1 = \Seq\ofArray($v0_1);
    $x = \String\split($v1_1, [ \String\join(method0(NULL), $v20_1) ], NULL, 0);
    $_v2 = $x;
    return \Option\value($_v2);
}

#21
function closure17($unitVar, $v0_1) {
    return function ($v) use ($closure18, $v0_1) {     return closure18($v0_1, $v);
 };
}

#22
function closure20($v0_1, $v1_1) {
    return $v1_1->indexOf === 0;
}

#23
function closure19($unitVar, $v0_1) {
    return function ($v) use ($closure20, $v0_1) {     return closure20($v0_1, $v);
 };
}

#24
function closure23($v0_1, $v1_1, $v2_1) {
    return $v2_1->\String\substring($v0_1, $v1_1);
}

#25
function closure22($v0_1, $v1_1) {
    return function ($v) use ($closure23, $v0_1, $v1_1) {     return closure23($v0_1, $v1_1, $v);
 };
}

#26
function closure21($unitVar, $v0_1) {
    return function ($v) use ($closure22, $v0_1) {     return closure22($v0_1, $v);
 };
}

#27
function closure24($unitVar, $v0_1) {
    return $v0_1->toLocaleLowerCase;
}

#28
function closure25($unitVar, $v0_1) {
    return $v0_1->toLocaleUpperCase;
}

#29
function closure26($unitVar, $v0_1) {
    return $v0_1->trim;
}

#30
function closure28($v0_1, $v1_1) {
    return \String\trimEnd($v1_1, $v0_1);
}

#31
function closure27($unitVar, $v0_1) {
    return function ($v) use ($closure28, $v0_1) {     return closure28($v0_1, $v);
 };
}

#32
function closure30($v0_1, $v1_1) {
    return \String\trimStart($v1_1, $v0_1);
}

#33
function closure29($unitVar, $v0_1) {
    return function ($v) use ($closure30, $v0_1) {     return closure30($v0_1, $v);
 };
}

#34
function closure32($v0_1, $v1_1) {
    if ($v1_1->length <= $v0_1) {
        return $v1_1;
    } else {
        $v4_1 = $v0_1 - 1;
        return $v1_1->slice . '...';
    }
}

#35
function closure31($unitVar, $v0_1) {
    return function ($v) use ($closure32, $v0_1) {     return closure32($v0_1, $v);
 };
}

#36
function closure34($v0_1, $v1_1) {
    $v2_1 = \BigInt\toInt64(\BigInt\fromInt32($v1_1->length));
    if (\BigInt\compare($v2_1, $v0_1) <= 0) {
        return $v1_1;
    } else {
        $v5_1 = \BigInt\toFloat64($v0_1) / 2;
        $v8_1 = \BigInt\toInt64(\BigInt\fromFloat64($Math->ceil));
        $v11_1 = \BigInt\toInt64(\BigInt\fromFloat64($Math->floor));
        $v12_1 = \BigInt\toInt64(\BigInt\op_Subtraction($v8_1, NULL));
        $v13_1 = $v1_1->slice;
        $v14_1 = \BigInt\toInt64(\BigInt\op_Subtraction($v2_1, $v11_1));
        $v15_1 = \BigInt\toInt64(\BigInt\op_Subtraction($v2_1, NULL));
        return \String\join('', \Seq\ofArray([ $v13_1, '...', $v1_1->slice ]));
    }
}

#37
function closure33($unitVar, $v0_1) {
    return function ($v) use ($closure34, $v0_1) {     return closure34($v0_1, $v);
 };
}

#38
function closure35($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \String\toText(\String\interpolate('%A%P()', [ $v0_1 ]));
    $_v1 = $x;
    return \Option\value($_v1);
}

#39
function method1($v0_1, $v1_1) {
    return $v1_1->l0 < $v0_1;
}

#40
function closure37($v0_1, $v1_1) {
    $v2_1 = $v1_1->length;
    $v4_1 = new Mut0(0, '');
    while (method1($v2_1, $v4_1)) {
        $v6_1 = $v4_1->l0;
        $v9_1 = $v4_1->l1 . \FSharpArray\item($v6_1, $v1_1) . $v0_1 . '';
        $v10_1 = $v6_1 + 1;
        $v4_1->l0 = $v10_1;
        $v4_1->l1 = $v9_1;
    }
    return $v4_1->l1;
}

#41
function closure36($unitVar, $v0_1) {
    return function ($v) use ($closure37, $v0_1) {     return closure37($v0_1, $v);
 };
}

#42
function closure39($v0_1, $v1_1) {
    return \String\join($v0_1, $v1_1);
}

#43
function closure38($unitVar, $v0_1) {
    return function ($v) use ($closure39, $v0_1) {     return closure39($v0_1, $v);
 };
}

#44
function closure41($v0_1, $v1_1) {
    return \String\join($v0_1, $v1_1);
}

#45
function closure40($unitVar, $v0_1) {
    return function ($v) use ($closure41, $v0_1) {     return closure41($v0_1, $v);
 };
}

#46
function method2($v0_1, $v1_1) {
    return $v1_1->l0 < $v0_1;
}

#47
function closure42($unitVar, $v0_1) {
    $v1_1 = $v0_1->length;
    $v2_1 = \FSharpArray\fill([  ], 0, $v1_1, '');
    $v3_1 = new Mut1(0);
    while (method2($v1_1, $v3_1)) {
        $v5_1 = $v3_1->l0;
        $v6_1 = $v0_1[$v5_1];
        $v2_1[$v5_1] = $v6_1;
        $v7_1 = $v5_1 + 1;
        $v3_1->l0 = $v7_1;
    }
    return $v2_1;
}

#48
$GLOBALS['v0'] = function ($v) use ($closure0) { return closure0(NULL, $v);
 };

#49
function contains($x) {
    return $GLOBALS['v0']($x);
}

#50
$GLOBALS['v1'] = function ($v) use ($closure2) { return closure2(NULL, $v);
 };

#51
function ends_with($x) {
    return $GLOBALS['v1']($x);
}

#52
$GLOBALS['v2'] = function ($v) use ($closure4) { return closure4(NULL, $v);
 };

#53
function pad_left($x) {
    return $GLOBALS['v2']($x);
}

#54
$GLOBALS['v3'] = function ($v) use ($closure7) { return closure7(NULL, $v);
 };

#55
function pad_right($x) {
    return $GLOBALS['v3']($x);
}

#56
$GLOBALS['v4'] = function ($v) use ($closure9) { return closure9(NULL, $v);
 };

#57
function replace($x) {
    return $GLOBALS['v4']($x);
}

#58
$GLOBALS['v5'] = function ($v) use ($closure12) { return closure12(NULL, $v);
 };

#59
function slice($x) {
    return $GLOBALS['v5']($x);
}

#60
$GLOBALS['v6'] = function ($v) use ($closure15) { return closure15(NULL, $v);
 };

#61
function split($x) {
    return $GLOBALS['v6']($x);
}

#62
$GLOBALS['v7'] = function ($v) use ($closure17) { return closure17(NULL, $v);
 };

#63
function split_string($x) {
    return $GLOBALS['v7']($x);
}

#64
$GLOBALS['v8'] = function ($v) use ($closure19) { return closure19(NULL, $v);
 };

#65
function starts_with($x) {
    return $GLOBALS['v8']($x);
}

#66
$GLOBALS['v9'] = function ($v) use ($closure21) { return closure21(NULL, $v);
 };

#67
function substring($x) {
    return $GLOBALS['v9']($x);
}

#68
$GLOBALS['v10'] = function ($v) use ($closure24) { return closure24(NULL, $v);
 };

#69
function to_lower($x) {
    return $GLOBALS['v10']($x);
}

#70
$GLOBALS['v11'] = function ($v) use ($closure25) { return closure25(NULL, $v);
 };

#71
function to_upper($x) {
    return $GLOBALS['v11']($x);
}

#72
$GLOBALS['v12'] = function ($v) use ($closure26) { return closure26(NULL, $v);
 };

#73
function trim($x) {
    return $GLOBALS['v12']($x);
}

#74
$GLOBALS['v13'] = function ($v) use ($closure27) { return closure27(NULL, $v);
 };

#75
function trim_end($x) {
    return $GLOBALS['v13']($x);
}

#76
$GLOBALS['v14'] = function ($v) use ($closure29) { return closure29(NULL, $v);
 };

#77
function trim_start($x) {
    return $GLOBALS['v14']($x);
}

#78
$GLOBALS['v15'] = function ($v) use ($closure31) { return closure31(NULL, $v);
 };

#79
function ellipsis($x) {
    return $GLOBALS['v15']($x);
}

#80
$GLOBALS['v16'] = function ($v) use ($closure33) { return closure33(NULL, $v);
 };

#81
function ellipsis_end($x) {
    return $GLOBALS['v16']($x);
}

#82
$GLOBALS['v17'] = function ($v) use ($closure35) { return closure35(NULL, $v);
 };

#83
function format_exception($x) {
    return $GLOBALS['v17']($x);
}

#84
$GLOBALS['v18'] = function ($v) use ($closure36) { return closure36(NULL, $v);
 };

#85
function concat_array_trailing($x) {
    return $GLOBALS['v18']($x);
}

#86
$GLOBALS['v19'] = function ($v) use ($closure38) { return closure38(NULL, $v);
 };

#87
function concat($x) {
    return $GLOBALS['v19']($x);
}

#88
$GLOBALS['v20'] = function ($v) use ($closure40) { return closure40(NULL, $v);
 };

#89
function join_0027($x) {
    return $GLOBALS['v20']($x);
}

#90
$GLOBALS['v21'] = function ($v) use ($closure42) { return closure42(NULL, $v);
 };

#91
function to_char_array($x) {
    return $GLOBALS['v21']($x);
}

#92

