namespace Polyglot.FSharp

open System
open System.Collections
open System.Collections.Generic
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
        
        member _.PerformanceInvoke (fn: 'TInput -> 'T) (input: 'TInput) =
            let time1 = stopwatch.ElapsedMilliseconds
            
            let result = 
                [| 0 .. 2000000 |]
                |> Array.Parallel.map (fun _ ->
                    fn input
                )
                |> Array.head
                    
            let time2 = stopwatch.ElapsedMilliseconds - time1
            
            result, time2
        
                
module PerformanceChallenges =
    /// UniqueLetters
    module UniqueLetters =
(*
Solution: abc
Test case 1. A. Time: 1501L
Test case 2. B. Time: 1912L
Test case 3. C. Time: 2132L
Test case 4. D. Time: 1542L
Test case 5. E. Time: 1447L
Test case 6. F. Time: 1494L
Test case 7. G. Time: 1440L
Test case 8. H. Time: 1250L

Solution: accabb
Test case 1. A. Time: 1937L
Test case 2. B. Time: 2396L
Test case 3. C. Time: 2468L
Test case 4. D. Time: 1676L
Test case 5. E. Time: 1786L
Test case 6. F. Time: 1777L
Test case 7. G. Time: 1609L
Test case 8. H. Time: 1313L

Solution: pprrqqpp
Test case 1. A. Time: 2138L
Test case 2. B. Time: 2734L
Test case 3. C. Time: 2575L
Test case 4. D. Time: 1918L
Test case 5. E. Time: 1924L
Test case 6. F. Time: 2127L
Test case 7. G. Time: 1735L
Test case 8. H. Time: 1431L

Solution: aaaaaaaaaaaaaaccccccabbbbbbbaaacccbbbaaccccccccccacbbbbbbbbbbbbbcccccccbbbbbbbb
Test case 1. A. Time: 14175L
Test case 2. B. Time: 11819L
Test case 3. C. Time: 8308L
Test case 4. D. Time: 5473L
Test case 5. E. Time: 5723L
Test case 6. F. Time: 5595L
Test case 7. G. Time: 5904L
Test case 8. H. Time: 2091L
*)
        let solutions = [
            "A",
            fun input ->
                input
                |> Seq.toList
                |> List.fold (fun acc x -> if List.contains x acc then acc else acc @ [ x ]) []
                |> Seq.toArray
                |> String
                
            "B",
            fun input ->
                input
                |> Seq.rev
                |> fun list -> Seq.foldBack (fun x acc -> if List.contains x acc then acc else x :: acc) list []
                |> Seq.rev
                |> Seq.toArray
                |> String
                
            "C",
            fun input ->
                input
                |> Seq.rev
                |> fun list -> Seq.foldBack (fun x (set, acc) -> if Set.contains x set then set, acc else set.Add x, x :: acc) list (Set.ofList [], [])
                |> snd
                |> Seq.rev
                |> Seq.toArray
                |> String
                
            "D",
            fun input ->
                input
                |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, Array.append acc [| x |]) (Set.ofList [], [||])
                |> snd
                |> String
                
            "E",
            fun input ->
                input
                |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, x :: acc) (Set.ofList [], [])
                |> snd
                |> List.rev
                |> List.toArray
                |> String
                
            "F",
            fun input ->
                input
                |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, acc @ [ x ]) (Set.ofList [], [])
                |> snd
                |> List.toArray
                |> String
                
            "G",
            fun input ->
                input
                |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, x :: acc) (Set.ofList [], [])
                |> snd
                |> List.toArray
                |> Array.rev
                |> String
                
            "H",
            fun input ->
                input
                |> Seq.distinct
                |> Seq.toArray
                |> String
        ]
            
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
                printfn "\nSolution: %s" input
                
                solutions
                |> List.mapi (fun i (testName, solution) ->
                    let fn x =
                        solution x
                    let result, time = this.PerformanceInvoke fn input
                    printfn "Test case %d. %s. Time: %A" (i + 1) testName time
                    result
                )
                |> function
                    | [] | [ _ ] as x -> x
                    | (head :: tail) as x when tail |> List.forall ((=) head) -> x
                    | x -> failwithf "Challenge error: %A" x
                |> List.head

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

