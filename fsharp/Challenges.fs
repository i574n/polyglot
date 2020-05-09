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
          Result: string
          TimeList: int64 list }
    
    type IChallenge =
        abstract member Run: unit -> seq<TestCaseResult>
        
    [<AbstractClass>]
    type Challenge<'TInput, 'TExpected when 'TExpected : equality> () =
        let stopwatch = Stopwatch ()
        do stopwatch.Start ()
        
        let performanceInvoke (fn: unit -> 'T) =
            let time1 = stopwatch.ElapsedMilliseconds
            
            let result = 
                [| 0 .. 2000000 |]
                |> Array.Parallel.map (fun _ ->
                    fn ()
                )
                |> Array.head
                    
            let time2 = stopwatch.ElapsedMilliseconds - time1
            
            result, time2
            
            
        abstract member Solutions: (string * ('TInput -> 'TExpected)) list
        abstract member TestCases: seq<'TInput * 'TExpected>
        interface IChallenge with
            member this.Run () =
                this.TestCases
                |> Seq.toArray
                |> (if this.Solutions.Length > 1 then Array.map else Array.Parallel.map) this.Process
                |> Array.toSeq
        
        member this.Process (input, expected) =
            let inputStr =
                match box input with
                | :? ICollection as input -> 
                    input.Cast<obj> ()
                    |> Seq.map string
                    |> String.concat ","
                | _ -> input.ToString ()
                
            printfn "\nSolution: %s" inputStr
            
            let results = 
                this.Solutions
                |> List.mapi (fun i (testName, solution) ->
                    let result, time = performanceInvoke (fun () -> solution input)
                    printfn "Test case %d. %s. Time: %A" (i + 1) testName time
                    result, time
                )
                |> function
                    | [] | [ _ ] as x -> x
                    | (head :: tail) as x when tail |> List.forall ((=) head) -> x
                    | x -> failwithf "Challenge error: %A" x
                
            { Input = inputStr
              Expected = expected.ToString ()
              Result = results.Head.ToString ()
              TimeList = results |> List.map snd }
                
                
module Challenges =
    module Empty3 =
        type Challenge () =
            inherit Model.Challenge<string * string, string> ()
            
            override _.Solutions = [
                "A",
                fun (a, _b) ->
                    a
            ]
            
            override _.TestCases = seq {
                ("a", "a"), "a"
                ("a", "a"), "a"
            }
            
                
                
    module Empty2 =
        type Challenge () =
            inherit Model.Challenge<string * string, string> ()
            
            override _.Solutions = [
                "A",
                fun (a, _b) ->
                    a
            ]
            
            override _.TestCases = seq {
                ("a", "a"), "a"
                ("a", "a"), "a"
            }
            
            
    module Empty =
        type Challenge () =
            inherit Model.Challenge<int, int> ()
            
            override _.Solutions = [
                "A",
                fun n ->
                    n
            ]
            
            override _.TestCases = seq {
                0, 0
                2, 2
                5, 5
            }
            
        
    module UniqueLetters =
        type Challenge () =
            inherit Model.Challenge<string, string> ()
            
            override _.Solutions = [
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
                    |> fun list -> Seq.foldBack (fun x (set, acc) -> if Set.contains x set then set, acc else set.Add x, x :: acc) list (Set.empty, [])
                    |> snd
                    |> Seq.rev
                    |> Seq.toArray
                    |> String
                    
                "D",
                fun input ->
                    input
                    |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, Array.append acc [| x |]) (Set.empty, [||])
                    |> snd
                    |> String
                    
                "E",
                fun input ->
                    input
                    |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, x :: acc) (Set.empty, [])
                    |> snd
                    |> List.rev
                    |> List.toArray
                    |> String
                    
                "F",
                fun input ->
                    input
                    |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, acc @ [ x ]) (Set.empty, [])
                    |> snd
                    |> List.toArray
                    |> String
                    
                "G",
                fun input ->
                    input
                    |> Seq.fold (fun (set, acc) x -> if Set.contains x set then set, acc else set.Add x, x :: acc) (Set.empty, [])
                    |> snd
                    |> List.toArray
                    |> Array.rev
                    |> String
                    
                "H",
                fun input ->
                    input
                    |> Seq.toList
                    |> fun list ->
                        let rec loop set = function
                            | head :: tail when Set.contains head set -> loop set tail
                            | head :: tail -> (loop (set.Add head) tail) @ [ head ]
                            | [] -> []
                        loop Set.empty list
                        |> List.rev
                    |> List.toArray
                    |> String
                    
                "I",
                fun input ->
                    input
                    |> Seq.toList
                    |> fun list ->
                        let rec loop set = function
                            | head :: tail when Set.contains head set -> loop set tail
                            | head :: tail -> loop (set.Add head) tail |> Array.append [| head |]
                            | [] -> [||]
                        loop Set.empty list
                    |> String
                    
                "J",
                fun input ->
                    input
                    |> Seq.toList
                    |> fun list ->
                        let rec loop set = function
                            | head :: tail when Set.contains head set -> loop set tail
                            | head :: tail -> head :: loop (set.Add head) tail
                            | [] -> []
                        loop Set.empty list
                    |> List.toArray
                    |> String
                    
                "K",
                fun input ->
                    input
                    |> Seq.distinct
                    |> Seq.toArray
                    |> String
            ]
            
            override _.TestCases = seq {
                "abc", "abc"
                "accabb", "acb"
                "pprrqqpp", "prq"
                "aaaaaaaaaaaaaaccccccabbbbbbbaaacccbbbaaccccccccccacbbbbbbbbbbbbbcccccccbbbbbbbb", "acb"
            }
(*
Solution: abc
Test case 1. A. Time: 1635L
Test case 2. B. Time: 2036L
Test case 3. C. Time: 2124L
Test case 4. D. Time: 1512L
Test case 5. E. Time: 1408L
Test case 6. F. Time: 1501L
Test case 7. G. Time: 1475L
Test case 8. H. Time: 1460L
Test case 9. I. Time: 1502L
Test case 10. J. Time: 1298L
Test case 11. K. Time: 1278L

Solution: accabb
Test case 1. A. Time: 1849L
Test case 2. B. Time: 2175L
Test case 3. C. Time: 2350L
Test case 4. D. Time: 1749L
Test case 5. E. Time: 1568L
Test case 6. F. Time: 1674L
Test case 7. G. Time: 1669L
Test case 8. H. Time: 1709L
Test case 9. I. Time: 1677L
Test case 10. J. Time: 1463L
Test case 11. K. Time: 1306L

Solution: pprrqqpp
Test case 1. A. Time: 1997L
Test case 2. B. Time: 2554L
Test case 3. C. Time: 2629L
Test case 4. D. Time: 1774L
Test case 5. E. Time: 1771L
Test case 6. F. Time: 1783L
Test case 7. G. Time: 1701L
Test case 8. H. Time: 1900L
Test case 9. I. Time: 1900L
Test case 10. J. Time: 1649L
Test case 11. K. Time: 1294L

Solution: aaaaaaaaaaaaaaccccccabbbbbbbaaacccbbbaaccccccccccacbbbbbbbbbbbbbcccccccbbbbbbbb
Test case 1. A. Time: 13221L
Test case 2. B. Time: 10843L
Test case 3. C. Time: 7877L
Test case 4. D. Time: 5281L
Test case 5. E. Time: 4974L
Test case 6. F. Time: 5766L
Test case 7. G. Time: 5410L
Test case 8. H. Time: 5366L
Test case 9. I. Time: 5236L
Test case 10. J. Time: 5022L
Test case 11. K. Time: 1999L
*)

    
    // https://www.hackerrank.com/challenges/rotate-string/forum
    module RotateStrings =
        type Challenge () =
            inherit Model.Challenge<string, string> ()
            
            override _.Solutions = [
                "A",
                fun (input: string) ->
                    let resultList =
                        List.fold (fun acc x ->
                            let rotate (text: string) (letter: string) = text.Substring (1, input.Length - 1) + letter
                            [ rotate (if acc.IsEmpty then input else acc.Head) (string x) ] @ acc
                        ) [] (Seq.toList input)
                        
                    List.foldBack (fun acc x -> x + acc + " ") resultList ""
                    |> fun x -> x.TrimEnd ()
                    
                "B",
                fun input ->
                    input
                    |> Seq.toList
                    |> List.fold (fun (acc: string list) letter ->
                        let last =
                            if acc.IsEmpty
                            then input
                            else acc.Head
                            
                        let item = last.[1 .. input.Length - 1] + string letter
                            
                        item :: acc
                    ) []
                    |> List.rev
                    |> String.concat " "
                    
                "C",
                fun input ->
                    input
                    |> Seq.toList
                    |> List.fold (fun (acc: string list) letter -> acc.Head.[ 1 .. input.Length - 1 ] + string letter :: acc) [ input ]
                    |> List.rev
                    |> List.skip 1
                    |> String.concat " "
                    
                "CA",
                fun input ->
                    input
                    |> Seq.fold (fun (acc: string list) letter -> acc.Head.[ 1 .. input.Length - 1 ] + string letter :: acc) [ input ]
                    |> Seq.rev
                    |> Seq.skip 1
                    |> String.concat " "
                    
                "CB",
                fun input ->
                    input
                    |> Seq.toArray
                    |> Array.fold (fun (acc: string[]) letter -> acc |> Array.append [| acc.[0].[ 1 .. input.Length - 1 ] + string letter |]) [| input |]
                    |> Array.rev
                    |> Array.skip 1
                    |> String.concat " "
                    
                "D",
                fun input ->
                    input
                    |> Seq.toList
                    |> fun list ->
                        let rec loop (acc: char list list) = function
                            | _ when acc.Length = list.Length -> acc
                            | head :: tail ->
                                let item = tail @ [ head ]
                                loop (item :: acc) item
                            | [] -> []
                        loop [] list
                    |> List.rev
                    |> List.map (List.toArray >> String)
                    |> String.concat " "
                    
                "E",
                fun input ->
                    input
                    |> Seq.toList
                    |> fun list ->
                        let rec loop (last: string) = function
                            | head :: tail ->
                                let item = last.[1 .. input.Length - 1] + string head
                                item :: loop item tail
                            | [] -> []
                        loop input list
                    |> String.concat " "
                    
                "F",
                fun input ->
                    Array.singleton 0
                    |> Array.append [| 1 .. input.Length - 1 |]
                    |> Array.map (fun i -> input.[ i .. ] + input.[ .. i - 1 ])
                    |> String.concat " "
                    
                "FA",
                fun input ->
                    List.singleton 0
                    |> List.append [ 1 .. input.Length - 1 ]
                    |> List.map (fun i -> input.[ i .. ] + input.[ .. i - 1 ])
                    |> String.concat " "
                    
                "FB",
                fun input ->
                    Seq.singleton 0
                    |> Seq.append (seq { 1 .. input.Length - 1 })
                    |> Seq.map (fun i -> input.[ i .. ] + input.[ .. i - 1 ])
                    |> String.concat " "
                    
                "FC",
                fun input ->
                    Array.singleton 0
                    |> Array.append [| 1 .. input.Length - 1 |]
                    |> Array.Parallel.map (fun i -> input.[ i .. ] + input.[ .. i - 1 ])
                    |> String.concat " "
            ]
            
            override _.TestCases = seq {
                "abc", "bca cab abc"
                "abcde", "bcdea cdeab deabc eabcd abcde"
                "abcdefghi", "bcdefghia cdefghiab defghiabc efghiabcd fghiabcde ghiabcdef hiabcdefg iabcdefgh abcdefghi"
                "abab", "baba abab baba abab"
                "aa", "aa aa"
                "z", "z"
            }
(*
Solution: abc
Test case 1. A. Time: 1769L
Test case 2. B. Time: 1528L
Test case 3. C. Time: 1541L
Test case 4. CA. Time: 1867L
Test case 5. CB. Time: 1727L
Test case 6. D. Time: 1701L
Test case 7. E. Time: 1440L
Test case 8. F. Time: 1361L
Test case 9. FA. Time: 1426L
Test case 10. FB. Time: 2179L
Test case 11. FC. Time: 3519L

Solution: abcde
Test case 1. A. Time: 2133L
Test case 2. B. Time: 2091L
Test case 3. C. Time: 2050L
Test case 4. CA. Time: 2357L
Test case 5. CB. Time: 2296L
Test case 6. D. Time: 2563L
Test case 7. E. Time: 2004L
Test case 8. F. Time: 1812L
Test case 9. FA. Time: 1961L
Test case 10. FB. Time: 2602L
Test case 11. FC. Time: 4054L

Solution: abcdefghi
Test case 1. A. Time: 3847L
Test case 2. B. Time: 3188L
Test case 3. C. Time: 3321L
Test case 4. CA. Time: 3608L
Test case 5. CB. Time: 3681L
Test case 6. D. Time: 5328L
Test case 7. E. Time: 3055L
Test case 8. F. Time: 2593L
Test case 9. FA. Time: 3545L
Test case 10. FB. Time: 4038L
Test case 11. FC. Time: 5239L

Solution: abab
Test case 1. A. Time: 2036L
Test case 2. B. Time: 1863L
Test case 3. C. Time: 1816L
Test case 4. CA. Time: 2102L
Test case 5. CB. Time: 2019L
Test case 6. D. Time: 2163L
Test case 7. E. Time: 1742L
Test case 8. F. Time: 1591L
Test case 9. FA. Time: 1746L
Test case 10. FB. Time: 2404L
Test case 11. FC. Time: 3805L

Solution: aa
Test case 1. A. Time: 1272L
Test case 2. B. Time: 1338L
Test case 3. C. Time: 1314L
Test case 4. CA. Time: 1579L
Test case 5. CB. Time: 1513L
Test case 6. D. Time: 1313L
Test case 7. E. Time: 1278L
Test case 8. F. Time: 1179L
Test case 9. FA. Time: 1201L
Test case 10. FB. Time: 1937L
Test case 11. FC. Time: 2949L

Solution: z
Test case 1. A. Time: 961L
Test case 2. B. Time: 912L
Test case 3. C. Time: 982L
Test case 4. CA. Time: 1257L
Test case 5. CB. Time: 1171L
Test case 6. D. Time: 986L
Test case 7. E. Time: 938L
Test case 8. F. Time: 275L
Test case 9. FA. Time: 243L
Test case 10. FB. Time: 818L
Test case 11. FC. Time: 1925L
*)

        
    module ReturnLettersWithOddCount =
        type Challenge () =
            inherit Model.Challenge<int, string> ()
            
            override _.Solutions = [
                "A",
                fun n ->
                    let mutable _builder = StringBuilder (new string('a', n))
                    if n % 2 = 0 then
                        _builder.[0] <- 'b'
                        
                    _builder.ToString ()
            ]
            
            override _.TestCases = seq {
                1, "a"
                2, "ba"
                3, "aaa"
                9, "aaaaaaaaa"
                10, "baaaaaaaaa"
            }

    
    module HasAnyPairCloseToEachother =
        type Challenge () =
            inherit Model.Challenge<int[], bool> ()
            
            override _.Solutions = [
                "A",
                fun (a: int[]) ->
                    let indices = Enumerable.Range(0, a.Length).ToArray ()
                    System.Array.Sort (a, indices)
                    
                    indices
                    |> Array.take (a.Length - 1)
                    |> Array.exists (fun i -> a.[i + 1] - a.[i] = 1)
            ]
            
            override _.TestCases = seq {
                [| 0 |], false
                [| 1; 2 |], true
                [| 3; 5 |], false
                [| 3; 4; 6 |], true
                [| 2; 4; 6 |], false
            }
            
module ChallengeList =
            
    let challenges : Model.IChallenge list = [
//        Challenges.Empty3.Challenge ()
//        Challenges.Empty2.Challenge ()
//        Challenges.Empty.Challenge ()
//        Challenges.UniqueLetters.Challenge () :> Model.IChallenge
        Challenges.RotateStrings.Challenge () :> Model.IChallenge
//        Challenges.ReturnLettersWithOddCount.Challenge ()
//        Challenges.HasAnyPairCloseToEachother.Challenge ()
    ]

