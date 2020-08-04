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

    module Challenge =
        let run (solutions: (string * ('TInput -> 'TExpected)) list) (input, expected) =
            let inputStr =
                match box input with
                | :? ICollection as input ->
                    input.Cast<obj> ()
                    |> Seq.map string
                    |> String.concat ","
                | _ -> input.ToString ()

            printfn ""
            printfn "Solution: %s" inputStr

            let performanceInvoke (fn: unit -> 'T) =
                GC.Collect ()
                let stopwatch = Stopwatch ()
                stopwatch.Start ()
                let time1 = stopwatch.ElapsedMilliseconds

                let result =
                    [| 0 .. 2000000 |]
                    |> Array.Parallel.map (fun _ ->
                        fn ()
                    )
                    |> Array.last

                let time2 = stopwatch.ElapsedMilliseconds - time1

                result, time2

            let resultsWithTime =
                solutions
                |> List.mapi (fun i (testName, solution) ->
                    let result, time = performanceInvoke (fun () -> solution input)
                    printfn "Test case %d. %s. Time: %A" (i + 1) testName time
                    result, time
                )


            match resultsWithTime |> List.map fst with
            | ([] | [ _ ]) -> ()
            | (head :: tail) when tail |> List.forall ((=) head) -> ()
            | results -> failwithf "Challenge error: %A" results

            { Input = inputStr
              Expected = expected.ToString ()
              Result = resultsWithTime |> Seq.map fst |> Seq.head |> fun x -> x.ToString ()
              TimeList = resultsWithTime |> List.map snd }

        let runAll testName (solutions: (string * ('TInput -> 'TExpected)) list) testCases =
            printfn ""
            printfn ""
            printfn "Test: %s" testName
            testCases
            |> Seq.map (run solutions)


module Challenges =
    module rec Empty3 =
        let solutions = [
            "A",
            fun (a, _b) ->
                a
        ]
        let testCases = seq {
            ("a", "a"), "a"
            ("a", "a"), "a"
        }
        let runAll () = Model.Challenge.runAll (nameof Empty3) solutions testCases
(*
Test: Empty3

Solution: (a, a)
Test case 1. A. Time: 91L

Solution: (a, a)
Test case 1. A. Time: 56L

Input   Expected        Result  Best
---     ---             ---     ---
(a, a)  a               a       (1, 91)
(a, a)  a               a       (1, 56)

Averages
Test case 1. Average Time: 73L

Ranking
Test case 1. Average Time: 73L
*)


    module rec Empty2 =
        let solutions = [
            "A",
            fun (a, _b) ->
                a
        ]
        let testCases = seq {
            ("a", "a"), "a"
            ("a", "a"), "a"
        }
        let runAll () = Model.Challenge.runAll (nameof Empty2) solutions testCases
(*
Test: Empty2

Solution: (a, a)
Test case 1. A. Time: 59L

Solution: (a, a)
Test case 1. A. Time: 53L

Input   Expected        Result  Best
---     ---             ---     ---
(a, a)  a               a       (1, 59)
(a, a)  a               a       (1, 53)

Averages
Test case 1. Average Time: 56L

Ranking
Test case 1. Average Time: 56L
*)


    module rec Empty =
        let solutions = [
            "A",
            fun n ->
                n
        ]
        let testCases = seq {
            0, 0
            2, 2
            5, 5
        }
        let runAll () = Model.Challenge.runAll (nameof Empty) solutions testCases
(*
Test: Empty

Solution: 0
Test case 1. A. Time: 61L

Solution: 2
Test case 1. A. Time: 62L

Solution: 5
Test case 1. A. Time: 70L

Input   Expected        Result  Best
---     ---             ---     ---
0       0               0       (1, 61)
2       2               2       (1, 62)
5       5               5       (1, 70)

Averages
Test case 1. Average Time: 64L

Ranking
Test case 1. Average Time: 64L
*)


    module rec UniqueLetters =
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
        let testCases = seq {
            "abc", "abc"
            "accabb", "acb"
            "pprrqqpp", "prq"
            "aaaaaaaaaaaaaaccccccabbbbbbbaaacccbbbaaccccccccccacbbbbbbbbbbbbbcccccccbbbbbbbb", "acb"
        }
        let runAll () = Model.Challenge.runAll (nameof UniqueLetters) solutions testCases
(*
Test: UniqueLetters

Solution: abc
Test case 1. A. Time: 1512L
Test case 2. B. Time: 1947L
Test case 3. C. Time: 2023L
Test case 4. D. Time: 1358L
Test case 5. E. Time: 1321L
Test case 6. F. Time: 1346L
Test case 7. G. Time: 1304L
Test case 8. H. Time: 1383L
Test case 9. I. Time: 1495L
Test case 10. J. Time: 1245L
Test case 11. K. Time: 1219L

Solution: accabb
Test case 1. A. Time: 1648L
Test case 2. B. Time: 2061L
Test case 3. C. Time: 2413L
Test case 4. D. Time: 1561L
Test case 5. E. Time: 1593L
Test case 6. F. Time: 1518L
Test case 7. G. Time: 1415L
Test case 8. H. Time: 1510L
Test case 9. I. Time: 1445L
Test case 10. J. Time: 1636L
Test case 11. K. Time: 1317L

Solution: pprrqqpp
Test case 1. A. Time: 2255L
Test case 2. B. Time: 2408L
Test case 3. C. Time: 2393L
Test case 4. D. Time: 1675L
Test case 5. E. Time: 1911L
Test case 6. F. Time: 2126L
Test case 7. G. Time: 1504L
Test case 8. H. Time: 1715L
Test case 9. I. Time: 1537L
Test case 10. J. Time: 1522L
Test case 11. K. Time: 1322L

Solution: aaaaaaaaaaaaaaccccccabbbbbbbaaacccbbbaaccccccccccacbbbbbbbbbbbbbcccccccbbbbbbbb
Test case 1. A. Time: 13073L
Test case 2. B. Time: 11519L
Test case 3. C. Time: 8373L
Test case 4. D. Time: 5860L
Test case 5. E. Time: 6490L
Test case 6. F. Time: 6325L
Test case 7. G. Time: 5799L
Test case 8. H. Time: 7099L
Test case 9. I. Time: 6133L
Test case 10. J. Time: 5993L
Test case 11. K. Time: 2040L

Input                                                                           Expected        Result  Best
---                                                                             ---             ---     ---
abc                                                                             abc             abc     (11, 1219)
accabb                                                                          acb             acb     (11, 1317)
pprrqqpp                                                                        prq             prq     (11, 1322)
aaaaaaaaaaaaaaccccccabbbbbbbaaacccbbbaaccccccccccacbbbbbbbbbbbbbcccccccbbbbbbbb acb             acb     (11, 2040)

Averages
Test case 1. Average Time: 4622L
Test case 2. Average Time: 4483L
Test case 3. Average Time: 3800L
Test case 4. Average Time: 2613L
Test case 5. Average Time: 2828L
Test case 6. Average Time: 2828L
Test case 7. Average Time: 2505L
Test case 8. Average Time: 2926L
Test case 9. Average Time: 2652L
Test case 10. Average Time: 2599L
Test case 11. Average Time: 1474L

Ranking
Test case 1. Average Time: 4622L
Test case 2. Average Time: 4483L
Test case 3. Average Time: 3800L
Test case 8. Average Time: 2926L
Test case 5. Average Time: 2828L
Test case 6. Average Time: 2828L
Test case 9. Average Time: 2652L
Test case 4. Average Time: 2613L
Test case 10. Average Time: 2599L
Test case 7. Average Time: 2505L
Test case 11. Average Time: 1474L
*)


    // https://www.hackerrank.com/challenges/rotate-string/forum
    module rec RotateStrings =
        let solutions = [
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
        let testCases = seq {
            "abc", "bca cab abc"
            "abcde", "bcdea cdeab deabc eabcd abcde"
            "abcdefghi", "bcdefghia cdefghiab defghiabc efghiabcd fghiabcde ghiabcdef hiabcdefg iabcdefgh abcdefghi"
            "abab", "baba abab baba abab"
            "aa", "aa aa"
            "z", "z"
        }
        let runAll () = Model.Challenge.runAll (nameof RotateStrings) solutions testCases
(*
Test: RotateStrings

Solution: abc
Test case 1. A. Time: 1842L
Test case 2. B. Time: 1846L
Test case 3. C. Time: 1936L
Test case 4. CA. Time: 2224L
Test case 5. CB. Time: 2329L
Test case 6. D. Time: 2474L
Test case 7. E. Time: 1664L
Test case 8. F. Time: 1517L
Test case 9. FA. Time: 1651L
Test case 10. FB. Time: 3764L
Test case 11. FC. Time: 5415L

Solution: abcde
Test case 1. A. Time: 3356L
Test case 2. B. Time: 2592L
Test case 3. C. Time: 2346L
Test case 4. CA. Time: 2997L
Test case 5. CB. Time: 3061L
Test case 6. D. Time: 4051L
Test case 7. E. Time: 1905L
Test case 8. F. Time: 1771L
Test case 9. FA. Time: 2175L
Test case 10. FB. Time: 3275L
Test case 11. FC. Time: 5266L

Solution: abcdefghi
Test case 1. A. Time: 4492L
Test case 2. B. Time: 3526L
Test case 3. C. Time: 3583L
Test case 4. CA. Time: 3711L
Test case 5. CB. Time: 4783L
Test case 6. D. Time: 7557L
Test case 7. E. Time: 3452L
Test case 8. F. Time: 3050L
Test case 9. FA. Time: 3275L
Test case 10. FB. Time: 4635L
Test case 11. FC. Time: 5616L

Solution: abab
Test case 1. A. Time: 2093L
Test case 2. B. Time: 1843L
Test case 3. C. Time: 1746L
Test case 4. CA. Time: 2085L
Test case 5. CB. Time: 2139L
Test case 6. D. Time: 2095L
Test case 7. E. Time: 1723L
Test case 8. F. Time: 1558L
Test case 9. FA. Time: 1620L
Test case 10. FB. Time: 2319L
Test case 11. FC. Time: 3918L

Solution: aa
Test case 1. A. Time: 1107L
Test case 2. B. Time: 1241L
Test case 3. C. Time: 1183L
Test case 4. CA. Time: 1563L
Test case 5. CB. Time: 1525L
Test case 6. D. Time: 1591L
Test case 7. E. Time: 1327L
Test case 8. F. Time: 1151L
Test case 9. FA. Time: 1180L
Test case 10. FB. Time: 1733L
Test case 11. FC. Time: 2817L

Solution: z
Test case 1. A. Time: 816L
Test case 2. B. Time: 745L
Test case 3. C. Time: 928L
Test case 4. CA. Time: 1375L
Test case 5. CB. Time: 1029L
Test case 6. D. Time: 852L
Test case 7. E. Time: 712L
Test case 8. F. Time: 263L
Test case 9. FA. Time: 232L
Test case 10. FB. Time: 773L
Test case 11. FC. Time: 1789L

Input           Expected                                                                                        Result                                                                                          Best
---             ---                                                                                             ---                                                                                             ---
abc             bca cab abc                                                                                     bca cab abc                                                                                     (8, 1517)
abcde           bcdea cdeab deabc eabcd abcde                                                                   bcdea cdeab deabc eabcd abcde                                                                   (8, 1771)
abcdefghi       bcdefghia cdefghiab defghiabc efghiabcd fghiabcde ghiabcdef hiabcdefg iabcdefgh abcdefghi       bcdefghia cdefghiab defghiabc efghiabcd fghiabcde ghiabcdef hiabcdefg iabcdefgh abcdefghi       (8, 3050)
abab            baba abab baba abab                                                                             baba abab baba abab                                                                             (8, 1558)
aa              aa aa                                                                                           aa aa                                                                                           (1, 1107)
z               z                                                                                               z                                                                                               (9, 232)

Averages
Test case 1. Average Time: 2284L
Test case 2. Average Time: 1965L
Test case 3. Average Time: 1953L
Test case 4. Average Time: 2325L
Test case 5. Average Time: 2477L
Test case 6. Average Time: 3103L
Test case 7. Average Time: 1797L
Test case 8. Average Time: 1551L
Test case 9. Average Time: 1688L
Test case 10. Average Time: 2749L
Test case 11. Average Time: 4136L

Ranking
Test case 11. Average Time: 4136L
Test case 6. Average Time: 3103L
Test case 10. Average Time: 2749L
Test case 5. Average Time: 2477L
Test case 4. Average Time: 2325L
Test case 1. Average Time: 2284L
Test case 2. Average Time: 1965L
Test case 3. Average Time: 1953L
Test case 7. Average Time: 1797L
Test case 9. Average Time: 1688L
Test case 8. Average Time: 1551L
*)


    module rec ReturnLettersWithOddCount =
        let solutions = [
            "A",
            fun n ->
                let mutable _builder = StringBuilder (new string('a', n))
                if n % 2 = 0 then
                    _builder.[0] <- 'b'

                _builder.ToString ()
        ]
        let testCases = seq {
            1, "a"
            2, "ba"
            3, "aaa"
            9, "aaaaaaaaa"
            10, "baaaaaaaaa"
        }
        let runAll () = Model.Challenge.runAll (nameof ReturnLettersWithOddCount) solutions testCases
(*
Test: ReturnLettersWithOddCount

Solution: 1
Test case 1. A. Time: 645L

Solution: 2
Test case 1. A. Time: 663L

Solution: 3
Test case 1. A. Time: 680L

Solution: 9
Test case 1. A. Time: 730L

Solution: 10
Test case 1. A. Time: 815L

Input   Expected        Result          Best
---     ---             ---             ---
1       a               a               (1, 645)
2       ba              ba              (1, 663)
3       aaa             aaa             (1, 680)
9       aaaaaaaaa       aaaaaaaaa       (1, 730)
10      baaaaaaaaa      baaaaaaaaa      (1, 815)

Averages
Test case 1. Average Time: 706L

Ranking
Test case 1. Average Time: 706L
*)


    module rec HasAnyPairCloseToEachother =
        let solutions = [
            "A",
            fun (a: int[]) ->
                let indices = Enumerable.Range(0, a.Length).ToArray ()
                Array.Sort (a, indices)

                indices
                |> Array.take (a.Length - 1)
                |> Array.exists (fun i -> a.[i + 1] - a.[i] = 1)
        ]
        let testCases = seq {
            [| 0 |], false
            [| 1; 2 |], true
            [| 3; 5 |], false
            [| 3; 4; 6 |], true
            [| 2; 4; 6 |], false
        }
        let runAll () = Model.Challenge.runAll (nameof HasAnyPairCloseToEachother) solutions testCases
(*
Test: HasAnyPairCloseToEachother

Solution: 0
Test case 1. A. Time: 137L

Solution: 1,2
Test case 1. A. Time: 186L

Solution: 3,5
Test case 1. A. Time: 206L

Solution: 3,4,6
Test case 1. A. Time: 149L

Solution: 2,4,6
Test case 1. A. Time: 150L

Input   Expected        Result  Best
---     ---             ---     ---
0       False           False   (1, 137)
1,2     True            True    (1, 186)
3,5     False           False   (1, 206)
3,4,6   True            True    (1, 149)
2,4,6   False           False   (1, 150)

Averages
Test case 1. Average Time: 165L

Ranking
Test case 1. Average Time: 165L
*)


module ChallengeList =
    let challenges = [
//        Challenges.Empty3.runAll
//        Challenges.Empty2.runAll
        Challenges.Empty.runAll
//        Challenges.UniqueLetters.runAll
//        Challenges.RotateStrings.runAll
//        Challenges.ReturnLettersWithOddCount.runAll
//        Challenges.HasAnyPairCloseToEachother.runAll
    ]

