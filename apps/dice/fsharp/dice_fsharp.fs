#if !INTERACTIVE
namespace Polyglot
#endif

module dice_fsharp =

    open Common

    /// ## sixthPowerSequence

    let sixthPowerSequence = 1 |> Seq.unfold (fun state -> Some (state, state * 6)) |> Seq.cache

    /// ## accumulateDiceRolls

    let rec accumulateDiceRolls log rolls power acc =
        match rolls with
        | _ when power < 0 ->
            log |> Option.iter ((|>) $"accumulateDiceRolls / power: {power} / acc: {acc}")
            Some (acc + 1, rolls)
        | [] -> None
        | roll :: rest when roll > 1 ->
            let coeff = sixthPowerSequence |> Seq.item power
            let value = (roll - 1) * coeff
            log |> Option.iter ((|>) $"accumulateDiceRolls / \
                power: {power} / acc: {acc} / roll: {roll} / value: {value}"
            )
            accumulateDiceRolls log rest (power - 1) (acc + value)
        | roll :: rest ->
            log |> Option.iter ((|>) $"accumulateDiceRolls / power: {power} / acc: {acc} / roll: {roll}")
            accumulateDiceRolls log rest (power - 1) acc

    /// ## rollWithinBounds

    let rollWithinBounds log max rolls =
        let power = List.length rolls - 1
        match accumulateDiceRolls log rolls power 0 with
        | Some (result, _) when result >= 1 && result <= max -> Some result
        | _ -> None

    /// ## calculateDiceCount

    let inline calculateDiceCount log max =
        let rec loop n p =
            if p < max
            then loop (n + 1) (p * 6)
            else
                log |> Option.iter ((|>) $"calculateDiceCount / max: {max} / n: {n} / p: {p}")
                n
        if max = 1
        then 1
        else loop 0 1

    /// ## rollDice

#if FABLE_COMPILER_RUST
    let rollDice () : int =
#if !WASM
        Fable.Core.RustInterop.emitRustExpr () "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
#else
        1
#endif
#else
    let private random = System.Random ()
    let rollDice () =
        random.Next (1, 7)
#endif

    /// ## rotateNumber

    let rotateNumber max n =
        (n - 1 + max) % max + 1

    /// ## rotateNumbers

    let rotateNumbers max items =
        items |> Seq.map (rotateNumber max)

    /// ## createSequentialRoller

    let createSequentialRoller list =
        let mutable currentIndex = 0
        fun () ->
            match list |> List.tryItem currentIndex with
            | Some item ->
                currentIndex <- currentIndex + 1
                item
            | None ->
                failwith "createSequentialRoller / End of list"

    /// ## rollProgressively

    let rollProgressively log roll reroll max =
        let power = (calculateDiceCount log max) - 1
        let rec loop rolls size =
            if size < power + 1
            then loop (roll () :: rolls) (size + 1)
            else
                match accumulateDiceRolls log rolls power 0 with
                | Some (result, _) when result <= max -> result
                | _ when reroll -> loop (List.init power (fun _ -> roll ())) power
                | _ -> loop (roll () :: rolls) (size + 1)
        loop [] 0

    /// ## main

    let main args =
        let result = rollProgressively (Some (printfn "%s")) rollDice true (System.Int32.MaxValue / 10)
        trace Debug (fun () -> $"main / result: {result}") getLocals
        0
