namespace Polyglot.FSharp

open System
open System.Collections
open System.Diagnostics
open System.Linq
open System.Text

module Model =
    type TestCaseResult =
        { Input: string
          Expected: string
          Result: string }
    
    type IChallenge =
        abstract member Run: unit -> seq<TestCaseResult>
        abstract member ParallelRun: unit -> seq<TestCaseResult>
        
    [<AbstractClass>]
    type Challenge<'TInput, 'TExpected> () =
        
        abstract member TestCases: unit -> seq<'TInput * 'TExpected>
        abstract member Invoke: 'TInput -> 'TExpected
        
        member this.Process (input, expected) =
            let inputStr =
                match box input with
                | :? ICollection as input -> 
                    input.Cast<obj> ()
                    |> Seq.map string
                    |> String.concat ","
                | _ -> input.ToString ()
                
            let result = this.Invoke input
            
            { Input = inputStr
              Expected = expected.ToString ()
              Result = result.ToString () }
        
        interface IChallenge with
            member this.Run () =
                this.TestCases ()
                |> Seq.toArray
                |> Array.map this.Process
                |> Array.toSeq
                
            member this.ParallelRun () =
                this.TestCases ()
                |> Seq.toArray
                |> Array.Parallel.map this.Process
                |> Array.toSeq
                
    [<AbstractClass>]
    type PerformanceChallenge<'TInput, 'TExpected> () =
        inherit Challenge<'TInput, 'TExpected> ()
        
        let stopwatch = Stopwatch ()
        do stopwatch.Start ()
        
        member _.PerformanceInvoke testName (fn: 'TInput -> 'T) (input: 'TInput) =
            let time1 = stopwatch.ElapsedMilliseconds
            
            let result = 
                [| 0 .. 2000000 |]
                |> Array.Parallel.map (fun _ ->
                    fn input
                )
                |> Array.head
                    
            let time2 = stopwatch.ElapsedMilliseconds - time1
            printfn "Test case %d. Time: %A" testName time2
            
            result
        
                
module PerformanceChallenges =
    /// UniqueLetters
    module UniqueLetters =
(*
Solution:
Test case 1. Time: 1605L
Test case 2. Time: 2016L
Test case 3. Time: 2330L
Test case 4. Time: 1641L
Test case 5. Time: 1588L
Test case 6. Time: 1541L
Test case 7. Time: 1508L
Solution:
Test case 1. Time: 1830L
Test case 2. Time: 2301L
Test case 3. Time: 2540L
Test case 4. Time: 1852L
Test case 5. Time: 1779L
Test case 6. Time: 1868L
Test case 7. Time: 1592L
Solution:
Test case 1. Time: 2037L
Test case 2. Time: 2667L
Test case 3. Time: 2625L
Test case 4. Time: 1846L
Test case 5. Time: 2026L
Test case 6. Time: 1837L
Test case 7. Time: 1814L
Solution:
Test case 1. Time: 14876L
Test case 2. Time: 13843L
Test case 3. Time: 10535L
Test case 4. Time: 7306L
Test case 5. Time: 6997L
Test case 6. Time: 7342L
Test case 7. Time: 7269L
*)
        let solutions = [|
            fun input ->
                input
                |> Seq.toList
                |> List.fold (fun acc x -> if List.contains x acc then acc else acc @ [ x ]) []
                |> Seq.toArray
                |> String
                
            fun input ->
                input
                |> Seq.rev
                |> fun list -> Seq.foldBack (fun x acc -> if List.contains x acc then acc else x :: acc) list []
                |> Seq.rev
                |> Seq.toArray
                |> String
                
            fun input ->
                input
                |> Seq.rev
                |> fun list -> Seq.foldBack (fun x (set, acc) -> if Set.contains x set then set, acc else set.Add x, x :: acc) list (Set.ofList [], [])
                |> snd
                |> Seq.rev
                |> Seq.toArray
                |> String
                
            fun input ->
                input
                |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, Array.append acc [| x |]) (Set.ofList [], [||])
                |> snd
                |> String
                
            fun input ->
                input
                |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, x :: acc) (Set.ofList [], [])
                |> snd
                |> List.rev
                |> List.toArray
                |> String
                
            fun input ->
                input
                |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, acc @ [ x ]) (Set.ofList [], [])
                |> snd
                |> List.toArray
                |> String
                
            fun input ->
                input
                |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, x :: acc) (Set.ofList [], [])
                |> snd
                |> List.toArray
                |> Array.rev
                |> String
        |]
            
        let testCases = seq {
            "abc", "abc"
            "accabb", "acb"
            "pprrqqpp", "prq"
            "aaaaaaaaaaaaaaccccccabbbbbbbaaacccbbbaaccccccccccacbbbbbbbbbbbbbcccccccbbbbbbbb", "acb"
        }
        
        type Challenge () =
            inherit Model.PerformanceChallenge<string, string> ()
            override _.TestCases () = testCases
            override this.Invoke input =
                solutions
                |> fun solutions -> printfn "Solution:"; solutions
                |> Array.mapi (fun i solution -> this.PerformanceInvoke (i + 1) (fun x -> solution x) input)
                |> Array.head

module Challenges =
    
    /// Empty3
    module Empty3 =
        let solution a b =
            a
            
        let testCases = seq {
            ("a", "a"), "a"
            ("a", "a"), "a"
        }
        
        type Challenge () =
            inherit Model.Challenge<string * string, string> ()
            override _.TestCases () = testCases
            override _.Invoke input =
                let a, b = input
                solution a b
                
    /// Empty2
    module Empty2 =
        let solution a b =
            a
            
        let testCases = seq {
            ("a", "a"), "a"
            ("a", "a"), "a"
        }
        
        type Challenge () =
            inherit Model.Challenge<string * string, string> ()
            override _.TestCases () = testCases
            override _.Invoke input =
                let a, b = input
                solution a b
            
    /// Empty
    module Empty =
        let solution n =
            n
            
        let testCases = seq {
            0, 0
            2, 2
            5, 5
        }
        
        type Challenge () =
            inherit Model.Challenge<int, int> ()
            override _.TestCases () = testCases
            override _.Invoke input = solution input
        
        
    /// Return letters with odd count
    module ReturnLettersWithOddCount =
        let solution n =
            let mutable _builder = StringBuilder (new string('a', n))
            if n % 2 = 0 then
                _builder.[0] <- 'b'
                
            _builder.ToString ()
            
        let testCases = seq {
            1, "a"
            2, "ba"
            3, "aaa"
            9, "aaaaaaaaa"
            10, "baaaaaaaaa"
        }
        
        type Challenge () =
            inherit Model.Challenge<int, string> ()
            override _.TestCases () = testCases
            override _.Invoke input = solution input

    
    /// Has any pair that are close to eachother
    module HasAnyPairCloseToEachother =
        let solution (a: int[]) =
            let indices = Enumerable.Range(0, a.Length).ToArray ()
            System.Array.Sort (a, indices)
            
            indices
            |> Array.take (a.Length - 1)
            |> Array.exists (fun i -> a.[i + 1] - a.[i] = 1)
        
        let testCases = seq {
            [| 0 |], false
            [| 1; 2 |], true
            [| 3; 5 |], false
            [| 3; 4; 6 |], true
            [| 2; 4; 6 |], false
        }
        
        type Challenge () =
            inherit Model.Challenge<int[], bool> ()
            override _.TestCases () = testCases
            override _.Invoke input = solution input
            
module ChallengeList =
            
    let challenges : Model.IChallenge list = [
        Challenges.Empty3.Challenge ()
//        Empty2.Challenge ()
//        Empty.Challenge ()
//        ReturnLettersWithOddCount.Challenge ()
//        HasAnyPairCloseToEachother.Challenge ()
    ]

    let performanceChallenge : Model.IChallenge =
        PerformanceChallenges.UniqueLetters.Challenge () :> Model.IChallenge
//        Empty2.Challenge ()
//        Empty.Challenge ()
//        ReturnLettersWithOddCount.Challenge ()
//        HasAnyPairCloseToEachother.Challenge ()

