<?php
namespace Trace;

require_once(__FABLE_LIBRARY__.'/BigInt.php');
require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/List.php');
require_once(__FABLE_LIBRARY__.'/Map.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/String.php');
require_once(__FABLE_LIBRARY__.'/Util.php');

use \FSharpUnion;
use \IComparable;

#0
$GLOBALS['State_trace_state'] = NULL;

#1
class Mut0 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return 'Int64';
    }
    function CompareTo($other) {
        $_cmp__1 = $this->l0 > $other->l0 ? 1 : ($this->l0 < $other->l0 ? -1 : 0);
        if ($_cmp__1 != 0) {
            return $_cmp__1;
        }        
        return 0;
    }
}

#2
class Mut1 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '??? \'Boolean\'';
    }
    function CompareTo($other) {
        $_cmp__2 = $this->l0->CompareTo($other->l0);
        if ($_cmp__2 != 0) {
            return $_cmp__2;
        }        
        return 0;
    }
}

#3
abstract class US0 implements FSharpUnion {
    static function allCases() {
        return [ '\\Trace\\US0_US0_0', '\\Trace\\US0_US0_1', '\\Trace\\US0_US0_2', '\\Trace\\US0_US0_3', '\\Trace\\US0_US0_4' ];
    }
}

#3
class US0_US0_0 extends US0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__3 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__3;
    }
}

#3
class US0_US0_1 extends US0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__4 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__4;
    }
}

#3
class US0_US0_2 extends US0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_2';
    }
    function get_Tag() {
        return 2;
    }
    function CompareTo($other) {
        $_cmp__5 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__5;
    }
}

#3
class US0_US0_3 extends US0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_3';
    }
    function get_Tag() {
        return 3;
    }
    function CompareTo($other) {
        $_cmp__6 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__6;
    }
}

#3
class US0_US0_4 extends US0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_4';
    }
    function get_Tag() {
        return 4;
    }
    function CompareTo($other) {
        $_cmp__7 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__7;
    }
}

#4
class Mut2 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '\\Trace\\US0';
    }
    function CompareTo($other) {
        $_cmp__8 = $this->l0->CompareTo($other->l0);
        if ($_cmp__8 != 0) {
            return $_cmp__8;
        }        
        return 0;
    }
}

#5
class Mut3 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '??? \'LambdaType (String, Unit)\'';
    }
    function CompareTo($other) {
        $_cmp__9 = $this->l0->CompareTo($other->l0);
        if ($_cmp__9 != 0) {
            return $_cmp__9;
        }        
        return 0;
    }
}

#6
abstract class US1 implements FSharpUnion {
    static function allCases() {
        return [ '\\Trace\\US1_US1_0', '\\Trace\\US1_US1_1' ];
    }
}

#6
class US1_US1_0 extends US1 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US1_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__10 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__10 != 0) {
            return $_cmp__10;
        }        
        $_cmp__11 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__11 != 0) {
            return $_cmp__11;
        }        
        return 0;
    }
}

#6
class US1_US1_1 extends US1 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US1_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__12 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__12;
    }
}

#7
abstract class US2 implements FSharpUnion {
    static function allCases() {
        return [ '\\Trace\\US2_US2_0', '\\Trace\\US2_US2_1' ];
    }
}

#7
class US2_US2_0 extends US2 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US2_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__13 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__13 != 0) {
            return $_cmp__13;
        }        
        $_cmp__14 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__14 != 0) {
            return $_cmp__14;
        }        
        return 0;
    }
}

#7
class US2_US2_1 extends US2 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US2_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__15 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__15;
    }
}

#8
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#9
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#10
function US0__get_IsUS0_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#11
function US0__get_IsUS0_3($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#12
function US0__get_IsUS0_4($this_, $unitArg) {
    if ($this_->get_Tag() == 4) {
        return true;
    } else {
        return false;
    }
}

#13
function US1__get_IsUS1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#14
function US1__get_IsUS1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#15
function US2__get_IsUS2_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#16
function US2__get_IsUS2_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#17
function closure1($unitVar, $v0_1) {
    return NULL;
}

#18
function method0($v0_1) {
    return $v0_1;
}

#19
function method1($v0_1) {
    return $v0_1;
}

#20
function closure0($unitVar, $unitVar_1) {
    $v0_1 = new Mut1(true);
    $v1_1 = new Mut0(NULL);
    $v3 = new Mut2(new US0_US0_0());
    $v5 = new Mut3(function ($v) use ($closure1) {     return closure1(NULL, $v);
 });
    $_v6 = NULL;
    $x = method1(NULL);
    $_v6 = $x;
    return [ $v1_1, $v0_1, $v3, \Option\value($_v6), $v5 ];
}

#21
function closure6($unitVar, $v0_1) {
    return new US2_US2_0($v0_1);
}

#22
function method3($unitVar) {
    return function ($v) use ($closure6) {     return closure6(NULL, $v);
 };
}

#23
function method4($unitVar) {
    return '';
}

#24
function closure5($v0_1, $v1_1, $v2, $unitVar) {
    if (is_null($GLOBALS['State_trace_state'])) {
        $GLOBALS['State_trace_state'] = closure0(NULL, NULL);
    } else {
    }
    $patternInput = \Option\value($GLOBALS['State_trace_state']);
    $_v9 = NULL;
    $x = \Util\defaultOf();
    $_v9 = $x;
    $v61 = \Option\value($_v9);
    $v62 = $patternInput[0]->l0;
    switch ($v0_1->get_Tag())
    {
        case 1:
            $v72 = 'Debug';
            break;
        case 2:
            $v72 = 'Info';
            break;
        case 0:
            $v72 = 'Verbose';
            break;
        case 3:
            $v72 = 'Warning';
            break;
        default:
            $v72 = 'Critical';
            break;
    }
    $v73 = $v72->toLocaleLowerCase;
    $_v74 = NULL;
    $x_1 = \Util\defaultOf();
    $_v74 = $x_1;
    return \String\trimEnd(\String\trimStart(NULL, [  ]), [ ' ', '/' ]);
}

#25
function method5($v0_1, $v1_1) {
    $v2 = function ($arg10_0040) use ($closure0) {     return closure0(NULL, NULL);
 };
    if (is_null($GLOBALS['State_trace_state'])) {
        $GLOBALS['State_trace_state'] = $v2(NULL);
    } else {
    }
    $patternInput = \Option\value($GLOBALS['State_trace_state']);
    $v3 = $patternInput[0];
    if (is_null($GLOBALS['State_trace_state'])) {
        $GLOBALS['State_trace_state'] = $v2(NULL);
    } else {
    }
    $patternInput_1 = \Option\value($GLOBALS['State_trace_state']);
    $v13 = $patternInput_1[2]->l0;
    if ($patternInput_1[1]->l0 === false ? false : \Map\find($v0_1, \Map\ofSeq(\FSharpList\cons([ new US0_US0_0(), 0 ], \FSharpList\cons([ new US0_US0_1(), 1 ], \FSharpList\cons([ new US0_US0_2(), 2 ], \FSharpList\cons([ new US0_US0_3(), 3 ], \FSharpList\cons([ new US0_US0_4(), 4 ], \FSharpList\_empty()))))), [ 'Compare' => function () {     return function ($x, $y) {     return \Util\compare($x, $y);
 };
 } ])) >= \Map\find($v13, \Map\ofSeq(\FSharpList\cons([ new US0_US0_0(), 0 ], \FSharpList\cons([ new US0_US0_1(), 1 ], \FSharpList\cons([ new US0_US0_2(), 2 ], \FSharpList\cons([ new US0_US0_3(), 3 ], \FSharpList\cons([ new US0_US0_4(), 4 ], \FSharpList\_empty()))))), [ 'Compare' => function () {     return function ($x_1, $y_1) {     return \Util\compare($x_1, $y_1);
 };
 } ]))) {
        $v21 = \BigInt\toInt64(\BigInt\op_Addition($v3->l0, NULL));
        $v3->l0 = $v21;
        $v22 = NULL;
        $_v23 = NULL;
        \Util\defaultOf();
        $_v23 = NULL;
        \Option\value($_v23);
        return $patternInput[4]->l0($v22);
    } else {
        return NULL;
    }
}

#26
function method2($v0_1, $v1_1, $v2) {
    return method5($v0_1, function ($arg10_0040) use ($closure5, $v0_1, $v1_1, $v2) {     return closure5($v0_1, $v1_1, $v2, NULL);
 });
}

#27
function closure4($v0_1, $v1_1, $v2) {
    return method2($v0_1, $v1_1, $v2);
}

#28
function closure3($v0_1, $v1_1) {
    return function ($v) use ($closure4, $v0_1, $v1_1) {     return closure4($v0_1, $v1_1, $v);
 };
}

#29
function closure2($unitVar, $v0_1) {
    return function ($v) use ($closure3, $v0_1) {     return closure3($v0_1, $v);
 };
}

#30
$GLOBALS['v0'] = function ($arg10_0040) use ($closure0) { return closure0(NULL, NULL);
 };

#31
if (is_null($GLOBALS['State_trace_state'])) {
    $GLOBALS['State_trace_state'] = $GLOBALS['v0'](NULL);
} else {
}

#32
$GLOBALS['v1'] = function ($v) use ($closure2) { return closure2(NULL, $v);
 };

#33
function trace($x) {
    return $GLOBALS['v1']($x);
}

#34

