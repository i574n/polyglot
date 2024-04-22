<?php
namespace Networking;

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
        return [ '\\Networking\\US0_US0_0', '\\Networking\\US0_US0_1', '\\Networking\\US0_US0_2', '\\Networking\\US0_US0_3', '\\Networking\\US0_US0_4' ];
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
        return '\\Networking\\US0';
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
        return [ '\\Networking\\US1_US1_0', '\\Networking\\US1_US1_1' ];
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
        return [ '\\Networking\\US2_US2_0', '\\Networking\\US2_US2_1' ];
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
abstract class US3 implements FSharpUnion {
    static function allCases() {
        return [ '\\Networking\\US3_US3_0', '\\Networking\\US3_US3_1' ];
    }
}

#8
class US3_US3_0 extends US3 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US3_0';
    }
    static function get_f0_0_Type() {
        return '??? \'Boolean\'';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__16 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__16 != 0) {
            return $_cmp__16;
        }        
        $_cmp__17 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__17 != 0) {
            return $_cmp__17;
        }        
        return 0;
    }
}

#8
class US3_US3_1 extends US3 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US3_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__18 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__18;
    }
}

#9
abstract class US4 implements FSharpUnion {
    static function allCases() {
        return [ '\\Networking\\US4_US4_0', '\\Networking\\US4_US4_1' ];
    }
}

#9
class US4_US4_0 extends US4 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US4_0';
    }
    static function get_f0_0_Type() {
        return '??? \'Boolean\'';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__19 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__19 != 0) {
            return $_cmp__19;
        }        
        $_cmp__20 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__20 != 0) {
            return $_cmp__20;
        }        
        return 0;
    }
}

#9
class US4_US4_1 extends US4 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US4_1';
    }
    static function get_f1_0_Type() {
        return '\\Networking\\System_Exception';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__21 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__21 != 0) {
            return $_cmp__21;
        }        
        $_cmp__22 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__22 != 0) {
            return $_cmp__22;
        }        
        return 0;
    }
}

#10
abstract class US5 implements FSharpUnion {
    static function allCases() {
        return [ '\\Networking\\US5_US5_0', '\\Networking\\US5_US5_1' ];
    }
}

#10
class US5_US5_0 extends US5 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US5_0';
    }
    static function get_f0_0_Type() {
        return '??? \'Boolean\'';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__23 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__23 != 0) {
            return $_cmp__23;
        }        
        $_cmp__24 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__24 != 0) {
            return $_cmp__24;
        }        
        return 0;
    }
}

#10
class US5_US5_1 extends US5 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US5_1';
    }
    static function get_f1_0_Type() {
        return '\\Networking\\System_Exception';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__25 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__25 != 0) {
            return $_cmp__25;
        }        
        $_cmp__26 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__26 != 0) {
            return $_cmp__26;
        }        
        return 0;
    }
}

#11
abstract class US6 implements FSharpUnion {
    static function allCases() {
        return [ '\\Networking\\US6_US6_0', '\\Networking\\US6_US6_1' ];
    }
}

#11
class US6_US6_0 extends US6 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US6_0';
    }
    static function get_f0_0_Type() {
        return 'Int32';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__27 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__27 != 0) {
            return $_cmp__27;
        }        
        $_cmp__28 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__28 != 0) {
            return $_cmp__28;
        }        
        return 0;
    }
}

#11
class US6_US6_1 extends US6 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US6_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__29 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__29;
    }
}

#12
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#13
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#14
function US0__get_IsUS0_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#15
function US0__get_IsUS0_3($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#16
function US0__get_IsUS0_4($this_, $unitArg) {
    if ($this_->get_Tag() == 4) {
        return true;
    } else {
        return false;
    }
}

#17
function US1__get_IsUS1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#18
function US1__get_IsUS1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#19
function US2__get_IsUS2_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#20
function US2__get_IsUS2_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#21
function US3__get_IsUS3_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#22
function US3__get_IsUS3_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#23
function US4__get_IsUS4_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#24
function US4__get_IsUS4_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#25
function US5__get_IsUS5_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#26
function US5__get_IsUS5_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#27
function US6__get_IsUS6_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#28
function US6__get_IsUS6_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#29
function closure1($unitVar, $v0_1) {
    return NULL;
}

#30
function method0($v0_1) {
    return $v0_1;
}

#31
function method1($v0_1) {
    return $v0_1;
}

#32
function closure0($unitVar, $unitVar_1) {
    $v0_1 = new Mut1(true);
    $v1_1 = new Mut0(NULL);
    $v3_1 = new Mut2(new US0_US0_0());
    $v5 = new Mut3(function ($v) use ($closure1) {     return closure1(NULL, $v);
 });
    $_v6 = NULL;
    $x = method1(NULL);
    $_v6 = $x;
    return [ $v1_1, $v0_1, $v3_1, \Option\value($_v6), $v5 ];
}

#33
function closure3($v0_1, $unitVar) {
    return NULL;
}

#34
function closure4($unitVar, $unitVar_1) {
    return '';
}

#35
function closure6($unitVar, $v0_1) {
    return new US2_US2_0($v0_1);
}

#36
function method3($unitVar) {
    return function ($v) use ($closure6) {     return closure6(NULL, $v);
 };
}

#37
function method4($unitVar) {
    return '';
}

#38
function closure5($v0_1, $v1_1, $v2_1, $unitVar) {
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

#39
function method5($v0_1, $v1_1) {
    $v2_1 = function ($arg10_0040) use ($closure0) {     return closure0(NULL, NULL);
 };
    if (is_null($GLOBALS['State_trace_state'])) {
        $GLOBALS['State_trace_state'] = $v2_1(NULL);
    } else {
    }
    $patternInput = \Option\value($GLOBALS['State_trace_state']);
    $v3_1 = $patternInput[0];
    if (is_null($GLOBALS['State_trace_state'])) {
        $GLOBALS['State_trace_state'] = $v2_1(NULL);
    } else {
    }
    $patternInput_1 = \Option\value($GLOBALS['State_trace_state']);
    $v13 = $patternInput_1[2]->l0;
    if ($patternInput_1[1]->l0 === false ? false : \Map\find($v0_1, \Map\ofSeq(\FSharpList\cons([ new US0_US0_0(), 0 ], \FSharpList\cons([ new US0_US0_1(), 1 ], \FSharpList\cons([ new US0_US0_2(), 2 ], \FSharpList\cons([ new US0_US0_3(), 3 ], \FSharpList\cons([ new US0_US0_4(), 4 ], \FSharpList\_empty()))))), [ 'Compare' => function () {     return function ($x, $y) {     return \Util\compare($x, $y);
 };
 } ])) >= \Map\find($v13, \Map\ofSeq(\FSharpList\cons([ new US0_US0_0(), 0 ], \FSharpList\cons([ new US0_US0_1(), 1 ], \FSharpList\cons([ new US0_US0_2(), 2 ], \FSharpList\cons([ new US0_US0_3(), 3 ], \FSharpList\cons([ new US0_US0_4(), 4 ], \FSharpList\_empty()))))), [ 'Compare' => function () {     return function ($x_1, $y_1) {     return \Util\compare($x_1, $y_1);
 };
 } ]))) {
        $v21 = \BigInt\toInt64(\BigInt\op_Addition($v3_1->l0, NULL));
        $v3_1->l0 = $v21;
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

#40
function method2($v0_1, $v1_1, $v2_1) {
    return method5($v0_1, function ($arg10_0040) use ($closure5, $v0_1, $v1_1, $v2_1) {     return closure5($v0_1, $v1_1, $v2_1, NULL);
 });
}

#41
function closure2($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#42
function closure9($unitVar, $v0_1) {
    return new US4_US4_0($v0_1);
}

#43
function closure10($unitVar, $v0_1) {
    return new US4_US4_1($v0_1);
}

#44
function closure11($unitVar, $unitVar_1) {
    return 'run_with_timeout_async';
}

#45
function closure12($v0_1, $unitVar) {
    return NULL;
}

#46
function closure13($v0_1, $unitVar) {
    return NULL;
}

#47
function closure8($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#48
function closure7($unitVar, $v0_1) {
    return function ($v) use ($closure8, $v0_1) {     return closure8($v0_1, $v);
 };
}

#49
function closure17($unitVar, $v0_1) {
    return new US6_US6_0($v0_1);
}

#50
function method7($unitVar) {
    return function ($v) use ($closure17) {     return closure17(NULL, $v);
 };
}

#51
function closure18($unitVar, $unitVar_1) {
    return 'wait_for_port_access';
}

#52
function closure19($v0_1, $v1_1, $unitVar) {
    return NULL;
}

#53
function method6($v0_1, $v1_1, $v2_1, $v3_1) {
    $_v4 = NULL;
    $x = \Util\defaultOf();
    $_v4 = $x;
    return \Option\value($_v4);
}

#54
function closure16($v0_1, $v1_1, $v2_1) {
    return method6($v0_1, $v1_1, $v2_1, NULL);
}

#55
function closure15($v0_1, $v1_1) {
    return function ($v) use ($closure16, $v0_1, $v1_1) {     return closure16($v0_1, $v1_1, $v);
 };
}

#56
function closure14($unitVar, $v0_1) {
    return function ($v) use ($closure15, $v0_1) {     return closure15($v0_1, $v);
 };
}

#57
function method8($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#58
function closure21($v0_1, $v1_1) {
    return method8($v0_1, $v1_1);
}

#59
function closure20($unitVar, $v0_1) {
    return function ($v) use ($closure21, $v0_1) {     return closure21($v0_1, $v);
 };
}

#60
$GLOBALS['v0'] = function ($arg10_0040) use ($closure0) { return closure0(NULL, NULL);
 };

#61
if (is_null($GLOBALS['State_trace_state'])) {
    $GLOBALS['State_trace_state'] = $GLOBALS['v0'](NULL);
} else {
}

#62
$GLOBALS['v1'] = function ($v) use ($closure2) { return closure2(NULL, $v);
 };

#63
function test_port_open($x) {
    return $GLOBALS['v1']($x);
}

#64
$GLOBALS['v2'] = function ($v) use ($closure7) { return closure7(NULL, $v);
 };

#65
function test_port_open_timeout($x) {
    return $GLOBALS['v2']($x);
}

#66
$GLOBALS['v3'] = function ($v) use ($closure14) { return closure14(NULL, $v);
 };

#67
function wait_for_port_access($x) {
    return $GLOBALS['v3']($x);
}

#68
$GLOBALS['v4'] = function ($v) use ($closure20) { return closure20(NULL, $v);
 };

#69
function get_available_port($x) {
    return $GLOBALS['v4']($x);
}

#70

