namespace Polyglot.FSharp

open System.Collections
open System.Linq
open System.Text

module Model =
    type TestCaseResult =
        { Input: string
          Expected: string
          Result: string }
    
    type IChallenge =
        abstract member Run: unit -> seq<TestCaseResult>
        
    [<AbstractClass>]
    type Challenge<'TInput, 'TExpected> () =
        
        abstract member TestCases: unit -> seq<'TInput * 'TExpected>
        abstract member Invoke: 'TInput -> 'TExpected
        
        interface IChallenge with
            member this.Run () =
                this.TestCases ()
                |> Seq.toArray
                |> Array.Parallel.map (fun (input, expected) ->
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
                )
                |> Array.toSeq

module Challenges =
    
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
            
            
    let challenges : Model.IChallenge list = [
        Empty.Challenge ()
        ReturnLettersWithOddCount.Challenge ()
        HasAnyPairCloseToEachother.Challenge ()
    ]

