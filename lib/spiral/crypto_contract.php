<?php
namespace Crypto;

require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/Util.php');

use \IComparable;

#0
class ICryptoCreateHash {
}

#1
class Mut0 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return 'Int32';
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
function method0($v0_1, $v1) {
    return $v1->l0 < $v0_1;
}

#3
function closure0($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#4
$GLOBALS['v0'] = function ($v) use ($closure0) { return closure0(NULL, $v);
 };

#5
function hash_text($x) {
    return $GLOBALS['v0']($x);
}

#6

