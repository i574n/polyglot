<?php
namespace Polyglot\dice_fsharp;

require_once(__FABLE_LIBRARY__.'/List.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/Random.php');
require_once(__FABLE_LIBRARY__.'/Seq.php');
require_once(__FABLE_LIBRARY__.'/String.php');
require_once(__ROOT__.'/../../../../../lib/fsharp/Common.fs.php');

#0
$GLOBALS['sixthPowerSequence'] = \Seq\cache(\Seq\unfold(function ($state) { return [ $state, $state * 6 ];
 }, 1));

#1
function accumulateDiceRolls($log, $rolls, $power, $acc) {
    if ($power < 0) {
        \Seq\iterate((function ($arg) {         return function ($func) use ($arg) {         return $func($arg);
 };
 })(NULL), \Option\toArray($log));
        return [ $acc + 1, $rolls ];
    } else {
        if (!\FSharpList\isEmpty($rolls)) {
            if (\FSharpList\head($rolls) > 1) {
                $rest_1 = \FSharpList\tail($rolls);
                $roll_1 = \FSharpList\head($rolls);
                $value = ($roll_1 - 1) * \Seq\item($power, $GLOBALS['sixthPowerSequence']);
                \Seq\iterate((function ($arg_1) {                 return function ($func_1) use ($arg_1) {                 return $func_1($arg_1);
 };
 })(NULL), \Option\toArray($log));
                return accumulateDiceRolls($log, $rest_1, $power - 1, $acc + $value);
            } else {
                $rest_2 = \FSharpList\tail($rolls);
                $roll_2 = \FSharpList\head($rolls);
                \Seq\iterate((function ($arg_2) {                 return function ($func_2) use ($arg_2) {                 return $func_2($arg_2);
 };
 })(NULL), \Option\toArray($log));
                return accumulateDiceRolls($log, $rest_2, $power - 1, $acc);
            }
        } else {
            return NULL;
        }
    }
}

#2
function rollWithinBounds($log, $max, $rolls) {
    $matchValue = accumulateDiceRolls($log, $rolls, \FSharpList\length($rolls) - 1, 0);
    if (!is_null($matchValue)) {
        if ((function ($result) use ($max) {         if ($result >= 1) {
            return $result <= $max;
        } else {
            return false;
        }
 })($matchValue[0])) {
            $result_1 = $matchValue[0];
            return $result_1;
        } else {
            return NULL;
        }
    } else {
        return NULL;
    }
}

#3
$GLOBALS['random'] = \Random\nonSeeded();

#4
function rollDice($unitVar) {
    return $GLOBALS['random']->Next2;
}

#5
function rotateNumber($max, $n) {
    return ($n - 1 + $max) % $max + 1;
}

#6
function rotateNumbers($max, $items) {
    return \Seq\map(function ($n) use ($max, $rotateNumber) {     return rotateNumber($max, $n);
 }, $items);
}

#7
function createSequentialRoller($list) {
    $currentIndex = 0;
    return function ($unitVar) use ($list, &$currentIndex) { 
        $matchValue = \FSharpList\tryItem($currentIndex, $list);
        if (is_null($matchValue)) {
            throw new \Exception('createSequentialRoller / End of list');
        } else {
            $item = $matchValue;
            $currentIndex = $currentIndex + 1;
            return $item;
        }
    };
}

#8
function rollProgressively($log, $roll, $reroll, $max) {
    $power = (function ($max_1) use ($log) { 
        $loop = function ($n, $p) use ($log, $max_1, &$loop) {         if ($p < $max_1) {
            return $loop($n + 1, $p * 6);
        } else {
            \Seq\iterate((function ($arg) {             return function ($func) use ($arg) {             return $func($arg);
 };
 })(NULL), \Option\toArray($log));
            return $n;
        }
 };
        if ($max_1 === 1) {
            return 1;
        } else {
            return $loop(0, 1);
        }
    })($max) - 1;
    $loop_1 = function ($rolls, $size) use ($accumulateDiceRolls, $log, $max, $power, $reroll, $roll, &$loop_1) {     if ($size < $power + 1) {
        return $loop_1(\FSharpList\cons($roll(NULL), $rolls), $size + 1);
    } else {
        $matchValue = accumulateDiceRolls($log, $rolls, $power, 0);
        if (!is_null($matchValue)) {
            if ($matchValue[0] <= $max) {
                $result_1 = $matchValue[0];
                return $result_1;
            } else {
                if ($reroll) {
                    return $loop_1(\FSharpList\initialize($power, function ($_arg) use ($roll) {                     return $roll(NULL);
 }), $power);
                } else {
                    return $loop_1(\FSharpList\cons($roll(NULL), $rolls), $size + 1);
                }
            }
        } else {
            if ($reroll) {
                return $loop_1(\FSharpList\initialize($power, function ($_arg) use ($roll) {                 return $roll(NULL);
 }), $power);
            } else {
                return $loop_1(\FSharpList\cons($roll(NULL), $rolls), $size + 1);
            }
        }
    }
 };
    return $loop_1(\FSharpList\_empty(), 0);
}

#9
function main($args) {
    $result = rollProgressively((function ($clo) {     return function ($arg) use ($clo) {     return $clo($arg);
 };
 })(\String\toConsole(\String\printf('%s'))), function ($arg00_0040) use ($rollDice) {     return rollDice(NULL);
 }, true, ~~~~~~2147483647 / 10);
    \Common\trace(new \Polyglot.Common\TraceLevel_Debug(), function ($unitVar) {     return NULL;
 }, function ($arg00_0040_1) {     return '';
 });
    return 0;
}

