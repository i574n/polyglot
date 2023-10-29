<?php
namespace Dice;

require_once(__FABLE_LIBRARY__.'/BigInt.php');
require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');

use \FSharpUnion;
use \IComparable;

#0
abstract class UH0 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\UH0_UH0_0', '\\Dice\\UH0_UH0_1' ];
    }
}

#0
class UH0_UH0_0 extends UH0 implements IComparable {
    public $Item1;
    public $Item2;
    function __construct($Item1, $Item2) {
        $this->Item1 = $Item1;
        $this->Item2 = $Item2;
    }
    static function get_FSharpCase() {
        return 'UH0_0';
    }
    static function get_Item1_Type() {
        return 'UInt64';
    }
    static function get_Item2_Type() {
        return '??? \'LambdaType
  (Unit,
   DeclaredType
     ({ FullName = "Dice.UH0"
        Path = SourcePath "C:/home/git/polyglot/apps/dice/target/dice.fs" }, []))\'';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__1 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__1 != 0) {
            return $_cmp__1;
        }        
        $_cmp__2 = $this->Item1 > $other->Item1 ? 1 : ($this->Item1 < $other->Item1 ? -1 : 0);
        if ($_cmp__2 != 0) {
            return $_cmp__2;
        }        
        $_cmp__3 = $this->Item2->CompareTo($other->Item2);
        if ($_cmp__3 != 0) {
            return $_cmp__3;
        }        
        return 0;
    }
}

#0
class UH0_UH0_1 extends UH0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'UH0_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__4 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__4;
    }
}

#1
abstract class UH1 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\UH1_UH1_0', '\\Dice\\UH1_UH1_1' ];
    }
}

#1
class UH1_UH1_0 extends UH1 implements IComparable {
    public $Item1;
    public $Item2;
    function __construct($Item1, $Item2) {
        $this->Item1 = $Item1;
        $this->Item2 = $Item2;
    }
    static function get_FSharpCase() {
        return 'UH1_0';
    }
    static function get_Item1_Type() {
        return 'UInt64';
    }
    static function get_Item2_Type() {
        return '\\Dice\\UH1';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__5 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__5 != 0) {
            return $_cmp__5;
        }        
        $_cmp__6 = $this->Item1 > $other->Item1 ? 1 : ($this->Item1 < $other->Item1 ? -1 : 0);
        if ($_cmp__6 != 0) {
            return $_cmp__6;
        }        
        $_cmp__7 = $this->Item2->CompareTo($other->Item2);
        if ($_cmp__7 != 0) {
            return $_cmp__7;
        }        
        return 0;
    }
}

#1
class UH1_UH1_1 extends UH1 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'UH1_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__8 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__8;
    }
}

#2
abstract class US0 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US0_US0_0', '\\Dice\\US0_US0_1' ];
    }
}

#2
class US0_US0_0 extends US0 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US0_0';
    }
    static function get_f0_0_Type() {
        return '\\Dice\\UH0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__9 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__9 != 0) {
            return $_cmp__9;
        }        
        $_cmp__10 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__10 != 0) {
            return $_cmp__10;
        }        
        return 0;
    }
}

#2
class US0_US0_1 extends US0 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US0_1';
    }
    static function get_f1_0_Type() {
        return '??? \'LambdaType
  (Unit,
   DeclaredType
     ({ FullName = "Dice.UH0"
        Path = SourcePath "C:/home/git/polyglot/apps/dice/target/dice.fs" }, []))\'';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__11 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__11 != 0) {
            return $_cmp__11;
        }        
        $_cmp__12 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__12 != 0) {
            return $_cmp__12;
        }        
        return 0;
    }
}

#3
class Mut0 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '\\Dice\\US0';
    }
    function CompareTo($other) {
        $_cmp__13 = $this->l0->CompareTo($other->l0);
        if ($_cmp__13 != 0) {
            return $_cmp__13;
        }        
        return 0;
    }
}

#4
class Mut1 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return 'Int32';
    }
    function CompareTo($other) {
        $_cmp__14 = $this->l0 > $other->l0 ? 1 : ($this->l0 < $other->l0 ? -1 : 0);
        if ($_cmp__14 != 0) {
            return $_cmp__14;
        }        
        return 0;
    }
}

#5
abstract class US1 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US1_US1_0', '\\Dice\\US1_US1_1' ];
    }
}

#5
class US1_US1_0 extends US1 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US1_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__15 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__15;
    }
}

#5
class US1_US1_1 extends US1 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US1_1';
    }
    static function get_f1_0_Type() {
        return 'UInt64';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__16 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__16 != 0) {
            return $_cmp__16;
        }        
        $_cmp__17 = $this->f1_0 > $other->f1_0 ? 1 : ($this->f1_0 < $other->f1_0 ? -1 : 0);
        if ($_cmp__17 != 0) {
            return $_cmp__17;
        }        
        return 0;
    }
}

#6
abstract class US2 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US2_US2_0', '\\Dice\\US2_US2_1' ];
    }
}

#6
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

#6
class US2_US2_1 extends US2 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US2_1';
    }
    static function get_f1_0_Type() {
        return '??? \'LambdaType (String, Unit)\'';
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

#7
abstract class US3 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US3_US3_0', '\\Dice\\US3_US3_1' ];
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
        $_cmp__21 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__21;
    }
}

#7
class US3_US3_1 extends US3 implements IComparable {
    public $f1_0;
    public $f1_1;
    function __construct($f1_0, $f1_1) {
        $this->f1_0 = $f1_0;
        $this->f1_1 = $f1_1;
    }
    static function get_FSharpCase() {
        return 'US3_1';
    }
    static function get_f1_0_Type() {
        return 'UInt64';
    }
    static function get_f1_1_Type() {
        return '\\Dice\\UH1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__22 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__22 != 0) {
            return $_cmp__22;
        }        
        $_cmp__23 = $this->f1_0 > $other->f1_0 ? 1 : ($this->f1_0 < $other->f1_0 ? -1 : 0);
        if ($_cmp__23 != 0) {
            return $_cmp__23;
        }        
        $_cmp__24 = $this->f1_1->CompareTo($other->f1_1);
        if ($_cmp__24 != 0) {
            return $_cmp__24;
        }        
        return 0;
    }
}

#8
function closure2($v0, $unitVar) {
    return $v0;
}

#9
function method1($v0, $v1, $v2) {
    switch ($v1->get_Tag())
    {
        case 1:
            return $v2;
        default:
            $v6 = method1($v0, $v1->Item2(NULL), $v2);
            return new UH0_UH0_0(\BigInt\toUInt64(\BigInt\op_Addition(\BigInt\toUInt64(\BigInt\op_Modulus(\BigInt\toUInt64(\BigInt\op_Addition(\BigInt\toUInt64(\BigInt\op_Subtraction($v1->Item1, NULL)), $v0)), $v0)), NULL)), function ($arg10_0040) use ($closure2, $v6) {             return closure2($v6, NULL);
 });
    }
}

#10
function closure1($v0, $v1) {
    return method1($v0, $v1, new UH0_UH0_1());
}

#11
function closure0($unitVar, $v0) {
    return function ($v) use ($closure1, $v0) {     return closure1($v0, $v);
 };
}

#12
function method2($v0, $v1) {
    switch ($v0->get_Tag())
    {
        case 1:
            return $v1;
        default:
            return method2($v0->Item2, new UH1_UH1_0($v0->Item1, $v1));
    }
}

#13
function method3($v0, $v1) {
    switch ($v0->get_Tag())
    {
        case 1:
            return $v1;
        default:
            return new UH1_UH1_0($v0->Item1, method3($v0->Item2, $v1));
    }
}

#14
function closure4($v0, $unitVar) {
    return $v0;
}

#15
function method4($v0, $v1) {
    switch ($v0->get_Tag())
    {
        case 1:
            return $v1;
        default:
            $v4 = method4($v0->Item2, $v1);
            return new UH0_UH0_0($v0->Item1, function ($arg10_0040) use ($closure4, $v4) {             return closure4($v4, NULL);
 });
    }
}

#16
function closure5($v0, $unitVar) {
    return $v0;
}

#17
function closure6($v0, $v1, $unitVar) {
    $v2 = $v1->l0;
    switch ($v2->get_Tag())
    {
        case 1:
            $v5 = $v2->f1_0(NULL);
            switch ($v5->get_Tag())
            {
                case 1:
                    $v12 = new UH0_UH0_1();
                    break;
                default:
                    $v12 = new UH0_UH0_0($v5->Item1, $method5($v0, $v5->Item2));
                    break;
            }
            $v1->l0 = new US0_US0_0($v12);
            return $v12;
        default:
            return $v2->f0_0;
    }
}

#18
function method5($v0, $v1) {
    $v3 = new Mut0(new US0_US0_1($v1));
    return function ($arg10_0040) use ($closure6, $v0, $v3) {     return closure6($v0, $v3, NULL);
 };
}

#19
function method7($v0, $v1) {
    switch ($v1->get_Tag())
    {
        case 1:
            return new US1_US1_0();
        default:
            if ($v0 <= 0) {
                return new US1_US1_1($v1->Item1);
            } else {
                return method7($v0 - 1, $v1->Item2(NULL));
            }
    }
}

#20
function method6($v0, $v1, $v2, $v3) {
    $v4 = $v0(NULL);
    $v6 = method7($v1->l0, $v4);
    switch ($v6->get_Tag())
    {
        case 1:
            $v9 = $v1->l0 + 1;
            $v1->l0 = $v9;
            return $v6->f1_0;
        default:
            if ($v3->l0 === -1) {
                $v12 = $v1->l0;
                $v3->l0 = $v12;
            } else {
            }
            if ($v2->l0 >= $v3->l0) {
                $v18 = 1;
            } else {
                $v18 = $v2->l0 + 1;
            }
            $v2->l0 = $v18;
            $v20 = $v2->l0 - 1;
            $v1->l0 = $v20;
            return method6($v0, $v1, $v2, $v3);
    }
}

#21
function closure7($v0, $v1, $v2, $v3, $unitVar) {
    return method6($v0, $v1, $v2, $v3);
}

#22
function closure3($unitVar, $v0) {
    $v5 = method4(method3($v0, method2($v0, new UH1_UH1_1())), new UH0_UH0_1());
    $v7 = method5($v5, function ($arg10_0040) use ($closure5, $v5) {     return closure5($v5, NULL);
 });
    $v8 = new Mut1(0);
    $v9 = new Mut1(1);
    $v10 = new Mut1(-1);
    return function ($arg10_0040_1) use ($closure7, $v10, $v7, $v8, $v9) {     return closure7($v7, $v8, $v9, $v10, NULL);
 };
}

#23
function method8($v0, $v1, $v2, $v3) {
    if (\BigInt\compare($v3, NULL) > 0 ? \BigInt\compare($v3, $v1) < 0 : false) {
        return method8($v0, $v1, \BigInt\toInt64(\BigInt\op_Addition($v2, NULL)), \BigInt\toUInt64(\BigInt\op_Multiply($v3, NULL)));
    } else {
        $v10 = NULL;
        switch ($v0->get_Tag())
        {
            case 1:
                $v0->f1_0($v10);
                break;
            default:
                break;
        }
        return $v2;
    }
}

#24
function closure75($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure75) {     return closure75(NULL, NULL);
 });
}

#25
function closure74($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure75) {     return closure75(NULL, NULL);
 });
}

#26
function closure73($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure74) {     return closure74(NULL, NULL);
 });
}

#27
function closure72($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure73) {     return closure73(NULL, NULL);
 });
}

#28
function closure71($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure72) {     return closure72(NULL, NULL);
 });
}

#29
function closure70($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure71) {     return closure71(NULL, NULL);
 });
}

#30
function closure69($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure70) {     return closure70(NULL, NULL);
 });
}

#31
function closure68($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure69) {     return closure69(NULL, NULL);
 });
}

#32
function closure67($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure68) {     return closure68(NULL, NULL);
 });
}

#33
function closure66($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure67) {     return closure67(NULL, NULL);
 });
}

#34
function closure65($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure66) {     return closure66(NULL, NULL);
 });
}

#35
function closure64($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure65) {     return closure65(NULL, NULL);
 });
}

#36
function closure63($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure64) {     return closure64(NULL, NULL);
 });
}

#37
function closure62($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure63) {     return closure63(NULL, NULL);
 });
}

#38
function closure61($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure62) {     return closure62(NULL, NULL);
 });
}

#39
function closure60($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure61) {     return closure61(NULL, NULL);
 });
}

#40
function closure59($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure60) {     return closure60(NULL, NULL);
 });
}

#41
function closure58($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure59) {     return closure59(NULL, NULL);
 });
}

#42
function closure57($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure58) {     return closure58(NULL, NULL);
 });
}

#43
function closure56($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure57) {     return closure57(NULL, NULL);
 });
}

#44
function closure55($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure56) {     return closure56(NULL, NULL);
 });
}

#45
function closure54($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure55) {     return closure55(NULL, NULL);
 });
}

#46
function closure53($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure54) {     return closure54(NULL, NULL);
 });
}

#47
function closure52($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure53) {     return closure53(NULL, NULL);
 });
}

#48
function closure51($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure52) {     return closure52(NULL, NULL);
 });
}

#49
function closure50($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure51) {     return closure51(NULL, NULL);
 });
}

#50
function closure49($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure50) {     return closure50(NULL, NULL);
 });
}

#51
function closure48($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure49) {     return closure49(NULL, NULL);
 });
}

#52
function closure47($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure48) {     return closure48(NULL, NULL);
 });
}

#53
function closure46($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure47) {     return closure47(NULL, NULL);
 });
}

#54
function closure45($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure46) {     return closure46(NULL, NULL);
 });
}

#55
function closure44($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure45) {     return closure45(NULL, NULL);
 });
}

#56
function closure43($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure44) {     return closure44(NULL, NULL);
 });
}

#57
function closure42($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure43) {     return closure43(NULL, NULL);
 });
}

#58
function closure41($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure42) {     return closure42(NULL, NULL);
 });
}

#59
function closure40($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure41) {     return closure41(NULL, NULL);
 });
}

#60
function closure39($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure40) {     return closure40(NULL, NULL);
 });
}

#61
function closure38($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure39) {     return closure39(NULL, NULL);
 });
}

#62
function closure37($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure38) {     return closure38(NULL, NULL);
 });
}

#63
function closure36($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure37) {     return closure37(NULL, NULL);
 });
}

#64
function closure35($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure36) {     return closure36(NULL, NULL);
 });
}

#65
function closure34($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure35) {     return closure35(NULL, NULL);
 });
}

#66
function closure33($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure34) {     return closure34(NULL, NULL);
 });
}

#67
function closure32($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure33) {     return closure33(NULL, NULL);
 });
}

#68
function closure31($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure32) {     return closure32(NULL, NULL);
 });
}

#69
function closure30($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure31) {     return closure31(NULL, NULL);
 });
}

#70
function closure29($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure30) {     return closure30(NULL, NULL);
 });
}

#71
function closure28($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure29) {     return closure29(NULL, NULL);
 });
}

#72
function closure27($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure28) {     return closure28(NULL, NULL);
 });
}

#73
function closure26($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure27) {     return closure27(NULL, NULL);
 });
}

#74
function closure25($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure26) {     return closure26(NULL, NULL);
 });
}

#75
function closure24($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure25) {     return closure25(NULL, NULL);
 });
}

#76
function closure23($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure24) {     return closure24(NULL, NULL);
 });
}

#77
function closure22($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure23) {     return closure23(NULL, NULL);
 });
}

#78
function closure21($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure22) {     return closure22(NULL, NULL);
 });
}

#79
function closure20($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure21) {     return closure21(NULL, NULL);
 });
}

#80
function closure19($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure20) {     return closure20(NULL, NULL);
 });
}

#81
function closure18($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure19) {     return closure19(NULL, NULL);
 });
}

#82
function closure17($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure18) {     return closure18(NULL, NULL);
 });
}

#83
function closure16($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure17) {     return closure17(NULL, NULL);
 });
}

#84
function closure15($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure16) {     return closure16(NULL, NULL);
 });
}

#85
function closure14($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure15) {     return closure15(NULL, NULL);
 });
}

#86
function closure13($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure14) {     return closure14(NULL, NULL);
 });
}

#87
function closure12($unitVar, $unitVar_1) {
    return new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure13) {     return closure13(NULL, NULL);
 });
}

#88
function method11($v0, $v1) {
    switch ($v1->get_Tag())
    {
        case 1:
            return new US1_US1_0();
        default:
            if (\BigInt\compare($v0, NULL) <= 0) {
                return new US1_US1_1($v1->Item1);
            } else {
                return method11(\BigInt\toInt64(\BigInt\op_Subtraction($v0, NULL)), $v1->Item2(NULL));
            }
    }
}

#89
function method10($v0, $v1, $v2, $v3) {
    if (\BigInt\compare($v1, NULL) < 0) {
        $v5 = NULL;
        switch ($v0->get_Tag())
        {
            case 1:
                $v0->f1_0($v5);
                break;
            default:
                break;
        }
        return new US3_US3_1(\BigInt\toUInt64(\BigInt\op_Addition($v3, NULL)), $v2);
    } else {
        switch ($v2->get_Tag())
        {
            case 1:
                return new US3_US3_0();
            default:
                $v11 = $v2->Item2;
                $v10 = $v2->Item1;
                if (\BigInt\compare($v10, NULL) > 0) {
                    $v16 = method11($v1, new UH0_UH0_0(NULL, function ($arg10_0040) use ($closure12) {                     return closure12(NULL, NULL);
 }));
                    switch ($v16->get_Tag())
                    {
                        case 1:
                            $v20 = $v16->f1_0;
                            break;
                        default:
                            throw new \Exception('Option does not have a value.');
                            break;
                    }
                    $v22 = \BigInt\toUInt64(\BigInt\op_Multiply(\BigInt\toUInt64(\BigInt\op_Subtraction($v10, NULL)), $v20));
                    $v23 = NULL;
                    switch ($v0->get_Tag())
                    {
                        case 1:
                            $v0->f1_0($v23);
                            break;
                        default:
                            break;
                    }
                    $v25 = \BigInt\toUInt64(\BigInt\op_Addition($v3, $v22));
                    return method10($v0, \BigInt\toInt64(\BigInt\op_Subtraction($v1, NULL)), $v11, $v25);
                } else {
                    $v28 = NULL;
                    switch ($v0->get_Tag())
                    {
                        case 1:
                            $v0->f1_0($v28);
                            break;
                        default:
                            break;
                    }
                    return method10($v0, \BigInt\toInt64(\BigInt\op_Subtraction($v1, NULL)), $v11, $v3);
                }
        }
    }
}

#90
function method12($v0, $v1, $v2) {
    if (\BigInt\compare($v2, $v0) < 0) {
        return new UH1_UH1_0($v1(NULL), method12($v0, $v1, \BigInt\toInt64(\BigInt\op_Addition($v2, NULL))));
    } else {
        return new UH1_UH1_1();
    }
}

#91
function method13($v0, $v1, $v2, $v3, $v4, $v5) {
    $v6 = \BigInt\toInt64(\BigInt\op_Addition($v4, NULL));
    if (\BigInt\compare($v4, $v6) < 0) {
        return $method9($v0, $v1, $v2, $v3, $v4, new UH1_UH1_0($v1(NULL), $v5), $v6);
    } else {
        $v12 = method10($v0, $v4, $v5, NULL);
        if ($v12->get_Tag() == 1) {
            $v13 = $v12->f1_0;
            if (\BigInt\compare($v13, $v3) <= 0) {
                return $v13;
            } else {
                if ($v2) {
                    return method13($v0, $v1, $v2, $v3, $v4, method12($v4, $v1, NULL));
                } else {
                    return $method9($v0, $v1, $v2, $v3, $v4, new UH1_UH1_0($v1(NULL), $v5), $v6);
                }
            }
        } else {
            if ($v2) {
                return method13($v0, $v1, $v2, $v3, $v4, method12($v4, $v1, NULL));
            } else {
                return $method9($v0, $v1, $v2, $v3, $v4, new UH1_UH1_0($v1(NULL), $v5), $v6);
            }
        }
    }
}

#92
function method9($v0, $v1, $v2, $v3, $v4, $v5, $v6) {
    if (\BigInt\compare($v6, \BigInt\toInt64(\BigInt\op_Addition($v4, NULL))) < 0) {
        return method9($v0, $v1, $v2, $v3, $v4, new UH1_UH1_0($v1(NULL), $v5), \BigInt\toInt64(\BigInt\op_Addition($v6, NULL)));
    } else {
        $v14 = method10($v0, $v4, $v5, NULL);
        if ($v14->get_Tag() == 1) {
            $v15 = $v14->f1_0;
            if (\BigInt\compare($v15, $v3) <= 0) {
                return $v15;
            } else {
                if ($v2) {
                    return method13($v0, $v1, $v2, $v3, $v4, method12($v4, $v1, NULL));
                } else {
                    return method9($v0, $v1, $v2, $v3, $v4, new UH1_UH1_0($v1(NULL), $v5), \BigInt\toInt64(\BigInt\op_Addition($v6, NULL)));
                }
            }
        } else {
            if ($v2) {
                return method13($v0, $v1, $v2, $v3, $v4, method12($v4, $v1, NULL));
            } else {
                return method9($v0, $v1, $v2, $v3, $v4, new UH1_UH1_0($v1(NULL), $v5), \BigInt\toInt64(\BigInt\op_Addition($v6, NULL)));
            }
        }
    }
}

#93
function closure11($v0, $v1, $v2, $v3) {
    return method9($v0, $v1, $v2, $v3, \BigInt\toInt64(\BigInt\op_Subtraction(\BigInt\equals($v3, NULL) ? NULL : method8($v0, $v3, NULL, NULL), NULL)), new UH1_UH1_1(), NULL);
}

#94
function closure10($v0, $v1, $v2) {
    return function ($v) use ($closure11, $v0, $v1, $v2) {     return closure11($v0, $v1, $v2, $v);
 };
}

#95
function closure9($v0, $v1) {
    return function ($v) use ($closure10, $v0, $v1) {     return closure10($v0, $v1, $v);
 };
}

#96
function closure8($unitVar, $v0) {
    return function ($v) use ($closure9, $v0) {     return closure9($v0, $v);
 };
}

#97
function method14($v0, $v1) {
    switch ($v0->get_Tag())
    {
        case 1:
            return $v1;
        default:
            return method14($v0->Item2, \BigInt\toInt64(\BigInt\op_Addition($v1, NULL)));
    }
}

#98
function closure78($v0, $v1, $v2) {
    $v7 = method10($v0, \BigInt\toInt64(\BigInt\op_Subtraction(method14($v2, NULL), NULL)), $v2, NULL);
    if ($v7->get_Tag() == 1) {
        $v8 = $v7->f1_0;
        if (\BigInt\compare($v8, NULL) >= 0 ? \BigInt\compare($v8, $v1) <= 0 : false) {
            return new US1_US1_1($v8);
        } else {
            return new US1_US1_0();
        }
    } else {
        return new US1_US1_0();
    }
}

#99
function closure77($v0, $v1) {
    return function ($v) use ($closure78, $v0, $v1) {     return closure78($v0, $v1, $v);
 };
}

#100
function closure76($unitVar, $v0) {
    return function ($v) use ($closure77, $v0) {     return closure77($v0, $v);
 };
}

#101
function method0($unitVar) {
    return NULL;
}

#102
method0(NULL);

#103
function main($_args) {
    return 0;
}

