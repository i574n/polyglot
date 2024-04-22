<?php
namespace File_system;

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
class IFsExistsSync {
}

#2
class IPathJoin {
}

#3
class IPathDirname {
}

#4
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

#5
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

#6
abstract class US0 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US0_US0_0', '\\File_system\\US0_US0_1', '\\File_system\\US0_US0_2', '\\File_system\\US0_US0_3', '\\File_system\\US0_US0_4' ];
    }
}

#6
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

#6
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

#6
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

#6
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

#6
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

#7
class Mut2 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '\\File_system\\US0';
    }
    function CompareTo($other) {
        $_cmp__8 = $this->l0->CompareTo($other->l0);
        if ($_cmp__8 != 0) {
            return $_cmp__8;
        }        
        return 0;
    }
}

#8
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

#9
abstract class US1 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US1_US1_0', '\\File_system\\US1_US1_1' ];
    }
}

#9
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

#9
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

#10
abstract class US2 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US2_US2_0', '\\File_system\\US2_US2_1' ];
    }
}

#10
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

#10
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

#11
abstract class US4 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US4_US4_0', '\\File_system\\US4_US4_1', '\\File_system\\US4_US4_2' ];
    }
}

#11
class US4_US4_0 extends US4 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US4_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__16 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__16;
    }
}

#11
class US4_US4_1 extends US4 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US4_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__17 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__17;
    }
}

#11
class US4_US4_2 extends US4 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US4_2';
    }
    function get_Tag() {
        return 2;
    }
    function CompareTo($other) {
        $_cmp__18 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__18;
    }
}

#12
abstract class US5 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US5_US5_0', '\\File_system\\US5_US5_1', '\\File_system\\US5_US5_2', '\\File_system\\US5_US5_3', '\\File_system\\US5_US5_4' ];
    }
}

#12
class US5_US5_0 extends US5 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US5_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__19 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__19;
    }
}

#12
class US5_US5_1 extends US5 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US5_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__20 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__20;
    }
}

#12
class US5_US5_2 extends US5 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US5_2';
    }
    function get_Tag() {
        return 2;
    }
    function CompareTo($other) {
        $_cmp__21 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__21;
    }
}

#12
class US5_US5_3 extends US5 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US5_3';
    }
    function get_Tag() {
        return 3;
    }
    function CompareTo($other) {
        $_cmp__22 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__22;
    }
}

#12
class US5_US5_4 extends US5 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US5_4';
    }
    function get_Tag() {
        return 4;
    }
    function CompareTo($other) {
        $_cmp__23 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__23;
    }
}

#13
abstract class US3 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US3_US3_0', '\\File_system\\US3_US3_1' ];
    }
}

#13
class US3_US3_0 extends US3 implements IComparable {
    public $f0_0;
    public $f0_1;
    function __construct($f0_0, $f0_1) {
        $this->f0_0 = $f0_0;
        $this->f0_1 = $f0_1;
    }
    static function get_FSharpCase() {
        return 'US3_0';
    }
    static function get_f0_0_Type() {
        return '\\File_system\\US4';
    }
    static function get_f0_1_Type() {
        return '\\File_system\\US5';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__24 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__24 != 0) {
            return $_cmp__24;
        }        
        $_cmp__25 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__25 != 0) {
            return $_cmp__25;
        }        
        $_cmp__26 = $this->f0_1->CompareTo($other->f0_1);
        if ($_cmp__26 != 0) {
            return $_cmp__26;
        }        
        return 0;
    }
}

#13
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
        $_cmp__27 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__27;
    }
}

#14
abstract class US6 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US6_US6_0', '\\File_system\\US6_US6_1' ];
    }
}

#14
class US6_US6_0 extends US6 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US6_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__28 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__28 != 0) {
            return $_cmp__28;
        }        
        $_cmp__29 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__29 != 0) {
            return $_cmp__29;
        }        
        return 0;
    }
}

#14
class US6_US6_1 extends US6 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US6_1';
    }
    static function get_f1_0_Type() {
        return '\\File_system\\System_Exception';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__30 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__30 != 0) {
            return $_cmp__30;
        }        
        $_cmp__31 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__31 != 0) {
            return $_cmp__31;
        }        
        return 0;
    }
}

#15
abstract class US7 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US7_US7_0', '\\File_system\\US7_US7_1' ];
    }
}

#15
class US7_US7_0 extends US7 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US7_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__32 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__32 != 0) {
            return $_cmp__32;
        }        
        $_cmp__33 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__33 != 0) {
            return $_cmp__33;
        }        
        return 0;
    }
}

#15
class US7_US7_1 extends US7 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US7_1';
    }
    static function get_f1_0_Type() {
        return '\\File_system\\System_Exception';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__34 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__34 != 0) {
            return $_cmp__34;
        }        
        $_cmp__35 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__35 != 0) {
            return $_cmp__35;
        }        
        return 0;
    }
}

#16
abstract class US8 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US8_US8_0', '\\File_system\\US8_US8_1' ];
    }
}

#16
class US8_US8_0 extends US8 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US8_0';
    }
    static function get_f0_0_Type() {
        return 'String';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__36 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__36 != 0) {
            return $_cmp__36;
        }        
        $_cmp__37 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__37 != 0) {
            return $_cmp__37;
        }        
        return 0;
    }
}

#16
class US8_US8_1 extends US8 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US8_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__38 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__38;
    }
}

#17
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#18
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#19
function US0__get_IsUS0_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#20
function US0__get_IsUS0_3($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#21
function US0__get_IsUS0_4($this_, $unitArg) {
    if ($this_->get_Tag() == 4) {
        return true;
    } else {
        return false;
    }
}

#22
function US1__get_IsUS1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#23
function US1__get_IsUS1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#24
function US2__get_IsUS2_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#25
function US2__get_IsUS2_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#26
function US4__get_IsUS4_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#27
function US4__get_IsUS4_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#28
function US4__get_IsUS4_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#29
function US5__get_IsUS5_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#30
function US5__get_IsUS5_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#31
function US5__get_IsUS5_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#32
function US5__get_IsUS5_3($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#33
function US5__get_IsUS5_4($this_, $unitArg) {
    if ($this_->get_Tag() == 4) {
        return true;
    } else {
        return false;
    }
}

#34
function US3__get_IsUS3_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#35
function US3__get_IsUS3_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#36
function US6__get_IsUS6_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#37
function US6__get_IsUS6_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#38
function US7__get_IsUS7_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#39
function US7__get_IsUS7_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#40
function US8__get_IsUS8_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#41
function US8__get_IsUS8_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#42
function closure1($unitVar, $v0_1) {
    return NULL;
}

#43
function method0($v0_1) {
    return $v0_1;
}

#44
function method1($v0_1) {
    return $v0_1;
}

#45
function closure0($unitVar, $unitVar_1) {
    $v0_1 = new Mut1(true);
    $v1_1 = new Mut0(NULL);
    $v3_1 = new Mut2(new US0_US0_0());
    $v5_1 = new Mut3(function ($v) use ($closure1) {     return closure1(NULL, $v);
 });
    $_v6 = NULL;
    $x = method1(NULL);
    $_v6 = $x;
    return [ $v1_1, $v0_1, $v3_1, \Option\value($_v6), $v5_1 ];
}

#46
function closure3($unitVar, $unitVar_1) {
    return 'file_system.delete_directory_async';
}

#47
function closure5($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#48
function closure6($unitVar, $unitVar_1) {
    return '';
}

#49
function closure4($v0_1, $v1_1, $unitVar) {
    return NULL;
}

#50
function closure8($unitVar, $v0_1) {
    return new US2_US2_0($v0_1);
}

#51
function method4($unitVar) {
    return function ($v) use ($closure8) {     return closure8(NULL, $v);
 };
}

#52
function method5($unitVar) {
    return '';
}

#53
function closure7($v0_1, $v1_1, $v2_1, $unitVar) {
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

#54
function method6($v0_1, $v1_1) {
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
    $v13_1 = $patternInput_1[2]->l0;
    if ($patternInput_1[1]->l0 === false ? false : \Map\find($v0_1, \Map\ofSeq(\FSharpList\cons([ new US0_US0_0(), 0 ], \FSharpList\cons([ new US0_US0_1(), 1 ], \FSharpList\cons([ new US0_US0_2(), 2 ], \FSharpList\cons([ new US0_US0_3(), 3 ], \FSharpList\cons([ new US0_US0_4(), 4 ], \FSharpList\_empty()))))), [ 'Compare' => function () {     return function ($x, $y) {     return \Util\compare($x, $y);
 };
 } ])) >= \Map\find($v13_1, \Map\ofSeq(\FSharpList\cons([ new US0_US0_0(), 0 ], \FSharpList\cons([ new US0_US0_1(), 1 ], \FSharpList\cons([ new US0_US0_2(), 2 ], \FSharpList\cons([ new US0_US0_3(), 3 ], \FSharpList\cons([ new US0_US0_4(), 4 ], \FSharpList\_empty()))))), [ 'Compare' => function () {     return function ($x_1, $y_1) {     return \Util\compare($x_1, $y_1);
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

#55
function method3($v0_1, $v1_1, $v2_1) {
    return method6($v0_1, function ($arg10_0040) use ($closure7, $v0_1, $v1_1, $v2_1) {     return closure7($v0_1, $v1_1, $v2_1, NULL);
 });
}

#56
function method2($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#57
function closure2($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#58
function closure11($unitVar, $unitVar_1) {
    return 'file_system.wait_for_file_access';
}

#59
function closure12($v0_1, $v1_1, $v2_1, $unitVar) {
    return NULL;
}

#60
function method7($v0_1, $v1_1, $v2_1, $v3_1) {
    $_v4 = NULL;
    $x = \Util\defaultOf();
    $_v4 = $x;
    return \Option\value($_v4);
}

#61
function closure10($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#62
function closure9($unitVar, $v0_1) {
    return function ($v) use ($closure10, $v0_1) {     return closure10($v0_1, $v);
 };
}

#63
function method8($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#64
function closure13($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#65
function closure14($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#66
function method9($v0_1) {
    return $v0_1;
}

#67
function closure16($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#68
function closure15($unitVar, $v0_1) {
    return function ($v) use ($closure16, $v0_1) {     return closure16($v0_1, $v);
 };
}

#69
function closure18($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#70
function closure17($unitVar, $v0_1) {
    return function ($v) use ($closure18, $v0_1) {     return closure18($v0_1, $v);
 };
}

#71
function closure20($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#72
function closure19($unitVar, $v0_1) {
    return function ($v) use ($closure20, $v0_1) {     return closure20($v0_1, $v);
 };
}

#73
function closure22($unitVar, $unitVar_1) {
    return 'delete_file_async';
}

#74
function closure23($v0_1, $v1_1, $unitVar) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    $v10_1 = \Option\value($_v2);
    return NULL;
}

#75
function method10($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#76
function closure21($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#77
function closure26($unitVar, $unitVar_1) {
    return 'move_file_async';
}

#78
function closure27($v0_1, $v1_1, $v2_1, $unitVar) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    $v11_1 = \Option\value($_v3);
    $v12_1 = function ($v) use ($closure5) {     return closure5(NULL, $v);
 };
    return NULL;
}

#79
function method11($v0_1, $v1_1, $v2_1) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    return \Option\value($_v3);
}

#80
function closure25($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#81
function closure24($unitVar, $v0_1) {
    return function ($v) use ($closure25, $v0_1) {     return closure25($v0_1, $v);
 };
}

#82
function closure29($unitVar, $v0_1) {
    return new US6_US6_0($v0_1);
}

#83
function closure30($unitVar, $v0_1) {
    return new US6_US6_1($v0_1);
}

#84
function closure31($unitVar, $unitVar_1) {
    return 'run_with_timeout_async';
}

#85
function closure32($unitVar, $unitVar_1) {
    return NULL;
}

#86
function closure33($v0_1, $unitVar) {
    return NULL;
}

#87
function closure34($unitVar, $unitVar_1) {
    return 'read_all_text_retry_async';
}

#88
function method13($v0_1, $v1_1) {
    return NULL;
}

#89
function closure35($v0_1, $v1_1, $unitVar) {
    return method13($v0_1, $v1_1);
}

#90
function method12($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#91
function closure28($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#92
function closure37($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $x = \Util\defaultOf();
    $_v0 = $x;
    return \Option\value($_v0);
}

#93
function method14($v0_1) {
    return $v0_1;
}

#94
function method15($v0_1) {
    return $v0_1;
}

#95
function closure36($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $x = \Util\defaultOf();
    $_v0 = $x;
    return \Option\value($_v0);
}

#96
function closure39($unitVar, $unitVar_1) {
    return 'file_system.create_temp_directory';
}

#97
function closure40($v0_1, $v1_1, $unitVar) {
    return NULL;
}

#98
function closure41($v0_1, $unitVar) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    $v10_1 = \Option\value($_v1);
    $_v11 = NULL;
    $x_1 = \Util\defaultOf();
    $_v11 = $x_1;
    $v20 = \Option\value($_v11);
    $_v21 = NULL;
    \Util\defaultOf();
    $_v21 = NULL;
    \Option\value($_v21);
    return NULL;
}

#99
function closure38($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $patternInput = [ \Util\defaultOf(), \Util\defaultOf() ];
    $_v0 = [ $patternInput[0], $patternInput[1] ];
    $patternInput_1 = \Option\value($_v0);
    return [ $patternInput_1[0], $patternInput_1[1] ];
}

#100
function closure42($unitVar, $unitVar_1) {
    return 'C:\\home\\git\\polyglot\\lib\\spiral';
}

#101
function closure46($unitVar, $v0_1) {
    $_v1 = NULL;
    $_v1 = false;
    return \Option\value($_v1);
}

#102
function closure47($unitVar, $v0_1) {
    $_v1 = NULL;
    $_v1 = false;
    return \Option\value($_v1);
}

#103
function closure48($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = $US8();
    $_v1 = $x;
    $v43 = \Option\value($_v1);
    switch ($v43->get_Tag())
    {
        case 0:
            return $v43->f0_0;
        default:
            return NULL;
    }
}

#104
function method17($unitVar) {
    return function ($v) use ($closure48) {     return closure48(NULL, $v);
 };
}

#105
function closure49($unitVar, $v0_1) {
    return new US8_US8_0($v0_1);
}

#106
function method18($unitVar) {
    return function ($v) use ($closure49) {     return closure49(NULL, $v);
 };
}

#107
function method19($v0_1, $v1_1, $v2_1, $v3_1) {
    $_v4 = NULL;
    $x = \Util\defaultOf();
    $_v4 = $x;
    if ($v1_1 ? function ($v) use ($closure46) {     return closure46(NULL, $v);
 } : function ($v_1) use ($closure47) {     return closure47(NULL, $v_1);
 }(\Option\value($_v4))) {
        return $v3_1;
    } else {
        $v40 = method17(NULL)($v3_1);
        $v43 = \Option\defaultArg(\Option\map(method18(NULL), $v40), new US8_US8_1());
        switch ($v43->get_Tag())
        {
            case 0:
                return method19($v0_1, $v1_1, $v2_1, $v43->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#108
function method16($v0_1, $v1_1, $v2_1) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    if ($v1_1 ? function ($v) use ($closure46) {     return closure46(NULL, $v);
 } : function ($v_1) use ($closure47) {     return closure47(NULL, $v_1);
 }(\Option\value($_v3))) {
        return $v2_1;
    } else {
        $v39 = method17(NULL)($v2_1);
        $v42 = \Option\defaultArg(\Option\map(method18(NULL), $v39), new US8_US8_1());
        switch ($v42->get_Tag())
        {
            case 0:
                return method19($v0_1, $v1_1, $v2_1, $v42->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#109
function closure45($v0_1, $v1_1, $v2_1) {
    return method16($v0_1, $v1_1, $v2_1);
}

#110
function closure44($v0_1, $v1_1) {
    return function ($v) use ($closure45, $v0_1, $v1_1) {     return closure45($v0_1, $v1_1, $v);
 };
}

#111
function closure43($unitVar, $v0_1) {
    return function ($v) use ($closure44, $v0_1) {     return closure44($v0_1, $v);
 };
}

#112
function closure50($unitVar, $v0_1) {
    $_v1 = NULL;
    $_v1 = false;
    if (\Option\value($_v1) === false) {
        return $v0_1;
    } else {
        return NULL->\String\replace('\\', '/');
    }
}

#113
function closure51($unitVar, $v0_1) {
    return NULL;
}

#114
function method20($unitVar) {
    return 'polyglot';
}

#115
function method21($unitVar) {
    return '.paket';
}

#116
function method22($unitVar) {
    return 'polyglot';
}

#117
function method23($unitVar) {
    return '.paket';
}

#118
function method25($v0_1, $v1_1, $v2_1) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    $v33 = \Option\value($_v3);
    $_v34 = NULL;
    $_v34 = false;
    if (\Option\value($_v34)) {
        return $v2_1;
    } else {
        $v59 = method17(NULL)($v2_1);
        $v62 = \Option\defaultArg(\Option\map(method18(NULL), $v59), new US8_US8_1());
        switch ($v62->get_Tag())
        {
            case 0:
                return method25($v0_1, $v1_1, $v62->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#119
function method24($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    $v32 = \Option\value($_v2);
    $_v33 = NULL;
    $_v33 = false;
    if (\Option\value($_v33)) {
        return $v1_1;
    } else {
        $v58 = method17(NULL)($v1_1);
        $v61 = \Option\defaultArg(\Option\map(method18(NULL), $v58), new US8_US8_1());
        switch ($v61->get_Tag())
        {
            case 0:
                return method25($v0_1, $v1_1, $v61->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#120
function method26($unitVar) {
    return 'polyglot';
}

#121
function closure52($unitVar, $unitVar_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    $v34 = method24(\Option\value($_v1), 'C:\\home\\git\\polyglot\\lib\\spiral');
    $_v35 = NULL;
    $x_1 = \Util\defaultOf();
    $_v35 = $x_1;
    return \Option\value($_v35);
}

#122
function method28($unitVar) {
    return 'target/polyglot/trace';
}

#123
function method29($unitVar) {
    return 'target/polyglot/trace';
}

#124
function method27($v0_1) {
    $_v1 = NULL;
    \Util\defaultOf();
    $_v1 = NULL;
    \Option\value($_v1);
    return NULL;
}

#125
function closure54($unitVar, $v0_1) {
    return method27($v0_1);
}

#126
function closure53($unitVar, $v0_1) {
    if (is_null($GLOBALS['State_trace_state'])) {
        $GLOBALS['State_trace_state'] = closure0(NULL, NULL);
    } else {
    }
    $patternInput = \Option\value($GLOBALS['State_trace_state']);
    if ($v0_1) {
        $v9_1 = function ($v) use ($closure54) {         return closure54(NULL, $v);
 };
    } else {
        $v9_1 = function ($v_1) use ($closure1) {         return closure1(NULL, $v_1);
 };
    }
    $patternInput[4]->l0 = $v9_1;
    return NULL;
}

#127
function closure56($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#128
function closure55($unitVar, $v0_1) {
    return function ($v) use ($closure56, $v0_1) {     return closure56($v0_1, $v);
 };
}

#129
$GLOBALS['v0'] = function ($arg10_0040) use ($closure0) { return closure0(NULL, NULL);
 };

#130
if (is_null($GLOBALS['State_trace_state'])) {
    $GLOBALS['State_trace_state'] = $GLOBALS['v0'](NULL);
} else {
}

#131
$GLOBALS['v1'] = function ($v) use ($closure2) { return closure2(NULL, $v);
 };

#132
function delete_directory_async($x) {
    return $GLOBALS['v1']($x);
}

#133
$GLOBALS['v2'] = function ($v) use ($closure9) { return closure9(NULL, $v);
 };

#134
function wait_for_file_access($x) {
    return $GLOBALS['v2']($x);
}

#135
$GLOBALS['v3'] = function ($v) use ($closure13) { return closure13(NULL, $v);
 };

#136
function wait_for_file_access_read($x) {
    return $GLOBALS['v3']($x);
}

#137
$GLOBALS['v4'] = function ($v) use ($closure14) { return closure14(NULL, $v);
 };

#138
function read_all_text_async($x) {
    return $GLOBALS['v4']($x);
}

#139
$GLOBALS['v5'] = function ($v) use ($closure15) { return closure15(NULL, $v);
 };

#140
function file_exists_content($x) {
    return $GLOBALS['v5']($x);
}

#141
$GLOBALS['v6'] = function ($v) use ($closure17) { return closure17(NULL, $v);
 };

#142
function write_all_text_async($x) {
    return $GLOBALS['v6']($x);
}

#143
$GLOBALS['v7'] = function ($v) use ($closure19) { return closure19(NULL, $v);
 };

#144
function write_all_text_exists($x) {
    return $GLOBALS['v7']($x);
}

#145
$GLOBALS['v8'] = function ($v) use ($closure21) { return closure21(NULL, $v);
 };

#146
function delete_file_async($x) {
    return $GLOBALS['v8']($x);
}

#147
$GLOBALS['v9'] = function ($v) use ($closure24) { return closure24(NULL, $v);
 };

#148
function move_file_async($x) {
    return $GLOBALS['v9']($x);
}

#149
$GLOBALS['v10'] = function ($v) use ($closure28) { return closure28(NULL, $v);
 };

#150
function read_all_text_retry_async($x) {
    return $GLOBALS['v10']($x);
}

#151
$GLOBALS['v11'] = function ($arg10_0040) use ($closure36) { return closure36(NULL, NULL);
 };

#152
function create_temp_directory_name($unitVar) {
    return $GLOBALS['v11'](NULL);
}

#153
$GLOBALS['v12'] = function ($arg10_0040) use ($closure38) { return closure38(NULL, NULL);
 };

#154
function create_temp_directory($unitVar) {
    return $GLOBALS['v12'](NULL);
}

#155
$GLOBALS['v13'] = function ($arg10_0040) use ($closure42) { return closure42(NULL, NULL);
 };

#156
function get_source_directory($unitVar) {
    return $GLOBALS['v13'](NULL);
}

#157
$GLOBALS['v14'] = function ($v) use ($closure43) { return closure43(NULL, $v);
 };

#158
function find_parent($x) {
    return $GLOBALS['v14']($x);
}

#159
$GLOBALS['v15'] = function ($v) use ($closure50) { return closure50(NULL, $v);
 };

#160
function normalize_path($x) {
    return $GLOBALS['v15']($x);
}

#161
$GLOBALS['v16'] = function ($v) use ($closure51) { return closure51(NULL, $v);
 };

#162
function new_file_uri($x) {
    return $GLOBALS['v16']($x);
}

#163
$GLOBALS['v17'] = function ($arg10_0040) use ($closure52) { return closure52(NULL, NULL);
 };

#164
function get_repository_root($unitVar) {
    return $GLOBALS['v17'](NULL);
}

#165
$GLOBALS['v18'] = function ($v) use ($closure53) { return closure53(NULL, $v);
 };

#166
function init_trace_file($x) {
    return $GLOBALS['v18']($x);
}

#167
$GLOBALS['v19'] = function ($v) use ($closure55) { return closure55(NULL, $v);
 };

#168
function op_LessDivideGreater($x) {
    return $GLOBALS['v19']($x);
}

#169

