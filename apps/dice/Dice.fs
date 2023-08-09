#if !INTERACTIVE
namespace Polyglot
#endif

module Dice =

    open Common

    /// ## pow6

    let pow6 = 1 |> Seq.unfold (fun state -> Some (state, state * 6)) |> Seq.cache

    /// ## rollAcc

    let rec rollAcc log rolls power acc =
        match rolls with
        | _ when power < 0 ->
            if log then printfn $"rollAcc / power: {power} / acc: {acc}"
            Some (acc + 1, rolls)
        | [] -> None
        | roll :: rest when roll > 1 ->
            let coeff = pow6 |> Seq.item power
            let value = (roll - 1) * coeff
            if log then printfn $"rollAcc / power: {power} / acc: {acc} / roll: {roll} / value: {value}"
            rollAcc log rest (power - 1) (acc + value)
        | roll :: rest ->
            if log then printfn $"rollAcc / power: {power} / acc: {acc} / roll: {roll}"
            rollAcc log rest (power - 1) acc

    /// ## fixedRoll

    let fixedRoll log max rolls =
        let rec rollMax power =
            match rollAcc log rolls power 0 with
            | Some (result, _) when result >= 1 && result <= max -> Some result
            | _ -> None

        rollMax (List.length rolls - 1)

    /// ## numDices

    let numDices log max =
        let rec numDices' n p =
            if log then printfn $"numDices / max: {max} / n: {n} / p: {p}"
            if p >= max
            then n
            else numDices' (n + 1) (p * 6)
        if max = 1
        then 1
        else numDices' 0 1

    /// ## progressiveRoll

#if FABLE_COMPILER_RUST
    let rollD6 () : int =
#if CHAIN
        Fable.Core.Rust.emitExpr () "1"
#else
        Fable.Core.Rust.emitExpr () "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
#endif
#else
    let private random = System.Random ()
    let rollD6 () =
        random.Next (1, 7)
#endif

    /// ## progressiveRoll

    let progressiveRoll log reroll max =
        let rec rollMax power =
            let rec loop rolls size =
                if size < power + 1
                then loop (rollD6 () :: rolls) (size + 1)
                else
                    match rollAcc log rolls power 0 with
                    | Some (result, _) when result <= max -> result
                    | _ when reroll -> loop (List.init power (fun _ -> rollD6 ())) power
                    | _ -> loop (rollD6 () :: rolls) (size + 1)
            loop [] 0
        rollMax ((numDices log max) - 1)

    /// ## main

    [<EntryPoint>]
    let main args =
        let result = fixedRoll true 2000 [1; 5; 4; 4; 5]
        trace Debug (fun () -> $"main / result: {result |> Option.defaultValue -1}") getLocals
        0
