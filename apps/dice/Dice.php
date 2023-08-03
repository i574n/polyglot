<?php
namespace Polyglot\Dice;

require_once(__FABLE_LIBRARY__.'/List.php');
require_once(__FABLE_LIBRARY__.'/Random.php');
require_once(__FABLE_LIBRARY__.'/Seq.php');
require_once(__FABLE_LIBRARY__.'/String.php');
require_once(__ROOT__.'/../../../../../nbs/Common.fs.php');

#0
$GLOBALS['pow6'] = \Seq\cache(\Seq\unfold(function ($state) { return [ $state, $state * 6 ];
 }, 1));

#1
function rollAcc($log, $rolls, $power, $acc) {
    if ($power < 0) {
        if ($log) {
            \String\toConsole(NULL);
        } else {
        }
        return [ $acc + 1, $rolls ];
    } else {
        if (!\FSharpList\isEmpty($rolls)) {
            if (\FSharpList\head($rolls) > 1) {
                $rest_1 = \FSharpList\tail($rolls);
                $roll_1 = \FSharpList\head($rolls);
                $value = ($roll_1 - 1) * \Seq\item($power, $GLOBALS['pow6']);
                if ($log) {
                    \String\toConsole(NULL);
                } else {
                }
                return rollAcc($log, $rest_1, $power - 1, $acc + $value);
            } else {
                $rest_2 = \FSharpList\tail($rolls);
                $roll_2 = \FSharpList\head($rolls);
                if ($log) {
                    \String\toConsole(NULL);
                } else {
                }
                return rollAcc($log, $rest_2, $power - 1, $acc);
            }
        } else {
            return NULL;
        }
    }
}

#2
function fixedRoll($log, $max, $rolls) {
    $matchValue = rollAcc($log, $rolls, \FSharpList\length($rolls) - 1, 0);
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
function numDices($log, $max) {
    $numDices_0027 = function ($n, $p) use ($log, $max, &$numDices_0027) { 
        if ($log) {
            \String\toConsole(NULL);
        } else {
        }
        if ($p >= $max) {
            return $n;
        } else {
            return $numDices_0027($n + 1, $p * 6);
        }
    };
    if ($max === 1) {
        return 1;
    } else {
        return $numDices_0027(0, 1);
    }
}

#4
$GLOBALS['random'] = \Random\nonSeeded();

#5
function rollD6($unitVar) {
    return $GLOBALS['random']->Next2;
}

#6
function progressiveRoll($log, $reroll, $max) {
    $power = numDices($log, $max) - 1;
    $loop = function ($rolls, $size) use ($log, $max, $power, $reroll, $rollAcc, $rollD6, &$loop) {     if ($size < $power + 1) {
        return $loop(\FSharpList\cons(rollD6(NULL), $rolls), $size + 1);
    } else {
        $matchValue = rollAcc($log, $rolls, $power, 0);
        if (!is_null($matchValue)) {
            if ($matchValue[0] <= $max) {
                $result_1 = $matchValue[0];
                return $result_1;
            } else {
                if ($reroll) {
                    return $loop(\FSharpList\initialize($power, function ($_arg) use ($rollD6) {                     return rollD6(NULL);
 }), $power);
                } else {
                    return $loop(\FSharpList\cons(rollD6(NULL), $rolls), $size + 1);
                }
            }
        } else {
            if ($reroll) {
                return $loop(\FSharpList\initialize($power, function ($_arg) use ($rollD6) {                 return rollD6(NULL);
 }), $power);
            } else {
                return $loop(\FSharpList\cons(rollD6(NULL), $rolls), $size + 1);
            }
        }
    }
 };
    return $loop(\FSharpList\_empty(), 0);
}

#7
function main($args) {
    $result = fixedRoll(true, 2000, \FSharpList\cons(1, \FSharpList\cons(5, \FSharpList\cons(4, \FSharpList\cons(4, \FSharpList\cons(5, \FSharpList\_empty()))))));
    \Common\trace(new \Polyglot.Common\TraceLevel_Debug(), function ($unitVar) {     return NULL;
 }, function ($arg00_0040) {     return '';
 });
    return 0;
}

