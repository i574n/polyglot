<?php
namespace Networking;

require_once(__FABLE_LIBRARY__.'/BigInt.php');
require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
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
abstract class US1 implements FSharpUnion {
    static function allCases() {
        return [ '\\Networking\\US1_US1_0', '\\Networking\\US1_US1_1' ];
    }
}

#5
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
        $_cmp__9 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__9 != 0) {
            return $_cmp__9;
        }        
        $_cmp__10 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__10 != 0) {
            return $_cmp__10;
        }        
        return 0;
    }
}

#5
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
        $_cmp__11 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__11;
    }
}

#6
abstract class US2 implements FSharpUnion {
    static function allCases() {
        return [ '\\Networking\\US2_US2_0', '\\Networking\\US2_US2_1' ];
    }
}

#6
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
        $_cmp__12 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__12 != 0) {
            return $_cmp__12;
        }        
        $_cmp__13 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__13 != 0) {
            return $_cmp__13;
        }        
        return 0;
    }
}

#6
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
        $_cmp__14 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__14;
    }
}

#7
abstract class US3 implements FSharpUnion {
    static function allCases() {
        return [ '\\Networking\\US3_US3_0', '\\Networking\\US3_US3_1' ];
    }
}

#7
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
        $_cmp__15 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__15 != 0) {
            return $_cmp__15;
        }        
        $_cmp__16 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__16 != 0) {
            return $_cmp__16;
        }        
        return 0;
    }
}

#7
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
        $_cmp__17 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__17;
    }
}

#8
abstract class US4 implements FSharpUnion {
    static function allCases() {
        return [ '\\Networking\\US4_US4_0', '\\Networking\\US4_US4_1' ];
    }
}

#8
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
        $_cmp__18 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__18 != 0) {
            return $_cmp__18;
        }        
        $_cmp__19 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__19 != 0) {
            return $_cmp__19;
        }        
        return 0;
    }
}

#8
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
        $_cmp__20 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__20 != 0) {
            return $_cmp__20;
        }        
        $_cmp__21 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__21 != 0) {
            return $_cmp__21;
        }        
        return 0;
    }
}

#9
abstract class US5 implements FSharpUnion {
    static function allCases() {
        return [ '\\Networking\\US5_US5_0', '\\Networking\\US5_US5_1' ];
    }
}

#9
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
        $_cmp__22 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__22 != 0) {
            return $_cmp__22;
        }        
        $_cmp__23 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__23 != 0) {
            return $_cmp__23;
        }        
        return 0;
    }
}

#9
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
        $_cmp__24 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__24 != 0) {
            return $_cmp__24;
        }        
        $_cmp__25 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__25 != 0) {
            return $_cmp__25;
        }        
        return 0;
    }
}

#10
abstract class US6 implements FSharpUnion {
    static function allCases() {
        return [ '\\Networking\\US6_US6_0', '\\Networking\\US6_US6_1' ];
    }
}

#10
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
        $_cmp__26 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__26 != 0) {
            return $_cmp__26;
        }        
        $_cmp__27 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__27 != 0) {
            return $_cmp__27;
        }        
        return 0;
    }
}

#10
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
        $_cmp__28 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__28;
    }
}

#11
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#12
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#13
function US0__get_IsUS0_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#14
function US0__get_IsUS0_3($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#15
function US0__get_IsUS0_4($this_, $unitArg) {
    if ($this_->get_Tag() == 4) {
        return true;
    } else {
        return false;
    }
}

#16
function US1__get_IsUS1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#17
function US1__get_IsUS1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#18
function US2__get_IsUS2_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#19
function US2__get_IsUS2_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#20
function US3__get_IsUS3_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#21
function US3__get_IsUS3_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#22
function US4__get_IsUS4_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#23
function US4__get_IsUS4_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#24
function US5__get_IsUS5_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#25
function US5__get_IsUS5_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#26
function US6__get_IsUS6_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#27
function US6__get_IsUS6_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#28
function method0($v0_1) {
    return $v0_1;
}

#29
function method1($v0_1) {
    return $v0_1;
}

#30
function closure0($unitVar, $unitVar_1) {
    $v0_1 = new Mut1(true);
    $v1_1 = new Mut0(NULL);
    $v3_1 = new Mut2(new US0_US0_0());
    $v4_1 = new Mut1(false);
    $_v5 = NULL;
    $x = method1(NULL);
    $_v5 = $x;
    return [ $v1_1, $v4_1, $v0_1, $v3_1, \Option\value($_v5) ];
}

#31
function closure2($v0_1, $unitVar) {
    return NULL;
}

#32
function closure3($unitVar, $unitVar_1) {
    return '';
}

#33
function closure5($unitVar, $v0_1) {
    return new US2_US2_0($v0_1);
}

#34
function method3($unitVar) {
    return function ($v) use ($closure5) {     return closure5(NULL, $v);
 };
}

#35
function method4($unitVar) {
    return '';
}

#36
function closure4($v0_1, $v1_1, $v2_1, $unitVar) {
    if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
        $GLOBALS['State_trace_state'] = closure0(NULL, NULL);
    } else {
    }
    $patternInput = \Option\value($GLOBALS['State_trace_state']);
    $_v9 = NULL;
    $x = \Util\defaultOf();
    $_v9 = $x;
    $v60 = \Option\value($_v9);
    $v61 = $patternInput[0]->l0;
    switch ($v0_1->get_Tag())
    {
        case 1:
            $v71 = 'Debug';
            break;
        case 2:
            $v71 = 'Info';
            break;
        case 0:
            $v71 = 'Verbose';
            break;
        case 3:
            $v71 = 'Warning';
            break;
        default:
            $v71 = 'Critical';
            break;
    }
    $v72 = $v71->toLocaleLowerCase;
    $_v73 = NULL;
    $x_1 = \Util\defaultOf();
    $_v73 = $x_1;
    return \String\trimEnd(\String\trimStart(NULL, [  ]), [ ' ', '/' ]);
}

#37
function method2($v0_1, $v1_1, $v2_1) {
    $v3_1 = function ($arg10_0040) use ($closure0) {     return closure0(NULL, NULL);
 };
    if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
        $GLOBALS['State_trace_state'] = $v3_1(NULL);
    } else {
    }
    $v4_1 = \Option\value($GLOBALS['State_trace_state'])[0];
    if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
        $GLOBALS['State_trace_state'] = $v3_1(NULL);
    } else {
    }
    $patternInput_1 = \Option\value($GLOBALS['State_trace_state']);
    $v14 = $patternInput_1[3]->l0;
    if ($patternInput_1[2]->l0 ? \Util\compare($v0_1, $v14) >= 0 : false) {
        $v19 = \BigInt\toInt64(\BigInt\op_Addition($v4_1->l0, NULL));
        $v4_1->l0 = $v19;
        $v21 = NULL;
        $_v22 = NULL;
        \Util\defaultOf();
        $_v22 = NULL;
        \Option\value($_v22);
        return NULL;
    } else {
        return NULL;
    }
}

#38
function closure1($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#39
function closure8($unitVar, $v0_1) {
    return new US4_US4_0($v0_1);
}

#40
function closure9($unitVar, $v0_1) {
    return new US4_US4_1($v0_1);
}

#41
function closure10($unitVar, $unitVar_1) {
    return 'run_with_timeout_async';
}

#42
function closure11($v0_1, $unitVar) {
    return NULL;
}

#43
function closure12($v0_1, $unitVar) {
    return NULL;
}

#44
function closure7($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#45
function closure6($unitVar, $v0_1) {
    return function ($v) use ($closure7, $v0_1) {     return closure7($v0_1, $v);
 };
}

#46
function closure16($unitVar, $v0_1) {
    return new US6_US6_0($v0_1);
}

#47
function method6($unitVar) {
    return function ($v) use ($closure16) {     return closure16(NULL, $v);
 };
}

#48
function closure17($unitVar, $unitVar_1) {
    return 'wait_for_port_access';
}

#49
function closure18($v0_1, $v1_1, $unitVar) {
    return NULL;
}

#50
function method5($v0_1, $v1_1, $v2_1, $v3_1) {
    $_v4 = NULL;
    $x = \Util\defaultOf();
    $_v4 = $x;
    return \Option\value($_v4);
}

#51
function closure15($v0_1, $v1_1, $v2_1) {
    return method5($v0_1, $v1_1, $v2_1, NULL);
}

#52
function closure14($v0_1, $v1_1) {
    return function ($v) use ($closure15, $v0_1, $v1_1) {     return closure15($v0_1, $v1_1, $v);
 };
}

#53
function closure13($unitVar, $v0_1) {
    return function ($v) use ($closure14, $v0_1) {     return closure14($v0_1, $v);
 };
}

#54
function method7($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#55
function closure20($v0_1, $v1_1) {
    return method7($v0_1, $v1_1);
}

#56
function closure19($unitVar, $v0_1) {
    return function ($v) use ($closure20, $v0_1) {     return closure20($v0_1, $v);
 };
}

#57
$GLOBALS['v0'] = function ($arg10_0040) use ($closure0) { return closure0(NULL, NULL);
 };

#58
if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
    $GLOBALS['State_trace_state'] = $GLOBALS['v0'](NULL);
} else {
}

#59
$GLOBALS['v1'] = function ($v) use ($closure1) { return closure1(NULL, $v);
 };

#60
function test_port_open($x) {
    return $GLOBALS['v1']($x);
}

#61
$GLOBALS['v2'] = function ($v) use ($closure6) { return closure6(NULL, $v);
 };

#62
function test_port_open_timeout($x) {
    return $GLOBALS['v2']($x);
}

#63
$GLOBALS['v3'] = function ($v) use ($closure13) { return closure13(NULL, $v);
 };

#64
function wait_for_port_access($x) {
    return $GLOBALS['v3']($x);
}

#65
$GLOBALS['v4'] = function ($v) use ($closure19) { return closure19(NULL, $v);
 };

#66
function get_available_port($x) {
    return $GLOBALS['v4']($x);
}

#67

