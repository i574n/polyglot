<?php
namespace Dice;

require_once(__FABLE_LIBRARY__.'/BigInt.php');
require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/Random.php');
require_once(__FABLE_LIBRARY__.'/String.php');

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
        return 'UInt8';
    }
    static function get_Item2_Type() {
        return '??? \'LambdaType
  (Unit,
   DeclaredType
     ({ FullName = "Dice.UH0"
        Path =
         SourcePath "C:/home/git/polyglot/target/polyglot/builder/dice/dice.fs" },
      []))\'';
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
        return 'UInt8';
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
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__9 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__9;
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
        return '??? \'LambdaType (String, Unit)\'';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__10 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__10 != 0) {
            return $_cmp__10;
        }        
        $_cmp__11 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__11 != 0) {
            return $_cmp__11;
        }        
        return 0;
    }
}

#3
abstract class US1 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US1_US1_0', '\\Dice\\US1_US1_1' ];
    }
}

#3
class US1_US1_0 extends US1 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US1_0';
    }
    static function get_f0_0_Type() {
        return '\\Dice\\UH0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__12 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__12 != 0) {
            return $_cmp__12;
        }        
        $_cmp__13 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__13 != 0) {
            return $_cmp__13;
        }        
        return 0;
    }
}

#3
class US1_US1_1 extends US1 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US1_1';
    }
    static function get_f1_0_Type() {
        return '??? \'LambdaType
  (Unit,
   DeclaredType
     ({ FullName = "Dice.UH0"
        Path =
         SourcePath "C:/home/git/polyglot/target/polyglot/builder/dice/dice.fs" },
      []))\'';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__14 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__14 != 0) {
            return $_cmp__14;
        }        
        $_cmp__15 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__15 != 0) {
            return $_cmp__15;
        }        
        return 0;
    }
}

#4
class Mut0 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '\\Dice\\US1';
    }
    function CompareTo($other) {
        $_cmp__16 = $this->l0->CompareTo($other->l0);
        if ($_cmp__16 != 0) {
            return $_cmp__16;
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
        return 'Int64';
    }
    function CompareTo($other) {
        $_cmp__17 = $this->l0 > $other->l0 ? 1 : ($this->l0 < $other->l0 ? -1 : 0);
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
        return 'UInt8';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__19 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__19 != 0) {
            return $_cmp__19;
        }        
        $_cmp__20 = $this->f1_0 > $other->f1_0 ? 1 : ($this->f1_0 < $other->f1_0 ? -1 : 0);
        if ($_cmp__20 != 0) {
            return $_cmp__20;
        }        
        return 0;
    }
}

#7
class Mut2 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '\\Dice\\US2';
    }
    function CompareTo($other) {
        $_cmp__21 = $this->l0->CompareTo($other->l0);
        if ($_cmp__21 != 0) {
            return $_cmp__21;
        }        
        return 0;
    }
}

#8
abstract class US3 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US3_US3_0', '\\Dice\\US3_US3_1' ];
    }
}

#8
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
        $_cmp__22 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__22;
    }
}

#8
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
        $_cmp__23 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__23 != 0) {
            return $_cmp__23;
        }        
        $_cmp__24 = $this->f1_0 > $other->f1_0 ? 1 : ($this->f1_0 < $other->f1_0 ? -1 : 0);
        if ($_cmp__24 != 0) {
            return $_cmp__24;
        }        
        $_cmp__25 = $this->f1_1->CompareTo($other->f1_1);
        if ($_cmp__25 != 0) {
            return $_cmp__25;
        }        
        return 0;
    }
}

#9
abstract class UH2 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\UH2_UH2_0', '\\Dice\\UH2_UH2_1' ];
    }
}

#9
class UH2_UH2_0 extends UH2 implements IComparable {
    public $Item1;
    public $Item2;
    function __construct($Item1, $Item2) {
        $this->Item1 = $Item1;
        $this->Item2 = $Item2;
    }
    static function get_FSharpCase() {
        return 'UH2_0';
    }
    static function get_Item1_Type() {
        return 'UInt64';
    }
    static function get_Item2_Type() {
        return '??? \'LambdaType
  (Unit,
   DeclaredType
     ({ FullName = "Dice.UH2"
        Path =
         SourcePath "C:/home/git/polyglot/target/polyglot/builder/dice/dice.fs" },
      []))\'';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__26 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__26 != 0) {
            return $_cmp__26;
        }        
        $_cmp__27 = $this->Item1 > $other->Item1 ? 1 : ($this->Item1 < $other->Item1 ? -1 : 0);
        if ($_cmp__27 != 0) {
            return $_cmp__27;
        }        
        $_cmp__28 = $this->Item2->CompareTo($other->Item2);
        if ($_cmp__28 != 0) {
            return $_cmp__28;
        }        
        return 0;
    }
}

#9
class UH2_UH2_1 extends UH2 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'UH2_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__29 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__29;
    }
}

#10
abstract class US4 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US4_US4_0', '\\Dice\\US4_US4_1' ];
    }
}

#10
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
        $_cmp__30 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__30;
    }
}

#10
class US4_US4_1 extends US4 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US4_1';
    }
    static function get_f1_0_Type() {
        return 'UInt64';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__31 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__31 != 0) {
            return $_cmp__31;
        }        
        $_cmp__32 = $this->f1_0 > $other->f1_0 ? 1 : ($this->f1_0 < $other->f1_0 ? -1 : 0);
        if ($_cmp__32 != 0) {
            return $_cmp__32;
        }        
        return 0;
    }
}

#11
abstract class US5 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US5_US5_0', '\\Dice\\US5_US5_1' ];
    }
}

#11
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
        $_cmp__33 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__33;
    }
}

#11
class US5_US5_1 extends US5 implements IComparable {
    public $f1_0;
    public $f1_1;
    function __construct($f1_0, $f1_1) {
        $this->f1_0 = $f1_0;
        $this->f1_1 = $f1_1;
    }
    static function get_FSharpCase() {
        return 'US5_1';
    }
    static function get_f1_0_Type() {
        return 'Int64';
    }
    static function get_f1_1_Type() {
        return '\\Dice\\UH1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__34 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__34 != 0) {
            return $_cmp__34;
        }        
        $_cmp__35 = $this->f1_0 > $other->f1_0 ? 1 : ($this->f1_0 < $other->f1_0 ? -1 : 0);
        if ($_cmp__35 != 0) {
            return $_cmp__35;
        }        
        $_cmp__36 = $this->f1_1->CompareTo($other->f1_1);
        if ($_cmp__36 != 0) {
            return $_cmp__36;
        }        
        return 0;
    }
}

#12
function closure2($v0_1, $unitVar) {
    return $v0_1;
}

#13
function method0($v0_1, $v1_1, $v2_1) {
    switch ($v1_1->get_Tag())
    {
        case 1:
            return $v2_1;
        default:
            $v6 = method0($v0_1, $v1_1->Item2(NULL), $v2_1);
            $v11 = \BigInt\toInt64(\BigInt\op_Addition(\BigInt\toInt64(\BigInt\op_Modulus(\BigInt\toInt64(\BigInt\op_Addition(\BigInt\toInt64(\BigInt\op_Subtraction(\BigInt\toInt64(\BigInt\fromUInt8($v1_1->Item1)), NULL)), $v0_1)), $v0_1)), NULL));
            return new UH0_UH0_0(\BigInt\toUInt8($v11) & 0xFF, function ($arg10_0040) use ($closure2, $v6) {             return closure2($v6, NULL);
 });
    }
}

#14
function closure1($v0_1, $v1_1) {
    return method0($v0_1, $v1_1, new UH0_UH0_1());
}

#15
function closure0($unitVar, $v0_1) {
    return function ($v) use ($closure1, $v0_1) {     return closure1($v0_1, $v);
 };
}

#16
function closure4($unitVar, $v0_1) {
    return new US0_US0_1($v0_1);
}

#17
function method1($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return $v1_1;
        default:
            return method1($v0_1->Item2, new UH1_UH1_0($v0_1->Item1, $v1_1));
    }
}

#18
function method2($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return $v1_1;
        default:
            return new UH1_UH1_0($v0_1->Item1, method2($v0_1->Item2, $v1_1));
    }
}

#19
function closure6($v0_1, $unitVar) {
    return $v0_1;
}

#20
function method3($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return $v1_1;
        default:
            $v4_1 = method3($v0_1->Item2, $v1_1);
            return new UH0_UH0_0($v0_1->Item1, function ($arg10_0040) use ($closure6, $v4_1) {             return closure6($v4_1, NULL);
 });
    }
}

#21
function closure7($v0_1, $unitVar) {
    return $v0_1;
}

#22
function closure8($v0_1, $v1_1, $unitVar) {
    $v2_1 = $v1_1->l0;
    switch ($v2_1->get_Tag())
    {
        case 1:
            $v5 = $v2_1->f1_0(NULL);
            switch ($v5->get_Tag())
            {
                case 1:
                    $v12 = new UH0_UH0_1();
                    break;
                default:
                    $v12 = new UH0_UH0_0($v5->Item1, $method4($v0_1, $v5->Item2));
                    break;
            }
            $v1_1->l0 = new US1_US1_0($v12);
            return $v12;
        default:
            return $v2_1->f0_0;
    }
}

#23
function method4($v0_1, $v1_1) {
    $v3_1 = new Mut0(new US1_US1_1($v1_1));
    return function ($arg10_0040) use ($closure8, $v0_1, $v3_1) {     return closure8($v0_1, $v3_1, NULL);
 };
}

#24
function method6($v0_1, $v1_1) {
    switch ($v1_1->get_Tag())
    {
        case 1:
            return new US2_US2_0();
        default:
            if (\BigInt\compare($v0_1, NULL) <= 0) {
                return new US2_US2_1($v1_1->Item1);
            } else {
                return method6(\BigInt\toInt64(\BigInt\op_Subtraction($v0_1, NULL)), $v1_1->Item2(NULL));
            }
    }
}

#25
function method5($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5) {
    $v10 = \String\toText(\String\interpolate('create_sequential_roller / roll / current_index: %P() / acc: %P() / len: %P() / last_item: %A%P()', [ $v2_1->l0, $v3_1->l0, $v4_1->l0, $v5->l0 ]));
    switch ($v0_1->get_Tag())
    {
        case 1:
            $v0_1->f1_0($v10);
            break;
        default:
            break;
    }
    $v12 = $v1_1(NULL);
    $v14 = method6($v2_1->l0, $v12);
    switch ($v14->get_Tag())
    {
        case 1:
            $v15 = $v14->f1_0;
            $v17 = \BigInt\toInt64(\BigInt\op_Addition($v2_1->l0, NULL));
            $v2_1->l0 = $v17;
            $v5->l0 = new US2_US2_1($v15);
            return $v15;
        default:
            switch ($v0_1->get_Tag())
            {
                case 1:
                    $v0_1->f1_0('create_sequential_roller / roll / None');
                    break;
                default:
                    break;
            }
            if (\BigInt\equals($v4_1->l0, NULL)) {
                $v23 = $v2_1->l0;
                $v4_1->l0 = $v23;
            } else {
            }
            if (\BigInt\compare($v3_1->l0, $v4_1->l0) >= 0) {
                $v29 = NULL;
            } else {
                $v29 = \BigInt\toInt64(\BigInt\op_Addition($v3_1->l0, NULL));
            }
            $v3_1->l0 = $v29;
            $v31 = \BigInt\toInt64(\BigInt\op_Subtraction($v3_1->l0, NULL));
            $v2_1->l0 = $v31;
            $v5->l0 = new US2_US2_0();
            return method5($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5);
    }
}

#26
function closure9($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5, $unitVar) {
    return method5($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5);
}

#27
function closure5($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            $v0_1->f1_0('create_sequential_roller ()');
            break;
        default:
            break;
    }
    $v8 = method3(method2($v1_1, method1($v1_1, new UH1_UH1_1())), new UH0_UH0_1());
    $v10 = method4($v8, function ($arg10_0040) use ($closure7, $v8) {     return closure7($v8, NULL);
 });
    $v11 = new Mut1(NULL);
    $v12 = new Mut1(NULL);
    $v13 = new Mut1(NULL);
    $v15 = new Mut2(new US2_US2_0());
    return function ($arg10_0040_1) use ($closure9, $v0_1, $v10, $v11, $v12, $v13, $v15) {     return closure9($v0_1, $v10, $v11, $v12, $v13, $v15, NULL);
 };
}

#28
function closure3($unitVar, $v0_1) {
    $v3_1 = \Option\defaultArg(\Option\map(function ($v) use ($closure4) {     return closure4(NULL, $v);
 }, $v0_1), new US0_US0_0());
    return function ($v_1) use ($closure5, $v3_1) {     return closure5($v3_1, $v_1);
 };
}

#29
function method7($v0_1, $v1_1, $v2_1, $v3_1) {
    if (\BigInt\compare($v3_1, $v1_1) < 0) {
        $v5 = \BigInt\toUInt64(\BigInt\op_Multiply($v3_1, NULL));
        if (\BigInt\compare($v5, $v3_1) > 0) {
            return method7($v0_1, $v1_1, $v2_1 + 1, $v5);
        } else {
            $v9 = NULL;
            switch ($v0_1->get_Tag())
            {
                case 1:
                    $v0_1->f1_0($v9);
                    break;
                default:
                    break;
            }
            return $v2_1;
        }
    } else {
        $v12 = NULL;
        switch ($v0_1->get_Tag())
        {
            case 1:
                $v0_1->f1_0($v12);
                break;
            default:
                break;
        }
        return $v2_1;
    }
}

#30
function closure77($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure77) {     return closure77(NULL, NULL);
 });
}

#31
function closure76($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure77) {     return closure77(NULL, NULL);
 });
}

#32
function closure75($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure76) {     return closure76(NULL, NULL);
 });
}

#33
function closure74($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure75) {     return closure75(NULL, NULL);
 });
}

#34
function closure73($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure74) {     return closure74(NULL, NULL);
 });
}

#35
function closure72($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure73) {     return closure73(NULL, NULL);
 });
}

#36
function closure71($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure72) {     return closure72(NULL, NULL);
 });
}

#37
function closure70($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure71) {     return closure71(NULL, NULL);
 });
}

#38
function closure69($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure70) {     return closure70(NULL, NULL);
 });
}

#39
function closure68($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure69) {     return closure69(NULL, NULL);
 });
}

#40
function closure67($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure68) {     return closure68(NULL, NULL);
 });
}

#41
function closure66($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure67) {     return closure67(NULL, NULL);
 });
}

#42
function closure65($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure66) {     return closure66(NULL, NULL);
 });
}

#43
function closure64($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure65) {     return closure65(NULL, NULL);
 });
}

#44
function closure63($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure64) {     return closure64(NULL, NULL);
 });
}

#45
function closure62($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure63) {     return closure63(NULL, NULL);
 });
}

#46
function closure61($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure62) {     return closure62(NULL, NULL);
 });
}

#47
function closure60($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure61) {     return closure61(NULL, NULL);
 });
}

#48
function closure59($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure60) {     return closure60(NULL, NULL);
 });
}

#49
function closure58($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure59) {     return closure59(NULL, NULL);
 });
}

#50
function closure57($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure58) {     return closure58(NULL, NULL);
 });
}

#51
function closure56($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure57) {     return closure57(NULL, NULL);
 });
}

#52
function closure55($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure56) {     return closure56(NULL, NULL);
 });
}

#53
function closure54($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure55) {     return closure55(NULL, NULL);
 });
}

#54
function closure53($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure54) {     return closure54(NULL, NULL);
 });
}

#55
function closure52($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure53) {     return closure53(NULL, NULL);
 });
}

#56
function closure51($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure52) {     return closure52(NULL, NULL);
 });
}

#57
function closure50($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure51) {     return closure51(NULL, NULL);
 });
}

#58
function closure49($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure50) {     return closure50(NULL, NULL);
 });
}

#59
function closure48($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure49) {     return closure49(NULL, NULL);
 });
}

#60
function closure47($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure48) {     return closure48(NULL, NULL);
 });
}

#61
function closure46($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure47) {     return closure47(NULL, NULL);
 });
}

#62
function closure45($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure46) {     return closure46(NULL, NULL);
 });
}

#63
function closure44($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure45) {     return closure45(NULL, NULL);
 });
}

#64
function closure43($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure44) {     return closure44(NULL, NULL);
 });
}

#65
function closure42($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure43) {     return closure43(NULL, NULL);
 });
}

#66
function closure41($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure42) {     return closure42(NULL, NULL);
 });
}

#67
function closure40($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure41) {     return closure41(NULL, NULL);
 });
}

#68
function closure39($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure40) {     return closure40(NULL, NULL);
 });
}

#69
function closure38($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure39) {     return closure39(NULL, NULL);
 });
}

#70
function closure37($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure38) {     return closure38(NULL, NULL);
 });
}

#71
function closure36($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure37) {     return closure37(NULL, NULL);
 });
}

#72
function closure35($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure36) {     return closure36(NULL, NULL);
 });
}

#73
function closure34($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure35) {     return closure35(NULL, NULL);
 });
}

#74
function closure33($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure34) {     return closure34(NULL, NULL);
 });
}

#75
function closure32($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure33) {     return closure33(NULL, NULL);
 });
}

#76
function closure31($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure32) {     return closure32(NULL, NULL);
 });
}

#77
function closure30($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure31) {     return closure31(NULL, NULL);
 });
}

#78
function closure29($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure30) {     return closure30(NULL, NULL);
 });
}

#79
function closure28($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure29) {     return closure29(NULL, NULL);
 });
}

#80
function closure27($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure28) {     return closure28(NULL, NULL);
 });
}

#81
function closure26($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure27) {     return closure27(NULL, NULL);
 });
}

#82
function closure25($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure26) {     return closure26(NULL, NULL);
 });
}

#83
function closure24($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure25) {     return closure25(NULL, NULL);
 });
}

#84
function closure23($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure24) {     return closure24(NULL, NULL);
 });
}

#85
function closure22($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure23) {     return closure23(NULL, NULL);
 });
}

#86
function closure21($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure22) {     return closure22(NULL, NULL);
 });
}

#87
function closure20($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure21) {     return closure21(NULL, NULL);
 });
}

#88
function closure19($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure20) {     return closure20(NULL, NULL);
 });
}

#89
function closure18($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure19) {     return closure19(NULL, NULL);
 });
}

#90
function closure17($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure18) {     return closure18(NULL, NULL);
 });
}

#91
function closure16($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure17) {     return closure17(NULL, NULL);
 });
}

#92
function closure15($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure16) {     return closure16(NULL, NULL);
 });
}

#93
function closure14($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure15) {     return closure15(NULL, NULL);
 });
}

#94
function method10($v0_1, $v1_1) {
    switch ($v1_1->get_Tag())
    {
        case 1:
            return new US4_US4_0();
        default:
            if ($v0_1 <= 0) {
                return new US4_US4_1($v1_1->Item1);
            } else {
                return method10($v0_1 - 1, $v1_1->Item2(NULL));
            }
    }
}

#95
function method9($v0_1, $v1_1, $v2_1, $v3_1) {
    if ($v1_1 < 0) {
        $v5 = NULL;
        switch ($v0_1->get_Tag())
        {
            case 1:
                $v0_1->f1_0($v5);
                break;
            default:
                break;
        }
        return new US3_US3_1(\BigInt\toUInt64(\BigInt\op_Addition($v3_1, NULL)), $v2_1);
    } else {
        switch ($v2_1->get_Tag())
        {
            case 1:
                return new US3_US3_0();
            default:
                $v11 = $v2_1->Item2;
                $v10 = $v2_1->Item1;
                if ($v10 > 1) {
                    $v16 = method10($v1_1, new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure14) {                     return closure14(NULL, NULL);
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
                    $v23 = \BigInt\toUInt64(\BigInt\op_Multiply(\BigInt\toUInt64(\BigInt\fromUInt8($v10 - 1)), $v20));
                    $v24 = NULL;
                    switch ($v0_1->get_Tag())
                    {
                        case 1:
                            $v0_1->f1_0($v24);
                            break;
                        default:
                            break;
                    }
                    return method9($v0_1, $v1_1 - 1, $v11, \BigInt\toUInt64(\BigInt\op_Addition($v3_1, $v23)));
                } else {
                    $v29 = NULL;
                    switch ($v0_1->get_Tag())
                    {
                        case 1:
                            $v0_1->f1_0($v29);
                            break;
                        default:
                            break;
                    }
                    return method9($v0_1, $v1_1 - 1, $v11, $v3_1);
                }
        }
    }
}

#96
function method11($v0_1, $v1_1, $v2_1) {
    if ($v2_1 < $v0_1) {
        return new UH1_UH1_0($v1_1(NULL), method11($v0_1, $v1_1, ($v2_1 + 1)));
    } else {
        return new UH1_UH1_1();
    }
}

#97
function method12($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5) {
    $v6 = $v4_1 + 1;
    if ($v4_1 < $v6) {
        return $method8($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_0($v1_1(NULL), $v5), $v6);
    } else {
        $v12 = method9($v0_1, $v4_1, $v5, NULL);
        if ($v12->get_Tag() == 1) {
            $v13 = $v12->f1_0;
            if (\BigInt\compare($v13, $v3_1) <= 0) {
                return $v13;
            } else {
                if ($v2_1) {
                    return method12($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, method11($v4_1, $v1_1, 0));
                } else {
                    return $method8($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_0($v1_1(NULL), $v5), $v6);
                }
            }
        } else {
            if ($v2_1) {
                return method12($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, method11($v4_1, $v1_1, 0));
            } else {
                return $method8($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_0($v1_1(NULL), $v5), $v6);
            }
        }
    }
}

#98
function method8($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5, $v6) {
    if ($v6 < $v4_1 + 1) {
        return method8($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_0($v1_1(NULL), $v5), $v6 + 1);
    } else {
        $v14 = method9($v0_1, $v4_1, $v5, NULL);
        if ($v14->get_Tag() == 1) {
            $v15 = $v14->f1_0;
            if (\BigInt\compare($v15, $v3_1) <= 0) {
                return $v15;
            } else {
                if ($v2_1) {
                    return method12($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, method11($v4_1, $v1_1, 0));
                } else {
                    return method8($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_0($v1_1(NULL), $v5), $v6 + 1);
                }
            }
        } else {
            if ($v2_1) {
                return method12($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, method11($v4_1, $v1_1, 0));
            } else {
                return method8($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_0($v1_1(NULL), $v5), $v6 + 1);
            }
        }
    }
}

#99
function closure13($v0_1, $v1_1, $v2_1, $v3_1) {
    return method8($v0_1, $v1_1, $v2_1, $v3_1, (\BigInt\equals($v3_1, NULL) ? 1 : method7($v0_1, $v3_1, 0, NULL)) - 1, new UH1_UH1_1(), 0);
}

#100
function closure12($v0_1, $v1_1, $v2_1) {
    return function ($v) use ($closure13, $v0_1, $v1_1, $v2_1) {     return closure13($v0_1, $v1_1, $v2_1, $v);
 };
}

#101
function closure11($v0_1, $v1_1) {
    return function ($v) use ($closure12, $v0_1, $v1_1) {     return closure12($v0_1, $v1_1, $v);
 };
}

#102
function closure10($unitVar, $v0_1) {
    $v3_1 = \Option\defaultArg(\Option\map(function ($v) use ($closure4) {     return closure4(NULL, $v);
 }, $v0_1), new US0_US0_0());
    return function ($v_1) use ($closure11, $v3_1) {     return closure11($v3_1, $v_1);
 };
}

#103
function method13($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return $v1_1;
        default:
            return method13($v0_1->Item2, $v1_1 + 1);
    }
}

#104
function closure80($v0_1, $v1_1, $v2_1) {
    $v10 = method9(\Option\defaultArg(\Option\map(function ($v) use ($closure4) {     return closure4(NULL, $v);
 }, $v0_1), new US0_US0_0()), method13($v2_1, 0) - 1, $v2_1, NULL);
    if ($v10->get_Tag() == 1) {
        $v11 = $v10->f1_0;
        if (\BigInt\compare($v11, NULL) >= 0 ? \BigInt\compare($v11, $v1_1) <= 0 : false) {
            $v20 = new US4_US4_1($v11);
        } else {
            $v20 = new US4_US4_0();
        }
    } else {
        $v20 = new US4_US4_0();
    }
    switch ($v20->get_Tag())
    {
        case 1:
            return $v20->f1_0;
        default:
            return NULL;
    }
}

#105
function closure79($v0_1, $v1_1) {
    return function ($v) use ($closure80, $v0_1, $v1_1) {     return closure80($v0_1, $v1_1, $v);
 };
}

#106
function closure78($unitVar, $v0_1) {
    return function ($v) use ($closure79, $v0_1) {     return closure79($v0_1, $v);
 };
}

#107
function method39($v0_1, $v1_1) {
    $v2_1 = NULL;
    $console->log;
    return new US5_US5_1(\BigInt\toInt64(\BigInt\op_Addition($v1_1, NULL)), $v0_1);
}

#108
function method38($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v7 = \BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1));
                $v8 = NULL;
                $console->log;
                return method39($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v7)));
            } else {
                $v11 = NULL;
                $console->log;
                return method39($v4_1, $v1_1);
            }
    }
}

#109
function method37($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method38($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method38($v4_1, $v1_1);
            }
    }
}

#110
function method36($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method37($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method37($v4_1, $v1_1);
            }
    }
}

#111
function method35($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method36($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method36($v4_1, $v1_1);
            }
    }
}

#112
function method34($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method35($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method35($v4_1, $v1_1);
            }
    }
}

#113
function method33($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method34($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method34($v4_1, $v1_1);
            }
    }
}

#114
function method32($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method33($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method33($v4_1, $v1_1);
            }
    }
}

#115
function method31($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method32($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method32($v4_1, $v1_1);
            }
    }
}

#116
function method30($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method31($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method31($v4_1, $v1_1);
            }
    }
}

#117
function method29($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method30($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method30($v4_1, $v1_1);
            }
    }
}

#118
function method28($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method29($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method29($v4_1, $v1_1);
            }
    }
}

#119
function method27($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method28($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method28($v4_1, $v1_1);
            }
    }
}

#120
function method26($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method27($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method27($v4_1, $v1_1);
            }
    }
}

#121
function method25($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method26($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method26($v4_1, $v1_1);
            }
    }
}

#122
function method24($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method25($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method25($v4_1, $v1_1);
            }
    }
}

#123
function method23($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method24($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method24($v4_1, $v1_1);
            }
    }
}

#124
function method22($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method23($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method23($v4_1, $v1_1);
            }
    }
}

#125
function method21($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method22($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method22($v4_1, $v1_1);
            }
    }
}

#126
function method20($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method21($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method21($v4_1, $v1_1);
            }
    }
}

#127
function method19($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method20($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method20($v4_1, $v1_1);
            }
    }
}

#128
function method18($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method19($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method19($v4_1, $v1_1);
            }
    }
}

#129
function method17($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method18($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method18($v4_1, $v1_1);
            }
    }
}

#130
function method16($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method17($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method17($v4_1, $v1_1);
            }
    }
}

#131
function method15($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 1:
            return new US5_US5_0();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method16($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method16($v4_1, $v1_1);
            }
    }
}

#132
function method14($v0_1, $v1_1) {
    if ($v1_1 < 24) {
        $result = NULL;
        $value = \Random\nonSeeded()->Next2;
        $x = $value & 0xFF;
        $result = $x;
        return method14(new UH1_UH1_0(\Option\value($result), $v0_1), $v1_1 + 1);
    } else {
        $v13 = method15($v0_1, NULL);
        if ($v13->get_Tag() == 1) {
            $v14 = $v13->f1_0;
            if (\BigInt\compare($v14, NULL) <= 0) {
                return $v14;
            } else {
                $result_1 = NULL;
                $value_1 = \Random\nonSeeded()->Next2;
                $x_1 = $value_1 & 0xFF;
                $result_1 = $x_1;
                $v22 = \Option\value($result_1);
                $result_2 = NULL;
                $value_2 = \Random\nonSeeded()->Next2;
                $x_2 = $value_2 & 0xFF;
                $result_2 = $x_2;
                $v26 = \Option\value($result_2);
                $result_3 = NULL;
                $value_3 = \Random\nonSeeded()->Next2;
                $x_3 = $value_3 & 0xFF;
                $result_3 = $x_3;
                $v30 = \Option\value($result_3);
                $result_4 = NULL;
                $value_4 = \Random\nonSeeded()->Next2;
                $x_4 = $value_4 & 0xFF;
                $result_4 = $x_4;
                $v34 = \Option\value($result_4);
                $result_5 = NULL;
                $value_5 = \Random\nonSeeded()->Next2;
                $x_5 = $value_5 & 0xFF;
                $result_5 = $x_5;
                $v38 = \Option\value($result_5);
                $result_6 = NULL;
                $value_6 = \Random\nonSeeded()->Next2;
                $x_6 = $value_6 & 0xFF;
                $result_6 = $x_6;
                $v42 = \Option\value($result_6);
                $result_7 = NULL;
                $value_7 = \Random\nonSeeded()->Next2;
                $x_7 = $value_7 & 0xFF;
                $result_7 = $x_7;
                $v46 = \Option\value($result_7);
                $result_8 = NULL;
                $value_8 = \Random\nonSeeded()->Next2;
                $x_8 = $value_8 & 0xFF;
                $result_8 = $x_8;
                $v50 = \Option\value($result_8);
                $result_9 = NULL;
                $value_9 = \Random\nonSeeded()->Next2;
                $x_9 = $value_9 & 0xFF;
                $result_9 = $x_9;
                $v54 = \Option\value($result_9);
                $result_10 = NULL;
                $value_10 = \Random\nonSeeded()->Next2;
                $x_10 = $value_10 & 0xFF;
                $result_10 = $x_10;
                $v58 = \Option\value($result_10);
                $result_11 = NULL;
                $value_11 = \Random\nonSeeded()->Next2;
                $x_11 = $value_11 & 0xFF;
                $result_11 = $x_11;
                $v62 = \Option\value($result_11);
                $result_12 = NULL;
                $value_12 = \Random\nonSeeded()->Next2;
                $x_12 = $value_12 & 0xFF;
                $result_12 = $x_12;
                $v66 = \Option\value($result_12);
                $result_13 = NULL;
                $value_13 = \Random\nonSeeded()->Next2;
                $x_13 = $value_13 & 0xFF;
                $result_13 = $x_13;
                $v70 = \Option\value($result_13);
                $result_14 = NULL;
                $value_14 = \Random\nonSeeded()->Next2;
                $x_14 = $value_14 & 0xFF;
                $result_14 = $x_14;
                $v74 = \Option\value($result_14);
                $result_15 = NULL;
                $value_15 = \Random\nonSeeded()->Next2;
                $x_15 = $value_15 & 0xFF;
                $result_15 = $x_15;
                $v78 = \Option\value($result_15);
                $result_16 = NULL;
                $value_16 = \Random\nonSeeded()->Next2;
                $x_16 = $value_16 & 0xFF;
                $result_16 = $x_16;
                $v82 = \Option\value($result_16);
                $result_17 = NULL;
                $value_17 = \Random\nonSeeded()->Next2;
                $x_17 = $value_17 & 0xFF;
                $result_17 = $x_17;
                $v86 = \Option\value($result_17);
                $result_18 = NULL;
                $value_18 = \Random\nonSeeded()->Next2;
                $x_18 = $value_18 & 0xFF;
                $result_18 = $x_18;
                $v90 = \Option\value($result_18);
                $result_19 = NULL;
                $value_19 = \Random\nonSeeded()->Next2;
                $x_19 = $value_19 & 0xFF;
                $result_19 = $x_19;
                $v94 = \Option\value($result_19);
                $result_20 = NULL;
                $value_20 = \Random\nonSeeded()->Next2;
                $x_20 = $value_20 & 0xFF;
                $result_20 = $x_20;
                $v98 = \Option\value($result_20);
                $result_21 = NULL;
                $value_21 = \Random\nonSeeded()->Next2;
                $x_21 = $value_21 & 0xFF;
                $result_21 = $x_21;
                $v102 = \Option\value($result_21);
                $result_22 = NULL;
                $value_22 = \Random\nonSeeded()->Next2;
                $x_22 = $value_22 & 0xFF;
                $result_22 = $x_22;
                $v106 = \Option\value($result_22);
                $result_23 = NULL;
                $value_23 = \Random\nonSeeded()->Next2;
                $x_23 = $value_23 & 0xFF;
                $result_23 = $x_23;
                return method14(new UH1_UH1_0($v22, new UH1_UH1_0($v26, new UH1_UH1_0($v30, new UH1_UH1_0($v34, new UH1_UH1_0($v38, new UH1_UH1_0($v42, new UH1_UH1_0($v46, new UH1_UH1_0($v50, new UH1_UH1_0($v54, new UH1_UH1_0($v58, new UH1_UH1_0($v62, new UH1_UH1_0($v66, new UH1_UH1_0($v70, new UH1_UH1_0($v74, new UH1_UH1_0($v78, new UH1_UH1_0($v82, new UH1_UH1_0($v86, new UH1_UH1_0($v90, new UH1_UH1_0($v94, new UH1_UH1_0($v98, new UH1_UH1_0($v102, new UH1_UH1_0($v106, new UH1_UH1_0(\Option\value($result_23), new UH1_UH1_1()))))))))))))))))))))))), 23);
            }
        } else {
            $result_24 = NULL;
            $value_24 = \Random\nonSeeded()->Next2;
            $x_24 = $value_24 & 0xFF;
            $result_24 = $x_24;
            $v143 = \Option\value($result_24);
            $result_25 = NULL;
            $value_25 = \Random\nonSeeded()->Next2;
            $x_25 = $value_25 & 0xFF;
            $result_25 = $x_25;
            $v147 = \Option\value($result_25);
            $result_26 = NULL;
            $value_26 = \Random\nonSeeded()->Next2;
            $x_26 = $value_26 & 0xFF;
            $result_26 = $x_26;
            $v151 = \Option\value($result_26);
            $result_27 = NULL;
            $value_27 = \Random\nonSeeded()->Next2;
            $x_27 = $value_27 & 0xFF;
            $result_27 = $x_27;
            $v155 = \Option\value($result_27);
            $result_28 = NULL;
            $value_28 = \Random\nonSeeded()->Next2;
            $x_28 = $value_28 & 0xFF;
            $result_28 = $x_28;
            $v159 = \Option\value($result_28);
            $result_29 = NULL;
            $value_29 = \Random\nonSeeded()->Next2;
            $x_29 = $value_29 & 0xFF;
            $result_29 = $x_29;
            $v163 = \Option\value($result_29);
            $result_30 = NULL;
            $value_30 = \Random\nonSeeded()->Next2;
            $x_30 = $value_30 & 0xFF;
            $result_30 = $x_30;
            $v167 = \Option\value($result_30);
            $result_31 = NULL;
            $value_31 = \Random\nonSeeded()->Next2;
            $x_31 = $value_31 & 0xFF;
            $result_31 = $x_31;
            $v171 = \Option\value($result_31);
            $result_32 = NULL;
            $value_32 = \Random\nonSeeded()->Next2;
            $x_32 = $value_32 & 0xFF;
            $result_32 = $x_32;
            $v175 = \Option\value($result_32);
            $result_33 = NULL;
            $value_33 = \Random\nonSeeded()->Next2;
            $x_33 = $value_33 & 0xFF;
            $result_33 = $x_33;
            $v179 = \Option\value($result_33);
            $result_34 = NULL;
            $value_34 = \Random\nonSeeded()->Next2;
            $x_34 = $value_34 & 0xFF;
            $result_34 = $x_34;
            $v183 = \Option\value($result_34);
            $result_35 = NULL;
            $value_35 = \Random\nonSeeded()->Next2;
            $x_35 = $value_35 & 0xFF;
            $result_35 = $x_35;
            $v187 = \Option\value($result_35);
            $result_36 = NULL;
            $value_36 = \Random\nonSeeded()->Next2;
            $x_36 = $value_36 & 0xFF;
            $result_36 = $x_36;
            $v191 = \Option\value($result_36);
            $result_37 = NULL;
            $value_37 = \Random\nonSeeded()->Next2;
            $x_37 = $value_37 & 0xFF;
            $result_37 = $x_37;
            $v195 = \Option\value($result_37);
            $result_38 = NULL;
            $value_38 = \Random\nonSeeded()->Next2;
            $x_38 = $value_38 & 0xFF;
            $result_38 = $x_38;
            $v199 = \Option\value($result_38);
            $result_39 = NULL;
            $value_39 = \Random\nonSeeded()->Next2;
            $x_39 = $value_39 & 0xFF;
            $result_39 = $x_39;
            $v203 = \Option\value($result_39);
            $result_40 = NULL;
            $value_40 = \Random\nonSeeded()->Next2;
            $x_40 = $value_40 & 0xFF;
            $result_40 = $x_40;
            $v207 = \Option\value($result_40);
            $result_41 = NULL;
            $value_41 = \Random\nonSeeded()->Next2;
            $x_41 = $value_41 & 0xFF;
            $result_41 = $x_41;
            $v211 = \Option\value($result_41);
            $result_42 = NULL;
            $value_42 = \Random\nonSeeded()->Next2;
            $x_42 = $value_42 & 0xFF;
            $result_42 = $x_42;
            $v215 = \Option\value($result_42);
            $result_43 = NULL;
            $value_43 = \Random\nonSeeded()->Next2;
            $x_43 = $value_43 & 0xFF;
            $result_43 = $x_43;
            $v219 = \Option\value($result_43);
            $result_44 = NULL;
            $value_44 = \Random\nonSeeded()->Next2;
            $x_44 = $value_44 & 0xFF;
            $result_44 = $x_44;
            $v223 = \Option\value($result_44);
            $result_45 = NULL;
            $value_45 = \Random\nonSeeded()->Next2;
            $x_45 = $value_45 & 0xFF;
            $result_45 = $x_45;
            $v227 = \Option\value($result_45);
            $result_46 = NULL;
            $value_46 = \Random\nonSeeded()->Next2;
            $x_46 = $value_46 & 0xFF;
            $result_46 = $x_46;
            return method14(new UH1_UH1_0($v143, new UH1_UH1_0($v147, new UH1_UH1_0($v151, new UH1_UH1_0($v155, new UH1_UH1_0($v159, new UH1_UH1_0($v163, new UH1_UH1_0($v167, new UH1_UH1_0($v171, new UH1_UH1_0($v175, new UH1_UH1_0($v179, new UH1_UH1_0($v183, new UH1_UH1_0($v187, new UH1_UH1_0($v191, new UH1_UH1_0($v195, new UH1_UH1_0($v199, new UH1_UH1_0($v203, new UH1_UH1_0($v207, new UH1_UH1_0($v211, new UH1_UH1_0($v215, new UH1_UH1_0($v219, new UH1_UH1_0($v223, new UH1_UH1_0($v227, new UH1_UH1_0(\Option\value($result_46), new UH1_UH1_1()))))))))))))))))))))))), 23);
        }
    }
}

#133
function closure81($unitVar, $v0_1) {
    $v1_1 = NULL;
    $console->log;
    $v5 = NULL;
    $console->log;
    return 0;
}

#134
$GLOBALS['v0'] = function ($v) use ($closure0) { return closure0(NULL, $v);
 };

#135
function rotate_numbers($x) {
    return $GLOBALS['v0']($x);
}

#136
$GLOBALS['v1'] = function ($v) use ($closure3) { return closure3(NULL, $v);
 };

#137
function create_sequential_roller($x) {
    return $GLOBALS['v1']($x);
}

#138
$GLOBALS['v2'] = function ($v) use ($closure10) { return closure10(NULL, $v);
 };

#139
function roll_progressively($x) {
    return $GLOBALS['v2']($x);
}

#140
$GLOBALS['v3'] = function ($v) use ($closure78) { return closure78(NULL, $v);
 };

#141
function roll_within_bounds($x) {
    return $GLOBALS['v3']($x);
}

#142
$GLOBALS['v4'] = function ($v) use ($closure81) { return closure81(NULL, $v);
 };

#143
function main($args) {
    return $GLOBALS['v4']($args);
}

