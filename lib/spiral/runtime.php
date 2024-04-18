<?php
namespace Runtime;

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
        return [ '\\Runtime\\US0_US0_0', '\\Runtime\\US0_US0_1', '\\Runtime\\US0_US0_2', '\\Runtime\\US0_US0_3', '\\Runtime\\US0_US0_4' ];
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
        return '\\Runtime\\US0';
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
        return [ '\\Runtime\\US1_US1_0', '\\Runtime\\US1_US1_1' ];
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
abstract class UH0 implements FSharpUnion {
    static function allCases() {
        return [ '\\Runtime\\UH0_UH0_0', '\\Runtime\\UH0_UH0_1' ];
    }
}

#6
class UH0_UH0_0 extends UH0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'UH0_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__12 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__12;
    }
}

#6
class UH0_UH0_1 extends UH0 implements IComparable {
    public $Item1;
    public $Item2;
    function __construct($Item1, $Item2) {
        $this->Item1 = $Item1;
        $this->Item2 = $Item2;
    }
    static function get_FSharpCase() {
        return 'UH0_1';
    }
    static function get_Item1_Type() {
        return '??? \'Char\'';
    }
    static function get_Item2_Type() {
        return '\\Runtime\\UH0';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__13 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__13 != 0) {
            return $_cmp__13;
        }        
        $_cmp__14 = $this->Item1->CompareTo($other->Item1);
        if ($_cmp__14 != 0) {
            return $_cmp__14;
        }        
        $_cmp__15 = $this->Item2->CompareTo($other->Item2);
        if ($_cmp__15 != 0) {
            return $_cmp__15;
        }        
        return 0;
    }
}

#7
abstract class US3 implements FSharpUnion {
    static function allCases() {
        return [ '\\Runtime\\US3_US3_0', '\\Runtime\\US3_US3_1' ];
    }
}

#7
class US3_US3_0 extends US3 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US3_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__16 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__16;
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
abstract class US2 implements FSharpUnion {
    static function allCases() {
        return [ '\\Runtime\\US2_US2_0', '\\Runtime\\US2_US2_1', '\\Runtime\\US2_US2_2' ];
    }
}

#8
class US2_US2_0 extends US2 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US2_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__18 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__18;
    }
}

#8
class US2_US2_1 extends US2 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US2_1';
    }
    static function get_f1_0_Type() {
        return '\\Runtime\\US3';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__19 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__19 != 0) {
            return $_cmp__19;
        }        
        $_cmp__20 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__20 != 0) {
            return $_cmp__20;
        }        
        return 0;
    }
}

#8
class US2_US2_2 extends US2 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US2_2';
    }
    function get_Tag() {
        return 2;
    }
    function CompareTo($other) {
        $_cmp__21 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__21;
    }
}

#9
abstract class US4 implements FSharpUnion {
    static function allCases() {
        return [ '\\Runtime\\US4_US4_0', '\\Runtime\\US4_US4_1' ];
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
        return 'String';
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
        $_cmp__24 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__24;
    }
}

#10
abstract class US5 implements FSharpUnion {
    static function allCases() {
        return [ '\\Runtime\\US5_US5_0', '\\Runtime\\US5_US5_1' ];
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
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__25 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__25 != 0) {
            return $_cmp__25;
        }        
        $_cmp__26 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__26 != 0) {
            return $_cmp__26;
        }        
        return 0;
    }
}

#10
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
        $_cmp__27 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__27;
    }
}

#11
abstract class US6 implements FSharpUnion {
    static function allCases() {
        return [ '\\Runtime\\US6_US6_0', '\\Runtime\\US6_US6_1' ];
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
        return '??? \'LambdaType
  (Tuple ([Boolean; String; Number (Int32, Empty)], true),
   DeclaredType ({ FullName = "Microsoft.FSharp.Control.FSharpAsync`1"
                   Path = CoreAssemblyName "FSharp.Core" }, [Unit]))\'';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__28 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__28 != 0) {
            return $_cmp__28;
        }        
        $_cmp__29 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__29 != 0) {
            return $_cmp__29;
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
        $_cmp__30 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__30;
    }
}

#12
abstract class US7 implements FSharpUnion {
    static function allCases() {
        return [ '\\Runtime\\US7_US7_0', '\\Runtime\\US7_US7_1' ];
    }
}

#12
class US7_US7_0 extends US7 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US7_0';
    }
    static function get_f0_0_Type() {
        return '\\Runtime\\System_Threading_CancellationToken';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__31 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__31 != 0) {
            return $_cmp__31;
        }        
        $_cmp__32 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__32 != 0) {
            return $_cmp__32;
        }        
        return 0;
    }
}

#12
class US7_US7_1 extends US7 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US7_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__33 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__33;
    }
}

#13
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#14
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#15
function US0__get_IsUS0_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#16
function US0__get_IsUS0_3($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#17
function US0__get_IsUS0_4($this_, $unitArg) {
    if ($this_->get_Tag() == 4) {
        return true;
    } else {
        return false;
    }
}

#18
function US1__get_IsUS1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#19
function US1__get_IsUS1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#20
function UH0__get_IsUH0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#21
function UH0__get_IsUH0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#22
function US3__get_IsUS3_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#23
function US3__get_IsUS3_1($this_, $unitArg) {
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
function US2__get_IsUS2_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#27
function US4__get_IsUS4_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#28
function US4__get_IsUS4_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
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
function US6__get_IsUS6_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#32
function US6__get_IsUS6_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#33
function US7__get_IsUS7_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#34
function US7__get_IsUS7_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#35
function method0($v0_1) {
    return $v0_1;
}

#36
function method1($v0_1) {
    return $v0_1;
}

#37
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

#38
function closure1($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $_v0 = false;
    return \Option\value($_v0);
}

#39
function closure2($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $_v0 = false;
    if (\Option\value($_v0)) {
        return '.exe';
    } else {
        return '';
    }
}

#40
function method2($unitVar) {
    return [ '', '' ];
}

#41
function closure5($v0_1, $v1_1) {
    return new UH0_UH0_1($v0_1, $v1_1);
}

#42
function closure4($unitVar, $v0_1) {
    return function ($v) use ($closure5, $v0_1) {     return closure5($v0_1, $v);
 };
}

#43
function method3($unitVar) {
    return function ($v) use ($closure4) {     return closure4(NULL, $v);
 };
}

#44
function method4($v0_1, $v1_1, $v2_1, $v3_1) {
    if ($v2_1->get_Tag() == 1) {
        $v5 = $v2_1->Item2;
        $v4_1 = $v2_1->Item1;
        if ('"' === $v4_1) {
            if ($v1_1 === '') {
                return method4($v0_1, $v1_1, $v5, new US2_US2_1(new US3_US3_0()));
            } else {
                switch ($v3_1->get_Tag())
                {
                    case 1:
                        if ($v3_1->f1_0->get_Tag() == 0) {
                            return method4($v0_1, $v1_1, $v5, new US2_US2_1(new US3_US3_1()));
                        } else {
                            if (' ' === $v4_1) {
                                return method4($v0_1, $v1_1, $v5, new US2_US2_2());
                            } else {
                                return method4($v0_1, NULL, $v5, $v3_1);
                            }
                        }
                    case 0:
                        if (' ' === $v4_1) {
                            return method4($v0_1, $v1_1, $v5, new US2_US2_2());
                        } else {
                            return method4($v0_1, NULL, $v5, $v3_1);
                        }
                    default:
                        return method4(NULL, $v1_1, $v5, new US2_US2_2());
                }
            }
        } else {
            if ('\'' === $v4_1) {
                if ($v1_1 === '') {
                    return method4($v0_1, $v1_1, $v5, new US2_US2_1(new US3_US3_0()));
                } else {
                    switch ($v3_1->get_Tag())
                    {
                        case 1:
                            if ($v3_1->f1_0->get_Tag() == 0) {
                                return method4($v0_1, $v1_1, $v5, new US2_US2_1(new US3_US3_1()));
                            } else {
                                if (' ' === $v4_1) {
                                    return method4($v0_1, $v1_1, $v5, new US2_US2_2());
                                } else {
                                    return method4($v0_1, NULL, $v5, $v3_1);
                                }
                            }
                        case 0:
                            if (' ' === $v4_1) {
                                return method4($v0_1, $v1_1, $v5, new US2_US2_2());
                            } else {
                                return method4($v0_1, NULL, $v5, $v3_1);
                            }
                        default:
                            return method4(NULL, $v1_1, $v5, new US2_US2_2());
                    }
                }
            } else {
                switch ($v3_1->get_Tag())
                {
                    case 1:
                        if ($v3_1->f1_0->get_Tag() == 0) {
                            if (' ' === $v4_1) {
                                return method4($v0_1, NULL, $v5, new US2_US2_1(new US3_US3_0()));
                            } else {
                                return method4($v0_1, NULL, $v5, $v3_1);
                            }
                        } else {
                            if (' ' === $v4_1) {
                                return method4($v0_1, $v1_1, $v5, new US2_US2_2());
                            } else {
                                return method4($v0_1, NULL, $v5, $v3_1);
                            }
                        }
                    case 0:
                        if (' ' === $v4_1) {
                            return method4($v0_1, $v1_1, $v5, new US2_US2_2());
                        } else {
                            return method4($v0_1, NULL, $v5, $v3_1);
                        }
                    default:
                        return method4(NULL, $v1_1, $v5, new US2_US2_2());
                }
            }
        }
    } else {
        switch ($v3_1->get_Tag())
        {
            case 1:
                if ($v3_1->f1_0->get_Tag() == 0) {
                    return [ $v1_1->\String\replace('\\', '/'), $v0_1 ];
                } else {
                    return [ $v1_1->\String\replace('\\', '/'), $v0_1 ];
                }
            case 0:
                return [ $v1_1->\String\replace('\\', '/'), $v0_1 ];
            default:
                return [ $v1_1->\String\replace('\\', '/'), $v0_1 ];
        }
    }
}

#45
function closure6($unitVar, $v0_1) {
    return new US4_US4_0($v0_1);
}

#46
function method5($unitVar) {
    return function ($v) use ($closure6) {     return closure6(NULL, $v);
 };
}

#47
function closure7($v0_1, $v1_1, $v2_1, $v3_1, $unitVar) {
    return \String\toText(\String\interpolate('execute_with_options_async / options: %A%P()', [ [ $v0_1, $v1_1, $v2_1, $v3_1 ] ]));
}

#48
function closure8($unitVar, $unitVar_1) {
    return '';
}

#49
function method6($unitVar) {
    return function ($arg10_0040) use ($closure8) {     return closure8(NULL, NULL);
 };
}

#50
function closure10($unitVar, $v0_1) {
    return new US5_US5_0($v0_1);
}

#51
function method8($unitVar) {
    return function ($v) use ($closure10) {     return closure10(NULL, $v);
 };
}

#52
function method9($unitVar) {
    return '';
}

#53
function closure9($v0_1, $v1_1, $v2_1, $unitVar) {
    if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
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
function method7($v0_1, $v1_1, $v2_1) {
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

#55
function closure12($unitVar, $v0_1) {
    return new US6_US6_0($v0_1);
}

#56
function method10($unitVar) {
    return function ($v) use ($closure12) {     return closure12(NULL, $v);
 };
}

#57
function closure13($v0_1, $unitVar) {
    return NULL;
}

#58
function closure11($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5, $v6) {
    $_v7 = NULL;
    $x = \Util\defaultOf();
    $_v7 = $x;
    $v32 = \Option\value($_v7);
    $_v33 = NULL;
    \Util\defaultOf();
    $_v33 = NULL;
    \Option\value($_v33);
    return NULL;
}

#59
function closure14($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5, $v6) {
    $_v7 = NULL;
    $x = \Util\defaultOf();
    $_v7 = $x;
    $v33 = \Option\value($_v7);
    $_v34 = NULL;
    \Util\defaultOf();
    $_v34 = NULL;
    \Option\value($_v34);
    return NULL;
}

#60
function closure15($unitVar, $v0_1) {
    return new US7_US7_0($v0_1);
}

#61
function method11($unitVar) {
    return function ($v) use ($closure15) {     return closure15(NULL, $v);
 };
}

#62
function closure16($v0_1, $unitVar) {
    $_v1 = NULL;
    $_v1 = false;
    if (\Option\value($_v1) === false) {
        $_v11 = NULL;
        \Util\defaultOf();
        $_v11 = NULL;
        \Option\value($_v11);
        return NULL;
    } else {
        return NULL;
    }
}

#63
function closure17($v0_1, $unitVar) {
    return \String\toText(\String\interpolate('execute_with_options_async / WaitForExitAsync / ex: %A%P()', [ $v0_1 ]));
}

#64
function method12($unitVar) {
    return '
';
}

#65
function closure18($v0_1, $v1_1, $unitVar) {
    return NULL;
}

#66
function closure3($unitVar, $v0_1) {
    $_v4 = NULL;
    $x = \Util\defaultOf();
    $_v4 = $x;
    return \Option\value($_v4);
}

#67
function closure19($unitVar, $_arg) {
    $_v4 = NULL;
    $x = \Util\defaultOf();
    $_v4 = $x;
    return \Option\value($_v4);
}

#68
$GLOBALS['v0'] = function ($arg10_0040) use ($closure0) { return closure0(NULL, NULL);
 };

#69
if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
    $GLOBALS['State_trace_state'] = $GLOBALS['v0'](NULL);
} else {
}

#70
$GLOBALS['v1'] = function ($arg10_0040) use ($closure1) { return closure1(NULL, NULL);
 };

#71
function is_windows($unitVar) {
    return $GLOBALS['v1'](NULL);
}

#72
$GLOBALS['v2'] = function ($arg10_0040) use ($closure2) { return closure2(NULL, NULL);
 };

#73
function get_executable_suffix($unitVar) {
    return $GLOBALS['v2'](NULL);
}

#74
$GLOBALS['v3'] = function ($v) use ($closure3) { return closure3(NULL, $v);
 };

#75
function execute_async($x) {
    return $GLOBALS['v3']($x);
}

#76
$GLOBALS['v4'] = function ($arg10_0040) use ($closure19) { return closure19(NULL, $arg10_0040);
 };

#77
function execute_with_options_async($x) {
    return $GLOBALS['v4']($x);
}

#78

